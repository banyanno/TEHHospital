Public Class FormPrintApointmentStatistict
    Dim DAAppointStatistic As New DSConsultTableAdapters.CONSULING_APPOINTMENTTableAdapter
    Dim tblAppoint As DataTable
    Dim CrAppointState As New AppointmentStatistict
    Dim Title As String = ""
    Dim Field As String = ""
    
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If RadPatientAppointment.Checked = True Then
            tblAppoint = DAAppointStatistic.SelectStatistictAppDateToDate(DFrom.Value.Date, DTo.Value.Date)
            Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
            Field = "Patient Appointment"
        ElseIf RadPatientCall.Checked = True Then
            tblAppoint = DAAppointStatistic.SelectStatistictDateToDateWithCalled(DFrom.Value.Date, DTo.Value.Date)
            Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
            Field = "Patient called"
        ElseIf RadPatientComeOnApp.Checked = True Then
            tblAppoint = DAAppointStatistic.SelectStatistictDateToDateCome(DFrom.Value.Date, DTo.Value.Date)
            Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
            Field = "Patient come on App"
        ElseIf RadPatientNotCome.Checked = True Then
            tblAppoint = DAAppointStatistic.SelectStatistictDateToDateNotCome(DFrom.Value.Date, DTo.Value.Date)
            Title = "From Date:" & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To:" & Format(DTo.Value.Date, "dd/MM/yyyy")
            Field = "Patient not come"
        End If
        CrAppointState.SetDataSource(tblAppoint)
        CrvViewer.ReportSource = CrAppointState
        CrAppointState.SetParameterValue("Title", Title)
        CrAppointState.SetParameterValue("Field", Field)


    End Sub
End Class