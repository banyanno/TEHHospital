Partial Class DataSetCashCountDaily
    Partial Class IncomeSummaryDataTable

        Private Sub IncomeSummaryDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TotalReilColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
