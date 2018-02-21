Public Class CheckAllCashCount

    Private Sub CheckAllCashCount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TblDepInCashCount As DataTable = MCashCollection.SelectDepartInCashCount()
        GridDepartment.DataSource = TblDepInCashCount
    End Sub

    Private Sub ShowCashCount(ByVal DateIn As Date, ByVal DepartID As Integer)
        Dim i As Integer
        GBPayment.Text = "List of patient in department:" & GridDepartment.GetRow.Cells("DEPARTMENT_NAME").Value
        Me.GridCashCollection.DataSource = MCashCollection.DailyCashCollectionByDepartment(Me.dtpDateFrom.Value, DepartID)
        Dim tblCashCount As DataTable = MCashCollection.SelectCashCountByDepartment(DateIn, DepartID)
        Me.dgvRemarks.DataSource = MCashCollection.DailyRemarksAccReceivedByDep(Me.dtpDateFrom.Value, DepartID)
        Dim RowCC As DataRow
        If tblCashCount.Rows.Count > 0 Then
            For i = 0 To tblCashCount.Rows.Count - 1
                RowCC = tblCashCount.Rows(i)
                With RowCC
                    Me.txt100USD.Text = .Item(2).ToString
                    Me.txt50USD.Text = .Item(5).ToString
                    Me.txt20USD.Text = .Item(8).ToString
                    Me.txt10USD.Text = .Item(11).ToString
                    Me.txt5USD.Text = .Item(14).ToString
                    Me.txt1USD.Text = .Item(17).ToString
                    Me.txtTotalUSDCount.Text = .Item(19).ToString
                    Me.txt100000R.Text = .Item(21).ToString
                    Me.txt50000R.Text = .Item(24).ToString
                    Me.txt20000R.Text = .Item(27).ToString
                    Me.txt10000R.Text = .Item(30).ToString
                    Me.txt5000R.Text = .Item(33).ToString
                    Me.txt2000R.Text = .Item(36).ToString
                    Me.txt1000R.Text = .Item(39).ToString
                    Me.txt500R.Text = .Item(42).ToString
                    Me.txt100R.Text = .Item(45).ToString
                    Me.txt50R.Text = .Item(48).ToString
                    Me.txtTotalRielCount.Text = .Item(50).ToString
                End With
            Next
        End If
    End Sub
    Sub ClearCashCount()
        Me.txt100USD.Text = "0"
        Me.txt50USD.Text = "0"
        Me.txt20USD.Text = "0"
        Me.txt10USD.Text = "0"
        Me.txt5USD.Text = "0"
        Me.txt1USD.Text = "0"
        Me.txt100000R.Text = "0"
        Me.txt50000R.Text = "0"
        Me.txt20000R.Text = "0"
        Me.txt10000R.Text = "0"
        Me.txt5000R.Text = "0"
        Me.txt2000R.Text = "0"
        Me.txt1000R.Text = "0"
        Me.txt500R.Text = "0"
        Me.txt100R.Text = "0"
        Me.txt50R.Text = "0"
        Me.txt100USD.Focus()
        txtTotalRielCount.Text = "0"
        txtTotalUSDCount.Text = "0"
        GridCashCollection.DataSource = Nothing
        dgvRemarks.DataSource = Nothing
    End Sub
    Private Sub dtpDateFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateFrom.ValueChanged
        ClearCashCount()
        If GridDepartment.SelectedItems.Count = 0 Then Exit Sub
        ShowCashCount(dtpDateFrom.Value.Date, GridDepartment.GetRow.Cells("CASH_IN_DEPART").Value)
    End Sub

    Private Sub GridDepartment_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDepartment.SelectionChanged
        ClearCashCount()
        If GridDepartment.SelectedItems.Count = 0 Then Exit Sub
        ShowCashCount(dtpDateFrom.Value.Date, GridDepartment.GetRow.Cells("CASH_IN_DEPART").Value)
    End Sub
End Class