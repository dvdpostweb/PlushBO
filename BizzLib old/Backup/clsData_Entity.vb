Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data

Namespace BizzLib
    Public Class clsData_Entity
        Inherits clsOneTableData
        ' Methods
        Public Sub New(ByVal SessionInfo As clsSessionInfo)
            MyBase.New(SessionInfo)
            Me.mvarAddrTableName = "GeneralAddress"
        End Sub

        Public Sub New(ByVal SessionInfo As clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
            MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "EntityID", "SELECT * FROM generalentity", WhereClause, OrderByTxt)
            Me.mvarAddrTableName = "GeneralAddress"
        End Sub

        Public Sub Delete(ByVal ID As Integer)
            Dim msgNbr As Integer = -1
            Dim view As New DataView(Me.DataSet1.Tables.Item(Me.TableName), (Me.IDField & " = " & Conversions.ToString(ID)), Me.IDField, DataViewRowState.CurrentRows)
            If (view.Count <> 0) Then
                msgNbr = Me.ValidateRecordBeforeDelete(view.Item(0))
                If (msgNbr > 0) Then
                    Dim exception As New Exception(MyBase.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                    exception.Source = "##"
                    Throw exception
                End If
                Me.mvarAddrData.Delete(Conversions.ToInteger(view.Item(0).Item("AddrID")))
                view.Item(0).Delete
                Me.Save
            End If
        End Sub

        Public Overrides Function DeleteByID(ByVal ID As Integer) As Integer
            Return MyBase.BKGlobal.ExecuteDelete(("DELETE generalentity WHERE EntityID = " & Conversions.ToString(ID)))
        End Function

        Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
            Return MyBase.BKGlobal.ExecuteExists(("Select Count(*) FROM generalentity WHERE " & IDFieldName & " = " & Conversions.ToString(ID)))
        End Function

        Public Function FindIDByName(ByVal Name As String) As Integer
            Return MyBase.BKGlobal.ExecuteFindID(("Select EntityID as ID FROM generalentity WHERE Name = '" & Name & "'"))
        End Function

        Public Function FindNameByID(ByVal EntityID As Integer) As String
            Return MyBase.BKGlobal.ExecuteFindFieldValue("Name", ("Select Name FROM generalentity WHERE EntityID = " & Conversions.ToString(EntityID)))
        End Function

        Public Sub LoadAddress(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal AddrID As Integer)
            Me.mvarAddrData = New clsData_Address(Me.SessionInfo, DataSet1, DataSetType, Me.mvarAddrTableName, AddrID)
            Me.mvarAddrData.TableOfData.Columns.Item("PersonYN").DefaultValue = 0
            Me.mvarAddrData.TableOfData.Columns.Item("EntityYN").DefaultValue = True
            Me.mvarAddrData.TableOfData.Columns.Item("BankYN").DefaultValue = False
            Me.mvarAddrData.TableOfData.Columns.Item("CustomerYN").DefaultValue = False
            Me.mvarAddrData.TableOfData.Columns.Item("SupplierYN").DefaultValue = False
            Me.mvarAddrData.TableOfData.Columns.Item("EmployeeYN").DefaultValue = False
            Me.mvarAddrData.TableOfData.Columns.Item("LocYN").DefaultValue = False
        End Sub

        Public Sub Save()
            Dim msgNbr As Integer = -1
            Try 
                msgNbr = Me.ValidateDataSetBeforeSave
                If (msgNbr > 0) Then
                    Throw New Exception(MyBase.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                End If
                Me.mvarAddrData.Save
                Me.SaveDataSet
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub SaveOnlyAddr()
            Dim msgNbr As Integer = -1
            Try 
                msgNbr = Me.ValidateDataSetBeforeSave
                If (msgNbr > 0) Then
                    Throw New Exception(MyBase.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                End If
                Me.mvarAddrData.Save
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub SaveOnlyEntity()
            Dim msgNbr As Integer = -1
            Try 
                msgNbr = Me.ValidateDataSetBeforeSave
                If (msgNbr > 0) Then
                    Throw New Exception(MyBase.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                End If
                Me.SaveDataSet
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As DataRowView) As Integer
            Return -1
        End Function

        Public Overrides Function ValidateRecordFields(ByRef Row1 As DataRowView) As Integer
            Dim num As Integer = -1
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Row1.Item("EntityID"), ""), "", False) Then
                Row1.Item("EntityID") = MyBase.BKGlobal.GetNextID("EntityID")
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Row1.Item("Name"), ""), "", False) Then
                num = 5
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Row1.Item("HoldingID"), ""), "", False) Then
                num = 8
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Row1.Item("CurrCode"), ""), "", False) Then
                num = 9
            End If
            Return num
        End Function


        ' Properties
        Public ReadOnly Property AddrData As DataTable
            Get
                Return Me.mvarAddrData.TableOfData
            End Get
        End Property

        Public Property AddrTableName As String
            Get
                Return Me.mvarAddrTableName
            End Get
            Set(ByVal Value As String)
                Me.mvarAddrTableName = Value
            End Set
        End Property


        ' Fields
        Private mvarAddrData As clsData_Address
        Private mvarAddrTableName As String
    End Class
End Namespace

