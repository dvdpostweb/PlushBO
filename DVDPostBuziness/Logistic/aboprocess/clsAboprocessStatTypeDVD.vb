Public Class clsAboprocessStatTypeDVD

    Public Enum Priority
        HIGH = 1
        MEDIUM = 2
        LOW = 3
    End Enum


    Enum TypeStat
        ABOPROCESS_ID
        TOTALCUSTOMERS
        CUSTOMERSERVED
        DVDSENTHIGH
        DVDSENTMEDIUM
        DVDSENTLOW
        PRIORITYSUM
        CUSTOMERPARTIALSERVED
        CUSTOMERMUSTSERVED
        CUSTOMERNOSERVED
        CUSTOMERNOSERVEDSUSPENDED
        CUSTOMERNOSERVEDNOCREDIT
        CUSTOMERNOSERVEDATHOME
        CUSTOMERNOSERVEDNOTFINDDVD
        CUSTOMERNOTSERVEDATTRIBUTEDRANKTOOLOW
        CUSTOMERNOSERVEDWISHLISTEMPTY
        CUSTOMERNOSERVEDWISHLISTLESS20
        DVDAVAILABLE
        DVDSEND
        DVDASK
        DVDSENDNORM
        DVDSENDCOMP
        CPTERROR
        CUSTOMERNOMANAGED
        DVDMAX
    End Enum

    Public EndTime As DateTime
    Public lstCust As List(Of Integer)
    Private _LstStat As Dictionary(Of TypeStat, Integer) = New Dictionary(Of TypeStat, Integer)

    Public Sub clear()
        _LstStat.Clear()
    End Sub

    Public Function getkey(ByVal pos As Integer) As Integer
        If lstCust.Count > pos Then
            Return lstCust(pos)
        End If
        Return -1
    End Function

    Public Function size() As Integer
        Return lstCust.Count
    End Function

    Public Sub deleteCustomers(ByVal key As Integer)
        lstCust.Remove(key)
    End Sub

    Public Sub addCustomers(ByVal key As Integer)
        lstCust.Add(key)
    End Sub


    Public Property AboProcess_id() As Integer
        Get
            Return GetValue(TypeStat.ABOPROCESS_ID)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.ABOPROCESS_ID, value)
        End Set
    End Property

    Public Property CptCustomer() As Integer
        Get
            Return GetValue(TypeStat.TOTALCUSTOMERS)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.TOTALCUSTOMERS, value)
        End Set
    End Property

    Public Property CptCustomerMustServed() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERMUSTSERVED)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CUSTOMERMUSTSERVED, value)

        End Set
    End Property
    Public Property CptCustomerServed() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERSERVED)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CUSTOMERSERVED, value)

        End Set
    End Property

    Public Property CptCustomerNoServed() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOSERVED)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CUSTOMERNOSERVED, value)

        End Set
    End Property

    Public Property CptCustomerNoManaged() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOMANAGED)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CUSTOMERNOMANAGED, value)
        End Set
    End Property

    Public Property CptCustomerDVDMax() As Integer
        Get
            Return GetValue(TypeStat.DVDMAX)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.DVDMAX, value)
        End Set
    End Property

    Public Property CptCustomerNoServedSuspended() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOSERVEDSUSPENDED)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CUSTOMERNOSERVEDSUSPENDED, value)

        End Set
    End Property

    Public Property CptCustomerNoServedNoCredit() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOSERVEDNOCREDIT)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CUSTOMERNOSERVEDNOCREDIT, value)

        End Set
    End Property

    Public Property CptCustomerNoServedAtHome() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOSERVEDATHOME)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CUSTOMERNOSERVEDATHOME, value)

        End Set
    End Property

    Public Property CptCustomerNoServedNotFindDVD() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOSERVEDNOTFINDDVD)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CUSTOMERNOSERVEDNOTFINDDVD, value)

        End Set
    End Property

    Public Property CPTCustomerPartialServed() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERPARTIALSERVED)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CUSTOMERPARTIALSERVED, value)
        End Set
    End Property

    Public Property CPTCustomerNotServedAttributedRanktoolow() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOTSERVEDATTRIBUTEDRANKTOOLOW)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CUSTOMERNOTSERVEDATTRIBUTEDRANKTOOLOW, value)
        End Set
    End Property

    Public Property CptDVDAvailable() As Integer
        Get
            Return GetValue(TypeStat.DVDAVAILABLE)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.DVDAVAILABLE, value)

        End Set
    End Property
    Public Property CptDVDask() As Integer
        Get
            Return GetValue(TypeStat.DVDASK)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.DVDASK, value)

        End Set
    End Property

    Public Property CptDVDSend() As Integer
        Get
            Return GetValue(TypeStat.DVDSEND)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.DVDSEND, value)

        End Set
    End Property

    Public Property CptDVDSendNorm() As Integer
        Get
            Return GetValue(TypeStat.DVDSENDNORM)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.DVDSENDNORM, value)

        End Set
    End Property

    Public Property CptDVDSendComp() As Integer
        Get
            Return GetValue(TypeStat.DVDSENDCOMP)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.DVDSENDCOMP, value)

        End Set
    End Property


    Public Property CptDVDWishlistEmpty() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOSERVEDWISHLISTEMPTY)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CUSTOMERNOSERVEDWISHLISTEMPTY, value)

        End Set
    End Property

    Public Property CptDVDWishlistLess20() As Integer
        Get
            Return GetValue(TypeStat.CUSTOMERNOSERVEDWISHLISTLESS20)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CUSTOMERNOSERVEDWISHLISTLESS20, value)
        End Set
    End Property


    Public Property CPTDVDSentHigh() As Integer
        Get
            Return GetValue(TypeStat.DVDSENTHIGH)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.DVDSENTHIGH, value)
        End Set
    End Property

    Public Property CPTDVDSentMedium() As Integer
        Get
            Return GetValue(TypeStat.DVDSENTMEDIUM)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.DVDSENTMEDIUM, value)
        End Set
    End Property

    Public Property CPTDVDSentLow() As Integer
        Get
            Return GetValue(TypeStat.DVDSENTLOW)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.DVDSENTLOW, value)
        End Set
    End Property

    Public Property PrioritySum() As Integer
        Get
            Return GetValue(TypeStat.PRIORITYSUM)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.PRIORITYSUM, value)
        End Set
    End Property

    Public Property CPTError() As Integer
        Get
            Return GetValue(TypeStat.CPTERROR)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTERROR, value)
        End Set
    End Property

    Public Sub addPriority(ByRef CustomerStat As PlushBuziness.clsCustomer_Stat_TypeDVD, ByVal priority As Integer)

        PrioritySum += priority
        Select Case priority

            Case StatAbo.Priority.HIGH
                CustomerStat.statSend.dvd_highsent += 1
                CPTDVDSentHigh += 1
            Case StatAbo.Priority.MEDIUM
                CustomerStat.statSend.dvd_mediumsent += 1
                CPTDVDSentMedium += 1
            Case StatAbo.Priority.LOW
                CustomerStat.statSend.dvd_lowsent += 1
                CPTDVDSentLow += 1

        End Select
    End Sub

    Public Function GetMetricsPriority() As Decimal
        Dim metrics As Decimal = 0
        If CptDVDSend > 0 Then
            metrics = PrioritySum / CptDVDSend
        End If
        Return metrics
    End Function

    Public Function GetRate_DVD_Served() As Integer
        Dim rate As Integer = 0
        If CptDVDask > 0 Then
            rate = (CptDVDSend / CptDVDask) * 100
        End If

        Return rate

    End Function


    Public Function GetRate_Cust_Served() As Integer
        Dim rate As Integer = 0
        If CptCustomerMustServed > 0 Then
            rate = ((CptCustomerServed + CPTCustomerPartialServed) / (CptCustomerMustServed)) * 100
        End If

        Return rate

    End Function

    Private Sub SetValue(ByVal type As TypeStat, ByVal value As Integer)

        If Not _LstStat.ContainsKey(type) Then
            _LstStat.Add(type, value)
        Else
            _LstStat(type) = value
        End If


    End Sub

    Private Function GetValue(ByVal type As TypeStat) As Integer

        If Not _LstStat.ContainsKey(type) Then
            Return 0
        Else
            Return _LstStat(type)
        End If

    End Function

    Public Function GetMetricsFormat(ByVal metrics As Decimal) As String

        Return metrics.ToString("0.##").Replace(",", ".")

    End Function
    Public Sub SaveStat()
        Dim sql As String
        sql = StrUpdateStat()
        PlushData.clsConnection.ExecuteNonQuery(sql)

    End Sub

    Public Sub CreateStat(ByVal dateStart As DateTime, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD)
        Dim sql As String
        sql = StrInsertStat(dateStart, type_dvd)
        PlushData.clsConnection.ExecuteNonQuery(sql)

        AboProcess_id = GetAboprocess_id()

    End Sub

    Public Function StrUpdateStat() As String

        Dim SQLTxt As String
        '   EndTime = Now()
        SQLTxt = "update aboprocess_stats_new set " & _
          "date_end = now()" & _
          ",total_customers = " & CptCustomer & _
          ",total_dvd_available = " & CptDVDAvailable & _
          ",cust_served = " & CptCustomerServed & _
          ",cust_partial_served = " & CPTCustomerPartialServed & _
          ",cust_notserved_total = " & CptCustomerNoServed & _
          ",cust_notserved_nomanaged = " & CptCustomerNoManaged & _
          ", dvd_to_send = " & CptDVDSendNorm & _
          ", cust_notserved_nocredit = " & CptCustomerNoServedNoCredit & _
          ", cust_notserved_nodvdfound = " & CptCustomerNoServedNotFindDVD & _
          ", cust_notserved_attributed_ranktoolow = " & CPTCustomerNotServedAttributedRanktoolow & _
          ", cust_notserved_suspended = " & CptCustomerNoServedSuspended & _
          ", cust_notserved_too_many_at_home = " & CptCustomerNoServedAtHome & _
          ", rate_dvd_served = " & GetRate_DVD_Served() & _
          ", rate_cust_served = " & GetRate_Cust_Served() & _
          ", metrics_priority = " & GetMetricsFormat(GetMetricsPriority) & _
          ", wishlist_empty = " & CptDVDWishlistEmpty & _
          ", wishlist_less20 = " & CptDVDWishlistLess20 & _
          ", dvd_asked = " & CptDVDask & _
          ", dvd_sent = " & CptDVDSend & _
          ", dvd_highsent = " & CPTDVDSentHigh & _
          ", dvd_mediumsent = " & CPTDVDSentMedium & _
          ", dvd_lowsent = " & CPTDVDSentLow & _
          ", cust_notserved_error = " & CPTError & _
          ", cust_must_served = " & CptCustomerMustServed & _
          " where aboprocess_id = " & AboProcess_id


        Return SQLTxt

    End Function
    Public Function StrInsertStat(ByVal dateStart As DateTime, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As String

        Dim SQLTxt As String
        '   EndTime = Now()
        SQLTxt = "insert into aboprocess_stats_new (products_type,date_start,date_end,total_customers,total_dvd_available, " & _
          "cust_served,cust_partial_served, cust_notserved_total,cust_notserved_nomanaged, dvd_to_send," & _
          "dvd_compensation, cust_notserved_nocredit, cust_notserved_nodvdfound,cust_notserved_attributed_ranktoolow, " & _
          " cust_notserved_suspended,cust_notserved_too_many_at_home, rate_dvd_served, rate_cust_served,metrics_priority," & _
          " wishlist_empty,wishlist_less20,dvd_asked,dvd_sent,dvd_highsent," & _
          "dvd_mediumsent,dvd_lowsent,cust_notserved_error,cust_must_served " & _
          ") values (" & type_dvd & ", now(),now()," & CptCustomer & "," & _
          CptDVDAvailable & "," & CptCustomerServed & "," & CPTCustomerPartialServed & "," & _
          CptCustomerNoServed & "," & CptCustomerNoManaged & "," & CptDVDSendNorm & "," & CptDVDSendComp & "," & _
          CptCustomerNoServedNoCredit & "," & CptCustomerNoServedNotFindDVD & "," & CPTCustomerNotServedAttributedRanktoolow & "," & _
          CptCustomerNoServedSuspended & "," & CptCustomerNoServedAtHome & "," & _
          GetRate_DVD_Served() & "," & GetRate_Cust_Served() & _
          "," & GetMetricsFormat(GetMetricsPriority) & "," & CptDVDWishlistEmpty & "," & CptDVDWishlistLess20 & "," & _
          CptDVDask & "," & CptDVDSend & "," & CPTDVDSentHigh & "," & _
          CPTDVDSentMedium & "," & CPTDVDSentLow & "," & CPTError & "," & CptCustomerMustServed & ")"

        Return SQLTxt

    End Function

    Private Function GetAboprocess_id() As Integer
        Dim sql As String
        Dim aboprocess_id As Integer
        sql = "select max(aboprocess_id) aboprocess_id from aboprocess_stats_new "
        aboprocess_id = PlushData.clsConnection.ExecuteScalar(sql)
        Return aboprocess_id
    End Function

    Public Sub New()
        lstCust = New List(Of Integer)
    End Sub
End Class
