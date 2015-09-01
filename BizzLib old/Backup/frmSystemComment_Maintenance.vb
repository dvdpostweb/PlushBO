Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
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
    Public Class frmSystemComment_Maintenance
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            AddHandler MyBase.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmSystemComment_Maintenance.__ENCList
            SyncLock list
                frmSystemComment_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableName = "generalcomment"
            Me.CommentTableName = ""
            Me.CommentRef = ""
            Me.CommentFieldName = ""
            Me.CommentFieldID = -1
            Me.DataTableLinked = False
            Me.OpenType = "BROWSE"
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmSystemComment_Maintenance.__ENCList
            SyncLock list
                frmSystemComment_Maintenance.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.TableName = "generalcomment"
            Me.CommentTableName = ""
            Me.CommentRef = ""
            Me.CommentFieldName = ""
            Me.CommentFieldID = -1
            Me.DataTableLinked = False
            Me.OpenType = "BROWSE"
            Me.InitializeComponent
        End Sub

        Private Sub btnDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.DeleteRecord
        End Sub

        Private Sub btnEdit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.EditRecord
        End Sub

        Private Sub btnFirst_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.btnNavFirst_Click
        End Sub

        Private Sub btnLast_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.btnNavLast_Click
        End Sub

        Private Sub btnNavFirst_Click()
            Me.BindingContext.Item(Me.objDs, Me.TableName).Position = 0
            Me.PositionChanged
        End Sub

        Private Sub btnNavLast_Click()
            Me.BindingContext.Item(Me.objDs, Me.TableName).Position = (Me.objDs.Tables.Item(Me.TableName).Rows.Count - 1)
            Me.PositionChanged
        End Sub

        Private Sub btnNavNext_Click()
            Me.BindingContext.Item(Me.objDs, Me.TableName).Position += 1
            Me.PositionChanged
        End Sub

        Private Sub btnNavPrev_Click()
            Me.BindingContext.Item(Me.objDs, Me.TableName).Position -= 1
            Me.PositionChanged
        End Sub

        Private Sub btnNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.NewRecord
        End Sub

        Private Sub btnNext_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.btnNavNext_Click
        End Sub

        Private Sub btnPrevious_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.btnNavPrev_Click
        End Sub

        Private Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.SaveChanges
        End Sub

        Private Sub btnUndo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.UndoChanges
        End Sub

        Private Sub DeleteRecord()
            If (((Me.BindingContext.Item(Me.objDs, Me.TableName).Count > 0) AndAlso (Interaction.MsgBox(MyBase.BKGlobal.GetMsg(1, Me.SessionInfo.UserLang, True), MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes)) AndAlso Me.ValidateBeforeDelete) Then
                Me.BindingContext.Item(Me.objDs, Me.TableName).RemoveAt(Me.BindingContext.Item(Me.objDs, Me.TableName).Position)
                Me.UpdateDataSet
                Me.EnablingAll(False)
                Me.PositionChanged
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub EditRecord()
            Me.btnNew.set_Enabled(False)
            Me.btnEdit.set_Enabled(False)
            Me.btnSave.set_Enabled(True)
            Me.btnDelete.set_Enabled(False)
            Me.btnUndo.set_Enabled(True)
            Me.PopMenuNew.Enabled = False
            Me.PopMenuEdit.Enabled = False
            Me.PopMenuSave.Enabled = True
            Me.PopMenuDelete.Enabled = False
            Me.PopMenuUndo.Enabled = True
            Me.EnablingForEdit
            Me.EnablingNavButton(False)
            Me.OpenType = "EDIT"
        End Sub

        Private Sub EnablingAll(ByVal Enabling As Boolean)
            Me.EnablingEditFields(Enabling)
            Me.EnablingKeyFields(Enabling)
        End Sub

        Private Sub EnablingEditFields(ByVal Enabling As Boolean)
            Me.editDescription.Enabled = Enabling
            Me.MemoEditComment.get_Properties.set_Enabled(Enabling)
        End Sub

        Private Sub EnablingForEdit()
            Me.EnablingEditFields(True)
        End Sub

        Private Sub EnablingKeyFields(ByVal Enabling As Boolean)
            If Not Me.DataTableLinked Then
                Me.editCommentRef.Enabled = Enabling
            End If
            Me.LookUpLang.get_Properties.set_Enabled(Enabling)
            Me.spinPage.get_Properties.set_Enabled(Enabling)
        End Sub

        Private Sub EnablingNavButton(ByVal Enabling As Boolean)
            Me.btnFirst.set_Enabled(Enabling)
            Me.btnPrevious.set_Enabled(Enabling)
            Me.btnLast.set_Enabled(Enabling)
            Me.btnFirst.set_Enabled(Enabling)
        End Sub

        Private Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            If ((Me.OpenType = "EDIT") Or (Me.OpenType = "NEW")) Then
                Select Case Interaction.MsgBox(MyBase.BKGlobal.GetMsg(4, Me.SessionInfo.UserLang, True), (MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel), Nothing)
                    Case MsgBoxResult.Yes
                        Me.SaveChanges
                        Exit Select
                    Case MsgBoxResult.No
                        Me.UndoChanges
                        Exit Select
                    Case MsgBoxResult.Cancel
                        e.Cancel = True
                        Exit Select
                End Select
            End If
        End Sub

        Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Me.btnSave.set_Enabled(False)
                Me.HelpProvider1.HelpNamespace = (".\Help\" & Me.SessionInfo.UserLang & "\BizzKeys.chm")
                If (((Me.CommentTableName & "") <> "") And ((Me.CommentRef & "") <> "")) Then
                    Me.DataTableLinked = True
                End If
                If (Me.OpenType = "NEW") Then
                    Me.NewRecord
                End If
                If (Me.OpenType = "EDIT") Then
                    If ((Me.CommentRef & "") <> "") Then
                        Me.BindingContext.Item(Me.objDs, Me.TableName).Position = Me.objDs.Tables.Item(Me.TableName).DefaultView.Find(New Object() { Me.CommentRef })
                        Me.PositionChanged
                        Me.EditRecord
                    Else
                        Me.OpenType = "BROWSE"
                        Return
                    End If
                End If
                Me.LoadDataSet
                Dim popMenuAssociatedTasks As MenuItem = Me.PopMenuAssociatedTasks
                MyBase.BKGlobal.LoadAssociatedMenu(Conversions.ToInteger(Me.Tag), (popMenuAssociatedTasks), Me)
                Me.PopMenuAssociatedTasks = popMenuAssociatedTasks
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError
            End Try
            Me.PositionChanged
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ResourceManager(GetType(frmSystemComment_Maintenance))
            Me.lblReference = New Label
            Me.lblLanguage = New Label
            Me.lblDescription = New Label
            Me.editCommentRef = New TextBox
            Me.objDs = New dsGeneral
            Me.editDescription = New TextBox
            Me.ToolBarContextMenu = New ContextMenu
            Me.MenuLanguages = New MenuItem
            Me.MenuAttachements = New MenuItem
            Me.StatusBar1 = New StatusBar
            Me.StatusBarPanel1 = New StatusBarPanel
            Me.StatusBarPanel2 = New StatusBarPanel
            Me.Panel1 = New Panel
            Me.editInDate1 = New DateEdit
            Me.MemoEditComment = New MemoEdit
            Me.LookUpLang = New LookUpEdit
            Me.objdsGeneral = New dsGeneral
            Me.spinPage = New SpinEdit
            Me.lblDate = New Label
            Me.lblPage = New Label
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
            Me.HelpProvider1 = New HelpProvider
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
            Me.PopMenuUserTasks = New MenuItem
            Me.cmbDefaultListRepos.BeginInit
            Me.cmbViewListRepos.BeginInit
            Me.BarManager1.BeginInit
            Me.txtQuickSearchRepos.BeginInit
            Me.cmbFilterListRepos.BeginInit
            Me.cmbReportListRepos.BeginInit
            Me.objDs.BeginInit
            Me.StatusBarPanel1.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.Panel1.SuspendLayout
            Me.editInDate1.get_Properties.BeginInit
            Me.MemoEditComment.get_Properties.BeginInit
            Me.LookUpLang.get_Properties.BeginInit
            Me.objdsGeneral.BeginInit
            Me.spinPage.get_Properties.BeginInit
            Me.SuspendLayout
            Me.Main_Bar.set_Offset(0)
            Me.Main_Bar.set_Visible(True)
            Me.Nav_Bar.set_DockCol(1)
            Me.Nav_Bar.set_Offset(&H91)
            Me.Nav_Bar.set_Visible(True)
            Dim point As New Point(&H10, 8)
            Me.lblReference.Location = point
            Me.lblReference.Name = "lblReference"
            Dim size As New Size(&H40, &H17)
            Me.lblReference.Size = size
            Me.lblReference.TabIndex = 3
            Me.lblReference.Text = "Reference"
            point = New Point(400, 8)
            Me.lblLanguage.Location = point
            Me.lblLanguage.Name = "lblLanguage"
            size = New Size(&H40, &H17)
            Me.lblLanguage.Size = size
            Me.lblLanguage.TabIndex = 4
            Me.lblLanguage.Text = "Language"
            point = New Point(&H10, &H38)
            Me.lblDescription.Location = point
            Me.lblDescription.Name = "lblDescription"
            size = New Size(&H40, &H17)
            Me.lblDescription.Size = size
            Me.lblDescription.TabIndex = 5
            Me.lblDescription.Text = "Description"
            Me.editCommentRef.DataBindings.Add(New Binding("Text", Me.objDs, "generalcomment.CommentRef"))
            Me.editCommentRef.Enabled = False
            point = New Point(&H58, 8)
            Me.editCommentRef.Location = point
            Me.editCommentRef.Name = "editCommentRef"
            size = New Size(&H128, 20)
            Me.editCommentRef.Size = size
            Me.editCommentRef.TabIndex = 0
            Me.editCommentRef.Text = ""
            Me.objDs.DataSetName = "dsGeneral"
            Me.objDs.Locale = New CultureInfo("en-US")
            Me.editDescription.DataBindings.Add(New Binding("Text", Me.objDs, "generalcomment.Description"))
            Me.editDescription.Enabled = False
            point = New Point(&H58, &H38)
            Me.editDescription.Location = point
            Me.editDescription.Name = "editDescription"
            size = New Size(480, 20)
            Me.editDescription.Size = size
            Me.editDescription.TabIndex = 4
            Me.editDescription.Text = ""
            Me.ToolBarContextMenu.MenuItems.AddRange(New MenuItem() { Me.MenuLanguages, Me.MenuAttachements })
            Me.MenuLanguages.Index = 0
            Me.MenuLanguages.Text = "Languages"
            Me.MenuAttachements.Index = 1
            Me.MenuAttachements.Text = "Attachements"
            point = New Point(0, &H1A0)
            Me.StatusBar1.Location = point
            Me.StatusBar1.Name = "StatusBar1"
            Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel1, Me.StatusBarPanel2 })
            Me.StatusBar1.ShowPanels = True
            size = New Size(&H248, &H16)
            Me.StatusBar1.Size = size
            Me.StatusBar1.TabIndex = 30
            Me.StatusBarPanel1.AutoSize = StatusBarPanelAutoSize.Contents
            Me.StatusBarPanel1.Text = "..."
            Me.StatusBarPanel1.Width = &H18
            Me.StatusBarPanel2.AutoSize = StatusBarPanelAutoSize.Contents
            Me.StatusBarPanel2.MinWidth = 0
            Me.StatusBarPanel2.Width = 10
            Me.Panel1.BackColor = SystemColors.Window
            Me.Panel1.Controls.Add(Me.editInDate1)
            Me.Panel1.Controls.Add(Me.MemoEditComment)
            Me.Panel1.Controls.Add(Me.LookUpLang)
            Me.Panel1.Controls.Add(Me.spinPage)
            Me.Panel1.Controls.Add(Me.lblDate)
            Me.Panel1.Controls.Add(Me.lblPage)
            Me.Panel1.Controls.Add(Me.editCommentRef)
            Me.Panel1.Controls.Add(Me.editDescription)
            Me.Panel1.Controls.Add(Me.lblReference)
            Me.Panel1.Controls.Add(Me.lblLanguage)
            Me.Panel1.Controls.Add(Me.lblDescription)
            Me.Panel1.Dock = DockStyle.Fill
            point = New Point(0, &H1A)
            Me.Panel1.Location = point
            Me.Panel1.Name = "Panel1"
            size = New Size(&H248, 390)
            Me.Panel1.Size = size
            Me.Panel1.TabIndex = &H1F
            Me.editInDate1.DataBindings.Add(New Binding("EditValue", Me.objDs, "generalcomment.InDate"))
            Dim time As New DateTime(&H7D4, 6, &H10, 0, 0, 0, 0)
            Me.editInDate1.set_EditValue(time)
            point = New Point(&H1D0, &H20)
            Me.editInDate1.Location = point
            Me.editInDate1.Name = "editInDate1"
            Me.editInDate1.get_Properties.get_Buttons.AddRange(New EditorButton() { New EditorButton(-5) })
            size = New Size(&H68, 20)
            Me.editInDate1.Size = size
            Me.editInDate1.TabIndex = 14
            Me.MemoEditComment.DataBindings.Add(New Binding("EditValue", Me.objDs, "generalcomment.Comment"))
            Me.MemoEditComment.set_EditValue("")
            point = New Point(&H10, &H58)
            Me.MemoEditComment.Location = point
            Me.MemoEditComment.Name = "MemoEditComment"
            size = New Size(560, &H120)
            Me.MemoEditComment.Size = size
            Me.MemoEditComment.TabIndex = 5
            Me.LookUpLang.DataBindings.Add(New Binding("EditValue", Me.objDs, "generalcomment.Lang"))
            point = New Point(&H1D0, 8)
            Me.LookUpLang.Location = point
            Me.LookUpLang.Name = "LookUpLang"
            Me.LookUpLang.get_Properties.get_Buttons.AddRange(New EditorButton() { New EditorButton(-5) })
            Me.LookUpLang.get_Properties.get_Columns.AddRange(New LookUpColumnInfo() { New LookUpColumnInfo("Lang", "Lang", &H2E, 0, "", True, 1), New LookUpColumnInfo("Description", "Description", &H40, 0, "", True, 1) })
            Me.LookUpLang.get_Properties.set_DataSource(Me.objdsGeneral.systemlanguagecode)
            Me.LookUpLang.get_Properties.set_DisplayMember("Lang")
            Me.LookUpLang.get_Properties.set_NullText("")
            Me.LookUpLang.get_Properties.set_ValueMember("Lang")
            size = New Size(&H68, 20)
            Me.LookUpLang.Size = size
            Me.LookUpLang.TabIndex = 1
            Me.objdsGeneral.DataSetName = "dsGeneral"
            Me.objdsGeneral.Locale = New CultureInfo("en-US")
            Me.spinPage.DataBindings.Add(New Binding("EditValue", Me.objDs, "generalcomment.Page"))
            Dim num As New Decimal(New Integer() { 1, 0, 0, 0 })
            Me.spinPage.set_EditValue(num)
            point = New Point(&H58, &H20)
            Me.spinPage.Location = point
            Me.spinPage.Name = "spinPage"
            Me.spinPage.get_Properties.get_Buttons.AddRange(New EditorButton() { New EditorButton })
            size = New Size(&H4B, 20)
            Me.spinPage.Size = size
            Me.spinPage.TabIndex = 2
            point = New Point(400, &H20)
            Me.lblDate.Location = point
            Me.lblDate.Name = "lblDate"
            size = New Size(&H40, &H17)
            Me.lblDate.Size = size
            Me.lblDate.TabIndex = 13
            Me.lblDate.Text = "Date"
            point = New Point(&H10, &H20)
            Me.lblPage.Location = point
            Me.lblPage.Name = "lblPage"
            size = New Size(&H40, &H17)
            Me.lblPage.Size = size
            Me.lblPage.TabIndex = 12
            Me.lblPage.Text = "Page"
            Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
            Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
            Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
            Me.OleDbDataAdapter1.TableMappings.AddRange(New DataTableMapping() { New DataTableMapping("Table", "generalcomment", New DataColumnMapping() { New DataColumnMapping("EntityID", "EntityID"), New DataColumnMapping("CommentRef", "CommentRef"), New DataColumnMapping("Lang", "Lang"), New DataColumnMapping("Page", "Page"), New DataColumnMapping("UserID", "UserID"), New DataColumnMapping("Description", "Description"), New DataColumnMapping("Comment", "Comment"), New DataColumnMapping("InDate", "InDate"), New DataColumnMapping("TableName", "TableName"), New DataColumnMapping("FieldName", "FieldName"), New DataColumnMapping("FieldID", "FieldID") }) })
            Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
            Me.OleDbDeleteCommand1.CommandText = "DELETE FROM generalcomment WHERE (CommentRef = ?) AND (EntityID = ?) AND (Lang = ?) AND (Page = ?) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (FieldID = ? OR ? IS NULL AND FieldID IS NULL) AND (FieldName = ? OR ? IS NULL AND FieldName IS NULL) AND (InDate = ? OR ? IS NULL AND InDate IS NULL) AND (TableName = ? OR ? IS NULL AND TableName IS NULL) AND (UserID = ?)"
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_CommentRef", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "CommentRef", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_EntityID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "EntityID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Page", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "Page", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_FieldID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FieldID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_FieldID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FieldID", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_FieldName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_FieldName1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_InDate", OleDbType.DBTimeStamp, 8, ParameterDirection.Input, False, 0, 0, "InDate", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_InDate1", OleDbType.DBTimeStamp, 8, ParameterDirection.Input, False, 0, 0, "InDate", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_TableName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "TableName", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_TableName1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "TableName", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New OleDbParameter("Original_UserID", OleDbType.VarChar, 8, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing))
            Me.OleDbInsertCommand1.CommandText = "INSERT INTO generalcomment(EntityID, CommentRef, Lang, Page, UserID, Description, Comment, InDate, TableName, FieldName, FieldID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?); SELECT EntityID, CommentRef, Lang, Page, UserID, Description, Comment, InDate, TableName, FieldName, FieldID FROM generalcomment WHERE (CommentRef = ?) AND (EntityID = ?) AND (Lang = ?) AND (Page = ?)"
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("EntityID", OleDbType.Integer, 4, "EntityID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("CommentRef", OleDbType.VarChar, 50, "CommentRef"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Page", OleDbType.Integer, 4, "Page"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("UserID", OleDbType.VarChar, 8, "UserID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 50, "Description"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Comment", OleDbType.VarChar, &H7FFFFFFF, "Comment"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("InDate", OleDbType.DBTimeStamp, 8, "InDate"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("TableName", OleDbType.VarChar, 50, "TableName"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("FieldName", OleDbType.VarChar, 50, "FieldName"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_CommentRef", OleDbType.VarChar, 50, "CommentRef"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_EntityID", OleDbType.Integer, 4, "EntityID"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbInsertCommand1.Parameters.Add(New OleDbParameter("Select_Page", OleDbType.Integer, 4, "Page"))
            Me.OleDbSelectCommand1.CommandText = "SELECT EntityID, CommentRef, Lang, Page, UserID, Description, Comment, InDate, TableName, FieldName, FieldID FROM generalcomment"
            Me.OleDbUpdateCommand1.CommandText = "UPDATE generalcomment SET EntityID = ?, CommentRef = ?, Lang = ?, Page = ?, UserID = ?, Description = ?, Comment = ?, InDate = ?, TableName = ?, FieldName = ?, FieldID = ? WHERE (CommentRef = ?) AND (EntityID = ?) AND (Lang = ?) AND (Page = ?) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (FieldID = ? OR ? IS NULL AND FieldID IS NULL) AND (FieldName = ? OR ? IS NULL AND FieldName IS NULL) AND (InDate = ? OR ? IS NULL AND InDate IS NULL) AND (TableName = ? OR ? IS NULL AND TableName IS NULL) AND (UserID = ?); SELECT EntityID, CommentRef, Lang, Page, UserID, Description, Comment, InDate, TableName, FieldName, FieldID FROM generalcomment WHERE (CommentRef = ?) AND (EntityID = ?) AND (Lang = ?) AND (Page = ?)"
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("EntityID", OleDbType.Integer, 4, "EntityID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("CommentRef", OleDbType.VarChar, 50, "CommentRef"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Page", OleDbType.Integer, 4, "Page"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("UserID", OleDbType.VarChar, 8, "UserID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 50, "Description"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Comment", OleDbType.VarChar, &H7FFFFFFF, "Comment"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("InDate", OleDbType.DBTimeStamp, 8, "InDate"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("TableName", OleDbType.VarChar, 50, "TableName"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("FieldName", OleDbType.VarChar, 50, "FieldName"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("FieldID", OleDbType.Integer, 4, "FieldID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_CommentRef", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "CommentRef", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_EntityID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "EntityID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Page", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "Page", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_FieldID", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FieldID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_FieldID1", OleDbType.Integer, 4, ParameterDirection.Input, False, 0, 0, "FieldID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_FieldName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_FieldName1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "FieldName", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_InDate", OleDbType.DBTimeStamp, 8, ParameterDirection.Input, False, 0, 0, "InDate", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_InDate1", OleDbType.DBTimeStamp, 8, ParameterDirection.Input, False, 0, 0, "InDate", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_TableName", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "TableName", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_TableName1", OleDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "TableName", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Original_UserID", OleDbType.VarChar, 8, ParameterDirection.Input, False, 0, 0, "UserID", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_CommentRef", OleDbType.VarChar, 50, "CommentRef"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_EntityID", OleDbType.Integer, 4, "EntityID"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbUpdateCommand1.Parameters.Add(New OleDbParameter("Select_Page", OleDbType.Integer, 4, "Page"))
            Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
            Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
            Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
            Me.OleDbDataAdapter2.TableMappings.AddRange(New DataTableMapping() { New DataTableMapping("Table", "systemlanguagecode", New DataColumnMapping() { New DataColumnMapping("Lang", "Lang"), New DataColumnMapping("Description", "Description") }) })
            Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
            Me.OleDbDeleteCommand2.CommandText = "DELETE FROM systemlanguagecode WHERE (Lang = ?) AND (Description = ? OR ? IS NULL AND Description IS NULL)"
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand2.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbInsertCommand2.CommandText = "INSERT INTO systemlanguagecode(Lang, Description) VALUES (?, ?); SELECT Lang, Description FROM systemlanguagecode WHERE (Lang = ?)"
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 100, "Description"))
            Me.OleDbInsertCommand2.Parameters.Add(New OleDbParameter("Select_Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbSelectCommand2.CommandText = "SELECT Lang, Description FROM systemlanguagecode"
            Me.OleDbUpdateCommand2.CommandText = "UPDATE systemlanguagecode SET Lang = ?, Description = ? WHERE (Lang = ?) AND (Description = ? OR ? IS NULL AND Description IS NULL); SELECT Lang, Description FROM systemlanguagecode WHERE (Lang = ?)"
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Lang", OleDbType.VarChar, 2, "Lang"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Description", OleDbType.VarChar, 100, "Description"))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_Lang", OleDbType.VarChar, 2, ParameterDirection.Input, False, 0, 0, "Lang", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_Description", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Original_Description1", OleDbType.VarChar, 100, ParameterDirection.Input, False, 0, 0, "Description", DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand2.Parameters.Add(New OleDbParameter("Select_Lang", OleDbType.VarChar, 2, "Lang"))
            Me.HelpProvider1.HelpNamespace = ".\Help\BizzKeys.chm"
            Me.RightMouseMenu.MenuItems.AddRange(New MenuItem() { Me.PopMenuNew, Me.PopMenuEdit, Me.PopMenuDelete, Me.PopMenuSave, Me.PopMenuUndo, Me.MenuItem5, Me.PopMenuPrintPreview, Me.MenuItem7, Me.PopMenuAssociatedTasks, Me.MenuItem9, Me.PopMenuUserTasks })
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
            Me.PopMenuUserTasks.Index = 10
            Me.PopMenuUserTasks.Text = "User Tasks"
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Size(&H248, &H1B6)
            Me.ClientSize = size
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.StatusBar1)
            Me.HelpProvider1.SetHelpKeyword(Me, "Comments")
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmSystemComment_Maintenance"
            Me.HelpProvider1.SetShowHelp(Me, True)
            Me.ShowInTaskbar = False
            Me.Text = "Comments Maintenance"
            Me.Controls.SetChildIndex(Me.StatusBar1, 0)
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.cmbDefaultListRepos.EndInit
            Me.cmbViewListRepos.EndInit
            Me.BarManager1.EndInit
            Me.txtQuickSearchRepos.EndInit
            Me.cmbFilterListRepos.EndInit
            Me.cmbReportListRepos.EndInit
            Me.objDs.EndInit
            Me.StatusBarPanel1.EndInit
            Me.StatusBarPanel2.EndInit
            Me.Panel1.ResumeLayout(False)
            Me.editInDate1.get_Properties.EndInit
            Me.MemoEditComment.get_Properties.EndInit
            Me.LookUpLang.get_Properties.EndInit
            Me.objdsGeneral.EndInit
            Me.spinPage.get_Properties.EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadDataSet()
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim dataSet As New dsGeneral
            Try 
                If Me.DataTableLinked Then
                    Dim selectCommand As OleDbCommand = Me.OleDbDataAdapter1.SelectCommand
                    selectCommand.CommandText = String.Concat(New String() { selectCommand.CommandText, " WHERE FieldName = '", Me.CommentFieldName, "' AND TableName = '", Me.CommentTableName, "' AND FieldID = ", Conversions.ToString(Me.CommentFieldID) })
                End If
                ClsDs.FillDataSet(dataSet.Tables.Item(Me.TableName), Me.OleDbDataAdapter1, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError()
            End Try
            Try
                ClsDs.FillDataSet(Me.objdsGeneral.Tables.Item("systemlanguagecode"), Me.OleDbDataAdapter2, True)
                Me.objDs.Clear()
                Me.objDs.Merge(dataSet)
                If (Me.CommentTableName = "") Then
                    Me.objDs.Tables.Item(Me.TableName).Columns.Item("Page").DefaultValue = 1
                Else
                    Me.objDs.Tables.Item(Me.TableName).Columns.Item("Page").DefaultValue = (Me.objDs.Tables.Item(Me.TableName).Rows.Count + 1)
                End If
                Me.objDs.Tables.Item(Me.TableName).Columns.Item("Lang").DefaultValue = Me.SessionInfo.UserLang
                Me.objDs.Tables.Item(Me.TableName).Columns.Item("InDate").DefaultValue = DateAndTime.Today
                Me.objDs.Tables.Item(Me.TableName).Columns.Item("UserID").DefaultValue = Me.SessionInfo.UserID
                Me.objDs.Tables.Item(Me.TableName).Columns.Item("EntityID").DefaultValue = Me.SessionInfo.EntityID
                Me.objDs.Tables.Item(Me.TableName).Columns.Item("TableName").DefaultValue = Me.CommentTableName
                Me.objDs.Tables.Item(Me.TableName).Columns.Item("FieldName").DefaultValue = Me.CommentFieldName
                Me.objDs.Tables.Item(Me.TableName).Columns.Item("FieldID").DefaultValue = Me.CommentFieldID
                Me.objDs.Tables.Item(Me.TableName).Columns.Item("CommentRef").DefaultValue = Me.CommentRef
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Sub MenuLanguages_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim maintenance As New frmgeneraldesctranslation_Maintenance(Me.SessionInfo)
            maintenance.FieldKey = Me.editCommentRef.Text
            maintenance.Field = "generalcomment.CommandRef"
            maintenance.ShowDialog(Me)
        End Sub

        Private Sub NewRecord()
            Me.btnNew.set_Enabled(False)
            Me.btnEdit.set_Enabled(False)
            Me.btnSave.set_Enabled(True)
            Me.btnDelete.set_Enabled(False)
            Me.btnUndo.set_Enabled(True)
            Me.PopMenuNew.Enabled = False
            Me.PopMenuEdit.Enabled = False
            Me.PopMenuSave.Enabled = True
            Me.PopMenuDelete.Enabled = False
            Me.PopMenuUndo.Enabled = True
            Me.EnablingAll(True)
            Me.EnablingNavButton(False)
            Me.OpenType = "NEW"
            Try
                Me.BindingContext.Item(Me.objDs, Me.TableName).EndCurrentEdit()
                Me.BindingContext.Item(Me.objDs, Me.TableName).AddNew()
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError()
            End Try
            Me.PositionChanged()
        End Sub

        Private Sub PopMenuDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DeleteRecord()
        End Sub

        Private Sub PopMenuEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.EditRecord()
        End Sub

        Private Sub PopMenuNew_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.NewRecord()
        End Sub

        Private Sub PopMenuSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SaveChanges()
        End Sub

        Private Sub PopMenuUndo_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.UndoChanges()
        End Sub

        Private Sub PositionChanged()
            Me.StatusBar1.Panels.Item(0).Text = ((Me.BindingContext.Item(Me.objDs, Me.TableName).Position + 1).ToString & " /  " & Me.BindingContext.Item(Me.objDs, Me.TableName).Count.ToString)
            If ((Me.objDs.Tables.Item(Me.TableName).Rows.Count > 0) And (Me.BindingContext.Item(Me.objDs, Me.TableName).Position < Me.objDs.Tables.Item(Me.TableName).Rows.Count)) Then
                If Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject(Me.objDs.Tables.Item(Me.TableName).Rows.Item(Me.BindingContext.Item(Me.objDs, Me.TableName).Position).Item("TableName"), ""), "", False) Then
                    Me.StatusBar1.Panels.Item(1).Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("*** ", Me.objDs.Tables.Item(Me.TableName).Rows.Item(Me.BindingContext.Item(Me.objDs, Me.TableName).Position).Item("TableName")), " ***"))
                Else
                    Me.StatusBar1.Panels.Item(1).Text = ""
                End If
            Else
                Me.StatusBar1.Panels.Item(1).Text = ""
            End If
        End Sub

        Private Sub SaveChanges()
            Me.btnNew.set_Enabled(True)
            Me.btnEdit.set_Enabled(True)
            Me.btnSave.set_Enabled(False)
            Me.btnDelete.set_Enabled(True)
            Me.btnUndo.set_Enabled(False)
            Me.PopMenuNew.Enabled = True
            Me.PopMenuEdit.Enabled = True
            Me.PopMenuSave.Enabled = False
            Me.PopMenuDelete.Enabled = True
            Me.PopMenuUndo.Enabled = False
            Me.EnablingAll(False)
            Me.EnablingNavButton(True)
            Me.OpenType = "BROWSE"
            Try
                Me.UpdateDataSet()
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError()
            End Try
            Me.PositionChanged()
        End Sub

        Private Sub ShortCutPressed(ByVal sender As Object, ByVal e As KeyEventArgs)
            If ((e.KeyCode = Me.SessionInfo.ShortCut.DeleteKey) And (e.Modifiers = Me.SessionInfo.ShortCut.DeleteModifier)) Then
                Me.DeleteRecord()
            End If
            If ((e.KeyCode = Me.SessionInfo.ShortCut.AddKey) And (e.Modifiers = Me.SessionInfo.ShortCut.AddModifier)) Then
                Me.NewRecord()
            End If
            If ((e.KeyCode = Me.SessionInfo.ShortCut.EditKey) And (e.Modifiers = Me.SessionInfo.ShortCut.EditModifier)) Then
                Me.EditRecord()
            End If
            If ((e.KeyCode = Me.SessionInfo.ShortCut.SaveKey) And (e.Modifiers = Me.SessionInfo.ShortCut.SaveModifier)) Then
                Me.SaveChanges()
            End If
            If ((e.KeyCode = Me.SessionInfo.ShortCut.UndoKey) And (e.Modifiers = Me.SessionInfo.ShortCut.UndoModifier)) Then
                If (Me.OpenType <> "BROWSE") Then
                    Me.UndoChanges()
                Else
                    Me.Close()
                End If
            End If
        End Sub

        Private Sub UndoChanges()
            Me.btnNew.set_Enabled(True)
            Me.btnEdit.set_Enabled(True)
            Me.btnSave.set_Enabled(False)
            Me.btnDelete.set_Enabled(True)
            Me.btnUndo.set_Enabled(False)
            Me.PopMenuNew.Enabled = True
            Me.PopMenuEdit.Enabled = True
            Me.PopMenuSave.Enabled = False
            Me.PopMenuDelete.Enabled = True
            Me.PopMenuUndo.Enabled = False
            Me.EnablingAll(False)
            Me.EnablingNavButton(True)
            Me.BindingContext.Item(Me.objDs, Me.TableName).CancelCurrentEdit()
            Me.PositionChanged()
            Me.OpenType = "BROWSE"
        End Sub

        Public Sub UpdateDataSet()
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim dataSet As New dsGeneral
            Me.BindingContext.Item(Me.objDs, Me.TableName).EndCurrentEdit()
            dataSet = DirectCast(Me.objDs.GetChanges, dsGeneral)
            If (Not dataSet Is Nothing) Then
                Try
                    ClsDs.UpdateDataSource(dataSet.Tables.Item(Me.TableName), Me.OleDbDataAdapter1, True)
                    Me.objDs.Merge(dataSet)
                    Me.objDs.AcceptChanges()
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Me.objDs.RejectChanges()
                    Throw exception
                    ProjectData.ClearProjectError()
                End Try
            End If
        End Sub

        Private Function ValidateBeforeDelete() As Boolean
            Return True
        End Function


        ' Properties
        Public Overrides Property btnDelete As BarButtonItem
            Get
                Return MyBase.btnDelete
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnDelete Is Nothing) Then
                    MyBase.btnDelete.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDelete_ItemClick, IntPtr)))
                End If
                MyBase.btnDelete = WithEventsValue
                If (Not MyBase.btnDelete Is Nothing) Then
                    MyBase.btnDelete.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnDelete_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overrides Property btnEdit As BarButtonItem
            Get
                Return MyBase.btnEdit
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnEdit Is Nothing) Then
                    MyBase.btnEdit.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEdit_ItemClick, IntPtr)))
                End If
                MyBase.btnEdit = WithEventsValue
                If (Not MyBase.btnEdit Is Nothing) Then
                    MyBase.btnEdit.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnEdit_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overrides Property btnFirst As BarButtonItem
            Get
                Return MyBase.btnFirst
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnFirst Is Nothing) Then
                    MyBase.btnFirst.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFirst_ItemClick, IntPtr)))
                End If
                MyBase.btnFirst = WithEventsValue
                If (Not MyBase.btnFirst Is Nothing) Then
                    MyBase.btnFirst.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnFirst_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overrides Property btnLast As BarButtonItem
            Get
                Return MyBase.btnLast
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnLast Is Nothing) Then
                    MyBase.btnLast.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnLast_ItemClick, IntPtr)))
                End If
                MyBase.btnLast = WithEventsValue
                If (Not MyBase.btnLast Is Nothing) Then
                    MyBase.btnLast.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnLast_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overrides Property btnNew As BarButtonItem
            Get
                Return MyBase.btnNew
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnNew Is Nothing) Then
                    MyBase.btnNew.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNew_ItemClick, IntPtr)))
                End If
                MyBase.btnNew = WithEventsValue
                If (Not MyBase.btnNew Is Nothing) Then
                    MyBase.btnNew.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNew_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overrides Property btnNext As BarButtonItem
            Get
                Return MyBase.btnNext
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnNext Is Nothing) Then
                    MyBase.btnNext.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNext_ItemClick, IntPtr)))
                End If
                MyBase.btnNext = WithEventsValue
                If (Not MyBase.btnNext Is Nothing) Then
                    MyBase.btnNext.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnNext_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overrides Property btnPrevious As BarButtonItem
            Get
                Return MyBase.btnPrevious
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnPrevious Is Nothing) Then
                    MyBase.btnPrevious.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrevious_ItemClick, IntPtr)))
                End If
                MyBase.btnPrevious = WithEventsValue
                If (Not MyBase.btnPrevious Is Nothing) Then
                    MyBase.btnPrevious.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnPrevious_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overrides Property btnSave As BarButtonItem
            Get
                Return MyBase.btnSave
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnSave Is Nothing) Then
                    MyBase.btnSave.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSave_ItemClick, IntPtr)))
                End If
                MyBase.btnSave = WithEventsValue
                If (Not MyBase.btnSave Is Nothing) Then
                    MyBase.btnSave.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnSave_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Public Overrides Property btnUndo As BarButtonItem
            Get
                Return MyBase.btnUndo
            End Get
            Set(ByVal WithEventsValue As BarButtonItem)
                If (Not MyBase.btnUndo Is Nothing) Then
                    MyBase.btnUndo.remove_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnUndo_ItemClick, IntPtr)))
                End If
                MyBase.btnUndo = WithEventsValue
                If (Not MyBase.btnUndo Is Nothing) Then
                    MyBase.btnUndo.add_ItemClick(New ItemClickEventHandler(Me, DirectCast(Me.btnUndo_ItemClick, IntPtr)))
                End If
            End Set
        End Property

        Friend Overridable Property editCommentRef As TextBox
            Get
                Return Me._editCommentRef
            End Get
            Set(ByVal WithEventsValue As TextBox)
                If (Not Me._editCommentRef Is Nothing) Then
                    RemoveHandler Me._editCommentRef.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
                Me._editCommentRef = WithEventsValue
                If (Not Me._editCommentRef Is Nothing) Then
                    AddHandler Me._editCommentRef.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
            End Set
        End Property

        Friend Overridable Property editDescription As TextBox
            Get
                Return Me._editDescription
            End Get
            Set(ByVal WithEventsValue As TextBox)
                If (Not Me._editDescription Is Nothing) Then
                    RemoveHandler Me._editDescription.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
                Me._editDescription = WithEventsValue
                If (Not Me._editDescription Is Nothing) Then
                    AddHandler Me._editDescription.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
            End Set
        End Property

        Friend Overridable Property editInDate1 As DateEdit
            Get
                Return Me._editInDate1
            End Get
            Set(ByVal WithEventsValue As DateEdit)
                If (Not Me._editInDate1 Is Nothing) Then
                    RemoveHandler Me._editInDate1.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
                Me._editInDate1 = WithEventsValue
                If (Not Me._editInDate1 Is Nothing) Then
                    AddHandler Me._editInDate1.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
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

        Friend Overridable Property lblDate As Label
            Get
                Return Me._lblDate
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblDate = WithEventsValue
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

        Friend Overridable Property lblLanguage As Label
            Get
                Return Me._lblLanguage
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblLanguage = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblPage As Label
            Get
                Return Me._lblPage
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblPage = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblReference As Label
            Get
                Return Me._lblReference
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblReference = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LookUpLang As LookUpEdit
            Get
                Return Me._LookUpLang
            End Get
            Set(ByVal WithEventsValue As LookUpEdit)
                If (Not Me._LookUpLang Is Nothing) Then
                    RemoveHandler Me._LookUpLang.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
                Me._LookUpLang = WithEventsValue
                If (Not Me._LookUpLang Is Nothing) Then
                    AddHandler Me._LookUpLang.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
            End Set
        End Property

        Friend Overridable Property MemoEditComment As MemoEdit
            Get
                Return Me._MemoEditComment
            End Get
            Set(ByVal WithEventsValue As MemoEdit)
                If (Not Me._MemoEditComment Is Nothing) Then
                    RemoveHandler Me._MemoEditComment.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
                Me._MemoEditComment = WithEventsValue
                If (Not Me._MemoEditComment Is Nothing) Then
                    AddHandler Me._MemoEditComment.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
            End Set
        End Property

        Friend Overridable Property MenuAttachements As MenuItem
            Get
                Return Me._MenuAttachements
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                Me._MenuAttachements = WithEventsValue
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

        Friend Overridable Property MenuLanguages As MenuItem
            Get
                Return Me._MenuLanguages
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not Me._MenuLanguages Is Nothing) Then
                    RemoveHandler Me._MenuLanguages.Click, New EventHandler(AddressOf Me.MenuLanguages_Click)
                End If
                Me._MenuLanguages = WithEventsValue
                If (Not Me._MenuLanguages Is Nothing) Then
                    AddHandler Me._MenuLanguages.Click, New EventHandler(AddressOf Me.MenuLanguages_Click)
                End If
            End Set
        End Property

        Friend Overridable Property objDs As dsGeneral
            Get
                Return Me._objDs
            End Get
            Set(ByVal WithEventsValue As dsGeneral)
                Me._objDs = WithEventsValue
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
                If (Not Me._PopMenuDelete Is Nothing) Then
                    RemoveHandler Me._PopMenuDelete.Click, New EventHandler(AddressOf Me.PopMenuDelete_Click)
                End If
                Me._PopMenuDelete = WithEventsValue
                If (Not Me._PopMenuDelete Is Nothing) Then
                    AddHandler Me._PopMenuDelete.Click, New EventHandler(AddressOf Me.PopMenuDelete_Click)
                End If
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
                If (Not Me._PopMenuNew Is Nothing) Then
                    RemoveHandler Me._PopMenuNew.Click, New EventHandler(AddressOf Me.PopMenuEdit_Click)
                    RemoveHandler Me._PopMenuNew.Click, New EventHandler(AddressOf Me.PopMenuNew_Click)
                End If
                Me._PopMenuNew = WithEventsValue
                If (Not Me._PopMenuNew Is Nothing) Then
                    AddHandler Me._PopMenuNew.Click, New EventHandler(AddressOf Me.PopMenuEdit_Click)
                    AddHandler Me._PopMenuNew.Click, New EventHandler(AddressOf Me.PopMenuNew_Click)
                End If
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
                If (Not Me._PopMenuSave Is Nothing) Then
                    RemoveHandler Me._PopMenuSave.Click, New EventHandler(AddressOf Me.PopMenuSave_Click)
                End If
                Me._PopMenuSave = WithEventsValue
                If (Not Me._PopMenuSave Is Nothing) Then
                    AddHandler Me._PopMenuSave.Click, New EventHandler(AddressOf Me.PopMenuSave_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PopMenuUndo As MenuItem
            Get
                Return Me._PopMenuUndo
            End Get
            Set(ByVal WithEventsValue As MenuItem)
                If (Not Me._PopMenuUndo Is Nothing) Then
                    RemoveHandler Me._PopMenuUndo.Click, New EventHandler(AddressOf Me.PopMenuUndo_Click)
                End If
                Me._PopMenuUndo = WithEventsValue
                If (Not Me._PopMenuUndo Is Nothing) Then
                    AddHandler Me._PopMenuUndo.Click, New EventHandler(AddressOf Me.PopMenuUndo_Click)
                End If
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

        Friend Overridable Property RightMouseMenu As ContextMenu
            Get
                Return Me._RightMouseMenu
            End Get
            Set(ByVal WithEventsValue As ContextMenu)
                Me._RightMouseMenu = WithEventsValue
            End Set
        End Property

        Friend Overridable Property spinPage As SpinEdit
            Get
                Return Me._spinPage
            End Get
            Set(ByVal WithEventsValue As SpinEdit)
                If (Not Me._spinPage Is Nothing) Then
                    RemoveHandler Me._spinPage.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
                Me._spinPage = WithEventsValue
                If (Not Me._spinPage Is Nothing) Then
                    AddHandler Me._spinPage.KeyDown, New KeyEventHandler(AddressOf Me.ShortCutPressed)
                End If
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

        Friend Overridable Property ToolBarContextMenu As ContextMenu
            Get
                Return Me._ToolBarContextMenu
            End Get
            Set(ByVal WithEventsValue As ContextMenu)
                Me._ToolBarContextMenu = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("editCommentRef")> _
        Private _editCommentRef As TextBox
        <AccessedThroughProperty("editDescription")> _
        Private _editDescription As TextBox
        <AccessedThroughProperty("editInDate1")> _
        Private _editInDate1 As DateEdit
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider
        <AccessedThroughProperty("lblDate")> _
        Private _lblDate As Label
        <AccessedThroughProperty("lblDescription")> _
        Private _lblDescription As Label
        <AccessedThroughProperty("lblLanguage")> _
        Private _lblLanguage As Label
        <AccessedThroughProperty("lblPage")> _
        Private _lblPage As Label
        <AccessedThroughProperty("lblReference")> _
        Private _lblReference As Label
        <AccessedThroughProperty("LookUpLang")> _
        Private _LookUpLang As LookUpEdit
        <AccessedThroughProperty("MemoEditComment")> _
        Private _MemoEditComment As MemoEdit
        <AccessedThroughProperty("MenuAttachements")> _
        Private _MenuAttachements As MenuItem
        <AccessedThroughProperty("MenuItem5")> _
        Private _MenuItem5 As MenuItem
        <AccessedThroughProperty("MenuItem7")> _
        Private _MenuItem7 As MenuItem
        <AccessedThroughProperty("MenuItem9")> _
        Private _MenuItem9 As MenuItem
        <AccessedThroughProperty("MenuLanguages")> _
        Private _MenuLanguages As MenuItem
        <AccessedThroughProperty("objDs")> _
        Private _objDs As dsGeneral
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
        <AccessedThroughProperty("PopMenuUserTasks")> _
        Private _PopMenuUserTasks As MenuItem
        <AccessedThroughProperty("RightMouseMenu")> _
        Private _RightMouseMenu As ContextMenu
        <AccessedThroughProperty("spinPage")> _
        Private _spinPage As SpinEdit
        <AccessedThroughProperty("StatusBar1")> _
        Private _StatusBar1 As StatusBar
        <AccessedThroughProperty("StatusBarPanel1")> _
        Private _StatusBarPanel1 As StatusBarPanel
        <AccessedThroughProperty("StatusBarPanel2")> _
        Private _StatusBarPanel2 As StatusBarPanel
        <AccessedThroughProperty("ToolBarContextMenu")> _
        Private _ToolBarContextMenu As ContextMenu
        Public CommentFieldID As Integer
        Public CommentFieldName As String
        Public CommentRef As String
        Public CommentTableName As String
        Private components As IContainer
        Private DataTableLinked As Boolean
        Public OpenType As String
        Private TableName As String
    End Class
End Namespace

