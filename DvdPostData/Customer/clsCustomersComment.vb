Public Class clsCustomersComment

    Public Shared Function GetCustomersComment(ByVal customers_id As Integer) As String
        Dim sql As String
        sql = "select cc.* , su.FullName from customers_comment cc " & _
              "left join securityuser su on cc.customers_comment_adminby = su.UserID where cc.customers_id = " & customers_id & " order by customers_comment_date desc"
        Return sql
    End Function

    Public Shared Function GetInsertCustomersComment(ByVal customers_id As Integer, ByVal commentText As String)
        Dim sql As String
        commentText = Replace(commentText, "'", "\'")

        sql = "insert into customers_comment (customers_id,customers_comment_text,customers_comment_date,customers_comment_adminby) " & _
              " values (" & customers_id & " , '" & commentText & "' , now(), " & PlushData.clsSession.user_id & " )"
        Return sql
    End Function

End Class
