Public Class clsPhoneActivation

    Public Shared Function insertPhoneActivation(ByVal customers_id As Integer, ByVal stop_phone_id As String, ByVal other_reason As String, ByVal call_phone As String, ByVal date_delete As Boolean) As String
        Dim sql As String
        Dim date_delete_phone_activation As String


        If call_phone <> "" Then
            call_phone = " '" & call_phone & "' " '" '" & PlushTools.ClsDate.formatDate(call_phone) & "' "
        Else
            call_phone = " DEFAULT(call_phone)"
        End If

        If date_delete = True Then
            date_delete_phone_activation = " now() "
        Else
            date_delete_phone_activation = " DEFAULT(date_delete_phone_activation) "
        End If

        If other_reason <> "" Then
            other_reason = Replace(other_reason, "'", "\'")
            other_reason = " '" & other_reason & "' "
        Else
            other_reason = " DEFAULT(other_reason) "
        End If

        If stop_phone_id <> "" Then
            stop_phone_id = "'" & stop_phone_id & "'"
        Else
            stop_phone_id = " DEFAULT(stop_phone_id) "
        End If

        sql = "insert into historique_phone_activation  ( customers_id, stop_phone_id, other_reason, call_phone, date_delete_phone_activation ) value (" & _
              " " & customers_id & " , " & stop_phone_id & " , " & other_reason & " , " & call_phone & " , " & date_delete_phone_activation & " ) "




        Return sql
    End Function



    Public Shared Function UpdatePhoneActivation(ByVal customer_id As Integer, ByVal stop_phone_id As String, ByVal other_reason As String, ByVal call_phone As String, ByVal date_delete As Boolean) As String
        Dim sql As String
        Dim date_delete_phone_activation As String


        If call_phone <> "" Then
            call_phone = " '" & call_phone & "' " '" '" & PlushTools.ClsDate.formatDateTimeDB(call_phone) & "' "
        Else
            call_phone = " DEFAULT(call_phone)"
        End If

        If date_delete = True Then
            date_delete_phone_activation = " now() "
        Else
            date_delete_phone_activation = " DEFAULT(date_delete_phone_activation) "
        End If

        If other_reason <> "" Then
            other_reason = Replace(other_reason, "'", "\'")
            other_reason = " '" & other_reason & "' "
        Else
            other_reason = " DEFAULT(other_reason) "
        End If

        If stop_phone_id <> "" Then
            stop_phone_id = "'" & stop_phone_id & "'"
        Else
            stop_phone_id = " DEFAULT(stop_phone_id) "
        End If


        sql = "update historique_phone_activation  set  stop_phone_id = " & stop_phone_id & " , other_reason = " & other_reason & " , call_phone = " & call_phone & " , date_delete_phone_activation = " & date_delete_phone_activation & " where customers_id = " & customer_id
        Return sql
    End Function


    Public Shared Function updateCustomerStep(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "update customers set customers_registration_step = 31 where customers_id = " & customers_id
        Return sql
    End Function
    ' customers_id, stop_phone_id, other_reason, call_phone, date_delete_phone_activation

    'Public Shared Function GetHistoriquePhoneActivation(ByVal customers_id As Integer) As String
    '    Dim sql As String
    '    sql = "select * from historique_phone_activation where customers_id = " & customers_id
    '    Return sql
    'End Function

    Public Shared Function GetStopPhoneActiReason() As String
        Dim sql As String
        sql = "select * from stop_phone_acti_reason"
        Return sql
    End Function

    Public Shared Function GetExist(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = " select count(*) from historique_phone_activation where customers_id = " & customers_id
        Return sql
    End Function


    Public Shared Function GetPhoneActivation()
        Dim sql As String
        sql = " SELECT if(isnull(hpa.hist_phone_activation_id),111111111,hpa.hist_phone_activation_id) phone_activation_id, c.customers_id, c.customers_firstname, c.customers_lastname, c.customers_email_address, c.customers_abo,c.customers_abo_payment_method,c.customers_language, " & _
              " c.black_listed, ab.entry_street_address, ab.entry_postcode, c.domiciliation_number, cast( call_phone as char) as call_phone " & _
              " FROM customers c " & _
              " join address_book ab on  c.customers_default_address_id = ab.address_book_id And c.customers_id = ab.customers_id " & _
              " left join (select yy.* from  historique_phone_activation yy " & _
              "                                                Join " & _
              "                                                     (select max(hist_phone_activation_id) as id , customers_id " & _
              "                                                      from historique_phone_activation group by customers_id) xx on yy.customers_id =  xx.customers_id) " & _
              "      hpa  on hpa.customers_id = c.customers_id " & _
              " where  c.customers_registration_step = " & PlushData.ClsCustomersData.StepRegistrationStatus.OK & " and c.customers_abo = " & PlushData.ClsCustomersData.abo.UNVALID & _
              " order by 1 desc"
        '"    And c.customers_abo_payment_method = " & DvdPostData.ClsCustomersData.Payment_Method.VIREMENT & _ Igor: this condition is removed on Christophe's request

        '" and (hpa.customers_id is null or (hpa.date_delete_phone_activation is null and hpa.stop_phone_id is null))"
        Return sql
    End Function


End Class
