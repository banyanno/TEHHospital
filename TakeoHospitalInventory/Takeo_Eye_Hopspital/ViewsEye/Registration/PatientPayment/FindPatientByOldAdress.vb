Public Class FindPatientByOldAdress
    Dim UMiantPayment As UCPatientPayment
    Sub New(ByVal UMiantPayment As UCPatientPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UMiantPayment = UMiantPayment
        ' Add any initialization after the InitializeComponent() call.
        With cboProvince
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
            .SelectedIndex = -1
        End With
        'CboProNo.Text = ""
        cboDistrict.Text = ""
        cboCommune.Text = ""
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        UMiantPayment.Cursor = Cursors.WaitCursor
        UMiantPayment.DSPatient.Clear()
        UMiantPayment.GridPatientInformation.Refresh()
        UMiantPayment.ActionFindPatien(EmptyString(TxtPatientSearchNo.Text.Trim), "", DateRFrom.Value, DateRTo.Value, _
            txtEngName.Text.Trim, _
            txtKhmerName.Text.Trim, _
            cboSex.Text.Trim, _
            cboProvince.Text.Trim, _
            cboDistrict.Text.Trim, _
            cboCommune.Text.Trim, "")
        TxtPatientSearchNo.Focus()
        TxtPatientSearchNo.Select()
        TxtPatientSearchNo.SelectAll()
    End Sub

   


 



 

    Private Sub cboDistrict_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDistrict.SelectedValueChanged
        If cboDistrict.SelectedValue Is Nothing Then
        Else
            Try
                With cboCommune
                    .DataSource = ModProvince.SelectCommune(CInt(cboDistrict.SelectedValue))
                    .DisplayMember = "Commune"
                    .ValueMember = "KhumCode"
                    .SelectedIndex = -1
                End With
                Me.cboCommune.SelectAll()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cboProvince_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvince.SelectedValueChanged
        If cboProvince.SelectedValue Is Nothing Then
        Else
            Try
                With cboDistrict
                    .DataSource = ModProvince.SelectDistrict(CInt(cboProvince.SelectedValue))
                    .DisplayMember = "DISTRICT"
                    .ValueMember = "SrokCode"
                    .SelectedIndex = -1
                End With
                cboDistrict.Text = ""
                cboCommune.Text = ""
            Catch ex As Exception

            End Try
            
            'TxtAddress.Text = ""
            'Me.CboDisUpdate.SelectAll()
        End If
    End Sub
End Class