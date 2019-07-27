Public Class DashboardAdress
    Dim DAProvince As New DSAddressTableAdapters.TBL_PROVINCETableAdapter
    Dim DADistrict As New DSAddressTableAdapters.TBL_DISTRICTTableAdapter
    Dim DACommune As New DSAddressTableAdapters.TBL_COMMUNETableAdapter
    Dim DAVillage As New DSAddressTableAdapters.TBL_VILLAGETableAdapter
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshProvince()
    End Sub
    Private Sub RefreshProvince()
        GridProvince.DataSource = DAProvince.GetData
    End Sub
    Private Sub RefreshDistrict(ByVal ProvinceID As Int16)
        GridDistrict.DataSource = DADistrict.SelectDistrictByProvince(ProvinceID)
    End Sub
    Private Sub RefreshCommune(ByVal DistrictID As Integer)
        GridCommune.DataSource = DACommune.SelectCommuneByDistrict(DistrictID)
    End Sub
    Private Sub RefreshVillage(ByVal CommuneID As Integer)
        GridVillage.DataSource = DAVillage.SelectVillageByCOMMUNEID(CommuneID)
    End Sub

    Private Sub GridProvince_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridProvince.SelectionChanged
        If GridProvince.SelectedItems.Count = 0 Then
            GridDistrict.DataSource = Nothing
        Else
            RefreshDistrict(GridProvince.GetRow.Cells("PROVINCEID").Value)
        End If

    End Sub

    Private Sub GridDistrict_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDistrict.SelectionChanged
        If GridDistrict.SelectedItems.Count = 0 Then
            GridCommune.DataSource = Nothing
        Else
            RefreshCommune(GridDistrict.GetRow.Cells("DISTRICTID").Value)
        End If


    End Sub

    Private Sub GridCommune_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCommune.SelectionChanged
        If GridCommune.SelectedItems.Count = 0 Then
            GridVillage.DataSource = Nothing
        Else
            RefreshVillage(GridCommune.GetRow.Cells("COMMUNEID").Value)
        End If
    End Sub

    Private Sub ProvinceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProvinceToolStripMenuItem.Click
        Dim FProvince As New FormProvince
        If FProvince.ShowDialog() = DialogResult.OK Then
            RefreshProvince()
        End If
    End Sub

    Private Sub DistrictToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictToolStripMenuItem.Click
        If GridProvince.SelectedItems.Count = 0 Then Exit Sub
        Dim FDistrict As New FormDistrict
        FDistrict.LblProvince.Text = GridProvince.GetRow.Cells("PROVINCEID").Value
        If FDistrict.ShowDialog() = DialogResult.OK Then
            RefreshDistrict(FDistrict.LblProvince.Text)
        End If

    End Sub

    Private Sub CommuneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommuneToolStripMenuItem.Click
        If GridDistrict.SelectedItems.Count = 0 Then Exit Sub
        Dim FCommune As New FormCommune
        FCommune.LblDistrict.Text = GridDistrict.GetRow.Cells("DISTRICTID").Value
        If FCommune.ShowDialog = DialogResult.OK Then
            RefreshCommune(FCommune.LblDistrict.Text)
        End If
    End Sub

    Private Sub VillageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VillageToolStripMenuItem.Click
        If GridCommune.SelectedItems.Count = 0 Then Exit Sub
        Dim FVillage As New FormVillage
        FVillage.LblCommune.Text = GridCommune.GetRow.Cells("COMMUNEID").Value
        If FVillage.ShowDialog = DialogResult.OK Then
            RefreshVillage(FVillage.LblCommune.Text)
        End If
    End Sub

    Private Sub GridProvince_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridProvince.RowDoubleClick
        Dim FProvince As New FormProvince
        FProvince.LblSaveOption.Text = GridProvince.GetRow.Cells("PROVINCEID").Value
        FProvince.TxtValueAddres.Text = GridProvince.GetRow.Cells("PROV_EN").Value
        If FProvince.ShowDialog() = DialogResult.OK Then
            RefreshProvince()
        End If
    End Sub

    Private Sub GridDistrict_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDistrict.RowDoubleClick
        If GridProvince.SelectedItems.Count = 0 Then Exit Sub
        Dim FDistrict As New FormDistrict
        FDistrict.LblSaveOption.Text = GridDistrict.GetRow.Cells("DISTRICTID").Value
        FDistrict.TxtValueAddres.Text = GridDistrict.GetRow.Cells("DIST_EN").Value
        If FDistrict.ShowDialog() = DialogResult.OK Then
            RefreshDistrict(GridProvince.GetRow.Cells("PROVINCEID").Value)
        End If
    End Sub

    Private Sub GridCommune_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridCommune.RowDoubleClick
        If GridDistrict.SelectedItems.Count = 0 Then Exit Sub
        Dim FCommune As New FormCommune
        FCommune.LblSaveOption.Text = GridCommune.GetRow.Cells("COMMUNEID").Value
        FCommune.TxtValueAddres.Text = GridCommune.GetRow.Cells("COMM_EN").Value
        If FCommune.ShowDialog = DialogResult.OK Then
            RefreshCommune(GridDistrict.GetRow.Cells("DISTRICTID").Value)
        End If
    End Sub

    Private Sub GridVillage_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridVillage.RowDoubleClick
        If GridCommune.SelectedItems.Count = 0 Then Exit Sub
        Dim FVillage As New FormVillage
        FVillage.LblSaveOption.Text = GridVillage.GetRow.Cells("VILLAGEID").Value
        FVillage.TxtValueAddres.Text = GridVillage.GetRow.Cells("VILL_EN").Value
        If FVillage.ShowDialog = DialogResult.OK Then
            RefreshVillage(GridCommune.GetRow.Cells("COMMUNEID").Value)
        End If
    End Sub
End Class
