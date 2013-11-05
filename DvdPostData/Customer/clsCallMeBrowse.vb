Public Class clsCallMeBrowse

    Public Shared Function getselectforUpdate() As String
        Dim sql As String

        sql = " select pr.id,pr.customer_id, pr.name, pr.phone" & _
              " hour,day, pr.reason,pr.comment,open " & _
              " FROM phone_custserv pr " & _
              " where open = 0"

        Return sql
    End Function

    Public Shared Function getselectCallMeBrowse() As String
        Dim sql As String

        sql = " select id,pr.customer_id customers_id , pr.name, c.customers_firstname, pr.language_id call_langauge, c.customers_lastname,c.customers_language,pr.phone," & _
              " hour,day, reason,pr.comment,open " & _
              " FROM phone_custserv pr " & _
              " LEFT JOIN customers c on c.customers_id = pr.customer_id where open = 0"

        Return sql
    End Function
    Private Shared Function getSelectValueGlobalCode(ByVal key As String) As String
        Dim sql As String

        sql = " SELECT CodeValue, CodeDesc FROM generalglobalcode " & _
              " where codetype = '" & key & "'"
        Return sql
    End Function

    Public Shared Function getSelectValueReason() As String
        Dim sql As String

        sql = "select id,name from category_tickets"

        Return sql
    End Function

    Public Shared Function getSelectValueHour() As String

        Return getSelectValueGlobalCode("phone_request_time")
    End Function
    Public Shared Function getUpdateCallMeBrowse(ByVal comment As String, ByVal id As Integer) As String
        Dim sql As String
        sql = "UPDATE phone_custserv set open = 1,updated_at = now(), comment = '" & comment & "' " & _
               " WHERE id = " & id
        Return sql
    End Function
End Class
