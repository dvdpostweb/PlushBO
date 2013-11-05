Public Class clsMoviewmax_info
    Inherits BizzLib.clsOneTableData

    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "products_id", "SELECT * FROM feesharing_moviemax_input ", WhereClause, OrderByTxt)
    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(SessionInfo)
    End Sub

    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        ''Check if Entity Exist
        'If Row1.Item("HoldingID") & "" <> "" Then
        '    Dim _DataEntity As New BizzLib.clsData_Entity(SessionInfo)
        '    If _DataEntity.Exists("HoldingID", Row1.Item("HoldingID")) Then
        '        'Cannot Delete - Entities as Attached to this Holding
        '        _MsgID = 12
        '    End If
        'End If
        Return _MsgID
    End Function
    Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        'Check ID
        If Row1.Item(IDField) & "" = "" Then
            _MsgID = 106 'You must select a Product
            'Row1.Item(IDField) = BKGlobal.GetNextID(IDField)
        End If
        'Check Name
        'If Row1.Item("Name") & "" = "" Then
        '    'Name Cannot Be Blank
        '    _MsgID = 5
        'End If
        Return _MsgID
    End Function

    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("Select Count(*) FROM feesharing_moviemax_input WHERE " & IDFieldName & " = " & ID)
    End Function
    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE feesharing_moviemax_input WHERE products_id = " & ID)
    End Function
End Class
