Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Runtime.CompilerServices

Namespace BizzLib
    Public Class clsData_Customer
        Inherits clsOneTableData
        ' Methods
        Public Sub New(ByVal SessionInfo As clsSessionInfo)
            MyBase.New(SessionInfo)
            Me.mvarAddrTableName = "GeneralAddress"
        End Sub

        Public Sub New(ByVal SessionInfo As clsSessionInfo, ByVal DataSet1 As DataSet, ByVal CustomerID As Integer, ByVal DataSetType As String, ByVal TableName As String)
            MyBase.New(SessionInfo)
            Me.mvarAddrTableName = "GeneralAddress"
            Dim whereClause As String = (" where CustomerID = " & Conversions.ToString(CustomerID) & " ")
            MyBase.Initialize(DataSet1, DataSetType, TableName, "CustomerID", "SELECT * FROM CRMCustomer", whereClause, "")
        End Sub

        Public Sub New(ByVal SessionInfo As clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
            MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "CustomerID", "SELECT * FROM CRMCustomer", WhereClause, OrderByTxt)
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
                view.Item(0).Delete
                Me.SaveOnlyCustomer
            End If
        End Sub

        Public Overrides Function DeleteByID(ByVal ID As Integer) As Integer
            Dim num As Integer
            Return num
        End Function

        Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
            Return MyBase.BKGlobal.ExecuteExists(("Select Count(*) FROM CRMCustomer WHERE " & IDFieldName & " = " & Conversions.ToString(ID)))
        End Function

        Public Sub LoadAddress(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal AddrID As Integer)
            Me.mvarAddrData = New clsData_Address(Me.SessionInfo, DataSet1, DataSetType, Me.mvarAddrTableName, AddrID)
            Me.mvarAddrData.TableOfData.Columns.Item("PersonYN").DefaultValue = 0
            Me.mvarAddrData.TableOfData.Columns.Item("EntityYN").DefaultValue = False
            Me.mvarAddrData.TableOfData.Columns.Item("BankYN").DefaultValue = False
            Me.mvarAddrData.TableOfData.Columns.Item("CustomerYN").DefaultValue = True
            Me.mvarAddrData.TableOfData.Columns.Item("SupplierYN").DefaultValue = False
            Me.mvarAddrData.TableOfData.Columns.Item("EmployeeYN").DefaultValue = True
            Me.mvarAddrData.TableOfData.Columns.Item("LocYN").DefaultValue = False
            If Not Information.IsNothing(Me.mvarAddrData.TableOfData.Rows.Item(0)) Then
                Dim row As DataRow = Me.mvarAddrData.TableOfData.Rows.Item(0)
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Item("PersonYN"))) Then
                    row.Item("PersonYN") = 0
                End If
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Item("EntityYN"))) Then
                    row.Item("EntityYN") = False
                End If
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Item("BankYN"))) Then
                    row.Item("BankYN") = False
                End If
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Item("CustomerYN"))) Then
                    row.Item("CustomerYN") = True
                End If
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Item("SupplierYN"))) Then
                    row.Item("SupplierYN") = False
                End If
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Item("EmployeeYN"))) Then
                    row.Item("EmployeeYN") = True
                End If
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Item("LocYN"))) Then
                    row.Item("LocYN") = False
                End If
                row = Nothing
            End If
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

        Public Sub SaveOnlyCustomer()
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
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Row1.Item("CustomerID"), ""), "", False) Then
                Row1.Item("CustomerID") = MyBase.BKGlobal.GetNextID("CustomerID")
            End If
            Return -1
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

