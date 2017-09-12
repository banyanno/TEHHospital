Public Class FormUpdateCalled
    Dim DAUpdateCalled As New DSConsultTableAdapters.CONSULING_APPOINTMENTTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtPatientNo, "", ErrorProvider1) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "", ErrorProvider1) = False Then Exit Sub
        If LblIsUpdate.Text <> "0" Then
            If MessageBox.Show("Do you want to update patient called?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DAUpdateCalled.IsUpdateCall(True, DateCalled.Value.Date, TxtCallNoted.Text, LblIsUpdate.Text) = 1 Then
                    MessageBox.Show("Update successfull!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class