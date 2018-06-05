Public Class NewRefraction
    Dim DARefDiagnosis As New DSRefractionTableAdapters.REFRACTION_DIAGNOSISTableAdapter
    Dim DARefGlasess As New DSRefractionTableAdapters.REFRACTION_GLASSESTableAdapter
    Dim DARefVA As New DSRefractionTableAdapters.REFRACTION_VATableAdapter
    Dim DAPatient As New DSRefractionTableAdapters.TblPatientsTableAdapter
    Dim DARefraction As New DSRefractionTableAdapters.REFRACTIONTableAdapter

    Dim DARefAxis As New DSRefractionTableAdapters.REFRACTION_AXISTableAdapter
    Dim DARefVAReading As New DSRefractionTableAdapters.REFRACTION_VAREADINGTableAdapter
    Dim DAAdd As New DSRefractionTableAdapters.REFRACTION_ADDTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        RefreshVA()
        RefreshGlasess()
        RefreshDiagnosis()
        RefreshVAReading()
        RefreshAxis()
        RefreshAdd()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub RefreshVAReading()
        With CboLVAReading
            .DataSource = DARefVAReading.GetData
            .ValueMember = "VAREAD_ID"
            .DisplayMember = "VAREADING"
            .SelectedIndex = -1
        End With
       
    End Sub
    Private Sub RefreshAdd()
        With CboADD
            .DataSource = DAAdd.GetData
            .ValueMember = "ADD_ID"
            .DisplayMember = "ADD_REFRACTION"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub RefreshAxis()
        With CboRAxis
            .DataSource = DARefAxis.GetData
            .ValueMember = "AXIS_ID"
            .DisplayMember = "AXIS_NAME"
            .SelectedIndex = -1
        End With
        With CboLAxis
            .DataSource = DARefAxis.GetData
            .ValueMember = "AXIS_ID"
            .DisplayMember = "AXIS_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnNewVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVA.Click
        Dim NewRefVA As New NewRefracVA
        If NewRefVA.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVA()

        End If
    End Sub
    Private Sub RefreshVA()
        With CboLVAOld
            .DataSource = DARefVA.GetData
            .ValueMember = "RFRA_VA_ID"
            .DisplayMember = "REFRA_VA"
            .SelectedIndex = -1
        End With
        With CboRVAOld
            .DataSource = DARefVA.GetData
            .ValueMember = "RFRA_VA_ID"
            .DisplayMember = "REFRA_VA"
            .SelectedIndex = -1
        End With
        With CboLVARefrac
            .DataSource = DARefVA.GetData
            .ValueMember = "RFRA_VA_ID"
            .DisplayMember = "REFRA_VA"
            .SelectedIndex = -1
        End With
        With CboRVARefrac
            .DataSource = DARefVA.GetData
            .ValueMember = "RFRA_VA_ID"
            .DisplayMember = "REFRA_VA"
            .SelectedIndex = -1
        End With


    End Sub

    Private Sub BtnNewDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewDiagnosis.Click
        Dim NewDiagnosis As New NewRefDiagnosis
        If NewDiagnosis.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshDiagnosis()
        End If
    End Sub
    Private Sub RefreshDiagnosis()
        With CboDiagnosis
            .DataSource = DARefDiagnosis.GetData
            .DisplayMember = "REF_DIAGNOSIS"
            .ValueMember = "REFRACT_DIAG_ID"
            .SelectedIndex = -1
        End With


    End Sub

    Private Sub BtnNewGlasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewGlasses.Click
        Dim FRefGlasses As New NewRefGlasses
        If FRefGlasses.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshGlasess()
        End If
    End Sub
    Private Sub RefreshGlasess()
        With CboRGlasses
            .DataSource = DARefGlasess.GetData
            .ValueMember = "REFRA_GLASSES_ID"
            .DisplayMember = "REFRA_GLASSES"
            .SelectedIndex = -1
        End With
        With CboLGlasses
            .DataSource = DARefGlasess.GetData
            .ValueMember = "REFRA_GLASSES_ID"
            .DisplayMember = "REFRA_GLASSES"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub NewRefraction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnNewVARefrac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVARefrac.Click
        Dim NewRefVA As New NewRefracVA
        If NewRefVA.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVA()

        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnFindPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPatient.Click
        If ValidateTextField(TxtPatientNo, "", ErrRefraction) = False Then Exit Sub
        FindLoadingPatientNo(TxtPatientNo.Text.Trim)
    End Sub
    Private Sub FindLoadingPatientNo(ByVal PatientNo As String)
        Dim TPatient As DataTable = DAPatient.SelectPatientNo(PatientNo)
        If TPatient.Rows.Count > 0 Then
            For Each rows As DataRow In TPatient.Rows
                TxtPatientName.Text = rows("NameEng")
                TxtPatientSex.Text = rows("Sex")
                TxtPatientAge.Text = rows("Age")
                TxtPatientTel.Text = rows("Telephone")
                TxtPatientAddress.Text = rows("Address")
            Next
        Else
            MessageBox.Show("Patient found please check number's patient again!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPatientNo.Select()
            TxtPatientNo.SelectAll()
            TxtPatientName.Text = ""
            TxtPatientSex.Text = ""
            TxtPatientAge.Text = ""
            TxtPatientTel.Text = ""
            TxtPatientAddress.Text = ""
        End If

    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtPatientName, "", ErrRefraction) = False Then Exit Sub
        If ValidateTextField(TxtPatientSex, "", ErrRefraction) = False Then Exit Sub
        If ValidateDateField(RefrationDate, "", ErrRefraction) = False Then Exit Sub
        If ValidateCombobox(CboDiagnosis, "", ErrRefraction) = False Then Exit Sub
        If ValidateCombobox(CboLGlasses, "", ErrRefraction) = False Then Exit Sub
        If ValidateCombobox(CboRGlasses, "", ErrRefraction) = False Then Exit Sub
        If ValidateCombobox(CboLVARefrac, "", ErrRefraction) = False Then Exit Sub
        If ValidateCombobox(CboRVARefrac, "", ErrRefraction) = False Then Exit Sub
        If lblSaveOption.Text = "0" Then
            If DARefraction.CheckExistingPatient(TxtPatientNo.Text, RefrationDate.Value) > 0 Then
                MessageBox.Show("Today patient already register in Refraction.Please check patient again!", "Refraction", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Do you want to save new refraction?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DARefraction.InsertNewRefration(TxtPatientNo.Text, TxtPatientName.Text, TxtPatientSex.Text, TxtPatientAge.Text, TxtPatientTel.Text, TxtPatientAddress.Text, RefrationDate.Value.Date, CboLVAOld.Text, CboRVAOld.Text, CboDiagnosis.Text, CboLGlasses.Text, CboRGlasses.Text, CboLVARefrac.Text, CboRVARefrac.Text, TxtRefractionNote.Text, IIf(ChPrescription.Checked = True, True, False), False, "", ChIsOld.Checked, CboLAxis.Text, CboRAxis.Text, CboLVAReading.Text, CboADD.Text, IIf(DARefraction.CheckOldOrNew(TxtPatientNo.Text) > 0, True, False)) = 1 Then
                    MessageBox.Show("Save new refraction successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update refraction?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DARefraction.UpdateRefraction(TxtPatientNo.Text, TxtPatientName.Text, TxtPatientSex.Text, TxtPatientAge.Text, TxtPatientTel.Text, TxtPatientAddress.Text, RefrationDate.Value.Date, CboLVAOld.Text, CboRVAOld.Text, CboDiagnosis.Text, CboLGlasses.Text, CboRGlasses.Text, CboLVARefrac.Text, CboRVARefrac.Text, TxtRefractionNote.Text, CboLAxis.Text, CboRAxis.Text, CboLVAReading.Text, CboADD.Text, ChPrescription.Checked, ChIsOld.Checked, lblSaveOption.Text) = 1 Then
                    MessageBox.Show("Update refraction successful!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If

    End Sub

    Private Sub BtnVAReading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVAReading.Click
        Dim VAReading As New NewVAReading
        If VAReading.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshVAReading()
        End If
    End Sub

    Private Sub BtnGlassesAxis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGlassesAxis.Click
        Dim Axis As New NewAxisPara
        If Axis.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshAxis()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NAdd As New NewADDPara
        If NAdd.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshAdd()
        End If

    End Sub
End Class