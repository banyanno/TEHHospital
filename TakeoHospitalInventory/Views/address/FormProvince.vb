Public Class FormProvince
    Dim DA_Province As New DSAddressTableAdapters.TBL_PROVINCETableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DA_Province.InsertNewProvince(TxtValueAddres.Text)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DA_Province.UpdateProvince(TxtValueAddres.Text, LblSaveOption.Text)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class