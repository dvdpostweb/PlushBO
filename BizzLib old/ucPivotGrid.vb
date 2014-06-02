Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraTab
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Namespace BizzLib
    Public Class ucPivotGrid
        Inherits XtraUserControl
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.ucPivotGrid_Load)
            Dim list As ArrayList = ucPivotGrid.__ENCList
            SyncLock list
                ucPivotGrid.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Private Sub AddSummaryOptions()
            Dim enumerator As IEnumerator
            Dim list As New ArrayList
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Me.PivotGrid1.get_OptionsView)
            Try 
                enumerator = properties.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As PropertyDescriptor = DirectCast(enumerator.Current, PropertyDescriptor)
                    If (IIf((current.PropertyType.Equals(GetType(Boolean)) AndAlso (current.Name.IndexOf("Total") > -1)), 1, 0) <> 0) Then
                        list.Add(current.Name)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
            list.Sort
            Me.clbOptions.set_DataSource(list)
            Dim i As Integer
            For i = 0 To Me.clbOptions.get_ItemCount - 1
                Me.clbOptions.SetItemChecked(i, SetOptions.OptionValueByString(Me.clbOptions.GetItemText(i), Me.PivotGrid1.get_OptionsView))
            Next i
        End Sub

        Private Sub btnBiggerCaps_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.ChangeFontSize(1)
        End Sub

        Private Sub btnDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Me.cmbName.get_EditValue, ""), "", False) Then
                Interaction.MsgBox("Nothing to delete. Please select the analyze you want to delete.", MsgBoxStyle.OkOnly, Nothing)
            Else
                Dim analyzeID As Integer = Conversions.ToInteger(Me.cmbName.get_EditValue)
                If (Interaction.MsgBox(Me.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes) Then
                    Me.DeleteAnalyze(analyzeID)
                    Me.LoadAnalyzeList
                End If
            End If
        End Sub

        Private Sub btnEdit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Me.cmbName.get_EditValue, ""), "", False) Then
                Interaction.MsgBox("Please select an analyze.", MsgBoxStyle.OkOnly, Nothing)
            Else
                Dim analyzeID As Integer = Conversions.ToInteger(Me.cmbName.get_EditValue)
                Me.EditAnalyzeName(analyzeID)
            End If
        End Sub

        Private Sub btnExport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Select Case Me.cmbExportTo.get_EditValue.ToString
                Case "Excel"
                    Me.ExportTo("Microsoft Excel Document", "Microsoft Excel|*.xls", "XLS")
                    Exit Select
                Case "HTML"
                    Me.ExportTo("HTML Document", "HTML Documents|*.html", "HTML")
                    Exit Select
                Case "Rich Text"
                    Me.ExportTo("RTF Document", "RTF Documents|*.rtf", "RTF")
                    Exit Select
                Case "Text"
                    Me.ExportTo("Text Document", "Text Files|*.txt", "TXT")
                    Exit Select
                Case "MHT"
                    Me.ExportTo("MHT Document", "MHT Documents|*.mht", "MHT")
                    Exit Select
                Case "PDF"
                    Me.ExportTo("PDF Document", "PDF Documents|*.pdf", "PDF")
                    Exit Select
            End Select
        End Sub

        Private Sub btnLoad_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Me.cmbName.get_EditValue, ""), "", False) Then
                Interaction.MsgBox("Nothing to load. Please select an analyze.", MsgBoxStyle.OkOnly, Nothing)
            Else
                Dim analyzeID As Integer = Conversions.ToInteger(Me.cmbName.get_EditValue)
                Me.LoadAnalyze(analyzeID)
            End If
        End Sub

        Private Sub btnMakeCommon_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Me.cmbName.get_EditValue, ""), "", False) Then
                Interaction.MsgBox("Please select an analyze first.", MsgBoxStyle.OkOnly, Nothing)
            Else
                Dim analyzeID As Integer = Conversions.ToInteger(Me.cmbName.get_EditValue)
                Me.MakeCommon(analyzeID)
            End If
        End Sub

        Private Sub btnNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.cmbName.set_EditValue(Nothing)
            Me.SaveAnalyze
        End Sub

        Private Sub btnPrint_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If (Not Me.PivotGrid1 Is Nothing) Then
                Me.PivotGrid1.ShowPrintPreview
            End If
        End Sub

        Private Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SaveAnalyze
        End Sub

        Private Sub btnSendToUSer_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Me.cmbName.get_EditValue, ""), "", False) Then
                Interaction.MsgBox("Please select an analyze first.", MsgBoxStyle.OkOnly, Nothing)
            Else
                Dim analyzeID As Integer = Conversions.ToInteger(Me.cmbName.get_EditValue)
                Me.SendToUSer(analyzeID)
            End If
        End Sub

        Private Sub btnSmallerCaps_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.ChangeFontSize(-1)
        End Sub

        Private Sub btnStyleCondition_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        End Sub

        Private Sub ceTopValuesShowOthers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetFieldTop
        End Sub

        Private Sub ChangeFontSize(ByVal FontIncrement As Integer)
            If Not Information.IsNothing(Me.PivotGrid1) Then
                Dim num As Integer = CInt(Math.Round(CDbl((Me.PivotGrid1.get_Appearance.get_Cell.get_Font.Size + FontIncrement))))
                If (num >= 0) Then
                    Dim style As FontStyle = Me.PivotGrid1.get_Appearance.get_Cell.get_Font.Style
                    Dim unit As GraphicsUnit = Me.PivotGrid1.get_Appearance.get_Cell.get_Font.Unit
                    Dim fontFamily As FontFamily = Me.PivotGrid1.get_Appearance.get_Cell.get_Font.FontFamily
                    Me.PivotGrid1.get_Appearance.get_Cell.set_Font(New Font(fontFamily, CSng(num), style, unit))
                    Me.PivotGrid1.get_Appearance.get_CustomTotalCell.set_Font(New Font(fontFamily, CSng(num), style, unit))
                    Me.PivotGrid1.get_Appearance.get_FieldHeader.set_Font(New Font(fontFamily, CSng(num), style, unit))
                    Me.PivotGrid1.get_Appearance.get_FieldValue.set_Font(New Font(fontFamily, CSng(num), style, unit))
                    Me.PivotGrid1.BestFit
                End If
            End If
        End Sub

        Private Sub clbOptions_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
            SetOptions.SetOptionValueByString(Me.clbOptions.GetItemText(e.get_Index), Me.PivotGrid1.get_OptionsView, (e.get_State = CheckState.Checked))
        End Sub

        Private Sub ClearFieldTop()
            Dim enumerator As IEnumerator
            Dim expression As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Me.cmbTopField.get_Text)
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    expression = DirectCast(enumerator.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(expression.get_FieldName, Me.cmbTopField.get_EditValue, False) Then
                        goto Label_0087
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        Label_0087:
            If (Not Information.IsNothing(expression) AndAlso (expression.get_Area Is 0)) Then
                expression.set_TopValueCount(0)
                expression.set_TopValueShowOthers(False)
            End If
        End Sub

        Private Sub ClearSortBy()
            Dim enumerator As IEnumerator
            Dim expression As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Me.cmbSortField.get_Text)
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    expression = DirectCast(enumerator.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(expression.get_FieldName, Me.cmbSortField.get_EditValue, False) Then
                        goto Label_0087
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        Label_0087:
            If (Not Information.IsNothing(expression) AndAlso (expression.get_Area Is 0)) Then
                expression.get_SortBySummaryInfo.set_Field(Nothing)
            End If
        End Sub

        Private Sub cmbGroupField_Enter(ByVal sender As Object, ByVal e As EventArgs)
            Dim enumerator As IEnumerator
            Me.cmbGroupField.get_Properties.get_Items.Clear
            Me.cmbGroupField.get_Properties.get_Items.Clear
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As PivotGridField = DirectCast(enumerator.Current, PivotGridField)
                    If (IIf((((current.get_Area Is 0) Or (current.get_Area Is 1)) AndAlso current.get_Visible), 1, 0) <> 0) Then
                        Me.cmbGroupField.get_Properties.get_Items.Add(current.get_FieldName)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        End Sub

        Private Sub cmbGroupIntervall_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim interval As PivotGroupInterval
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim values As Array = Enum.GetValues(GetType(PivotGroupInterval))
            Dim expression As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Me.cmbSortField.get_Text)
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    expression = DirectCast(enumerator.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(expression.get_FieldName, Me.cmbGroupField.get_EditValue, False) Then
                        goto Label_00A2
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        Label_00A2:
            If (Information.IsNothing(expression) OrElse Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Me.cmbGroupField.get_EditValue, ""), "", False)) Then
                Return
            End If
            Try 
                enumerator2 = values.GetEnumerator
                Do While enumerator2.MoveNext
                    interval = DirectCast(Conversions.ToInteger(enumerator2.Current), PivotGroupInterval)
                    If Operators.ConditionalCompareObjectEqual(interval.ToString, Me.cmbGroupIntervall.get_EditValue, False) Then
                        goto Label_0150
                    End If
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2,IDisposable).Dispose
                End If
            End Try
        Label_0150:
            Try 
                expression.set_GroupInterval(interval)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.MsgBox("Wrong Group Interval Selected", MsgBoxStyle.Critical, Nothing)
                expression.set_GroupInterval(0)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Private Sub cmbSortByField_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            Dim str As String = e.get_Button.get_Tag.ToString
            If (str = "DeleteSortByField") Then
                Me.ClearSortBy
                Me.cmbSortByField.set_EditValue("")
            End If
        End Sub

        Private Sub cmbSortByField_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim expression As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Me.cmbSortField.get_Text)
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    expression = DirectCast(enumerator.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(expression.get_FieldName, Me.cmbSortField.get_EditValue, False) Then
                        goto Label_008D
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        Label_008D:
            If (Information.IsNothing(expression) OrElse (Not expression.get_Area Is 0)) Then
                Return
            End If
            Dim current As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Me.cmbSortByField.get_Text)
            Try 
                enumerator2 = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator2.MoveNext
                    current = DirectCast(enumerator2.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(current.get_FieldName, Me.cmbSortByField.get_EditValue, False) Then
                        goto Label_0143
                    End If
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2,IDisposable).Dispose
                End If
            End Try
        Label_0143:
            If (Not Information.IsNothing(current) AndAlso (current.get_Area Is 3)) Then
                expression.get_SortBySummaryInfo.set_Field(current)
            End If
        End Sub

        Private Sub cmbSortField_Enter(ByVal sender As Object, ByVal e As EventArgs)
            Me.InitSortComboBoxes
        End Sub

        Private Sub cmbSortField_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim enumerator As IEnumerator
            Dim expression As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Me.cmbSortField.get_Text)
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    expression = DirectCast(enumerator.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(expression.get_FieldName, Me.cmbSortField.get_EditValue, False) Then
                        goto Label_0087
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        Label_0087:
            If (Not Information.IsNothing(expression) AndAlso (expression.get_Area Is 0)) Then
                Me.cmbSortByField.set_EditValue(expression.get_SortBySummaryInfo.get_FieldName)
            End If
        End Sub

        Private Sub cmbSummaryField_Enter(ByVal sender As Object, ByVal e As EventArgs)
            Me.InitSummaryComboBoxes
        End Sub

        Private Sub cmbSummaryField_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim enumerator As IEnumerator
            Dim expression As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Conversions.ToString(Me.cmbSummaryField.get_EditValue))
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    expression = DirectCast(enumerator.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(expression.get_FieldName, Me.cmbSummaryField.get_EditValue, False) Then
                        goto Label_008C
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        Label_008C:
            If (Not Information.IsNothing(expression) AndAlso (expression.get_Area Is 3)) Then
                Me.cmbSummaryType.set_EditValue(expression.get_SummaryType)
                Me.SetFieldFont(expression)
                expression.get_Appearance.get_ValueTotal.set_BackColor(Color.LightSkyBlue)
            End If
        End Sub

        Private Sub cmbSummaryType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim enumerator As IEnumerator
            Dim expression As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Conversions.ToString(Me.cmbSummaryField.get_EditValue))
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    expression = DirectCast(enumerator.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(expression.get_FieldName, Me.cmbSummaryField.get_EditValue, False) Then
                        goto Label_008C
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        Label_008C:
            If Not Information.IsNothing(expression) Then
                expression.set_SummaryType(DirectCast(Conversions.ToInteger(Me.cmbSummaryType.get_EditValue), PivotSummaryType))
                Me.SetFieldCaption(expression)
            End If
        End Sub

        Private Sub cmbTopField_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(e.get_Button.get_Tag)) Then
                Dim str As String = e.get_Button.get_Tag.ToString
                If (str = "DeleteTopField") Then
                    Me.ClearFieldTop
                    Me.cmbTopField.set_EditValue("")
                End If
            End If
        End Sub

        Private Sub cmbTopField_Enter(ByVal sender As Object, ByVal e As EventArgs)
            Me.InitTopComboBoxes
        End Sub

        Private Sub cmbTopField_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.PivotGrid1.BeginUpdate
            Me.SetFieldTop
            Me.PivotGrid1.EndUpdate
        End Sub

        Public Function CopyAnalyze(ByVal AnalyzeID As Integer) As Integer
            Dim enumerator As IEnumerator
            Dim analyze As New dsAnalyze
            Dim analyze2 As New dsAnalyze
            Dim set As New clsDataSet(Me.SessionInfo)
            If (AnalyzeID = 0) Then
                Return 0
            End If
            Dim sQLTxt As String = ("SELECT * FROM generalanalyze WHERE AnalyzeID = " & Conversions.ToString(AnalyzeID))
            ClsDs.FillDataSet(analyze.Tables.Item("generalanalyze"), sQLTxt, True, False)
            If (analyze.Tables.Item("generalanalyze").Rows.Count = 0) Then
                Return 0
            End If
            Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("AnalyzeID"))
            Dim row As DataRow = analyze2.Tables.Item("generalanalyze").NewRow
            row.ItemArray = analyze.Tables.Item("generalanalyze").Rows.Item(0).ItemArray
            row.Item("AnalyzeID") = num
            row.Item("UserID") = Me.SessionInfo.UserID
            row.Item("Name") = Operators.ConcatenateObject("Copy of ", analyze.Tables.Item("generalanalyze").Rows.Item(0).Item("Name"))
            analyze2.Tables.Item("generalanalyze").Rows.Add(row)
            ClsDs.UpdateDataSource(analyze2.Tables.Item("generalanalyze"), sQLTxt, True)
            Dim str2 As String = ("SELECT * FROM generalanalyzefield WHERE AnalyzeID = " & Conversions.ToString(AnalyzeID))
            ClsDs.FillDataSet(analyze.Tables.Item("generalanalyzefield"), str2, True, False)
            Try
                enumerator = analyze.Tables.Item("generalanalyzefield").Rows.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                    row = analyze2.Tables.Item("generalanalyzefield").NewRow
                    row.ItemArray = current.ItemArray
                    row.Item("AnalyzeID") = num
                    analyze2.Tables.Item("generalanalyzefield").Rows.Add(row)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            ClsDs.UpdateDataSource(analyze2.Tables.Item("generalanalyzefield"), str2, True)
            Return num
        End Function

        Public Sub DeleteAnalyze(ByVal AnalyzeID As Integer)
            Me.DeleteAnalyzeDetail(AnalyzeID)
            Me.BKGlobal.Cls1.ExecuteNonQuery(("DELETE FROM generalanalyze WHERE AnalyzeID = " & Conversions.ToString(AnalyzeID)), True)
        End Sub

        Public Sub DeleteAnalyzeDetail(ByVal AnalyzeID As Integer)
            Me.BKGlobal.Cls1.ExecuteNonQuery(("DELETE FROM generalanalyzefield WHERE AnalyzeID = " & Conversions.ToString(AnalyzeID)), True)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Sub EditAnalyzeName(ByVal AnalyzeID As Integer)
            Me.LoadAnalyzeTable(AnalyzeID)
            If (Me.mvarDS.Tables.Item("generalanalyze1").Rows.Count = 0) Then
                Interaction.MsgBox("Sorry this analyze does not exist anymore. Deleting database entry.", MsgBoxStyle.OkOnly, Nothing)
                Me.DeleteAnalyze(AnalyzeID)
            Else
                Dim row As DataRow = Me.mvarDS.Tables.Item("generalanalyze1").Rows.Item(0)
                Dim analyze As New frmDialogNewAnalyze
                analyze.AnalyzeName = Conversions.ToString(row.Item("Name"))
                analyze.AnalyzeDesc = Conversions.ToString(row.Item("Description"))
                analyze.ShowDialog(Me.ParentForm)
                If (analyze.DialogResult <> DialogResult.Cancel) Then
                    Dim analyzeName As String = analyze.AnalyzeName
                    Dim analyzeDesc As String = analyze.AnalyzeDesc
                    row.Item("Name") = analyzeName
                    row.Item("Description") = analyzeDesc
                    Me.BKGlobal.Cls1.UpdateDataSource(Me.mvarDS.Tables.Item("generalanalyze1"), "SELECT * FROM generalanalyze ", True)
                    Me.LoadAnalyzeList()
                End If
            End If
        End Sub

        Private Sub EndExport()
            Me.stopThread = True
            Me.thread.Join()
        End Sub

        Private Sub ExportTo(ByVal title As String, ByVal filter As String, ByVal exportFormat As String)
            If (Not Me.PivotGrid1 Is Nothing) Then
                Me.SaveFileDialog1.Title = title
                Me.SaveFileDialog1.Filter = filter
                Me.SaveFileDialog1.ShowDialog(Me)
                Dim fileName As String = Me.SaveFileDialog1.FileName
                If (fileName <> "") Then
                    Me.stopThread = False
                    Me.thread = New Thread(New ThreadStart(AddressOf Me.StartExport))
                    Me.thread.Start()
                    Dim current As Cursor = Cursor.Current
                    Cursor.Current = Cursors.WaitCursor
                    Select Case exportFormat
                        Case "HTML"
                            Me.PivotGrid1.ExportToHtml(fileName)
                            Exit Select
                        Case "MHT"
                            Me.PivotGrid1.ExportToMht(fileName)
                            Exit Select
                        Case "PDF"
                            Me.PivotGrid1.ExportToPdf(fileName)
                            Exit Select
                        Case "XLS"
                            Me.PivotGrid1.ExportToXls(fileName)
                            Exit Select
                        Case "RTF"
                            Me.PivotGrid1.ExportToRtf(fileName)
                            Exit Select
                        Case "TXT"
                            Me.PivotGrid1.ExportToText(fileName)
                            Exit Select
                    End Select
                    Me.EndExport()
                    Cursor.Current = current
                End If
            End If
        End Sub

        Private Sub icbTotalsLocations_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.PivotGrid1.get_OptionsView.set_TotalsLocation(DirectCast(Conversions.ToInteger(Me.icbTotalsLocations.get_EditValue), PivotTotalsLocation))
        End Sub

        Private Sub InitGrpComboBoxes()
            Dim enumerator As IEnumerator
            Dim values As Array = Enum.GetValues(GetType(PivotGroupInterval))
            Try
                enumerator = values.GetEnumerator
                Do While enumerator.MoveNext
                    Dim interval As PivotGroupInterval = DirectCast(Conversions.ToInteger(enumerator.Current), PivotGroupInterval)
                    Me.cmbGroupIntervall.get_Properties.get_Items.Add(interval.ToString)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Public Sub Initialize(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.mvarBKGlobal = New clsGlobal(CurrentSessionInfo)
            Me.LoadAnalyzeList()
        End Sub

        <DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(ucPivotGrid))
            Dim diagram As New XYDiagram
            Dim series As New Series
            Dim series2 As New Series
            Me.grpSortSummary = New GroupBox
            Me.cmbSortByField = New ComboBoxEdit
            Me.lblSortByField = New Label
            Me.cmbSortField = New ComboBoxEdit
            Me.Label2 = New Label
            Me.grpPrintSaveLoad = New GroupBox
            Me.cmbName = New LookUpEdit
            Me.mvarDS = New dsAnalyze
            Me.lblName = New Label
            Me.cmbExportTo = New ComboBoxEdit
            Me.lblExport = New Label
            Me.grpSummary = New GroupBox
            Me.cmbSummaryField = New ComboBoxEdit
            Me.Label1 = New Label
            Me.cmbSummaryType = New ImageComboBoxEdit
            Me.clbOptions = New CheckedListBoxControl
            Me.label3 = New Label
            Me.grpTop = New GroupBox
            Me.seTop = New SpinEdit
            Me.cmbTopField = New ComboBoxEdit
            Me.ceTopValuesShowOthers = New CheckEdit
            Me.SaveFileDialog1 = New SaveFileDialog
            Me.OpenFileDialog1 = New OpenFileDialog
            Me.BarManager1 = New BarManager(Me.components)
            Me.Bar1 = New Bar
            Me.btnExport = New BarButtonItem
            Me.btnPrint = New BarButtonItem
            Me.btnNew = New BarButtonItem
            Me.btnSave = New BarButtonItem
            Me.btnEdit = New BarButtonItem
            Me.btnLoad = New BarButtonItem
            Me.btnDelete = New BarButtonItem
            Me.btnBiggerCaps = New BarButtonItem
            Me.btnSmallerCaps = New BarButtonItem
            Me.btnSendToUSer = New BarButtonItem
            Me.btnMakeCommon = New BarButtonItem
            Me.btnStyleCondition = New BarButtonItem
            Me.barDockControlTop = New BarDockControl
            Me.barDockControlBottom = New BarDockControl
            Me.barDockControlLeft = New BarDockControl
            Me.barDockControlRight = New BarDockControl
            Me.DockManager1 = New DockManager(Me.components)
            Me.PanelParameters = New DockPanel
            Me.DockPanel2_Container = New ControlContainer
            Me.grpMisc = New GroupBox
            Me.icbTotalsLocations = New ImageComboBoxEdit
            Me.Label4 = New Label
            Me.grpGroup = New GroupBox
            Me.lblGrpInterval = New Label
            Me.lblGrpField = New Label
            Me.cmbGroupField = New ComboBoxEdit
            Me.cmbGroupIntervall = New ComboBoxEdit
            Me.PanelChartParameters = New DockPanel
            Me.DockPanel1_Container = New ControlContainer
            Me.btnRefreshChart = New SimpleButton
            Me.btnArea = New SimpleButton
            Me.btnPie = New SimpleButton
            Me.btnBar = New SimpleButton
            Me.btnLines = New SimpleButton
            Me.chkShowLabel = New CheckEdit
            Me.PivotGrid1 = New PivotGridControl
            Me.SplitterControl1 = New SplitterControl
            Me.XtraTabControl1 = New XtraTabControl
            Me.tabPivotGrid = New XtraTabPage
            Me.tabChart = New XtraTabPage
            Me.ChartControl1 = New ChartControl
            Me.hideContainerLeft = New AutoHideContainer
            Me.grpSortSummary.SuspendLayout()
            Me.cmbSortByField.get_Properties.BeginInit()
            Me.cmbSortField.get_Properties.BeginInit()
            Me.grpPrintSaveLoad.SuspendLayout()
            Me.cmbName.get_Properties.BeginInit()
            Me.mvarDS.BeginInit()
            Me.cmbExportTo.get_Properties.BeginInit()
            Me.grpSummary.SuspendLayout()
            Me.cmbSummaryField.get_Properties.BeginInit()
            Me.cmbSummaryType.get_Properties.BeginInit()
            Me.clbOptions.BeginInit()
            Me.grpTop.SuspendLayout()
            Me.seTop.get_Properties.BeginInit()
            Me.cmbTopField.get_Properties.BeginInit()
            Me.ceTopValuesShowOthers.get_Properties.BeginInit()
            Me.BarManager1.BeginInit()
            Me.DockManager1.BeginInit()
            Me.PanelParameters.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            Me.grpMisc.SuspendLayout()
            Me.icbTotalsLocations.get_Properties.BeginInit()
            Me.grpGroup.SuspendLayout()
            Me.cmbGroupField.get_Properties.BeginInit()
            Me.cmbGroupIntervall.get_Properties.BeginInit()
            Me.PanelChartParameters.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.chkShowLabel.get_Properties.BeginInit()
            Me.PivotGrid1.BeginInit()
            Me.XtraTabControl1.BeginInit()
            Me.XtraTabControl1.SuspendLayout()
            Me.tabPivotGrid.SuspendLayout()
            Me.tabChart.SuspendLayout()
            Me.ChartControl1.BeginInit()
            diagram.BeginInit()
            series.BeginInit()
            series2.BeginInit()
            Me.hideContainerLeft.SuspendLayout()
            Me.SuspendLayout()
            Me.grpSortSummary.Controls.Add(Me.cmbSortByField)
            Me.grpSortSummary.Controls.Add(Me.lblSortByField)
            Me.grpSortSummary.Controls.Add(Me.cmbSortField)
            Me.grpSortSummary.Controls.Add(Me.Label2)
            Dim point As New Point(8, &H130)
            Me.grpSortSummary.Location = point
            Me.grpSortSummary.Name = "grpSortSummary"
            Dim size As New Size(&HF8, &H48)
            Me.grpSortSummary.Size = size
            Me.grpSortSummary.TabIndex = 20
            Me.grpSortSummary.TabStop = False
            Me.grpSortSummary.Text = "Sort by Sumary Info"
            point = New Point(&H58, 40)
            Me.cmbSortByField.Location = point
            Me.cmbSortByField.Name = "cmbSortByField"
            Me.cmbSortByField.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5), New EditorButton("DeleteSortByField", 2)})
            size = New Size(&H98, 20)
            Me.cmbSortByField.Size = size
            Me.cmbSortByField.TabIndex = &H15
            Me.lblSortByField.AutoSize = True
            point = New Point(8, 40)
            Me.lblSortByField.Location = point
            Me.lblSortByField.Name = "lblSortByField"
            size = New Size(&H30, 13)
            Me.lblSortByField.Size = size
            Me.lblSortByField.TabIndex = 20
            Me.lblSortByField.Text = "By Field:"
            point = New Point(&H58, &H10)
            Me.cmbSortField.Location = point
            Me.cmbSortField.Name = "cmbSortField"
            Me.cmbSortField.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            size = New Size(&H98, 20)
            Me.cmbSortField.Size = size
            Me.cmbSortField.TabIndex = &H13
            Me.Label2.AutoSize = True
            point = New Point(8, &H10)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&H38, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = &H12
            Me.Label2.Text = "Sort Field:"
            Me.grpPrintSaveLoad.Controls.Add(Me.cmbName)
            Me.grpPrintSaveLoad.Controls.Add(Me.lblName)
            Me.grpPrintSaveLoad.Controls.Add(Me.cmbExportTo)
            Me.grpPrintSaveLoad.Controls.Add(Me.lblExport)
            point = New Point(8, 0)
            Me.grpPrintSaveLoad.Location = point
            Me.grpPrintSaveLoad.Name = "grpPrintSaveLoad"
            size = New Size(&HF8, &H38)
            Me.grpPrintSaveLoad.Size = size
            Me.grpPrintSaveLoad.TabIndex = &H13
            Me.grpPrintSaveLoad.TabStop = False
            point = New Point(&H58, 8)
            Me.cmbName.Location = point
            Me.cmbName.Name = "cmbName"
            Me.cmbName.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            Me.cmbName.get_Properties.get_Columns.AddRange(New LookUpColumnInfo() {New LookUpColumnInfo("Name", "Name", &H4B, 0, "", True, 1), New LookUpColumnInfo("Description", "Description", &H4B, 0, "", True, 1)})
            Me.cmbName.get_Properties.set_DataSource(Me.mvarDS.generalanalyze)
            Me.cmbName.get_Properties.set_DisplayMember("Name")
            Me.cmbName.get_Properties.set_NullText("")
            Me.cmbName.get_Properties.set_ValueMember("AnalyzeID")
            size = New Size(&H98, 20)
            Me.cmbName.Size = size
            Me.cmbName.TabIndex = 7
            Me.mvarDS.DataSetName = "dsAnalyze"
            Me.mvarDS.Locale = New CultureInfo("en-US")
            Me.mvarDS.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.lblName.AutoSize = True
            Me.lblName.ImeMode = ImeMode.NoControl
            point = New Point(8, 8)
            Me.lblName.Location = point
            Me.lblName.Name = "lblName"
            size = New Size(&H22, 13)
            Me.lblName.Size = size
            Me.lblName.TabIndex = 6
            Me.lblName.Text = "Name"
            Me.cmbExportTo.set_EditValue("Excel")
            point = New Point(&H58, &H20)
            Me.cmbExportTo.Location = point
            Me.cmbExportTo.Name = "cmbExportTo"
            Me.cmbExportTo.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            Me.cmbExportTo.get_Properties.get_Items.AddRange(New Object() {"Excel", "PDF", "Rich Text", "Text", "HTML", "MHT"})
            size = New Size(&H98, 20)
            Me.cmbExportTo.Size = size
            Me.cmbExportTo.TabIndex = 1
            Me.lblExport.AutoSize = True
            Me.lblExport.ImeMode = ImeMode.NoControl
            point = New Point(8, &H20)
            Me.lblExport.Location = point
            Me.lblExport.Name = "lblExport"
            size = New Size(&H42, 13)
            Me.lblExport.Size = size
            Me.lblExport.TabIndex = 0
            Me.lblExport.Text = "Export Type"
            Me.grpSummary.Controls.Add(Me.cmbSummaryField)
            Me.grpSummary.Controls.Add(Me.Label1)
            Me.grpSummary.Controls.Add(Me.cmbSummaryType)
            Me.grpSummary.Controls.Add(Me.clbOptions)
            Me.grpSummary.Controls.Add(Me.label3)
            point = New Point(8, 120)
            Me.grpSummary.Location = point
            Me.grpSummary.Name = "grpSummary"
            size = New Size(&HF8, &HB8)
            Me.grpSummary.Size = size
            Me.grpSummary.TabIndex = &H12
            Me.grpSummary.TabStop = False
            Me.grpSummary.Text = "Summary Options"
            point = New Point(&H68, &H10)
            Me.cmbSummaryField.Location = point
            Me.cmbSummaryField.Name = "cmbSummaryField"
            Me.cmbSummaryField.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            size = New Size(&H88, 20)
            Me.cmbSummaryField.Size = size
            Me.cmbSummaryField.TabIndex = &H11
            Me.Label1.AutoSize = True
            point = New Point(8, &H10)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H21, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 14
            Me.Label1.Text = "Field:"
            Me.cmbSummaryType.set_EditValue("imageComboBoxEdit1")
            point = New Point(&H68, 40)
            Me.cmbSummaryType.Location = point
            Me.cmbSummaryType.Name = "cmbSummaryType"
            Me.cmbSummaryType.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            Me.cmbSummaryType.get_Properties.set_DropDownRows(10)
            size = New Size(&H88, 20)
            Me.cmbSummaryType.Size = size
            Me.cmbSummaryType.TabIndex = 13
            Me.clbOptions.set_CheckOnClick(True)
            Me.clbOptions.set_ItemHeight(&H11)
            Me.clbOptions.set_LeftCoord(0)
            point = New Point(&H10, &H40)
            Me.clbOptions.Location = point
            Me.clbOptions.set_MultiColumn(True)
            Me.clbOptions.Name = "clbOptions"
            size = New Size(&HE0, &H70)
            Me.clbOptions.Size = size
            Me.clbOptions.TabIndex = &H10
            Me.label3.AutoSize = True
            point = New Point(8, 40)
            Me.label3.Location = point
            Me.label3.Name = "label3"
            size = New Size(&H52, 13)
            Me.label3.Size = size
            Me.label3.TabIndex = 15
            Me.label3.Text = "Summary Type:"
            Me.grpTop.Controls.Add(Me.seTop)
            Me.grpTop.Controls.Add(Me.cmbTopField)
            Me.grpTop.Controls.Add(Me.ceTopValuesShowOthers)
            point = New Point(8, &H38)
            Me.grpTop.Location = point
            Me.grpTop.Name = "grpTop"
            size = New Size(&HF8, &H40)
            Me.grpTop.Size = size
            Me.grpTop.TabIndex = &H11
            Me.grpTop.TabStop = False
            Me.grpTop.Text = "Top Values options"
            Dim num As New Decimal(New Integer() {0, 0, 0, 0})
            Me.seTop.set_EditValue(num)
            point = New Point(&H10, &H10)
            Me.seTop.Location = point
            Me.seTop.Name = "seTop"
            Me.seTop.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton})
            Me.seTop.get_Properties.set_EditValueChangedFiringMode(0)
            Me.seTop.get_Properties.set_IsFloatValue(False)
            Me.seTop.get_Properties.get_Mask.set_EditMask("N00")
            num = New Decimal(New Integer() {30, 0, 0, 0})
            Me.seTop.get_Properties.set_MaxValue(num)
            num = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seTop.get_Properties.set_MinValue(num)
            size = New Size(&H48, 20)
            Me.seTop.Size = size
            Me.seTop.TabIndex = 7
            point = New Point(&H60, &H10)
            Me.cmbTopField.Location = point
            Me.cmbTopField.Name = "cmbTopField"
            Me.cmbTopField.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5), New EditorButton("DeleteTopField", 2)})
            size = New Size(&H90, 20)
            Me.cmbTopField.Size = size
            Me.cmbTopField.TabIndex = 11
            point = New Point(&H10, 40)
            Me.ceTopValuesShowOthers.Location = point
            Me.ceTopValuesShowOthers.Name = "ceTopValuesShowOthers"
            Me.ceTopValuesShowOthers.get_Properties.set_Caption("TopValuesShowOthers")
            size = New Size(&HE0, &H12)
            Me.ceTopValuesShowOthers.Size = size
            Me.ceTopValuesShowOthers.TabIndex = 10
            Me.BarManager1.get_Bars.AddRange(New Bar() {Me.Bar1})
            Me.BarManager1.get_DockControls.Add(Me.barDockControlTop)
            Me.BarManager1.get_DockControls.Add(Me.barDockControlBottom)
            Me.BarManager1.get_DockControls.Add(Me.barDockControlLeft)
            Me.BarManager1.get_DockControls.Add(Me.barDockControlRight)
            Me.BarManager1.set_DockManager(Me.DockManager1)
            Me.BarManager1.set_Form(Me)
            Me.BarManager1.get_Items.AddRange(New BarItem() {Me.btnExport, Me.btnPrint, Me.btnSave, Me.btnEdit, Me.btnLoad, Me.btnDelete, Me.btnBiggerCaps, Me.btnSmallerCaps, Me.btnSendToUSer, Me.btnMakeCommon, Me.btnNew, Me.btnStyleCondition})
            Me.BarManager1.set_MaxItemId(14)
            Me.Bar1.set_BarName("AnalizeBar")
            Me.Bar1.set_DockCol(0)
            Me.Bar1.set_DockRow(0)
            Me.Bar1.set_DockStyle(2)
            point = New Point(&H37, &H7F)
            Me.Bar1.set_FloatLocation(point)
            size = New Size(100, 100)
            Me.Bar1.set_FloatSize(size)
            Me.Bar1.get_LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(Me.btnExport), New LinkPersistInfo(Me.btnPrint), New LinkPersistInfo(Me.btnNew), New LinkPersistInfo(Me.btnSave), New LinkPersistInfo(Me.btnEdit), New LinkPersistInfo(Me.btnLoad), New LinkPersistInfo(Me.btnDelete), New LinkPersistInfo(Me.btnBiggerCaps), New LinkPersistInfo(Me.btnSmallerCaps), New LinkPersistInfo(Me.btnSendToUSer), New LinkPersistInfo(Me.btnMakeCommon), New LinkPersistInfo(0, False, Me.btnStyleCondition, False)})
            Me.Bar1.set_Offset(1)
            Me.Bar1.set_Text("Analize")
            Me.btnExport.set_Caption("Export")
            Me.btnExport.set_Glyph(DirectCast(manager.GetObject("btnExport.Glyph"), Image))
            Me.btnExport.set_Hint("Export")
            Me.btnExport.set_Id(0)
            Me.btnExport.set_Name("btnExport")
            Me.btnPrint.set_Caption("Print")
            Me.btnPrint.set_Glyph(DirectCast(manager.GetObject("btnPrint.Glyph"), Image))
            Me.btnPrint.set_Hint("Print")
            Me.btnPrint.set_Id(1)
            Me.btnPrint.set_Name("btnPrint")
            Me.btnNew.set_Caption("New")
            Me.btnNew.set_Glyph(DirectCast(manager.GetObject("btnNew.Glyph"), Image))
            Me.btnNew.set_Hint("Save as new Analyze")
            Me.btnNew.set_Id(11)
            Me.btnNew.set_Name("btnNew")
            Me.btnSave.set_Caption("Save")
            Me.btnSave.set_Glyph(DirectCast(manager.GetObject("btnSave.Glyph"), Image))
            Me.btnSave.set_Hint("Save")
            Me.btnSave.set_Id(2)
            Me.btnSave.set_Name("btnSave")
            Me.btnEdit.set_Caption("Rename")
            Me.btnEdit.set_Glyph(DirectCast(manager.GetObject("btnEdit.Glyph"), Image))
            Me.btnEdit.set_Hint("Edit Analyze Name / description")
            Me.btnEdit.set_Id(10)
            Me.btnEdit.set_Name("btnEdit")
            Me.btnLoad.set_Caption("Load")
            Me.btnLoad.set_Glyph(DirectCast(manager.GetObject("btnLoad.Glyph"), Image))
            Me.btnLoad.set_Hint("Load")
            Me.btnLoad.set_Id(4)
            Me.btnLoad.set_Name("btnLoad")
            Me.btnDelete.set_Caption("Delete")
            Me.btnDelete.set_Glyph(DirectCast(manager.GetObject("btnDelete.Glyph"), Image))
            Me.btnDelete.set_Hint("Delete")
            Me.btnDelete.set_Id(5)
            Me.btnDelete.set_Name("btnDelete")
            Me.btnBiggerCaps.set_Caption("Bigger")
            Me.btnBiggerCaps.set_Glyph(DirectCast(manager.GetObject("btnBiggerCaps.Glyph"), Image))
            Me.btnBiggerCaps.set_Hint("Bigger Caps")
            Me.btnBiggerCaps.set_Id(7)
            Me.btnBiggerCaps.set_Name("btnBiggerCaps")
            Me.btnSmallerCaps.set_Caption("Smaller")
            Me.btnSmallerCaps.set_Description("Smaller Caps")
            Me.btnSmallerCaps.set_Glyph(DirectCast(manager.GetObject("btnSmallerCaps.Glyph"), Image))
            Me.btnSmallerCaps.set_Hint("Smaller Caps")
            Me.btnSmallerCaps.set_Id(6)
            Me.btnSmallerCaps.set_Name("btnSmallerCaps")
            Me.btnSendToUSer.set_Caption("ToUSer")
            Me.btnSendToUSer.set_Glyph(DirectCast(manager.GetObject("btnSendToUSer.Glyph"), Image))
            Me.btnSendToUSer.set_Hint("Send this analyze to another user")
            Me.btnSendToUSer.set_Id(8)
            Me.btnSendToUSer.set_Name("btnSendToUSer")
            Me.btnMakeCommon.set_Caption("ToCommon")
            Me.btnMakeCommon.set_Glyph(DirectCast(manager.GetObject("btnMakeCommon.Glyph"), Image))
            Me.btnMakeCommon.set_Hint("Make this analyze common to all users")
            Me.btnMakeCommon.set_Id(9)
            Me.btnMakeCommon.set_Name("btnMakeCommon")
            Me.btnStyleCondition.set_Caption("StyleCondition")
            Me.btnStyleCondition.set_Glyph(DirectCast(manager.GetObject("btnStyleCondition.Glyph"), Image))
            Me.btnStyleCondition.set_Id(13)
            Me.btnStyleCondition.set_Name("btnStyleCondition")
            Me.DockManager1.get_AutoHideContainers.AddRange(New AutoHideContainer() {Me.hideContainerLeft})
            Me.DockManager1.set_Form(Me)
            Me.DockManager1.get_RootPanels.AddRange(New DockPanel() {Me.PanelParameters})
            Me.DockManager1.get_TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
            Me.PanelParameters.Controls.Add(Me.DockPanel2_Container)
            Me.PanelParameters.set_Dock(3)
            size = New Size(200, &HC6)
            Me.PanelParameters.set_FloatSize(size)
            Dim guid As New Guid("aea8b689-57b7-45d7-9693-d650898e186e")
            Me.PanelParameters.set_ID(guid)
            point = New Point(&H13, &H2A)
            Me.PanelParameters.set_Location(point)
            Me.PanelParameters.Name = "PanelParameters"
            Me.PanelParameters.get_Options.set_ShowCloseButton(False)
            size = New Size(&H10D, &H21E)
            Me.PanelParameters.set_Size(size)
            Me.PanelParameters.set_Text("Data Parameters")
            Me.DockPanel2_Container.Controls.Add(Me.grpMisc)
            Me.DockPanel2_Container.Controls.Add(Me.grpGroup)
            Me.DockPanel2_Container.Controls.Add(Me.grpPrintSaveLoad)
            Me.DockPanel2_Container.Controls.Add(Me.grpTop)
            Me.DockPanel2_Container.Controls.Add(Me.grpSummary)
            Me.DockPanel2_Container.Controls.Add(Me.grpSortSummary)
            point = New Point(3, &H19)
            Me.DockPanel2_Container.Location = point
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            size = New Size(&H107, &H202)
            Me.DockPanel2_Container.Size = size
            Me.DockPanel2_Container.TabIndex = 0
            Me.grpMisc.Controls.Add(Me.icbTotalsLocations)
            Me.grpMisc.Controls.Add(Me.Label4)
            point = New Point(8, 440)
            Me.grpMisc.Location = point
            Me.grpMisc.Name = "grpMisc"
            size = New Size(&HF8, &H40)
            Me.grpMisc.Size = size
            Me.grpMisc.TabIndex = &H16
            Me.grpMisc.TabStop = False
            Me.grpMisc.Text = "Misc"
            Me.icbTotalsLocations.set_EditValue("imageComboBoxEdit1")
            point = New Point(120, &H10)
            Me.icbTotalsLocations.Location = point
            Me.icbTotalsLocations.Name = "icbTotalsLocations"
            Me.icbTotalsLocations.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            size = New Size(&H74, 20)
            Me.icbTotalsLocations.Size = size
            Me.icbTotalsLocations.TabIndex = 7
            Me.Label4.AutoSize = True
            point = New Point(8, &H10)
            Me.Label4.Location = point
            Me.Label4.Name = "Label4"
            size = New Size(&H56, 13)
            Me.Label4.Size = size
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "Totals Location: "
            Me.grpGroup.Controls.Add(Me.lblGrpInterval)
            Me.grpGroup.Controls.Add(Me.lblGrpField)
            Me.grpGroup.Controls.Add(Me.cmbGroupField)
            Me.grpGroup.Controls.Add(Me.cmbGroupIntervall)
            point = New Point(8, &H178)
            Me.grpGroup.Location = point
            Me.grpGroup.Name = "grpGroup"
            size = New Size(&HF8, &H40)
            Me.grpGroup.Size = size
            Me.grpGroup.TabIndex = &H15
            Me.grpGroup.TabStop = False
            Me.grpGroup.Text = "Grouping"
            Me.lblGrpInterval.AutoSize = True
            point = New Point(8, 40)
            Me.lblGrpInterval.Location = point
            Me.lblGrpInterval.Name = "lblGrpInterval"
            size = New Size(&H2F, 13)
            Me.lblGrpInterval.Size = size
            Me.lblGrpInterval.TabIndex = &H16
            Me.lblGrpInterval.Text = "Intervall"
            Me.lblGrpField.AutoSize = True
            point = New Point(8, &H10)
            Me.lblGrpField.Location = point
            Me.lblGrpField.Name = "lblGrpField"
            size = New Size(&H1D, 13)
            Me.lblGrpField.Size = size
            Me.lblGrpField.TabIndex = &H15
            Me.lblGrpField.Text = "Field"
            point = New Point(&H58, &H10)
            Me.cmbGroupField.Location = point
            Me.cmbGroupField.Name = "cmbGroupField"
            Me.cmbGroupField.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            size = New Size(&H98, 20)
            Me.cmbGroupField.Size = size
            Me.cmbGroupField.TabIndex = 20
            point = New Point(&H58, 40)
            Me.cmbGroupIntervall.Location = point
            Me.cmbGroupIntervall.Name = "cmbGroupIntervall"
            Me.cmbGroupIntervall.get_Properties.get_Buttons.AddRange(New EditorButton() {New EditorButton(-5)})
            size = New Size(&H98, 20)
            Me.cmbGroupIntervall.Size = size
            Me.cmbGroupIntervall.TabIndex = 0
            Me.PanelChartParameters.Controls.Add(Me.DockPanel1_Container)
            Me.PanelChartParameters.set_Dock(3)
            guid = New Guid("a083f23c-4493-44ea-9107-88d70fe91d0e")
            Me.PanelChartParameters.set_ID(guid)
            point = New Point(0, 0)
            Me.PanelChartParameters.set_Location(point)
            Me.PanelChartParameters.Name = "PanelChartParameters"
            Me.PanelChartParameters.set_SavedDock(3)
            Me.PanelChartParameters.set_SavedIndex(1)
            size = New Size(200, &H21E)
            Me.PanelChartParameters.set_Size(size)
            Me.PanelChartParameters.set_Text("Chart Parameters")
            Me.PanelChartParameters.set_Visibility(2)
            Me.DockPanel1_Container.Controls.Add(Me.btnRefreshChart)
            Me.DockPanel1_Container.Controls.Add(Me.btnArea)
            Me.DockPanel1_Container.Controls.Add(Me.btnPie)
            Me.DockPanel1_Container.Controls.Add(Me.btnBar)
            Me.DockPanel1_Container.Controls.Add(Me.btnLines)
            Me.DockPanel1_Container.Controls.Add(Me.chkShowLabel)
            point = New Point(3, &H19)
            Me.DockPanel1_Container.Location = point
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            size = New Size(&HC2, &H202)
            Me.DockPanel1_Container.Size = size
            Me.DockPanel1_Container.TabIndex = 0
            point = New Point(&H18, &H10)
            Me.btnRefreshChart.Location = point
            Me.btnRefreshChart.Name = "btnRefreshChart"
            size = New Size(&H4B, &H17)
            Me.btnRefreshChart.Size = size
            Me.btnRefreshChart.TabIndex = 0
            Me.btnRefreshChart.set_Text("Refresh")
            point = New Point(80, 120)
            Me.btnArea.Location = point
            Me.btnArea.Name = "btnArea"
            size = New Size(&H30, &H30)
            Me.btnArea.Size = size
            Me.btnArea.TabIndex = 12
            Me.btnArea.set_Text("Area")
            point = New Point(&H18, 120)
            Me.btnPie.Location = point
            Me.btnPie.Name = "btnPie"
            size = New Size(&H30, &H30)
            Me.btnPie.Size = size
            Me.btnPie.TabIndex = 11
            Me.btnPie.set_Text("Pie")
            point = New Point(80, &H40)
            Me.btnBar.Location = point
            Me.btnBar.Name = "btnBar"
            size = New Size(&H30, &H30)
            Me.btnBar.Size = size
            Me.btnBar.TabIndex = 10
            Me.btnBar.set_Text("Bars")
            point = New Point(&H18, &H40)
            Me.btnLines.Location = point
            Me.btnLines.Name = "btnLines"
            size = New Size(&H30, &H30)
            Me.btnLines.Size = size
            Me.btnLines.TabIndex = 9
            Me.btnLines.set_Text("Lines")
            point = New Point(40, &HD8)
            Me.chkShowLabel.Location = point
            Me.chkShowLabel.Name = "chkShowLabel"
            Me.chkShowLabel.get_Properties.set_Caption("Show Labels")
            size = New Size(80, &H12)
            Me.chkShowLabel.Size = size
            Me.chkShowLabel.TabIndex = 9
            Me.PivotGrid1.BackColor = Color.FromArgb(&HF7, &HF5, &HF1)
            Me.PivotGrid1.Cursor = Cursors.Default
            Me.PivotGrid1.Dock = DockStyle.Fill
            point = New Point(0, 0)
            Me.PivotGrid1.Location = point
            Me.PivotGrid1.Name = "PivotGrid1"
            Me.PivotGrid1.get_OptionsLayout.set_StoreAllOptions(True)
            Me.PivotGrid1.get_OptionsLayout.set_StoreAppearance(True)
            size = New Size(&H2A7, &H200)
            Me.PivotGrid1.Size = size
            Me.PivotGrid1.TabIndex = 1
            point = New Point(&H120, &H2A)
            Me.SplitterControl1.Location = point
            Me.SplitterControl1.Name = "SplitterControl1"
            size = New Size(8, &H21E)
            Me.SplitterControl1.Size = size
            Me.SplitterControl1.TabIndex = 5
            Me.SplitterControl1.TabStop = False
            Me.XtraTabControl1.Dock = DockStyle.Fill
            point = New Point(&H128, &H2A)
            Me.XtraTabControl1.Location = point
            Me.XtraTabControl1.Name = "XtraTabControl1"
            Me.XtraTabControl1.set_SelectedTabPage(Me.tabPivotGrid)
            size = New Size(&H2B0, &H21E)
            Me.XtraTabControl1.Size = size
            Me.XtraTabControl1.TabIndex = 7
            Me.XtraTabControl1.get_TabPages.AddRange(New XtraTabPage() {Me.tabPivotGrid, Me.tabChart})
            Me.XtraTabControl1.Text = "XtraTabControl1"
            Me.tabPivotGrid.Controls.Add(Me.PivotGrid1)
            Me.tabPivotGrid.Name = "tabPivotGrid"
            size = New Size(&H2A7, &H200)
            Me.tabPivotGrid.set_Size(size)
            Me.tabPivotGrid.set_Text("GRID")
            Me.tabChart.Controls.Add(Me.ChartControl1)
            Me.tabChart.Name = "tabChart"
            size = New Size(500, &H200)
            Me.tabChart.set_Size(size)
            Me.tabChart.set_Text("Chart")
            diagram.get_AxisY.get_Range.set_SideMarginsEnabled(True)
            diagram.get_AxisX.get_Range.set_SideMarginsEnabled(True)
            Me.ChartControl1.set_Diagram(diagram)
            Me.ChartControl1.Dock = DockStyle.Fill
            point = New Point(0, 0)
            Me.ChartControl1.Location = point
            Me.ChartControl1.Name = "ChartControl1"
            series.set_Name("Series 1")
            series2.set_Name("Series 2")
            Me.ChartControl1.set_SeriesSerializable(New Series() {series, series2})
            size = New Size(500, &H200)
            Me.ChartControl1.Size = size
            Me.ChartControl1.TabIndex = 0
            Me.hideContainerLeft.Controls.Add(Me.PanelChartParameters)
            Me.hideContainerLeft.set_Dock(DockStyle.Left)
            point = New Point(0, &H2A)
            Me.hideContainerLeft.Location = point
            Me.hideContainerLeft.Name = "hideContainerLeft"
            size = New Size(&H13, &H21E)
            Me.hideContainerLeft.Size = size
            Me.Controls.Add(Me.XtraTabControl1)
            Me.Controls.Add(Me.SplitterControl1)
            Me.Controls.Add(Me.PanelParameters)
            Me.Controls.Add(Me.hideContainerLeft)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ucPivotGrid"
            size = New Size(&H3D8, &H248)
            Me.Size = size
            Me.grpSortSummary.ResumeLayout(False)
            Me.grpSortSummary.PerformLayout()
            Me.cmbSortByField.get_Properties.EndInit()
            Me.cmbSortField.get_Properties.EndInit()
            Me.grpPrintSaveLoad.ResumeLayout(False)
            Me.grpPrintSaveLoad.PerformLayout()
            Me.cmbName.get_Properties.EndInit()
            Me.mvarDS.EndInit()
            Me.cmbExportTo.get_Properties.EndInit()
            Me.grpSummary.ResumeLayout(False)
            Me.grpSummary.PerformLayout()
            Me.cmbSummaryField.get_Properties.EndInit()
            Me.cmbSummaryType.get_Properties.EndInit()
            Me.clbOptions.EndInit()
            Me.grpTop.ResumeLayout(False)
            Me.seTop.get_Properties.EndInit()
            Me.cmbTopField.get_Properties.EndInit()
            Me.ceTopValuesShowOthers.get_Properties.EndInit()
            Me.BarManager1.EndInit()
            Me.DockManager1.EndInit()
            Me.PanelParameters.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            Me.grpMisc.ResumeLayout(False)
            Me.grpMisc.PerformLayout()
            Me.icbTotalsLocations.get_Properties.EndInit()
            Me.grpGroup.ResumeLayout(False)
            Me.grpGroup.PerformLayout()
            Me.cmbGroupField.get_Properties.EndInit()
            Me.cmbGroupIntervall.get_Properties.EndInit()
            Me.PanelChartParameters.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.chkShowLabel.get_Properties.EndInit()
            Me.PivotGrid1.EndInit()
            Me.XtraTabControl1.EndInit()
            Me.XtraTabControl1.ResumeLayout(False)
            Me.tabPivotGrid.ResumeLayout(False)
            Me.tabChart.ResumeLayout(False)
            diagram.EndInit()
            series.EndInit()
            series2.EndInit()
            Me.ChartControl1.EndInit()
            Me.hideContainerLeft.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Private Sub InitSortComboBoxes()
            Dim enumerator As IEnumerator
            Me.cmbSortField.get_Properties.get_Items.Clear()
            Me.cmbSortByField.get_Properties.get_Items.Clear()
            Try
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As PivotGridField = DirectCast(enumerator.Current, PivotGridField)
                    If (IIf(((current.get_Area Is 0) AndAlso current.get_Visible), 1, 0) <> 0) Then
                        Me.cmbSortField.get_Properties.get_Items.Add(current.get_FieldName)
                    End If
                    If (IIf(((current.get_Area Is 3) AndAlso current.get_Visible), 1, 0) <> 0) Then
                        Me.cmbSortByField.get_Properties.get_Items.Add(current.get_FieldName)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Private Sub InitSummaryComboBoxes()
            Dim enumerator As IEnumerator
            Dim str As String = (Me.cmbSummaryField.get_Text & "")
            Me.cmbSummaryField.get_Properties.get_Items.Clear()
            Try
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As PivotGridField = DirectCast(enumerator.Current, PivotGridField)
                    If (IIf(((current.get_Area Is 3) AndAlso current.get_Visible), 1, 0) <> 0) Then
                        Me.cmbSummaryField.get_Properties.get_Items.Add(current.get_FieldName)
                        Me.SetFieldCaption(current)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            If Information.IsNothing(Me.PivotGrid1.get_Fields.FieldByName(Conversions.ToString(Me.cmbSummaryField.get_EditValue))) Then
                Me.cmbSummaryField.set_SelectedIndex(0)
            End If
        End Sub

        Private Sub InitSummaryTypeComboBoxes()
            Dim enumerator As IEnumerator
            Dim values As Array = Enum.GetValues(GetType(PivotSummaryType))
            Try
                enumerator = values.GetEnumerator
                Do While enumerator.MoveNext
                    Dim type As PivotSummaryType = DirectCast(Conversions.ToInteger(enumerator.Current), PivotSummaryType)
                    Me.cmbSummaryType.get_Properties.get_Items.Add(New ImageComboBoxItem(type.ToString, type, -1))
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Private Sub InitTopComboBoxes()
            Dim enumerator As IEnumerator
            Me.cmbTopField.get_Properties.get_Items.Clear()
            Try
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As PivotGridField = DirectCast(enumerator.Current, PivotGridField)
                    If (IIf(((current.get_Area Is 0) AndAlso current.get_Visible), 1, 0) <> 0) Then
                        Me.cmbTopField.get_Properties.get_Items.Add(current.get_FieldName)
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Private Sub InitTotalPositionComboBoxes()
            Dim enumerator As IEnumerator
            Dim values As Array = Enum.GetValues(GetType(PivotTotalsLocation))
            Try
                enumerator = values.GetEnumerator
                Do While enumerator.MoveNext
                    Dim location As PivotTotalsLocation = DirectCast(Conversions.ToInteger(enumerator.Current), PivotTotalsLocation)
                    Me.icbTotalsLocations.get_Properties.get_Items.Add(New ImageComboBoxItem(location.ToString, location, -1))
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.icbTotalsLocations.set_EditValue(Me.PivotGrid1.get_OptionsView.get_TotalsLocation)
        End Sub

        Public Sub LoadAnalyze(ByVal AnalyzeID As Integer)
            Me.LoadAnalyzeTable(AnalyzeID)
            If (Me.mvarDS.Tables.Item("generalanalyze1").Rows.Count = 0) Then
                Interaction.MsgBox("Sorry this analyze does not exist anymore. Deleting database entry.", MsgBoxStyle.OkOnly, Nothing)
                Me.DeleteAnalyze(AnalyzeID)
            Else
                Dim enumerator As IEnumerator
                Dim row As DataRow = Me.mvarDS.Tables.Item("generalanalyze1").Rows.Item(0)
                Me.PivotGrid1.get_OptionsView.set_ShowColumnGrandTotals(Conversions.ToBoolean(row.Item("ColGrandTotal")))
                Me.PivotGrid1.get_OptionsView.set_ShowColumnTotals(Conversions.ToBoolean(row.Item("ColTotal")))
                Me.PivotGrid1.get_OptionsView.set_ShowGrandTotalsForSingleValues(Conversions.ToBoolean(row.Item("GrandTotalSingle")))
                Me.PivotGrid1.get_OptionsView.set_ShowRowGrandTotals(Conversions.ToBoolean(row.Item("RowGrandTotal")))
                Me.PivotGrid1.get_OptionsView.set_ShowRowTotals(Conversions.ToBoolean(row.Item("RowTotal")))
                Me.PivotGrid1.get_OptionsView.set_ShowTotalsForSingleValues(Conversions.ToBoolean(row.Item("TotalSingle")))
                Me.seTop.set_EditValue(Nothing)
                Me.cmbTopField.set_EditValue(Nothing)
                Try
                    enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As PivotGridField = DirectCast(enumerator.Current, PivotGridField)
                        Dim view2 As New DataView(Me.mvarDS.Tables.Item("generalanalyzefield"), ("FieldName = '" & current.get_FieldName & "' "), "", DataViewRowState.CurrentRows)
                        If (view2.Count = 1) Then
                            Dim enumerator2 As IEnumerator
                            Dim view As DataRowView = view2.Item(0)
                            current.set_Area(DirectCast(Conversions.ToInteger(view.Item("Area")), PivotArea))
                            current.set_TopValueCount(Conversions.ToInteger(view.Item("TopValueCount")))
                            If Operators.ConditionalCompareObjectNotEqual(view.Item("TopValueCount"), 0, False) Then
                                Me.seTop.set_EditValue(RuntimeHelpers.GetObjectValue(view.Item("TopValueCount")))
                                Me.cmbTopField.set_EditValue(current.get_FieldName)
                            End If
                            current.set_TopValueShowOthers(Conversions.ToBoolean(view.Item("TopValueShowOthers")))
                            current.set_Caption(Conversions.ToString(view.Item("FieldCaption")))
                            current.set_GroupInterval(DirectCast(Conversions.ToInteger(view.Item("GroupIntervall")), PivotGroupInterval))
                            Try
                                enumerator2 = Me.PivotGrid1.get_Fields.GetEnumerator
                                Do While enumerator2.MoveNext
                                    Dim field2 As PivotGridField = DirectCast(enumerator2.Current, PivotGridField)
                                    If Operators.ConditionalCompareObjectEqual(field2.get_FieldName, view.Item("SortBySummaryField"), False) Then
                                        current.get_SortBySummaryInfo.set_Field(field2)
                                        Me.cmbSortField.set_EditValue(current.get_FieldName)
                                        Me.cmbSortByField.set_EditValue(RuntimeHelpers.GetObjectValue(view.Item("SortBySummaryField")))
                                    End If
                                Loop
                            Finally
                                If TypeOf enumerator2 Is IDisposable Then
                                    TryCast(enumerator2, IDisposable).Dispose()
                                End If
                            End Try
                            current.set_Visible(Conversions.ToBoolean(view.Item("FieldVisible")))
                            current.set_SummaryType(DirectCast(Conversions.ToInteger(view.Item("SummaryType")), PivotSummaryType))
                            current.set_SortOrder(DirectCast(Conversions.ToInteger(view.Item("SortOrder")), PivotSortOrder))
                            Dim i As Integer
                            For i = 0 To Me.clbOptions.get_ItemCount - 1
                                Me.clbOptions.SetItemChecked(i, SetOptions.OptionValueByString(Me.clbOptions.GetItemText(i), Me.PivotGrid1.get_OptionsView))
                            Next i
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
        End Sub

        Public Sub LoadAnalyzeDetailTable(ByVal AnalyzeID As Integer)
            Dim sQLTxt As String = ("SELECT * FROM generalanalyzefield WHERE AnalyzeID = " & Conversions.ToString(AnalyzeID) & " ORDER BY FieldName ")
            Me.mvarDS.Tables.Item("generalanalyzefield").Clear()
            Me.BKGlobal.Cls1.FillDataSet(Me.mvarDS.Tables.Item("generalanalyzefield"), sQLTxt, True, False)
        End Sub

        Public Sub LoadAnalyzeList()
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generalanalyze WHERE MenuID = ", Conversions.ToString(Me.MenuID), " AND ( UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " OR AnalyzeID < 0 ) ORDER BY Name "})
            Me.mvarDS.Tables.Item("generalanalyze").Clear()
            Me.BKGlobal.Cls1.FillDataSet(Me.mvarDS.Tables.Item("generalanalyze"), sQLTxt, True, False)
        End Sub

        Public Sub LoadAnalyzeTable(ByVal AnalyzeID As Integer)
            Dim sQLTxt As String = ("SELECT * FROM generalanalyze WHERE AnalyzeID = " & Conversions.ToString(AnalyzeID))
            Me.mvarDS.Tables.Item("generalanalyze1").Clear()
            Me.BKGlobal.Cls1.FillDataSet(Me.mvarDS.Tables.Item("generalanalyze1"), sQLTxt, True, False)
            Me.LoadAnalyzeDetailTable(AnalyzeID)
        End Sub

        Public Sub MakeCommon(ByVal AnalyzeID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            If ((AnalyzeID > 0) AndAlso (Interaction.MsgBox(Me.BKGlobal.GetMsg(&H26, Me.SessionInfo.UserLang, True), MsgBoxStyle.OkCancel, Nothing) <> MsgBoxResult.Cancel)) Then
                Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("NEGAnalyzeID"))
                Dim sQLtxt As String = String.Concat(New String() {"UPDATE generalanalyze SET AnalyzeID = ", Conversions.ToString(num), ", UserID = 0  WHERE AnalyzeID = ", Conversions.ToString(AnalyzeID), " "})
                ClsDs.ExecuteNonQuery(sQLtxt, True)
            End If
        End Sub

        Private Sub PivotGrid1_CellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs)
            Dim form As New Form
            form.Text = "Drill Down Form"
            form.StartPosition = FormStartPosition.CenterParent
            Dim grid As New DataGrid
            grid.Parent = form
            grid.Dock = DockStyle.Fill
            grid.DataSource = e.CreateDrillDownDataSource
            form.Width = 520
            form.Height = 300
            form.ShowDialog()
            form.Dispose()
        End Sub

        Public Sub SaveAnalyze()
            Dim row As DataRow
            Dim num As Integer
            Dim enumerator As IEnumerator
            Dim analyzeName As String = ""
            Dim analyzeDesc As String = ""
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Me.cmbName.get_EditValue, ""), "", False) Then
                Dim analyze As New frmDialogNewAnalyze
                analyze.ShowDialog(Me.ParentForm)
                If (analyze.DialogResult = DialogResult.Cancel) Then
                    Return
                End If
                analyzeName = analyze.AnalyzeName
                analyzeDesc = analyze.AnalyzeDesc
                num = Conversions.ToInteger(Me.BKGlobal.GetNextID("AnalyzeID"))
            ElseIf (Interaction.MsgBox(("Do you want to overwrite Analyze : " & Me.cmbName.get_Text), MsgBoxStyle.YesNo, "Overwrite Confirmation") = MsgBoxResult.Yes) Then
                analyzeName = Me.cmbName.get_Text
                num = Conversions.ToInteger(Me.cmbName.get_EditValue)
            Else
                Return
            End If
            Me.DeleteAnalyzeDetail(num)
            Me.LoadAnalyzeTable(num)
            If (Me.mvarDS.Tables.Item("generalanalyze1").Rows.Count = 0) Then
                row = Me.mvarDS.Tables.Item("generalanalyze1").NewRow
                row.Item("AnalyzeID") = num
                row.Item("UserID") = Me.SessionInfo.UserID
                row.Item("MenuID") = Me.MenuID
                row.Item("Name") = analyzeName
                row.Item("Description") = analyzeDesc
                Me.mvarDS.Tables.Item("generalanalyze1").Rows.Add(row)
            Else
                row = Me.mvarDS.Tables.Item("generalanalyze1").Rows.Item(0)
            End If
            row.Item("ColGrandTotal") = Me.PivotGrid1.get_OptionsView.get_ShowColumnGrandTotals
            row.Item("ColTotal") = Me.PivotGrid1.get_OptionsView.get_ShowColumnTotals
            row.Item("GrandTotalSingle") = Me.PivotGrid1.get_OptionsView.get_ShowGrandTotalsForSingleValues
            row.Item("RowGrandTotal") = Me.PivotGrid1.get_OptionsView.get_ShowRowGrandTotals
            row.Item("RowTotal") = Me.PivotGrid1.get_OptionsView.get_ShowRowTotals
            row.Item("TotalSingle") = Me.PivotGrid1.get_OptionsView.get_ShowTotalsForSingleValues
            Me.LoadAnalyzeDetailTable(num)
            Try
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As PivotGridField = DirectCast(enumerator.Current, PivotGridField)
                    Dim row2 As DataRow = Me.mvarDS.Tables.Item("generalanalyzefield").NewRow
                    row2.Item("AnalyzeID") = num
                    row2.Item("FieldName") = current.get_FieldName
                    row2.Item("Area") = current.get_Area
                    row2.Item("TopValueCount") = current.get_TopValueCount
                    row2.Item("TopValueShowOthers") = current.get_TopValueShowOthers
                    row2.Item("FieldCaption") = current.get_Caption
                    row2.Item("SortOrder") = current.get_SortOrder
                    row2.Item("GroupIntervall") = current.get_GroupInterval
                    If Not Information.IsNothing(current.get_SortBySummaryInfo.get_Field) Then
                        row2.Item("SortBySummaryField") = current.get_SortBySummaryInfo.get_Field.get_FieldName
                    Else
                        row2.Item("SortBySummaryField") = ""
                    End If
                    row2.Item("FieldVisible") = current.get_Visible
                    row2.Item("SummaryType") = current.get_SummaryType
                    Me.mvarDS.Tables.Item("generalanalyzefield").Rows.Add(row2)
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Me.BKGlobal.Cls1.UpdateDataSource(Me.mvarDS.Tables.Item("generalanalyze1"), "SELECT * FROM generalanalyze ", True)
            Me.BKGlobal.Cls1.UpdateDataSource(Me.mvarDS.Tables.Item("generalanalyzefield"), "SELECT * FROM generalanalyzefield ", True)
            Me.LoadAnalyzeList()
        End Sub

        Private Function SendToUSer(ByVal AnalyzeID As Integer) As Integer
            Dim num3 As Integer
            If (AnalyzeID = 0) Then
                Return 0
            End If
            Dim user As New frmDialogSelectUser(Me.SessionInfo)
            Dim set As New clsDataSet(Me.SessionInfo)
            user.ShowDialog(Me.ParentForm)
            If (user.DialogResult <> DialogResult.OK) Then
                Return num3
            End If
            Dim num2 As Integer = Conversions.ToInteger(user.SelectedUserID)
            If (num2 = Me.SessionInfo.UserID) Then
                Return 0
            End If
            Dim num As Integer = Me.CopyAnalyze(AnalyzeID)
            If (num = 0) Then
                Return num3
            End If
            Dim sQLtxt As String = ("UPDATE generalanalyze SET UserID = " & Conversions.ToString(num2) & " WHERE AnalyzeID = " & Conversions.ToString(num))
            ClsDs.ExecuteNonQuery(sQLtxt, True)
            Return num
        End Function

        Private Sub SetFieldCaption(ByVal field As PivotGridField)
            field.set_Caption(String.Format("{0}({1})", field.get_FieldName, field.get_SummaryType))
            If (field.get_SummaryType Is 0) Then
                field.get_CellFormat.set_FormatString("")
            Else
                field.get_CellFormat.set_FormatString(field.get_ValueFormat.get_FormatString)
            End If
            If (Me.PivotGrid1.get_OptionsDataField.get_Area Is 1) Then
                field.BestFit
            End If
        End Sub

        Private Sub SetFieldFont(ByVal field As PivotGridField)
            Dim enumerator As IEnumerator
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As PivotGridField = DirectCast(enumerator.Current, PivotGridField)
                    If (Not current Is field) Then
                        If current.get_Appearance.get_Header.get_Font.Bold Then
                            current.get_Appearance.get_Header.set_Font(New Font(current.get_Appearance.get_Header.get_Font, FontStyle.Regular))
                        End If
                    Else
                        current.get_Appearance.get_Header.set_Font(New Font(current.get_Appearance.get_Header.get_Font, FontStyle.Bold))
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        End Sub

        Public Sub SetFields()
            Dim enumerator As IEnumerator
            Me.PivotGrid1.RetrieveFields
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As PivotGridField = DirectCast(enumerator.Current, PivotGridField)
                    current.get_Options.set_ShowInCustomizationForm(True)
                    current.set_Visible(False)
                    current.get_CellFormat.set_FormatType(3)
                    current.get_CellFormat.set_FormatString("N2")
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        End Sub

        Private Sub SetFieldTop()
            Dim enumerator As IEnumerator
            Dim expression As PivotGridField = Me.PivotGrid1.get_Fields.FieldByName(Me.cmbTopField.get_Text)
            Try 
                enumerator = Me.PivotGrid1.get_Fields.GetEnumerator
                Do While enumerator.MoveNext
                    expression = DirectCast(enumerator.Current, PivotGridField)
                    If Operators.ConditionalCompareObjectEqual(expression.get_FieldName, Me.cmbTopField.get_EditValue, False) Then
                        goto Label_0087
                    End If
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator,IDisposable).Dispose
                End If
            End Try
        Label_0087:
            If (Not Information.IsNothing(expression) AndAlso (expression.get_Area Is 0)) Then
                expression.set_TopValueCount(Convert.ToInt32(Me.seTop.get_Value))
                expression.set_TopValueShowOthers(Me.ceTopValuesShowOthers.get_Checked)
            End If
        End Sub

        Private Sub seTop_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.SetFieldTop
        End Sub

        Private Sub StartExport()
            Thread.Sleep(400)
            If Not Me.stopThread Then
                Dim up As New frmProgressPopUp
                up.Show
                Try 
                    Do While Not Me.stopThread
                        Application.DoEvents
                        Thread.Sleep(100)
                    Loop
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    ProjectData.ClearProjectError
                End Try
                up.Dispose
            End If
        End Sub

        Private Sub ucPivotGrid_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.AddSummaryOptions
            Me.InitSummaryTypeComboBoxes
            Me.InitGrpComboBoxes
            Me.InitTotalPositionComboBoxes
            Me.MenuID = Conversions.ToInteger(Me.ParentForm.Tag)
            If Not Information.IsNothing(Me.SessionInfo) Then
                Me.LoadAnalyzeList
            End If
        End Sub


        ' Properties
        Public Overridable Property Bar1 As Bar
            Get
                Return Me._Bar1
            End Get
            Set(ByVal WithEventsValue As Bar)
                Me._Bar1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlBottom As BarDockControl
            Get
                Return Me._barDockControlBottom
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlBottom = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlLeft As BarDockControl
            Get
                Return Me._barDockControlLeft
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlLeft = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlRight As BarDockControl
            Get
                Return Me._barDockControlRight
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlRight = WithEventsValue
            End Set
        End Property

        Friend Overridable Property barDockControlTop As BarDockControl
            Get
                Return Me._barDockControlTop
            End Get
            Set(ByVal WithEventsValue As BarDockControl)
                Me._barDockControlTop = WithEventsValue
            End Set
        End Property

        Public Overridable Property BarManager1 As BarManager
            Get
                Return Me._BarManager1
            End Get
            Set(ByVal WithEventsValue As BarManager)
                Me._BarManager1 = WithEventsValue
            End Set
        End Property

        Public Property BKGlobal As clsGlobal
            Get
                Return Me.mvarBKGlobal
            End Get
            Set(ByVal Value As clsGlobal)
                Me.mvarBKGlobal = Value
            End Set
        End Property

        Friend Overridable Property btnArea As SimpleButton
            Get
                Return Me._btnArea
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                Me._btnArea = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnBar As SimpleButton
            Get
                Return Me._btnBar
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                Me._btnBar = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnBiggerCaps As BarButtonItem
            Get
                Return Me._btnBiggerCaps
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnBiggerCaps Is Nothing) Then
                    Me._btnBiggerCaps.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnBiggerCaps_ItemClick, IntPtr)))
                End If
                Me._btnBiggerCaps = WithEventsValue
                If (Not Me._btnBiggerCaps Is Nothing) Then
                    Me._btnBiggerCaps.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnBiggerCaps_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnDelete As BarButtonItem
            Get
                Return Me._btnDelete
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnDelete Is Nothing) Then
                    Me._btnDelete.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDelete_ItemClick, IntPtr)))
                End If
                Me._btnDelete = WithEventsValue
                If (Not Me._btnDelete Is Nothing) Then
                    Me._btnDelete.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDelete_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnEdit As BarButtonItem
            Get
                Return Me._btnEdit
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnEdit Is Nothing) Then
                    Me._btnEdit.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEdit_ItemClick, IntPtr)))
                End If
                Me._btnEdit = WithEventsValue
                If (Not Me._btnEdit Is Nothing) Then
                    Me._btnEdit.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEdit_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnExport As BarButtonItem
            Get
                Return Me._btnExport
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnExport Is Nothing) Then
                    Me._btnExport.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnExport_ItemClick, IntPtr)))
                End If
                Me._btnExport = WithEventsValue
                If (Not Me._btnExport Is Nothing) Then
                    Me._btnExport.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnExport_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnLines As SimpleButton
            Get
                Return Me._btnLines
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                Me._btnLines = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnLoad As BarButtonItem
            Get
                Return Me._btnLoad
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnLoad Is Nothing) Then
                    Me._btnLoad.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnLoad_ItemClick, IntPtr)))
                End If
                Me._btnLoad = WithEventsValue
                If (Not Me._btnLoad Is Nothing) Then
                    Me._btnLoad.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnLoad_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnMakeCommon As BarButtonItem
            Get
                Return Me._btnMakeCommon
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnMakeCommon Is Nothing) Then
                    Me._btnMakeCommon.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeCommon_ItemClick, IntPtr)))
                End If
                Me._btnMakeCommon = WithEventsValue
                If (Not Me._btnMakeCommon Is Nothing) Then
                    Me._btnMakeCommon.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnMakeCommon_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnNew As BarButtonItem
            Get
                Return Me._btnNew
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnNew Is Nothing) Then
                    Me._btnNew.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNew_ItemClick, IntPtr)))
                End If
                Me._btnNew = WithEventsValue
                If (Not Me._btnNew Is Nothing) Then
                    Me._btnNew.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNew_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnPie As SimpleButton
            Get
                Return Me._btnPie
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                Me._btnPie = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnPrint As BarButtonItem
            Get
                Return Me._btnPrint
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnPrint Is Nothing) Then
                    Me._btnPrint.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrint_ItemClick, IntPtr)))
                End If
                Me._btnPrint = WithEventsValue
                If (Not Me._btnPrint Is Nothing) Then
                    Me._btnPrint.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrint_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnRefreshChart As SimpleButton
            Get
                Return Me._btnRefreshChart
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                Me._btnRefreshChart = WithEventsValue
            End Set
        End Property

        Friend Overridable Property btnSave As BarButtonItem
            Get
                Return Me._btnSave
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSave Is Nothing) Then
                    Me._btnSave.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSave_ItemClick, IntPtr)))
                End If
                Me._btnSave = WithEventsValue
                If (Not Me._btnSave Is Nothing) Then
                    Me._btnSave.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSave_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnSendToUSer As BarButtonItem
            Get
                Return Me._btnSendToUSer
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSendToUSer Is Nothing) Then
                    Me._btnSendToUSer.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendToUSer_ItemClick, IntPtr)))
                End If
                Me._btnSendToUSer = WithEventsValue
                If (Not Me._btnSendToUSer Is Nothing) Then
                    Me._btnSendToUSer.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSendToUSer_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnSmallerCaps As BarButtonItem
            Get
                Return Me._btnSmallerCaps
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnSmallerCaps Is Nothing) Then
                    Me._btnSmallerCaps.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSmallerCaps_ItemClick, IntPtr)))
                End If
                Me._btnSmallerCaps = WithEventsValue
                If (Not Me._btnSmallerCaps Is Nothing) Then
                    Me._btnSmallerCaps.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSmallerCaps_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property btnStyleCondition As BarButtonItem
            Get
                Return Me._btnStyleCondition
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not Me._btnStyleCondition Is Nothing) Then
                    Me._btnStyleCondition.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnStyleCondition_ItemClick, IntPtr)))
                End If
                Me._btnStyleCondition = WithEventsValue
                If (Not Me._btnStyleCondition Is Nothing) Then
                    Me._btnStyleCondition.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnStyleCondition_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property ceTopValuesShowOthers As CheckEdit
            Get
                Return Me._ceTopValuesShowOthers
            End Get
            Set(ByVal WithEventsValue As CheckEdit)
                If (Not Me._ceTopValuesShowOthers Is Nothing) Then
                    Me._ceTopValuesShowOthers.remove_CheckedChanged(New EventHandler(AddressOf Me.ceTopValuesShowOthers_CheckedChanged))
                End If
                Me._ceTopValuesShowOthers = WithEventsValue
                If (Not Me._ceTopValuesShowOthers Is Nothing) Then
                    Me._ceTopValuesShowOthers.add_CheckedChanged(New EventHandler(AddressOf Me.ceTopValuesShowOthers_CheckedChanged))
                End If
            End Set
        End Property

        Friend Overridable Property ChartControl1 As ChartControl
            Get
                Return Me._ChartControl1
            End Get
            Set(ByVal WithEventsValue As ChartControl)
                Me._ChartControl1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property chkShowLabel As CheckEdit
            Get
                Return Me._chkShowLabel
            End Get
            Set(ByVal WithEventsValue As CheckEdit)
                Me._chkShowLabel = WithEventsValue
            End Set
        End Property

        Friend Overridable Property clbOptions As CheckedListBoxControl
            Get
                Return Me._clbOptions
            End Get
            Set(ByVal WithEventsValue As CheckedListBoxControl)
                If (Not Me._clbOptions Is Nothing) Then
                    Me._clbOptions.remove_ItemCheck(New ItemCheckEventHandler(Me, DirectCast(Me.clbOptions_ItemCheck, IntPtr)))
                End If
                Me._clbOptions = WithEventsValue
                If (Not Me._clbOptions Is Nothing) Then
                    Me._clbOptions.add_ItemCheck(New ItemCheckEventHandler(Me, DirectCast(Me.clbOptions_ItemCheck, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property cmbExportTo As ComboBoxEdit
            Get
                Return Me._cmbExportTo
            End Get
            Set(ByVal WithEventsValue As ComboBoxEdit)
                Me._cmbExportTo = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmbGroupField As ComboBoxEdit
            Get
                Return Me._cmbGroupField
            End Get
            Set(ByVal WithEventsValue As ComboBoxEdit)
                If (Not Me._cmbGroupField Is Nothing) Then
                    RemoveHandler Me._cmbGroupField.Enter, New EventHandler(AddressOf Me.cmbGroupField_Enter)
                End If
                Me._cmbGroupField = WithEventsValue
                If (Not Me._cmbGroupField Is Nothing) Then
                    AddHandler Me._cmbGroupField.Enter, New EventHandler(AddressOf Me.cmbGroupField_Enter)
                End If
            End Set
        End Property

        Friend Overridable Property cmbGroupIntervall As ComboBoxEdit
            Get
                Return Me._cmbGroupIntervall
            End Get
            Set(ByVal WithEventsValue As ComboBoxEdit)
                If (Not Me._cmbGroupIntervall Is Nothing) Then
                    Me._cmbGroupIntervall.remove_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbGroupIntervall_SelectedIndexChanged))
                End If
                Me._cmbGroupIntervall = WithEventsValue
                If (Not Me._cmbGroupIntervall Is Nothing) Then
                    Me._cmbGroupIntervall.add_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbGroupIntervall_SelectedIndexChanged))
                End If
            End Set
        End Property

        Friend Overridable Property cmbName As LookUpEdit
            Get
                Return Me._cmbName
            End Get
            Set(ByVal WithEventsValue As LookUpEdit)
                Me._cmbName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmbSortByField As ComboBoxEdit
            Get
                Return Me._cmbSortByField
            End Get
            Set(ByVal WithEventsValue As ComboBoxEdit)
                If (Not Me._cmbSortByField Is Nothing) Then
                    Me._cmbSortByField.remove_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbSortByField_SelectedIndexChanged))
                    Me._cmbSortByField.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbSortByField_ButtonClick, IntPtr)))
                End If
                Me._cmbSortByField = WithEventsValue
                If (Not Me._cmbSortByField Is Nothing) Then
                    Me._cmbSortByField.add_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbSortByField_SelectedIndexChanged))
                    Me._cmbSortByField.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbSortByField_ButtonClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property cmbSortField As ComboBoxEdit
            Get
                Return Me._cmbSortField
            End Get
            Set(ByVal WithEventsValue As ComboBoxEdit)
                If (Not Me._cmbSortField Is Nothing) Then
                    Me._cmbSortField.remove_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbSortField_SelectedIndexChanged))
                    RemoveHandler Me._cmbSortField.Enter, New EventHandler(AddressOf Me.cmbSortField_Enter)
                End If
                Me._cmbSortField = WithEventsValue
                If (Not Me._cmbSortField Is Nothing) Then
                    Me._cmbSortField.add_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbSortField_SelectedIndexChanged))
                    AddHandler Me._cmbSortField.Enter, New EventHandler(AddressOf Me.cmbSortField_Enter)
                End If
            End Set
        End Property

        Friend Overridable Property cmbSummaryField As ComboBoxEdit
            Get
                Return Me._cmbSummaryField
            End Get
            Set(ByVal WithEventsValue As ComboBoxEdit)
                If (Not Me._cmbSummaryField Is Nothing) Then
                    Me._cmbSummaryField.remove_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbSummaryField_SelectedIndexChanged))
                    RemoveHandler Me._cmbSummaryField.Enter, New EventHandler(AddressOf Me.cmbSummaryField_Enter)
                End If
                Me._cmbSummaryField = WithEventsValue
                If (Not Me._cmbSummaryField Is Nothing) Then
                    Me._cmbSummaryField.add_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbSummaryField_SelectedIndexChanged))
                    AddHandler Me._cmbSummaryField.Enter, New EventHandler(AddressOf Me.cmbSummaryField_Enter)
                End If
            End Set
        End Property

        Friend Overridable Property cmbSummaryType As ImageComboBoxEdit
            Get
                Return Me._cmbSummaryType
            End Get
            Set(ByVal WithEventsValue As ImageComboBoxEdit)
                If (Not Me._cmbSummaryType Is Nothing) Then
                    Me._cmbSummaryType.remove_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbSummaryType_SelectedIndexChanged))
                End If
                Me._cmbSummaryType = WithEventsValue
                If (Not Me._cmbSummaryType Is Nothing) Then
                    Me._cmbSummaryType.add_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbSummaryType_SelectedIndexChanged))
                End If
            End Set
        End Property

        Friend Overridable Property cmbTopField As ComboBoxEdit
            Get
                Return Me._cmbTopField
            End Get
            Set(ByVal WithEventsValue As ComboBoxEdit)
                If (Not Me._cmbTopField Is Nothing) Then
                    Me._cmbTopField.remove_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbTopField_ButtonClick, IntPtr)))
                    Me._cmbTopField.remove_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbTopField_SelectedIndexChanged))
                    RemoveHandler Me._cmbTopField.Enter, New EventHandler(AddressOf Me.cmbTopField_Enter)
                End If
                Me._cmbTopField = WithEventsValue
                If (Not Me._cmbTopField Is Nothing) Then
                    Me._cmbTopField.add_ButtonClick(New ButtonPressedEventHandler(Me, DirectCast(Me.cmbTopField_ButtonClick, IntPtr)))
                    Me._cmbTopField.add_SelectedIndexChanged(New EventHandler(AddressOf Me.cmbTopField_SelectedIndexChanged))
                    AddHandler Me._cmbTopField.Enter, New EventHandler(AddressOf Me.cmbTopField_Enter)
                End If
            End Set
        End Property

        Friend Overridable Property DockManager1 As DockManager
            Get
                Return Me._DockManager1
            End Get
            Set(ByVal WithEventsValue As DockManager)
                Me._DockManager1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DockPanel1_Container As ControlContainer
            Get
                Return Me._DockPanel1_Container
            End Get
            Set(ByVal WithEventsValue As ControlContainer)
                Me._DockPanel1_Container = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DockPanel2_Container As ControlContainer
            Get
                Return Me._DockPanel2_Container
            End Get
            Set(ByVal WithEventsValue As ControlContainer)
                Me._DockPanel2_Container = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpGroup As GroupBox
            Get
                Return Me._grpGroup
            End Get
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpMisc As GroupBox
            Get
                Return Me._grpMisc
            End Get
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpMisc = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpPrintSaveLoad As GroupBox
            Get
                Return Me._grpPrintSaveLoad
            End Get
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpPrintSaveLoad = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpSortSummary As GroupBox
            Get
                Return Me._grpSortSummary
            End Get
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpSortSummary = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpSummary As GroupBox
            Get
                Return Me._grpSummary
            End Get
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpSummary = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpTop As GroupBox
            Get
                Return Me._grpTop
            End Get
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpTop = WithEventsValue
            End Set
        End Property

        Friend Overridable Property hideContainerLeft As AutoHideContainer
            Get
                Return Me._hideContainerLeft
            End Get
            Set(ByVal WithEventsValue As AutoHideContainer)
                Me._hideContainerLeft = WithEventsValue
            End Set
        End Property

        Friend Overridable Property icbTotalsLocations As ImageComboBoxEdit
            Get
                Return Me._icbTotalsLocations
            End Get
            Set(ByVal WithEventsValue As ImageComboBoxEdit)
                If (Not Me._icbTotalsLocations Is Nothing) Then
                    Me._icbTotalsLocations.remove_SelectedIndexChanged(New EventHandler(AddressOf Me.icbTotalsLocations_SelectedIndexChanged))
                End If
                Me._icbTotalsLocations = WithEventsValue
                If (Not Me._icbTotalsLocations Is Nothing) Then
                    Me._icbTotalsLocations.add_SelectedIndexChanged(New EventHandler(AddressOf Me.icbTotalsLocations_SelectedIndexChanged))
                End If
            End Set
        End Property

        Friend Overridable Property Label1 As Label
            Get
                Return Me._Label1
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._Label1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label2 As Label
            Get
                Return Me._Label2
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._Label2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property label3 As Label
            Get
                Return Me._label3
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._label3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label4 As Label
            Get
                Return Me._Label4
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._Label4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblExport As Label
            Get
                Return Me._lblExport
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblExport = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblGrpField As Label
            Get
                Return Me._lblGrpField
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblGrpField = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblGrpInterval As Label
            Get
                Return Me._lblGrpInterval
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblGrpInterval = WithEventsValue
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

        Friend Overridable Property lblSortByField As Label
            Get
                Return Me._lblSortByField
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblSortByField = WithEventsValue
            End Set
        End Property

        Friend Overridable Property mvarDS As dsAnalyze
            Get
                Return Me._mvarDS
            End Get
            Set(ByVal WithEventsValue As dsAnalyze)
                Me._mvarDS = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OpenFileDialog1 As OpenFileDialog
            Get
                Return Me._OpenFileDialog1
            End Get
            Set(ByVal WithEventsValue As OpenFileDialog)
                Me._OpenFileDialog1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PanelChartParameters As DockPanel
            Get
                Return Me._PanelChartParameters
            End Get
            Set(ByVal WithEventsValue As DockPanel)
                Me._PanelChartParameters = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PanelParameters As DockPanel
            Get
                Return Me._PanelParameters
            End Get
            Set(ByVal WithEventsValue As DockPanel)
                Me._PanelParameters = WithEventsValue
            End Set
        End Property

        Public Overridable Property PivotGrid1 As PivotGridControl
            Get
                Return Me._PivotGrid1
            End Get
            Set(ByVal WithEventsValue As PivotGridControl)
                If (Not Me._PivotGrid1 Is Nothing) Then
                    Me._PivotGrid1.remove_CellDoubleClick(New PivotCellEventHandler(Me, DirectCast(Me.PivotGrid1_CellDoubleClick, IntPtr)))
                End If
                Me._PivotGrid1 = WithEventsValue
                If (Not Me._PivotGrid1 Is Nothing) Then
                    Me._PivotGrid1.add_CellDoubleClick(New PivotCellEventHandler(Me, DirectCast(Me.PivotGrid1_CellDoubleClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property SaveFileDialog1 As SaveFileDialog
            Get
                Return Me._SaveFileDialog1
            End Get
            Set(ByVal WithEventsValue As SaveFileDialog)
                Me._SaveFileDialog1 = WithEventsValue
            End Set
        End Property

        Public Property SessionInfo As clsSessionInfo
            Get
                Return Me.mvarSessionInfo
            End Get
            Set(ByVal Value As clsSessionInfo)
                Me.mvarSessionInfo = Value
                Me.mvarBKGlobal = New clsGlobal(Me.mvarSessionInfo)
            End Set
        End Property

        Friend Overridable Property seTop As SpinEdit
            Get
                Return Me._seTop
            End Get
            Set(ByVal WithEventsValue As SpinEdit)
                If (Not Me._seTop Is Nothing) Then
                    Me._seTop.remove_EditValueChanged(New EventHandler(AddressOf Me.seTop_EditValueChanged))
                End If
                Me._seTop = WithEventsValue
                If (Not Me._seTop Is Nothing) Then
                    Me._seTop.add_EditValueChanged(New EventHandler(AddressOf Me.seTop_EditValueChanged))
                End If
            End Set
        End Property

        Friend Overridable Property SplitterControl1 As SplitterControl
            Get
                Return Me._SplitterControl1
            End Get
            Set(ByVal WithEventsValue As SplitterControl)
                Me._SplitterControl1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tabChart As XtraTabPage
            Get
                Return Me._tabChart
            End Get
            Set(ByVal WithEventsValue As XtraTabPage)
                Me._tabChart = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tabPivotGrid As XtraTabPage
            Get
                Return Me._tabPivotGrid
            End Get
            Set(ByVal WithEventsValue As XtraTabPage)
                Me._tabPivotGrid = WithEventsValue
            End Set
        End Property

        Friend Overridable Property XtraTabControl1 As XtraTabControl
            Get
                Return Me._XtraTabControl1
            End Get
            Set(ByVal WithEventsValue As XtraTabControl)
                Me._XtraTabControl1 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("Bar1")> _
        Private _Bar1 As Bar
        <AccessedThroughProperty("barDockControlBottom")> _
        Private _barDockControlBottom As BarDockControl
        <AccessedThroughProperty("barDockControlLeft")> _
        Private _barDockControlLeft As BarDockControl
        <AccessedThroughProperty("barDockControlRight")> _
        Private _barDockControlRight As BarDockControl
        <AccessedThroughProperty("barDockControlTop")> _
        Private _barDockControlTop As BarDockControl
        <AccessedThroughProperty("BarManager1")> _
        Private _BarManager1 As BarManager
        <AccessedThroughProperty("btnArea")> _
        Private _btnArea As SimpleButton
        <AccessedThroughProperty("btnBar")> _
        Private _btnBar As SimpleButton
        <AccessedThroughProperty("btnBiggerCaps")> _
        Private _btnBiggerCaps As BarButtonItem
        <AccessedThroughProperty("btnDelete")> _
        Private _btnDelete As BarButtonItem
        <AccessedThroughProperty("btnEdit")> _
        Private _btnEdit As BarButtonItem
        <AccessedThroughProperty("btnExport")> _
        Private _btnExport As BarButtonItem
        <AccessedThroughProperty("btnLines")> _
        Private _btnLines As SimpleButton
        <AccessedThroughProperty("btnLoad")> _
        Private _btnLoad As BarButtonItem
        <AccessedThroughProperty("btnMakeCommon")> _
        Private _btnMakeCommon As BarButtonItem
        <AccessedThroughProperty("btnNew")> _
        Private _btnNew As BarButtonItem
        <AccessedThroughProperty("btnPie")> _
        Private _btnPie As SimpleButton
        <AccessedThroughProperty("btnPrint")> _
        Private _btnPrint As BarButtonItem
        <AccessedThroughProperty("btnRefreshChart")> _
        Private _btnRefreshChart As SimpleButton
        <AccessedThroughProperty("btnSave")> _
        Private _btnSave As BarButtonItem
        <AccessedThroughProperty("btnSendToUSer")> _
        Private _btnSendToUSer As BarButtonItem
        <AccessedThroughProperty("btnSmallerCaps")> _
        Private _btnSmallerCaps As BarButtonItem
        <AccessedThroughProperty("btnStyleCondition")> _
        Private _btnStyleCondition As BarButtonItem
        <AccessedThroughProperty("ceTopValuesShowOthers")> _
        Private _ceTopValuesShowOthers As CheckEdit
        <AccessedThroughProperty("ChartControl1")> _
        Private _ChartControl1 As ChartControl
        <AccessedThroughProperty("chkShowLabel")> _
        Private _chkShowLabel As CheckEdit
        <AccessedThroughProperty("clbOptions")> _
        Private _clbOptions As CheckedListBoxControl
        <AccessedThroughProperty("cmbExportTo")> _
        Private _cmbExportTo As ComboBoxEdit
        <AccessedThroughProperty("cmbGroupField")> _
        Private _cmbGroupField As ComboBoxEdit
        <AccessedThroughProperty("cmbGroupIntervall")> _
        Private _cmbGroupIntervall As ComboBoxEdit
        <AccessedThroughProperty("cmbName")> _
        Private _cmbName As LookUpEdit
        <AccessedThroughProperty("cmbSortByField")> _
        Private _cmbSortByField As ComboBoxEdit
        <AccessedThroughProperty("cmbSortField")> _
        Private _cmbSortField As ComboBoxEdit
        <AccessedThroughProperty("cmbSummaryField")> _
        Private _cmbSummaryField As ComboBoxEdit
        <AccessedThroughProperty("cmbSummaryType")> _
        Private _cmbSummaryType As ImageComboBoxEdit
        <AccessedThroughProperty("cmbTopField")> _
        Private _cmbTopField As ComboBoxEdit
        <AccessedThroughProperty("DockManager1")> _
        Private _DockManager1 As DockManager
        <AccessedThroughProperty("DockPanel1_Container")> _
        Private _DockPanel1_Container As ControlContainer
        <AccessedThroughProperty("DockPanel2_Container")> _
        Private _DockPanel2_Container As ControlContainer
        <AccessedThroughProperty("grpGroup")> _
        Private _grpGroup As GroupBox
        <AccessedThroughProperty("grpMisc")> _
        Private _grpMisc As GroupBox
        <AccessedThroughProperty("grpPrintSaveLoad")> _
        Private _grpPrintSaveLoad As GroupBox
        <AccessedThroughProperty("grpSortSummary")> _
        Private _grpSortSummary As GroupBox
        <AccessedThroughProperty("grpSummary")> _
        Private _grpSummary As GroupBox
        <AccessedThroughProperty("grpTop")> _
        Private _grpTop As GroupBox
        <AccessedThroughProperty("hideContainerLeft")> _
        Private _hideContainerLeft As AutoHideContainer
        <AccessedThroughProperty("icbTotalsLocations")> _
        Private _icbTotalsLocations As ImageComboBoxEdit
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("label3")> _
        Private _label3 As Label
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label
        <AccessedThroughProperty("lblExport")> _
        Private _lblExport As Label
        <AccessedThroughProperty("lblGrpField")> _
        Private _lblGrpField As Label
        <AccessedThroughProperty("lblGrpInterval")> _
        Private _lblGrpInterval As Label
        <AccessedThroughProperty("lblName")> _
        Private _lblName As Label
        <AccessedThroughProperty("lblSortByField")> _
        Private _lblSortByField As Label
        <AccessedThroughProperty("mvarDS")> _
        Private _mvarDS As dsAnalyze
        <AccessedThroughProperty("OpenFileDialog1")> _
        Private _OpenFileDialog1 As OpenFileDialog
        <AccessedThroughProperty("PanelChartParameters")> _
        Private _PanelChartParameters As DockPanel
        <AccessedThroughProperty("PanelParameters")> _
        Private _PanelParameters As DockPanel
        <AccessedThroughProperty("PivotGrid1")> _
        Private _PivotGrid1 As PivotGridControl
        <AccessedThroughProperty("SaveFileDialog1")> _
        Private _SaveFileDialog1 As SaveFileDialog
        <AccessedThroughProperty("seTop")> _
        Private _seTop As SpinEdit
        <AccessedThroughProperty("SplitterControl1")> _
        Private _SplitterControl1 As SplitterControl
        <AccessedThroughProperty("tabChart")> _
        Private _tabChart As XtraTabPage
        <AccessedThroughProperty("tabPivotGrid")> _
        Private _tabPivotGrid As XtraTabPage
        <AccessedThroughProperty("XtraTabControl1")> _
        Private _XtraTabControl1 As XtraTabControl
        Private cls1 As clsDataSet
        Private components As IContainer
        Public MenuID As Integer
        Private mvarBKGlobal As clsGlobal
        Private mvarSessionInfo As clsSessionInfo
        Private stopThread As Boolean
        Private thread As Thread
    End Class
End Namespace

