Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
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
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmSystemFilter_Maintenance
        Inherits frmGeneral_Maintenance
        ' Methods
        Public Sub New()
            AddHandler MyBase.EventDeleteRecord, New EventDeleteRecordEventHandler(AddressOf Me.DeleteRecord)
            AddHandler MyBase.EventUpdateDataset, New EventUpdateDatasetEventHandler(AddressOf Me.UpdateDataSet)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            AddHandler MyBase.EventEnablingEditFields, New EventEnablingEditFieldsEventHandler(AddressOf Me.EnablingEditFields)
            AddHandler MyBase.EventEnablingkeyFields, New EventEnablingkeyFieldsEventHandler(AddressOf Me.EnablingKeyFields)
            AddHandler MyBase.EventPrintForm, New EventPrintFormEventHandler(AddressOf Me.StartPrintForm)
            AddHandler MyBase.EventLoadDataset, New EventLoadDatasetEventHandler(AddressOf Me.LoadDataSet)
            AddHandler MyBase.EventNewRecord, New EventNewRecordEventHandler(AddressOf Me.NewRecord)
            AddHandler MyBase.EventPositionChanged, New EventPositionChangedEventHandler(AddressOf Me.PositionChanged)
            AddHandler MyBase.EventEditRecord, New EventEditRecordEventHandler(AddressOf Me.EditRecord)
            AddHandler MyBase.EventSaveChanges, New EventSaveChangesEventHandler(AddressOf Me.SaveChanges)
            AddHandler MyBase.EventUndoChanges, New EventUndoChangesEventHandler(AddressOf Me.UndoChanges)
            Dim list As ArrayList = frmSystemFilter_Maintenance.__ENCList
            SyncLock list
                frmSystemFilter_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableNameSub = "generalfiltersub"
            Me.KeyDataSet = "BizzLib.dsFilter"
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.EventDeleteRecord, New EventDeleteRecordEventHandler(AddressOf Me.DeleteRecord)
            AddHandler MyBase.EventUpdateDataset, New EventUpdateDatasetEventHandler(AddressOf Me.UpdateDataSet)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            AddHandler MyBase.EventEnablingEditFields, New EventEnablingEditFieldsEventHandler(AddressOf Me.EnablingEditFields)
            AddHandler MyBase.EventEnablingkeyFields, New EventEnablingkeyFieldsEventHandler(AddressOf Me.EnablingKeyFields)
            AddHandler MyBase.EventPrintForm, New EventPrintFormEventHandler(AddressOf Me.StartPrintForm)
            AddHandler MyBase.EventLoadDataset, New EventLoadDatasetEventHandler(AddressOf Me.LoadDataSet)
            AddHandler MyBase.EventNewRecord, New EventNewRecordEventHandler(AddressOf Me.NewRecord)
            AddHandler MyBase.EventPositionChanged, New EventPositionChangedEventHandler(AddressOf Me.PositionChanged)
            AddHandler MyBase.EventEditRecord, New EventEditRecordEventHandler(AddressOf Me.EditRecord)
            AddHandler MyBase.EventSaveChanges, New EventSaveChangesEventHandler(AddressOf Me.SaveChanges)
            AddHandler MyBase.EventUndoChanges, New EventUndoChangesEventHandler(AddressOf Me.UndoChanges)
            Dim list As ArrayList = frmSystemFilter_Maintenance.__ENCList
            SyncLock list
                frmSystemFilter_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableNameSub = "generalfiltersub"
            Me.KeyDataSet = "BizzLib.dsFilter"
            Me.InitializeComponent
        End Sub

        Private Sub btnRefreshSQL_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position >= 0) Then
                Me.txtSQL.set_Text(MyBase.BKFilter.FilterGenerateSQL(Conversions.ToInteger(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField))))
            End If
        End Sub

        Private Sub DeleteRecord(ByVal Sender As Object, ByVal e As EventArgs)
            If (((Me.BindingContext.Item(Me.objDS, MyBase.TableName).Count > 0) AndAlso (Interaction.MsgBox(MyBase.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes)) AndAlso Me.ValidateBeforeDelete) Then
                MyBase.BKFilter.DeleteFilterSub(Conversions.ToInteger(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField)))
                Me.BindingContext.Item(Me.objDS, MyBase.TableName).RemoveAt(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position)
                Me.UpdateDataSet
                Me.EnablingAll(False)
                Me.PositionChanged(RuntimeHelpers.GetObjectValue(Sender), e)
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub EditRecord(ByVal Sender As Object, ByVal e As EventArgs)
            Me.SetState(ObjectState.EditState)
            Me.PopMenuNew.Enabled = False
            Me.PopMenuEdit.Enabled = False
            Me.PopMenuSave.Enabled = True
            Me.PopMenuDelete.Enabled = False
            Me.PopMenuUndo.Enabled = True
            Me.EnablingForEdit
            MyBase.OpenType = "EDIT"
        End Sub

        Private Sub EnablingEditFields(ByVal Enabling As Boolean)
            Me.txtName.Enabled = Enabling
            Me.txtDescription.Enabled = Enabling
            Me.chkDefaultFilter.Enabled = Enabling
            Me.txttopRows.get_Properties.set_Enabled(Enabling)
            Me.Grid1.Enabled = Enabling
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
                MyBase.IDField = "FilterID"
                MyBase.TableName = "generalfilter"
                Me.MainDataSet = Me.objDS
                Me.HelpProvider1.HelpNamespace = (".\Help\" & Me.SessionInfo.UserLang & "\BizzKeys.chm")
                MyBase.SQLTxt1 = Me.OleDbDataAdapter1.SelectCommand.CommandText
                Me.LoadDataSet
                Me.BarManager1.get_Bars.get_Item("Misc_Bar2").set_Visible(False)
                Me.BarManager1.get_Bars.get_Item("Filter_Bar").set_Visible(False)
                Me.BarManager1.get_Bars.get_Item("DefaultSet_Bar").set_Visible(False)
                If (MyBase.OpenType = "NEW") Then
                    Me.NewRecord(RuntimeHelpers.GetObjectValue(sender), e)
                End If
                If (MyBase.OpenType = "EDIT") Then
                    If (MyBase.KeyValue <> "") Then
                        Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Sort = MyBase.IDField
                        Dim str As String = Conversions.ToString(Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Item(Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Find(New Object() { MyBase.KeyValue })).Item(MyBase.KeyFieldName))
                        Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Sort = MyBase.KeyFieldName
                        Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position = Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Find(New Object() { str })
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
                ProjectData.ClearProjectError
            End Try
            Me.PositionChanged(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ResourceManager(GetType(frmSystemFilter_Maintenance))
            Me.lblFilterName = New Label
            Me.lblDescription = New Label
            Me.txtName = New TextBox
            Me.objDS = New dsFilter
            Me.txtDescription = New TextBox
            Me.Panel1 = New Panel
            Me.TabControl1 = New TabControl
            Me.tabCriteria1 = New TabPage
            Me.Grid1 = New GridControl
            Me.GridView1 = New GridView
            Me.GridColumn1 = New GridColumn
            Me.GridColumn2 = New GridColumn
            Me.tabSQL = New TabPage
            Me.Panel3 = New Panel
            Me.btnRefreshSQL = New SimpleButton
            Me.txtSQL = New MemoEdit
            Me.Panel2 = New Panel
            Me.lblTopRows = New Label
            Me.txttopRows = New CalcEdit
            Me.chkDefaultFilter = New CheckBox
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
            Me.objDS.BeginInit
            Me.Panel1.SuspendLayout
            Me.TabControl1.SuspendLayout
            Me.tabCriteria1.SuspendLayout
            Me.Grid1.BeginInit
            Me.GridView1.BeginInit
            Me.tabSQL.SuspendLayout
            Me.Panel3.SuspendLayout
            Me.txtSQL.get_Properties.BeginInit
            Me.Panel2.SuspendLayout
            Me.txttopRows.get_Properties.BeginInit
            Me.SuspendLayout
            Dim point As New Point(8, 8)
            Me.lblFilterName.Location = point
            Me.lblFilterName.Name = "lblFilterName"
            Me.lblFilterName.TabIndex = 3
            Me.lblFilterName.Text = "Filter Name"
            point = New Point(8, &H20)
            Me.lblDescription.Location = point
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.TabIndex = 4
            Me.lblDescription.Text = "Description"
            Me.txtName.DataBindings.Add(New Binding("Text", Me.objDS, "generalfilter.Name"))
            Me.txtName.Enabled = False
            point = New Point(&H70, 8)
            Me.txtName.Location = point
            Me.txtName.Name = "txtName"
            Dim size As New Size(&HC0, 20)
            Me.txtName.Size = size
            Me.txtName.TabIndex = 8
            Me.txtName.Text = ""
            Me.objDS.DataSetName = "dsFilter"
            Me.objDS.Locale = New CultureInfo("en-US")
            Me.txtDescription.DataBindings.Add(New Binding("Text", Me.objDS, "generalfilter.Description"))
            Me.txtDescription.Enabled = False
            point = New Point(&H70, &H20)
            Me.txtDescription.Location = point
            Me.txtDescription.Name = "txtDescription"
            size = New Size(&H180, 20)
            Me.txtDescription.Size = size
            Me.txtDescription.TabIndex = 9
            Me.txtDescription.Text = ""
            Me.Panel1.BackColor = SystemColors.Window
            Me.Panel1.Controls.Add(Me.TabControl1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = DockStyle.Fill
            point = New Point(0, &H36)
            Me.Panel1.Location = point
            Me.Panel1.Name = "Panel1"
            size = New Size(&H210, &H182)
            Me.Panel1.Size = size
            Me.Panel1.TabIndex = &H1F
            Me.TabControl1.Controls.Add(Me.tabCriteria1)
            Me.TabControl1.Controls.Add(Me.tabSQL)
            Me.TabControl1.Dock = DockStyle.Fill
            point = New Point(0, &H60)
            Me.TabControl1.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            size = New Size(&H210, 290)
            Me.TabControl1.Size = size
            Me.TabControl1.TabIndex = 13
            Me.tabCriteria1.Controls.Add(Me.Grid1)
            point = New Point(4, &H16)
            Me.tabCriteria1.Location = point
            Me.tabCriteria1.Name = "tabCriteria1"
            size = New Size(520, &H108)
            Me.tabCriteria1.Size = size
            Me.tabCriteria1.TabIndex = 0
            Me.tabCriteria1.Text = "Criteria"
            Me.Grid1.set_DataMember("generalfiltersub")
            Me.Grid1.set_DataSource(Me.objDS)
            Me.Grid1.Dock = DockStyle.Fill
            Me.Grid1.get_EmbeddedNavigator.Name = ""
            point = New Point(0, 0)
            Me.Grid1.Location = point
            Me.Grid1.set_MainView(Me.GridView1)
            Me.Grid1.Name = "Grid1"
            size = New Size(520, &H108)
            Me.Grid1.Size = size
            Me.Grid1.TabIndex = 0
            Me.Grid1.set_Text("GridControl1")
            Me.GridView1.get_Columns.AddRange(New GridColumn() { Me.GridColumn1, Me.GridColumn2 })
            Me.GridView1.set_GridControl(Me.Grid1)
            Me.GridView1.set_GroupPanelText("...")
            Me.GridView1.set_Name("GridView1")
            Me.GridColumn1.set_Caption("Field")
            Me.GridColumn1.set_FieldName("FieldName")
            Me.GridColumn1.set_Name("GridColumn1")
            Me.GridColumn1.set_VisibleIndex(0)
            Me.GridColumn2.set_Caption("Criteria")
            Me.GridColumn2.set_FieldName("FieldCriteria")
            Me.GridColumn2.set_Name("GridColumn2")
            Me.GridColumn2.set_VisibleIndex(1)
            Me.GridColumn2.set_Width(&H16B)
            Me.tabSQL.Controls.Add(Me.Panel3)
            Me.tabSQL.Controls.Add(Me.txtSQL)
            point = New Point(4, &H16)
            Me.tabSQL.Location = point
            Me.tabSQL.Name = "tabSQL"
            size = New Size(520, 340)
            Me.tabSQL.Size = size
            Me.tabSQL.TabIndex = 1
            Me.tabSQL.Text = "SQL"
            Me.Panel3.Controls.Add(Me.btnRefreshSQL)
            Me.Panel3.Dock = DockStyle.Top
            point = New Point(0, 0)
            Me.Panel3.Location = point
            Me.Panel3.Name = "Panel3"
            size = New Size(520, &H30)
            Me.Panel3.Size = size
            Me.Panel3.TabIndex = 2
            point = New Point(&H10, 8)
            Me.btnRefreshSQL.Location = point
            Me.btnRefreshSQL.Name = "btnRefreshSQL"
            size = New Size(80, &H18)
            Me.btnRefreshSQL.Size = size
            Me.btnRefreshSQL.TabIndex = 0
            Me.btnRefreshSQL.set_Text("Refresh")
            Me.txtSQL.Dock = DockStyle.Fill
            Me.txtSQL.set_EditValue("")
            point = New Point(0, 0)
            Me.txtSQL.Location = point
            Me.txtSQL.Name = "txtSQL"
            Me.txtSQL.get_Properties.set_ReadOnly(True)
            size = New Size(520, 340)
            Me.txtSQL.Size = size
            Me.txtSQL.TabIndex = 1
            Me.Panel2.Controls.Add(Me.lblTopRows)
            Me.Panel2.Controls.Add(Me.txttopRows)
            Me.Panel2.Controls.Add(Me.txtName)
            Me.Panel2.Controls.Add(Me.lblDescription)
            Me.Panel2.Controls.Add(Me.lblFilterName)
            Me.Panel2.Controls.Add(Me.txtDescription)
            Me.Panel2.Controls.Add(Me.chkDefaultFilter)
            Me.Panel2.Dock = DockStyle.Top
            point = New Point(0, 0)
            Me.Panel2.Location = point
            Me.Panel2.Name = "Panel2"
            size = New Size(&H210, &H60)
            Me.Panel2.Size = size
            Me.Panel2.TabIndex = 11
            point = New Point(160, &H38)
            Me.lblTopRows.Location = point
            Me.lblTopRows.Name = "lblTopRows"
            Me.lblTopRows.TabIndex = 13
            Me.lblTopRows.Text = "Top Rows"
            Me.txttopRows.DataBindings.Add(New Binding("EditValue", Me.objDS, "generalfilter.TopRows"))
            point = New Point(&H108, &H38)
            Me.txttopRows.Location = point
            Me.txttopRows.Name = "txttopRows"
            Me.txttopRows.get_Properties.get_Buttons.AddRange(New EditorButton() { New EditorButton(-5) })
            Me.txttopRows.get_Properties.get_DisplayFormat.set_FormatString("n0")
            Me.txttopRows.get_Properties.get_DisplayFormat.set_FormatType(1)
            Me.txttopRows.get_Properties.set_Enabled(False)
            size = New Size(&H88, 20)
            Me.txttopRows.Size = size
            Me.txttopRows.TabIndex = 12
            Me.chkDefaultFilter.CheckAlign = ContentAlignment.MiddleRight
            Me.chkDefaultFilter.DataBindings.Add(New Binding("Checked", Me.objDS, "generalfilter.DefaultFilter"))
            point = New Point(8, &H38)
            Me.chkDefaultFilter.Location = point
            Me.chkDefaultFilter.Name = "chkDefaultFilter"
            size = New Size(120, &H18)
            Me.chkDefaultFilter.Size = size
            Me.chkDefaultFilter.TabIndex = 10
            Me.chkDefaultFilter.Text = "Default Filter"
            Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
            Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
            Me.OleDbDataAdapter1.TableMappings.AddRange(New DataTableMapping() { New DataTableMapping("Table", "generalfilter", New DataColumnMapping() { New DataColumnMapping("FilterID", "FilterID"), New DataColumnMapping("Name", "Name"), New DataColumnMapping("UserID", "UserID"), New DataColumnMapping("MenuID", "MenuID"), New DataColumnMapping("Description", "Description"), New DataColumnMapping("DefaultFilter", "DefaultFilter"), New DataColumnMapping("SystemFilter", "SystemFilter"), New DataColumnMapping("TopRows", "TopRows") }) })
            Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
            Me.OleDbDeleteCommand1.CommandText = "DELETE FROM generalfilter WHERE (FilterID = ?) AND (DefaultFilter = ? OR ? IS NULL AND DefaultFilter IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (MenuID = ?) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (SystemFilter = ? OR ? IS NULL AND SystemFilter IS NULL) AND (TopRows = ? OR ? IS NULL AND TopRows IS NULL) AND (UserID = ?)"
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_FilterID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FilterID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_DefaultFilter", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "DefaultFilter", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_DefaultFilter1", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "DefaultFilter", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_MenuID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Name", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Name1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_SystemFilter", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemFilter", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_SystemFilter1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemFilter", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_TopRows", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TopRows", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_TopRows1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TopRows", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_UserID", OleDbType.VarChar, 10, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing))
            Me.OleDbInsertCommand1.CommandText = "INSERT INTO generalfilter(FilterID, Name, UserID, MenuID, Description, DefaultFilter, SystemFilter, TopRows) VALUES (?, ?, ?, ?, ?, ?, ?, ?); SELECT FilterID, Name, UserID, MenuID, Description, DefaultFilter, SystemFilter, TopRows FROM GeneralFilter WHERE (FilterID = ?)"
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("FilterID", OleDbType.Integer, 4, "FilterID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Name", OleDbType.VarChar, 50, "Name"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("UserID", OleDbType.VarChar, 10, "UserID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("MenuID", OleDbType.Integer, 4, "MenuID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 150, "Description"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("DefaultFilter", OleDbType.Boolean, 1, "DefaultFilter"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("SystemFilter", OleDbType.Integer, 4, "SystemFilter"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("TopRows", OleDbType.Integer, 4, "TopRows"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_FilterID", OleDbType.Integer, 4, "FilterID"))
            Me.OleDbSelectCommand1.CommandText = "SELECT FilterID, Name, UserID, MenuID, Description, DefaultFilter, SystemFilter, TopRows FROM generalfilter"
            Me.OleDbUpdateCommand1.CommandText = "UPDATE generalfilter SET FilterID = ?, Name = ?, UserID = ?, MenuID = ?, Description = ?, DefaultFilter = ?, SystemFilter = ?, TopRows = ? WHERE (FilterID = ?) AND (DefaultFilter = ? OR ? IS NULL AND DefaultFilter IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (MenuID = ?) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (SystemFilter = ? OR ? IS NULL AND SystemFilter IS NULL) AND (TopRows = ? OR ? IS NULL AND TopRows IS NULL) AND (UserID = ?); SELECT FilterID, Name, UserID, MenuID, Description, DefaultFilter, SystemFilter, TopRows FROM generalfilter WHERE (FilterID = ?)"
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("FilterID", OleDbType.Integer, 4, "FilterID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Name", OleDbType.VarChar, 50, "Name"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("UserID", OleDbType.VarChar, 10, "UserID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("MenuID", OleDbType.Integer, 4, "MenuID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 150, "Description"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("DefaultFilter", OleDbType.Boolean, 1, "DefaultFilter"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("SystemFilter", OleDbType.Integer, 4, "SystemFilter"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("TopRows", OleDbType.Integer, 4, "TopRows"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_FilterID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FilterID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_DefaultFilter", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "DefaultFilter", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_DefaultFilter1", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "DefaultFilter", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_MenuID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Name", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Name1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_SystemFilter", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemFilter", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_SystemFilter1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemFilter", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_TopRows", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TopRows", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_TopRows1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TopRows", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_UserID", OleDbType.VarChar, 10, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_FilterID", OleDbType.Integer, 4, "FilterID"))
            Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
            Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
            Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
            Me.OleDbDataAdapter2.TableMappings.AddRange(New DataTableMapping() { New DataTableMapping("Table", "generalfiltersub", New DataColumnMapping() { New DataColumnMapping("FilterID", "FilterID"), New DataColumnMapping("OrderNbr", "OrderNbr"), New DataColumnMapping("FieldName", "FieldName"), New DataColumnMapping("FieldCriteria", "FieldCriteria") }) })
            Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
            Me.OleDbDeleteCommand2.CommandText = "DELETE FROM generalfiltersub WHERE (FieldName = ?) AND (FilterID = ?) AND (OrderNbr = ?) AND (FieldCriteria = ? OR ? IS NULL AND FieldCriteria IS NULL)"
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_FieldName", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_FilterID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FilterID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_OrderNbr", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_FieldCriteria", OleDbType.VarChar, &H800, ParameterDirection.Input, False, 0, 0, "FieldCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_FieldCriteria1", OleDbType.VarChar, &H800, ParameterDirection.Input, False, 0, 0, "FieldCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbInsertCommand2.CommandText = "INSERT INTO generalfiltersub(FilterID, OrderNbr, FieldName, FieldCriteria) VALUES (?, ?, ?, ?); SELECT FilterID, OrderNbr, FieldName, FieldCriteria FROM GeneralFilterSub WHERE (FieldName = ?) AND (FilterID = ?) AND (OrderNbr = ?)"
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("FilterID", OleDbType.Integer, 4, "FilterID"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("OrderNbr", OleDbType.Integer, 4, "OrderNbr"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("FieldName", OleDbType.VarChar, 150, "FieldName"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("FieldCriteria", OleDbType.VarChar, &H800, "FieldCriteria"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Select_FieldName", OleDbType.VarChar, 150, "FieldName"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Select_FilterID", OleDbType.Integer, 4, "FilterID"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Select_OrderNbr", OleDbType.Integer, 4, "OrderNbr"))
            Me.OleDbSelectCommand2.CommandText = "SELECT FilterID, OrderNbr, FieldName, FieldCriteria FROM generalfiltersub"
            Me.OleDbUpdateCommand2.CommandText = "UPDATE generalfiltersub SET FilterID = ?, OrderNbr = ?, FieldName = ?, FieldCriteria = ? WHERE (FieldName = ?) AND (FilterID = ?) AND (OrderNbr = ?) AND (FieldCriteria = ? OR ? IS NULL AND FieldCriteria IS NULL); SELECT FilterID, OrderNbr, FieldName, FieldCriteria FROM generalfiltersub WHERE (FieldName = ?) AND (FilterID = ?) AND (OrderNbr = ?)"
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("FilterID", OleDbType.Integer, 4, "FilterID"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("OrderNbr", OleDbType.Integer, 4, "OrderNbr"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("FieldName", OleDbType.VarChar, 150, "FieldName"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("FieldCriteria", OleDbType.VarChar, &H800, "FieldCriteria"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_FieldName", OleDbType.VarChar, 150, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_FilterID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FilterID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_OrderNbr", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "OrderNbr", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_FieldCriteria", OleDbType.VarChar, &H800, ParameterDirection.Input, False, 0, 0, "FieldCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_FieldCriteria1", OleDbType.VarChar, &H800, ParameterDirection.Input, False, 0, 0, "FieldCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Select_FieldName", OleDbType.VarChar, 150, "FieldName"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Select_FilterID", OleDbType.Integer, 4, "FilterID"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Select_OrderNbr", OleDbType.Integer, 4, "OrderNbr"))
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Size(&H210, &H1CE)
            Me.ClientSize = size
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "frmSystemFilter_Maintenance"
            Me.Text = "Filter"
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.objDS.EndInit
            Me.Panel1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tabCriteria1.ResumeLayout(False)
            Me.Grid1.EndInit
            Me.GridView1.EndInit
            Me.tabSQL.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.txtSQL.get_Properties.EndInit
            Me.Panel2.ResumeLayout(False)
            Me.txttopRows.get_Properties.EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadDataSet()
            Dim set2 As New clsDataSet(Me.SessionInfo)
            Dim dataSet As DataSet = Me.objDS.Clone
            Try 
                Me.OleDbDataAdapter1.SelectCommand.CommandText = String.Concat(New String() { MyBase.SQLTxt1, " WHERE ( UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " or UserId = 0 ) AND MenuID = ", Conversions.ToString(Me.FilterForMenuID), " ORDER BY ", MyBase.KeyFieldName })
                set2.FillDataSet(dataSet.Tables.Item(MyBase.TableName), Me.OleDbDataAdapter1, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
            Try 
                Me.objDS.Clear
                Me.objDS.Merge(dataSet)
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("MenuID").DefaultValue = Me.FilterForMenuID
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("UserID").DefaultValue = Me.SessionInfo.UserID
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("DefaultFilter").DefaultValue = 0
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("SystemFilter").DefaultValue = 0
                Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Sort = "Name"
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub LoadDataSetSub(ByVal FilterID As Integer)
            Dim set2 As New clsDataSet(Me.SessionInfo)
            Dim dataSet As DataSet = Me.objDS.Clone
            Try 
                Me.OleDbDataAdapter2.SelectCommand.CommandText = ("SELECT * FROM generalfiltersub WHERE FilterID = " & Conversions.ToString(FilterID) & " ORDER BY FieldName")
                set2.FillDataSet(dataSet.Tables.Item(Me.TableNameSub), Me.OleDbDataAdapter2, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
            Try 
                Me.objDS.Tables.Item(Me.TableNameSub).Clear
                Me.objDS.Merge(dataSet)
                Me.objDS.Tables.Item(Me.TableNameSub).Columns.Item("FilterID").DefaultValue = FilterID
                Me.objDS.Tables.Item(Me.TableNameSub).Columns.Item("OrderNbr").DefaultValue = 1
                Me.objDS.Tables.Item(Me.TableNameSub).DefaultView.Sort = "FieldName"
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError
            End Try
        End Sub

        Private Sub NewRecord(ByVal Sender As Object, ByVal e As EventArgs)
            Me.SetState(ObjectState.NewState)
            Me.PopMenuNew.Enabled = False
            Me.PopMenuEdit.Enabled = False
            Me.PopMenuSave.Enabled = True
            Me.PopMenuDelete.Enabled = False
            Me.PopMenuUndo.Enabled = True
            Me.EnablingAll(True)
            MyBase.OpenType = "NEW"
            Try 
                Dim enumerator As IEnumerator
                Me.objDS.Tables.Item(Me.TableNameSub).Clear
                Me.BindingContext.Item(Me.objDS, MyBase.TableName).EndCurrentEdit
                Me.BindingContext.Item(Me.objDS, Me.TableNameSub).EndCurrentEdit
                Me.BindingContext.Item(Me.objDS, MyBase.TableName).AddNew
                Try 
                    enumerator = Me.FilterForTable.Columns.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As DataColumn = DirectCast(enumerator.Current, DataColumn)
                        If Information.IsNothing(Me.objDS.Tables.Item(Me.TableNameSub).Rows.Find(New Object() { -1, 1, current.ColumnName })) Then
                            Dim row As DataRow = Me.objDS.Tables.Item(Me.TableNameSub).NewRow
                            row.Item("FieldName") = current.ColumnName
                            row.Item("OrderNbr") = 1
                            row.Item("FilterID") = -1
                            Me.objDS.Tables.Item(Me.TableNameSub).Rows.Add(row)
                        End If
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator,IDisposable).Dispose
                    End If
                End Try
                Me.Grid1.set_DataSource(Me.objDS)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError
            End Try
            Me.PositionChanged(RuntimeHelpers.GetObjectValue(Sender), e)
        End Sub

        Private Sub PositionChanged(ByVal Sender As Object, ByVal e As EventArgs)
            Dim filterID As Integer = -1
            If (Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position >= 0) Then
                Me.StatusBar1.Text = ((Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position + 1).ToString & " of  " & Me.BindingContext.Item(Me.objDS, MyBase.TableName).Count.ToString)
                Me.ToolTip1.SetToolTip(Me.StatusBar1, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(((MyBase.TableName & "-->") & MyBase.IDField & "="), DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField)), "")))
                Me.txtQuickSearch.set_EditValue(Me.txtName.Text)
                If (MyBase.OpenType <> "NEW") Then
                    filterID = Conversions.ToInteger(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), ""))
                    MyBase.BKFilter.FilterSubVerify(filterID, Me.FilterForTable)
                    Me.LoadDataSetSub(filterID)
                End If
            End If
        End Sub

        Private Sub SaveChanges(ByVal Sender As Object, ByVal e As EventArgs)
            If Me.ValidateBeforeSave Then
                Me.SetState(ObjectState.BrowseState)
                Me.PopMenuNew.Enabled = True
                Me.PopMenuEdit.Enabled = True
                Me.PopMenuSave.Enabled = False
                Me.PopMenuDelete.Enabled = True
                Me.PopMenuUndo.Enabled = False
                Me.EnablingAll(False)
                MyBase.OpenType = "BROWSE"
                If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), ""), "", False) Then
                    Dim enumerator As IEnumerator
                    Me.NewFilterID = Conversions.ToInteger(MyBase.BKGlobal.GetNextID(MyBase.IDField))
                    DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField) = Me.NewFilterID
                    Try 
                        enumerator = Me.objDS.Tables.Item(Me.TableNameSub).DefaultView.GetEnumerator
                        Do While enumerator.MoveNext
                            Dim current As DataRowView = DirectCast(enumerator.Current, DataRowView)
                            current.Item("FilterID") = Me.NewFilterID
                        Loop
                    Finally
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator,IDisposable).Dispose
                        End If
                    End Try
                Else
                    Me.NewFilterID = Conversions.ToInteger(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), ""))
                End If
                Try 
                    Me.UpdateDataSet
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    MessageBox.Show(exception.Message)
                    ProjectData.ClearProjectError
                End Try
                If Me.chkDefaultFilter.Checked Then
                    MyBase.BKFilter.FilterAssignDefault(Me.NewFilterID, Me.FilterForMenuID)
                End If
                Me.PositionChanged(RuntimeHelpers.GetObjectValue(Sender), e)
            End If
        End Sub

        Private Sub StartPrintForm()
            MyBase.BKReport.PrintForm(MyBase.CurrentReportID, New DataRow() { DirectCast(Me.BindingContext.Item(Me.MainDataSet, MyBase.TableName).Current, DataRowView).Row }, Nothing)
        End Sub

        Private Sub UndoChanges(ByVal Sender As Object, ByVal e As EventArgs)
            Me.SetState(ObjectState.BrowseState)
            Me.PopMenuNew.Enabled = True
            Me.PopMenuEdit.Enabled = True
            Me.PopMenuSave.Enabled = False
            Me.PopMenuDelete.Enabled = True
            Me.PopMenuUndo.Enabled = False
            Me.EnablingAll(False)
            Me.BindingContext.Item(Me.objDS, MyBase.TableName).CancelCurrentEdit
            Me.BindingContext.Item(Me.objDS, Me.TableNameSub).CancelCurrentEdit
            Me.PositionChanged(RuntimeHelpers.GetObjectValue(Sender), e)
            MyBase.OpenType = "BROWSE"
        End Sub

        Public Sub UpdateDataSet()
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim dataSet As New dsFilter
            Me.GridView1.CloseEditor
            Me.BindingContext.Item(Me.objDS, MyBase.TableName).EndCurrentEdit
            Me.BindingContext.Item(Me.objDS, Me.TableNameSub).EndCurrentEdit
            dataSet = DirectCast(Me.objDS.GetChanges, dsFilter)
            If (Not dataSet Is Nothing) Then
                Try 
                    ClsDs.UpdateDataSource(dataSet.Tables.Item(MyBase.TableName), Me.OleDbDataAdapter1, True)
                    ClsDs.UpdateDataSource(dataSet.Tables.Item(Me.TableNameSub), Me.OleDbDataAdapter2, True)
                    Me.objDS.Merge(dataSet)
                    Me.objDS.AcceptChanges
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Throw exception
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Private Function ValidateBeforeDelete() As Boolean
            If (Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position < 0) Then
                Return False
            End If
            If Operators.ConditionalCompareObjectEqual(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item("SystemFilter"), 1, False) Then
                Interaction.MsgBox(MyBase.BKGlobal.GetMsg(&H33, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
                Return False
            End If
            If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), 0, False), Not Me.SessionInfo.CanModifyGlobalViews)) Then
                Interaction.MsgBox(MyBase.BKGlobal.GetMsg(50, Me.SessionInfo.UserLang, True), MsgBoxStyle.Information, Nothing)
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
        Friend Overridable Property btnRefreshSQL As SimpleButton
            Get
                Return Me._btnRefreshSQL
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnRefreshSQL Is Nothing) Then
                    RemoveHandler Me._btnRefreshSQL.Click, New EventHandler(AddressOf Me.btnRefreshSQL_Click)
                End If
                Me._btnRefreshSQL = WithEventsValue
                If (Not Me._btnRefreshSQL Is Nothing) Then
                    AddHandler Me._btnRefreshSQL.Click, New EventHandler(AddressOf Me.btnRefreshSQL_Click)
                End If
            End Set
        End Property

        Friend Overridable Property chkDefaultFilter As CheckBox
            Get
                Return Me._chkDefaultFilter
            End Get
            Set(ByVal WithEventsValue As CheckBox)
                Me._chkDefaultFilter = WithEventsValue
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

        Friend Overridable Property GridColumn1 As GridColumn
            Get
                Return Me._GridColumn1
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._GridColumn1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GridColumn2 As GridColumn
            Get
                Return Me._GridColumn2
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._GridColumn2 = WithEventsValue
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

        Friend Overridable Property lblDescription As Label
            Get
                Return Me._lblDescription
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblDescription = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblFilterName As Label
            Get
                Return Me._lblFilterName
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblFilterName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblTopRows As Label
            Get
                Return Me._lblTopRows
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblTopRows = WithEventsValue
            End Set
        End Property

        Friend Overridable Property objDS As dsFilter
            Get
                Return Me._objDS
            End Get
            Set(ByVal WithEventsValue As dsFilter)
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

        Friend Overridable Property TabControl1 As TabControl
            Get
                Return Me._TabControl1
            End Get
            Set(ByVal WithEventsValue As TabControl)
                Me._TabControl1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tabCriteria1 As TabPage
            Get
                Return Me._tabCriteria1
            End Get
            Set(ByVal WithEventsValue As TabPage)
                Me._tabCriteria1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tabSQL As TabPage
            Get
                Return Me._tabSQL
            End Get
            Set(ByVal WithEventsValue As TabPage)
                Me._tabSQL = WithEventsValue
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

        Friend Overridable Property txtSQL As MemoEdit
            Get
                Return Me._txtSQL
            End Get
            Set(ByVal WithEventsValue As MemoEdit)
                Me._txtSQL = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txttopRows As CalcEdit
            Get
                Return Me._txttopRows
            End Get
            Set(ByVal WithEventsValue As CalcEdit)
                Me._txttopRows = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("btnRefreshSQL")> _
        Private _btnRefreshSQL As SimpleButton
        <AccessedThroughProperty("chkDefaultFilter")> _
        Private _chkDefaultFilter As CheckBox
        <AccessedThroughProperty("Grid1")> _
        Private _Grid1 As GridControl
        <AccessedThroughProperty("GridColumn1")> _
        Private _GridColumn1 As GridColumn
        <AccessedThroughProperty("GridColumn2")> _
        Private _GridColumn2 As GridColumn
        <AccessedThroughProperty("GridView1")> _
        Private _GridView1 As GridView
        <AccessedThroughProperty("lblDescription")> _
        Private _lblDescription As Label
        <AccessedThroughProperty("lblFilterName")> _
        Private _lblFilterName As Label
        <AccessedThroughProperty("lblTopRows")> _
        Private _lblTopRows As Label
        <AccessedThroughProperty("objDS")> _
        Private _objDS As dsFilter
        <AccessedThroughProperty("OleDbDataAdapter1")> _
        Private _OleDbDataAdapter1 As OleDbDataAdapter
        <AccessedThroughProperty("OleDbDataAdapter2")> _
        Private _OleDbDataAdapter2 As OleDbDataAdapter
        <AccessedThroughProperty("OleDbDeleteCommand1")> _
        Private _OleDbDeleteCommand1 As OleDbCommand
        <AccessedThroughProperty("OleDbDeleteCommand2")> _
        Private _OleDbDeleteCommand2 As OleDbCommand
        <AccessedThroughProperty("OleDbInsertCommand1")> _
        Private _OleDbInsertCommand1 As OleDbCommand
        <AccessedThroughProperty("OleDbInsertCommand2")> _
        Private _OleDbInsertCommand2 As OleDbCommand
        <AccessedThroughProperty("OleDbSelectCommand1")> _
        Private _OleDbSelectCommand1 As OleDbCommand
        <AccessedThroughProperty("OleDbSelectCommand2")> _
        Private _OleDbSelectCommand2 As OleDbCommand
        <AccessedThroughProperty("OleDbUpdateCommand1")> _
        Private _OleDbUpdateCommand1 As OleDbCommand
        <AccessedThroughProperty("OleDbUpdateCommand2")> _
        Private _OleDbUpdateCommand2 As OleDbCommand
        <AccessedThroughProperty("Panel1")> _
        Private _Panel1 As Panel
        <AccessedThroughProperty("Panel2")> _
        Private _Panel2 As Panel
        <AccessedThroughProperty("Panel3")> _
        Private _Panel3 As Panel
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl
        <AccessedThroughProperty("tabCriteria1")> _
        Private _tabCriteria1 As TabPage
        <AccessedThroughProperty("tabSQL")> _
        Private _tabSQL As TabPage
        <AccessedThroughProperty("txtDescription")> _
        Private _txtDescription As TextBox
        <AccessedThroughProperty("txtName")> _
        Private _txtName As TextBox
        <AccessedThroughProperty("txtSQL")> _
        Private _txtSQL As MemoEdit
        <AccessedThroughProperty("txttopRows")> _
        Private _txttopRows As CalcEdit
        Private components As IContainer
        Public FilterForMenuID As Integer
        Public FilterForTable As DataTable
        Private KeyDataSet As String
        Public NewFilterID As Integer
        Private TableNameSub As String
    End Class
End Namespace

