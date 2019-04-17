Public Class ForRelativeFamily
    Dim DAFamily As New DSConsultTableAdapters.FAMILY_RELATIVETableAdapter
    Private Sub BtnNewFamily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewFamily.Click
        Dim FNewFamilyRelative As New AddNewFamilyRelative
        If FNewFamilyRelative.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshFamily()
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshFamily()
    End Sub
    Private Sub RefreshFamily()
        GridFamilyRelative.DataSource = DAFamily.GetData
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridFamilyRelative.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DAFamily.DeleteFamily(GridFamilyRelative.GetRow.Cells("FAMILY_RELATIVE_ID").Value) = 1 Then
                RefreshFamily()
            End If
        End If
    End Sub

    Private Sub GridFamilyRelative_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFamilyRelative.RowDoubleClick
        If GridFamilyRelative.SelectedItems.Count = 0 Then Exit Sub
        Dim FormFamilyRelative As New AddNewFamilyRelative
        FormFamilyRelative.lblFamilyID.Text = GridFamilyRelative.GetRow.Cells("FAMILY_RELATIVE_ID").Value
        FormFamilyRelative.TxtFamilyRelative.Text = GridFamilyRelative.GetRow.Cells("FAMILY_RELATIVE").Value
        If FormFamilyRelative.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshFamily()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ForRelativeFamily_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshFamily()
    End Sub
End Class