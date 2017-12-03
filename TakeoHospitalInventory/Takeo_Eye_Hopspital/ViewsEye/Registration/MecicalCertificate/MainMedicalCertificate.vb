Imports System
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.ReportSource
Public Class MainMedicalCertificate
    Dim DA_MecicalCertificate As New DSMedicalCertificateTableAdapters.V_MEDICAL_CERTIFICATETableAdapter
    Dim MainInventory As MainTakeoInventory
    Dim ValReport As Integer = 0
    Dim DA_Medical As New DSMedicalCertificateTableAdapters.MEDICAL_CERTIFICATETableAdapter
    Sub New(ByVal MainInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainInventory = MainInventory
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnDr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDr.Click
        Dim Dr As New DRMedical
        Dr.ShowDialog()
    End Sub

    Private Sub BtnNewMedicalCertificate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewMedicalCertificate.Click
        Dim NMedicalCertificate As New NewMedicalCertificate
        If NMedicalCertificate.ShowDialog() = DialogResult.OK Then
            BGLoadingData.RunWorkerAsync()
        End If
    End Sub


    Private Sub RefreshData()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf RefreshData))
        Else
            If ValReport = 1 Then

                Dim WReport As New ViewMedicalCertificat

                Dim RMedicalCertificate As New CRMedicalForm
                Dim TblMedical As DataTable = DA_MecicalCertificate.GetDataByMedicalID(GridMedicalCertificate.GetRow.Cells("MEDICAL_CID").Value)
                RMedicalCertificate.SetDataSource(TblMedical)

                ' RMedicalCertificate.PrintToPrinter(1, False, 1, 1)



                Dim CrExportOptionsBig As ExportOptions
                Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
                CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\PatientCertificate.pdf"
                CrExportOptionsBig = RMedicalCertificate.ExportOptions
                With CrExportOptionsBig
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptionsBig
                    .FormatOptions = CrFormatTypeOptionsBig
                End With

                RMedicalCertificate.Export()
                WReport.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\PatientCertificate.pdf"
                WReport.AxAcroPDF1.setZoom(100)
                WReport.ShowDialog()


            End If
            Try
                If TxtPatientNo.Text = "" Then
                    GridMedicalCertificate.DataSource = DA_MecicalCertificate.GetDataByDToD(DFrom.Value.Date, DateTo.Value.Date)
                    ValReport = 0
                Else
                    GridMedicalCertificate.DataSource = DA_MecicalCertificate.GetDataByDateAndPatientNo(DFrom.Value.Date, DateTo.Value.Date, TxtPatientNo.Text)
                    ValReport = 0
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
        End If

    End Sub


    Private Sub BGLoadingData_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadingData.DoWork
        RefreshData()
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BGLoadingData_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadingData.RunWorkerCompleted
        MainInventory.StatusLoading(False)
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        MainInventory.StatusLoading(True)
        BGLoadingData.RunWorkerAsync()
    End Sub

    Private Sub BtnRefesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefesh.Click
        BGLoadingData.RunWorkerAsync()
    End Sub

    Private Sub BtnMedicalCertificate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMedicalCertificate.Click
        If GridMedicalCertificate.SelectedItems.Count = 0 Then Exit Sub
        ValReport = 1
        MainInventory.StatusLoading(True)
        BGLoadingData.RunWorkerAsync()
    End Sub

    Private Sub GridMedicalCertificate_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridMedicalCertificate.RowDoubleClick
        Dim NMedicalCertificate As New NewMedicalCertificate
        NMedicalCertificate.LblSaveOption.Text = GridMedicalCertificate.GetRow.Cells("MEDICAL_CID").Value
        NMedicalCertificate.TxtPatientNo.Text = GridMedicalCertificate.GetRow.Cells("PatientNo").Value
        NMedicalCertificate.TxtPatientName.Text = GridMedicalCertificate.GetRow.Cells("NameKhmer").Value
        NMedicalCertificate.TxtPatientSex.Text = GridMedicalCertificate.GetRow.Cells("Sex").Value
        NMedicalCertificate.txtPatientAge.Text = GridMedicalCertificate.GetRow.Cells("Age").Value
        NMedicalCertificate.TxtPatientAddress.Text = GridMedicalCertificate.GetRow.Cells("Address").Value
        NMedicalCertificate.TxtPatientOccupation.Text = GridMedicalCertificate.GetRow.Cells("Occupation").Value
        NMedicalCertificate.DateExam.Checked = True
        NMedicalCertificate.DateExam.Value = GridMedicalCertificate.GetRow.Cells("DATE_EXAM").Value
        NMedicalCertificate.TxtSymtom.Text = GridMedicalCertificate.GetRow.Cells("SYMPTOM").Value
        NMedicalCertificate.TxtTREATMENT.Text = GridMedicalCertificate.GetRow.Cells("TREATMENT").Value
        NMedicalCertificate.TxtAdvice.Text = GridMedicalCertificate.GetRow.Cells("ADVICE").Value
        'If TypeOf (GridMedicalCertificate.GetRow.Cells("DATE_TREATMENT").Value) Is DBNull Then
        '    'Else
        '    '    NMedicalCertificate.DateSurgery.Checked = True
        '    '    NMedicalCertificate.DateSurgery.Value = GridMedicalCertificate.GetRow.Cells("DATE_TREATMENT").Value
        '    'End If
        '    'NMedicalCertificate.cboEye1.Text = GridMedicalCertificate.GetRow.Cells("EYE").Value
        '    'If TypeOf (GridMedicalCertificate.GetRow.Cells("ADVICE").Value) Is DBNull Then
        '    'Else
        '    '    NMedicalCertificate.DateAdvice.Checked = True
        '    '    NMedicalCertificate.DateAdvice.Text = GridMedicalCertificate.GetRow.Cells("ADVICE").Value
        '    'End If

        NMedicalCertificate.DatePrepare.Checked = True
        NMedicalCertificate.DatePrepare.Value = GridMedicalCertificate.GetRow.Cells("CREATE_DATE").Value
        NMedicalCertificate.CboDoctor.Text = GridMedicalCertificate.GetRow.Cells("DOCTOR").Value
        If NMedicalCertificate.ShowDialog = DialogResult.OK Then
            BGLoadingData.RunWorkerAsync()
        End If
    End Sub

  
    Private Sub BtnDeleted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleted.Click
        If GridMedicalCertificate.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Medical.IsDeleted(1, CInt(GridMedicalCertificate.GetRow.Cells("MEDICAL_CID").Value)) = 1 Then
                BtnView_Click(sender, e)
            End If
        End If
    End Sub
End Class
