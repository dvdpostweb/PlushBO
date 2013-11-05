Public Class clsSession

    Public Shared user_id As Integer
    Public Shared isAdmin As Boolean
    Public Shared isEnvTest As Boolean
    Public Shared Version As String
    Public Shared isDVDPostUser As Boolean = False
    Public Shared isBatch As Boolean = False
    Public Shared box_id As Integer = Integer.MaxValue
    Public Shared FullName As String
    Public Shared Lst_role As New List(Of Integer)

    Public Shared Function isAccesMenu(ByVal dtMenuRole As DataTable, ByVal menu_id As Integer) As Boolean
        Dim lst_dr() As DataRow
        lst_dr = dtMenuRole.Select("menuid = " & menu_id)

        Return lst_dr.Length > 0
    End Function

    Public Shared Function GetLstRole() As String
        Dim str As String = ""


        For Each role_id As Integer In Lst_role
            str = str + role_id.ToString() + ","
            If role_id = 1 Then isAdmin = True
        Next
        If str.Length > 0 Then str = str.Remove(str.Length - 1, 1)

        Return str
    End Function
End Class