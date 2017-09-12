Public Class UCDoctor

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GridDoctor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridDoctor.CellClick
        Try

            TxtDoctorName.Text = GridDoctor.Rows(e.RowIndex).Cells(1).Value
            CboSex.Text = GridDoctor.Rows(e.RowIndex).Cells(2).Value
            TxtAge.Text = GridDoctor.Rows(e.RowIndex).Cells(3).Value
            TxtTel.Text = GridDoctor.Rows(e.RowIndex).Cells(4).Value
            TxtFunction.Text = GridDoctor.Rows(e.RowIndex).Cells(5).Value
            
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FDoctor As New FRMNewDoctor
        FDoctor.ShowDialog()
        If FDoctor.isDoctorClose = True Then
            GridDoctor.DataSource = ModDoctor.SelectDoctor()
        End If
    End Sub

    Private Sub BtnViewData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewData.Click
        LoadDoctor()
    End Sub
    Sub LoadDoctor()
        GridDoctor.DataSource = ModDoctor.SelectDoctor()
        ModCommon.NumberAllRowHeaderDataGrid(GridDoctor)
    End Sub

    Private Sub GridDoctor_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridDoctor.CellDoubleClick
        Try
            Dim FDoctor As New FRMNewDoctor
            FDoctor.lblSaveOption.Text = GridDoctor.Rows(e.RowIndex).Cells(0).Value
            FDoctor.TxtDoctorName.Text = GridDoctor.Rows(e.RowIndex).Cells(1).Value
            FDoctor.CboSex.Text = GridDoctor.Rows(e.RowIndex).Cells(2).Value
            FDoctor.TxtAge.Text = GridDoctor.Rows(e.RowIndex).Cells(3).Value
            FDoctor.TxtTel.Text = GridDoctor.Rows(e.RowIndex).Cells(4).Value
            FDoctor.TxtFunction.Text = GridDoctor.Rows(e.RowIndex).Cells(5).Value
            FDoctor.ShowDialog()
            If FDoctor.isDoctorClose = True Then
                LoadDoctor()
            End If
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub BtnViewOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewOther.Click
        LoadOther()
    End Sub

    Private Sub BtnNewOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewOther.Click
        Dim FNewOther As New FrmOther
        FNewOther.ShowDialog()
        If FNewOther.isCloseOther = True Then
            LoadOther()
        End If
    End Sub
    Sub LoadOther()
        GridOther.DataSource = ModDoctor.SelectOther()
        ModCommon.NumberAllRowHeaderDataGrid(GridOther)
    End Sub

   
    Private Sub GridOther_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOther.CellDoubleClick
        Try
            Dim FOther As New FrmOther
            FOther.LblSaveOption.Text = GridOther.Rows(e.RowIndex).Cells(0).Value
            FOther.TxtOther.Text = GridOther.Rows(e.RowIndex).Cells(1).Value
            FOther.TxtDescription.Text = GridOther.Rows(e.RowIndex).Cells(2).Value
            FOther.ShowDialog()
            If FOther.isCloseOther = True Then
                LoadOther()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Try
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                Dim rowIndex As Integer = GridDoctor.SelectedCells(0).RowIndex
                Dim No As String = GridDoctor.Rows(rowIndex).Cells(0).Value
                If ModDoctor.DeleteDoctor(No) = 1 Then
                    MsgBox(MSG_DELETE_SUCCESS, MsgBoxStyle.Information, "Delete")
                    LoadDoctor()
                Else
                    MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                Dim rowIndex As Integer = GridOther.SelectedCells(0).RowIndex
                Dim No As String = GridOther.Rows(rowIndex).Cells(0).Value
                If ModDoctor.DeleteOther(No) = 1 Then
                    MsgBox(MSG_DELETE_SUCCESS, MsgBoxStyle.Information, "Delete")
                    LoadOther()
                Else
                    MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
        End Try
       
    End Sub

    Private Sub GridOther_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOther.CellClick
        Try
            TxtOther.Text = GridOther.Rows(e.RowIndex).Cells(1).Value
            TxtDescription.Text = GridOther.Rows(e.RowIndex).Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub
End Class
