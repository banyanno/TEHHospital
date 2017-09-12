Public Class DashbardPostoneCancelOT
    Dim DAPostpone As New DSWardWithOTTableAdapters.V_NewInpatientDetialLeaveTableAdapter

    
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If ChPrintPreview.Checked = True Then
            CrystalReportViewer1.Visible = True
            CrystalReportViewer1.Dock = DockStyle.Fill
            GridEXPostpone.Visible = False
            Dim CrvPostpone As New CrystalPostponeOT
            Dim tblPostpone As DataTable = DAPostpone.SelectOTPostone(DateFrom.Value.Date, DateTo.Value.Date, True)
            CrvPostpone.SetDataSource(tblPostpone)
            CrvPostpone.SetParameterValue("DateToDate", "From:" & Format(DateFrom.Value.Date, "dd/MM/yyy") & " To:" & Format(DateTo.Value.Date, "dd/MM/yyyy"))
            CrystalReportViewer1.ReportSource = CrvPostpone
        Else
            CrystalReportViewer1.Visible = False
            CrystalReportViewer1.Dock = DockStyle.Fill
            GridEXPostpone.Visible = True
            GridEXPostpone.Dock = DockStyle.Fill
            GridEXPostpone.DataSource = DAPostpone.SelectOTPostone(DateFrom.Value.Date, DateTo.Value.Date, True)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateCall.Click
        If GridEXPostpone.SelectedItems.Count = 0 Then Exit Sub
        Dim FupdateCall As New UpdateCall
        FupdateCall.LblSaveOption.Text = GridEXPostpone.GetRow.Cells("NewInPatientNo").Value
        FupdateCall.TxtNote.Text = GridEXPostpone.GetRow.Cells("OTCANCEL_NOTE").Value
        If FupdateCall.ShowDialog = DialogResult.OK Then
            BtnPrintPreview_Click(sender, e)
        End If
    End Sub
End Class
