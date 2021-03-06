﻿Imports DevExpress.XtraEditors
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
    Public Class frmDialogSelectUser
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmDialogSelectUser.__ENCList
            SyncLock list
                frmDialogSelectUser.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frm_Load)
            AddHandler MyBase.Closing, New CancelEventHandler(AddressOf Me.frm_Closing)
            Dim list As ArrayList = frmDialogSelectUser.__ENCList
            SyncLock list
                frmDialogSelectUser.__ENCList.Add(New WeakReference(Me))
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
            Me.HelpProvider1.HelpNamespace = (Me.SessionInfo.ApplDir & "\Help\BizzKeys.chm")
            MyBase.Cls1.FillDataSet(Me.objDS.Tables.Item("securityuser"), "SELECT * FROM securityuser WHERE UserID <> 0 ", True, False)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ResourceManager(GetType(frmDialogSelectUser))
            Me.HelpProvider1 = New HelpProvider
            Me.ToolTip1 = New ToolTip(Me.components)
            Me.StatusBar1 = New StatusBar
            Me.StatusBarPanel1 = New StatusBarPanel
            Me.StatusBarPanel2 = New StatusBarPanel
            Me.lblName = New Label
            Me.btnOK1 = New SimpleButton
            Me.btnCancel = New SimpleButton
            Me.cmbUsers = New LookUpEdit
            Me.objDS = New dsSecurity
            Me.StatusBarPanel1.BeginInit
            Me.StatusBarPanel2.BeginInit
            Me.cmbUsers.get_Properties.BeginInit
            Me.objDS.BeginInit
            Me.SuspendLayout
            Dim point As New Point(0, 80)
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
            point = New Point(8, &H10)
            Me.lblName.Location = point
            Me.lblName.Name = "lblName"
            size = New Size(80, &H17)
            Me.lblName.Size = size
            Me.lblName.TabIndex = 3
            Me.lblName.Text = "User Name"
            point = New Point(&H108, &H30)
            Me.btnOK1.Location = point
            Me.btnOK1.Name = "btnOK1"
            Me.btnOK1.TabIndex = &H22
            Me.btnOK1.set_Text("OK")
            Me.btnCancel.set_DialogResult(DialogResult.Cancel)
            point = New Point(&H158, &H30)
            Me.btnCancel.Location = point
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.TabIndex = &H23
            Me.btnCancel.set_Text("Cancel")
            point = New Point(&H58, &H10)
            Me.cmbUsers.Location = point
            Me.cmbUsers.Name = "cmbUsers"
            Me.cmbUsers.get_Properties.get_Buttons.AddRange(New EditorButton() { New EditorButton(-5) })
            Me.cmbUsers.get_Properties.get_Columns.AddRange(New LookUpColumnInfo() { New LookUpColumnInfo("FullName", "FullName", &H3A, 0, "", True, 1) })
            Me.cmbUsers.get_Properties.set_DataSource(Me.objDS.securityuser)
            Me.cmbUsers.get_Properties.set_DisplayMember("FullName")
            Me.cmbUsers.get_Properties.set_NullText("")
            Me.cmbUsers.get_Properties.set_ValueMember("UserID")
            size = New Size(&H148, 20)
            Me.cmbUsers.Size = size
            Me.cmbUsers.TabIndex = &H24
            Me.objDS.DataSetName = "dsSecurity"
            Me.objDS.Locale = New CultureInfo("en-US")
            Me.AcceptButton = Me.btnOK1
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            Me.CancelButton = Me.btnCancel
            size = New Size(&H1A8, &H66)
            Me.ClientSize = size
            Me.Controls.Add(Me.cmbUsers)
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
            Me.Name = "frmDialogSelectUser"
            Me.HelpProvider1.SetShowHelp(Me, True)
            Me.ShowInTaskbar = False
            Me.Text = "Please select a user."
            Me.StatusBarPanel1.EndInit
            Me.StatusBarPanel2.EndInit
            Me.cmbUsers.get_Properties.EndInit
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

        Friend Overridable Property cmbUsers As LookUpEdit
            Get
                Return Me._cmbUsers
            End Get
            Set(ByVal WithEventsValue As LookUpEdit)
                Me._cmbUsers = WithEventsValue
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

        Friend Overridable Property objDS As dsSecurity
            Get
                Return Me._objDS
            End Get
            Set(ByVal WithEventsValue As dsSecurity)
                Me._objDS = WithEventsValue
            End Set
        End Property

        Public Property SelectedUserID As String
            Get
                Return Conversions.ToString(Me.cmbUsers.get_EditValue)
            End Get
            Set(ByVal Value As String)
                Me.cmbUsers.set_EditValue(Value)
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
        <AccessedThroughProperty("cmbUsers")> _
        Private _cmbUsers As LookUpEdit
        <AccessedThroughProperty("HelpProvider1")> _
        Private _HelpProvider1 As HelpProvider
        <AccessedThroughProperty("lblName")> _
        Private _lblName As Label
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

