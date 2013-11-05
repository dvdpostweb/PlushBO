Public Class clsData_Role
    Inherits BizzLib.clsOneTableData
    Dim mvarEntityListData As clsData_Role_Entity
    Dim mvarEntityListTableName As String = "securityrole_entity"
    Dim mvarMenuListData As clsData_Menu_Role
    Dim mvarMenuListTableName As String = "securitymenu_role"

    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                   ByVal WhereClause As String, ByVal OrderByTxt As String)
        MyBase.New(SessionInfo)
        'hello
        If WhereClause & "" = "" Then
            WhereClause = " WHERE roleid <> 0 "
        Else
            WhereClause = WhereClause & " AND ( roleid <> 0 ) "
        End If
        MyBase.Initialize(DataSet1, DataSetType, TableName, "RoleID", "SELECT * FROM securityrole ", WhereClause, OrderByTxt)
    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                   ByVal RoleID As Integer)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "RoleID", "SELECT * FROM securityrole ", " WHERE roleid = " & RoleID & " ", "")
    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(SessionInfo)
    End Sub

    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        'Check if a User has this Role
        If Row1("RoleID") & "" <> "" Then
            Dim _DataUser As New clsData_User(SessionInfo)
            If _DataUser.Exists("DefaultRoleID", Row1("RoleID")) Then
                'Cannot Delete - Users are Attached to this Role
                _MsgID = 16
            End If
        End If
        Return _MsgID
    End Function
    Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        'Check ID
        If Row1(IDField) & "" = "" Then
            Row1(IDField) = BKGlobal.GetNextID(IDField)
        End If
        'Check Name
        If Row1("Name") & "" = "" Then
            'Name Cannot Be Blank
            _MsgID = 5
        End If
        Return _MsgID
    End Function

    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("Select Count(*) FROM securityrole WHERE " & IDFieldName & " = " & ID)
    End Function
    Public Overloads Sub Save()
        Dim _MsgID As Integer = -1
        'Add Any Saving Before
        Try
            _MsgID = ValidateDataSetBeforeSave()
            If _MsgID <= 0 Then
                'Save Associated EntityList
                mvarEntityListData.Save()
                'Save Associated MenuList
                mvarMenuListData.Save()
                'Save Changes
                SaveDataSet()
            Else
                Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overloads Sub SaveOnlyRole()
        Dim _MsgID As Integer = -1
        'Add Any Saving Before
        Try
            _MsgID = ValidateDataSetBeforeSave()
            If _MsgID <= 0 Then
                'Save Changes
                SaveDataSet()
            Else
                Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overloads Sub SaveOnlyEntityList()
        Dim _MsgID As Integer = -1
        'Add Any Saving Before
        Try
            _MsgID = ValidateDataSetBeforeSave()
            If _MsgID <= 0 Then
                'Save Associated CreditLines
                mvarEntityListData.Save()
            Else
                Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overloads Sub SaveOnlyMenuList()
        Dim _MsgID As Integer = -1
        'Add Any Saving Before
        Try
            _MsgID = ValidateDataSetBeforeSave()
            If _MsgID <= 0 Then
                'Save Associated CreditLines
                mvarMenuListData.Save()
            Else
                Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Overloads Sub Delete(ByVal ID As Integer)
        Dim _View1 As DataView
        Dim _MsgID As Integer = -1

        _View1 = New DataView(DataSet1.Tables(TableName), MyBase.IDField & " = " & ID, MyBase.IDField, DataViewRowState.CurrentRows)
        If _View1.Count = 0 Then
            Exit Sub
        End If
        _MsgID = ValidateRecordBeforeDelete(_View1(0))
        If _MsgID <= 0 Then
            'Delete associated Tables
            mvarEntityListData.DeleteByRoleID(_View1(0)("RoleID"))
            mvarMenuListData.DeleteByRoleID(_View1(0)("RoleID"))
            'Delete the Record
            _View1(0).Delete()
            Save()
        Else
            Dim _ex As New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
            _ex.Source = "##"
            Throw _ex
        End If
    End Sub
    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE securityrole WHERE RoleID = " & ID)
    End Function
    Public Sub LoadEntityList(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal RoleID As Integer)
        mvarEntityListData = New clsData_Role_Entity(SessionInfo, DataSet1, DataSetType, mvarEntityListTableName, RoleID)
        DataSet1.Tables(mvarEntityListTableName).Columns("RoleID").DefaultValue = RoleID
    End Sub
    Public Sub LoadMenuList(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal RoleID As Integer)
        mvarMenuListData = New clsData_Menu_Role(SessionInfo, DataSet1, DataSetType, mvarMenuListTableName, RoleID)
        DataSet1.Tables(mvarMenuListTableName).Columns("RoleID").DefaultValue = RoleID
    End Sub

