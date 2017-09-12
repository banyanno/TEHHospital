Public Class FormMarkEOD
    Dim DA_BusDays As New DSPatientReceiptTableAdapters.BusinessesTableAdapter
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSettingMarkEOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSettingMarkEOD.Click
        If ValidateDateField(DateNewBusinessDay, "", ErrorProvider1) = False Then Exit Sub
        If DateNewBusinessDay.Value.Date <= GetDateServer() Then
            MessageBox.Show("You can not set the same day!", "Business day", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'MessageBox.Show(DA_BusDays.CheckMarkEODExist(DateNewBusinessDay.Value.Date, GetDateServer.Date).ToString)
        If LblSaveOption.Text = "0" Then
            If DA_BusDays.CheckMarkEODExist(DateNewBusinessDay.Value.Date, GetDateServer.Date) = 0 Then
                If MessageBox.Show("Do you want to mark new business day?", "Mark EOD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    '' Get Current day-1 
                    Dim TblCurrDay As DataTable = DA_BusDays.SelectBusinessDay()
                    Dim GetCurrDay As Date = GeteDateServer.Date
                    Dim GetCurrID As Integer = 0
                    For Each rows As DataRow In TblCurrDay.Rows
                        GetCurrID = IIf(TypeOf (rows("ID")) Is DBNull, 0, rows("ID"))
                        GetCurrDay = IIf(TypeOf (rows("NEXT_BUSINESS_DATE")) Is DBNull, Now.Date, rows("NEXT_BUSINESS_DATE"))
                    Next

                    If DA_BusDays.InsertNewEOD(GetCurrDay.Date, "Y", DateNewBusinessDay.Value.Date, Now.Date) = 1 Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        DA_BusDays.UpdateStatusBusinessDay("N", GetCurrID)
                    End If
                End If
            Else
                MessageBox.Show("You have already mark end of busines day. You can not mark again.", "E-O-D", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If MessageBox.Show("Do you want to update business day?", "Mark EOD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_BusDays.CorrectBusinessDay(DateNewBusinessDay.Value.Date, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update business day", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
       

    End Sub

  
End Class