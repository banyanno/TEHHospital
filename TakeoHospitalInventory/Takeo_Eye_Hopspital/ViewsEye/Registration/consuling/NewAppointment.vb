Public Class NewAppointment
    Dim DA_ConApp As New DSConsultTableAdapters.CONSULING_APPOINTMENTTableAdapter
    Dim DA_Daignosis As New DSConsultTableAdapters.TblSurgeryTableAdapter
    Dim DA_Surgery As New DSConsultTableAdapters.tblDiagSurgeriesTableAdapter
    Dim DA_AppPara As New DSConsultTableAdapters.APPOINT_PARATableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboSecondDiagnosis
            .DataSource = DA_Daignosis.GetData
            .ValueMember = DA_Daignosis.GetData.Columns("SID").ColumnName
            .DisplayMember = DA_Daignosis.GetData.Columns("Surgery").ColumnName
            .SelectedIndex = -1
        End With
        With CboSecondSurgery
            .DataSource = DA_Surgery.GetData
            .ValueMember = DA_Surgery.GetData.Columns("SID").ColumnName
            .DisplayMember = DA_Surgery.GetData.Columns("Surgeries").ColumnName
            .SelectedIndex = -1
        End With
        With CboDoctor
            .DataSource = ModDoctor.SelectDoctor()
            .ValueMember = "doctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
        LoadingAppPara()
    End Sub
    Private Sub LoadingAppPara()
        With AutocompleteMenu1
            For Each row As DataRow In DA_AppPara.GetData
                .AddItem(row("APP_PARAVALUE"))
            Next
        End With
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtPatientNo, "", ErrAppointment) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "", ErrAppointment) = False Then Exit Sub
        If ValidateDateTimePicker(DateApp, "", ErrAppointment) = False Then Exit Sub

        If LblSave.Text = "0" Then
            If MessageBox.Show("Do you want to save new appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_ConApp.InsertNewApp(CDbl(EmptyString(TxtPatientNo.Text)), TxtPatientName.Text, "", TxtPatientSex.Text, TxtAge.Text, Now.Date, DateApp.Value.Date, False, TxtNote.Text, "", False, CboSecondDiagnosis.Text, CboSecondSurgery.Text, CboEye.Text, TxtTel.Text, "Consuling", CInt(CboDoctor.SelectedValue), CboDoctor.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to save new appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_ConApp.UpdatePatientApp(CDbl(EmptyString(TxtPatientNo.Text)), TxtPatientName.Text, "", TxtPatientSex.Text, TxtAge.Text, DateApp.Value.Date, TxtNote.Text, CboSecondDiagnosis.Text, CboSecondSurgery.Text, CboEye.Text, CInt(CboDoctor.SelectedValue), CboDoctor.Text, CDbl(LblSave.Text)) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If ValidateTextField(TxtPatientNo, "", ErrAppointment) = False Then Exit Sub
        FindPatientNo(EmptyString(TxtPatientNo.Text))
       
    End Sub
    Dim DA_Patient As New DSConsultTableAdapters.TblPatientsTableAdapter
    Private Sub FindPatientNo(ByVal patientNo As Double)
        Dim TblPatient As DataTable = DA_Patient.GetDataByPatientNo(patientNo)
        If TblPatient.Rows.Count <= 0 Then
            MessageBox.Show("Patient No not found. Please check it again.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPatientNo.Focus()
            TxtPatientNo.SelectAll()
            TxtPatientName.Text = ""
            TxtPatientSex.Text = ""
            TxtAge.Text = ""
            'TxtPatientOccupation.Text = ""
            'TxtPatientAddress.Text = ""
        Else
            For Each Row As DataRow In TblPatient.Rows
                TxtPatientName.Text = Row("NameKhmer")
                TxtPatientSex.Text = Row("Sex")
                TxtAge.Text = Row("Age")
                TxtTel.Text = Row("Telephone")
                'TxtPatientOccupation.Text = Row("Occupation")
                'TxtPatientAddress.Text = Row("Address")
                'CboProNo.Text = Row("Province")
                'CboDisNo.Text = Row("District")
                'CboCommNo.Text = Row("Commune")
                'txtFamilyAddress.Text = Row("Address")
            Next
        End If
        
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

   
    Private Sub BtnSetNewApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetNewApp.Click
        Dim FAppointmentPara As New AppointmentParameter
        FAppointmentPara.ShowDialog()
        LoadingAppPara()
    End Sub

    Private Sub NewAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class