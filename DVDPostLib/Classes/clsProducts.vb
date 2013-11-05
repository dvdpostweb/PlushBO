
Imports System.Net.Mail
Public Class clsProduct_BarCode
    Private _BarcodeWithCheckDigit As String
    Private _IsBarCodeValid As Boolean

    Private Const LN_CODEBAR As Integer = 13

    Public Const LN_CODEBAR_VALID As Integer = 12

    Private Const CHECKSUMMOD As Integer = 127
    Private Const HEADERSTANDARD As String = "211"

    Private Const POS_HEADER As Integer = 0
    Private Const LN_HEADER As Integer = 3

    Private Const POS_PRODUCTS_ID As Integer = 3
    Private Const LN_PRODUCTS_ID As Integer = 6

    Private Const POS_DVD_ID As Integer = 9
    Private Const LN_DVD_ID As Integer = 3

    Private Const POS_CHECKSUM As Integer = 12
    Private Const LN_CHECKSUM As Integer = 1

    'something changet to upload

    ReadOnly Property ProductID() As Integer
        Get
            If IsBarCodeValid Then
                Return GetProductID()
            Else
                Return -1
            End If
        End Get
    End Property
    ReadOnly Property DVDID() As Integer
        Get
            If IsBarCodeValid Then
                Return GetDVDID()
            Else
                Return -1
            End If
        End Get
    End Property
    ReadOnly Property Barcode() As String
        Get
            Return _BarcodeWithCheckDigit
        End Get
    End Property
    ReadOnly Property IsBarCodeValid() As Boolean
        Get
            Return _IsBarCodeValid
        End Get
    End Property
    Private Function GetProductID() As Integer
        Return GetID(POS_PRODUCTS_ID, LN_PRODUCTS_ID)
    End Function
    Private Function GetID(ByVal pos As Integer, ByVal ln As Integer) As Integer
        Dim id As Integer = 0
        Dim result As String
        If (barCode.Length >= pos + ln) Then
            result = barCode.Substring(pos, ln)

            If Not Integer.TryParse(result, id) Then
                id = -1
            End If
        End If
        Return id
    End Function
    Private Function GetCHECKSUM() As Integer
        Return GetID(POS_CHECKSUM, LN_CHECKSUM)
    End Function
    Private Function GetHEADER() As String
        Dim result As Integer
        result = GetID(POS_HEADER, LN_HEADER)
        Return result.ToString("000")
    End Function
    Private Function GetDVDID() As Integer
        Return GetID(POS_DVD_ID, LN_DVD_ID)
    End Function

    Public Sub New(ByVal vBarCodeWithCheckDigit As String)
        If vBarCodeWithCheckDigit.Length > LN_CODEBAR Or vBarCodeWithCheckDigit.Length < LN_CODEBAR - 1 Then
            _IsBarCodeValid = False
            Exit Sub
        End If

        If vBarCodeWithCheckDigit.Length = LN_CODEBAR_VALID Then
            vBarCodeWithCheckDigit = "0" + vBarCodeWithCheckDigit
        End If

        _BarcodeWithCheckDigit = vBarCodeWithCheckDigit
        _IsBarCodeValid = ValidateBarCode()

    End Sub
    Public Sub New(ByVal vProduct_ID As Integer, ByVal vDVD_ID As Integer)
        CreateBarCodeInfo(vProduct_ID, vDVD_ID)
    End Sub
    Private Function ValidateBarCode() As Boolean
        If Not IsNumeric(Barcode) Then
            Return False
        End If
        If _BarcodeWithCheckDigit.Length <> LN_CODEBAR Then
            Return False
        Else
            Dim checksum As Boolean = True
            Dim header As String = GetHEADER()

            If header <> HEADERSTANDARD Then
                checksum = CreateCheckSumProduct(Barcode) = header
            End If

            Dim result As String
            result = computeCheckDigit(Barcode)
            Return (GetCHECKSUM() = result) And checksum
        End If
    End Function
    Private Function CreateCheckSumProduct(ByVal barcode As String) As String
        Return CreateCheckSumProduct(GetProductID(), GetDVDID())
    End Function
    Private Function CreateCheckSumProduct(ByVal products_id As Integer, ByVal dvd_id As Integer) As String
        Dim result As Long
        result = products_id * dvd_id
        result = result Mod CHECKSUMMOD

        Return result.ToString("000")
    End Function
    Private Sub CreateBarCodeInfo(ByVal products_id As Integer, ByVal dvd_id As Integer)
        Dim checkSumDigit As String
        Dim codebar As String
        Dim checkSum As String

        checkSumDigit = CreateCheckSumProduct(products_id, dvd_id)
        codebar = checkSumDigit & products_id.ToString("000000") & dvd_id.ToString("000")
        checkSum = computeCheckDigit(codebar).ToString()
        _BarcodeWithCheckDigit = codebar & checkSum
        _IsBarCodeValid = True
    End Sub
    Private Function computeCheckDigit(ByVal codebar As String) As Integer
        If codebar.Length < LN_CODEBAR_VALID Then
            Return String.Empty
        End If
        Dim result As Integer
        Dim Impair As Integer = 0
        Dim Pair As Integer = 0

        For index As Integer = 1 To LN_CODEBAR_VALID Step 2
            result = CInt(codebar.Substring(index - 1, 1))
            Impair += result
        Next

        For index As Integer = 2 To LN_CODEBAR_VALID Step 2
            result = CInt(codebar.Substring(index - 1, 1))
            Pair += result
        Next

        Dim z As Integer = (3 * Pair) + Impair
        Dim intmod As Integer = z Mod 10
        Dim check As Integer = 10 - intmod
        If check = 10 Then
            check = 0
        End If
        Return check
    End Function
