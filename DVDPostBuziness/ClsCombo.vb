Public Class ClsCombo

    Public Shared Function addRowEmpty(ByVal dt As DataTable, Optional ByVal valueEmpty As Integer = 0) As DataTable
        Dim lst(1) As String

        lst(0) = valueEmpty
        lst(1) = String.Empty
        dt.Rows.Add(lst)

        Return dt
    End Function

    Public Shared Function GetListEnum(ByVal sql As String) As List(Of PlushBuziness.clsKeyComboEnum)
        Dim dt As DataTable
        Dim Strenum As String
        Dim lstResult() As String = Nothing
        Dim lstStatus As New List(Of PlushBuziness.clsKeyComboEnum)

        dt = PlushData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count > 0 Then
            Strenum = dt.Rows(0)("type")
            Strenum = Mid(Strenum, 6, Strenum.Length - 6)
            Strenum = Strenum.Replace("'", "")
            lstResult = Strenum.Split(",")


            For Each Item As String In lstResult
                lstStatus.Add(New PlushBuziness.clsKeyComboEnum(Item, Item))
            Next

        End If

        Return lstStatus
    End Function

End Class
