Public Class ClsParrainage
    Public Shared Function getActivationNotLinked() As String
        Dim sql As String
        sql = "select * from activation_code_errors where linked = 0 "
        Return sql
    End Function



End Class
