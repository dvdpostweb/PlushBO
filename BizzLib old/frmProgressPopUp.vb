Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmProgressPopUp
        Inherits frmBKForm
        ' Methods
        Public Sub New()
            Dim list As ArrayList = frmProgressPopUp.__ENCList
            SyncLock list
                frmProgressPopUp.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.InitializeComponent
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ResourceManager(GetType(frmProgressPopUp))
            Me.pictureBox1 = New PictureBox
            Me.SuspendLayout
            Me.pictureBox1.Dock = DockStyle.Fill
            Me.pictureBox1.Image = DirectCast(manager.GetObject("pictureBox1.Image"), Image)
            Dim point As New Point(0, 0)
            Me.pictureBox1.Location = point
            Me.pictureBox1.Name = "pictureBox1"
            Dim size As New Size(200, &H20)
            Me.pictureBox1.Size = size
            Me.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            Me.pictureBox1.TabIndex = 6
            Me.pictureBox1.TabStop = False
            size = New Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Size(&HCA, &H20)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmProgressPopUP"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Exporting"
            Me.ResumeLayout(False)
        End Sub


        ' Properties
        Friend Overridable Property pictureBox1 As PictureBox
            Get
                Return Me._pictureBox1
            End Get
            Set(ByVal WithEventsValue As PictureBox)
                Me._pictureBox1 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        <AccessedThroughProperty("pictureBox1")> _
        Private _pictureBox1 As PictureBox
        Private components As IContainer
    End Class
End Namespace

