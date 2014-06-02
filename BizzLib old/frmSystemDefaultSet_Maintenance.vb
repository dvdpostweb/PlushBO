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
    Public Class frmSystemDefaultSet_Maintenance
        Inherits frmGeneral_Maintenance
        ' Methods
        Public Sub New()
            AddHandler MyBase.EventLoadDataset, New EventLoadDatasetEventHandler(AddressOf Me.LoadDataSet)
            AddHandler MyBase.EventNewRecord, New EventNewRecordEventHandler(AddressOf Me.NewRecord)
            AddHandler MyBase.EventPositionChanged, New EventPositionChangedEventHandler(AddressOf Me.PositionChanged)
            AddHandler MyBase.EventEditRecord, New EventEditRecordEventHandler(AddressOf Me.EditRecord)
            AddHandler MyBase.EventSaveChanges, New EventSaveChangesEventHandler(AddressOf Me.SaveChanges)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.EventUndoChanges, New EventUndoChangesEventHandler(AddressOf Me.UndoChanges)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            AddHandler MyBase.EventDeleteRecord, New EventDeleteRecordEventHandler(AddressOf Me.DeleteRecord)
            AddHandler MyBase.EventUpdateDataset, New EventUpdateDatasetEventHandler(AddressOf Me.UpdateDataSet)
            AddHandler MyBase.EventEnablingEditFields, New EventEnablingEditFieldsEventHandler(AddressOf Me.EnablingEditFields)
            AddHandler MyBase.EventEnablingkeyFields, New EventEnablingkeyFieldsEventHandler(AddressOf Me.EnablingKeyFields)
            AddHandler MyBase.EventPrintForm, New EventPrintFormEventHandler(AddressOf Me.StartPrintForm)
            Dim list As ArrayList = frmSystemDefaultSet_Maintenance.__ENCList
            SyncLock list
                frmSystemDefaultSet_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableNameSub = "generaldefaultsetsub"
            Me.KeyDataSet = "BizzLib.dsDefaultSet"
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.EventLoadDataset, New EventLoadDatasetEventHandler(AddressOf Me.LoadDataSet)
            AddHandler MyBase.EventNewRecord, New EventNewRecordEventHandler(AddressOf Me.NewRecord)
            AddHandler MyBase.EventPositionChanged, New EventPositionChangedEventHandler(AddressOf Me.PositionChanged)
            AddHandler MyBase.EventEditRecord, New EventEditRecordEventHandler(AddressOf Me.EditRecord)
            AddHandler MyBase.EventSaveChanges, New EventSaveChangesEventHandler(AddressOf Me.SaveChanges)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.EventUndoChanges, New EventUndoChangesEventHandler(AddressOf Me.UndoChanges)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            AddHandler MyBase.EventDeleteRecord, New EventDeleteRecordEventHandler(AddressOf Me.DeleteRecord)
            AddHandler MyBase.EventUpdateDataset, New EventUpdateDatasetEventHandler(AddressOf Me.UpdateDataSet)
            AddHandler MyBase.EventEnablingEditFields, New EventEnablingEditFieldsEventHandler(AddressOf Me.EnablingEditFields)
            AddHandler MyBase.EventEnablingkeyFields, New EventEnablingkeyFieldsEventHandler(AddressOf Me.EnablingKeyFields)
            AddHandler MyBase.EventPrintForm, New EventPrintFormEventHandler(AddressOf Me.StartPrintForm)
            Dim list As ArrayList = frmSystemDefaultSet_Maintenance.__ENCList
            SyncLock list
                frmSystemDefaultSet_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableNameSub = "generaldefaultsetsub"
            Me.KeyDataSet = "BizzLib.dsDefaultSet"
            Me.InitializeComponent
        End Sub

        Private Sub DeleteRecord(ByVal Sender As Object, ByVal e As EventArgs)
            If (((Me.BindingContext.Item(Me.objDS, MyBase.TableName).Count > 0) AndAlso (Interaction.MsgBox(MyBase.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes)) AndAlso Me.ValidateBeforeDelete) Then
                MyBase.BKDefaultSet.DeleteDefaultSet(Conversions.ToInteger(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField)))
                Me.EnablingAll(False)
                Me.LoadDataSet
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
            Me.chkDefault.Enabled = Enabling
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
                MyBase.IDField = "DefaultSetID"
                MyBase.TableName = "generaldefaultset"
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
            Dim manager As New ResourceManager(GetType(frmSystemDefaultSet_Maintenance))
            Me.lblSetName = New Label
            Me.lblDescription = New Label
            Me.txtName = New TextBox
            Me.objDS = New dsDefaultSet
            Me.txtDescription = New TextBox
            Me.Panel1 = New Panel
            Me.TabControl1 = New TabControl
            Me.tabCriteria1 = New TabPage
            Me.Grid1 = New GridControl
            Me.GridView1 = New GridView
            Me.colDefaultSetID = New GridColumn
            Me.colControlName = New GridColumn
            Me.colControlType = New GridColumn
            Me.colControlProperty = New GridColumn
            Me.colValueType = New GridColumn
            Me.colDateValue = New GridColumn
            Me.colBoolValue = New GridColumn
            Me.colIntValue = New GridColumn
            Me.colDblValue = New GridColumn
            Me.colStringValue = New GridColumn
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
            Me.objDS.BeginInit
            Me.Panel1.SuspendLayout
            Me.TabControl1.SuspendLayout
            Me.tabCriteria1.SuspendLayout
            Me.Grid1.BeginInit
            Me.GridView1.BeginInit
            Me.Panel2.SuspendLayout
            Me.SuspendLayout
            Dim point As New Point(8, 8)
            Me.lblSetName.Location = point
            Me.lblSetName.Name = "lblSetName"
            Me.lblSetName.TabIndex = 3
            Me.lblSetName.Text = "Name"
            point = New Point(8, &H20)
            Me.lblDescription.Location = point
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.TabIndex = 4
            Me.lblDescription.Text = "Description"
            Me.txtName.DataBindings.Add(New Binding("Text", Me.objDS, "generaldefaultset.Name"))
            Me.txtName.Enabled = False
            point = New Point(&H70, 8)
            Me.txtName.Location = point
            Me.txtName.Name = "txtName"
            Dim size As New Size(&HC0, 20)
            Me.txtName.Size = size
            Me.txtName.TabIndex = 8
            Me.txtName.Text = ""
            Me.objDS.DataSetName = "dsDefaultSet"
            Me.objDS.Locale = New CultureInfo("en-US")
            Me.txtDescription.DataBindings.Add(New Binding("Text", Me.objDS, "generaldefaultset.Description"))
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
            Me.tabCriteria1.Text = "Default Values"
            Me.Grid1.set_DataSource(Me.objDS.generaldefaultsetsub)
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
            Me.GridView1.get_Columns.AddRange(New GridColumn() { Me.colDefaultSetID, Me.colControlName, Me.colControlType, Me.colControlProperty, Me.colValueType, Me.colDateValue, Me.colBoolValue, Me.colIntValue, Me.colDblValue, Me.colStringValue })
            Me.GridView1.set_GridControl(Me.Grid1)
            Me.GridView1.set_GroupPanelText("...")
            Me.GridView1.set_Name("GridView1")
            Me.GridView1.get_OptionsBehavior.set_Editable(False)
            Me.colDefaultSetID.set_Caption("DefaultSetID")
            Me.colDefaultSetID.set_FieldName("DefaultSetID")
            Me.colDefaultSetID.set_Name("colDefaultSetID")
            Me.colDefaultSetID.set_VisibleIndex(0)
            Me.colControlName.set_Caption("ControlName")
            Me.colControlName.set_FieldName("ControlName")
            Me.colControlName.set_Name("colControlName")
            Me.colControlName.set_VisibleIndex(1)
            Me.colControlType.set_Caption("ControlType")
            Me.colControlType.set_FieldName("ControlType")
            Me.colControlType.set_Name("colControlType")
            Me.colControlType.set_VisibleIndex(2)
            Me.colControlProperty.set_Caption("ControlProperty")
            Me.colControlProperty.set_FieldName("ControlProperty")
            Me.colControlProperty.set_Name("colControlProperty")
            Me.colControlProperty.set_VisibleIndex(3)
            Me.colValueType.set_Caption("ValueType")
            Me.colValueType.set_FieldName("ValueType")
            Me.colValueType.set_Name("colValueType")
            Me.colValueType.set_VisibleIndex(4)
            Me.colDateValue.set_Caption("DateValue")
            Me.colDateValue.set_FieldName("DateValue")
            Me.colDateValue.set_Name("colDateValue")
            Me.colDateValue.set_VisibleIndex(5)
            Me.colBoolValue.set_Caption("BoolValue")
            Me.colBoolValue.set_FieldName("BoolValue")
            Me.colBoolValue.set_Name("colBoolValue")
            Me.colBoolValue.set_VisibleIndex(6)
            Me.colIntValue.set_Caption("IntValue")
            Me.colIntValue.set_FieldName("IntValue")
            Me.colIntValue.set_Name("colIntValue")
            Me.colIntValue.set_VisibleIndex(7)
            Me.colDblValue.set_Caption("DblValue")
            Me.colDblValue.set_FieldName("DblValue")
            Me.colDblValue.set_Name("colDblValue")
            Me.colDblValue.set_VisibleIndex(8)
            Me.colStringValue.set_Caption("StringValue")
            Me.colStringValue.set_FieldName("StringValue")
            Me.colStringValue.set_Name("colStringValue")
            Me.colStringValue.set_VisibleIndex(9)
            Me.Panel2.Controls.Add(Me.txtName)
            Me.Panel2.Controls.Add(Me.lblDescription)
            Me.Panel2.Controls.Add(Me.lblSetName)
            Me.Panel2.Controls.Add(Me.txtDescription)
            Me.Panel2.Controls.Add(Me.chkDefault)
            Me.Panel2.Dock = DockStyle.Top
            point = New Point(0, 0)
            Me.Panel2.Location = point
            Me.Panel2.Name = "Panel2"
            size = New Size(&H210, &H60)
            Me.Panel2.Size = size
            Me.Panel2.TabIndex = 11
            Me.chkDefault.CheckAlign = ContentAlignment.MiddleRight
            Me.chkDefault.DataBindings.Add(New Binding("Checked", Me.objDS, "generaldefaultset.DefaultCriteria"))
            point = New Point(8, &H38)
            Me.chkDefault.Location = point
            Me.chkDefault.Name = "chkDefault"
            size = New Size(120, &H18)
            Me.chkDefault.Size = size
            Me.chkDefault.TabIndex = 10
            Me.chkDefault.Text = "Default"
            Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
            Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
            Me.OleDbDataAdapter1.TableMappings.AddRange(New DataTableMapping() { New DataTableMapping("Table", "generaldefaultset", New DataColumnMapping() { New DataColumnMapping("DefaultSetID", "DefaultSetID"), New DataColumnMapping("UserID", "UserID"), New DataColumnMapping("MenuID", "MenuID"), New DataColumnMapping("Name", "Name"), New DataColumnMapping("Description", "Description"), New DataColumnMapping("DefaultCriteria", "DefaultCriteria"), New DataColumnMapping("SystemCriteria", "SystemCriteria"), New DataColumnMapping("TemplateCriteria", "TemplateCriteria") }) })
            Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
            Me.OleDbDeleteCommand1.CommandText = "DELETE FROM generaldefaultset WHERE (DefaultSetID = ?) AND (DefaultCriteria = ? OR ? IS NULL AND DefaultCriteria IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (MenuID = ? OR ? IS NULL AND MenuID IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (SystemCriteria = ? OR ? IS NULL AND SystemCriteria IS NULL) AND (TemplateCriteria = ? OR ? IS NULL AND TemplateCriteria IS NULL) AND (UserID = ? OR ? IS NULL AND UserID IS NULL)"
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_DefaultSetID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultSetID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_DefaultCriteria", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_DefaultCriteria1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_MenuID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_MenuID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Name", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Name1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_SystemCriteria", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_SystemCriteria1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_TemplateCriteria", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TemplateCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_TemplateCriteria1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TemplateCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_UserID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_UserID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing))
            Me.OleDbInsertCommand1.CommandText = "INSERT INTO generaldefaultset(DefaultSetID, UserID, MenuID, Name, Description, DefaultCriteria, SystemCriteria, TemplateCriteria) VALUES (?, ?, ?, ?, ?, ?, ?, ?); SELECT DefaultSetID, UserID, MenuID, Name, Description, DefaultCriteria, SystemCriteria, TemplateCriteria FROM generaldefaultset WHERE (DefaultSetID = ?)"
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("DefaultSetID", OleDbType.Integer, 4, "DefaultSetID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("UserID", OleDbType.Integer, 4, "UserID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("MenuID", OleDbType.Integer, 4, "MenuID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Name", OleDbType.VarChar, 50, "Name"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 50, "Description"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("DefaultCriteria", OleDbType.Integer, 4, "DefaultCriteria"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("SystemCriteria", OleDbType.Integer, 4, "SystemCriteria"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("TemplateCriteria", OleDbType.Integer, 4, "TemplateCriteria"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_DefaultSetID", OleDbType.Integer, 4, "DefaultSetID"))
            Me.OleDbSelectCommand1.CommandText = "SELECT DefaultSetID, UserID, MenuID, Name, Description, DefaultCriteria, SystemCriteria, TemplateCriteria FROM generaldefaultset"
            Me.OleDbUpdateCommand1.CommandText = "UPDATE generaldefaultset SET DefaultSetID = ?, UserID = ?, MenuID = ?, Name = ?, Description = ?, DefaultCriteria = ?, SystemCriteria = ?, TemplateCriteria = ? WHERE (DefaultSetID = ?) AND (DefaultCriteria = ? OR ? IS NULL AND DefaultCriteria IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (MenuID = ? OR ? IS NULL AND MenuID IS NULL) AND (Name = ? OR ? IS NULL AND Name IS NULL) AND (SystemCriteria = ? OR ? IS NULL AND SystemCriteria IS NULL) AND (TemplateCriteria = ? OR ? IS NULL AND TemplateCriteria IS NULL) AND (UserID = ? OR ? IS NULL AND UserID IS NULL); SELECT DefaultSetID, UserID, MenuID, Name, Description, DefaultCriteria, SystemCriteria, TemplateCriteria FROM generaldefaultset WHERE (DefaultSetID = ?)"
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("DefaultSetID", OleDbType.Integer, 4, "DefaultSetID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("UserID", OleDbType.Integer, 4, "UserID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("MenuID", OleDbType.Integer, 4, "MenuID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Name", OleDbType.VarChar, 50, "Name"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 50, "Description"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("DefaultCriteria", OleDbType.Integer, 4, "DefaultCriteria"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("SystemCriteria", OleDbType.Integer, 4, "SystemCriteria"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("TemplateCriteria", OleDbType.Integer, 4, "TemplateCriteria"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_DefaultSetID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultSetID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_DefaultCriteria", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_DefaultCriteria1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_MenuID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_MenuID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "MenuID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Name", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Name1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Name", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_SystemCriteria", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_SystemCriteria1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "SystemCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_TemplateCriteria", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TemplateCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_TemplateCriteria1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "TemplateCriteria", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_UserID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_UserID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_DefaultSetID", OleDbType.Integer, 4, "DefaultSetID"))
            Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
            Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
            Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
            Me.OleDbDataAdapter2.TableMappings.AddRange(New DataTableMapping() { New DataTableMapping("Table", "generaldefaultsetsub", New DataColumnMapping() { New DataColumnMapping("DefaultSetID", "DefaultSetID"), New DataColumnMapping("ControlName", "ControlName"), New DataColumnMapping("ControlType", "ControlType"), New DataColumnMapping("ControlProperty", "ControlProperty"), New DataColumnMapping("ValueType", "ValueType"), New DataColumnMapping("DateValue", "DateValue"), New DataColumnMapping("BoolValue", "BoolValue"), New DataColumnMapping("IntValue", "IntValue"), New DataColumnMapping("DblValue", "DblValue"), New DataColumnMapping("StringValue", "StringValue") }) })
            Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
            Me.OleDbDeleteCommand2.CommandText = "DELETE FROM generaldefaultsetsub WHERE (ControlName = ?) AND (DefaultSetID = ?) AND (BoolValue = ? OR ? IS NULL AND BoolValue IS NULL) AND (ControlProperty = ? OR ? IS NULL AND ControlProperty IS NULL) AND (ControlType = ? OR ? IS NULL AND ControlType IS NULL) AND (DateValue = ? OR ? IS NULL AND DateValue IS NULL) AND (DblValue = ? OR ? IS NULL AND DblValue IS NULL) AND (IntValue = ? OR ? IS NULL AND IntValue IS NULL) AND (StringValue = ? OR ? IS NULL AND StringValue IS NULL) AND (ValueType = ? OR ? IS NULL AND ValueType IS NULL)"
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_ControlName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlName", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_DefaultSetID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultSetID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_BoolValue", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "BoolValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_BoolValue1", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "BoolValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_ControlProperty", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlProperty", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_ControlProperty1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlProperty", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_ControlType", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlType", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_ControlType1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlType", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_DateValue", OleDbType.DBTimeStamp, 8, ParameterDirection.Input, False, 0, 0, "DateValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_DateValue1", OleDbType.DBTimeStamp, 8, ParameterDirection.Input, False, 0, 0, "DateValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_DblValue", OleDbType.Double, 8, ParameterDirection.Input, False, 0, 0, "DblValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_DblValue1", OleDbType.Double, 8, ParameterDirection.Input, False, 0, 0, "DblValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_IntValue", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "IntValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_IntValue1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "IntValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_StringValue", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "StringValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_StringValue1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "StringValue", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_ValueType", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ValueType", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_ValueType1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ValueType", DataRowVersion.Original, Nothing))
            Me.OleDbInsertCommand2.CommandText = "INSERT INTO generaldefaultsetsub(DefaultSetID, ControlName, ControlType, ControlProperty, ValueType, DateValue, BoolValue, IntValue, DblValue, StringValue) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?); SELECT DefaultSetID, ControlName, ControlType, ControlProperty, ValueType, DateValue, BoolValue, IntValue, DblValue, StringValue FROM generaldefaultsetsub WHERE (ControlName = ?) AND (DefaultSetID = ?)"
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("DefaultSetID", OleDbType.Integer, 4, "DefaultSetID"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("ControlName", OleDbType.VarChar, 50, "ControlName"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("ControlType", OleDbType.VarChar, 50, "ControlType"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("ControlProperty", OleDbType.VarChar, 50, "ControlProperty"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("ValueType", OleDbType.VarChar, 50, "ValueType"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("DateValue", OleDbType.DBTimeStamp, 8, "DateValue"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("BoolValue", OleDbType.Boolean, 1, "BoolValue"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("IntValue", OleDbType.Integer, 4, "IntValue"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("DblValue", OleDbType.Double, 8, "DblValue"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("StringValue", OleDbType.VarChar, 50, "StringValue"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Select_ControlName", OleDbType.VarChar, 50, "ControlName"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Select_DefaultSetID", OleDbType.Integer, 4, "DefaultSetID"))
            Me.OleDbSelectCommand2.CommandText = "SELECT DefaultSetID, ControlName, ControlType, ControlProperty, ValueType, DateValue, BoolValue, IntValue, DblValue, StringValue FROM generaldefaultsetsub"
            Me.OleDbUpdateCommand2.CommandText = "UPDATE generaldefaultsetsub SET DefaultSetID = ?, ControlName = ?, ControlType = ?, ControlProperty = ?, ValueType = ?, DateValue = ?, BoolValue = ?, IntValue = ?, DblValue = ?, StringValue = ? WHERE (ControlName = ?) AND (DefaultSetID = ?) AND (BoolValue = ? OR ? IS NULL AND BoolValue IS NULL) AND (ControlProperty = ? OR ? IS NULL AND ControlProperty IS NULL) AND (ControlType = ? OR ? IS NULL AND ControlType IS NULL) AND (DateValue = ? OR ? IS NULL AND DateValue IS NULL) AND (DblValue = ? OR ? IS NULL AND DblValue IS NULL) AND (IntValue = ? OR ? IS NULL AND IntValue IS NULL) AND (StringValue = ? OR ? IS NULL AND StringValue IS NULL) AND (ValueType = ? OR ? IS NULL AND ValueType IS NULL); SELECT DefaultSetID, ControlName, ControlType, ControlProperty, ValueType, DateValue, BoolValue, IntValue, DblValue, StringValue FROM generaldefaultsetsub WHERE (ControlName = ?) AND (DefaultSetID = ?)"
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("DefaultSetID", OleDbType.Integer, 4, "DefaultSetID"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("ControlName", OleDbType.VarChar, 50, "ControlName"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("ControlType", OleDbType.VarChar, 50, "ControlType"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("ControlProperty", OleDbType.VarChar, 50, "ControlProperty"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("ValueType", OleDbType.VarChar, 50, "ValueType"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("DateValue", OleDbType.DBTimeStamp, 8, "DateValue"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("BoolValue", OleDbType.Boolean, 1, "BoolValue"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("IntValue", OleDbType.Integer, 4, "IntValue"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("DblValue", OleDbType.Double, 8, "DblValue"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("StringValue", OleDbType.VarChar, 50, "StringValue"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_ControlName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlName", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_DefaultSetID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "DefaultSetID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_BoolValue", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "BoolValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_BoolValue1", OleDbType.Boolean, 1, ParameterDirection.Input, False, 0, 0, "BoolValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_ControlProperty", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlProperty", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_ControlProperty1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlProperty", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_ControlType", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlType", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_ControlType1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ControlType", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_DateValue", OleDbType.DBTimeStamp, 8, ParameterDirection.Input, False, 0, 0, "DateValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_DateValue1", OleDbType.DBTimeStamp, 8, ParameterDirection.Input, False, 0, 0, "DateValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_DblValue", OleDbType.Double, 8, ParameterDirection.Input, False, 0, 0, "DblValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_DblValue1", OleDbType.Double, 8, ParameterDirection.Input, False, 0, 0, "DblValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_IntValue", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "IntValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_IntValue1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "IntValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_StringValue", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "StringValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_StringValue1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "StringValue", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_ValueType", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ValueType", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_ValueType1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "ValueType", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Select_ControlName", OleDbType.VarChar, 50, "ControlName"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Select_DefaultSetID", OleDbType.Integer, 4, "DefaultSetID"))
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Size(&H210, &H1CE)
            Me.ClientSize = size
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "frmSystemDefaultSet_Maintenance"
            Me.Text = "Default Set"
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.objDS.EndInit
            Me.Panel1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.tabCriteria1.ResumeLayout(False)
            Me.Grid1.EndInit
            Me.GridView1.EndInit
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadDataSet()
            Dim set2 As New clsDataSet(Me.SessionInfo)
            Dim dataSet As DataSet = Me.objDS.Clone
            Try 
                Me.OleDbDataAdapter1.SelectCommand.CommandText = String.Concat(New String() { MyBase.SQLTxt1, " WHERE UserID = ", Conversions.ToString(Me.SessionInfo.UserID), " AND MenuID = ", Conversions.ToString(Me.ForMenuID), " ORDER BY ", MyBase.KeyFieldName })
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
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("MenuID").DefaultValue = Me.ForMenuID
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("UserID").DefaultValue = Me.SessionInfo.UserID
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("DefaultCriteria").DefaultValue = 0
                Me.objDS.Tables.Item(MyBase.TableName).Columns.Item("SystemCriteria").DefaultValue = 0
                Me.objDS.Tables.Item(MyBase.TableName).DefaultView.Sort = "Name"
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub LoadDataSetSub(ByVal DefaultSetID As Integer)
            Dim set2 As New clsDataSet(Me.SessionInfo)
            Dim dataSet As DataSet = Me.objDS.Clone
            Try 
                Me.OleDbDataAdapter2.SelectCommand.CommandText = ("SELECT * FROM generaldefaultsetsub WHERE DefaultSetID = " & Conversions.ToString(DefaultSetID) & " ORDER BY ControlName")
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
                Me.objDS.Tables.Item(Me.TableNameSub).DefaultView.Sort = "ControlName"
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
                Me.objDS.Tables.Item(Me.TableNameSub).Clear
                Me.BindingContext.Item(Me.objDS, MyBase.TableName).EndCurrentEdit
                Me.BindingContext.Item(Me.objDS, MyBase.TableName).AddNew
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
            Dim defaultSetID As Integer = -1
            If (Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position >= 0) Then
                Me.StatusBar1.Text = ((Me.BindingContext.Item(Me.objDS, MyBase.TableName).Position + 1).ToString & " of  " & Me.BindingContext.Item(Me.objDS, MyBase.TableName).Count.ToString)
                Me.ToolTip1.SetToolTip(Me.StatusBar1, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(((MyBase.TableName & "-->") & MyBase.IDField & "="), DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField)), "")))
                Me.txtQuickSearch.set_EditValue(Me.txtName.Text)
                If (MyBase.OpenType <> "NEW") Then
                    defaultSetID = Conversions.ToInteger(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), ""))
                    Me.LoadDataSetSub(defaultSetID)
                End If
            End If
        End Sub

        Private Sub SaveChanges(ByVal Sender As Object, ByVal e As EventArgs)
            If Me.ValidateBeforeSave Then
                Dim num As Integer
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
                    num = Conversions.ToInteger(MyBase.BKGlobal.GetNextID(MyBase.IDField))
                    DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField) = num
                    Try 
                        enumerator = Me.objDS.Tables.Item(Me.TableNameSub).DefaultView.GetEnumerator
                        Do While enumerator.MoveNext
                            Dim current As DataRowView = DirectCast(enumerator.Current, DataRowView)
                            current.Item("FilterID") = num
                        Loop
                    Finally
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator,IDisposable).Dispose
                        End If
                    End Try
                Else
                    num = Conversions.ToInteger(Operators.ConcatenateObject(DirectCast(Me.BindingContext.Item(Me.objDS, MyBase.TableName).Current, DataRowView).Item(MyBase.IDField), ""))
                End If
                Try 
                    Me.UpdateDataSet
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    MessageBox.Show(exception.Message)
                    ProjectData.ClearProjectError
                End Try
                If Me.chkDefault.Checked Then
                    MyBase.BKDefaultSet.DefaultSetAssignDefault(num, Me.ForMenuID)
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
            Dim set2 As New clsDataSet(Me.SessionInfo)
            Dim dataSet As New dsDefaultSet
            Me.BindingContext.Item(Me.objDS, MyBase.TableName).EndCurrentEdit
            dataSet = DirectCast(Me.objDS.GetChanges, dsDefaultSet)
            If (Not dataSet Is Nothing) Then
                Try 
                    set2.UpdateDataSource(dataSet.Tables.Item(MyBase.TableName), Me.OleDbDataAdapter1, True)
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
        Friend Overridable Property chkDefault As CheckBox
            Get
                Return Me._chkDefault
            End Get
            Set(ByVal WithEventsValue As CheckBox)
                Me._chkDefault = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colBoolValue As GridColumn
            Get
                Return Me._colBoolValue
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colBoolValue = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colControlName As GridColumn
            Get
                Return Me._colControlName
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colControlName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colControlProperty As GridColumn
            Get
                Return Me._colControlProperty
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colControlProperty = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colControlType As GridColumn
            Get
                Return Me._colControlType
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colControlType = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colDateValue As GridColumn
            Get
                Return Me._colDateValue
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colDateValue = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colDblValue As GridColumn
            Get
                Return Me._colDblValue
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colDblValue = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colDefaultSetID As GridColumn
            Get
                Return Me._colDefaultSetID
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colDefaultSetID = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colIntValue As GridColumn
            Get
                Return Me._colIntValue
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colIntValue = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colStringValue As GridColumn
            Get
                Return Me._colStringValue
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colStringValue = WithEventsValue
            End Set
        End Property

        Friend Overridable Property colValueType As GridColumn
            Get
                Return Me._colValueType
            End Get
            Set(ByVal WithEventsValue As GridColumn)
                Me._colValueType = WithEventsValue
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

        Friend Overridable Property lblSetName As Label
            Get
                Return Me._lblSetName
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblSetName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property objDS As dsDefaultSet
            Get
                Return Me._objDS
            End Get
            Set(ByVal WithEventsValue As dsDefaultSet)
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
        <AccessedThroughProperty("chkDefault")> _
        Private _chkDefault As CheckBox
        <AccessedThroughProperty("colBoolValue")> _
        Private _colBoolValue As GridColumn
        <AccessedThroughProperty("colControlName")> _
        Private _colControlName As GridColumn
        <AccessedThroughProperty("colControlProperty")> _
        Private _colControlProperty As GridColumn
        <AccessedThroughProperty("colControlType")> _
        Private _colControlType As GridColumn
        <AccessedThroughProperty("colDateValue")> _
        Private _colDateValue As GridColumn
        <AccessedThroughProperty("colDblValue")> _
        Private _colDblValue As GridColumn
        <AccessedThroughProperty("colDefaultSetID")> _
        Private _colDefaultSetID As GridColumn
        <AccessedThroughProperty("colIntValue")> _
        Private _colIntValue As GridColumn
        <AccessedThroughProperty("colStringValue")> _
        Private _colStringValue As GridColumn
        <AccessedThroughProperty("colValueType")> _
        Private _colValueType As GridColumn
        <AccessedThroughProperty("Grid1")> _
        Private _Grid1 As GridControl
        <AccessedThroughProperty("GridView1")> _
        Private _GridView1 As GridView
        <AccessedThroughProperty("lblDescription")> _
        Private _lblDescription As Label
        <AccessedThroughProperty("lblSetName")> _
        Private _lblSetName As Label
        <AccessedThroughProperty("objDS")> _
        Private _objDS As dsDefaultSet
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
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl
        <AccessedThroughProperty("tabCriteria1")> _
        Private _tabCriteria1 As TabPage
        <AccessedThroughProperty("txtDescription")> _
        Private _txtDescription As TextBox
        <AccessedThroughProperty("txtName")> _
        Private _txtName As TextBox
        Private components As IContainer
        Public ForMenuID As Integer
        Private KeyDataSet As String
        Private TableNameSub As String
    End Class
End Namespace

