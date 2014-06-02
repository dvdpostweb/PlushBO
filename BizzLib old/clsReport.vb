Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class clsReport
        ' Methods
        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.mvarBKGlobal = New clsGlobal(CurrentSessionInfo)
        End Sub

        Public Function CopyReport(ByVal ReportID As Integer) As Integer
            Dim set2 As New dsDefaultSet
            Dim set3 As New dsDefaultSet
            Dim ClsDs As New clsDataSet(Me.SessionInfo)
            If (ReportID = 0) Then
                Return 0
            End If
            Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
            ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
            If (set2.Tables.Item("generalreport").Rows.Count = 0) Then
                Return 0
            End If
            Dim nbreportID As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("ReportID"))
            Dim row2 As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
            Dim row As DataRow = set3.Tables.Item("generalreport").NewRow
            row.ItemArray = row2.ItemArray
            row.Item("ReportID") = nbreportID
            row.Item("DefaultReport") = 0
            row.Item("SystemReport") = 0
            row.Item("UserID") = Me.SessionInfo.UserID
            row.Item("Name") = Operators.ConcatenateObject("Copy of ", row2.Item("Name"))
            set3.Tables.Item("generalreport").Rows.Add(row)
            ClsDs.UpdateDataSource(set3.Tables.Item("generalreport"), sQLTxt, True)
            If (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row2.Item("ReportPath")), ReportID) & "\"), row2.Item("Name")), ".repx"))) AndAlso Directory.Exists(Me.GetReportPath(Conversions.ToString(row2.Item("ReportPath")), ReportID))) Then
                File.Copy(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row2.Item("ReportPath")), ReportID) & "\"), row2.Item("Name")), ".repx")), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), reportID) & "\"), row.Item("Name")), ".repx")))
            End If
            Return reportID
        End Function

        Public Function CreateNewReport(ByVal MenuID As Integer, ByVal OwnerForm As Form) As Integer
            Dim reportDesc As String
            Dim reportName As String
            Dim reportPath As String
            Dim set2 As New dsDefaultSet
            Dim ClsDs As New clsDataSet(Me.SessionInfo)
            Dim report As New frmDialogNewReport(Me.SessionInfo)
            Dim num As Integer = 0
            Dim flag As Boolean = True
            Do
                report.ShowDialog(OwnerForm)
                If (report.DialogResult = DialogResult.Cancel) Then
                    Return 0
                End If
                reportName = report.ReportName
                reportDesc = report.ReportDesc
                reportPath = report.ReportPath
                If (Not Directory.Exists((report.ReportPath & "")) And ((report.ReportPath & "") <> "")) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(&H42, "", True), MsgBoxStyle.Critical, Nothing)
                    flag = False
                End If
                If ((reportName & "") = "") Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(5, "", True), MsgBoxStyle.Critical, Nothing)
                    flag = False
                End If
            Loop While Not flag
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generalreport WHERE Name = '", reportName, "' AND ReportPath = '", reportPath, "'"})
            ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
            If (set2.Tables.Item("generalreport").Rows.Count > 0) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H41, "", True), MsgBoxStyle.Critical, Nothing)
                Return 0
            End If
            num = Conversions.ToInteger(Me.BKGlobal.GetNextID("ReportID"))
            sQLTxt = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(num))
            ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
            Dim row As DataRow = set2.Tables.Item("generalreport").NewRow
            row.Item("ReportID") = num
            row.Item("UserID") = Me.SessionInfo.UserID
            row.Item("MenuID") = MenuID
            row.Item("Name") = reportName
            row.Item("Description") = reportDesc
            row.Item("ReportPath") = reportPath
            row.Item("SystemReport") = 0
            set2.Tables.Item("generalreport").Rows.Add(row)
            ClsDs.UpdateDataSource(set2.Tables.Item("generalreport"), sQLTxt, True)
            Return num
        End Function

        Public Sub DeleteReport(ByVal ReportID As Integer)
            If (ReportID <> 0) Then
                If (Not Me.SessionInfo.CanModifyGlobalViews And (ReportID < 0)) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(&H3E, "", True), MsgBoxStyle.Critical, Nothing)
                Else
                    Dim set2 As New dsDefaultSet
                    Dim ClsDs As New clsDataSet(Me.SessionInfo)
                    Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
                    ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
                    If (set2.Tables.Item("generalreport").Rows.Count <> 0) Then
                        Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
                        If Operators.ConditionalCompareObjectEqual(row.Item("SystemReport"), 1, False) Then
                            Interaction.MsgBox(Me.BKGlobal.GetMsg(&H44, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                        ElseIf (Interaction.MsgBox(Me.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes) Then
                            Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))
                            If File.Exists(path) Then
                                File.Delete(path)
                            End If
                            row.Delete()
                            ClsDs.UpdateDataSource(set2.Tables.Item("generalreport"), sQLTxt, True)
                        End If
                    End If
                End If
            End If
        End Sub

        Public Sub DesignReport(ByVal ReportID As Integer, ByVal RptDS As DataSet)
            If (ReportID <> 0) Then
                If (Not Me.SessionInfo.CanModifyGlobalViews And (ReportID < 0)) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(&H3F, "", True), MsgBoxStyle.Critical, Nothing)
                Else
                    Dim set2 As New dsDefaultSet
                    Dim ClsDs As New clsDataSet(Me.SessionInfo)
                    Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
                    ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
                    If (set2.Tables.Item("generalreport").Rows.Count <> 0) Then
                        If Operators.ConditionalCompareObjectEqual(set2.Tables.Item("generalreport").Rows.Item(0).Item("SystemReport"), 1, False) Then
                            Interaction.MsgBox(Me.BKGlobal.GetMsg(&H43, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                        Else
                            Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
                            Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))
                            If File.Exists(path) Then
                                Dim report As New XtraReport
                                Dim ex As New XRDesignFormEx
                                report.LoadLayout(path)
                                report.set_DataSource(RptDS)
                                ex.OpenReport(report)
                                ex.set_FileName(path)
                                ex.Show()
                            Else
                                Dim report2 As New XtraReport
                                Dim ex2 As New XRDesignFormEx
                                report2.set_DataSource(RptDS)
                                ex2.OpenReport(report2)
                                ex2.set_FileName(path)
                                ex2.Show()
                            End If
                        End If
                    End If
                End If
            End If
        End Sub

        Public Sub DesignReport(ByVal ReportID As Integer, ByVal DS As DataSet, ByVal TableNames As String())
            If (ReportID <> 0) Then
                If (Not Me.SessionInfo.CanModifyGlobalViews And (ReportID < 0)) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(&H3F, "", True), MsgBoxStyle.Critical, Nothing)
                Else
                    Dim set2 As New dsDefaultSet
                    Dim set As New clsDataSet(Me.SessionInfo)
                    Dim set3 As New DataSet
                    Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
                    ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
                    If (set2.Tables.Item("generalreport").Rows.Count <> 0) Then
                        If Operators.ConditionalCompareObjectEqual(set2.Tables.Item("generalreport").Rows.Item(0).Item("SystemReport"), 1, False) Then
                            Interaction.MsgBox(Me.BKGlobal.GetMsg(&H43, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                        Else
                            Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
                            Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))
                            Dim str3 As String
                            For Each str3 In TableNames
                                set3.Tables.Add(DS.Tables.Item(str3).Copy)
                            Next
                            If File.Exists(path) Then
                                Dim report As New XtraReport
                                Dim ex As New XRDesignFormEx
                                report.LoadLayout(path)
                                report.set_DataSource(set3)
                                ex.OpenReport(report)
                                ex.set_FileName(path)
                                ex.Show()
                            Else
                                Dim report2 As New XtraReport
                                Dim ex2 As New XRDesignFormEx
                                report2.set_DataSource(set3)
                                ex2.OpenReport(report2)
                                ex2.set_FileName(path)
                                ex2.Show()
                            End If
                        End If
                    End If
                End If
            End If
        End Sub

        Public Sub DesignReport(ByVal ReportID As Integer, Optional ByVal Rows As DataRow() = Nothing, Optional ByVal DataTables As DataTable() = Nothing)
            If (ReportID <> 0) Then
                If (Not Me.SessionInfo.CanModifyGlobalViews And (ReportID < 0)) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(&H3F, "", True), MsgBoxStyle.Critical, Nothing)
                Else
                    Dim set2 As New dsDefaultSet
                    Dim set3 As New DataSet
                    Dim set As New clsDataSet(Me.SessionInfo)
                    Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
                    ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
                    If (set2.Tables.Item("generalreport").Rows.Count <> 0) Then
                        If Operators.ConditionalCompareObjectEqual(set2.Tables.Item("generalreport").Rows.Item(0).Item("SystemReport"), 1, False) Then
                            Interaction.MsgBox(Me.BKGlobal.GetMsg(&H43, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                        Else
                            Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
                            Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))
                            If Not Information.IsNothing(Rows) Then
                                Dim row2 As DataRow
                                For Each row2 In Rows
                                    set3.Tables.Add(row2.Table.Clone)
                                    Dim row3 As DataRow = set3.Tables.Item(row2.Table.TableName).NewRow
                                    row3.ItemArray = row2.ItemArray
                                    set3.Tables.Item(row2.Table.TableName).Rows.Add(row3)
                                Next
                            End If
                            If Not Information.IsNothing(DataTables) Then
                                Dim table As DataTable
                                For Each table In DataTables
                                    set3.Tables.Add(table.Copy)
                                Next
                            End If
                            If File.Exists(path) Then
                                Dim report As New XtraReport
                                Dim ex As New XRDesignFormEx
                                report.LoadLayout(path)
                                report.set_DataSource(set3)
                                ex.OpenReport(report)
                                ex.set_FileName(path)
                                ex.Show()
                            Else
                                Dim report2 As New XtraReport
                                Dim ex2 As New XRDesignFormEx
                                report2.set_DataSource(set3)
                                ex2.OpenReport(report2)
                                ex2.set_FileName(path)
                                ex2.Show()
                            End If
                        End If
                    End If
                End If
            End If
        End Sub

        Public Function EditReportInfo(ByVal ReportID As Integer, ByVal OwnerForm As Form) As Integer
            Dim num As Integer
            Dim set2 As New dsDefaultSet
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim report As New frmDialogNewReport(Me.SessionInfo)
            If (ReportID = 0) Then
                Return num
            End If
            If (Not Me.SessionInfo.CanModifyGlobalViews And (ReportID < 0)) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H3F, "", True), MsgBoxStyle.Critical, Nothing)
                Return num
            End If
            Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
            ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
            If (set2.Tables.Item("generalreport").Rows.Count = 0) Then
                Return num
            End If
            If Operators.ConditionalCompareObjectEqual(set2.Tables.Item("generalreport").Rows.Item(0).Item("SystemReport"), 1, False) Then
                Interaction.MsgBox(Me.BKGlobal.GetMsg(&H43, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                Return num
            End If
            Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
            report.ReportName = Conversions.ToString(row.Item("Name"))
            report.ReportDesc = Conversions.ToString(row.Item("Description"))
            report.ReportPath = Conversions.ToString(row.Item("ReportPath"))
            Dim flag As Boolean = True
            Do
                report.ShowDialog(OwnerForm)
                If (report.DialogResult = DialogResult.Cancel) Then
                    Return 0
                End If
                If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(row.Item("ReportPath"), report.ReportPath, False), Operators.CompareObjectNotEqual(row.Item("Name"), report.ReportName, False))) Then
                    Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))
                    Dim destFileName As String = (Me.GetReportPath(report.ReportPath, ReportID) & "\" & report.ReportName & ".repx")
                    If (Not Directory.Exists((report.ReportPath & "")) And ((report.ReportPath & "") <> "")) Then
                        Interaction.MsgBox(Me.BKGlobal.GetMsg(&H42, "", True), MsgBoxStyle.Critical, Nothing)
                        flag = False
                    End If
                    If (File.Exists(path) And Directory.Exists(Me.GetReportPath(report.ReportPath, ReportID))) Then
                        File.Move(path, destFileName)
                    End If
                End If
                row.Item("Name") = report.ReportName
                row.Item("Description") = report.ReportDesc
                row.Item("ReportPath") = report.ReportPath
                If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(row.Item("Name"), ""), "", False) Then
                    Interaction.MsgBox(Me.BKGlobal.GetMsg(5, "", True), MsgBoxStyle.Critical, Nothing)
                    flag = False
                End If
            Loop While Not flag
            ClsDs.UpdateDataSource(set2.Tables.Item("generalreport"), sQLTxt, True)
            Return ReportID
        End Function

        Public Sub ExportGridToExcel(ByVal OwnerForm As Form, ByVal GridView1 As GridView)
            Dim file As New frmDialogueSelectExcelFile(Me.SessionInfo)
            file.ShowDialog(OwnerForm.ParentForm)
            If (file.DialogResult <> DialogResult.Cancel) Then
                Dim info As New FileInfo(file.SelectedFileName)
                If ((info.FullName & "") <> "") Then
                    If (info.Extension <> ".xls") Then
                        Interaction.MsgBox("This is not an XLS file.", MsgBoxStyle.Critical, Nothing)
                    ElseIf info.Directory.Exists Then
                        Dim provider As New ExportXlsProvider(info.FullName)
                        Dim link As BaseExportLink = GridView1.CreateExportLink(provider)
                        link.set_ExportCellsAsDisplayText(False)
                        link.ExportTo(True)
                    End If
                End If
            End If
        End Sub

        Private Function GetFilteredData(ByVal view As ColumnView) As DataView
            If (view Is Nothing) Then
                Return Nothing
            End If
            If (((view.get_ActiveFilter Is Nothing) Or Not view.get_ActiveFilterEnabled) Or (view.get_ActiveFilter.get_Expression = "")) Then
                Return DirectCast(view.get_DataSource, DataView)
            End If
            Dim table As DataTable = DirectCast(NewLateBinding.LateGet(view.get_DataSource, Nothing, "Table", New Object(0 - 1) {}, Nothing, Nothing, Nothing), DataTable)
            Dim view2 As New DataView(table)
            view2.RowFilter = view.get_ActiveFilter.get_Expression
            Return view2
        End Function

        Public Function GetReportPath(ByVal ReportPath As String, ByVal ReportID As Integer) As String
            If ((ReportPath & "") <> "") Then
                Return ReportPath
            End If
            If (ReportID < 0) Then
                Return Me.SessionInfo.GlobalReportsPath
            End If
            Return Me.SessionInfo.UserDocPath
        End Function

        Private Function IsLandscape(ByVal pMenuID As Integer) As Boolean
            Dim flag As Boolean
            Dim set2 As New DataSet
            Dim set As New clsDataSet(Me.SessionInfo)
            set2.Tables.Add("systemmenu")
            ClsDs.FillDataSet(set2.Tables.Item("systemmenu"), ("SELECT MenuLandScape from systemmenu where MenuID = " & Conversions.ToString(pMenuID)), True, False)
            Dim table As DataTable = set2.Tables.Item("systemmenu")
            If (table.Rows.Count = 0) Then
                Return False
            End If
            If Information.IsDBNull(RuntimeHelpers.GetObjectValue(table.Rows.Item(0).Item(0))) Then
                Return False
            End If
            Return Conversions.ToBoolean(table.Rows.Item(0).Item(0))
            table = Nothing
            Return flag
        End Function

        Public Sub LoadToolBarReportList1(ByVal BarManager1 As BarManager, ByVal MenuID As Integer)
            Dim set2 As New dsDefaultSet
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = String.Concat(New String() {"SELECT * FROM generalreport WHERE MenuID = ", Conversions.ToString(MenuID), " AND (UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " OR ReportID < 0 ) "})
            ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
            Dim edit As RepositoryItemLookUpEdit = BarManager1.get_RepositoryItems.get_Item("cmbReportListRepos")
            edit.set_DataSource(set2.Tables.Item("generalreport"))
            edit.set_DisplayMember("Name")
            edit.set_ValueMember("ReportID")
            edit.get_Columns.Clear()
            edit.get_Columns.Add(New LookUpColumnInfo("Name", &H4B))
            edit.get_Columns.Add(New LookUpColumnInfo("Description", 150))
        End Sub

        Public Sub MakeReportCommon(ByVal ReportID As Integer)
            Dim set As New clsDataSet(Me.SessionInfo)
            If ((ReportID > 0) AndAlso (Interaction.MsgBox(Me.BKGlobal.GetMsg(&H40, Me.SessionInfo.UserLang, True), MsgBoxStyle.OkCancel, Nothing) <> MsgBoxResult.Cancel)) Then
                Dim num As Integer = Conversions.ToInteger(Me.BKGlobal.GetNextID("NEGReportID"))
                Dim set2 As New dsDefaultSet
                Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
                ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
                If (set2.Tables.Item("generalreport").Rows.Count <> 0) Then
                    Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
                    If (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))) AndAlso Directory.Exists(Me.GetReportPath(Me.SessionInfo.GlobalReportsPath, ReportID))) Then
                        File.Move(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx")), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Me.SessionInfo.GlobalReportsPath, ReportID) & "\"), row.Item("Name")), ".repx")))
                    End If
                    set2.Tables.Item("generalreport").Rows.Item(0).Item("ReportPath") = ""
                    set2.Tables.Item("generalreport").Rows.Item(0).Item("ReportID") = num
                    ClsDs.UpdateDataSource(set2.Tables.Item("generalreport"), sQLTxt, True)
                End If
            End If
        End Sub

        Public Sub PrintForm(ByVal ReportID As Integer, ByVal RptDS As DataSet)
            Dim set2 As New dsDefaultSet
            Dim set3 As New DataSet
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
            ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
            If (set2.Tables.Item("generalreport").Rows.Count <> 0) Then
                Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
                Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))
                If Not File.Exists(path) Then
                    Dim report As New XtraReport
                    Dim ex As New XRDesignFormEx
                    report.set_DataSource(RptDS)
                    ex.OpenReport(report)
                    ex.set_FileName(path)
                    ex.Show()
                Else
                    Dim report2 As New XtraReport
                    report2.LoadLayout(path)
                    report2.set_DataSource(RptDS)
                    report2.ShowPreview()
                End If
            End If
        End Sub

        Public Sub PrintForm(ByVal ReportID As Integer, Optional ByVal Rows As DataRow() = Nothing, Optional ByVal DataTables As DataTable() = Nothing)
            Dim set2 As New dsDefaultSet
            Dim set3 As New DataSet
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
            ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
            If (set2.Tables.Item("generalreport").Rows.Count <> 0) Then
                Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
                Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))
                If Not Information.IsNothing(Rows) Then
                    Dim row2 As DataRow
                    For Each row2 In Rows
                        set3.Tables.Add(row2.Table.Clone)
                        Dim row3 As DataRow = set3.Tables.Item(row2.Table.TableName).NewRow
                        row3.ItemArray = row2.ItemArray
                        set3.Tables.Item(row2.Table.TableName).Rows.Add(row3)
                    Next
                End If
                If Not Information.IsNothing(DataTables) Then
                    Dim table As DataTable
                    For Each table In DataTables
                        set3.Tables.Add(table.Copy)
                    Next
                End If
                If Not File.Exists(path) Then
                    Dim report As New XtraReport
                    Dim ex As New XRDesignFormEx
                    report.set_DataSource(set3)
                    ex.OpenReport(report)
                    ex.set_FileName(path)
                    ex.Show()
                Else
                    Dim report2 As New XtraReport
                    report2.LoadLayout(path)
                    report2.set_DataSource(set3)
                    report2.ShowPreview()
                End If
            End If
        End Sub

        Public Sub PrintGrid(ByVal pGrid1 As GridControl, Optional ByVal pLandScape As Boolean = False)
            Dim system As New PrintingSystem
            Dim link As New PrintableComponentLink
            system.get_Links.Add(link)
            link.set_Component(pGrid1)
            link.CreateDocument(system)
            system.get_PageSettings.set_Landscape(pLandScape)
            system.get_PageSettings.set_PaperKind(PaperKind.A4)
            system.get_PreviewFormEx.Show()
        End Sub

        Public Sub PrintReport(ByVal ReportID As Integer, ByVal Grid1 As GridControl, ByVal DS As DataSet, ByVal TableNames As String(), ByVal MenuID As Integer)
            If (ReportID = 0) Then
                Me.PrintGrid(Grid1, Me.IsLandscape(MenuID))
            Else
                Dim set2 As New dsDefaultSet
                Dim set3 As New DataSet
                Dim set As New clsDataSet(Me.SessionInfo)
                Dim sQLTxt As String = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(ReportID))
                ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
                If (set2.Tables.Item("generalreport").Rows.Count <> 0) Then
                    Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
                    Dim path As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx"))
                    Dim filteredData As DataView = Me.GetFilteredData(DirectCast(Grid1.get_DefaultView, ColumnView))
                    set3.Tables.Add(filteredData.ToTable)
                    Dim str3 As String
                    For Each str3 In TableNames
                        If (set3.Tables.Item(str3) Is Nothing) Then
                            set3.Tables.Add(DS.Tables.Item(str3).Copy)
                        End If
                    Next
                    If Not File.Exists(path) Then
                        Dim report As New XtraReport
                        Dim ex As New XRDesignFormEx
                        report.set_DataSource(set3)
                        ex.OpenReport(report)
                        ex.set_FileName(path)
                        ex.Show()
                    Else
                        Dim report2 As New XtraReport
                        report2.LoadLayout(path)
                        report2.set_DataSource(set3)
                        report2.ShowPreview()
                    End If
                End If
            End If
        End Sub

        Public Function SendReportToUser(ByVal ReportID As Integer, ByVal OwnerForm As Form) As Integer
            Dim num3 As Integer
            If (ReportID = 0) Then
                Return 0
            End If
            Dim user As New frmDialogSelectUser(Me.SessionInfo)
            Dim security As New dsSecurity
            Dim set2 As New dsDefaultSet
            Dim set As New clsDataSet(Me.SessionInfo)
            user.ShowDialog(OwnerForm)
            If (user.DialogResult <> DialogResult.OK) Then
                Return num3
            End If
            Dim num2 As Integer = Conversions.ToInteger(user.SelectedUserID)
            If (num2 = Me.SessionInfo.UserID) Then
                Return 0
            End If
            Dim sQLTxt As String = ("SELECT * FROM SecurityUSer WHERE UserID = " & Conversions.ToString(num2))
            ClsDs.FillDataSet(security.Tables.Item("securityuser"), sQLTxt, True, False)
            If (security.Tables.Item("securityuser").Rows.Count = 0) Then
                Return 0
            End If
            Dim num As Integer = Me.CopyReport(ReportID)
            If (num = 0) Then
                Return num3
            End If
            sQLTxt = ("SELECT * FROM generalreport WHERE ReportID = " & Conversions.ToString(num))
            ClsDs.FillDataSet(set2.Tables.Item("generalreport"), sQLTxt, True, False)
            If (set2.Tables.Item("generalreport").Rows.Count = 0) Then
                Return 0
            End If
            Dim row As DataRow = set2.Tables.Item("generalreport").Rows.Item(0)
            If (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), num) & "\"), row.Item("Name")), ".repx"))) AndAlso Directory.Exists(Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), num))) Then
                File.Move(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(row.Item("ReportPath")), ReportID) & "\"), row.Item("Name")), ".repx")), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.GetReportPath(Conversions.ToString(security.Tables.Item("securityuser").Rows.Item(0).Item("UserDocPath")), num) & "\"), row.Item("Name")), ".repx")))
            End If
            set2.Tables.Item("generalreport").Rows.Item(0).Item("UserID") = num2
            set2.Tables.Item("generalreport").Rows.Item(0).Item("ReportPath") = ""
            ClsDs.UpdateDataSource(set2.Tables.Item("generalreport"), sQLTxt, True)
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

