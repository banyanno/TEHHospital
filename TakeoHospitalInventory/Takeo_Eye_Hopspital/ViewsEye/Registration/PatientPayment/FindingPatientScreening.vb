Public Class FindingPatientScreening
    Dim DAPatientScreening As New DSDashboardPatientTableAdapters.IMP_TblPatientsScreeningTableAdapter
    Dim NewPayment As NewPatientPayment
    Sub New(ByVal NewPayment As NewPatientPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.NewPayment = NewPayment
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        'NewPayment.TxtNameEng.Text = ""
        'NewPayment.TxtNameKhmer.Text = ""
        'NewPayment.TxtAgePatient.Text = ""
        'NewPayment.CboSexPatien.Text = ""
        'NewPayment.TxtTel.Text = ""
        'NewPayment.CboOccupation.Text = ""
        'NewPayment.CboProNo.Text = ""
        'NewPayment.CboDisNo.Text = ""
        'NewPayment.CboCommNo.Text = ""
        'NewPayment.TxtAddress.Text = ""
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim TblPatientScreening As DataTable
        If RadByPatientNo.Checked = True Then
            If ValidateTextField(TxtPatientScreeningNo, "", ErrPatientScreening) = False Then Exit Sub
            TblPatientScreening = DAPatientScreening.FindByPatientNo(EmptyString(TxtPatientScreeningNo.Text))
            If TblPatientScreening.Rows.Count = 0 Then
                MessageBox.Show("Can not find patient no in screening book. Please check in screening book!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                GridPatientScreening.DataSource = TblPatientScreening
            End If
        ElseIf RadPatientNameEng.Checked = True Then
            If ValidateTextField(TxtPatientNameEng, "", ErrPatientScreening) = False Then Exit Sub
            TblPatientScreening = DAPatientScreening.FindByEngName(TxtPatientNameEng.Text)
            If TblPatientScreening.Rows.Count = 0 Then
                MessageBox.Show("Can not find patient no in screening book. Please check in screening book!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                GridPatientScreening.DataSource = TblPatientScreening
            End If
        ElseIf RadPatientNameKh.Checked = True Then
            If ValidateTextField(TxtPatientNameKh, "", ErrPatientScreening) = False Then Exit Sub
            TblPatientScreening = DAPatientScreening.FindByKhName(TxtPatientNameKh.Text)
            If TblPatientScreening.Rows.Count = 0 Then
                MessageBox.Show("Can not find patient no in screening book. Please check in screening book!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                GridPatientScreening.DataSource = TblPatientScreening
            End If
        ElseIf RadTel.Checked = True Then
            If ValidateTextField(TxtPatientTel, "", ErrPatientScreening) = False Then Exit Sub
            TblPatientScreening = DAPatientScreening.FindByTelephone(TxtPatientTel.Text)
            If TblPatientScreening.Rows.Count = 0 Then
                MessageBox.Show("Can not find patient no in screening book. Please check in screening book!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                GridPatientScreening.DataSource = TblPatientScreening
            End If
        End If
    End Sub
    Private Sub ViewPatientInfo(ByVal gridPatientScreening As Janus.Windows.GridEX.GridEX)
        'For Each drow As DataRow In TblPatientScreening.Rows
        NewPayment.TxtNameEng.Text = gridPatientScreening.GetRow.Cells("NameEng").Value
        NewPayment.TxtNameKhmer.Text = gridPatientScreening.GetRow.Cells("NameKhmer").Value
        NewPayment.TxtAgePatient.Text = gridPatientScreening.GetRow.Cells("Age").Value
        NewPayment.CboSexPatien.Text = gridPatientScreening.GetRow.Cells("Sex").Value
        NewPayment.TxtTel.Text = gridPatientScreening.GetRow.Cells("Telephone").Value
        NewPayment.CboOccupation.Text = gridPatientScreening.GetRow.Cells("Occupation").Value
        NewPayment.CboProNo.Text = gridPatientScreening.GetRow.Cells("Province").Value
        NewPayment.CboDisNo.Text = gridPatientScreening.GetRow.Cells("District").Value
        NewPayment.CboCommNo.Text = gridPatientScreening.GetRow.Cells("Commune").Value
        NewPayment.CboVillage.Text = gridPatientScreening.GetRow.Cells("Village").Value
        NewPayment.TxtAddress.Text = gridPatientScreening.GetRow.Cells("Address").Value
        ' Next
    End Sub
    Private Sub TxtPatientScreeningNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientScreeningNo.KeyPress
        SetDisableKeyString(e)
    End Sub

   
    

    Private Sub RadPatientNameEng_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientNameEng.CheckedChanged
        TxtPatientNameEng.Enabled = RadPatientNameEng.Checked
        TxtPatientNameEng.Focus()
        TxtPatientNameEng.SelectAll()
    End Sub

    Private Sub RadPatientNameKh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientNameKh.CheckedChanged
        TxtPatientNameKh.Enabled = RadPatientNameKh.Checked
        TxtPatientNameKh.Focus()
        TxtPatientNameKh.SelectAll()
    End Sub

    Private Sub RadTel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTel.CheckedChanged
        TxtPatientTel.Enabled = RadTel.Checked
        TxtPatientTel.Focus()
        TxtPatientTel.SelectAll()
    End Sub

    Private Sub RadByPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPatientNo.CheckedChanged
        TxtPatientScreeningNo.Enabled = RadByPatientNo.Checked
        TxtPatientScreeningNo.Focus()
        TxtPatientScreeningNo.SelectAll()
    End Sub

    Private Sub GridPatientScreening_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPatientScreening.RowDoubleClick
        If GridPatientScreening.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to add to TEH registration?", "Screening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ViewPatientInfo(Me.GridPatientScreening)
        End If

    End Sub
End Class