Public Class FormPrintApointmentStatistict
    Dim DAAppointStatistic As New DSConsultTableAdapters.CONSULING_APPOINTMENTTableAdapter
    Dim tblAppoint As DataTable
    Dim CrAppointState As New AppointmentStatistict
    Dim Title As String = ""
    Dim Field As String = ""
    
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If RadPatientAppointment.Checked = True Then
            If RadAllAppointment.Checked = True Then
                tblAppoint = DAAppointStatistic.SelectStatistictAppDateToDate(DFrom.Value.Date, DTo.Value.Date)
                Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
                Field = "Patient all appointment"
            ElseIf RadAllHavePhone.Checked = True Then
                tblAppoint = DAAppointStatistic.SelectStatistictAppDateToDateHavePhone(DFrom.Value.Date, DTo.Value.Date)
                Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
                Field = "Patient all appointment have phone"
            ElseIf RadAllDonthavephone.Checked = True Then
                tblAppoint = DAAppointStatistic.SelectStatistictAppDateToDateNoPhone(DFrom.Value.Date, DTo.Value.Date)
                Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
                Field = "Patient all appointment don't have phone"
            End If
        ElseIf RadCall.Checked = True Then
            If RadIsnotCall.Checked = True Then
                tblAppoint = DAAppointStatistic.SelectStatistictDateToDateWithCalledAndCome(DFrom.Value.Date, DTo.Value.Date, False, ChIsComeOrNotCome.Checked)
                Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
                If ChIsComeOrNotCome.Checked = True Then
                    Field = "Patient is not called and come"
                Else
                    Field = "Patient is not called and not come"
                End If
            ElseIf RadCall.Checked = True Then
                tblAppoint = DAAppointStatistic.SelectStatistictDateToDateWithCalledAndCome(DFrom.Value.Date, DTo.Value.Date, True, ChIsComeOrNotCome.Checked)
                Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
                If ChIsComeOrNotCome.Checked = True Then
                    Field = "Patient is called and come"
                Else
                    Field = "Patient is called and not come"
                End If

            End If
           
        ElseIf RadPatientCome.Checked = True Then
            If RadPatientComeOnApp.Checked = True Then
                tblAppoint = DAAppointStatistic.SelectStatistictDateToDateCome(DFrom.Value.Date, DTo.Value.Date)
                Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
                Field = "Patient is come"
            ElseIf RadPatientNotCome.Checked = True Then
                tblAppoint = DAAppointStatistic.SelectStatistictDateToDateNotCome(DFrom.Value.Date, DTo.Value.Date)
                Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
                Field = "Patient is not come"
            End If
        End If
        CrAppointState.SetDataSource(tblAppoint)
        CrvViewer.ReportSource = CrAppointState
        CrAppointState.SetParameterValue("Title", Title)
        CrAppointState.SetParameterValue("Field", Field)


    End Sub

    Private Sub RadPatientAppointment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientAppointment.CheckedChanged
        GbAllAppointment.Enabled = RadPatientAppointment.Checked
    End Sub

    Private Sub RadCall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCall.CheckedChanged
        GrCall.Enabled = RadCall.Checked
    End Sub


    Private Sub RadPatientCome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientCome.CheckedChanged
        GrCome.Enabled = RadPatientCome.Checked
    End Sub
End Class