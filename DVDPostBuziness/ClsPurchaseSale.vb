Public Class ClsPurchaseSale

    Public Function CreatePrevisionAchat() As Boolean
        Dim sql As String

        sql = PlushData.ClsPurchaseSale.GetInsertCreateRateRotationAbo()
        PlushData.clsConnection.ExecuteNonQuery(sql)

        sql = PlushData.ClsPurchaseSale.GetDeletePrevisionPurchaseCurrentdate()
        PlushData.clsConnection.ExecuteNonQuery(sql)

        sql = PlushData.ClsPurchaseSale.getInsertCreatePrevisionAchat("DVD_NORM")
        PlushData.clsConnection.ExecuteNonQuery(sql)

        Return True

    End Function

    Public Function ViewBreakSeries() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsPurchaseSale.GetSelectSeriesBreak()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Public Function ViewAlgoPurchasesOrderClosedCurrent() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsPurchaseSale.GetSelectCurrentOrdersClosedPurchase()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Public Function ViewAlgoPurchasesOrderCurrent() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsPurchaseSale.GetSelectCurrentOrdersPurchase()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function

    Public Function ViewAlgoPurchasesSalesByProduct(ByVal product_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsPurchaseSale.GetSelectViewPurchaseSaleByProducts(product_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Public Function ViewAlgoPurchase() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsPurchaseSale.GetSelectViewPurchase()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function

    Public Function ViewAlgoSale() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.ClsPurchaseSale.GetSelectViewSale()
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt
    End Function

    'Public Function ViewAlgo() As DataTable
    '    Dim sql As String
    '    Dim dt As DataTable

    '    sql = DvdPostData.ClsPurchaseSale.GetSelectViewPurchase()
    '    dt = DvdPostData.clsConnection.FillDataSet(sql)

    '    Return dt
    'End Function
End Class