End Class

Public Class clsData_Role_Entity
    Inherits BizzLib.clsOneTableData

    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                   ByVal WhereClause As String, ByVal OrderByTxt As String)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "RoleID", "SELECT * FROM securityrole_entity ", WhereClause, OrderByTxt)
    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                   ByVal RoleID As Integer)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "RoleID", "SELECT * FROM securityrole_entity ", " WHERE roleid = " & RoleID & " ", "")

    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(SessionInfo)
    End Sub

    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        Return _MsgID
    End Function
    Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        Return _MsgID
    End Function

    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("Select Count(*) FROM securityrole_entity WHERE " & IDFieldName & " = " & ID)
    End Function
    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE FROM securityrole_entity WHERE RoleID = " & ID)
    End Function
    Public Overloads Function DeleteByRoleID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE FROM securityrole_entity WHERE RoleID = " & ID)
    End Function
    Public Overloads Function DeleteByEntityID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE FROM securityrole_entity WHERE EntityID = " & ID)
    End Function
End Class

Public Class clsData_Menu_Role
    Inherits BizzLib.clsOneTableData

    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                   ByVal WhereClause As String, ByVal OrderByTxt As String)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "RoleID", "SELECT * FROM securitymenu_role ", WhereClause, OrderByTxt)
    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                   ByVal RoleID As Integer)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "RoleID", "SELECT * FROM securitymenu_role ", " WHERE roleid = " & RoleID & " ", "")

    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(SessionInfo)
    End Sub

    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        Return _MsgID
    End Function
    Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        Return _MsgID
    End Function

    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("Select Count(*) FROM securitymenu_role WHERE " & IDFieldName & " = " & ID)
    End Function
    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE securitymenu_role WHERE RoleID = " & ID)
    End Function
    Public Overloads Function DeleteByRoleID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE FROM securitymenu_role WHERE RoleID = " & ID)
    End Function
    Public Overloads Function DeleteByMenuID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE FROM securitymenu_role WHERE MenuID = " & ID)
    End Function
End Class

Public Class clsData_User
    Inherits BizzLib.clsOneTableData

    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                   ByVal WhereClause As String, ByVal OrderByTxt As String)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "UserID", "SELECT * FROM securityuser ", WhereClause, OrderByTxt)
    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                   ByVal UserID As Integer, ByVal OrderByTxt As String)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "UserID", "SELECT * FROM securityuser ", " WHERE UserID = " & UserID & " ", OrderByTxt)
    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(SessionInfo)
    End Sub

    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        Return _MsgID
    End Function
    Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        'Check ID
        If Row1(IDField) & "" = "" Then
            Row1(IDField) = BKGlobal.GetNextID(IDField)
        End If
        'Check Name
        If Row1("FullName") & "" = "" Then
            'Name Cannot Be Blank
            _MsgID = 5
        End If
        'Check Login
        If Row1("Login") & "" = "" Then
            'Login Cannot Be Blank
            _MsgID = 14
        End If
        'Check PassWord
        If Row1("PassWord") & "" = "" Then
            'PassWord Cannot Be Blank
            _MsgID = 15
        End If
        Return _MsgID
    End Function

    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("Select Count(*) FROM securityuser WHERE " & IDFieldName & " = " & ID)
    End Function
    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE securityuser WHERE UserID = " & ID)
    End Function
End Class
