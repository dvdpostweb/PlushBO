Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Data
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class clsGlobal
        ' Methods
        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.mvarCls1 = New clsDataSet(Me.mvarSessionInfo)
        End Sub

        Public Function CheckMenuAccessAutorization(ByVal MenuID As Integer, ByVal RoleID As Integer) As Boolean
            Dim security As New dsSecurity
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() { "SELECT * FROM securitymenu_role WHERE RoleID = ", Conversions.ToString(RoleID), " AND MenuID = ", Conversions.ToString(MenuID), "" })
            Try 
                [dset].FillDataSet(security.Tables.Item("securitymenu_role"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Return (security.Tables.Item("securitymenu_role").Rows.Count > 0)
        End Function

        Public Sub ContextMenuClick(ByVal Sender As Object, ByVal OwnerForm As Form)
            Dim menu As clsUserMenu = DirectCast(DirectCast(Sender, MenuItem), clsUserMenu)
            If Me.SessionInfo.MDIStyle Then
                Me.StartMenuForm(Conversions.ToString(menu.MergeOrder), OwnerForm.MdiParent)
            Else
                Me.StartMenuForm(Conversions.ToString(menu.MergeOrder), OwnerForm)
            End If
        End Sub

        Public Function DeleteComments(ByVal EntityID As Integer, ByVal CommentRef As String) As Integer
            Return Me.ExecuteDelete(String.Concat(New String() {"DELETE FROM generalcomment WHERE EntityID = ", Conversions.ToString(EntityID), " AND CommentRef = '", CommentRef, "'"}))
        End Function

        Public Function DeleteTranslations(ByVal FieldName As String, ByVal FieldID As Integer) As Integer
            Return Me.ExecuteDelete(("DELETE FROM generaldesctranslation WHERE Field = '" & FieldName & "' AND FieldID = " & Conversions.ToString(FieldID)))
        End Function

        Public Function ExecuteCount(ByVal SQLTxt As String) As Integer
            Dim num As Integer = -1
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            set2.Tables.Add("RowsCount")
            Try
                [dset].FillDataSet(set2.Tables.Item("RowsCount"), SQLTxt, True, False)
                num = Conversions.ToInteger(set2.Tables.Item("RowsCount").Rows.Item(0).Item(0))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Return num
        End Function

        Public Function ExecuteDelete(ByVal SQLTxt As String) As Integer
            Dim num As Integer = -1
            Dim dset As New clsDataSet(Me.SessionInfo)
            Try
                num = [dset].ExecuteNonQuery(SQLTxt, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Return num
        End Function

        Public Function ExecuteExists(ByVal SQLTxt As String) As Boolean
            Dim num As Integer = -1
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            set2.Tables.Add("RowsCount")
            Try
                [dset].FillDataSet(set2.Tables.Item("RowsCount"), SQLTxt, True, False)
                num = Conversions.ToInteger(set2.Tables.Item("RowsCount").Rows.Item(0).Item(0))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Return (num > 0)
        End Function

        Public Function ExecuteFindFieldValue(ByVal FieldName As String, ByVal SQLTxt As String) As String
            Dim count As Integer
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            set2.Tables.Add("FieldTable")
            set2.Tables.Item("FieldTable").Columns.Add(FieldName)
            Try
                [dset].FillDataSet(set2.Tables.Item("FieldTable"), SQLTxt, True, False)
                count = set2.Tables.Item("FieldTable").Rows.Count
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (count = 0) Then
                Return ""
            End If
            If (count > 1) Then
                Return ""
            End If
            Return Conversions.ToString(Operators.ConcatenateObject(set2.Tables.Item("FieldTable").Rows.Item(0).Item(FieldName), ""))
        End Function

        Public Function ExecuteFindFieldValueINT(ByVal FieldName As String, ByVal SQLTxt As String) As Integer
            Dim count As Integer
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            set2.Tables.Add("FieldTable")
            set2.Tables.Item("FieldTable").Columns.Add(FieldName)
            Try
                [dset].FillDataSet(set2.Tables.Item("FieldTable"), SQLTxt, True, False)
                count = set2.Tables.Item("FieldTable").Rows.Count
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (count = 0) Then
                Return -1
            End If
            If (count > 1) Then
                Return -1
            End If
            Return Conversions.ToInteger(set2.Tables.Item("FieldTable").Rows.Item(0).Item(FieldName))
        End Function

        Public Function ExecuteFindID(ByVal SQLTxt As String) As Integer
            Dim count As Integer
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            set2.Tables.Add("IDTable")
            set2.Tables.Item("IDTable").Columns.Add("ID")
            Try
                [dset].FillDataSet(set2.Tables.Item("IDTable"), SQLTxt, True, False)
                count = set2.Tables.Item("IDTable").Rows.Count
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (count = 0) Then
                Return 0
            End If
            If (count > 1) Then
                Return 0
            End If
            Return Conversions.ToInteger(set2.Tables.Item("IDTable").Rows.Item(0).Item("ID"))
        End Function

        Public Function GetAssemblyName(ByVal MenuID As Integer) As String
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM systemmenu WHERE MenuID = " & Conversions.ToString(MenuID))
            Try
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Return Conversions.ToString(system.Tables.Item("systemmenu").Rows.Item(0).Item("MenuAssembly"))
            End If
            Return ""
        End Function

        Public Function GetAssociatedMenu(ByVal MenuID As Integer) As DataTable
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT systemmenu.MenuID as MenuID, MenuLabel, MenuForm, MenuStartID  FROM systemmenusub  LEFT JOIN systemmenu On  systemmenu.MenuID = systemmenusub.SubMenuID WHERE systemmenusub.MenuID = " & Conversions.ToString(MenuID))
            Try
                set2.Tables.Add("MenuSub")
                [dset].FillDataSet(set2.Tables.Item("MenuSub"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Return set2.Tables.Item("MenuSub")
        End Function

        Public Function GetExRate(ByVal FromCurr As String, ByVal ToCurr As String, ByVal AsDate As DateTime) As Double
            Dim num As Double
            Dim num2 As Double
            Dim str2 As String
            Dim str As String = String.Concat(New String() {"CONVERT(DATETIME, '", Conversions.ToString(DateAndTime.Year(AsDate)), "-", Conversions.ToString(DateAndTime.Month(AsDate)), "-", Conversions.ToString(DateAndTime.Day(AsDate)), " 00:00:00',102)"})
            Dim general As New dsGeneral
            Dim dset As New clsDataSet(Me.SessionInfo)
            If (Me.SessionInfo.BaseCurrency = FromCurr) Then
                num2 = 1
            Else
                str2 = String.Concat(New String() {"SELECT TOP 1 * FROM systemcurrencyexrate WHERE (ExChangeType = '0') AND  DateDiff(Day, Fromdate , ", str, ") >= 0 AND CurrCode = '", FromCurr, "' ORDER BY FromDate DESC"})
                general.Tables.Item("systemcurrencyexrate").Clear()
                [dset].FillDataSet(general.Tables.Item("systemcurrencyexrate"), str2, True, False)
                If (general.Tables.Item("systemcurrencyexrate").Rows.Count > 0) Then
                    If Operators.ConditionalCompareObjectEqual(general.Tables.Item("systemcurrencyexrate").Rows.Item(0).Item("ExRate"), 0, False) Then
                        num2 = 1
                    Else
                        num2 = Conversions.ToDouble(Operators.DivideObject(1, general.Tables.Item("systemcurrencyexrate").Rows.Item(0).Item("ExRate")))
                    End If
                Else
                    num2 = 1
                End If
            End If
            If (Me.SessionInfo.BaseCurrency = ToCurr) Then
                num = 1
            Else
                str2 = String.Concat(New String() {"SELECT TOP 1 * FROM systemcurrencyexrate WHERE (ExChangeType = '0') AND  DateDiff(Day, Fromdate , ", str, ") >= 0 AND CurrCode = '", ToCurr, "' ORDER BY FromDate DESC"})
                general.Tables.Item("systemcurrencyexrate").Clear()
                [dset].FillDataSet(general.Tables.Item("systemcurrencyexrate"), str2, True, False)
                If (general.Tables.Item("systemcurrencyexrate").Rows.Count > 0) Then
                    If Operators.ConditionalCompareObjectEqual(general.Tables.Item("systemcurrencyexrate").Rows.Item(0).Item("ExRate"), 0, False) Then
                        num = 1
                    Else
                        num = Conversions.ToDouble(general.Tables.Item("systemcurrencyexrate").Rows.Item(0).Item("ExRate"))
                    End If
                Else
                    num = 1
                End If
            End If
            Return (num2 * num)
        End Function

        Public Function GetFieldLabel(ByVal ViewName As String, ByVal FieldName As String, ByVal Lang As String, Optional ByVal DefaultLabel As String = "") As String
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM systemfieldtranslation WHERE ViewName = '", ViewName, "' AND FieldName = '", FieldName, "' AND Lang = '", Lang, "'"})
            set2.Tables.Add("FieldLabel")
            Try
                [dset].FillDataSet(set2.Tables.Item("FieldLabel"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (set2.Tables.Item("FieldLabel").Rows.Count > 0) Then
                Return Conversions.ToString(set2.Tables.Item("FieldLabel").Rows.Item(0).Item("Label"))
            End If
            Return DefaultLabel
        End Function

        Public Function GetForm(ByVal FormName As String, ByVal AssemblyName As String, ByVal MenuID As Integer) As Form
            Dim form As frmBKForm
            If (FormName = "frmGeneral_Browse") Then
                form = New frmGeneral_Browse(Me.SessionInfo)
                If (Me.SetGeneralBrowseParam(DirectCast(form, frmGeneral_Browse), MenuID) = 0) Then
                    Return Nothing
                End If
                form.Tag = MenuID
                form.Text = Me.GetFormBanner(MenuID)
                form.Icon = New Icon(Me.SessionInfo.FormIcon)
                form.ShowInTaskbar = Me.SessionInfo.ShowInTaskBar
                DirectCast(form, frmGeneral_Browse).StartUp()
                Return form
            End If
            form = DirectCast(Activator.CreateInstance(Me.GetFormType(FormName, AssemblyName)), frmBKForm)
            form.SetBKOjects(Me.SessionInfo)
            form.Tag = MenuID
            form.Text = Me.GetFormBanner(MenuID)
            form.Icon = New Icon(Me.SessionInfo.FormIcon)
            form.ShowInTaskbar = Me.SessionInfo.ShowInTaskBar
            Return form
        End Function

        Public Function GetFormBanner(ByVal MenuID As Integer) As String
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM systemmenutranslation Where MenuID = ", Conversions.ToString(MenuID), " AND Lang = '", Me.SessionInfo.UserLang, "'"})
            Try
                [dset].FillDataSet(system.Tables.Item("systemmenutranslation"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmenutranslation").Rows.Count > 0) Then
                Return Conversions.ToString(system.Tables.Item("systemmenutranslation").Rows.Item(0).Item("MenuLabel"))
            End If
            sQLTxt = ("SELECT * FROM systemmenu WHERE MenuID = " & Conversions.ToString(MenuID))
            Try
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Return Conversions.ToString(system.Tables.Item("systemmenu").Rows.Item(0).Item("MenuLabel"))
            End If
            Return ""
        End Function

        Public Function GetFormName(ByVal MenuID As Integer) As String
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM systemmenu WHERE MenuID = " & Conversions.ToString(MenuID))
            Try
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Return Conversions.ToString(system.Tables.Item("systemmenu").Rows.Item(0).Item("MenuForm"))
            End If
            Return ""
        End Function

        Public Function GetFormType(ByVal FormName As String, ByVal AssemblyName As String) As Type
            Dim assembly As Assembly = Assembly.LoadFrom((Me.SessionInfo.ApplDir & "\" & AssemblyName))
            Dim length As Integer = Strings.InStr(AssemblyName, ".", CompareMethod.Text)
            Dim str As String = Strings.Mid(AssemblyName, 1, length)
            Return [assembly].GetType((str & FormName), True)
        End Function

        Public Function GetGlobalParam(ByVal Category As String, ByVal ParamName As String) As String
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Try
                [dset].FillDataSet(system.Tables.Item("generalglobalparameter"), String.Concat(New String() {"SELECT * FROM generalglobalparameter WHERE SetUpCategory = '", Category, "' AND Name = '", ParamName, "'"}), True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("generalglobalparameter").Rows.Count > 0) Then
                Return Conversions.ToString(Operators.ConcatenateObject(system.Tables.Item("generalglobalparameter").Rows.Item(0).Item("ParamValue"), ""))
            End If
            Return ""
        End Function

        Public Function GetMenuLabelTranslation(ByVal MenuID As Integer, ByVal Lang As String) As String
            Dim str2 As String
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() {"SELECT MenuID, Lang, MenuLabel FROM systemmenutranslation WHERE MenuID = ", Conversions.ToString(MenuID), " AND Lang = '", Lang, "'"})
            Try
                set2.Tables.Add("MenuTranslation")
                [dset].FillDataSet(set2.Tables.Item("MenuTranslation"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Dim table As DataTable = set2.Tables.Item("MenuTranslation")
            If (table.Rows.Count = 1) Then
                Return Conversions.ToString(table.Rows.Item(0).Item("MenuLabel"))
            End If
            Return ""
            table = Nothing
            Return str2
        End Function

        Public Function GetMsg(ByVal MsgNbr As Integer, Optional ByVal Lang As String = "", Optional ByVal AddMsgNbr As Boolean = True) As String
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            If (Lang = "") Then
                Lang = Me.SessionInfo.UserLang
            End If
            If (Lang = "") Then
                Lang = "EN"
            End If
            Try
                [dset].FillDataSet(system.Tables.Item("systemmessage"), String.Concat(New String() {"SELECT * FROM systemmessage WHERE MessageID = ", Conversions.ToString(MsgNbr), " AND Lang = '", Lang, "'"}), True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmessage").Rows.Count > 0) Then
                If AddMsgNbr Then
                    Return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(system.Tables.Item("systemmessage").Rows.Item(0).Item("MessageBody"), " ("), MsgNbr), ")"))
                End If
                Return Conversions.ToString(system.Tables.Item("systemmessage").Rows.Item(0).Item("MessageBody"))
            End If
            If AddMsgNbr Then
                Return ("(" & Conversions.ToString(MsgNbr) & ")")
            End If
            Return ""
        End Function

        Public Function GetNextDate(ByVal Intervall As Intervall, ByVal StartDate As DateTime, Optional ByVal NbrOfInterval As Integer = 1) As DateTime
            Select Case CInt(Intervall)
                Case 0
                    Return DateAndTime.DateAdd(DateInterval.Day, CDbl((1 * NbrOfInterval)), StartDate)
                Case 1
                    Return DateAndTime.DateAdd(DateInterval.WeekOfYear, CDbl((1 * NbrOfInterval)), StartDate)
                Case 2
                    Return DateAndTime.DateAdd(DateInterval.WeekOfYear, CDbl((2 * NbrOfInterval)), StartDate)
                Case 3
                    Return DateAndTime.DateAdd(DateInterval.Month, CDbl((1 * NbrOfInterval)), StartDate)
                Case 4
                    Return DateAndTime.DateAdd(DateInterval.Month, CDbl((3 * NbrOfInterval)), StartDate)
                Case 5
                    Return DateAndTime.DateAdd(DateInterval.Month, CDbl((6 * NbrOfInterval)), StartDate)
                Case 6
                    Return DateAndTime.DateAdd(DateInterval.Year, CDbl((1 * NbrOfInterval)), StartDate)
            End Select
            Return DateAndTime.DateAdd(DateInterval.Day, CDbl((1 * NbrOfInterval)), StartDate)
        End Function

        Public Function GetNextID(ByVal KeyName As String) As String
            Dim num As Integer
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Try
                [dset].FillDataSet(system.Tables.Item("systemsequence"), ("SELECT * FROM systemsequence WHERE KeyName = '" & KeyName & "'"), True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemsequence").Rows.Count > 0) Then
                num = Conversions.ToInteger(system.Tables.Item("systemsequence").Rows.Item(0).Item("NextValue"))
                Dim row As DataRow = system.Tables.Item("systemsequence").Rows.Item(0)
                Dim str2 As String = "NextValue"
                row.Item(str2) = Operators.AddObject(row.Item(str2), system.Tables.Item("systemsequence").Rows.Item(0).Item("Increment"))
                [dset].UpdateDataSource(system.Tables.Item("systemsequence"), True)
            Else
                num = -1
            End If
            Return Conversions.ToString(num)
        End Function

        Public Function GetRounding(ByVal CurrCode As String) As Integer
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Try
                [dset].FillDataSet(system.Tables.Item("systemcurrency"), ("SELECT * FROM systemcurrency WHERE CurrCode = '" & CurrCode & "' "), True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemcurrency").Rows.Count > 0) Then
                Return Conversions.ToInteger(system.Tables.Item("systemcurrency").Rows.Item(0).Item("RndFact"))
            End If
            Return 2
        End Function

        Public Function GetStartCode2(ByVal StartCode As String) As String
            Dim str2 As String
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = (" SELECT * FROM systemmenu WHERE MenuStartCode = '" & StartCode & "'")
            Try
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Dim row As DataRow = system.Tables.Item("systemmenu").Rows.Item(0)
                Return Conversions.ToString(Operators.ConcatenateObject(row.Item("MenuStartCode2"), ""))
                row = Nothing
                Return str2
            End If
            sQLTxt = (" SELECT * FROM systemmenu WHERE MenuStartCode2 = '" & StartCode & "'")
            [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Dim row2 As DataRow = system.Tables.Item("systemmenu").Rows.Item(0)
                Return Conversions.ToString(Operators.ConcatenateObject(row2.Item("MenuStartCode"), ""))
                row2 = Nothing
                Return str2
            End If
            Return Conversions.ToString(0)
        End Function

        Public Function GetStartID(ByVal StartCode As String) As Integer
            Dim num As Integer
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = (" SELECT * FROM systemmenu WHERE MenuStartCode = '" & StartCode & "'")
            Try
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Dim row As DataRow = system.Tables.Item("systemmenu").Rows.Item(0)
                Return Conversions.ToInteger(row.Item("MenuID"))
                row = Nothing
                Return num
            End If
            sQLTxt = (" SELECT * FROM systemmenu WHERE MenuStartCode2 = '" & StartCode & "'")
            [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Dim row2 As DataRow = system.Tables.Item("systemmenu").Rows.Item(0)
                Return Conversions.ToInteger(row2.Item("MenuID"))
                row2 = Nothing
                Return num
            End If
            Return -1
        End Function

        Public Function GetUserMenu(ByVal UserID1 As Integer) As DataTable
            Dim set2 As New DataSet
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT systemmenu.MenuID as MenuID, MenuLabel, MenuForm, MenuStartID, MenuStartCode, MenuStartCode2  FROM securityusermenu  LEFT JOIN systemmenu On systemmenu.MenuID = securityusermenu.MenuID WHERE UserID = " & Conversions.ToString(UserID1))
            Try
                set2.Tables.Add("MenuUser")
                [dset].FillDataSet(set2.Tables.Item("MenuUser"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Return set2.Tables.Item("MenuUser")
        End Function

        Public Sub LoadAssociatedMenu(ByVal MenuID As Integer, ByRef ParentMenu As MenuItem, ByVal Ownerform As Form)
            Dim enumerator As IEnumerator
            Dim associatedMenu As DataTable = Me.GetAssociatedMenu(MenuID)
            Try
                enumerator = associatedMenu.Rows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                    Dim item As New clsUserMenu(Conversions.ToString(current.Item("MenuLabel")), Ownerform)
                    item.MergeOrder = Conversions.ToInteger(current.Item("MenuStartID"))
                    item.Text = Conversions.ToString(current.Item("MenuLabel"))
                    AddHandler item.UserMenu_Click, New UserMenu_ClickEventHandler(AddressOf Me.ContextMenuClick)
                    ParentMenu.MenuItems.Add(item)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Public Sub QuickSearch(ByVal GridView1 As AdvBandedGridView, ByVal objds As DataSet, ByVal Tablename As String, ByVal NameField As String, ByVal SearchTxt As String)
            Dim view As New DataView(objds.Tables.Item(Tablename), (NameField & " Like '" & SearchTxt & "*'"), NameField, DataViewRowState.CurrentRows)
            If (view.Count > 0) Then
                Dim num As Integer = GridView1.LocateByValue(0, GridView1.get_Columns.get_Item(NameField), RuntimeHelpers.GetObjectValue(view.Item(0).Item(NameField)))
                GridView1.set_TopRowIndex(num)
                GridView1.set_FocusedRowHandle(num)
            End If
        End Sub

        Public Function SetGeneralBrowseParam(ByVal FRM As frmGeneral_Browse, ByVal MenuID As Integer) As Integer
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM systemmenu WHERE MenuID = " & Conversions.ToString(MenuID))
            Try
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmenu").Rows.Count = 1) Then
                FRM.TableName = Conversions.ToString(system.Tables.Item("systemmenu").Rows.Item(0).Item("BrowseTableName"))
                FRM.IDField = Conversions.ToString(system.Tables.Item("systemmenu").Rows.Item(0).Item("BrowseIDField"))
                FRM.NameField = Conversions.ToString(system.Tables.Item("systemmenu").Rows.Item(0).Item("BrowseNameField"))
                FRM.MaintenanceMenuID = Conversions.ToInteger(system.Tables.Item("systemmenu").Rows.Item(0).Item("BrowsetoMaintMenuID"))
                FRM.WhereClause = Conversions.ToString(Operators.ConcatenateObject(system.Tables.Item("systemmenu").Rows.Item(0).Item("BrowseWhereClause"), ""))
                If (Strings.InStr(FRM.WhereClause, "@AllowedEntityList", CompareMethod.Text) <> 0) Then
                    FRM.WhereClause = Strings.Replace(FRM.WhereClause, "@AllowedEntityList", Me.SessionInfo.AllowedEntityList, 1, -1, CompareMethod.Text)
                End If
                If (Strings.InStr(FRM.WhereClause, "@EntityID", CompareMethod.Text) <> 0) Then
                    FRM.WhereClause = Strings.Replace(FRM.WhereClause, "@EntityID", Conversions.ToString(Me.SessionInfo.EntityID), 1, -1, CompareMethod.Text)
                End If
                FRM.OrderByClause = Conversions.ToString(Operators.ConcatenateObject(system.Tables.Item("systemmenu").Rows.Item(0).Item("BrowseOrderByClause"), ""))
                Return 1
            End If
            Return 0
        End Function

        Public Sub SetToolBar(ByVal ToolBarManager As BarManager, ByVal MenuID As Integer, Optional ByVal btnNew As Boolean = True, Optional ByVal btnEdit As Boolean = True, Optional ByVal btnDelete As Boolean = True, Optional ByVal btnSave As Boolean = True, Optional ByVal btnView As Boolean = True, Optional ByVal btnFilter As Boolean = True, Optional ByVal btnPrint As Boolean = True, Optional ByVal btnExportToExcel As Boolean = True, Optional ByVal QuickSearch As Boolean = True, Optional ByVal btnHScroll As Boolean = False, Optional ByVal btnDefaultSet As Boolean = False)
            Dim filter As New clsFilter(Me.SessionInfo)
            Dim dset As New clsDefaultSet(Me.SessionInfo)
            Dim report As New clsReport(Me.SessionInfo)
            Dim view As New clsBrowseView(Me.SessionInfo)
            ToolBarManager.get_Bars.get_Item("Main_Bar").set_DockCol(0)
            ToolBarManager.get_Bars.get_Item("Misc_Bar").set_DockCol(0)
            ToolBarManager.get_Bars.get_Item("Misc_Bar2").set_DockCol(0)
            ToolBarManager.get_Bars.get_Item("QuickSearch_Bar").set_DockCol(0)
            ToolBarManager.get_Bars.get_Item("View_Bar").set_DockCol(0)
            If (((btnNew Or btnEdit) Or btnDelete) Or btnSave) Then
                ToolBarManager.get_Bars.get_Item("Main_Bar").set_Visible(True)
            End If
            If btnNew Then
                ToolBarManager.get_Items.get_Item("btnNew").set_Visibility(0)
            Else
                ToolBarManager.get_Items.get_Item("btnNew").set_Visibility(1)
            End If
            If btnEdit Then
                ToolBarManager.get_Items.get_Item("btnEdit").set_Visibility(0)
            Else
                ToolBarManager.get_Items.get_Item("btnEdit").set_Visibility(1)
            End If
            If btnDelete Then
                ToolBarManager.get_Items.get_Item("btnDelete").set_Visibility(0)
            Else
                ToolBarManager.get_Items.get_Item("btnDelete").set_Visibility(1)
            End If
            If btnSave Then
                ToolBarManager.get_Items.get_Item("btnSave").set_Visibility(0)
            Else
                ToolBarManager.get_Items.get_Item("btnSave").set_Visibility(1)
            End If
            ToolBarManager.get_Bars.get_Item("View_Bar").set_Visible(btnView)
            ToolBarManager.get_Bars.get_Item("Filter_Bar").set_Visible(btnFilter)
            ToolBarManager.get_Bars.get_Item("Report_Bar").set_Visible(btnPrint)
            ToolBarManager.get_Bars.get_Item("DefaultSet_Bar").set_Visible(btnDefaultSet)
            If Not Information.IsNothing(ToolBarManager.get_Items.get_Item("MainBtns_btnExcel")) Then
                If btnExportToExcel Then
                    ToolBarManager.get_Items.get_Item("MainBtns_btnExcel").set_Visibility(0)
                Else
                    ToolBarManager.get_Items.get_Item("MainBtns_btnExcel").set_Visibility(1)
                End If
            End If
            ToolBarManager.get_Bars.get_Item("QuickSearch_Bar").set_Visible(QuickSearch)
            If Not Information.IsNothing(ToolBarManager.get_Items.get_Item("MainBtns_btnBestFit")) Then
                If btnHScroll Then
                    ToolBarManager.get_Items.get_Item("MainBtns_btnBestFit").set_Visibility(1)
                Else
                    ToolBarManager.get_Items.get_Item("MainBtns_btnBestFit").set_Visibility(0)
                End If
            End If
            If btnPrint Then
                report.LoadToolBarReportList1(ToolBarManager, MenuID)
                ToolBarManager.get_Items.get_Item("btnMakeReportCommon").set_Enabled(Me.SessionInfo.CanModifyGlobalViews)
            End If
            If btnFilter Then
                filter.LoadToolBarFilterList1(ToolBarManager, MenuID, True)
                ToolBarManager.get_Items.get_Item("btnMakeFilterCommon").set_Enabled(Me.SessionInfo.CanModifyGlobalViews)
            End If
            If btnView Then
                view.LoadToolBarViewList1(ToolBarManager, MenuID, True)
                ToolBarManager.get_Items.get_Item("btnMakeViewCommon").set_Enabled(Me.SessionInfo.CanModifyGlobalViews)
            End If
            If btnDefaultSet Then
                [dset].LoadToolBarDefaultSetList1(ToolBarManager, MenuID, True)
                ToolBarManager.get_Items.get_Item("btnMakeDefaultCommon").set_Enabled(Me.SessionInfo.CanModifyGlobalViews)
            End If
        End Sub

        Public Sub StartForm(ByVal Form1 As Form, ByVal MenuID As Integer, Optional ByVal OwnerForm As Form = Nothing, Optional ByVal ShowForm As Boolean = True)
            Form1.Text = Me.GetFormBanner(MenuID)
            Form1.Icon = New Icon(Me.SessionInfo.FormIcon)
            Form1.ShowInTaskbar = Me.SessionInfo.ShowInTaskBar
            If Me.SessionInfo.MDIStyle Then
                Form1.MdiParent = OwnerForm
                If ShowForm Then
                    Form1.Show()
                End If
            ElseIf Information.IsNothing(OwnerForm) Then
                If ShowForm Then
                    Form1.Show()
                End If
            ElseIf ShowForm Then
                Form1.ShowDialog(OwnerForm)
            End If
        End Sub

        Public Sub StartForm(ByVal FormName As String, ByVal AssemblyName As String, ByVal MenuID As Integer, ByVal OwnerForm As Form, Optional ByVal ShowForm As Boolean = True)
            Dim form As frmBKForm
            If (FormName = "frmGeneral_Browse") Then
                form = New frmGeneral_Browse(Me.SessionInfo)
                If (Me.SetGeneralBrowseParam(DirectCast(form, frmGeneral_Browse), MenuID) = 0) Then
                    Return
                End If
                form.Tag = MenuID
                form.Text = Me.GetFormBanner(MenuID)
                form.Icon = New Icon(Me.SessionInfo.FormIcon)
                form.ShowInTaskbar = Me.SessionInfo.ShowInTaskBar
                DirectCast(form, frmGeneral_Browse).StartUp()
            Else
                form = DirectCast(Activator.CreateInstance(Me.GetFormType(FormName, AssemblyName)), frmBKForm)
                form.SetBKOjects(Me.SessionInfo)
                form.Tag = MenuID
                form.Text = Me.GetFormBanner(MenuID)
                form.Icon = New Icon(Me.SessionInfo.FormIcon)
                form.ShowInTaskbar = Me.SessionInfo.ShowInTaskBar
            End If
            Me.SessionInfo.MDIStyle = True
            If Me.SessionInfo.MDIStyle Then
                form.MdiParent = OwnerForm
                If ShowForm Then
                    form.Show()
                End If
            Else
                form.MinimizeBox = True
                form.MaximizeBox = True
                If Information.IsNothing(OwnerForm) Then
                    If ShowForm Then
                        form.Show()
                    End If
                ElseIf ShowForm Then
                    If (OwnerForm.Name = "frmSystemMainMenu") Then
                        form.Show()
                    Else
                        form.ShowDialog(OwnerForm)
                    End If
                End If
            End If
        End Sub

        Public Function StartMenuForm(ByVal MenuStartID As String, ByVal OwnerForm As Form) As Integer
            Dim num As Integer
            Dim system As New dsSystem
            Dim dset As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = (" SELECT * FROM systemmenu WHERE MenuStartCode = '" & MenuStartID & "'")
            Try
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Dim row As DataRow = system.Tables.Item("systemmenu").Rows.Item(0)
                If (Me.CheckMenuAccessAutorization(Conversions.ToInteger(row.Item("MenuID")), Me.SessionInfo.RoleID) Or (Me.SessionInfo.UserID = 0)) Then
                    If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(row.Item("MenuForm"), ""), "", False) Then
                        Me.StartForm(Conversions.ToString(row.Item("MenuForm")), Conversions.ToString(row.Item("MenuAssembly")), Conversions.ToInteger(row.Item("MenuID")), OwnerForm, True)
                        Return Conversions.ToInteger(row.Item("MenuID"))
                    End If
                    Return -1
                End If
                Interaction.MsgBox(Me.GetMsg(&H25, Me.SessionInfo.UserLang, True), MsgBoxStyle.Critical, Nothing)
                row = Nothing
                Return num
            End If
            sQLTxt = (" SELECT * FROM systemmenu WHERE MenuStartCode2 = '" & MenuStartID & "'")
            [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
            If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                Dim row2 As DataRow = system.Tables.Item("systemmenu").Rows.Item(0)
                If (Me.CheckMenuAccessAutorization(Conversions.ToInteger(row2.Item("MenuID")), Me.SessionInfo.RoleID) Or (Me.SessionInfo.UserID = 0)) Then
                    If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(row2.Item("MenuForm"), ""), "", False) Then
                        Me.StartForm(Conversions.ToString(row2.Item("MenuForm")), Conversions.ToString(row2.Item("MenuAssembly")), Conversions.ToInteger(row2.Item("MenuID")), OwnerForm, True)
                        Return Conversions.ToInteger(row2.Item("MenuID"))
                    End If
                    Return -1
                End If
                Interaction.MsgBox(Me.GetMsg(&H25, Me.SessionInfo.UserLang, True), MsgBoxStyle.Critical, Nothing)
                row2 = Nothing
                Return num
            End If
            If Versioned.IsNumeric(MenuStartID) Then
                sQLTxt = (" SELECT * FROM systemmenu WHERE MenuStartID = " & MenuStartID & "")
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
                If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                    Dim row3 As DataRow = system.Tables.Item("systemmenu").Rows.Item(0)
                    If (Me.CheckMenuAccessAutorization(Conversions.ToInteger(row3.Item("MenuID")), Me.SessionInfo.RoleID) Or (Me.SessionInfo.UserID = 0)) Then
                        If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(row3.Item("MenuForm"), ""), "", False) Then
                            Me.StartForm(Conversions.ToString(row3.Item("MenuForm")), Conversions.ToString(row3.Item("MenuAssembly")), Conversions.ToInteger(row3.Item("MenuID")), OwnerForm, True)
                            Return Conversions.ToInteger(row3.Item("MenuID"))
                        End If
                        Return -1
                    End If
                    Interaction.MsgBox(Me.GetMsg(&H25, Me.SessionInfo.UserLang, True), MsgBoxStyle.Critical, Nothing)
                    row3 = Nothing
                    Return num
                End If
                If Not Versioned.IsNumeric(MenuStartID) Then
                    Return -1
                End If
                sQLTxt = (" SELECT * FROM systemmenu WHERE MenuID = " & MenuStartID & "")
                [dset].FillDataSet(system.Tables.Item("systemmenu"), sQLTxt, True, False)
                If (system.Tables.Item("systemmenu").Rows.Count > 0) Then
                    Dim row4 As DataRow = system.Tables.Item("systemmenu").Rows.Item(0)
                    If (Me.CheckMenuAccessAutorization(Conversions.ToInteger(row4.Item("MenuID")), Me.SessionInfo.RoleID) Or (Me.SessionInfo.UserID = 0)) Then
                        If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(row4.Item("MenuForm"), ""), "", False) Then
                            Me.StartForm(Conversions.ToString(row4.Item("MenuForm")), Conversions.ToString(row4.Item("MenuAssembly")), Conversions.ToInteger(row4.Item("MenuID")), OwnerForm, True)
                            Return Conversions.ToInteger(row4.Item("MenuID"))
                        End If
                        Return -1
                    End If
                    Interaction.MsgBox(Me.GetMsg(&H25, Me.SessionInfo.UserLang, True), MsgBoxStyle.Critical, Nothing)
                    row4 = Nothing
                    Return num
                End If
            End If
            Return -1
        End Function

        Public Sub ToolBarQueryBrowse_Actions(ByVal sender As Object, ByVal btnName As String, ByRef OwnerForm As Form, ByRef GridView1 As AdvBandedGridView, ByVal ObjDS As DataSet, ByVal TableName As String, ByVal NameField As String, ByRef ToolBar1 As BarManager, ByRef CurrentFilterID As Integer, ByRef CurrentReportId As Integer, ByRef CurrentDefaultSetID As Integer, ByRef CurrentBrowseViewID As Integer, ByRef StatusBar1 As StatusBar, ByVal TablesToPrint As String())
            Dim filter As New clsFilter(Me.SessionInfo)
            Dim dset As New clsDefaultSet(Me.SessionInfo)
            Dim report As New clsReport(Me.SessionInfo)
            Dim view As New clsBrowseView(Me.SessionInfo)
            If Information.IsDBNull(RuntimeHelpers.GetObjectValue(DirectCast(ToolBar1.get_Items.get_Item("cmbFilterList"), BarEditItem).get_EditValue)) Then
                CurrentFilterID = 0
            Else
                CurrentFilterID = Conversions.ToInteger(DirectCast(ToolBar1.get_Items.get_Item("cmbFilterList"), BarEditItem).get_EditValue)
            End If
            If Information.IsDBNull(RuntimeHelpers.GetObjectValue(DirectCast(ToolBar1.get_Items.get_Item("cmbViewList"), BarEditItem).get_EditValue)) Then
                CurrentBrowseViewID = 0
            Else
                CurrentBrowseViewID = Conversions.ToInteger(DirectCast(ToolBar1.get_Items.get_Item("cmbViewList"), BarEditItem).get_EditValue)
            End If
            If Information.IsDBNull(RuntimeHelpers.GetObjectValue(DirectCast(ToolBar1.get_Items.get_Item("cmbReportList"), BarEditItem).get_EditValue)) Then
                CurrentReportId = 0
            Else
                CurrentReportId = Conversions.ToInteger(DirectCast(ToolBar1.get_Items.get_Item("cmbReportList"), BarEditItem).get_EditValue)
            End If
            Dim str As String = btnName
            Select Case str
                Case "MainBtns_btnExcel"
                    report.ExportGridToExcel(OwnerForm, GridView1)
                    Exit Select
                Case "btnQuickSearch"
                    Me.QuickSearch(GridView1, ObjDS, TableName, NameField, Conversions.ToString(DirectCast(ToolBar1.get_Items.get_Item("txtQuickSearch"), BarEditItem).get_EditValue))
                    GridView1.get_GridControl.Focus()
                    Exit Select
                Case "MainBtns_btnBestFit"
                    GridView1.get_OptionsView.set_ColumnAutoWidth(Not GridView1.get_OptionsView.get_ColumnAutoWidth)
                    Exit Select
                Case Else
                    If (IIf(((str = "MainBtns_btnBigger") OrElse (str = "MainBtns_btnSmaller")), 1, 0) <> 0) Then
                        If Not Information.IsNothing(GridView1) Then
                            Dim num As Integer
                            If (btnName = "MainBtns_btnBigger") Then
                                num = CInt(Math.Round(CDbl((GridView1.get_Appearance.get_Row.get_Font.Size + 1.0!))))
                            Else
                                num = CInt(Math.Round(CDbl((GridView1.get_Appearance.get_Row.get_Font.Size - 1.0!))))
                            End If
                            If (num = 0) Then
                                num = 1
                            End If
                            Dim style As FontStyle = GridView1.get_Appearance.get_Row.get_Font.Style
                            Dim unit As GraphicsUnit = GridView1.get_Appearance.get_Row.get_Font.Unit
                            Dim fontFamily As FontFamily = GridView1.get_Appearance.get_Row.get_Font.FontFamily
                            GridView1.get_Appearance.get_Row.set_Font(New Font(fontFamily, CSng(num), style, unit))
                            GridView1.get_Appearance.get_GroupRow.set_Font(New Font(fontFamily, CSng(num), style, unit))
                            GridView1.get_Appearance.get_HeaderPanel.set_Font(New Font(fontFamily, CSng(num), style, unit))
                        End If
                    Else
                        Select Case str
                            Case "btnDefault"
                                CurrentDefaultSetID = [dset].LoadDefaultSet(CurrentDefaultSetID, OwnerForm)
                                Exit Select
                            Case "btnSaveDefaultSet"
                                CurrentDefaultSetID = [dset].SaveDefaultSet(CurrentDefaultSetID, Conversions.ToInteger(OwnerForm.Tag), OwnerForm)
                                Exit Select
                            Case "btnNewDefaultSet"
                                CurrentDefaultSetID = [dset].NewDefaultSet(Conversions.ToInteger(OwnerForm.Tag), OwnerForm)
                                [dset].LoadToolBarDefaultSetList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                Exit Select
                            Case "btnDeleteDefaultSet"
                                [dset].DeleteDefaultSet(CurrentDefaultSetID)
                                [dset].LoadToolBarDefaultSetList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), True)
                                Exit Select
                            Case "btnEditDefaultSet"
                                [dset].EditDefaultSetInfo(CurrentDefaultSetID, OwnerForm)
                                [dset].LoadToolBarDefaultSetList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                Exit Select
                            Case "btnMakeDefaultSetCommon"
                                [dset].MakeDefaultSetCommon(CurrentDefaultSetID)
                                Exit Select
                            Case "btnSendDefaultSetUser"
                                [dset].SendDefaultSetToUser(CurrentDefaultSetID, OwnerForm)
                                Exit Select
                            Case "btnCopyDefaultSet"
                                CurrentDefaultSetID = [dset].CopyDefaultSet(CurrentDefaultSetID)
                                [dset].EditDefaultSetInfo(CurrentDefaultSetID, OwnerForm)
                                [dset].LoadToolBarDefaultSetList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                Exit Select
                            Case "btnNewFilter"
                                filter.NewFilterDialogue(Conversions.ToInteger(OwnerForm.Tag), ObjDS.Tables.Item(TableName), OwnerForm)
                                filter.LoadToolBarFilterList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                Exit Select
                            Case "btnDeleteFilter"
                                filter.DeleteFilter(CurrentFilterID)
                                filter.LoadToolBarFilterList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), True)
                                Exit Select
                            Case "btnEditFilter"
                                filter.EditFilterInfo(CurrentFilterID, Conversions.ToInteger(OwnerForm.Tag), ObjDS.Tables.Item(TableName), OwnerForm)
                                filter.LoadToolBarFilterList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                Exit Select
                            Case "btnMakeFilterCommon"
                                filter.MakeFilterCommon(CurrentFilterID)
                                Exit Select
                            Case "btnSendFilterUSer"
                                filter.SendFilterToUser(CurrentFilterID, OwnerForm)
                                Exit Select
                            Case "btnCopyFilter"
                                CurrentFilterID = filter.CopyFilter(CurrentFilterID)
                                filter.EditFilterInfo(CurrentFilterID, Conversions.ToInteger(OwnerForm.Tag), ObjDS.Tables.Item(TableName), OwnerForm)
                                filter.LoadToolBarFilterList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                Exit Select
                            Case "btnView"
                                view.LoadBrowseViewDefinition(CurrentBrowseViewID, Conversions.ToInteger(OwnerForm.Tag), TableName, (GridView1), StatusBar1.Panels.Item(0))
                                Exit Select
                            Case "btnNewView"
                                view.NewViewDialogue(Conversions.ToInteger(OwnerForm.Tag), ObjDS.Tables.Item(TableName), GridView1.get_GridControl, OwnerForm)
                                view.LoadToolBarViewList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                DirectCast(ToolBar1.get_Items.get_Item("cmbViewList"), BarEditItem).set_EditValue(CInt(CurrentBrowseViewID))
                                Exit Select
                            Case "btnEditView"
                                view.EditViewInfo(CurrentBrowseViewID, Conversions.ToInteger(OwnerForm.Tag), ObjDS.Tables.Item(TableName), OwnerForm)
                                view.LoadToolBarViewList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                DirectCast(ToolBar1.get_Items.get_Item("cmbViewList"), BarEditItem).set_EditValue(CInt(CurrentBrowseViewID))
                                Exit Select
                            Case "btnDeleteView"
                                view.DeleteBrowseView(CurrentBrowseViewID)
                                view.LoadToolBarViewList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), True)
                                DirectCast(ToolBar1.get_Items.get_Item("cmbViewList"), BarEditItem).set_EditValue(CInt(CurrentBrowseViewID))
                                Exit Select
                            Case "btnSaveView"
                                view.SaveCurrentBrowseViewDefinition(CurrentBrowseViewID, TableName, GridView1, False)
                                view.LoadToolBarViewList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                DirectCast(ToolBar1.get_Items.get_Item("cmbViewList"), BarEditItem).set_EditValue(CInt(CurrentBrowseViewID))
                                Exit Select
                            Case "btnMakeViewCommon"
                                view.MakeViewCommon(CurrentBrowseViewID)
                                Exit Select
                            Case "btnSendViewUser"
                                view.SendBrowseViewToUser(CurrentBrowseViewID, OwnerForm)
                                Exit Select
                            Case "btnCopyView"
                                If (Not CurrentBrowseViewID Is 0) Then
                                    CurrentBrowseViewID = view.CopyBrowseView(CurrentBrowseViewID)
                                    view.EditViewInfo(CurrentBrowseViewID, Conversions.ToInteger(OwnerForm.Tag), ObjDS.Tables.Item(TableName), OwnerForm)
                                    view.LoadToolBarViewList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag), False)
                                    DirectCast(ToolBar1.get_Items.get_Item("cmbViewList"), BarEditItem).set_EditValue(CInt(CurrentBrowseViewID))
                                End If
                                Exit Select
                        End Select
                        If (str = "btnPrint") Then
                            report.PrintReport(CurrentReportId, GridView1.get_GridControl, ObjDS, TablesToPrint, Conversions.ToInteger(Conversion.Int(RuntimeHelpers.GetObjectValue(OwnerForm.Tag))))
                        ElseIf (str = "btnNewReport") Then
                            report.CreateNewReport(Conversions.ToInteger(OwnerForm.Tag), OwnerForm)
                            report.LoadToolBarReportList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag))
                        ElseIf (str = "btnDeleteReport") Then
                            report.DeleteReport(CurrentReportId)
                            report.LoadToolBarReportList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag))
                        ElseIf (str = "btnDesignReport") Then
                            report.DesignReport(CurrentReportId, ObjDS, TablesToPrint)
                            report.LoadToolBarReportList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag))
                        ElseIf (str = "btnEditReportInfo") Then
                            report.EditReportInfo(CurrentReportId, OwnerForm)
                            report.LoadToolBarReportList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag))
                        ElseIf (str = "btnMakeReportCommon") Then
                            report.MakeReportCommon(CurrentReportId)
                        ElseIf (str = "btnSendReportUser") Then
                            report.SendReportToUser(CurrentReportId, OwnerForm)
                        ElseIf ((str = "btnCopyReport") AndAlso (Not CurrentReportId Is 0)) Then
                            CurrentReportId = report.CopyReport(CurrentReportId)
                            report.EditReportInfo(CurrentReportId, OwnerForm)
                            report.LoadToolBarReportList1(ToolBar1, Conversions.ToInteger(OwnerForm.Tag))
                        End If
                    End If
                    Exit Select
            End Select
        End Sub

        Public Sub ToolBarQueryBrowse_ToolClick2(ByVal sender As Object, ByVal btnName As String, ByRef OwnerForm As Form, ByRef GridView1 As AdvBandedGridView, ByVal ObjDS As DataSet, ByVal TableName As String, ByVal NameField As String, ByRef ToolBar1 As BarManager, ByRef CurrentFilterID As Integer, ByRef CurrentReportId As Integer, ByRef CurrentDefaultSetID As Integer, ByRef CurrentBrowseViewID As Integer, ByRef StatusBar1 As StatusBar, ByVal TablesToPrint As String())
            Me.ToolBarQueryBrowse_Actions(RuntimeHelpers.GetObjectValue(sender), btnName, (OwnerForm), (GridView1), ObjDS, TableName, NameField, (ToolBar1), (CurrentFilterID), (CurrentReportId), (CurrentDefaultSetID), (CurrentBrowseViewID), (StatusBar1), TablesToPrint)
        End Sub


        ' Properties
        Public ReadOnly Property Cls1 As clsDataSet
            Get
                Return Me.mvarCls1
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


        ' Fields
        Private mvarCls1 As clsDataSet
        Private mvarSessionInfo As clsSessionInfo

        ' Nested Types
        Public Enum GlobalState
            ' Fields
            Both = 2
            [Global] = 0
            Local = 1
        End Enum

        Public Enum Intervall
            ' Fields
            Day = 0
            Month = 3
            SixMonthes = 5
            ThreeMonthes = 4
            TwoWeeks = 2
            Week = 1
            Year = 6
        End Enum

        Public Enum ObjectState
            ' Fields
            BrowseState = 2
            EditState = 1
            NewState = 0
        End Enum
    End Class
End Namespace

