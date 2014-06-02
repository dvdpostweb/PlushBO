Imports DevExpress.XtraBars
Imports DevExpress.XtraPrinting
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
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmGeneral_Maintenance
        Inherits frmBKForm
        ' Events
        Public Event EventDeleteRecord As EventDeleteRecordEventHandler
        Public Event EventDesignReport As EventDesignReportEventHandler
        Public Event EventEditRecord As EventEditRecordEventHandler
        Public Event EventEnablingEditFields As EventEnablingEditFieldsEventHandler
        Public Event EventEnablingkeyFields As EventEnablingkeyFieldsEventHandler
        Public Event EventLoadDataset As EventLoadDatasetEventHandler
        Public Event EventNavFirst As EventNavFirstEventHandler
        Public Event EventNavLast As EventNavLastEventHandler
        Public Event EventNavNext As EventNavNextEventHandler
        Public Event EventNavPrevious As EventNavPreviousEventHandler
        Public Event EventNewRecord As EventNewRecordEventHandler
        Public Event EventPositionChanged As EventPositionChangedEventHandler
        Public Event EventPrintForm As EventPrintFormEventHandler
        Public Event EventSaveChanges As EventSaveChangesEventHandler
        Public Event EventUndoChanges As EventUndoChangesEventHandler
        Public Event EventUpdateDataset As EventUpdateDatasetEventHandler

        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmGeneral_Maintenance_Load)
            Dim list As ArrayList = frmGeneral_Maintenance.__ENCList
            SyncLock list
                frmGeneral_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableName = ""
            Me.OpenType = "BROWSE"
            Me.KeyFieldName = ""
            Me.IDField = ""
            Me.KeyValue = ""
            Me.RaiseEventForReportDesigner = False
            Me.CurrentBrowseViewID = 0
            Me.CurrentFilterID = 0
            Me.CurrentReportID = 0
            Me.CurrentDefaultSetID = 0
            Me.FilterTxt = ""
            Me.IsFiltered = False
            Me.FrmIsLoading = True
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmGeneral_Maintenance_Load)
            Dim list As ArrayList = frmGeneral_Maintenance.__ENCList
            SyncLock list
                frmGeneral_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableName = ""
            Me.OpenType = "BROWSE"
            Me.KeyFieldName = ""
            Me.IDField = ""
            Me.KeyValue = ""
            Me.RaiseEventForReportDesigner = False
            Me.CurrentBrowseViewID = 0
            Me.CurrentFilterID = 0
            Me.CurrentReportID = 0
            Me.CurrentDefaultSetID = 0
            Me.FilterTxt = ""
            Me.IsFiltered = False
            Me.FrmIsLoading = True
            Me.InitializeComponent
        End Sub

        Public Overrides Sub btnAttachements_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.GotoAttachement(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Public Overrides Sub btnComments_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.GotoComment(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Public Overrides Sub btnCopyDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.CurrentDefaultSetID = MyBase.BKDefaultSet.CopyDefaultSet(Me.CurrentDefaultSetID)
            MyBase.BKDefaultSet.EditDefaultSetInfo(Me.CurrentDefaultSetID, Me)
            MyBase.BKDefaultSet.LoadToolBarDefaultSetList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), False)
        End Sub

        Public Overrides Sub btnCopyFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetFilterID
            MyBase.BKFilter.EditFilterInfo(Me.CurrentFilterID, Conversions.ToInteger(Me.Tag), Me.MainDataSet.Tables.Item(Me.TableName), Me)
            MyBase.BKFilter.LoadToolBarFilterList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), False)
        End Sub

        Public Overrides Sub btnCopyReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetReportID
            MyBase.BKReport.EditReportInfo(Me.CurrentReportID, Me)
            MyBase.BKReport.LoadToolBarReportList1(Me.BarManager1, Conversions.ToInteger(Me.Tag))
        End Sub

        Public Overrides Sub btnDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If (Me.OpenType <> "BROWSE") Then
                Me.SetDefaultSetID
                Me.CurrentDefaultSetID = MyBase.BKDefaultSet.LoadDefaultSet(Me.CurrentDefaultSetID, Me)
                Me.BindingContext.Item(Me.MainDataSet).EndCurrentEdit
            End If
        End Sub

        Public Overrides Sub btnDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim eventDeleteRecordEvent As EventDeleteRecordEventHandler = Me.EventDeleteRecordEvent
            If (Not eventDeleteRecordEvent Is Nothing) Then
                eventDeleteRecordEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overrides Sub btnDeleteDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetDefaultSetID
            MyBase.BKDefaultSet.DeleteDefaultSet(Me.CurrentDefaultSetID)
            MyBase.BKDefaultSet.LoadToolBarDefaultSetList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), True)
        End Sub

        Public Overrides Sub btnDeleteFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetFilterID
            MyBase.BKFilter.DeleteFilter(Me.CurrentFilterID)
            MyBase.BKFilter.LoadToolBarFilterList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), True)
        End Sub

        Public Overrides Sub btnDeleteReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetReportID
            MyBase.BKReport.DeleteReport(Me.CurrentReportID)
            MyBase.BKReport.LoadToolBarReportList1(Me.BarManager1, Conversions.ToInteger(Me.Tag))
        End Sub

        Public Overrides Sub btnDesignReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetReportID
            If Not Me.RaiseEventForReportDesigner Then
                MyBase.BKReport.DesignReport(Me.CurrentReportID, Me.MainDataSet, New String() { Me.TableName })
            Else
                Dim eventDesignReportEvent As EventDesignReportEventHandler = Me.EventDesignReportEvent
                If (Not eventDesignReportEvent Is Nothing) Then
                    eventDesignReportEvent.Invoke
                End If
            End If
            MyBase.BKReport.LoadToolBarReportList1(Me.BarManager1, Conversions.ToInteger(Me.Tag))
        End Sub

        Public Overrides Sub btnEdit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim eventEditRecordEvent As EventEditRecordEventHandler = Me.EventEditRecordEvent
            If (Not eventEditRecordEvent Is Nothing) Then
                eventEditRecordEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overrides Sub btnEditDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetDefaultSetID
            MyBase.BKDefaultSet.EditDefaultSetInfo(Me.CurrentDefaultSetID, Me)
            MyBase.BKDefaultSet.LoadToolBarDefaultSetList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), False)
        End Sub

        Public Overrides Sub btnEditFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetFilterID
            MyBase.BKFilter.EditFilterInfo(Me.CurrentFilterID, Conversions.ToInteger(Me.Tag), Me.MainDataSet.Tables.Item(Me.TableName), Me)
            MyBase.BKFilter.LoadToolBarFilterList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), False)
            Me.cmbFilterList.set_EditValue(Me.CurrentFilterID)
        End Sub

        Public Overrides Sub btnEditReportInfo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetReportID
            MyBase.BKReport.EditReportInfo(Me.CurrentReportID, Me)
            MyBase.BKReport.LoadToolBarReportList1(Me.BarManager1, Conversions.ToInteger(Me.Tag))
            Me.cmbReportList.set_EditValue(Me.CurrentReportID)
        End Sub

        Public Overrides Sub btnFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetFilterID
            Me.FilterTxt = MyBase.BKFilter.FilterGenerateSQL(Me.CurrentFilterID)
            If ((Me.FilterTxt & "") = "") Then
                Me.IsFiltered = False
            Else
                Me.IsFiltered = True
            End If
            Dim eventLoadDatasetEvent As EventLoadDatasetEventHandler = Me.EventLoadDatasetEvent
            If (Not eventLoadDatasetEvent Is Nothing) Then
                eventLoadDatasetEvent.Invoke
            End If
        End Sub

        Public Overrides Sub btnFirst_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Position = 0
            Dim eventNavFirstEvent As EventNavFirstEventHandler = Me.EventNavFirstEvent
            If (Not eventNavFirstEvent Is Nothing) Then
                eventNavFirstEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
            Dim eventPositionChangedEvent As EventPositionChangedEventHandler = Me.EventPositionChangedEvent
            If (Not eventPositionChangedEvent Is Nothing) Then
                eventPositionChangedEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overrides Sub btnLast_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Position = (Me.MainDataSet.Tables.Item(Me.TableName).Rows.Count - 1)
            Dim eventNavLastEvent As EventNavLastEventHandler = Me.EventNavLastEvent
            If (Not eventNavLastEvent Is Nothing) Then
                eventNavLastEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
            Dim eventPositionChangedEvent As EventPositionChangedEventHandler = Me.EventPositionChangedEvent
            If (Not eventPositionChangedEvent Is Nothing) Then
                eventPositionChangedEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overrides Sub btnMakeDefaultCommon_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetDefaultSetID
            MyBase.BKDefaultSet.MakeDefaultSetCommon(Me.CurrentDefaultSetID)
        End Sub

        Public Overrides Sub btnMakeFilterCommon_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetFilterID
            MyBase.BKFilter.MakeFilterCommon(Me.CurrentFilterID)
        End Sub

        Public Overrides Sub btnMakeReportCommon_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetReportID
            MyBase.BKReport.MakeReportCommon(Me.CurrentReportID)
        End Sub

        Public Overrides Sub btnNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim eventNewRecordEvent As EventNewRecordEventHandler = Me.EventNewRecordEvent
            If (Not eventNewRecordEvent Is Nothing) Then
                eventNewRecordEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overrides Sub btnNewDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetDefaultSetID
            Me.CurrentDefaultSetID = MyBase.BKDefaultSet.NewDefaultSet(Conversions.ToInteger(Me.Tag), Me)
            MyBase.BKDefaultSet.LoadToolBarDefaultSetList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), False)
            Me.cmbDefaultList.set_EditValue(Me.CurrentDefaultSetID)
        End Sub

        Public Overrides Sub btnNewFilter_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.CurrentFilterID = MyBase.BKFilter.NewFilterDialogue(Conversions.ToInteger(Me.Tag), Me.MainDataSet.Tables.Item(Me.TableName), Me)
            MyBase.BKFilter.LoadToolBarFilterList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), False)
            Me.cmbFilterList.set_EditValue(Me.CurrentFilterID)
        End Sub

        Public Overrides Sub btnNewReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.CurrentReportID = MyBase.BKReport.CreateNewReport(Conversions.ToInteger(Me.Tag), Me)
            MyBase.BKReport.LoadToolBarReportList1(Me.BarManager1, Conversions.ToInteger(Me.Tag))
            Me.cmbReportList.set_EditValue(Me.CurrentReportID)
        End Sub

        Public Overrides Sub btnNext_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Position += 1
            Dim eventNavNextEvent As EventNavNextEventHandler = Me.EventNavNextEvent
            If (Not eventNavNextEvent Is Nothing) Then
                eventNavNextEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
            Dim eventPositionChangedEvent As EventPositionChangedEventHandler = Me.EventPositionChangedEvent
            If (Not eventPositionChangedEvent Is Nothing) Then
                eventPositionChangedEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overrides Sub btnPrevious_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Position -= 1
            Dim eventNavPreviousEvent As EventNavPreviousEventHandler = Me.EventNavPreviousEvent
            If (Not eventNavPreviousEvent Is Nothing) Then
                eventNavPreviousEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
            Dim eventPositionChangedEvent As EventPositionChangedEventHandler = Me.EventPositionChangedEvent
            If (Not eventPositionChangedEvent Is Nothing) Then
                eventPositionChangedEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overrides Sub btnPrint_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetReportID
            If (Me.CurrentReportID = 0) Then
                Me.PrintCurrentForm
            Else
                Dim eventPrintFormEvent As EventPrintFormEventHandler = Me.EventPrintFormEvent
                If (Not eventPrintFormEvent Is Nothing) Then
                    eventPrintFormEvent.Invoke
                End If
            End If
        End Sub

        Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.QuickSearch(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Public Overrides Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim eventSaveChangesEvent As EventSaveChangesEventHandler = Me.EventSaveChangesEvent
            If (Not eventSaveChangesEvent Is Nothing) Then
                eventSaveChangesEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overrides Sub btnSaveDefault_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetDefaultSetID
            Me.CurrentDefaultSetID = MyBase.BKDefaultSet.SaveDefaultSet(Me.CurrentDefaultSetID, Conversions.ToInteger(Me.Tag), Me)
        End Sub

        Public Overrides Sub btnSendDefaultUser_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetDefaultSetID
            MyBase.BKDefaultSet.SendDefaultSetToUser(Me.CurrentDefaultSetID, Me)
        End Sub

        Public Overrides Sub btnSendFilterUSer_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetFilterID
            MyBase.BKFilter.SendFilterToUser(Me.CurrentFilterID, Me)
        End Sub

        Public Overrides Sub btnSendReportUser_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SetReportID
            MyBase.BKReport.SendReportToUser(Me.CurrentReportID, Me)
        End Sub

        Public Overrides Sub btnTranslation_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.GotoTranslation(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Public Overrides Sub btnUndo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If (Me.OpenType <> "BROWSE") Then
                Dim eventUndoChangesEvent As EventUndoChangesEventHandler = Me.EventUndoChangesEvent
                If (Not eventUndoChangesEvent Is Nothing) Then
                    eventUndoChangesEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
                End If
            Else
                Me.Close
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Sub EnablingAll(ByVal Enabling As Boolean)
            Dim eventEnablingEditFieldsEvent As EventEnablingEditFieldsEventHandler = Me.EventEnablingEditFieldsEvent
            If (Not eventEnablingEditFieldsEvent Is Nothing) Then
                eventEnablingEditFieldsEvent.Invoke(Enabling)
            End If
            Dim eventEnablingkeyFieldsEvent As EventEnablingkeyFieldsEventHandler = Me.EventEnablingkeyFieldsEvent
            If (Not eventEnablingkeyFieldsEvent Is Nothing) Then
                eventEnablingkeyFieldsEvent.Invoke(Enabling)
            End If
        End Sub

        Public Sub EnablingForEdit()
            Dim eventEnablingEditFieldsEvent As EventEnablingEditFieldsEventHandler = Me.EventEnablingEditFieldsEvent
            If (Not eventEnablingEditFieldsEvent Is Nothing) Then
                eventEnablingEditFieldsEvent.Invoke(True)
            End If
        End Sub

        Public Sub EnablingNavButton(ByVal Enabling As Boolean)
            Me.BarManager1.get_Items.get_Item("btnFirst").set_Enabled(Enabling)
            Me.BarManager1.get_Items.get_Item("btnPrevious").set_Enabled(Enabling)
            Me.BarManager1.get_Items.get_Item("btnNext").set_Enabled(Enabling)
            Me.BarManager1.get_Items.get_Item("btnLast").set_Enabled(Enabling)
        End Sub

        Public Sub EnablingQuickSearch(ByVal Enabling As Boolean)
            Me.BarManager1.get_Items.get_Item("txtQuickSearch").set_Enabled(Enabling)
            Me.BarManager1.get_Items.get_Item("btnQuickSearch").set_Enabled(Enabling)
        End Sub

        Private Sub frmGeneral_Maintenance_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.DesignMode Then
                Me.SetUpDefaults
            End If
        End Sub

        Public Overridable Sub GotoAttachement(ByVal Sender As Object, ByVal e As EventArgs)
        End Sub

        Public Overridable Sub GotoComment(ByVal Sender As Object, ByVal e As EventArgs)
            Dim maintenance As New frmSystemComment_Maintenance(Me.SessionInfo)
            Dim num As Integer = Conversions.ToInteger(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Current, DataRowView).Item(Me.IDField), ""))
            maintenance.CommentRef = Conversions.ToString(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Current, DataRowView).Item(Me.KeyFieldName), ""))
            maintenance.CommentTableName = Me.TableName
            maintenance.CommentFieldName = Me.IDField
            maintenance.CommentFieldID = num
            maintenance.ShowDialog(Me)
        End Sub

        Public Overridable Sub GotoTranslation(ByVal Sender As Object, ByVal e As EventArgs)
            Dim maintenance As New frmgeneraldesctranslation_Maintenance(Me.SessionInfo)
            Dim num As Integer = Conversions.ToInteger(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Current, DataRowView).Item(Me.IDField), ""))
            maintenance.FieldID = num
            maintenance.FieldKey = Conversions.ToString(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Current, DataRowView).Item(Me.KeyFieldName), ""))
            maintenance.Field = (Me.TableName & "." & Me.IDField)
            maintenance.ShowDialog(Me)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Me.RightMouseMenu = New ContextMenu
            Me.PopMenuNew = New MenuItem
            Me.PopMenuEdit = New MenuItem
            Me.PopMenuDelete = New MenuItem
            Me.PopMenuSave = New MenuItem
            Me.PopMenuUndo = New MenuItem
            Me.MenuItem5 = New MenuItem
            Me.PopMenuPrintPreview = New MenuItem
            Me.MenuItem7 = New MenuItem
            Me.PopMenuAssociatedTasks = New MenuItem
            Me.MenuItem9 = New MenuItem
            Me.ToolTip1 = New ToolTip(Me.components)
            Me.HelpProvider1 = New HelpProvider
            Me.MainDataSet = New DataSet
            Me.StatusBar1 = New StatusBar
            Me.StatusBarPanel1 = New StatusBarPanel
            Me.StatusBarPanel2 = New StatusBarPanel
            Me.PrintSystem1 = New PrintingSystem(Me.components)
            Me.cmbViewListRepos.BeginInit
            Me.BarManager1.BeginInit
            Me.txtQuickSearchRepos.BeginInit
            Me.cmbReportListRepos.BeginInit
            Me.cmbFilterListRepos.BeginInit
            Me.cmbDefaultListRepos.BeginInit
            Me.MainDataSet.BeginInit
            Me.StatusBarPanel1.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.PrintSystem1.BeginInit
            Me.SuspendLayout
            Me.btnUndo.set_Enabled(False)
            Me.btnUndo.set_Visibility(0)
            Dim point As New Point(&H65, &H99)
            Me.Main_Bar.set_FloatLocation(point)
            Me.Main_Bar.set_Offset(0)
            Me.Main_Bar.set_Visible(True)
            Me.Nav_Bar.set_DockCol(2)
            Me.Nav_Bar.set_Offset(240)
            Me.Nav_Bar.set_Visible(True)
            Me.QuickSearch_Bar.set_DockCol(3)
            Me.QuickSearch_Bar.set_Visible(True)
            Me.btnSave.set_Enabled(False)
            Me.Report_Bar.set_DockCol(2)
            Me.Report_Bar.set_DockRow(1)
            Me.Report_Bar.set_Offset(&H19E)
            Me.Report_Bar.set_Visible(True)
            Me.Filter_Bar.set_DockCol(1)
            Me.Filter_Bar.set_DockRow(1)
            Me.Filter_Bar.set_Offset(&HD0)
            Me.Filter_Bar.set_Visible(True)
            Me.Misc_Bar2.set_Offset(&H8F)
            Me.Misc_Bar2.set_Visible(True)
            Me.DefaultSet_Bar.set_DockRow(1)
            Me.DefaultSet_Bar.set_Offset(0)
            Me.DefaultSet_Bar.set_Visible(True)
            Me.RightMouseMenu.MenuItems.AddRange(New MenuItem() { Me.PopMenuNew, Me.PopMenuEdit, Me.PopMenuDelete, Me.PopMenuSave, Me.PopMenuUndo, Me.MenuItem5, Me.PopMenuPrintPreview, Me.MenuItem7, Me.PopMenuAssociatedTasks, Me.MenuItem9 })
            Me.RightMouseMenu.RightToLeft = RightToLeft.No
            Me.PopMenuNew.Index = 0
            Me.PopMenuNew.Text = "New"
            Me.PopMenuEdit.Index = 1
            Me.PopMenuEdit.Text = "Edit"
            Me.PopMenuDelete.Index = 2
            Me.PopMenuDelete.Text = "Delete"
            Me.PopMenuSave.Index = 3
            Me.PopMenuSave.Text = "Save"
            Me.PopMenuUndo.Index = 4
            Me.PopMenuUndo.Text = "Undo"
            Me.MenuItem5.Index = 5
            Me.MenuItem5.Text = "-"
            Me.PopMenuPrintPreview.Index = 6
            Me.PopMenuPrintPreview.Text = "Print Preview"
            Me.MenuItem7.Index = 7
            Me.MenuItem7.Text = "-"
            Me.PopMenuAssociatedTasks.Index = 8
            Me.PopMenuAssociatedTasks.Text = "Associated Tasks"
            Me.MenuItem9.Index = 9
            Me.MenuItem9.Text = "-"
            Me.HelpProvider1.HelpNamespace = ".\Help\BizzKeys.chm"
            Me.MainDataSet.DataSetName = "NewDataSet"
            Me.MainDataSet.Locale = New CultureInfo("fr-BE")
            point = New Point(0, &H148)
            Me.StatusBar1.Location = point
            Me.StatusBar1.Name = "StatusBar1"
            Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel1, Me.StatusBarPanel2 })
            Me.StatusBar1.ShowPanels = True
            Dim size As New Size(&H420, &H16)
            Me.StatusBar1.Size = size
            Me.StatusBar1.TabIndex = &H22
            Me.StatusBarPanel1.AutoSize = StatusBarPanelAutoSize.Spring
            Me.StatusBarPanel1.Width = &H3F2
            Me.StatusBarPanel2.ToolTipText = "Filter Notification"
            Me.StatusBarPanel2.Width = 30
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Size(&H420, 350)
            Me.ClientSize = size
            Me.ContextMenu = Me.RightMouseMenu
            Me.Controls.Add(Me.StatusBar1)
            Me.HelpButton = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmGeneral_Maintenance"
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.Manual
            Me.Text = "##"
            Me.Controls.SetChildIndex(Me.StatusBar1, 0)
            Me.cmbViewListRepos.EndInit
            Me.BarManager1.EndInit
            Me.txtQuickSearchRepos.EndInit
            Me.cmbReportListRepos.EndInit
            Me.cmbFilterListRepos.EndInit
            Me.cmbDefaultListRepos.EndInit
            Me.MainDataSet.EndInit
            Me.StatusBarPanel1.EndInit
            Me.StatusBarPanel2.EndInit
            Me.PrintSystem1.EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Sub MyBaseEditrecord(ByVal objds As DataSet)
            If (Me.BindingContext.Item(objds, Me.TableName).Position >= 0) Then
                Me.SetState(ObjectState.EditState)
                Me.PopMenuNew.Enabled = False
                Me.PopMenuEdit.Enabled = False
                Me.PopMenuSave.Enabled = True
                Me.PopMenuDelete.Enabled = False
                Me.PopMenuUndo.Enabled = True
                Me.EnablingForEdit
                Me.OpenType = "EDIT"
            End If
        End Sub

        Public Sub MyBaseNewRecord(ByVal objds As DataSet)
            Me.SetState(ObjectState.NewState)
            Me.PopMenuNew.Enabled = False
            Me.PopMenuEdit.Enabled = False
            Me.PopMenuSave.Enabled = True
            Me.PopMenuDelete.Enabled = False
            Me.PopMenuUndo.Enabled = True
            Me.EnablingAll(True)
            Me.OpenType = "NEW"
            Try 
                Me.BindingContext.Item(objds, Me.TableName).EndCurrentEdit
                Me.BindingContext.Item(objds, Me.TableName).AddNew
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub MyBaseUndoChanges(ByVal objds As DataSet)
            Me.SetState(ObjectState.BrowseState)
            Me.PopMenuNew.Enabled = True
            Me.PopMenuEdit.Enabled = True
            Me.PopMenuSave.Enabled = False
            Me.PopMenuDelete.Enabled = True
            Me.PopMenuUndo.Enabled = False
            Me.EnablingAll(False)
            Me.OpenType = "BROWSE"
        End Sub

        Public Sub PrintCurrentForm()
            Dim graphics As BrickGraphics = Me.PrintSystem1.get_Graph
            SendKeys.SendWait("%{PRTSC}")
            Dim clipboardImage As Image = Me.ClipboardImage
            Me.PrintSystem1.Begin
            graphics.set_Modifier(1)
            Dim ef2 As New RectangleF(0!, 0!, 100!, 100!)
            graphics.DrawEmptyBrick(ef2)
            Dim location As New PointF(0!, 0!)
            Dim ef As New RectangleF(location, graphics.get_ClientPageSize)
            If (Not clipboardImage Is Nothing) Then
                ef = New RectangleF(0!, 0!, CSng(clipboardImage.Width), CSng(clipboardImage.Height))
                graphics.DrawImage(clipboardImage, ef, 0, Color.Transparent).set_Separable(True)
            Else
                MessageBox.Show("Image is null...")
            End If
            graphics.set_Font(New Font("Arial", 8!, FontStyle.Underline))
            graphics.set_BackColor(Color.Transparent)
            graphics.set_Modifier(4)
            ef = New RectangleF(0!, 0!, 0!, CSng(graphics.get_Font.Height))
            Dim brick As PageInfoBrick = graphics.DrawPageInfo(1, "XtraPrintingSystem by Developer Express inc.", Color.Blue, ef, 0)
            brick.set_Url("www.devexpress.com")
            brick.set_Hint(brick.get_Url)
            brick.set_Alignment(4)
            brick.set_AutoWidth(True)
            Me.PrintSystem1.End
            Me.PrintSystem1.get_PreviewFormEx.Show
            Me.PrintSystem1.get_PreviewFormEx.Activate
        End Sub

        Public Sub QuickSearch(ByVal Sender As Object, ByVal e As EventArgs)
            Dim view As DataView
            Dim sort As String = Me.MainDataSet.Tables.Item(Me.TableName).DefaultView.Sort
            Me.MainDataSet.Tables.Item(Me.TableName).DefaultView.Sort = Me.KeyFieldName
            If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.txtQuickSearch.get_EditValue)) Then
                view = New DataView(Me.MainDataSet.Tables.Item(Me.TableName), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.KeyFieldName & " >= "), Me.txtQuickSearch.get_EditValue), "")), Me.KeyFieldName, DataViewRowState.CurrentRows)
            Else
                view = New DataView(Me.MainDataSet.Tables.Item(Me.TableName), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Me.KeyFieldName & " Like '"), Me.txtQuickSearch.get_EditValue), "*'")), Me.KeyFieldName, DataViewRowState.CurrentRows)
            End If
            If (view.Count > 0) Then
                Me.BindingContext.Item(Me.MainDataSet, Me.TableName).Position = Me.MainDataSet.Tables.Item(Me.TableName).DefaultView.Find(New Object() { RuntimeHelpers.GetObjectValue(view.Item(0).Item(Me.KeyFieldName)) })
                Dim eventPositionChangedEvent As EventPositionChangedEventHandler = Me.EventPositionChangedEvent
                If (Not eventPositionChangedEvent Is Nothing) Then
                    eventPositionChangedEvent.Invoke(RuntimeHelpers.GetObjectValue(Sender), e)
                End If
            End If
            Me.MainDataSet.Tables.Item(Me.TableName).DefaultView.Sort = sort
        End Sub

        Public Sub SetDefaultSetID()
            If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.cmbDefaultList.get_EditValue)) Then
                Me.CurrentDefaultSetID = 0
            Else
                Me.CurrentDefaultSetID = Conversions.ToInteger(Me.cmbDefaultList.get_EditValue)
            End If
        End Sub

        Public Sub SetFilterID()
            If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.cmbFilterList.get_EditValue)) Then
                Me.CurrentFilterID = 0
            Else
                Me.CurrentFilterID = Conversions.ToInteger(Me.cmbFilterList.get_EditValue)
            End If
        End Sub

        Public Sub SetReportID()
            If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.cmbReportList.get_EditValue)) Then
                Me.CurrentReportID = 0
            Else
                Me.CurrentReportID = Conversions.ToInteger(Me.cmbReportList.get_EditValue)
            End If
        End Sub

        Public Sub SetState(ByVal State As ObjectState)
            Select Case CInt(State)
                Case 0
                    Me.EnablingQuickSearch(False)
                    Me.BarManager1.get_Items.get_Item("btnNew").set_Enabled(False)
                    Me.BarManager1.get_Items.get_Item("btnEdit").set_Enabled(False)
                    Me.BarManager1.get_Items.get_Item("btnSave").set_Enabled(True)
                    Me.BarManager1.get_Items.get_Item("btnDelete").set_Enabled(False)
                    Me.BarManager1.get_Items.get_Item("btnUndo").set_Enabled(True)
                    Me.EnablingNavButton(False)
                    Exit Select
                Case 1
                    Me.EnablingQuickSearch(False)
                    Me.BarManager1.get_Items.get_Item("btnNew").set_Enabled(False)
                    Me.BarManager1.get_Items.get_Item("btnEdit").set_Enabled(False)
                    Me.BarManager1.get_Items.get_Item("btnSave").set_Enabled(True)
                    Me.BarManager1.get_Items.get_Item("btnDelete").set_Enabled(False)
                    Me.BarManager1.get_Items.get_Item("btnUndo").set_Enabled(True)
                    Me.EnablingNavButton(False)
                    Exit Select
                Case 2
                    Me.EnablingQuickSearch(True)
                    Me.BarManager1.get_Items.get_Item("btnNew").set_Enabled(True)
                    Me.BarManager1.get_Items.get_Item("btnEdit").set_Enabled(True)
                    Me.BarManager1.get_Items.get_Item("btnSave").set_Enabled(False)
                    Me.BarManager1.get_Items.get_Item("btnDelete").set_Enabled(True)
                    Me.BarManager1.get_Items.get_Item("btnUndo").set_Enabled(False)
                    Me.EnablingNavButton(True)
                    Exit Select
            End Select
        End Sub

        Public Sub SetUpDefaults()
            MyBase.BKDefaultSet.LoadToolBarDefaultSetList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), True)
            MyBase.BKFilter.LoadToolBarFilterList1(Me.BarManager1, Conversions.ToInteger(Me.Tag), True)
            MyBase.BKReport.LoadToolBarReportList1(Me.BarManager1, Conversions.ToInteger(Me.Tag))
        End Sub


        ' Properties
        Protected Property ClipboardImage As Image
            Get
                Dim dataObject As IDataObject = Clipboard.GetDataObject
                If ((Not dataObject Is Nothing) AndAlso dataObject.GetDataPresent(DataFormats.Bitmap)) Then
                    Return DirectCast(dataObject.GetData(DataFormats.Bitmap), Image)
                End If
                Return Nothing
            End Get
            Set(ByVal Value As Image)
                Clipboard.SetDataObject(Value)
            End Set
        End Property

        Public Overridable Property HelpProvider1 As HelpProvider
            Get
                Return Me._HelpProvider1
            End Get
            Set(ByVal WithEventsValue As HelpProvider)
                Me._HelpProvider1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property MainDataSet As DataSet
            Get
                Return Me._MainDataSet
            End Get
            Set(ByVal WithEventsValue As DataSet)
                Me._MainDataSet = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MenuItem5 As MenuItem
            Get
                Return Me._MenuItem5
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._MenuItem5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MenuItem7 As MenuItem
            Get
                Return Me._MenuItem7
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._MenuItem7 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MenuItem9 As MenuItem
            Get
                Return Me._MenuItem9
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._MenuItem9 = WithEventsValue
            End Set
        End Property

        Public Overridable Property PopMenuAssociatedTasks As MenuItem
            Get
                Return Me._PopMenuAssociatedTasks
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuAssociatedTasks = WithEventsValue
            End Set
        End Property

        Public Overridable Property PopMenuDelete As MenuItem
            Get
                Return Me._PopMenuDelete
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuDelete = WithEventsValue
            End Set
        End Property

        Public Overridable Property PopMenuEdit As MenuItem
            Get
                Return Me._PopMenuEdit
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuEdit = WithEventsValue
            End Set
        End Property

        Public Overridable Property PopMenuNew As MenuItem
            Get
                Return Me._PopMenuNew
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuNew = WithEventsValue
            End Set
        End Property

        Public Overridable Property PopMenuPrintPreview As MenuItem
            Get
                Return Me._PopMenuPrintPreview
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuPrintPreview = WithEventsValue
            End Set
        End Property

        Public Overridable Property PopMenuSave As MenuItem
            Get
                Return Me._PopMenuSave
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuSave = WithEventsValue
            End Set
        End Property

        Public Overridable Property PopMenuUndo As MenuItem
            Get
                Return Me._PopMenuUndo
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuUndo = WithEventsValue
            End Set
        End Property

        Public Overridable Property PrintSystem1 As PrintingSystem
            Get
                Return Me._PrintSystem1
            End Get
            Set(ByVal WithEventsValue As PrintingSystem)
                Me._PrintSystem1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property RightMouseMenu As ContextMenu
            Get
                Return Me._RightMouseMenu
            End Get
            Set(ByVal WithEventsValue As ContextMenu)
                Me._RightMouseMenu = WithEventsValue
            End Set
        End Property

        Public Overridable Property StatusBar1 As StatusBar
            Get
                Return Me._StatusBar1
            End Get
            Set(ByVal WithEventsValue As StatusBar)
                Me._StatusBar1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property StatusBarPanel1 As StatusBarPanel
            Get
                Return Me._StatusBarPanel1
            End Get
            Set(ByVal WithEventsValue As StatusBarPanel)
                Me._StatusBarPanel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property StatusBarPanel2 As StatusBarPanel
            Get
                Return Me._StatusBarPanel2
            End Get
            Set(ByVal WithEventsValue As StatusBarPanel)
                Me._StatusBarPanel2 = WithEventsValue
            End Set
        End Property

        Public Overridable Property ToolTip1 As ToolTip
            Get
                Return Me._ToolTip1
            End Get
            Set(ByVal WithEventsValue As ToolTip)
                Me._ToolTip1 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared _ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider
        <AccessedThroughProperty("MainDataSet")> _
        Private _MainDataSet As DataSet
        <AccessedThroughProperty("MenuItem5")> _
        Private _MenuItem5 As MenuItem
        <AccessedThroughProperty("MenuItem7")> _
        Private _MenuItem7 As MenuItem
        <AccessedThroughProperty("MenuItem9")> _
        Private _MenuItem9 As MenuItem
        <AccessedThroughProperty("PopMenuAssociatedTasks")> _
        Private _PopMenuAssociatedTasks As MenuItem
        <AccessedThroughProperty("PopMenuDelete")> _
        Private _PopMenuDelete As MenuItem
        <AccessedThroughProperty("PopMenuEdit")> _
        Private _PopMenuEdit As MenuItem
        <AccessedThroughProperty("PopMenuNew")> _
        Private _PopMenuNew As MenuItem
        <AccessedThroughProperty("PopMenuPrintPreview")> _
        Private _PopMenuPrintPreview As MenuItem
        <AccessedThroughProperty("PopMenuSave")> _
        Private _PopMenuSave As MenuItem
        <AccessedThroughProperty("PopMenuUndo")> _
        Private _PopMenuUndo As MenuItem
        <AccessedThroughProperty("PrintSystem1")> _
        Private _PrintSystem1 As PrintingSystem
        <AccessedThroughProperty("RightMouseMenu")> _
        Private _RightMouseMenu As ContextMenu
        <AccessedThroughProperty("StatusBar1")> _
        Private _StatusBar1 As StatusBar
        <AccessedThroughProperty("StatusBarPanel1")> _
        Private _StatusBarPanel1 As StatusBarPanel
        <AccessedThroughProperty("StatusBarPanel2")> _
        Private _StatusBarPanel2 As StatusBarPanel
        <AccessedThroughProperty("ToolTip1")> _
        Private _ToolTip1 As ToolTip
        Private components As IContainer
        Public CurrentBrowseViewID As Integer
        Public CurrentDefaultSetID As Integer
        Public CurrentFilterID As Integer
        Public CurrentReportID As Integer
        Public FilterTxt As String
        Public FrmIsLoading As Boolean
        Public IDField As String
        Public IsFiltered As Boolean
        Public KeyFieldName As String
        Public KeyValue As String
        Public OpenType As String
        Public RaiseEventForReportDesigner As Boolean
        Public SQLTxt1 As String
        Public TableName As String

        ' Nested Types
        Public Delegate Sub EventDeleteRecordEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventDesignReportEventHandler()

        Public Delegate Sub EventEditRecordEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventEnablingEditFieldsEventHandler(ByVal Enabling As Boolean)

        Public Delegate Sub EventEnablingkeyFieldsEventHandler(ByVal Enabling As Boolean)

        Public Delegate Sub EventLoadDatasetEventHandler()

        Public Delegate Sub EventNavFirstEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventNavLastEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventNavNextEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventNavPreviousEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventNewRecordEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventPositionChangedEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventPrintFormEventHandler()

        Public Delegate Sub EventSaveChangesEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventUndoChangesEventHandler(ByVal Sender As Object, ByVal e As EventArgs)

        Public Delegate Sub EventUpdateDatasetEventHandler()
    End Class
End Namespace

