Imports System.Data.Common

Public Class frmPrescription

    Dim UPrescripList As UCPrescriptionList
    '--- For edit Prescription purpose
    Dim DoctorDataAdapter As New DSPharmacyTableAdapters.TblDoctorTableAdapter
    Dim PatientDataAdapter As New DSPharmacyTableAdapters.TblPatientsTableAdapter
    Dim DA_New_Old_Adapter As New DSPharmacy_V1TableAdapters.TblNew_Old_OutPatientTableAdapter
    Dim TblPatient As DataTable
    Dim PrescripDataAdapter As New DSPharmacyTableAdapters.VPRESCRIP_MAIN_INVENTORYTableAdapter
    Dim PrescripItemDataAdapter As New DSPharmacyTableAdapters.VPRESCRIP_DETAIL_INVENTORYTableAdapter
    Dim SurgeryDataAdapter As New DSPharmacyTableAdapters.TblSurgeryTableAdapter

    Private THIDataContext As New BaseDataContext
    Dim DTblTemPrescripDetail As DataTable = New DSPharmacy.TmpPrescripDetailDataTable
    Dim DiagnosisDataAdapter As DSPharmacyTableAdapters.TblSurgeryTableAdapter
    Public PrescripID As Double

    Dim DA_Surgery As New DSConsultTableAdapters.tblDiagSurgeriesTableAdapter

    Dim DAPatient As New DSCustomerTableAdapters.TblPatientsTableAdapter
    Dim DA_ConApp As New DSConsultTableAdapters.CONSULING_APPOINTMENTTableAdapter

    '' Add adjust corrent drunk.
    Dim ItemUnitDataAdapter As DSItemUnitTableAdapters.tblItemUnitTableAdapter
    Dim MedicineDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim DepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Dim ContainerDataAdapter As DSContainerTableAdapters.tblContainerTableAdapter
    Dim LabourDataAdapter As DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
    Dim DACheckItemStock As New DSPharmacyTableAdapters.VPRESCRIP_CHECK_STOCKTableAdapter
    Dim DA_PTrackingTime As New DataReportUtilityTableAdapters.PATIENT_TIMETRACKINGTableAdapter
    Public Sub New(ByVal pMainPrescrip As UCPrescriptionList)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UPrescripList = pMainPrescrip
        With CboSecondSurgery
            .DataSource = DA_Surgery.GetData
            .ValueMember = DA_Surgery.GetData.Columns("SID").ColumnName
            .DisplayMember = DA_Surgery.GetData.Columns("Surgeries").ColumnName
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LblLoading.Visible = True
        'PictLoading.Visible = True
        CboPatient.Focus()
        CboPatient.Select()
        CboPatient.SelectAll()
        DiagnosisDataAdapter = New DSPharmacyTableAdapters.TblSurgeryTableAdapter
        With CbDiagnosis
            .DataSource = DiagnosisDataAdapter.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgery"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        With CboDoctor
            .DataSource = DoctorDataAdapter.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With

        If LblSaveStatus.Text = "1" Then  '--- Editable mode
            '--- Get Prescription information
            Dim DTblPrescrip As DataTable = PrescripDataAdapter.GetDataPrescipByID(PrescripID)
            For Each row As DataRow In DTblPrescrip.Rows
                If TypeOf row("PatientNo") Is DBNull = False Then
                    '--- Get Pateint's Prescription information
                    Dim DTblPatient As DataTable = PatientDataAdapter.GetDataPatientByID(row("PatientNo"))
                    GetPrescripPatientInfo(DTblPatient)
                End If

                If TypeOf row("DoctorNo") Is DBNull = False Then
                    '--- Get Pateint's Prescription information
                    TxtDoctorNo.Text = row("DoctorNo")
                    Dim DTblDoctor As DataTable = DoctorDataAdapter.GetDataDoctorByID(row("DoctorNo"))
                    GetPrescripDoctorInfo(DTblDoctor)

                End If
                '--- Get item Prescription
                Dim DTblPrescripItem As DataTable = PrescripItemDataAdapter.GetDataPrescipItemsByPrescipID(PrescripID)
                GetPrescripItemInfo(DTblPrescripItem)

                If TypeOf row("DiagnosisID") Is DBNull = False Then
                    '--- Get Pateint's Prescription information
                    CbDiagnosis.SelectedValue = row("DiagnosisID")
                End If

                If TypeOf row("IssueDate") Is DBNull = False Then DateCreatePrescrip.Value = row("IssueDate")

            Next

        End If



        '' Load data to Add drug module.
        ItemUnitDataAdapter = New DSItemUnitTableAdapters.tblItemUnitTableAdapter
        'MedicineDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        MedicineDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        ContainerDataAdapter = New DSContainerTableAdapters.tblContainerTableAdapter
        LabourDataAdapter = New DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
        '--- Initial ItemUnit
        With cbItemUnit
            .DataSource = ItemUnitDataAdapter.GetData
            .ValueMember = "ItemUnitID"
            .DisplayMember = "ItemUnitName"
            '.SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With

        '--- Initial Medicine in Hospital
        With CboItemName
            .DataSource = MedicineDataAdapter.GetItemDataByDepartID(PHARMACY_DEPART_ID)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"

            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With
        With CboOpticalShop
            .DataSource = MedicineDataAdapter.GetItemDataByDepartID(OPTICALSHOP_DEPART_ID)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With
        '--- Initial Remark
        With cbRemark
            .Items.Add("Free In Pharmacy")
            .Items.Add("Outside-Purchase")
            .Items.Add("Item In Optical-Shop")
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = 0
        End With


        With cbItemContainer
            .DataSource = ContainerDataAdapter.GetData
            .ValueMember = "ContainerID"
            .DisplayMember = "ContainerName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbLabourFac
            .DataSource = LabourDataAdapter.GetData
            .ValueMember = "LabourFacID"
            .DisplayMember = "LabourFacName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        cbRemark.Enabled = False
        '---
        TxtItemName.Enabled = False
    End Sub

    Sub GetPrescripPatientInfo(ByVal DTPatient As DataTable)
        For Each row As DataRow In DTPatient.Rows
            If TypeOf row("PatientNo") Is DBNull = False Then
                TxtPatientNoReal.Text = row("PatientNo")
                TxtTempPatientNo.Text = row("PatientNo")
            End If

            If TypeOf row("PatientNo") Is DBNull = False Then TxtPatientNoReal.Text = row("PatientNo")
            If TypeOf row("NameEng") Is DBNull = False Then TxtPatientName.Text = row("NameEng")
            If TypeOf row("NameKhmer") Is DBNull = False Then TxtNameKh.Text = row("NameKhmer")
            If TypeOf row("Occupation") Is DBNull = False Then TxtPatOccupation.Text = row("Occupation")
            If TypeOf row("Sex") Is DBNull = False Then TxtPatSex.Text = row("Sex")
            If TypeOf row("Age") Is DBNull = False Then TxtPatAge.Text = row("Age")
            If TypeOf row("Address") Is DBNull = False Then txtAddress.Text = row("Address")

        Next

    End Sub
    Sub GetPrescripDoctorInfo(ByVal DTDoctor As DataTable)
        For Each row As DataRow In DTDoctor.Rows
            If TypeOf row("DoctorName") Is DBNull = False Then CboDoctor.Text = row("DoctorName")
            If TypeOf row("Sex") Is DBNull = False Then TxtDocSex.Text = row("Sex")
        Next
    End Sub
    Sub GetPrescripItemInfo(ByVal DTPrescipItem)

        For Each row As DataRow In DTPrescipItem.Rows
            Dim obj(7) As Object
            With GridMedicine
                If TypeOf row("ItemID") Is DBNull = False Then
                    obj(0) = row("ItemID")
                Else
                    obj(0) = ""
                End If

                If TypeOf row("ItemName") Is DBNull = False Then obj(1) = row("ItemName")
                If TypeOf row("ItemQuantity") Is DBNull = False Then obj(2) = row("ItemQuantity")

                If TypeOf row("ItemUnitID") Is DBNull = False Then
                    obj(3) = row("ItemUnitID")
                Else
                    obj(3) = ""
                End If
                If TypeOf row("Remark") Is DBNull = False Then
                    obj(4) = row("Remark")
                Else
                    obj(4) = ""
                End If

                If TypeOf row("IsOutsideMedicine") Is DBNull = False Then
                    obj(5) = row("IsOutsideMedicine")
                Else
                    obj(5) = ""
                End If

                If TypeOf row("ContainerName") Is DBNull = False Then
                    obj(6) = row("ContainerName")
                Else
                    obj(6) = ""
                End If

                If TypeOf row("LabourFacName") Is DBNull = False Then
                    obj(7) = row("LabourFacName")
                Else
                    obj(7) = ""
                End If
                .Rows.Add(obj)
            End With
        Next

    End Sub

    Private Sub FindPatientInfo()
        'If Me.InvokeRequired Then
        '    Me.Invoke(New MethodInvoker(AddressOf FindPatientInfo))
        'Else
        If ValidateTextField(CboPatient, "", ErrorPrescription) = False Then Exit Sub
        'If PatientOption = 1 Then '--- Optical Shop Invoice
        'If CheckExistingInCustomerList(TxtPatientNo.Text) > 0 Then
        '    MessageBox.Show("The patient already add to optical shop's old customer.", "Please go to select in customer list.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'Else
        If RadPatientNo.Checked = True Then
            GridPatientInformation.DataSource = DAPatient.GetDataByPatientNo(EmptyString(CboPatient.Text))
        End If
        If RadPatientName.Checked = True Then
            GridPatientInformation.DataSource = DAPatient.SelectPatientName("%" & CboPatient.Text & "%")
            'End If

        End If
        'Else '--- NIL
        '    GridPatientInformation.DataSource = DAPatient.GetDataByPatientNo(TxtPatientNo.Text)
        'End If
        'End If

    End Sub

    Private Sub BtnBrowsePatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowsePatient.Click

        FindPatientInfo()
        

    End Sub

    Private Sub BtnBrowseDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowseDoctor.Click

        Dim FBrowseDoctor As New frmBrowseDoctor
        If FBrowseDoctor.ShowDialog = DialogResult.OK Then
            TxtDoctorNo.Text = FBrowseDoctor.DoctorNo
            TxtDocSex.Text = FBrowseDoctor.DocSex
            CboDoctor.Text = FBrowseDoctor.DoctorName

        End If

    End Sub

    Private Sub TxtPatientNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If CboPatient.Text <> "" Then
            Try
                Dim TPatient = From patient In THIDataContext.getTHIDataContext.TblPatients Where patient.PatientNo = Val(CboPatient.Text)
                Dim TmpPatient As TblPatient = TPatient.SingleOrDefault

                CboPatient.Text = TmpPatient.PatientNo
                TxtPatientName.Text = TmpPatient.NameEng
                TxtPatSex.Text = TmpPatient.Sex
                TxtPatOccupation.Text = TmpPatient.Occupation
                txtAddress.Text = TmpPatient.Address
                TxtPatAge.Text = TmpPatient.Age
                TxtTempPatientNo.Text = TmpPatient.PatientNo

            Catch ex As Exception
                MessageBox.Show("Patient No does not exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CboPatient.Text = ""
                TxtPatientName.Text = ""
                TxtPatSex.Text = ""
                TxtPatOccupation.Text = ""
                txtAddress.Text = ""
                TxtPatAge.Text = ""
                TxtTempPatientNo.Text = ""
            End Try
        End If
    End Sub


    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAddMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMedicine.Click
        AddItem()
        'Dim FAddNewMedicine As New frmAddDrug(Me)
        'FAddNewMedicine.ShowDialog()

    End Sub

    Sub AddItem()
        If RbDrugOutsideHos.Checked = True Then
            If ValidateTextField(TxtItemName, "", ErrorPrescription) = False Then Exit Sub
        End If
        If RbDrugInHos.Checked = True Then
            If ValidateCombobox(CboItemName, "", ErrorPrescription) = False Then Exit Sub
        End If
        If RadItemInOpticalShop.Checked = True Then
            If ValidateCombobox(CboOpticalShop, "", ErrorPrescription) = False Then Exit Sub
        End If
        If ValidateTextField(TxtQuantity, "", ErrorPrescription) = False Then Exit Sub

        If RbDrugInHos.Checked = True Then
            If Val(TxtQuantity.Text) > Val(TxtUnitsInStock.Text) Then
                MessageBox.Show("Item quantity cannot greater than quantity present in stock.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If MessageBox.Show("Do you want to add this medicine ?", "medicine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If RbDrugInHos.Checked = True Then
                Me.AddMedicineDetail(CboItemName.SelectedValue, CboItemName.Text, cbItemUnit.SelectedValue, CInt(TxtQuantity.Text), 1, cbRemark.Text, 0, 0)
            End If

            If RbDrugOutsideHos.Checked = True Then
                Me.AddMedicineDetail(0, TxtItemName.Text, cbItemUnit.SelectedValue, CInt(TxtQuantity.Text), 0, cbRemark.Text, cbItemContainer.SelectedValue, cbLabourFac.SelectedValue)
            End If

            If RadItemInOpticalShop.Checked = True Then
                Me.AddMedicineDetail(CboOpticalShop.SelectedValue, CboOpticalShop.Text, cbItemUnit.SelectedValue, CInt(TxtQuantity.Text), 2, cbRemark.Text, 0, 0)
            End If

            RbDrugInHos.Focus()
            CleanMedicine()
            CboItemName.SelectAll()
            CboItemName.Select()
        End If

    End Sub
    Sub CleanMedicine()
        Try
            CboItemName.SelectedIndex = -1
            TxtItemName.Text = ""
            cbItemUnit.SelectedIndex = -1
            TxtQuantity.Text = ""
            cbRemark.SelectedIndex = 0
            CboItemName.Text = ""
        Catch ex As Exception
            CboItemName.SelectedIndex = -1
            CboItemName.Text = ""
            TxtQuantity.Text = ""
        End Try

    End Sub
    Private Sub TxtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQuantity.KeyPress
        SetDisableKeyString(e)
       
    End Sub

    Private Sub CboItemName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboItemName.Leave
        TxtQuantity.SelectAll()
        TxtQuantity.Select()
    End Sub

    Private Sub CboItemName_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItemName.SelectedValueChanged
        Dim TotalItem As Integer = 0
        Dim CurrentStock As Integer = 0
        Try
            TotalItem = DACheckItemStock.SelectTotalQTYItem(CboItemName.SelectedValue)
        Catch ex As Exception

        End Try
        Try

            CurrentStock = (DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), CInt(CboItemName.SelectedValue)))

        Catch ex As Exception
        End Try
        TxtUnitsInStock.Text = CurrentStock - TotalItem
       
    End Sub
    Sub AddMedicineDetail(ByVal ItemID As Integer, ByVal ItemName As String, ByVal ItemUnit As Integer, _
                           ByVal Qty As Integer, ByVal IsOutsideMedicine As Integer, _
                           ByVal Remark As String, ByVal ItemContainer As Integer, ByVal ItemLabourFac As Integer)
        Try
            If ItemID <> 0 Then
                For i As Integer = 0 To GridMedicine.Rows.Count - 1
                    If ItemID = GridMedicine.Rows(i).Cells("cItemID").Value Then
                        MessageBox.Show("This medicine already exist, could you check againt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            Else
                For i As Integer = 0 To GridMedicine.Rows.Count - 1
                    If ItemName = GridMedicine.Rows(i).Cells("cItemName").Value Then
                        MessageBox.Show("This medicine already exist, could you check againt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            End If

            Dim obj(7) As Object
            With GridMedicine
                obj(0) = ItemID
                obj(1) = ItemName
                obj(2) = Qty
                obj(3) = ItemUnit
                obj(4) = Remark
                obj(5) = IsOutsideMedicine
                obj(6) = ItemContainer
                obj(7) = ItemLabourFac
                .Rows.Add(obj)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnRemveMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemveMedicine.Click
        With GridMedicine
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete item Request Detail ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If ValidateTextField(TxtPatientNoReal, "", ErrorPrescription) = False Then Exit Sub
        If ValidateCombobox(CboDoctor, "", ErrorPrescription) = False Then Exit Sub
        If ValidateCombobox(CbDiagnosis, "", ErrorPrescription) = False Then Exit Sub

        If GridMedicine.Rows.Count = 0 Then
            MessageBox.Show("Cannot save new prescription without medicine.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ModDiagnosis.CheckNameDiagnosis(CbDiagnosis.Text) = 0 Then
            MsgBox("Daignosis not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
            CbDiagnosis.Select()
            CbDiagnosis.SelectAll()
            Exit Sub
        End If
        If DateApp.Checked = True Then
            'If ValidateCombobox(CboSecondSurgery, "", ErrorPrescription) = False Then Exit Sub
            If ValidateCombobox(CboEye, "", ErrorPrescription) = False Then Exit Sub
        End If
        If LblSaveStatus.Text = "0" Then '--- Add new prescription
            If MessageBox.Show("Do you want save new Prescription ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try
                    '--- Insert table PRESCRIPTION_INVENTORY
                    Dim TPrescripInventory As New PRESCIP_INVENTORY
                    TPrescripInventory.PatientNo = Val(TxtPatientNoReal.Text)
                    TPrescripInventory.DoctorNo = Val(TxtDoctorNo.Text)
                    TPrescripInventory.IssueDate = DateCreatePrescrip.Value.Date
                    TPrescripInventory.DiagnosisID = CbDiagnosis.SelectedValue
                    TPrescripInventory.Status = 0 'Indicate that prescription not yet give medicine to patient .
                    TPrescripInventory.PrescriptionNote = TxtPrescriptionNote.Text
                    TPrescripInventory.TIME_CREATE = Format(GetDateServer, "hh:mm:ss tt").ToString
                    THIDataContext.getTHIDataContext.PRESCIP_INVENTORies.InsertOnSubmit(TPrescripInventory)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '--- Insert table PRSCRIP_DETAIL_INVENTORY
                    For Each row As DataGridViewRow In GridMedicine.Rows

                        Dim TPrescripDetail As New PRESCRIP_DETAIL_INVENTORY
                        TPrescripDetail.PrescripID = TPrescripInventory.PrescripID
                        TPrescripDetail.ItemID = row.Cells("cItemID").Value
                        TPrescripDetail.ItemName = row.Cells("cItemName").Value
                        TPrescripDetail.IsOutsideMedicine = row.Cells("cIsOutsideMedicine").Value
                        TPrescripDetail.ItemUnitID = row.Cells("cItemUnitID").Value
                        TPrescripDetail.ItemQuantity = Val(row.Cells("cQuantity").Value)
                        TPrescripDetail.Remark = row.Cells("cRemark").Value

                        THIDataContext.getTHIDataContext.PRESCRIP_DETAIL_INVENTORies.InsertOnSubmit(TPrescripDetail)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        If row.Cells("cIsOutsideMedicine").Value = 0 Then
                            '--- Validate item name already exist
                            Dim myItemOutSide = From IOS In THIDataContext.getTHIDataContext.ITEM_OUTSIDE_INVENTORies Where IOS.ItemName.ToUpper = row.Cells("cItemName").Value.ToString.ToUpper
                            If myItemOutSide.ToList.Count = 0 Then
                                '--- Insert table ITEM_OUTSIDE_INVENTORY
                                Dim TItemOutSide As New ITEM_OUTSIDE_INVENTORY
                                TItemOutSide.ItemName = row.Cells("cItemName").Value
                                TItemOutSide.Quantity = Val(row.Cells("cQuantity").Value)
                                TItemOutSide.PrescripID = TPrescripInventory.PrescripID
                                TItemOutSide.DepartID = CInt(DEPART_ID)
                                TItemOutSide.IsRegistered = False
                                TItemOutSide.ContainerID = row.Cells("ContainerID").Value
                                TItemOutSide.LabourFacID = row.Cells("LabourFacID").Value
                                TItemOutSide.RegisterDate = DateCreatePrescrip.Value.Date

                                THIDataContext.getTHIDataContext.ITEM_OUTSIDE_INVENTORies.InsertOnSubmit(TItemOutSide)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Else ' In Case item outside invetory already register update quantity
                                Dim TItemOutSide As ITEM_OUTSIDE_INVENTORY = myItemOutSide.SingleOrDefault
                                TItemOutSide.Quantity = TItemOutSide.Quantity + Val(row.Cells("cQuantity").Value)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            End If
                        End If
                    Next

                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox(ex.Message)
                    THIDataContext.getTHIDataContext.Connection.Close()
                Finally
                    DA_PTrackingTime.UpdatePharmacy(Format(Now, "hh:mm:ss tt").ToString, TxtPatientNoReal.Text, CheckMarkEOD().Date)
                    ':::::::::::::::::: Update Diagnosis in New or Old patient Books :::::::::::::::::::::::::::::
                    If LblNew_OldID.Text <> "0" Then
                        ModNew_Outpatient.EnterPatientDiagnosis(LblNew_OldID.Text, CbDiagnosis.Text)
                    End If
                    If DateApp.Checked = True Then
                        DA_ConApp.InsertNewApp(CDbl(EmptyString(TxtPatientNoReal.Text)), TxtNameKh.Text, "", TxtPatSex.Text, TxtPatAge.Text, Now.Date, DateApp.Value.Date, False, TxtPrescriptionNote.Text, "", False, CbDiagnosis.Text, CboSecondSurgery.Text, CboEye.Text, TxtTel.Text, "Pharmacy", CboDoctor.SelectedValue, CboDoctor.Text)
                    End If
                    trans = Nothing
                    UPrescripList.CheckStatusGive(0)

                    MessageBox.Show("Save new prescription successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Me.DialogResult = Windows.Forms.DialogResult.OK
                End Try
            End If

            clearForm()



        Else    '--- Edit Prescription
            If MessageBox.Show("Do you want save Prescription ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try
                    '--- Insert table PRESCRIPTION_INVENTORY
                    Dim TPrescripInventory As New PRESCIP_INVENTORY
                    Dim ObjPrescrip = From Prescrip In THIDataContext.getTHIDataContext.PRESCIP_INVENTORies Where Prescrip.PrescripID = PrescripID
                    TPrescripInventory = ObjPrescrip.SingleOrDefault()

                    TPrescripInventory.PatientNo = Val(TxtPatientNoReal.Text)
                    TPrescripInventory.DoctorNo = Val(TxtDoctorNo.Text)
                    TPrescripInventory.IssueDate = DateCreatePrescrip.Value.Date
                    TPrescripInventory.DiagnosisID = CbDiagnosis.SelectedValue
                    TPrescripInventory.Status = 0 'Indicate that prescription not yet give medicine to patient.     
                    TPrescripInventory.PrescriptionNote = TxtPrescriptionNote.Text
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM PRESCRIP_DETAIL_INVENTORY where PrescripID={0}", PrescripID)

                    '--- Insert table PRSCRIP_DETAIL_INVENTORY
                    For Each row As DataGridViewRow In GridMedicine.Rows

                        Dim TPrescripDetail As New PRESCRIP_DETAIL_INVENTORY
                        TPrescripDetail.PrescripID = TPrescripInventory.PrescripID
                        TPrescripDetail.ItemID = row.Cells("cItemID").Value
                        TPrescripDetail.ItemName = row.Cells("cItemName").Value

                        Try
                            TPrescripDetail.IsOutsideMedicine = row.Cells("cIsOutsideMedicine").Value
                        Catch ex As Exception

                        End Try

                        TPrescripDetail.ItemUnitID = row.Cells("cItemUnitID").Value
                        TPrescripDetail.ItemQuantity = Val(row.Cells("cQuantity").Value)
                        TPrescripDetail.Remark = row.Cells("cRemark").Value

                        THIDataContext.getTHIDataContext.PRESCRIP_DETAIL_INVENTORies.InsertOnSubmit(TPrescripDetail)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        If row.Cells("cIsOutsideMedicine").Value = False Then
                            '--- Validate item name already exist
                            Dim myItemOutSide = From IOS In THIDataContext.getTHIDataContext.ITEM_OUTSIDE_INVENTORies Where IOS.ItemName.ToUpper = row.Cells("cItemName").Value.ToString.ToUpper
                            If myItemOutSide.ToList.Count = 0 Then
                                '--- Insert table ITEM_OUTSIDE_INVENTORY
                                Dim TItemOutSide As New ITEM_OUTSIDE_INVENTORY
                                TItemOutSide.ItemName = row.Cells("cItemName").Value
                                TItemOutSide.Quantity = Val(row.Cells("cQuantity").Value)
                                TItemOutSide.PrescripID = TPrescripInventory.PrescripID
                                TItemOutSide.DepartID = CInt(DEPART_ID)
                                TItemOutSide.IsRegistered = False
                                TItemOutSide.ContainerID = row.Cells("ContainerID").Value
                                TItemOutSide.LabourFacID = row.Cells("LabourFacID").Value
                                TItemOutSide.RegisterDate = DateCreatePrescrip.Value.Date

                                THIDataContext.getTHIDataContext.ITEM_OUTSIDE_INVENTORies.InsertOnSubmit(TItemOutSide)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Else ' In Case item outside invetory already register update quantity
                                Dim TItemOutSide As ITEM_OUTSIDE_INVENTORY = myItemOutSide.SingleOrDefault
                                TItemOutSide.Quantity = TItemOutSide.Quantity + Val(row.Cells("cQuantity").Value)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            End If
                        End If
                    Next
                    MessageBox.Show("Save new prescription successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox(ex.Message)
                    THIDataContext.getTHIDataContext.Connection.Close()
                Finally
                    trans = Nothing

                    'clearForm()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End Try
            End If
        End If

    End Sub
    Private Sub clearForm()
        RadPatientNo.Checked = True
        LblSaveStatus.Text = "0"
        CboPatient.Text = ""
        CboPatient.Select()
        CboPatient.Focus()
        CboPatient.SelectAll()
        TxtTempPatientNo.Text = ""
        TxtPatientNoReal.Text = ""
        CboSecondSurgery.Text = ""
        TxtNameKh.Text = ""
        TxtPatientName.Text = ""
        TxtPatOccupation.Text = ""
        TxtPatSex.Text = ""
        TxtPatAge.Text = ""
        txtAddress.Text = ""
        TxtTel.Text = ""
        CboDoctor.SelectedIndex = -1
        CbDiagnosis.SelectedIndex = -1
        GridMedicine.DataSource = Nothing
        DateApp.Checked = False
        CboEye.Text = ""
        TxtPrescriptionNote.Text = ""
        LblItemUnitID.Text = "0"
        LblItemID.Text = "0"
        RbDrugInHos.Checked = True
        GridPatientInformation.DataSource = Nothing
        GridMedicine.DataSource = Nothing
        GridMedicine.Rows.Clear()
        GridMedicine.Refresh()
        LblNew_OldID.Text = "0"
        CleanMedicine()
    End Sub

    Private Sub BgLoadPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadPatient.DoWork
        TblPatient = PatientDataAdapter.GetData
       
    End Sub

    Private Sub BgLoadPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadPatient.RunWorkerCompleted
        'Application.DoEvents()
        'With CboPatient
        '    .DataSource = TblPatient
        '    .ValueMember = "PatientNo"
        '    .DisplayMember = "PatientNo"
        '    .SelectedIndex = -1
        'End With
        'TxtPatientName.Text = ""
        'TxtPatOccupation.Text = ""
        'TxtPatAge.Text = ""
        'TxtPatSex.Text = ""
        'txtAddress.Text = ""
        'LblLoading.Visible = False
        'PictLoading.Visible = False
    End Sub

    
    

    Private Sub CboDoctor_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDoctor.SelectedValueChanged
        Try
            TxtDoctorNo.Text = CboDoctor.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CboPatient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboPatient.KeyPress
        If RadPatientNo.Checked = True Then
            SetDisableKeyString(e)
        End If
    End Sub

    Private Sub CboPatient_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboPatient.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidateTextField(TxtPatientNo, "", ErrFind) = False Then Exit Sub
            If RadPatientName.Checked = True Then
                GridPatientInformation.DataSource = DAPatient.SelectPatientName("%" & TxtPatientNo.Text & "%")
            End If
            If RadPatientNo.Checked = True Then
                GridPatientInformation.DataSource = DAPatient.GetDataByPatientNo(EmptyString(TxtPatientNo.Text))
            End If

        End If
    End Sub

    Private Sub GridPatientInformation_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientInformation.SelectionChanged
        Try
            'Dim FFindPatient As New SelectPatient2
            'FFindPatient.PatientOption = 1
            'If FFindPatient.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim TblTempPatient As DataTable = PatientDataAdapter.GetDataPatientByID(EmptyString(GridPatientInformation.GetRow.Cells("PatientNo").Value))

            'If TblTempPatient.Rows.Count < 1 Then
            '    MessageBox.Show("Can not find this pateint no. Could you check Pattient No again.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'Else
            TxtPatientNoReal.Text = GridPatientInformation.GetRow.Cells("PatientNo").Value
            Dim TblTempNew_Old As DataTable = DA_New_Old_Adapter.GetDataByBlankDiagnosis(GridPatientInformation.GetRow.Cells("PatientNo").Value, "")
            For Each DRow As DataRow In TblTempPatient.Rows
                TxtTempPatientNo.Text = DRow("PatientNo")
                TxtNameKh.Text = DRow("NameKhmer")
                TxtPatientName.Text = DRow("NameEng")
                TxtPatOccupation.Text = DRow("Occupation")
                TxtPatAge.Text = DRow("Age")
                TxtPatSex.Text = DRow("Sex")
                txtAddress.Text = DRow("Address")
                TxtTel.Text = DRow("Telephone")
            Next
            For Each DRowNew_Old As DataRow In TblTempNew_Old.Rows
                LblNew_OldID.Text = DRowNew_Old("NewOutPatientNo")
            Next
            '    'End If
            'End If


            'Dim FBrowsePatient As New frmBrowsePatient
            'If FBrowsePatient.ShowDialog = DialogResult.OK Then
            '    CboPatient.Text = FBrowsePatient.PatientNo
            '    TxtPatientName.Text = FBrowsePatient.PatientName
            '    TxtPatSex.Text = FBrowsePatient.PatientSex
            '    TxtPatOccupation.Text = FBrowsePatient.PatientOccupa
            '    txtAddress.Text = FBrowsePatient.PatientAddr
            '    TxtPatAge.Text = FBrowsePatient.PatientAge
            '    TxtTempPatientNo.Text = FBrowsePatient.PatientNo
            'End If
        Catch ex As Exception
            TxtPatientNoReal.Text = ""
            TxtTempPatientNo.Text = ""
            TxtNameKh.Text = ""
            TxtPatientName.Text = ""
            TxtPatOccupation.Text = ""
            TxtPatAge.Text = ""
            TxtPatSex.Text = ""
            txtAddress.Text = ""
        End Try
    End Sub

   
    Private Sub RbDrugInHos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDrugInHos.CheckedChanged
        If RbDrugInHos.Checked Then
            Try
                CboItemName.Enabled = True
                cbRemark.SelectedIndex = 0
                CboOpticalShop.SelectedIndex = -1
                CboOpticalShop.Enabled = False
                GroupMedicineInfo.Enabled = False
                CboItemName.Text = ""
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub RadItemInOpticalShop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadItemInOpticalShop.CheckedChanged
        CboOpticalShop.Enabled = True
        CboOpticalShop.SelectedIndex = -1
        cbRemark.SelectedIndex = 2
        CboItemName.SelectedIndex = -1
        CboItemName.Enabled = False
        GroupMedicineInfo.Enabled = False
    End Sub

    Private Sub RbDrugOutsideHos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDrugOutsideHos.CheckedChanged
        If RbDrugOutsideHos.Checked Then
            CboItemName.Enabled = False
            TxtItemName.Enabled = True
            cbRemark.SelectedIndex = 1
            CboOpticalShop.SelectedIndex = -1
            CboOpticalShop.Enabled = False
            GroupMedicineInfo.Enabled = True
        End If
    End Sub

   

    Private Sub TxtQuantity_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyDown
        'MsgBox(e.KeyCode)
        
    End Sub

    Private Sub TxtQuantity_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyUp
        If e.KeyCode = 190 Then
            TxtQuantity.Text = ""
        End If
    End Sub

   

    Private Sub frmPrescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItem()
        End If
    End Sub

   
End Class