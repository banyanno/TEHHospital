Public Class UCDiagnosisAndSurgeries

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        GridMainDiagnosis.DataSource = ModDiagnosis.SelectMainDiagnosis(TxtFindDiagnosis.Text)
        ModCommon.NumberAllRowHeaderDataGrid(GridMainDiagnosis)
    End Sub

    Private Sub BtnDiagosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewDiagosis.Click
        Dim frmDiagnosis As New FrmMainDiagnosis
        frmDiagnosis.ShowDialog()
        If frmDiagnosis.isDiagClose = True Then
            LoadDiagnosis(frmDiagnosis.TxtDiagnosis.Text)
        End If
        frmDiagnosis.Dispose()
        frmDiagnosis.Close()
    End Sub
    Sub LoadDiagnosis(ByVal Diagnosis As String)
        GridMainDiagnosis.DataSource = ModDiagnosis.SelectMainDiagnosis(Diagnosis)
        ModCommon.NumberAllRowHeaderDataGrid(GridMainDiagnosis)
    End Sub

    Private Sub CreateSubDiagToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateSubDiagToolStripMenuItem.Click
        Try
            Dim rowIndex As Integer = GridMainDiagnosis.SelectedCells(0).RowIndex
            Dim frmSubDiagnosis As New FRMDiagnosis
            frmSubDiagnosis.LblMainDiagID.Text = GridMainDiagnosis.Rows(rowIndex).Cells(0).Value
            frmSubDiagnosis.ShowDialog()
            If frmSubDiagnosis.DialogResult = DialogResult.OK Then
                GridSubDiagnosis.DataSource = ModDiagnosis.SelectSubDiagnosis(frmSubDiagnosis.LblMainDiagID.Text)
            End If
        Catch ex As Exception
            MsgBox("Please select main diagnosis.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub GridMainDiagnosis_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMainDiagnosis.SelectionChanged
        Try
            Dim rowIndex As Integer = GridMainDiagnosis.SelectedCells(0).RowIndex
            GridSubDiagnosis.DataSource = ModDiagnosis.SelectSubDiagnosis(GridMainDiagnosis.Rows(rowIndex).Cells(0).Value)
            ModCommon.NumberAllRowHeaderDataGrid(GridSubDiagnosis)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridMainDiagnosis_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridMainDiagnosis.CellDoubleClick
        Try
            Dim fMainDiagnosis As New FrmMainDiagnosis
            fMainDiagnosis.LblSaveOption.Text = GridMainDiagnosis.Rows(e.RowIndex).Cells(0).Value
            fMainDiagnosis.TxtDiagnosis.Text = GridMainDiagnosis.Rows(e.RowIndex).Cells(1).Value
            fMainDiagnosis.TxtCode.Text = GridMainDiagnosis.Rows(e.RowIndex).Cells(3).Value
            fMainDiagnosis.TxtDescription.Text = GridMainDiagnosis.Rows(e.RowIndex).Cells(2).Value
            fMainDiagnosis.ChTypeOther.Checked = GridMainDiagnosis.Rows(e.RowIndex).Cells(4).Value
            fMainDiagnosis.ShowDialog()
            If fMainDiagnosis.isDiagClose = True Then
                LoadDiagnosis("")
            End If
            fMainDiagnosis.Dispose()
            fMainDiagnosis.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridSubDiagnosis_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridSubDiagnosis.CellDoubleClick
        Try
            Dim fSubDiagnosis As New FRMDiagnosis
            fSubDiagnosis.LblSaveOption.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(0).Value
            fSubDiagnosis.LblMainDiagID.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(1).Value
            fSubDiagnosis.txtDiagnosis.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(2).Value
            fSubDiagnosis.txtDescription.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(3).Value
            fSubDiagnosis.TxtCode.Text = GridSubDiagnosis.Rows(e.RowIndex).Cells(4).Value
            fSubDiagnosis.ShowDialog()
            If fSubDiagnosis.DialogResult = DialogResult.OK Then
                GridSubDiagnosis.DataSource = ModDiagnosis.SelectSubDiagnosis(fSubDiagnosis.LblMainDiagID.Text)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DeleteDiagnosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteDiagnosisToolStripMenuItem.Click
        Try
            Dim rowIndex As Integer = GridMainDiagnosis.SelectedCells(0).RowIndex
            Dim DiagnosisNo As String = GridMainDiagnosis.Rows(rowIndex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModDiagnosis.DeleteMainDiagnosis(DiagnosisNo) = 1 Then
                    LoadDiagnosis("")
                Else
                    MsgBox("Error delete diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteSubDiagnosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSubDiagnosisToolStripMenuItem.Click
        Try
            Dim rowIndex As Integer = GridSubDiagnosis.SelectedCells(0).RowIndex
            Dim subDiagnosisNo As String = GridSubDiagnosis.Rows(rowIndex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModDiagnosis.DeleteSubDiagnosisBySSID(subDiagnosisNo) = 1 Then
                    MsgBox("Delete sub diagnosis successfully.", MsgBoxStyle.Information, "Delete")
                Else
                    MsgBox("Error delete sub diagnosis.", MsgBoxStyle.Critical, "Error")
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnFindSurgeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindSurgeries.Click
        GridSurgeries.DataSource = ModSurgeries.SelectSurgeriesByType(TxtSurgeries.Text)
        ModCommon.NumberAllRowHeaderDataGrid(GridSurgeries)
    End Sub

    Private Sub BtnNewSurgeries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewSurgeries.Click
        Dim FSurgeries As New FRMSurgeryType
        FSurgeries.ShowDialog()
        If FSurgeries.isSurgClose = True Then
            LoadSurgeries(FSurgeries.TxtSurgeriesType.Text)
        End If
        FSurgeries.Dispose()
        FSurgeries.Close()
    End Sub
    Sub LoadSurgeries(ByVal Surgeries As String)
        GridSurgeries.DataSource = ModSurgeries.SelectSurgeriesByType(Surgeries)
        ModCommon.NumberAllRowHeaderDataGrid(GridSurgeries)
    End Sub

    Private Sub GridSurgeries_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridSurgeries.CellDoubleClick
        'Try
        Dim FSurgeries As New FRMSurgeryType
        FSurgeries.LblSaveOption.Text = GridSurgeries.Rows(e.RowIndex).Cells("TypeSID").Value
        FSurgeries.TxtSurgeriesType.Text = GridSurgeries.Rows(e.RowIndex).Cells("Surgeries").Value
        FSurgeries.TxtDescription.Text = GridSurgeries.Rows(e.RowIndex).Cells("SurgDescription").Value
        If TypeOf GridSurgeries.Rows(e.RowIndex).Cells("SurgeriesFee").Value Is DBNull Then
            FSurgeries.TxtSurgeryPrice.Text = 0
        Else
            FSurgeries.TxtSurgeryPrice.Text = GridSurgeries.Rows(e.RowIndex).Cells("SurgeriesFee").Value
        End If

        FSurgeries.ChTypeOther.Checked = GridSurgeries.Rows(e.RowIndex).Cells("TypeSurgeries").Value
        FSurgeries.ShowDialog()
        If FSurgeries.isSurgClose = True Then
            LoadSurgeries("")
        End If
        FSurgeries.Dispose()
        FSurgeries.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim rowIndex As Integer = GridSurgeries.SelectedCells(0).RowIndex
            Dim No As String = GridSurgeries.Rows(rowIndex).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModSurgeries.DeleteSurgeries(No) = 1 Then
                    MsgBox("Delete sub diagnosis successfully.", MsgBoxStyle.Information, "Delete")
                    LoadSurgeries("")
                Else
                    MsgBox("Error delete sub diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

  
End Class
