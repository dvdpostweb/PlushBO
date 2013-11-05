Public Class clsCustomer_stat

    Public customers_id As Integer
    Private Norm As clsCustomer_Stat_TypeDVD
    Private Adult As clsCustomer_Stat_TypeDVD

    Public Sub New(ByVal Pcustomers_id As Integer, ByVal sleep As Boolean)

        customers_id = Pcustomers_id
        Norm = New clsCustomer_Stat_TypeDVD(Pcustomers_id, PlushData.clsProductDvd.Type_DVD.DVD_NORM, sleep)
        Adult = New clsCustomer_Stat_TypeDVD(Pcustomers_id, PlushData.clsProductDvd.Type_DVD.DVD_ADULT, sleep)
    End Sub

    Public Function GetStat(ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As clsCustomer_Stat_TypeDVD
        Select Case type_dvd
            Case PlushData.clsProductDvd.Type_DVD.DVD_ADULT
                Return Adult
            Case PlushData.clsProductDvd.Type_DVD.DVD_NORM
                Return Norm
            Case Else
                Return Norm
        End Select
    End Function

    Public Function SaveStat(ByVal aboprocess_id As Integer, ByVal type_dvd As PlushData.clsProductDvd.Type_DVD) As Boolean
        Me.GetStat(type_dvd).SaveStat(aboprocess_id)
    End Function
End Class
