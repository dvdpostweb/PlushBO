Public Class [IN]
    Inherits State

   
    Public Overrides Sub getMID(ByVal context As Context)
        context.State = New ClsMID()
    End Sub

    Public Overrides Sub getStock(ByVal context As Context)
        context.State = New STOCK()
    End Sub

End Class
