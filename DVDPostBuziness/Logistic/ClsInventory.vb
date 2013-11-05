Public Class ClsInventory

    Public Shared Function isAboprocessRun() As Boolean
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.AboProcessData.IsAboprocessRun()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt.Rows.Count > 0

    End Function

    Public Shared Function isNPP(ByVal customers_id As String) As Boolean
        Dim sql As String
        Dim dt As DataTable
        sql = PlushData.ClsCustomersData.GetSelectNPPCreditByCustomer(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt.Rows(0)(0) > 0

    End Function

End Class
