Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data

Namespace BizzLib
    Public Class clsCRMcountry
        Inherits clsOneTableData
        ' Methods
        Public Sub New(ByVal SessionInfo As clsSessionInfo)
            MyBase.New(SessionInfo)
        End Sub

        Public Sub New(ByVal SessionInfo As clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
            MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "Code", "SELECT * FROM CRMcountry ", WhereClause, OrderByTxt)
        End Sub

        Public Function DeleteByCode(ByVal Code As String) As Integer
            Return MyBase.BKGlobal.ExecuteDelete(("DELETE CRMcountry WHERE Code = '" & Code & "'"))
        End Function

        Public Overrides Function DeleteByID(ByVal ID As Integer) As Integer
            Return -1
        End Function

        Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
            Return True
        End Function

        Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As DataRowView) As Integer
            Return -1
        End Function

        Public Overrides Function ValidateRecordFields(ByRef Row1 As DataRowView) As Integer
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Row1.Item(Me.IDField), ""), "", False) Then
                Row1.Item(Me.IDField) = MyBase.BKGlobal.GetNextID(Me.IDField)
            End If
            Return -1
        End Function

    End Class
End Namespace

