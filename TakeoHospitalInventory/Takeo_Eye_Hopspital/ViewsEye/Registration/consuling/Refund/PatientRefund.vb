Public Class PatientRefund
    Dim DA_Patient As New DSConsultTableAdapters.TblPatientsTableAdapter
    Dim DA_PatientRefund As New DSRefundTableAdapters.PATIENT_REFUNDTableAdapter
    Dim DA_PatientReceipt As New DSRefundTableAdapters.tblPatientReceiptTableAdapter
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtPatientNo, "", ErrRefund) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "", ErrRefund) = False Then Exit Sub
        If ValidateDateField(DateRefund, "", ErrRefund) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new patient refund?", "Refund", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_PatientRefund.InsertNewRefund(EmptyString(TxtPatientNo.Text), TxtPatientName.Text, EmptyString(TxtReceiptNo.Text), CDec(IIf(RadDolar.Checked = True, EmptyString(TxtMoneyRefund.Text), 0)), CDec(IIf(RadRield.Checked = True, EmptyString(TxtMoneyRefund.Text), 0)), TxtRefundFor.Text, DateRefund.Value.Date, TxtRefundNote.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do yow want to update patient refund?", "Refund", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_PatientRefund.UpdatePatientRefund(EmptyString(TxtPatientNo.Text), TxtPatientName.Text, EmptyString(TxtReceiptNo.Text), CDec(IIf(RadDolar.Checked = True, EmptyString(TxtMoneyRefund.Text), 0)), CDec(IIf(RadRield.Checked = True, EmptyString(TxtMoneyRefund.Text), 0)), TxtRefundFor.Text, DateRefund.Value.Date, TxtRefundNote.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
        
        
    End Sub
    Private Sub FindPatientNo(ByVal patientNo As Double)
        Dim TblPatient As DataTable = DA_Patient.GetDataByPatientNo(patientNo)
        If TblPatient.Rows.Count <= 0 Then
            MessageBox.Show("Patient No not found. Please check it again.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPatientNo.Focus()
            GridRefund.DataSource = Nothing
            TxtPatientNo.SelectAll()
            TxtPatientName.Text = ""
            'TxtSex.Text = ""
            'TxtAge.Text = ""
            'TxtPatientOccupation.Text = ""
            'TxtPatientAddress.Text = ""
        Else
            For Each Row As DataRow In TblPatient.Rows
                TxtPatientName.Text = Row("NameKhmer")
                'TxtSex.Text = Row("Sex")
                'TxtAge.Text = Row("Age")
                'TxtPatientOccupation.Text = Row("Occupation")
                'TxtPatientAddress.Text = Row("Address")
               
            Next
        End If
    End Sub
    Private Sub FindPatientReceipt(ByVal PatientNo As Double)
        Dim ConPaid As String = "NR"
        Dim tblReceiptInfo As DataTable = DA_PatientReceipt.SelectReceiptNoByPatientNo(PatientNo)
        GridRefund.DataSource = tblReceiptInfo
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FindPatientNo(EmptyString(TxtPatientNo.Text))
        FindPatientReceipt(EmptyString(TxtPatientNo.Text))
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub GridRefund_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridRefund.SelectionChanged
        If GridRefund.SelectedItems.Count = 0 Then Exit Sub
     
        If GridRefund.GetRow.Cells("TotalRiel").Value = 0 Then
            RadDolar.Checked = True
        Else
            RadRield.Checked = True
        End If
        TxtReceiptNo.Text = GridRefund.GetRow.Cells("ReceiptNo").Value
        TxtMoneyRefund.Text = IIf(GridRefund.GetRow.Cells("TotalRiel").Value = 0, GridRefund.GetRow.Cells("TotalUSD").Value, GridRefund.GetRow.Cells("TotalRiel").Value)
        TxtRefundFor.Text = GridRefund.GetRow.Cells("ConGeneral").Value
    End Sub

    Private Sub TxtMoneyRefund_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoneyRefund.KeyPress
        SetDisableKey(e)
    End Sub
End Class