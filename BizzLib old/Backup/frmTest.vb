Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace BizzLib
    Public Class frmTest
        Inherits Form
        ' Methods
        Public Sub New()
            Dim list As ArrayList = frmTest.__ENCList
            SyncLock list
                frmTest.__ENCList.Add(New WeakReference(Me))
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
            Dim size As New Size(5, 13)
            Me.AutoScaleBaseSize = size
            size = New Size(&H228, &H10A)
            Me.ClientSize = size
            Me.Name = "frmTest"
            Me.Text = "frmTest"
        End Sub


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        Private components As IContainer
    End Class
End Namespace

