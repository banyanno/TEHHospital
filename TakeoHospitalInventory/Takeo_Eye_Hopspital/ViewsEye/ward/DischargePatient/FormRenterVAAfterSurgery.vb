Public Class FormRenterVAAfterSurgery
    Dim DARefVA As New DSRefractionTableAdapters.REFRACTION_VATableAdapter
    Dim tblConselling As DataTable
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshVA()
        With CboDrSurgeon
            .DataSource = ModDoctor.SelectDoctor()
            .ValueMember = "doctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
    End Sub
    Public Sub LoadingPatientInCounseling(ByVal PatientNo As String)
        tblConselling = ModNewInPatient.GetConsellingInfo(PatientNo)
        For Each rows As DataRow In tblConselling.Rows
            lblDateConselling.Text = Format(CDate(rows("CONSULING_DATE")), "dd-MM-yyyy") ' Format( rows("CONSULING_DATE").ToString,  "dd-mm-yyyy")
            lblConsellingNo.Text = rows("CONSULING_ID").ToString
        Next
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

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboDrSurgeon, "", ErrVASurgery) = False Then Exit Sub
        If ValidateCombobox(CboSurgeonOnEye, "", ErrVASurgery) = False Then Exit Sub
        If ValidateCombobox(CboVAPH, "", ErrVASurgery) = False Then Exit Sub
        If ValidateCombobox(CboVAPlain, "", ErrVASurgery) = False Then Exit Sub
        If MessageBox.Show("Do you want to update VA after surgeon?", "VA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ModNewInPatient.UpdateVAAfterSurgeon(LblSaveOption.Text, True, CboDrSurgeon.Text, CboSurgeonOnEye.Text, CboVAPlain.Text, CboVAPH.Text)
            ModNewInPatient.UpdateVACounsellingAfterOP(lblConsellingNo.Text, CboVAPlain.Text, CboVAPH.Text)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnNewVARefrac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVARefrac.Click
        Dim NewRefVA As New NewRefracVA
        If NewRefVA.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVA()
        End If
    End Sub
End Class