Public Class FrmDateFollowUP

    Public isClose As Boolean = False
    Dim DA_PTrackingTime As New DataReportUtilityTableAdapters.PATIENT_TIMETRACKINGTableAdapter
    Dim DARefVA As New DSRefractionTableAdapters.REFRACTION_VATableAdapter
    Dim tblConselling As DataTable
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        RefreshVA()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
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
        If chIsVASurgeon.Checked = True Then
            If ValidateCombobox(CboDrSurgeon, "", ErDateFollowUp) = False Then Exit Sub
            If ValidateCombobox(CboSurgeonOnEye, "", ErDateFollowUp) = False Then Exit Sub
            'If ValidateCombobox(CboVAPH, "", ErDateFollowUp) = False Then Exit Sub
            'If ValidateCombobox(CboVAPlain, "", ErDateFollowUp) = False Then Exit Sub
        End If
        Dim dialogResult As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = Windows.Forms.DialogResult.Yes Then
            If ModNewInPatient.UpdateFollowUp(LblSaveOption.Text, LblDateLeave.Text, DaFollowup, DrName) = 1 Then
                DA_PTrackingTime.UpdateDISCHARGE(Format(Now, "hh:mm:ss tt").ToString, lblPatientNo.Text, CheckMarkEOD().Date)
                If chIsVASurgeon.Checked = True Then
                    ModNewInPatient.UpdateVAAfterSurgeon(LblSaveOption.Text, chIsVASurgeon.Checked, CboDrSurgeon.Text, CboSurgeonOnEye.Text, CboVAPlain.Text, CboVAPH.Text)
                    ModNewInPatient.UpdateVAConselling(lblConsellingNo.Text, CboVAPlain.Text, CboVAPH.Text)
                End If
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
        With CboDrSurgeon
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

    Private Sub BtnNewVARefrac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVARefrac.Click
        Dim NewRefVA As New NewRefracVA
        If NewRefVA.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVA()
        End If
    End Sub

    Private Sub RefreshVA()

        With CboVAPlain
            .DataSource = DARefVA.GetData
            .ValueMember = "RFRA_VA_ID"
            .DisplayMember = "REFRA_VA"
            .SelectedIndex = -1
        End With
        With CboVAPH
            .DataSource = DARefVA.GetData
            .ValueMember = "RFRA_VA_ID"
            .DisplayMember = "REFRA_VA"
            .SelectedIndex = -1
        End With


    End Sub


    Private Sub chIsSurgeon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chIsVASurgeon.CheckedChanged
        GroupVASurgeon.Enabled = chIsVASurgeon.Checked
        If chIsVASurgeon.Checked = True Then
            tblConselling = ModNewInPatient.GetConsellingInfo(lblPatientNo.Text)
            For Each rows As DataRow In tblConselling.Rows
                lblDateConselling.Text = Format(CDate(rows("CONSULING_DATE")), "dd-MM-yyyy") ' Format( rows("CONSULING_DATE").ToString,  "dd-mm-yyyy")
                lblConsellingNo.Text = rows("CONSULING_ID").ToString
            Next
        Else
            lblDateConselling.Text = ""
            lblConsellingNo.Text = ""
        End If
    End Sub
End Class