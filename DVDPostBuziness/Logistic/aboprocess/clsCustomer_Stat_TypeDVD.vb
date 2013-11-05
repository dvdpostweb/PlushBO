Public Class clsCustomer_Stat_TypeDVD

    Public nb_request As Integer ' without restriction 
    Public nb_request_max As Integer ' restriction max send one shot
    Public nb_request_max_credit As Integer ' restriction max send / max credit
    Public nb_request_max_credit_findDvdWishlist As Integer ' restriction max send / max credit / max found dvd

    Public nb_send As Integer
    Public nb_compensation As Integer

    Public stop_process As Boolean
    Public dt_wishlist As DataTable
    Public statSend As clsCustomer_Stat_TypeDvd_STAT
    Public maxDvdSend As Integer
    Public typeDvd As PlushData.clsProductDvd.Type_DVD



    Public Function SaveStat(ByVal aboprocess_id As Integer) As Boolean
        ' sql 
        statSend.SaveStat(aboprocess_id)
    End Function

    Public Sub New(ByVal customers_id As Integer, ByVal var_typeDvd As PlushData.clsProductDvd.Type_DVD, ByVal sleep As Boolean)


        nb_request = 0
        nb_request_max = 0
        nb_request_max_credit = 0
        nb_request_max_credit_findDvdWishlist = 0
        stop_process = False
        dt_wishlist = Nothing
        statSend = New clsCustomer_Stat_TypeDvd_STAT(customers_id, sleep)
        maxDvdSend = 0
        typeDvd = var_typeDvd
    End Sub
End Class
