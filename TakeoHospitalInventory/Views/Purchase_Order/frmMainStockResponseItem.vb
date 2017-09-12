Imports System.Data.Common

Public Class frmMainStockResponseItem

    Public myRequestDetailID As Integer
    Public myItemName As String
    Public myComment As String
    Public myResponseQty As String
    Public myRequestQty As String
    Public myItemID As String
    Public myRequestID As String
    Public ReqFromDepartID As Integer

    Public isRequestInputFromDepart As Boolean
    Private DepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Private THIDataContext As New BaseDataContext
    Private InventoryRepo As IInventory = New Inventory
    Private RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository
    Dim ItemProviderDataAdapter As New DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter
    Dim ItemProResToDepartDataAdapter As New DSRequestTableAdapters.ITEM_PROVIDER_TRANSTableAdapter
    Public VendorRepo As IVendorRepository = New VendorRepository
    Dim ItemExpireDetial As New DSItemPriceTableAdapters.ViewExpireDateDetialTableAdapter

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtResponseQuantity.Text <> "" Then
            '--- Validate response quantity must smaller than request quantity
            If Val(txtRequestQuantity.Text) <> 0 Then
                If Val(txtResponseQuantity.Text) > Val(txtRequestQuantity.Text) Then
                    MessageBox.Show("Response Quantity must be smaller than Request Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtResponseQuantity.Focus()
                    Exit Sub
                End If
            Else '--- In case request quantity equals 0 so we validate response quantity must be smaller than units in stock.
                If Val(txtResponseQuantity.Text) > Val(txtInStock.Text) Then
                    MessageBox.Show("Response Quantity must be smaller than InStock Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtResponseQuantity.Focus()
                    Exit Sub
                End If
            End If
        End If

        '--- In case reqeust quantity greater than quantity in stock
        If Val(txtResponseQuantity.Text) > Val(txtInStock.Text) Then
            MessageBox.Show("Response Quantity must be smaller than InStock Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResponseQuantity.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Do you want save response item information ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '--- Update table tblRequestDetail
                Dim q = From RD In THIDataContext.getTHIDataContext.tblRequestDetails Where RD.RequestDetailID = myRequestDetailID
                Dim RequestDetail As tblRequestDetail = q.SingleOrDefault
                RequestDetail.ResponseQuantity = Val(txtResponseQuantity.Text)
                RequestDetail.Status = 2 'Sent            
                THIDataContext.getTHIDataContext.SubmitChanges()
                '===

                '--- Update table tblRequestStatusTracking (UserID update , Comment update)
                Dim RequestST = From RST In THIDataContext.getTHIDataContext.tblRequestStatusTrackings Where RST.RequestID = Val(myRequestID)
                Dim myRequestStatusTracking As tblRequestStatusTracking = RequestST.SingleOrDefault
                myRequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)
                myRequestStatusTracking.Comment = rtbComment.Text
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- Delete ITEM_PROVIDER_TRANS
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM ITEM_PROVIDER_TRANS WHERE RequestID={0} AND ItemID={1}", myRequestID, myItemID)
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- ITEM_PROVIDER_TRANS update
                With gridProviderDetail
                    For Each rRow As DataGridViewRow In .Rows
                        '--- Save ITEM_PROVIDER_TRANS
                        Dim ItemProTrans As New ITEM_PROVIDER_TRAN
                        ItemProTrans.ItemID = myItemID
                        ItemProTrans.RequestID = myRequestID
                        ItemProTrans.ProviderID = Val(rRow.Cells("ProviderID").Value)
                        ' ItemProTrans.TransDate '--- Update when department received item
                        ItemProTrans.DepartUseID = ReqFromDepartID
                        ItemProTrans.Quantity = Val(rRow.Cells("GivenQty").Value)
                        ItemProTrans.EXPIRE_ID = Val(rRow.Cells("EXPIRE_ID").Value)

                        ItemProTrans.EXPIRE_DATE = CDate(FormatDateTime(rRow.Cells("EXPIRE_DATE").Value, DateFormat.ShortDate)).Date
                        ItemProTrans.Status = 0 '--- Incomplete status, When department received item status is Complete

                        THIDataContext.getTHIDataContext.ITEM_PROVIDER_TRANs.InsertOnSubmit(ItemProTrans)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                    Next
                End With

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
            End Try

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResponseQuantity.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, TextBox).Text.Contains(Chr(46)) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If ValidateTextField(TxtProviderName, "", Errors) = False Then Exit Sub
        If ValidateTextField(txtExpireDate, "", Errors) = False Then Exit Sub
        If ValidateTextField(TxtGivenQty, "", Errors) = False Then Exit Sub
        If ValidateTextField(TxtGivenQty, "", Errors) = False Then Exit Sub
        'If Int(TxtGivenQty.Text) > Int(txtRequestQuantity.Text) Then
        '    MessageBox.Show("The give quality can big than quality give by item expire. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    TxtGivenQty.Select()
        '    TxtGivenQty.SelectAll()
        '    TxtGivenQty.Focus()
        '    Exit Sub
        'End If
        If Int(TxtGivenQty.Text) > Int(GridExpireDetail.GetRow.Cells("UnitsInStock").Value) Then
            MessageBox.Show("The give quality can big than quality give by item expire. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtGivenQty.Select()
            TxtGivenQty.SelectAll()
            TxtGivenQty.Focus()
            Exit Sub
        End If
        If Int(txtResponseQuantity.Text) > Int(txtRequestQuantity.Text) Then
            MessageBox.Show("The Response quality can big than quality request by item. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtResponseQuantity.Select()
            txtResponseQuantity.SelectAll()
            txtResponseQuantity.Focus()
            Exit Sub
        End If

        Dim obj(6) As Object
        Dim ProviderName As String = ""
        Dim ProviderID As Integer = 0

        Dim ExpierID As Integer = 0
        Dim ExpireDate As Date


        ProviderName = TxtProviderName.Text
        ProviderID = LblPriverID.Text
        ExpierID = LblExpireID.Text


        With gridProviderDetail
            obj(0) = ProviderName
            obj(1) = TxtGivenQty.Text
            obj(2) = ProviderID
            obj(3) = txtExpireDate.Text
            obj(4) = LblExpireID.Text
            'obj(5) = 

            If gridProviderDetail.Rows.Count = 0 Then
                gridProviderDetail.Rows.Add(obj)
                txtResponseQuantity.Text = Val(txtResponseQuantity.Text) + Val(TxtGivenQty.Text)
            Else
                If IsDupValidateExpireID(obj, ExpierID) = False Then
                    gridProviderDetail.Rows.Add(obj)
                    txtResponseQuantity.Text = Val(txtResponseQuantity.Text) + Val(TxtGivenQty.Text)
                Else
                    MessageBox.Show("Item's expire already Exist.please select another expier", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With
        CleanItemProvider()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete selected provider ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    txtResponseQuantity.Text = Val(txtResponseQuantity.Text) - Val(rRow.Cells("GivenQty").Value)
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub

    Private Sub RbVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbVendor.CheckedChanged
        If RbVendor.Checked = True Then
            CbVendor.Enabled = True
            CbDonation.Enabled = False
        Else
            CbVendor.Enabled = False
            CbDonation.Enabled = True
        End If
    End Sub

    Private Sub RbDonator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDonator.CheckedChanged

        If RbDonator.Checked = True Then
            CbVendor.Enabled = False
            CbDonation.Enabled = True
        Else
            CbVendor.Enabled = True
            CbDonation.Enabled = False
        End If
    End Sub

    Private Sub TxtGivenQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGivenQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Function IsDupValidateProvider(ByVal pObj() As Object, ByVal pProviderID As Integer) As Boolean

        Dim IsExist As Boolean = False
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .Rows
                If rRow.Cells("ProviderID").Value = pProviderID Then
                    IsExist = True
                    Exit For
                End If
            Next
        End With

        Return IsExist

    End Function


    Function IsDupValidateExpireID(ByVal pObj() As Object, ByVal ExpireID As Integer) As Boolean

        Dim IsExist As Boolean = False
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .Rows
                If rRow.Cells("EXPIRE_ID").Value = ExpireID Then
                    IsExist = True
                    Exit For
                End If
            Next
        End With

        Return IsExist

    End Function

    Private Sub frmMainStockResponseItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GridExpireDetail.DataSource = ItemExpireDetial.SelectExpireByItemID(Val(lblItemID.Text))
        txtItemName.Text = myItemName
        txtResponseQuantity.Text = myResponseQty
        txtRequestQuantity.Text = myRequestQty

        If isRequestInputFromDepart = False Then
            txtInStock.Text = InventoryRepo.GetMainStockQuantityByItemID(CInt(myItemID))
        Else
            txtInStock.Text = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), CInt(myItemID))
        End If

        rtbComment.Text = myComment

        With CbDonation
            .DataSource = ItemProviderDataAdapter.GetItemDonorByItemID(CInt(myItemID))
            .ValueMember = "VendorID"
            .DisplayMember = "VenderName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With CbVendor
            .DataSource = ItemProviderDataAdapter.GetItemVendorByItemID(CInt(myItemID))
            .ValueMember = "VendorID"
            .DisplayMember = "VenderName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        CbDonation.Enabled = False
        CbVendor.Enabled = False

        '--- Load gridProviderDetail
        Dim ItemProResToDepartDT As DataTable = ItemProResToDepartDataAdapter.GetProInfoResToDepart(Val(myItemID), Val(myRequestID))

        For Each row As DataRow In ItemProResToDepartDT.Rows
            Dim obj(5) As Object
            With gridProviderDetail
                obj(0) = VendorRepo.GetVendorNameByID(CInt(row("ProviderID")))
                obj(1) = row("Quantity")
                obj(2) = row("ProviderID")
                obj(3) = Format(row("EXPIRE_DATE"), "dd/MM/yyyy")
                obj(4) = row("EXPIRE_ID")
                'obj(5) = row("InventoryID")
                .Rows.Add(obj)
            End With
        Next

    End Sub

    Private Sub CleanItemProvider()
        LblPriverID.Text = 0
        LblExpireID.Text = 0
        TxtProviderName.Text = ""
        txtExpireDate.Text = ""
        TxtGivenQty.Text = ""
        TxtGivenQty.Text = "0"
        TxtQTYExpire.Text = "0"
        TxtGivenQty.Focus()
        TxtGivenQty.SelectAll()
    End Sub

   
    Private Sub TxtGivenQty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtGivenQty.KeyUp
        'If Val(TxtGivenQty.Text) > Val(TxtQTYExpire.Text) Then
        '    TxtGivenQty.Text = 0
        '    TxtGivenQty.Focus()
        '    TxtGivenQty.SelectAll()
        'End If
    End Sub

    Private Sub GridExpireDetail_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridExpireDetail.RowDoubleClick
        LblPriverID.Text = GridExpireDetail.GetRow.Cells("PROVIDER_ID").Value
        TxtProviderName.Text = GridExpireDetail.GetRow.Cells("VenderName").Value
        txtExpireDate.Text = GridExpireDetail.GetRow.Cells("EXPIRE_DATE").Value
        TxtQTYExpire.Text = GridExpireDetail.GetRow.Cells("UnitsInStock").Value
        LblExpireID.Text = GridExpireDetail.GetRow.Cells("InventoryID").Value
        TxtGivenQty.Text = "0"
        TxtGivenQty.Focus()
        TxtGivenQty.SelectAll()
    End Sub
End Class