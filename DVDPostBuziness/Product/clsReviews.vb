Public Class clsReviews
    Public Shared Function GetReviewNoManaged() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectReviewsNoManaged()
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

#Region "Customer"

    Public Shared Function GetCritiqueCustomers(ByVal customers_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectCritiqueCustomers(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetReviewCustomer(ByVal customers_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectReviewsCustomers(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetAverageCritiqueCustomers(ByVal customers_id) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectAverageCritiqueCustomers(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetRating(ByVal customers_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectRating(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestNumberCritique(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectBestNumberCritique(isweek)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function getBestqualityDvdpostCritique(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectBestqualityDvdpostCritique(isweek)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestCritiqueCustomers(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectBestCritiqueCustomers(isweek)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestRating(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectBestRating(isweek)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function


#End Region
    Public Shared Function getValueReview() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.getSelectValueRating()
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt

    End Function

#Region "Product"

    Public Shared Function GetReviewProduct(ByVal products_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectReviewsProducts(products_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetAverageCritiqueProducts(ByVal products_id) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectAverageCritiqueProducts(products_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetAverageRatingProducts(ByVal products_id As String) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectAverageRatingProducts(products_id)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestRatingProducts(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectBestRatingProducts(isweek)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestProductPolemique(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = PlushData.clsReviews.GetSelectBestProductPolemique(isweek)
        dt = PlushData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

#End Region

   


End Class
