Public Class ClsPurchase
    Inherits State
    Public Overrides Sub getStock(ByVal context As Context)
        context.State = New STOCK()
    End Sub
   
End Class
