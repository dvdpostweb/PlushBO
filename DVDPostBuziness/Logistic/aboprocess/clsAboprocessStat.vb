Public Class clsAboprocessStat

    Private Stat_Norm As clsAboprocessStatTypeDVD
    Private Stat_Adult As clsAboprocessStatTypeDVD
    Private Customers As List(Of clsCustomer_stat)
    Public maxDvdSend As Integer

    Private Shared _customerSearch_id As Integer

    Public Sub New()
        Stat_Norm = New clsAboprocessStatTypeDVD()
        Stat_Adult = New clsAboprocessStatTypeDVD()
        Customers = New List(Of clsCustomer_stat)
    End Sub


    Public Function SaveStat(ByVal customers_id As Integer, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As Boolean
        Dim cust As clsCustomer_stat
        cust = getcustomer(customers_id)

        If Not cust Is Nothing Then
            cust.GetStat(type_dvd).SaveStat(Stat_Norm.AboProcess_id)
        End If

        Return False
    End Function
    Public Function GetStat(ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As clsAboprocessStatTypeDVD
        Select Case type_dvd
            Case PlushData.clsProductDvd.Type_DVD.DVD_ADULT
                Return Stat_Adult
            Case PlushData.clsProductDvd.Type_DVD.DVD_NORM
                Return Stat_Norm
            Case Else
                Return Stat_Norm
        End Select
    End Function

    Private Function getkey(ByVal pos As Integer, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As Integer
        Dim custStat As clsAboprocessStatTypeDVD
        custStat = GetStat(type_dvd)
        Return custStat.getkey(pos)
    End Function

    Public Function size(ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As Integer
        Dim custStat As clsAboprocessStatTypeDVD
        custStat = GetStat(type_dvd)
        Return custStat.size()
    End Function

    Public Sub deleteCustomers(ByVal pos As Integer, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD)
        Dim custStat As clsAboprocessStatTypeDVD
        custStat = GetStat(type_dvd)
        custStat.deleteCustomers(custStat.getkey(pos))

    End Sub

    'Private Sub addCustomers(ByVal key As Integer, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD)
    '    Dim custStat As clsAboprocessStatTypeDVD
    '    custStat = GetStat(type_dvd)
    '    custStat.addCustomers(key)

    'End Sub
    Public Function GetDataStat() As DataTable
        Dim sql As String
        Dim dt As DataTable
        sql = "select * from aboprocess_stats_new where aboprocess_id in (" & Stat_Norm.AboProcess_id & "," & Stat_Adult.AboProcess_id & ")"
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt

    End Function
    Public Function getcustomer(ByVal index As Integer, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As clsCustomer_stat
        Dim key As Integer

        key = getkey(index, type_dvd)
        If key < Customers.Count Then
            Return Customers(key)
        End If

        Return Nothing
    End Function
    Private Function GetCustomer(ByVal customers_id As Integer) As clsCustomer_stat
        _customerSearch_id = customers_id
        Dim cust As clsCustomer_stat
        cust = Customers.Find(AddressOf ExistCustomer)
        Return cust
    End Function

    Public Sub saveStat(ByVal type_dvd As PlushData.clsProductDvd.Type_DVD)
        GetStat(type_dvd).SaveStat()
    End Sub
    'Private Function SaveStat(ByVal cust As clsCustomer_stat) As Boolean
    '    cust.SaveStat(Stat_Norm.AboProcess_id)
    '    cust.SaveStat(Stat_Adult.AboProcess_id)


    'End Function

    'Public Sub SaveStat()

    '    For Each cust As clsCustomer_stat In Customers
    '        SaveStat(cust)
    '    Next

    'End Sub

    Private Shared Function ExistCustomer(ByVal cust As clsCustomer_stat) _
      As Boolean

        Return cust.customers_id = _customerSearch_id
    End Function

    Public Function addCustomer(ByVal customers_id As Integer, ByVal sleep As Boolean) As clsCustomer_stat

        Dim cust As clsCustomer_stat
        cust = getcustomer(customers_id)
        If cust Is Nothing Then
            cust = New clsCustomer_stat(customers_id, sleep)
            Customers.Add(cust)
            Stat_Norm.addCustomers(Customers.Count() - 1)
            Stat_Adult.addCustomers(Customers.Count() - 1)
        End If

        Return cust
    End Function
End Class
