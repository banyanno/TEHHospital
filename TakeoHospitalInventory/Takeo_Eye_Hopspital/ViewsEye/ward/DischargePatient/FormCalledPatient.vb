Public Class FormCalledPatient
    Dim danewInpatient As New DSPaatientLeaveTableAdapters.TblNewInPatientTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MessageBox.Show("Do you want to update patient call?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If danewInpatient.UpdateIsCalled(True, DateCalled.Value.Date, TxtCallNoted.Text, LblIsUpdate.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class