End Class
Public Class clsProduct_DVD
    Inherits BizzLib.clsOneTableData
    Private _productsId As Integer = -1
    'Private _dvdId As Integer
    Private _productsType As String
    Private _ObjBarCode As clsProduct_BarCode
    'Private _INOUT As DvdPostData.clsProductDvd.INOUT
    Private _product_dvd_status As PlushData.clsProductDvd.DVDStatus

    'Private _box_id As Integer
    'Private _posBox_id As Integer

    Public alert_cre_date As DateTime = Nothing
    Public alert_comment As String = ""
    'Public OrdersDataTable As DataTable = Nothing
    Public Products_dvd_row As DataRow
    Public Product_row As DataRow


    Public Sub New(ByVal vSessionInfo As BizzLib.clsSessionInfo, ByVal vDataset1 As dsProducts)
        MyBase.New(vSessionInfo)
        initObject(vDataset1)

    End Sub


    Public Sub New(ByVal vSessionInfo As BizzLib.clsSessionInfo, ByVal vDataset1 As dsProducts, ByVal vBarCodeWithCheckDigit As String)
        MyBase.New(vSessionInfo)

        '_ObjBarCode = New clsProduct_BarCode(vBarCodeWithCheckDigit)
        initObject(vDataset1)

    End Sub
    Public Sub New(ByVal vSessionInfo As BizzLib.clsSessionInfo, ByVal vDataset1 As dsProducts, ByVal productsId As Integer, ByVal dvdId As Integer)
        MyBase.New(vSessionInfo)
        _productsId = productsId
        '_ObjBarCode = New clsProduct_BarCode(productsId, dvdId)
        initObject(vDataset1)

    End Sub
    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As DataRowView) As Integer
        Return -1
    End Function
    Public Overrides Function ValidateRecordFields(ByRef Row1 As DataRowView) As Integer
        Dim _MsgID As Integer = -1
        'Check ID
        If Row1("products_id") & "" = "" Then
        End If
        Return _MsgID
    End Function
    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer

    End Function
    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("Select Count(*) FROM products_dvd WHERE " & IDFieldName & " = " & ID)
    End Function

    Public Property products_dvd_status() As PlushData.clsProductDvd.DVDStatus
        Get
            Return _product_dvd_status
        End Get
        Set(ByVal value As PlushData.clsProductDvd.DVDStatus)
            _product_dvd_status = value
        End Set
    End Property

    'Public ReadOnly Property INOUT() As DvdPostData.clsProductDvd.INOUT
    '    Get
    '        Return _INOUT
    '    End Get
    'End Property

    Public ReadOnly Property isAdult() As Boolean
        Get
            If _productsType = "DVD_ADULT" Then
                Return True
            ElseIf _productsType = "DVD_NORM" Then
                Return False
            Else
                Return False
            End If
        End Get
    End Property
    Public ReadOnly Property productsType() As String
        Get
            Return _productsType
        End Get
    End Property
    Public ReadOnly Property ProductsID() As Integer
        Get
            Return _productsId
        End Get
    End Property
    'Public ReadOnly Property PosBoxID() As Integer
    '    Get
    '        Return _posBox_id
    '    End Get
    'End Property
    'Public ReadOnly Property BoxID() As Integer
    '    Get
    '        Return _box_id
    '    End Get
    'End Property
    'Public ReadOnly Property DvdId() As Integer
    '    Get
    '        Return _dvdId
    '    End Get
    'End Property
    Public ReadOnly Property BarCode() As clsProduct_BarCode
        Get
            Return _ObjBarCode
        End Get
    End Property
    Public Sub initObject(ByVal vDataSet1 As DataSet)

        'If _ObjBarCode.IsBarCodeValid Then
        '_productsId = _ObjBarCode.ProductID  'CInt(Mid(_ObjBarCode.BarcodeWithCheckDigit, 4, 6))
        '_dvdId = _ObjBarCode.DVDID  'CInt(Mid(_BarcodeWithCheckDigit, 10, 3))
        MyBase.Initialize(vDataSet1, "", "products", "products_id", "SELECT * FROM products where products_id = " & _productsId, "", "")
        'DataSet1 = vDataSet1
        If MyBase.TableOfData.Rows.Count = 1 Then
            Product_row = MyBase.TableOfData.Rows(0)
            _productsType = MyBase.TableOfData.Rows(0)("products_type")
            'If _dvdId <> -1 Then
            '    Load_One_Products_DVD_Info()
            'End If
        Else
            _productsId = -1
            '_dvdId = -1
            _productsType = ""
        End If
        ''Else
        '_productsId = -1
        ''_dvdId = -1
        '_productsType = ""
        'End If
    End Sub

    'Public Function GetPosBox(Optional ByVal posbox_id As Integer = 0, Optional ByVal change_status As DvdPostData.clsProductDvd.DVDStatus = -1) As Integer

    '    Dim new_status As DvdPostData.clsProductDvd.DVDStatus
    '    new_status = GetNewStatus(change_status)

    '    Select Case new_status
    '        Case DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
    '            DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BADLABEL, _
    '            DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN, _
    '            DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED, _
    '            DvdPostData.clsProductDvd.DVDStatus.DVD_SOLD, _
    '            DvdPostData.clsProductDvd.DVDStatus.PREP_FOR_SOLD, _
    '            DvdPostData.clsProductDvd.DVDStatus.INVENTAIRE, _
    '            DvdPostData.clsProductDvd.DVDStatus.VOD
    '            Return 1
    '        Case Else
    '            If posbox_id = 0 Then
    '                Return PosBoxID
    '            Else
    '                Return posbox_id
    '            End If

    '    End Select

    'End Function
    Private Function GetNewStatus(ByVal change_status As PlushData.clsProductDvd.DVDStatus) As PlushData.clsProductDvd.DVDStatus

        If change_status = -1 Then
            Return products_dvd_status
        Else
            Return change_status
        End If


    End Function
    'Public Function GetBox(Optional ByVal box_id As Integer = 0, Optional ByVal change_status As DvdPostData.clsProductDvd.DVDStatus = -1) As Integer
    '    Dim new_status As DvdPostData.clsProductDvd.DVDStatus

    '    new_status = GetNewStatus(change_status)
    '    Select Case new_status
    '        Case DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU
    '            Return DvdPostData.clsProductDvd.BOXTYPE.BIZARREMENT_PERDU

    '        Case DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BADLABEL
    '            Return DvdPostData.clsProductDvd.BOXTYPE.BADLABEL

    '        Case DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN, _
    '            DvdPostData.clsProductDvd.DVDStatus.IRREPARABLE
    '            Return DvdPostData.clsProductDvd.BOXTYPE.BROKEN

    '        Case DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED, _
    '             DvdPostData.clsProductDvd.DVDStatus.ENTRETIEN
    '            Return DvdPostData.clsProductDvd.BOXTYPE.DAMAGED

    '        Case DvdPostData.clsProductDvd.DVDStatus.DVD_SOLD
    '            Return DvdPostData.clsProductDvd.BOXTYPE.SOLD

    '        Case DvdPostData.clsProductDvd.DVDStatus.PREP_FOR_SOLD
    '            Return DvdPostData.clsProductDvd.BOXTYPE.PREPFORSOLD

    '        Case DvdPostData.clsProductDvd.DVDStatus.INVENTAIRE
    '            Return DvdPostData.clsProductDvd.BOXTYPE.INVENTAIRE

    '        Case DvdPostData.clsProductDvd.DVDStatus.VOD
    '            Return DvdPostData.clsProductDvd.BOXTYPE.VOD

    '        Case DvdPostData.clsProductDvd.DVDStatus.CUSTOMERS_SERVICE
    '            Return DvdPostData.clsProductDvd.BOXTYPE.CUSTSERV

    '        Case DvdPostData.clsProductDvd.DVDStatus.NON_LOCATIF
    '            Return DvdPostData.clsProductDvd.BOXTYPE.NOLOCATIVE

    '        Case Else
    '            If box_id = 0 Then
    '                Return BoxID
    '            Else
    '                Return box_id
    '            End If

    '    End Select

    'End Function
    Public Sub SaveAll()
        Me.Save()
        SaveActors()
        SaveLanguages()
        SaveUndertitles()
        SaveSoundtracks()
        SaveCategories()
        'SaveThemes()
        'SaveTrailers()
        SaveDescriptionFR()
        SaveDescriptionNL()
        SaveDescriptionEN()
    End Sub
    Public Sub SaveAll(ByVal imdb_id As Integer)
        Me.Save()
        SaveActors()
        SaveLanguages()
        SaveUndertitles()
        SaveSoundtracks()
        SaveCategories(imdb_id)
        'SaveThemes(imdb_id)
        'SaveTrailers()
        SaveDescriptionFR()
        SaveDescriptionNL()
        SaveDescriptionEN()
    End Sub
    Public Sub LoadProductsDetail()
        DataSet1.Tables("products").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products"), "select * from products where products_id = " & ProductsID)
        DataSet1.Tables("products").Columns("products_id").DefaultValue = ProductsID

    End Sub
    Public Sub LoadVod()
        DataSet1.Tables("streaming_products").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("streaming_products"), "select group_concat(distinct pl.short_alpha) audio, group_concat(distinct pu.short_alpha) subtitle" & _
        " from products p join streaming_products sp on p.imdb_id = sp.imdb_id " & _
        " left join products_languages pl on sp.language_id = pl.languages_id and pl.languagenav_id = 1 " & _
        " left join products_undertitles pu on sp.subtitle_id = pu.undertitles_id and pu.language_id = 1 " & _
        " where p.products_id = " & ProductsID)
        'DataSet1.Tables("streaming_products").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub LoadActors()
        DataSet1.Tables("products_to_actors").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_to_actors"), "select * from products_to_actors where products_id = " & ProductsID)
        DataSet1.Tables("products_to_actors").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveActors()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_actors").GetChanges() Is Nothing Then
            refresh = True
        End If
        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_actors"), "select * from products_to_actors ")
        If refresh Then
            LoadActors()
        End If
    End Sub

    Public Sub LoadLanguages()
        DataSet1.Tables("products_to_languages").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_to_languages"), "select * from products_to_languages where products_id = " & ProductsID)
        DataSet1.Tables("products_to_languages").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveLanguages()
        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_languages"), "select * from products_to_languages ")
    End Sub

    Public Sub LoadUndertitles()
        DataSet1.Tables("products_to_undertitles").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_to_undertitles"), "select * from products_to_undertitles where products_id = " & ProductsID)
        DataSet1.Tables("products_to_undertitles").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveUndertitles()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_undertitles").GetChanges() Is Nothing Then
            refresh = True
        End If
        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_undertitles"), "select * from products_to_undertitles ")
        If refresh Then
            LoadUndertitles()
        End If
    End Sub

    Public Sub LoadSoundtracks()
        DataSet1.Tables("products_to_soundtracks").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_to_soundtracks"), "select * from products_to_soundtracks where products_id = " & ProductsID)
        DataSet1.Tables("products_to_soundtracks").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveSoundtracks()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_soundtracks").GetChanges() Is Nothing Then
            refresh = True
        End If
        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_soundtracks"), "select * from products_to_soundtracks ")
        If refresh Then
            LoadSoundtracks()
        End If
    End Sub

    'Public Sub LoadTrailers()
    '    DataSet1.Tables("products_trailers").Clear()
    '    DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_trailers"), "select * from products_trailers where products_id = " & ProductsID)
    '    DataSet1.Tables("products_trailers").Columns("products_id").DefaultValue = ProductsID
    'End Sub
    Public Sub LoadStreamingTrailers()
        DataSet1.Tables("streaming_trailers").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("streaming_trailers"), "select sp.id, sp.filename, pl.short_alpha audio, pu.short_alpha subtitle, sp.status" & _
        " from products p join streaming_trailers sp on p.imdb_id = sp.imdb_id " & _
        " left join products_languages pl on sp.language_id = pl.languages_id and pl.languagenav_id = 1 " & _
        " left join products_undertitles pu on sp.subtitle_id = pu.undertitles_id and pu.language_id = 1 " & _
        " where p.products_id = " & ProductsID)
    End Sub
    'Public Sub SaveTrailers()
    '    Dim refresh As Boolean = False
    '    If Not DataSet1.Tables("products_trailers").GetChanges() Is Nothing Then
    '        refresh = True
    '    End If
    '    DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_trailers"), "select trailers_id, products_id, trailer, language_id, broadcast from products_trailers ")
    '    If refresh Then
    '        LoadTrailers()
    '    End If

    'End Sub

    Public Sub LoadCategories()
        DataSet1.Tables("products_to_categories").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_to_categories"), "select * from products_to_categories where products_id = " & ProductsID)
        DataSet1.Tables("products_to_categories").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveCategories()
        '  dvdpostdata.clsconnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select * from products_to_categories ")
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_categories").GetChanges() Is Nothing Then
            refresh = True
        End If
        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select products_id, categories_id from products_to_categories where products_id = " & ProductsID)
        If refresh Then
            LoadCategories()
        End If
    End Sub

    Public Sub SaveCategories(ByVal imdb_id As Integer)
        '  dvdpostdata.clsconnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select * from products_to_categories ")
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_categories").GetChanges() Is Nothing Then
            refresh = True
        End If


        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select products_id, categories_id from products_to_categories where products_id = " & ProductsID)
        PlushData.clsConnection.ExecuteNonQuery("delete from products_to_categories where products_id <> " & ProductsID & " and products_id in (select products_id from products where imdb_id = " & imdb_id & ")")
        PlushData.clsConnection.ExecuteNonQuery("insert into products_to_categories select p.products_id, c.categories_id, sysdate() from (Select categories_id from products_to_categories where products_id = " & ProductsID & ") c," & _
                                                    "( select products_id from products where imdb_id = " & imdb_id & " and products_id <> " & ProductsID & " ) p ")

        If refresh Then
            LoadCategories()
        End If
    End Sub

    'Public Sub LoadThemes()
    '    DataSet1.Tables("products_to_themes").Clear()
    '    DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_themes"), "select * from products_to_themes where products_id = " & ProductsID)
    '    DataSet1.Tables("products_to_themes").Columns("products_id").DefaultValue = ProductsID
    'End Sub
    'Public Sub SaveThemes()
    '    Dim refresh As Boolean = False
    '    If Not DataSet1.Tables("products_to_themes").GetChanges() Is Nothing Then
    '        refresh = True
    '    End If
    '    DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_themes"), "select * from products_to_themes where products_id = " & ProductsID)
    '    If refresh Then
    '        LoadThemes()
    '    End If
    'End Sub

    'Public Sub SaveThemes(ByVal imdb_id As Integer)
    '    Dim refresh As Boolean = False
    '    If Not DataSet1.Tables("products_to_themes").GetChanges() Is Nothing Then
    '        refresh = True
    '    End If
    '    DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_themes"), "select * from products_to_themes where products_id = " & ProductsID)
    '    DvdPostData.clsConnection.ExecuteNonQuery("delete from products_to_themes where products_id <> " & ProductsID & " and products_id in (select products_id from products where imdb_id = " & imdb_id & ")")
    '    DvdPostData.clsConnection.ExecuteNonQuery("insert into products_to_themes select p.products_id, c.themes_id, sysdate() from (Select themes_id from products_to_themes where products_id = " & ProductsID & ") c," & _
    '                                                "( select products_id from products where imdb_id = " & imdb_id & " and products_id <> " & ProductsID & " ) p ")
    '    If refresh Then
    '        LoadThemes()
    '    End If
    'End Sub

    Public Sub LoadDescriptionFR()
        DataSet1.Tables("products_description_fr").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_description_fr"), "select * from products_description where language_id = 1 and products_id = " & ProductsID)
        DataSet1.Tables("products_description_fr").Columns("products_id").DefaultValue = ProductsID
        DataSet1.Tables("products_description_fr").Columns("language_id").DefaultValue = 1
        If DataSet1.Tables("products_description_fr").Rows.Count < 1 Then
            PlushData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 1)")
            PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_description_fr"), "select * from products_description where language_id = 1 and products_id = " & ProductsID)
        End If
    End Sub
    Public Sub SaveDescriptionFR()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_description_fr").GetChanges() Is Nothing Then
            For i As Integer = 0 To DataSet1.Tables("products_description_fr").Rows.Count - 1
                DataSet1.Tables("products_description_fr").Rows(i)("products_description") = Replace(DataSet1.Tables("products_description_fr").Rows(i)("products_description").ToString(), "’", "'")
            Next
            refresh = True

        End If
        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_description_fr"), "select * from products_description ")
        If refresh Then
            LoadDescriptionFR()
        End If
    End Sub

    Public Sub LoadDescriptionNL()
        DataSet1.Tables("products_description_nl").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_description_nl"), "select * from products_description where language_id = 2 and products_id = " & ProductsID)
        DataSet1.Tables("products_description_nl").Columns("products_id").DefaultValue = ProductsID
        DataSet1.Tables("products_description_nl").Columns("language_id").DefaultValue = 2
        If DataSet1.Tables("products_description_nl").Rows.Count < 1 Then
            PlushData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 2)")
            PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_description_nl"), "select * from products_description where language_id = 2 and products_id = " & ProductsID)
        End If

    End Sub
    Public Sub SaveDescriptionNL()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_description_nl").GetChanges() Is Nothing Then
            For i As Integer = 0 To DataSet1.Tables("products_description_nl").Rows.Count - 1
                DataSet1.Tables("products_description_nl").Rows(i)("products_description") = Replace(DataSet1.Tables("products_description_nl").Rows(i)("products_description").ToString(), "’", "'")
            Next
            refresh = True
        End If
        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_description_nl"), "select * from products_description ")
        If refresh Then
            LoadDescriptionNL()
        End If
    End Sub

    Public Sub LoadDescriptionEN()
        DataSet1.Tables("products_description_en").Clear()
        PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_description_en"), "select * from products_description where language_id = 3 and products_id = " & ProductsID)
        DataSet1.Tables("products_description_en").Columns("products_id").DefaultValue = ProductsID
        DataSet1.Tables("products_description_en").Columns("language_id").DefaultValue = 3
        If DataSet1.Tables("products_description_en").Rows.Count < 1 Then
            PlushData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 3)")
            PlushData.clsConnection.FillDataSet(DataSet1.Tables("products_description_en"), "select * from products_description where language_id = 3 and products_id = " & ProductsID)
        End If
    End Sub
    Public Sub SaveDescriptionEN()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_description_en").GetChanges() Is Nothing Then
            For i As Integer = 0 To DataSet1.Tables("products_description_en").Rows.Count - 1
                DataSet1.Tables("products_description_en").Rows(i)("products_description") = Replace(DataSet1.Tables("products_description_en").Rows(i)("products_description").ToString(), "’", "'")
            Next
            refresh = True
        End If
        PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_description_en"), "select * from products_description ")
        If refresh Then
            LoadDescriptionEN()
        End If
    End Sub
    'Public Function AddNewDVD(ByVal vNbrOfDVDToAdd As Integer) As Integer
    '    Dim intmaxproducts_dvdid As Integer = 0
    '    Dim _SQLTxt As String
    '    _SQLTxt = "SELECT if(max(products_dvdid)  is null, 0, max(products_dvdid))  as cnt FROM products_dvd where products_id = '" & ProductsID & "' "
    '    intmaxproducts_dvdid = BKGlobal.ExecuteFindFieldValueINT("cnt", _SQLTxt)

    '    _SQLTxt = "update products set products_dvd_quantity = products_dvd_quantity + '" & vNbrOfDVDToAdd & _
    '              "' , products_availability = 1 where products_id = '" & ProductsID & "'  "
    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    '    Dim i As Integer
    '    For i = (intmaxproducts_dvdid + 1) To (vNbrOfDVDToAdd + intmaxproducts_dvdid)
    '        _SQLTxt = "insert into products_dvd (products_id , products_dvdid ,`inout`,  products_dvd_status, last_admindate, dvd_buy_date, box_id)values( '" & _
    '                ProductsID & "' , '" & i & "' , 1 , " & DvdPostData.clsProductDvd.DVDStatus.PURCHASE & " , now(), now(), " & DvdPostData.clsProductDvd.BOXTYPE.PURCHASE & " ) "
    '        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

    '        ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.PURCHASE, "add new dvd", DvdPostData.ClsProducts_dvd_state.state.PURCHASE, DvdPostData.clsProductDvd.INOUT.IN)

    '    Next
    '    Return i
    'End Function
    Public Function AddNewProduct() As Integer 'Return the new Product_id
        Dim _row As DataRow = TableOfData.NewRow
        Dim _Date As String
        _Date = PlushTools.ClsDate.formatDateDB(Date.Now)
        _row("products_id") = 0
        _row("products_type") = "DVD_NORM"
        _row("products_media") = "DVD"
        _row("products_status") = -1
        _row("products_availability") = 0
        _row("products_date_added") = _Date
        _row("products_last_modified") = _Date
        _row("products_quantity") = 0
        _row("imdb_id") = 0
        _row("products_price") = 0
        _row("products_title") = ""
        _row("products_tax_class_id") = 0
        _row("products_ordered") = 0
        _row("products_public") = 1 'tout public
        _row("products_picture_format") = 4 ' 16/9 compatible 4/3
        _row("products_countries_id") = 223
        _row("products_barcode") = 0
        _row("products_dvd_quantity") = 0
        _row("products_regional_code") = 2
        _row("products_language_fr") = 0
        _row("products_undertitle_nl") = 0
        _row("in_the_bags") = 0
        _row("in_the_bags_next") = 0
        _row("in_cinema_now") = 0
        _row("products_dvdpostchoice") = 0
        _row("products_french") = 0
        _row("products_next") = 0
        _row("products_tiscali_hp_fr") = 0
        _row("products_tiscali_hp_nl") = 0
        _row("products_series_id") = 0
        _row("products_series_number") = 0
        _row("products_series_aboprocess_id") = 0
        _row("products_series_aboprocess_number") = 0
        _row("feesharing") = 0
        _row("feesharing_end") = DBNull.Value
        _row("feesharing_upfront_fee") = 0
        _row("feesharing_upfront_fee_recoverable") = 0
        _row("feesharing_turn_price") = 0
        _row("feesharing_turn_price_after3month") = 0
        _row("feesharing_upfront_fee") = 0
        _row("feesharing_buy_option_price") = 0
        _row("feesharing_expected_nbr_turns") = 0
        _row("products_desire") = 0
        _row("products_desire_weighted") = 0
        _row("quantity_to_sale") = 0
        _row("products_sale_price") = 0
        _row("products_sale_date") = DBNull.Value
        _row("distributors_id") = 0
        _row("quantity_new_to_sale") = 0
        _row("products_new_sale_price") = 0
        _row("only_for_sale") = 0
        _row("products_other_language") = 0
        _row("products_product_type") = "Movie"
        _row("criteo_status") = 0
        TableOfData.Rows.Add(_row)
        SaveAll()
        'Retreiving the ID just Created
        _productsId = BKGlobal.ExecuteFindFieldValueINT("products_id", "select products_id from products where products_date_added = '" & _Date & "' ORDER by products_id desc limit 1 ")
        PlushData.clsConnection.ExecuteNonQuery("insert into products_to_soundtracks  (products_id, products_soundtracks_id) values (" & _productsId & ", 4)") 'Default SoundTracks = Dolby Digital
        PlushData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 1)")
        PlushData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 2)")
        PlushData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 3)")
        Product_row = _row
        '_dvdId = -1
        _productsType = "DVD_NORM"
        Return _productsId
    End Function
    Public Function IsInCategory(ByVal vProducts_ID As Integer, ByVal vCategories_ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("select count(*) cnt from products_to_categories where products_id = " & vProducts_ID & " AND categories_id = " & vCategories_ID)
    End Function
    Public Function IsInTheme(ByVal vProducts_ID As Integer, ByVal vTheme_ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("select count(*) cnt from products_to_themes where products_id = " & vProducts_ID & " AND themes_id = " & vTheme_ID)
    End Function
    Public Function CopyProduct() As Integer
        'Return the New Product_ID Created
        If ProductsID = -1 Then Exit Function
        Dim _row_from As DataRow
        Dim _row_to As DataRow
        Dim _Date As String = Year(Now) & "-" & Month(Now) & "-" & Day(Now) & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
        Dim _DSFrom As New DataSet
        Dim _DSTo As New DataSet
        _DSFrom.Tables.Add("products")
        Dim _newID As Integer
        PlushData.clsConnection.FillDataSet(_DSFrom.Tables("products"), "SELECT * FROM products WHERE products_id = " & ProductsID)
        _DSTo.Tables.Add(_DSFrom.Tables("products").Clone)
        If _DSFrom.Tables("products").Rows.Count = 1 Then
            _row_from = _DSFrom.Tables("products").Rows(0)
            _row_to = _DSTo.Tables("products").NewRow
            _row_to.ItemArray = _row_from.ItemArray
            _row_to("products_id") = 0
            _row_to("products_status") = -1
            _row_to("products_quantity") = 0
            _row_to("products_dvd_quantity") = 0
            _row_to("products_availability") = -1
            _row_to("products_date_added") = _Date
            _row_to("products_last_modified") = _Date
            _row_to("products_sale_date") = DBNull.Value
            _row_to("products_sale_price") = 0
            _row_to("quantity_to_sale") = 0
            _row_to("products_new_sale_price") = 0
            _row_to("quantity_new_to_sale") = 0
            _row_to("only_for_sale") = 0
            _row_to("feesharing") = 0
            _row_to("feesharing_end") = DBNull.Value
            _row_to("feesharing_upfront_fee") = 0
            _row_to("feesharing_upfront_fee_recoverable") = 0
            _row_to("feesharing_turn_price") = 0
            _row_to("feesharing_turn_price_after3month") = 0
            _row_to("feesharing_upfront_fee") = 0
            _row_to("feesharing_buy_option_price") = 0
            _row_to("feesharing_expected_nbr_turns") = 0
            _DSTo.Tables("products").Rows.Add(_row_to)
            PlushData.clsConnection.UpdateDataTableInDB(_DSTo.Tables("products"), "SELECT * FROM products")
            'Retreiving the ID just Created
            _newID = BKGlobal.ExecuteFindFieldValueINT("products_id", "select products_id from products where products_date_added = '" & _Date & "' ORDER by products_id desc limit 1 ")
            If _newID <> -1 Then
                'Creates Actors , Language, Undertiltes, SoundTracks, Trailers, Categories, Themes, DescFR, DescNL, DescEN
                CopyInfo("products_to_actors", _newID)
                CopyInfo("products_to_languages", _newID)
                CopyInfo("products_to_undertitles", _newID)
                CopyInfo("products_to_soundtracks", _newID)
                CopyInfo("products_trailers", _newID, "trailers_id")
                CopyInfo("products_to_categories", _newID)
                CopyInfo("products_to_themes", _newID)
                CopyInfo("products_description", _newID) 'ALL Languages in one SHot
            End If
            Return _newID

        Else
            MsgBox("Impossible de copier cette fiche DVD", MsgBoxStyle.Exclamation)
            Return -1
        End If

    End Function
    Private Sub CopyInfo(ByVal vTableName As String, ByVal vToProductID As Integer, Optional ByVal IDFieldToNull As String = "")
        If ProductsID = -1 Then Exit Sub
        Dim _DSFrom As New DataSet
        Dim _DSTo As New DataSet
        Dim _row_from As DataRow
        Dim _row_to As DataRow
        _DSFrom.Tables.Add(vTableName)
        PlushData.clsConnection.FillDataSet(_DSFrom.Tables(vTableName), "SELECT * FROM " & vTableName & " WHERE products_id = " & ProductsID)
        _DSTo.Tables.Add(_DSFrom.Tables(vTableName).Clone)
        For Each _row_from In _DSFrom.Tables(vTableName).Rows
            _row_to = _DSTo.Tables(vTableName).NewRow
            _row_to.ItemArray = _row_from.ItemArray
            _row_to("products_id") = vToProductID
            If IDFieldToNull & "" <> "" Then
                _row_to(IDFieldToNull) = DBNull.Value
            End If
            _DSTo.Tables(vTableName).Rows.Add(_row_to)
        Next
        PlushData.clsConnection.UpdateDataTableInDB(_DSTo.Tables(vTableName), "SELECT * FROM " & vTableName)
    End Sub
    Public Sub Load_One_Products_DVD_Info()
        Dim _DS As New DataSet
        _DS.Tables.Add("TmpTable")
        PlushData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), "SELECT * FROM products_dvd where products_id = " & ProductsID)
        If _DS.Tables("TmpTable").Rows.Count = 1 Then
            Products_dvd_row = _DS.Tables("TmpTable").Rows(0)
            '_INOUT = Products_dvd_row("inout")
            _product_dvd_status = Products_dvd_row("products_dvd_status")
            '_box_id = Products_dvd_row("box_id")
            '_posBox_id = Products_dvd_row("pibox_id")
        Else
            Products_dvd_row = Nothing
        End If
    End Sub
    'Public Sub Load_All_Products_DVD_Info()
    '    DataSet1.Tables("products_dvd").Clear()
    '    DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_dvd"), "SELECT * FROM products_dvd where products_id = " & ProductsID)
    'End Sub
    'Public Sub LoadFirstAlarm()
    '    Dim _SqlTxt As String = "select alert_cre_date, alert_comment, products_dvd_id FROM products_alert WHERE products_id=" & _
    '              ProductsID & " and (products_dvd_id=0 or products_dvd_id=" & _
    '              DvdId & ") order by products_dvd_id DESC limit 1"
    '    Dim _DS As New DataSet
    '    _DS.Tables.Add("AlarmInfo")
    '    DvdPostData.clsConnection.FillDataSet(_DS.Tables("AlarmInfo"), _SqlTxt)
    '    If _DS.Tables("AlarmInfo").Rows.Count = 1 Then
    '        alert_cre_date = _DS.Tables("AlarmInfo").Rows(0)("alert_cre_date")
    '        alert_comment = _DS.Tables("AlarmInfo").Rows(0)("alert_comment")
    '    Else
    '        alert_cre_date = Nothing
    '        alert_comment = ""
    '    End If
    'End Sub
    'Public Sub LoadExpeditedOrders()
    '    OrdersDataTable = New DataTable("Orders")
    '    'Orders Status : 2=Pret pour Expedition, 12=Retardé, 6=Perdu, 15=Transit Kiala , 17 = delayed go , 18 = delayed back 
    '    Dim _SqlTxt As String = "SELECT pdesc.products_name, pdvd.products_dvd_status, op.products_id, op.orders_id, last_modified, o.orders_status, " & _
    '        " op.orders_products_status, op.products_dvd, customers_id, date_purchased, customers_id, customers_name" & " FROM orders_products op " & _
    '        " left join orders o on o.orders_id = op.orders_id " & _
    '        " left join products_dvd pdvd on pdvd.products_id = op.products_id and op.products_dvd=pdvd.products_dvdid " & _
    '        " left join products_description pdesc on pdesc.products_id=op.products_id and pdesc.language_id=3 " & _
    '        " WHERE (o.orders_status = 2 Or o.orders_status = 12 Or o.orders_status = 6 or o.orders_status = 15 or o.orders_status = 17 or o.orders_status = 18 )" & _
    '        " AND op.products_id = " & ProductsID & _
    '        " AND op.products_dvd= " & DvdId & _
    '        " order by products_dvd"

    '    DvdPostData.clsConnection.FillDataSet(OrdersDataTable, _SqlTxt)
    'End Sub
    Public Function GetProductLangLabel() As String
        Dim _Label As String = ""
        Dim _SQLTXt As String
        Dim _FR As Boolean = False
        Dim _NL As Boolean = False
        'FR
        _SQLTXt = "SELECT count(*) from products_to_languages WHERE products_id = " & ProductsID & " AND products_languages_id = 1 "
        If BKGlobal.ExecuteExists(_SQLTXt) = True Then _FR = True
        _SQLTXt = "SELECT count(*) from products_to_undertitles WHERE products_id = " & ProductsID & " AND products_undertitles_id = 1 "
        If BKGlobal.ExecuteExists(_SQLTXt) = True Then _FR = True
        'NL
        _SQLTXt = "SELECT count(*) from products_to_languages WHERE products_id = " & ProductsID & " AND products_languages_id = 2 "
        If BKGlobal.ExecuteExists(_SQLTXt) = True Then _NL = True
        _SQLTXt = "SELECT count(*) from products_to_undertitles WHERE products_id = " & ProductsID & " AND products_undertitles_id = 2 "
        If BKGlobal.ExecuteExists(_SQLTXt) = True Then _NL = True
        If _FR Then _Label = _Label & "F"
        If _FR And _NL Then _Label = _Label & " - "
        If _NL Then _Label = _Label & "N"
        Return _Label
    End Function
    'Public Function GetlastCreatedOrder() As DataRow
    '    Dim TmpTable As DataTable = New DataTable("TmpTable")
    '    'Orders Status : 2=Pret pour Expedition, 12=Retardé, 6=Perdu, 15=Transit Kiala
    '    Dim _SqlTxt As String = "SELECT o.orders_id, o.multishipment_sm, o.date_purchased, o.orders_status, op.orders_products_status, " & _
    '        " op.products_id, op.products_dvd as dvd_id, " & _
    '        " o.delivery_name, o.delivery_street_address, lang.name as lang_name, c.customers_id, " & _
    '        " o.delivery_city, o.delivery_country, o.delivery_postcode, o.secured_mail, pdvd.box_id, pdvd.pibox_id, c.customers_abo_multishipment,op.pick_boxid " & _
    '        " FROM orders_products op " & _
    '        " left join orders o on o.orders_id = op.orders_id " & _
    '        " left join products_dvd pdvd on pdvd.products_id = op.products_id and op.products_dvd=pdvd.products_dvdid " & _
    '        " left join customers c on c.customers_id = o.customers_id " & _
    '        " left join languages lang on lang.languages_id = c.customers_language " & _
    '        " WHERE  op.products_id = " & ProductsID & _
    '        " AND op.products_dvd= " & DvdId & _
    '        " order by o.date_purchased DESC limit 1"
    '    DvdPostData.clsConnection.FillDataSet(TmpTable, _SqlTxt)
    '    If TmpTable.Rows.Count = 1 Then
    '        Return TmpTable.Rows(0)
    '    Else
    '        Return Nothing
    '    End If
    'End Function

    'Public Function GetCptOrders(ByVal products_id As Integer, ByVal dvd_id As Integer) As Integer
    '    Dim sql As String
    '    Dim result As Integer
    '    sql = DvdPostData.clsOdersStatusHistory.getCptOrdersNotReturned(products_id, dvd_id)
    '    result = DvdPostData.clsConnection.ExecuteScalar(sql)

    '    Return result
    'End Function

    Public Function GetlastOrder(ByVal products_id As Integer, ByVal dvd_id As Integer) As DataRow
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsOdersStatusHistory.GetLastOrders(products_id, dvd_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count = 1 Then
            Return dt.Rows(0)
        Else
            Return Nothing

        End If

    End Function

    'Public Function GetLastModifiedOrder(ByRef orders_status As Integer) As DataRow
    '    Dim _order As DataRow
    '    Dim status_condition As String = ""
    '    Dim _DS As New DataSet
    '    _DS.Tables.Add("TmpTable")
    '    If orders_status > 0 Then status_condition = " and new_value=" & orders_status
    '    Dim _SQLTxt As String = "SELECT op.orders_id, osh.date_added, o.orders_status, op.orders_products_status, op.products_dvd, customers_id, date_purchased, " & _
    '              " customers_id FROM orders o left join orders_status_history osh on osh.orders_id=o.orders_id " & _
    '              " left join orders_products op on o.orders_id = op.orders_id WHERE op.products_id =" & ProductsID & _
    '              " AND op.products_dvd=" & DvdId & " " & status_condition & " order by last_modified DESC limit 1"
    '    DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), _SQLTxt)
    '    If _DS.Tables("TmpTable").Rows.Count = 1 Then
    '        _order = _DS.Tables("TmpTable").Rows(0)
    '    Else
    '        _order = Nothing
    '    End If

    '    Return _order
    'End Function

    Public Sub ChangeDVDAtHome(ByRef vCustomers_id As Integer, ByVal vQty As Integer)
        Dim columnName As String = "customers_abo_dvd_home_norm"
        If isAdult Then
            columnName = "customers_abo_dvd_home_adult"
        End If
        Dim _sql As String = "update customers c set " & columnName & " = if(" & columnName & " >= abs(" & vQty & ")," & columnName & " + " & vQty & ",0) " & _
                             " where c.customers_id=" & vCustomers_id
        PlushData.clsConnection.ExecuteNonQuery(_sql)
    End Sub

    'Public Function ChangeStateProductsDVD(ByVal dvd_status As DvdPostData.clsProductDvd.DVDStatus, _
    '                                       ByVal comment As String, ByVal process_type As DvdPostData.ClsProducts_dvd_state.state, _
    '                                        ByVal dvdInout As DvdPostData.clsProductDvd.INOUT, Optional ByVal pick_group As Integer = -1) As Boolean
    '    Dim sql As String

    '    ChangeStatus(dvd_status, process_type)
    '    products_dvd_status = dvd_status
    '    ChangeBox(GetBox(), GetPosBox())
    '    sql = DvdPostData.ClsProducts_dvd_state.getInsertHistory(ProductsID, DvdId, process_type, dvd_status, GetBox(), GetPosBox(), dvdInout, pick_group)
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)
    '    LogStatusDVD(comment)

    'End Function

    'Public Function ChangeStateProductsDVD(ByVal dvd_status As DvdPostData.clsProductDvd.DVDStatus, _
    '                                       ByVal box_id As Integer, ByVal posbox_id As Integer, _
    '                                       ByVal comment As String, ByVal process_type As DvdPostData.ClsProducts_dvd_state.state, _
    '                                       ByVal dvdInout As DvdPostData.clsProductDvd.INOUT, Optional ByVal pick_group As Integer = -1, _
    '                                       Optional ByVal NewDVDINOUT As DvdPostData.clsProductDvd.INOUT = DvdPostData.clsProductDvd.INOUT.IN) As Boolean
    '    Dim sql As String

    '    ChangeStatus(dvd_status, process_type)
    '    products_dvd_status = dvd_status
    '    ChangeBox(GetBox(box_id), GetPosBox(posbox_id), NewDVDINOUT)

    '    sql = DvdPostData.ClsProducts_dvd_state.getInsertHistory(ProductsID, DvdId, process_type, dvd_status, box_id, PosBoxID, dvdInout, pick_group)
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql, True)
    '    LogStatusDVD(comment)

    'End Function
    'Private Function ChangeStatus(ByVal status As DvdPostData.clsProductDvd.DVDStatus, ByVal process_type As DvdPostData.ClsProducts_dvd_state.state) As Boolean
    '    Dim sql As String
    '    Dim ok As Boolean

    '    If status = products_dvd_status Then Return False
    '    ' products_dvd_status = status
    '    sql = " update products_dvd set products_dvd_status= " & status & _
    '         " where products_id = " & ProductsID & " and products_dvdid  = " & DvdId

    '    ok = DvdPostData.clsConnection.ExecuteNonQuery(sql) > 0

    '    sql = "INSERT INTO products_dvd_status_history values (null, now()," & _
    '         status & ", " & DvdPostData.clsSession.user_id & ", " & products_dvd_status & ", '" & PlushTools.clsEnum.getNameStrEnum(process_type) & "', " & ProductsID & ", " & DvdId & ")"
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    Return ok


    'End Function
    'Private Function ChangeBox(ByVal box_id As Integer, ByVal posBox As Integer, Optional ByVal NewDVDINOUT As DvdPostData.clsProductDvd.INOUT = DvdPostData.clsProductDvd.INOUT.IN) As Boolean

    '    Dim sql As String
    '    Dim ok As Boolean
    '    sql = "update products_dvd pd set box_id = " & box_id & ", `inout` = " & NewDVDINOUT & ", pibox_id = " & posBox & _
    '           " , last_adminby = " & DvdPostData.clsSession.user_id & " , last_admindate = now() where pd.products_id=" & _
    '           ProductsID & " and pd.products_dvdid=" & DvdId

    '    Me._box_id = box_id
    '    Me._posBox_id = posBox

    '    ok = DvdPostData.clsConnection.ExecuteNonQuery(sql) > 0
    '    Return ok
    'End Function

    Private Function LogStatusDVD(ByVal comment As String) As Boolean
        Dim sql As String
        sql = "INSERT INTO securityuser_log (UserID, LogDate, products_id, dvd_id,  Log_Type) values (" & _
            PlushData.clsSession.user_id & ", now(),  " & ProductsID & ", " & -1 & ", '" & comment & "'" & _
            ") "
        PlushData.clsConnection.ExecuteNonQuery(sql)

    End Function

    Private Sub GetOutTheBox()
        'Get a DVD out of the Box and Renumber other DVDs
        Dim intbox_id As Integer
        Dim intpibox_id As Integer
        Dim sSQL As String
        Dim _DS As New dsProducts


        'line_up
        sSQL = "SELECT * from products_dvd where products_id=" & ProductsID & " and products_dvdid=" & -1 & " "
        PlushData.clsConnection.FillDataSet(_DS.Tables("products_dvd"), sSQL)
        If _DS.Tables("products_dvd").Rows.Count = 1 Then
            intbox_id = _DS.Tables("products_dvd").Rows(0)("box_id")
            intpibox_id = _DS.Tables("products_dvd").Rows(0)("pibox_id")
        Else
            intbox_id = -1
            intpibox_id = -1
        End If

        'put int the box 0
        sSQL = "update products_dvd pd set box_id = 0,  `inout` = 1, pibox_id= 0 , last_adminby = " & PlushData.clsSession.user_id & _
              " , last_admindate = now() where pd.products_id=" & ProductsID & " and pd.products_dvdid=" & -1 & " "
        PlushData.clsConnection.ExecuteNonQuery(sSQL)


        If intbox_id > 0 Then
            'Line Up
            sSQL = "update products_dvd set pibox_id = pibox_id - 1 where box_id = '" & intbox_id & _
                   "' and pibox_id > '" & intpibox_id & "'and `inout` = 1 and products_dvd_status = 1 order by pibox_id asc "
            PlushData.clsConnection.ExecuteNonQuery(sSQL)
        End If





    End Sub
    Private Sub GetOutTheBox2(ByVal vStatus As Integer, ByVal vproductsid As Integer, ByVal vDvdid As Integer)
        'Get a DVD out of the Box and Renumber other DVDs when the dvd are "bizarment perdu ", "abime" and "broken"
        Dim intbox_id As Integer
        Dim intpibox_id As Integer
        Dim inout As Integer
        Dim sSQL As String
        Dim _DS As New dsProducts
        Dim count As Integer = 0
        Dim dsCount As New DataSet()
        Dim exist As Boolean = False


        'line_up
        sSQL = "SELECT * from products_dvd where products_id=" & vproductsid & " and products_dvdid=" & vDvdid & " "
        PlushData.clsConnection.FillDataSet(_DS.Tables("products_dvd"), sSQL)
        If _DS.Tables("products_dvd").Rows.Count = 1 Then
            intbox_id = _DS.Tables("products_dvd").Rows(0)("box_id")
            intpibox_id = _DS.Tables("products_dvd").Rows(0)("pibox_id")
            inout = _DS.Tables("products_dvd").Rows(0)("inout")
        Else
            intbox_id = -1
            intpibox_id = -1
        End If

        'put int the box 0

        'put de dvd 'abime' in the box 70000        
        If vStatus = PlushData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED Or vStatus = PlushData.clsProductDvd.DVDStatus.ENTRETIEN Then

            dsCount.Tables.Add("count")
            exist = False 'Me.existDVD(vDvdid, vproductsid, 70000)
            If exist = True Then
                MsgBox("this dvd exist already, you cannot place this dvd in the box 70000", MsgBoxStyle.Exclamation)
                dsCount.Clear()
                Exit Sub
            End If

            If IsNothing(dsCount.Tables("count")) Then

            Else
                PlushData.clsConnection.FillDataSet(dsCount.Tables("count"), "select count(*) as count from products_dvd where  box_id = 70000  ")
                count = dsCount.Tables("count").Rows(0)("count")
                count = count + 1
            End If

            Dim _sql As String = "update products_dvd set box_id = 70000 , pibox_id = '" & count & "',last_admindate = now(), last_adminby = '" & PlushData.clsSession.user_id & "'where products_id = " & vproductsid & " and products_dvdid=" & vDvdid & " "
            PlushData.clsConnection.ExecuteNonQuery(_sql)
            MsgBox("put the dvd in box 70000 at the pibox " + count.ToString, MsgBoxStyle.Exclamation)

        End If

        'put de dvd 'broken' in the box 80000
        If vStatus = PlushData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN Or vStatus = PlushData.clsProductDvd.DVDStatus.IRREPARABLE Then


            dsCount.Tables.Add("count")

            exist = False 'Me.existDVD(vDvdid, vproductsid, 80000)
            If exist = True Then
                MsgBox("this dvd exist already, you cannot place this dvd in the box 80000", MsgBoxStyle.Exclamation)
                dsCount.Clear()
                Exit Sub
            End If
            If IsNothing(dsCount.Tables("count")) Then

            Else
                PlushData.clsConnection.FillDataSet(dsCount.Tables("count"), "select count(*) as count from products_dvd where  box_id = 80000  ")
                count = dsCount.Tables("count").Rows(0)("count")
                count = count + 1
            End If

            Dim _sql As String = "update products_dvd set box_id = 80000 , pibox_id = '" & count & "',last_admindate = now(),last_adminby = '" & PlushData.clsSession.user_id & "' where products_id = " & vproductsid & " and products_dvdid=" & vDvdid & " "
            PlushData.clsConnection.ExecuteNonQuery(_sql)
            MsgBox("put the dvd in box 80000 at the pibox " + count.ToString, MsgBoxStyle.Exclamation)

        End If



        'renumber pibox_id under 60000
        If vStatus = 2 Or 4 Or 15 And intbox_id <= 60000 And inout = 1 Then
            If intbox_id > 0 Then

                sSQL = "update products_dvd pdvd set pibox_id = pibox_id - 1 where box_id = '" & intbox_id & _
                       "' and pibox_id > '" & intpibox_id & "'and pdvd.inout = 1  order by pibox_id asc "
            End If
            If intbox_id < 0 Then
                sSQL = "update products_dvd pdvd set pibox_id = pibox_id + 1 where box_id = '" & intbox_id & _
                       "' and pibox_id > '" & intpibox_id & "'and pdvd.inout = 1 and products_dvd_status = 1 order by pibox_id asc "
            End If
            PlushData.clsConnection.ExecuteNonQuery(sSQL)
        End If

        'put the dvd inout = 1 by the process in 
        If inout = 0 Then
            PlushData.clsConnection.ExecuteNonQuery("update products_dvd pdvd set pdvd.inout = 1 where products_id = " & vproductsid & " and products_dvdid=' " & vDvdid & " '")
        End If
        dsCount.Clear()
    End Sub
    Public Sub putInTheBox(ByVal dt As DataTable, ByVal status As Integer, ByVal boxId As Integer, ByVal piboxId As Integer, ByVal productsId As Integer, ByVal dvdId As Integer, ByVal userId As Integer)
        If dt.Rows.Count = 1 Then
            Dim inout As Integer = PlushData.clsProcessIN.Status.IN
            Dim updateProducts As String = PlushData.clsProductDvd.GetUpdateBoxPiboxStatus(productsId, dvdId, status, inout, boxId, piboxId, userId)
            PlushData.clsConnection.ExecuteNonQuery(updateProducts)
        Else
            MsgBox("This DVD may not have multiple products_dvdid ")
        End If
    End Sub


    'check if a dvdid exist
    Public Function existDVD(ByVal vDVDid As Integer, ByVal vProductsid As Integer, ByVal vbox_id As Integer) As Boolean


        Dim count As Integer
        Dim _dsExist As New DataSet()
        _dsExist.Tables.Add("exist")
        PlushData.clsConnection.FillDataSet(_dsExist.Tables("exist"), "select *  from products_dvd where products_id ='" & vProductsid & "' and products_dvdid = '" & vDVDid & "' and box_id = '" & vbox_id & "'")
        count = _dsExist.Tables("exist").Rows.Count
        If count > 0 Then
            Return True
        Else
            Return False
        End If
        _dsExist.Clear()

    End Function
    Private Sub GetInTheBox(ByVal v_NewBoxID As Integer, ByVal v_NewPiBoxID As Integer) 'Insert DVD In Stock
        Dim intbox_id As Integer
        Dim intpibox_id As Integer
        Dim _inout As Integer
        Dim sSQL As String
        Dim _DS As New dsProducts
        sSQL = "SELECT * from products_dvd where products_id=" & ProductsID & " and products_dvdid=" & -1 & " "
        PlushData.clsConnection.FillDataSet(_DS.Tables("products_dvd"), sSQL)
        If _DS.Tables("products_dvd").Rows.Count = 1 Then
            intbox_id = _DS.Tables("products_dvd").Rows(0)("box_id")
            intpibox_id = _DS.Tables("products_dvd").Rows(0)("pibox_id")
            _inout = _DS.Tables("products_dvd").Rows(0)("inout")
        Else
            intbox_id = -1
            intpibox_id = -1
        End If

        If intbox_id > 0 And _inout > 0 Then 'DVD Was Already in a Box - Removing it and renumber all DVD
            sSQL = "update products_dvd set pibox_id = pibox_id - 1 where box_id = '" & intbox_id & _
                   "' and pibox_id > '" & intpibox_id & "' order by pibox_id asc "
            PlushData.clsConnection.ExecuteNonQuery(sSQL)
        End If
        'Move 1 position all others DVD in the Box
        sSQL = "update products_dvd set pibox_id = pibox_id + 1 where box_id = '" & v_NewBoxID & _
               "' and pibox_id > '" & v_NewPiBoxID & "' order by pibox_id asc "
        PlushData.clsConnection.ExecuteNonQuery(sSQL)
        'Insert the DVD in the New Box
        sSQL = "update products_dvd pd set box_id = " & v_NewBoxID & ",  `inout` = 1, pibox_id = " & v_NewPiBoxID & _
               " , last_adminby = " & PlushData.clsSession.user_id & " , last_admindate = now() where pd.products_id=" & _
               ProductsID & " and pd.products_dvdid=" & -1 & " "
        PlushData.clsConnection.ExecuteNonQuery(sSQL)
    End Sub


    Public Overrides Function ToString() As String
        Return _productsId & "-" & 0
    End Function
