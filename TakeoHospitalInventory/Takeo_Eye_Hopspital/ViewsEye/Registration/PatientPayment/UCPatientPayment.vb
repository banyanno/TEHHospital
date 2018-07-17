'Option Strict On
'Option Explicit On
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Threading
Imports System.Diagnostics
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Timers
Public Class UCPatientPayment
   
 
    Dim startDate As DateTime

    Private patientNoSearh As String
    Private patientEngName As String
    Private patientKhName As String
    Private patientAge As String
    Private patientSex As String
    Private patientProvince As String
    Private patientDistrict As String
    Private patientCommune As String
    Private OldPatientNo As String
    Dim DateFrom As String
    Dim DateTo As String

    Dim mainForm As MainTakeoInventory
    Dim SQlDataAdapter As New SqlDataAdapter
    Dim SqlComman As New SqlCommand
    '' Form Declaration 

    Dim DA_Consult_Detail As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim DS_Consult As New DSConsultTableAdapters.CONSULINGTableAdapter
    ' Report Path
    Dim ReportNOPR As New ReportNewOutPatientReceipt
    Dim DA_Appoint As New DSConsultTableAdapters.CONSULING_APPOINTMENTTableAdapter
    Sub New(ByVal mainSubForm As MainTakeoInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.mainForm = mainSubForm

        With CboOccupation
            .DataSource = ModOccupation.SelectAllOccupation()
            .ValueMember = "Occupation"
            .SelectedValue = "OccNo"
            .Text = Nothing
        End With
        Me.SplitContainer1.SplitterDistance = Me.Height / 2
        'FNewPatientReceipt =
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        'showMerlin(1000, 100)
        'Merlin("", "Alert") 

        Me.Cursor = Cursors.WaitCursor
        Me.DSPatient.Clear()
        GridPatientInformation.Refresh()
        ActionFindPatien(EmptyString(TxtPatientSearchNo.Text.Trim), EmptyString(TxtOldPatientNo.Text.Trim), DateRFrom.Value, DateRTo.Value, _
            txtEngName.Text.Trim, _
            txtKhmerName.Text.Trim, _
            cboSex.Text.Trim, _
            cboProvince.Text.Trim, _
            cboDistrict.Text.Trim, _
            cboCommune.Text.Trim)
        'GridPatientInformation.Select()
        'GridPatientInformation.Focus()
    End Sub


    Sub ActionFindPatien(ByVal PatientNo As String, ByVal OldPatient As String, ByVal DFrom As String, ByVal DTo As String, ByVal PEngName As String, ByVal PKh As String, ByVal Sex As String, ByVal Province As String, ByVal District As String, ByVal Commune As String)
        DateFrom = DFrom
        DateTo = DTo
        patientNoSearh = PatientNo
        OldPatientNo = OldPatient
        patientEngName = PEngName
        patientKhName = PKh

        patientSex = Sex
        patientProvince = Province
        patientDistrict = District
        patientCommune = Commune
        btnFind.Enabled = False
        'startDate = DateTime.Now
        ' ProgrestData.Visible = True

        ' Do search action

        bgPatient.RunWorkerAsync()

        'TimerSearchPatien.Start()
    End Sub

    Private Sub bgPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgPatient.DoWork
        ' Me.TblPatientsTableAdapter.FillBy(Me.DSPatient.TblPatients, patientNoSearh, patientProvince)

        FillPatientInformation()
        'Me.V_NewoutpatientTableAdapter.Fill(Me.DSPatient.V_Newoutpatient)
        'Me.V_OldOutpatientTableAdapter.Fill(Me.DSPatient.V_OldOutpatient)
        'Me.V_InpatientTableAdapter.Fill(Me.DSPatient.V_Inpatient)
        'Me.SetDataObjects()
        If (bgPatient.CancellationPending) Then ' Test if user hit Cancel key
            e.Cancel = True
            Return
        End If
    End Sub
    Private Sub bgPatient_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgPatient.ProgressChanged
        ProgrestData.Value = e.ProgressPercentage
    End Sub

    Private Sub bgPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgPatient.RunWorkerCompleted
        Try
           
         
            'ProgrestData.Value = 100
            btnFind.Enabled = True
            'ProgrestData.Visible = False
            ProgrestData.Value = 0
            'Dim PatientNo As Integer = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text

            'LoadPatientBooks(PatientNo)
            'TimerSearchPatien.Stop()

        Catch ex As Exception

        End Try
        mainForm.StatusLoading(False)
        Cursor = Cursors.Default

    End Sub
    'End Sub
    Private Sub FillPatientInformation()
        mainForm.StatusLoading(True)
        Dim Cnn As SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Try
            SqlComman.CommandText = SearchPatient(patientNoSearh, OldPatientNo, DateFrom, DateTo, patientEngName, patientKhName, patientAge, patientSex, patientProvince, patientDistrict, patientCommune)
            SqlComman.Connection = Cnn
            SQlDataAdapter.SelectCommand = SqlComman
            SQlDataAdapter.Fill(DSPatient.TblPatients)
            'GridPatientInformation.DataSource = DSPatient.Tables(1)

            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Function SearchPatient(ByVal PatientID As String, ByVal OldPatientNo As String, ByVal DFrom As String, ByVal DTo As String, ByVal Name As String, ByVal KhmerName As String, ByVal Age As String, ByVal Sex As String, ByVal Province As String, ByVal District As String, ByVal Commune As String) As String
        'CONVERT(VARCHAR(10),CreateDate, 103) as
        Dim sql As String = "SELECT DISTINCT [No]" & _
        ",PatientNo, CreateDate,Province" & _
        ",District,Commune,NameEng" & _
        ",NameKhmer,Age,Sex" & _
        ",Address,Occupation,Telephone,TIME_CREATE" & _
        " FROM TblPatients  WHERE PatientNo IS NOT NULL  "
        If DFrom <> "" And DTo <> "" Then
            sql = sql & _
             " AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DTo & "' AS DATETIME), 1) as Datetime) "
        End If
        If PatientID <> "0" Then
            sql = sql & " AND PatientNo=" & PatientID
        End If
        If OldPatientNo <> "0" Then
            sql = sql & " AND OlePatientNo=" & OldPatientNo
        End If
        If Province <> "" Then
            sql = sql & " AND Province ='" & Province.Replace("'", "''") & "'"
        End If
        If District <> "" Then
            sql = sql & " AND District='" & District.Replace("'", "''") & "'"
        End If
        If Commune <> "" Then
            sql = sql & " AND Commune='" & Commune.Replace("'", "''") & "'"
        End If
        If Name <> String.Empty Then
            sql = sql & " AND NameEng Like '%" & Name & "%' "
        End If
        If KhmerName <> String.Empty Then
            sql = sql & " AND NameKhmer LIKE N'%" & KhmerName & "%' "
        End If
        If Sex <> String.Empty Then

            sql = sql & " AND Sex='" & Sex & "' "

        End If
        If Age <> String.Empty Then
            sql = sql & " AND Age='" & Age & "'"
        End If
        Return sql & " ORDER BY PatientNo DESC"
    End Function


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtPatientNo, "patient no", ErrPatient) = False Or _
        ValidateTextField(TxtNameEng, "Name English", ErrPatient) = False Or _
        ValidateTextField(TxtNameKhmer, "Name Khmer", ErrPatient) = False Or _
        ValidateTextField(TxtAgePatient, "Age", ErrPatient) = False Or _
        ValidateCombobox(CboOccupation, "Occupation", ErrPatient) = False Or _
        ValidateTextField(TxtTel, "Tel", ErrPatient) = False Or _
        ValidateCombobox(CboSexPatien, "Sex", ErrPatient) = False Or _
        ValidateCombobox(CboProNo, "Province", ErrPatient) = False Or _
        ValidateCombobox(CboDisNo, "District", ErrPatient) = False Or _
        ValidateCombobox(CboCommNo, "Commune", ErrPatient) = False _
        Then
            'showMerlin(100, 100)
            'Merlin("", "Suggest")
        Else
            If lblSaveOption.Text = "0" Then
                ModGlobleVariable.DIALOG_SAVE = MessageBox.Show(ModGlobleVariable.MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ModGlobleVariable.DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                    'Dim i As Integer

                    'For i = 0 To 100000
                    ' Insert new patient sucessfully
                    If ModRegistration.NewRegistrationPatient(TxtPatientNo.Text, CStr(Now), CboProNo.Text, CboDisNo.Text, CboCommNo.Text, TxtNameEng.Text, TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text, CboOccupation.Text, TxtTel.Text, "", Today.Year) = 1 Then
                        If ModRegistration.SavePatienToFollowUP(TxtPatientNo.Text) = 1 Then
                            MsgBox("The registration new patient successfully", MsgBoxStyle.Information)
                            ActionFindPatien(TxtPatientNo.Text, "0", "", "", "", "", "", "", "", "")
                        Else
                            MsgBox("Error new registratin. Please contact Developer1", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Error new registratin. Please contact Developer", MsgBoxStyle.Critical)
                    End If
                    'Next
                End If
            Else
                ModGlobleVariable.DIALOG_UPDATE = MessageBox.Show(ModGlobleVariable.MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ModGlobleVariable.DIALOG_UPDATE = DialogResult.Yes Then
                    If ModRegistration.UpdatePatient(lblSaveOption.Text, CboProNo.Text, CboDisNo.Text, CboCommNo.Text, TxtNameEng.Text, TxtNameKhmer.Text, TxtAgePatient.Text, CboSexPatien.Text, TxtAddress.Text, CboOccupation.Text, TxtTel.Text, DateRegis.Value) = 1 Then
                        MsgBox("Update patient sucessffully.", MsgBoxStyle.Information, "Update")
                        ActionFindPatien(TxtPatientNo.Text, "0", "", "", "", "", "", "", "", "")
                    Else
                        MsgBox("Update patient error.", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        End If

    End Sub


    Private Sub txtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtPatientFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtFindReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPatienNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientSearchNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.txtEngName.Focus()
        End If
    End Sub


    Private Sub txtPatientNoFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtPatientName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtSex_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cboDiagnosisLeft_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cboDiagnosisRight_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub


    Private Sub CboCommNo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.SelectedValueChanged
        TxtAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
    End Sub

    Private Sub TimerSearchPatien_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSearchPatien.Tick
        'Dim ts As TimeSpan = DateTime.Now.Subtract(startDate)
        'lblTimeShowData.Text = "Time Load Data..." & ts.Minutes.ToString("00") & _
        '":" & ts.Seconds.ToString("00") & _
        '":" + ts.Milliseconds.ToString("000")
        'If (ProgrestData.Value = ProgrestData.Maximum) Then
        '    ProgrestData.Value = 0
        'End If
        'ProgrestData.PerformStep()
    End Sub

    Sub LoadOldPatientForm(ByVal ReceiptNo As String, ByVal PatientNo As String, ByVal EngName As String, ByVal KhName As String, ByVal Age As String, ByVal Sex As String, ByVal Address As String, ByVal PatientFee As String)
        Dim FOldPatient As New FRMOld_Outpatient
        FOldPatient.TxtReceiptNo.Text = ReceiptNo
        FOldPatient.TxtPatientNo.Text = PatientNo
        FOldPatient.TxtPatientName.Text = KhName
        FOldPatient.TxtPatientFee.Text = "0"
        FOldPatient.TxtPatientFee.Enabled = False
        FOldPatient.RadioRiel.Enabled = False
        FOldPatient.RadioDolar.Enabled = False
        FOldPatient.TxtAge.Text = Age
        FOldPatient.TxtSex.Text = Sex
        FOldPatient.TxtAddress.Text = Address
        FOldPatient.TxtPatientFee.Text = PatientFee
        FOldPatient.ShowDialog()
        If FOldPatient.isCloseOld = True Then
            LoadPatientBooks(FOldPatient.TxtPatientNo.Text)
        Else
            Exit Sub
        End If
        FOldPatient.Close()
        FOldPatient.Dispose()
    End Sub

    Sub LoadInPatientForm(ByVal DateReceip As Date, ByVal ReceiptNo As String, ByVal PatientNo As String, ByVal KhName As String, ByVal EngName As String, ByVal Age As String, ByVal Sex As String, ByVal Address As String)
        Dim FIn_Patient As New FRMIn_patient
        FIn_Patient.DateIn.Checked = True
        FIn_Patient.DateIn.Value = DateReceip
        FIn_Patient.TxtReceiptNo.Text = ReceiptNo
        FIn_Patient.TxtPatientNo.Text = PatientNo
        FIn_Patient.TxtPatientName.Text = KhName
        FIn_Patient.TxtAge.Text = Age
        FIn_Patient.TxtSex.Text = Sex
        FIn_Patient.TxtAddress.Text = Address
        FIn_Patient.LblPatientNameEng.Text = EngName
        'FIn_Patient.TxtHosFee.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
        FIn_Patient.ShowDialog()
        If FIn_Patient.isCloseIn = True Then
            LoadPatientBooks(FIn_Patient.TxtPatientNo.Text)
        Else
            Exit Sub
        End If
        FIn_Patient.Close()
        FIn_Patient.Dispose()
    End Sub

    Private Sub FollowUpRegistrationFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRegistrationForm.Click

        If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
            ShowRegistrationFormByNew()
        End If
    End Sub

    Sub ShowRegistrationFormByNew()
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        mainForm.CreateRegisForm()
        mainForm.examinationForm.TxtPatientNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
        mainForm.examinationForm.TxtPatientName.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
        mainForm.examinationForm.TxtAge.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
        mainForm.examinationForm.TxtSex.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
        mainForm.examinationForm.TxtAddress.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
        'mainForm.examinationForm.TxtPatientNo.Focus()
        mainForm.examinationForm.FindPatientRegistration()
    End Sub

    Private Sub CboAgePatient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAgePatient.KeyPress
        SetDisableKeyString(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.CboSexPatien.Focus()
        End If
    End Sub
    Private Sub CboSexPatien_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboSexPatien.KeyDown
        Select Case e.KeyCode
            Case Keys.F
                Me.CboSexPatien.Text = "F"
            Case Keys.M
                Me.CboSexPatien.Text = "M"
            Case Else
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub TxtAgePatient_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAgePatient.KeyUp
        If e.KeyCode = 190 Then
            TxtAgePatient.Text = ""
        End If
        If TxtAgePatient.Text.Length > 2 Then
            MsgBox("Patient's age can not > 100.", MsgBoxStyle.Critical, "Error")
            TxtAgePatient.Text = "0"
        End If
    End Sub

    Private Sub CboSexPatien_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboSexPatien.KeyPress
        SetDisableKey(e)
    End Sub
    Dim DAPatientReceipt As New DSDashboardPatientTableAdapters.tblPatientReceiptTableAdapter
    Private Sub BtnOldOutPatientReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOldOutPatientReceipt.Click
        If GridPatientInformation.SelectedItems.Count > 0 Then
            If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
                'Dim TblTemTblReceitp As DataTable = DAPatientReceipt.GetDataByCheckDatin(GridPatientInformation.GetRow.Cells("PatientNo").Value, GetDateServer.Date)
                If ModOld_Outpatient.CheckDuplicatePatientOneDay(GridPatientInformation.GetRow.Cells("PatientNo").Value, ModGlobleVariable.CheckMarkEOD.Date, 1) > 0 Then
                    MessageBox.Show("Can not registration patient for Old patient book on the same day. Could you check old patient book agian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If ModOld_Outpatient.CheckDuplicatePatientOneDay(GridPatientInformation.GetRow.Cells("PatientNo").Value, ModGlobleVariable.CheckMarkEOD.Date, 0) > 0 Then
                    MessageBox.Show("Can not registration patient for Old patient book on the same day. Could you check old patient book agian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                    'End If
                    'If TblTemTblReceitp.Rows.Count > 0 Then
                    '    MessageBox.Show("This Patient No " & GridPatientInformation.GetRow.Cells("PatientNo").Value & " is already register for old patient book receipt, Could you check again.", "existing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Exit Sub
                Else
                    Dim FOldPatientReceipt As New frmOldOutPatientReceipt
                    FOldPatientReceipt.IS_UPDATE = False
                    FOldPatientReceipt.txtHN.Text = TxtPatientNo.Text
                    FOldPatientReceipt.txtPatient.Text = TxtNameKhmer.Text
                    If FOldPatientReceipt.ShowDialog() = DialogResult.OK Then
                        UpdatetFollowupInnewPatient(TxtPatientNo.Text)
                        ActionFindPatien(TxtPatientNo.Text, "0", "", "", "", "", "", "", "", "")
                        CheckIsPatientConsult(GridPatientInformation.GetRow.Cells("PatientNo").Value, 0)

                    End If
                    FOldPatientReceipt.Dispose()
                    FOldPatientReceipt.Close()
                End If


            End If

            
        Else
            MessageBox.Show("Please select patient in list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Function CheckIsPatientConsult(ByVal PatientNo As Double, ByVal Status As Integer) As Boolean
        Dim DataTbl As DataTable = DA_Consult_Detail.GetDataByCheckTotalConsult(PatientNo, Status, True)
        'Dim strConsultfor As String = ""
        'Dim strServiceFor As String = ""
        'Dim DConsult As Date = Now
        GridConsult.DataSource = DataTbl
        If DataTbl.Rows.Count >= 1 Then
            For i As Integer = 0 To DataTbl.Rows.Count - 1
                strConsultfor = strConsultfor & " " & DataTbl.Rows(i).Item("CONSULT_FOR")
                strServiceFor = strServiceFor & " " & DataTbl.Rows(i).Item("DONATE_TYPE")
                DConsult = DataTbl.Rows(i).Item("CONSULING_DATE")
                '' MsgBox(DataTbl.Rows(i).Item("CONSULT_FOR"))
                'LblConsultID.Text = DataTbl.Rows(i).Item("CONSULING_ID")
                'LblConsultDate.Text = DataTbl.Rows(i).Item("CONSULING_DATE")
                'LblConsultType.Text = DataTbl.Rows(i).Item("DONATE_TYPE")
                'lblConsultFor.Text = DataTbl.Rows(i).Item("CONSULT_FOR")
                'LblSendBy.Text = DataTbl.Rows(i).Item("APROVE_BY")
                'rdOperationR.Checked = True
                'rdOperationR.Enabled = False
                'rdOperationD.Enabled = False
                'txtOperationFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                'txtOperationFee.Enabled = False
                'CboDiagnosis.Text = DataTbl.Rows(i).Item("DIAGNOSIS2")
                'txtOperation.Text = DataTbl.Rows(i).Item("OPERATION2")
                'TxtHosFee.Text = DataTbl.Rows(i).Item("HOSPITAL_FEE")
                'RRielSSFee.Checked = True
                'RReilFFee.Checked = True
                'TxtHosFee.Enabled = False
                'If DataTbl.Rows(i).Item("DONATE_TYPE") = "Social" Then
                '    TxtSosialServiceFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                '    ChDonation.Checked = True
                '    CboDonation.Text = DataTbl.Rows(i).Item("ORG")
                '    TxtDonationPay.Text = DataTbl.Rows(i).Item("DONATE_DOLAR")
                '    TxtFullFee.Text = "0"
                '    ChDonation.Enabled = False
                '    GroupBox8.Enabled = False
                'End If
                'If DataTbl.Rows(i).Item("DONATE_TYPE") = "Nil" Then
                '    TxtSosialServiceFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                '    ChDonation.Checked = True
                '    CboDonation.Text = DataTbl.Rows(i).Item("ORG")
                '    MsgBox(DataTbl.Rows(i).Item("DONATE_DOLAR"))
                '    TxtDonationPay.Text = DataTbl.Rows(i).Item("DONATE_DOLAR")
                '    TxtFullFee.Text = "0"
                '    ChDonation.Enabled = False
                '    GroupBox8.Enabled = False
                'End If
                'If DataTbl.Rows(i).Item("DONATE_TYPE") = "Full" Then
                '    TxtSosialServiceFee.Text = "0"
                '    TxtFullFee.Text = DataTbl.Rows(i).Item("HOSPITAL_FEE")
                'End If
                'TxtSosialServiceFee.Enabled = False
                'TxtFullFee.Enabled = False

                'RRielSSFee.Enabled = False
                'RDolarSSFee.Enabled = False

                'RReilFFee.Enabled = False
                'RDolarFFee.Enabled = False

            Next
            'LblTotalConsult.Text = DataTbl.Rows.Count
            ''LblConsultFor.Text = strConsultfor
            'LblServiceFor.Text = strServiceFor
            'DateConsult.Value = DConsult
            Return True
        Else
            'LblTotalConsult.Text = 0
            'LblConsultFor.Text = "No Consult"
            'LblServiceFor.Text = "No Service"
            'DateConsult.Value = Now.Date
            Return False
        End If
    End Function

    Private Sub BtnInpatientReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInpatientReceipt.Click
        If GridPatientInformation.SelectedItems.Count > 0 Then
            Dim FForInpatientReceipt As New FormForInpatientReceiptFront
            FForInpatientReceipt.txtHN.Text = TxtPatientNo.Text
            FForInpatientReceipt.txtPatient.Text = TxtNameKhmer.Text
            FForInpatientReceipt.LblPatientEn.Text = TxtNameEng.Text
            FForInpatientReceipt.LblSex.Text = CboSexPatien.Text
            FForInpatientReceipt.LblAge.Text = TxtAgePatient.Text
            FForInpatientReceipt.LblAddress.Text = TxtAddress.Text
            FForInpatientReceipt.dtpDateIn.Checked = True

            If GridConsult.GetRows.Count > 0 Then
                FForInpatientReceipt.dtpDateIn.Value = GridConsult.GetRow.Cells("CONSULING_DATE").Value
                FForInpatientReceipt.lblConsutIDv.Text = GridConsult.GetRow.Cells("CONSULING_ID").Value
            Else

            End If

            If FForInpatientReceipt.ShowDialog = DialogResult.OK Then
                ActionFindPatien(TxtPatientNo.Text, "0", "", "", "", "", "", "", "", "")
                CheckIsPatientConsult(GridPatientInformation.GetRow.Cells("PatientNo").Value, 0)
            End If
            FForInpatientReceipt.Dispose()
            FForInpatientReceipt.Close()
            'FormForInpatientReceiptFront.ShowDialog()
            'LoadInPatientReceipat(TxtPatientNo.Text, TxtNameKhmer.Text, TxtNameEng.Text, TxtAgePatient.Text, Me.CboSexPatien.Text, TxtAddress.Text)
        Else
            MessageBox.Show("Please select patient in list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
       
    End Sub
    Sub LoadInPatientReceipat(ByVal PatientNo As String, ByVal KhName As String, ByVal EngName As String, ByVal Age As String, ByVal Sex As String, ByVal Address As String)
        If PatientNo <> String.Empty Then
            Dim FInpatientReceipt As New frmInpatientReceipt
            FInpatientReceipt.txtHN.Text = TxtPatientNo.Text
            FInpatientReceipt.txtPatient.Text = KhName
            FInpatientReceipt.ShowDialog()
            If FInpatientReceipt.DialogResult = DialogResult.OK Then
                ActionFindPatien(TxtPatientNo.Text, "0", "", "", "", "", "", "", "", "")
                LoadInPatientForm(FInpatientReceipt.dtpDateIn.Value, FInpatientReceipt.txtReceiptNumber.Text, PatientNo, KhName, EngName, Age, Sex, Address)
            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub BtnCashReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCashReceipt.Click
        If TxtPatientNo.Text <> "" Then
            Dim FCashReceipt As New frmCashReceipt
            FCashReceipt.txtHN.Text = TxtPatientNo.Text
            FCashReceipt.txtPatient.Text = TxtNameKhmer.Text
            FCashReceipt.ShowDialog()
            ActionFindPatien(TxtPatientNo.Text, "0", "", "", "", "", "", "", "", "")
            'If FCashReceipt.DialogResult = DialogResult.OK Then
            '    ActionFindPatien(TxtPatientNo.Text, "", "", "", "", "", "")
            'End If
        End If
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click

        Dim FNewPatientPay As New NewPatientPayment
        FNewPatientPay.ShowDialog()
        FNewPatientPay.Dispose()
        FNewPatientPay.Close()
        ' NewPatientPayment.ShowDialog()

    End Sub
    Sub ClearForm()
        TxtPatientNo.Text = ""
        TxtNameEng.Text = ""
        TxtNameKhmer.Text = ""
        TxtAgePatient.Text = ""
        CboSexPatien.Text = ""
        TxtTel.Text = ""
        CboOccupation.Text = ""
        CboProNo.Text = ""
        CboDisNo.Text = ""
        CboCommNo.Text = ""
        TxtAddress.Text = ""
    End Sub

    Private Sub UCPatientPayment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.Control = True And e.KeyCode = Keys.N Then
            Dim frmPatientInfo As New FRMIn_patient
            frmPatientInfo.ShowDialog()
        End If
    End Sub

    Private Sub UCPatientPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tblPermistion As DataTable = ModUser.GetMenuPermission(USER_NAME)

        For Each obj As Object In GroupPayment.Controls
            If TypeOf obj Is Button Then
                Dim Btn As Button = CType(obj, Button)

                For indexMenu = 0 To tblPermistion.Rows.Count - 1
                    'MsgBox(tblPermistion.Rows(indexMenu).Item(0))
                    If tblPermistion.Rows(indexMenu).Item(0) = "Phone Number" Then
                        ' TxtTel.Visible = True
                    Else
                        'TxtTel.Visible = False
                    End If
                    If Btn.Tag = tblPermistion.Rows(indexMenu).Item(0) Then
                        Btn.Enabled = True
                    End If
                Next
            End If
        Next

        'For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
        '    With TBLACCESS_ROLE.Rows(i)
        '        If .Item(0) <> "Administrator" Then
        '            'LblTel.Visible = False
        '            TxtTel.Visible = False
        '        Else
        '            'LblTel.Visible = True
        '            TxtTel.Visible = True
        '        End If
        '    End With
        'Next

        'For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
        '    With TBLACCESS_ROLE.Rows(i)
        '        If .Item(0) = "New Registration" Then
        '            Me.BtnNewOutPatient.Enabled = True
        '            Me.BtnOldOutPatientReceipt.Enabled = False
        '            Me.BtnInpatientReceipt.Enabled = False
        '            Me.BtnCashReceipt.Enabled = False
        '        ElseIf .Item(0) = "Old Registration" Then
        '            Me.BtnNew.Enabled = False
        '            Me.BtnNewOutPatient.Enabled = False
        '            Me.BtnOldOutPatientReceipt.Enabled = True
        '            Me.BtnInpatientReceipt.Enabled = True
        '            Me.BtnCashReceipt.Enabled = True
        '        ElseIf .Item(0) = "Cashier" Then
        '            Me.BtnNew.Enabled = False
        '            Me.BtnNewOutPatient.Enabled = False
        '            Me.BtnOldOutPatientReceipt.Enabled = False
        '            Me.BtnInpatientReceipt.Enabled = False
        '            Me.BtnCashReceipt.Enabled = True
        '        End If
        '    End With
        'Next
    End Sub

    Private Sub CboProNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProNo.GotFocus
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
        End With
        'CboProNo.Text = ""
        CboDisNo.Text = ""
        CboCommNo.Text = ""
        TxtAddress.Text = ""
        Me.CboProNo.SelectAll()
    End Sub


    Private Sub CboDisNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboDisNo.GotFocus
        With CboDisNo
            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
        End With
        CboDisNo.Text = ""
        CboCommNo.Text = ""
        TxtAddress.Text = ""
        Me.CboDisNo.SelectAll()
    End Sub



    Private Sub CboCommNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommNo.GotFocus
        With CboCommNo
            .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
        End With
        Me.CboCommNo.SelectAll()
    End Sub

    Private Sub cboProvince_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvince.GotFocus
        With cboProvince
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
            .SelectAll()
        End With
        'cboProvince.Text = ""
        'cboDistrict.Text = ""
        cboCommune.Text = ""
    End Sub

    Private Sub cboProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvince.SelectedIndexChanged

    End Sub

    Private Sub cboDistrict_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDistrict.GotFocus
        With cboDistrict
            .DataSource = ModProvince.SelectDistrict(CInt(cboProvince.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
            .SelectAll()
        End With
        'cboDistrict.Text = ""
        'cboCommune.Text = ""
    End Sub

    Private Sub cboCommune_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCommune.GotFocus
        With cboCommune
            .DataSource = ModProvince.SelectCommune(CInt(cboDistrict.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
            .SelectAll()
        End With
    End Sub


    Private Sub TxtPatientNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TxtNameEng.Focus()
        End If
    End Sub


    Private Sub TxtNameEng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNameEng.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TxtNameKhmer.Focus()
        End If
    End Sub


    Private Sub TxtNameKhmer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNameKhmer.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TxtAgePatient.Focus()
        End If
    End Sub



    Private Sub TxtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTel.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.CboOccupation.Focus()
        End If
    End Sub
    Private Sub TxtOccupation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.CboProNo.Focus()
        End If
    End Sub


    Private Sub txtEngName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEngName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.txtKhmerName.Focus()
        End If
    End Sub


    Private Sub txtKhmerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKhmerName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.cboSex.Focus()
        End If
    End Sub

    Private Sub cboSex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSex.KeyDown
        Select Case e.KeyCode
            Case Keys.F
                Me.cboSex.Text = "F"
            Case Keys.M
                Me.cboSex.Text = "M"
            Case Else
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub GridPatientInformation_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientInformation.SelectionChanged
        Try
            If GridPatientInformation.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
                MainBtnPrintRegistrationForm.Enabled = True
                MNewPatientBook.Enabled = False
                MenuOldPatientBook.Enabled = False
                MInPateintBook.Enabled = False
                MenuRegistrationForm.Enabled = True
                BtnReferToOtherHospital.Enabled = True
                BtnPrintRegistrationFormAgain.Enabled = True
                BtnPrintRegisV2.Enabled = True
                BtnUpdateRegistrationForm.Enabled = True
                BtnShowBook.Enabled = True
                MFree.Enabled = True
                lblSaveOption.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(0).Text
                TxtPatientNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
                TxtNameKhmer.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
                TxtNameEng.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(3).Text
                TxtAgePatient.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
                CboSexPatien.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
                TxtAddress.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
                CboOccupation.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(7).Text
                TxtTel.Text = IIf(UserGlobleVariable.DEPART_NAME.ToUpper = "ADMINISTRATOR", GridPatientInformation.SelectedItems(0).GetRow.Cells(8).Text, "")
                CboProNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(9).Text
                CboDisNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(10).Text
                CboCommNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(11).Text
                DateRegis.Value = GridPatientInformation.SelectedItems(0).GetRow.Cells(12).Value
                CheckIsPatientConsult(GridPatientInformation.GetRow.Cells("PatientNo").Value, 0)
            Else
                MainBtnPrintRegistrationForm.Enabled = False
                BtnReferToOtherHospital.Enabled = False
                BtnPrintRegistrationFormAgain.Enabled = False
                BtnPrintRegisV2.Enabled = False
                BtnUpdateRegistrationForm.Enabled = False
                BtnShowBook.Enabled = False
               
            End If
            If GridPatientInformation.SelectedItems(0).Table.Key = "NewOutPatient" Then
                BtnPrintNewOutPatient.Enabled = True
                MNewPatientBook.Enabled = True
                MainBtnNewPatientBook.Enabled = True
                CreateNewoutPatientBook.Enabled = True
                MPrintPatientNewReceipt.Enabled = True
            Else
                BtnPrintNewOutPatient.Enabled = False
                MainBtnNewPatientBook.Enabled = False
                MNewPatientBook.Enabled = False
                CreateNewoutPatientBook.Enabled = False
                MPrintPatientNewReceipt.Enabled = False
            End If
            If GridPatientInformation.SelectedItems(0).Table.Key = "OldOutPatient" Then
                MenuOldPatientBook.Enabled = True
                BtnPrintOldOutPatient.Enabled = True
                MainBtnOldPatientBook.Enabled = True
                MCreateOldPatient.Enabled = True
                MPrintOldPatientReceipt.Enabled = True

            Else
                BtnPrintOldOutPatient.Enabled = False
                MainBtnOldPatientBook.Enabled = False
                MenuOldPatientBook.Enabled = False
                MCreateOldPatient.Enabled = False
                MPrintOldPatientReceipt.Enabled = False

            End If
            If GridPatientInformation.SelectedItems(0).Table.Key = "Inpatient" Then
                BtnPrintInPatient.Enabled = True
                MaintBtnPrintInPatient.Enabled = True
                MInPateintBook.Enabled = True
                MCreateInpatientBook.Enabled = True
                MPrintInpatientReceipt.Enabled = True
            Else
                MInPateintBook.Enabled = False
                BtnPrintInPatient.Enabled = False
                MaintBtnPrintInPatient.Enabled = False
                MCreateInpatientBook.Enabled = False
                MPrintInpatientReceipt.Enabled = False
            End If
        Catch ex As Exception
            'LblTotalConsult.Text = 0
            'LblConsultFor.Text = "No Consult"
        End Try
       
    End Sub
    Sub LoadPatientBooks(ByVal PatientNo As String)
        GridNewOutpatient.Refresh()
        GridOldOutPatient.Refresh()
        GridInpatient.Refresh()
        GridNewOutpatient.DataSource = ModNew_Outpatient.SelectNewPatientBook(PatientNo)
        GridOldOutPatient.DataSource = ModOld_Outpatient.SelectOldPatientBook(PatientNo)
        GridInpatient.DataSource = ModInPatient.SelectInpatientBook(PatientNo)
    End Sub
    Dim FOld_Outpatient As New FRMOld_Outpatient
    Private Sub GridOldOutPatient_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOldOutPatient.CellDoubleClick
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) <> "Administrator" Then
                    Exit Sub
                    Exit For
                End If
            End With
        Next
        Try
            FOld_Outpatient.LblSaveOption.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(0).Value
            FOld_Outpatient.TxtPatientNo.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(1).Value
            FOld_Outpatient.TxtReceiptNo.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(2).Value
            FOld_Outpatient.TxtPatientName.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(3).Value
            FOld_Outpatient.TxtAge.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(4).Value
            FOld_Outpatient.TxtSex.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(5).Value
            FOld_Outpatient.TxtAddress.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(6).Value
            Dim Riel As String = GridOldOutPatient.Rows(e.RowIndex).Cells(7).Value
            If Riel <> "0" Then
                FOld_Outpatient.RadioDolar.Checked = False
                FOld_Outpatient.RadioRiel.Checked = True
                FOld_Outpatient.TxtPatientFee.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(7).Value
            Else
                FOld_Outpatient.RadioDolar.Checked = True
                FOld_Outpatient.RadioRiel.Checked = False
                FOld_Outpatient.TxtPatientFee.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(8).Value
            End If
            FOld_Outpatient.CboDiagnosis.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(9).Value
            'FOld_Outpatient.ChPrescribed.Checked = GridOldOutPatient.Rows(e.RowIndex).Cells(10).Value
            'FOld_Outpatient.ChDispensed.Checked = GridOldOutPatient.Rows(e.RowIndex).Cells(11).Value
            FOld_Outpatient.ChHearing.Checked = GridOldOutPatient.Rows(e.RowIndex).Cells(12).Value
            FOld_Outpatient.ChUnderstand.Checked = GridOldOutPatient.Rows(e.RowIndex).Cells(13).Value
            FOld_Outpatient.ChSeeing.Checked = GridOldOutPatient.Rows(e.RowIndex).Cells(14).Value
            FOld_Outpatient.ChPhysical.Checked = GridOldOutPatient.Rows(e.RowIndex).Cells(15).Value
            FOld_Outpatient.TxtOther.Text = GridOldOutPatient.Rows(e.RowIndex).Cells(16).Value
            FOld_Outpatient.DateFollowUp.Value = Format(GridOldOutPatient.Rows(e.RowIndex).Cells(17).Value, "MM/dd/yyyy")
            FOld_Outpatient.ShowDialog()
            If FOld_Outpatient.isCloseOld = True Then
                GridOldOutPatient.DataSource = ModOld_Outpatient.SelectOldDetailByReceiptNo(FOld_Outpatient.TxtReceiptNo.Text, FOld_Outpatient.TxtPatientNo.Text)
                ModCommon.NumberAllRowHeaderDataGrid(GridOldOutPatient)
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub OLDPATIENTBOOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFreeOldPatientBook.Click
        Try
            If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim PatientNo As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
                Dim KhName As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
                Dim EngName As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(3).Text
                Dim Age As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
                Dim Sex As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
                Dim Address As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
                LoadOldPatientForm("0", PatientNo, EngName, KhName, Age, Sex, Address, "")
                If DA_Appoint.CheckTotalAppoint(EmptyString(GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Value)) > 0 Then
                    DA_Appoint.UpdateOnAppoint(True, EmptyString(GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Value))
                End If

            End If
        Catch ex As Exception
            MsgBox("Please select patient informatin.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub INPATIENTBOOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFreeInPatientbook.Click
        Try
            If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim PatientNo As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
                Dim KhName As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
                Dim EngName As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(3).Text
                Dim Age As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
                Dim Sex As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
                Dim Address As String = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text

                LoadInPatientForm(Now(), "0", PatientNo, KhName, EngName, Age, Sex, Address)
            End If
        Catch ex As Exception
            MsgBox("Please select patient informatin.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub GridNewOutpatient_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridNewOutpatient.CellDoubleClick
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) <> "Administrator" Then
                    Exit Sub
                    Exit For
                End If
            End With
        Next
        Try
            'Dim PatientFee As Integer
            Dim New_OutPatient As New FRMNew_Outpatient
            New_OutPatient.LblSaveOption.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(0).Value
            New_OutPatient.TxtPatientNo.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(1).Value
            New_OutPatient.TxtReceiptNo.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(3).Value
            New_OutPatient.TxtPatientName.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(5).Value
            New_OutPatient.TxtAge.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(6).Value
            New_OutPatient.TxtSex.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(7).Value
            New_OutPatient.TxtAddress.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(8).Value
            Dim Riel As String = GridNewOutpatient.Rows(e.RowIndex).Cells(9).Value
            If Riel <> "0" Then
                New_OutPatient.RadioDolar.Checked = False
                New_OutPatient.RadioRiel.Checked = True
                New_OutPatient.TxtPatientFee.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(9).Value
            Else
                New_OutPatient.RadioDolar.Checked = True
                New_OutPatient.RadioRiel.Checked = False
                New_OutPatient.TxtPatientFee.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(10).Value
            End If
            New_OutPatient.CboDiagnosis.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(11).Value
            New_OutPatient.ChPrescribed.Checked = GridNewOutpatient.Rows(e.RowIndex).Cells(12).Value
            New_OutPatient.ChDispensed.Checked = GridNewOutpatient.Rows(e.RowIndex).Cells(13).Value
            New_OutPatient.ChHearing.Checked = GridNewOutpatient.Rows(e.RowIndex).Cells(14).Value
            New_OutPatient.ChUnderstand.Checked = GridNewOutpatient.Rows(e.RowIndex).Cells(15).Value
            New_OutPatient.ChSeeing.Checked = GridNewOutpatient.Rows(e.RowIndex).Cells(16).Value
            New_OutPatient.ChPhysical.Checked = GridNewOutpatient.Rows(e.RowIndex).Cells(17).Value
            New_OutPatient.TxtOther.Text = GridNewOutpatient.Rows(e.RowIndex).Cells(18).Value
            New_OutPatient.DateFollowUp.Value = Format(GridNewOutpatient.Rows(e.RowIndex).Cells(19).Value, "MM/dd/yyyy")
            New_OutPatient.ShowDialog()
            If New_OutPatient.isNewClose = True Then
                GridNewOutpatient.DataSource = ModNew_Outpatient.SelectNewOutNo(EmptyString(New_OutPatient.LblSaveOption.Text))
                NumberAllRowHeaderDataGrid(GridNewOutpatient)
            End If
            New_OutPatient.Dispose()
            New_OutPatient.Close()
        Catch ex As Exception

        End Try
    End Sub
  

    

    Private Sub MenuCreateOldPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCreateOldPatient.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "OldOutPatient" Then
            Dim FOldPatient As New FRMOld_Outpatient
            FOldPatient.TxtReceiptNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(0).Text
            FOldPatient.TxtReceiptNo.ReadOnly = True
            FOldPatient.TxtPatientNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            FOldPatient.TxtPatientName.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
            FOldPatient.TxtAge.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(3).Text
            FOldPatient.TxtSex.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
            FOldPatient.TxtAddress.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
            FOldPatient.TxtPatientFee.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
            FOldPatient.ShowDialog()
            FOldPatient.Close()
            FOldPatient.Dispose()
        End If
    End Sub

    Private Sub CreateInPatientBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCreateInpatientBook.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "Inpatient" Then
            Dim FIn_Patient As New FRMIn_patient
            FIn_Patient.TxtReceiptNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            FIn_Patient.TxtReceiptNo.ReadOnly = True
            FIn_Patient.TxtPatientNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(0).Text
            FIn_Patient.TxtPatientName.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
            FIn_Patient.TxtAge.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(3).Text
            FIn_Patient.TxtSex.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
            FIn_Patient.TxtAddress.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
            FIn_Patient.TxtHosFee.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
            FIn_Patient.ShowDialog()
            FIn_Patient.Close()
            FIn_Patient.Dispose()
        End If
    End Sub
    Dim frmReportNOPR As New frmReportNewOutPatientReceipt
    Private Sub MenuPrintNewReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintPatientNewReceipt.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "NewOutPatient" Then
            Dim ReceiptNo = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            Try
                ReportNOPR.SetDataSource(MNewOutpatientReceipt.ReportNewOutpatientReceipt(ReceiptNo).Tables(1))
                ReportNOPR.Refresh()
                frmReportNOPR.crvReportNewOutPatientReceipt.ReportSource = ReportNOPR
                frmReportNOPR.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
            End Try
        End If
    End Sub
    Dim ReportOOPR As New ReportOldOutPatientReceipt
    Dim frmReportOOPR As New frmReportOldOutPatientReceipt
    Private Sub PrintOldPatientReceiptAgianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintOldPatientReceipt.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "OldOutPatient" Then
            Dim ReceiptNo = GridPatientInformation.SelectedItems(0).GetRow.Cells(0).Text
            ReportOOPR.SetDataSource(MOldOutpatientReceipt.ReportOldOutpatientReceipt(ReceiptNo).Tables(1))
            frmReportOOPR.crvReportOldOutPatientReceipt.ReportSource = ReportOOPR
            ReportOOPR.Refresh()
            frmReportOOPR.ShowDialog()
        End If
    End Sub
    Dim frmReportInPR As New frmReportInpatientReceipt
    '-------------Report Form Active--------------------------------
    Dim ReportInPR As New ReportInpatientReceipt
    Private Sub PrintInPatientReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPrintInpatientReceipt.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "Inpatient" Then
            Dim ReceiptNo = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            ReportInPR.SetDataSource(MInpatientReceipt.ReportInpatientReceipt(ReceiptNo).Tables(1))
            frmReportInPR.crvInpatientReceipt.ReportSource = ReportInPR
            ReportInPR.Refresh()
            frmReportInPR.ShowDialog()
        End If
    End Sub

    Private Sub BtnPatientAchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatientAchive.Click
        Dim FAchieveNew As New FormForNewOutpatientAchive
        If FAchieveNew.ShowDialog = DialogResult.OK Then
            LoadPatientBooks(FAchieveNew.txtHN.Text)

        End If
        FAchieveNew.Dispose()
        FAchieveNew.Close()
        'Dim FAchieveNew As New FRMAChievNew()
        'Dim DiagnosisTem As String
        'FAchieveNew.ShowDialog()
        'If FAchieveNew.isClose = True Then
        'LoadOldPatientReceipt(FAchieveNew.TxtNewPatientNo.Text, FAchieveNew.TxtNameKhmer.Text, FAchieveNew.TxtNameEng.Text, FAchieveNew.TxtAgePatient.Text, FAchieveNew.CboSexPatien.Text, FAchieveNew.TxtAddress.Text)
        'End If
        'FAchieveNew.Dispose()
        'FAchieveNew.Close()
    End Sub

   
    
    Private Sub GridInpatient_CellDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridInpatient.CellDoubleClick
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) <> "Administrator" Then
                    Exit Sub
                    Exit For
                End If
            End With
        Next
        'Try
        Dim FInpatient As New FRMIn_patient
        Dim SosialMoney As Integer
        Dim FullMoney As Integer
        FInpatient.LblSaveOption.Text = GridInpatient.Rows(e.RowIndex).Cells("InNo").Value
        FInpatient.TxtPatientNo.Text = GridInpatient.Rows(e.RowIndex).Cells("PatientNo1").Value
        FInpatient.TxtReceiptNo.Text = GridInpatient.Rows(e.RowIndex).Cells("ReceiptNo1").Value
        FInpatient.TxtPatientName.Text = GridInpatient.Rows(e.RowIndex).Cells("NameKhmer3").Value
        FInpatient.TxtAge.Text = GridInpatient.Rows(e.RowIndex).Cells("Age1").Value
        FInpatient.TxtSex.Text = GridInpatient.Rows(e.RowIndex).Cells("Sex1").Value
        FInpatient.TxtAddress.Text = GridInpatient.Rows(e.RowIndex).Cells("Address1").Value
        FInpatient.CboDiagnosis.Text = GridInpatient.Rows(e.RowIndex).Cells("Diagnosis1").Value
        FInpatient.CboOperationType.Text = GridInpatient.Rows(e.RowIndex).Cells("TypeOfOperation").Value
        FInpatient.TxtHosFee.Text = GridInpatient.Rows(e.RowIndex).Cells("HosFee").Value
        ' Money as riel
        SosialMoney = GridInpatient.Rows(e.RowIndex).Cells("SocialFee").Value
        If SosialMoney <> 0 Then
            FInpatient.TxtSosialServiceFee.Text = GridInpatient.Rows(e.RowIndex).Cells("SocialFee").Value
            FInpatient.RRielSSFee.Checked = True
        Else
            FInpatient.TxtSosialServiceFee.Text = GridInpatient.Rows(e.RowIndex).Cells("DolarSosial").Value
            FInpatient.RDolarSSFee.Checked = True
        End If
        ' Money Full fee as riel
        FullMoney = GridInpatient.Rows(e.RowIndex).Cells("FullFee").Value
        If FullMoney <> 0 Then
            FInpatient.TxtFullFee.Text = GridInpatient.Rows(e.RowIndex).Cells("FullFee").Value
            FInpatient.RReilFFee.Checked = True
        Else
            FInpatient.TxtFullFee.Text = GridInpatient.Rows(e.RowIndex).Cells("DolarFull").Value
            FInpatient.RDolarFFee.Checked = True
        End If
        FInpatient.TxtOther.Text = GridInpatient.Rows(e.RowIndex).Cells("Other1").Value
        FInpatient.DateIn.Value = Format(GridInpatient.Rows(e.RowIndex).Cells("CreateDate1").Value, "MM/dd/yyyy")
        FInpatient.ShowDialog()
        If FInpatient.isCloseIn = True Then
            GridInpatient.DataSource = ModInPatient.SelectInpatientDetailByReceipt(EmptyString(FInpatient.TxtReceiptNo.Text), FInpatient.TxtPatientNo.Text)
            ModCommon.NumberAllRowHeaderDataGrid(GridInpatient)
        End If
        'Catch ex As Exception

        'End Try
    End Sub


    Private Sub TxtOldPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOldPatientNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.txtEngName.Focus()
        End If
    End Sub

    Private Sub CreateNewoutPatientBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewoutPatientBook.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "NewOutPatient" Then
            Dim FNewOutPatient As New FRMNew_Outpatient
            FNewOutPatient.LblSaveOption.Text = 0
            FNewOutPatient.TxtReceiptNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            FNewOutPatient.TxtPatientNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
            FNewOutPatient.TxtReceiptNo.ReadOnly = True
            FNewOutPatient.TxtPatientName.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(3).Text
            FNewOutPatient.TxtAge.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
            FNewOutPatient.TxtSex.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
            FNewOutPatient.TxtAddress.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
            If GridPatientInformation.SelectedItems(0).GetRow.Cells(7).Text <> "0" Then
                FNewOutPatient.TxtPatientFee.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(7).Text
                FNewOutPatient.RadioRiel.Checked = True
            Else
                FNewOutPatient.TxtPatientFee.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(8).Text
                FNewOutPatient.RadioDolar.Checked = True
            End If

            FNewOutPatient.ShowDialog()
            FNewOutPatient.Close()
            FNewOutPatient.Dispose()
        End If
    End Sub

    Private Sub PatientReferToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientReferToToolStripMenuItem.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
            Dim FRefer As New FrmRefer
            FRefer.TxtPatientNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            FRefer.TxtPatientName.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
            FRefer.TxtAge.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
            FRefer.TxtSex.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
            FRefer.TxtAddress.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
            FRefer.ShowDialog()
            FRefer.Close()
            FRefer.Dispose()
        End If

    End Sub
   
    Dim CheckPanel As Boolean = False
    Private Sub TShowPatientBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowBook.Click
        If CheckPanel = False Then
            If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
                SplitContainer2.Panel2Collapsed = False
                CheckPanel = True
                Dim PatientNo As Long = GridPatientInformation.GetRow.Cells(1).Text
                LoadPatientBooks(PatientNo)
            End If

        Else
            SplitContainer2.Panel2Collapsed = True
            CheckPanel = False
        End If
    End Sub

    Private Sub BtnPrintNewOutPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintNewOutPatient.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "NewOutPatient" Then
            Dim ReceiptNo = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            Try
                ReportNOPR.SetDataSource(MNewOutpatientReceipt.ReportNewOutpatientReceipt(ReceiptNo).Tables(1))
                ReportNOPR.Refresh()
                frmReportNOPR.crvReportNewOutPatientReceipt.ReportSource = ReportNOPR
                frmReportNOPR.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
            End Try
        End If
    End Sub

    Private Sub BtnPrintOldOutPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintOldOutPatient.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "OldOutPatient" Then
            Dim ReceiptNo = GridPatientInformation.SelectedItems(0).GetRow.Cells(0).Text
            ReportOOPR.SetDataSource(MOldOutpatientReceipt.ReportOldOutpatientReceipt(ReceiptNo).Tables(1))
            frmReportOOPR.crvReportOldOutPatientReceipt.ReportSource = ReportOOPR
            ReportOOPR.Refresh()
            frmReportOOPR.ShowDialog()
        End If
    End Sub

    Private Sub BtnPrintInPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintInPatient.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "Inpatient" Then
            Dim ReceiptNo = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            ReportInPR.SetDataSource(MInpatientReceipt.ReportInpatientReceipt(ReceiptNo).Tables(1))
            frmReportInPR.crvInpatientReceipt.ReportSource = ReportInPR
            ReportInPR.Refresh()
            frmReportInPR.ShowDialog()
        End If
    End Sub

   
    Private Sub BtnPrintRegistrationForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
        '    ShowRegistrationFormByNew()
        'End If
    End Sub

    Private Sub BtnReferToOtherHospital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReferToOtherHospital.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
            Dim FRefer As New FrmRefer
            FRefer.TxtPatientNo.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(1).Text
            FRefer.TxtPatientName.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(2).Text
            FRefer.TxtAge.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(4).Text
            FRefer.TxtSex.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(5).Text
            FRefer.TxtAddress.Text = GridPatientInformation.SelectedItems(0).GetRow.Cells(6).Text
            FRefer.ShowDialog()
            FRefer.Close()
            FRefer.Dispose()
        End If
    End Sub

    Private Sub BtnUpdateRegistrationForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateRegistrationForm.Click
        If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
            ShowRegistrationFormByNew()
        End If
    End Sub

    Private Sub BtnPrintRegistrationFormAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintRegistrationFormAgain.Click
        Try
            If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim frmReportForm As New ReportForm
                'Dim rowIndex As Int16 = GridPatientInformation.GetRow.Cells("").Value
                GLOBLE_PATIENT_NO = GridPatientInformation.GetRow.Cells("PatientNo").Value 'GridPatientFollowUp.Rows(rowIndex).Cells(1).Value
                frmReportForm.LoadRegistrationForm()
                frmReportForm.ShowDialog()
                frmReportForm.Close()
                frmReportForm.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Please select follow up.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnMoPoTsyo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMoPoTsyo.Click
        Dim FMoPoTsypo As New FormMainPoMoSypo
        FMoPoTsypo.ShowDialog()
        FMoPoTsypo.Close()
        FMoPoTsypo.Dispose()
    End Sub

    Private Sub GridPatientInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientInformation.Click
        Try
            If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
                'SplitContainer2.Panel2Collapsed = False
                'CheckPanel = True
                Dim PatientNo As Double = GridPatientInformation.GetRow.Cells(1).Text
                LoadPatientBooks(PatientNo)
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub BtnPrintRegisV2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintRegisV2.Click
        Try
            If GridPatientInformation.SelectedItems(0).Table.Key = "PatientInfo" Then
                Dim frmReportForm As New ReportForm
                'Dim rowIndex As Int16 = GridPatientInformation.GetRow.Cells("").Value
                GLOBLE_PATIENT_NO = GridPatientInformation.GetRow.Cells("PatientNo").Value 'GridPatientFollowUp.Rows(rowIndex).Cells(1).Value
                frmReportForm.LoadRegistrationFormV2()
                frmReportForm.ShowDialog()
                frmReportForm.Close()
                frmReportForm.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Please select follow up.", MsgBoxStyle.Critical)
        End Try
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.V_NewoutpatientTableAdapter.Fill(Me.DSPatient.V_Newoutpatient)
        Me.V_OldOutpatientTableAdapter.Fill(Me.DSPatient.V_OldOutpatient)
        Me.V_InpatientTableAdapter.Fill(Me.DSPatient.V_Inpatient)
    End Sub
End Class
