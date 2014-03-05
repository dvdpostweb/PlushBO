Public Class ClsMID
    Inherits State

    Public Overrides Sub getOut(ByVal context As Context)

        context.State = New ClsOut()
    End Sub
End Class
