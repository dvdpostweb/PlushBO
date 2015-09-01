Module start
    Private Function GetKey() As String
        Dim key As String
        key = Configuration.ConfigurationManager.AppSettings("KEY_EXEC")

        Return key
    End Function

    Private Function GetTimeOut() As Integer
        Dim key As Integer
        key = Configuration.ConfigurationManager.AppSettings("KEY_TIMEOUTMIN")
        Return key
    End Function
    Private Sub LaunchMappingFolder()
        Process.Start("connectBizkeys.bat")
    End Sub
    Private Function isvalidArgument(ByVal cmdArgs() As String) As String
        If cmdArgs.Length > 0 AndAlso cmdArgs.Length < 3 Then
            If cmdArgs(0) = GetKey() Then
                If cmdArgs(1) = "prod" Or cmdArgs(1) = "test" Then
                    Return cmdArgs(1)
                Else
                    Return String.Empty
                End If
            Else
                Return String.Empty
            End If
        Else
            Return String.Empty
        End If

    End Function
    Function Main(ByVal cmdArgs() As String) As Integer

        Dim env As String

        env = isvalidArgument(cmdArgs)
        Try
            If env <> String.Empty Then
                PlushData.clsSession.isBatch = True
                PlushData.clsSession.user_id = 0
                PlushData.clsConnection.typeEnv = env
                PlushData.clsSession.isEnvTest = env = "test"
                PlushData.clsConnection.timeoutMIN = GetTimeOut()

                LaunchMappingFolder()

                Dim clscust As New PlushBuziness.ClsCustomers()

                clscust.ReconductionOgone(PlushData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionOgone(PlushData.ClsCustomersData.Country.NEDERLANDS)

                'clscust.ReconductionOgoneADULTSVOD(PlushData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionOgoneADULTSVOD(PlushData.ClsCustomersData.Country.NEDERLANDS)
                'clscust.ReconductionOgoneADULTSVOD(PlushData.ClsCustomersData.Country.LUXEMBOURG)

                clscust.ChangeCard_customers(PlushData.ClsCustomersData.Country.BELGIUM)
                'clscust.ChangeCard_customers(PlushData.ClsCustomersData.Country.NEDERLANDS)

                'ogone reject payment for customer who pay after duration limit
                clscust.RejetFileOgone()

                'clscust.ReconductionDomiciliation(PlushData.ClsCustomersData.Country.BELGIUM)

                'clscust.ReconductionDomiciliationADULTSVOD(PlushData.ClsCustomersData.Country.BELGIUM)

                'clscust.ReconductionPhone(DvdPostData.ClsCustomersData.Country.BELGIQUE)
                'clscust.ReconductionPhone(DvdPostData.ClsCustomersData.Country.PAYSBAS)

                'clscust.ReconductionSms(DvdPostData.ClsCustomersData.Country.BELGIQUE)
                'clscust.ReconductionSms(DvdPostData.ClsCustomersData.Country.PAYSBAS)

                'clscust.ReconductionVirement(PlushData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionVirement(PlushData.ClsCustomersData.Country.NEDERLANDS)

                'clscust.ReconductionVirementADULTSVOD(PlushData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionVirementADULTSVOD(PlushData.ClsCustomersData.Country.NEDERLANDS)

                'PlushBuziness.ClsBankTransfer.print()

                Dim _OffLinePay As New PlushBuziness.clsOffLinePayments()
                _OffLinePay.ApplyAllTransitions()

                'PlushBuziness.ClsCredits.UpdateCreditMoreMonth()
                'Dim sql As String
                'Sql = DvdPostData.clsProductDvd.GetStepProductDisabled()
                'DvdPostData.clsConnection.ExecuteNonQuery(sql)

                PlushBuziness.clsOffLinePayments.matchingOffline()
                'DVDPostBuziness.ClsBankTransfer.matching()
                'clscust.CreateCustomersRotation()
                'Dim sql As String
                'call store procedure to calculate average of the duration of keeping dvdat home
                'Sql = PlushData.ClsPurchaseSale.GetInsertCreateRateRotationAbo()
                'PlushData.clsConnection.ExecuteNonQuery(sql)

                ' Dim cls As New DVDPostBuziness.ClsPurchaseSale
                ' cls.CreatePrevisionAchat()

                'calculate vod statistic
                'PlushBuziness.ClsVod.InsertStatVod()
                'clscust.UpdateDvd_at_Home()
                PlushBuziness.ClsVod.UpdateVodPrice()
                'PlushBuziness.ClsVod.UpdateSoonVod()

                'clscust.ReconductionPayPal(PlushData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionPayPal(PlushData.ClsCustomersData.Country.NEDERLANDS)

                'clscust.ReconductionPayPalADULTSVOD(PlushData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionPayPalADULTSVOD(PlushData.ClsCustomersData.Country.NEDERLANDS)

                'PPV
                Dim clsPPV As PlushBuziness.clsPPV = New PlushBuziness.clsPPV
                clsPPV.CreatePPVPaymentsManager(PlushData.ClsCustomersData.Country.BELGIUM, DateTime.Now.Date.AddDays(-1), DateTime.Now.Date)


            Else
                Console.WriteLine("Error Argument")
            End If

        Catch ex As Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Batch, ex)
        End Try

    End Function

End Module
