Public Class CheckCunselling
    Dim ConViewer As Integer = 0
    Dim TblConsulting As DataTable
    Dim DA_Consulting As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        'MEyeInventory.StatusLoading(True)

        'If RadAllConsult.Checked = True Then
        '    ConViewer = 3
        'ElseIf RadForNewPatient.Checked = True Then
        '    ConViewer = 1
        'ElseIf RadForOld.Checked = True Then
        '    ConViewer = 1
        'ElseIf RadForInPatient.Checked = True Then
        '    ConViewer = 1
        'ElseIf RadForOpticalShop.Checked = True Then
        '    ConViewer = 1
        'End If


        'BgLoadConsult.RunWorkerAsync()
        GridConsulting.DataSource = DA_Consulting.SelectNotYetCompleteWithDep(DFrom.Value.Date, DTo.Value.Date, 0, CType(IIf(RadForInPatient.Checked = True, RadForInPatient.Text, RadForOpticalShop.Text), String))
    End Sub

    Private Sub BgLoadConsult_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadConsult.DoWork
        ViewReport()
    End Sub
    Private Sub ViewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ViewReport))
        Else
            If ConViewer = 1 Then
                If RadAllConsult.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDate(DFrom.Value.Date, DTo.Value.Date)
                End If
                If RadForNewPatient.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDateWithConsult(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text)

                End If
                If RadForOld.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDateWithConsult(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text)

                End If
                If RadForInPatient.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDateWithConsult(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text)

                End If
                If RadForOpticalShop.Checked = True Then
                    TblConsulting = DA_Consulting.GetDataByDateToDateWithConsult(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text)

                End If
            ElseIf ConViewer = 2 Then
                TblConsulting = DA_Consulting.GetDataByConsultID(GridConsulting.GetRow.Cells("CONSULING_ID").Value)
            ElseIf ConViewer = 3 Then
                FindingConsult()
            End If
        End If
    End Sub
    Private Sub FindingConsult()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf FindingConsult))
        Else
            If TxtPatientNo.Text = "" Then
                'Find consulting by date:
                TblConsulting = DA_Consulting.GetDataByDateToDate(DFrom.Value.Date, DTo.Value.Date)
            Else
                TblConsulting = DA_Consulting.GetDataByDateToDateWithPNo(TxtPatientNo.Text, DFrom.Value.Date, DTo.Value.Date)
            End If
        End If
    End Sub
    Public Sub BtnWaitingConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWaitingConsult.Click
        GridConsulting.DataSource = DA_Consulting.SelectNotYetCompleteWithDep(DFrom.Value.Date, DTo.Value.Date, 0, CType(IIf(RadForInPatient.Checked = True, RadForInPatient.Text, RadForOpticalShop.Text), String)) 'DA_Consulting.SelectStatusWaitingAndConcel(DFrom.Value.Date, DTo.Value, 0)
    End Sub

    Private Sub BtnAccepcounselling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccepcounselling.Click
        GridConsulting.DataSource = DA_Consulting.SelectNotAcceptConsult(DFrom.Value.Date, DTo.Value, False)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        GridConsulting.DataSource = DA_Consulting.SelectStatusWaitingAndConcel(DFrom.Value.Date, DTo.Value, 2)
    End Sub

    Private Sub BgLoadConsult_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadConsult.RunWorkerCompleted
        GridConsulting.DataSource = TblConsulting
    End Sub
End Class