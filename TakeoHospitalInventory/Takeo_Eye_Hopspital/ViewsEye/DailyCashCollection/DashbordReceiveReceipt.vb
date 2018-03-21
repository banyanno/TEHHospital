Imports System.Data.SqlClient

Public Class DashbordReceiveReceipt
    Dim mainForm As MainTakeoInventory
    Dim DAPaymentWaiting As New DSPaymentListTableAdapters.tblPatientReceiptTableAdapter
    Dim DAOpticalShop As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Dim DSWaitingPayment As New DSPaymentList
    Dim SQlDataAdapter As New SqlDataAdapter
    Dim SqlComman As New SqlCommand
    Sub New(ByVal mainSubForm As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.mainForm = mainSubForm
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub DashbordReceiveReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GenerateReceipt()
        'GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentListAll
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        GenerateReceipt()
        'GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentListAll
    End Sub
    
    Private Sub GenerateReceipt()
        Dim tblPermistion As DataTable = ModUser.GetMenuPermission(USER_NAME)
        Dim StrAdd As String = ""
      

        For Each rows As DataRow In tblPermistion.Rows

            If rows("MenuNo").ToString = "IR" Then
                StrAdd = StrAdd & "  ConGeneral='IR' OR"
            ElseIf rows("MenuNo").ToString = "NR" Then
                StrAdd = StrAdd & "  ConGeneral='NR' OR"
            ElseIf rows("MenuNo").ToString = "OR" Then
                StrAdd = StrAdd & "  ConGeneral='OR' OR"
            ElseIf rows("MenuNo").ToString = "OP" Then
                StrAdd = StrAdd & "  ConGeneral='OP' OR"
            End If
        Next
        If StrAdd = "" Then
            GridJanusWaitingPayment.DataSource = Nothing
        Else
            Dim Cnn As SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
            Try
                If Cnn.State = ConnectionState.Closed Then
                    Cnn.Open()
                End If
                SqlComman.CommandText = GetReceiptByDepartment(StrAdd) 'SearchPatient(patientNoSearh, OldPatientNo, DateFrom, DateTo, patientEngName, patientKhName, patientAge, patientSex, patientProvince, patientDistrict, patientCommune)

                SqlComman.Connection = Cnn
                SQlDataAdapter.SelectCommand = SqlComman
                DSWaitingPayment.tblPatientReceipt.Clear()
                SQlDataAdapter.Fill(DSWaitingPayment.tblPatientReceipt)  'DSPatient.TblPatients)
                'GridPatientInformation.DataSource = DSPatient.Tables(1)
                GridJanusWaitingPayment.DataSource = DSWaitingPayment.tblPatientReceipt
                Cnn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

        
    End Sub

    Private Function GetReceiptByDepartment(ByVal StrPara As String) As String
        Dim sql As String = "SELECT AmoutWord, ArtificialEyeFeeRiel, ArtificialEyeFeeUSD, CashRiel, CashTotal, CashUSD, CashierIn, CashierUpdate, ConAE, ConCON, ConDelete, ConFOL, ConFullFee, ConGLA, ConGeneral, ConMED, ConOP, ConOT, ConPay, ConSocialFee, ConsultationFeeRiel, ConsultationFeeUSD, DateIn, DateNow, DateUpdate, DonateNote, DonationID, DonationName, DonationPay, FollowUpFeeRiel, FollowUpFeeUSD, FullFeeRiel, FullFeeUSD, GlassFeeRiel, GlassFeeUSD, HN, HosFee, ID, IDCashReceipt, IsDonation, IsPatientNill, MedicineFeeRiel, MedicineFeeUSD, Operation, OperationFeeRiel, OperationFeeUSD, OtherFeeRiel, OtherFeeUSD, PatientName, PrintCount, Rates, ReceiptNo, ReceiptNote, SocialFeeRiel, SocialFeeUSD, TIME_CREATE, TIME_ISSUE, TotalRiel, TotalUSD, Years FROM tblPatientReceipt WHERE (ConPay = '0') AND (ConDelete = '0')  "
        If StrPara <> "" Then
            sql = sql & " AND (" & StrPara.Substring(0, StrPara.Length - 2).ToString & ")"
        End If
        sql = sql & " ORDER BY ReceiptNo "
        Return sql
    End Function

    Private Sub GridJanusWaitingPayment_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridJanusWaitingPayment.RowDoubleClick
        If GridJanusWaitingPayment.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select receipt to pay.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frmCashReceipt As New frmCashReceipt
            Dim frmInpatientR As New frmInpatientReceipt
            Dim frmNewOPR As New frmNewOutpatientReceipt
            Dim frmOldOPR As New frmOldOutPatientReceipt

            If GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "IR" Then
                isTrueFalse = True
                frmInpatientR.lblID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmInpatientR.lblReceiptToPrintID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmInpatientR.ShowDialog()
                GenerateReceipt()

                '--------Refresh data------------------
                'GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
                'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                'NumberofRecord()
                '--------------------------------------
            ElseIf GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "NR" Then
                isTrueFalse = True
                frmNewOPR.lblID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmNewOPR.lblReceiptToPrintID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmNewOPR.ShowDialog()
                GenerateReceipt()
                '--------Refresh data------------------

                'GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
                'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                ' NumberofRecord()
                '--------------------------------------
            ElseIf GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "OR" Then
                isTrueFalse = True
                frmOldOPR.lblID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmOldOPR.lblReceiptToPrintID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmOldOPR.GrpReferal.Visible = False
                frmOldOPR.ShowDialog()
                GenerateReceipt()
                '--------Refresh data------------------
                ' GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
                'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                'NumberofRecord()
                '--------------------------------------
            ElseIf GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "OP" Then
                PaymentForOpticalShop()
                GenerateReceipt()
                'GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
            ElseIf GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "CR" Then
                'isTrueFalse = True
                'frmCashReceipt.lblID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                'frmCashReceipt.txtCashReceiptNumber.Text = CRID
                'frmCashReceipt.lblReceiptToPrintID.Text = CRID
                'frmCashReceipt.ShowDialog()
                ''--------Refresh data------------------
                'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                ''NumberofRecord()
                ''--------------------------------------
            End If

        End If
    End Sub
    Sub PaymentForOpticalShop()
        ' MsgBox(GridJanusWaitingPayment.GetRow.Cells("ReceiptNo").Value)
        Dim TblOpticalShop As DataTable = DAOpticalShop.GetDataByReceiptNo(GridJanusWaitingPayment.GetRow.Cells("ReceiptNo").Value)
        ' if Rows count > 1 mean have multi receipt.....
        If TblOpticalShop.Rows.Count > 1 Then
        Else
            Dim fPayment As New FormPayment
            Dim isDisplayAmountCur As Integer = 0

            For Each DROW As DataRow In TblOpticalShop.Rows
                Dim TypeNo As Integer = DROW("IncomType")
                If TypeNo = 1 Then
                    fPayment.RadMedicine.Checked = True
                ElseIf TypeNo = 2 Then
                    fPayment.RadSunGlasses.Checked = True
                ElseIf TypeNo = 3 Then
                    fPayment.RadReadMod.Checked = True
                ElseIf TypeNo = 4 Then
                    fPayment.RadSpectacle.Checked = True
                ElseIf TypeNo = 5 Then
                    fPayment.RadFundRaising.Checked = True
                ElseIf TypeNo = 6 Then
                    fPayment.RadOther.Checked = True
                ElseIf TypeNo = 7 Then
                    fPayment.RadLV.Checked = True
                End If
                fPayment.LblReceiptID.Text = DROW("ReceiptID")
                fPayment.lblReceiptNo.Text = DROW("ReceiptNo")
                fPayment.LblReceiptDate.Text = DROW("ReceiptDate")
                fPayment.TxtCustomerNo.Text = DROW("CustomerNo")
                fPayment.TxtCustomerName.Text = DROW("CusName")
                fPayment.TxtAge.Text = DROW("Age")
                fPayment.TxtSex.Text = DROW("Sex")
                fPayment.TxtTotalAsDolar.Text = DROW("TotalDolar")
                fPayment.TxtTotalAsReal.Text = DROW("TotalReal")
                If TypeOf DROW("isDonation") Is DBNull Then
                    fPayment.TxtFundName.Text = ""
                Else

                    fPayment.TxtFundName.Text = IIf(TypeOf DROW("DonationName") Is DBNull, "", DROW("DonationName"))
                    If TypeOf DROW("DonateAmount") Is DBNull Then
                        fPayment.TxtDonateAmount.Text = ""
                    Else
                        fPayment.TxtDonateAmount.Text = DROW("DonateAmount")
                    End If
                End If
                If TypeOf DROW("PayByDonation") Is DBNull Then
                    fPayment.TxtPayByFund.Text = ""
                Else
                    fPayment.TxtPayByFund.Text = DROW("PayByDonation")
                End If
                If TypeOf DROW("PayBySelf") Is DBNull Then
                    fPayment.TxtPayBySelf.Text = ""
                Else
                    fPayment.TxtPayBySelf.Text = DROW("PayBySelf")
                End If


                '--- Load Payment type currency
                If TypeOf DROW("PaymentCur") Is DBNull = False Then
                    If DROW("PaymentCur") = "USD" Then
                        fPayment.RadUSD.Checked = True
                        fPayment.ChDolar.Checked = True
                        isDisplayAmountCur = 1
                    Else
                        fPayment.RadKHR.Checked = True
                        fPayment.ChReal.Checked = True
                        isDisplayAmountCur = 2
                    End If
                End If

                '--- Load Payment type information
                'MsgBox("Payment Type : ----> " & GridReceipt.GetRow.Cells("PaymentType").Value)
                If TypeOf DROW("PaymentType") Is DBNull = False Then
                    If DROW("PaymentType") = 1 Then
                        If TypeOf DROW("FullAmount") Is DBNull = False Then
                            fPayment.TxtFullAmount.Text = DROW("FullAmount")
                            fPayment.RadFull.Checked = True
                            If isDisplayAmountCur = 1 Then
                                fPayment.TxtAmountDolar.Text = DROW("FullAmount")
                            Else
                                fPayment.TxtAmounInReal.Text = DROW("FullAmount")
                            End If
                        Else
                            fPayment.TxtFullAmount.Text = ""
                        End If
                    ElseIf DROW("PaymentType") = 2 Then
                        If TypeOf DROW("NilAmount") Is DBNull = False Then
                            fPayment.TxtNilAmount.Text = DROW("NilAmount")
                            fPayment.RadNil.Checked = True
                        Else
                            fPayment.TxtNilAmount.Text = ""
                        End If
                    Else
                        If TypeOf DROW("SocialAmount") Is DBNull = False Then
                            fPayment.TxtSocialAmount.Text = DROW("SocialAmount")
                            fPayment.TxtTemSocialAmount.Text = DROW("SocialAmount")
                            fPayment.RadSocial.Checked = True
                            If isDisplayAmountCur = 1 Then
                                fPayment.TxtAmountDolar.Text = DROW("SocialAmount")
                            Else
                                fPayment.TxtAmounInReal.Text = DROW("SocialAmount")
                            End If
                        Else
                            fPayment.TxtSocialAmount.Text = ""
                        End If
                    End If
                End If

                '--- Pass Receipt status value
                fPayment.LblIsPaidStatus.Text = DROW("IsPaid")
                '--- Load information receipt paid
                If CInt(DROW("IsPaid")) = 1 Then

                    fPayment.LblAmountInFigureR.Visible = True
                    fPayment.LblAmountInFigureD.Visible = True
                    fPayment.Label19.Visible = True
                    If TypeOf DROW("Comment") Is DBNull Then
                        fPayment.TxtComment.Text = ""
                    Else
                        fPayment.TxtComment.Text = DROW("Comment")
                    End If

                    '--- Amount Customer Paid
                    If TypeOf DROW("PaidR") Is DBNull Then
                        fPayment.TxtAmounInReal.Text = ""
                        fPayment.LblAmountInFigureR.Text = "0.00"
                    Else
                        'fPayment.TxtAmounInReal.Text = GridReceipt.GetRow.Cells("PaidR").Value
                        fPayment.LblAmountInFigureR.Text = DROW("PaidR")
                        'fPayment.ChReal.Checked = True

                    End If

                    If TypeOf DROW("PaidDollar") Is DBNull Then
                        fPayment.TxtAmountDolar.Text = ""
                        fPayment.LblAmountInFigureD.Text = "0.00"
                    Else
                        'fPayment.TxtAmountDolar.Text = GridReceipt.GetRow.Cells("PaidDollar").Value
                        fPayment.LblAmountInFigureD.Text = DROW("PaidDollar")
                        'fPayment.ChDolar.Checked = True
                    End If

                    '--- Amount Return 
                    If TypeOf DROW("ReturnReal") Is DBNull Then
                        fPayment.TxtReturnReal.Text = ""
                    Else
                        fPayment.TxtReturnReal.Text = DROW("ReturnReal")
                    End If

                    If TypeOf DROW("ReturnDolar") Is DBNull Then
                        fPayment.TxtReturnDolar.Text = ""
                    Else
                        fPayment.TxtReturnDolar.Text = DROW("ReturnDolar")
                    End If
                    '--- Enable Box edit Reciept's comment purpose
                    fPayment.TxtComment.Enabled = True
                End If
            Next
            If fPayment.ShowDialog = DialogResult.OK Then

            End If
        End If

    End Sub

    Private Sub BtnNewCashCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCashCount.Click
        Dim CashCountByDep As New CashReceivedByDepartment
        CashCountByDep.ShowDialog()
    End Sub

    Private Sub BtnAccountReceiveable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccountReceiveable.Click
        Dim frmAccRec As New frmAccountReceivable
        frmAccRec.ShowDialog()
    End Sub

    Private Sub BtnAccPayable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccPayable.Click
        Dim FPayable As New FormNewAccountPayable
        FPayable.ShowDialog()

    End Sub

    Private Sub BtnDonate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDonate.Click
        Dim FMainDonation As New FormMainDonateReport
        FMainDonation.ShowDialog()
    End Sub
End Class
