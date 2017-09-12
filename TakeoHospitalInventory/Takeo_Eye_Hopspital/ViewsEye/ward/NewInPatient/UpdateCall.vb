Public Class UpdateCall

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MessageBox.Show("Do you want to update call postpone?", "Is call", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If ModNewInPatient.UpdateStatusCallPostpone(LblSaveOption.Text, True, TxtNote.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End If
    End Sub
End Class