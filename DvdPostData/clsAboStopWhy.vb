Public Class clsAboStopWhy


    Private Shared Function GetSelectCountReconduction(ByVal strkeyCustomer As String) As String
        Dim sql As String

        sql = " select count(*) cpt_reconduction " & _
              " from abo a where a.customerid = " & strkeyCustomer & _
              " and  a.`action` = " & ClsCustomersData.TypeAction.ACTION_RECONDUCTION & _
              "        and a.date >= (select max(date) from abo aa where aa.customerid = a.customerid " & _
              "        and aa.action in (" & ClsCustomersData.TypeAction.ACTION_CREATE & "," & ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION & "," & ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT & _
              "      ) group by aa.customerid ) group by a.customerid "

        Return sql
    End Function

    Private Shared Function GetSelectSizeWishlist(ByVal strkeyCustomer As String) As String
        Dim sql As String
        sql = "select count(*) cpt from wishlist where customers_id = " & strkeyCustomer
        Return sql
    End Function

    Public Shared Function getAboStop(ByVal _DateFromTxt As String, ByVal _DateToTxt As String)
        Dim sql As String
        sql = " select pa. qty_credit dvdPerMonth ,c.customers_abo_dvd_credit credit , cs.id  , cs.customers_id , cs.date_stop  , cr.reason , cs.comment , cs.comment_users,cs.prevent_users " & _
              ", (" & GetSelectCountReconduction("c.customers_id") & ") cpt_reconduction " & _
              ", (" & GetSelectSizeWishlist("c.customers_id") & ") size_wishlist " & _
              " from customers c " & _
              " join customers_abo_stop cs on cs.customers_id = c.customers_id" & _
              " left join customers_abo_stop_reason cr on cr.id = cs.reason_id" & _
              " join products_abo pa on c.customers_abo_type = pa.products_id " & _
              " where cs.date_stop >= '" & _DateFromTxt & "' and cs.date_stop <= '" & _DateToTxt & " ' "
        Return sql
    End Function


    Public Shared Function getPreviousAction(ByVal customersId As Integer)
        Dim sql As String
        sql = "SELECT abo.`Date` as abo_date, abo.`action` as action_id , a.name as action_name, " & _
              "ac.activation_id, ac.activation_group, ag.activation_group_name ,dc.discount_code_id, dc.discount_code from abo " & _
              "LEFT JOIN abo_action a on a.id = abo.action " & _
              "LEFT JOIN activation_code ac on ac.activation_id = abo.code_id " & _
              "LEFT JOIN activation_group ag on ag.activation_group_id = ac.activation_group " & _
              "LEFT JOIN discount_code dc on dc.discount_code_id = abo.code_id " & _
              "where abo.customerid = " & customersId & " and abo_id <> (select abo_id from  abo  where  customerid = " & customersId & " order by date desc limit 1 ) order by date desc limit 1"
        Return sql
    End Function



End Class
