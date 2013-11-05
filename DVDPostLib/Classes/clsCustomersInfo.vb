Public Class ClsCustomersInfo
    Public Class clsCustomerABOInfo
        Public ABO_ID As Integer
        Public ABO_Name As String
        Public DVD_Credit As Integer
        Public ABO_price As Double
        Public DVD_At_Home As Integer
        Public ABO_Description As String
        Private mvarSessionInfo As BizzLib.clsSessionInfo
        Dim Cls1 As BizzLib.clsDataSet

        Public Sub New(ByVal v_SessionInfo As BizzLib.clsSessionInfo, ByVal v_ABo_ID As Integer, ByVal v_lang As Integer)
            mvarSessionInfo = v_SessionInfo
            Cls1 = New BizzLib.clsDataSet(mvarSessionInfo)
            Dim _DS As New DataSet
            _DS.Tables.Add("products")
            _DS.Tables.Add("products_abo")
            _DS.Tables.Add("products_description")
            Dim _SQLTxt As String
            _SQLTxt = "SELECT products_id, products_price FROM products where products_id = " & v_ABo_ID
            Cls1.FillDataSet(_DS.Tables("products"), _SQLTxt)
            _SQLTxt = "SELECT * FROM products_abo where products_id = " & v_ABo_ID
            Cls1.FillDataSet(_DS.Tables("products_abo"), _SQLTxt)
            _SQLTxt = "SELECT * FROM products_description where products_id = " & v_ABo_ID & " AND language_id = " & v_lang
            Cls1.FillDataSet(_DS.Tables("products_description"), _SQLTxt)
            ABO_ID = v_ABo_ID
            Try
                If Not IsNothing(_DS.Tables("products_description")) Then
                    If _DS.Tables("products_description").Rows.Count = 1 Then
                        ABO_Name = _DS.Tables("products_description").Rows(0)("products_name")
                        ABO_Description = _DS.Tables("products_description").Rows(0)("products_description")
                        DVD_Credit = _DS.Tables("products_abo").Rows(0)("qty_credit")
                        ABO_price = _DS.Tables("products").Rows(0)("products_price")
                        DVD_At_Home = _DS.Tables("products_abo").Rows(0)("qty_at_home")
                    Else
                        ABO_Name = ""
                        ABO_Description = ""
                        DVD_Credit = 0
                        ABO_price = 0
                        DVD_At_Home = 0
                    End If
                Else
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

    End Class
    Public Class clsCustomer
        Inherits BizzLib.clsOneTableData

        Dim mvarDefaultAddrData As clsCustomerAddress
        Dim mvarAllAddrData As clsCustomerAddress
        Dim mvarCurrentCustomerID As Integer
        Dim mvarDefaultAddrID As Integer


        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal vCustomers_ID As Integer, Optional ByVal boolViewNegativeBoxes As Boolean = False)

            MyBase.New(SessionInfo, DataSet1, "", "customers", "customers_id", "SELECT * FROM customers", " where customers_id = " & vCustomers_ID, "")
            ' Dim sql As String
            'sql = " select ca.last_login_at customers_info_date_of_last_logon,ca.number_of_logins customers_info_number_of_logons, c.* " & _
            '      " from customers c join customer_attributes ca on c.customers_id = ca.customer_id " & _
            '      " where customers_id = " & vCustomers_ID

            ' MyBase.New(SessionInfo, DataSet1, "", "customers", "customers_id", "SELECT * FROM customers", " where customers_id = " & vCustomers_ID, "")
            ' sql = "SELECT * FROM customers where customers_id = " & vCustomers_ID
            ' DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("customers"), sql)

            ' !!!!!!!!!!!!!!!!!!!!!!!
            '' il faut le meme nombre de colonne que de champs dans la db pour faire un update table 
            'Dim dt As DataTable

            'dt = DataSet1.Tables("customers")
            'dt.Columns.Remove(dt.Columns(dt.Columns.Count - 1))
            'dt.Columns.Remove(dt.Columns(dt.Columns.Count - 1))
            '' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            mvarCurrentCustomerID = vCustomers_ID
            DataSet1.Tables("address_book_default").Clear()
            DataSet1.Tables("address_book_all").Clear()

            If DataSet1.Tables("customers").Rows.Count = 1 Then
                Dim dr As DataRow
                dr = DataSet1.Tables("customers").Rows(0)

                mvarDefaultAddrID = dr("customers_default_address_id")
                mvarDefaultAddrData = New clsCustomerAddress(SessionInfo, DataSet1, mvarCurrentCustomerID, mvarDefaultAddrID)
                mvarAllAddrData = New clsCustomerAddress(SessionInfo, DataSet1, mvarCurrentCustomerID)
            Else
                mvarDefaultAddrID = -1
            End If

        End Sub

        ReadOnly Property objDefaultAddr() As clsCustomerAddress
            Get
                objDefaultAddr = mvarDefaultAddrData
            End Get
        End Property
        ReadOnly Property objAllAddr() As clsCustomerAddress
            Get
                objAllAddr = mvarAllAddrData
            End Get
        End Property

        Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As DataRowView) As Integer
            Return -1
        End Function
        Public Overrides Function ValidateRecordFields(ByRef Row1 As DataRowView) As Integer
            Return -1
        End Function

        Public Overloads Sub Save()
            Try
                mvarDefaultAddrData.Save()
                Dim sql As String
                sql = "SELECT * FROM customers where customers_id = " & mvarCurrentCustomerID
                PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("customers"), sql)

                'sql = "SELECT * FROM customer_attributes where customer_id = " & mvarCurrentCustomerID
                'PlushData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("customer_attributes"), sql)
            Catch ex As Exception
                MsgBox("Error save customers", MsgBoxStyle.Critical)
                PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.SignaletiqueCustomer, ex, mvarCurrentCustomerID.ToString())
                Throw ex
            End Try
        End Sub
        Public Overloads Sub SaveOnlyCustomer()
            Dim _MsgID As Integer = -1
            'Add Any Saving Before
            Try
                _MsgID = ValidateDataSetBeforeSave()
                If _MsgID <= 0 Then
                    'Save Changes
                    SaveDataSet()
                Else
                    Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
                End If
            Catch ex As Exception
                PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.SignaletiqueCustomer, ex)
            End Try
        End Sub
        Public Overloads Sub SaveOnlyDefaultAddress()
            Dim _MsgID As Integer = -1
            'Add Any Saving Before
            Try
                _MsgID = ValidateDataSetBeforeSave()
                If _MsgID <= 0 Then
                    'Save Associated Address Record
                    mvarDefaultAddrData.Save()
                Else
                    Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
                End If
            Catch ex As Exception
                '  DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.SignaletiqueCustomer, ex)
                ' Throw ex
            End Try
        End Sub
        Public Overloads Sub Delete(ByVal ID As Integer)

        End Sub

        Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
        End Function
        Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
            Return BKGlobal.ExecuteExists("Select Count(*) FROM customers WHERE " & IDFieldName & " = " & ID)
        End Function


    End Class
    Public Class clsCustomerAddress
        Inherits BizzLib.clsOneTableData

        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal vCustomers_ID As Integer, ByVal vAddressID As Integer)
            MyBase.New(SessionInfo, DataSet1, "", "address_book_default", "address_book_id", "SELECT * FROM address_book ", " where customers_id = " & vCustomers_ID & " and address_book_id = " & vAddressID, "")
        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal vCustomers_ID As Integer)
            MyBase.New(SessionInfo, DataSet1, "", "address_book_all", "address_book_id", "SELECT * FROM address_book ", " where customers_id = " & vCustomers_ID, "")
        End Sub

        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
            MyBase.New(SessionInfo)
        End Sub
        Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As DataRowView) As Integer
            Return -1
        End Function
        Public Overrides Function ValidateRecordFields(ByRef Row1 As DataRowView) As Integer
            Dim _MsgID As Integer = -1
            Return _MsgID
        End Function

        Public Overloads Sub Save()
            Dim _MsgID As Integer = -1
            Dim nameTable As String = "address_book_default"
            'Add Any Saving Before
            Try
                _MsgID = ValidateDataSetBeforeSave()
                If DataSet1.Tables(nameTable).GetChanges() IsNot Nothing Then
                    Dim sql As String
                    Dim firstname As String
                    Dim lastname As String
                    Dim address As String
                    Dim postcode As String
                    Dim city As String
                    Dim country_id As Integer
                    Dim customers_id As Integer
                    Dim defaultAddr As Integer
                    defaultAddr = DataSet1.Tables(nameTable).Rows(0)("address_book_id")
                    customers_id = DataSet1.Tables(nameTable).Rows(0)("customers_id")
                    lastname = DataSet1.Tables(nameTable).Rows(0)("entry_lastname")
                    firstname = DataSet1.Tables(nameTable).Rows(0)("entry_firstname")
                    address = DataSet1.Tables(nameTable).Rows(0)("entry_street_address")
                    postcode = DataSet1.Tables(nameTable).Rows(0)("entry_postcode")
                    city = DataSet1.Tables(nameTable).Rows(0)("entry_city")
                    country_id = DataSet1.Tables(nameTable).Rows(0)("entry_country_id")

                    lastname = lastname.Replace("'", "''")
                    firstname = firstname.Replace("'", "''")

                    sql = PlushData.clsAddressBook.InsertAddressHistory(customers_id, defaultAddr)

                    PlushData.clsConnection.ExecuteNonQuery(sql)

                    sql = PlushData.clsAddressBook.UpdateAddressBook(customers_id, defaultAddr + 1, firstname, lastname, address, postcode, city, country_id)
                    PlushData.clsConnection.ExecuteNonQuery(sql)

                    sql = PlushData.clsAddressBook.UpdateDefaultAddress(customers_id, defaultAddr + 1)
                    PlushData.clsConnection.ExecuteNonQuery(sql)
                    'Save Changes
                    DataSet1.Tables(nameTable).RejectChanges()
                    SaveDataSet()

                End If
            Catch ex As Exception
                PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.SignaletiqueCustomer, ex)
                Throw ex
            End Try
        End Sub
        Public Overloads Sub Delete(ByVal ID As Integer)

        End Sub
        Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer

        End Function
        Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
            Return BKGlobal.ExecuteExists("Select Count(*) FROM address_book WHERE " & IDFieldName & " = " & ID)
        End Function
    End Class
   
    'Public Class clsCustomerABO
    '    Inherits BizzLib.clsOneTableData
    '    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal vCustomers_ID As Integer)
    '        MyBase.New(SessionInfo)
    '        DataSet1.Tables("abo").Clear()
    '        MyBase.Initialize(DataSet1, "", "abo", "abo_id", _
    '               "SELECT * FROM abo ", _
    '               " where customerid = " & vCustomers_ID, " ORDER BY date DESC ")
    '    End Sub
    '    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
    '        MyBase.New(SessionInfo)
    '    End Sub
    '    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As DataRowView) As Integer
    '        Return -1
    '    End Function
    '    Public Overrides Function ValidateRecordFields(ByRef Row1 As DataRowView) As Integer
    '        Dim _MsgID As Integer = -1
    '        Return _MsgID
    '    End Function
    '    Public Overloads Sub Save()
    '        Dim _MsgID As Integer = -1
    '        'Add Any Saving Before
    '        Try
    '            _MsgID = ValidateDataSetBeforeSave()
    '            If _MsgID <= 0 Then
    '                'Save Changes
    '                SaveDataSet()
    '            Else
    '                Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
    '            End If
    '        Catch ex As Exception
    '            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.SignaletiqueCustomer, ex)
    '        End Try
    '    End Sub
    '    Public Overloads Sub Delete(ByVal ID As Integer)

    '    End Sub
    '    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
    '    End Function
    '    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
    '        Return BKGlobal.ExecuteExists("Select Count(*) FROM wishlist_assigned WHERE " & IDFieldName & " = " & ID)
    '    End Function
    'End Class
 
End Class
