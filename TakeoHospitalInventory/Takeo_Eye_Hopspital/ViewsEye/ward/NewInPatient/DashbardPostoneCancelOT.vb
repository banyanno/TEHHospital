Public Class DashbardPostoneCancelOT
    Dim DAPostpone As New DSWardWithOTTableAdapters.V_NewInpatientDetialLeaveTableAdapter

    
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If ChPrintPreview.Checked = True Then
            CrystalReportViewer1.Visible = True
            CrystalReportViewer1.Dock = DockStyle.Fill
            GridEXPostpone.Visible = False
            Dim CrvPostpone As New CrystalPostponeOT
            Dim tblPostpone As DataTable
            If ChDeleteRecord.Checked = True Then
                tblPostpone = DAPostpone.SelectAllWithCancelOrDelete(DateFrom.Value.Date, DateTo.Value.Date, True, True)
                CrvPostpone.SetDataSource(tblPostpone)
                CrvPostpone.SetParameterValue("DateToDate", "Deleted From:" & Format(DateFrom.Value.Date, "dd/MM/yyy") & " To:" & Format(DateTo.Value.Date, "dd/MM/yyyy"))
            Else
                tblPostpone = DAPostpone.SelectOTPostone(DateFrom.Value.Date, DateTo.Value.Date, True) 'DAPostpone.SelectAllWithCancelOrDelete(DateFrom.Value.Date, DateTo.Value.Date, True, False)
                CrvPostpone.SetDataSource(tblPostpone)
                CrvPostpone.SetParameterValue("DateToDate", "From:" & Format(DateFrom.Value.Date, "dd/MM/yyy") & " To:" & Format(DateTo.Value.Date, "dd/MM/yyyy"))
            End If

            
            CrystalReportViewer1.ReportSource = CrvPostpone
        Else
            CrystalReportViewer1.Visible = False
            CrystalReportViewer1.Dock = DockStyle.Fill
            GridEXPostpone.Visible = True
            GridEXPostpone.Dock = DockStyle.Fill
            If ChDeleteRecord.Checked = True Then
                GridEXPostpone.DataSource = DAPostpone.SelectAllWithCancelOrDelete(DateFrom.Value.Date, DateTo.Value.Date, True, True)
            Else
                GridEXPostpone.DataSource = DAPostpone.SelectOTPostone(DateFrom.Value.Date, DateTo.Value.Date, True)
            End If



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

    Private Sub BtnDeletePostone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletePostone.Click
        If GridEXPostpone.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete posptone?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ModNewInPatient.UpdateDeletePostonce(GridEXPostpone.GetRow.Cells("NewInPatientNo").Value, True) Then
                MessageBox.Show("Delete successfull!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnPrintPreview_Click(sender, e)
            Else
                MessageBox.Show("Delete un-successfull!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub UndoPostone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoPostone.Click
        If GridEXPostpone.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to undo posptone?", "Undo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ModNewInPatient.UpdateDeletePostonce(GridEXPostpone.GetRow.Cells("NewInPatientNo").Value, False) Then
                MessageBox.Show("Undo successfull!", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnPrintPreview_Click(sender, e)
            Else
                MessageBox.Show("Delete un-successfull!", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