#Region "Process-ABO"
    'Public Function AssignDVD(ByVal isIllimitedAbo As Boolean, ByVal isCompensation As Boolean, ByVal wl_id As Integer, ByVal customers_id As Integer, ByVal creditAction As DvdPostData.clsCreditHistory.ActionId, ByVal orders_type As DvdPostData.ClsCustomersData.OrdersType) As Integer
    '    Try
    '        Dim orders_id As Integer = 0
    '        orders_id = createOrder(customers_id, orders_type)
    '        SetProductsAsOrdered()
    '        SetCustomerHasNewOrder(isIllimitedAbo, isCompensation, customers_id, creditAction, orders_id)
    '        RemoveWishlistEntry(wl_id)
    '        If isCompensation Then
    '            flagCompensation(customers_id, orders_id)
    '        End If
    '        Return orders_id
    '    Catch ex As Exception
    '        DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Abo_Process, ex, customers_id)
    '        Throw ex
    '    End Try
    'End Function
    'Private Function createOrder(ByRef customers_id As Integer, ByVal orderstype As DvdPostData.ClsCustomersData.OrdersType) As Integer
    '    Dim sql As String

    '    Dim orders_id As Integer
    '    Dim result As Object
    '    Dim products_name As String = ""
    '    Dim products_model As String = ""

    '    If IsNothing(Product_row) Then
    '        MsgBox("DVD Info not Loaded", MsgBoxStyle.Critical)
    '        Return -1
    '    End If
    '    If ProductsID = -1 Then
    '        MsgBox("DVD Info not Loaded", MsgBoxStyle.Critical)
    '        Return -1
    '    End If
    '    If _productsType & "" = "" Then
    '        _productsType = MyBase.TableOfData.Rows(0)("products_type")
    '    End If
    '    If _productsType & "" = "" Then 'If Product Type still blank then Exit
    '        MsgBox("Product Type Not Defined. Cannot Delete Order", MsgBoxStyle.Critical)
    '        Return -1
    '    End If
    '    If Product_row("products_type") = "ABO" Then
    '        Return -1
    '    End If
    '    sql = "insert into orders (orders_id, customers_id, customers_name,date_purchased, orders_status,user_modified) "
    '    sql = sql & " values (null," & customers_id & ",'MESSAGE_ORDER_TO_FILL',now(),1," & DvdPostData.clsSession.user_id & ")"
    '    result = DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    sql = "select max(orders_id) orders_id from orders where customers_id=" & customers_id
    '    result = DvdPostData.clsConnection.ExecuteScalar(sql)

    '    If Not result Is Nothing Then
    '        orders_id = result
    '    End If
    '    'sql = "insert into orders_total (orders_id, title, text, value, class, sort_order) values (" & orders_id & ", 'Total:', '', 0, 'ot_total', 4  )"
    '    'DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    sql = "insert into orders_status_history (orders_id, new_value, date_added) values (" & orders_id & ", 1,now())"
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    sql = "insert into orders_products (orders_id, products_id , products_dvd , products_name, products_quantity, orders_products_type ) values (" & _
    '        orders_id & ", '" & ProductsID & "','" & DvdId & "', 'MESSAGE_ORDERSPRODUCTS_TO_FILL', '1', '" & productsType & "')"
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    'Update Customer Info in Order

    '    sql = "update orders o "
    '    sql = sql & " LEFT JOIN customers c on c.customers_id = o.customers_id "
    '    sql = sql & " LEFT JOIN address_book ab on ab.address_book_id=c.customers_default_address_id and ab.customers_id=o.customers_id "
    '    sql = sql & " LEFT JOIN country co on ab.entry_country_id=co.countries_id  "
    '    sql = sql & " set "
    '    sql = sql & " o.customers_name=concat(c.customers_firstname,' ',customers_lastname)"
    '    sql = sql & " ,o.customers_street_address=ab.entry_street_address"
    '    sql = sql & " ,o.customers_suburb=ab.entry_suburb"
    '    sql = sql & " ,o.customers_city=ab.entry_city"
    '    sql = sql & " ,o.customers_postcode=ab.entry_postcode"
    '    sql = sql & " ,o.customers_state=ab.entry_state"
    '    sql = sql & " ,o.customers_country= if(co.countries_name is null ,'BELGIUM',co.countries_name)"
    '    sql = sql & " ,o.customers_telephone=c.customers_telephone"
    '    sql = sql & " ,o.customers_email_address=c.customers_email_address"
    '    sql = sql & " ,o.customers_address_format_id=1"
    '    sql = sql & " ,o.delivery_name=concat(ab.entry_firstname,' ',ab.entry_lastname)"
    '    sql = sql & " ,o.delivery_street_address=ab.entry_street_address"
    '    sql = sql & " ,o.delivery_suburb=ab.entry_suburb"
    '    sql = sql & " ,o.delivery_city=ab.entry_city"
    '    sql = sql & " ,o.delivery_postcode=ab.entry_postcode"
    '    sql = sql & " ,o.delivery_state=ab.entry_state"
    '    sql = sql & " ,o.delivery_country=if(co.countries_name is null ,'BELGIUM',co.countries_name)"
    '    sql = sql & " ,o.delivery_address_format_id=1"
    '    sql = sql & " ,o.payment_method='abo'"
    '    sql = sql & " ,o.date_purchased=now()"
    '    sql = sql & " ,o.orders_status=1"
    '    sql = sql & " ,o.comments=''"
    '    sql = sql & " ,o.currency='EUR'"
    '    sql = sql & " ,o.currency_value=1"
    '    sql = sql & " ,o.site=1"
    '    sql = sql & " ,o.orders_type ='" & PlushTools.clsEnum.getNameStrEnum(orderstype) & "'"
    '    sql = sql & " WHERE o.orders_id = " & orders_id

    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    'Update Produts Info in orders_products

    '    sql = "update orders_products op "
    '    sql = sql & " LEFT JOIN orders o on o.orders_id = op.orders_id "
    '    sql = sql & " LEFT JOIN customers c on c.customers_id=o.customers_id "
    '    sql = sql & " LEFT JOIN products p on p.products_id=op.products_id "
    '    sql = sql & " LEFT JOIN products_description pd on pd.products_id = op.products_id and pd.language_id = c.customers_language "
    '    sql = sql & " set op.products_model=p.products_model, op.products_name=pd.products_name, op.orders_products_type = p.products_type "
    '    sql = sql & " where op.orders_id=" & orders_id

    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)


    '    Return orders_id

    'End Function
    'Private Sub SetProductsAsOrdered()
    '    Dim _sql As String
    '    _sql = "update products_dvd pd set  `inout` = 2 WHERE pd.products_id = " & ProductsID & " AND products_dvdid = " & DvdId
    '    DvdPostData.clsConnection.ExecuteNonQuery(_sql)
    'End Sub
    Private Sub SetCustomerHasNewOrder(ByVal isIllimitedAbo As Boolean, ByVal isCompensation As Boolean, ByVal customers_id As Integer, ByVal creditAction As PlushData.clsCreditHistory.ActionId, ByVal orders_id As Integer)
        Dim sql As String
        Dim DVDAtHomeColumnName As String = "customers_abo_dvd_home_norm"
        If isAdult Then DVDAtHomeColumnName = "customers_abo_dvd_home_adult"

        'Increase the rank only if customer not VIP
        'Update DVDAtHome Adult or Norm
        'Update DVD Rent This Month (before, update happened only if abo_type=2)
        Dim setRentThisMonth As String = ""
        If Not isCompensation And Not isIllimitedAbo Then
            setRentThisMonth = ", customers_abo_dvd_credit = if(customers_abo_dvd_credit > 0,customers_abo_dvd_credit - 1,0) " & _
                               " , customers_abo_dvd_remain = if(customers_abo_dvd_remain > 0,customers_abo_dvd_remain - 1,0) "

            'insert  credit use in table credit_history (must be insert behind update dvd credit 
            Dim sqlCreditHist As String = PlushData.clsCreditHistory.GetInsertCreditHistory(-1, customers_id, creditAction, False, orders_id)
            PlushData.clsConnection.ExecuteNonQuery(sqlCreditHist)
        End If


        sql = "update customers c set " & DVDAtHomeColumnName & "=(" & DVDAtHomeColumnName & "+1) " & setRentThisMonth & _
             " where customers_id=" & customers_id
        PlushData.clsConnection.ExecuteNonQuery(sql)

    End Sub
    Private Sub RemoveWishlistEntry(ByVal wl_id As Integer)
        Dim sql As String
        Dim tableSuffix As String = ""


        'save the previous wishlist entry in wishlist_assigned
        sql = "insert into wishlist_assigned (wl_id,customers_id ,products_id,rank,date_added,date_assigned,wishlist_type,priority,wishlist_source_id,theme_event_id) " & _
              " select wl_id, customers_id ,product_id ,rank ,date_added , now(), wishlist_type,priority,wishlist_source_id,theme_event_id " & _
              " from wishlist where wl_id=" & wl_id
        PlushData.clsConnection.ExecuteNonQuery(sql)
        'delete the entry from wishlist
        ' debug david 
        sql = "delete from wishlist where wl_id=" & wl_id
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub
    Private Sub flagCompensation(ByRef customers_id As Integer, ByRef orders_id As Integer)
        'MUST STORE THE DVD SENT IN COMPENSATION
        'MARK THE DVD AS SENT !!!! COMPENSATION NOTPROCESSED MUST BE SET BACK
        'Finding the compensation to update
        Dim sql As String
        sql = "select * FROM compensation c left join products p on ( c.products_id = p.products_id) "
        sql = sql & "  where compensation_date_setback IS NULL and customers_id=" & customers_id
        If isAdult Then
            sql = sql & " and p.products_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_ADULT) & "' limit 1 "
        Else
            sql = sql & " and (p.products_type = '" & PlushTools.clsEnum.getNameStrEnum(PlushData.clsProductDvd.Type_DVD.DVD_NORM) & "'  or c.products_id IS NULL) limit 1 "
        End If
        Dim _compensationID As Integer = -1
        _compensationID = BKGlobal.ExecuteFindFieldValueINT("compensation_id", sql)
        If _compensationID > 0 Then
            sql = "update compensation c "
            sql = sql & " set c.compensation_date_setback=now(), c.orders_id_given=" & orders_id & ", c.products_id_given=" & ProductsID & _
                  "  where compensation_id = " & _compensationID
            PlushData.clsConnection.ExecuteNonQuery(sql)
        End If
    End Sub
    Public Function ReplaceDvdWishlist(ByVal customers_id As Integer, ByVal products_id As Integer) As Boolean
        Dim sql As String
        Dim dt As DataTable

        sql = "select * from wishlist_assigned where customers_id = '" & customers_id & "' and products_id = '" & ProductsID & "'"
        dt = PlushData.clsConnection.FillDataSet(Sql)
        If dt.Rows.Count > 0 Then

            'Add back to WishList
            sql = "INSERT INTO wishlist (customers_id, product_id, rank, priority, date_added, wishlist_type,wishlist_source_id,theme_event_id) " & _
                      " select customers_id,products_id, rank ,priority ,date_added,wishlist_type," & PlushData.ClsCustomersData.Wishlist_Source.CANCELORDER & ",theme_event_id " & _
                      " FROM wishlist_assigned where customers_id = '" & customers_id & "' and products_id = '" & ProductsID & "' order by date_added desc limit 1 "
            PlushData.clsConnection.ExecuteNonQuery(sql)

            'delete from wishlist assigned
            sql = "DELETE FROM wishlist_assigned where customers_id = '" & customers_id & "' and products_id = '" & ProductsID & "'"
            PlushData.clsConnection.ExecuteNonQuery(sql)
            Return True
        End If


        Return False
    End Function

    'Public Function CancelOrder(ByVal isIllimitedAbo As Boolean, ByVal vOrderID As Integer, ByVal vCustomerID As Integer) As Boolean
    '    Dim _SQLTxt As String

    '    DvdPostData.clsConnection.CreateTransaction(False)
    '    Try
    '        Dim sql As String
    '        Dim dt As DataTable

    '        sql = "select count(*) from orders where customers_id = " & vCustomerID & " and orders_id = " & vOrderID & " and orders_status <> " & DvdPostData.clsOdersStatusHistory.OrderStatusNew.RETURNED
    '        If DvdPostData.clsConnection.ExecuteScalar(sql) = 0 Then
    '            MsgBox("Order returned => delete order denied", MsgBoxStyle.Critical)
    '            Return False
    '        End If

    '        'if Inout = 2 then set it Back to 1

    '        If Not IsNothing(Products_dvd_row) Then
    '            ' if the dvd is in the customers x but an order for customers Y is also opened
    '            If Products_dvd_row("INOUT") <> 0 Then
    '                _SQLTxt = "update products_dvd SET `inout` = " & DvdPostData.clsProductDvd.INOUT.IN & _
    '                          " WHERE products_id = " & ProductsID & _
    '                          " AND products_dvdid = " & DvdId
    '                DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)


    '            End If
    '        Else
    '            MsgBox("product empty ")
    '            Return False
    '        End If

    '        ReplaceDvdWishlist(vCustomerID, ProductsID)


    '        'insert credit_history before the update of customers_abo_dvd_credit 'by gauthier
    '        Dim colDVDatHome As String
    '        If Me.productsType = "DVD_ADULT" Then
    '            colDVDatHome = "customers_abo_dvd_home_adult"

    '        Else
    '            colDVDatHome = "customers_abo_dvd_home_norm"
    '        End If
    '        Dim sqlcredit As String = ""
    '        If Not isIllimitedAbo Then
    '            DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.clsCreditHistory.GetInsertCreditHistory(1, vCustomerID, DvdPostData.clsCreditHistory.ActionId.DELETEORDER, False, vOrderID))
    '            If DVDPostBuziness.ClsInventory.isNPP(vCustomerID) Then
    '                sqlcredit = ", customers_abo_dvd_credit = customers_abo_dvd_credit + 1, customers_abo_dvd_remain = customers_abo_dvd_remain + 1 "
    '            Else
    '                sqlcredit = ", customers_abo_dvd_credit = customers_abo_dvd_credit + 1 "
    '            End If
    '        End If
    '            _SQLTxt = "UPDATE customers set " & colDVDatHome & " = " & colDVDatHome & " - 1 " & _
    '                        sqlcredit & _
    '                        " WHERE customers_id = " & vCustomerID
    '            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

    '            _SQLTxt = "Insert orders_canceled (orders_id,customers_id,products_id,products_dvd_id,last_modified,user_modified,box_id,pos,orders_type,orders_status) " & _
    '                      " select " & vOrderID & "," & vCustomerID & "," & Products_dvd_row("products_id") & "," & _
    '                      Products_dvd_row("products_dvdid") & ",now()," & DvdPostData.clsSession.user_id & "," & _
    '                      Products_dvd_row("box_id") & "," & Products_dvd_row("pibox_id") & ",orders_type,orders_status " & _
    '                      " from orders where orders_id = " & vOrderID & " and orders_type is not null"
    '            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

    '            'Delete Order
    '            _SQLTxt = "DELETE FROM orders_products where orders_id = " & vOrderID
    '            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    '            _SQLTxt = "DELETE FROM orders where orders_id = " & vOrderID
    '            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    '            DvdPostData.clsConnection.CommitTransaction(True)
    '            Return True
    '    Catch ex As Exception
    '        DvdPostData.clsConnection.CommitTransaction(False)
    '        ' DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Cancel, ex)

    '        Return False
    '    End Try

    'End Function

