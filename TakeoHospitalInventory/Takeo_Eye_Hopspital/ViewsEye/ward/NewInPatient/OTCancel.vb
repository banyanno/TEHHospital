Public Class OTCancel
    Dim DA_Donater As New DSConsultTableAdapters.DONATIONTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDonateName
            .DataSource = DA_Donater.GetData
            .ValueMember = DA_Donater.GetData.Columns("DonationID").ColumnName
            .DisplayMember = DA_Donater.GetData.Columns("DonationName").ColumnName
            .SelectedIndex = -1
        End With

        With CboSurgeryName
            .DataSource = ModSurgeries.SelectSurgeries()
            .DisplayMember = "Surgeries"
            .ValueMember = "SID"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If RadDonate.Checked = True Then
            If ValidateCombobox(CboDonateName, "", ErrCancelOT) = False Then Exit Sub
        End If

        If ValidateCombobox(CboSurgeryName, "", ErrCancelOT) = False Then Exit Sub
        If ValidateDateField(DateCancel, "", ErrCancelOT) = False Then Exit Sub
        If MessageBox.Show("Do you want to update cancel OT?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If ModNewInPatient.UpdateOTWating(LblSaveOption.Text, 0) = 1 Then
                If ModNewInPatient.UpdateOTCancel(LblSaveOption.Text, CStr(IIf(RadCancel.Checked = True, "Cancel", "Postpone")), DateCancel.Value.Date, TxtNote.Text, True, CStr(IIf(RadDonate.Checked = True, CboDonateName.Text, RadPatientPaid.Text)), CboSurgeryName.Text, EmptyString(TxtReceiptNo.Text)) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub OTCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadPatientPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientPaid.CheckedChanged
        CboDonateName.Enabled = False
    End Sub

    Private Sub RadDonate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDonate.CheckedChanged
        CboDonateName.Enabled = True
    End Sub
End Class