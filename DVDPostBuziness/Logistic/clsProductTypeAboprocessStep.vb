Public Class clsProductTypeAboprocessStep

    Public nb_sent As Integer
    Public nb_request As Integer ' without restriction 
    Public nb_request_max As Integer ' restriction max send one shot
    Public nb_request_max_credit As Integer ' restriction max send / max credit
    Public nb_request_max_credit_sizeWishlist As Integer ' restriction max send / max credit / max size wishlist

    Public nb_compensation As Integer
    Public stop_process As Boolean
    Public dt_wishlist As DataTable

End Class