#End Region
#Region "ProcessIN"

    Private Function GetDVDStatus(ByVal orderStatus As PlushData.clsOdersStatusHistory.OrderStatusNew) As PlushData.clsProductDvd.DVDStatus
        Select Case orderStatus
            'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_broken
            '    Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN
            'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DAMAGED
            '    Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED
            'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED
            '    Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
            'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED_BACK
            '    Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
            'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED_GO
            '    Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
            Case PlushData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED, _
                 PlushData.clsOdersStatusHistory.OrderStatusNew.COMPLAINT_INADMISSIBLE, _
                 PlushData.clsOdersStatusHistory.OrderStatusNew.INTERCHANGE, _
                 PlushData.clsOdersStatusHistory.OrderStatusNew.DELAYED_BACK, _
                 PlushData.clsOdersStatusHistory.OrderStatusNew.DELAYED_GO
                Return PlushData.clsProductDvd.DVDStatus.DVD_STATUS_OK

                'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_NOORDER
                '    Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
                'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_ALREADYBOX
                '    Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK
                'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_CUSTSERV
                '    Return DvdPostData.clsProductDvd.DVDStatus.CUSTOMERS_SERVICE
                'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_BADLABEL
                '    Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BADLABEL


        End Select
    End Function

    'Private Function GetOrderProductStatus(ByVal orderStatus As DvdPostData.clsOdersStatusHistory.OrderStatus) As DvdPostData.clsOdersStatusHistory.OrderProductStatus
    '    Select Case orderStatus
    '        Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_broken
    '            Return DvdPostData.clsOdersStatusHistory.OrderProductStatus.ORDERS_PRODUCTS_STATUS_BROKEN
    '        Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DAMAGED
    '            Return DvdPostData.clsOdersStatusHistory.OrderProductStatus.ORDERS_PRODUCTS_STATUS_DAMAGED
    '        Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_LOST
    '            Return DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_LOST
    '        Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED
    '            Return DvdPostData.clsOdersStatusHistory.OrderProductStatus.ORDERS_PRODUCTS_STATUS_DELAYED
    '        Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED_BACK
    '            Return DvdPostData.clsOdersStatusHistory.OrderProductStatus.ORDERS_PRODUCTS_DELAYED_BACK
    '        Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED_GO
    '            Return DvdPostData.clsOdersStatusHistory.OrderProductStatus.ORDERS_PRODUCTS_STATUS_DELAYED_GO
    '        Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_EXPEDITED
    '            Return DvdPostData.clsOdersStatusHistory.OrderProductStatus.ORDERS_PRODUCTS_STATUS_RETURNED


    '    End Select

    'End Function
    'Public Function processDVDIn(ByVal StatusOrder As DvdPostData.clsOdersStatusHistory.OrderStatusNew, ByVal vBoxID As Integer, ByVal vPiBoxID As Integer, ByVal orders_id As Integer, ByVal vcustomers_id As Integer, ByVal comment As String, ByVal dvdinout As DvdPostData.clsProductDvd.INOUT) As Boolean

    '    Dim ProcessIN As String = "Process IN"
    '    Dim Iscompensation As Boolean = False
    '    Dim IsDecreaseDVD_Home As Boolean = False
    '    Dim isChangeStatus As Boolean = False
    '    '  Dim custServCat As Integer
    '    '  Dim custServAutoAnsw As Integer
    '    Dim IsMustInBox As Boolean = False ' ajouter au box en cours 
    '    Dim isorder As Boolean = True

    '    Try
    '        DvdPostData.clsConnection.CreateTransaction(False)
    '        Select Case StatusOrder

    '            'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_BROKEN
    '            '    custServCat = 2
    '            '    custServAutoAnsw = 22
    '            '    Iscompensation = True
    '            '    IsDecreaseDVD_Home = True
    '            '    isChangeStatus = True


    '            'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DAMAGED
    '            '    Iscompensation = True
    '            '    custServCat = 1
    '            '    custServAutoAnsw = 23
    '            '    IsDecreaseDVD_Home = True

    '            Case DvdPostData.clsOdersStatusHistory.OrderStatusNew.CHECK
    '                IsMustInBox = True
    '                IsDecreaseDVD_Home = True
    '                isChangeStatus = False
    '                isorder = False

    '            Case DvdPostData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED
    '                isorder = True
    '                IsMustInBox = True
    '                IsDecreaseDVD_Home = True
    '                isChangeStatus = True

    '            Case DvdPostData.clsOdersStatusHistory.OrderStatusNew.INTERCHANGE, _
    '                DvdPostData.clsOdersStatusHistory.OrderStatusNew.DELAYED_BACK, _
    '                DvdPostData.clsOdersStatusHistory.OrderStatusNew.DELAYED_GO, _
    '                DvdPostData.clsOdersStatusHistory.OrderStatusNew.LOST_BY_POST, _
    '                DvdPostData.clsOdersStatusHistory.OrderStatusNew.BROKEN_CHARGE

    '                isorder = True
    '                IsMustInBox = True
    '                IsDecreaseDVD_Home = False
    '                isChangeStatus = True

    '                'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_BADLABEL
    '                '    IsDecreaseDVD_Home = True
    '                '    isChangeStatus = True

    '                'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_NOORDER, _
    '                '    DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_ALREADYBOX
    '                '    isChangeStatus = True
    '                '    IsMustInBox = True
    '                '    isorder = False

    '                'Case DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED, _
    '                '    DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED_BACK, _
    '                '    DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_DELAYED_GO
    '                '    ' mut add credit  
    '                '    IsMustInBox = True
    '                '    isChangeStatus = True
    '                '    isorder = True
    '                '    IsDecreaseDVD_Home = True

    '            Case Else
    '                DvdPostData.clsConnection.CommitTransaction(True)
    '                Return False
    '        End Select


    '        If isorder Then
    '            '  Dim statusOrdersProduct As DvdPostData.clsOdersStatusHistory.OrderProductStatus
    '            '  statusOrdersProduct = GetOrderProductStatus(StatusOrder)
    '            setOrderAsReturned(orders_id, StatusOrder)
    '        End If

    '        Dim Newproducts_dvd_status As Integer
    '        Newproducts_dvd_status = GetDVDStatus(StatusOrder)

    '        Dim ok As Boolean
    '        ok = ChangeBox(GetBox(vBoxID, Newproducts_dvd_status), GetPosBox(vPiBoxID, Newproducts_dvd_status))

    '        If isChangeStatus Then
    '            ok = ok Or ChangeStatus(Newproducts_dvd_status, DvdPostData.ClsProducts_dvd_state.state.IN)
    '        End If
    '        Dim sql As String
    '        If ok Then
    '            sql = DvdPostData.ClsProducts_dvd_state.getInsertHistory(ProductsID, DvdId, DvdPostData.ClsProducts_dvd_state.state.IN, products_dvd_status, Me.BoxID, Me.PosBoxID, DvdPostData.clsProductDvd.INOUT.IN)
    '            DvdPostData.clsConnection.ExecuteNonQuery(sql)
    '        End If

    '        'If Iscompensation Then
    '        '    Me.insertCompensation(vcustomers_id, comment, orders_id, ProductsID, Me.DvdId)
    '        '    If custServCat > -1 Then
    '        '        Me.insertCustServ(vcustomers_id, orders_id, ProductsID, Me.DvdId, custServCat, custServAutoAnsw)
    '        '    End If
    '        'End If

    '        If IsDecreaseDVD_Home Then
    '            ChangeDVDAtHome(vcustomers_id, -1)
    '        End If


    '        If comment = "" Then
    '            comment = ProcessIN & " - " & PlushTools.clsEnum.getNameStrEnum(Newproducts_dvd_status)
    '        End If
    '        LogStatusDVD(comment)
    '        Dim cpt As Integer
    '        DvdPostData.clsConnection.CommitTransaction(True)
    '        Return IsMustInBox
    '    Catch ex As Exception
    '        DvdPostData.clsConnection.CommitTransaction(False)
    '        DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Logistic, ex.Message, vcustomers_id)
    '        Throw ex
    '    End Try

    'End Function

    'insert in the table compensation

    Public Sub insertCompensation(ByRef customers_id As Integer, ByRef compensation_comment As String, ByRef orders_id As Integer, ByRef products_id As Integer, ByRef products_dvdid As Integer)
        Dim existComp As Boolean = False
        existComp = existCompensation(customers_id, products_id)
        If existComp = False Then
            PlushData.clsConnection.ExecuteNonQuery("insert into compensation (customers_id,compensation_date_given,compensation_comment,orders_id,products_id,products_dvdid) " & _
                                                 " values (" & customers_id & " , now() , '" & compensation_comment & "' , " & orders_id & " ," & products_id & " , " & products_dvdid & " ) ")

        End If
    End Sub

    Public Function existCompensation(ByRef customers_id As Integer, ByRef products_id As Integer) As Boolean
        Dim exist As Boolean = False
        Dim sql As String = "Select Count(*) from compensation where customers_id = '" & customers_id & " ' and products_id = '" & products_id & "'"
        exist = BKGlobal.ExecuteExists(sql)
        Return exist
    End Function



    'insert in the table custserv
    Public Sub insertCustServ(ByVal customers_id As Integer, ByVal orders_id As Integer, ByVal products_id As Integer, ByVal dvd_id As Integer, ByVal custSevtCat As Integer, ByVal custServAutoAnsw As Integer)
        Dim sql As String
        Dim existCustServ As Boolean = False

        existCustServ = Me.existCustServ(customers_id, products_id)

        If existCustServ = False Then
            sql = "insert into custserv (customers_id ,language_id, custserv_cat_id, customer_date , orders_id, products_id, dvd_id, admindate, adminby,adminmessage,messagesent) select" & _
                  " c.customers_id,c.customers_language , " & custSevtCat & " , now()," & orders_id & "  ," & products_id & " ," & dvd_id & " , now(), 99 ," & _
                  "(select csa.messages_html from custserv_auto_answer csa where csa.language_id = c.customers_language and csa.custserv_auto_answer_id=  " & custServAutoAnsw & ") " & _
                   ",1 from customers c where c.customers_id = " & customers_id & " "
            PlushData.clsConnection.ExecuteNonQuery(sql)

        End If

    End Sub

    Public Function existCustServ(ByRef customers_id As Integer, ByRef products_id As Integer) As Boolean
        Dim exist As Boolean = False
        exist = BKGlobal.ExecuteExists("Select Count(*) from custserv where customers_id = " & customers_id & " and products_id = " & products_id & " ")
        Return exist
    End Function

    Private Sub ChangeOrder(ByVal orders_id As Integer, ByVal old_orders_status As PlushData.clsOdersStatusHistory.OrderStatusNew, ByVal new_status As PlushData.clsOdersStatusHistory.OrderStatusNew)
        Dim _sql As String
        _sql = " update orders o set o.orders_status = " & new_status & _
                ", o.last_modified=now() where orders_id = " & orders_id

        Dim updatedRows As Integer = PlushData.clsConnection.ExecuteNonQuery(_sql)
        If Not updatedRows > 0 Then
        End If
        _sql = "insert into orders_status_history  (orders_id, new_value, old_value, date_added, customer_notified ) values (" & orders_id & ", " & _
            new_status & ", " & old_orders_status & ", now(), 0)"
        updatedRows = PlushData.clsConnection.ExecuteNonQuery(_sql)
    End Sub

    Public Sub setOrderAsExpedited(ByVal orders_id As Integer, ByVal old_orders_status As PlushData.clsOdersStatusHistory.OrderStatusNew)
        ChangeOrder(orders_id, old_orders_status, PlushData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED)
    End Sub


    Public Sub setOrderAsReturned(ByVal orders_id As Integer, ByVal old_orders_status As PlushData.clsOdersStatusHistory.OrderStatusNew)
        ChangeOrder(orders_id, old_orders_status, PlushData.clsOdersStatusHistory.OrderStatusNew.RETURNED)
    End Sub

