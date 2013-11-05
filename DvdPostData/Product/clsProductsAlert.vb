Public Class clsProductsAlert
    Public Enum checkStatus
        CHECKED = 1
        NOT_CHECKED = 0
    End Enum

    Public Shared Function getProductsAlert(ByVal products_id As Integer, ByVal products_dvd_id As Integer)
        Dim sql As String
        sql = "select pa.* from products_alert pa " & _
               " where products_id = " & products_id & _
              " and products_dvd_id = " & products_dvd_id & " and  check_status = " & checkStatus.NOT_CHECKED
        Return sql
    End Function
    Public Shared Function getProductsAlert(ByVal check_status As checkStatus)
        Dim sql As String
        sql = "select pa.* , su.FullName from products_alert pa left join securityuser su on su.UserId = pa.user_modified  where check_status = " & check_status & " order by alert_id desc"
        Return sql
    End Function

    Public Shared Function insertProductsAlert(ByVal products_id As Integer, ByVal products_dvd_id As String, ByVal alert_comment As String) As String
        Dim sql As String

        sql = "insert into products_alert (products_id, products_dvd_id, alert_cre_date, alert_comment, user_modified)  values(" & products_id & " ,  " & products_dvd_id & " , now() , '" & alert_comment & "' , " & clsSession.user_id & ") "
        Return sql
    End Function


    Public Shared Function UpdateCheckStatus(ByVal alert_id As Integer, ByVal ckeck_status As checkStatus)
        Dim sql As String
        sql = "update products_alert  set check_status = " & checkStatus.CHECKED & " , user_modified = " & clsSession.user_id & " where alert_id =  " & alert_id
        Return sql
    End Function
End Class
