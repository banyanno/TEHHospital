Partial Class DSWardWithOT
    Partial Class V_IOLRegistrationDataTable

        Private Sub V_IOLRegistrationDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PatientNoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