#End Region
#Region "ProcessOUT"
    'Public Sub SetOrderAsExpedited(ByVal vOrderRow As DataRow)
    '    Dim _SQL As String
    '    Dim _DS As New DataSet
    '    _DS.Tables.Add("TmpProductsDVDTable")
    '    '*************************************************
    '    'ALL THE FOLLOWING IS DONE AT THE PROCESS_OUT
    '    '*************************************************
    '    'Assign Orders_PRoducts  Status
    '    _SQL = "update orders_products op set op.orders_products_status = " & DvdPostData.clsOdersStatusHistory.OrderProductStatus.ORDERS_PRODUCTS_STATUS_EXPEDITED & _
    '         " " & _
    '         " where op.orders_id=" & vOrderRow("orders_id")
    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
    '    'Assign Orders Status
    '    _SQL = "update orders o " & _
    '                  "  set o.orders_status = " & DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_EXPEDITED & _
    '                  ", o.last_modified = now(), o.multishipment_sm = '" & vOrderRow("multishipment_sm") & "' " & _
    '                  " where o.orders_id = " & vOrderRow("orders_id")

    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
    '    'Set Products_DVD : Inout = 0 lastadmin ... -- Warning do not set box_id and pibox_id to 0, so I can re-print the list
    '    _SQL = "update products_dvd pd set pd.date_lastrented=now(), pd.`inout` = 0 , last_adminby = 0, last_admindate = now() " & _
    '          ", nbr_rotation = nbr_rotation + 1, nbr_rotation_since_last_check = nbr_rotation_since_last_check + 1 " & _
    '          " where pd.products_id = " & vOrderRow("products_id") & " AND pd.products_dvdid=" & vOrderRow("dvd_id")
    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
    '    'insert orders_status_history
    '    _SQL = "insert into orders_status_history (orders_id, new_value, old_value, date_added, customer_notified) values ('" & _
    '         vOrderRow("orders_id") & "', 2, 1, now(), 0)"
    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
    '    'Line Up
    '    _SQL = "SELECT products_id, products_dvdid, box_id, pibox_id from products_dvd where products_id=" & _
    '        vOrderRow("products_id") & " and products_dvdid=" & vOrderRow("dvd_id") & " "
    '    _DS.Tables("TmpProductsDVDTable").Clear()
    '    DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpProductsDVDTable"), _SQL)
    '    If _DS.Tables("TmpProductsDVDTable").Rows.Count = 1 Then
    '        If _DS.Tables("TmpProductsDVDTable").Rows(0)("pibox_id") > 0 Then
    '            _SQL = "update products_dvd pd set pibox_id = pibox_id - 1 " & _
    '                  " where box_id = '" & _DS.Tables("TmpProductsDVDTable").Rows(0)("box_id") & _
    '                  "' and pibox_id > '" & _DS.Tables("TmpProductsDVDTable").Rows(0)("pibox_id") & "' "
    '            DvdPostData.clsConnection.ExecuteNonQuery(_SQL)
    '        End If
    '    End If
    '    'Log the User Scann
    '    _SQL = "INSERT INTO securityuser_log (UserID, LogDate, products_id, dvd_id,  Log_Type) values (" & _
    '           DvdPostData.clsSession.user_id & ", now(),  " & ProductsID & ", " & DvdId & ", 'Process OUT'" & _
    '           ") "
    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQL)

    'End Sub
