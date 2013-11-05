Public Class ClsBrokenCustomer
    Inherits State
    Public Overrides Sub getStock(ByVal context As Context)
        context.State = New STOCK()
    End Sub

    Public Overrides Sub getEntretienLogistic(ByVal context As Context)
        context.State = New ClsEntretienLogistic()
    End Sub
End Class
