Imports System.Data.Common
Imports Janus.Windows.GridEX

Public Class UCRunEndOfDay

    Dim ItemInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim MainStockItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim EndofDayRunDataAdapter As DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Private THIDataContext As New BaseDataContext
    Dim EndofDayRepo As IEndofDayRepository = New EndofDayRepository
    Dim VEODAccessRightDA As DSUserManagementTableAdapters.VEODAccessRightTableAdapter
    Dim MTakeoInventory As MainTakeoInventory

    Public Sub New(ByVal MTakeoInventory As MainTakeoInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        EndofDayRunDataAdapter = New DSEndofDayRunTableAdapters.VRunEndofDayResultTableAdapter
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        MainStockItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        VEODAccessRightDA = New DSUserManagementTableAdapters.VEODAccessRightTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub UCRunEndOfDay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Initial combo department
        With cbDepart
            '.DataSource = DepartDataAdapter.GetDepartDataByDepartID(CInt(DEPART_ID))
            .DataSource = VEODAccessRightDA.GetEODAccessRightByUserID(CInt(USER_ID)) '-- Get department list available for user run EOD
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbDepartS
            '.DataSource = DepartDataAdapter.GetDepartDataByDepartID(CInt(DEPART_ID))
            .DataSource = DepartDataAdapter.GetData '-- Get department list available for user run EOD
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(GetDateServer.Date, GetDateServer.Date)
        RunEndofDayStatus(REDCalendar.SelectionEnd.Date)

        '------- Activate Combo Department ------
        cbDepart.Enabled = Not (ChBAll.Checked)
        cbDepartS.Enabled = Not (ChBAllS.Checked)
        SplitContainer1.SplitterDistance = Me.Height / 3

    End Sub

    Private Sub BtnProcessEndOfDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcessEndOfDay.Click

        If MessageBox.Show("Do you want process run end of day ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MTakeoInventory.StatusLoading(True)
            Application.DoEvents()
            If BgLoadingRunEOD.IsBusy = True Then
                BgLoadingRunEOD.CancelAsync()
            Else
                BgLoadingRunEOD.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        If ChBAllS.Checked = False Then
            If ValidateCombobox(cbDepartS, "", ErrorEOD) = False Then Exit Sub

            Try
                Dim myDepartID As Integer = cbDepartS.SelectedValue
                Dim fromDate As Date = dptFromDate.Value.Date
                Dim toDate As Date = dptToDate.Value.Date

                gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllItemEndofDaySearch(myDepartID, fromDate, toDate)
            Catch ex As Exception

            End Try
        Else
            Try
                Dim fromDate As Date = dptFromDate.Value.Date
                Dim toDate As Date = dptToDate.Value.Date

                gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(fromDate, toDate)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub REDCalendar_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles REDCalendar.DateChanged       
        RunEndofDayStatus(REDCalendar.SelectionStart.Date)
    End Sub

    Sub RunEndofDayStatus(ByVal pDate As Date)
        If EndofDayRepo.IsRunEndofDayInParticularDay(CInt(DEPART_ID), pDate) = False Then
            LbNotYet.Visible = True
            LbReady.Visible = False
        Else
            LbNotYet.Visible = False
            LbReady.Visible = True
        End If
    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        If ValidateCombobox(cbDepartS, "", ErrorEOD) = False Then Exit Sub

        Dim FRptRequestView As New frmReportViewer

        '  FRptRequestView.ReportOption = 9
        FRptRequestView.ReportOption = 16
        FRptRequestView.FDate = dptFromDate.Value.Date
        FRptRequestView.TDate = dptToDate.Value.Date
        FRptRequestView.DepartID = cbDepartS.SelectedValue
        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub BgLoadingRunEOD_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingRunEOD.DoWork
        Try
            MenuReceivedAll.Enabled = False
        Catch ex As Exception

        End Try
        Try
            MenuReadyInOT.Enabled = False
        Catch ex As Exception

        End Try

        RubEndOfDay()
    End Sub

    Sub RubEndOfDay()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf RubEndOfDay))
        Else

            If ChBAll.Checked = True Then ' else of block chbAll = false -------------------------------------------------------------------------------------------------------------------------------

                Dim DepartTable As DataTable = DepartDataAdapter.GetData

                Dim DA_Request As New DSEODTableAdapters.tblRequestTableAdapter
                Dim DA_Req_Detail As New DSEODTableAdapters.tblRequestDetailTableAdapter
                Dim DA_Received As New DSEODTableAdapters.tblReceivedTableAdapter
                Dim DA_Received_detail As New DSEODTableAdapters.tblReceivedDetailTableAdapter
                Dim DA_Used As New DSEODTableAdapters.tblUsedTableAdapter
                Dim DA_UsedDetail As New DSEODTableAdapters.tblUsedDetailTableAdapter
                Dim DA_AdjustHis As New DSEODTableAdapters.tblAdjustStockHistoryTableAdapter
                Dim DA_Req_Caritas As New DSEODTableAdapters.CARITAS_REQUEST_INVENTORYTableAdapter
                Dim DA_Req_Carit_Detail As New DSEODTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
                Dim DA_EODRun As New DSEODTableAdapters.tblEndofDayRunTableAdapter
                Dim DA_EODStatus As New DSEODTableAdapters.tblEndofDayRunStatusTableAdapter
                Dim sysDate As Date = REDCalendar.SelectionEnd.Date
                Dim DA_BeginingTract As New DSEODTableAdapters.tblBeginBalanceTraceTableAdapter
                '==================== loop all department to eod ======================================
                For Each row As DataRow In DepartTable.Rows
                    


                    'Dim tblUsed As DataTable = DA_Used.GetUseListByDate(sysDate, CInt(row("DepartID")))
                    'Dim tblAdjustHis As DataTable = DA_AdjustHis.GetAdjustListByDate(sysDate, CInt(row("DepartID")))
                    'Dim TblReqListCaris As DataTable
                    'Dim TblRecListCaris As DataTable

                  


                                        '=================== Re-run EOD ===============================
                    DA_EODRun.DeleteEODByDepID(CInt(row("DepartID")), sysDate)
                    DA_EODStatus.DeleteEODStatusByDepID(CInt(row("DepartID")), sysDate)
                    DA_EODStatus.InsertNewEODStatusByDepID(sysDate, 1, CInt(row("DepartID")))
                    Dim TotalRequest As Integer = 0
                    Dim TotalReceived As Integer = 0
                    Dim TotalReqCar As Integer = 0
                    Dim TotalReceCar As Integer = 0
                    Dim TotalUsed As Integer = 0
                    Dim TotalAjust As Integer = 0
                    Dim ItemID As Integer = 0
                    '================= Item Request  In day ================
                    Application.DoEvents()
                    Threading.Thread.Sleep(100)
                    For Each rowReques As DataRow In DA_Request.GetRequestListByDate(sysDate, CInt(row("DepartID")))
                        For Each RowReqDetail As DataRow In DA_Req_Detail.GetRequestDetailListByRequestID(rowReques("RequestID")).Rows
                            DA_EODRun.InsertReqToEOD(sysDate, CInt(row("DepartID")), CInt(USER_ID), CInt(RowReqDetail("ItemID")), CInt(RowReqDetail("Quantity")), 0, 0, 0)
                        Next
                    Next
                    For Each RowReceived As DataRow In DA_Received.GetRecievedListByDate(sysDate, CInt(row("DepartID"))).Rows
                        For Each RowReceive As DataRow In DA_Received_detail.GetRecievedDetailListByRecievedID(RowReceived("ReceivedID")).Rows
                            DA_EODRun.InsertReqToEOD(sysDate, CInt(row("DepartID")), CInt(USER_ID), CInt(RowReceive("ItemID")), 0, CInt(RowReceive("ReceivedQuantity")), 0, 0)
                        Next
                    Next
                    '--- MainStock Request and Received to Caritas update End of day==================

                    If CInt(row("DepartID")) = MAIN_STOCK_DEPART_ID Then
                        Application.DoEvents()
                        Threading.Thread.Sleep(100)
                        ' MsgBox(row("DepartID"))
                        'For Each RowCaristas As DataRow In DA_Req_Caritas.GetCaritasRequestListByDate(sysDate).Rows
                        '    MsgBox(RowCaristas("Status").ToString)
                        '    If RowCaristas("Status") = 3 Then
                        For Each RowCarReqDetail As DataRow In DA_Req_Carit_Detail.GetReceivedCaritasBydate(sysDate) 'GetCaritasReqDetailListByReqID(RowCaristas("RequestID"))
                            DA_EODRun.InsertReqToEOD(sysDate, CInt(row("DepartID")), CInt(USER_ID), CInt(RowCarReqDetail("ItemID")), CInt(RowCarReqDetail("RequestQuantity")), CInt(RowCarReqDetail("ReceivedQuantity")), 0, 0)
                        Next
                        'For Each RowCarRec As DataRow In DA_Req_Carit_Detail
                        '    End If
                        'Next
                    End If
                    Application.DoEvents()
                    Threading.Thread.Sleep(100)
                    '--- Process run end of day item used in current day
                    For Each RowUsed As DataRow In DA_Used.GetUseListByDate(sysDate, CInt(row("DepartID"))).Rows
                        For Each RowUseDetail As DataRow In DA_UsedDetail.GetUsedDetailListByUsedID(RowUsed("UsedID")).Rows
                            DA_EODRun.InsertReqToEOD(sysDate, CInt(row("DepartID")), CInt(USER_ID), CInt(RowUseDetail("ItemID")), 0, 0, CInt(RowUseDetail("UsedQuantity")), 0)
                        Next
                    Next


                    Application.DoEvents()
                    Threading.Thread.Sleep(100)
                    '--- Process run of Day in for Adjust stok 
                    For Each RowAdjust As DataRow In DA_AdjustHis.GetAdjustListByDate(sysDate, CInt(row("DepartID"))).Rows
                        DA_EODRun.InsertReqToEOD(sysDate, CInt(row("DepartID")), CInt(USER_ID), CInt(RowAdjust("ItemID")), 0, 0, 0, CInt(RowAdjust("Difference")))
                    Next


                    ' ======= Update BeginBalance and EndBalance of item in table tblEndofDayRun (fomular = UnitsInStock + UsedQTY - ReceivedQTY)==========
                    'If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                    Application.DoEvents()
                    Threading.Thread.Sleep(100)

                    For Each RowEOD As DataRow In DA_EODRun.GetCurrentEODToUpdate(CInt(row("DepartID")), sysDate)
                        Application.DoEvents()
                        Threading.Thread.Sleep(100)
                        ' MessageBox.Show(row("DepartID") & "  " & RowEOD("ItemID"))
                        Dim BeginingItem As Integer
                        Try
                            BeginingItem = CInt(DA_BeginingTract.GetBeginingItemBalance(CInt(row("DepartID")), sysDate, CInt(RowEOD("ItemID"))))
                        Catch ex As Exception
                            BeginingItem = 0
                        End Try

                        Dim EndBalance As Integer = 0
                        For Each RowToUpdate As DataRow In DA_EODRun.GetExistingItemEOD(CInt(row("DepartID")), sysDate, CInt(RowEOD("ItemID")))
                            Application.DoEvents()
                            Threading.Thread.Sleep(100)
                            DA_EODRun.DeleteDateByDepAndItem(CInt(row("DepartID")), sysDate, CInt(RowEOD("ItemID")))
                            EndBalance = (BeginingItem + CInt(RowToUpdate("Rcqty")) + CInt(RowToUpdate("Ad"))) - CInt(RowToUpdate("UQty")) '((itemBeginBalance + updateEndofDayRun.ReceivedQty) + updateEndofDayRun.AdjustQTY) - (updateEndofDayRun.UseQty)
                            DA_EODRun.InsertLastUpdateEOD(sysDate, CInt(row("DepartID")), CInt(USER_ID), CInt(RowEOD("ItemID")), CInt(RowToUpdate("Rqty")), CInt(RowToUpdate("Rcqty")), CInt(RowToUpdate("UQty")), CInt(RowToUpdate("Ad")), BeginingItem, EndBalance)
                            'DA_EODRun .InsertReqToEOD (sysDate ,CInt(row("DepartID")),CInt(USER_ID ),CInt(RowEOD("ItemID")),cint(RowToUpdate("Rqty")),cint( RowToUpdate("Rcqty")),CInt(RowToUpdate("UQty"))
                            'DA_EODRun.UpdateExistItem(RowToUpdate("Rqty"), RowToUpdate("Rcqty"), RowToUpdate("UQty"), BeginingItem, 1, RowToUpdate("Ad"), CInt(row("DepartID")), CInt(RowEOD("ItemID")), sysDate)
                        Next
                    Next
                Next
            End If
            'End If
            End If
    End Sub

    Private Sub BgLoadingRunEOD_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingRunEOD.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
        Try
            MenuReceivedAll.Enabled = True
        Catch ex As Exception

        End Try
        Try
            MenuReadyInOT.Enabled = True
        Catch ex As Exception

        End Try
        gridItemsEndofDayRun.DataSource = EndofDayRunDataAdapter.GetAllRunEndofDayData(REDCalendar.SelectionEnd.Date, REDCalendar.SelectionEnd.Date)
        MessageBox.Show("Process run end of day successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

   
    Public Sub BtnEndofDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEndofDay.Click
        'If MessageBox.Show("Do you want process run end of day ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        If BgLoadingRunEOD.IsBusy = True Then
            BgLoadingRunEOD.CancelAsync()
        Else
            BgLoadingRunEOD.RunWorkerAsync()
        End If
        'End If
    End Sub


    Private Sub ChBAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAll.CheckedChanged
        cbDepart.Enabled = Not (ChBAll.Checked)

    End Sub


    Private Sub ChBAllS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAllS.CheckedChanged
        cbDepartS.Enabled = Not (ChBAllS.Checked)
    End Sub

    
End Class
