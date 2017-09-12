Public Class FormPatientDischarged

    Sub LoadUndoPatient()
        GridUndoInPatient.DataSource = ModNewInPatient.SelectListPatientDischarged(TxtPatientNo.Text.Trim, ChDoctor.Checked, CboDoctor.Text, DateFrom.Value, DateTo.Value)
        ModCommon.NumberAllRowHeaderDataGrid(GridUndoInPatient)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If ChDoctor.Checked = True Then
            If ValidateCombobox(CboDoctor, "", ErrDischarge) = False Then Exit Sub
        End If
        Call LoadUndoPatient()
    End Sub

    Private Sub MUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUndo.Click
        Try
            If Me.GridUndoInPatient.Rows.Count > 0 Then
                Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridUndoInPatient)
                Dim NewInNo As String = GridUndoInPatient.Rows(Index).Cells(0).Value
                DIALOG_UPDATE = MessageBox.Show("Do you really want to undo discharged?", "Undo Discharged", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_UPDATE = DialogResult.Yes Then
                    If ModNewInPatient.UndoDischargedPatient(NewInNo, "NULL", "NULL") = 1 Then
                        MsgBox("Undo discharged inpatient successfully.", MsgBoxStyle.Information, "Undo Discharged")
                        LoadUndoPatient()
                    Else
                        MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub GridUndoInPatient_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridUndoInPatient.ColumnHeaderMouseClick
        ModCommon.NumberAllRowHeaderDataGrid(GridUndoInPatient)
    End Sub

    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click
        Dim DA_PLeave As New DSPaatientLeaveTableAdapters.VNewInLeavewWithTreatmentTableAdapter
        Dim TblLeave As DataTable = DA_PLeave.SelectPatientLeaveDateToDate(DateFrom.Value, DateTo.Value)
        Dim CReportPaitne As New CryReportPatientLeave
        CReportPaitne.SetDataSource(TblLeave)
        CrViewerLeave.ReportSource = CReportPaitne
        CReportPaitne.SetParameterValue("Title1", "Report Patients Leaved in Ward")
        CReportPaitne.SetParameterValue("Title2", "From: " & DateFrom.Text & " To: " & DateTo.Text)
    End Sub

    Private Sub FormPatientDischarged_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With CboDoctor
            .DataSource = ModDoctor.SelectDoctor()
            .ValueMember = "doctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub ChDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDoctor.CheckedChanged
        CboDoctor.SelectedIndex = -1
        CboDoctor.Enabled = ChDoctor.Checked
    End Sub

    Private Sub BtnFollowUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFollowUp.Click
        Dim DA_PLeave As New DSPaatientLeaveTableAdapters.VNewInLeavewWithTreatmentTableAdapter
        Dim TblLeave As DataTable
        If ChDoctor.Checked = True Then
            If ValidateCombobox(CboDoctor, "", ErrDischarge) = False Then Exit Sub
            TblLeave = DA_PLeave.SelectFollowUpInWardDoctor(DateFrom.Value, DateTo.Value, CboDoctor.Text)
        Else
            TblLeave = DA_PLeave.SelectPatientFollowupWard(DateFrom.Value, DateTo.Value)
        End If
        Dim CReportPaitne As New CryReportPatientLeave
        CReportPaitne.SetDataSource(TblLeave)
        CrViewerLeave.ReportSource = CReportPaitne
        CReportPaitne.SetParameterValue("Title1", "Report Patients Follow Up in Ward")
        CReportPaitne.SetParameterValue("Title2", "From: " & DateFrom.Text & " To: " & DateTo.Text)
    End Sub

    Private Sub BtnMenuCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuCall.Click

        If Me.GridUndoInPatient.Rows.Count > 0 Then
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridUndoInPatient)
            Dim NewInNo As String = GridUndoInPatient.Rows(Index).Cells("NewInPatientNo").Value
            Dim FCallPatient As New FormCalledPatient
            FCallPatient.LblIsUpdate.Text = NewInNo
         
            FCallPatient.TxtPatientNo.Text = GridUndoInPatient.Rows(Index).Cells("PatientNo").Value
            FCallPatient.TxtPatientName.Text = GridUndoInPatient.Rows(Index).Cells("NameKhmer").Value
            Try

                FCallPatient.TxtCallNoted.Text = GridUndoInPatient.Rows(Index).Cells("CALL_NOTED").Value
                FCallPatient.DateCalled.Value = GridUndoInPatient.Rows(Index).Cells("CALL_DATE").Value
            Catch ex As Exception

            End Try
            If FCallPatient.ShowDialog = Windows.Forms.DialogResult.OK Then
                Call LoadUndoPatient()
            End If
            'DIALOG_UPDATE = MessageBox.Show("Do you really want to upate called?", "Undo Discharged", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If DIALOG_UPDATE = DialogResult.Yes Then
            '    If ModNewInPatient.UndoDischargedPatient(NewInNo, "NULL", "NULL") = 1 Then
            '        MsgBox("Undo discharged inpatient successfully.", MsgBoxStyle.Information, "Undo Discharged")
            '        LoadUndoPatient()
            '    Else
            '        MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
            '    End If
            'End If
        End If
        
    End Sub
End Class