#End Region

    Public Sub RemoveDVDFromCatalogue()
        Dim _SQLTxt As String
        Dim _DS As New DataSet
        Dim _row As DataRow
        _DS.Tables.Add("TmpTable")
        'Change the Status of the Products
        _SQLTxt = "UPDATE products set products_status = -1 WHERE products_id = " & ProductsID
        PlushData.clsConnection.ExecuteNonQuery(_SQLTxt)

        'Load WishList containing the Product_ID
        _SQLTxt = " SELECT wl_id, product_id," & PlushData.clsMassEmail.CapitalizeSql("c.customers_firstname", "c.customers_lastname") & " as customers_name,c.*,p.*,pd.products_name " & _
                  " from wishlist w  " & _
                  " join customers c on w.customers_id = c.customers_id " & _
                  " join products p on w.product_id = p.products_id " & _
                  " join products_description pd on p.products_id = pd.products_id and pd.language_id = c.customers_language " & _
                  " where product_id = " & ProductsID
        PlushData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), _SQLTxt)
        'Send The Mails to TellCust that we have deleted the Products
        Dim _objDVDPostMisc As New clsDVDPostMisc(SessionInfo)
        ' send mail to customers
        'For Each _row In _DS.Tables("TmpTable").Rows
        '    If _row("customers_abo") = 1 Then
        '        DVDPostBuziness.clsMail.SendMail(_row, DVDPostBuziness.clsMail.Mail.MAIL_DVD_INDISPONIBLE)
        '    End If
        'Next
        'Delete Entries in the WishList
        _SQLTxt = "DELETE FROM wishlist where product_id = " & ProductsID
        PlushData.clsConnection.ExecuteNonQuery(_SQLTxt)
    End Sub

