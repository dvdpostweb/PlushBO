Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.OleDb

Namespace BizzLib
    Public MustInherit Class clsOneTableData
        ' Methods
        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.SetBKOjects(CurrentSessionInfo)
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal IDField As String, ByVal SQLTxt As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
            Me.SetBKOjects(CurrentSessionInfo)
            Me.mvarTableName = TableName
            Me.mvarSQLTxt = SQLTxt
            Me.mvarDataSetType = DataSetType
            Me.mvarIDField = IDField
            Me.mvarDataSet = DataSet1
            Me.mvarWhereClause = WhereClause
            Me.mvarOrderByTxt = OrderByTxt
            Me.Initialize(DataSet1, String.Concat(New String() { Me.mvarSQLTxt, " ", Me.mvarWhereClause, " ", Me.mvarOrderByTxt }))
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal IDField As String, ByVal SQLTxt As String, ByVal WhereClause As String, ByVal OrderByTxt As String, ByVal LimitToAllowedEntities As Boolean)
            Me.SetBKOjects(CurrentSessionInfo)
            Me.mvarTableName = TableName
            Me.mvarSQLTxt = SQLTxt
            Me.mvarDataSetType = DataSetType
            Me.mvarIDField = IDField
            Me.mvarDataSet = DataSet1
            If LimitToAllowedEntities Then
                If (WhereClause = "") Then
                    Me.mvarWhereClause = (" WHERE EntityID IN " & Me.SessionInfo.AllowedEntityList & " ")
                Else
                    Me.mvarWhereClause = (WhereClause & " AND EntityID ID " & Me.SessionInfo.AllowedEntityList & " ")
                End If
            Else
                Me.mvarWhereClause = WhereClause
            End If
            Me.mvarOrderByTxt = OrderByTxt
            Me.Initialize(DataSet1, String.Concat(New String() { Me.mvarSQLTxt, " ", Me.mvarWhereClause, " ", Me.mvarOrderByTxt }))
        End Sub

        Public Overridable Sub Delete(ByVal ID As Integer)
            Dim msgNbr As Integer = -1
            Dim view As New DataView(Me.mvarDataSet.Tables.Item(Me.TableName), (Me.mvarIDField & " = " & Conversions.ToString(ID)), Me.mvarIDField, DataViewRowState.CurrentRows)
            If (view.Count <> 0) Then
                msgNbr = Me.ValidateRecordBeforeDelete(view.Item(0))
                If (msgNbr > 0) Then
                    Dim exception As New Exception(Me.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                    exception.Source = "##"
                    Throw exception
                End If
                view.Item(0).Delete
                Me.Save
            End If
        End Sub

        Public MustOverride Function DeleteByID(ByVal ID As Integer) As Integer

        Public MustOverride Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean

        Public Sub Initialize(ByVal DataSet1 As DataSet, ByVal SQLTxt As String)
            If Information.IsNothing(DataSet1.Tables.Item(Me.mvarTableName)) Then
                DataSet1.Tables.Add(Me.mvarTableName)
            Else
                DataSet1.Tables.Item(Me.mvarTableName).Clear
            End If
            Try 
                Me.Cls1.FillDataSet(DataSet1.Tables.Item(Me.mvarTableName), SQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
            Try 
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub Initialize(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal IDField As String, ByVal SQLTxt As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
            Me.mvarTableName = TableName
            Me.mvarSQLTxt = SQLTxt
            Me.mvarDataSetType = DataSetType
            Me.mvarIDField = IDField
            Me.mvarDataSet = DataSet1
            Me.mvarWhereClause = WhereClause
            Me.mvarOrderByTxt = OrderByTxt
            Me.Initialize(DataSet1, String.Concat(New String() { Me.mvarSQLTxt, " ", Me.mvarWhereClause, " ", Me.mvarOrderByTxt }))
        End Sub

        Public Sub Save()
            Dim msgNbr As Integer = -1
            Try 
                msgNbr = Me.ValidateDataSetBeforeSave
                If (msgNbr > 0) Then
                    Throw New Exception(Me.BKGlobal.GetMsg(msgNbr, Me.SessionInfo.UserLang, True))
                End If
                Me.SaveDataSet
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub SaveDataSet()
            Dim changes As DataSet = Me.mvarDataSet.GetChanges
            If (Not changes Is Nothing) Then
                Try 
                    Me.Cls1.UpdateDataSource(changes.Tables.Item(Me.mvarTableName), Me.mvarSQLTxt, True)
                    Me.mvarDataSet.Tables.Item(Me.mvarTableName).AcceptChanges
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Throw exception
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Public Sub SetBKOjects(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.Cls1 = New clsDataSet(Me.SessionInfo)
            Me.BKGlobal = New clsGlobal(Me.SessionInfo)
            Me.BKFilter = New clsFilter(Me.SessionInfo)
            Me.BKBrowseView = New clsBrowseView(Me.SessionInfo)
            Me.BKDefaultSet = New clsDefaultSet(Me.SessionInfo)
            Me.BKReport = New clsReport(Me.SessionInfo)
            Me.BKCombo = New clsCombo(Me.SessionInfo)
        End Sub

        Public Function ValidateDataSetBeforeSave() As Integer
            Dim num2 As Integer
            Dim enumerator As IEnumerator
            Dim view2 As New DataView(Me.DataSet1.Tables.Item(Me.mvarTableName), "", "", (DataViewRowState.ModifiedCurrent Or DataViewRowState.Added))
            Try 
                enumerator = view2.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataRowView = DirectCast(enumerator.Current, DataRowView)
                    Try 
                        Dim num As Integer = Me.ValidateRecordFields((current))
                        If (num > 0) Then
                            Return num
                        End If
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Dim exception As Exception = exception1
                        Throw exception
                        ProjectData.ClearProjectError
                    End Try
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
            Return num2
        End Function

        Public MustOverride Function ValidateRecordBeforeDelete(ByVal Row1 As DataRowView) As Integer

        Public MustOverride Function ValidateRecordFields(ByRef Row1 As DataRowView) As Integer


        ' Properties
        Public Property DataSet1 As DataSet
            Get
                Return Me.mvarDataSet
            End Get
            Set(ByVal Value As DataSet)
                Me.mvarDataSet = Value
            End Set
        End Property

        Public Property DataSetType As String
            Get
                Return Me.mvarDataSetType
            End Get
            Set(ByVal Value As String)
                Me.mvarDataSetType = Value
            End Set
        End Property

        Public ReadOnly Property IDField As String
            Get
                Return Me.mvarIDField
            End Get
        End Property

        Public Property SessionInfo As clsSessionInfo
            Get
                Return Me.mvarSessionInfo
            End Get
            Set(ByVal Value As clsSessionInfo)
                Me.mvarSessionInfo = Value
            End Set
        End Property

        Public ReadOnly Property SQLTxt As String
            Get
                Return Me.mvarSQLTxt
            End Get
        End Property

        Public ReadOnly Property TableName As String
            Get
                Return Me.mvarTableName
            End Get
        End Property

        Public ReadOnly Property TableOfData As DataTable
            Get
                Return Me.DataSet1.Tables.Item(Me.TableName)
            End Get
        End Property


        ' Fields
        Public BKBrowseView As clsBrowseView
        Public BKCombo As clsCombo
        Public BKDefaultSet As clsDefaultSet
        Public BKFilter As clsFilter
        Public BKGlobal As clsGlobal
        Public BKReport As clsReport
        Public Cls1 As clsDataSet
        Private mvarDataSet As DataSet
        Private mvarDataSetType As String
        Private mvarIDField As String
        Private mvarOrderByTxt As String
        Public mvarSessionInfo As clsSessionInfo
        Private mvarSQLTxt As String
        Private mvarTableName As String
        Private mvarWhereClause As String
        Public OleBuilder As OleDbCommandBuilder
    End Class
End Namespace

