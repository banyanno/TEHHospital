Public Class FormEnterDoctor
    Public saveSucc As Boolean = False
    Dim DoctorDataAdapter As New DSPharmacyTableAdapters.TblDoctorTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDoctor
            .DataSource = DoctorDataAdapter.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ModValidation.ValidateCombobox(CboDoctor, "doctor", ErrDiagnosis) = False Then
            Exit Sub
        Else
            'If CboDoctor.Text.Trim <> "" Then
            '    If ModDiagnosis.CheckNameDiagnosis(CboDiagnosis.Text) = 0 Then
            '        MsgBox("Daignosis not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
            '        CboDiagnosis.Focus()
            '        CboDiagnosis.SelectAll()
            '        Exit Sub
            '    End If
            'End If
            DIALOG_SAVE = MessageBox.Show("Do you realy want enter this diagnosis?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModNew_Outpatient.EnterPatientDoctor(lblNewPatientNo.Text, CboDoctor.Text) = 1 Then
                    MsgBox("Enter doctor successful.", MsgBoxStyle.Information, "Save")
                    saveSucc = True
                    Me.Close()
                Else
                    MsgBox("Error enter diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub
End Class