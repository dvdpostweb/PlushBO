

Partial Public Class dsAboRent
    Class abo_stop_why_view1DataTable

    End Class

    Partial Class abo_view1DataTable

        Private Sub abo_view1DataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.products_dvdpostchoiceColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub abo_view1DataTable_abo_view1RowChanging(ByVal sender As System.Object, ByVal e As abo_view1RowChangeEvent) Handles Me.abo_view1RowChanging

        End Sub

    End Class

    Partial Class customersDataTable

    End Class

End Class
