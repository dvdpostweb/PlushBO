Public Class clsThemeEvent

    Public Shared Function GetEnumMysqlType() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM themes_events LIKE 'kind' "
        Return sql
    End Function

    Public Shared Function GetEnumMysqlBackgroundAttachment() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM themes_events LIKE 'background_attachment' "
        Return sql
    End Function

    Public Shared Function getInfoTable() As String
        Dim sql As String
        sql = "show table status like 'themes_events'"
        Return sql
    End Function

    Public Shared Function GetSearch(ByVal id As Object, ByVal title As Object) As String
        Dim sql As String
        Dim strId As String = ""
        Dim strTitle As String = ""

        If Not id Is Nothing AndAlso id <> String.Empty Then
            strId = " and id = " & id.ToString()
        End If

        If Not title Is Nothing AndAlso title <> String.Empty Then
            strTitle = " and UCASE(name) = '" & title.ToString().ToUpper() & "'"
        End If
        sql = "select *,1 title_page from themes_events where 1 " & strId & strTitle
        Return sql

    End Function
    Public Shared Function GetThemeEventSelected() As String
        Dim sql As String

        sql = "select id,name from themes_events_selections"
        Return sql
    End Function

    Public Shared Function GetThemeEventValue() As String
        Dim sql As String

        sql = "select id,name from themes_events"
        Return sql
    End Function

End Class
