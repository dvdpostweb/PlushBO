Public Class clsActors

    Public Shared Function GetSelectList() As String
        Dim sql As String

        sql = "select actors_id id, actors_name name from actors order by actors_name"

        Return sql
    End Function

End Class
