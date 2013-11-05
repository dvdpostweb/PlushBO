Public Class clsCompensation

    Public Shared Function GetCompensationByCust(ByVal customers_id As Integer) As String
        Dim sql As String
        'sql = "select * from compensation where customers_id = " & customers_id
        sql = " select c.* , pdes.products_name as products_name_given , pdes2.products_name  from compensation c " & _
              "join customers cust on cust.customers_id = c.customers_id " & _
              "left join products_description pdes on pdes.products_id = c.products_id_given and pdes.language_id = cust.customers_language " & _
              "left join products_description pdes2 on pdes2.products_id = c.products_id and pdes2.language_id = cust.customers_language " & _
              "where c.customers_id =  " & customers_id & " order by c.compensation_date_given desc "

        Return sql
    End Function


End Class
