Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Namespace BizzLib
    Public Class clsDataSet
        ' Methods
        Public Sub New(ByVal CurrSessionInfo As clsSessionInfo)
            Me.SessionInfo = CurrSessionInfo
        End Sub

        Public Function ExecuteNonQuery(ByVal SQLtxt As String, ByVal Optional vBoolCopyToClipBoard As Boolean = True) As Integer
            Dim num As Integer
            If (Me.SessionInfo.DBName = "") Then
                moGeneral.OleDBConnInitialize(Me.SessionInfo)
            End If
            If (Me.SessionInfo.DBConnType = "OLEDB") Then
                Dim command As New OleDbCommand(SQLtxt, Me.SessionInfo.OleDBConn)
                Me.SessionInfo.OleDBConn.Open
                num = command.ExecuteNonQuery
            End If
            If (Me.SessionInfo.DBConnType = "SQL") Then
                Dim command2 As New SqlCommand(SQLtxt, Me.SessionInfo.SQLDBConn)
                If (Me.SessionInfo.SQLDBConn.State <> ConnectionState.Open) Then
                    Me.SessionInfo.SQLDBConn.Open
                End If
                num = command2.ExecuteNonQuery
            End If
            If (Me.SessionInfo.DBConnType = "MySQL") Then
                Dim command3 As New MySqlCommand(SQLtxt, Me.SessionInfo.MySqlDbConn)
                If ((Me.SessionInfo.MySqlDbConn.State = ConnectionState.Closed) Or (Me.SessionInfo.MySqlDbConn.State = ConnectionState.Broken)) Then
                    Me.SessionInfo.MySqlDbConn.Open
                End If
                Try 
                    num = command3.ExecuteNonQuery
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Interaction.InputBox(exception.Message, "SQL String causing the error", SQLtxt, -1, -1)
                    ProjectData.ClearProjectError
                End Try
            End If
            Return num
        End Function

        Public Sub FillDataSet(ByVal dataTable1 As DataTable, ByVal OleDBDataAdapter1 As OleDbDataAdapter, ByVal Optional vBoolCopyToClipBoard As Boolean = True)
            If (Me.SessionInfo.DBName = "") Then
                moGeneral.OleDBConnInitialize(Me.SessionInfo)
            End If
            dataTable1.DataSet.EnforceConstraints = False
            Try 
                If (Me.SessionInfo.DBConnType = "OLEDB") Then
                    Me.SessionInfo.OleDBConn.Open
                    Me._oledb = New OleDbDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, Me.SessionInfo.OleDBConn)
                    Me._oledb.Fill(dataTable1)
                End If
                If (Me.SessionInfo.DBConnType = "SQL") Then
                    If (Me.SessionInfo.SQLDBConn.State <> ConnectionState.Open) Then
                        Me.SessionInfo.SQLDBConn.Open
                    End If
                    Me._sqlole = New SqlDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, Me.SessionInfo.SQLDBConn)
                    Me._sqlole.Fill(dataTable1)
                End If
                If (Me.SessionInfo.DBConnType = "MySQL") Then
                    If ((Me.SessionInfo.MySqlDbConn.State = ConnectionState.Closed) Or (Me.SessionInfo.MySqlDbConn.State = ConnectionState.Broken)) Then
                        Me.SessionInfo.MySqlDbConn.Open
                    End If
                    Me._mysqlole = New MySqlDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, Me.SessionInfo.MySqlDbConn)
                    Me._mysqlole.Fill(dataTable1)
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.InputBox(exception.Message, "SQL String causing the error", OleDBDataAdapter1.SelectCommand.CommandText, -1, -1)
                Throw exception
                ProjectData.ClearProjectError
            Finally
                dataTable1.DataSet.EnforceConstraints = True
                If (((Me.SessionInfo.DBConnType <> "OLEDB") AndAlso (Me.SessionInfo.DBConnType <> "SQL")) AndAlso (Me.SessionInfo.DBConnType = "MySQL")) Then
                End If
            End Try
        End Sub

        Public Sub FillDataSet(ByVal dataTable1 As DataTable, ByVal SQLTxt As String, ByVal Optional vBoolCopyToClipBoard As Boolean = True, ByVal Optional vBoolNewConn As Boolean = False)
            If (Me.SessionInfo.DBName = "") Then
                moGeneral.OleDBConnInitialize(Me.SessionInfo)
            End If
            Try 
                If (Me.SessionInfo.DBConnType = "OLEDB") Then
                    Me.SessionInfo.OleDBConn.Open
                    Me._oledb = New OleDbDataAdapter(SQLTxt, Me.SessionInfo.OleDBConn)
                    Me._oledb.Fill(dataTable1)
                End If
                If (Me.SessionInfo.DBConnType = "SQL") Then
                    If (Me.SessionInfo.SQLDBConn.State <> ConnectionState.Open) Then
                        Me.SessionInfo.SQLDBConn.Open
                    End If
                    Me._sqlole = New SqlDataAdapter(SQLTxt, Me.SessionInfo.SQLDBConn)
                    Me._sqlole.Fill(dataTable1)
                End If
                If (Me.SessionInfo.DBConnType = "MySQL") Then
                    Dim mySqlDbConn As MySqlConnection
                    If vBoolNewConn Then
                        mySqlDbConn = New MySqlConnection(Me.SessionInfo.DBConnString)
                    Else
                        mySqlDbConn = Me.SessionInfo.MySqlDbConn
                    End If
                    Me._mysqlole = New MySqlDataAdapter(SQLTxt, mySqlDbConn)
                    Me._mysqlole.Fill(dataTable1)
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.InputBox(exception.Message, "SQL String causing the error", SQLTxt, -1, -1)
                Throw exception
                ProjectData.ClearProjectError
            Finally
                If (((Me.SessionInfo.DBConnType <> "OLEDB") AndAlso (Me.SessionInfo.DBConnType <> "SQL")) AndAlso (Me.SessionInfo.DBConnType = "MySQL")) Then
                End If
            End Try
        End Sub

        Public Function GetReader(ByVal SQLTxt As String, ByVal Optional vBoolCopyToClipBoard As Boolean = True) As Object
            If (Me.SessionInfo.DBName = "") Then
                moGeneral.OleDBConnInitialize(Me.SessionInfo)
            End If
            Try 
                If (Me.SessionInfo.DBConnType = "OLEDB") Then
                    Me.SessionInfo.OleDBConn.Open
                    Me._oleCmd = New OleDbCommand(SQLTxt, Me.SessionInfo.OleDBConn)
                    Return Me._oleCmd.ExecuteReader
                End If
                If (Me.SessionInfo.DBConnType = "SQL") Then
                    If (Me.SessionInfo.SQLDBConn.State <> ConnectionState.Open) Then
                        Me.SessionInfo.SQLDBConn.Open
                    End If
                    Me._SQLCmd = New SqlCommand(SQLTxt, Me.SessionInfo.SQLDBConn)
                    Return Me._SQLCmd.ExecuteReader
                End If
                If (Me.SessionInfo.DBConnType = "MySQL") Then
                    If ((Me.SessionInfo.MySqlDbConn.State = ConnectionState.Closed) Or (Me.SessionInfo.MySqlDbConn.State = ConnectionState.Broken)) Then
                        Me.SessionInfo.MySqlDbConn.Open
                    End If
                    Me._MySqlOleCmd = New MySqlCommand(SQLTxt, Me.SessionInfo.MySqlDbConn)
                    Return Me._MySqlOleCmd.ExecuteReader
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.InputBox(exception.Message, "SQL String causing the error", SQLTxt, -1, -1)
                Throw exception
                ProjectData.ClearProjectError
            End Try
            Return Nothing
        End Function

        Public Sub UpdateDataSource(ByVal ChangedRows As DataTable, ByVal Optional vBoolCopyToClipBoard As Boolean = True)
            If (Me.SessionInfo.DBName = "") Then
                moGeneral.OleDBConnInitialize(Me.SessionInfo)
            End If
            Try 
                If (Not ChangedRows Is Nothing) Then
                    If (Me.SessionInfo.DBConnType = "OLEDB") Then
                        Dim builder As New OleDbCommandBuilder(Me._oledb)
                        Me.SessionInfo.OleDBConn.Open
                        Me._oledb.Update(ChangedRows)
                    End If
                    If (Me.SessionInfo.DBConnType = "SQL") Then
                        If ((Me.SessionInfo.SQLDBConn.State <> ConnectionState.Open) Or (Me.SessionInfo.MySqlDbConn.State = ConnectionState.Broken)) Then
                            Me.SessionInfo.SQLDBConn.Open
                        End If
                        Dim builder2 As New SqlCommandBuilder(Me._sqlole)
                        Me._sqlole.Update(ChangedRows)
                    End If
                    If (Me.SessionInfo.DBConnType = "MySQL") Then
                        If (Me.SessionInfo.MySqlDbConn.State = ConnectionState.Closed) Then
                            Me.SessionInfo.MySqlDbConn.Open
                        End If
                        Dim builder3 As New MySqlCommandBuilder(Me._mysqlole)
                        Me._mysqlole.Update(ChangedRows)
                    End If
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.InputBox(exception.Message, "SQL String causing the error", Me._mysqlole.SelectCommand.ToString, -1, -1)
                Throw exception
                ProjectData.ClearProjectError
            Finally
                If (((Me.SessionInfo.DBConnType <> "OLEDB") AndAlso (Me.SessionInfo.DBConnType <> "SQL")) AndAlso (Me.SessionInfo.DBConnType = "MySQL")) Then
                End If
            End Try
        End Sub

        Public Sub UpdateDataSource(ByVal ChangedRows As DataTable, ByVal OleDBDataAdapter1 As OleDbDataAdapter, ByVal Optional vBoolCopyToClipBoard As Boolean = True)
            If (Me.SessionInfo.DBName = "") Then
                moGeneral.OleDBConnInitialize(Me.SessionInfo)
            End If
            Try 
                If (Not ChangedRows Is Nothing) Then
                    If (Me.SessionInfo.DBConnType = "OLEDB") Then
                        Me.SessionInfo.OleDBConn.Open
                        Me._oledb = New OleDbDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, Me.SessionInfo.OleDBConn)
                        Dim builder As New OleDbCommandBuilder(Me._oledb)
                        Me._oledb.Update(ChangedRows)
                    End If
                    If (Me.SessionInfo.DBConnType = "SQL") Then
                        If (Me.SessionInfo.SQLDBConn.State <> ConnectionState.Open) Then
                            Me.SessionInfo.SQLDBConn.Open
                        End If
                        Me._sqlole = New SqlDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, Me.SessionInfo.SQLDBConn)
                        Dim builder2 As New SqlCommandBuilder(Me._sqlole)
                        Me._sqlole.Update(ChangedRows)
                    End If
                    If (Me.SessionInfo.DBConnType = "MySQL") Then
                        Me._mysqlole = New MySqlDataAdapter(OleDBDataAdapter1.SelectCommand.CommandText, Me.SessionInfo.MySqlDbConn)
                        Dim builder3 As New MySqlCommandBuilder(Me._mysqlole)
                        Me._mysqlole.Update(ChangedRows)
                    End If
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.InputBox(exception.Message, "SQL String causing the error", OleDBDataAdapter1.SelectCommand.CommandText, -1, -1)
                Throw exception
                ProjectData.ClearProjectError
            Finally
                If (((Me.SessionInfo.DBConnType <> "OLEDB") AndAlso (Me.SessionInfo.DBConnType <> "SQL")) AndAlso (Me.SessionInfo.DBConnType = "MySQL")) Then
                End If
            End Try
        End Sub

        Public Sub UpdateDataSource(ByVal ChangedRows As DataTable, ByVal SELECTSQLTxt As String, ByVal Optional vBoolCopyToClipBoard As Boolean = True)
            If (Me.SessionInfo.DBName = "") Then
                moGeneral.OleDBConnInitialize(Me.SessionInfo)
            End If
            Try 
                If (Not ChangedRows Is Nothing) Then
                    If (Me.SessionInfo.DBConnType = "OLEDB") Then
                        Me.SessionInfo.OleDBConn.Open
                        Me._oledb = New OleDbDataAdapter(SELECTSQLTxt, Me.SessionInfo.OleDBConn)
                        Dim builder As New OleDbCommandBuilder(Me._oledb)
                        Me._oledb.Update(ChangedRows)
                    End If
                    If (Me.SessionInfo.DBConnType = "SQL") Then
                        If ((Me.SessionInfo.SQLDBConn.State <> ConnectionState.Open) Or (Me.SessionInfo.MySqlDbConn.State = ConnectionState.Broken)) Then
                            Me.SessionInfo.SQLDBConn.Open
                        End If
                        Me._sqlole = New SqlDataAdapter(SELECTSQLTxt, Me.SessionInfo.SQLDBConn)
                        Dim builder2 As New SqlCommandBuilder(Me._sqlole)
                        Me._sqlole.Update(ChangedRows)
                    End If
                    If (Me.SessionInfo.DBConnType = "MySQL") Then
                        If (Me.SessionInfo.MySqlDbConn.State = ConnectionState.Closed) Then
                            Me.SessionInfo.MySqlDbConn.Open
                        End If
                        Me._mysqlole = New MySqlDataAdapter(SELECTSQLTxt, Me.SessionInfo.MySqlDbConn)
                        Dim builder3 As New MySqlCommandBuilder(Me._mysqlole)
                        Me._mysqlole.Update(ChangedRows)
                    End If
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.InputBox(exception.Message, "SQL String causing the error", SELECTSQLTxt, -1, -1)
                Throw exception
                ProjectData.ClearProjectError
            Finally
                If (((Me.SessionInfo.DBConnType <> "OLEDB") AndAlso (Me.SessionInfo.DBConnType <> "SQL")) AndAlso (Me.SessionInfo.DBConnType = "MySQL")) Then
                End If
            End Try
        End Sub


        ' Fields
        Private _mysqlole As MySqlDataAdapter
        Private _MySqlOleCmd As MySqlCommand
        Private _MySqlOleRD As MySqlDataReader
        Private _oleCmd As OleDbCommand
        Private _oledb As OleDbDataAdapter
        Private _oledbRD As OleDbDataReader
        Private _SQLCmd As SqlCommand
        Private _sqlole As SqlDataAdapter
        Private _SQLOleRD As SqlDataReader
        Private SessionInfo As clsSessionInfo
    End Class
End Namespace

