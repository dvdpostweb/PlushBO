Imports MySql.Data.MySqlClient

Public Class clsConnection

    Private Const _TIMEOUT As Integer = 120 * 60
    Private Shared ITimeout As Integer = 0
    Private Const SEPARATOR As String = ";*;"
    Private Shared _connectWrite As MySqlConnection
    Private Shared _connectRead As MySqlConnection
    Private Shared _StackTransaction As System.Collections.Generic.Stack(Of MySqlTransaction)
    'Private Shared _transact As MySqlTransaction
    Private Shared _typeEnv As String
    Private Shared _dataAdapter As MySqlDataAdapter
    Private Shared _isBulkQuery As Boolean ' only before commitransation you execute the bulkquery
    Private Shared _BulkQuery As String  ' all query
    Private Shared _connectionString As String

    Public Enum typeAccessDb
        WRITE
        READ
    End Enum
    Public Shared Function GetTransaction() As MySqlTransaction

        If _StackTransaction IsNot Nothing AndAlso _StackTransaction.Count > 0 Then
            Return _StackTransaction.Peek()
        End If

        Return Nothing
    End Function

    Public Shared Function Pop() As MySqlTransaction
        If _StackTransaction IsNot Nothing AndAlso _StackTransaction.Count > 0 Then
            Return _StackTransaction.Pop()
        End If
        Return Nothing
    End Function
    Public Shared Sub Push(ByVal trans As MySqlTransaction)

        If _StackTransaction Is Nothing Then
            _StackTransaction = New Stack(Of MySqlTransaction)
        End If
        _StackTransaction.Push(trans)
    End Sub

    Public Shared ReadOnly Property ConnectionString() As String
        Get
            Return _connectionString
        End Get
    End Property

    Public Shared ReadOnly Property bulkQuery() As String
        Get
            Return _BulkQuery & _isBulkQuery.ToString()
        End Get
    End Property
    Public Shared Property timeoutMIN() As Integer
        Get
            Return ITimeout
        End Get
        Set(ByVal value As Integer)
            ITimeout = value * 60
        End Set
    End Property


    Public Shared Property typeEnv() As String
        Get
            Return _typeEnv
        End Get
        Set(ByVal value As String)
            If Not _connectWrite Is Nothing AndAlso _connectWrite.State = ConnectionState.Open Then
                _connectWrite.Close()
            End If
            _typeEnv = value

        End Set
    End Property
    Public Shared Property ConnectType(ByVal access As typeAccessDb) As MySqlConnection

        Get
            Dim connect As MySql.Data.MySqlClient.MySqlConnection
            connect = GetConnect(access)

            If connect Is Nothing OrElse connect.State = ConnectionState.Closed OrElse Not connect.Ping() Then
                access = NewConnection(access)
            End If
            Return GetConnect(access)
        End Get
        Set(ByVal value As MySqlConnection)
            Dim connect As MySql.Data.MySqlClient.MySqlConnection
            connect = GetConnect(access)
            connect = value
            SetConnect(access, connect)
        End Set
    End Property

    Private Shared Sub SetConnect(ByVal access As typeAccessDb, ByVal ConnectType As MySqlConnection)
        If access = typeAccessDb.WRITE Then
            _connectWrite = ConnectType
        Else
            _connectRead = ConnectType
        End If
    End Sub

    Private Shared Function GetConnect(ByVal access As typeAccessDb) As MySqlConnection
        If access = typeAccessDb.WRITE Then
            Return _connectWrite
        Else
            Return _connectRead
        End If
    End Function
    Private Shared Function GetStackTrace() As String
        Dim stackTrace As StackTrace = New StackTrace()           ' get call stack
        Dim stackFrames() As StackFrame = stackTrace.GetFrames()  ' get method calls (frames)

        ' write call stack method names
        Dim result As String = ""
        Dim index As Integer = 0
        For Each stackFrame As StackFrame In stackFrames
            If index > 0 Then
                result += stackFrame.GetMethod().Name & vbNewLine ' write method name
            End If
            If index = 6 Then Exit For
            index += 1
        Next

        Return result
    End Function
    Public Shared Sub CreateTransaction(ByVal isBulkQuery As Boolean)
        Dim sql As String
        Dim trans As MySqlTransaction = GetTransaction()

        If trans IsNot Nothing Then

            sql = clsMsgError.InsertLogMsg(clsMsgError.processType.Batch, " error create transaction but exist an other transaction not finished !!")
            PlushData.clsConnection.ExecuteNonQuery(sql, True)

        Else
            If _connectWrite IsNot Nothing Then
                _connectWrite.Close()
                ConnectType(typeAccessDb.WRITE) = Nothing
            End If
            NewConnection(typeAccessDb.WRITE)
        End If

        _isBulkQuery = isBulkQuery
        If Not isBulkQuery Then
            If trans Is Nothing Then
                Push(_connectWrite.BeginTransaction())
            End If
        Else
            If _BulkQuery IsNot Nothing AndAlso _BulkQuery IsNot String.Empty Then
                Dim cpt_result As Integer
                ExecuteBulkQuery(clsMsgError.processType.Email, cpt_result)
            End If
            _BulkQuery = String.Empty

        End If

        Dim stack As String = GetStackTrace()
        sql = clsMsgError.InsertLogMsg(clsMsgError.processType.Batch, "user : " & clsSession.FullName & " StackTrace : " & stack & " | create transaction bulquery : " & isBulkQuery)
        PlushData.clsConnection.ExecuteNonQuery(sql, True)
    End Sub

    Private Shared Function CutQuery(ByVal sqlScript As String) As List(Of String)

        Dim lstTmp As String()
        Dim sqlTmp As String
        Dim result As List(Of String) = New List(Of String)
        lstTmp = sqlScript.Split(New String() {SEPARATOR}, StringSplitOptions.RemoveEmptyEntries)

        sqlTmp = ""
        ' couper toutes les 20 lignes 
        For i As Integer = 0 To lstTmp.Length - 1

            If (i + 1) Mod 20 = 0 Then
                result.Add(sqlTmp)
                sqlTmp = lstTmp(i) & ";"
            Else
                sqlTmp += lstTmp(i) & ";"
            End If
        Next
        result.Add(sqlTmp)
        Return result
    End Function
    Public Shared Function CancelBulkQuery() As Boolean
        _isBulkQuery = False
        _BulkQuery = ""
    End Function
    Public Shared Function ExecuteBulkQuery(ByVal typeProcess As PlushData.clsMsgError.processType, ByRef cpt_result As Integer) As Boolean

        If GetTransaction() Is Nothing Then
            CreateTransaction(False)
        End If

        Try
            cpt_result = 0
            Dim result As List(Of String)
            If (_BulkQuery IsNot Nothing AndAlso _BulkQuery IsNot String.Empty) Then

                result = CutQuery(_BulkQuery)
                CancelBulkQuery()
                For Each sql As String In result
                    cpt_result += ExecuteNonQuery(sql)
                Next

            End If

            CommitTransaction(True)
            Return True

        Catch ex As Exception
            CommitTransaction(False)
            If Not clsSession.isBatch Then MsgBox(ex.Message)

            Dim sql As String
            sql = clsMsgError.InsertLogMsg(typeProcess, ex.Message & " " & ex.StackTrace)
            PlushData.clsConnection.ExecuteNonQuery(sql, True)
            CancelBulkQuery()
            Return False
        End Try

    End Function
    Public Shared Sub CommitTransaction(ByVal ok As Boolean)
        Dim trans As MySqlTransaction
        trans = Pop()
        If trans Is Nothing Then Return
        If ok Then
            trans.Commit()
        Else
            trans.Rollback()
        End If
        trans = Nothing


        Dim sql As String
        Dim stack As String = GetStackTrace()

        sql = clsMsgError.InsertLogMsg(clsMsgError.processType.Batch, "stack trace : " & stack & " | Commit Transaction " & ok)
        PlushData.clsConnection.ExecuteNonQuery(sql, True)
        '_transact.Dispose()
    End Sub
    Public Shared Function GetConnectionString(ByVal typeenv As String, ByVal access As typeAccessDb) As String
        Return typeenv & "-" & PlushTools.clsEnum.getNameStrEnum(access)

    End Function

    Private Shared Function NewConnection(ByVal access As typeAccessDb) As typeAccessDb

        Dim connect As MySql.Data.MySqlClient.MySqlConnection
        Dim key As String

        key = GetConnectionString(typeEnv, access)
        _connectionString = Configuration.ConfigurationManager.ConnectionStrings(key).ConnectionString
        connect = GetConnect(access)
        connect = New MySqlConnection(_connectionString)
        SetConnect(access, connect)
        ' _transact = Nothing
        Try
            connect.Open()
            Return access
        Catch
            If access = typeAccessDb.READ Then
                NewConnection(typeAccessDb.WRITE)
                Return typeAccessDb.WRITE
            End If
        End Try

    End Function

    Private Shared Function CreateCommand(ByVal sql As String, ByVal access As typeAccessDb) As MySqlCommand
        Dim mycommand As MySqlCommand
        Dim connect As MySql.Data.MySqlClient.MySqlConnection
        Dim trans As MySqlTransaction = GetTransaction()

        If Not trans Is Nothing Then
            access = typeAccessDb.WRITE
        End If
        connect = GetConnect(access)

        If trans Is Nothing Then
            mycommand = New MySqlCommand(sql, ConnectType(access))
        Else
            mycommand = New MySqlCommand(sql, ConnectType(access), trans)
        End If
        If timeoutMIN = 0 Then
            mycommand.CommandTimeout = _TIMEOUT
        Else
            mycommand.CommandTimeout = timeoutMIN
        End If
        Return mycommand

    End Function
    Public Shared Function ExecuteNonQuery(ByVal sql As String, Optional ByVal forced As Boolean = False) As Integer
        Dim mycommand As MySqlCommand


        If _isBulkQuery And Not forced Then
            _BulkQuery = _BulkQuery + sql + SEPARATOR
            ' simuler que l'update a bien eu lieu 
            Return 1
        Else

            mycommand = CreateCommand(sql, typeAccessDb.WRITE)
            Return mycommand.ExecuteNonQuery()
        End If


    End Function

    Public Shared Function ExecuteScalar(ByVal sql As String, Optional ByVal access As typeAccessDb = typeAccessDb.WRITE) As Object
        Dim mycommand As MySqlCommand
        mycommand = CreateCommand(sql, access)
        Return mycommand.ExecuteScalar()

    End Function
    Private Shared Sub Init(ByVal sql As String, ByVal access As typeAccessDb)

        If Not (ConnectType(access).State = ConnectionState.Open AndAlso _dataAdapter IsNot Nothing) Then
            _dataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, ConnectType(access))
        End If
    End Sub
    Public Shared Sub FillDataSet(ByRef dt As DataTable, ByVal sql As String, Optional ByVal access As typeAccessDb = typeAccessDb.WRITE)

        If Not GetConnect(access) Is Nothing And GetTransaction() Is Nothing Then
            GetConnect(access).Close()
        End If

        Init(sql, access)
        _dataAdapter.SelectCommand = CreateCommand(sql, access)
        _dataAdapter.Fill(dt)
        _dataAdapter.Dispose()

    End Sub

    Public Shared Function FillDataSet(ByVal sql As String, Optional ByVal access As typeAccessDb = typeAccessDb.WRITE) As DataTable
        Dim dt As DataTable = New DataTable
        Init(sql, access)
        _dataAdapter.SelectCommand = CreateCommand(sql, access)
        _dataAdapter.Fill(dt)

        Return dt

    End Function
    Public Shared Function SaveData(ByVal dt As DataTable)
        Dim cpt As Integer
        cpt = _dataAdapter.Update(dt)
        Return cpt > 0
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        If Not _connectRead Is Nothing Then
           
            _connectRead.Close()
            _connectRead.Dispose()

        End If

        If Not _connectWrite Is Nothing Then
            Dim trans As MySqlTransaction = Pop()
            If Not trans Is Nothing Then
                trans.Commit()
            End If

            _connectWrite.Close()
            _connectWrite.Dispose()

        End If
    End Sub

    Public Shared Sub UpdateDataTableInDB(ByVal dt As DataTable, ByVal sql As String)

        If dt.GetChanges() Is Nothing Then Return
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, _connectWrite)
        Dim builder As New MySqlCommandBuilder(da)
        da.Update(dt)
    End Sub

    'Public Shared Sub UpdateDataTableInDB(ByVal ds As DataSet, ByVal sql As String)

    '    If ds.GetChanges() Is Nothing Then Return
    '    Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, _connectWrite)
    '    Dim builder As New MySqlCommandBuilder(da)
    '    da.Update(ds)
    'End Sub
End Class