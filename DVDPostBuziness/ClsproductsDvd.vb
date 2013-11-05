Public Class ClsproductsDvd

    Public Shared Sub resetposinbox(ByVal dt As DataTable)

        Dim i As Integer = 0
        Dim row As DataRowView
        Dim view As New DataView(dt, "", "pibox_id", DataViewRowState.CurrentRows)
        Dim sql As String
        '  view.RowFilter = " inout = 1"
        For Each row In view
            i += 1
            row("pibox_id") = i
            sql = PlushData.clsProductDvd.GetUpdateDVDpos(row("products_id"), row("products_dvdid"), i)
            PlushData.clsConnection.ExecuteNonQuery(sql)
        Next

    End Sub

    Public Shared Function getFirstPosBox(ByVal dt As DataTable, ByVal col As String) As Integer
        If dt.Rows.Count = 0 Then
            Return 0
        Else
            Return dt.Rows(0)(col)
        End If
    End Function


    Public Shared Function getLastPosBox(ByVal dt As DataTable, ByVal col As String) As Integer
        If dt.Rows.Count = 0 Then
            Return 0
        Else
            Return dt.Rows(dt.Rows.Count() - 1)(col)
        End If
    End Function


   
End Class
