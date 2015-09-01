Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraPrinting
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
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmgeneraldesctranslation_Maintenance
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmgeneraldesctranslation_Maintenance.__ENCList
            SyncLock list
                frmgeneraldesctranslation_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmgeneraldesctranslation_Maintenance.__ENCList
            SyncLock list
                frmgeneraldesctranslation_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Public Overrides Sub btnDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.DeleteRecord
        End Sub

        Public Overrides Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.UpdateDataSet
        End Sub

        Private Sub DeleteRecord()
            If Me.ValidateBeforeDelete Then
                Try 
                    Me.GridView1.DeleteRow(Me.GridView1.get_FocusedRowHandle)
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

        Private Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.GridView1.CloseEditor
            Me.UpdateDataSet
        End Sub

        Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.HelpProvider1.HelpNamespace = (".\Help\" & Me.SessionInfo.UserLang & "\BizzKeys.chm")
            Me.PrintableComponentLink1.set_Component(Me.Grid1)
            Try 
                Me.txtField.Text = Me.Field
                Me.txtFieldKey.Text = Me.FieldKey
                Me.txtFieldID.Text = Conversions.ToString(Me.FieldID)
                Me.LoadDataSet
                Dim popMenuAssociatedTasks As MenuItem = Me.PopMenuAssociatedTasks
                MyBase.BKGlobal.LoadAssociatedMenu(Conversions.ToInteger(Me.Tag), (popMenuAssociatedTasks), Me)
                Me.PopMenuAssociatedTasks = popMenuAssociatedTasks
                MyBase.BKGlobal.SetToolBar(Me.BarManager1, Conversions.ToInteger(Me.Tag), False, False, True, True, False, False, False, False, False, False, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError
            End Try
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ResourceManager(GetType(frmgeneraldesctranslation_Maintenance))
            Me.Grid1 = New GridControl
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
            Me.PopMenuUserTasks = New MenuItem
            Me.objDs1 = New dsGeneral
            Me.GridView1 = New AdvBandedGridView
            Me.GridBand1 = New GridBand
            Me.colLang = New BandedGridColumn
            Me.LookUpLang = New RepositoryItemLookUpEdit
            Me.objdsGeneral = New dsGeneral
            Me.colTranslate1 = New BandedGridColumn
            Me.Panel1 = New Panel
            Me.Panel2 = New Panel
            Me.lblFieldID = New Label
            Me.txtFieldID = New TextBox
            Me.lblCode = New Label
            Me.txtFieldKey = New TextBox
            Me.lblField = New Label
            Me.txtField = New TextBox
            Me.OleDbSelectCommand1 = New OleDbCommand
            Me.OleDbInsertCommand1 = New OleDbCommand
            Me.OleDbUpdateCommand1 = New OleDbCommand
            Me.OleDbDeleteCommand1 = New OleDbCommand
            Me.OleDbDataAdapter2 = New OleDbDataAdapter
            Me.OleDbDeleteCommand3 = New OleDbCommand
            Me.OleDbInsertCommand3 = New OleDbCommand
            Me.OleDbSelectCommand3 = New OleDbCommand
            Me.OleDbUpdateCommand3 = New OleDbCommand
            Me.OleDbDataAdapter1 = New OleDbDataAdapter
            Me.OleDbDeleteCommand2 = New OleDbCommand
            Me.OleDbInsertCommand2 = New OleDbCommand
            Me.OleDbSelectCommand2 = New OleDbCommand
            Me.OleDbUpdateCommand2 = New OleDbCommand
            Me.HelpProvider1 = New HelpProvider
            Me.StatusBar1 = New StatusBar
            Me.StatusBarPanel1 = New StatusBarPanel
            Me.StatusBarPanel2 = New StatusBarPanel
            Me.PrintingSystem1 = New PrintingSystem(Me.components)
            Me.PrintableComponentLink1 = New PrintableComponentLink(Me.components)
            Me.cmbDefaultListRepos.BeginInit
            Me.cmbViewListRepos.BeginInit
            Me.BarManager1.BeginInit
            Me.txtQuickSearchRepos.BeginInit
            Me.cmbFilterListRepos.BeginInit
            Me.cmbReportListRepos.BeginInit
            Me.Grid1.BeginInit
            Me.objDs1.BeginInit
            Me.GridView1.BeginInit
            Me.LookUpLang.BeginInit
            Me.objdsGeneral.BeginInit
            Me.Panel1.SuspendLayout
            Me.Panel2.SuspendLayout
            Me.StatusBarPanel1.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.PrintingSystem1.BeginInit
            Me.SuspendLayout
            Me.btnNew.set_Visibility(1)
            Me.btnEdit.set_Visibility(1)
            Me.cmbDefaultListRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("cmbDefaultListRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.cmbDefaultListRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.BeepOnError")))
            Me.cmbDefaultListRepos.get_Mask.set_EditMask(manager.GetString("cmbDefaultListRepos.Mask.EditMask"))
            Me.cmbDefaultListRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.IgnoreMaskBlank")))
            Me.cmbDefaultListRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("cmbDefaultListRepos.Mask.MaskType")), MaskType))
            Me.cmbDefaultListRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("cmbDefaultListRepos.Mask.PlaceHolder")))
            Me.cmbDefaultListRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.SaveLiteral")))
            Me.cmbDefaultListRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.ShowPlaceHolders")))
            Me.cmbDefaultListRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("cmbDefaultListRepos.Mask.UseMaskAsDisplayFormat")))
            Me.Main_Bar.set_Visible(True)
            Me.cmbViewListRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("cmbViewListRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.cmbViewListRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.BeepOnError")))
            Me.cmbViewListRepos.get_Mask.set_EditMask(manager.GetString("cmbViewListRepos.Mask.EditMask"))
            Me.cmbViewListRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.IgnoreMaskBlank")))
            Me.cmbViewListRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("cmbViewListRepos.Mask.MaskType")), MaskType))
            Me.cmbViewListRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("cmbViewListRepos.Mask.PlaceHolder")))
            Me.cmbViewListRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.SaveLiteral")))
            Me.cmbViewListRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.ShowPlaceHolders")))
            Me.cmbViewListRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("cmbViewListRepos.Mask.UseMaskAsDisplayFormat")))
            Me.txtQuickSearchRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("txtQuickSearchRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.txtQuickSearchRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.BeepOnError")))
            Me.txtQuickSearchRepos.get_Mask.set_EditMask(manager.GetString("txtQuickSearchRepos.Mask.EditMask"))
            Me.txtQuickSearchRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.IgnoreMaskBlank")))
            Me.txtQuickSearchRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("txtQuickSearchRepos.Mask.MaskType")), MaskType))
            Me.txtQuickSearchRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("txtQuickSearchRepos.Mask.PlaceHolder")))
            Me.txtQuickSearchRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.SaveLiteral")))
            Me.txtQuickSearchRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.ShowPlaceHolders")))
            Me.txtQuickSearchRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("txtQuickSearchRepos.Mask.UseMaskAsDisplayFormat")))
            Me.cmbFilterListRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("cmbFilterListRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.cmbFilterListRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.BeepOnError")))
            Me.cmbFilterListRepos.get_Mask.set_EditMask(manager.GetString("cmbFilterListRepos.Mask.EditMask"))
            Me.cmbFilterListRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.IgnoreMaskBlank")))
            Me.cmbFilterListRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("cmbFilterListRepos.Mask.MaskType")), MaskType))
            Me.cmbFilterListRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("cmbFilterListRepos.Mask.PlaceHolder")))
            Me.cmbFilterListRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.SaveLiteral")))
            Me.cmbFilterListRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.ShowPlaceHolders")))
            Me.cmbFilterListRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("cmbFilterListRepos.Mask.UseMaskAsDisplayFormat")))
            Me.cmbReportListRepos.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("cmbReportListRepos.Mask.AutoComplete")), AutoCompleteType))
            Me.cmbReportListRepos.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.BeepOnError")))
            Me.cmbReportListRepos.get_Mask.set_EditMask(manager.GetString("cmbReportListRepos.Mask.EditMask"))
            Me.cmbReportListRepos.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.IgnoreMaskBlank")))
            Me.cmbReportListRepos.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("cmbReportListRepos.Mask.MaskType")), MaskType))
            Me.cmbReportListRepos.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("cmbReportListRepos.Mask.PlaceHolder")))
            Me.cmbReportListRepos.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.SaveLiteral")))
            Me.cmbReportListRepos.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.ShowPlaceHolders")))
            Me.cmbReportListRepos.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("cmbReportListRepos.Mask.UseMaskAsDisplayFormat")))
            Me.Grid1.AccessibleDescription = manager.GetString("Grid1.AccessibleDescription")
            Me.Grid1.AccessibleName = manager.GetString("Grid1.AccessibleName")
            Me.Grid1.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.Anchor")), AnchorStyles)
            Me.Grid1.BackgroundImage = DirectCast(manager.GetObject("Grid1.BackgroundImage"), Image)
            Me.Grid1.ContextMenu = Me.RightMouseMenu
            Me.Grid1.set_DataMember(manager.GetString("Grid1.DataMember"))
            Me.Grid1.set_DataSource(Me.objDs1)
            Me.Grid1.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.Dock")), DockStyle)
            Me.Grid1.get_EmbeddedNavigator.AccessibleDescription = manager.GetString("Grid1.EmbeddedNavigator.AccessibleDescription")
            Me.Grid1.get_EmbeddedNavigator.AccessibleName = manager.GetString("Grid1.EmbeddedNavigator.AccessibleName")
            Me.Grid1.get_EmbeddedNavigator.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.EmbeddedNavigator.Anchor")), AnchorStyles)
            Me.Grid1.get_EmbeddedNavigator.BackgroundImage = DirectCast(manager.GetObject("Grid1.EmbeddedNavigator.BackgroundImage"), Image)
            Me.Grid1.get_EmbeddedNavigator.Enabled = Conversions.ToBoolean(manager.GetObject("Grid1.EmbeddedNavigator.Enabled"))
            Me.Grid1.get_EmbeddedNavigator.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.EmbeddedNavigator.ImeMode")), ImeMode)
            Me.Grid1.get_EmbeddedNavigator.Name = ""
            Me.Grid1.get_EmbeddedNavigator.Text = manager.GetString("Grid1.EmbeddedNavigator.Text")
            Me.Grid1.get_EmbeddedNavigator.set_TextLocation(DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.EmbeddedNavigator.TextLocation")), NavigatorButtonsTextLocation))
            Me.Grid1.get_EmbeddedNavigator.set_TextStringFormat(manager.GetString("Grid1.EmbeddedNavigator.TextStringFormat"))
            Me.Grid1.get_EmbeddedNavigator.set_ToolTip(manager.GetString("Grid1.EmbeddedNavigator.ToolTip"))
            Me.Grid1.get_EmbeddedNavigator.set_ToolTipIconType(DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.EmbeddedNavigator.ToolTipIconType")), ToolTipIconType))
            Me.Grid1.get_EmbeddedNavigator.set_ToolTipTitle(manager.GetString("Grid1.EmbeddedNavigator.ToolTipTitle"))
            Me.Grid1.Enabled = Conversions.ToBoolean(manager.GetObject("Grid1.Enabled"))
            Me.Grid1.Font = DirectCast(manager.GetObject("Grid1.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.Grid1, manager.GetString("Grid1.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.Grid1, DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.Grid1, manager.GetString("Grid1.HelpString"))
            Me.Grid1.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.ImeMode")), ImeMode)
            Me.Grid1.Location = DirectCast(manager.GetObject("Grid1.Location"), Point)
            Me.Grid1.set_MainView(Me.GridView1)
            Me.Grid1.Name = "Grid1"
            Me.Grid1.get_RepositoryItems.AddRange(New RepositoryItem() { Me.LookUpLang })
            Me.Grid1.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("Grid1.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me.Grid1, Conversions.ToBoolean(manager.GetObject("Grid1.ShowHelp")))
            Me.Grid1.Size = DirectCast(manager.GetObject("Grid1.Size"), Size)
            Me.Grid1.TabIndex = Conversions.ToInteger(manager.GetObject("Grid1.TabIndex"))
            Me.Grid1.get_ViewCollection.AddRange(New BaseView() { Me.GridView1 })
            Me.Grid1.Visible = Conversions.ToBoolean(manager.GetObject("Grid1.Visible"))
            Me.RightMouseMenu.MenuItems.AddRange(New MenuItem() { Me.PopMenuNew, Me.PopMenuEdit, Me.PopMenuDelete, Me.PopMenuSave, Me.MenuItem5, Me.PopMenuPrintPreview, Me.MenuItem7, Me.PopMenuAssociatedTasks, Me.MenuItem9, Me.PopMenuUserTasks })
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
            Me.PopMenuUserTasks.Enabled = Conversions.ToBoolean(manager.GetObject("PopMenuUserTasks.Enabled"))
            Me.PopMenuUserTasks.Index = 9
            Me.PopMenuUserTasks.Shortcut = DirectCast(Conversions.ToInteger(manager.GetObject("PopMenuUserTasks.Shortcut")), Shortcut)
            Me.PopMenuUserTasks.ShowShortcut = Conversions.ToBoolean(manager.GetObject("PopMenuUserTasks.ShowShortcut"))
            Me.PopMenuUserTasks.Text = manager.GetString("PopMenuUserTasks.Text")
            Me.PopMenuUserTasks.Visible = Conversions.ToBoolean(manager.GetObject("PopMenuUserTasks.Visible"))
            Me.objDs1.DataSetName = "dsGeneral"
            Me.objDs1.Locale = New CultureInfo("en-US")
            Me.GridView1.get_Bands.AddRange(New GridBand() { Me.GridBand1 })
            Me.GridView1.set_ChildGridLevelName(manager.GetString("GridView1.ChildGridLevelName"))
            Me.GridView1.get_Columns.AddRange(New BandedGridColumn() { Me.colLang, Me.colTranslate1 })
            Me.GridView1.set_GridControl(Me.Grid1)
            Me.GridView1.set_GroupFormat(manager.GetString("GridView1.GroupFormat"))
            Me.GridView1.set_GroupPanelText(manager.GetString("GridView1.GroupPanelText"))
            Me.GridView1.set_Name("GridView1")
            Me.GridView1.set_NewItemRowText(manager.GetString("GridView1.NewItemRowText"))
            Me.GridView1.get_OptionsView.set_NewItemRowPosition(2)
            Me.GridView1.get_OptionsView.set_ShowBands(False)
            Me.GridView1.set_PreviewFieldName(manager.GetString("GridView1.PreviewFieldName"))
            Me.GridView1.set_VertScrollTipFieldName(manager.GetString("GridView1.VertScrollTipFieldName"))
            Me.GridView1.set_ViewCaption(manager.GetString("GridView1.ViewCaption"))
            Me.GridBand1.set_AutoFillDown(Conversions.ToBoolean(manager.GetObject("GridBand1.AutoFillDown")))
            Me.GridBand1.set_Caption(manager.GetString("GridBand1.Caption"))
            Me.GridBand1.get_Columns.Add(Me.colLang)
            Me.GridBand1.get_Columns.Add(Me.colTranslate1)
            Me.GridBand1.set_CustomizationCaption(manager.GetString("GridBand1.CustomizationCaption"))
            Me.GridBand1.set_Fixed(DirectCast(Conversions.ToInteger(manager.GetObject("GridBand1.Fixed")), FixedStyle))
            Me.GridBand1.set_ImageAlignment(DirectCast(Conversions.ToInteger(manager.GetObject("GridBand1.ImageAlignment")), StringAlignment))
            Me.GridBand1.set_ImageIndex(Conversions.ToInteger(manager.GetObject("GridBand1.ImageIndex")))
            Me.GridBand1.set_MinWidth(Conversions.ToInteger(manager.GetObject("GridBand1.MinWidth")))
            Me.GridBand1.set_Name(manager.GetString("GridBand1.Name"))
            Me.GridBand1.set_RowCount(Conversions.ToInteger(manager.GetObject("GridBand1.RowCount")))
            Me.GridBand1.set_ToolTip(manager.GetString("GridBand1.ToolTip"))
            Me.GridBand1.set_Visible(Conversions.ToBoolean(manager.GetObject("GridBand1.Visible")))
            Me.GridBand1.set_Width(Conversions.ToInteger(manager.GetObject("GridBand1.Width")))
            Me.colLang.set_Caption(manager.GetString("colLang.Caption"))
            Me.colLang.set_ColumnEdit(Me.LookUpLang)
            Me.colLang.set_CustomizationCaption(manager.GetString("colLang.CustomizationCaption"))
            Me.colLang.set_FieldName(manager.GetString("colLang.FieldName"))
            Me.colLang.set_ImageAlignment(DirectCast(Conversions.ToInteger(manager.GetObject("colLang.ImageAlignment")), StringAlignment))
            Me.colLang.set_ImageIndex(Conversions.ToInteger(manager.GetObject("colLang.ImageIndex")))
            Me.colLang.set_Name("colLang")
            Me.colLang.set_ToolTip(manager.GetString("colLang.ToolTip"))
            Me.colLang.set_Visible(Conversions.ToBoolean(manager.GetObject("colLang.Visible")))
            Me.colLang.set_Width(Conversions.ToInteger(manager.GetObject("colLang.Width")))
            Me.LookUpLang.set_AccessibleDescription(manager.GetString("LookUpLang.AccessibleDescription"))
            Me.LookUpLang.set_AccessibleName(manager.GetString("LookUpLang.AccessibleName"))
            Me.LookUpLang.set_AutoHeight(Conversions.ToBoolean(manager.GetObject("LookUpLang.AutoHeight")))
            Me.LookUpLang.get_Buttons.AddRange(New EditorButton() { New EditorButton(-5) })
            Me.LookUpLang.get_Columns.AddRange(New LookUpColumnInfo() { New LookUpColumnInfo("Lang", "Lang", &H2E, 0, "", True, 1), New LookUpColumnInfo("Description", "Description", &H40, 0, "", True, 1) })
            Me.LookUpLang.set_DataSource(Me.objdsGeneral.systemlanguagecode)
            Me.LookUpLang.set_DisplayMember("Lang")
            Me.LookUpLang.get_Mask.set_AutoComplete(DirectCast(Conversions.ToInteger(manager.GetObject("LookUpLang.Mask.AutoComplete")), AutoCompleteType))
            Me.LookUpLang.get_Mask.set_BeepOnError(Conversions.ToBoolean(manager.GetObject("LookUpLang.Mask.BeepOnError")))
            Me.LookUpLang.get_Mask.set_EditMask(manager.GetString("LookUpLang.Mask.EditMask"))
            Me.LookUpLang.get_Mask.set_IgnoreMaskBlank(Conversions.ToBoolean(manager.GetObject("LookUpLang.Mask.IgnoreMaskBlank")))
            Me.LookUpLang.get_Mask.set_MaskType(DirectCast(Conversions.ToInteger(manager.GetObject("LookUpLang.Mask.MaskType")), MaskType))
            Me.LookUpLang.get_Mask.set_PlaceHolder(Conversions.ToChar(manager.GetObject("LookUpLang.Mask.PlaceHolder")))
            Me.LookUpLang.get_Mask.set_SaveLiteral(Conversions.ToBoolean(manager.GetObject("LookUpLang.Mask.SaveLiteral")))
            Me.LookUpLang.get_Mask.set_ShowPlaceHolders(Conversions.ToBoolean(manager.GetObject("LookUpLang.Mask.ShowPlaceHolders")))
            Me.LookUpLang.get_Mask.set_UseMaskAsDisplayFormat(Conversions.ToBoolean(manager.GetObject("LookUpLang.Mask.UseMaskAsDisplayFormat")))
            Me.LookUpLang.set_Name("LookUpLang")
            Me.LookUpLang.set_NullText(manager.GetString("LookUpLang.NullText"))
            Me.LookUpLang.set_ValueMember("Lang")
            Me.objdsGeneral.DataSetName = "dsGeneral"
            Me.objdsGeneral.Locale = New CultureInfo("en-US")
            Me.colTranslate1.set_Caption(manager.GetString("colTranslate1.Caption"))
            Me.colTranslate1.set_CustomizationCaption(manager.GetString("colTranslate1.CustomizationCaption"))
            Me.colTranslate1.set_FieldName(manager.GetString("colTranslate1.FieldName"))
            Me.colTranslate1.set_ImageAlignment(DirectCast(Conversions.ToInteger(manager.GetObject("colTranslate1.ImageAlignment")), StringAlignment))
            Me.colTranslate1.set_ImageIndex(Conversions.ToInteger(manager.GetObject("colTranslate1.ImageIndex")))
            Me.colTranslate1.set_Name("colTranslate1")
            Me.colTranslate1.set_ToolTip(manager.GetString("colTranslate1.ToolTip"))
            Me.colTranslate1.set_Visible(Conversions.ToBoolean(manager.GetObject("colTranslate1.Visible")))
            Me.colTranslate1.set_Width(Conversions.ToInteger(manager.GetObject("colTranslate1.Width")))
            Me.Panel1.AccessibleDescription = manager.GetString("Panel1.AccessibleDescription")
            Me.Panel1.AccessibleName = manager.GetString("Panel1.AccessibleName")
            Me.Panel1.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("Panel1.Anchor")), AnchorStyles)
            Me.Panel1.AutoScroll = Conversions.ToBoolean(manager.GetObject("Panel1.AutoScroll"))
            Me.Panel1.AutoScrollMargin = DirectCast(manager.GetObject("Panel1.AutoScrollMargin"), Size)
            Me.Panel1.AutoScrollMinSize = DirectCast(manager.GetObject("Panel1.AutoScrollMinSize"), Size)
            Me.Panel1.BackgroundImage = DirectCast(manager.GetObject("Panel1.BackgroundImage"), Image)
            Me.Panel1.Controls.Add(Me.Grid1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("Panel1.Dock")), DockStyle)
            Me.Panel1.Enabled = Conversions.ToBoolean(manager.GetObject("Panel1.Enabled"))
            Me.Panel1.Font = DirectCast(manager.GetObject("Panel1.Font"), Font)
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
            Me.Panel1.Text = manager.GetString("Panel1.Text")
            Me.Panel1.Visible = Conversions.ToBoolean(manager.GetObject("Panel1.Visible"))
            Me.Panel2.AccessibleDescription = manager.GetString("Panel2.AccessibleDescription")
            Me.Panel2.AccessibleName = manager.GetString("Panel2.AccessibleName")
            Me.Panel2.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("Panel2.Anchor")), AnchorStyles)
            Me.Panel2.AutoScroll = Conversions.ToBoolean(manager.GetObject("Panel2.AutoScroll"))
            Me.Panel2.AutoScrollMargin = DirectCast(manager.GetObject("Panel2.AutoScrollMargin"), Size)
            Me.Panel2.AutoScrollMinSize = DirectCast(manager.GetObject("Panel2.AutoScrollMinSize"), Size)
            Me.Panel2.BackgroundImage = DirectCast(manager.GetObject("Panel2.BackgroundImage"), Image)
            Me.Panel2.ContextMenu = Me.RightMouseMenu
            Me.Panel2.Controls.Add(Me.lblFieldID)
            Me.Panel2.Controls.Add(Me.txtFieldID)
            Me.Panel2.Controls.Add(Me.lblCode)
            Me.Panel2.Controls.Add(Me.txtFieldKey)
            Me.Panel2.Controls.Add(Me.lblField)
            Me.Panel2.Controls.Add(Me.txtField)
            Me.Panel2.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("Panel2.Dock")), DockStyle)
            Me.Panel2.Enabled = Conversions.ToBoolean(manager.GetObject("Panel2.Enabled"))
            Me.Panel2.Font = DirectCast(manager.GetObject("Panel2.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.Panel2, manager.GetString("Panel2.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.Panel2, DirectCast(Conversions.ToInteger(manager.GetObject("Panel2.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.Panel2, manager.GetString("Panel2.HelpString"))
            Me.Panel2.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("Panel2.ImeMode")), ImeMode)
            Me.Panel2.Location = DirectCast(manager.GetObject("Panel2.Location"), Point)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("Panel2.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me.Panel2, Conversions.ToBoolean(manager.GetObject("Panel2.ShowHelp")))
            Me.Panel2.Size = DirectCast(manager.GetObject("Panel2.Size"), Size)
            Me.Panel2.TabIndex = Conversions.ToInteger(manager.GetObject("Panel2.TabIndex"))
            Me.Panel2.Text = manager.GetString("Panel2.Text")
            Me.Panel2.Visible = Conversions.ToBoolean(manager.GetObject("Panel2.Visible"))
            Me.lblFieldID.AccessibleDescription = manager.GetString("lblFieldID.AccessibleDescription")
            Me.lblFieldID.AccessibleName = manager.GetString("lblFieldID.AccessibleName")
            Me.lblFieldID.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("lblFieldID.Anchor")), AnchorStyles)
            Me.lblFieldID.AutoSize = Conversions.ToBoolean(manager.GetObject("lblFieldID.AutoSize"))
            Me.lblFieldID.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("lblFieldID.Dock")), DockStyle)
            Me.lblFieldID.Enabled = Conversions.ToBoolean(manager.GetObject("lblFieldID.Enabled"))
            Me.lblFieldID.Font = DirectCast(manager.GetObject("lblFieldID.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.lblFieldID, manager.GetString("lblFieldID.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.lblFieldID, DirectCast(Conversions.ToInteger(manager.GetObject("lblFieldID.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.lblFieldID, manager.GetString("lblFieldID.HelpString"))
            Me.lblFieldID.Image = DirectCast(manager.GetObject("lblFieldID.Image"), Image)
            Me.lblFieldID.ImageAlign = DirectCast(Conversions.ToInteger(manager.GetObject("lblFieldID.ImageAlign")), ContentAlignment)
            Me.lblFieldID.ImageIndex = Conversions.ToInteger(manager.GetObject("lblFieldID.ImageIndex"))
            Me.lblFieldID.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("lblFieldID.ImeMode")), ImeMode)
            Me.lblFieldID.Location = DirectCast(manager.GetObject("lblFieldID.Location"), Point)
            Me.lblFieldID.Name = "lblFieldID"
            Me.lblFieldID.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("lblFieldID.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me.lblFieldID, Conversions.ToBoolean(manager.GetObject("lblFieldID.ShowHelp")))
            Me.lblFieldID.Size = DirectCast(manager.GetObject("lblFieldID.Size"), Size)
            Me.lblFieldID.TabIndex = Conversions.ToInteger(manager.GetObject("lblFieldID.TabIndex"))
            Me.lblFieldID.Text = manager.GetString("lblFieldID.Text")
            Me.lblFieldID.TextAlign = DirectCast(Conversions.ToInteger(manager.GetObject("lblFieldID.TextAlign")), ContentAlignment)
            Me.lblFieldID.Visible = Conversions.ToBoolean(manager.GetObject("lblFieldID.Visible"))
            Me.txtFieldID.AccessibleDescription = manager.GetString("txtFieldID.AccessibleDescription")
            Me.txtFieldID.AccessibleName = manager.GetString("txtFieldID.AccessibleName")
            Me.txtFieldID.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldID.Anchor")), AnchorStyles)
            Me.txtFieldID.AutoSize = Conversions.ToBoolean(manager.GetObject("txtFieldID.AutoSize"))
            Me.txtFieldID.BackgroundImage = DirectCast(manager.GetObject("txtFieldID.BackgroundImage"), Image)
            Me.txtFieldID.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldID.Dock")), DockStyle)
            Me.txtFieldID.Enabled = Conversions.ToBoolean(manager.GetObject("txtFieldID.Enabled"))
            Me.txtFieldID.Font = DirectCast(manager.GetObject("txtFieldID.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.txtFieldID, manager.GetString("txtFieldID.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.txtFieldID, DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldID.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.txtFieldID, manager.GetString("txtFieldID.HelpString"))
            Me.txtFieldID.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldID.ImeMode")), ImeMode)
            Me.txtFieldID.Location = DirectCast(manager.GetObject("txtFieldID.Location"), Point)
            Me.txtFieldID.MaxLength = Conversions.ToInteger(manager.GetObject("txtFieldID.MaxLength"))
            Me.txtFieldID.Multiline = Conversions.ToBoolean(manager.GetObject("txtFieldID.Multiline"))
            Me.txtFieldID.Name = "txtFieldID"
            Me.txtFieldID.PasswordChar = Conversions.ToChar(manager.GetObject("txtFieldID.PasswordChar"))
            Me.txtFieldID.ReadOnly = True
            Me.txtFieldID.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldID.RightToLeft")), RightToLeft)
            Me.txtFieldID.ScrollBars = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldID.ScrollBars")), ScrollBars)
            Me.HelpProvider1.SetShowHelp(Me.txtFieldID, Conversions.ToBoolean(manager.GetObject("txtFieldID.ShowHelp")))
            Me.txtFieldID.Size = DirectCast(manager.GetObject("txtFieldID.Size"), Size)
            Me.txtFieldID.TabIndex = Conversions.ToInteger(manager.GetObject("txtFieldID.TabIndex"))
            Me.txtFieldID.Text = manager.GetString("txtFieldID.Text")
            Me.txtFieldID.TextAlign = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldID.TextAlign")), HorizontalAlignment)
            Me.txtFieldID.Visible = Conversions.ToBoolean(manager.GetObject("txtFieldID.Visible"))
            Me.txtFieldID.WordWrap = Conversions.ToBoolean(manager.GetObject("txtFieldID.WordWrap"))
            Me.lblCode.AccessibleDescription = manager.GetString("lblCode.AccessibleDescription")
            Me.lblCode.AccessibleName = manager.GetString("lblCode.AccessibleName")
            Me.lblCode.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("lblCode.Anchor")), AnchorStyles)
            Me.lblCode.AutoSize = Conversions.ToBoolean(manager.GetObject("lblCode.AutoSize"))
            Me.lblCode.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("lblCode.Dock")), DockStyle)
            Me.lblCode.Enabled = Conversions.ToBoolean(manager.GetObject("lblCode.Enabled"))
            Me.lblCode.Font = DirectCast(manager.GetObject("lblCode.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.lblCode, manager.GetString("lblCode.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.lblCode, DirectCast(Conversions.ToInteger(manager.GetObject("lblCode.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.lblCode, manager.GetString("lblCode.HelpString"))
            Me.lblCode.Image = DirectCast(manager.GetObject("lblCode.Image"), Image)
            Me.lblCode.ImageAlign = DirectCast(Conversions.ToInteger(manager.GetObject("lblCode.ImageAlign")), ContentAlignment)
            Me.lblCode.ImageIndex = Conversions.ToInteger(manager.GetObject("lblCode.ImageIndex"))
            Me.lblCode.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("lblCode.ImeMode")), ImeMode)
            Me.lblCode.Location = DirectCast(manager.GetObject("lblCode.Location"), Point)
            Me.lblCode.Name = "lblCode"
            Me.lblCode.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("lblCode.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me.lblCode, Conversions.ToBoolean(manager.GetObject("lblCode.ShowHelp")))
            Me.lblCode.Size = DirectCast(manager.GetObject("lblCode.Size"), Size)
            Me.lblCode.TabIndex = Conversions.ToInteger(manager.GetObject("lblCode.TabIndex"))
            Me.lblCode.Text = manager.GetString("lblCode.Text")
            Me.lblCode.TextAlign = DirectCast(Conversions.ToInteger(manager.GetObject("lblCode.TextAlign")), ContentAlignment)
            Me.lblCode.Visible = Conversions.ToBoolean(manager.GetObject("lblCode.Visible"))
            Me.txtFieldKey.AccessibleDescription = manager.GetString("txtFieldKey.AccessibleDescription")
            Me.txtFieldKey.AccessibleName = manager.GetString("txtFieldKey.AccessibleName")
            Me.txtFieldKey.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldKey.Anchor")), AnchorStyles)
            Me.txtFieldKey.AutoSize = Conversions.ToBoolean(manager.GetObject("txtFieldKey.AutoSize"))
            Me.txtFieldKey.BackgroundImage = DirectCast(manager.GetObject("txtFieldKey.BackgroundImage"), Image)
            Me.txtFieldKey.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldKey.Dock")), DockStyle)
            Me.txtFieldKey.Enabled = Conversions.ToBoolean(manager.GetObject("txtFieldKey.Enabled"))
            Me.txtFieldKey.Font = DirectCast(manager.GetObject("txtFieldKey.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.txtFieldKey, manager.GetString("txtFieldKey.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.txtFieldKey, DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldKey.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.txtFieldKey, manager.GetString("txtFieldKey.HelpString"))
            Me.txtFieldKey.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldKey.ImeMode")), ImeMode)
            Me.txtFieldKey.Location = DirectCast(manager.GetObject("txtFieldKey.Location"), Point)
            Me.txtFieldKey.MaxLength = Conversions.ToInteger(manager.GetObject("txtFieldKey.MaxLength"))
            Me.txtFieldKey.Multiline = Conversions.ToBoolean(manager.GetObject("txtFieldKey.Multiline"))
            Me.txtFieldKey.Name = "txtFieldKey"
            Me.txtFieldKey.PasswordChar = Conversions.ToChar(manager.GetObject("txtFieldKey.PasswordChar"))
            Me.txtFieldKey.ReadOnly = True
            Me.txtFieldKey.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldKey.RightToLeft")), RightToLeft)
            Me.txtFieldKey.ScrollBars = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldKey.ScrollBars")), ScrollBars)
            Me.HelpProvider1.SetShowHelp(Me.txtFieldKey, Conversions.ToBoolean(manager.GetObject("txtFieldKey.ShowHelp")))
            Me.txtFieldKey.Size = DirectCast(manager.GetObject("txtFieldKey.Size"), Size)
            Me.txtFieldKey.TabIndex = Conversions.ToInteger(manager.GetObject("txtFieldKey.TabIndex"))
            Me.txtFieldKey.Text = manager.GetString("txtFieldKey.Text")
            Me.txtFieldKey.TextAlign = DirectCast(Conversions.ToInteger(manager.GetObject("txtFieldKey.TextAlign")), HorizontalAlignment)
            Me.txtFieldKey.Visible = Conversions.ToBoolean(manager.GetObject("txtFieldKey.Visible"))
            Me.txtFieldKey.WordWrap = Conversions.ToBoolean(manager.GetObject("txtFieldKey.WordWrap"))
            Me.lblField.AccessibleDescription = manager.GetString("lblField.AccessibleDescription")
            Me.lblField.AccessibleName = manager.GetString("lblField.AccessibleName")
            Me.lblField.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("lblField.Anchor")), AnchorStyles)
            Me.lblField.AutoSize = Conversions.ToBoolean(manager.GetObject("lblField.AutoSize"))
            Me.lblField.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("lblField.Dock")), DockStyle)
            Me.lblField.Enabled = Conversions.ToBoolean(manager.GetObject("lblField.Enabled"))
            Me.lblField.Font = DirectCast(manager.GetObject("lblField.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.lblField, manager.GetString("lblField.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.lblField, DirectCast(Conversions.ToInteger(manager.GetObject("lblField.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.lblField, manager.GetString("lblField.HelpString"))
            Me.lblField.Image = DirectCast(manager.GetObject("lblField.Image"), Image)
            Me.lblField.ImageAlign = DirectCast(Conversions.ToInteger(manager.GetObject("lblField.ImageAlign")), ContentAlignment)
            Me.lblField.ImageIndex = Conversions.ToInteger(manager.GetObject("lblField.ImageIndex"))
            Me.lblField.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("lblField.ImeMode")), ImeMode)
            Me.lblField.Location = DirectCast(manager.GetObject("lblField.Location"), Point)
            Me.lblField.Name = "lblField"
            Me.lblField.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("lblField.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me.lblField, Conversions.ToBoolean(manager.GetObject("lblField.ShowHelp")))
            Me.lblField.Size = DirectCast(manager.GetObject("lblField.Size"), Size)
            Me.lblField.TabIndex = Conversions.ToInteger(manager.GetObject("lblField.TabIndex"))
            Me.lblField.Text = manager.GetString("lblField.Text")
            Me.lblField.TextAlign = DirectCast(Conversions.ToInteger(manager.GetObject("lblField.TextAlign")), ContentAlignment)
            Me.lblField.Visible = Conversions.ToBoolean(manager.GetObject("lblField.Visible"))
            Me.txtField.AccessibleDescription = manager.GetString("txtField.AccessibleDescription")
            Me.txtField.AccessibleName = manager.GetString("txtField.AccessibleName")
            Me.txtField.Anchor = DirectCast(Conversions.ToInteger(manager.GetObject("txtField.Anchor")), AnchorStyles)
            Me.txtField.AutoSize = Conversions.ToBoolean(manager.GetObject("txtField.AutoSize"))
            Me.txtField.BackgroundImage = DirectCast(manager.GetObject("txtField.BackgroundImage"), Image)
            Me.txtField.Dock = DirectCast(Conversions.ToInteger(manager.GetObject("txtField.Dock")), DockStyle)
            Me.txtField.Enabled = Conversions.ToBoolean(manager.GetObject("txtField.Enabled"))
            Me.txtField.Font = DirectCast(manager.GetObject("txtField.Font"), Font)
            Me.HelpProvider1.SetHelpKeyword(Me.txtField, manager.GetString("txtField.HelpKeyword"))
            Me.HelpProvider1.SetHelpNavigator(Me.txtField, DirectCast(Conversions.ToInteger(manager.GetObject("txtField.HelpNavigator")), HelpNavigator))
            Me.HelpProvider1.SetHelpString(Me.txtField, manager.GetString("txtField.HelpString"))
            Me.txtField.ImeMode = DirectCast(Conversions.ToInteger(manager.GetObject("txtField.ImeMode")), ImeMode)
            Me.txtField.Location = DirectCast(manager.GetObject("txtField.Location"), Point)
            Me.txtField.MaxLength = Conversions.ToInteger(manager.GetObject("txtField.MaxLength"))
            Me.txtField.Multiline = Conversions.ToBoolean(manager.GetObject("txtField.Multiline"))
            Me.txtField.Name = "txtField"
            Me.txtField.PasswordChar = Conversions.ToChar(manager.GetObject("txtField.PasswordChar"))
            Me.txtField.ReadOnly = True
            Me.txtField.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("txtField.RightToLeft")), RightToLeft)
            Me.txtField.ScrollBars = DirectCast(Conversions.ToInteger(manager.GetObject("txtField.ScrollBars")), ScrollBars)
            Me.HelpProvider1.SetShowHelp(Me.txtField, Conversions.ToBoolean(manager.GetObject("txtField.ShowHelp")))
            Me.txtField.Size = DirectCast(manager.GetObject("txtField.Size"), Size)
            Me.txtField.TabIndex = Conversions.ToInteger(manager.GetObject("txtField.TabIndex"))
            Me.txtField.Text = manager.GetString("txtField.Text")
            Me.txtField.TextAlign = DirectCast(Conversions.ToInteger(manager.GetObject("txtField.TextAlign")), HorizontalAlignment)
            Me.txtField.Visible = Conversions.ToBoolean(manager.GetObject("txtField.Visible"))
            Me.txtField.WordWrap = Conversions.ToBoolean(manager.GetObject("txtField.WordWrap"))
            Me.OleDbSelectCommand1.CommandText = "SELECT Lang, Field, FieldID, Translate1 FROM generaldesctranslation"
            Me.OleDbInsertCommand1.CommandText = "INSERT INTO generaldesctranslation(Lang, Field, FieldID, Translate1) VALUES (?, ?, ?, ?); SELECT Lang, Field, FieldID, Translate1 FROM generaldesctranslation WHERE (Field = ?) AND (FieldID = ?) AND (Lang = ?)"
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Field", OleDbType.VarChar, 30, "Field"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Translate1", OleDbType.VarChar, 100, "Translate1"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_Field", OleDbType.VarChar, 30, "Field"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbUpdateCommand1.CommandText = "UPDATE generaldesctranslation SET Lang = ?, Field = ?, FieldID = ?, Translate1 = ? WHERE (Field = ?) AND (FieldID = ?) AND (Lang = ?) AND (Translate1 = ? OR ? IS NULL AND Translate1 IS NULL); SELECT Lang, Field, FieldID, Translate1 FROM SystemTranslationMaster WHERE (Field = ?) AND (FieldID = ?) AND (Lang = ?)"
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Field", OleDbType.VarChar, 30, "Field"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Translate1", OleDbType.VarChar, 100, "Translate1"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Field", OleDbType.VarChar, 30, ParameterDirection.Input, False, 0, 0, "Field", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_FieldID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FieldID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Translate1", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Translate1", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Translate11", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Translate1", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_Field", OleDbType.VarChar, 30, "Field"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbDeleteCommand1.CommandText = "DELETE FROM generaldesctranslation WHERE (Field = ?) AND (FieldID = ?) AND (Lang = ?) AND (Translate1 = ? OR ? IS NULL AND Translate1 IS NULL)"
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Field", OleDbType.VarChar, 30, ParameterDirection.Input, False, 0, 0, "Field", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_FieldID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FieldID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Translate1", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Translate1", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Translate11", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Translate1", DataRowVersion.Original, Nothing))
            Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand3
            Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand3
            Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand3
            Me.OleDbDataAdapter2.TableMappings.AddRange(New DataTableMapping() { New DataTableMapping("Table", "systemlanguagecode", New DataColumnMapping() { New DataColumnMapping("Lang", "Lang"), New DataColumnMapping("Description", "Description") }) })
            Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand3
            Me.OleDbDeleteCommand3.CommandText = "DELETE FROM systemlanguagecode WHERE (Lang = ?) AND (Description = ? OR ? IS NULL AND Description IS NULL)"
            Me.OleDbDeleteCommand3.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand3.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbInsertCommand3.CommandText = "INSERT INTO systemlanguagecode(Lang, Description) VALUES (?, ?); SELECT Lang, Description FROM systemlanguagecode WHERE (Lang = ?)"
            Me.OleDbInsertCommand3.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbInsertCommand3.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 100, "Description"))
            Me.OleDbInsertCommand3.Parameters.Add(New OleDbParameter("Select_Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbSelectCommand3.CommandText = "SELECT Lang, Description FROM systemlanguagecode"
            Me.OleDbUpdateCommand3.CommandText = "UPDATE systemlanguagecode SET Lang = ?, Description = ? WHERE (Lang = ?) AND (Description = ? OR ? IS NULL AND Description IS NULL); SELECT Lang, Description FROM systemlanguagecode WHERE (Lang = ?)"
            Me.OleDbUpdateCommand3.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbUpdateCommand3.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 100, "Description"))
            Me.OleDbUpdateCommand3.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand3.Parameters.Add(New OleDbParameter("Select_Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand2
            Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand2
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand2
            Me.OleDbDataAdapter1.TableMappings.AddRange(New DataTableMapping() { New DataTableMapping("Table", "generaldesctranslation", New DataColumnMapping() { New DataColumnMapping("Lang", "Lang"), New DataColumnMapping("Field", "Field"), New DataColumnMapping("FieldID", "FieldID"), New DataColumnMapping("Translate1", "Translate1") }) })
            Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand2
            Me.OleDbDeleteCommand2.CommandText = "DELETE FROM generaldesctranslation WHERE (Field = ?) AND (FieldID = ?) AND (Lang = ?) AND (Translate1 = ? OR ? IS NULL AND Translate1 IS NULL)"
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_Field", OleDbType.VarChar, 30, ParameterDirection.Input, False, 0, 0, "Field", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_FieldID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FieldID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_Translate1", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Translate1", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_Translate11", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Translate1", DataRowVersion.Original, Nothing))
            Me.OleDbInsertCommand2.CommandText = "INSERT INTO generaldesctranslation(Lang, Field, FieldID, Translate1) VALUES (?, ?, ?, ?); SELECT Lang, Field, FieldID, Translate1 FROM generaldesctranslation WHERE (Field = ?) AND (FieldID = ?)"
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Field", OleDbType.VarChar, 30, "Field"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Translate1", OleDbType.VarChar, 100, "Translate1"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Select_Field", OleDbType.VarChar, 30, "Field"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Select_FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbSelectCommand2.CommandText = "SELECT Lang, Field, FieldID, Translate1 FROM generaldesctranslation"
            Me.OleDbUpdateCommand2.CommandText = "UPDATE generaldesctranslation SET Lang = ?, Field = ?, FieldID = ?, Translate1 = ? WHERE (Field = ?) AND (FieldID = ?) AND (Lang = ?) AND (Translate1 = ? OR ? IS NULL AND Translate1 IS NULL); SELECT Lang, Field, FieldID, Translate1 FROM GeneralDescTranslation WHERE (Field = ?) AND (FieldID = ?)"
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Field", OleDbType.VarChar, 30, "Field"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Translate1", OleDbType.VarChar, 100, "Translate1"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_Field", OleDbType.VarChar, 30, ParameterDirection.Input, False, 0, 0, "Field", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_FieldID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FieldID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_Translate1", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Translate1", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_Translate11", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Translate1", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Select_Field", OleDbType.VarChar, 30, "Field"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Select_FieldID", OleDbType.Integer, 4, "FieldID"))
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
            Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel1, Me.StatusBarPanel2 })
            Me.StatusBar1.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBar1.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me.StatusBar1, Conversions.ToBoolean(manager.GetObject("StatusBar1.ShowHelp")))
            Me.StatusBar1.ShowPanels = True
            Me.StatusBar1.Size = DirectCast(manager.GetObject("StatusBar1.Size"), Size)
            Me.StatusBar1.TabIndex = Conversions.ToInteger(manager.GetObject("StatusBar1.TabIndex"))
            Me.StatusBar1.Text = manager.GetString("StatusBar1.Text")
            Me.StatusBar1.Visible = Conversions.ToBoolean(manager.GetObject("StatusBar1.Visible"))
            Me.StatusBarPanel1.Alignment = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBarPanel1.Alignment")), HorizontalAlignment)
            Me.StatusBarPanel1.AutoSize = StatusBarPanelAutoSize.Spring
            Me.StatusBarPanel1.Icon = DirectCast(manager.GetObject("StatusBarPanel1.Icon"), Icon)
            Me.StatusBarPanel1.MinWidth = Conversions.ToInteger(manager.GetObject("StatusBarPanel1.MinWidth"))
            Me.StatusBarPanel1.Text = manager.GetString("StatusBarPanel1.Text")
            Me.StatusBarPanel1.ToolTipText = manager.GetString("StatusBarPanel1.ToolTipText")
            Me.StatusBarPanel1.Width = Conversions.ToInteger(manager.GetObject("StatusBarPanel1.Width"))
            Me.StatusBarPanel2.Alignment = DirectCast(Conversions.ToInteger(manager.GetObject("StatusBarPanel2.Alignment")), HorizontalAlignment)
            Me.StatusBarPanel2.Icon = DirectCast(manager.GetObject("StatusBarPanel2.Icon"), Icon)
            Me.StatusBarPanel2.MinWidth = Conversions.ToInteger(manager.GetObject("StatusBarPanel2.MinWidth"))
            Me.StatusBarPanel2.Text = manager.GetString("StatusBarPanel2.Text")
            Me.StatusBarPanel2.ToolTipText = manager.GetString("StatusBarPanel2.ToolTipText")
            Me.StatusBarPanel2.Width = Conversions.ToInteger(manager.GetObject("StatusBarPanel2.Width"))
            Me.PrintingSystem1.get_Links.AddRange(New Object() { Me.PrintableComponentLink1 })
            Me.PrintableComponentLink1.set_PrintingSystem(Me.PrintingSystem1)
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
            Me.MaximizeBox = False
            Me.MaximumSize = DirectCast(manager.GetObject("$this.MaximumSize"), Size)
            Me.MinimizeBox = False
            Me.MinimumSize = DirectCast(manager.GetObject("$this.MinimumSize"), Size)
            Me.Name = "frmgeneraldesctranslation_Maintenance"
            Me.RightToLeft = DirectCast(Conversions.ToInteger(manager.GetObject("$this.RightToLeft")), RightToLeft)
            Me.HelpProvider1.SetShowHelp(Me, Conversions.ToBoolean(manager.GetObject("$this.ShowHelp")))
            Me.ShowInTaskbar = False
            Me.StartPosition = DirectCast(Conversions.ToInteger(manager.GetObject("$this.StartPosition")), FormStartPosition)
            Me.Text = manager.GetString("$this.Text")
            Me.Controls.SetChildIndex(Me.StatusBar1, 0)
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.cmbDefaultListRepos.EndInit
            Me.cmbViewListRepos.EndInit
            Me.BarManager1.EndInit
            Me.txtQuickSearchRepos.EndInit
            Me.cmbFilterListRepos.EndInit
            Me.cmbReportListRepos.EndInit
            Me.Grid1.EndInit
            Me.objDs1.EndInit
            Me.GridView1.EndInit
            Me.LookUpLang.EndInit
            Me.objdsGeneral.EndInit
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.StatusBarPanel1.EndInit
            Me.StatusBarPanel2.EndInit
            Me.PrintingSystem1.EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadDataSet()
            Dim dataSet As New dsGeneral
            Try 
                Dim selectCommand As OleDbCommand = Me.OleDbDataAdapter1.SelectCommand
                selectCommand.CommandText = String.Concat(New String() { selectCommand.CommandText, " WHERE FieldID = ", Conversions.ToString(Me.FieldID), " AND Field = '", Me.Field, "'" })
                MyBase.Cls1.FillDataSet(dataSet.Tables.Item("generaldesctranslation"), Me.OleDbDataAdapter1, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
            Try 
                Me.objDs1.Clear
                Me.objDs1.Merge(dataSet)
                Me.objDs1.Tables.Item("generaldesctranslation").Columns.Item("Field").DefaultValue = Me.Field
                Me.objDs1.Tables.Item("generaldesctranslation").Columns.Item("FieldID").DefaultValue = Me.FieldID
                MyBase.Cls1.FillDataSet(Me.objdsGeneral.Tables.Item("systemlanguagecode"), Me.OleDbDataAdapter2, True)
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub UpdateDataSet()
            Dim changes As New dsGeneral
            Me.BindingContext.Item(Me.objDs1, "generaldesctranslation").EndCurrentEdit
            changes = DirectCast(Me.objDs1.GetChanges, dsGeneral)
            If (Not changes Is Nothing) Then
                Try 
                    MyBase.Cls1.UpdateDataSource(changes.Tables.Item("generaldesctranslation"), Me.OleDbDataAdapter1, True)
                    Me.objDs1.AcceptChanges
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Throw exception
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Private Function ValidateBeforeDelete() As Boolean
            Return True
        End Function


        ' Properties
        Friend Overridable Property colLang As BandedGridColumn
            Get
                Return Me._colLang
            End Get
            Set(ByVal WithEventsValue As BandedGridColumn)
                Me._colLang = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colTranslate1 As BandedGridColumn
            Get
                Return Me._colTranslate1
            End Get
            Set(ByVal WithEventsValue As BandedGridColumn)
                Me._colTranslate1 = WithEventsValue
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

        Friend Overridable Property GridBand1 As GridBand
            Get
                Return Me._GridBand1
            End Get
            Set(ByVal WithEventsValue As GridBand)
                Me._GridBand1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GridView1 As AdvBandedGridView
            Get
                Return Me._GridView1
            End Get
            Set(ByVal WithEventsValue As AdvBandedGridView)
                Me._GridView1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property HelpProvider1 As HelpProvider
            Get
                Return Me._HelpProvider1
            End Get
            Set(ByVal WithEventsValue As HelpProvider)
                Me._HelpProvider1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblCode As Label
            Get
                Return Me._lblCode
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblCode = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblField As Label
            Get
                Return Me._lblField
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblField = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblFieldID As Label
            Get
                Return Me._lblFieldID
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblFieldID = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LookUpLang As RepositoryItemLookUpEdit
            Get
                Return Me._LookUpLang
            End Get
            Set(ByVal WithEventsValue As RepositoryItemLookUpEdit)
                Me._LookUpLang = WithEventsValue
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

        Friend Overridable Property objDs1 As dsGeneral
            Get
                Return Me._objDs1
            End Get
            Set(ByVal WithEventsValue As dsGeneral)
                Me._objDs1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property objdsGeneral As dsGeneral
            Get
                Return Me._objdsGeneral
            End Get
            Set(ByVal WithEventsValue As dsGeneral)
                Me._objdsGeneral = WithEventsValue
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

        Friend Overridable Property PopMenuAssociatedTasks As MenuItem
            Get
                Return Me._PopMenuAssociatedTasks
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuAssociatedTasks = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PopMenuDelete As MenuItem
            Get
                Return Me._PopMenuDelete
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuDelete = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PopMenuEdit As MenuItem
            Get
                Return Me._PopMenuEdit
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuEdit = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PopMenuNew As MenuItem
            Get
                Return Me._PopMenuNew
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuNew = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PopMenuPrintPreview As MenuItem
            Get
                Return Me._PopMenuPrintPreview
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuPrintPreview = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PopMenuSave As MenuItem
            Get
                Return Me._PopMenuSave
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuSave = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PopMenuUserTasks As MenuItem
            Get
                Return Me._PopMenuUserTasks
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._PopMenuUserTasks = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PrintableComponentLink1 As PrintableComponentLink
            Get
                Return Me._PrintableComponentLink1
            End Get
            Set(ByVal WithEventsValue As PrintableComponentLink)
                Me._PrintableComponentLink1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PrintingSystem1 As PrintingSystem
            Get
                Return Me._PrintingSystem1
            End Get
            Set(ByVal WithEventsValue As PrintingSystem)
                Me._PrintingSystem1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RightMouseMenu As ContextMenu
            Get
                Return Me._RightMouseMenu
            End Get
            Set(ByVal WithEventsValue As ContextMenu)
                Me._RightMouseMenu = WithEventsValue
            End Set
        End Property

        Friend Overridable Property StatusBar1 As StatusBar
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

        Friend Overridable Property txtField As TextBox
            Get
                Return Me._txtField
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtField = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtFieldID As TextBox
            Get
                Return Me._txtFieldID
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtFieldID = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtFieldKey As TextBox
            Get
                Return Me._txtFieldKey
            End Get
            Set(ByVal WithEventsValue As TextBox)
                Me._txtFieldKey = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("colLang")> _
        Private _colLang As BandedGridColumn
        <AccessedThroughProperty("colTranslate1")> _
        Private _colTranslate1 As BandedGridColumn
        <AccessedThroughProperty("Grid1")> _
        Private _Grid1 As GridControl
        <AccessedThroughProperty("GridBand1")> _
        Private _GridBand1 As GridBand
        <AccessedThroughProperty("GridView1")> _
        Private _GridView1 As AdvBandedGridView
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider
        <AccessedThroughProperty("lblCode")> _
        Private _lblCode As Label
        <AccessedThroughProperty("lblField")> _
        Private _lblField As Label
        <AccessedThroughProperty("lblFieldID")> _
        Private _lblFieldID As Label
        <AccessedThroughProperty("LookUpLang")> _
        Private _LookUpLang As RepositoryItemLookUpEdit
        <AccessedThroughProperty("MenuItem5")> _
        Private _MenuItem5 As MenuItem
        <AccessedThroughProperty("MenuItem7")> _
        Private _MenuItem7 As MenuItem
        <AccessedThroughProperty("MenuItem9")> _
        Private _MenuItem9 As MenuItem
        <AccessedThroughProperty("objDs1")> _
        Private _objDs1 As dsGeneral
        <AccessedThroughProperty("objdsGeneral")> _
        Private _objdsGeneral As dsGeneral
        <AccessedThroughProperty("OleDbDataAdapter1")> _
        Private _OleDbDataAdapter1 As OleDbDataAdapter
        <AccessedThroughProperty("OleDbDataAdapter2")> _
        Private _OleDbDataAdapter2 As OleDbDataAdapter
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
        <AccessedThroughProperty("PopMenuUserTasks")> _
        Private _PopMenuUserTasks As MenuItem
        <AccessedThroughProperty("PrintableComponentLink1")> _
        Private _PrintableComponentLink1 As PrintableComponentLink
        <AccessedThroughProperty("PrintingSystem1")> _
        Private _PrintingSystem1 As PrintingSystem
        <AccessedThroughProperty("RightMouseMenu")> _
        Private _RightMouseMenu As ContextMenu
        <AccessedThroughProperty("StatusBar1")> _
        Private _StatusBar1 As StatusBar
        <AccessedThroughProperty("StatusBarPanel1")> _
        Private _StatusBarPanel1 As StatusBarPanel
        <AccessedThroughProperty("StatusBarPanel2")> _
        Private _StatusBarPanel2 As StatusBarPanel
        <AccessedThroughProperty("txtField")> _
        Private _txtField As TextBox
        <AccessedThroughProperty("txtFieldID")> _
        Private _txtFieldID As TextBox
        <AccessedThroughProperty("txtFieldKey")> _
        Private _txtFieldKey As TextBox
        Private components As IContainer
        Public Field As String
        Public FieldID As Integer
        Public FieldKey As String
    End Class
End Namespace

