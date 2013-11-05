Public Class clsKeyComboEnum
    Private _DisplayMember As String
    Private _Value As String

    Public Property DisplayMember() As String
        Get
            Return _DisplayMember
        End Get
        Set(ByVal DisplayMember As String)
            _DisplayMember = DisplayMember
        End Set
    End Property

    Public Property Value() As String
        Get
            Return _Value
        End Get
        Set(ByVal value As String)
            _Value = value
        End Set
    End Property

    Public Sub New(ByVal str As String, ByVal key As String)

        DisplayMember = str
        Value = key
    End Sub
End Class

Public Class clsKeyCombo
    Private _DisplayMember As String
    Private _Value As Integer

    Public Property DisplayMember() As String
        Get
            Return _DisplayMember
        End Get
        Set(ByVal DisplayMember As String)
            _DisplayMember = DisplayMember
        End Set
    End Property

    Public Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            _Value = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal str As String, ByVal key As Integer)

        DisplayMember = str
        Value = key
    End Sub
End Class
