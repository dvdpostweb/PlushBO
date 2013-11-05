Public Class clsLandings
    Public Shared Function GetEnumMysqlActif() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM landings LIKE 'actif_french' "
        Return sql
    End Function

    Public Shared Function GetEnumMysqlLogin() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM landings LIKE 'login' "
        Return sql
    End Function

    Public Shared Function GetEnumMysqlKind() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM landings LIKE 'kind' "
        Return sql
    End Function
    Public Shared Function getInfoTable() As String
        Dim sql As String
        sql = "show table status like 'landings'"
        Return sql
    End Function
    Public Shared Function getLanguages() As String
        Dim sql As String
        sql = "select id,short from i18n_db_locales"
        Return sql
    End Function
    

    Private Shared Function getSiteBeta(ByVal type As String) As String
        Dim sql As String
        sql = " SELECT * FROM `landings` " & _
            " WHERE `landings`.`login` IN ('" & type & "','both') " & _
            " AND (expirated_date > now() or expirated_date is null) " & _
            " AND `landings`.`actif_french` in ('BETA','YES') ORDER BY ordered asc,id desc "
        Return Sql
    End Function
    Private Shared Function getSiteProduction(ByVal type As String) As String
        Dim sql As String
        sql = " SELECT * FROM `landings` " & _
              " WHERE `landings`.`login` IN ('" & type & "','both') " & _
              " AND (expirated_date > now() or expirated_date is null) " & _
              " AND `landings`.`actif_french` = 'YES' ORDER BY ordered asc,id desc "
        Return sql
    End Function

    Public Shared Function getPublicSiteProduction() As String
        Return getSiteProduction("public")
    End Function
    Public Shared Function getPublicSiteBeta() As String
        Return getSiteBeta("public")

    End Function

    Public Shared Function getPrivateSiteBeta() As String
        Return getSiteBeta("private")
    End Function
    Public Shared Function getPrivateSiteProduction() As String
        Return getSiteProduction("private")
    End Function

    Public Shared Function GetSearch(ByVal id As Object, ByVal title As Object, ByVal kind As Object) As String
        Dim sql As String
        Dim strId As String = ""
        Dim strTitle As String = ""
        Dim strKind As String = ""

        If Not id Is Nothing AndAlso id.ToString() <> String.Empty Then
            strId = " and id = " & id.ToString()
        End If

        If Not title Is Nothing AndAlso title <> String.Empty Then
            strTitle = " and UCASE(name) = '" & title.ToString().ToUpper() & "'"
        End If

        If Not kind Is Nothing AndAlso kind <> String.Empty Then
            strKind = " and UCASE(kind) = '" & kind.ToString().ToUpper() & "'"
        End If

        sql = "select * from landings where 1 " & strId & strTitle & strKind
        Return sql

    End Function
End Class
