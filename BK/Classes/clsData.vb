'Public Class clsDataSet
'    Dim _sqlole As SqlClient.SqlDataAdapter
'    Dim _oledb As OleDb.OleDbDataAdapter

'    Public Sub UpdateDataSource(ByVal ChangedRows As DataTable, ByVal OleDBDataAdapter1 As OleDb.OleDbDataAdapter)
'        Try
'            'The data source only needs to be updated if there are changes pending.
'            If (Not (ChangedRows) Is Nothing) Then
'                If UsedConnection = "OLEDB" Then
'                    OleDBConn.Open()
'                    _oledb = New OleDb.OleDbDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, OleDBConn)
'                    Dim _bld As New OleDb.OleDbCommandBuilder(_oledb)
'                    _oledb.Update(ChangedRows)
'                End If
'                If UsedConnection = "SQL" Then
'                    SQLDBConn.Open()
'                    _sqlole = New SqlClient.SqlDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, SQLDBConn)
'                    Dim _bld As New SqlClient.SqlCommandBuilder(_sqlole)
'                    _sqlole.Update(ChangedRows)
'                End If
'            End If
'        Catch updateException As System.Exception
'            'Add your error handling code here.
'            Throw updateException
'        Finally
'            If UsedConnection = "OLEDB" Then
'                OleDBConn.Close()
'            ElseIf UsedConnection = "SQL" Then
'                SQLDBConn.Close()
'            End If
'        End Try
'    End Sub
'    Public Sub UpdateDataSource(ByVal ChangedRows As DataTable, ByVal SELECTSQLTxt As String)
'        Try
'            'The data source only needs to be updated if there are changes pending.
'            If (Not (ChangedRows) Is Nothing) Then
'                If UsedConnection = "OLEDB" Then
'                    OleDBConn.Open()
'                    _oledb = New OleDb.OleDbDataAdapter(SELECTSQLTxt, OleDBConn)
'                    Dim _bld As New OleDb.OleDbCommandBuilder(_oledb)
'                    _oledb.Update(ChangedRows)
'                End If
'                If UsedConnection = "SQL" Then
'                    SQLDBConn.Open()
'                    _sqlole = New SqlClient.SqlDataAdapter(SELECTSQLTxt, SQLDBConn)
'                    Dim _bld As New SqlClient.SqlCommandBuilder(_sqlole)
'                    _sqlole.Update(ChangedRows)
'                End If
'            End If
'        Catch updateException As System.Exception
'            'Add your error handling code here.
'            Throw updateException
'        Finally
'            If UsedConnection = "OLEDB" Then
'                OleDBConn.Close()
'            ElseIf UsedConnection = "SQL" Then
'                SQLDBConn.Close()
'            End If
'        End Try
'    End Sub
'    Public Sub UpdateDataSource(ByVal ChangedRows As DataTable)
'        Try
'            'The data source only needs to be updated if there are changes pending.
'            If (Not (ChangedRows) Is Nothing) Then
'                If UsedConnection = "OLEDB" Then
'                    Dim _bld As New OleDb.OleDbCommandBuilder(_oledb)
'                    OleDBConn.Open()
'                    _oledb.Update(ChangedRows)
'                End If
'                If UsedConnection = "SQL" Then
'                    SQLDBConn.Open()
'                    Dim _bld As New SqlClient.SqlCommandBuilder(_sqlole)
'                    _sqlole.Update(ChangedRows)
'                End If
'            End If
'        Catch updateException As System.Exception
'            'Add your error handling code here.
'            Throw updateException
'        Finally
'            If UsedConnection = "OLEDB" Then
'                OleDBConn.Close()
'            ElseIf UsedConnection = "SQL" Then
'                SQLDBConn.Close()
'            End If
'        End Try
'    End Sub

'    Public Sub FillDataSet(ByVal dataTable1 As DataTable, ByVal OleDBDataAdapter1 As OleDb.OleDbDataAdapter)
'        'Turn off constraint checking before the dataset is filled.
'        'This allows the adapters to fill the dataset without concern
'        'for dependencies between the tables.

'        dataTable1.DataSet.EnforceConstraints = False
'        Try
'            If UsedConnection = "OLEDB" Then
'                OleDBConn.Open()
'                _oledb = New OleDb.OleDbDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, OleDBConn)
'                _oledb.Fill(dataTable1)
'                '_ds = dataTable1.DataSet.Clone
'                'OleDBDataAdapter1.Fill(_ds.Tables(dataTable1.TableName))
'                'dataTable1.DataSet.Merge(_ds.Tables(dataTable1.TableName))
'                'dataTable1 = _ds.Tables(dataTable1.TableName).Copy)
'            End If
'            If UsedConnection = "SQL" Then
'                'SQLDBConn.Open()
'                _sqlole = New SqlClient.SqlDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, SQLDBConn)
'                _sqlole.Fill(dataTable1)
'            End If
'        Catch fillException As System.Exception
'            'Add your error handling code here.
'            Throw fillException
'        Finally
'            'Turn constraint checking back on.
'            dataTable1.DataSet.EnforceConstraints = True
'            If UsedConnection = "OLEDB" Then
'                OleDBConn.Close()
'            ElseIf UsedConnection = "SQL" Then
'                'SQLDBConn.Close()
'            End If
'        End Try
'    End Sub
'    Public Sub FillDataSet(ByVal dataTable1 As DataTable, ByVal SQLTxt As String)
'        'Turn off constraint checking before the dataset is filled.
'        'This allows the adapters to fill the dataset without concern
'        'for dependencies between the tables.

'        'dataTable1.DataSet.EnforceConstraints = False
'        Try
'            If UsedConnection = "OLEDB" Then
'                OleDBConn.Open()
'                _oledb = New OleDb.OleDbDataAdapter(SQLTxt, OleDBConn)
'                _oledb.Fill(dataTable1)
'            End If
'            If UsedConnection = "SQL" Then
'                'SQLDBConn.Open()
'                _sqlole = New SqlClient.SqlDataAdapter(SQLTxt, SQLDBConn)
'                _sqlole.Fill(dataTable1)
'            End If
'        Catch fillException As System.Exception
'            'Add your error handling code here.
'            Throw fillException
'        Finally
'            'Turn constraint checking back on.
'            'dataTable1.DataSet.EnforceConstraints = True
'            If UsedConnection = "OLEDB" Then
'                OleDBConn.Close()
'            ElseIf UsedConnection = "SQL" Then
'                'SQLDBConn.Close()
'            End If
'        End Try
'    End Sub
'    Public Function ExecuteNonQuery(ByVal SQLtxt As String) As Integer
'        Dim _int As Integer
'        If UsedConnection = "OLEDB" Then
'            Dim _Cmd1 As OleDb.OleDbCommand
'            _Cmd1 = New OleDb.OleDbCommand(SQLtxt, OleDBConn)
'            OleDBConn.Open()
'            _int = _Cmd1.ExecuteNonQuery
'            OleDBConn.Close()
'        End If
'        If UsedConnection = "SQL" Then
'            Dim _Cmd1 As New SqlClient.SqlCommand(SQLtxt, SQLDBConn)
'            SQLDBConn.Open()
'            _int = _Cmd1.ExecuteNonQuery()
'            SQLDBConn.Close()
'        End If
'        Return _int
'    End Function
'End Class

