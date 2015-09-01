Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class clsDefaultSet
        ' Methods
        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.mvarBKGlobal = New clsGlobal(CurrentSessionInfo)
        End Sub

        Public Function CopyDefaultSet(ByVal DefaultSetID As Integer) As Integer
            Dim enumerator As IEnumerator
            Dim set2 As New dsDefaultSet
            Dim set3 As New dsDefaultSet
            Dim set As New clsDataSet(Me.SessionInfo)
            If (DefaultSetID = 0) Then
                Return 0
            End If
            Dim sQLTxt As String = ("SELECT * FROM generaldefaultset WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID))
            ClsDs.FillDataSet(set2.Tables.Item("generaldefaultset"), sQLTxt, True, False)
            If (set2.Tables.Item("generaldefaultset").Rows.Count = 0) Then
                Return 0
            End If
            Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("DefaultSetID"))
            Dim row As DataRow = set3.Tables.Item("generaldefaultset").NewRow
            row.ItemArray = set2.Tables.Item("generaldefaultset").Rows.Item(0).ItemArray
            row.Item("DefaultSetID") = num
            row.Item("DefaultCriteria") = 0
            row.Item("SystemCriteria") = 0
            row.Item("UserID") = Me.SessionInfo.UserID
            row.Item("Name") = Operators.ConcatenateObject("Copy of ", set2.Tables.Item("generaldefaultset").Rows.Item(0).Item("Name"))
            set3.Tables.Item("generaldefaultset").Rows.Add(row)
            ClsDs.UpdateDataSource(set3.Tables.Item("generaldefaultset"), sQLTxt, True)
            Dim str2 As String = ("SELECT * FROM generaldefaultsetsub WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID))
            ClsDs.FillDataSet(set2.Tables.Item("generaldefaultsetsub"), str2, True, False)
            Try
                enumerator = set2.Tables.Item("generaldefaultsetsub").Rows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                    row = set3.Tables.Item("generaldefaultsetsub").NewRow
                    row.ItemArray = current.ItemArray
                    row.Item("DefaultSetID") = num
                    set3.Tables.Item("generaldefaultsetsub").Rows.Add(row)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(set3.Tables.Item("generaldefaultsetsub"), str2, True)
            Return num
        End Function

        Public Sub DefaultSetAssignDefault(ByVal DefaultSetID As Integer, ByVal MenuID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            Me.DefaultSetClearDefault(MenuID)
            Dim sQLtxt As String = ("UPDATE generaldefaultset SET DefaultCriteria = 1 WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID))
            Try
                Dim num As Integer = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Sub DefaultSetClearDefault(ByVal MenuID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLtxt As String = ("UPDATE generaldefaultset SET DefaultCriteria = 0 WHERE MenuID = " & Conversions.ToString(MenuID) & " AND UserID = " & Conversions.ToString(Me.SessionInfo.UserID))
            Try
                Dim num As Integer = ClsDs.ExecuteNonQuery(sQLtxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Sub DeleteDefaultSet(ByVal DefaultSetID As Integer)
            Dim num As Integer = -1
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim set2 As New dsDefaultSet
            If (DefaultSetID <> 0) Then
                If (Not Me.SessionInfo.CanModifyGlobalViews And (DefaultSetID < 0)) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(&H47, "", True), MsgBoxStyle.Critical, Nothing)
                Else
                    Dim sQLTxt As String = ("SELECT * FROM generaldefaultset WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID))
                    ClsDs.FillDataSet(set2.Tables.Item("generaldefaultset"), sQLTxt, True, False)
                    If (set2.Tables.Item("generaldefaultset").Rows.Count <> 0) Then
                        Dim row As DataRow = set2.Tables.Item("generaldefaultset").Rows.Item(0)
                        If Operators.ConditionalCompareObjectEqual(row.Item("SystemCriteria"), 1, False) Then
                            Interaction.MsgBox(Me.BKGlobal.GetMsg(&H48, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                        ElseIf (Interaction.MsgBox(Me.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes) Then
                            Try
                                ClsDs.ExecuteNonQuery(("DELETE FROM generaldefaultsetsub WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID)), True)
                                num = ClsDs.ExecuteNonQuery(("DELETE FROM generaldefaultset WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID)), True)
                            Catch exception1 As Exception
                                ProjectData.SetProjectError(exception1)
                                Dim exception As Exception = exception1
                                Throw exception
                                ProjectData.ClearProjectError()
                            End Try
                        End If
                    End If
                End If
            End If
        End Sub

        Public Function EditDefaultSetInfo(ByVal DefaultSetID As Integer, ByVal OwnerForm As Form) As Integer
            Dim num As Integer
            Dim set2 As New dsDefaultSet
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim maintenance As New frmSystemDefaultSet_Maintenance(Me.SessionInfo)
            If (DefaultSetID = 0) Then
                Return num
            End If
            If (Not Me.SessionInfo.CanModifyGlobalViews And (DefaultSetID < 0)) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H3F, "", True), MsgBoxStyle.Critical, Nothing)
                Return num
            End If
            Dim sQLTxt As String = ("SELECT * FROM generaldefaultset WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID))
            ClsDs.FillDataSet(set2.Tables.Item("generaldefaultset"), sQLTxt, True, False)
            If (set2.Tables.Item("generaldefaultset").Rows.Count = 0) Then
                Return num
            End If
            If Operators.ConditionalCompareObjectEqual(set2.Tables.Item("generaldefaultset").Rows.Item(0).Item("SystemCriteria"), 1, False) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H31, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                Return num
            End If
            maintenance.KeyValue = Conversions.ToString(DefaultSetID)
            maintenance.OpenType = "EDIT"
            maintenance.ForMenuID = Conversions.ToInteger(set2.Tables.Item("generaldefaultset").Rows.Item(0).Item("MenuID"))
            maintenance.ShowDialog(OwnerForm)
            Return DefaultSetID
        End Function

        Public Function LoadDefaultSet(ByVal DefaultSetID As Integer, ByVal CallingForm As Form) As Integer
            Dim enumerator As IEnumerator
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim set2 As New dsDefaultSet
            Dim sQLTxt As String = ("SELECT * FROM generaldefaultsetsub WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID))
            If (DefaultSetID = 0) Then
                Dim num As Integer
                Return num
            End If
            ClsDs.FillDataSet(set2.Tables.Item("generaldefaultsetsub"), sQLTxt, True, False)
            Try
                enumerator = CallingForm.Controls.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As Control = DirectCast(enumerator.Current, Control)
                    Me.LoadValues(current, set2.Tables.Item("generaldefaultsetsub"))
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Return DefaultSetID
        End Function

        Public Sub LoadToolBarDefaultSetList1(ByVal BarManager1 As BarManager, ByVal MenuID As Integer, Optional ByVal SelectDefault As Boolean = False)
            Dim set2 As New dsDefaultSet
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generaldefaultset WHERE MenuID = ", Conversions.ToString(MenuID), " AND (UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " OR DefaultSetID < 0 ) "})
            ClsDs.FillDataSet(set2.Tables.Item("generaldefaultset"), sQLTxt, True, False)
            Dim edit As RepositoryItemLookUpEdit = BarManager1.get_RepositoryItems.get_Item("cmbDefaultListRepos")
            edit.set_DataSource(set2.Tables.Item("generaldefaultset"))
            edit.set_DisplayMember("Name")
            edit.set_ValueMember("DefaultSetID")
            edit.get_Columns.Clear()
            edit.get_Columns.Add(New LookUpColumnInfo("Name", &H4B))
            edit.get_Columns.Add(New LookUpColumnInfo("Description", 150))
            Dim num As Integer = 0
            If SelectDefault Then
                Dim enumerator As IEnumerator
                Try
                    enumerator = set2.Tables.Item("generaldefaultset").Rows.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                        If Conversions.ToBoolean(current.Item("DefaultCriteria")) Then
                            If (num = 0) Then
                                num = Conversions.ToInteger(current.Item("DefaultSetID"))
                            ElseIf Not Operators.ConditionalCompareObjectLess(current.Item("DefaultSetID"), 0, False) Then
                                num = Conversions.ToInteger(current.Item("DefaultSetID"))
                            End If
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            DirectCast(BarManager1.get_Items.get_Item("cmbDefaultList"), BarEditItem).set_EditValue(num)
        End Sub

        Public Sub LoadValues(ByVal Ctrl As Control, ByVal CriteriaSubTable As DataTable)
            Dim enumerator As IEnumerator
            Dim view As New DataView(CriteriaSubTable, ("ControlName = '" & Ctrl.Name & "'"), "", DataViewRowState.CurrentRows)
            If (view.Count = 1) Then
                Dim type As Type = Ctrl.GetType
                If Not Information.IsNothing(type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty")))) Then
                    Select Case view.Item(0).Item("ValueType").ToString
                        Case "String"
                            type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).SetValue(Ctrl, RuntimeHelpers.GetObjectValue(view.Item(0).Item("StringValue")), Nothing)
                            GoTo Label_0225
                        Case "Boolean"
                            type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).SetValue(Ctrl, RuntimeHelpers.GetObjectValue(view.Item(0).Item("BoolValue")), Nothing)
                            GoTo Label_0225
                        Case "Date"
                            type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).SetValue(Ctrl, RuntimeHelpers.GetObjectValue(view.Item(0).Item("DateValue")), Nothing)
                            GoTo Label_0225
                        Case "Integer"
                            type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).SetValue(Ctrl, RuntimeHelpers.GetObjectValue(view.Item(0).Item("IntValue")), Nothing)
                            Exit Select
                        Case "Double"
                            type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).SetValue(Ctrl, RuntimeHelpers.GetObjectValue(view.Item(0).Item("DblValue")), Nothing)
                            Exit Select
                    End Select
                End If
            End If
Label_0225:
            Try
                enumerator = Ctrl.Controls.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As Control = DirectCast(enumerator.Current, Control)
                    Me.LoadValues(current, CriteriaSubTable)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Public Sub MakeDefaultSetCommon(ByVal DefaultSetID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            If (Interaction.MsgBox(Me.BKGlobal.GetMsg(&H26, Me.SessionInfo.UserLang, True), MsgBoxStyle.OkCancel, Nothing) <> MsgBoxResult.Cancel) Then
                Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("NEGDefaultSetID"))
                Dim sQLtxt As String = String.Concat(New String() {"UPDATE generaldefaultset SET DefaultSetID = ", Conversions.ToString(num), ", UserID = 0  WHERE DefaultSetID = ", Conversions.ToString(DefaultSetID), " "})
                ClsDs.ExecuteNonQuery(sQLtxt, True)
            End If
        End Sub

        Public Function NewDefaultSet(ByVal MenuID As Integer, ByVal OwnerForm As Form) As Integer
            Dim set2 As New dsDefaultSet
            Dim set3 As New dsDefaultSet
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim maintenance As New frmSystemDefaultSet_Maintenance(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generaldefaultset WHERE UserID = 0 and MenuID = " & Conversions.ToString(MenuID) & " AND TemplateCriteria = 1")
            ClsDs.FillDataSet(set2.Tables.Item("generaldefaultset"), sQLTxt, True, False)
            If (set2.Tables.Item("generaldefaultset").Rows.Count = 0) Then
                Return 0
            End If
            Dim num2 As Integer = Conversions.ToInteger(set2.Tables.Item("generaldefaultset").Rows.Item(0).Item("DefaultSetID"))
            Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("DefaultSetID"))
            sQLTxt = ("SELECT * FROM generaldefaultset WHERE DefaultSetID = " & Conversions.ToString(num))
            ClsDs.FillDataSet(set3.Tables.Item("generaldefaultset"), sQLTxt, True, False)
            Dim current As DataRow = set3.Tables.Item("generaldefaultset").NewRow
            current.ItemArray = set2.Tables.Item("generaldefaultset").Rows.Item(0).ItemArray
            current.Item("DefaultSetID") = num
            current.Item("UserID") = Me.SessionInfo.UserID
            current.Item("MenuID") = MenuID
            current.Item("Name") = num
            current.Item("Description") = num
            current.Item("TemplateCriteria") = 0
            set3.Tables.Item("generaldefaultset").Rows.Add(current)
            ClsDs.UpdateDataSource(set3.Tables.Item("generaldefaultset"), sQLTxt, True)
            Dim str2 As String = ("SELECT * FROM generaldefaultsetsub WHERE DefaultSetID = " & Conversions.ToString(num2))
            ClsDs.FillDataSet(set2.Tables.Item("generaldefaultsetsub"), str2, True, False)
            If (set2.Tables.Item("generaldefaultsetsub").Rows.Count <> 0) Then
                Dim enumerator As IEnumerator
                Dim enumerator2 As IEnumerator
                str2 = ("SELECT * FROM generaldefaultsetsub WHERE DefaultSetID = " & Conversions.ToString(num))
                ClsDs.FillDataSet(set3.Tables.Item("generaldefaultsetsub"), str2, True, False)
                Try
                    enumerator = set2.Tables.Item("generaldefaultsetsub").Rows.GetEnumerator
                    Do While enumerator.MoveNext
                        current = DirectCast(enumerator.Current, DataRow)
                        Dim row As DataRow = set3.Tables.Item("generaldefaultsetsub").NewRow
                        row.ItemArray = current.ItemArray
                        row.Item("DefaultSetID") = num
                        set3.Tables.Item("generaldefaultsetsub").Rows.Add(row)
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                ClsDs.UpdateDataSource(set3.Tables.Item("generaldefaultsetsub"), str2, True)
                Try
                    enumerator2 = OwnerForm.Controls.GetEnumerator
                    Do While enumerator2.MoveNext
                        Dim ctrl As Control = DirectCast(enumerator2.Current, Control)
                        Me.SaveValues(ctrl, set3.Tables.Item("generaldefaultsetsub"))
                    Loop
                Finally
                    If TypeOf enumerator2 Is IDisposable Then
                        TryCast(enumerator2, IDisposable).Dispose()
                    End If
                End Try
                ClsDs.UpdateDataSource(set3.Tables.Item("generaldefaultsetsub"), str2, True)
                Me.EditDefaultSetInfo(num, OwnerForm)
            End If
            Return num
        End Function

        Public Function SaveDefaultSet(ByVal DefaultSetID As Integer, ByVal MenuID As Integer, ByVal Frm As Form) As Integer
            Dim num As Integer
            Dim set2 As New dsDefaultSet
            Dim set As New clsDataSet(Me.SessionInfo)
            If (DefaultSetID = 0) Then
                Return num
            End If
            If (Not ((DefaultSetID < 0) And Not Me.SessionInfo.CanModifyGlobalViews) OrElse (Interaction.MsgBox(Me.BKGlobal.GetMsg(&H45, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) <> MsgBoxResult.No)) Then
                Dim enumerator As IEnumerator
                Dim sQLTxt As String = ("SELECT * FROM generaldefaultset WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID))
                ClsDs.FillDataSet(set2.Tables.Item("generaldefaultset"), sQLTxt, True, False)
                Dim str2 As String = ("SELECT * FROM generaldefaultsetsub WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID))
                ClsDs.FillDataSet(set2.Tables.Item("generaldefaultsetsub"), str2, True, False)
                If (set2.Tables.Item("generaldefaultset").Rows.Count = 0) Then
                    Return num
                End If
                If Operators.ConditionalCompareObjectEqual(set2.Tables.Item("generaldefaultset").Rows.Item(0).Item("SystemCriteria"), 1, False) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(70, "", True), MsgBoxStyle.Critical, Nothing)
                    Return DefaultSetID
                End If
                Try
                    enumerator = Frm.Controls.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As Control = DirectCast(enumerator.Current, Control)
                        Me.SaveValues(current, set2.Tables.Item("generaldefaultsetsub"))
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                ClsDs.UpdateDataSource(set2.Tables.Item("generaldefaultsetsub"), str2, True)
            End If
            Return DefaultSetID
        End Function

        Public Sub SaveValues(ByVal Ctrl As Control, ByVal CriteriaSubTable As DataTable)
            Dim enumerator As IEnumerator
            Dim view As New DataView(CriteriaSubTable, ("ControlName = '" & Ctrl.Name & "'"), "", DataViewRowState.CurrentRows)
            If (view.Count = 1) Then
                Dim type As Type = Ctrl.GetType
                If Not Information.IsNothing(type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty")))) Then
                    Select Case view.Item(0).Item("ValueType").ToString
                        Case "String"
                            view.Item(0).Item("StringValue") = RuntimeHelpers.GetObjectValue(type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).GetValue(Ctrl, Nothing))
                            GoTo Label_0225
                        Case "Boolean"
                            view.Item(0).Item("BoolValue") = RuntimeHelpers.GetObjectValue(type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).GetValue(Ctrl, Nothing))
                            GoTo Label_0225
                        Case "Date"
                            view.Item(0).Item("DateValue") = RuntimeHelpers.GetObjectValue(type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).GetValue(Ctrl, Nothing))
                            GoTo Label_0225
                        Case "Integer"
                            view.Item(0).Item("IntValue") = RuntimeHelpers.GetObjectValue(type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).GetValue(Ctrl, Nothing))
                            Exit Select
                        Case "Double"
                            view.Item(0).Item("DblValue") = RuntimeHelpers.GetObjectValue(type.GetProperty(Conversions.ToString(view.Item(0).Item("ControlProperty"))).GetValue(Ctrl, Nothing))
                            Exit Select
                    End Select
                End If
            End If
Label_0225:
            Try
                enumerator = Ctrl.Controls.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As Control = DirectCast(enumerator.Current, Control)
                    Me.SaveValues(current, CriteriaSubTable)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Public Function SendDefaultSetToUser(ByVal DefaultSetID As Integer, ByVal OwnerForm As Form) As Integer
            Dim num3 As Integer
            If (DefaultSetID = 0) Then
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
            Dim num As Integer = Me.CopyDefaultSet(DefaultSetID)
            If (num = 0) Then
                Return num3
            End If
            Dim sQLtxt As String = ("UPDATE generaldefaultset SET UserID = " & Conversions.ToString(num2) & " WHERE DefaultSetID = " & Conversions.ToString(num))
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

