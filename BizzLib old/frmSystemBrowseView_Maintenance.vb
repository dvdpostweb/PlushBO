Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmSystemBrowseView_Maintenance
        Inherits frmGeneral_Maintenance
        ' Methods
        Public Sub New()
            AddHandler MyBase.EventLoadDataset, New EventLoadDatasetEventHandler(AddressOf Me.LoadDataSet)
            AddHandler MyBase.EventNewRecord, New EventNewRecordEventHandler(AddressOf Me.NewRecord)
            AddHandler MyBase.EventPositionChanged, New EventPositionChangedEventHandler(AddressOf Me.PositionChanged)
            AddHandler MyBase.EventEditRecord, New EventEditRecordEventHandler(AddressOf Me.EditRecord)
            AddHandler MyBase.EventSaveChanges, New EventSaveChangesEventHandler(AddressOf Me.SaveChanges)
            AddHandler MyBase.EventUndoChanges, New EventUndoChangesEventHandler(AddressOf Me.UndoChanges)
            AddHandler MyBase.EventDeleteRecord, New EventDeleteRecordEventHandler(AddressOf Me.DeleteRecord)
            AddHandler MyBase.EventUpdateDataset, New EventUpdateDatasetEventHandler(AddressOf Me.UpdateDataSet)
            AddHandler MyBase.EventEnablingEditFields, New EventEnablingEditFieldsEventHandler(AddressOf Me.EnablingEditFields)
            AddHandler MyBase.EventEnablingkeyFields, New EventEnablingkeyFieldsEventHandler(AddressOf Me.EnablingKeyFields)
            AddHandler MyBase.EventPrintForm, New EventPrintFormEventHandler(AddressOf Me.StartPrintForm)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmSystemBrowseView_Maintenance.__ENCList
            SyncLock list
                frmSystemBrowseView_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableNameSub = "generalbrowseviewcolumn"
            Me.TableNameSub1 = "generalbrowseviewgroupby"
            Me.KeyDataSet = "BizzLib.dsBrowseView"
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.EventLoadDataset, New EventLoadDatasetEventHandler(AddressOf Me.LoadDataSet)
            AddHandler MyBase.EventNewRecord, New EventNewRecordEventHandler(AddressOf Me.NewRecord)
            AddHandler MyBase.EventPositionChanged, New EventPositionChangedEventHandler(AddressOf Me.PositionChanged)
            AddHandler MyBase.EventEditRecord, New EventEditRecordEventHandler(AddressOf Me.EditRecord)
            AddHandler MyBase.EventSaveChanges, New EventSaveChangesEventHandler(AddressOf Me.SaveChanges)
            AddHandler MyBase.EventUndoChanges, New EventUndoChangesEventHandler(AddressOf Me.UndoChanges)
            AddHandler MyBase.EventDeleteRecord, New EventDeleteRecordEventHandler(AddressOf Me.DeleteRecord)
            AddHandler MyBase.EventUpdateDataset, New EventUpdateDatasetEventHandler(AddressOf Me.UpdateDataSet)
            AddHandler MyBase.EventEnablingEditFields, New EventEnablingEditFieldsEventHandler(AddressOf Me.EnablingEditFields)
            AddHandler MyBase.EventEnablingkeyFields, New EventEnablingkeyFieldsEventHandler(AddressOf Me.EnablingKeyFields)
            AddHandler MyBase.EventPrintForm, New EventPrintFormEventHandler(AddressOf Me.StartPrintForm)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmSystemBrowseView_Maintenance.__ENCList
            SyncLock list
                frmSystemBrowseView_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableNameSub = "generalbrowseviewcolumn"
            Me.TableNameSub1 = "generalbrowseviewgroupby"
            Me.KeyDataSet = "BizzLib.dsBrowseView"
            Me.InitializeComponent
        End Sub

        Public Sub BrowseViewColumnVerify(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByVal TableToBeViewed As DataTable)
            Dim current As DataColumn
            Dim row As DataRow
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim view As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() { "SELECT * FROM generalbrowseviewcolumn WHERE BrowseViewID = ", Conversions.ToString(BrowseViewID), " AND ViewName = '", ViewName, "' ORDER BY FieldName " })
            Try 
                ClsDs.FillDataSet(view.Tables.Item("generalbrowseviewcolumn"), sQLTxt, True, False)
                view.Tables.Item("generalbrowseviewcolumn").PrimaryKey = New DataColumn() {view.Tables.Item("generalbrowseviewcolumn").Columns.Item("FieldName")}
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Dim num As Integer = 0
            Try
                enumerator = TableToBeViewed.Columns.GetEnumerator
                Do While enumerator.MoveNext
                    current = DirectCast(enumerator.Current, DataColumn)
                    If Information.IsNothing(view.Tables.Item("generalbrowseviewcolumn").Rows.Find(current.ColumnName)) Then
                        row = view.Tables.Item("generalbrowseviewcolumn").NewRow
                        row.Item("FieldName") = current.ColumnName
                        row.Item("OrderNbr") = num
                        num += 1
                        row.Item("BrowseViewID") = BrowseViewID
                        row.Item("ViewName") = ViewName
                        row.Item("ToShow") = 0
                        row.Item("TotalSummary") = 5
                        Me.SetDataType(current, (row))
                        If ((current.DataType Is Type.GetType("System.Decimal")) Or (current.DataType Is Type.GetType("System.Double"))) Then
                            row.Item("DataType") = "Numeric"
                        End If
                        view.Tables.Item("generalbrowseviewcolumn").Rows.Add(row)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(view.Tables.Item("generalbrowseviewcolumn"), True)
            Try
                enumerator2 = view.Tables.Item("generalbrowseviewcolumn").Rows.GetEnumerator
                Do While enumerator2.MoveNext
                    Dim enumerator3 As IEnumerator
                    row = DirectCast(enumerator2.Current, DataRow)
                    Dim flag As Boolean = True
                    Try
                        enumerator3 = TableToBeViewed.Columns.GetEnumerator
                        Do While enumerator3.MoveNext
                            current = DirectCast(enumerator3.Current, DataColumn)
                            If Operators.ConditionalCompareObjectEqual(current.ColumnName, row.Item("FieldName"), False) Then
                                flag = False
                                GoTo Label_0301
                            End If
                        Loop
                    Finally
                        If TypeOf enumerator3 Is IDisposable Then
                            TryCast(enumerator3, IDisposable).Dispose()
                        End If
                    End Try
Label_0301:
                    If flag Then
                        row.Delete()
                    End If
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(view.Tables.Item("generalbrowseviewcolumn"), True)
        End Sub

        Public Sub BrowseViewGroupByVerify(ByVal BrowseViewID As Integer, ByVal ViewName As String, ByVal TableToBeViewed As DataTable)
            Dim current As DataColumn
            Dim row As DataRow
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim view As New dsBrowseView
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generalbrowseviewgroupby WHERE BrowseViewID = ", Conversions.ToString(BrowseViewID), " AND ViewName = '", ViewName, "' ORDER BY FieldName "})
            Dim builder As New OleDbCommandBuilder(Me._OleDbDataAdapter1)
            Try
                ClsDs.FillDataSet(view.Tables.Item("generalbrowseviewgroupby"), sQLTxt, True, False)
                view.Tables.Item("generalbrowseviewgroupby").PrimaryKey = New DataColumn() {view.Tables.Item("generalbrowseviewgroupby").Columns.Item("FieldName")}
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Dim num As Integer = 0
            Try
                enumerator = TableToBeViewed.Columns.GetEnumerator
                Do While enumerator.MoveNext
                    current = DirectCast(enumerator.Current, DataColumn)
                    If Information.IsNothing(view.Tables.Item("generalbrowseviewgroupby").Rows.Find(current.ColumnName)) Then
                        row = view.Tables.Item("generalbrowseviewgroupby").NewRow
                        row.Item("FieldName") = current.ColumnName
                        row.Item("OrderNbr") = num
                        num += 1
                        row.Item("BrowseViewID") = BrowseViewID
                        row.Item("ViewName") = ViewName
                        row.Item("ToGroup") = 0
                        view.Tables.Item("generalbrowseviewgroupby").Rows.Add(row)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(view.Tables.Item("generalbrowseviewgroupby"), True)
            Try
                enumerator2 = view.Tables.Item("generalbrowseviewgroupby").Rows.GetEnumerator
                Do While enumerator2.MoveNext
                    Dim enumerator3 As IEnumerator
                    row = DirectCast(enumerator2.Current, DataRow)
                    Dim flag As Boolean = True
                    Try
                        enumerator3 = TableToBeViewed.Columns.GetEnumerator
                        Do While enumerator3.MoveNext
                            current = DirectCast(enumerator3.Current, DataColumn)
                            If Operators.ConditionalCompareObjectEqual(current.ColumnName, row.Item("FieldName"), False) Then
                                flag = False
                                GoTo Label_02BB
                            End If
                        Loop
                    Finally
                        If TypeOf enumerator3 Is IDisposable Then
                            TryCast(enumerator3, IDisposable).Dispose()
                        End If
                    End Try
