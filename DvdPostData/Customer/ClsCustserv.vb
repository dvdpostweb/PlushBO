Public Class ClsCustserv

    Public Shared Function GetCustserv() As String
        Dim sql As String
        sql = " select * from custserv cs join custserv_cat cc on  cc.custserv_cat_id = cs.custserv_cat_id  and cc.language_id = cs.language_id"
        Return sql
    End Function

    Public Shared Function GetCustservByCustomers(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = GetCustserv() + " where cs.customers_id = " & customers_id & " order by cs.custserv_id desc "
        Return sql

    End Function

    Public Shared Function upadeCustservByCustMaint(ByVal custserv_id As String, ByVal messageAdmim As String, ByVal subject As String, ByVal msgSent As Boolean) As String
        Dim sql As String = "update custserv set admindate = now(),  adminby = " & PlushData.clsSession.user_id & " "
        Dim where As String = "where custserv_id = " & custserv_id

        If subject <> String.Empty Then
            sql = sql & ", subject = '" & subject & "' "
        End If

        If messageAdmim <> String.Empty Then
            sql = sql & ", adminmessage = '" & messageAdmim & "' "
        End If

        If msgSent = True Then
            sql = sql & ", messagesent = 1 "
        End If


        'Dim sql = "update custserv set subject = '" & subject & "' ,admindate = now() , adminby = " & DvdPostData.clsSession.user_id & " , adminmessage = '" & messageAdmim & "', messagesent =   where custserv_id = " & custserv_id
        Return sql + where
    End Function

    Public Shared Function GetCustServCustomers() As String
        Dim sql As String
        sql = " join customers c on c.customers_id = cs.customers_id where admindate is null and adminby is null and adminmessage is null " 'and customers_abo = " & DvdPostData.ClsCustomersData.abo.VALID
        Return GetCustserv() + sql
    End Function

End Class
