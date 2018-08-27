Public Class WinReport
    Dim DA_Donater As New DSConsultTableAdapters.DONATIONTableAdapter
    Dim DA_Consulting As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim TblConsulting As DataTable
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With cboDonate
            .DataSource = DA_Donater.GetData
            .ValueMember = DA_Donater.GetData.Columns("DonationID").ColumnName
            .DisplayMember = DA_Donater.GetData.Columns("DonationName").ColumnName
            .SelectedIndex = -1
        End With
        With CboDoctor
            .DataSource = ModDoctor.SelectDoctor()
            .ValueMember = "doctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    
    

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If ChSelectDoctor.Checked = True Then
            If ValidateCombobox(CboDoctor, "", ErrReport) = False Then Exit Sub
        Else
            If ChViewAll.Checked = False Then
                If ValidateCombobox(cboDonate, "", ErrReport) = False Then Exit Sub
            End If
        End If

        MainForm.StatusLoading(True)
        BgLoadConsult.RunWorkerAsync()
    End Sub
    Private Sub ViewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ViewReport))
        Else
            If ChSelectDoctor.Checked = True Then
                TblConsulting = DA_Consulting.GetDataByDateToDateByDoctor(DFrom.Value.Date, DTo.Value.Date, 1, CBool(IIf(ChAccept.Checked = True, True, False)), CInt(CboDoctor.SelectedValue))
            Else
                If ChConsultCancel.Checked = False Then

                    If ChViewAll.Checked = True Then
                        If RadAllConsult.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateToDateStatus(DFrom.Value.Date, DTo.Value.Date, 1, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                        If RadForNewPatient.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                        If RadForOld.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                        If RadForInPatient.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                        If RadForOpticalShop.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                    Else
                        If RadAllConsult.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateToDateDonateStatus(DFrom.Value.Date, DTo.Value.Date, cboDonate.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                        If RadForNewPatient.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text, cboDonate.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                        If RadForOld.Checked = True Then

                            TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text, cboDonate.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                        If RadForInPatient.Checked = True Then

                            TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text, cboDonate.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                        If RadForOpticalShop.Checked = True Then

                            TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text, cboDonate.Text, 1, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                    End If
                Else

                    If ChViewAll.Checked = True Then
                        If RadAllConsult.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateToDateStatus(DFrom.Value.Date, DTo.Value.Date, 2, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                        If RadForNewPatient.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                        If RadForOld.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                        If RadForInPatient.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                        If RadForOpticalShop.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateTodateWithConsultStatus(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                    Else
                        If RadAllConsult.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateToDateDonateStatus(DFrom.Value.Date, DTo.Value.Date, cboDonate.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                        If RadForNewPatient.Checked = True Then
                            TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForNewPatient.Text, cboDonate.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))

                        End If
                        If RadForOld.Checked = True Then

                            TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForOld.Text, cboDonate.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                        If RadForInPatient.Checked = True Then

                            TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForInPatient.Text, cboDonate.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                        If RadForOpticalShop.Checked = True Then

                            TblConsulting = DA_Consulting.GetDataByDateToDateWithDonateStatus(DFrom.Value.Date, DTo.Value.Date, RadForOpticalShop.Text, cboDonate.Text, 2, CBool(IIf(ChAccept.Checked = True, True, False)))
                        End If
                    End If
                End If

            End If

        End If

    End Sub

    Private Sub BgLoadConsult_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadConsult.DoWork
        ViewReport()
    End Sub

    Private Sub BgLoadConsult_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadConsult.RunWorkerCompleted

        Dim RDailyConsulting As New CRDailyConsulting
        Dim RDialyConsultingVersion2 As New CRDailyConsultingV2
        Dim RDialyConsultDelete As New CRDailyConsultingDelete
        If RadV1.Checked = True Then
            If ChSelectDoctor.Checked = True Then
                If RadAllConsult.Checked = True Then

                    RDailyConsulting.SetDataSource(TblConsulting)

                    CrvConsulting.ReportSource = RDailyConsulting
                    RDailyConsulting.SetParameterValue("Title", "All Consult on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept") & " With " & CboDoctor.Text)
                End If

            Else
                If ChConsultCancel.Checked = False Then
                    RDailyConsulting.SetDataSource(TblConsulting)

                    CrvConsulting.ReportSource = RDailyConsulting

                    If ChViewAll.Checked = True Then

                        If RadAllConsult.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "All Consult on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                        If RadForNewPatient.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "Consult for (New Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOld.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "Consult for (Old Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForInPatient.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "Consult for (In-Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOpticalShop.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "Consult for (Optical Shop) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If


                    Else
                        If RadAllConsult.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "All Consult on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                        If RadForNewPatient.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "Consult for (New Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOld.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "Consult for (Old Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForInPatient.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "Consult for (In-Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOpticalShop.Checked = True Then
                            RDailyConsulting.SetParameterValue("Title", "Consult for (Optical Shop) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                    End If
                Else

                    RDialyConsultDelete.SetDataSource(TblConsulting)
                    CrvConsulting.ReportSource = RDialyConsultDelete
                    If ChViewAll.Checked = True Then

                        If RadAllConsult.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "All Consult that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                        If RadForNewPatient.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (New Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOld.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (Old Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForInPatient.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (In-Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOpticalShop.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (Optical Shop) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If


                    Else
                        If RadAllConsult.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "All Consult that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                        If RadForNewPatient.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (New Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOld.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (Old Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForInPatient.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (In-Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOpticalShop.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (Optical Shop) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                    End If
                End If


            End If
            ' ================== In case report version 2 ===================================================
        ElseIf RadV2.Checked = True Then
            If ChSelectDoctor.Checked = True Then
                If RadAllConsult.Checked = True Then

                    RDialyConsultingVersion2.SetDataSource(TblConsulting)

                    CrvConsulting.ReportSource = RDailyConsulting
                    RDialyConsultingVersion2.SetParameterValue("Title", "All Consult on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept") & " With " & CboDoctor.Text)
                End If

            Else
                If ChConsultCancel.Checked = False Then
                    RDialyConsultingVersion2.SetDataSource(TblConsulting)

                    CrvConsulting.ReportSource = RDialyConsultingVersion2

                    If ChViewAll.Checked = True Then

                        If RadAllConsult.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "All Consult on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                        If RadForNewPatient.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "Consult for (New Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOld.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "Consult for (Old Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForInPatient.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "Consult for (In-Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOpticalShop.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "Consult for (Optical Shop) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If


                    Else
                        If RadAllConsult.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "All Consult on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                        If RadForNewPatient.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "Consult for (New Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOld.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "Consult for (Old Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForInPatient.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "Consult for (In-Patient) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOpticalShop.Checked = True Then
                            RDialyConsultingVersion2.SetParameterValue("Title", "Consult for (Optical Shop) on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                    End If
                Else

                    RDialyConsultDelete.SetDataSource(TblConsulting)
                    CrvConsulting.ReportSource = RDialyConsultDelete
                    If ChViewAll.Checked = True Then

                        If RadAllConsult.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "All Consult that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                        If RadForNewPatient.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (New Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOld.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (Old Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForInPatient.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (In-Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOpticalShop.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (Optical Shop) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If


                    Else
                        If RadAllConsult.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "All Consult that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                        If RadForNewPatient.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (New Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOld.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (Old Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForInPatient.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (In-Patient) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If
                        If RadForOpticalShop.Checked = True Then
                            RDialyConsultDelete.SetParameterValue("Title", "Consult for (Optical Shop) that cancel on date from: " & Format(DFrom.Value.Date, "dd/MM/yyyy") & " To: " & Format(DTo.Value.Date, "dd/MM/yyyy") & " For " & cboDonate.Text & " " & IIf(ChAccept.Checked = True, "Accept", "Un Accept"))
                        End If

                    End If
                End If


            End If
        End If


        


        MainForm.StatusLoading(False)
    End Sub

    Private Sub ChViewAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChViewAll.CheckedChanged
        If ChViewAll.Checked = True Then
            cboDonate.Enabled = True
            cboDonate.SelectedIndex = -1


            ChSelectDoctor.Checked = False
            CboDoctor.Enabled = False
            CboDoctor.SelectedIndex = -1
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChSelectDoctor.CheckedChanged
        If ChSelectDoctor.Checked = True Then
            CboDoctor.Enabled = True
            CboDoctor.SelectedIndex = -1
            ChViewAll.Checked = False
            cboDonate.Enabled = False
        Else
            CboDoctor.Enabled = False
            CboDoctor.SelectedIndex = -1
        End If
    End Sub
End Class