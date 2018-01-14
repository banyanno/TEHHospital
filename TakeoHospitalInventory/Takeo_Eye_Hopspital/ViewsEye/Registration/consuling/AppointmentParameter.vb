Public Class AppointmentParameter
    Dim DA_APPPara As New DSConsultTableAdapters.APPOINT_PARATableAdapter
    Private Sub AppointmentParameter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshParameter()
    End Sub

    Private Sub RefreshParameter()
        TxtParaValue.Text = ""
        LblSaveOption.Text = 0
        GridAppPara.DataSource = DA_APPPara.GetData
    End Sub

    Private Sub BtnSaveNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveNew.Click
        If ValidateTextField(TxtParaValue, "", ErrAppPara) = False Then Exit Sub
        LblSaveOption.Text = "0"
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new appointment parameter?", "App para", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_APPPara.InsertAppPara(TxtParaValue.Text) = 1 Then
                    RefreshParameter()
                Else
                    MessageBox.Show("Error save appoint para", "App para", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

    Private Sub GridAppPara_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAppPara.RowDoubleClick
        If GridAppPara.SelectedItems.Count = 0 Then Exit Sub
        LblSaveOption.Text = GridAppPara.GetRow.Cells("APP_PARAID").Value
        TxtParaValue.Text = GridAppPara.GetRow.Cells("APP_PARAVALUE").Value
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If LblSaveOption.Text <> "0" Then
            If MessageBox.Show("Do you want to update  appointment parameter?", "App para", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_APPPara.UpdateAppPara(TxtParaValue.Text, LblSaveOption.Text) = 1 Then
                    RefreshParameter()
                Else
                    MessageBox.Show("Error update appoint para", "App para", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridAppPara.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete appointment parameter?", "App para", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_APPPara.DeleteAppPara(GridAppPara.GetRow.Cells("APP_PARAID").Value) = 1 Then
                RefreshParameter()
            Else
                MessageBox.Show("Error update appoint para", "App para", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshParameter()
    End Sub
End Class