Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms

Namespace BizzLib
    Public Class clsSessionInfo
        ' Methods
        Public Sub New(ByVal UserID1 As Integer, ByVal RoleID1 As Integer, ByVal Optional vDBName As String = "", ByVal Optional vDBConnString As String = "", ByVal Optional vDBConType As String = "")
            Dim enumerator As IEnumerator
            Me.MDIStyle = True
            Me.AutoHideMenu = True
            Me.BannerVisible = True
            Me.FormIcon = (Application.StartupPath & "\icons\Logo.ico")
            Me.GLAcctSeparator = "-"
            Me.GlobalReportsPath = ".\reports"
            Me.DataBaseCultureInfo = "en-US"
            Me.DBName = ""
            Me.DBConnString = ""
            Me.DBConnType = ""
            Me.OleDBConn = New OleDbConnection
            Me.SQLDBConn = New SqlConnection
            Me.MySqlDbConn = New MySqlConnection
            Me.UserID = UserID1
            Me.RoleID = RoleID1
            Me.ApplDir = Application.StartupPath
            If (vDBName = "") Then
                moGeneral.OleDBConnInitialize(Me)
            Else
                Me.DBName = vDBName
                Me.DBConnString = vDBConnString
                Me.DBConnType = vDBConType
                Me.ChangeDBConnection
            End If
            Me.UserRow = Me.LoadUserData
            If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(Me.UserRow.Item("Lang"), ""), "", False) Then
                Me.UserLang = Conversions.ToString(Me.UserRow.Item("Lang"))
            Else
                Me.UserLang = "EN"
            End If
            If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.UserRow.Item("BannerVisible"))) Then
                Me.BannerVisible = Conversions.ToBoolean(Me.UserRow.Item("BannerVisible"))
            End If
            Me.UserLogin = Conversions.ToString(Me.UserRow.Item("Login"))
            Me.UserFullName = Conversions.ToString(Me.UserRow.Item("FullName"))
            Me.UserDocPath = Conversions.ToString(Operators.ConcatenateObject(Me.UserRow.Item("UserDocPath"), ""))
            Me.AutoSaveViews = Conversions.ToBoolean(Me.UserRow.Item("AutoSaveViews"))
            Me.ShowInTaskBar = Conversions.ToBoolean(Me.UserRow.Item("ShowInTaskBar"))
            Me.MDIStyle = True
            Me.AutoHideMenu = Conversions.ToBoolean(Me.UserRow.Item("AutoHideMenu"))
            Me.RoleRow = Me.LoadRoleData
            If Not Information.IsNothing(Me.RoleRow) Then
                If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(Me.RoleRow.Item("EntityID"), ""), "", False) Then
                    Me.EntityID = Conversions.ToInteger(Me.RoleRow.Item("EntityID"))
                Else
                    Me.EntityID = 0
                End If
                Me.RoleID = Conversions.ToInteger(Me.RoleRow.Item("RoleID"))
                Me.CanModifyGlobalViews = Conversions.ToBoolean(Me.RoleRow.Item("CanModifyGlobalViews"))
            Else
                Me.EntityID = 0
                Me.RoleID = 0
                Me.CanModifyGlobalViews = True
            End If
            Me.EntityRow = Me.LoadEntityData
            Me.EntityName = Conversions.ToString(Me.EntityRow.Item("Name"))
            Me.EntityCurr = Conversions.ToString(Me.EntityRow.Item("CurrCode"))
            If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.EntityRow.Item("FormIcon"))) Then
                Me.FormIcon = Conversions.ToString(Me.EntityRow.Item("FormIcon"))
            End If
            Me.AllowedEntityList = Me.LoadEntityListData
            Me.tblGlobalParam = Me.LoadGlobalParameters
            Try 
                enumerator = Me.tblGlobalParam.Rows.GetEnumerator
                Do While enumerator.MoveNext
                    Me.Row = DirectCast(enumerator.Current, DataRow)
                    Select Case Me.Row.Item("Name").ToString
                        Case "BaseCurrency"
                            Me.BaseCurrency = Conversions.ToString(Me.Row.Item("ParamValue"))
                            Exit Select
                        Case "MasterAcctSeparator"
                            Me.GLAcctSeparator = Conversions.ToString(Me.Row.Item("ParamValue"))
                            Exit Select
                        Case "ReportsPath"
                            Me.GlobalReportsPath = Conversions.ToString(Me.Row.Item("ParamValue"))
                            Exit Select
                    End Select
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
            Me.LoadUserStdShortCut
            Me.SetCultureInfo
        End Sub

        Public Sub ChangeDBConnection()
            Select Case Me.DBConnType
                Case "SQL"
                    Me.SQLDBConn = New SqlConnection(Me.DBConnString)
                    Exit Select
                Case "OLEDB"
                    Me.OleDBConn = New OleDbConnection(Me.DBConnString)
                    Exit Select
                Case "MySQL"
                    Me.MySqlDbConn = New MySqlConnection(Me.DBConnString)
                    Exit Select
            End Select
        End Sub

        Public Function GlobalOrLocalEntityList(ByVal GlobalState As GlobalState) As String
            Select Case CInt(GlobalState)
                Case 0
                    Return "(  0) "
                Case 1
                    Return ("( " & Conversions.ToString(Me.EntityID) & " )")
                Case 2
                    Return ("( 0, " & Conversions.ToString(Me.EntityID) & " )")
            End Select
            Return ""
        End Function

        Private Function LoadEntityData() As DataRow
            Dim general As New dsGeneral
            Dim set As New clsDataSet(Me)
            Dim sQLTxt As String = ("SELECT * FROM generalentity WHERE EntityID = " & Conversions.ToString(Me.EntityID))
            Try 
                ClsDs.FillDataSet(general.Tables.Item("generalentity"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (general.Tables.Item("generalentity").Rows.Count > 0) Then
                Return general.Tables.Item("generalentity").Rows.Item(0)
            End If
            Return Nothing
        End Function

        Private Function LoadEntityListData() As String
            Dim current As DataRow
            Dim str2 As String
            Dim security As New dsSecurity
            Dim set As New clsDataSet(Me)
            Dim left As String = "("
            If (Me.RoleID <> 0) Then
                str2 = ("SELECT * FROM generalentity WHERE EntityID IN (SELECT EntityID FROM securityrole_entity WHERE RoleID = " & Conversions.ToString(Me.RoleID) & ")")
                str2 = "SELECT * FROM generalentity "
                Try
                    ClsDs.FillDataSet(security.Tables.Item("generalentity"), str2, True, False)
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Throw exception
                    ProjectData.ClearProjectError()
                End Try
                If (security.Tables.Item("generalentity").Rows.Count > 0) Then
                    Dim enumerator As IEnumerator
                    Try
                        enumerator = security.Tables.Item("generalentity").Rows.GetEnumerator
                        Do While enumerator.MoveNext
                            current = DirectCast(enumerator.Current, DataRow)
                            left = Conversions.ToString(Operators.ConcatenateObject(left, Operators.ConcatenateObject(current.Item("EntityID"), ",")))
                        Loop
                    Finally
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                    Return (left & "-1)")
                End If
                Return ""
            End If
            str2 = "SELECT * FROM generalentity "
            Try
                ClsDs.FillDataSet(security.Tables.Item("generalentity"), str2, True, False)
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError()
            End Try
            If (security.Tables.Item("generalentity").Rows.Count > 0) Then
                Dim enumerator2 As IEnumerator
                Try
                    enumerator2 = security.Tables.Item("generalentity").Rows.GetEnumerator
                    Do While enumerator2.MoveNext
                        current = DirectCast(enumerator2.Current, DataRow)
                        left = Conversions.ToString(Operators.ConcatenateObject(left, Operators.ConcatenateObject(current.Item("EntityID"), ",")))
                    Loop
                Finally
                    If TypeOf enumerator2 Is IDisposable Then
                        TryCast(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                Return (left & "-1)")
            End If
            Return ""
        End Function

        Private Function LoadGlobalParameters() As DataTable
            Dim general As New dsGeneral
            Dim set As New clsDataSet(Me)
            Dim sQLTxt As String = "SELECT * FROM generalglobalparameter "
            Try
                ClsDs.FillDataSet(general.Tables.Item("generalglobalparameter"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (general.Tables.Item("generalglobalparameter").Rows.Count > 0) Then
                Return general.Tables.Item("generalglobalparameter")
            End If
            Return Nothing
        End Function

        Private Function LoadRoleData() As DataRow
            Dim security As New dsSecurity
            Dim set As New clsDataSet(Me)
            Dim sQLTxt As String = ("SELECT * FROM securityrole WHERE RoleID = " & Conversions.ToString(Me.RoleID))
            Try
                ClsDs.FillDataSet(security.Tables.Item("securityrole"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (security.Tables.Item("securityrole").Rows.Count > 0) Then
                Return security.Tables.Item("securityrole").Rows.Item(0)
            End If
            Return Nothing
        End Function

        Private Function LoadUserData() As DataRow
            Dim security As New dsSecurity
            Dim set As New clsDataSet(Me)
            Dim sQLTxt As String = ("SELECT * FROM securityuser WHERE UserID = " & Conversions.ToString(Me.UserID))
            Try
                ClsDs.FillDataSet(security.Tables.Item("securityuser"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (security.Tables.Item("securityuser").Rows.Count > 0) Then
                Return security.Tables.Item("securityuser").Rows.Item(0)
            End If
            Return Nothing
        End Function

        Private Sub LoadUserStdShortCut()
            Me.ShortCut = New clsStdShortCut(Me)
            Dim shortCutID As Integer = Conversions.ToInteger(Me.UserRow.Item("ShortCutID"))
            Me.ShortCut.LoadShortCut(shortCutID, Me.ShortCut)
        End Sub

        Private Sub SetCultureInfo()
            If (Me.UserLang = "") Then
                Me.UserLang = "EN"
            End If
            Dim userLang As String = Me.UserLang
            If ((userLang <> "EN") AndAlso (userLang = "FR")) Then
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr", True)
            End If
        End Sub


        ' Fields
        Public AllowedEntityList As String
        Public ApplDir As String
        Public AutoHideMenu As Boolean
        Public AutoSaveViews As Boolean
        Public BannerVisible As Boolean
        Public BaseCurrency As String
        Public CanModifyGlobalViews As Boolean
        Public DataBaseCultureInfo As String
        Public DBConnString As String
        Public DBConnType As String
        Public DBName As String
        Public EntityCurr As String
        Public EntityID As Integer
        Private EntityListRow As DataRow
        Public EntityName As String
        Private EntityRow As DataRow
        Public FormIcon As String
        Public GLAcctSeparator As String
        Public GlobalReportsPath As String
        Public MDIStyle As Boolean
        Public MySqlDbConn As MySqlConnection
        Public OleDBConn As OleDbConnection
        Public RoleID As Integer
        Private RoleRow As DataRow
        Private Row As DataRow
        Public ShortCut As clsStdShortCut
        Public ShowInTaskBar As Boolean
        Public SQLDBConn As SqlConnection
        Private tblGlobalParam As DataTable
        Public UserDocPath As String
        Public UserFullName As String
        Public UserID As Integer
        Public UserLang As String
        Public UserLogin As String
        Private UserRow As DataRow
    End Class
End Namespace

