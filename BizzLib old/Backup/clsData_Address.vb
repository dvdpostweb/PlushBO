Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace BizzLib
    Public Class clsData_Address
        Inherits clsOneTableData
        ' Methods
        Public Sub New(ByVal SessionInfo As clsSessionInfo)
            MyBase.New(SessionInfo)
            Me.mvarEmployeeTableName = "CRMEmployee"
            Me.mvarCustomerTableName = "CRMCustomer"
            Me.mvarSupplierTableName = "CRMSupplier"
        End Sub

        Public Sub New(ByVal SessionInfo As clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal ID As Integer)
            MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "AddrID", "SELECT * FROM GeneralAddress", (" WHERE AddrID = " & Conversions.ToString(ID)), "")
            Me.mvarEmployeeTableName = "CRMEmployee"
            Me.mvarCustomerTableName = "CRMCustomer"
            Me.mvarSupplierTableName = "CRMSupplier"
            If (DataSet1.Tables.Item(TableName).Rows.Count = 0) Then
                Dim row As DataRow = DataSet1.Tables.Item(TableName).NewRow
                row.Item("AddrID") = ID
                DataSet1.Tables.Item(TableName).Rows.Add(row)
            End If
        End Sub

        Public Sub New(ByVal SessionInfo As clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal WhereClause As String, ByVal OrderByTxt As String, ByVal Optional ALLEntities As Boolean = False)
            MyBase.New(SessionInfo)
            Me.mvarEmployeeTableName = "CRMEmployee"
            Me.mvarCustomerTableName = "CRMCustomer"
            Me.mvarSupplierTableName = "CRMSupplier"
            If Not ALLEntities Then
                If ((WhereClause & "") = "") Then
                    WhereClause = (" WHERE EntityID in " & SessionInfo.AllowedEntityList)
                Else
                    WhereClause = (WhereClause & " AND ( EntityID IN " & SessionInfo.AllowedEntityList & " ) ")
                End If
            End If
            MyBase.Initialize(DataSet1, DataSetType, TableName, "AddrID", "SELECT * FROM GeneralAddress", WhereClause, OrderByTxt)
        End Sub

        Public Overrides Sub Delete(ByVal ID As Integer)
            Dim msgNbr As Integer = -1
            Dim view As New DataView(Me.DataSet1.Tables.Item(Me.TableName), (Me.IDField & " = " & Conversions.ToString(ID)), Me.IDField, DataViewRowState.CurrentRows)
            If (view.Count <> 0) Then
                msgNbr = Me.ValidateRecordBeforeDelete(view.Item(0))
                If (msgNbr > 0) Then
                    Dim exception As New Exception(MyBase.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                    exception.Source = "##"
                    Throw exception
                End If
                If (Operators.ConditionalCompareObjectEqual(view.Item(0).Item("EmployeeYN"), True, False) AndAlso Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(view.Item(0).Item("EmployeeID")))) Then
                    Me.LoadEmployee(Me.DataSet1, "dsCRM", Conversions.ToInteger(view.Item(0).Item("EmployeeID")))
                    Me.mvarEmployeeData.Delete(Conversions.ToInteger(view.Item(0).Item("EmployeeID")))
                End If
                view.Item(0).Delete
                Me.Save
            End If
        End Sub

        Public Overrides Function DeleteByID(ByVal ID As Integer) As Integer
            Return MyBase.BKGlobal.ExecuteDelete(("DELETE GeneralAddress WHERE AddrID = " & Conversions.ToString(ID)))
        End Function

        Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
            Return MyBase.BKGlobal.ExecuteExists(("Select Count(*) FROM GeneralAddress WHERE " & IDFieldName & " = " & Conversions.ToString(ID)))
        End Function

        Public Sub LoadCustomer(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal CustomerID As Integer)
            DataSet1.Tables.Item(Me.mvarCustomerTableName).Clear
            Me.mvarCustomerData = New clsData_Customer(Me.SessionInfo, DataSet1, DataSetType, Me.mvarCustomerTableName, (" WHERE CustomerID = " & Conversions.ToString(CustomerID)), "")
        End Sub

        Public Sub LoadEmployee(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal EmployeeID As Integer)
            Me.mvarEmployeeData = New clsData_Employee(Me.SessionInfo, DataSet1, DataSetType, Me.mvarEmployeeTableName, (" WHERE EmployeeID = " & Conversions.ToString(EmployeeID)), "")
        End Sub

        Public Sub Save()
            Me.SaveOnlyAddr
        End Sub

        Public Sub SaveOnlyAddr()
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

        Public Sub SaveOnlyCustomer()
            If Not Information.IsNothing(Me.mvarCustomerData) Then
                Dim msgNbr As Integer = -1
                Try 
                    msgNbr = Me.ValidateDataSetBeforeSave
                    If (msgNbr > 0) Then
                        Throw New Exception(MyBase.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                    End If
                    Me.mvarCustomerData.SaveOnlyCustomer
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Throw exception
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Public Sub SaveOnlyEmployee()
            Dim msgNbr As Integer = -1
            Try 
                msgNbr = Me.ValidateDataSetBeforeSave
                If (msgNbr > 0) Then
                    Throw New Exception(MyBase.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                End If
                Me.mvarEmployeeData.SaveOnlyEmployee
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
            Dim num2 As Integer
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Row1.Item("AddrID"), ""), "", False) Then
                Row1.Item("AddrID") = MyBase.BKGlobal.GetNextID("AddrID")
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Row1.Item("Name"), ""), "", False) Then
            End If
            Return num2
        End Function


        ' Properties
        Public ReadOnly Property CustomerData As DataTable
            Get
                Return Me.mvarCustomerData.TableOfData
            End Get
        End Property

        Public ReadOnly Property EmployeeData As DataTable
            Get
                Return Me.mvarEmployeeData.TableOfData
            End Get
        End Property


        ' Fields
        Private mvarCustomerData As clsData_Customer
        Private mvarCustomerTableName As String
        Private mvarEmployeeData As clsData_Employee
        Private mvarEmployeeTableName As String
        Private mvarSupplierTableName As String
    End Class
End Namespace

