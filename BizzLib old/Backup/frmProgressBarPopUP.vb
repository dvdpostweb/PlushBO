Imports DevExpress.XtraEditors
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmProgressBarPopUP
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            Dim list As ArrayList = frmProgressBarPopUP.__ENCList
            SyncLock list
                frmProgressBarPopUP.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            MyBase.New(CurrentSessionInfo)
            Dim list As ArrayList = frmProgressBarPopUP.__ENCList
            SyncLock list
                frmProgressBarPopUP.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Private Sub btnOK1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ResourceManager(GetType(frmProgressBarPopUP))
            Me.MemoEdit1 = New MemoEdit
            Me.ProgressBar1 = New ProgressBarControl
            Me.btnOK1 = New SimpleButton
            Me.MemoEdit1.get_Properties.BeginInit
            Me.ProgressBar1.get_Properties.BeginInit
            Me.SuspendLayout
            Me.MemoEdit1.set_EditValue("")
            Dim point As New Point(8, &H20)
            Me.MemoEdit1.Location = point
            Me.MemoEdit1.Name = "MemoEdit1"
            Me.MemoEdit1.get_Properties.set_ReadOnly(True)
            Dim size As New Size(&H138, &H60)
            Me.MemoEdit1.Size = size
            Me.MemoEdit1.TabIndex = 3
            point = New Point(8, 8)
            Me.ProgressBar1.Location = point
            Me.ProgressBar1.Name = "ProgressBar1"
            size = New Size(&H138, &H10)
            Me.ProgressBar1.Size = size
            Me.ProgressBar1.TabIndex = 2
            Me.ProgressBar1.set_TabStop(False)
            point = New Point(240, &H88)
            Me.btnOK1.Location = point
            Me.btnOK1.Name = "btnOK1"
            size = New Size(80, &H18)
            Me.btnOK1.Size = size
            Me.btnOK1.TabIndex = 4
            Me.btnOK1.set_Text("&Ok")
            Me.AcceptButton = Me.btnOK1
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Size(&H148, &HA8)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.btnOK1)
            Me.Controls.Add(Me.MemoEdit1)
            Me.Controls.Add(Me.ProgressBar1)
            Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmProgressBarPopUP"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Progress Information"
            Me.MemoEdit1.get_Properties.EndInit
            Me.ProgressBar1.get_Properties.EndInit
            Me.ResumeLayout(False)
        End Sub

        Private Sub MemoEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub


        ' Properties
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

        Public Overridable Property MemoEdit1 As MemoEdit
            Get
                Return Me._MemoEdit1
            End Get
            Set(ByVal WithEventsValue As MemoEdit)
                If (Not Me._MemoEdit1 Is Nothing) Then
                    Me._MemoEdit1.remove_EditValueChanged(New EventHandler(AddressOf Me.MemoEdit1_EditValueChanged))
                End If
                Me._MemoEdit1 = WithEventsValue
                If (Not Me._MemoEdit1 Is Nothing) Then
                    Me._MemoEdit1.add_EditValueChanged(New EventHandler(AddressOf Me.MemoEdit1_EditValueChanged))
                End If
            End Set
        End Property

        Public Overridable Property ProgressBar1 As ProgressBarControl
            Get
                Return Me._ProgressBar1
            End Get
            Set(ByVal WithEventsValue As ProgressBarControl)
                Me._ProgressBar1 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("btnOK1")> _
        Private _btnOK1 As SimpleButton
        <AccessedThroughProperty("MemoEdit1")> _
        Private _MemoEdit1 As MemoEdit
        <AccessedThroughProperty("ProgressBar1")> _
        Private _ProgressBar1 As ProgressBarControl
        Private components As IContainer
    End Class
End Namespace

