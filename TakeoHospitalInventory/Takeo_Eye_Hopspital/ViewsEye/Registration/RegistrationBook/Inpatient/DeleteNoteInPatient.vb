Public Class DeleteNoteInPatient


    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtNote, "", ErrInpatien) = False Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If ModInPatient.UpdateInToCancel(LblSaveOption.Text, TxtNote.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class