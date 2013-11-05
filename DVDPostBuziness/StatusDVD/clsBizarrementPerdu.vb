Public Class clsBizarrementPerdu
    Inherits State

    Public Overrides Sub getStock(ByVal context As Context)
        context.State = New STOCK()
    End Sub

    Public Overrides Sub getIN(ByVal context As Context)
        context.State = New [IN]()
    End Sub

End Class
