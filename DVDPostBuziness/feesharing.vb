Public Class feesharing

    Public Function batchFeeSharing() As String
        Dim dt As DataTable
        Dim dr As DataRow
        Dim sql As String
        Dim str As String = String.Empty
        Dim barcode As String
        Dim dvdRented As Integer = 0
        Dim totalfee As Integer = 0
        Dim datePurchased As String
        Dim OdersProductsId As Integer
        Dim dateNow As String = formatdateFeeSharing(Date.Now)
        Dim updateValues As String = String.Empty
        Dim ok As Boolean


        sql = PlushData.clsFeeSharing.getOrdersInFeeSharing()
        dt = PlushData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            Try
                PlushData.clsConnection.CreateTransaction(True)

                str = "H" & vbTab & "311010" & vbTab & "1030" & vbTab & dateNow & vbTab & TimeString() & vbTab & "CEGEN V1.00 09/30/2003" & vbTab & "11.00" & vbLf
                For Each dr In dt.Rows
                    OdersProductsId = dr("orders_products_id")

                    datePurchased = formatdateFeeSharing(dr("date_purchased"))

                    barcode = GetBarCodeFeeSharing(CType(dr("products_id"), Integer), CType(dr("products_dvd"), Integer))

                    If barcode <> "" Then
                        str += "311010" & vbTab
                        str += dr("delivery_postcode") & vbTab
                        str += barcode & vbTab
                        str += Replace(dr("products_name"), "'", " ") & GetSubTitleLanguage(dr("products_language_fr"), dr("products_undertitle_nl")) & vbTab
                        str += datePurchased + vbTab
                        str += dateNow & vbTab
                        str += "0" & vbTab
                        str += "0" & vbTab
                        str += "1" & vbTab
                        str += "0" & vbTab
                        str += "120" & vbTab
                        str += "0" & vbTab
                        str += "0" & vbTab
                        str += "0" & vbTab
                        str += dr("products_id") & vbTab
                        str += "RENT" & vbTab
                        str += "0" & vbTab
                        str += "A" & vbTab
                        str += "DVD" & vbTab
                        str += "0" & vbTab
                        str += "0" & vbTab
                        str += "0" & vbLf

                        dvdRented += 1
                        totalfee += 120

                        sql = PlushData.clsFeeSharing.updateOdersProductsFee(OdersProductsId, PlushData.clsFeeSharing.feeSharingStudio.UNIVERSAL_GLOBAL_DATA)
                        PlushData.clsConnection.ExecuteNonQuery(sql)

                    End If
                Next
                str = str & "T" & vbTab & "311010" & vbTab & "1030" & vbTab & dvdRented & vbTab & dvdRented & vbTab & "0" & vbTab & totalfee & vbTab & "0" & vbLf

                sql = PlushData.clsFeeSharing.getInsertFeeSharing(str, totalfee)
                PlushData.clsConnection.ExecuteNonQuery(sql)

                ok = PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Feesharing, dvdRented)

                Return str
            Catch ex As Exception
                clsMsgError.MsgBox(ex.Message)
                clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Feesharing, ex)
            End Try

        Else
            Return str = String.Empty
        End If
        Return str
    End Function


    Private Function GetSubTitleLanguage(ByVal products_Language As Integer, ByVal products_undertitle As Integer) As String
        Dim subTitle As String
        If products_Language = 1 And products_undertitle = 0 Then
            subTitle = " fr"
        Else
            subTitle = ""
        End If
        Return subTitle + " DVD"
    End Function


    Private Function GetBarCodeFeeSharing(ByVal products_id As Integer, ByVal products_dvdid As Integer) As String
        Dim bc As String
        If Not IsNumeric(products_id) Then
            Return ""
        End If
        If Not IsNumeric(products_dvdid) Then
            Return ""
        End If

        bc = "111"
        If (products_id >= 0 And products_id < 10) Then
            bc = bc & "00000"
            bc = bc & products_id
        End If
        If (products_id >= 10 And products_id < 100) Then
            bc = bc & "0000"
            bc = bc & products_id
        End If
        If (products_id >= 100 And products_id < 1000) Then
            bc = bc & "000"
            bc = bc & products_id
        End If
        If (products_id >= 1000 And products_id < 10000) Then
            bc = bc & "00"
            bc = bc & products_id
        End If
        If (products_id >= 10000 And products_id < 100000) Then
            bc = bc & "0"
            bc = bc & products_id
        End If
        If (products_id >= 100000 And products_id < 1000000) Then
            bc = bc & "0"
            bc = bc & products_id
        End If
        If (products_dvdid >= 0 And products_dvdid < 10) Then
            bc = bc & "00"
            bc = bc & products_dvdid
        End If
        If (products_dvdid >= 10 And products_dvdid < 100) Then
            bc = bc & "0"
            bc = bc & products_dvdid
        End If
        If (products_dvdid >= 100 And products_dvdid < 1000) Then
            bc = bc & products_dvdid
        End If
        Dim y As Integer = Int(Mid(bc, 1, 1)) + Int(Mid(bc, 3, 1)) + Int(Mid(bc, 5, 1)) + Int(Mid(bc, 7, 1)) + Int(Mid(bc, 9, 1)) + Int(Mid(bc, 11, 1))
        Dim x As Integer = Int(Mid(bc, 2, 1)) + Int(Mid(bc, 4, 1)) + Int(Mid(bc, 6, 1)) + Int(Mid(bc, 8, 1)) + Int(Mid(bc, 10, 1)) + Int(Mid(bc, 12, 1))
        Dim z As Integer = (3 * x) + y
        Dim intmod As Integer = z Mod 10
        Dim check As Integer = 10 - intmod
        If check = 10 Then
            bc = bc & "0"
        Else
            bc = bc & check
        End If

        Return bc
    End Function

    Private Function formatdateFeeSharing(ByVal d As DateTime) As String
        Return d.ToString("MM/dd/yyyy")
    End Function

    Public Function processMovieMax(ByVal dStart As DateTime, ByVal dEnd As DateTime) As Boolean
        Dim dt As DataTable
        Dim sql As String

        Dim dr As DataRow
        Dim valueInsert As String = String.Empty
        Dim strTime As Integer = 0
        Dim titelnr As Integer
        Dim orders_products_id As Integer
        Dim productsDvdId As Integer
        Dim rate As String
        Dim updateValues As String = String.Empty
        Dim ok As Boolean
        Dim result As String

        sql = PlushData.clsFeeSharing.getFeeSharingMovieMaxProccess(dStart, dEnd)
        dt = PlushData.clsConnection.FillDataSet(sql)

        result = CheckValidMovieMaxInfo(dt)
        If result <> String.Empty Then
            MsgBox("Error Id moviemax is null (" & result & ")", MsgBoxStyle.Critical)
            Return False
        End If
        PlushData.clsConnection.CreateTransaction(True)
        Try
            For Each dr In dt.Rows

                orders_products_id = dr("orders_products_id")
                titelnr = dr("titelnr")
                rate = calculRate(dr("percentage"), dr("date_purchased"), dr("products_date_available"))
                productsDvdId = GetproductsDvdIdMovieMax(dr("products_dvd"))
                sql = PlushData.clsFeeSharing.getInsertValue(dr("date_purchased"), strTime, titelnr, rate, productsDvdId)
                PlushData.clsConnection.ExecuteNonQuery(sql)
                sql = PlushData.clsFeeSharing.updateOdersProductsFee(orders_products_id, PlushData.clsFeeSharing.feeSharingStudio.MOVIEMAX)
                PlushData.clsConnection.ExecuteNonQuery(sql)
                strTime = strTime + 1
            Next
            Dim cpt As Integer

            ok = PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Feesharing, cpt)
        Catch ex As Exception
            clsMsgError.MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Feesharing, ex)

        End Try

        Return ok

    End Function


    Private Function calculRate(ByVal pct As Integer, ByVal date_purchased As DateTime, ByVal products_date_available As DateTime) As String

        Dim rate As String
        Dim intervalDate As Integer = DateDiff(DateInterval.Month, date_purchased, products_date_available)

        Select Case pct
            Case 35
                If intervalDate < 3 Then
                    rate = "   2.86"
                Else
                    rate = "   2.00"
                End If


            Case 40
                If intervalDate < 3 Then
                    rate = "   2.50"
                Else
                    rate = "   1.75"
                End If


            Case 42
                If intervalDate < 3 Then
                    rate = "   2.38"
                Else
                    rate = "   1.67"
                End If
        End Select

        Return rate
    End Function

    Private Function GetproductsDvdIdMovieMax(ByVal products_dvdid As String) As String
        Dim productsDvdId As String = ""

        If products_dvdid < 10 Then
            productsDvdId = "00" & products_dvdid
        End If
        If products_dvdid > 9 And products_dvdid < 100 Then
            productsDvdId = "0" & products_dvdid
        End If
        If products_dvdid > 99 And products_dvdid < 1000 Then
            productsDvdId = products_dvdid
        End If

        Return productsDvdId
    End Function

    Private Function CheckValidMovieMaxInfo(ByVal dt As DataTable) As String
        Dim result As String = String.Empty
        Dim oldProduct As Integer = 0
        ' product_id chez moviemax (titlenr) 
        Dim view As New DataView(dt, "titelnr = 0 ", "", DataViewRowState.CurrentRows)
        If view.Count > 0 Then
            For Each drv As DataRowView In view
                If oldProduct <> drv("products_id") Then
                    result += drv("products_id") & ","
                End If
                oldProduct = drv("products_id")
            Next
        End If

        Return result
    End Function


    Public Function BatchMovieMax(ByVal date_moviemax As Date) As String
        Dim dt As DataTable
        Dim sql As String
        Dim dr As DataRow
        Dim outPut As String = String.Empty

        sql = PlushData.clsFeeSharing.GetMovieMaxOutPut(date_moviemax)
        dt = PlushData.clsConnection.FillDataSet(sql)

        For Each dr In dt.Rows
            outPut = outPut & ControlChars.Quote & dr("field1") & ControlChars.Quote & ","
            outPut = outPut & ControlChars.Quote & dr("field2") & ControlChars.Quote & ","
            outPut = outPut & ControlChars.Quote & Year(dr("date"))
            If Month(dr("date")) < 10 Then
                outPut = outPut & "0" & Month(dr("date"))
            Else
                outPut = outPut & Month(dr("date"))
            End If
            If DateAndTime.Day(dr("date")) < 10 Then
                outPut = outPut & "0" & DateAndTime.Day(dr("date")) & ControlChars.Quote & ","
            Else
                outPut = outPut & DateAndTime.Day(dr("date")) & ControlChars.Quote & ","
            End If
            outPut = outPut & ControlChars.Quote & dr("time").ToString & ControlChars.Quote & ","
            outPut = outPut & ControlChars.Quote & dr("titlenr") & ControlChars.Quote & ","
            outPut = outPut & ControlChars.Quote & dr("field6") & ControlChars.Quote & ","
            outPut = outPut & ControlChars.Quote & dr("field7") & ControlChars.Quote & ","
            outPut = outPut & ControlChars.Quote & dr("field8") & ControlChars.Quote & ","
            outPut = outPut & ControlChars.Quote & dr("field9") & ControlChars.Quote & vbLf
        Next

        Return outPut

    End Function

End Class
