Public Class StatAbo

    Public Enum Priority
        HIGH = 1
        MEDIUM = 2
        LOW = 3
    End Enum


    Enum TypeStat
        CPTCustomer
        CPTCustomerServed
        CPTDVDSentHigh
        CPTDVDSentMedium
        CPTDVDSentLow
        PrioritySum
        CPTCustomerPartialServed
        CPTCustomerMustServed
        CPTCustomerNoServed
        CPTCustomerNoServedSuspended
        CPTCustomerNoServedNoCredit
        CPTCustomerNoServedAtHome
        CPTCustomerNoServedNotFindDVD
        CPTCustomerNotServedAttributedRanktoolow
        CPTCustomerNoServedWishlistNormEmpty
        CPTCustomerNoServedWishlistNormLess20
        CPTCustomerNoServedWishlistAdultEmpty
        CPTCustomerNoServedWishlistAdultLess20
        CPTDVDAvailable
        CPTDVDSEND
        CPTDVDASK
        CPTDVDSENDADULT
        CPTDVDSENDNORM
        CPTDVDSENDCOMPADULT
        CPTDVDSENDCOMPNORM
        CPTERROR


    End Enum

    Public EndTime As DateTime

    Private _LstStat As Dictionary(Of TypeStat, Integer) = New Dictionary(Of TypeStat, Integer)

    Public Sub clear()
        _LstStat.Clear()
    End Sub

    Public Property CptCustomer() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomer)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTCustomer, value)
        End Set
    End Property

    Public Property CptCustomerMustServed() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerMustServed)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerMustServed, value)

        End Set
    End Property
    Public Property CptCustomerServed() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerServed)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerServed, value)

        End Set
    End Property



    Public Property CptCustomerNoServed() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServed)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerNoServed, value)

        End Set
    End Property

    Public Property CptCustomerNoServedSuspended() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServedSuspended)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerNoServedSuspended, value)

        End Set
    End Property

    Public Property CptCustomerNoServedNoCredit() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServedNoCredit)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerNoServedNoCredit, value)

        End Set
    End Property

    Public Property CptCustomerNoServedAtHome() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServedAtHome)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerNoServedAtHome, value)

        End Set
    End Property

    Public Property CptCustomerNoServedNotFindDVD() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServedNotFindDVD)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerNoServedNotFindDVD, value)

        End Set
    End Property

    Public Property CPTCustomerPartialServed() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerPartialServed)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTCustomerPartialServed, value)
        End Set
    End Property

    Public Property CPTCustomerNotServedAttributedRanktoolow() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNotServedAttributedRanktoolow)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTCustomerNotServedAttributedRanktoolow, value)
        End Set
    End Property

    Public Property CptDVDAvailable() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDAvailable)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTDVDAvailable, value)

        End Set
    End Property
    Public Property CptDVDask() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDASK)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTDVDASK, value)

        End Set
    End Property

    Public Property CptDVDSend() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDSEND)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTDVDSEND, value)

        End Set
    End Property

    Public Property CptDVDSendNorm() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDSENDNORM)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTDVDSENDNORM, value)

        End Set
    End Property

    Public Property CptDVDSendAdult() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDSENDADULT)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTDVDSENDADULT, value)

        End Set
    End Property

    Public Property CptDVDSendCompNorm() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDSENDCOMPNORM)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTDVDSENDCOMPNORM, value)

        End Set
    End Property

    Public Property CptDVDSendCompAdult() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDSENDCOMPADULT)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTDVDSENDCOMPADULT, value)

        End Set
    End Property

    Public Property CptDVDWishlistNormEmpty() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServedWishlistNormEmpty)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerNoServedWishlistNormEmpty, value)

        End Set
    End Property

    Public Property CptDVDWishlistNormLess20() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServedWishlistNormLess20)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTCustomerNoServedWishlistNormLess20, value)
        End Set
    End Property

    Public Property CptDVDWishlistAdultEmpty() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServedWishlistAdultEmpty)
        End Get
        Set(ByVal value As Integer)

            SetValue(TypeStat.CPTCustomerNoServedWishlistAdultEmpty, value)

        End Set
    End Property

    Public Property CptDVDWishlistAdultLess20() As Integer
        Get
            Return GetValue(TypeStat.CPTCustomerNoServedWishlistAdultLess20)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTCustomerNoServedWishlistAdultLess20, value)
        End Set
    End Property

    Public Property CPTDVDSentHigh() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDSentHigh)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTDVDSentHigh, value)
        End Set
    End Property

    Public Property CPTDVDSentMedium() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDSentMedium)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTDVDSentMedium, value)
        End Set
    End Property

    Public Property CPTDVDSentLow() As Integer
        Get
            Return GetValue(TypeStat.CPTDVDSentLow)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.CPTDVDSentLow, value)
        End Set
    End Property

    Public Property PrioritySum() As Integer
        Get
            Return GetValue(TypeStat.PrioritySum)
        End Get
        Set(ByVal value As Integer)
            SetValue(TypeStat.PrioritySum, value)
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

    Public Sub addPriority(ByRef CustomerStat As PlushData.Customer_stat, ByVal priority As Integer)

        PrioritySum += priority
        Select Case priority

            Case StatAbo.Priority.HIGH
                CustomerStat.dvd_highsent += 1
                CPTDVDSentHigh += 1
            Case StatAbo.Priority.MEDIUM
                CustomerStat.dvd_mediumsent += 1
                CPTDVDSentMedium += 1
            Case StatAbo.Priority.LOW
                CustomerStat.dvd_lowsent += 1
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
            rate = (CptCustomerServed / (CptCustomerMustServed)) * 100
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

    Public Function StrUpdateStat(ByVal aboprocess_id As Integer) As String

        Dim SQLTxt As String
        '   EndTime = Now()
        SQLTxt = "update aboprocess_stats set " & _
          "date_end = now()" & _
          ",total_customers = " & CptCustomer & _
          ",total_dvd_available = " & CptDVDAvailable & _
          ",cust_served = " & CptCustomerServed & _
          ",cust_not_served = " & CptCustomerNoServed & _
          ", dvd_norm_to_send = " & CptDVDSendNorm & _
          ", dvd_adult_to_send = " & CptDVDSendAdult & _
          ",dvd_norm_compensation = " & CptDVDSendCompNorm & _
          ", dvd_adult_compensation = " & CptDVDSendCompAdult & _
          ", notserved_nocredit = " & CptCustomerNoServedNoCredit & _
          ", notserved_nodvdfound = " & CptCustomerNoServedNotFindDVD & _
          ", notserved_attributed_ranktoolow = " & CPTCustomerNotServedAttributedRanktoolow & _
          ", notserved_suspended = " & CptCustomerNoServedSuspended & _
          ", notserved_too_many_at_home = " & CptCustomerNoServedAtHome & _
          ", rate_dvd_served = " & GetRate_DVD_Served() & _
          ", rate_cust_served = " & GetRate_Cust_Served() & _
          ",metrics_priority = " & GetMetricsFormat(GetMetricsPriority) & _
          ",wishlist_normempty = " & CptDVDWishlistNormEmpty & _
          ",wishlist_normless20 = " & CptDVDWishlistNormLess20 & _
          ",wishlist_adultempty = " & CptDVDWishlistAdultEmpty & _
          ",wishlist_adultless20 =" & CptDVDWishlistAdultLess20 & _
          ",dvd_asked = " & CptDVDask & _
          ",dvd_sent = " & CptDVDSend & _
          ",dvd_highsent = " & CPTDVDSentHigh & _
          ",dvd_mediumsent = " & CPTDVDSentMedium & _
          ",dvd_lowsent = " & CPTDVDSentLow & _
          ",cpterror = " & CPTError & _
          ",must_served = " & CptCustomerMustServed & _
          " where aboprocess_id = " & aboprocess_id


        Return SQLTxt

    End Function
    Public Function StrInsertStat(ByVal dateStart As DateTime) As String

        Dim SQLTxt As String
        '   EndTime = Now()
        SQLTxt = "insert into aboprocess_stats (date_start,date_end,total_customers,total_dvd_available, " & _
          "cust_served, cust_not_served, dvd_norm_to_send, dvd_adult_to_send," & _
          "dvd_norm_compensation, dvd_adult_compensation, notserved_nocredit, notserved_nodvdfound,notserved_attributed_ranktoolow, " & _
          " notserved_suspended, notserved_too_many_at_home, rate_dvd_served, rate_cust_served,metrics_priority," & _
          " wishlist_normempty,wishlist_normless20,wishlist_adultempty,wishlist_adultless20,dvd_asked,dvd_sent,dvd_highsent," & _
          "dvd_mediumsent,dvd_lowsent,cpterror,must_served " & _
          ") values ( now(),now()," & CptCustomer & "," & _
          CptDVDAvailable & "," & CptCustomerServed & "," & _
          CptCustomerNoServed & "," & CptDVDSendNorm & "," & _
          CptDVDSendAdult & "," & CptDVDSendCompNorm & "," & _
          CptDVDSendCompAdult & "," & CptCustomerNoServedNoCredit & "," & CptCustomerNoServedNotFindDVD & "," & CPTCustomerNotServedAttributedRanktoolow & "," & _
          CptCustomerNoServedSuspended & "," & CptCustomerNoServedAtHome & "," & _
          GetRate_DVD_Served() & "," & GetRate_Cust_Served() & _
          "," & GetMetricsFormat(GetMetricsPriority) & "," & CptDVDWishlistNormEmpty & "," & CptDVDWishlistNormLess20 & "," & _
          CptDVDWishlistAdultEmpty & "," & CptDVDWishlistAdultLess20 & "," & CptDVDask & "," & CptDVDSend & "," & CPTDVDSentHigh & "," & _
          CPTDVDSentMedium & "," & CPTDVDSentLow & "," & CPTError & "," & CptCustomerMustServed & ")"

        Return SQLTxt

    End Function

End Class
