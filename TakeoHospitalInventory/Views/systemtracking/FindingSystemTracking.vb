Public Class FindingSystemTracking
    Dim DSSystemTracking As DashboardSystemTracking
    Sub New(ByVal DSSystemTracking As DashboardSystemTracking)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DSSystemTracking = DSSystemTracking
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If RadByPatient.Checked = True Then
            DSSystemTracking.FindDateToDateWithPatient(DateFrom.Value.Date, DateTo.Value.Date, TxtPatientNo.Text)
        ElseIf RadByTrackingFrom.Checked = True Then
            DSSystemTracking.FindDateToDateWithTrackingFrom(DateFrom.Value.Date, DateTo.Value.Date, TxtTrackingFrom.Text)
        ElseIf RadByAction.Checked = True Then
            DSSystemTracking.FindDateToDateWithAction(DateFrom.Value.Date, DateTo.Value.Date, txtAction.Text)
        ElseIf RadDescription.Checked = True Then
            DSSystemTracking.FindDateToDateWithPatient(DateFrom.Value.Date, DateTo.Value.Date, TxtDescription.Text)
        Else
            DSSystemTracking.FindDateTodate(DateFrom.Value.Date, DateTo.Value.Date)
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnPritPreview1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPritPreview1.Click
        If RadByPatient.Checked = True Then
            DSSystemTracking.FindDateToDateWithPatient(DateFrom.Value.Date, DateTo.Value.Date, TxtPatientNo.Text)
        ElseIf RadByTrackingFrom.Checked = True Then
            DSSystemTracking.FindDateToDateWithTrackingFrom(DateFrom.Value.Date, DateTo.Value.Date, TxtTrackingFrom.Text)
        ElseIf RadByAction.Checked = True Then
            DSSystemTracking.FindDateToDateWithAction(DateFrom.Value.Date, DateTo.Value.Date, txtAction.Text)
        ElseIf RadDescription.Checked = True Then
            DSSystemTracking.FindDateToDateWithPatient(DateFrom.Value.Date, DateTo.Value.Date, TxtDescription.Text)
        Else
            DSSystemTracking.FindDateTodate(DateFrom.Value.Date, DateTo.Value.Date)
        End If
    End Sub
End Class