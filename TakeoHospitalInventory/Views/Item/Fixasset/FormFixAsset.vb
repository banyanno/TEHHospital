Public Class FormFixAsset
    Dim DA_FixAsset As New DS_FIXASSETTableAdapters.FIX_ASSETTableAdapter
    Dim DA_Dep As New DS_FIXASSETTableAdapters.tblDepartmentTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDepartment
            .DataSource = DA_Dep.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DateBuy, "", ErrFixAsset) = False Then Exit Sub
        If ValidateCombobox(CboDepartment, "", ErrFixAsset) = False Then Exit Sub
        If ValidateTextField(TxtProductName, "", ErrFixAsset) = False Then Exit Sub
        If ValidateTextField(TxtProductCOde, "", ErrFixAsset) = False Then Exit Sub
        If ValidateTextField(TxtProductPrice, "", ErrFixAsset) = False Then Exit Sub
        If ValidateTextField(TxtBuyer, "", ErrFixAsset) = False Then Exit Sub

        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new fix asset?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_FixAsset.InsertNewAsset(CboDepartment.SelectedValue.ToString, CboDepartment.Text, DateBuy.Value.Date, TxtProductName.Text, TxtProductCOde.Text, EmptyString(TxtProductPrice.Text), TxtBuyer.Text, TxtNote.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update fix asset?", "update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_FixAsset.UpdateFixAsset(CboDepartment.SelectedValue.ToString, CboDepartment.Text, DateBuy.Value.Date, TxtProductName.Text, TxtProductCOde.Text, EmptyString(TxtProductPrice.Text), TxtBuyer.Text, TxtNote.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub TxtProductPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProductPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class