End Class
Public Class clsDVDPostMisc
    Public mvarSessionInfo As BizzLib.clsSessionInfo
    Public BKGlobal As BizzLib.clsGlobal
    Public BKFilter As BizzLib.clsFilter
    Public BKBrowseView As BizzLib.clsBrowseView
    Public BKDefaultSet As BizzLib.clsDefaultSet
    Public BKReport As BizzLib.clsReport
    Public BKCombo As BizzLib.clsCombo
    Public Property SessionInfo() As BizzLib.clsSessionInfo
        Get
            SessionInfo = mvarSessionInfo
        End Get
        Set(ByVal Value As BizzLib.clsSessionInfo)
            mvarSessionInfo = Value
        End Set
    End Property
    Public Sub SetBKOjects(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        mvarSessionInfo = CurrentSessionInfo
        BKGlobal = New BizzLib.clsGlobal(SessionInfo)
        BKFilter = New BizzLib.clsFilter(SessionInfo)
        BKBrowseView = New BizzLib.clsBrowseView(SessionInfo)
        BKDefaultSet = New BizzLib.clsDefaultSet(SessionInfo)
        BKReport = New BizzLib.clsReport(SessionInfo)
        BKCombo = New BizzLib.clsCombo(SessionInfo)
    End Sub
    Public Sub New(ByVal vSessionInfo As BizzLib.clsSessionInfo)
        SetBKOjects(vSessionInfo)
    End Sub

End Class