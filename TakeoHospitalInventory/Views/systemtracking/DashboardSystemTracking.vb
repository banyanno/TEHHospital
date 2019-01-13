Public Class DashboardSystemTracking
    Dim DATracking As New DSSystemTrackingTableAdapters.SYSTEM_TRACKINGTableAdapter
    Dim TblSystemTracking As DataTable
    Dim CrTracking As New ReportSystemTracking
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        CrystallSystemtrack.Visible = False
        CrystallSystemtrack.Dock = DockStyle.Fill
        GridSystemTracking.Visible = True
        GridSystemTracking.Dock = DockStyle.Fill

        Dim FSystem As New FindingSystemTracking(Me)
        FSystem.BtnFind.Visible = True
        FSystem.BtnPritPreview1.Visible = False
        FSystem.Show()
    End Sub
    Public Sub FindDateTodate(ByVal DFrom As Date, ByVal DTo As Date)
        GridSystemTracking.DataSource = DATracking.SelectSystemTrackinngDateToDate(DFrom.Date, DTo.Date)
        TblSystemTracking = DATracking.SelectSystemTrackinngDateToDate(DFrom.Date, DTo.Date)
        CrTracking.SetDataSource(TblSystemTracking)
        CrystallSystemtrack.ReportSource = CrTracking
        CrTracking.SetParameterValue("DateToDate", "Date from:" & Format(DFrom, "dd/MM/yyyy") & " To:" & Format(DTo, "dd/MM/yyyy"))
    End Sub
    Public Sub FindDateToDateWithPatient(ByVal dFrom As Date, ByVal Dto As Date, ByVal PatientaNo As String)
        GridSystemTracking.DataSource = DATracking.SelectFilterDescription(dFrom.Date, Dto.Date, PatientaNo)
        TblSystemTracking = DATracking.SelectFilterDescription(dFrom.Date, Dto.Date, PatientaNo)
        CrTracking.SetDataSource(TblSystemTracking)
        CrystallSystemtrack.ReportSource = CrTracking
        CrTracking.SetParameterValue("DateToDate", "Date from:" & Format(dFrom, "dd/MM/yyyy") & " To:" & Format(Dto, "dd/MM/yyyy"))
    End Sub
    Public Sub FindDateToDateWithTrackingFrom(ByVal DFrom As Date, ByVal DTo As Date, ByVal TrackFrom As String)
        GridSystemTracking.DataSource = DATracking.SelectFilterFromTracking(DFrom.Date, DTo.Date, TrackFrom)
        TblSystemTracking = DATracking.SelectFilterFromTracking(DFrom.Date, DTo.Date, TrackFrom)
        CrTracking.SetDataSource(TblSystemTracking)
        CrystallSystemtrack.ReportSource = CrTracking
        CrTracking.SetParameterValue("DateToDate", "Date from:" & Format(DFrom, "dd/MM/yyyy") & " To:" & Format(DTo, "dd/MM/yyyy"))
    End Sub
    Public Sub FindDateToDateWithAction(ByVal DFrom As Date, ByVal DTo As Date, ByVal Action As String)
        GridSystemTracking.DataSource = DATracking.SelectFilterFromAction(DFrom.Date, DTo.Date, Action)
        TblSystemTracking = DATracking.SelectFilterFromAction(DFrom.Date, DTo.Date, Action)
        CrTracking.SetDataSource(TblSystemTracking)
        CrystallSystemtrack.ReportSource = CrTracking
        CrTracking.SetParameterValue("DateToDate", "Date from:" & Format(DFrom, "dd/MM/yyyy") & " To:" & Format(DTo, "dd/MM/yyyy"))

    End Sub

    Private Sub BtnRefreshHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshHistory.Click
        CrystallSystemtrack.Visible = True
        CrystallSystemtrack.Dock = DockStyle.Fill
        GridSystemTracking.Visible = False
        GridSystemTracking.Dock = DockStyle.None
        Dim FSystem As New FindingSystemTracking(Me)
        FSystem.BtnFind.Visible = False
        FSystem.BtnPritPreview1.Visible = True
        FSystem.Show()
    End Sub

End Class
