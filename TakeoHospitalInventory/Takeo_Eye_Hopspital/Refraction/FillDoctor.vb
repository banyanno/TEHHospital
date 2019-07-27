Public Class FillDoctor
    Dim DoctorDataAdapter As New DSPharmacyTableAdapters.TblDoctorTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDoctor
            .DataSource = DoctorDataAdapter.GetData(False)
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNo.Click
        Me.Close()
    End Sub

    Private Sub BtnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYes.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK 
    End Sub
End Class