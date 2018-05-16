Public Class RefractionParameter
    Dim DARefDiagnosis As New DSRefractionTableAdapters.REFRACTION_DIAGNOSISTableAdapter
    Dim DARefGlasess As New DSRefractionTableAdapters.REFRACTION_GLASSESTableAdapter
    Dim DARefVA As New DSRefractionTableAdapters.REFRACTION_VATableAdapter
    Dim DARefAxis As New DSRefractionTableAdapters.REFRACTION_AXISTableAdapter
    Dim DARefVAReading As New DSRefractionTableAdapters.REFRACTION_VAREADINGTableAdapter
    Dim DAAdd As New DSRefractionTableAdapters.REFRACTION_ADDTableAdapter

    Private Sub RefractionParameter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshParameter()
    End Sub

    Private Sub RefreshParameter()
        GridDiagnosisRefraction.DataSource = DARefDiagnosis.GetData
        GridGlassesRefraction.DataSource = DARefGlasess.GetData
        GridVARefraction.DataSource = DARefVA.GetData
        GridAxis.DataSource = DARefAxis.GetData
        GridVAReading.DataSource = DARefVAReading.GetData
        GridADD.DataSource = DAAdd.GetData
    End Sub
    Private Sub RefreshDiagnosis()
        GridDiagnosisRefraction.DataSource = DARefDiagnosis.GetData
    End Sub
    Private Sub RefreshGlasess()
        GridGlassesRefraction.DataSource = DARefGlasess.GetData
    End Sub
    Private Sub RefreshVA()
        GridVARefraction.DataSource = DARefVA.GetData
    End Sub
    Private Sub RefreshAxis()
        GridAxis.DataSource = DARefAxis.GetData
    End Sub
    Private Sub RefreshVAReading()
        GridVAReading.DataSource = DARefVAReading.GetData
    End Sub
    Private Sub RefreshAdd()
        GridADD.DataSource = DAAdd.GetData
    End Sub

    Private Sub BtnNewDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewDiagnosis.Click
        Dim NewDiagnosis As New NewRefDiagnosis
        If NewDiagnosis.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshDiagnosis()
        End If
    End Sub
    
   

    Private Sub BtnDeleteDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteDiagnosis.Click
        If GridDiagnosisRefraction.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DARefDiagnosis.DeleteRefraction(GridDiagnosisRefraction.GetRow.Cells("REFRACT_DIAG_ID").Value) = 1 Then
                RefreshDiagnosis()
            End If
        End If
    End Sub

    Private Sub BtnRefreshDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshDiagnosis.Click
        RefreshDiagnosis()
    End Sub

    Private Sub BtnNewGlasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewGlasses.Click
        Dim FRefGlasses As New NewRefGlasses
        If FRefGlasses.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshGlasess()
        End If
    End Sub

    Private Sub BtnDeleteGlasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteGlasses.Click
        If GridGlassesRefraction.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DARefGlasess.DeleteRefraGlasses(GridGlassesRefraction.GetRow.Cells("REFRA_GLASSES_ID").Value) = 1 Then
                RefreshGlasess()
            End If
        End If
    End Sub

    Private Sub BtnRefreshGlasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshGlasses.Click
        RefreshGlasess()
    End Sub

    Private Sub BtnNewVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVA.Click
        Dim NewRefVA As New NewRefracVA
        If NewRefVA.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVA()
        End If
    End Sub

    Private Sub BtnDeleteVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteVA.Click
        If GridVARefraction.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DARefVA.DeleteRefraVa(GridVARefraction.GetRow.Cells("RFRA_VA_ID").Value) = 1 Then
                RefreshVA()
            End If
        End If
    End Sub

    Private Sub GridDiagnosisRefraction_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDiagnosisRefraction.RowDoubleClick
        If GridDiagnosisRefraction.SelectedItems.Count = 0 Then Exit Sub
        Dim UpdateDiagnosis As New NewRefDiagnosis
        UpdateDiagnosis.LblSaveOption.Text = GridDiagnosisRefraction.GetRow.Cells("REFRACT_DIAG_ID").Value
        UpdateDiagnosis.TxtDiagnosis.Text = GridDiagnosisRefraction.GetRow.Cells("REF_DIAGNOSIS").Value
        If UpdateDiagnosis.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshDiagnosis()
        End If
    End Sub

    Private Sub GridGlassesRefraction_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridGlassesRefraction.RowDoubleClick
        If GridGlassesRefraction.SelectedItems.Count = 0 Then Exit Sub
        Dim UpdateGlasses As New NewRefGlasses
        UpdateGlasses.LblSaveOption.Text = GridGlassesRefraction.GetRow.Cells("REFRA_GLASSES_ID").Value
        UpdateGlasses.TextBox1.Text = GridGlassesRefraction.GetRow.Cells("REFRA_GLASSES").Value
        If UpdateGlasses.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshGlasess()
        End If
    End Sub

    Private Sub GridVARefraction_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridVARefraction.RowDoubleClick
        If GridVARefraction.SelectedItems.Count = 0 Then Exit Sub
        Dim UpdateVA As New NewRefracVA
        UpdateVA.LblSaveOption.Text = GridVARefraction.GetRow.Cells("RFRA_VA_ID").Value
        UpdateVA.TextBox1.Text = GridVARefraction.GetRow.Cells("REFRA_VA").Value
        If UpdateVA.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVA()
        End If
    End Sub

    Private Sub BtnNewAxis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAxis.Click
        Dim NAxis As New NewAxisPara
        If NAxis.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshAxis()
        End If
    End Sub

    
    Private Sub BtnRefreshAxix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshAxix.Click
        RefreshAxis()
    End Sub

    Private Sub BtnDeleteAxix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteAxix.Click
        If GridAxis.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete Axis", "Axis", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DARefAxis.DeleteAxis(GridAxis.GetRow.Cells("AXIS_ID").Value) = 1 Then
                RefreshAxis()
            End If
        End If
    End Sub

    Private Sub GridAxis_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAxis.RowDoubleClick
        If GridAxis.SelectedItems.Count = 0 Then Exit Sub
        Dim UpdateAxis As New NewAxisPara
        UpdateAxis.LblSaveOption.Text = GridAxis.GetRow.Cells("AXIS_ID").Value
        UpdateAxis.TxtAxis.Text = GridAxis.GetRow.Cells("AXIS_NAME").Value
        If UpdateAxis.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshAxis()
        End If
    End Sub

    Private Sub BtnNewVAReading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVAReading.Click
        Dim NVAReading As New NewVAReading
        If NVAReading.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVAReading()
        End If
    End Sub

    Private Sub BtnRefreshVAreading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshVAreading.Click
        RefreshVAReading()
    End Sub

    Private Sub BtnDeleteReading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteReading.Click
        If GridVAReading.SelectedItems.Count = 0 Then Exit Sub
        If DARefVAReading.DeleteVAReading(GridVAReading.GetRow.Cells("VAREAD_ID").Value) = 1 Then
            RefreshVAReading()
        End If
    End Sub

    Private Sub GridVAReading_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridVAReading.RowDoubleClick
        If GridVAReading.SelectedItems.Count = 0 Then Exit Sub
        Dim UpdateVAReading As New NewVAReading
        UpdateVAReading.LblSaveOption.Text = GridVAReading.GetRow.Cells("VAREAD_ID").Value
        UpdateVAReading.TxtVAReading.Text = GridVAReading.GetRow.Cells("VAREADING").Value
        If UpdateVAReading.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVAReading()
        End If
    End Sub

    Private Sub BtnRefreshAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshAdd.Click
        RefreshAdd()

    End Sub

    Private Sub BtnNewADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewADD.Click
        Dim NAdd As New NewADDPara
        If NAdd.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshAdd()
        End If
    End Sub

    Private Sub BtnDeleteAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteAdd.Click
        If GridADD.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DAAdd.DeleteADD(GridADD.GetRow.Cells("ADD_ID").Value) = 1 Then
                RefreshAdd()
            End If
        End If
    End Sub

    Private Sub GridADD_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridADD.RowDoubleClick
        Dim NAdd As New NewADDPara
        NAdd.LblSaveOption.Text = GridADD.GetRow.Cells("ADD_ID").Value
        NAdd.TxtADD.Text = GridADD.GetRow.Cells("ADD_REFRACTION").Value
        If NAdd.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshAdd()
        End If
    End Sub

End Class