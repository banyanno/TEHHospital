Public Class FormDeleteWaitingPay

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtCommand, "", ErrDelete) = False Then
            MessageBox.Show("Please enter command before you delete receipt.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If MReceiptController.DeleteReceipt(LblSaveOption.Text, TxtCommand.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            '(GridJanusWaitingPayment.GetRow.Cells("ReceiptNo").Value
        End If
    End Sub

    
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class