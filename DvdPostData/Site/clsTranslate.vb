Public Class clsTranslate

    Public Shared Function GetSearch(ByVal id As Object, ByVal title As Object, ByVal lang As Object, ByVal landing_id As Object) As String
        Dim sql As String
        Dim strId As String = ""
        Dim strTitle As String = ""
        Dim strlang As String = ""
        Dim strLanding As String = ""

        If Not id Is Nothing AndAlso id.ToString() <> String.Empty Then
            strId = " and id = " & id.ToString()
        End If

        If Not title Is Nothing AndAlso title <> String.Empty Then
            strTitle = " and UCASE(name) = '" & title.ToString().ToUpper() & "'"
        End If

        If Not lang Is Nothing AndAlso lang.ToString() <> String.Empty AndAlso lang > 0 Then
            strlang = " and locale_id = " & lang
        End If

        If Not landing_id Is Nothing AndAlso landing_id.ToString() <> String.Empty AndAlso landing_id > 0 Then
            strLanding = " and tr_key like '%\\_" & landing_id & "'"
        End If

        sql = "select * from i18n_db_translations where namespace in ('home.index.carousel_item','home.index.carousel_item_title','products.left_column') " & _
               strId & strTitle & strlang & strLanding
        Return sql

    End Function

    Public Shared Function getInfoTable() As String
        Dim sql As String
        sql = "show table status like 'i18n_db_translations'"
        Return sql
    End Function

    Public Shared Function GetLoadLanding()
        Dim sql As String

        sql = "select id,name from landings"

        Return sql
    End Function
End Class
