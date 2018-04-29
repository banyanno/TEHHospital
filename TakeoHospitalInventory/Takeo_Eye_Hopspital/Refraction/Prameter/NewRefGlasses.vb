Public Class NewRefGlasses
    Dim DARefGlasess As New DSRefractionTableAdapters.REFRACTION_GLASSESTableAdapter
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TextBox1, "", ErrorProvider1) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DARefGlasess.InsertRefGlasses(TextBox1.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DARefGlasess.UpdateRefraGlasess(TextBox1.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
End Class