Public Class MainRefraction
    Dim DARefraction As New DSRefractionTableAdapters.REFRACTIONTableAdapter
    Private Sub BtnParameter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParameter.Click
        Dim FRefractionParameter As New RefractionParameter
        FRefractionParameter.ShowDialog()
    End Sub

    Private Sub BtnNewRefraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewRefraction.Click
        Dim NewRefraction As New NewRefraction
        NewRefraction.RefrationDate.Checked = True
        NewRefraction.RefrationDate.Value = ModGlobleVariable.CheckMarkEOD

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
        If DEPART_ID = 26 Then
            Exit Sub
        Else
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
            NewRefraction.ChIsOld.Checked = GridRefraction.GetRow.Cells("IS_OLD_OR_NEW").Value
            NewRefraction.CboLVAOld.Text = GridRefraction.GetRow.Cells("OLD_LVA").Value
            NewRefraction.CboRVAOld.Text = GridRefraction.GetRow.Cells("OLD_RVA").Value
            NewRefraction.CboDiagnosis.Text = GridRefraction.GetRow.Cells("DIAGNOSIS").Value
            NewRefraction.CboLGlasses.Text = GridRefraction.GetRow.Cells("L_GLASSES").Value
            NewRefraction.CboRGlasses.Text = GridRefraction.GetRow.Cells("R_GLASSES").Value
            NewRefraction.CboLVARefrac.Text = GridRefraction.GetRow.Cells("LVA_REFRACTION").Value
            NewRefraction.CboRVARefrac.Text = GridRefraction.GetRow.Cells("RVA_REFRACTION").Value
            NewRefraction.TxtRefractionNote.Text = GridRefraction.GetRow.Cells("REFRACTION_NOTE").Value
            NewRefraction.ChPrescription.Checked = GridRefraction.GetRow.Cells("IS_PRESCRIPTION").Value

            NewRefraction.CboRAxis.Text = GridRefraction.GetRow.Cells("R_AXIS").Value
            NewRefraction.CboLAxis.Text = GridRefraction.GetRow.Cells("L_AXIS").Value

            NewRefraction.CboLVAReading.Text = GridRefraction.GetRow.Cells("LVA_READING").Value
            NewRefraction.CboADD.Text = GridRefraction.GetRow.Cells("RVA_READING").Value

            If NewRefraction.ShowDialog() = DialogResult.OK Then
                SelectDateToDatePatientNo(NewRefraction.TxtPatientNo.Text, NewRefraction.RefrationDate.Value.Date, NewRefraction.RefrationDate.Value.Date)
                NewRefraction.Close()
                NewRefraction.Dispose()
            End If
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
    Private Sub ShowAllWaitingApprove()
        Dim TblWaitingApprove As DataTable = DARefraction.SelectPrescrebtionStatus("Send", DateRefractFrom.Value.Date, DateRefractTo.Value.Date)
        GridRefraction.DataSource = TblWaitingApprove
    End Sub

    Private Sub TxtFindPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFindPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub MainRefraction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadingFinding()
        LoadingPermistion()
    End Sub
    Private Sub LoadingPermistion()
        If DEPART_ID = 26 Then
            BtnNewRefraction.Enabled = False
            BtnParameter.Enabled = False
            BtnReqPrescription.Enabled = False
            BtnDeleteRefraction.Enabled = False
        Else
            BtnDeleteRefraction.Enabled = True
            BtnNewRefraction.Enabled = True
            BtnParameter.Enabled = True
            BtnReqPrescription.Enabled = True
        End If
       
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
        If GridRefraction.GetRow.Cells("IS_PRESCRIPTION").Value = False Then
            MessageBox.Show("This patient is not prescription. please check again!", "Prescription", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If GridRefraction.GetRow.Cells("PRESCRIPT_STATUS").Value = "Send" Then
            MessageBox.Show("The patient already send", "Prescription", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to request prescription?", "Refraction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DARefraction.UpdateIsPrescription(True, "Send", GridRefraction.GetRow.Cells("REFRACT_ID").Value) = 1 Then
                MessageBox.Show("Request is successful!", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadingFinding()
            End If
        End If
    End Sub

    Private Sub BtnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReport.Click
        Dim ReportRefraction As New ReportAllRefraction
        Dim TblRepRefraction As DataTable
        Dim ParaList As String = ""
        If RadReportAll.Checked = True Then
            ParaList = "List all refraction."
            TblRepRefraction = DARefraction.SelectRefractionDFromToDTo(DFromReport.Value.Date, DToReport.Value.Date)
        ElseIf RadRepNew.Checked = True Then
            ParaList = "List New refraction."
            TblRepRefraction = DARefraction.SelectIsDateToDateWithOldOrNew(DFromReport.Value.Date, DToReport.Value.Date, False)
        ElseIf RadRepOld.Checked = True Then
            ParaList = "List Old refraction."
            TblRepRefraction = DARefraction.SelectIsDateToDateWithOldOrNew(DFromReport.Value.Date, DToReport.Value.Date, True)
        End If

        ReportRefraction.SetDataSource(TblRepRefraction)
        Me.CrystalReportViewer1.ReportSource = ReportRefraction
        ReportRefraction.SetParameterValue("Title", "From:" & DFromReport.Text & " To:" & DToReport.Text)
        ReportRefraction.SetParameterValue("IS_OLD_OR_NEW", ParaList)

    End Sub

    Private Sub BtnAprovPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAprovPrescription.Click
        If GridRefraction.SelectedItems.Count = 0 Then Exit Sub
        If GridRefraction.GetRow.Cells("PRESCRIPT_STATUS").Value = "Received" Then
            MessageBox.Show("The patient already Received.", "Prescription", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to request prescription?", "Refraction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DARefraction.UpdateIsPrescription(True, "Received", GridRefraction.GetRow.Cells("REFRACT_ID").Value) = 1 Then
                MessageBox.Show("Request is successful!", "Received", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadingFinding()
            End If
        End If
    End Sub

    Private Sub BtnRefreshListAprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshListAprove.Click
        ShowAllWaitingApprove()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ReportRefraction As New RefractionStatistic
        Dim TblRepRefraction As DataTable
        Dim ParaList As String = ""
        ' In case check prescription = true. it's mean for optical shop 
        If ChIsPrescriptOrRefraction.Checked = True Then
            If RadStatisticAll.Checked = True Then
                ParaList = "Prescription Statistic all"
                TblRepRefraction = DARefraction.SelectPrescrebtionStatus("Received", DStatisticFrom.Value.Date, DStatisticTo.Value.Date)
            ElseIf RadStatisticNew.Checked = True Then
                ParaList = "Prescription Statistic New"
                TblRepRefraction = DARefraction.SelectPrescriptionStatusOldOrNew("Received", DStatisticFrom.Value.Date, DStatisticTo.Value.Date, False)
            ElseIf RadStatistictOld.Checked = True Then
                ParaList = "Prescription Statistic Old"
                TblRepRefraction = DARefraction.SelectPrescriptionStatusOldOrNew("Received", DStatisticFrom.Value.Date, DStatisticTo.Value.Date, True)
            End If
        Else
            If RadStatisticAll.Checked = True Then
                ParaList = "Refraction Statistic all"
                TblRepRefraction = DARefraction.SelectRefractionDFromToDTo(DStatisticFrom.Value.Date, DStatisticTo.Value.Date)
            ElseIf RadStatisticNew.Checked = True Then
                ParaList = "Refraction Statistic New"
                TblRepRefraction = DARefraction.SelectIsDateToDateWithOldOrNew(DStatisticFrom.Value.Date, DStatisticTo.Value.Date, False)
            ElseIf RadStatistictOld.Checked = True Then
                ParaList = "Refraction Statistic Old"
                TblRepRefraction = DARefraction.SelectIsDateToDateWithOldOrNew(DStatisticFrom.Value.Date, DStatisticTo.Value.Date, True)
            End If
        End If

        ReportRefraction.SetDataSource(TblRepRefraction)
        Me.CrystalReportViewer1.ReportSource = ReportRefraction
        ReportRefraction.SetParameterValue("Title", "From:" & DStatisticFrom.Text & " To:" & DStatisticTo.Text)
        ReportRefraction.SetParameterValue("Title2", ParaList)
    End Sub
End Class
