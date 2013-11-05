Public Class clsThemeTop

    Public Shared Function GetEnumMysqlStyle() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM product_lists LIKE 'style' "
        Return sql
    End Function

    Public Shared Function GetEnumMysqlKind() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM product_lists LIKE 'kind' "
        Return sql
    End Function

    Public Shared Function GetEnumMysqlChannel() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM product_lists LIKE 'channel' "
        Return sql
    End Function

    Public Shared Function getInfoTable() As String
        Dim sql As String
        sql = "show table status like 'product_lists'"
        Return sql
    End Function

    Public Shared Function GetSearch(ByVal id As Object, ByVal title As Object, ByVal kind As Object, ByVal theme_event As Object, ByVal channel As Object) As String
        Dim sql As String
        Dim strId As String = ""
        Dim strTitle As String = ""
        Dim strKind As String = ""
        Dim strTheme_event As String = ""
        Dim strChannel As String = ""

        If Not id Is Nothing AndAlso id.ToString() <> String.Empty Then
            strId = " and id = " & id.ToString()
        End If

        If Not title Is Nothing AndAlso title <> String.Empty Then
            strTitle = " and UCASE(name) = '" & title.ToString().ToUpper() & "'"
        End If

        If Not kind Is Nothing AndAlso kind <> String.Empty Then
            strKind = " and UCASE(kind) = '" & kind.ToString().ToUpper() & "'"
        End If

        If Not theme_event Is Nothing AndAlso _
            theme_event.ToString() <> String.Empty AndAlso _
            theme_event > 0 _
            Then
            strTheme_event = "and theme_event_id = " & theme_event.ToString()
        End If

        If Not channel Is Nothing AndAlso channel <> String.Empty Then
            strChannel = " and UCASE(channel) = '" & channel.ToString().ToUpper() & "'"
        End If

        sql = "select * from product_lists where 1 " & strId & strTitle & strKind & strTheme_event & strChannel
        Return sql

    End Function

End Class
