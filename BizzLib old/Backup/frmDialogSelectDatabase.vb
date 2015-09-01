Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmDialogSelectDatabase
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmDialogSelectDatabase.__ENCList
            SyncLock list
                frmDialogSelectDatabase.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmDialogSelectDatabase.__ENCList
            SyncLock list
                frmDialogSelectDatabase.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DialogResult = DialogResult.Cancel
            Me.Hide
        End Sub

        Private Sub btnOK1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DialogResult = DialogResult.OK
            Me.Hide
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
        End Sub

        Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.Cls1.FillDataSet(Me.objDS.Tables.Item("systemdatabase"), "SELECT * FROM systemdatabase ", True, False)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ResourceManager(GetType(frmDialogSelectDatabase))
            Me.HelpProvider1 = New HelpProvider
            Me.ToolTip1 = New ToolTip(Me.components)
            Me.StatusBar1 = New StatusBar
            Me.StatusBarPanel1 = New StatusBarPanel
            Me.StatusBarPanel2 = New StatusBarPanel
            Me.lblName = New Label
            Me.btnOK1 = New SimpleButton
            Me.btnCancel = New SimpleButton
            Me.cmbDatabases = New LookUpEdit
            Me.objDS = New dsSecurity
            Me.lblWarning = New Label
            Me.StatusBarPanel1.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.cmbDatabases.get_Properties.BeginInit
            Me.objDS.BeginInit
            Me.SuspendLayout
            Dim point As New Point(0, &H80)
            Me.StatusBar1.Location = point
            Me.StatusBar1.Name = "StatusBar1"
            Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel1, Me.StatusBarPanel2 })
            Me.StatusBar1.ShowPanels = True
            Dim size As New Size(&H1A8, &H16)
            Me.StatusBar1.Size = size
            Me.StatusBar1.TabIndex = &H21
            Me.StatusBarPanel1.AutoSize = StatusBarPanelAutoSize.Spring
            Me.StatusBarPanel1.Width = &H17A
            Me.StatusBarPanel2.ToolTipText = "Filter Notification"
            Me.StatusBarPanel2.Width = 30
            point = New Point(8, &H38)
            Me.lblName.Location = point
            Me.lblName.Name = "lblName"
            size = New Size(80, &H17)
            Me.lblName.Size = size
            Me.lblName.TabIndex = 3
            Me.lblName.Text = "Database"
            point = New Point(&H108, &H58)
            Me.btnOK1.Location = point
            Me.btnOK1.Name = "btnOK1"
            Me.btnOK1.TabIndex = &H22
            Me.btnOK1.set_Text("OK")
            Me.btnCancel.set_DialogResult(DialogResult.Cancel)
            point = New Point(&H158, &H58)
            Me.btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = &H23
            Me.btnCancel.set_Text("Cancel")
            point = New Point(&H58, &H38)
            Me.cmbDatabases.Location = point
            Me.cmbDatabases.Name = "cmbDatabases"
            Me.cmbDatabases.get_Properties.get_Buttons.AddRange(New EditorButton() { New EditorButton(-5) })
            Me.cmbDatabases.get_Properties.get_Columns.AddRange(New LookUpColumnInfo() { New LookUpColumnInfo("DBName", "DBName", 70, 0, "", True, 1), New LookUpColumnInfo("Description", "Description", 130, 0, "", True, 1) })
            Me.cmbDatabases.get_Properties.set_DataSource(Me.objDS.systemdatabase)
            Me.cmbDatabases.get_Properties.set_DisplayMember("DBName")
            Me.cmbDatabases.get_Properties.set_NullText("")
            Me.cmbDatabases.get_Properties.set_ValueMember("DBName")
            size = New Size(&H148, 20)
            Me.cmbDatabases.Size = size
            Me.cmbDatabases.TabIndex = &H24
            Me.objDS.DataSetName = "dsSecurity"
            Me.objDS.Locale = New CultureInfo("en-US")
            point = New Point(8, 8)
            Me.lblWarning.Location = point
            Me.lblWarning.Name = "lblWarning"
            size = New Size(&H198, &H20)
            Me.lblWarning.Size = size
            Me.lblWarning.TabIndex = &H25
            Me.lblWarning.Text = "WARNING : Changing Database will close all windows. You will have to log in again."
            Me.AcceptButton = Me.btnOK1
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Size(&H1A8, 150)
            Me.ClientSize = size
            Me.Controls.Add(Me.lblWarning)
            Me.Controls.Add(Me.cmbDatabases)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK1)
            Me.Controls.Add(Me.StatusBar1)
            Me.Controls.Add(Me.lblName)
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
            Me.HelpButton = True
            Me.HelpProvider1.SetHelpKeyword(Me, "Filter")
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmDialogSelectDatabase"
            Me.HelpProvider1.SetShowHelp(Me, True)
            Me.ShowInTaskbar = False
            Me.Text = "Please select a database"
            Me.StatusBarPanel1.EndInit
            Me.StatusBarPanel2.EndInit
            Me.cmbDatabases.get_Properties.EndInit
            Me.objDS.EndInit
            Me.ResumeLayout(False)
        End Sub


        ' Properties
        Friend Overridable Property btnCancel As SimpleButton
            Get
                Return Me._btnCancel
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnCancel Is Nothing) Then
                    RemoveHandler Me._btnCancel.Click, New EventHandler(AddressOf Me.btnCancel_Click)
                End If
                Me._btnCancel = WithEventsValue
                If (Not Me._btnCancel Is Nothing) Then
                    AddHandler Me._btnCancel.Click, New EventHandler(AddressOf Me.btnCancel_Click)
                End If
            End Set
        End Property

        Friend Overridable Property btnOK1 As SimpleButton
            Get
                Return Me._btnOK1
            End Get
            Set(ByVal WithEventsValue As SimpleButton)
                If (Not Me._btnOK1 Is Nothing) Then
                    RemoveHandler Me._btnOK1.Click, New EventHandler(AddressOf Me.btnOK1_Click)
                End If
                Me._btnOK1 = WithEventsValue
                If (Not Me._btnOK1 Is Nothing) Then
                    AddHandler Me._btnOK1.Click, New EventHandler(AddressOf Me.btnOK1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmbDatabases As LookUpEdit
            Get
                Return Me._cmbDatabases
            End Get
            Set(ByVal WithEventsValue As LookUpEdit)
                Me._cmbDatabases = WithEventsValue
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

        Friend Overridable Property lblName As Label
            Get
                Return Me._lblName
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblWarning As Label
            Get
                Return Me._lblWarning
            End Get
            Set(ByVal WithEventsValue As Label)
                Me._lblWarning = WithEventsValue
            End Set
        End Property

        Friend Overridable Property objDS As dsSecurity
            Get
                Return Me._objDS
            End Get
            Set(ByVal WithEventsValue As dsSecurity)
                Me._objDS = WithEventsValue
            End Set
        End Property

        Public Property SelectedDBName As String
            Get
                Return Conversions.ToString(Me.cmbDatabases.get_EditValue)
            End Get
            Set(ByVal Value As String)
                Me.cmbDatabases.set_EditValue(Value)
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

        Friend Overridable Property ToolTip1 As ToolTip
            Get
                Return Me._ToolTip1
            End Get
            Set(ByVal WithEventsValue As ToolTip)
                Me._ToolTip1 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("btnCancel")> _
        Private _btnCancel As SimpleButton
        <AccessedThroughProperty("btnOK1")> _
        Private _btnOK1 As SimpleButton
        <AccessedThroughProperty("cmbDatabases")> _
        Private _cmbDatabases As LookUpEdit
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider
        <AccessedThroughProperty("lblName")> _
        Private _lblName As Label
        <AccessedThroughProperty("lblWarning")> _
        Private _lblWarning As Label
        <AccessedThroughProperty("objDS")> _
        Private _objDS As dsSecurity
        <AccessedThroughProperty("StatusBar1")> _
        Private _StatusBar1 As StatusBar
        <AccessedThroughProperty("StatusBarPanel1")> _
        Private _StatusBarPanel1 As StatusBarPanel
        <AccessedThroughProperty("StatusBarPanel2")> _
        Private _StatusBarPanel2 As StatusBarPanel
        <AccessedThroughProperty("ToolTip1")> _
        Private _ToolTip1 As ToolTip
        Private components As IContainer
    End Class
End Namespace

