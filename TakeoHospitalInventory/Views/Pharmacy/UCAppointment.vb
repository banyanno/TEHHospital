Public Class UCAppointment
    Dim DA_Appointment As New DSConsultTableAdapters.CONSULING_APPOINTMENTTableAdapter
    Private Sub BtnNewAppoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAppoint.Click
        Dim FNeApp As New NewAppointment
        If FNeApp.ShowDialog = DialogResult.OK Then
            GridAppointment.DataSource = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
        End If
    End Sub

    Private Sub BtnDisplayAppp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplayAppp.Click
        SplitContainer6.Panel2Collapsed = True
        SplitContainer6.Panel1Collapsed = False

        If ChByDoctor.Checked = True Then
            GridAppointment.DataSource = DA_Appointment.SelectAppDateToDateByDR(DateAFrom.Value.Date, DateATo.Value.Date, CInt(CboDoctor.SelectedValue))
        Else
            GridAppointment.DataSource = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
        End If

        If RadByDateCreate.Checked = True Then
            If ChByDoctor.Checked = True Then
                GridAppointment.DataSource = DA_Appointment.SelectAppDateToDateByDR(DateAFrom.Value.Date, DateATo.Value.Date, CInt(CboDoctor.SelectedValue))
            Else

                GridAppointment.DataSource = DA_Appointment.SelectDateCreate(DateAFrom.Value.Date, DateATo.Value.Date)

            End If

        Else
            If ChByDoctor.Checked = True Then
                GridAppointment.DataSource = DA_Appointment.SelectAppDateToDateByDR(DateAFrom.Value.Date, DateATo.Value.Date, CInt(CboDoctor.SelectedValue))
            Else
                GridAppointment.DataSource = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
            End If
            End If


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If GridAppointment.SelectedItems.Count = 0 Then Exit Sub
        Dim FNeApp As New NewAppointment
        FNeApp.LblSave.Text = GridAppointment.GetRow.Cells("APP_ID").Value
        FNeApp.TxtPatientNo.Text = GridAppointment.GetRow.Cells("PATIENT_NON").Value
        FNeApp.TxtPatientName.Text = GridAppointment.GetRow.Cells("PATIENT_NAME").Value
        FNeApp.TxtPatientSex.Text = GridAppointment.GetRow.Cells("PATIENT_SEX").Value
        FNeApp.TxtAge.Text = GridAppointment.GetRow.Cells("PATIENT_AGE").Value
        FNeApp.TxtNote.Text = GridAppointment.GetRow.Cells("APPIONT_NOTE").Value

        Try
            FNeApp.TxtTel.Text = GridAppointment.GetRow.Cells("PATIENT_TEL").Value
            FNeApp.CboDoctor.SelectedValue = GridAppointment.GetRow.Cells("DR_DI").Value
            FNeApp.CboDoctor.Text = GridAppointment.GetRow.Cells("DR_NAME").Value

        Catch ex As Exception

        End Try
        FNeApp.DateApp.Checked = True
        FNeApp.DateApp.Value = GridAppointment.GetRow.Cells("DATE_APPOINT").Value
        If FNeApp.ShowDialog = DialogResult.OK Then
            GridAppointment.DataSource = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
        End If
    End Sub

    Private Sub BtnReportApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReportApp.Click
        SplitContainer6.Panel2Collapsed = False
        SplitContainer6.Panel1Collapsed = True
        Dim CAppoint As New CRAppointment
        Dim TblApp As DataTable
     

        If ChByDoctor.Checked = True Then
            TblApp = DA_Appointment.SelectAppDateToDateByDR(DateAFrom.Value.Date, DateATo.Value.Date, CInt(CboDoctor.SelectedValue))
        Else
            TblApp = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
        End If

        If RadByDateCreate.Checked = True Then
            If ChByDoctor.Checked = True Then
                TblApp = DA_Appointment.SelectAppDateToDateByDR(DateAFrom.Value.Date, DateATo.Value.Date, CInt(CboDoctor.SelectedValue))
            Else

                TblApp = DA_Appointment.SelectDateCreate(DateAFrom.Value.Date, DateATo.Value.Date)

            End If

        Else
            If ChByDoctor.Checked = True Then
                TblApp = DA_Appointment.SelectAppDateToDateByDR(DateAFrom.Value.Date, DateATo.Value.Date, CInt(CboDoctor.SelectedValue))
            Else
                TblApp = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
            End If
        End If
        CAppoint.SetDataSource(TblApp)
        If RadByDateApp.Checked = True Then
            CAppoint.SetParameterValue("Title", "Select Date App From : " & DateAFrom.Text & " To :" & DateATo.Text)
        ElseIf RadByDateCreate.Checked = True Then
            CAppoint.SetParameterValue("Title", "Select Date Create App From : " & DateAFrom.Text & " To :" & DateATo.Text)
        End If

        CrystalApp.ReportSource = CAppoint
    End Sub

    Private Sub UpdateOnAppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateOnAppointmentToolStripMenuItem.Click
        If GridAppointment.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to update patient appointment on time?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Appointment.UpdateAppointOnorDelete(False, True, GridAppointment.GetRow.Cells("APP_ID").Value) = 1 Then
                GridAppointment.DataSource = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
            End If
        End If
    End Sub

    Private Sub DeleteAppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAppointmentToolStripMenuItem.Click
        If GridAppointment.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete appointment ?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Appointment.UpdateAppointOnorDelete(True, True, GridAppointment.GetRow.Cells("APP_ID").Value) = 1 Then
                GridAppointment.DataSource = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
            End If
        End If
    End Sub

    Private Sub GridAppointment_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAppointment.RowDoubleClick
        If GridAppointment.SelectedItems.Count = 0 Then Exit Sub
        Dim FNeApp As New NewAppointment
        FNeApp.LblSave.Text = GridAppointment.GetRow.Cells("APP_ID").Value
        FNeApp.TxtPatientNo.Text = GridAppointment.GetRow.Cells("PATIENT_NON").Value
        FNeApp.TxtPatientName.Text = GridAppointment.GetRow.Cells("PATIENT_NAME").Value
        FNeApp.TxtPatientSex.Text = GridAppointment.GetRow.Cells("PATIENT_SEX").Value
        FNeApp.TxtAge.Text = GridAppointment.GetRow.Cells("PATIENT_AGE").Value
        FNeApp.TxtNote.Text = GridAppointment.GetRow.Cells("APPIONT_NOTE").Value

        Try
            FNeApp.TxtTel.Text = GridAppointment.GetRow.Cells("PATIENT_TEL").Value
            FNeApp.CboDoctor.SelectedValue = GridAppointment.GetRow.Cells("DR_DI").Value
            FNeApp.CboDoctor.Text = GridAppointment.GetRow.Cells("DR_NAME").Value

        Catch ex As Exception

        End Try
        FNeApp.DateApp.Checked = True
        FNeApp.DateApp.Value = GridAppointment.GetRow.Cells("DATE_APPOINT").Value
        If FNeApp.ShowDialog = DialogResult.OK Then
            GridAppointment.DataSource = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
        End If
    End Sub

    Private Sub UCAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With CboDoctor
            .DataSource = ModDoctor.SelectDoctor()
            .ValueMember = "doctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub ChByDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChByDoctor.CheckedChanged

        CboDoctor.Enabled = ChByDoctor.Checked
        CboDoctor.SelectedIndex = -1

    End Sub

  
    Private Sub BtnCalled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalled.Click
        If GridAppointment.SelectedItems.Count = 0 Then Exit Sub
        Dim FUpdateCalled As New FormUpdateCalled
        FUpdateCalled.LblIsUpdate.Text = GridAppointment.GetRow.Cells("APP_ID").Value
        FUpdateCalled.TxtPatientNo.Text = GridAppointment.GetRow.Cells("PATIENT_NON").Value
        FUpdateCalled.TxtPatientName.Text = GridAppointment.GetRow.Cells("PATIENT_NAME").Value
        Try
            FUpdateCalled.DateCalled.Value = GridAppointment.GetRow.Cells("CALL_DATE").Value
            FUpdateCalled.TxtCallNoted.Text = GridAppointment.GetRow.Cells("CALL_NOTE").Value
        Catch ex As Exception

        End Try
        If FUpdateCalled.ShowDialog = DialogResult.OK Then
            GridAppointment.DataSource = DA_Appointment.SelectAppDate(DateAFrom.Value.Date, DateATo.Value.Date)
        End If
    End Sub
End Class
