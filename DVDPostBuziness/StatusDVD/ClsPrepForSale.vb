Public Class ClsPrepForSale
    Inherits State
    Public Overrides Sub getSale(ByVal context As Context)
        context.State = New ClsSale()
    End Sub
End Class
