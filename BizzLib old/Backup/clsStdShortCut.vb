Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data

Namespace BizzLib
    Public Class clsStdShortCut
        ' Methods
        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
        End Sub

        Public Sub LoadShortCut(ByVal ShortCutID As Integer, ByVal ShortCut1 As clsStdShortCut)
            Dim security As New dsSecurity
            Dim set As New clsDataSet(Me.SessionInfo)
            Dim sQLTxt As String = ("SELECT * FROM securityshortcut WHERE ShortCutID = " & Conversions.ToString(ShortCutID))
            Try 
                ClsDs.FillDataSet(security.Tables.Item("securityshortcut"), sQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
            If (security.Tables.Item("securityshortcut").Rows.Count > 0) Then
                Dim row As DataRow = security.Tables.Item("securityshortcut").Rows.Item(0)
                Me.AddKey = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("AddKey")))
                Me.EditKey = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("EditKey")))
                Me.DeleteKey = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("DeleteKey")))
                Me.SaveKey = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("SaveKey")))
                Me.UndoKey = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("UndoKey")))
                Me.HelpKey = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("HelpKey")))
                Me.AddModifier = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("AddKeyModifier")))
                Me.EditModifier = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("EditKeyModifier")))
                Me.DeleteModifier = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("DeleteKeyModifier")))
                Me.SaveModifier = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("SaveKeyModifier")))
                Me.UndoModifier = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("UndoKeyModifier")))
                Me.HelpModifier = Conversions.ToInteger(Operators.ConcatenateObject("0", row.Item("HelpKeyModifier")))
                row = Nothing
            Else
                Me.AddKey = &H74
                Me.AddKey_S = "F5"
                Me.EditKey = &H75
                Me.EditKey_S = "F6"
                Me.DeleteKey = &H76
                Me.DeleteKey_S = "F7"
                Me.SaveKey = &H77
                Me.SaveKey_S = "F8"
                Me.UndoKey = &H1B
                Me.UndoKey_S = "ESC"
                Me.HelpKey = &H70
                Me.HelpKey_S = "F1"
                Me.FirstKey = 120
                Me.FirstKey_S = "F9"
                Me.PreviousKey = &H79
                Me.PreviousKey_S = "F10"
                Me.NextKey = &H7A
                Me.NextKey_S = "F11"
                Me.LastKey = &H7B
                Me.LastKey_S = "F12"
                Me.PrintKey = 80
                Me.PrintKey_S = "ALT+P"
                Me.PrintModifier = &H40000
                Me.FilterKey = &H71
                Me.FilterKey_S = "F2"
                Me.BrowseColumnKey = &H72
                Me.BrowseColumnKey_S = "F3"
                Me.TranslationKey = -1
                Me.CommentKey = -1
                Me.AttachementKey = -1
            End If
        End Sub


        ' Properties
        Public Property SessionInfo As clsSessionInfo
            Get
                Return Me.mvarSessionInfo
            End Get
            Set(ByVal Value As clsSessionInfo)
                Me.mvarSessionInfo = Value
            End Set
        End Property


        ' Fields
        Public AddKey As Integer
        Public AddKey_S As String
        Public AddModifier As Integer
        Public AtachementKey_S As String
        Public AttachementKey As Integer
        Public AttachementModifier As Integer
        Public BrowseColumnKey As Integer
        Public BrowseColumnKey_S As String
        Public BrowseColumnModifier As Integer
        Public CommentKey As Integer
        Public CommentKey_S As String
        Public CommentModifier As Integer
        Public DeleteKey As Integer
        Public DeleteKey_S As String
        Public DeleteModifier As Integer
        Public EditKey As Integer
        Public EditKey_S As String
        Public EditModifier As Integer
        Public FilterKey As Integer
        Public FilterKey_S As String
        Public FilterModifier As Integer
        Public FirstKey As Integer
        Public FirstKey_S As String
        Public FirstModifier As Integer
        Public HelpKey As Integer
        Public HelpKey_S As String
        Public HelpModifier As Integer
        Public LastKey As Integer
        Public LastKey_S As String
        Public LastModifier As Integer
        Private mvarSessionInfo As clsSessionInfo
        Public NextKey As Integer
        Public NextKey_S As String
        Public NextModifier As Integer
        Public PreviousKey As Integer
        Public PreviousKey_S As String
        Public PreviousModifier As Integer
        Public PrintKey As Integer
        Public PrintKey_S As String
        Public PrintModifier As Integer
        Public SaveKey As Integer
        Public SaveKey_S As String
        Public SaveModifier As Integer
        Public TranslationKey As Integer
        Public TranslationKey_S As String
        Public TranslationModifier As Integer
        Public UndoKey As Integer
        Public UndoKey_S As String
        Public UndoModifier As Integer
    End Class
End Namespace

