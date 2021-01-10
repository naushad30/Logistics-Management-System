Partial Class LogisticDataSet
    Partial Class customer_regDataTable

        Private Sub customer_regDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.phoneColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
