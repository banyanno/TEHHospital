Public Class MainRefraction
    Dim DARefraction As New DSRefractionTableAdapters.REFRACTIONTableAdapter
    Private Sub BtnParameter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParameter.Click
        Dim FRefractionParameter As New RefractionParameter
        FRefractionParameter.ShowDialog()
    End Sub

    Private Sub BtnNewRefraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewRefraction.Click
        Dim NewRefraction As New NewRefraction
        If NewRefraction.ShowDialog() = DialogResult.OK Then
            SelectDateToDatePatientNo(NewRefraction.TxtPatientNo.Text, NewRefraction.RefrationDate.Value.Date, NewRefraction.RefrationDate.Value.Date)
            NewRefraction.Close()
            NewRefraction.Dispose()
        End If
    End Sub


    Private Sub SelectDateToDatePatientNo(ByVal PatientNo As String, ByVal DateFrom As Date, ByVal DateTo As Date)
        Dim TblPRefraction As DataTable = DARefraction.SelectDateToDateWithPatientNo(PatientNo, DateFrom, DateTo)
        GridRefraction.DataSource = TblPRefraction
    End Sub

    Private Sub ChWithPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChWithPatientNo.CheckedChanged
        TxtFindPatientNo.Enabled = ChWithPatientNo.Checked
    End Sub

    Private Sub GridRefraction_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridRefraction.RowDoubleClick
        If GridRefraction.SelectedItems.Count = 0 Then Exit Sub
        Dim NewRefraction As New NewRefraction
        NewRefraction.lblSaveOption.Text = GridRefraction.GetRow.Cells("REFRACT_ID").Value
        NewRefraction.BtnFindPatient.Enabled = False
        NewRefraction.TxtPatientNo.Enabled = False
        NewRefraction.TxtPatientNo.Text = GridRefraction.GetRow.Cells("PATIENT_NO").Value
        NewRefraction.TxtPatientName.Text = GridRefraction.GetRow.Cells("PATIENT_NAME").Value
        NewRefraction.TxtPatientSex.Text = GridRefraction.GetRow.Cells("PATEINT_SEX").Value
        NewRefraction.TxtPatientAge.Text = GridRefraction.GetRow.Cells("PATIENT_AGE").Value
        NewRefraction.TxtPatientTel.Text = GridRefraction.GetRow.Cells("PATIENT_TEL").Value
        NewRefraction.TxtPatientAddress.Text = GridRefraction.GetRow.Cells("PATIENT_ADDRESS").Value
        NewRefraction.RefrationDate.Checked = True
        NewRefraction.RefrationDate.Value = GridRefraction.GetRow.Cells("REFRATION_DATE").Value
        NewRefraction.CboLVAOld.Text = GridRefraction.GetRow.Cells("OLD_LVA").Value
        NewRefraction.CboRVAOld.Text = GridRefraction.GetRow.Cells("OLD_RVA").Value
        NewRefraction.CboDiagnosis.Text = GridRefraction.GetRow.Cells("DIAGNOSIS").Value
        NewRefraction.CboLGlasses.Text = GridRefraction.GetRow.Cells("L_GLASSES").Value
        NewRefraction.CboRGlasses.Text = GridRefraction.GetRow.Cells("R_GLASSES").Value
        NewRefraction.CboLVARefrac.Text = GridRefraction.GetRow.Cells("LVA_REFRACTION").Value
        NewRefraction.CboRVARefrac.Text = GridRefraction.GetRow.Cells("RVA_REFRACTION").Value
        NewRefraction.TxtRefractionNote.Text = GridRefraction.GetRow.Cells("REFRACTION_NOTE").Value
        NewRefraction.ChPrescription.Checked = GridRefraction.GetRow.Cells("IS_PRESCRIPTION").Value

        If NewRefraction.ShowDialog() = DialogResult.OK Then
            SelectDateToDatePatientNo(NewRefraction.TxtPatientNo.Text, NewRefraction.RefrationDate.Value.Date, NewRefraction.RefrationDate.Value.Date)
            NewRefraction.Close()
            NewRefraction.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadingFinding()
    End Sub
    Private Sub LoadingFinding()
        Dim TPRefract As DataTable
        If ChWithPatientNo.Checked = True Then
            If ValidateTextField(TxtFindPatientNo, "", ErrorProvider1) = False Then Exit Sub
            TPRefract = DARefraction.SelectDateToDateWithPatientNo(TxtFindPatientNo.Text, DateRefractFrom.Value.Date, DateRefractTo.Value.Date)
        Else
            TPRefract = DARefraction.SelectRefractionDFromToDTo(DateRefractFrom.Value.Date, DateRefractTo.Value.Date)
        End If
        GridRefraction.DataSource = TPRefract
    End Sub

    Private Sub TxtFindPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFindPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub MainRefraction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadingFinding()
    End Sub

    Private Sub BtnDeleteRefraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteRefraction.Click
        If GridRefraction.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete refraction?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DARefraction.DeleteRefraction(True, GridRefraction.GetRow.Cells("REFRACT_ID").Value) = 1 Then
                MessageBox.Show("Delete successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadingFinding()
            End If
        End If
    End Sub

    Private Sub BtnReqPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReqPrescription.Click
        If GridRefraction.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to request prescription?", "Refraction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DARefraction.UpdateIsPrescription(True, "Request", GridRefraction.GetRow.Cells("REFRACT_ID").Value) = 1 Then
                MessageBox.Show("Request is successful!", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadingFinding()
            End If
        End If
    End Sub

    Private Sub BtnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReport.Click
        Dim ReportRefraction As New ReportAllRefraction
        Dim TblRepRefraction As DataTable = DARefraction.SelectRefractionDFromToDTo(DFromReport.Value.Date, DToReport.Value.Date)
        ReportRefraction.SetDataSource(TblRepRefraction)
        Me.CrystalReportViewer1.ReportSource = ReportRefraction
        ReportRefraction.SetParameterValue("Title", "From:" & DFromReport.Text & " To:" & DToReport.Text)
    End Sub

    Private Sub BtnAprovPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAprovPrescription.Click
        If GridRefraction.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to request prescription?", "Refraction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DARefraction.UpdateIsPrescription(True, "Approved", GridRefraction.GetRow.Cells("REFRACT_ID").Value) = 1 Then
                MessageBox.Show("Request is successful!", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadingFinding()
            End If
        End If
    End Sub
End Class
