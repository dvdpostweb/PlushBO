Partial Class dsCustomers

    Partial Class siteDataTable

        Private Sub siteDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.site_nameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class customers_view2DataTable

        Private Sub customers_view2DataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.before_last_actionColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
