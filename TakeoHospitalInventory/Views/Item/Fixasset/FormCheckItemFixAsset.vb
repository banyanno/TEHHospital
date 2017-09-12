Public Class FormCheckItemFixAsset
    Dim DA_CheckAsset As New DS_FIXASSETTableAdapters.FIX_ASSET_CHECKTableAdapter
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DateCheck, "", ErrAssetCheck) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new asset check?", "Check Asset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_CheckAsset.InsertNewCheck(LblFixAssetID.Text, DateCheck.Value.Date, TxtNote.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new asset check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update asset check?", "Check Asset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_CheckAsset.UpdateCheckAsset(DateCheck.Value.Date, TxtNote.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update asset check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class