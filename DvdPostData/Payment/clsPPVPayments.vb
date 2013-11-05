Public Class clsPPVPayments

    Public Shared Function getSelectForPPVPayments(ByVal countryid As Integer, ByVal datetimeFrom As DateTime, ByVal datetimeTo As DateTime) As String
        Dim sql As String

        sql = " select c.customers_id, p.products_title, t.imdb_id, t.created_at, t.is_ppv, t.ppv_price amount from " & _
        " tokens t join customers c on t.customer_id = c.customers_id " & _
        " join products p on p.imdb_id = t.imdb_id " & _
        " where t.is_ppv = 1 and t.created_at >= '" & PlushTools.ClsDate.formatDate(datetimeFrom) & "' and " & _
        " t.created_at < '" & PlushTools.ClsDate.formatDate(datetimeTo) & "' group by c.customers_id, p.products_title, t.imdb_id, t.created_at "

        Return sql
    End Function

    Public Shared Function getInsertPPVPayment(ByVal batch_id As Integer, ByVal countryid As Integer, ByVal datetimeFrom As DateTime, ByVal datetimeTo As DateTime) As String
        Dim sql As String

        sql = " insert into payments_ppv (batch_id, country_id, from_date, to_date, created_at) values( " & batch_id & ", " & countryid & ", '" & PlushTools.ClsDate.formatDate(datetimeFrom) & "' , '" & PlushTools.ClsDate.formatDate(datetimeTo) & "', now() )"

        Return sql
    End Function

    Public Shared Function getSelectPPVPaymentExists(ByVal country_id As Integer, ByVal datetimeFrom As DateTime, ByVal datetimeTo As DateTime) As String
        Dim sql As String

        sql = " Select batch_id from payments_ppv where country_id = " & country_id & " and from_date = '" & PlushTools.ClsDate.formatDate(datetimeFrom) & "' and to_date = '" & PlushTools.ClsDate.formatDate(datetimeTo) & "' "

        Return sql
    End Function

    Public Shared Function getSelectPPVPaymentExists(ByVal batch_id As Integer) As String
        Dim sql As String

        sql = " Select count(*) from payments_ppv where batch_id = " & batch_id

        Return sql
    End Function

End Class
