Public Class clsCallHistory
    Private Shared dtFeuille As DataTable
    Private Shared dtArbre As DataTable
    Private Shared dtSaveBranch As DataTable
    Private Shared dtContact As DataTable

    Private Shared _queue As System.Collections.Queue

    Public Shared ReadOnly Property Queue() As System.Collections.Queue
        Get
            If _queue Is Nothing Then
                _queue = New System.Collections.Queue()
            End If
            Return _queue
        End Get

    End Property

    Public Shared ReadOnly Property contacts() As DataTable
        Get
            If dtContact Is Nothing Then
                Dim sql As String

                sql = PlushData.clsCallHistory.getSelectContact()
                dtContact = PlushData.clsConnection.FillDataSet(sql)
            End If
            Return dtContact
        End Get

    End Property

    Public Shared ReadOnly Property feuilles() As DataTable
        Get
            If dtFeuille Is Nothing Then
                Dim sql As String

                sql = PlushData.clsCallHistory.getSelectFeuille()
                dtFeuille = PlushData.clsConnection.FillDataSet(sql)
            End If
            Return dtFeuille
        End Get

    End Property

    Public Shared ReadOnly Property arbre() As DataTable
        Get
            If dtArbre Is Nothing Then
                Dim sql As String

                sql = PlushData.clsCallHistory.getSelectArbre()
                dtArbre = PlushData.clsConnection.FillDataSet(sql)
            End If
            Return dtArbre
        End Get

    End Property

    Private Shared ReadOnly Property savedBranch() As DataTable
        Get
            If dtSaveBranch Is Nothing Then
                Dim sql As String

                sql = PlushData.clsCallHistory.GetSelectBranchSave()
                dtSaveBranch = PlushData.clsConnection.FillDataSet(sql)
            End If
            Return dtSaveBranch
        End Get

    End Property

    Public Shared Function getChild() As DataView
        Dim dv As DataView
        dv = New DataView(arbre, "parent_id is null ", "", DataViewRowState.CurrentRows)
        Return dv
    End Function

    Public Shared Function getChild(ByVal parent_id As Integer) As DataView
        Dim dv As DataView
        dv = New DataView(arbre, "parent_id = " & parent_id, "", DataViewRowState.CurrentRows)
        Return dv
    End Function
    Public Shared Function getParentid(ByVal id As Integer) As Integer
        Dim dv As DataView
        dv = New DataView(arbre, "id = " & id, "", DataViewRowState.CurrentRows)
        If dv.Count > 0 Then
            If Not dv(0)("parent_id") Is DBNull.Value Then
                Return dv(0)("parent_id")
            Else
                Return -1
            End If
        Else
            Return -1
        End If
    End Function

    Public Shared Function getParent(ByVal id As Integer) As DataView
        Dim dv As DataView
        dv = New DataView(arbre, "id = " & id, "", DataViewRowState.CurrentRows)
        Return dv
    End Function

    Public Shared Function isMainCurrentNode() As Boolean
        Return PlushBuziness.clsCallHistory.Queue.Count = 0
    End Function
    Public Shared Function isFeuille(ByVal id As Integer) As Boolean
        Dim dv As DataView

        dv = New DataView(feuilles, "id = " & id, "", DataViewRowState.CurrentRows)
        Return dv.Count = 1

    End Function

    Public Shared Function isSaveBranch(ByVal id As Integer) As Boolean
        Dim dv As DataView

        dv = New DataView(savedBranch, "id = " & id, "", DataViewRowState.CurrentRows)
        Return dv.Count = 1

    End Function
    Private Shared Function getLastId() As Integer
        Dim sql As String
        Dim result As Integer

        sql = PlushData.clsCallHistory.getLastIdInsert()
        result = PlushData.clsConnection.ExecuteScalar(sql)
        Return result
    End Function
    '''' <summary>
    '''' recursive to find the way to nodeMain 
    '''' </summary>
    '''' <param name="id"></param>
    '''' <param name="lst"></param>
    '''' <remarks></remarks>
    'Private Shared Sub FindParent(ByVal id As Integer, ByRef lst As List(Of Integer))
    '    Dim dv As DataView

    '    dv = getParent(id)
    '    lst.Add(id)
    '    If dv.Count = 1 And Not dv(0)("parent_id") Is DBNull.Value Then
    '        FindParent(dv(0)("parent_id"), lst)
    '    End If

    'End Sub
    Public Shared Function Loadhistory(ByVal customers_id As Integer) As DataTable

        Dim dt As DataTable
        Dim sql As String

        sql = PlushData.clsCallHistory.getSelectCallHistory(customers_id)
        dt = PlushData.clsConnection.FillDataSet(sql)

        Return dt

    End Function
    Public Shared Function LoadValue(ByVal history_id As Integer) As String

        Dim dt As DataTable
        Dim sql As String
        Dim result As String = ""
        sql = PlushData.clsCallHistory.getSelectCallDetailHistory(history_id)
        dt = PlushData.clsConnection.FillDataSet(sql)


        For Each dr As DataRow In dt.Rows
            result = dr("text") + " -> " + result
        Next


        'For Each dr As DataRow In dt.Rows
        '    FindParent(dr("call_id"), lst)
        'Next

        Return result
    End Function
    Public Shared Sub SaveValue(ByVal lstValue As List(Of Integer), _
                                ByVal customers_id As Integer, _
                                ByVal FT As Boolean, _
                                ByVal nb_reconduction As Integer, _
                                ByVal contact_id As Integer, _
                                ByVal comment As String, _
                                ByVal start_date As DateTime, _
                                ByVal end_date As DateTime)


        Dim sql As String
        Dim id As Integer

        comment = comment.Replace("'", "''")
        sql = PlushData.clsCallHistory.getInsertHistory(customers_id, FT, nb_reconduction, contact_id, comment, start_date, end_date)
        PlushData.clsConnection.ExecuteNonQuery(sql)

        id = getLastId()

        For Each item As Integer In lstValue
            sql = PlushData.clsCallHistory.getInsertValueCall(id, item)
            PlushData.clsConnection.ExecuteNonQuery(sql)
        Next

    End Sub
End Class
