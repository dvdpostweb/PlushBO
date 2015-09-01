Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BizzLib
    Public Class clsUserMenu
        Inherits MenuItem
        ' Events
        Public Event UserMenu_Click As UserMenu_ClickEventHandler

        ' Methods
        Public Sub New(ByVal [text] As String, ByVal ownerform As Form)
            AddHandler MyBase.Click, New EventHandler(AddressOf Me.clsUserMenu_Click)
            Dim list As ArrayList = clsUserMenu.__ENCList
            SyncLock list
                clsUserMenu.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me.Text = [text]
            Me.OwnerForm = ownerform
        End Sub

        Private Sub clsUserMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim handler As UserMenu_ClickEventHandler = Me.UserMenu_ClickEvent
            If (Not handler Is Nothing) Then
                handler.Invoke(Me, Me.OwnerForm)
            End If
        End Sub


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        Public OwnerForm As Form
        Public ShortCutKey As Integer
        Public ShortCutModifier As Integer

        ' Nested Types
        Public Delegate Sub UserMenu_ClickEventHandler(ByVal sender As Object, ByVal OwnerForm As Form)
    End Class
End Namespace

