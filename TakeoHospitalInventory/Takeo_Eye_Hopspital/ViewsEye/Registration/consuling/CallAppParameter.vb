Public Class CallAppParameter
    Dim DA_CallPara As New DSConsultTableAdapters.CALL_PARAMETERTableAdapter
    Private Sub RefreshCallPara()
        LblSaveOption.Text = "0"
        TxtParaValue.Text = ""
        GridAppPara.DataSource = DA_CallPara.GetData
    End Sub
    Private Sub CallAppParameter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshCallPara()
    End Sub

    Private Sub BtnSaveNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveNew.Click
        If ValidateTextField(TxtParaValue, "", ErrPara) = False Then Exit Sub
        LblSaveOption.Text = "0"
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new Call para?", "Call para", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_CallPara.InsertCallKPara(TxtParaValue.Text) = 1 Then
                    RefreshCallPara()
                Else
                    MessageBox.Show("Error save call para", "Call para", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If ValidateTextField(TxtParaValue, "", ErrPara) = False Then Exit Sub

        If LblSaveOption.Text <> "0" Then
            If MessageBox.Show("Do you want to update Call para?", "Call para", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_CallPara.UpdateCallPara(TxtParaValue.Text, LblSaveOption.Text) = 1 Then
                    RefreshCallPara()
                Else
                    MessageBox.Show("Error update call para", "Call para", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridAppPara.SelectedItems.Count = 0 Then Exit Sub


        If MessageBox.Show("Do you want to delete Call para?", "Call para", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_CallPara.DeleteCallPara(GridAppPara.GetRow.Cells("CALL_PARAID").Value) = 1 Then
                RefreshCallPara()
            Else
                MessageBox.Show("Error deletre call para", "Call para", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub GridAppPara_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAppPara.RowDoubleClick
        If GridAppPara.SelectedItems.Count = 0 Then Exit Sub
        LblSaveOption.Text = GridAppPara.GetRow.Cells("CALL_PARAID").Value
        TxtParaValue.Text = GridAppPara.GetRow.Cells("CALL_PARAVALUE").Value

    End Sub
End Class