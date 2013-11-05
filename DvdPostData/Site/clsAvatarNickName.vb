Public Class clsAvatarNickName

    Public Shared Function GetSearchPending() As String
        Dim sql As String
        sql = "select customer_id,nickname,nickname_pending,avatar,avatar_pending " & _
        " from customers c join customer_attributes ca on c.customers_id = ca.customer_id " & _
        " where c.customers_abo = 1 and (ca.nickname_pending is not null or ca.avatar_pending is not null)"
        Return sql
    End Function
    Public Shared Function getUpdateValidAvatar(ByVal customer_id As Integer) As String
        Dim sql As String
        sql = " update customer_attributes " & _
              " set avatar = avatar_pending,avatar_pending = null,updated_at = now() " & _
              " where customer_id = " & customer_id
        Return sql
    End Function

    Public Shared Function getUpdateCancelAvatar(ByVal customer_id As Integer) As String
        Dim sql As String
        sql = " update customer_attributes " & _
              " set avatar_pending = null,updated_at = now() " & _
              " where customer_id = " & customer_id
        Return sql
    End Function

    Public Shared Function getUpdateValidNickname(ByVal customer_id As Integer) As String
        Dim sql As String
        sql = " update customer_attributes " & _
              " set nickname = nickname_pending,nickname_pending = null,updated_at = now() " & _
              " where customer_id = " & customer_id
        Return sql
    End Function

    Public Shared Function getUpdateCancelNickName(ByVal customer_id As Integer) As String
        Dim sql As String
        sql = " update customer_attributes " & _
              " set nickname_pending = null,updated_at = now() " & _
              " where customer_id = " & customer_id
        Return sql
    End Function
  
End Class
