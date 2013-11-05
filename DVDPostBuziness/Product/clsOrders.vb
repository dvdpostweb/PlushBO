Public Class clsOrders
    Private Shared Function UpdateOrder(ByVal sql As String, ByVal orders_id As Integer, ByVal newStatus As PlushData.clsOdersStatusHistory.OrderStatusNew, ByVal oldStatus As PlushData.clsOdersStatusHistory.OrderStatusNew) As Boolean
        Dim updatedRows As Integer = PlushData.clsConnection.ExecuteNonQuery(sql)
        If Not updatedRows > 0 Then
        End If
        sql = PlushData.clsOdersStatusHistory.getUpdateStatusOrderHistory(orders_id, newStatus, oldStatus)
        updatedRows = PlushData.clsConnection.ExecuteNonQuery(sql)

        Return updatedRows > 0

    End Function
    Public Shared Function UpdateOrder(ByVal orders_id As Integer, ByVal newStatus As PlushData.clsOdersStatusHistory.OrderStatusNew, ByVal oldStatus As PlushData.clsOdersStatusHistory.OrderStatusNew) As Boolean
        Dim sql As String

        sql = PlushData.clsOdersStatusHistory.getUpdateStatusOrder(orders_id, newStatus)

        Return UpdateOrder(sql, orders_id, newStatus, oldStatus)
    End Function

    Public Shared Function UpdateOrder(ByVal orders_id As Integer, ByVal newStatus As PlushData.clsOdersStatusHistory.OrderStatusNew, ByVal oldStatus As PlushData.clsOdersStatusHistory.OrderStatusNew, ByVal products_id As Integer, ByVal dvdid As Integer) As Boolean
        Dim sql As String
        sql = PlushData.clsOdersStatusHistory.getUpdateStatusOrder(orders_id, newStatus, products_id, dvdid)
        Return UpdateOrder(sql, orders_id, newStatus, oldStatus)
    End Function

    Public Shared Function GetselectOrderComplaint_Inadmissible() As DataTable
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsOdersStatusHistory.GetselectOrderComplaint_Inadmissible()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function

    Public Shared Function getOrderOneMonthkDelay() As DataTable

        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsOdersStatusHistory.getSelectOrderOneMonthDelay()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Public Shared Function getOrderTwoWeekCheck() As DataTable

        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.clsOdersStatusHistory.getSelectOrderTwoWeekCheck()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
End Class
