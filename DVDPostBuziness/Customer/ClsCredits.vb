Public Class ClsCredits

    Public Shared Sub RecalculCreditClient()
        Dim dt As DataTable
        Dim sql As String
        Dim credit_init As Integer
        Dim credit_current As Integer
        Dim creditFree_init As Integer
        Dim creditFree_current As Integer
        Dim customers_prec As Integer
        Dim customers_current As Integer
        Dim movement_free As Integer
        Dim movement_paid As Integer
        Dim index As Integer
        sql = PlushData.ClsCustomersData.GetLastReconductionCredityHistory()
        dt = PlushData.clsConnection.FillDataSet(sql)

        index = 0
        While index < dt.Rows.Count
            customers_current = dt.Rows(index)("customers_id")
            customers_prec = customers_current
            credit_init = dt.Rows(index)("credit") + dt.Rows(index)("quantity_free") + dt.Rows(index)("quantity_paid")
            creditFree_init = dt.Rows(index)("credit_free") + dt.Rows(index)("quantity_free")

            movement_free = 0
            movement_paid = 0
            index += 1

            While index < dt.Rows.Count AndAlso dt.Rows(index)("customers_id") = customers_prec
                customers_prec = dt.Rows(index)("customers_id")
                credit_current = credit_init + movement_free + movement_paid
                creditFree_current = creditFree_init + movement_free

                If creditFree_current <> dt.Rows(index)("credit_free") Then
                    dt.Rows(index)("credit_free") = creditFree_current
                End If

                If credit_current <> dt.Rows(index)("credit") Then
                    dt.Rows(index)("credit") = credit_current
                End If
                credit_init = credit_current
                creditFree_init = creditFree_current
                movement_free = dt.Rows(index)("quantity_free")
                movement_paid = dt.Rows(index)("quantity_paid")
                index += 1
            End While
        End While

        PlushData.clsConnection.UpdateDataTableInDB(dt, sql)
    End Sub

    'decrease credit if customer hold DVD at home next month
    Public Shared Sub UpdateCreditMoreMonth()
        Dim sql As String
        Dim dt As DataTable
        Dim customers_id As Integer
        Dim orders_id As Integer
        Dim isIllimitedAbo As Integer
        sql = PlushData.clsOdersStatusHistory.getUpdateCreditLostMoreMonth()
        dt = PlushData.clsConnection.FillDataSet(sql)

        PlushData.clsConnection.CreateTransaction(True)

        Try
            For Each dr As DataRow In dt.Rows

                customers_id = dr("customers_id")
                orders_id = dr("orders_id")
                isIllimitedAbo = PlushBuziness.ClsCustomers.isIllimitedaboByCustomers(customers_id)

                If Not isIllimitedAbo Then
                    sql = "UPDATE customers set customers_abo_dvd_credit = customers_abo_dvd_credit - 1  WHERE customers_id = " & customers_id
                    PlushData.clsConnection.ExecuteNonQuery(sql)

                    sql = PlushData.clsCreditHistory.GetInsertCreditHistory(-1, customers_id, PlushData.clsCreditHistory.ActionId.LONGTIME_DVD, False, orders_id)
                    PlushData.clsConnection.ExecuteNonQuery(sql, True)

                End If

            Next
            Dim cpt As Integer
            PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Batch, cpt)

        Catch ex As Exception
            PlushData.clsConnection.CancelBulkQuery()
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Batch, ex.Message)
        End Try


    End Sub


End Class
