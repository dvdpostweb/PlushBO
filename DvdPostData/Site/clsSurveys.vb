Public Class clsSurveys

    Public Enum kind
        PRODUCTS = 1
        ACTORS = 2
        DIRECTORS = 3
        FREE = 4
    End Enum
    Public Shared Function GetSurveysKind() As String
        Dim sql As String
        sql = "select id, name FROM survey_kinds "

        Return sql
    End Function

    Public Shared Function getInfoTableDetail() As String
        Dim sql As String
        sql = "show table status like 'survey_details'"
        Return sql
    End Function
    Public Shared Function getInfoTable() As String
        Dim sql As String
        sql = "show table status like 'surveys'"
        Return sql
    End Function
    Public Shared Function GetKindOfSurvey(ByVal id As Integer) As String
        Dim sql As String

        sql = "select survey_kind_id from surveys where id = " & id

        Return sql
    End Function
    Public Shared Function GetSearchSurvey(ByVal id As Object, ByVal title As Object, ByVal survey_kind_id As Object, ByVal themes_event_id As Object) As String
        Dim sql As String
        Dim strId As String = ""
        Dim strTitle As String = ""
        Dim strKind As String = ""
        Dim strTheme_event As String = ""

        If Not id Is Nothing AndAlso id.ToString() <> String.Empty Then
            strId = " and id = " & id.ToString()
        End If

        If Not title Is Nothing AndAlso title <> String.Empty Then
            strTitle = " and ( UCASE(title_nl) like '%" & title.ToString().ToUpper() & "%' or  UCASE(title_fr) like '%" & title.ToString().ToUpper() & "%' or UCASE(title_nl) like '%" & title.ToString().ToUpper() & "%' )"
        End If

        If Not survey_kind_id Is Nothing AndAlso survey_kind_id > 0 Then
            strKind = " and UCASE(survey_kind_id) = '" & survey_kind_id.ToString().ToUpper() & "'"
        End If

        If Not themes_event_id Is Nothing AndAlso _
            themes_event_id > 0 _
            Then
            strTheme_event = " and themes_event_id = " & themes_event_id.ToString()
        End If

        sql = "select * from surveys where 1 " & strId & strTitle & strKind & strTheme_event
        Return sql

    End Function

    Public Shared Function GetSurveys() As String
        Dim sql As String
        sql = "select id, title_fr FROM surveys "
        Return sql
    End Function

    Public Shared Function GetSearchSurveyDetails(ByVal survey_detail_id As Object, ByVal survey_id As Object) As String
        Dim sql As String

        Dim strId As String = ""
        Dim strSurvey As String = ""

        If Not survey_detail_id Is Nothing AndAlso survey_detail_id.ToString() <> String.Empty Then
            strId = " and id = " & survey_detail_id.ToString()
        End If

        If Not survey_id Is Nothing AndAlso survey_id.ToString() <> String.Empty Then
            strSurvey = " and survey_id = " & survey_id.ToString()
        End If

        sql = "select sd.* from survey_details sd " & _
              " where 1 " & strId & strSurvey
        Return sql

    End Function


End Class
