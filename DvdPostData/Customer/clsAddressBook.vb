Public Class clsAddressBook

    Public Shared Function GetAddressByCustomer(ByVal customers_id As String) As String
        Dim sql As String
        sql = "select * from address_book ab " & _
        "join country ctry on  ab.entry_country_id = ctry.countries_id " & _
        "join customers c on c.customers_id = ab.customers_id " & _
        "where c.customers_default_address_id <> ab.address_book_id and  ab.customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function InsertAddressHistory(ByVal customers_id As Integer, ByVal lastid As Integer) As String
        Dim sql As String
        sql = "insert address_book select customers_id," & lastid + 1 & ",entry_gender,entry_company,entry_firstname,entry_lastname,entry_street_address,entry_suburb" & _
              ", entry_postcode,entry_city,entry_state,entry_country_id,entry_zone_id,null from address_book where customers_id = " & customers_id & _
              " and address_book_id = " & lastid

        Return sql
    End Function

    Public Shared Function UpdateAddressBook(ByVal customers_id As Integer, ByVal newid As Integer, ByVal firstname As String, ByVal lastname As String, ByVal address As String, ByVal codepostal As String, ByVal city As String, ByVal country_id As Integer) As String
        Dim sql As String
        address = address.Replace("'", "''")
        sql = "update address_book set entry_firstname = '" & firstname.Replace("'", "''") & "',entry_lastname = '" & lastname.Replace("'", "''") & "',entry_street_address = '" & address & "'" & _
        ",entry_postcode = '" & codepostal & "',entry_city = '" & city.Replace("'", "''") & "',entry_country_id = " & country_id & _
        " where customers_id = " & customers_id & " and address_book_id = " & newid

        Return sql

    End Function
    Public Shared Function UpdateDefaultAddress(ByVal customers_id As Integer, ByVal newid As Integer) As String
        Dim sql As String
        sql = " update customers set customers_default_address_id = " & newid & " where customers_id = " & customers_id
        Return sql
    End Function

End Class
