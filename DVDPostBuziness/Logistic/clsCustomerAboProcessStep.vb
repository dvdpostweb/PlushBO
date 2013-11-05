Public Class clsCustomerAboProcessStep
    Public customers_id As Integer
    Public Norm As clsProductTypeAboprocessStep
    Public Adult As clsProductTypeAboprocessStep
    Public stat As PlushData.Customer_stat

    Public Sub New(ByVal Pcustomers_id As Integer, ByVal sleep As Boolean)

        customers_id = Pcustomers_id
        Norm = New clsProductTypeAboprocessStep()
        Adult = New clsProductTypeAboprocessStep()
        stat = New PlushData.Customer_stat(Pcustomers_id, sleep)
    End Sub
End Class
