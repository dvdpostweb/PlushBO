Public Class CustServ
    Inherits State

    Public Sub New()
        ' change Box
        ' change Status 

    End Sub

    Public Overrides Sub getStock(ByVal context As Context)
        context.State = New STOCK()
    End Sub

End Class
