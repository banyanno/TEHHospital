Public Class FormVillage
    Dim DA_Village As New DSAddressTableAdapters.TBL_VILLAGETableAdapter
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DA_Village.InsertNewVillage(TxtValueAddres.Text, LblCommune.Text)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DA_Village.UpdateVillage(TxtValueAddres.Text, LblSaveOption.Text)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class