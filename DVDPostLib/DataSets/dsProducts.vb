Partial Class dsProducts
    
    Partial Class _common_production_reviewsDataTable

        Private Sub _common_production_reviewsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
