Imports System.Data.Common
Public Class UCOT_AND_IOLList
    Private THIDataContext As New BaseDataContext
    Private OLD_IOLID As Integer
    Dim ItemListInDepartDataAdapter As New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim DA_Item_Department As New DSOTCurrentStoctTableAdapters.tblDeptStockTableAdapter
    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        ToolStripMenuItem1.Enabled = True
        MenuOperationReady.Enabled = True
        DeleteOTRegistrationToolStripMenuItem.Enabled = True
        ShowOTData()
    End Sub
    Sub ShowOTData()
        GridOTRegistration.DataSource = ModOTRegistration.SelectListOT(TxtPatientNo.Text)
        ModCommon.NumberAllRowHeaderDataGrid(GridOTRegistration)
    End Sub
    Sub ShowOTHistory()
        GridOTRegistration.DataSource = ModOTRegistration.SelectOTHistory(EmptyString(TxtFindPatientNo.Text), DateFrom.Value, DateTo.Value)
        ModCommon.NumberAllRowHeaderDataGrid(GridOTRegistration)
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Try
            MenuOperationReady.Enabled = True
            ToolStripMenuItem1.Enabled = True
            DeleteOTRegistrationToolStripMenuItem.Enabled = True
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOTRegistration.Rows(Index).Cells("OTNo").Value
            Dim PatientNo As String = GridOTRegistration.Rows(Index).Cells("PatientNo").Value
            Dim PatientName As String = GridOTRegistration.Rows(Index).Cells("NameKhmer1").Value.ToString.Replace("'", "")
            Dim Age As String = GridOTRegistration.Rows(Index).Cells("Age").Value
            Dim Sex As String = GridOTRegistration.Rows(Index).Cells("Sex").Value
            Dim Eye As String = GridOTRegistration.Rows(Index).Cells("Eye").Value
            Dim Surgeon As String = GridOTRegistration.Rows(Index).Cells("Surgeon").Value
            Dim IOL As String = GridOTRegistration.Rows(index).Cells("IOL").Value
            If IOL.Equals("") Then
                MessageBox.Show("You can not create IOL. Please contact administrator to create IOL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            
            'Dim DateOP As String = GridOTRegistration.Rows(Index).Cells("DateOperated").Value
            Dim FIOL As New FRMIOLRegistration
            FIOL.LblOTNo.Text = OTNo
            FIOL.txtPatientNo.Text = PatientNo
            FIOL.TxtName.Text = PatientName.Replace("'", "")
            FIOL.TxtSex.Text = Sex
            FIOL.TxtAge.Text = Age
            FIOL.CboEye.Text = Eye
            FIOL.CboSurgeon.Text = Surgeon
            'FIOL.LblDateCreateIOL.Text = DateOP
            FIOL.CboIOLItem.Text = GridOTRegistration.Rows(Index).Cells("IOL").Value.ToString.Replace("'", "")
            FIOL.ShowDialog()
            If FIOL.isClose = True Then
                GridIOL.DataSource = ModIOLRegistration.SelectIOL(FIOL.LblOTNo.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient to create IOL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub GridIOL_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridIOL.CellDoubleClick
        Try
            If IsReadyOP() = True Then
                If IsAdmin() = True Then
                    Dim fIOL As New FRMIOLRegistration
                    fIOL.LblOptionSave.Text = GridIOL.Rows(e.RowIndex).Cells(0).Value
                    fIOL.LblOTNo.Text = GridIOL.Rows(e.RowIndex).Cells(1).Value
                    fIOL.txtPatientNo.Text = GridIOL.Rows(e.RowIndex).Cells(2).Value
                    fIOL.TxtName.Text = GridIOL.Rows(e.RowIndex).Cells(3).Value
                    fIOL.TxtAge.Text = GridIOL.Rows(e.RowIndex).Cells(4).Value
                    fIOL.TxtSex.Text = GridIOL.Rows(e.RowIndex).Cells(5).Value
                    fIOL.CboSurgeon.Text = GridIOL.Rows(e.RowIndex).Cells(6).Value
                    fIOL.CboEye.Text = GridIOL.Rows(e.RowIndex).Cells(7).Value
                    fIOL.CboIOLItem.Text = GridIOL.Rows(e.RowIndex).Cells(8).Value
                    fIOL.DateIOL.Checked = True
                    fIOL.DateIOL.Value = GridIOL.Rows(e.RowIndex).Cells("CreateDate1").Value
                    fIOL.ShowDialog()
                    If fIOL.DialogResult = DialogResult.OK Then
                        GridIOL.DataSource = ModIOLRegistration.SelectIOL(fIOL.LblOTNo.Text)
                    End If
                Else
                    MessageBox.Show("You don't have permistion to edit IOL. Please contact system addmin to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Dim fIOL As New FRMIOLRegistration
                fIOL.LblOptionSave.Text = GridIOL.Rows(e.RowIndex).Cells(0).Value
                fIOL.LblOTNo.Text = GridIOL.Rows(e.RowIndex).Cells(1).Value
                fIOL.txtPatientNo.Text = GridIOL.Rows(e.RowIndex).Cells(2).Value
                fIOL.TxtName.Text = GridIOL.Rows(e.RowIndex).Cells(3).Value
                fIOL.TxtAge.Text = GridIOL.Rows(e.RowIndex).Cells(4).Value
                fIOL.TxtSex.Text = GridIOL.Rows(e.RowIndex).Cells(5).Value
                fIOL.CboSurgeon.Text = GridIOL.Rows(e.RowIndex).Cells(6).Value
                fIOL.CboEye.Text = GridIOL.Rows(e.RowIndex).Cells(7).Value
                fIOL.CboIOLItem.Text = GridIOL.Rows(e.RowIndex).Cells(8).Value
                fIOL.DateIOL.Checked = True
                fIOL.DateIOL.Value = GridIOL.Rows(e.RowIndex).Cells("CreateDate1").Value
                fIOL.ShowDialog()
                If fIOL.DialogResult = DialogResult.OK Then
                    GridIOL.DataSource = ModIOLRegistration.SelectIOL(fIOL.LblOTNo.Text)
                End If
            End If
            
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DeleteOTRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOTRegistrationToolStripMenuItem.Click
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOTRegistration.Rows(index).Cells("OTNo").Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModOTRegistration.DeleteOT(OTNo) Then
                    ModIOLRegistration.DeleteIOLByOT(OTNo)
                    MsgBox("Delete OT registration successfully.", MsgBoxStyle.Information, "Delete")
                    ShowOTData()
                    GridIOL.DataSource = ModIOLRegistration.SelectIOL(OTNo)
                Else
                    MsgBox("Error OT registration.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub






    Private Sub LinkOPReady_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        'Dim i As Integer = 0
        'Dim dialogresult As DialogResult
        'If LVOTRegistration.Items.Count > 0 Then
        '    dialogresult = MessageBox.Show("Are you sure operation ready?", "Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        '    If dialogresult = Windows.Forms.DialogResult.Yes Then
        '        For i = 0 To LVOTRegistration.Items.Count - 1
        '            If LVOTRegistration.Items(i).Checked = True Then
        '                'MAppointment.UpdateCancelAppoint(LVOTRegistration.Items(i).SubItems(0).Text, "0")
        '                ModOTRegistration.UpdateStatus(LVOTRegistration.Items(i).SubItems(0).Text, LVOTRegistration.Items(i).Checked)
        '            End If
        '        Next i
        '        ShowOTRegistration("")
        '    End If
        'Else
        '    MsgBox("Please select OT registration.", MsgBoxStyle.Critical, "Error")
        'End If
    End Sub




    Private Sub GridOTRegistration_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOTRegistration.CellDoubleClick
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim IsReady As Boolean = GridOTRegistration.Rows(index).Cells("Status").Value
            Dim Acess As String = ""
            For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
                With TBLACCESS_ROLE.Rows(i)
                    If .Item(0) = "Administrator" Then
                        Acess = "Administrator"
                    End If
                End With
            Next

            If IsReady = True Then
                If Acess = "Administrator" Then
                    Dim FOTRegistration As New FRMOTRegistration
                    FOTRegistration.LblSaveOption.Text = GridOTRegistration.Rows(e.RowIndex).Cells("OTNo").Value
                    FOTRegistration.TxtInpatientNo.Text = GridOTRegistration.Rows(e.RowIndex).Cells("NewInPatientNo").Value
                    FOTRegistration.TxtPatientNo.Text = GridOTRegistration.Rows(e.RowIndex).Cells("PatientNo").Value
                    FOTRegistration.TxtPatientName.Text = GridOTRegistration.Rows(e.RowIndex).Cells("NameKhmer1").Value
                    FOTRegistration.TxtAge.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Age").Value
                    FOTRegistration.TxtSex.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Sex").Value
                    FOTRegistration.TxtAddress.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Address").Value
                    Try
                        FOTRegistration.CboOperationTime.Checked = True
                        FOTRegistration.CboOperationTime.Text = GridOTRegistration.Rows(e.RowIndex).Cells("OperationTime").Value
                    Catch ex As Exception
                        FOTRegistration.CboOperationTime.Checked = False
                    End Try
                    Try
                        FOTRegistration.DateOperated.Checked = True
                        FOTRegistration.DateOperated.Value = GridOTRegistration.Rows(e.RowIndex).Cells("DateOperated").Value
                    Catch ex As Exception
                        FOTRegistration.DateOperated.Checked = False
                    End Try
                    FOTRegistration.TxtAnesthesia.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Anesthesia").Value
                    FOTRegistration.ChPrepareOT.Visible = False
                    FOTRegistration.CboAnesthetist.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Anesthetist").Value
                    FOTRegistration.CboEye.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Eye").Value
                    FOTRegistration.CboOperationType.Text = GridOTRegistration.Rows(e.RowIndex).Cells("OperationType").Value
                    'GridOTRegistration .Rows(e.RowIndex).Cells("IOL_ID").Value 
                    If TypeOf GridOTRegistration.Rows(e.RowIndex).Cells("IOL_ID").Value Is DBNull Then
                    Else
                        FOTRegistration.CboIOLItem.SelectedValue = GridOTRegistration.Rows(e.RowIndex).Cells("IOL_ID").Value
                        FOTRegistration.lblIOLIDOLD.Text = GridOTRegistration.Rows(e.RowIndex).Cells("IOL_ID").Value
                    End If
                    If TypeOf GridOTRegistration.Rows(e.RowIndex).Cells("IOL").Value Is DBNull Then
                        FOTRegistration.CboIOLItem.Text = ""
                    Else
                        FOTRegistration.CboIOLItem.Text = GridOTRegistration.Rows(e.RowIndex).Cells("IOL").Value
                    End If

                    FOTRegistration.CboSurgeon.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Surgeon").Value
                    FOTRegistration.CboAssistant.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Assistant").Value
                    FOTRegistration.TxtCirculation.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Circulation").Value
                    FOTRegistration.TxtCompli.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Compli").Value
                    FOTRegistration.TxtOther.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Others").Value
                    FOTRegistration.ShowDialog()
                    If FOTRegistration.DialogResult = DialogResult.OK Then
                        TxtPatientNo.Text = FOTRegistration.TxtPatientNo.Text
                        ShowOTData()
                    End If
                    FOTRegistration.Dispose()
                    FOTRegistration.Close()
                Else
                    MessageBox.Show("You don't have permistion to edit IOL. Please contact system admin to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                Dim FOTRegistration As New FRMOTRegistration
                FOTRegistration.LblSaveOption.Text = GridOTRegistration.Rows(e.RowIndex).Cells("OTNo").Value
                FOTRegistration.TxtInpatientNo.Text = GridOTRegistration.Rows(e.RowIndex).Cells("NewInPatientNo").Value
                FOTRegistration.TxtPatientNo.Text = GridOTRegistration.Rows(e.RowIndex).Cells("PatientNo").Value
                FOTRegistration.TxtPatientName.Text = GridOTRegistration.Rows(e.RowIndex).Cells("NameKhmer1").Value
                FOTRegistration.TxtAge.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Age").Value
                FOTRegistration.TxtSex.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Sex").Value
                FOTRegistration.TxtAddress.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Address").Value
                Try
                    FOTRegistration.CboOperationTime.Checked = True
                    FOTRegistration.CboOperationTime.Text = GridOTRegistration.Rows(e.RowIndex).Cells("OperationTime").Value
                Catch ex As Exception
                    FOTRegistration.CboOperationTime.Checked = False
                End Try
                Try
                    FOTRegistration.DateOperated.Checked = True
                    FOTRegistration.DateOperated.Value = GridOTRegistration.Rows(e.RowIndex).Cells("DateOperated").Value
                Catch ex As Exception
                    FOTRegistration.DateOperated.Checked = False
                End Try
                FOTRegistration.TxtAnesthesia.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Anesthesia").Value
                FOTRegistration.ChPrepareOT.Visible = False
                FOTRegistration.CboAnesthetist.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Anesthetist").Value
                FOTRegistration.CboEye.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Eye").Value
                FOTRegistration.CboOperationType.Text = GridOTRegistration.Rows(e.RowIndex).Cells("OperationType").Value
                'GridOTRegistration .Rows(e.RowIndex).Cells("IOL_ID").Value 
                If TypeOf GridOTRegistration.Rows(e.RowIndex).Cells("IOL_ID").Value Is DBNull Then
                Else
                    FOTRegistration.CboIOLItem.SelectedValue = GridOTRegistration.Rows(e.RowIndex).Cells("IOL_ID").Value
                    FOTRegistration.lblIOLIDOLD.Text = GridOTRegistration.Rows(e.RowIndex).Cells("IOL_ID").Value
                End If
                If TypeOf GridOTRegistration.Rows(e.RowIndex).Cells("IOL").Value Is DBNull Then
                    FOTRegistration.CboIOLItem.Text = ""
                Else
                    FOTRegistration.CboIOLItem.Text = GridOTRegistration.Rows(e.RowIndex).Cells("IOL").Value
                End If

                FOTRegistration.CboSurgeon.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Surgeon").Value
                FOTRegistration.CboAssistant.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Assistant").Value
                FOTRegistration.TxtCirculation.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Circulation").Value
                FOTRegistration.TxtCompli.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Compli").Value
                FOTRegistration.TxtOther.Text = GridOTRegistration.Rows(e.RowIndex).Cells("Others").Value
                FOTRegistration.ShowDialog()
                If FOTRegistration.DialogResult = DialogResult.OK Then
                    TxtPatientNo.Text = FOTRegistration.TxtPatientNo.Text
                    ShowOTData()
                End If
                FOTRegistration.Dispose()
                FOTRegistration.Close()
            End If
           
        Catch ex As Exception
            MsgBox("Error, OT Infos.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GridOTRegistration_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridOTRegistration.SelectionChanged
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOTRegistration.Rows(index).Cells("OTNo").Value
            GridIOL.DataSource = ModIOLRegistration.SelectIOL(OTNo)
           
            Dim IsReady As Boolean = GridOTRegistration.Rows(index).Cells("Status").Value
            If IsReady = True Then
                MenuOperationReady.Enabled = False
                ToolStripMenuItem1.Enabled = False
                ToolStripMenuItem1.Enabled = False
                If IsAdmin() = True Then
                    DeleteOTRegistrationToolStripMenuItem.Enabled = True
                    ToolStripMenuItem1.Enabled = True
                    MenuOperationReady.Enabled = True
                Else
                    DeleteOTRegistrationToolStripMenuItem.Enabled = False
                    ToolStripMenuItem1.Enabled = False
                    MenuOperationReady.Enabled = False
                End If

                'Else
                '    ToolStripMenuItem1.Enabled = True
                '    MenuOperationReady.Enabled = True
                '    DeleteOTRegistrationToolStripMenuItem.Enabled = True
            End If

        Catch ex As Exception
            GridIOL.DataSource = ModIOLRegistration.SelectIOL("0")
        End Try
    End Sub

    Private Sub DeleteIOLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteIOLToolStripMenuItem.Click
        Try
            Dim index = GridIOL.SelectedCells(0).RowIndex
            Dim OTNo As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim IOLNo As String = GridIOL.Rows(index).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_DELETE, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModIOLRegistration.DeleteIOL(IOLNo) = 1 Then
                    MsgBox("Delete IOL registration successfully.", MsgBoxStyle.Information, "Delete")
                    GridIOL.DataSource = ModIOLRegistration.SelectIOL(OTNo)
                Else
                    MsgBox("Error delete IOL registration.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Function CheckCurrentStockIOL(ByVal itemID As Integer) As Integer
        Dim tblIOL As DataTable = ItemListInDepartDataAdapter.GetItemDataInDepartByItemID(13, itemID)
        If tblIOL.Rows.Count = 0 Then
            Return 0
        Else
            For Each rows As DataRow In tblIOL.Rows
                Return rows("UnitsInStock")
            Next
        End If
    End Function
    Private Sub ReadyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOperationReady.Click

        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim PNo As Long = GridOTRegistration.Rows(index).Cells("PatientNo").Value
            Dim OTNo As String = GridOTRegistration.Rows(index).Cells("OTNo").Value
            Dim NewInPatientNo As String = GridOTRegistration.Rows(index).Cells("NewInPatientNo").Value
            Dim IOL As String = GridOTRegistration.Rows(index).Cells("IOL").Value
            Dim IOL_ID As Integer = GridOTRegistration.Rows(index).Cells("IOL_ID").Value

            If IOL.Trim <> "".Trim Then
                If CheckCurrentStockIOL(IOL_ID) = 0 Then
                    MsgBox("IOL out of stock in system. Could you check again.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                If GridIOL.Rows.Count = 0 Then

                    MessageBox.Show("Please create IOL number before set to operation ready.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Try
                        'Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
                        'Dim OTNo As String = GridOTRegistration.Rows(Index).Cells(0).Value
                        Dim PatientNo As String = GridOTRegistration.Rows(index).Cells("PatientNo").Value
                        Dim PatientName As String = GridOTRegistration.Rows(index).Cells("NameKhmer1").Value
                        Dim Age As String = GridOTRegistration.Rows(index).Cells("Age").Value
                        Dim Sex As String = GridOTRegistration.Rows(index).Cells("Sex").Value
                        'Dim DateOP As String = GridOTRegistration.Rows(Index).Cells("DateOperated").Value
                        Dim FIOL As New FRMIOLRegistration
                        FIOL.LblOTNo.Text = OTNo
                        FIOL.txtPatientNo.Text = PatientNo
                        FIOL.TxtName.Text = PatientName
                        FIOL.TxtSex.Text = Sex
                        FIOL.TxtAge.Text = Age
                        'FIOL.LblDateCreateIOL.Text = DateOP
                        FIOL.CboIOLItem.Text = GridOTRegistration.Rows(index).Cells("IOL").Value
                        FIOL.ShowDialog()
                        If FIOL.isClose = True Then
                            GridIOL.DataSource = ModIOLRegistration.SelectIOL(FIOL.LblOTNo.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Please select patient to create IOL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    Exit Sub
                End If

            End If
        Dim Dialog As DialogResult = MessageBox.Show("Are you sure this patient operation ready?", "Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Dialog = DialogResult.Yes Then

            If ModOTRegistration.UpdateStatus(OTNo) = 1 And ModNewInPatient.UpdateOTWating(NewInPatientNo, 3) >= 0 Then
                Dim FDateOperated As New FrmDateOperated
                FDateOperated.LblSaveOption.Text = OTNo

                If FDateOperated.ShowDialog() = DialogResult.OK Then
                    Dim DOT As Date = FDateOperated.DateOperated.Value.Date
                    '================== Case update stock
                    'If CInt(GridOTRegistration.Rows(index).Cells("Waiting").Value) = 3 And IOL.Trim <> "".Trim Then
                    '    If GridOTRegistration.Rows(index).Cells("IOL_ID_OLD").Value <> GridOTRegistration.Rows(index).Cells("IOL_ID").Value Then
                    '        ' Enable Menu OT
                    '        ContextMenuNewInPatient.Enabled = False
                    '        ProcessCutStoce(MyIOLItemID, DOT)
                    '    End If
                    'Else
                    If (IOL_ID <> 0) Then
                        Dim MyIOLItemID As Integer = Val(GridOTRegistration.Rows(index).Cells("IOL_ID").Value)
                        'ContextMenuNewInPatient.Enabled = False
                            ProcessCutStoce(MyIOLItemID, DOT, PNo.ToString)
                    Else
                        MessageBox.Show("Operation ready.", "OT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ShowOTData()

                    End If
                    'If IOL.Trim <> "".Trim And ModIOLRegistration.CheckIOLReady(PNo) = False Then
                    '============= Do cut stoce ===================

                    'Else

                    'End If

                End If


                'MsgBox("This patient operation ready.", MsgBoxStyle.Information, "Update")
            Else
                MsgBox("Error update status operation.", MsgBoxStyle.Critical, "Error")
            End If
        End If

        Catch ex As Exception
            MessageBox.Show("Please select patient to set to operation already. " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            'ContextMenuNewInPatient.Enabled = True

        End Try
        'ContextMenuNewInPatient.Enabled = True
    End Sub
    Sub ProcessCutStoce(ByVal MyIOLItemID As Integer, ByVal DateOT As Date, ByVal PatientNo As String)
        'ContextMenuNewInPatient.Enabled = False
        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            '=========== tblUsed ==============
            Dim mytblUsed As New tblUsed
            mytblUsed.UsedDepartID = CInt(13)
            mytblUsed.UsedDescription = "IOL use in OT By user " & USER_NAME & PatientNo
            mytblUsed.UsedUserID = CInt(USER_ID)
            mytblUsed.UsedDate = DateOT ' dptUsedDate.Value.Date

            THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
            THIDataContext.getTHIDataContext.SubmitChanges()
            '============ tblUsedDetail ============
            'For Each rRow As Janus.Windows.GridEX.GridEXRow In gridUsedItemDetail.GetRows
            Dim mytblUsedDetail As New tblUsedDetail
            mytblUsedDetail.UsedID = mytblUsed.UsedID
            mytblUsedDetail.ItemID = MyIOLItemID 'Val(rRow.Cells("ItemID").Value)
            mytblUsedDetail.UsedQuantity = 1 'Val(rRow.Cells("UsedQuantity").Value)

            THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
            THIDataContext.getTHIDataContext.SubmitChanges()

            '=========== Process cut stock ===========
            'If CInt(DEPART_ID) <> MAIN_STOCK_DEPART_ID Then

            ''Dim TblCurrentItemOT As DataTable = DA_Item_Department.GetDepartmentItemStock(CInt(DEPART_ID), MyIOLItemID)
            Dim TblCurrentItemOT As DataTable = DA_Item_Department.GetDepartmentItemStock(CInt(13), MyIOLItemID)
            Dim myDepartStock As New tblDeptStock
            ' move to particular record to cut balance in department stock
            'Dim qdepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = MyIOLItemID  'Val(rRow.Cells("ItemID").Value)
            'myDepartStock = qdepartStock.Single
            For Each IOL As DataRow In TblCurrentItemOT.Rows
                '========================= Management Begin item quantity before perform transaction =========================
                'Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = DateOT And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = MyIOLItemID Select BBT.BeginBalanceTraceID).Count
                Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = DateOT And BBT.DepartID = CInt(13) And BBT.ItemID = MyIOLItemID Select BBT.BeginBalanceTraceID).Count
                If q = 0 Then
                    '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                    Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                    mytblBeginBalanceTrace.Date = DateOT
                    'mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                    mytblBeginBalanceTrace.DepartID = CInt(13)
                    mytblBeginBalanceTrace.BeginBalanceOfDay = CInt(IOL("UnitsInStock"))  'myDepartStock.UnitsInStock
                    mytblBeginBalanceTrace.ItemID = MyIOLItemID  'Val(rRow.Cells("ItemID").Value)
                    THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                    THIDataContext.getTHIDataContext.SubmitChanges(Data.Linq.ConflictMode.ContinueOnConflict)
                End If

                '--- Update balance in department stock

                ' DA_Item_Department.UpdateStockIOL(IOL("UnitsInStock") - 1, DEPART_ID, MyIOLItemID)
                DA_Item_Department.UpdateStockIOL(IOL("UnitsInStock") - 1, 13, MyIOLItemID)
            Next
            'myDepartStock.UnitsInStock = myDepartStock.UnitsInStock - 1 'Val(rRow.Cells("UsedQuantity").Value)
            'THIDataContext.getTHIDataContext.SubmitChanges(Data.Linq.ConflictMode.ContinueOnConflict)

            ' End If
            ' Next

            '*** Finished
            trans.Commit()
            ' THIDataContext.getTHIDataContext.Connection.Close()
            'ContextMenuNewInPatient.Enabled = True

            'process run end of day.

        Catch ex As Exception
            trans.Rollback()
            MsgBox("Error : " & ex.Message)
        Finally
            THIDataContext.getTHIDataContext.Connection.Close()
            'MessageBox.Show("Used items save successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Application.DoEvents()
            'Application.DoEvents()
            'DEP_EOD.BtnEndofDay_Click(sender, e) ' 
            'ContextMenuNewInPatient.Enabled = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'trans = Nothing

            ShowOTData()
        End Try

    End Sub
    Private Sub BtnFindHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindHistory.Click
        ShowOTHistory()
    End Sub

    Private Sub BtnStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatistic.Click
        Dim FOTStatistic As New FrmOTStatistic
        FOTStatistic.ShowDialog()
        FOTStatistic.Close()
        FOTStatistic.Dispose()
    End Sub

    Private Sub cmdUndoDeleteOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndoDeleteOT.Click
        Dim frmUndoDelOT As New frmUndoDeleteOT
        frmUndoDelOT.ShowDialog()
    End Sub



    Private Sub GridOTRegistration_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridOTRegistration.ColumnHeaderMouseClick
        ModCommon.NumberAllRowHeaderDataGrid(GridOTRegistration)
    End Sub

    Private Sub BtnCreateIOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateIOL.Click
        Try
            Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOTRegistration.Rows(Index).Cells("OTNo").Value
            Dim PatientNo As String = GridOTRegistration.Rows(Index).Cells("PatientNo").Value
            Dim PatientName As String = GridOTRegistration.Rows(Index).Cells("NameKhmer1").Value
            Dim Age As String = GridOTRegistration.Rows(Index).Cells("Age").Value
            Dim Sex As String = GridOTRegistration.Rows(Index).Cells("Sex").Value
            Dim FIOL As New FRMIOLRegistration
            FIOL.LblOTNo.Text = OTNo
            FIOL.txtPatientNo.Text = PatientNo
            FIOL.TxtName.Text = PatientName
            FIOL.TxtSex.Text = Sex
            FIOL.TxtAge.Text = Age
            FIOL.ShowDialog()
            If FIOL.isClose = True Then
                GridIOL.DataSource = ModIOLRegistration.SelectIOL(FIOL.LblOTNo.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient to create IOL.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnOperationReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOperationReady.Click
        Try
            Dim Dialog As DialogResult = MessageBox.Show("Are you sure this patient operation ready?", "Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = GridOTRegistration.Rows(index).Cells(0).Value
            Dim NewInPatientNo As String = GridOTRegistration.Rows(index).Cells("NewInPatientNo").Value
            If Dialog = DialogResult.Yes Then
                If ModOTRegistration.UpdateStatus(OTNo) = 1 And ModNewInPatient.UpdateOTWating(NewInPatientNo, 3) >= 0 Then
                    Dim FDateOperated As New FrmDateOperated
                    FDateOperated.LblSaveOption.Text = OTNo
                    FDateOperated.ShowDialog()
                    FDateOperated.Dispose()
                    FDateOperated.Close()
                    ShowOTData()
                    MsgBox("This patient operation ready.", MsgBoxStyle.Information, "Update")
                Else
                    MsgBox("Error update status operation.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Please select patient to set to operation already.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub UCOT_AND_IOLList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuReadyInOT = MenuOperationReady
        ShowOTData()
    End Sub

    
    Private Sub GridIOL_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridIOL.SelectionChanged
        Try

            If IsReadyOP() = True Then
                If IsAdmin() = True Then
                    DeleteIOLToolStripMenuItem.Enabled = True
                Else
                    DeleteIOLToolStripMenuItem.Enabled = False
                    'MessageBox.Show("You don't have permistion to delet IOL. Please contact system admin to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                DeleteIOLToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Function IsAdmin() As Boolean
        Dim Acess As String = ""
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Administrator" Then
                    Return True
                Else
                    Return False
                End If
            End With
        Next
    End Function
    Function IsReadyOP() As Boolean
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim IsReady As Boolean = GridOTRegistration.Rows(index).Cells("Status").Value
            If IsReady = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

  
    
End Class
