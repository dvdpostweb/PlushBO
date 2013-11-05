Public Class clsUsers


    Public Shared Function GetSelectMenu_role(ByVal role_id As Integer) As String
        Dim sql As String
        sql = "select * from securitymenu_role where roleid = " & role_id
        Return sql
    End Function

    Public Shared Function GetselectUser_role(ByVal user_id As Integer) As String
        Dim sql As String
        sql = "select * from securityuser_role where userid = " & user_id
        Return sql
    End Function

    Public Shared Function GetselectRole() As String
        Dim sql As String
        sql = "select * from securityrole"
        Return sql
    End Function

    Public Shared Function GetselectUser() As String
        Dim sql As String
        sql = "select * from securityuser"
        Return sql
    End Function

    Public Shared Function GetUpdatePwdUser(ByVal userid As Integer, ByVal newpwd As String) As String
        Dim sql As String
        sql = "update securityuser set password = '" & newpwd & "' where userid = " & userid
        Return sql
    End Function
End Class