Label_02BB:
                    If flag Then
                        row.Delete()
                    End If
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(view.Tables.Item("generalbrowseviewgroupby"), True)
        End Sub

        Private Sub btnDown_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num2 As Integer = Me.GridView1.get_FocusedRowHandle
            Me.GridView1.CloseEditor()
            Me.GridView1.UpdateCurrentRow()
            Dim num As Integer = Conversions.ToInteger(Me.GridView1.GetRowCellValue(Me.GridView1.get_FocusedRowHandle, Me.GridView1.get_Columns.get_Item("OrderNbr")))
            Dim right As String = Conversions.ToString(Me.GridView1.GetRowCellValue(Me.GridView1.get_FocusedRowHandle, Me.GridView1.get_Columns.get_Item("FieldName")))
            If (num <> Me.objDS.Tables.Item(Me.TableNameSub).Rows.Count) Then
                Dim current As DataRowView
                Dim enumerator As IEnumerator
                Dim enumerator2 As IEnumerator
                Dim view2 As New DataView(Me.objDS.Tables.Item(Me.TableNameSub), "", "OrderNbr", DataViewRowState.CurrentRows)
                Try
                    enumerator = view2.GetEnumerator
                    Do While enumerator.MoveNext
                        current = DirectCast(enumerator.Current, DataRowView)
                        If Operators.ConditionalCompareObjectEqual(current.Item("OrderNbr"), (num + 1), False) Then
                            current.Item("OrderNbr") = num
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                view2 = New DataView(Me.objDS.Tables.Item(Me.TableNameSub), "", "OrderNbr", DataViewRowState.CurrentRows)
                Try
                    enumerator2 = view2.GetEnumerator
                    Do While enumerator2.MoveNext
                        current = DirectCast(enumerator2.Current, DataRowView)
                        If Operators.ConditionalCompareObjectEqual(current.Item("FieldName"), right, False) Then
                            current.Item("OrderNbr") = (num + 1)
                        End If
                    Loop
                Finally
                    If TypeOf enumerator2 Is IDisposable Then
                        TryCast(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                Me.GridView1.set_FocusedRowHandle((num2 + 1))
                Me.UpdateDataSet()
            End If
        End Sub

        Private Sub btnDown1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num2 As Integer = Me.GridView2.get_FocusedRowHandle
            Me.GridView2.CloseEditor()
            Me.GridView2.UpdateCurrentRow()
            Dim num As Integer = Conversions.ToInteger(Me.GridView2.GetRowCellValue(Me.GridView2.get_FocusedRowHandle, Me.GridView2.get_Columns.get_Item("OrderNbr")))
            Dim right As String = Conversions.ToString(Me.GridView2.GetRowCellValue(Me.GridView2.get_FocusedRowHandle, Me.GridView2.get_Columns.get_Item("FieldName")))
            If (num <> Me.objDS.Tables.Item(Me.TableNameSub1).Rows.Count) Then
                Dim current As DataRowView
                Dim enumerator As IEnumerator
                Dim enumerator2 As IEnumerator
                Dim view2 As New DataView(Me.objDS.Tables.Item(Me.TableNameSub1), "", "OrderNbr", DataViewRowState.CurrentRows)
                Try
                    enumerator = view2.GetEnumerator
                    Do While enumerator.MoveNext
                        current = DirectCast(enumerator.Current, DataRowView)
                        If Operators.ConditionalCompareObjectEqual(current.Item("OrderNbr"), (num + 1), False) Then
                            current.Item("OrderNbr") = num
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                view2 = New DataView(Me.objDS.Tables.Item(Me.TableNameSub1), "", "OrderNbr", DataViewRowState.CurrentRows)
                Try
                    enumerator2 = view2.GetEnumerator
                    Do While enumerator2.MoveNext
                        current = DirectCast(enumerator2.Current, DataRowView)
                        If Operators.ConditionalCompareObjectEqual(current.Item("FieldName"), right, False) Then
                            current.Item("OrderNbr") = (num + 1)
                        End If
                    Loop
                Finally
                    If TypeOf enumerator2 Is IDisposable Then
                        TryCast(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                Me.GridView2.set_FocusedRowHandle((num2 + 1))
                Me.UpdateDataSet()
            End If
        End Sub

        Private Sub btnUP_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num2 As Integer = Me.GridView1.get_FocusedRowHandle
            Me.GridView1.CloseEditor()
            Me.GridView1.UpdateCurrentRow()
            Dim num As Integer = Conversions.ToInteger(Me.GridView1.GetRowCellValue(Me.GridView1.get_FocusedRowHandle, Me.GridView1.get_Columns.get_Item("OrderNbr")))
            Dim right As String = Conversions.ToString(Me.GridView1.GetRowCellValue(Me.GridView1.get_FocusedRowHandle, Me.GridView1.get_Columns.get_Item("FieldName")))
            If (num <> 0) Then
                Dim current As DataRowView
                Dim enumerator As IEnumerator
                Dim enumerator2 As IEnumerator
                Dim view2 As New DataView(Me.objDS.Tables.Item(Me.TableNameSub), "", "OrderNbr", DataViewRowState.CurrentRows)
                Try
                    enumerator = view2.GetEnumerator
                    Do While enumerator.MoveNext
                        current = DirectCast(enumerator.Current, DataRowView)
                        If Operators.ConditionalCompareObjectEqual(current.Item("OrderNbr"), (num - 1), False) Then
                            current.Item("OrderNbr") = num
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                view2 = New DataView(Me.objDS.Tables.Item(Me.TableNameSub), "", "OrderNbr", DataViewRowState.CurrentRows)
                Try
                    enumerator2 = view2.GetEnumerator
                    Do While enumerator2.MoveNext
                        current = DirectCast(enumerator2.Current, DataRowView)
                        If Operators.ConditionalCompareObjectEqual(current.Item("FieldName"), right, False) Then
                            current.Item("OrderNbr") = (num - 1)
                        End If
                    Loop
                Finally
                    If TypeOf enumerator2 Is IDisposable Then
                        TryCast(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                Me.GridView1.set_FocusedRowHandle((num2 - 1))
                Me.UpdateDataSet()
            End If
        End Sub

        Private Sub btnUp1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num2 As Integer = Me.GridView2.get_FocusedRowHandle
            Me.GridView2.CloseEditor()
            Me.GridView2.UpdateCurrentRow()
            Dim num As Integer = Conversions.ToInteger(Me.GridView2.GetRowCellValue(Me.GridView2.get_FocusedRowHandle, Me.GridView2.get_Columns.get_Item("OrderNbr")))
            Dim right As String = Conversions.ToString(Me.GridView2.GetRowCellValue(Me.GridView2.get_FocusedRowHandle, Me.GridView2.get_Columns.get_Item("FieldName")))
            If (num <> 0) Then
                Dim current As DataRowView
                Dim enumerator As IEnumerator
                Dim enumerator2 As IEnumerator
                Dim view2 As New DataView(Me.objDS.Tables.Item(Me.TableNameSub1), "", "OrderNbr", DataViewRowState.CurrentRows)
                Try
                    enumerator = view2.GetEnumerator
                    Do While enumerator.MoveNext
                        current = DirectCast(enumerator.Current, DataRowView)
                        If Operators.ConditionalCompareObjectEqual(current.Item("OrderNbr"), (num - 1), False) Then
                            current.Item("OrderNbr") = num
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                view2 = New DataView(Me.objDS.Tables.Item(Me.TableNameSub1), "", "OrderNbr", DataViewRowState.CurrentRows)
                Try
                    enumerator2 = view2.GetEnumerator
                    Do While enumerator2.MoveNext
                        current = DirectCast(enumerator2.Current, DataRowView)
                        If Operators.ConditionalCompareObjectEqual(current.Item("FieldName"), right, False) Then
                            current.Item("OrderNbr") = (num - 1)
                        End If
                    Loop
                Finally
                    If TypeOf enumerator2 Is IDisposable Then
                        TryCast(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                Me.GridView2.set_FocusedRowHandle((num2 - 1))
                Me.UpdateDataSet()
            End If
        End Sub

        Private Sub DeleteRecord(ByVal Sender As Object, ByVal e As EventArgs)
            If (((Me.BindingContext.Item(Me.objDS, MyBase.TableName).Count > 0) AndAlso (Interaction.MsgBox(MyBase.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes)) AndAlso Me.ValidateBeforeDelete) Then
                MyBase.BKBrowseView.DeleteBrowseViewColumn(Conversions.ToInteger(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField)))
                MyBase.BKBrowseView.DeleteBrowseViewGroupBy(Conversions.ToInteger(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField)))
                Me.BindingContext.Item(Me.objDS, MyBase.TableName).RemoveAt(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position)
                Me.UpdateDataSet()
                Me.EnablingAll(False)
                Me.PositionChanged(RuntimeHelpers.GetObjectValue(Sender), e)
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub EditRecord(ByVal Sender As Object, ByVal e As EventArgs)
            If (Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position >= 0) Then
                If Operators.ConditionalCompareObjectEqual(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item("SystemView"), 1, False) Then
                    Interaction.MsgBox(MyBase.BKGlobal.GetMsg(&H2A, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), 0, False), Not Me.SessionInfo.CanModifyGlobalViews)) Then
                    Interaction.MsgBox(MyBase.BKGlobal.GetMsg(&H27, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                Else
                    Me.SetState(ObjectState.EditState)
                    Me.PopMenuNew.Enabled = False
                    Me.PopMenuEdit.Enabled = False
                    Me.PopMenuSave.Enabled = True
                    Me.PopMenuDelete.Enabled = False
                    Me.PopMenuUndo.Enabled = True
                    Me.EnablingForEdit()
                    MyBase.OpenType = "EDIT"
                End If
            End If
        End Sub

        Private Sub EnablingEditFields(ByVal Enabling As Boolean)
            Me.txtName.Enabled = Enabling
            Me.txtDescription.Enabled = Enabling
            Me.chkDefault.Enabled = Enabling
            Me.Grid1.Enabled = Enabling
            Me.btnDown.Enabled = Enabling
            Me.btnUP.Enabled = Enabling
            Me.Grid2.Enabled = Enabling
            Me.btnDown1.Enabled = Enabling
            Me.btnUp1.Enabled = Enabling
        End Sub

        Private Sub EnablingKeyFields(ByVal Enabling As Boolean)
        End Sub

        Private Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            If ((MyBase.OpenType = "EDIT") Or (MyBase.OpenType = "NEW")) Then
                Select Case Interaction.MsgBox(MyBase.BKGlobal.GetMsg(4, Me.SessionInfo.UserLang, True), (MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel), Nothing)
                    Case MsgBoxResult.Yes
                        Me.SaveChanges(RuntimeHelpers.GetObjectValue(sender), e)
                        Exit Select
                    Case MsgBoxResult.No
                        Me.UndoChanges(RuntimeHelpers.GetObjectValue(sender), e)
                        Exit Select
                    Case MsgBoxResult.Cancel
                        e.Cancel = True
                        Exit Select
                End Select
            End If
        End Sub

        Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Try
                MyBase.KeyFieldName = "Name"
                MyBase.IDField = "BrowseViewID"
                MyBase.TableName = "generalbrowseview"
                Me.MainDataSet = Me.objDS
                Me.HelpProvider1.HelpNamespace = (".\Help\" & Me.SessionInfo.UserLang & "\BizzKeys.chm")
                MyBase.SQLTxt1 = Me.OleDbDataAdapter1.SelectCommand.CommandText
                MyBase.BKCombo.GetCombo_generalglobalcodeint(Me.objDS, "TotalSummaryType", "TotalSummaryType", "CodeType")
                MyBase.BKCombo.GetCombo_generalglobalcodeint(Me.objDS, "GroupSummaryType", "GroupSummaryType", "CodeType")
                Me.LoadDataSet()
                If Not Information.IsNothing(Me.BarManager1.get_Bars.get_Item("Misc_Bar2")) Then
                    Me.BarManager1.get_Bars.get_Item("Misc_Bar2").set_Visible(False)
                End If
                If Not Information.IsNothing(Me.BarManager1.get_Bars.get_Item("Filter_Bar")) Then
                    Me.BarManager1.get_Bars.get_Item("Filter_Bar").set_Visible(False)
                End If
                If Not Information.IsNothing(Me.BarManager1.get_Bars.get_Item("DefaultSet_Bar")) Then
                    Me.BarManager1.get_Bars.get_Item("DefaultSet_Bar").set_Visible(False)
                End If
                If (MyBase.OpenType = "NEW") Then
                    Me.NewRecord(RuntimeHelpers.GetObjectValue(sender), e)
                End If
                If (MyBase.OpenType = "EDIT") Then
                    If (MyBase.KeyValue <> "") Then
                        Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Sort = MyBase.IDField
                        Dim str As String = Conversions.ToString(Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Item(Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Find(New Object() {MyBase.KeyValue})).Item(MyBase.KeyFieldName))
                        Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Sort = MyBase.KeyFieldName
                        Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position = Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Find(New Object() {str})
                        Me.PositionChanged(RuntimeHelpers.GetObjectValue(sender), e)
                        Me.EditRecord(RuntimeHelpers.GetObjectValue(sender), e)
                    Else
                        MyBase.OpenType = "BROWSE"
                        Return
                    End If
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError()
            End Try
            Me.PositionChanged(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        <DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(frmSystemBrowseView_Maintenance))
            Me.lblName = New Label
            Me.lblDescription = New Label
            Me.txtName = New TextBox
            Me.objDS = New dsBrowseView
            Me.txtDescription = New TextBox
            Me.Panel1 = New Panel
            Me.TabControl1 = New TabControl
            Me.tabColumns = New TabPage
            Me.Panel4 = New Panel
            Me.Grid1 = New GridControl
            Me.GridView1 = New GridView
            Me.colOrderNbr = New GridColumn
            Me.colFieldName = New GridColumn
            Me.colToShow = New GridColumn
            Me.chkToShow = New RepositoryItemCheckEdit
            Me.colColumnWidth = New GridColumn
            Me.colRowIndex = New GridColumn
            Me.colTotalSummary = New GridColumn
            Me.TotalSummaryTypesLookUp = New RepositoryItemLookUpEdit
            Me.colGroupSummary = New GridColumn
            Me.GroupSummaryTypeLookUp = New RepositoryItemLookUpEdit
            Me.colDataType = New GridColumn
            Me.Panel3 = New Panel
            Me.btnDown = New SimpleButton
            Me.btnUP = New SimpleButton
            Me.tabGroupBy = New TabPage
            Me.Grid2 = New GridControl
            Me.GridView2 = New GridView
            Me.colFieldName1 = New GridColumn
            Me.colOrderNbr1 = New GridColumn
            Me.colToGroup = New GridColumn
            Me.chkToGroup = New RepositoryItemCheckEdit
            Me.Panel5 = New Panel
            Me.btnDown1 = New SimpleButton
            Me.btnUp1 = New SimpleButton
            Me.Panel2 = New Panel
            Me.chkDefault = New CheckBox
            Me.OleDbDataAdapter1 = New OleDbDataAdapter
            Me.OleDbDeleteCommand1 = New OleDbCommand
            Me.OleDbInsertCommand1 = New OleDbCommand
            Me.OleDbSelectCommand1 = New OleDbCommand
            Me.OleDbUpdateCommand1 = New OleDbCommand
            Me.OleDbDataAdapter2 = New OleDbDataAdapter
            Me.OleDbDeleteCommand2 = New OleDbCommand
            Me.OleDbInsertCommand2 = New OleDbCommand
            Me.OleDbSelectCommand2 = New OleDbCommand
            Me.OleDbUpdateCommand2 = New OleDbCommand
            Me.OleDbDataAdapter3 = New OleDbDataAdapter
            Me.OleDbDeleteCommand3 = New OleDbCommand
            Me.OleDbInsertCommand3 = New OleDbCommand
            Me.OleDbSelectCommand3 = New OleDbCommand
            Me.OleDbUpdateCommand3 = New OleDbCommand
            Me.colcolumn_header = New GridColumn
            Me.PrintSystem1.BeginInit()
            Me.MainDataSet.BeginInit()
            Me.cmbViewListRepos.BeginInit()
            Me.txtQuickSearchRepos.BeginInit()
            Me.cmbReportListRepos.BeginInit()
            Me.cmbFilterListRepos.BeginInit()
            Me.cmbDefaultListRepos.BeginInit()
            Me.objDS.BeginInit()
            Me.Panel1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.tabColumns.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Grid1.BeginInit()
            Me.GridView1.BeginInit()
            Me.chkToShow.BeginInit()
            Me.TotalSummaryTypesLookUp.BeginInit()
            Me.GroupSummaryTypeLookUp.BeginInit()
            Me.Panel3.SuspendLayout()
            Me.tabGroupBy.SuspendLayout()
            Me.Grid2.BeginInit()
            Me.GridView2.BeginInit()
            Me.chkToGroup.BeginInit()
            Me.Panel5.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            Dim point As New Point(0, 440)
            Me.StatusBar1.Location = point
            Dim size As New Size(&H379, &H16)
            Me.StatusBar1.Size = size
            point = New Point(8, 8)
            Me.lblName.Location = point
            Me.lblName.Name = "lblName"
            size = New Size(100, &H17)
            Me.lblName.Size = size
            Me.lblName.TabIndex = 3
            Me.lblName.Text = "Name"
            point = New Point(8, &H20)
            Me.lblDescription.Location = point
            Me.lblDescription.Name = "lblDescription"
            size = New Size(100, &H17)
            Me.lblDescription.Size = size
            Me.lblDescription.TabIndex = 4
            Me.lblDescription.Text = "Description"
            Me.txtName.DataBindings.Add(New Binding("Text", Me.objDS, "generalbrowseview.Name", True))
            Me.txtName.Enabled = False
            point = New Point(&H70, 8)
            Me.txtName.Location = point
            Me.txtName.Name = "txtName"
            size = New Size(&HF8, 20)
            Me.txtName.Size = size
            Me.txtName.TabIndex = 8
            Me.objDS.DataSetName = "dsBrowseView"
            Me.objDS.Locale = New CultureInfo("en-US")
            Me.objDS.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.txtDescription.DataBindings.Add(New Binding("Text", Me.objDS, "generalbrowseview.Description", True))
            Me.txtDescription.Enabled = False
            point = New Point(&H70, &H20)
            Me.txtDescription.Location = point
            Me.txtDescription.Name = "txtDescription"
            size = New Size(&H180, 20)
            Me.txtDescription.Size = size
            Me.txtDescription.TabIndex = 9
            Me.Panel1.BackColor = SystemColors.Window
            Me.Panel1.Controls.Add(Me.TabControl1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = DockStyle.Fill
            point = New Point(0, &H39)
            Me.Panel1.Location = point
            Me.Panel1.Name = "Panel1"
            size = New Size(&H379, &H17F)
            Me.Panel1.Size = size
            Me.Panel1.TabIndex = &H1F
            Me.TabControl1.Controls.Add(Me.tabColumns)
            Me.TabControl1.Controls.Add(Me.tabGroupBy)
            Me.TabControl1.Dock = DockStyle.Fill
            point = New Point(0, &H38)
            Me.TabControl1.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            size = New Size(&H379, &H147)
            Me.TabControl1.Size = size
            Me.TabControl1.TabIndex = 13
            Me.tabColumns.Controls.Add(Me.Panel4)
            point = New Point(4, &H16)
            Me.tabColumns.Location = point
            Me.tabColumns.Name = "tabColumns"
            size = New Size(&H371, &H12D)
            Me.tabColumns.Size = size
            Me.tabColumns.TabIndex = 0
            Me.tabColumns.Text = "Columns"
            Me.Panel4.Controls.Add(Me.Grid1)
            Me.Panel4.Controls.Add(Me.Panel3)
            Me.Panel4.Dock = DockStyle.Fill
            point = New Point(0, 0)
            Me.Panel4.Location = point
            Me.Panel4.Name = "Panel4"
            size = New Size(&H371, &H12D)
            Me.Panel4.Size = size
            Me.Panel4.TabIndex = 6
            Me.Grid1.set_DataSource(Me.objDS.generalbrowseviewcolumn)
            Me.Grid1.Dock = DockStyle.Fill
            Me.Grid1.get_EmbeddedNavigator.Name = ""
            Me.Grid1.set_FormsUseDefaultLookAndFeel(False)
            point = New Point(0, 0)
            Me.Grid1.Location = point
            Me.Grid1.set_MainView(Me.GridView1)
            Me.Grid1.Name = "Grid1"
            Me.Grid1.get_RepositoryItems.AddRange(New RepositoryItem() {Me.chkToShow, Me.TotalSummaryTypesLookUp, Me.GroupSummaryTypeLookUp})
            size = New Size(&H371, &H105)
            Me.Grid1.Size = size
            Me.Grid1.TabIndex = 5
            Me.Grid1.get_ViewCollection.AddRange(New BaseView() {Me.GridView1})
            Me.GridView1.get_Columns.AddRange(New GridColumn() {Me.colOrderNbr, Me.colFieldName, Me.colToShow, Me.colColumnWidth, Me.colRowIndex, Me.colTotalSummary, Me.colGroupSummary, Me.colDataType, Me.colcolumn_header})
            Me.GridView1.set_GridControl(Me.Grid1)
            Me.GridView1.set_GroupPanelText("...")
            Me.GridView1.set_Name("GridView1")
            Me.GridView1.get_SortInfo.AddRange(New GridColumnSortInfo() {New GridColumnSortInfo(Me.colOrderNbr, 1)})
            Me.colOrderNbr.set_Caption("OrderNbr")
            Me.colOrderNbr.set_FieldName("OrderNbr")
            Me.colOrderNbr.set_Name("colOrderNbr")
            Me.colOrderNbr.set_Visible(True)
            Me.colOrderNbr.set_VisibleIndex(0)
            Me.colOrderNbr.set_Width(&H3A)
            Me.colFieldName.set_Caption("FieldName")
            Me.colFieldName.set_FieldName("FieldName")
            Me.colFieldName.set_Name("colFieldName")
            Me.colFieldName.set_Visible(True)
            Me.colFieldName.set_VisibleIndex(1)
            Me.colFieldName.set_Width(&HB6)
            Me.colToShow.set_Caption("ToShow")
            Me.colToShow.set_ColumnEdit(Me.chkToShow)
            Me.colToShow.set_FieldName("ToShow")
            Me.colToShow.set_Name("colToShow")
            Me.colToShow.set_Visible(True)
            Me.colToShow.set_VisibleIndex(2)
            Me.colToShow.set_Width(&H39)
            Me.chkToShow.set_AutoHeight(False)
            Me.chkToShow.set_Name("chkToShow")
            Me.chkToShow.set_NullStyle(0)
            Me.colColumnWidth.set_Caption("ColumnWidth")
            Me.colColumnWidth.set_FieldName("ColumnWidth")
            Me.colColumnWidth.set_Name("colColumnWidth")
            Me.colColumnWidth.set_Visible(True)
            Me.colColumnWidth.set_VisibleIndex(3)
            Me.colColumnWidth.set_Width(&H4C)
            Me.colRowIndex.set_Caption("RowIndex")
            Me.colRowIndex.set_FieldName("RowIndex")
            Me.colRowIndex.set_Name("colRowIndex")
            Me.colRowIndex.set_Visible(True)
            Me.colRowIndex.set_VisibleIndex(4)
            Me.colRowIndex.set_Width(&H3E)
            Me.colTotalSummary.set_Caption("TotalSummary")
            Me.colTotalSummary.set_ColumnEdit(Me.TotalSummaryTypesLookUp)
            Me.colTotalSummary.set_FieldName("TotalSummary")
            Me.colTotalSummary.set_Name("colTotalSummary")
            Me.colTotalSummary.set_Visible(True)
            Me.colTotalSummary.set_VisibleIndex(5)
            Me.TotalSummaryTypesLookUp.set_AutoHeight(False)
            Me.TotalSummaryTypesLookUp.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            Me.TotalSummaryTypesLookUp.get_Columns.AddRange(New LookUpColumnInfo() {New LookUpColumnInfo("CodeDesc", "CodeDesc", 60, 0, "", True, 1)})
            Me.TotalSummaryTypesLookUp.set_DataSource(Me.objDS.TotalSummaryType)
            Me.TotalSummaryTypesLookUp.set_DisplayMember("CodeDesc")
            Me.TotalSummaryTypesLookUp.set_Name("TotalSummaryTypesLookUp")
            Me.TotalSummaryTypesLookUp.set_NullText("")
            Me.TotalSummaryTypesLookUp.set_ValueMember("CodeValue")
            Me.colGroupSummary.set_Caption("GroupSummary")
            Me.colGroupSummary.set_ColumnEdit(Me.GroupSummaryTypeLookUp)
            Me.colGroupSummary.set_FieldName("GroupSummary")
            Me.colGroupSummary.set_Name("colGroupSummary")
            Me.colGroupSummary.set_Visible(True)
            Me.colGroupSummary.set_VisibleIndex(6)
            Me.GroupSummaryTypeLookUp.set_AutoHeight(False)
            Me.GroupSummaryTypeLookUp.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            Me.GroupSummaryTypeLookUp.get_Columns.AddRange(New LookUpColumnInfo() {New LookUpColumnInfo("CodeDesc", "CodeDesc", 60, 0, "", True, 1)})
            Me.GroupSummaryTypeLookUp.set_DataSource(Me.objDS.GroupSummaryType)
            Me.GroupSummaryTypeLookUp.set_DisplayMember("CodeDesc")
            Me.GroupSummaryTypeLookUp.set_Name("GroupSummaryTypeLookUp")
            Me.GroupSummaryTypeLookUp.set_NullText("")
            Me.GroupSummaryTypeLookUp.set_ValueMember("CodeValue")
            Me.colDataType.set_Caption("DataType")
            Me.colDataType.set_FieldName("DataType")
            Me.colDataType.set_Name("colDataType")
            Me.colDataType.set_Visible(True)
            Me.colDataType.set_VisibleIndex(7)
            Me.Panel3.Controls.Add(Me.btnDown)
            Me.Panel3.Controls.Add(Me.btnUP)
            Me.Panel3.Dock = DockStyle.Bottom
            point = New Point(0, &H105)
            Me.Panel3.Location = point
            Me.Panel3.Name = "Panel3"
            size = New Size(&H371, 40)
            Me.Panel3.Size = size
            Me.Panel3.TabIndex = 4
            Me.btnDown.set_Image(DirectCast(manager.GetObject("btnDown.Image"), Image))
            Me.btnDown.set_ImageIndex(13)
            point = New Point(&H38, 8)
            Me.btnDown.Location = point
            Me.btnDown.Name = "btnDown"
            size = New Size(&H20, &H17)
            Me.btnDown.Size = size
            Me.btnDown.TabIndex = 3
            Me.btnUP.set_Image(DirectCast(manager.GetObject("btnUP.Image"), Image))
            Me.btnUP.set_ImageIndex(14)
            point = New Point(&H10, 8)
            Me.btnUP.Location = point
            Me.btnUP.Name = "btnUP"
            size = New Size(&H20, &H17)
            Me.btnUP.Size = size
            Me.btnUP.TabIndex = 2
            Me.tabGroupBy.Controls.Add(Me.Grid2)
            Me.tabGroupBy.Controls.Add(Me.Panel5)
            point = New Point(4, &H16)
            Me.tabGroupBy.Location = point
            Me.tabGroupBy.Name = "tabGroupBy"
            size = New Size(&H2E0, &H130)
            Me.tabGroupBy.Size = size
            Me.tabGroupBy.TabIndex = 1
            Me.tabGroupBy.Text = "Group By"
            Me.Grid2.set_DataSource(Me.objDS.generalbrowseviewgroupby)
            Me.Grid2.Dock = DockStyle.Fill
            Me.Grid2.get_EmbeddedNavigator.Name = ""
            Me.Grid2.set_FormsUseDefaultLookAndFeel(False)
            point = New Point(0, 0)
            Me.Grid2.Location = point
            Me.Grid2.set_MainView(Me.GridView2)
            Me.Grid2.Name = "Grid2"
            Me.Grid2.get_RepositoryItems.AddRange(New RepositoryItem() {Me.chkToShow, Me.chkToGroup})
            size = New Size(&H2E0, &H108)
            Me.Grid2.Size = size
            Me.Grid2.TabIndex = 7
            Me.Grid2.get_ViewCollection.AddRange(New BaseView() {Me.GridView2})
            Me.GridView2.get_Columns.AddRange(New GridColumn() {Me.colFieldName1, Me.colOrderNbr1, Me.colToGroup})
            Me.GridView2.set_GridControl(Me.Grid2)
            Me.GridView2.set_GroupPanelText("...")
            Me.GridView2.get_GroupSummary.AddRange(New GridSummaryItem() {New GridGroupSummaryItem(6, "ViewName", Nothing, "")})
            Me.GridView2.set_Name("GridView2")
            Me.GridView2.get_SortInfo.AddRange(New GridColumnSortInfo() {New GridColumnSortInfo(Me.colOrderNbr1, 1)})
            Me.colFieldName1.set_Caption("FieldName")
            Me.colFieldName1.set_FieldName("FieldName")
            Me.colFieldName1.set_Name("colFieldName1")
            Me.colFieldName1.set_Visible(True)
            Me.colFieldName1.set_VisibleIndex(1)
            Me.colFieldName1.set_Width(&H14B)
            Me.colOrderNbr1.set_Caption("OrderNbr")
            Me.colOrderNbr1.set_FieldName("OrderNbr")
            Me.colOrderNbr1.set_Name("colOrderNbr1")
            Me.colOrderNbr1.set_Visible(True)
            Me.colOrderNbr1.set_VisibleIndex(0)
            Me.colOrderNbr1.set_Width(&H4E)
            Me.colToGroup.set_Caption("ToGroup")
            Me.colToGroup.set_ColumnEdit(Me.chkToGroup)
            Me.colToGroup.set_FieldName("ToGroup")
            Me.colToGroup.set_Name("colToGroup")
            Me.colToGroup.set_Visible(True)
            Me.colToGroup.set_VisibleIndex(2)
            Me.colToGroup.set_Width(&H59)
            Me.chkToGroup.set_AutoHeight(False)
            Me.chkToGroup.set_Name("chkToGroup")
            Me.chkToGroup.set_NullStyle(0)
            Me.Panel5.Controls.Add(Me.btnDown1)
            Me.Panel5.Controls.Add(Me.btnUp1)
            Me.Panel5.Dock = DockStyle.Bottom
            point = New Point(0, &H108)
            Me.Panel5.Location = point
            Me.Panel5.Name = "Panel5"
            size = New Size(&H2E0, 40)
            Me.Panel5.Size = size
            Me.Panel5.TabIndex = 6
            Me.btnDown1.set_Image(DirectCast(manager.GetObject("btnDown1.Image"), Image))
            Me.btnDown1.set_ImageIndex(13)
            point = New Point(&H38, 8)
            Me.btnDown1.Location = point
            Me.btnDown1.Name = "btnDown1"
            size = New Size(&H20, &H17)
            Me.btnDown1.Size = size
            Me.btnDown1.TabIndex = 3
            Me.btnUp1.set_Image(DirectCast(manager.GetObject("btnUp1.Image"), Image))
            Me.btnUp1.set_ImageIndex(14)
            point = New Point(&H10, 8)
            Me.btnUp1.Location = point
            Me.btnUp1.Name = "btnUp1"
            size = New Size(&H20, &H17)
            Me.btnUp1.Size = size
            Me.btnUp1.TabIndex = 2
            Me.Panel2.Controls.Add(Me.txtName)
            Me.Panel2.Controls.Add(Me.lblDescription)
            Me.Panel2.Controls.Add(Me.lblName)
            Me.Panel2.Controls.Add(Me.txtDescription)
            Me.Panel2.Controls.Add(Me.chkDefault)
            Me.Panel2.Dock = DockStyle.Top
            point = New Point(0, 0)
            Me.Panel2.Location = point
            Me.Panel2.Name = "Panel2"
            size = New Size(&H379, &H38)
            Me.Panel2.Size = size
            Me.Panel2.TabIndex = 11
            Me.chkDefault.CheckAlign = ContentAlignment.MiddleRight
            Me.chkDefault.DataBindings.Add(New Binding("Checked", Me.objDS, "generalbrowseview.DefaultView", True))
            point = New Point(&H170, 4)
            Me.chkDefault.Location = point
            Me.chkDefault.Name = "chkDefault"
            size = New Size(120, &H18)
            Me.chkDefault.Size = size
            Me.chkDefault.TabIndex = 10
            Me.chkDefault.Text = "Default"
            Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
            Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
            Me.OleDbDataAdapter1.TableMappings.AddRange(New DataTableMapping() {New DataTableMapping("Table", "generalbrowseview", New DataColumnMapping() {New DataColumnMapping("BrowseViewID", "BrowseViewID"), New DataColumnMapping("UserID", "UserID"), New DataColumnMapping("MenuID", "MenuID"), New DataColumnMapping("Name", "Name"), New DataColumnMapping("Description", "Description"), New DataColumnMapping("DefaultView", "DefaultView"), New DataColumnMapping("WindowWidth", "WindowWidth"), New DataColumnMapping("WindowHeight", "WindowHeight"), New DataColumnMapping("SystemView", "SystemView")})})
            Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
            Me.OleDbDeleteCommand1.CommandText = manager.GetString("OleDbDeleteCommand1.CommandText")
            Me.OleDbDeleteCommand1.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("Original_BrowseViewID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "BrowseViewID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_DefaultView", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultView", DataRowVersion.Original, Nothing), New OleDbParameter("Original_DefaultView1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultView", DataRowVersion.Original, Nothing), New OleDbParameter("Original_Description", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing), New OleDbParameter("Original_Description1", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing), New OleDbParameter("Original_MenuID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_MenuID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_Name", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing), New OleDbParameter("Original_Name1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing), New OleDbParameter("Original_SystemView", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemView", DataRowVersion.Original, Nothing), New OleDbParameter("Original_SystemView1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemView", DataRowVersion.Original, Nothing), New OleDbParameter("Original_UserID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_UserID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_WindowHeight", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "WindowHeight", DataRowVersion.Original, Nothing), New OleDbParameter("Original_WindowHeight1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "WindowHeight", DataRowVersion.Original, Nothing), New OleDbParameter("Original_WindowWidth", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "WindowWidth", DataRowVersion.Original, Nothing), New OleDbParameter("Original_WindowWidth1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "WindowWidth", DataRowVersion.Original, Nothing)})
            Me.OleDbInsertCommand1.CommandText = manager.GetString("OleDbInsertCommand1.CommandText")
            Me.OleDbInsertCommand1.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("UserID", OleDbType.Integer, 4, "UserID"), New OleDbParameter("MenuID", OleDbType.Integer, 4, "MenuID"), New OleDbParameter("Name", OleDbType.VarChar, 50, "Name"), New OleDbParameter("Description", OleDbType.VarChar, 150, "Description"), New OleDbParameter("DefaultView", OleDbType.Integer, 4, "DefaultView"), New OleDbParameter("WindowWidth", OleDbType.Integer, 4, "WindowWidth"), New OleDbParameter("WindowHeight", OleDbType.Integer, 4, "WindowHeight"), New OleDbParameter("SystemView", OleDbType.Integer, 4, "SystemView"), New OleDbParameter("Select_BrowseViewID", OleDbType.Integer, 4, "BrowseViewID")})
            Me.OleDbSelectCommand1.CommandText = "SELECT BrowseViewID, UserID, MenuID, Name, Description, DefaultView, WindowWidth, WindowHeight, SystemView FROM generalbrowseview"
            Me.OleDbUpdateCommand1.CommandText = manager.GetString("OleDbUpdateCommand1.CommandText")
            Me.OleDbUpdateCommand1.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("UserID", OleDbType.Integer, 4, "UserID"), New OleDbParameter("MenuID", OleDbType.Integer, 4, "MenuID"), New OleDbParameter("Name", OleDbType.VarChar, 50, "Name"), New OleDbParameter("Description", OleDbType.VarChar, 150, "Description"), New OleDbParameter("DefaultView", OleDbType.Integer, 4, "DefaultView"), New OleDbParameter("WindowWidth", OleDbType.Integer, 4, "WindowWidth"), New OleDbParameter("WindowHeight", OleDbType.Integer, 4, "WindowHeight"), New OleDbParameter("SystemView", OleDbType.Integer, 4, "SystemView"), New OleDbParameter("Original_BrowseViewID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "BrowseViewID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_DefaultView", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultView", DataRowVersion.Original, Nothing), New OleDbParameter("Original_DefaultView1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultView", DataRowVersion.Original, Nothing), New OleDbParameter("Original_Description", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing), New OleDbParameter("Original_Description1", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing), New OleDbParameter("Original_MenuID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_MenuID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_Name", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing), New OleDbParameter("Original_Name1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing), New OleDbParameter("Original_SystemView", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemView", DataRowVersion.Original, Nothing), New OleDbParameter("Original_SystemView1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemView", DataRowVersion.Original, Nothing), New OleDbParameter("Original_UserID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_UserID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_WindowHeight", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "WindowHeight", DataRowVersion.Original, Nothing), New OleDbParameter("Original_WindowHeight1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "WindowHeight", DataRowVersion.Original, Nothing), New OleDbParameter("Original_WindowWidth", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "WindowWidth", DataRowVersion.Original, Nothing), New OleDbParameter("Original_WindowWidth1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "WindowWidth", DataRowVersion.Original, Nothing), New OleDbParameter("Select_BrowseViewID", OleDbType.Integer, 4, "BrowseViewID")})
            Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
            Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
            Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
            Me.OleDbDataAdapter2.TableMappings.AddRange(New DataTableMapping() {New DataTableMapping("Table", "generalbrowseviewcolumn", New DataColumnMapping() {New DataColumnMapping("BrowseViewID", "BrowseViewID"), New DataColumnMapping("ViewName", "ViewName"), New DataColumnMapping("FieldName", "FieldName"), New DataColumnMapping("OrderNbr", "OrderNbr"), New DataColumnMapping("ColumnWidth", "ColumnWidth"), New DataColumnMapping("ToShow", "ToShow"), New DataColumnMapping("RowIndex", "RowIndex"), New DataColumnMapping("GroupSummary", "GroupSummary"), New DataColumnMapping("TotalSummary", "TotalSummary"), New DataColumnMapping("DataType", "DataType")})})
            Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
            Me.OleDbDeleteCommand2.CommandText = manager.GetString("OleDbDeleteCommand2.CommandText")
            Me.OleDbDeleteCommand2.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("Original_BrowseViewID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "BrowseViewID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_FieldName", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ViewName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ViewName", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ColumnWidth", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "ColumnWidth", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ColumnWidth1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "ColumnWidth", DataRowVersion.Original, Nothing), New OleDbParameter("Original_DataType", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "DataType", DataRowVersion.Original, Nothing), New OleDbParameter("Original_DataType1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "DataType", DataRowVersion.Original, Nothing), New OleDbParameter("Original_GroupSummary", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "GroupSummary", DataRowVersion.Original, Nothing), New OleDbParameter("Original_GroupSummary1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "GroupSummary", DataRowVersion.Original, Nothing), New OleDbParameter("Original_OrderNbr", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing), New OleDbParameter("Original_OrderNbr1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing), New OleDbParameter("Original_RowIndex", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "RowIndex", DataRowVersion.Original, Nothing), New OleDbParameter("Original_RowIndex1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "RowIndex", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ToShow", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "ToShow", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ToShow1", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "ToShow", DataRowVersion.Original, Nothing), New OleDbParameter("Original_TotalSummary", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TotalSummary", DataRowVersion.Original, Nothing), New OleDbParameter("Original_TotalSummary1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TotalSummary", DataRowVersion.Original, Nothing)})
            Me.OleDbInsertCommand2.CommandText = manager.GetString("OleDbInsertCommand2.CommandText")
            Me.OleDbInsertCommand2.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("ViewName", OleDbType.VarChar, 50, "ViewName"), New OleDbParameter("FieldName", OleDbType.VarChar, 150, "FieldName"), New OleDbParameter("OrderNbr", OleDbType.Integer, 4, "OrderNbr"), New OleDbParameter("ColumnWidth", OleDbType.Integer, 4, "ColumnWidth"), New OleDbParameter("ToShow", OleDbType.Boolean, 1, "ToShow"), New OleDbParameter("RowIndex", OleDbType.Integer, 4, "RowIndex"), New OleDbParameter("GroupSummary", OleDbType.Integer, 4, "GroupSummary"), New OleDbParameter("TotalSummary", OleDbType.Integer, 4, "TotalSummary"), New OleDbParameter("DataType", OleDbType.VarChar, 50, "DataType"), New OleDbParameter("Select_BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("Select_FieldName", OleDbType.VarChar, 150, "FieldName"), New OleDbParameter("Select_ViewName", OleDbType.VarChar, 50, "ViewName")})
            Me.OleDbSelectCommand2.CommandText = "SELECT BrowseViewID, ViewName, FieldName, OrderNbr, ColumnWidth, ToShow, RowIndex, GroupSummary, TotalSummary, DataType FROM generalbrowseviewcolumn"
            Me.OleDbUpdateCommand2.CommandText = manager.GetString("OleDbUpdateCommand2.CommandText")
            Me.OleDbUpdateCommand2.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("ViewName", OleDbType.VarChar, 50, "ViewName"), New OleDbParameter("FieldName", OleDbType.VarChar, 150, "FieldName"), New OleDbParameter("OrderNbr", OleDbType.Integer, 4, "OrderNbr"), New OleDbParameter("ColumnWidth", OleDbType.Integer, 4, "ColumnWidth"), New OleDbParameter("ToShow", OleDbType.Boolean, 1, "ToShow"), New OleDbParameter("RowIndex", OleDbType.Integer, 4, "RowIndex"), New OleDbParameter("GroupSummary", OleDbType.Integer, 4, "GroupSummary"), New OleDbParameter("TotalSummary", OleDbType.Integer, 4, "TotalSummary"), New OleDbParameter("DataType", OleDbType.VarChar, 50, "DataType"), New OleDbParameter("Original_BrowseViewID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "BrowseViewID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_FieldName", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ViewName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ViewName", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ColumnWidth", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "ColumnWidth", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ColumnWidth1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "ColumnWidth", DataRowVersion.Original, Nothing), New OleDbParameter("Original_DataType", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "DataType", DataRowVersion.Original, Nothing), New OleDbParameter("Original_DataType1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "DataType", DataRowVersion.Original, Nothing), New OleDbParameter("Original_GroupSummary", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "GroupSummary", DataRowVersion.Original, Nothing), New OleDbParameter("Original_GroupSummary1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "GroupSummary", DataRowVersion.Original, Nothing), New OleDbParameter("Original_OrderNbr", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing), New OleDbParameter("Original_OrderNbr1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing), New OleDbParameter("Original_RowIndex", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "RowIndex", DataRowVersion.Original, Nothing), New OleDbParameter("Original_RowIndex1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "RowIndex", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ToShow", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "ToShow", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ToShow1", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "ToShow", DataRowVersion.Original, Nothing), New OleDbParameter("Original_TotalSummary", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TotalSummary", DataRowVersion.Original, Nothing), New OleDbParameter("Original_TotalSummary1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TotalSummary", DataRowVersion.Original, Nothing), New OleDbParameter("Select_BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("Select_FieldName", OleDbType.VarChar, 150, "FieldName"), New OleDbParameter("Select_ViewName", OleDbType.VarChar, 50, "ViewName")})
            Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand3
            Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
            Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
            Me.OleDbDataAdapter3.TableMappings.AddRange(New DataTableMapping() {New DataTableMapping("Table", "generalbrowseviewgroupby", New DataColumnMapping() {New DataColumnMapping("BrowseViewID", "BrowseViewID"), New DataColumnMapping("ViewName", "ViewName"), New DataColumnMapping("FieldName", "FieldName"), New DataColumnMapping("OrderNbr", "OrderNbr"), New DataColumnMapping("ToGroup", "ToGroup")})})
            Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand3
            Me.OleDbDeleteCommand3.CommandText = manager.GetString("OleDbDeleteCommand3.CommandText")
            Me.OleDbDeleteCommand3.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("Original_BrowseViewID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "BrowseViewID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_FieldName", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ViewName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ViewName", DataRowVersion.Original, Nothing), New OleDbParameter("Original_OrderNbr", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing), New OleDbParameter("Original_OrderNbr1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ToGroup", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "ToGroup", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ToGroup1", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "ToGroup", DataRowVersion.Original, Nothing)})
            Me.OleDbInsertCommand3.CommandText = manager.GetString("OleDbInsertCommand3.CommandText")
            Me.OleDbInsertCommand3.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("ViewName", OleDbType.VarChar, 50, "ViewName"), New OleDbParameter("FieldName", OleDbType.VarChar, 150, "FieldName"), New OleDbParameter("OrderNbr", OleDbType.Integer, 4, "OrderNbr"), New OleDbParameter("ToGroup", OleDbType.Boolean, 1, "ToGroup"), New OleDbParameter("Select_BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("Select_FieldName", OleDbType.VarChar, 150, "FieldName"), New OleDbParameter("Select_ViewName", OleDbType.VarChar, 50, "ViewName")})
            Me.OleDbSelectCommand3.CommandText = "SELECT BrowseViewID, ViewName, FieldName, OrderNbr, ToGroup FROM GeneralBrowseViewGroupBy"
            Me.OleDbUpdateCommand3.CommandText = manager.GetString("OleDbUpdateCommand3.CommandText")
            Me.OleDbUpdateCommand3.Parameters.AddRange(New OleDbParameter() {New OleDbParameter("BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("ViewName", OleDbType.VarChar, 50, "ViewName"), New OleDbParameter("FieldName", OleDbType.VarChar, 150, "FieldName"), New OleDbParameter("OrderNbr", OleDbType.Integer, 4, "OrderNbr"), New OleDbParameter("ToGroup", OleDbType.Boolean, 1, "ToGroup"), New OleDbParameter("Original_BrowseViewID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "BrowseViewID", DataRowVersion.Original, Nothing), New OleDbParameter("Original_FieldName", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ViewName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ViewName", DataRowVersion.Original, Nothing), New OleDbParameter("Original_OrderNbr", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing), New OleDbParameter("Original_OrderNbr1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ToGroup", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "ToGroup", DataRowVersion.Original, Nothing), New OleDbParameter("Original_ToGroup1", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "ToGroup", DataRowVersion.Original, Nothing), New OleDbParameter("Select_BrowseViewID", OleDbType.Integer, 4, "BrowseViewID"), New OleDbParameter("Select_FieldName", OleDbType.VarChar, 150, "FieldName"), New OleDbParameter("Select_ViewName", OleDbType.VarChar, 50, "ViewName")})
            Me.colcolumn_header.set_Caption("column_header")
            Me.colcolumn_header.set_FieldName("column_header")
            Me.colcolumn_header.set_Name("colcolumn_header")
            Me.colcolumn_header.set_Visible(True)
            Me.colcolumn_header.set_VisibleIndex(8)
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Size(&H379, &H1CE)
            Me.ClientSize = size
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "frmSystemBrowseView_Maintenance"
            Me.Text = "Browse View Maintenance"
            Me.Controls.SetChildIndex(Me.StatusBar1, 0)
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.PrintSystem1.EndInit()
            Me.MainDataSet.EndInit()
            Me.cmbViewListRepos.EndInit()
            Me.txtQuickSearchRepos.EndInit()
            Me.cmbReportListRepos.EndInit()
            Me.cmbFilterListRepos.EndInit()
            Me.cmbDefaultListRepos.EndInit()
            Me.objDS.EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tabColumns.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Grid1.EndInit()
            Me.GridView1.EndInit()
            Me.chkToShow.EndInit()
            Me.TotalSummaryTypesLookUp.EndInit()
            Me.GroupSummaryTypeLookUp.EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.tabGroupBy.ResumeLayout(False)
            Me.Grid2.EndInit()
            Me.GridView2.EndInit()
            Me.chkToGroup.EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadDataSet()
            Dim set2 As New clsDataSet(Me.SessionInfo)
            Dim dataSet As DataSet = Me.objDS.Clone
            Try
                Dim str As String
                If Me.SessionInfo.CanModifyGlobalViews Then
                    str = String.Concat(New String() {MyBase.SQLTxt1, " WHERE MenuID = ", Conversions.ToString(Me.ForMenuID), " AND ( UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " OR BrowseViewID < 0 ) ORDER BY ", MyBase.KeyFieldName})
                Else
                    str = String.Concat(New String() {MyBase.SQLTxt1, " WHERE MenuID = ", Conversions.ToString(Me.ForMenuID), " AND UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " AND BrowseViewID > 0 ORDER BY ", MyBase.KeyFieldName})
                End If
                set2.FillDataSet(dataSet.Tables.Item(MyBase.TableName), str, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.objDS.Tables.Item(MyBase.TableName).Clear()
                Me.objDS.Merge(dataSet)
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("MenuID").DefaultValue = Me.ForMenuID
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("UserID").DefaultValue = Me.SessionInfo.UserID
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("DefaultView").DefaultValue = 0
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("SystemView").DefaultValue = 0
                Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Sort = "Name"
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Sub LoadDataSetSub(ByVal BrowseViewID As Integer)
            Dim set2 As New clsDataSet(Me.SessionInfo)
            Dim dataSet As DataSet = Me.objDS.Clone
            Try
                Me.OleDbDataAdapter2.SelectCommand.CommandText = String.Concat(New String() {"SELECT * FROM generalbrowseviewcolumn WHERE BrowseViewID = ", Conversions.ToString(BrowseViewID), " AND ViewName = '", Me.ForTable.TableName, "' ORDER BY OrderNbr"})
                set2.FillDataSet(dataSet.Tables.Item(Me.TableNameSub), Me.OleDbDataAdapter2, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.objDS.Tables.Item(Me.TableNameSub).Clear()
                Me.objDS.Merge(dataSet)
                Me.objDS.Tables.Item(Me.TableNameSub).Columns.Item("BrowseViewID").DefaultValue = BrowseViewID
                Me.objDS.Tables.Item(Me.TableNameSub).Columns.Item("ViewName").DefaultValue = Me.ForTable.TableName
                Me.objDS.Tables.Item(Me.TableNameSub).Columns.Item("ColumnWidth").DefaultValue = 0
                Me.objDS.Tables.Item(Me.TableNameSub).Columns.Item("RowIndex").DefaultValue = 0
                Me.objDS.Tables.Item(Me.TableNameSub).DefaultView.Sort = "OrderNbr"
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Sub LoadDataSetSub1(ByVal BrowseViewID As Integer)
            Dim set2 As New clsDataSet(Me.SessionInfo)
            Dim dataSet As DataSet = Me.objDS.Clone
            Try
                Me.OleDbDataAdapter3.SelectCommand.CommandText = String.Concat(New String() {"SELECT * FROM generalbrowseviewgroupby WHERE BrowseViewID = ", Conversions.ToString(BrowseViewID), " AND ViewName = '", Me.ForTable.TableName, "' ORDER BY OrderNbr"})
                set2.FillDataSet(dataSet.Tables.Item(Me.TableNameSub1), Me.OleDbDataAdapter3, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.objDS.Tables.Item(Me.TableNameSub1).Clear()
                Me.objDS.Merge(dataSet)
                Me.objDS.Tables.Item(Me.TableNameSub1).Columns.Item("BrowseViewID").DefaultValue = BrowseViewID
                Me.objDS.Tables.Item(Me.TableNameSub1).Columns.Item("ViewName").DefaultValue = Me.ForTable.TableName
                Me.objDS.Tables.Item(Me.TableNameSub1).DefaultView.Sort = "OrderNbr"
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Sub NewRecord(ByVal Sender As Object, ByVal e As EventArgs)
            Dim num As Integer = 0
            Me.DefaultView = Me.ForGrid.get_Views.get_Item(0)
            Dim count As Integer = Me.DefaultView.get_Columns.Count
            Me.SetState(ObjectState.NewState)
            Me.PopMenuNew.Enabled = False
            Me.PopMenuEdit.Enabled = False
            Me.PopMenuSave.Enabled = True
            Me.PopMenuDelete.Enabled = False
            Me.PopMenuUndo.Enabled = True
            Me.EnablingAll(True)
            MyBase.OpenType = "NEW"
            Try
                Dim current As DataColumn
                Dim row As DataRow
                Dim enumerator As IEnumerator
                Dim enumerator2 As IEnumerator
                Dim enumerator3 As IEnumerator
                Me.objDS.Tables.Item(Me.TableNameSub).Clear()
                Me.BindingContext.Item(Me.objDS, MyBase.TableName).EndCurrentEdit()
                Me.BindingContext.Item(Me.objDS, Me.TableNameSub).EndCurrentEdit()
                Me.BindingContext.Item(Me.objDS, Me.TableNameSub1).EndCurrentEdit()
                Me.BindingContext.Item(Me.objDS, MyBase.TableName).AddNew()
                Try
                    enumerator = Me.ForTable.Columns.GetEnumerator
                    Do While enumerator.MoveNext
                        current = DirectCast(enumerator.Current, DataColumn)
                        If Not Information.IsNothing(Me.DefaultView.get_Bands.get_Item(0).get_Columns.get_Item(current.ColumnName)) Then
                            row = Me.objDS.Tables.Item(Me.TableNameSub).NewRow
                            row.Item("FieldName") = current.ColumnName
                            row.Item("ViewName") = Me.ForTable.TableName
                            row.Item("BrowseViewID") = -1
                            row.Item("TotalSummary") = Me.DefaultView.get_Columns.get_Item(current.ColumnName).get_SummaryItem.get_SummaryType
                            row.Item("ToShow") = True
                            Me.SetDataType(current, (row))
                            row.Item("OrderNbr") = Me.DefaultView.get_Columns.get_Item(current.ColumnName).get_VisibleIndex
                            If Not Information.IsNothing(Me.DefaultView.get_GroupSummary.get_Item(current.ColumnName)) Then
                                row.Item("GroupSummary") = Me.DefaultView.get_GroupSummary.get_Item(current.ColumnName).get_SummaryType
                            End If
                            Me.objDS.Tables.Item(Me.TableNameSub).Rows.Add(row)
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                num = (count + 1)
                Try
                    enumerator2 = Me.ForTable.Columns.GetEnumerator
                    Do While enumerator2.MoveNext
                        current = DirectCast(enumerator2.Current, DataColumn)
                        If Information.IsNothing(Me.DefaultView.get_Bands.get_Item(0).get_Columns.get_Item(current.ColumnName)) Then
                            row = Me.objDS.Tables.Item(Me.TableNameSub).NewRow
                            row.Item("FieldName") = current.ColumnName
                            row.Item("ViewName") = Me.ForTable.TableName
                            row.Item("BrowseViewID") = -1
                            row.Item("ToShow") = False
                            row.Item("TotalSummary") = 5
                            Me.SetDataType(current, (row))
                            row.Item("OrderNbr") = num
                            num += 1
                            Me.objDS.Tables.Item(Me.TableNameSub).Rows.Add(row)
                        End If
                    Loop
                Finally
                    If TypeOf enumerator2 Is IDisposable Then
                        TryCast(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                num = Me.DefaultView.get_GroupedColumns.Count
                Try
                    enumerator3 = Me.ForTable.Columns.GetEnumerator
                    Do While enumerator3.MoveNext
                        current = DirectCast(enumerator3.Current, DataColumn)
                        If Not Information.IsNothing(Me.DefaultView.get_Columns.get_Item(current.ColumnName)) Then
                            row = Me.objDS.Tables.Item(Me.TableNameSub1).NewRow
                            row.Item("FieldName") = current.ColumnName
                            row.Item("ViewName") = Me.ForTable.TableName
                            row.Item("BrowseViewID") = -1
                            If (Me.DefaultView.get_Columns.get_Item(current.ColumnName).get_GroupIndex >= 0) Then
                                row.Item("ToGroup") = True
                                row.Item("OrderNbr") = Me.DefaultView.get_Columns.get_Item(current.ColumnName).get_GroupIndex
                            Else
                                row.Item("ToGroup") = False
                                row.Item("OrderNbr") = num
                                num += 1
                            End If
                            Me.objDS.Tables.Item(Me.TableNameSub1).Rows.Add(row)
                        Else
                            row = Me.objDS.Tables.Item(Me.TableNameSub1).NewRow
                            row.Item("FieldName") = current.ColumnName
                            row.Item("ViewName") = Me.ForTable.TableName
                            row.Item("BrowseViewID") = -1
                            row.Item("ToGroup") = False
                            row.Item("OrderNbr") = num
                            num += 1
                            Me.objDS.Tables.Item(Me.TableNameSub1).Rows.Add(row)
                        End If
                    Loop
                Finally
                    If TypeOf enumerator3 Is IDisposable Then
                        TryCast(enumerator3, IDisposable).Dispose()
                    End If
                End Try
                Me.GridView1.ClearSorting()
                Me.GridView1.get_Columns.get_Item("OrderNbr").set_SortOrder(1)
                Me.GridView2.ClearSorting()
                Me.GridView2.get_Columns.get_Item("OrderNbr").set_SortOrder(1)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError()
            End Try
            Me.PositionChanged(RuntimeHelpers.GetObjectValue(Sender), e)
        End Sub

        Private Sub PositionChanged(ByVal Sender As Object, ByVal e As EventArgs)
            Dim browseViewID As Integer = -1
            If (Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position >= 0) Then
                Me.StatusBar1.Text = ((Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position + 1).ToString & " of  " & Me.BindingContext.Item(Me.objDS, MyBase.TableName).Count.ToString)
                Me.ToolTip1.SetToolTip(Me.StatusBar1, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(((MyBase.TableName & "-->") & MyBase.IDField & "="), DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField)), "")))
                Me.txtQuickSearch.set_EditValue(Me.txtName.Text)
                If (MyBase.OpenType <> "NEW") Then
                    browseViewID = Conversions.ToInteger(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), ""))
                    Me.BrowseViewColumnVerify(browseViewID, Me.ForTable.TableName, Me.ForTable)
                    Me.LoadDataSetSub(browseViewID)
                    Me.BrowseViewGroupByVerify(browseViewID, Me.ForTable.TableName, Me.ForTable)
                    Me.LoadDataSetSub1(browseViewID)
                End If
            End If
        End Sub

        Private Sub SaveChanges(ByVal Sender As Object, ByVal e As EventArgs)
            If Me.ValidateBeforeSave Then
                Dim num As Integer
                If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), ""), "", False) Then
                    Dim current As DataRowView
                    Dim enumerator As IEnumerator
                    Dim enumerator2 As IEnumerator
                    num = Conversions.ToInteger(MyBase.BKGlobal.GetNextID(MyBase.IDField))
                    DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField) = num
                    Try
                        enumerator = Me.objDS.Tables.Item(Me.TableNameSub).DefaultView.GetEnumerator
                        Do While enumerator.MoveNext
                            current = DirectCast(enumerator.Current, DataRowView)
                            current.Item(MyBase.IDField) = num
                        Loop
                    Finally
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                    Try
                        enumerator2 = Me.objDS.Tables.Item(Me.TableNameSub1).DefaultView.GetEnumerator
                        Do While enumerator2.MoveNext
                            current = DirectCast(enumerator2.Current, DataRowView)
                            current.Item(MyBase.IDField) = num
                        Loop
                    Finally
                        If TypeOf enumerator2 Is IDisposable Then
                            TryCast(enumerator2, IDisposable).Dispose()
                        End If
                    End Try
                Else
                    num = Conversions.ToInteger(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), ""))
                End If
                Try
                    Me.UpdateDataSet()
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    MessageBox.Show(exception.Message)
                    ProjectData.ClearProjectError()
                End Try
                If Me.chkDefault.Checked Then
                    MyBase.BKBrowseView.BrowseViewAssignDefault(num, Me.ForMenuID)
                End If
                Me.PositionChanged(RuntimeHelpers.GetObjectValue(Sender), e)
                Me.SetState(ObjectState.BrowseState)
                Me.PopMenuNew.Enabled = True
                Me.PopMenuEdit.Enabled = True
                Me.PopMenuSave.Enabled = False
                Me.PopMenuDelete.Enabled = True
                Me.PopMenuUndo.Enabled = False
                Me.EnablingAll(False)
                MyBase.OpenType = "BROWSE"
            End If
        End Sub

        Private Sub SetDataType(ByVal _col As DataColumn, ByRef _Row As DataRow)
            If ((_col.DataType.ToString = "System.Decimal") Or (_col.DataType.ToString = "System.Double")) Then
                _Row.Item("DataType") = "Numeric"
            ElseIf (_col.DataType.ToString = "System.DateTime") Then
                _Row.Item("DataType") = "Date"
            Else
                _Row.Item("DataType") = "String"
            End If
        End Sub

        Private Sub StartPrintForm()
            MyBase.BKReport.PrintForm(MyBase.CurrentReportID, New DataRow() {DirectCast(Me.BindingContext.Item(Me.MainDataSet, MyBase.TableName).Current, DataRowView).Row}, Nothing)
        End Sub

        Private Sub UndoChanges(ByVal Sender As Object, ByVal e As EventArgs)
            Me.SetState(ObjectState.BrowseState)
            Me.PopMenuNew.Enabled = True
            Me.PopMenuEdit.Enabled = True
            Me.PopMenuSave.Enabled = False
            Me.PopMenuDelete.Enabled = True
            Me.PopMenuUndo.Enabled = False
            Me.EnablingAll(False)
            Me.BindingContext.Item(Me.objDS, MyBase.TableName).CancelCurrentEdit()
            Me.BindingContext.Item(Me.objDS, Me.TableNameSub).CancelCurrentEdit()
            Me.PositionChanged(RuntimeHelpers.GetObjectValue(Sender), e)
            MyBase.OpenType = "BROWSE"
        End Sub

        Public Sub UpdateDataSet()
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim changes As New dsBrowseView
            Me.GridView1.CloseEditor()
            Me.GridView1.UpdateCurrentRow()
            Me.GridView2.CloseEditor()
            Me.GridView2.UpdateCurrentRow()
            Me.BindingContext.Item(Me.objDS, MyBase.TableName).EndCurrentEdit()
            Me.BindingContext.Item(Me.objDS, Me.TableNameSub).EndCurrentEdit()
            Me.BindingContext.Item(Me.objDS, Me.TableNameSub1).EndCurrentEdit()
            changes = DirectCast(Me.objDS.GetChanges, dsBrowseView)
            If (Not changes Is Nothing) Then
                Try
                    ClsDs.UpdateDataSource(changes.Tables.Item(MyBase.TableName), Me.OleDbDataAdapter1, True)
                    ClsDs.UpdateDataSource(changes.Tables.Item(Me.TableNameSub), Me.OleDbDataAdapter2, True)
                    ClsDs.UpdateDataSource(changes.Tables.Item(Me.TableNameSub1), Me.OleDbDataAdapter3, True)
                    Me.objDS.AcceptChanges()
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Throw exception
                    ProjectData.ClearProjectError()
                End Try
            End If
        End Sub

        Private Function ValidateBeforeDelete() As Boolean
            If (Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position < 0) Then
                Return False
            End If
            If Operators.ConditionalCompareObjectEqual(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item("SystemView"), 1, False) Then
                Interaction.MsgBox(MyBase.BKGlobal.GetMsg(&H29, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                Return False
            End If
            If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), 0, False), Not Me.SessionInfo.CanModifyGlobalViews)) Then
                Interaction.MsgBox(MyBase.BKGlobal.GetMsg(40, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                Return False
            End If
            Return True
        End Function

        Private Function ValidateBeforeSave() As Boolean
            If ((Me.txtName.Text & "") = "") Then
                Interaction.MsgBox(MyBase.BKGlobal.GetMsg(5, Me.SessionInfo.UserLang, True), MsgBoxStyle.Critical, Nothing)
                Return False
            End If
            Return True
        End Function


        ' Properties
        Friend Overridable Property btnDown As SimpleButton
            Get
                Return Me._btnDown
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnDown Is Nothing) Then
                    RemoveHandler Me._btnDown.Click, New EventHandler(AddressOf Me.btnDown_Click)
                End If
                Me._btnDown = WithEventsValue
                If (Not Me._btnDown Is Nothing) Then
                    AddHandler Me._btnDown.Click, New EventHandler(AddressOf Me.btnDown_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnDown1 As SimpleButton
            Get
                Return Me._btnDown1
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnDown1 Is Nothing) Then
                    RemoveHandler Me._btnDown1.Click, New EventHandler(AddressOf Me.btnDown1_Click)
                End If
                Me._btnDown1 = WithEventsValue
                If (Not Me._btnDown1 Is Nothing) Then
                    AddHandler Me._btnDown1.Click, New EventHandler(AddressOf Me.btnDown1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnUP As SimpleButton
            Get
                Return Me._btnUP
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnUP Is Nothing) Then
                    RemoveHandler Me._btnUP.Click, New EventHandler(AddressOf Me.btnUP_Click)
                End If
                Me._btnUP = WithEventsValue
                If (Not Me._btnUP Is Nothing) Then
                    AddHandler Me._btnUP.Click, New EventHandler(AddressOf Me.btnUP_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnUp1 As SimpleButton
            Get
                Return Me._btnUp1
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnUp1 Is Nothing) Then
                    RemoveHandler Me._btnUp1.Click, New EventHandler(AddressOf Me.btnUp1_Click)
                End If
                Me._btnUp1 = WithEventsValue
                If (Not Me._btnUp1 Is Nothing) Then
                    AddHandler Me._btnUp1.Click, New EventHandler(AddressOf Me.btnUp1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property chkDefault As CheckBox
            Get
                Return Me._chkDefault
            End Get
            Set(ByVal WithEventsValue As CheckBox)
                Me._chkDefault = WithEventsValue
            End Set
        End Property

        Friend Overridable Property chkToGroup As RepositoryItemCheckEdit
            Get
                Return Me._chkToGroup
            End Get
            Set(ByVal WithEventsValue As RepositoryItemCheckEdit)
                Me._chkToGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property chkToShow As RepositoryItemCheckEdit
            Get
                Return Me._chkToShow
            End Get
            Set(ByVal WithEventsValue As RepositoryItemCheckEdit)
                Me._chkToShow = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colcolumn_header As GridColumn
            Get
                Return Me._colcolumn_header
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colcolumn_header = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colColumnWidth As GridColumn
            Get
                Return Me._colColumnWidth
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colColumnWidth = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colDataType As GridColumn
            Get
                Return Me._colDataType
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colDataType = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colFieldName As GridColumn
            Get
                Return Me._colFieldName
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colFieldName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colFieldName1 As GridColumn
            Get
                Return Me._colFieldName1
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colFieldName1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colGroupSummary As GridColumn
            Get
                Return Me._colGroupSummary
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colGroupSummary = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colOrderNbr As GridColumn
            Get
                Return Me._colOrderNbr
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colOrderNbr = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colOrderNbr1 As GridColumn
            Get
                Return Me._colOrderNbr1
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colOrderNbr1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colRowIndex As GridColumn
            Get
                Return Me._colRowIndex
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colRowIndex = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colToGroup As GridColumn
            Get
                Return Me._colToGroup
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colToGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colToShow As GridColumn
            Get
                Return Me._colToShow
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colToShow = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colTotalSummary As GridColumn
            Get
                Return Me._colTotalSummary
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colTotalSummary = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Grid1 As GridControl
            Get
                Return Me._Grid1
            End Get
            Set(ByVal WithEventsValue As GridControl)
                Me._Grid1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Grid2 As GridControl
            Get
                Return Me._Grid2
            End Get
            Set(ByVal WithEventsValue As GridControl)
                Me._Grid2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GridView1 As GridView
            Get
                Return Me._GridView1
            End Get
            Set(ByVal WithEventsValue As GridView)
                Me._GridView1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GridView2 As GridView
            Get
                Return Me._GridView2
            End Get
            Set(ByVal WithEventsValue As GridView)
                Me._GridView2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GroupSummaryTypeLookUp As RepositoryItemLookUpEdit
            Get
                Return Me._GroupSummaryTypeLookUp
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                Me._GroupSummaryTypeLookUp = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblDescription As Label
            Get
                Return Me._lblDescription
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblDescription = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblName As Label
            Get
                Return Me._lblName
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property objDS As dsBrowseView
            Get
                Return Me._objDS
            End Get
            Set(ByVal WithEventsValue As dsBrowseView)
                Me._objDS = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbDataAdapter1 As OleDbDataAdapter
            Get
                Return Me._OleDbDataAdapter1
            End Get
            Set(ByVal WithEventsValue As OleDbDataAdapter)
                Me._OleDbDataAdapter1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbDataAdapter2 As OleDbDataAdapter
            Get
                Return Me._OleDbDataAdapter2
            End Get
            Set(ByVal WithEventsValue As OleDbDataAdapter)
                Me._OleDbDataAdapter2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbDataAdapter3 As OleDbDataAdapter
            Get
                Return Me._OleDbDataAdapter3
            End Get
            Set(ByVal WithEventsValue As OleDbDataAdapter)
                Me._OleDbDataAdapter3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbDeleteCommand1 As OleDbCommand
            Get
                Return Me._OleDbDeleteCommand1
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbDeleteCommand1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbDeleteCommand2 As OleDbCommand
            Get
                Return Me._OleDbDeleteCommand2
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbDeleteCommand2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbDeleteCommand3 As OleDbCommand
            Get
                Return Me._OleDbDeleteCommand3
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbDeleteCommand3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbInsertCommand1 As OleDbCommand
            Get
                Return Me._OleDbInsertCommand1
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbInsertCommand1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbInsertCommand2 As OleDbCommand
            Get
                Return Me._OleDbInsertCommand2
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbInsertCommand2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbInsertCommand3 As OleDbCommand
            Get
                Return Me._OleDbInsertCommand3
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbInsertCommand3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbSelectCommand1 As OleDbCommand
            Get
                Return Me._OleDbSelectCommand1
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbSelectCommand1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbSelectCommand2 As OleDbCommand
            Get
                Return Me._OleDbSelectCommand2
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbSelectCommand2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbSelectCommand3 As OleDbCommand
            Get
                Return Me._OleDbSelectCommand3
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbSelectCommand3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbUpdateCommand1 As OleDbCommand
            Get
                Return Me._OleDbUpdateCommand1
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbUpdateCommand1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbUpdateCommand2 As OleDbCommand
            Get
                Return Me._OleDbUpdateCommand2
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbUpdateCommand2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OleDbUpdateCommand3 As OleDbCommand
            Get
                Return Me._OleDbUpdateCommand3
            End Get
            Set(ByVal WithEventsValue As OleDbCommand)
                Me._OleDbUpdateCommand3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Panel1 As Panel
            Get
                Return Me._Panel1
            End Get
            Set(ByVal WithEventsValue As Panel)
                Me._Panel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Panel2 As Panel
            Get
                Return Me._Panel2
            End Get
            Set(ByVal WithEventsValue As Panel)
                Me._Panel2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Panel3 As Panel
            Get
                Return Me._Panel3
            End Get
            Set(ByVal WithEventsValue As Panel)
                Me._Panel3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Panel4 As Panel
            Get
                Return Me._Panel4
            End Get
            Set(ByVal WithEventsValue As Panel)
                Me._Panel4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Panel5 As Panel
            Get
                Return Me._Panel5
            End Get
            Set(ByVal WithEventsValue As Panel)
                Me._Panel5 = WithEventsValue
            End Set
        End Property

        Public Overrides Property PopMenuDelete As MenuItem
            Get
                Return MyBase.PopMenuDelete
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not MyBase.PopMenuDelete Is Nothing) Then
                    RemoveHandler MyBase.PopMenuDelete.Click, New EventHandler(AddressOf Me.DeleteRecord)
                End If
                MyBase.PopMenuDelete = WithEventsValue
                If (Not MyBase.PopMenuDelete Is Nothing) Then
                    AddHandler MyBase.PopMenuDelete.Click, New EventHandler(AddressOf Me.DeleteRecord)
                End If
            End Set
        End Property

        Public Overrides Property PopMenuEdit As MenuItem
            Get
                Return MyBase.PopMenuEdit
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not MyBase.PopMenuEdit Is Nothing) Then
                    RemoveHandler MyBase.PopMenuEdit.Click, New EventHandler(AddressOf Me.EditRecord)
                End If
                MyBase.PopMenuEdit = WithEventsValue
                If (Not MyBase.PopMenuEdit Is Nothing) Then
                    AddHandler MyBase.PopMenuEdit.Click, New EventHandler(AddressOf Me.EditRecord)
                End If
            End Set
        End Property

        Public Overrides Property PopMenuNew As MenuItem
            Get
                Return MyBase.PopMenuNew
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not MyBase.PopMenuNew Is Nothing) Then
                    RemoveHandler MyBase.PopMenuNew.Click, New EventHandler(AddressOf Me.NewRecord)
                End If
                MyBase.PopMenuNew = WithEventsValue
                If (Not MyBase.PopMenuNew Is Nothing) Then
                    AddHandler MyBase.PopMenuNew.Click, New EventHandler(AddressOf Me.NewRecord)
                End If
            End Set
        End Property

        Public Overrides Property PopMenuSave As MenuItem
            Get
                Return MyBase.PopMenuSave
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not MyBase.PopMenuSave Is Nothing) Then
                    RemoveHandler MyBase.PopMenuSave.Click, New EventHandler(AddressOf Me.SaveChanges)
                End If
                MyBase.PopMenuSave = WithEventsValue
                If (Not MyBase.PopMenuSave Is Nothing) Then
                    AddHandler MyBase.PopMenuSave.Click, New EventHandler(AddressOf Me.SaveChanges)
                End If
            End Set
        End Property

        Public Overrides Property PopMenuUndo As MenuItem
            Get
                Return MyBase.PopMenuUndo
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not MyBase.PopMenuUndo Is Nothing) Then
                    RemoveHandler MyBase.PopMenuUndo.Click, New EventHandler(AddressOf Me.UndoChanges)
                End If
                MyBase.PopMenuUndo = WithEventsValue
                If (Not MyBase.PopMenuUndo Is Nothing) Then
                    AddHandler MyBase.PopMenuUndo.Click, New EventHandler(AddressOf Me.UndoChanges)
                End If
            End Set
        End Property

        Friend Overridable Property tabColumns As TabPage
            Get
                Return Me._tabColumns
            End Get
            Set(ByVal WithEventsValue As TabPage)
                Me._tabColumns = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TabControl1 As TabControl
            Get
                Return Me._TabControl1
            End Get
            Set(ByVal WithEventsValue As TabControl)
                Me._TabControl1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tabGroupBy As TabPage
            Get
                Return Me._tabGroupBy
            End Get
            Set(ByVal WithEventsValue As TabPage)
                Me._tabGroupBy = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TotalSummaryTypesLookUp As RepositoryItemLookUpEdit
            Get
                Return Me._TotalSummaryTypesLookUp
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                Me._TotalSummaryTypesLookUp = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtDescription As TextBox
            Get
                Return Me._txtDescription
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtDescription = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtName As TextBox
            Get
                Return Me._txtName
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtName = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("btnDown")> _
        Private _btnDown As SimpleButton
        <AccessedThroughProperty("btnDown1")> _
        Private _btnDown1 As SimpleButton
        <AccessedThroughProperty("btnUP")> _
        Private _btnUP As SimpleButton
        <AccessedThroughProperty("btnUp1")> _
        Private _btnUp1 As SimpleButton
        <AccessedThroughProperty("chkDefault")> _
        Private _chkDefault As CheckBox
        <AccessedThroughProperty("chkToGroup")> _
        Private _chkToGroup As RepositoryItemCheckEdit
        <AccessedThroughProperty("chkToShow")> _
        Private _chkToShow As RepositoryItemCheckEdit
        <AccessedThroughProperty("colcolumn_header")> _
        Private _colcolumn_header As GridColumn
        <AccessedThroughProperty("colColumnWidth")> _
        Private _colColumnWidth As GridColumn
        <AccessedThroughProperty("colDataType")> _
        Private _colDataType As GridColumn
        <AccessedThroughProperty("colFieldName")> _
        Private _colFieldName As GridColumn
        <AccessedThroughProperty("colFieldName1")> _
        Private _colFieldName1 As GridColumn
        <AccessedThroughProperty("colGroupSummary")> _
        Private _colGroupSummary As GridColumn
        <AccessedThroughProperty("colOrderNbr")> _
        Private _colOrderNbr As GridColumn
        <AccessedThroughProperty("colOrderNbr1")> _
        Private _colOrderNbr1 As GridColumn
        <AccessedThroughProperty("colRowIndex")> _
        Private _colRowIndex As GridColumn
        <AccessedThroughProperty("colToGroup")> _
        Private _colToGroup As GridColumn
        <AccessedThroughProperty("colToShow")> _
        Private _colToShow As GridColumn
        <AccessedThroughProperty("colTotalSummary")> _
        Private _colTotalSummary As GridColumn
        <AccessedThroughProperty("Grid1")> _
        Private _Grid1 As GridControl
        <AccessedThroughProperty("Grid2")> _
        Private _Grid2 As GridControl
        <AccessedThroughProperty("GridView1")> _
        Private _GridView1 As GridView
        <AccessedThroughProperty("GridView2")> _
        Private _GridView2 As GridView
        <AccessedThroughProperty("GroupSummaryTypeLookUp")> _
        Private _GroupSummaryTypeLookUp As RepositoryItemLookUpEdit
        <AccessedThroughProperty("lblDescription")> _
        Private _lblDescription As Label
        <AccessedThroughProperty("lblName")> _
        Private _lblName As Label
        <AccessedThroughProperty("objDS")> _
        Private _objDS As dsBrowseView
        <AccessedThroughProperty("OleDbDataAdapter1")> _
        Private _OleDbDataAdapter1 As OleDbDataAdapter
        <AccessedThroughProperty("OleDbDataAdapter2")> _
        Private _OleDbDataAdapter2 As OleDbDataAdapter
        <AccessedThroughProperty("OleDbDataAdapter3")> _
        Private _OleDbDataAdapter3 As OleDbDataAdapter
        <AccessedThroughProperty("OleDbDeleteCommand1")> _
        Private _OleDbDeleteCommand1 As OleDbCommand
        <AccessedThroughProperty("OleDbDeleteCommand2")> _
        Private _OleDbDeleteCommand2 As OleDbCommand
        <AccessedThroughProperty("OleDbDeleteCommand3")> _
        Private _OleDbDeleteCommand3 As OleDbCommand
        <AccessedThroughProperty("OleDbInsertCommand1")> _
        Private _OleDbInsertCommand1 As OleDbCommand
        <AccessedThroughProperty("OleDbInsertCommand2")> _
        Private _OleDbInsertCommand2 As OleDbCommand
        <AccessedThroughProperty("OleDbInsertCommand3")> _
        Private _OleDbInsertCommand3 As OleDbCommand
        <AccessedThroughProperty("OleDbSelectCommand1")> _
        Private _OleDbSelectCommand1 As OleDbCommand
        <AccessedThroughProperty("OleDbSelectCommand2")> _
        Private _OleDbSelectCommand2 As OleDbCommand
        <AccessedThroughProperty("OleDbSelectCommand3")> _
        Private _OleDbSelectCommand3 As OleDbCommand
        <AccessedThroughProperty("OleDbUpdateCommand1")> _
        Private _OleDbUpdateCommand1 As OleDbCommand
        <AccessedThroughProperty("OleDbUpdateCommand2")> _
        Private _OleDbUpdateCommand2 As OleDbCommand
        <AccessedThroughProperty("OleDbUpdateCommand3")> _
        Private _OleDbUpdateCommand3 As OleDbCommand
        <AccessedThroughProperty("Panel1")> _
        Private _Panel1 As Panel
        <AccessedThroughProperty("Panel2")> _
        Private _Panel2 As Panel
        <AccessedThroughProperty("Panel3")> _
        Private _Panel3 As Panel
        <AccessedThroughProperty("Panel4")> _
        Private _Panel4 As Panel
        <AccessedThroughProperty("Panel5")> _
        Private _Panel5 As Panel
        <AccessedThroughProperty("tabColumns")> _
        Private _tabColumns As TabPage
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl
        <AccessedThroughProperty("tabGroupBy")> _
        Private _tabGroupBy As TabPage
        <AccessedThroughProperty("TotalSummaryTypesLookUp")> _
        Private _TotalSummaryTypesLookUp As RepositoryItemLookUpEdit
        <AccessedThroughProperty("txtDescription")> _
        Private _txtDescription As TextBox
        <AccessedThroughProperty("txtName")> _
        Private _txtName As TextBox
        Private components As IContainer
        Private DefaultView As AdvBandedGridView
        Public ForGrid As GridControl
        Public ForMenuID As Integer
        Public ForTable As DataTable
        Private KeyDataSet As String
        Private TableNameSub As String
        Private TableNameSub1 As String
        Public ViewName As String
    End Class
End Namespace

