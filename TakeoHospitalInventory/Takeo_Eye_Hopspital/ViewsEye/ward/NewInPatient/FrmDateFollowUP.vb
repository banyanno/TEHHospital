Public Class FrmDateFollowUP

    Public isClose As Boolean = False
    Dim DA_PTrackingTime As New DataReportUtilityTableAdapters.PATIENT_TIMETRACKINGTableAdapter

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        isClose = False
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim DaFollowup As String
        Dim DrName As String
        If DateFollowUp.Checked = True Then

            If ValidateCombobox(CboDoctor, "", ErDateFollowUp) = False Then Exit Sub
            DaFollowup = "'" & Me.DateFollowUp.Value & "'"
            DrName = CboDoctor.Text

        Else
            DaFollowup = "NULL"
            DrName = "NULL"
        End If
        Dim dialogResult As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = Windows.Forms.DialogResult.Yes Then
            If ModNewInPatient.UpdateFollowUp(LblSaveOption.Text, LblDateLeave.Text, DaFollowup, DrName) = 1 Then
                DA_PTrackingTime.UpdateDISCHARGE(Format(Now, "hh:mm:ss tt").ToString, lblPatientNo.Text, CheckMarkEOD().Date)
                MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                isClose = True
                Me.Close()
            Else
                MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub FrmDateFollowUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LblDateLeave.Text = GeteDateServer()
        With CboDoctor
            .DataSource = ModDoctor.SelectDoctor()
            .ValueMember = "doctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub DateFollowUp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateFollowUp.ValueChanged
        If DateFollowUp.Checked = True Then
            CboDoctor.Enabled = True
            CboDoctor.SelectedIndex = -1
        Else
            CboDoctor.Enabled = False
            CboDoctor.SelectedIndex = -1
        End If
    End Sub
End Class