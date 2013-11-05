Public Class clsDirectors
    Public Shared Function GetSelectList() As String
        Dim sql As String

        sql = "select directors_id id, directors_name name from directors order by directors_name"

        Return sql
    End Function
End Class
