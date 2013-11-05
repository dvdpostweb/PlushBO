Public Class clsCreditHistory

    Public Enum ActionId
        ABOPROCESS = 1
        PROCESSIN = 2
        DELETEORDER = 3
        FREERECONDUCTION = 4
        RECONDUCTION = 5
        FREEUPGRADE = 6
        INIT = 7
        MANUAL_CREDIT = 8
        PROMO_COMBINED = 9
        KDO = 10
        MANUAL_ASSIGN = 11
        VOD = 12
        VOD_MORE_IP = 13
        LONGTIME_DVD = 14
    End Enum

    Public Enum ActionValue
        ABOPROCESS = -1
        MANUAL_ASSIGN = -1
    End Enum

    Public Shared Function GetSelectCheckAnomalie() As String
        Dim sql As String

        sql = " select c.customers_abo_dvd_credit,ch.* from customers c " & _
               " join credit_history ch on c.customers_id = ch.customers_id " & _
               " join ( " & _
               "     select customers_id,max(id) id from credit_history group by customers_id " & _
               " ) xx on ch.id = xx.id " & _
               " where (ch.credit_paid + ch.credit_free + quantity_paid + quantity_free) <> c.customers_abo_dvd_credit " & _
               " and c.customers_abo = 1"
        Return sql
    End Function

    Public Shared Function GetCreditHistory() 'ByVal startDate As DateTime, ByVal endDate As DateTime) As String
        Dim sql As String
        sql = " select ch.id, ch.customers_id,ch.credit_paid + ch.quantity_paid + quantity_free + credit_free total," & _
              " ch.credit_paid + ch.quantity_paid total_paid," & _
              " ch.credit_paid, ch.quantity_paid, " & _
              " ch.user_modified, ch.date_added, ca.name as action_name," & _
              " quantity_free + credit_free total_free , quantity_free , credit_free , orders_id " & _
        "from credit_history ch left join credit_action ca on ca.id = ch.credit_action_id "
        Return sql
    End Function
    Private Shared Function GetAllCreditHistory(ByVal customers_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable
        sql = "select ch.*,0 total from credit_history ch where customers_id = " & customers_id & " order by 1"

        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Private Shared Sub saveData(ByVal dr As DataRow)

        Dim sql As String
        Dim strorder_id As String = "null"
        Dim strAbotype As String = "null"

        If dr("orders_id") IsNot DBNull.Value Then
            strorder_id = dr("orders_id")
        End If

        If dr("abo_type") IsNot DBNull.Value Then
            strAbotype = dr("abo_type")
        End If
        sql = "insert credit_history_new values(" & _
          dr("id") & "," & _
          dr("customers_id") & "," & _
          dr("credit_action_id") & "," & _
          dr("credit_paid") & "," & _
          dr("credit_free") & "," & _
          dr("total") & "," & _
          dr("user_modified") & ",'" & _
          PlushTools.ClsDate.formatDateTimeDB(dr("date_added")) & "'," & _
          dr("quantity_free") & "," & _
          dr("quantity_paid") & "," & _
         strorder_id & "," & _
         strAbotype & ")"


        PlushData.clsConnection.ExecuteNonQuery(sql)

    End Sub
    Public Shared Sub GetUpdateAllCreditHistory(ByVal customers_id As Integer, ByVal combined As Boolean)
        Dim dt As DataTable
        Dim dt_result As DataTable
        Dim dr_result As DataRow
        Dim dr_prec As DataRow = Nothing
        dt = GetAllCreditHistory(customers_id)

        dt_result = dt.Clone()
        For Each dr As DataRow In dt.Rows

            If dr("credit_action_id") = ActionId.INIT Then
                dr_result = dt_result.NewRow()
                dr_result("id") = dr("id")
                dr_result("customers_id") = dr("customers_id")
                dr_result("credit_action_id") = dr("credit_action_id")
                dr_result("credit_paid") = dr("credit_paid")
                dr_result("user_modified") = dr("user_modified")
                dr_result("date_added") = dr("date_added")
                dr_result("quantity_free") = dr("quantity_free")
                dr_result("quantity_paid") = dr("quantity_paid")
                dr_result("orders_id") = dr("orders_id")
                dr_result("credit_free") = dr("credit_free")
                dr_result("abo_type") = dr("abo_type")



            Else
                dr_result = dt_result.NewRow()
                If dr_prec Is Nothing Then
                    dr_prec = dt_result.NewRow()
                    dr_prec("id") = dr("id")
                    dr_prec("customers_id") = dr("customers_id")
                    dr_prec("credit_action_id") = ActionId.INIT
                    dr_prec("credit_paid") = dr("credit_paid")
                    dr_prec("user_modified") = 0
                    dr_prec("date_added") = Now()
                    dr_prec("quantity_free") = 0
                    dr_prec("quantity_paid") = 0
                    dr_prec("orders_id") = DBNull.Value
                    dr_prec("credit_free") = dr("credit_free")
                    dr_prec("abo_type") = DBNull.Value
                End If
                getCredit(dr_prec, dr, dr_result, combined)
            End If
            dr_result("total") = dr_result("quantity_free") + dr_result("quantity_paid") + dr_result("credit_free") + dr_result("credit_paid")
            dt_result.Rows.Add(dr_result)
            dr_prec = dr_result
            saveData(dr_result)
        Next
        dt_result.Dispose()
    End Sub

    Public Shared Function GetInsertCreditHistory(ByVal quantity As Integer, ByVal customers_id As Integer, ByVal action As ActionId, ByVal combined As Boolean, Optional ByVal orders_id As Integer = Nothing, Optional ByVal oldCredit As Integer = Nothing) As String
        Dim sql As String
        '  Dim credit As String

        ' sql = "insert into credit_history (customers_id , credit_action_id ,credit , added_paid , user_modified , quantity_free , credit_free)" & _
        '                   "  values (" & customersId & ", " & action & " ,   ( " & GetCustomerCredit(customersId) & ")  , " & quantity & ", " & clsSession.user_id & ")"

        'If oldCredit = Nothing Then
        '    credit = GetCustomerCredit(customers_id)
        'Else
        '    credit = oldCredit
        'End If


        sql = "insert into credit_history (customers_id , credit_action_id , user_modified,credit_paid , quantity_paid ,  quantity_free , credit_free , orders_id )" & _
              " values (" & customers_id & " , " & action & " , " & clsSession.user_id & "," & GetCreditPaidOrFree(customers_id, quantity, action, orders_id, combined)


        If orders_id <> Nothing Then
            sql = sql + " , " & orders_id & ")"
        Else
            sql = sql + " , null )"
        End If

        Return sql
    End Function
    Public Shared Function GetInsertNPPCreditHistory(ByVal quantity As Integer, ByVal max_dvd As Integer, ByVal customers_id As Integer, ByVal action As ActionId, ByVal combined As Boolean, Optional ByVal orders_id As Integer = Nothing, Optional ByVal oldCredit As Integer = Nothing) As String
        Dim sql As String

        sql = "insert into credit_history (customers_id , credit_action_id , user_modified,credit_paid , quantity_paid ,  quantity_free , max_dvd, credit_free , orders_id )" & _
              " values (" & customers_id & " , " & action & " , " & clsSession.user_id & "," & GetCreditPaidOrFree(customers_id, quantity, action, orders_id, combined)

        If orders_id <> Nothing Then
            sql = sql + " , " & orders_id & ")"
        Else
            sql = sql + " , null )"
        End If

        Return sql
    End Function
    Public Shared Function GetLastCreditHistory(ByVal customers_id As Integer) As String
        Dim sql As String

        'sql = " select ch.* from credit_history ch join " & _
        '      "(select customers_id,max(id) id from credit_history where customers_id = " & customers_id & " group by customers_id) max_credit " & _
        '     " on ch.customers_id = max_credit.customers_id and ch.id = max_credit.id "

        sql = "select * from credit_history where customers_id = " & customers_id & " order by id desc limit 1"
        Return sql

    End Function
    Public Shared Function GetCustomerCredit(ByVal customersId As Integer) As String
        'Dim credit As Object
        Dim sql As String = "select customers_abo_dvd_credit from customers where customers_id = " & customersId
        'credit = DvdPostData.clsConnection.ExecuteScalar(sql)
        Return sql 'CType(credit, Integer)
    End Function


    Public Shared Function GetCreditHistoryByCust(ByVal customers_id As Integer) As String
        Dim sql
        sql = GetCreditHistory() + " where customers_id  = " & customers_id & " order by ch.id desc"
        Return sql
    End Function

    Private Shared Sub getCredit(ByVal dr_prec As DataRow, ByVal dr_current As DataRow, ByRef dr_new As DataRow, ByVal combined As Boolean)
        Dim credit_free As Integer
        Dim quantity_free As Integer
        Dim credit_Paid As Integer
        Dim quantity_Paid As Integer

        Dim SumCreditQuantFree As Integer
        Dim SumCreditPaid As Integer

        credit_free = dr_prec("credit_free")
        quantity_free = dr_prec("quantity_free")
        credit_Paid = dr_prec("credit_paid")
        quantity_Paid = dr_prec("quantity_paid")

        SumCreditQuantFree = credit_free + quantity_free
        SumCreditPaid = credit_Paid + quantity_Paid


        dr_new("id") = dr_current("id")
        dr_new("customers_id") = dr_current("customers_id")
        dr_new("credit_action_id") = dr_current("credit_action_id")
        dr_new("credit_paid") = SumCreditPaid
        dr_new("user_modified") = dr_current("user_modified")
        dr_new("date_added") = dr_current("date_added")
        dr_new("quantity_free") = dr_current("quantity_free")
        dr_new("quantity_paid") = dr_current("quantity_paid")
        dr_new("orders_id") = dr_current("orders_id")
        dr_new("credit_free") = SumCreditQuantFree
        dr_new("abo_type") = dr_current("abo_type")

        Select Case dr_current("credit_action_id")
            Case ActionId.FREERECONDUCTION, ActionId.FREEUPGRADE
                If dr_current("quantity_free") <> 0 Then
                    dr_new("quantity_free") = dr_current("quantity_free")
                Else
                    dr_new("quantity_free") = dr_current("quantity_paid")
                End If
                dr_new("quantity_paid") = 0

            Case ActionId.DELETEORDER

                If credit_free <> 0 Then
                    dr_new("quantity_free") = dr_current("quantity_free")
                    dr_new("quantity_paid") = 0
                Else
                    dr_new("quantity_paid") = dr_current("quantity_paid")
                    dr_new("quantity_free") = 0
                End If
            Case ActionId.MANUAL_CREDIT
                dr_new("quantity_free") = dr_current("quantity_free")
                dr_new("quantity_paid") = 0

            Case ActionId.ABOPROCESS, ActionId.MANUAL_ASSIGN, ActionId.LONGTIME_DVD
                If SumCreditQuantFree > 0 Then
                    If dr_current("quantity_free") <> 0 Then
                        dr_new("quantity_free") = dr_current("quantity_free")
                    Else
                        dr_new("quantity_free") = dr_current("quantity_paid")
                    End If
                    dr_new("quantity_paid") = 0
                Else
                    If dr_current("quantity_paid") <> 0 Then
                        dr_new("quantity_paid") = dr_current("quantity_paid")
                    Else
                        dr_new("quantity_paid") = dr_current("quantity_free")
                    End If
                    dr_new("quantity_free") = 0
                End If

            Case ActionId.RECONDUCTION
                If Not combined Then
                    dr_new("credit_paid") = 0
                End If
                dr_new("quantity_paid") = dr_current("quantity_paid")
                dr_new("quantity_free") = 0
        End Select

    End Sub

    Private Shared Function GetCreditPaidOrFree(ByVal customers_id As Integer, ByVal quantity_credit As Integer, ByVal action As ActionId, ByVal orders_id As Integer, ByVal combined As Boolean) As String
        Dim dt As DataTable
        Dim insertField As String = ""
        Dim SumCreditQuantFree As Integer
        Dim SumCreditPaid As Integer
        Dim credit_free As Integer
        Dim quantity_free As Integer
        Dim credit_Paid As Integer
        Dim quantity_Paid As Integer
        'dt = DvdPostData.clsConnection.FillDataSet(GetCreditHistoryByCust(customers_id) + " limit 1") '"select ( credit_free + quantity_free) from credit_history where customers_id = " & customers_id & " order by id desc limit 1 ")
        dt = PlushData.clsConnection.FillDataSet(GetLastCreditHistory(customers_id))

        If dt.Rows.Count = 0 Then
            credit_free = 0
            quantity_free = 0
        Else
            credit_free = dt.Rows(0)("credit_free")
            quantity_free = dt.Rows(0)("quantity_free")
            credit_Paid = dt.Rows(0)("credit_paid")
            quantity_Paid = dt.Rows(0)("quantity_paid")
        End If

        SumCreditQuantFree = credit_free + quantity_free
        SumCreditPaid = credit_Paid + quantity_Paid

        Dim strFree As String = SumCreditPaid & ",0," & quantity_credit & "," & SumCreditQuantFree
        Dim strpaid As String = SumCreditPaid & "," & quantity_credit & ",0," & SumCreditQuantFree

        Select Case action
            Case ActionId.FREERECONDUCTION, ActionId.FREEUPGRADE
                insertField = strFree

            Case ActionId.DELETEORDER
                credit_free = GetOrdersFree(customers_id, orders_id)
                If credit_free > 0 Then
                    insertField = strFree
                Else
                    insertField = strpaid
                End If
            Case ActionId.MANUAL_CREDIT
                If quantity_credit > 0 Then
                    insertField = strFree
                Else
                    If SumCreditQuantFree > 0 Then
                        insertField = strFree
                    Else
                        insertField = strpaid
                    End If
                End If

            Case ActionId.ABOPROCESS, ActionId.MANUAL_ASSIGN, ActionId.LONGTIME_DVD
                If SumCreditQuantFree > 0 Then
                    insertField = strFree
                Else
                    insertField = strpaid
                End If

            Case ActionId.RECONDUCTION
                If Not combined Then
                    insertField = "0," & quantity_credit & ",0,0"
                Else
                    insertField = strpaid
                End If

        End Select



        Return insertField
    End Function


    Public Shared Function GetOrdersIdCreditHistory(ByVal customers_id As Integer, ByVal orders_id As Integer) As String
        Dim sql As String = "select credit_free from credit_history where customers_id = " & customers_id & "  and orders_id = " & orders_id & " order by id desc limit 1 "
        Return sql
    End Function


    Private Shared Function GetOrdersFree(ByVal customers_id As Integer, ByVal orders_id As Integer) As Integer
        Dim credit_free As Integer
        credit_free = PlushData.clsConnection.ExecuteScalar(GetOrdersIdCreditHistory(customers_id, orders_id))

        If credit_free > 0 Then
            Return credit_free
        End If

        Return Nothing

    End Function


End Class
