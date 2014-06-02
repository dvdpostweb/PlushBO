Public Class clsWelcomeCall

    Public Shared Function getselectWelcomeCall() As String
        Dim sql As String

        sql = " select c.customers_id customers_id , c.customers_firstname, c.customers_lastname, c.customers_language, c.email, c.customers_telephone, c.customers_abo_validityto, " & _
              " c.welcomecall_hour, c.welcomecall_day, c.welcomecall_done, " & _
              " (select count(id) from tokens t where t.customer_id = a.customerid and t.created_at > date_add(now(), interval -30 day)) vodwatched " & _
              " FROM (select * from abo a WHERE a.Action in (1, 6, 8) and a.Date > date_add(now(), interval -30 day) " & _
              "        and not exists(select * from abo a1 where a1.customerid = a.customerid and a1.action in(6, 7, 8)    and a1.date < date_add(now(), interval -30 day)" & _
              " and a1.date > date_add(now(),interval -1 year) ) ) a " & _
              " join customers c on a.customerid = c.customers_id where c.welcomecall_done = 0 "

        Return sql
    End Function

    Public Shared Function getselectforUpdate() As String
        Dim sql As String

        sql = " select customers_id, welcomecall_hour, welcomecall_day, welcomecall_done FROM customers where welcomecall_done = 0 "
        Return sql
    End Function

    Public Shared Function getUpdateWelcomecall(ByVal id As Integer) As String
        Dim sql As String
        sql = "UPDATE customers set welcomecall_done = 1, updated_at = now() " & _
               " WHERE customers_id = " & id
        Return sql
    End Function

End Class
