Public Class STOCK
    Inherits State
    Public Overrides Sub getIN(ByVal context As Context)
        context.State = New [IN]
    End Sub

    Public Overrides Sub getPrepForSale(ByVal context As Context)
        context.State = New ClsPrepForSale()
    End Sub
End Class

