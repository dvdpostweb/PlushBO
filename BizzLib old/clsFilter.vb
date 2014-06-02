Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class clsFilter
        ' Methods
        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.mvarBKGlobal = New clsGlobal(CurrentSessionInfo)
        End Sub

        Public Sub ApplyDefaultFilter(ByVal MenuID As Integer, ByRef IsFiltered As Boolean, ByRef FilterTxt As String, ByVal Optional Panel1 As StatusBarPanel = Nothing)
            Dim filterID As Integer = 0
            Dim str As String = ""
            filterID = Me.FindDefaultFilter(Me.SessionInfo.UserID, MenuID)
            If (filterID = 0) Then
                IsFiltered = False
                FilterTxt = ""
                If Not Information.IsNothing(Panel1) Then
                    Panel1.Icon = Nothing
                End If
            Else
                str = Me.FilterGenerateSQL(filterID)
                If (str = "") Then
                    IsFiltered = False
                    FilterTxt = ""
                    If Not Information.IsNothing(Panel1) Then
                        Panel1.Icon = Nothing
                    End If
                    filterID = 0
                Else
                    IsFiltered = True
                    FilterTxt = str
                    If Not Information.IsNothing(Panel1) Then
                        Panel1.Icon = New Icon((Me.SessionInfo.ApplDir & "/icons/FilterIsOn.ico"))
                    End If
                End If
            End If
        End Sub

        Public Sub ApplyFilter(ByRef OLEAdapter As OleDbDataAdapter, ByRef IsFiltered As Boolean, ByVal FilterID As Integer, ByVal WhereClause As String, ByVal Optional Panel1 As StatusBarPanel = Nothing)
            Dim selectCommand As OleDbCommand
            Dim str As String = ""
            If (FilterID = 0) Then
                IsFiltered = False
                str = ""
                If (WhereClause <> "") Then
                    selectCommand = OLEAdapter.SelectCommand
                    selectCommand.CommandText = (selectCommand.CommandText & WhereClause & " ")
                End If
                If Not Information.IsNothing(Panel1) Then
                    Panel1.Icon = Nothing
                    Panel1.ToolTipText = ""
                End If
            Else
                str = Me.FilterGenerateSQL(FilterID)
                If (str = "") Then
                    IsFiltered = False
                    str = ""
                    If (WhereClause <> "") Then
                        selectCommand = OLEAdapter.SelectCommand
                        selectCommand.CommandText = (selectCommand.CommandText & WhereClause & " ")
                    End If
                    If Not Information.IsNothing(Panel1) Then
                        Panel1.Icon = Nothing
                        Panel1.ToolTipText = ""
                    End If
                Else
                    IsFiltered = True
                    If (WhereClause = "") Then
                        selectCommand = OLEAdapter.SelectCommand
                        selectCommand.CommandText = (selectCommand.CommandText & " WHERE " & str)
                    Else
                        selectCommand = OLEAdapter.SelectCommand
                        selectCommand.CommandText = String.Concat(New String() { selectCommand.CommandText, WhereClause, " AND ( ", str, " )" })
                    End If
                    If Not Information.IsNothing(Panel1) Then
                        Panel1.Icon = New Icon((Me.SessionInfo.ApplDir & "/icons/FilterIsOn.ico"))
                        Panel1.ToolTipText = str
                    End If
                End If
                Dim num As Integer = Me.FilterGetTopRows(FilterID)
                If (num > 0) Then
                    IsFiltered = False
                    OLEAdapter.SelectCommand.CommandText = OLEAdapter.SelectCommand.CommandText.Replace("SELECT", ("SELECT TOP " & Conversions.ToString(num) & " "))
                    If Not Information.IsNothing(Panel1) Then
                        Panel1.Icon = New Icon((Me.SessionInfo.ApplDir & "/icons/FilterIsOn.ico"))
                        Panel1.ToolTipText = (Panel1.ToolTipText & " TOP Rows : " & Conversions.ToString(num))
                    End If
                End If
            End If
        End Sub

        Public Sub ApplyFilter(ByRef SQLTxt As String, ByRef IsFiltered As Boolean, ByVal FilterID As Integer, ByVal WhereClause As String, ByVal Optional Panel1 As StatusBarPanel = Nothing)
            Dim str As String = ""
            If (FilterID = 0) Then
                IsFiltered = False
                str = ""
                If (WhereClause <> "") Then
                    SQLTxt = (SQLTxt & WhereClause & " ")
                End If
                If Not Information.IsNothing(Panel1) Then
                    Panel1.Icon = Nothing
                    Panel1.ToolTipText = ""
                End If
            Else
                str = Me.FilterGenerateSQL(FilterID)
                If (str = "") Then
                    IsFiltered = False
                    str = ""
                    If (WhereClause <> "") Then
                        SQLTxt = (SQLTxt & WhereClause & " ")
                    End If
                    If Not Information.IsNothing(Panel1) Then
                        Panel1.Icon = Nothing
                        Panel1.ToolTipText = ""
                    End If
                Else
                    IsFiltered = True
                    If (WhereClause = "") Then
                        SQLTxt = (SQLTxt & " WHERE " & str)
                    Else
                        SQLTxt = String.Concat(New String() { SQLTxt, WhereClause, " AND ( ", str, " )" })
                    End If
                    If Not Information.IsNothing(Panel1) Then
                        Panel1.Icon = New Icon((Me.SessionInfo.ApplDir & "/icons/FilterIsOn.ico"))
                        Panel1.ToolTipText = str
                    End If
                End If
                Dim num As Integer = Me.FilterGetTopRows(FilterID)
                If (num > 0) Then
                    IsFiltered = False
                    SQLTxt = SQLTxt.Replace("SELECT", ("SELECT TOP " & Conversions.ToString(num) & " "))
                    If Not Information.IsNothing(Panel1) Then
                        Panel1.Icon = New Icon((Me.SessionInfo.ApplDir & "/icons/FilterIsOn.ico"))
                        Panel1.ToolTipText = (Panel1.ToolTipText & " TOP Rows : " & Conversions.ToString(num))
                    End If
                End If
            End If
        End Sub

        Public Function CopyFilter(ByVal FilterID As Integer) As Integer
            Dim enumerator As IEnumerator
            Dim filter As New dsFilter
            Dim filter2 As New dsFilter
            Dim set As New clsDataSet(Me.SessionInfo)
            If (FilterID = 0) Then
                Return 0
            End If
            Dim sQLTxt As String = ("SELECT * FROM generalfilter WHERE FilterID = " & Conversions.ToString(FilterID))
            ClsDs.FillDataSet(filter.Tables.Item("generalfilter"), sQLTxt, True, False)
            If (filter.Tables.Item("generalfilter").Rows.Count = 0) Then
                Return 0
            End If
            Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("FilterID"))
            Dim row As DataRow = filter2.Tables.Item("generalfilter").NewRow
            row.ItemArray = filter.Tables.Item("generalfilter").Rows.Item(0).ItemArray
            row.Item("FilterID") = num
            row.Item("DefaultFilter") = False
            row.Item("SystemFilter") = 0
            row.Item("UserID") = Me.SessionInfo.UserID
            row.Item("Name") = Operators.ConcatenateObject("Copy of ", filter.Tables.Item("generalfilter").Rows.Item(0).Item("Name"))
            filter2.Tables.Item("generalfilter").Rows.Add(row)
            ClsDs.UpdateDataSource(filter2.Tables.Item("generalfilter"), sQLTxt, True)
            Dim str2 As String = ("SELECT * FROM generalfiltersub WHERE FilterID = " & Conversions.ToString(FilterID))
            ClsDs.FillDataSet(filter.Tables.Item("generalfiltersub"), str2, True, False)
            Try
                enumerator = filter.Tables.Item("generalfiltersub").Rows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                    row = filter2.Tables.Item("generalfiltersub").NewRow
                    row.ItemArray = current.ItemArray
                    row.Item("FilterID") = num
                    filter2.Tables.Item("generalfiltersub").Rows.Add(row)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(filter2.Tables.Item("generalfiltersub"), str2, True)
            Return num
        End Function

        Public Sub DeleteFilter(ByVal FilterID As Integer)
            If (FilterID <> 0) Then
                If (Not Me.SessionInfo.CanModifyGlobalViews And (FilterID < 0)) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(50, "", True), MsgBoxStyle.Critical, Nothing)
                Else
                    Dim filter As New dsFilter
                    Dim set As New clsDataSet(Me.SessionInfo)
                    Dim sQLTxt As String = ("SELECT * FROM generalfilter WHERE FilterID = " & Conversions.ToString(FilterID))
                    ClsDs.FillDataSet(filter.Tables.Item("generalfilter"), sQLTxt, True, False)
                    If (filter.Tables.Item("generalfilter").Rows.Count <> 0) Then
                        Dim row As DataRow = filter.Tables.Item("generalfilter").Rows.Item(0)
                        If Operators.ConditionalCompareObjectEqual(row.Item("SystemFilter"), 1, False) Then
                            Interaction.MsgBox(Me.BKGlobal.GetMsg(&H33, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                        ElseIf (Interaction.MsgBox(Me.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes) Then
                            sQLTxt = ("DELETE FROM generalfiltersub WHERE FilterID = " & Conversions.ToString(FilterID))
                            ClsDs.ExecuteNonQuery(sQLTxt, True)
                            sQLTxt = ("DELETE FROM generalfilter WHERE FilterID = " & Conversions.ToString(FilterID))
                            ClsDs.ExecuteNonQuery(sQLTxt, True)
                        End If
                    End If
                End If
            End If
        End Sub

        Public Sub DeleteFilterSub(ByVal FilterID As Integer)
            Dim num As Integer = -1
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLtxt As String = ("DELETE FROM generalfiltersub WHERE FilterID = " & Conversions.ToString(FilterID))
            Try
                num = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Function EditFilterInfo(ByVal FilterID As Integer, ByVal FilterForMenuID As Integer, ByVal FilterForTable As DataTable, ByVal OwnerForm As Form) As Integer
            Dim num As Integer
            Dim filter As New dsFilter
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim maintenance As New frmSystemFilter_Maintenance(Me.SessionInfo)
            If (FilterID = 0) Then
                Return num
            End If
            If (Not Me.SessionInfo.CanModifyGlobalViews And (FilterID < 0)) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H3F, "", True), MsgBoxStyle.Critical, Nothing)
                Return num
            End If
            Dim sQLTxt As String = ("SELECT * FROM generalfilter WHERE FilterID = " & Conversions.ToString(FilterID))
            ClsDs.FillDataSet(filter.Tables.Item("generalfilter"), sQLTxt, True, False)
            If (filter.Tables.Item("generalfilter").Rows.Count = 0) Then
                Return num
            End If
            If Operators.ConditionalCompareObjectEqual(filter.Tables.Item("generalfilter").Rows.Item(0).Item("SystemFilter"), 1, False) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H31, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                Return num
            End If
            maintenance.KeyValue = Conversions.ToString(FilterID)
            maintenance.OpenType = "EDIT"
            maintenance.FilterForMenuID = FilterForMenuID
            maintenance.FilterForTable = FilterForTable
            maintenance.ShowDialog(OwnerForm)
            Return FilterID
        End Function

        Public Sub FilterAssignDefault(ByVal FilterID As Integer, ByVal MenuID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            Me.FilterClearDefault(MenuID)
            Dim sQLtxt As String = ("UPDATE generalfilter SET DefaultFilter = 1 WHERE FilterID = " & Conversions.ToString(FilterID))
            Try
                Dim num As Integer = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Sub FilterClearDefault(ByVal MenuID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLtxt As String = ("UPDATE generalfilter SET DefaultFilter = 0 WHERE MenuID = " & Conversions.ToString(MenuID) & " AND UserID = " & Conversions.ToString(Me.SessionInfo.UserID))
            Try
                Dim num As Integer = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Function FilterGenerateSQL(ByVal FilterID As Integer) As String
            Dim enumerator As IEnumerator
            Dim filter As New dsFilter
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generalfiltersub WHERE FilterID = " & Conversions.ToString(FilterID) & " ORDER BY FieldName ")
            Dim left As String = ""
            If (FilterID = 0) Then
                Return ""
            End If
            Try
                ClsDs.FillDataSet(filter.Tables.Item("generalfiltersub"), sQLTxt, True, False)
                filter.Tables.Item("generalfiltersub").PrimaryKey = New DataColumn() {filter.Tables.Item("generalfiltersub").Columns.Item("FieldName")}
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (filter.Tables.Item("generalfiltersub").Rows.Count = 0) Then
                Return ""
            End If
            Try
                enumerator = filter.Tables.Item("generalfiltersub").Rows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                    If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(current.Item("FieldCriteria"), ""), "", False) Then
                        If ((left & "") <> "") Then
                            left = (left & " AND ")
                        End If
                        left = Conversions.ToString(Operators.AddObject(left, Operators.AddObject(" ", current.Item("FieldCriteria"))))
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return left
        End Function

        Public Function FilterGetTopRows(ByVal FilterID As Integer) As Integer
            Dim filter As New dsFilter
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generalfilter WHERE FilterID = " & Conversions.ToString(FilterID) & " ORDER BY FilterID ")
            Try
                ClsDs.FillDataSet(filter.Tables.Item("generalfilter"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (filter.Tables.Item("generalfilter").Rows.Count <> 0) Then
                If Information.IsDBNull(RuntimeHelpers.GetObjectValue(filter.Tables.Item("generalfilter").Rows.Item(0).Item("TopRows"))) Then
                    Return -1
                End If
                If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(filter.Tables.Item("generalfilter").Rows.Item(0).Item("TopRows"))) Then
                    Dim num2 As Integer = Conversions.ToInteger(filter.Tables.Item("generalfilter").Rows.Item(0).Item("TopRows"))
                    If (num2 < 0) Then
                        Return -1
                    End If
                    Return num2
                End If
            End If
            Return -1
        End Function

        Public Sub FilterSubVerify(ByVal FilterID As Integer, ByVal TableToBeFiltered As DataTable)
            Dim current As DataColumn
            Dim row As DataRow
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim filter As New dsFilter
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generalfiltersub WHERE FilterID = " & Conversions.ToString(FilterID) & " ORDER BY FieldName ")
            Try
                ClsDs.FillDataSet(filter.Tables.Item("generalfiltersub"), sQLTxt, True, False)
                filter.Tables.Item("generalfiltersub").PrimaryKey = New DataColumn() {filter.Tables.Item("generalfiltersub").Columns.Item("FieldName")}
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Try
                enumerator = TableToBeFiltered.Columns.GetEnumerator
                Do While enumerator.MoveNext
                    current = DirectCast(enumerator.Current, DataColumn)
                    If Information.IsNothing(filter.Tables.Item("generalfiltersub").Rows.Find(current.ColumnName)) Then
                        row = filter.Tables.Item("generalfiltersub").NewRow
                        row.Item("FieldName") = current.ColumnName
                        row.Item("OrderNbr") = 1
                        row.Item("FilterID") = FilterID
                        filter.Tables.Item("generalfiltersub").Rows.Add(row)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(filter.Tables.Item("generalfiltersub"), True)
            Try
                enumerator2 = filter.Tables.Item("generalfiltersub").Rows.GetEnumerator
                Do While enumerator2.MoveNext
                    Dim enumerator3 As IEnumerator
                    row = DirectCast(enumerator2.Current, DataRow)
                    Dim flag As Boolean = True
                    Try
                        enumerator3 = TableToBeFiltered.Columns.GetEnumerator
                        Do While enumerator3.MoveNext
                            current = DirectCast(enumerator3.Current, DataColumn)
                            If Operators.ConditionalCompareObjectEqual(current.ColumnName, row.Item("FieldName"), False) Then
                                flag = False
                                GoTo Label_0251
                            End If
                        Loop
                    Finally
                        If TypeOf enumerator3 Is IDisposable Then
                            TryCast(enumerator3, IDisposable).Dispose()
                        End If
                    End Try
Label_0251:
                    If flag Then
                        row.Delete()
                    End If
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(filter.Tables.Item("generalfiltersub"), True)
        End Sub

        Public Function FindDefaultFilter(ByVal USerID As Integer, ByVal MenuID As Integer) As Integer
            Dim filter As New dsFilter
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim num As Integer = 0
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generalfilter WHERE UserID = ", Conversions.ToString(USerID), " AND MenuID = ", Conversions.ToString(MenuID), " AND DefaultFilter = 1 "})
            Try
                ClsDs.FillDataSet(filter.Tables.Item("generalfilter"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (filter.Tables.Item("generalfilter").Rows.Count = 0) Then
                num = 0
            Else
                num = Conversions.ToInteger(filter.Tables.Item("generalfilter").Rows.Item(0).Item("FilterID"))
            End If
            If (num <> 0) Then
                Return num
            End If
            sQLTxt = ("SELECT * FROM generalfilter WHERE UserID <= 0  AND MenuID = " & Conversions.ToString(MenuID) & " AND DefaultFilter = 1 ")
            Try
                ClsDs.FillDataSet(filter.Tables.Item("generalfilter"), sQLTxt, True, False)
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError()
            End Try
            If (filter.Tables.Item("generalfilter").Rows.Count = 0) Then
                Return 0
            End If
            Return Conversions.ToInteger(filter.Tables.Item("generalfilter").Rows.Item(0).Item("FilterID"))
        End Function

        Public Sub LoadToolBarFilterList1(ByVal BarManager1 As BarManager, ByVal MenuID As Integer, Optional ByVal SelectDefault As Boolean = False)
            Dim filter As New dsFilter
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generalfilter WHERE MenuID = ", Conversions.ToString(MenuID), " AND (UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " OR FilterID < 0 ) "})
            ClsDs.FillDataSet(filter.Tables.Item("generalfilter"), sQLTxt, True, False)
            Dim edit As RepositoryItemLookUpEdit = BarManager1.get_RepositoryItems.get_Item("cmbFilterListRepos")
            edit.set_DataSource(filter.Tables.Item("generalfilter"))
            edit.set_DisplayMember("Name")
            edit.set_ValueMember("FilterID")
            edit.get_Columns.Clear()
            edit.get_Columns.Add(New LookUpColumnInfo("Name", &H4B))
            edit.get_Columns.Add(New LookUpColumnInfo("Description", 150))
            Dim num As Integer = 0
            If SelectDefault Then
                Dim enumerator As IEnumerator
                Try
                    enumerator = filter.Tables.Item("generalfilter").Rows.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                        If Conversions.ToBoolean(current.Item("DefaultFilter")) Then
                            If (num = 0) Then
                                num = Conversions.ToInteger(current.Item("FilterID"))
                            ElseIf Not Operators.ConditionalCompareObjectLess(current.Item("BrowseViewID"), 0, False) Then
                                num = Conversions.ToInteger(current.Item("FilterID"))
                            End If
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            DirectCast(BarManager1.get_Items.get_Item("cmbFilterList"), BarEditItem).set_EditValue(num)
        End Sub

        Public Sub MakeFilterCommon(ByVal FilterID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            If ((FilterID >= 0) AndAlso (Interaction.MsgBox(Me.BKGlobal.GetMsg(&H2F, Me.SessionInfo.UserLang, True), MsgBoxStyle.OkCancel, Nothing) <> MsgBoxResult.Cancel)) Then
                Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("NEGFilterID"))
                Dim sQLtxt As String = String.Concat(New String() {"UPDATE generalfilter SET FilterID = ", Conversions.ToString(num), ", UserID = 0  WHERE FilterID = ", Conversions.ToString(FilterID), " "})
                ClsDs.ExecuteNonQuery(sQLtxt, True)
                sQLtxt = String.Concat(New String() {"UPDATE generalfiltersub SET FilterID = ", Conversions.ToString(num), "  WHERE FilterID = ", Conversions.ToString(FilterID), " "})
                ClsDs.ExecuteNonQuery(sQLtxt, True)
            End If
        End Sub

        Public Function NewFilterDialogue(ByVal FilterForMenuID As Integer, ByVal FilterForTable As DataTable, ByVal OwnerForm As Form) As Integer
            Dim maintenance As New frmSystemFilter_Maintenance(Me.SessionInfo)
            maintenance.OpenType = "NEW"
            maintenance.FilterForMenuID = FilterForMenuID
            maintenance.FilterForTable = FilterForTable
            maintenance.ShowDialog(OwnerForm)
            Return maintenance.NewFilterID
        End Function

        Public Function SendFilterToUser(ByVal FilterID As Integer, ByVal OwnerForm As Form) As Integer
            Dim num3 As Integer
            If (FilterID = 0) Then
                Return 0
            End If
            Dim user As New frmDialogSelectUser(Me.SessionInfo)
            Dim set As New clsDataSet(Me.SessionInfo)
            user.ShowDialog(OwnerForm)
            If (user.DialogResult <> DialogResult.OK) Then
                Return num3
            End If
            Dim num2 As Integer = Conversions.ToInteger(user.SelectedUserID)
            If (num2 = Me.SessionInfo.UserID) Then
                Return 0
            End If
            Dim num As Integer = Me.CopyFilter(FilterID)
            If (num = 0) Then
                Return num3
            End If
            Dim sQLtxt As String = ("UPDATE generalfilter SET UserID = " & Conversions.ToString(num2) & " WHERE FilterID = " & Conversions.ToString(num))
            ClsDs.ExecuteNonQuery(sQLtxt, True)
            Return num
        End Function


        ' Properties
        Public Property BKGlobal As clsGlobal
            Get
                Return Me.mvarBKGlobal
            End Get
            Set(ByVal Value As clsGlobal)
                Me.mvarBKGlobal = Value
            End Set
        End Property

        Public Property SessionInfo As clsSessionInfo
            Get
                Return Me.mvarSessionInfo
            End Get
            Set(ByVal Value As clsSessionInfo)
                Me.mvarSessionInfo = Value
            End Set
        End Property


        ' Fields
        Private mvarBKGlobal As clsGlobal
        Private mvarSessionInfo As clsSessionInfo
    End Class
End Namespace

