Public Class AddNewFamilyRelative
    Dim DA_FamilyRelative As New DSConsultTableAdapters.FAMILY_RELATIVETableAdapter
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtFamilyRelative, "", ErrFamilyRelative) = False Then Exit Sub
        If lblFamilyID.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_FamilyRelative.InsertNewFamily(TxtFamilyRelative.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_FamilyRelative.UpdateFamily(TxtFamilyRelative.Text, lblFamilyID.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
        
    End Sub
End Class