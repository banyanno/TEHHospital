Public Class FormBusinessDay
    Dim DA_BusDay As New DSPatientReceiptTableAdapters.BusinessesTableAdapter
   

    Private Sub BtnNewBusinessDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewBusinessDay.Click
        Dim FMarkEOD As New FormMarkEOD
        If FMarkEOD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RefreshBusinessDay()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FormBusinessDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshBusinessDay()
    End Sub
    Sub RefreshBusinessDay()
        GridEXBusinessDay.DataSource = DA_BusDay.GetData(GetDateServer.Now.AddDays(-5))
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshBusinessDay()
    End Sub

    Private Sub GridEXBusinessDay_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridEXBusinessDay.MouseDoubleClick
        If GridEXBusinessDay.SelectedItems.Count = 0 Then Exit Sub
        If GridEXBusinessDay.GetRow.Cells("STATUS").Value <> "Y" Then Exit Sub
        Dim FMarkEOD As New FormMarkEOD
        FMarkEOD.BtnSettingMarkEOD.Text = "Update"
        FMarkEOD.LblSaveOption.Text = GridEXBusinessDay.GetRow.Cells("ID").Value
        FMarkEOD.DateNewBusinessDay.Checked = True
        FMarkEOD.DateNewBusinessDay.Value = GridEXBusinessDay.GetRow.Cells("NEXT_BUSINESS_DATE").Value
        If FMarkEOD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RefreshBusinessDay()
        End If
    End Sub
End Class