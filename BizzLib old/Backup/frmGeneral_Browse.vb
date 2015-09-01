Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmGeneral_Browse
        Inherits frmBKForm
        ' Events
        Public Event SelectedTabPageChanged As SelectedTabPageChangedEventHandler

        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmGeneral_Browse.__ENCList
            SyncLock list
                frmGeneral_Browse.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.objDS = New DataSet
            Me.TableName = ""
            Me.IDField = ""
            Me.NameField = ""
            Me.MaintenanceMenuID = -1
            Me.WhereClause = ""
            Me.OrderByClause = ""
            Me.CurrentBrowseViewID = 0
            Me.CurrentFilterID = 0
            Me.CurrentReportID = 0
            Me.CurrentDefaultSetID = 0
            Me.FilterTxt = ""
            Me.IsFiltered = False
            Me.CanSave = False
            Me.CanDelete = False
            Me.CanNew = True
            Me.CanEdit = True
            Me.AutoLoadData = True
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmGeneral_Browse.__ENCList
            SyncLock list
                frmGeneral_Browse.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.objDS = New DataSet
            Me.TableName = ""
            Me.IDField = ""
            Me.NameField = ""
            Me.MaintenanceMenuID = -1
            Me.WhereClause = ""
            Me.OrderByClause = ""
            Me.CurrentBrowseViewID = 0
            Me.CurrentFilterID = 0
            Me.CurrentReportID = 0
            Me.CurrentDefaultSetID = 0
            Me.FilterTxt = ""
            Me.IsFiltered = False
            Me.CanSave = False
            Me.CanDelete = False
            Me.CanNew = True
            Me.CanEdit = True
            Me.AutoLoadData = True
            Me.InitializeComponent
            Me.UcPivotGrid1.Initialize(Me.SessionInfo)
        End Sub

        Public Overrides Sub Btn_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.CreateParameterTable(Me.objDS)
            Dim ownerForm As Form = Me
            Dim view As AdvBandedGridView = Me.GridView1
            Dim manager As BarManager = Me.BarManager1
            Dim bar As StatusBar = Me.StatusBar1
            MyBase.BKGlobal.ToolBarQueryBrowse_ToolClick2(RuntimeHelpers.GetObjectValue(sender), e.get_Item.get_Name, (ownerForm), (view), Me.objDS, Me.TableName, Me.NameField, (manager), (Me.CurrentFilterID), (Me.CurrentReportID), (Me.CurrentDefaultSetID), (Me.CurrentBrowseViewID), (bar), New String() { Me.TableName, "ParaTable" })
            Me.StatusBar1 = bar
            Me.BarManager1 = manager
            Me.GridView1 = view
            Select Case e.get_Item.get_Name
                Case "btnFilter"
                    Me.LoadDataSet
                    Exit Select
                Case "btnNew"
                    Me.NewRecord(RuntimeHelpers.GetObjectValue(sender), e)
                    Exit Select
                Case "btnEdit"
                    Me.EditRecord(RuntimeHelpers.GetObjectValue(sender), e)
                    Exit Select
                Case "btnDelete"
                    Me.DeleteRecord(RuntimeHelpers.GetObjectValue(sender), e)
                    Exit Select
                Case "btnSave"
                    Me.SaveChanges(RuntimeHelpers.GetObjectValue(sender), e)
                    Exit Select
            End Select
        End Sub

        Public Overrides Sub btnExportXML_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim file As New frmDialogSelectXMLFile
            file.mvarBoolSave = True
            file.ShowDialog(Me)
            If (file.DialogResult <> DialogResult.Cancel) Then
                Dim text As String = file.txtFileName.Text
                Dim table As DataTable = Me.objDS.Tables.Item(Me.TableName).Copy
                Dim set As New DataSet(Me.objDS.DataSetName)
                ClsDs.Tables.Add(table)
                ClsDs.WriteXml([text], XmlWriteMode.WriteSchema)
            End If
        End Sub

        Public Overrides Sub btnImportXML_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim file As New frmDialogSelectXMLFile
            file.mvarBoolSave = False
            file.ShowDialog(Me)
            If (file.DialogResult <> DialogResult.Cancel) Then
                Dim text As String = file.txtFileName.Text
                Dim table As DataTable = Me.objDS.Tables.Item(Me.TableName).Copy
                Dim set As New DataSet(Me.objDS.DataSetName)
                ClsDs.Tables.Add(table)
                ClsDs.ReadXml([text], XmlReadMode.ReadSchema)
                Me.objDS.Merge(ClsDs.Tables.Item(Me.TableName))
                Me.objDS.Tables.Item(Me.TableName).DefaultView.Sort = Me.NameField
                Me.Grid1.set_DataSource(Me.objDS.Tables.Item(Me.TableName).DefaultView)
                Me.UcPivotGrid1.PivotGrid1.set_DataSource(Me.objDS.Tables.Item(Me.TableName).DefaultView)
                Me.UcPivotGrid1.PivotGrid1.set_DataMember("")
                Me.UcPivotGrid1.SetFields()
            End If
        End Sub

        Public Overridable Sub CreateParameterTable(ByVal RptDs As DataSet)
            If Not Information.IsNothing(RptDs.Tables.Item("ParaTable")) Then
                RptDs.Tables.Remove("ParaTable")
            End If
            RptDs.Tables.Add("ParaTable")
        End Sub

        Public Overridable Sub DeleteRecord(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Overridable Sub EditRecord(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.MaintenanceMenuID <> -1) Then
                Dim formName As String = MyBase.BKGlobal.GetFormName(Me.MaintenanceMenuID)
                Dim assemblyName As String = MyBase.BKGlobal.GetAssemblyName(Me.MaintenanceMenuID)
                If ((formName & "") <> "") Then
                    Dim maintenance As frmGeneral_Maintenance = DirectCast(MyBase.BKGlobal.GetForm(formName, assemblyName, Me.MaintenanceMenuID), frmGeneral_Maintenance)
                    Dim type As Type = Type.GetType(("BizzKeys." & formName))
                    If Not Information.IsNothing(Me.GridView1.GetDataRow(Me.GridView1.get_FocusedRowHandle)) Then
                        maintenance.KeyValue = Conversions.ToString(Me.GridView1.GetDataRow(Me.GridView1.get_FocusedRowHandle).Item(Me.IDField))
                        Dim str4 As String = Conversions.ToString(Me.GridView1.GetDataRow(Me.GridView1.get_FocusedRowHandle).Item(Me.NameField))
                        maintenance.OpenType = "EDIT"
                        maintenance.IDField = Me.IDField
                        maintenance.KeyFieldName = Me.NameField
                        maintenance.Tag = Me.MaintenanceMenuID
                        MyBase.BKGlobal.StartForm(maintenance, Me.MaintenanceMenuID, Me.ParentForm, True)
                        Me.LoadDataSet
                        Dim num As Integer = Me.GridView1.LocateByValue(0, Me.GridView1.get_Columns.get_Item(Me.NameField), str4)
                        If (num <> -2147483648) Then
                            Me.GridView1.set_TopRowIndex(num)
                            Me.GridView1.set_FocusedRowHandle(num)
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub EventDeleteRecord(ByVal sender As Object, ByVal e As EventArgs)
            Me.DeleteRecord(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Public Overridable Sub EventEditRecord(ByVal sender As Object, ByVal e As EventArgs)
            Me.EditRecord(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Private Sub EventNewRecord(ByVal sender As Object, ByVal e As EventArgs)
            Me.NewRecord(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Private Sub EventSaveChanges(ByVal sender As Object, ByVal e As EventArgs)
            Me.SaveChanges(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Public Overridable Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            If Me.SessionInfo.AutoSaveViews Then
                MyBase.BKBrowseView.SaveCurrentBrowseViewDefinition(Me.CurrentBrowseViewID, Me.TableName, Me.GridView1, True)
            End If
            Me.UpdateDataSet
        End Sub

        Public Overridable Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            If (((Me.TableName <> "") And (Me.IDField <> "")) And (Me.NameField <> "")) Then
                Me.StartUp
            End If
        End Sub

        Public Overridable Sub Grid1_Validated(ByVal sender As Object, ByVal e As ValidateRowEventArgs)
        End Sub

        Public Overridable Sub gridview1_doubleclick(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Public Overridable Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
            DirectCast(Me.BarManager1.get_Items.get_Item("txtQuickSearch"), BarEditItem).set_EditValue(Operators.ConcatenateObject(Me.GridView1.GetRowCellValue(e.get_FocusedRowHandle, Me.GridView1.get_Columns.get_Item(Me.NameField)), ""))
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(frmGeneral_Browse))
            Me.Grid1 = New GridControl
            Me.GridView1 = New AdvBandedGridView
            Me.GridBand1 = New GridBand
            Me.UcPivotGrid1 = New ucPivotGrid
            Me.RightMouseMenu = New ContextMenu
            Me.PopMenuNew = New MenuItem
            Me.PopMenuEdit = New MenuItem
            Me.PopMenuDelete = New MenuItem
            Me.PopMenuSave = New MenuItem
            Me.MenuItem5 = New MenuItem
            Me.PopMenuPrintPreview = New MenuItem
            Me.MenuItem7 = New MenuItem
            Me.PopMenuAssociatedTasks = New MenuItem
            Me.MenuItem9 = New MenuItem
            Me.HelpProvider1 = New HelpProvider
            Me.StatusBar1 = New StatusBar
            Me.StatusBarPanel2 = New StatusBarPanel
            Me.StatusBarPanel3 = New StatusBarPanel
            Me.Panel1 = New Panel
            Me.TabControl1 = New XtraTabControl
            Me.TabParameters = New XtraTabPage
            Me.TabResult = New XtraTabPage
            Me.TabAnalyse = New XtraTabPage
            Me.TabChart = New XtraTabPage
            Me.UcChart1 = New ucChart
            Me.SaveFileDialog1 = New SaveFileDialog
            Me.Bar1 = New Bar
            Me.cmbViewListRepos.BeginInit
            Me.txtQuickSearchRepos.BeginInit
            Me.cmbReportListRepos.BeginInit
            Me.cmbFilterListRepos.BeginInit
            Me.cmbDefaultListRepos.BeginInit
            Me.Grid1.BeginInit
            Me.GridView1.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.StatusBarPanel3.BeginInit
            Me.Panel1.SuspendLayout
            Me.TabControl1.BeginInit
            Me.TabControl1.SuspendLayout
            Me.TabResult.SuspendLayout
            Me.TabAnalyse.SuspendLayout
            Me.TabChart.SuspendLayout
            Me.SuspendLayout
            manager.ApplyResources(Me.Grid1, "Grid1")
            Me.Grid1.get_EmbeddedNavigator.Name = ""
            Me.Grid1.set_FormsUseDefaultLookAndFeel(False)
            Me.Grid1.set_MainView(Me.GridView1)
            Me.Grid1.Name = "Grid1"
            Me.HelpProvider1.SetShowHelp(Me.Grid1, Conversions.ToBoolean(manager.GetObject("Grid1.ShowHelp")))
            Me.Grid1.get_ViewCollection.AddRange(New BaseView() { Me.GridView1 })
            Me.GridView1.get_Bands.AddRange(New GridBand() { Me.GridBand1 })
            Me.GridView1.set_GridControl(Me.Grid1)
            Me.GridView1.set_GroupFooterShowMode(2)
            manager.ApplyResources(Me.GridView1, "GridView1")
            Me.GridView1.set_Name("GridView1")
            Me.GridView1.get_OptionsBehavior.set_AllowIncrementalSearch(True)
            Me.GridView1.get_OptionsBehavior.set_Editable(False)
            Me.GridView1.get_OptionsView.set_ShowBands(False)
            Me.GridView1.get_OptionsView.set_ShowFooter(True)
            manager.ApplyResources(Me.GridBand1, "GridBand1")
            manager.ApplyResources(Me.UcPivotGrid1, "UcPivotGrid1")
            Me.UcPivotGrid1.Name = "UcPivotGrid1"
            Me.UcPivotGrid1.SessionInfo = Nothing
            Me.HelpProvider1.SetShowHelp(Me.UcPivotGrid1, Conversions.ToBoolean(manager.GetObject("UcPivotGrid1.ShowHelp")))
            Me.RightMouseMenu.MenuItems.AddRange(New MenuItem() { Me.PopMenuNew, Me.PopMenuEdit, Me.PopMenuDelete, Me.PopMenuSave, Me.MenuItem5, Me.PopMenuPrintPreview, Me.MenuItem7, Me.PopMenuAssociatedTasks, Me.MenuItem9 })
            manager.ApplyResources(Me.PopMenuNew, "PopMenuNew")
            Me.PopMenuNew.Index = 0
            manager.ApplyResources(Me.PopMenuEdit, "PopMenuEdit")
            Me.PopMenuEdit.Index = 1
            manager.ApplyResources(Me.PopMenuDelete, "PopMenuDelete")
            Me.PopMenuDelete.Index = 2
            manager.ApplyResources(Me.PopMenuSave, "PopMenuSave")
            Me.PopMenuSave.Index = 3
            manager.ApplyResources(Me.MenuItem5, "MenuItem5")
            Me.MenuItem5.Index = 4
            manager.ApplyResources(Me.PopMenuPrintPreview, "PopMenuPrintPreview")
            Me.PopMenuPrintPreview.Index = 5
            manager.ApplyResources(Me.MenuItem7, "MenuItem7")
            Me.MenuItem7.Index = 6
            manager.ApplyResources(Me.PopMenuAssociatedTasks, "PopMenuAssociatedTasks")
            Me.PopMenuAssociatedTasks.Index = 7
            manager.ApplyResources(Me.MenuItem9, "MenuItem9")
            Me.MenuItem9.Index = 8
            manager.ApplyResources(Me.StatusBar1, "StatusBar1")
            Me.StatusBar1.Name = "StatusBar1"
            Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel2, Me.StatusBarPanel3 })
            Me.HelpProvider1.SetShowHelp(Me.StatusBar1, Conversions.ToBoolean(manager.GetObject("StatusBar1.ShowHelp")))
            Me.StatusBar1.ShowPanels = True
            manager.ApplyResources(Me.StatusBarPanel2, "StatusBarPanel2")
            manager.ApplyResources(Me.StatusBarPanel3, "StatusBarPanel3")
            Me.Panel1.Controls.Add(Me.TabControl1)
            manager.ApplyResources(Me.Panel1, "Panel1")
            Me.Panel1.Name = "Panel1"
            Me.HelpProvider1.SetShowHelp(Me.Panel1, Conversions.ToBoolean(manager.GetObject("Panel1.ShowHelp")))
            manager.ApplyResources(Me.TabControl1, "TabControl1")
            Me.TabControl1.get_LookAndFeel.set_SkinName("Lilian")
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.set_SelectedTabPage(Me.TabParameters)
            Me.HelpProvider1.SetShowHelp(Me.TabControl1, Conversions.ToBoolean(manager.GetObject("TabControl1.ShowHelp")))
            Me.TabControl1.get_TabPages.AddRange(New XtraTabPage() { Me.TabParameters, Me.TabResult, Me.TabAnalyse, Me.TabChart })
            Me.TabParameters.Name = "TabParameters"
            Me.TabParameters.set_PageVisible(False)
            Me.HelpProvider1.SetShowHelp(Me.TabParameters, Conversions.ToBoolean(manager.GetObject("TabParameters.ShowHelp")))
            manager.ApplyResources(Me.TabParameters, "TabParameters")
            Me.TabResult.Controls.Add(Me.Grid1)
            Me.TabResult.Name = "TabResult"
            Me.HelpProvider1.SetShowHelp(Me.TabResult, Conversions.ToBoolean(manager.GetObject("TabResult.ShowHelp")))
            manager.ApplyResources(Me.TabResult, "TabResult")
            Me.TabAnalyse.Controls.Add(Me.UcPivotGrid1)
            Me.TabAnalyse.Name = "TabAnalyse"
            Me.HelpProvider1.SetShowHelp(Me.TabAnalyse, Conversions.ToBoolean(manager.GetObject("TabAnalyse.ShowHelp")))
            manager.ApplyResources(Me.TabAnalyse, "TabAnalyse")
            Me.TabChart.Controls.Add(Me.UcChart1)
            Me.TabChart.Name = "TabChart"
            Me.HelpProvider1.SetShowHelp(Me.TabChart, Conversions.ToBoolean(manager.GetObject("TabChart.ShowHelp")))
            manager.ApplyResources(Me.TabChart, "TabChart")
            manager.ApplyResources(Me.UcChart1, "UcChart1")
            Me.UcChart1.Name = "UcChart1"
            Me.UcChart1.SessionInfo = Nothing
            Me.HelpProvider1.SetShowHelp(Me.UcChart1, Conversions.ToBoolean(manager.GetObject("UcChart1.ShowHelp")))
            Me.Bar1.set_BarName("View_Bar")
            Me.Bar1.set_DockCol(2)
            Me.Bar1.set_DockRow(0)
            Me.Bar1.set_DockStyle(2)
            Dim point As New Point(&H205, &HBC)
            Me.Bar1.set_FloatLocation(point)
            Me.Bar1.set_Offset(&H117)
            manager.ApplyResources(Me.Bar1, "Bar1")
            manager.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.StatusBar1)
            Me.HelpButton = True
            Me.Name = "frmGeneral_Browse"
            Me.HelpProvider1.SetShowHelp(Me, Conversions.ToBoolean(manager.GetObject("$this.ShowHelp")))
            Me.ShowInTaskbar = False
            Me.Controls.SetChildIndex(Me.StatusBar1, 0)
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.cmbViewListRepos.EndInit
            Me.txtQuickSearchRepos.EndInit
            Me.cmbReportListRepos.EndInit
            Me.cmbFilterListRepos.EndInit
            Me.cmbDefaultListRepos.EndInit
            Me.Grid1.EndInit
            Me.GridView1.EndInit
            Me.StatusBarPanel2.EndInit
            Me.StatusBarPanel3.EndInit
            Me.Panel1.ResumeLayout(False)
            Me.TabControl1.EndInit
            Me.TabControl1.ResumeLayout(False)
            Me.TabResult.ResumeLayout(False)
            Me.TabAnalyse.ResumeLayout(False)
            Me.TabChart.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Public Overridable Sub LoadDataSet()
            Dim selectCommandText As String = ("SELECT * FROM " & Me.TableName & " ")
            If Information.IsNothing(Me.objDS.Tables.Item(Me.TableName)) Then
                Me.objDS.Tables.Add(Me.TableName)
            Else
                Me.objDS.Tables.Item(Me.TableName).Clear
            End If
            Try 
                Me.OledbAdpat = New OleDbDataAdapter(selectCommandText, Me.SessionInfo.OleDBConn)
                MyBase.BKFilter.ApplyFilter((Me.OledbAdpat), (Me.IsFiltered), Me.CurrentFilterID, (Me.WhereClause & ""), Me.StatusBar1.Panels.Item(1))
                MyBase.Cls1.FillDataSet(Me.objDS.Tables.Item(Me.TableName), (Me.OledbAdpat.SelectCommand.CommandText & " " & Me.OrderByClause), True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
            Try 
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError
            End Try
            Me.objDS.Tables.Item(Me.TableName).DefaultView.Sort = Me.NameField
            Me.Grid1.set_DataSource(Me.objDS.Tables.Item(Me.TableName).DefaultView)
            Me.UcPivotGrid1.PivotGrid1.set_DataSource(Me.objDS.Tables.Item(Me.TableName).DefaultView)
        End Sub

        Public Overridable Sub NewRecord(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.MaintenanceMenuID <> -1) Then
                Dim formName As String = MyBase.BKGlobal.GetFormName(Me.MaintenanceMenuID)
                Dim assemblyName As String = MyBase.BKGlobal.GetAssemblyName(Me.MaintenanceMenuID)
                If ((formName & "") <> "") Then
                    Dim maintenance As frmGeneral_Maintenance = DirectCast(MyBase.BKGlobal.GetForm(formName, assemblyName, Me.MaintenanceMenuID), frmGeneral_Maintenance)
                    maintenance.OpenType = "NEW"
                    maintenance.IDField = Me.IDField
                    maintenance.KeyFieldName = Me.NameField
                    maintenance.Tag = Me.MaintenanceMenuID
                    maintenance.KeyValue = ""
                    MyBase.BKGlobal.StartForm(maintenance, Me.MaintenanceMenuID, Me.ParentForm, True)
                    Me.LoadDataSet
                End If
            End If
        End Sub

        Public Overridable Sub SaveChanges(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateDataSet
        End Sub

        Public Overridable Sub StartUp()
            Try 
                Me.Misc_Bar.set_Visible(True)
                Me.HelpProvider1.HelpNamespace = (Me.SessionInfo.ApplDir & "\Help\" & Me.SessionInfo.UserLang & "\BizzKeys.chm")
                Me.SQLTxt1 = ("SELECT * FROM " & Me.TableName & " ")
                Me.CurrentFilterID = MyBase.BKFilter.FindDefaultFilter(Me.SessionInfo.UserID, Conversions.ToInteger(Me.Tag))
                If Me.AutoLoadData Then
                    Me.LoadDataSet
                End If
                Dim popMenuAssociatedTasks As MenuItem = Me.PopMenuAssociatedTasks
                MyBase.BKGlobal.LoadAssociatedMenu(Conversions.ToInteger(Me.Tag), (popMenuAssociatedTasks), Me)
                Me.PopMenuAssociatedTasks = popMenuAssociatedTasks
                Dim gridView As AdvBandedGridView = Me.GridView1
                Me.GridView1 = gridView
                Me.CurrentBrowseViewID = MyBase.BKBrowseView.LoadDefaultBrowseViewDefinition(Me.SessionInfo.UserID, Conversions.ToInteger(Me.Tag), Me.TableName, (gridView), Me.StatusBar1.Panels.Item(0))
                MyBase.BKGlobal.SetToolBar(Me.BarManager1, Conversions.ToInteger(Me.Tag), Me.CanNew, Me.CanEdit, Me.CanDelete, Me.CanSave, True, True, True, True, True, False, False)
                Me.Grid1.set_DataSource(Me.objDS.Tables.Item(Me.TableName).DefaultView)
                Me.UcPivotGrid1.Initialize(Me.SessionInfo)
                Me.UcPivotGrid1.PivotGrid1.set_DataSource(Me.objDS.Tables.Item(Me.TableName).DefaultView)
                Me.Grid1.set_DataMember("")
                Me.UcPivotGrid1.PivotGrid1.set_DataMember("")
                Me.UcPivotGrid1.SetFields
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Overridable Sub TabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs)
            Dim selectedTabPageChangedEvent As SelectedTabPageChangedEventHandler = Me.SelectedTabPageChangedEvent
            If (Not selectedTabPageChangedEvent Is Nothing) Then
                selectedTabPageChangedEvent.Invoke(RuntimeHelpers.GetObjectValue(sender), e)
            End If
        End Sub

        Public Overridable Sub UndoChanges(ByVal sender As Object, ByVal e As EventArgs)
            Me.GridView1.CancelUpdateCurrentRow
        End Sub

        Public Overridable Sub UpdateDataSet()
            If Me.CanSave Then
                Me.GridView1.CloseEditor
                Dim dataSet As DataSet = Me.objDS.Clone
                Me.BindingContext.Item(Me.objDS, Me.TableName).EndCurrentEdit
                dataSet = Me.objDS.GetChanges
                If (Not dataSet Is Nothing) Then
                    Try 
                        MyBase.Cls1.UpdateDataSource(dataSet.Tables.Item(Me.TableName), Me.SQLTxt1, True)
                        Me.objDS.Merge(dataSet)
                        Me.objDS.AcceptChanges
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Dim exception As Exception = exception1
                        Throw exception
                        ProjectData.ClearProjectError
                    End Try
                End If
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

        Public Overridable Property Grid1 As GridControl
            Get
                Return Me._Grid1
            End Get
            Set(ByVal WithEventsValue As GridControl)
                Me._Grid1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GridBand1 As GridBand
            Get
                Return Me._GridBand1
            End Get
            Set(ByVal WithEventsValue As GridBand)
                Me._GridBand1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property GridView1 As AdvBandedGridView
            Get
                Return Me._GridView1
            End Get
            Set(ByVal WithEventsValue As AdvBandedGridView)
                If (Not Me._GridView1 Is Nothing) Then
                    Me._GridView1.remove_ValidateRow(New ValidateRowEventHandler(Me, DirectCast(Me.Grid1_Validated, IntPtr)))
                    Me._GridView1.remove_DoubleClick(New EventHandler(AddressOf Me.gridview1_doubleclick))
                    Me._GridView1.remove_DoubleClick(New EventHandler(AddressOf Me.EventEditRecord))
                    Me._GridView1.remove_FocusedRowChanged(New FocusedRowChangedEventHandler(Me, DirectCast(Me.GridView1_FocusedRowChanged, IntPtr)))
                End If
                Me._GridView1 = WithEventsValue
                If (Not Me._GridView1 Is Nothing) Then
                    Me._GridView1.add_ValidateRow(New ValidateRowEventHandler(Me, DirectCast(Me.Grid1_Validated, IntPtr)))
                    Me._GridView1.add_DoubleClick(New EventHandler(AddressOf Me.gridview1_doubleclick))
                    Me._GridView1.add_DoubleClick(New EventHandler(AddressOf Me.EventEditRecord))
                    Me._GridView1.add_FocusedRowChanged(New FocusedRowChangedEventHandler(Me, DirectCast(Me.GridView1_FocusedRowChanged, IntPtr)))
                End If
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

        Public Overridable Property MenuItem9 As MenuItem
            Get
                Return Me._MenuItem9
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._MenuItem9 = WithEventsValue
            End Set
        End Property

        Public Overridable Property Panel1 As Panel
            Get
                Return Me._Panel1
            End Get
            Set(ByVal WithEventsValue As Panel)
                Me._Panel1 = WithEventsValue
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
                If (Not Me._PopMenuDelete Is Nothing) Then
                    RemoveHandler Me._PopMenuDelete.Click, New EventHandler(AddressOf Me.EventDeleteRecord)
                End If
                Me._PopMenuDelete = WithEventsValue
                If (Not Me._PopMenuDelete Is Nothing) Then
                    AddHandler Me._PopMenuDelete.Click, New EventHandler(AddressOf Me.EventDeleteRecord)
                End If
            End Set
        End Property

        Public Overridable Property PopMenuEdit As MenuItem
            Get
                Return Me._PopMenuEdit
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not Me._PopMenuEdit Is Nothing) Then
                    RemoveHandler Me._PopMenuEdit.Click, New EventHandler(AddressOf Me.EventEditRecord)
                End If
                Me._PopMenuEdit = WithEventsValue
                If (Not Me._PopMenuEdit Is Nothing) Then
                    AddHandler Me._PopMenuEdit.Click, New EventHandler(AddressOf Me.EventEditRecord)
                End If
            End Set
        End Property

        Public Overridable Property PopMenuNew As MenuItem
            Get
                Return Me._PopMenuNew
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not Me._PopMenuNew Is Nothing) Then
                    RemoveHandler Me._PopMenuNew.Click, New EventHandler(AddressOf Me.EventNewRecord)
                End If
                Me._PopMenuNew = WithEventsValue
                If (Not Me._PopMenuNew Is Nothing) Then
                    AddHandler Me._PopMenuNew.Click, New EventHandler(AddressOf Me.EventNewRecord)
                End If
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
                If (Not Me._PopMenuSave Is Nothing) Then
                    RemoveHandler Me._PopMenuSave.Click, New EventHandler(AddressOf Me.SaveChanges)
                End If
                Me._PopMenuSave = WithEventsValue
                If (Not Me._PopMenuSave Is Nothing) Then
                    AddHandler Me._PopMenuSave.Click, New EventHandler(AddressOf Me.SaveChanges)
                End If
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

        Public Overridable Property SaveFileDialog1 As SaveFileDialog
            Get
                Return Me._SaveFileDialog1
            End Get
            Set(ByVal WithEventsValue As SaveFileDialog)
                Me._SaveFileDialog1 = WithEventsValue
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

        Friend Overridable Property StatusBarPanel2 As StatusBarPanel
            Get
                Return Me._StatusBarPanel2
            End Get
            Set(ByVal WithEventsValue As StatusBarPanel)
                Me._StatusBarPanel2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property StatusBarPanel3 As StatusBarPanel
            Get
                Return Me._StatusBarPanel3
            End Get
            Set(ByVal WithEventsValue As StatusBarPanel)
                Me._StatusBarPanel3 = WithEventsValue
            End Set
        End Property

        Public Overridable Property TabAnalyse As XtraTabPage
            Get
                Return Me._TabAnalyse
            End Get
            Set(ByVal WithEventsValue As XtraTabPage)
                Me._TabAnalyse = WithEventsValue
            End Set
        End Property

        Public Overridable Property TabChart As XtraTabPage
            Get
                Return Me._TabChart
            End Get
            Set(ByVal WithEventsValue As XtraTabPage)
                Me._TabChart = WithEventsValue
            End Set
        End Property

        Public Overridable Property TabControl1 As XtraTabControl
            Get
                Return Me._TabControl1
            End Get
            Set(ByVal WithEventsValue As XtraTabControl)
                If (Not Me._TabControl1 Is Nothing) Then
                    Me._TabControl1.remove_SelectedPageChanged(New TabPageChangedEventHandler(Me, DirectCast(Me.TabControl1_SelectedPageChanged, IntPtr)))
                End If
                Me._TabControl1 = WithEventsValue
                If (Not Me._TabControl1 Is Nothing) Then
                    Me._TabControl1.add_SelectedPageChanged(New TabPageChangedEventHandler(Me, DirectCast(Me.TabControl1_SelectedPageChanged, IntPtr)))
                End If
            End Set
        End Property

        Public Overridable Property TabParameters As XtraTabPage
            Get
                Return Me._TabParameters
            End Get
            Set(ByVal WithEventsValue As XtraTabPage)
                Me._TabParameters = WithEventsValue
            End Set
        End Property

        Public Overridable Property TabResult As XtraTabPage
            Get
                Return Me._TabResult
            End Get
            Set(ByVal WithEventsValue As XtraTabPage)
                Me._TabResult = WithEventsValue
            End Set
        End Property

        Public Overridable Property UcChart1 As ucChart
            Get
                Return Me._UcChart1
            End Get
            Set(ByVal WithEventsValue As ucChart)
                Me._UcChart1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property UcPivotGrid1 As ucPivotGrid
            Get
                Return Me._UcPivotGrid1
            End Get
            Set(ByVal WithEventsValue As ucPivotGrid)
                Me._UcPivotGrid1 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("Bar1")> _
        Private _Bar1 As Bar
        <AccessedThroughProperty("Grid1")> _
        Private _Grid1 As GridControl
        <AccessedThroughProperty("GridBand1")> _
        Private _GridBand1 As GridBand
        <AccessedThroughProperty("GridView1")> _
        Private _GridView1 As AdvBandedGridView
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider
        <AccessedThroughProperty("MenuItem5")> _
        Private _MenuItem5 As MenuItem
        <AccessedThroughProperty("MenuItem7")> _
        Private _MenuItem7 As MenuItem
        <AccessedThroughProperty("MenuItem9")> _
        Private _MenuItem9 As MenuItem
        <AccessedThroughProperty("Panel1")> _
        Private _Panel1 As Panel
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
        <AccessedThroughProperty("RightMouseMenu")> _
        Private _RightMouseMenu As ContextMenu
        <AccessedThroughProperty("SaveFileDialog1")> _
        Private _SaveFileDialog1 As SaveFileDialog
        <AccessedThroughProperty("StatusBar1")> _
        Private _StatusBar1 As StatusBar
        <AccessedThroughProperty("StatusBarPanel2")> _
        Private _StatusBarPanel2 As StatusBarPanel
        <AccessedThroughProperty("StatusBarPanel3")> _
        Private _StatusBarPanel3 As StatusBarPanel
        <AccessedThroughProperty("TabAnalyse")> _
        Private _TabAnalyse As XtraTabPage
        <AccessedThroughProperty("TabChart")> _
        Private _TabChart As XtraTabPage
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As XtraTabControl
        <AccessedThroughProperty("TabParameters")> _
        Private _TabParameters As XtraTabPage
        <AccessedThroughProperty("TabResult")> _
        Private _TabResult As XtraTabPage
        <AccessedThroughProperty("UcChart1")> _
        Private _UcChart1 As ucChart
        <AccessedThroughProperty("UcPivotGrid1")> _
        Private _UcPivotGrid1 As ucPivotGrid
        Public AutoLoadData As Boolean
        Public CanDelete As Boolean
        Public CanEdit As Boolean
        Public CanNew As Boolean
        Public CanSave As Boolean
        Private components As IContainer
        Public CurrentBrowseViewID As Integer
        Public CurrentDefaultSetID As Integer
        Public CurrentFilterID As Integer
        Public CurrentReportID As Integer
        Public FilterTxt As String
        Public IDField As String
        Public IsFiltered As Boolean
        Public MaintenanceMenuID As Integer
        Public NameField As String
        Public objDS As DataSet
        Public OledbAdpat As OleDbDataAdapter
        Public OrderByClause As String
        Public SQLTxt1 As String
        Public TableName As String
        Public WhereClause As String

        ' Nested Types
        Public Delegate Sub SelectedTabPageChangedEventHandler(ByVal sender As Object, ByVal e As TabPageChangedEventArgs)
    End Class
End Namespace

