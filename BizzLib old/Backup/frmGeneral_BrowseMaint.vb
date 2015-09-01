Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmGeneral_BrowseMaint
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmGeneral_BrowseMaint.__ENCList
            SyncLock list
                frmGeneral_BrowseMaint.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableName = ""
            Me.IDField = ""
            Me.NameField = ""
            Me.KeyDataSet = ""
            Me.CurrentBrowseViewID = 0
            Me.CurrentFilterID = 0
            Me.CurrentReportID = 0
            Me.CurrentDefaultSetID = 0
            Me.FilterTxt = ""
            Me.IsFiltered = False
            Me.BaseGrid1 = New GridControl
            Me.BaseGridView1 = New AdvBandedGridView
            Me.BaseGridBand1 = New GridBand
            Me.ForCurrentEntityOnly = True
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmGeneral_BrowseMaint.__ENCList
            SyncLock list
                frmGeneral_BrowseMaint.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableName = ""
            Me.IDField = ""
            Me.NameField = ""
            Me.KeyDataSet = ""
            Me.CurrentBrowseViewID = 0
            Me.CurrentFilterID = 0
            Me.CurrentReportID = 0
            Me.CurrentDefaultSetID = 0
            Me.FilterTxt = ""
            Me.IsFiltered = False
            Me.BaseGrid1 = New GridControl
            Me.BaseGridView1 = New AdvBandedGridView
            Me.BaseGridBand1 = New GridBand
            Me.ForCurrentEntityOnly = True
            Me.InitializeComponent
        End Sub

        Public Overrides Sub Btn_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.CreateParameterTable(Me.MainDataSet)
            Dim ownerForm As Form = Me
            Dim view As AdvBandedGridView = Me.BaseGridView1
            Dim manager As BarManager = Me.BarManager1
            Dim bar As StatusBar = Me.StatusBar1
            MyBase.BKGlobal.ToolBarQueryBrowse_ToolClick2(RuntimeHelpers.GetObjectValue(sender), e.get_Item.get_Name, (ownerForm), (view), Me.MainDataSet, Me.TableName, Me.NameField, (manager), (Me.CurrentFilterID), (Me.CurrentReportID), (Me.CurrentDefaultSetID), (Me.CurrentBrowseViewID), (bar), New String() { Me.TableName, "ParaTable" })
            Me.StatusBar1 = bar
            Me.BarManager1 = manager
            Me.BaseGridView1 = view
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

        Public Overridable Sub CreateParameterTable(ByVal RptDs As DataSet)
            If Not Information.IsNothing(RptDs.Tables.Item("ParaTable")) Then
                RptDs.Tables.Remove("ParaTable")
            End If
            RptDs.Tables.Add("ParaTable")
        End Sub

        Public Overridable Sub DeleteRecord(ByVal sender As Object, ByVal e As EventArgs)
            If ((Interaction.MsgBox(MyBase.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes) AndAlso Me.ValidateBeforeDelete) Then
                Try 
                    Dim dataRow As DataRow = Me.BaseGridView1.GetDataRow(Me.BaseGridView1.get_FocusedRowHandle)
                    Me.BaseGridView1.DeleteRow(Me.BaseGridView1.get_FocusedRowHandle)
                    Me.UpdateDataSet
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, Nothing)
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Overridable Sub EditRecord(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Public Overridable Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            MyBase.BKBrowseView.SaveCurrentBrowseViewDefinition(Me.CurrentBrowseViewID, Me.TableName, Me.BaseGridView1, False)
            Me.UpdateDataSet
        End Sub

        Public Overridable Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            If (Not Me.DesignMode And (Me.TableName <> "")) Then
                Try 
                    Me.HelpProvider1.HelpNamespace = (".\Help\" & Me.SessionInfo.UserLang & "\BizzKeys.chm")
                    Me.LoadDataSet
                    Dim popMenuAssociatedTasks As MenuItem = Me.PopMenuAssociatedTasks
                    MyBase.BKGlobal.LoadAssociatedMenu(Conversions.ToInteger(Me.Tag), (popMenuAssociatedTasks), Me)
                    Me.PopMenuAssociatedTasks = popMenuAssociatedTasks
                    Dim gridView As AdvBandedGridView = Me.BaseGridView1
                    Me.BaseGridView1 = gridView
                    Me.CurrentBrowseViewID = MyBase.BKBrowseView.LoadDefaultBrowseViewDefinition(Me.SessionInfo.UserID, Conversions.ToInteger(Me.Tag), Me.TableName, (gridView), Me.StatusBar1.Panels.Item(0))
                    MyBase.BKGlobal.SetToolBar(Me.BarManager1, Conversions.ToInteger(Me.Tag), False, False, True, True, True, False, True, True, True, False, False)
                    Me.BaseGrid1.set_DataMember("")
                    Me.BaseGrid1.set_DataSource(Me.MainDataSet.Tables.Item(Me.TableName).DefaultView)
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    MessageBox.Show(exception.Message)
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Public Overridable Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
            Me.txtQuickSearch.set_EditValue(RuntimeHelpers.GetObjectValue(Me.BaseGridView1.GetRowCellValue(e.get_FocusedRowHandle, Me.BaseGridView1.get_Columns.get_Item(Me.NameField))))
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ResourceManager(GetType(frmGeneral_BrowseMaint))
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
            Me.Panel1 = New PanelControl
            Me.MainDataSet = New DataSet
            Me.BarButtonItem1 = New BarButtonItem
            Me.cmbViewListRepos.BeginInit
            Me.txtQuickSearchRepos.BeginInit
            Me.cmbReportListRepos.BeginInit
            Me.cmbFilterListRepos.BeginInit
            Me.BarManager1.BeginInit
            Me.cmbDefaultListRepos.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.StatusBarPanel3.BeginInit
            Me.Panel1.BeginInit
            Me.MainDataSet.BeginInit
            Me.SuspendLayout
            Me.View_Bar.set_DockCol(3)
            Me.View_Bar.set_Visible(True)
            Me.cmbViewListRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("cmbViewListRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.cmbViewListRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.BeepOnError")))
            Me.cmbViewListRepos.get_Mask.set_EditMask(manager.GetString("cmbViewListRepos.Mask.EditMask"))
            Me.cmbViewListRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.IgnoreMaskBlank")))
            Me.cmbViewListRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("cmbViewListRepos.Mask.MaskType")), MaskType))
            Me.cmbViewListRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("cmbViewListRepos.Mask.PlaceHolder")))
            Me.cmbViewListRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.SaveLiteral")))
            Me.cmbViewListRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.ShowPlaceHolders")))
            Me.cmbViewListRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.UseMaskAsDisplayFormat")))
            Me.QuickSearch_Bar.set_DockCol(2)
            Me.QuickSearch_Bar.set_Visible(True)
            Me.txtQuickSearchRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("txtQuickSearchRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.txtQuickSearchRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.BeepOnError")))
            Me.txtQuickSearchRepos.get_Mask.set_EditMask(manager.GetString("txtQuickSearchRepos.Mask.EditMask"))
            Me.txtQuickSearchRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.IgnoreMaskBlank")))
            Me.txtQuickSearchRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("txtQuickSearchRepos.Mask.MaskType")), MaskType))
            Me.txtQuickSearchRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("txtQuickSearchRepos.Mask.PlaceHolder")))
            Me.txtQuickSearchRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.SaveLiteral")))
            Me.txtQuickSearchRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.ShowPlaceHolders")))
            Me.txtQuickSearchRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.UseMaskAsDisplayFormat")))
            Me.Report_Bar.set_DockCol(2)
            Me.Report_Bar.set_DockRow(1)
            Me.Report_Bar.set_Visible(True)
            Me.cmbReportListRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("cmbReportListRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.cmbReportListRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.BeepOnError")))
            Me.cmbReportListRepos.get_Mask.set_EditMask(manager.GetString("cmbReportListRepos.Mask.EditMask"))
            Me.cmbReportListRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.IgnoreMaskBlank")))
            Me.cmbReportListRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("cmbReportListRepos.Mask.MaskType")), MaskType))
            Me.cmbReportListRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("cmbReportListRepos.Mask.PlaceHolder")))
            Me.cmbReportListRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.SaveLiteral")))
            Me.cmbReportListRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.ShowPlaceHolders")))
            Me.cmbReportListRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.UseMaskAsDisplayFormat")))
            Me.Filter_Bar.set_DockRow(1)
            Me.Filter_Bar.set_Offset(1)
            Me.Filter_Bar.set_Visible(True)
            Me.cmbFilterListRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("cmbFilterListRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.cmbFilterListRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.BeepOnError")))
            Me.cmbFilterListRepos.get_Mask.set_EditMask(manager.GetString("cmbFilterListRepos.Mask.EditMask"))
            Me.cmbFilterListRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.IgnoreMaskBlank")))
            Me.cmbFilterListRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("cmbFilterListRepos.Mask.MaskType")), MaskType))
            Me.cmbFilterListRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("cmbFilterListRepos.Mask.PlaceHolder")))
            Me.cmbFilterListRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.SaveLiteral")))
            Me.cmbFilterListRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.ShowPlaceHolders")))
            Me.cmbFilterListRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.UseMaskAsDisplayFormat")))
            Me.DefaultSet_Bar.set_DockCol(1)
            Me.DefaultSet_Bar.set_DockRow(1)
            Me.DefaultSet_Bar.set_Offset(0)
            Me.DefaultSet_Bar.set_Visible(True)
            Me.Main_Bar.set_Offset(2)
            Me.Main_Bar.set_Visible(True)
            Me.Misc_Bar.set_DockCol(1)
            Me.Misc_Bar.set_Offset(&H90)
            Me.Misc_Bar.set_Visible(True)
            Me.cmbDefaultListRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("cmbDefaultListRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.cmbDefaultListRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.BeepOnError")))
            Me.cmbDefaultListRepos.get_Mask.set_EditMask(manager.GetString("cmbDefaultListRepos.Mask.EditMask"))
            Me.cmbDefaultListRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.IgnoreMaskBlank")))
            Me.cmbDefaultListRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("cmbDefaultListRepos.Mask.MaskType")), MaskType))
            Me.cmbDefaultListRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("cmbDefaultListRepos.Mask.PlaceHolder")))
            Me.cmbDefaultListRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.SaveLiteral")))
            Me.cmbDefaultListRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.ShowPlaceHolders")))
            Me.cmbDefaultListRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.UseMaskAsDisplayFormat")))
            Me.RightMouseMenu.MenuItems.AddRange(New MenuItem() { Me.PopMenuNew, Me.PopMenuEdit, Me.PopMenuDelete, Me.PopMenuSave, Me.MenuItem5, Me.PopMenuPrintPreview, Me.MenuItem7, Me.PopMenuAssociatedTasks, Me.MenuItem9 })
            Me.RightMouseMenu.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("RightMouseMenu.RightToLeft")), RightToLeft)
            Me.PopMenuNew.Enabled = Conversions.ToBoolean(manager.GetObject("PopMenuNew.Enabled"))
            Me.PopMenuNew.Index = 0
            Me.PopMenuNew.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("PopMenuNew.Shortcut")), Shortcut)
            Me.PopMenuNew.ShowShortcut = Conversions.ToBoolean(manager.GetObject("PopMenuNew.ShowShortcut"))
            Me.PopMenuNew.Text = manager.GetString("PopMenuNew.Text")
            Me.PopMenuNew.Visible = Conversions.ToBoolean(manager.GetObject("PopMenuNew.Visible"))
            Me.PopMenuEdit.Enabled = Conversions.ToBoolean(manager.GetObject("PopMenuEdit.Enabled"))
            Me.PopMenuEdit.Index = 1
            Me.PopMenuEdit.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("PopMenuEdit.Shortcut")), Shortcut)
            Me.PopMenuEdit.ShowShortcut = Conversions.ToBoolean(manager.GetObject("PopMenuEdit.ShowShortcut"))
            Me.PopMenuEdit.Text = manager.GetString("PopMenuEdit.Text")
            Me.PopMenuEdit.Visible = Conversions.ToBoolean(manager.GetObject("PopMenuEdit.Visible"))
            Me.PopMenuDelete.Enabled = Conversions.ToBoolean(manager.GetObject("PopMenuDelete.Enabled"))
            Me.PopMenuDelete.Index = 2
            Me.PopMenuDelete.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("PopMenuDelete.Shortcut")), Shortcut)
            Me.PopMenuDelete.ShowShortcut = Conversions.ToBoolean(manager.GetObject("PopMenuDelete.ShowShortcut"))
            Me.PopMenuDelete.Text = manager.GetString("PopMenuDelete.Text")
            Me.PopMenuDelete.Visible = Conversions.ToBoolean(manager.GetObject("PopMenuDelete.Visible"))
            Me.PopMenuSave.Enabled = Conversions.ToBoolean(manager.GetObject("PopMenuSave.Enabled"))
            Me.PopMenuSave.Index = 3
            Me.PopMenuSave.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("PopMenuSave.Shortcut")), Shortcut)
            Me.PopMenuSave.ShowShortcut = Conversions.ToBoolean(manager.GetObject("PopMenuSave.ShowShortcut"))
            Me.PopMenuSave.Text = manager.GetString("PopMenuSave.Text")
            Me.PopMenuSave.Visible = Conversions.ToBoolean(manager.GetObject("PopMenuSave.Visible"))
            Me.MenuItem5.Enabled = Conversions.ToBoolean(manager.GetObject("MenuItem5.Enabled"))
            Me.MenuItem5.Index = 4
            Me.MenuItem5.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("MenuItem5.Shortcut")), Shortcut)
            Me.MenuItem5.ShowShortcut = Conversions.ToBoolean(manager.GetObject("MenuItem5.ShowShortcut"))
            Me.MenuItem5.Text = manager.GetString("MenuItem5.Text")
            Me.MenuItem5.Visible = Conversions.ToBoolean(manager.GetObject("MenuItem5.Visible"))
            Me.PopMenuPrintPreview.Enabled = Conversions.ToBoolean(manager.GetObject("PopMenuPrintPreview.Enabled"))
            Me.PopMenuPrintPreview.Index = 5
            Me.PopMenuPrintPreview.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("PopMenuPrintPreview.Shortcut")), Shortcut)
            Me.PopMenuPrintPreview.ShowShortcut = Conversions.ToBoolean(manager.GetObject("PopMenuPrintPreview.ShowShortcut"))
            Me.PopMenuPrintPreview.Text = manager.GetString("PopMenuPrintPreview.Text")
            Me.PopMenuPrintPreview.Visible = Conversions.ToBoolean(manager.GetObject("PopMenuPrintPreview.Visible"))
            Me.MenuItem7.Enabled = Conversions.ToBoolean(manager.GetObject("MenuItem7.Enabled"))
            Me.MenuItem7.Index = 6
            Me.MenuItem7.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("MenuItem7.Shortcut")), Shortcut)
            Me.MenuItem7.ShowShortcut = Conversions.ToBoolean(manager.GetObject("MenuItem7.ShowShortcut"))
            Me.MenuItem7.Text = manager.GetString("MenuItem7.Text")
            Me.MenuItem7.Visible = Conversions.ToBoolean(manager.GetObject("MenuItem7.Visible"))
            Me.PopMenuAssociatedTasks.Enabled = Conversions.ToBoolean(manager.GetObject("PopMenuAssociatedTasks.Enabled"))
            Me.PopMenuAssociatedTasks.Index = 7
            Me.PopMenuAssociatedTasks.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("PopMenuAssociatedTasks.Shortcut")), Shortcut)
            Me.PopMenuAssociatedTasks.ShowShortcut = Conversions.ToBoolean(manager.GetObject("PopMenuAssociatedTasks.ShowShortcut"))
            Me.PopMenuAssociatedTasks.Text = manager.GetString("PopMenuAssociatedTasks.Text")
            Me.PopMenuAssociatedTasks.Visible = Conversions.ToBoolean(manager.GetObject("PopMenuAssociatedTasks.Visible"))
            Me.MenuItem9.Enabled = Conversions.ToBoolean(manager.GetObject("MenuItem9.Enabled"))
            Me.MenuItem9.Index = 8
            Me.MenuItem9.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("MenuItem9.Shortcut")), Shortcut)
            Me.MenuItem9.ShowShortcut = Conversions.ToBoolean(manager.GetObject("MenuItem9.ShowShortcut"))
            Me.MenuItem9.Text = manager.GetString("MenuItem9.Text")
            Me.MenuItem9.Visible = Conversions.ToBoolean(manager.GetObject("MenuItem9.Visible"))
            Me.HelpProvider1.HelpNamespace = manager.GetString("HelpProvider1.HelpNamespace")
            Me.StatusBar1.AccessibleDescription = manager.GetString("StatusBar1.AccessibleDescription")
            Me.StatusBar1.AccessibleName = manager.GetString("StatusBar1.AccessibleName")
            Me.StatusBar1.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBar1.Anchor")), AnchorStyles)
            Me.StatusBar1.BackgroundImage = DirectCast(manager.GetObject("StatusBar1.BackgroundImage"), Image)
            Me.StatusBar1.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBar1.Dock")), DockStyle)
            Me.StatusBar1.Enabled = Conversions.ToBoolean(manager.GetObject("StatusBar1.Enabled"))
            Me.StatusBar1.Font = DirectCast(manager.GetObject("StatusBar1.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.StatusBar1, manager.GetString("StatusBar1.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.StatusBar1, DirectCast(Conversions.ToInteger(manager.GetObject("StatusBar1.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.StatusBar1, manager.GetString("StatusBar1.HelpString"))
            Me.StatusBar1.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBar1.ImeMode")), ImeMode)
            Me.StatusBar1.Location = DirectCast(manager.GetObject("StatusBar1.Location"), Point)
            Me.StatusBar1.Name = "StatusBar1"
            Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel2, Me.StatusBarPanel3 })
            Me.StatusBar1.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBar1.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me.StatusBar1, Conversions.ToBoolean(manager.GetObject("StatusBar1.ShowHelp")))
            Me.StatusBar1.ShowPanels = True
            Me.StatusBar1.Size = DirectCast(manager.GetObject("StatusBar1.Size"), Size)
            Me.StatusBar1.TabIndex = Conversions.ToInteger(manager.GetObject("StatusBar1.TabIndex"))
            Me.StatusBar1.Text = manager.GetString("StatusBar1.Text")
            Me.StatusBar1.Visible = Conversions.ToBoolean(manager.GetObject("StatusBar1.Visible"))
            Me.StatusBarPanel2.Alignment = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBarPanel2.Alignment")), HorizontalAlignment)
            Me.StatusBarPanel2.AutoSize = StatusBarPanelAutoSize.Spring
            Me.StatusBarPanel2.Icon = DirectCast(manager.GetObject("StatusBarPanel2.Icon"), Icon)
            Me.StatusBarPanel2.MinWidth = Conversions.ToInteger(manager.GetObject("StatusBarPanel2.MinWidth"))
            Me.StatusBarPanel2.Text = manager.GetString("StatusBarPanel2.Text")
            Me.StatusBarPanel2.ToolTipText = manager.GetString("StatusBarPanel2.ToolTipText")
            Me.StatusBarPanel2.Width = Conversions.ToInteger(manager.GetObject("StatusBarPanel2.Width"))
            Me.StatusBarPanel3.Alignment = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBarPanel3.Alignment")), HorizontalAlignment)
            Me.StatusBarPanel3.Icon = DirectCast(manager.GetObject("StatusBarPanel3.Icon"), Icon)
            Me.StatusBarPanel3.MinWidth = Conversions.ToInteger(manager.GetObject("StatusBarPanel3.MinWidth"))
            Me.StatusBarPanel3.Text = manager.GetString("StatusBarPanel3.Text")
            Me.StatusBarPanel3.ToolTipText = manager.GetString("StatusBarPanel3.ToolTipText")
            Me.StatusBarPanel3.Width = Conversions.ToInteger(manager.GetObject("StatusBarPanel3.Width"))
            Me.Panel1.AccessibleDescription = manager.GetString("Panel1.AccessibleDescription")
            Me.Panel1.AccessibleName = manager.GetString("Panel1.AccessibleName")
            Me.Panel1.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("Panel1.Anchor")), AnchorStyles)
            Me.Panel1.set_AutoScroll(Conversions.ToBoolean(manager.GetObject("Panel1.AutoScroll")))
            Me.Panel1.set_AutoScrollMargin(DirectCast(manager.GetObject("Panel1.AutoScrollMargin"), Size))
            Me.Panel1.set_AutoScrollMinSize(DirectCast(manager.GetObject("Panel1.AutoScrollMinSize"), Size))
            Me.Panel1.get_Appearance.set_Image(DirectCast(manager.GetObject("Panel1.BackgroundImage"), Image))
            Me.Panel1.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("Panel1.Dock")), DockStyle)
            Me.Panel1.Enabled = Conversions.ToBoolean(manager.GetObject("Panel1.Enabled"))
            Me.HelpProvider1.SetHelpKeyword(Me.Panel1, manager.GetString("Panel1.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.Panel1, DirectCast(Conversions.ToInteger(manager.GetObject("Panel1.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.Panel1, manager.GetString("Panel1.HelpString"))
            Me.Panel1.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("Panel1.ImeMode")), ImeMode)
            Me.Panel1.Location = DirectCast(manager.GetObject("Panel1.Location"), Point)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("Panel1.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me.Panel1, Conversions.ToBoolean(manager.GetObject("Panel1.ShowHelp")))
            Me.Panel1.Size = DirectCast(manager.GetObject("Panel1.Size"), Size)
            Me.Panel1.TabIndex = Conversions.ToInteger(manager.GetObject("Panel1.TabIndex"))
            Me.Panel1.set_Text(manager.GetString("Panel1.Text"))
            Me.Panel1.Visible = Conversions.ToBoolean(manager.GetObject("Panel1.Visible"))
            Me.MainDataSet.DataSetName = "NewDataSet"
            Me.MainDataSet.Locale = New CultureInfo("fr-BE")
            Me.BarButtonItem1.set_AccessibleDescription(manager.GetString("BarButtonItem1.AccessibleDescription"))
            Me.BarButtonItem1.set_AccessibleName(manager.GetString("BarButtonItem1.AccessibleName"))
            Me.BarButtonItem1.set_Caption(manager.GetString("BarButtonItem1.Caption"))
            Dim guid As New Guid("434484d9-7ac5-47e5-9412-313a111b7240")
            Me.BarButtonItem1.set_CategoryGuid(guid)
            Me.BarButtonItem1.set_Description(manager.GetString("BarButtonItem1.Description"))
            Me.BarButtonItem1.set_Glyph(DirectCast(manager.GetObject("BarButtonItem1.Glyph"), Image))
            Me.BarButtonItem1.set_Hint(manager.GetString("BarButtonItem1.Hint"))
            Me.BarButtonItem1.set_Id(0)
            Me.BarButtonItem1.set_Name("BarButtonItem1")
            Me.AccessibleDescription = manager.GetString("$this.AccessibleDescription")
            Me.AccessibleName = manager.GetString("$this.AccessibleName")
            Me.AutoScaleBaseSize = DirectCast(manager.GetObject("$this.AutoScaleBaseSize"), Size)
            Me.AutoScroll = Conversions.ToBoolean(manager.GetObject("$this.AutoScroll"))
            Me.AutoScrollMargin = DirectCast(manager.GetObject("$this.AutoScrollMargin"), Size)
            Me.AutoScrollMinSize = DirectCast(manager.GetObject("$this.AutoScrollMinSize"), Size)
            Me.BackgroundImage = DirectCast(manager.GetObject("$this.BackgroundImage"), Image)
            Me.ClientSize = DirectCast(manager.GetObject("$this.ClientSize"), Size)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.StatusBar1)
            Me.Enabled = Conversions.ToBoolean(manager.GetObject("$this.Enabled"))
            Me.Font = DirectCast(manager.GetObject("$this.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me, manager.GetString("$this.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me, DirectCast(Conversions.ToInteger(manager.GetObject("$this.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me, manager.GetString("$this.HelpString"))
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("$this.ImeMode")), ImeMode)
            Me.Location = DirectCast(manager.GetObject("$this.Location"), Point)
            Me.MaximumSize = DirectCast(manager.GetObject("$this.MaximumSize"), Size)
            Me.MinimumSize = DirectCast(manager.GetObject("$this.MinimumSize"), Size)
            Me.Name = "frmGeneral_BrowseMaint"
            Me.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("$this.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me, Conversions.ToBoolean(manager.GetObject("$this.ShowHelp")))
            Me.ShowInTaskbar = False
            Me.StartPosition = DirectCast(Conversions.ToInteger(manager.GetObject("$this.StartPosition")), FormStartPosition)
            Me.Text = manager.GetString("$this.Text")
            Me.Controls.SetChildIndex(Me.StatusBar1, 0)
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.cmbViewListRepos.EndInit
            Me.txtQuickSearchRepos.EndInit
            Me.cmbReportListRepos.EndInit
            Me.cmbFilterListRepos.EndInit
            Me.BarManager1.EndInit
            Me.cmbDefaultListRepos.EndInit
            Me.StatusBarPanel2.EndInit
            Me.StatusBarPanel3.EndInit
            Me.Panel1.EndInit
            Me.MainDataSet.EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Overridable Sub LoadDataSet()
            Dim dataSet As DataSet = Me.MainDataSet.Clone
            Dim sQLTxt As String = Me.SQLTxt1
            Try 
                If Me.ForCurrentEntityOnly Then
                    MyBase.BKFilter.ApplyFilter((sQLTxt), (Me.IsFiltered), Me.CurrentFilterID, (" WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & " "), Me.StatusBar1.Panels.Item(1))
                Else
                    MyBase.BKFilter.ApplyFilter((sQLTxt), (Me.IsFiltered), Me.CurrentFilterID, " ", Me.StatusBar1.Panels.Item(1))
                End If
                sQLTxt = (sQLTxt & " ORDER BY " & Me.NameField)
                MyBase.Cls1.FillDataSet(dataSet.Tables.Item(Me.TableName), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
            Try 
                Me.MainDataSet.Tables.Item(Me.TableName).Clear
                Me.MainDataSet.Merge(dataSet)
                If Me.ForCurrentEntityOnly Then
                    Me.MainDataSet.Tables.Item(Me.TableName).Columns.Item("EntityID").DefaultValue = Me.SessionInfo.EntityID
                End If
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Overridable Sub NewRecord(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Public Overridable Sub SaveChanges(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateDataSet
        End Sub

        Public Overridable Sub UndoChanges(ByVal sender As Object, ByVal e As EventArgs)
            Me.BaseGridView1.CancelUpdateCurrentRow
        End Sub

        Public Overridable Sub UpdateDataSet()
            Dim changes As DataSet = Me.MainDataSet.Clone
            Me.BaseGridView1.CloseEditor
            Me.BaseGridView1.UpdateCurrentRow
            Me.BindingContext.Item(Me.MainDataSet, Me.TableName).EndCurrentEdit
            changes = Me.MainDataSet.GetChanges
            If (Not changes Is Nothing) Then
                Try 
                    MyBase.Cls1.UpdateDataSource(changes.Tables.Item(Me.TableName), Me.SQLTxt1, True)
                    Me.MainDataSet.Tables.Item(Me.TableName).AcceptChanges
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Throw exception
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Public Overridable Function ValidateBeforeDelete() As Boolean
            Return True
        End Function


        ' Properties
        Public Overridable Property BarButtonItem1 As BarButtonItem
            Get
                Return Me._BarButtonItem1
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                Me._BarButtonItem1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property BaseGrid1 As GridControl
            Get
                Return Me._BaseGrid1
            End Get
            Set(ByVal WithEventsValue As GridControl)
                If (Not Me._BaseGrid1 Is Nothing) Then
                    RemoveHandler Me._BaseGrid1.DoubleClick, New EventHandler(AddressOf Me.EditRecord)
                End If
                Me._BaseGrid1 = WithEventsValue
                If (Not Me._BaseGrid1 Is Nothing) Then
                    AddHandler Me._BaseGrid1.DoubleClick, New EventHandler(AddressOf Me.EditRecord)
                End If
            End Set
        End Property

        Public Overridable Property BaseGridBand1 As GridBand
            Get
                Return Me._BaseGridBand1
            End Get
            Set(ByVal WithEventsValue As GridBand)
                Me._BaseGridBand1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property BaseGridView1 As AdvBandedGridView
            Get
                Return Me._BaseGridView1
            End Get
            Set(ByVal WithEventsValue As AdvBandedGridView)
                If (Not Me._BaseGridView1 Is Nothing) Then
                    Me._BaseGridView1.remove_FocusedRowChanged(New FocusedRowChangedEventHandler(Me, DirectCast(Me.GridView1_FocusedRowChanged, IntPtr)))
                End If
                Me._BaseGridView1 = WithEventsValue
                If (Not Me._BaseGridView1 Is Nothing) Then
                    Me._BaseGridView1.add_FocusedRowChanged(New FocusedRowChangedEventHandler(Me, DirectCast(Me.GridView1_FocusedRowChanged, IntPtr)))
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

        Public Overridable Property MainDataSet As DataSet
            Get
                Return Me._MainDataSet
            End Get
            Set(ByVal WithEventsValue As DataSet)
                Me._MainDataSet = WithEventsValue
            End Set
        End Property

        Public Overridable Property MenuItem5 As MenuItem
            Get
                Return Me._MenuItem5
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._MenuItem5 = WithEventsValue
            End Set
        End Property

        Public Overridable Property MenuItem7 As MenuItem
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

        Public Overridable Property Panel1 As PanelControl
            Get
                Return Me._Panel1
            End Get
            Set(ByVal WithEventsValue As PanelControl)
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
                    RemoveHandler Me._PopMenuDelete.Click, New EventHandler(AddressOf Me.DeleteRecord)
                End If
                Me._PopMenuDelete = WithEventsValue
                If (Not Me._PopMenuDelete Is Nothing) Then
                    AddHandler Me._PopMenuDelete.Click, New EventHandler(AddressOf Me.DeleteRecord)
                End If
            End Set
        End Property

        Public Overridable Property PopMenuEdit As MenuItem
            Get
                Return Me._PopMenuEdit
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not Me._PopMenuEdit Is Nothing) Then
                    RemoveHandler Me._PopMenuEdit.Click, New EventHandler(AddressOf Me.EditRecord)
                End If
                Me._PopMenuEdit = WithEventsValue
                If (Not Me._PopMenuEdit Is Nothing) Then
                    AddHandler Me._PopMenuEdit.Click, New EventHandler(AddressOf Me.EditRecord)
                End If
            End Set
        End Property

        Public Overridable Property PopMenuNew As MenuItem
            Get
                Return Me._PopMenuNew
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not Me._PopMenuNew Is Nothing) Then
                    RemoveHandler Me._PopMenuNew.Click, New EventHandler(AddressOf Me.NewRecord)
                End If
                Me._PopMenuNew = WithEventsValue
                If (Not Me._PopMenuNew Is Nothing) Then
                    AddHandler Me._PopMenuNew.Click, New EventHandler(AddressOf Me.NewRecord)
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

        Public Overridable Property StatusBar1 As StatusBar
            Get
                Return Me._StatusBar1
            End Get
            Set(ByVal WithEventsValue As StatusBar)
                Me._StatusBar1 = WithEventsValue
            End Set
        End Property

        Public Overridable Property StatusBarPanel2 As StatusBarPanel
            Get
                Return Me._StatusBarPanel2
            End Get
            Set(ByVal WithEventsValue As StatusBarPanel)
                Me._StatusBarPanel2 = WithEventsValue
            End Set
        End Property

        Public Overridable Property StatusBarPanel3 As StatusBarPanel
            Get
                Return Me._StatusBarPanel3
            End Get
            Set(ByVal WithEventsValue As StatusBarPanel)
                Me._StatusBarPanel3 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("BarButtonItem1")> _
        Private _BarButtonItem1 As BarButtonItem
        <AccessedThroughProperty("BaseGrid1")> _
        Private _BaseGrid1 As GridControl
        <AccessedThroughProperty("BaseGridBand1")> _
        Private _BaseGridBand1 As GridBand
        <AccessedThroughProperty("BaseGridView1")> _
        Private _BaseGridView1 As AdvBandedGridView
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
        <AccessedThroughProperty("Panel1")> _
        Private _Panel1 As PanelControl
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
        <AccessedThroughProperty("StatusBar1")> _
        Private _StatusBar1 As StatusBar
        <AccessedThroughProperty("StatusBarPanel2")> _
        Private _StatusBarPanel2 As StatusBarPanel
        <AccessedThroughProperty("StatusBarPanel3")> _
        Private _StatusBarPanel3 As StatusBarPanel
        Private components As IContainer
        Public CurrentBrowseViewID As Integer
        Public CurrentDefaultSetID As Integer
        Public CurrentFilterID As Integer
        Public CurrentReportID As Integer
        Public FilterTxt As String
        Public ForCurrentEntityOnly As Boolean
        Public IDField As String
        Public IsFiltered As Boolean
        Public KeyDataSet As String
        Public NameField As String
        Public SQLTxt1 As String
        Public TableName As String
    End Class
End Namespace

