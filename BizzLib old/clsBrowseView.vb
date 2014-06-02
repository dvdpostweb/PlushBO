Imports DevExpress.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class clsBrowseView
        ' Methods
        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.mvarBKGlobal = New clsGlobal(CurrentSessionInfo)
        End Sub

        Public Sub BrowseViewAssignDefault(ByVal BrowseViewID As Integer, ByVal MenuID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            Me.BrowseViewClearDefault(MenuID)
            Dim sQLtxt As String = ("UPDATE generalbrowseview SET DefaultView = 1 WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
            Try 
                Dim num As Integer = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Sub BrowseViewClearDefault(ByVal MenuID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLtxt As String = ("UPDATE generalbrowseview SET DefaultView = 0 WHERE MenuID = " & Conversions.ToString(MenuID) & " AND UserID = " & Conversions.ToString(Me.SessionInfo.UserID))
            Try
                Dim num As Integer = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Function CopyBrowseView(ByVal BrowseViewID As Integer) As Integer
            Dim current As DataRow
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim view As New dsBrowseView
            Dim view2 As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            If (BrowseViewID = 0) Then
                Return 0
            End If
            Dim sQLTxt As String = ("SELECT * FROM generalbrowseview WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
            ClsDs.FillDataSet(view.Tables.Item("generalbrowseview"), sQLTxt, True, False)
            If (view.Tables.Item("generalbrowseview").Rows.Count = 0) Then
                Return 0
            End If
            Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("BrowseViewID"))
            Dim row As DataRow = view2.Tables.Item("generalbrowseview").NewRow
            row.ItemArray = view.Tables.Item("generalbrowseview").Rows.Item(0).ItemArray
            row.Item("BrowseViewID") = num
            row.Item("SystemView") = 0
            row.Item("DefaultView") = 0
            row.Item("UserID") = Me.SessionInfo.UserID
            row.Item("Name") = Operators.ConcatenateObject("Copy of ", view.Tables.Item("generalbrowseview").Rows.Item(0).Item("Name"))
            view2.Tables.Item("generalbrowseview").Rows.Add(row)
            ClsDs.UpdateDataSource(view2.Tables.Item("generalbrowseview"), sQLTxt, True)
            Dim str2 As String = ("SELECT * FROM generalbrowseviewcolumn WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
            ClsDs.FillDataSet(view.Tables.Item("generalbrowseviewcolumn"), str2, True, False)
            Try
                enumerator = view.Tables.Item("generalbrowseviewcolumn").Rows.GetEnumerator
                Do While enumerator.MoveNext
                    current = DirectCast(enumerator.Current, DataRow)
                    row = view2.Tables.Item("generalbrowseviewcolumn").NewRow
                    row.ItemArray = current.ItemArray
                    row.Item("BrowseViewID") = num
                    view2.Tables.Item("generalbrowseviewcolumn").Rows.Add(row)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(view2.Tables.Item("generalbrowseviewcolumn"), str2, True)
            str2 = ("SELECT * FROM generalbrowseviewgroupby WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
            ClsDs.FillDataSet(view.Tables.Item("generalbrowseviewgroupby"), str2, True, False)
            Try
                enumerator2 = view.Tables.Item("generalbrowseviewgroupby").Rows.GetEnumerator
                Do While enumerator2.MoveNext
                    current = DirectCast(enumerator2.Current, DataRow)
                    row = view2.Tables.Item("generalbrowseviewgroupby").NewRow
                    row.ItemArray = current.ItemArray
                    row.Item("BrowseViewID") = num
                    view2.Tables.Item("generalbrowseviewgroupby").Rows.Add(row)
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(view2.Tables.Item("generalbrowseviewgroupby"), str2, True)
            Return num
        End Function

        Public Sub DeleteBrowseView(ByVal BrowseViewID As Integer)
            If (BrowseViewID <> 0) Then
                If (Not Me.SessionInfo.CanModifyGlobalViews And (BrowseViewID < 0)) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(40, "", True), MsgBoxStyle.Critical, Nothing)
                Else
                    Dim view As New dsBrowseView
                    Dim set As New clsDataSet(Me.SessionInfo)
                    Dim sQLTxt As String = ("SELECT * FROM generalbrowseview WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
                    ClsDs.FillDataSet(view.Tables.Item("generalbrowseview"), sQLTxt, True, False)
                    If (view.Tables.Item("generalbrowseview").Rows.Count <> 0) Then
                        If Operators.ConditionalCompareObjectEqual(view.Tables.Item("generalbrowseview").Rows.Item(0).Item("SystemView"), 1, False) Then
                            Interaction.MsgBox(Me.BKGlobal.GetMsg(&H29, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                        ElseIf (Interaction.MsgBox(Me.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes) Then
                            sQLTxt = ("DELETE FROM generalbrowseviewgroupby WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
                            ClsDs.ExecuteNonQuery(sQLTxt, True)
                            sQLTxt = ("DELETE FROM generalbrowseviewcolumn WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
                            ClsDs.ExecuteNonQuery(sQLTxt, True)
                            sQLTxt = ("DELETE FROM generalbrowseview WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
                            ClsDs.ExecuteNonQuery(sQLTxt, True)
                        End If
                    End If
                End If
            End If
        End Sub

        Public Function DeleteBrowseViewColumn(ByVal BrowseViewID As Integer) As Integer
            Dim num As Integer = -1
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLtxt As String = ("DELETE FROM generalbrowseviewcolumn WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
            Try
                num = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Return num
        End Function

        Public Function DeleteBrowseViewGroupBy(ByVal BrowseViewID As Integer) As Integer
            Dim num As Integer = -1
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLtxt As String = ("DELETE FROM generalbrowseviewgroupby WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
            Try
                num = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Return num
        End Function

        Public Function EditViewInfo(ByVal BrowseViewID As Integer, ByVal ForMenuID As Integer, ByVal ForTable As DataTable, ByVal OwnerForm As Form) As Integer
            Dim num As Integer
            Dim view As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim maintenance As New frmSystemBrowseView_Maintenance(Me.SessionInfo)
            If (BrowseViewID = 0) Then
                Return num
            End If
            If (Not Me.SessionInfo.CanModifyGlobalViews And (BrowseViewID < 0)) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H27, "", True), MsgBoxStyle.Critical, Nothing)
                Return num
            End If
            Dim sQLTxt As String = ("SELECT * FROM generalbrowseview WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
            ClsDs.FillDataSet(view.Tables.Item("generalbrowseview"), sQLTxt, True, False)
            If (view.Tables.Item("generalbrowseview").Rows.Count = 0) Then
                Return num
            End If
            If Operators.ConditionalCompareObjectEqual(view.Tables.Item("generalbrowseview").Rows.Item(0).Item("SystemView"), 1, False) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H2A, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                Return num
            End If
            maintenance.KeyValue = Conversions.ToString(BrowseViewID)
            maintenance.OpenType = "EDIT"
            maintenance.ForMenuID = ForMenuID
            maintenance.ForTable = ForTable
            maintenance.ViewName = ForTable.TableName
            maintenance.ShowDialog(OwnerForm)
            Return BrowseViewID
        End Function

        Public Function FindDefaultBrowseView(ByVal USerID As Integer, ByVal MenuID As Integer) As Integer
            Dim view As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim num As Integer = 0
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generalbrowseview WHERE UserID = ", Conversions.ToString(USerID), " AND MenuID = ", Conversions.ToString(MenuID), " AND DefaultView = 1 "})
            Try
                ClsDs.FillDataSet(view.Tables.Item("generalbrowseview"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (view.Tables.Item("generalbrowseview").Rows.Count = 0) Then
                num = 0
            Else
                num = Conversions.ToInteger(view.Tables.Item("generalbrowseview").Rows.Item(0).Item("BrowseViewID"))
            End If
            If (num <> 0) Then
                Return num
            End If
            sQLTxt = ("SELECT * FROM generalbrowseview WHERE BrowseViewID < 0  AND MenuID = " & Conversions.ToString(MenuID) & " AND DefaultView = 1 ")
            Try
                ClsDs.FillDataSet(view.Tables.Item("generalbrowseview"), sQLTxt, True, False)
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError()
            End Try
            If (view.Tables.Item("generalbrowseview").Rows.Count = 0) Then
                Return 0
            End If
            Return Conversions.ToInteger(view.Tables.Item("generalbrowseview").Rows.Item(0).Item("BrowseViewID"))
        End Function

        Public Function GetBrowseDescription(ByVal BrowseViewID As Integer) As String
            Dim view As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generalbrowseview WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID) & " ")
            Try
                ClsDs.FillDataSet(view.Tables.Item("generalbrowseview"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (view.Tables.Item("generalbrowseview").Rows.Count > 0) Then
                Return Conversions.ToString(Operators.ConcatenateObject(view.Tables.Item("generalbrowseview").Rows.Item(0).Item("Description"), ""))
            End If
            Return ""
        End Function

        Public Sub LoadBrowseViewDefinition(ByVal BrowseViewID As Integer, ByVal MenuID1 As Integer, ByVal ViewName As String, ByRef GridView As AdvBandedGridView, Optional ByVal Panel1 As StatusBarPanel = Nothing)
            If (BrowseViewID <> 0) Then
                Me.SetBrowseColumns(BrowseViewID, ViewName, (GridView))
                Me.SetBrowseGroupBy(BrowseViewID, ViewName, (GridView))
                If Not Information.IsNothing(Panel1) Then
                    Panel1.Text = Me.GetBrowseDescription(BrowseViewID)
                End If
            End If
        End Sub

        Public Function LoadDefaultBrowseViewDefinition(ByVal UserID As Integer, ByVal MenuID As Integer, ByVal ViewName As String, ByRef GridView As AdvBandedGridView, Optional ByVal Panel1 As StatusBarPanel = Nothing) As Integer
            Dim browseViewID As Integer = Me.FindDefaultBrowseView(UserID, MenuID)
            If (browseViewID <> 0) Then
                Me.SetBrowseColumns(browseViewID, ViewName, (GridView))
                Me.SetBrowseGroupBy(browseViewID, ViewName, (GridView))
                If Not Information.IsNothing(Panel1) Then
                    Panel1.Text = Me.GetBrowseDescription(browseViewID)
                End If
            End If
            Return browseViewID
        End Function

        Public Sub LoadToolBarViewList1(ByVal BarManager1 As BarManager, ByVal MenuID As Integer, Optional ByVal SelectDefault As Boolean = False)
            Dim view As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generalbrowseview WHERE MenuID = ", Conversions.ToString(MenuID), " AND (UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " OR BrowseViewID < 0 ) ORDER BY  DefaultView DESC, Name "})
            ClsDs.FillDataSet(view.Tables.Item("generalbrowseview"), sQLTxt, True, False)
            Dim edit As RepositoryItemLookUpEdit = BarManager1.get_RepositoryItems.get_Item("cmbViewListRepos")
            edit.set_DataSource(view.Tables.Item("generalbrowseview"))
            edit.set_DisplayMember("Name")
            edit.set_ValueMember("BrowseViewID")
            edit.get_Columns.Clear()
            edit.get_Columns.Add(New LookUpColumnInfo("Name", &H4B))
            edit.get_Columns.Add(New LookUpColumnInfo("Description", 150))
            Dim num As Integer = 0
            If SelectDefault Then
                Dim enumerator As IEnumerator
                Try
                    enumerator = view.Tables.Item("generalbrowseview").Rows.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                        If Conversions.ToBoolean(current.Item("DefaultView")) Then
                            If (num = 0) Then
                                num = Conversions.ToInteger(current.Item("BrowseViewID"))
                            ElseIf Not Operators.ConditionalCompareObjectLess(current.Item("BrowseViewID"), 0, False) Then
                                num = Conversions.ToInteger(current.Item("BrowseViewID"))
                            End If
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            DirectCast(BarManager1.get_Items.get_Item("cmbViewList"), BarEditItem).set_EditValue(num)
        End Sub

        Public Sub MakeViewCommon(ByVal BrowseViewID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            If ((BrowseViewID > 0) AndAlso (Interaction.MsgBox(Me.BKGlobal.GetMsg(&H26, Me.SessionInfo.UserLang, True), MsgBoxStyle.OkCancel, Nothing) <> MsgBoxResult.Cancel)) Then
                Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("NEGBrowseViewID"))
                Dim sQLtxt As String = String.Concat(New String() {"UPDATE generalbrowseview SET BrowseViewID = ", Conversions.ToString(num), ", UserID = 0  WHERE BrowseViewID = ", Conversions.ToString(BrowseViewID), " "})
                ClsDs.ExecuteNonQuery(sQLtxt, True)
            End If
        End Sub

        Public Sub NewViewDialogue(ByVal ForMenuID As Integer, ByVal ForTable As DataTable, ByVal ForGrid As GridControl, ByVal OwnerForm As Form)
            Dim maintenance As New frmSystemBrowseView_Maintenance(Me.SessionInfo)
            maintenance.OpenType = "NEW"
            maintenance.ForMenuID = ForMenuID
            maintenance.ForTable = ForTable
            maintenance.ViewName = ForTable.TableName
            maintenance.ForGrid = ForGrid
            maintenance.ShowDialog(OwnerForm)
        End Sub

        Public Sub SaveCurrentBrowseViewDefinition(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByVal GridView As AdvBandedGridView, Optional ByVal Silent As Boolean = False)
            Dim view As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            If (BrowseViewID <> 0) Then
                Dim sQLTxt As String = ("SELECT * FROM generalbrowseview WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID))
                ClsDs.FillDataSet(view.Tables.Item("generalbrowseview"), sQLTxt, True, False)
                If (view.Tables.Item("generalbrowseview").Rows.Count <> 0) Then
                    If Operators.ConditionalCompareObjectEqual(view.Tables.Item("generalbrowseview").Rows.Item(0).Item("SystemView"), 1, False) Then
                        If Not Silent Then
                            Interaction.MsgBox(Me.BKGlobal.GetMsg(&H2A, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                        End If
                    ElseIf ((BrowseViewID >= 0) OrElse (Me.SessionInfo.CanModifyGlobalViews AndAlso (Interaction.MsgBox(Me.BKGlobal.GetMsg(&H2B, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) <> MsgBoxResult.No))) Then
                        Dim row As DataRow
                        Dim current As BandedGridColumn
                        Dim enumerator As IEnumerator
                        Dim enumerator3 As IEnumerator
                        Dim enumerator4 As IEnumerator
                        sQLTxt = ("UPDATE generalbrowseviewcolumn SET ToShow = 0 Where BrowseViewID = " & Conversions.ToString(BrowseViewID))
                        ClsDs.ExecuteNonQuery(sQLTxt, True)
                        sQLTxt = ("SELECT * FROM generalbrowseviewcolumn WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID) & " ORDER BY ViewName, RowIndex, OrderNbr ")
                        Try
                            ClsDs.FillDataSet(view.Tables.Item("generalbrowseviewcolumn"), sQLTxt, True, False)
                        Catch exception1 As Exception
                            ProjectData.SetProjectError(exception1)
                            Dim exception As Exception = exception1
                            Throw exception
                            ProjectData.ClearProjectError()
                        End Try
                        view.Tables.Item("generalbrowseviewcolumn").PrimaryKey = New DataColumn() {view.Tables.Item("generalbrowseviewcolumn").Columns.Item("ViewName"), view.Tables.Item("generalbrowseviewcolumn").Columns.Item("FieldName")}
                        Dim table As DataTable = view.Tables.Item("generalbrowseviewcolumn")
                        Try
                            enumerator = GridView.get_Bands.get_Item(0).get_Columns.GetEnumerator
                            Do While enumerator.MoveNext
                                current = DirectCast(enumerator.Current, BandedGridColumn)
                                row = table.Rows.Find(New Object() {ViewName, current.get_FieldName})
                                If Not Information.IsNothing(row) Then
                                    Dim enumerator2 As IEnumerator
                                    row.Item("OrderNbr") = current.get_ColIndex
                                    row.Item("ColumnWidth") = current.get_Width
                                    row.Item("RowIndex") = current.get_RowIndex
                                    row.Item("TotalSummary") = current.get_SummaryItem.get_SummaryType
                                    row.Item("GroupSummary") = 6
                                    row.Item("ToShow") = 1
                                    Try
                                        enumerator2 = GridView.get_GroupSummary.GetEnumerator
                                        Do While enumerator2.MoveNext
                                            Dim item As GridGroupSummaryItem = DirectCast(enumerator2.Current, GridGroupSummaryItem)
                                            If (item.get_FieldName = current.get_FieldName) Then
                                                row.Item("GroupSummary") = item.get_SummaryType
                                                GoTo Label_0394
                                            End If
                                        Loop
                                    Finally
                                        If TypeOf enumerator2 Is IDisposable Then
                                            TryCast(enumerator2, IDisposable).Dispose()
                                        End If
                                    End Try
Label_0394:
                                End If
                            Loop
                        Finally
                            If TypeOf enumerator Is IDisposable Then
                                TryCast(enumerator, IDisposable).Dispose()
                            End If
                        End Try
                        table = Nothing
                        ClsDs.UpdateDataSource(view.Tables.Item("generalbrowseviewcolumn"), sQLTxt, True)
                        Dim str2 As String = ("SELECT * FROM generalbrowseviewgroupby WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID) & " ORDER BY ViewName, OrderNbr ")
                        Try
                            ClsDs.FillDataSet(view.Tables.Item("generalbrowseviewgroupby"), str2, True, False)
                        Catch exception3 As Exception
                            ProjectData.SetProjectError(exception3)
                            Dim exception2 As Exception = exception3
                            Throw exception2
                            ProjectData.ClearProjectError()
                        End Try
                        view.Tables.Item("generalbrowseviewgroupby").PrimaryKey = New DataColumn() {view.Tables.Item("generalbrowseviewgroupby").Columns.Item("ViewName"), view.Tables.Item("generalbrowseviewgroupby").Columns.Item("FieldName")}
                        Try
                            enumerator3 = view.Tables.Item("generalbrowseviewgroupby").Rows.GetEnumerator
                            Do While enumerator3.MoveNext
                                row = DirectCast(enumerator3.Current, DataRow)
                                row.Item("ToGroup") = 0
                            Loop
                        Finally
                            If TypeOf enumerator3 Is IDisposable Then
                                TryCast(enumerator3, IDisposable).Dispose()
                            End If
                        End Try
                        ClsDs.UpdateDataSource(view.Tables.Item("generalbrowseviewgroupby"), True)
                        Dim table2 As DataTable = view.Tables.Item("generalbrowseviewgroupby")
                        Try
                            enumerator4 = GridView.get_Bands.get_Item(0).get_Columns.GetEnumerator
                            Do While enumerator4.MoveNext
                                current = DirectCast(enumerator4.Current, BandedGridColumn)
                                If (current.get_GroupIndex >= 0) Then
                                    row = table2.Rows.Find(New Object() {ViewName, current.get_FieldName})
                                    If Not Information.IsNothing(row) Then
                                        row.Item("OrderNbr") = current.get_GroupIndex
                                        row.Item("ToGroup") = 1
                                    End If
                                End If
                            Loop
                        Finally
                            If TypeOf enumerator4 Is IDisposable Then
                                TryCast(enumerator4, IDisposable).Dispose()
                            End If
                        End Try
                        table2 = Nothing
                        ClsDs.UpdateDataSource(view.Tables.Item("generalbrowseviewgroupby"), True)
                    End If
                End If
            End If
        End Sub

        Public Function SendBrowseViewToUser(ByVal BrowseViewID As Integer, ByVal OwnerForm As Form) As Integer
            Dim num3 As Integer
            If (BrowseViewID = 0) Then
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
            Dim num As Integer = Me.CopyBrowseView(BrowseViewID)
            If (num = 0) Then
                Return num3
            End If
            Dim sQLtxt As String = ("UPDATE generalbrowseview SET UserID = " & Conversions.ToString(num2) & " WHERE BrowseViewID = " & Conversions.ToString(num))
            ClsDs.ExecuteNonQuery(sQLtxt, True)
            Return num
        End Function

        Public Sub SetBrowseColumns(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByRef GridView As AdvBandedGridView)
            Dim current As DataRowView
            Dim column As BandedGridColumn
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim enumerator3 As IEnumerator
            Dim view2 As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generalbrowseviewcolumn WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID) & " ORDER BY RowIndex, OrderNbr DESC ")
            Try
                ClsDs.FillDataSet(view2.Tables.Item("generalbrowseviewcolumn"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            GridView.get_Bands.get_Item(0).get_Columns.Clear()
            GridView.get_GroupSummary.Clear()
            Dim view As New DataView(view2.Tables.Item("generalbrowseviewcolumn"), "ToShow = 1", "RowIndex, OrderNbr ", DataViewRowState.CurrentRows)
            Dim num As Integer = 0
            Dim left As Integer = 0
            Try
                enumerator = view.GetEnumerator
                Do While enumerator.MoveNext
                    Dim num2 As Integer
                    Dim num4 As Integer
                    Dim str2 As String
                    current = DirectCast(enumerator.Current, DataRowView)
                    If Information.IsDBNull(RuntimeHelpers.GetObjectValue(current.Item("RowIndex"))) Then
                        left = 0
                    ElseIf Operators.ConditionalCompareObjectNotEqual(left, Operators.ConcatenateObject(current.Item("RowIndex"), ""), False) Then
                        left = Conversions.ToInteger(current.Item("RowIndex"))
                        num = 0
                    End If
                    If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(GridView.get_Columns, Nothing, "Item", New Object() {RuntimeHelpers.GetObjectValue(current.Item("FieldName"))}, Nothing, Nothing, Nothing))) Then
                        column = DirectCast(NewLateBinding.LateGet(GridView.get_Columns, Nothing, "Item", New Object() {RuntimeHelpers.GetObjectValue(current.Item("FieldName"))}, Nothing, Nothing, Nothing), BandedGridColumn)
                    Else
                        column = New BandedGridColumn
                        column.set_Name(Conversions.ToString(current.Item("FieldName")))
                        column.set_FieldName(Conversions.ToString(current.Item("FieldName")))
                    End If
                    If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(current.Item("column_header"), ""), "", False) Then
                        str2 = Conversions.ToString(Operators.ConcatenateObject(current.Item("column_header"), ""))
                    Else
                        str2 = Conversions.ToString(Operators.ConcatenateObject(current.Item("FieldName"), ""))
                    End If
                    column.set_Caption(Me.BKGlobal.GetFieldLabel(ViewName, Conversions.ToString(current.Item("FieldName")), Me.SessionInfo.UserLang, str2))
                    If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(current.Item("RowIndex"))) Then
                        column.set_RowIndex(Conversions.ToInteger(current.Item("RowIndex")))
                        num4 = Conversions.ToInteger(current.Item("RowIndex"))
                    Else
                        column.set_RowIndex(0)
                        num4 = 0
                    End If
                    If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(current.Item("OrderNbr"))) Then
                        num2 = Conversions.ToInteger(current.Item("OrderNbr"))
                    Else
                        num2 = 0
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(current.Item("ColumnWidth"))) AndAlso Operators.ConditionalCompareObjectNotEqual(current.Item("ColumnWidth"), 0, False)) Then
                        column.set_Width(Conversions.ToInteger(current.Item("ColumnWidth")))
                    End If
                    If (Strings.Mid(Conversions.ToString(Operators.ConcatenateObject(current.Item("DataType"), "")), 1, 1) = "N") Then
                        Dim num5 As Integer = -1
                        If Versioned.IsNumeric(Strings.Mid(Conversions.ToString(Operators.ConcatenateObject(current.Item("DataType"), "")), 2, 1)) Then
                            num5 = Conversions.ToInteger(Strings.Mid(Conversions.ToString(Operators.ConcatenateObject(current.Item("DataType"), "")), 2, 1))
                        End If
                        column.get_DisplayFormat.set_FormatType(1)
                        If (num5 = -1) Then
                            column.get_DisplayFormat.set_FormatString("N")
                        Else
                            column.get_DisplayFormat.set_FormatString(("N" & Conversions.ToString(num5)))
                        End If
                    End If
                    If (Strings.InStr("d,D,t,T,f,F,g,G", Conversions.ToString(current.Item("DataType")), CompareMethod.Binary) <> 0) Then
                        column.get_DisplayFormat.set_FormatType(2)
                        column.get_DisplayFormat.set_FormatString(Conversions.ToString(current.Item("DataType")))
                    End If
                    column.set_OwnerBand(GridView.get_Bands.get_Item(0))
                    If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(current.Item("TotalSummary"), ""), "", False) Then
                        column.get_SummaryItem.set_SummaryType(6)
                    ElseIf Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(current.Item("TotalSummary"), 0, False), Operators.CompareObjectGreater(current.Item("TotalSummary"), 4, False))) Then
                        column.get_SummaryItem.set_SummaryType(6)
                    Else
                        column.get_SummaryItem.set_SummaryType(DirectCast(Conversions.ToInteger(current.Item("TotalSummary")), SummaryItemType))
                        If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(current.Item("DataType"), ""), "Numeric", False) Then
                            column.get_SummaryItem.set_DisplayFormat("{0:N}")
                        End If
                    End If
                    If Not Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(current.Item("GroupSummary"), ""), "", False) Then
                        Dim item As New GridGroupSummaryItem(DirectCast(Conversions.ToInteger(current.Item("GroupSummary")), SummaryItemType), Conversions.ToString(current.Item("FieldName")), DirectCast(NewLateBinding.LateGet(GridView.get_Columns, Nothing, "Item", New Object() {RuntimeHelpers.GetObjectValue(current.Item("FieldName"))}, Nothing, Nothing, Nothing), GridColumn), "", RuntimeHelpers.GetObjectValue(current.Item("FieldName")))
                        If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(current.Item("DataType"), ""), "Numeric", False) Then
                            item.set_DisplayFormat("{0:N}")
                        End If
                        GridView.get_GroupSummary.Add(item)
                    End If
                    GridView.get_Bands.get_Item(0).get_Columns.Insert(num, column)
                    GridView.SetColumnPosition(column, num4, num2)
                    num += 1
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Try
                enumerator2 = view.GetEnumerator
                Do While enumerator2.MoveNext
                    current = DirectCast(enumerator2.Current, DataRowView)
                    If ((Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(current.Item("ColumnWidth"))) AndAlso Operators.ConditionalCompareObjectNotEqual(current.Item("ColumnWidth"), 0, False)) AndAlso Not Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(GridView.get_Bands.get_Item(0).get_Columns, Nothing, "Item", New Object() {Operators.ConcatenateObject("col", current.Item("FieldName"))}, Nothing, Nothing, Nothing)))) Then
                        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(GridView.get_Bands.get_Item(0).get_Columns, Nothing, "Item", New Object() {Operators.ConcatenateObject("col", current.Item("FieldName"))}, Nothing, Nothing, Nothing), Nothing, "Width", New Object() {RuntimeHelpers.GetObjectValue(current.Item("ColumnWidth"))}, Nothing, Nothing, False, True)
                    End If
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            view = New DataView(view2.Tables.Item("generalbrowseviewcolumn"), "ToShow = 0 ", "", DataViewRowState.CurrentRows)
            Try
                enumerator3 = view.GetEnumerator
                Do While enumerator3.MoveNext
                    current = DirectCast(enumerator3.Current, DataRowView)
                    If Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(GridView.get_Columns, Nothing, "Item", New Object() {RuntimeHelpers.GetObjectValue(current.Item("FieldName"))}, Nothing, Nothing, Nothing))) Then
                        column = New BandedGridColumn
                        column.set_VisibleIndex(-1)
                        column.set_Name(Conversions.ToString(current.Item("FieldName")))
                        column.set_FieldName(Conversions.ToString(current.Item("FieldName")))
                        column.set_Caption(Me.BKGlobal.GetFieldLabel(ViewName, Conversions.ToString(current.Item("FieldName")), Me.SessionInfo.UserLang, Conversions.ToString(current.Item("FieldName"))))
                        GridView.get_Columns.Add(column)
                    End If
                Loop
            Finally
                If TypeOf enumerator3 Is IDisposable Then
                    TryCast(enumerator3, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Public Sub SetBrowseGroupBy(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByRef GridView As AdvBandedGridView)
            Dim current As DataRow
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim view As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generalbrowseviewgroupby WHERE BrowseViewID = " & Conversions.ToString(BrowseViewID) & " AND ToGroup = 1 ORDER BY OrderNbr ")
            Try
                ClsDs.FillDataSet(view.Tables.Item("generalbrowseviewgroupby"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Try
                enumerator = view.Tables.Item("generalbrowseviewgroupby").Rows.GetEnumerator
                Do While enumerator.MoveNext
                    current = DirectCast(enumerator.Current, DataRow)
                    If Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(GridView.get_Columns, Nothing, "Item", New Object() {RuntimeHelpers.GetObjectValue(current.Item("FieldName"))}, Nothing, Nothing, Nothing))) Then
                        Dim column As New BandedGridColumn
                        column.set_VisibleIndex(-1)
                        column.set_Name(Conversions.ToString(current.Item("FieldName")))
                        column.set_FieldName(Conversions.ToString(current.Item("FieldName")))
                        column.set_Caption(Me.BKGlobal.GetFieldLabel(ViewName, Conversions.ToString(current.Item("FieldName")), Me.SessionInfo.UserLang, Conversions.ToString(current.Item("FieldName"))))
                        GridView.get_Columns.Add(column)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Dim num As Integer = 0
            Try
                enumerator2 = view.Tables.Item("generalbrowseviewgroupby").Rows.GetEnumerator
                Do While enumerator2.MoveNext
                    current = DirectCast(enumerator2.Current, DataRow)
                    GridView.get_Columns.ColumnByFieldName(Conversions.ToString(current.Item("FieldName"))).set_GroupIndex(num)
                    num += 1
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
        End Sub


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

