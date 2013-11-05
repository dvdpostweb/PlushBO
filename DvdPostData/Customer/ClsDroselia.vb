Public Class ClsDroselia

    Public Shared Function CreateCodeDroselia(ByVal Droseliacode As String, ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "insert into droselia_codes (droselia_codes,customers_id,buy_date) " & _
        " values ('" & Droseliacode & "'," & customers_id & ",now()) "

        Return sql

    End Function


    Public Shared Function GetDroselia(ByVal customers_id As Integer)
        Dim sql As String
        sql = "select * from droselia_codes dc left join droselia_catalog_stream dcs on dc.catalog_id = dcs.catalog_id" & _
        " where dc.customers_id = " & customers_id & " order by dc.id desc "
        Return sql
    End Function

End Class
