Imports System

Namespace BizzLib
    Public MustInherit Class clsBKGenericClass
        ' Methods
        Public Sub SetBKOjects(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
            Me.BKGlobal = New clsGlobal(Me.SessionInfo)
            Me.BKFilter = New clsFilter(Me.SessionInfo)
            Me.BKBrowseView = New clsBrowseView(Me.SessionInfo)
            Me.BKDefaultSet = New clsDefaultSet(Me.SessionInfo)
            Me.BKReport = New clsReport(Me.SessionInfo)
            Me.BKCombo = New clsCombo(Me.SessionInfo)
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
        Public BKBrowseView As clsBrowseView
        Public BKCombo As clsCombo
        Public BKDefaultSet As clsDefaultSet
        Public BKFilter As clsFilter
        Public BKGlobal As clsGlobal
        Public BKReport As clsReport
        Public mvarSessionInfo As clsSessionInfo
    End Class
End Namespace

