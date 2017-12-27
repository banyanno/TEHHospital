Public Class UCPatientReportUtility
    Dim CRReferal As New CRPatientReferal
    Dim CRRefDialy As New CRPatientReferralDialy
    Dim CRDisablity As New CRPatientDisability
    Dim CROccupation As New CRPatientOccupation
    Dim CRReferTo As New CRPatientRefer
    Dim CRReferalByAge As New CryPatientReferalByAge
    Dim CRCombindRefferal As New CRPCombindPateintRefferal
    Dim CRDisabilityByAge As New CRPatientDisabilityByAge
    Dim CRPatientCombindDisability As New CRPCombindPateintDisability
    Dim DFromReferal, DToReferal, DFromDisability, DToDisability, DFromOcc, DToOcc, DFromRefer, DToRefer As Date
    Dim TblPatientReferal, TblPatientReferalByAgeTakeo, TblReferalByKV, tblReferalBySelf, tblReferalByPatient, tblReferalByFriend, _
            tblReferalByCDMDS, tblReferalByChurch, tblReferalByNGO, tblReferalByWorker, tblReferalByOther, tblReferalPreyKabasVC, tblReferalPKScreening, TblSchoolScreening, TblMoPoCho As DataTable
    Dim TblPatientDisability, tblDisabilityHearing, tblDisabilityUnderstand, tblDisabilitySeeing, tblDisabilityPhysical As DataTable
    Dim TblPatientOccupation As DataTable
    Dim TblPatientReferTo As DataTable
    Dim DAReportRefferal As New DSReferal_New_OldTableAdapters.V_Referal_New_OldTableAdapter
    Dim DA_ReferalV1 As New DataReportUtilityTableAdapters.V_Referal_V1TableAdapter
    Dim DA_ReferalByAdult As New DataReportUtilityTableAdapters.V_Referal_VByAgeTableAdapter
    Dim Tbl_ReferalV1 As DataTable
    Dim TblPatientCombindDisAbility As DataTable
    Dim DA_PatientCombindDisability As New DSReferal_New_OldTableAdapters.ViewCombindPatientsDisabilityTableAdapter
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click

        DFromReferal = DateFrom.Value
        DToReferal = DateTo.Value
        BtnPreview.Enabled = False
        PicLoadReport.Visible = True
        BgLoadReportReferal.RunWorkerAsync()
    End Sub
    Private Sub btnPrintDisability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintDisability.Click
        DFromDisability = DateFromDis.Value
        DToDisability = DateToDis.Value
        btnPrintDisability.Enabled = False
        PicLoadReport.Visible = True
        BgDisability.RunWorkerAsync()
    End Sub
    Private Sub BgDisability_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgDisability.DoWork
        Call LoadReportDisability()
    End Sub
    Private Sub BgLoadReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadReportReferal.DoWork
        LoadReportReferal()
    End Sub

    Sub LoadReportReferal()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadReportReferal))
        Else
            If RadByDate.Checked = True Then
                Tbl_ReferalV1 = DA_ReferalByAdult.GetDataByDailyDate(DFromReferal, DToReferal)
            End If
            If RadReferalDaily.Checked = True Then
                'TblPatientReferal = Me.V_ReferalTableAdapter.GetDataPatientReferralDaily(DFromReferal, DToReferal) ' TblFollowUpWithReferalTableAdapter.GetData(DFromReferal, DToReferal)
                Tbl_ReferalV1 = DA_ReferalV1.GetDataByDailyDate(DFromReferal, DToReferal)
            End If
            If Me.RadReferalByAge.Checked = True Then
                TblPatientReferal = DAReportRefferal.GetDataByNew_Old_Referal(DToReferal, DFromReferal) ' Me.TblCombindRefferalTableAdapter.GetDataByRefferalCombind(DToReferal, DFromReferal)
                'tblReferalBySelf = Me.ReferalBySelfTableAdapter.GetDataSelf(DToReferal, DFromReferal)
                'tblReferalByPatient = Me.ReferalByPatientTableAdapter.GetDataPatient(DToReferal, DFromReferal)
                'tblReferalByFriend = Me.ReferalByFriendTableAdapter.GetDataFriend(DToReferal, DFromReferal)
                'tblReferalByCDMDS = Me.ReferalCDMDTableAdapter.GetDataCDMD(DToReferal, DFromReferal)
                'TblPatientReferalByAgeTakeo = Me.ReferalByTakeoTableAdapter.GetDataTakeoScreening(DToReferal, DFromReferal)
                'TblReferalByKV = Me.ReferalByKVTableAdapter.GetDataByKV(DToReferal, DFromReferal)
                'tblReferalByChurch = Me.ReferalByChurchTableAdapter.GetDataChurch(DToReferal, DFromReferal)
                'tblReferalByNGO = Me.ReferalByNGOTableAdapter.GetDataNGO(DToReferal, DFromReferal)
                'tblReferalByWorker = Me.ReferalByWorkerTableAdapter.GetDataWorker(DToReferal, DFromReferal)
                'tblReferalByOther = Me.ReferalByOtherTableAdapter.GetDataOther(DToReferal, DFromReferal)
                'tblReferalPreyKabasVC = Me.ReferalByPreyKabasVCTableAdapter.GetData(DToReferal, DFromReferal)
                'tblReferalPKScreening = Me.ReferalByPreyKabascreeningTableAdapter.GetData(DToReferal, DFromReferal)
                'TblSchoolScreening = Me.ReferalBySchoolTableAdapter.GetData(DToReferal, DFromReferal)
                'TblMoPoCho = Me.ReferalByMoPoChoTableAdapter.GetData(DToReferal, DFromReferal)

            End If
        End If
    End Sub

    Sub LoadReportDisability()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadReportDisability))
        Else
            If Me.rdDisByDaily.Checked = True Then
                TblPatientDisability = Me.DataTableDisabilityTableAdapter.GetData(DFromDisability, DToDisability)
            End If
            If Me.rdDisByAge.Checked = True Then
                If RadAll.Checked = True Then
                    tblDisabilityHearing = Me.DisabilityHearingTableAdapter.GetDataByHearing(DToDisability, DFromDisability)
                    tblDisabilityUnderstand = Me.DisabilityUnderstandTableAdapter.GetDataByUnderstand(DToDisability, DFromDisability)
                    tblDisabilitySeeing = Me.DisabilitySeeingTableAdapter.GetDataBySeeing(DToDisability, DFromDisability)
                    tblDisabilityPhysical = Me.DisabilityPhysicalTableAdapter.GetDataByPhysical(DToDisability, DFromDisability)
                ElseIf RadByNew.Checked = True Then
                    tblDisabilityHearing = Me.DisabilityHearingTableAdapter.GetDataByHearingFollowup(DFromDisability, DToDisability, False)
                    tblDisabilityUnderstand = Me.DisabilityUnderstandTableAdapter.GetDataByUnderstadingFollowup(DFromDisability, DToDisability, False)
                    tblDisabilitySeeing = Me.DisabilitySeeingTableAdapter.GetDataBySeeingFollowup(DFromDisability, DToDisability, False)
                    tblDisabilityPhysical = Me.DisabilityPhysicalTableAdapter.GetDataByPhysicalFollowup(DFromDisability, DToDisability, False)
                ElseIf RadByOld.Checked = True Then
                    tblDisabilityHearing = Me.DisabilityHearingTableAdapter.GetDataByHearingFollowup(DFromDisability, DToDisability, True)
                    tblDisabilityUnderstand = Me.DisabilityUnderstandTableAdapter.GetDataByUnderstadingFollowup(DFromDisability, DToDisability, True)
                    tblDisabilitySeeing = Me.DisabilitySeeingTableAdapter.GetDataBySeeingFollowup(DFromDisability, DToDisability, True)
                    tblDisabilityPhysical = Me.DisabilityPhysicalTableAdapter.GetDataByPhysicalFollowup(DFromDisability, DToDisability, True)


                End If
            End If
            If Me.RadCombinDisability.Checked = True Then
                If RadAll.Checked = True Then
                    TblPatientCombindDisAbility = DA_PatientCombindDisability.GetData(DateFromDis.Value.Date, DateToDis.Value.Date)
                ElseIf RadByNew.Checked = True Then
                    TblPatientCombindDisAbility = DA_PatientCombindDisability.GetDataByPatientNewOrOld(DateFromDis.Value.Date, DateToDis.Value.Date, False)
                ElseIf RadByOld.Checked = True Then
                    TblPatientCombindDisAbility = DA_PatientCombindDisability.GetDataByPatientNewOrOld(DateFromDis.Value.Date, DateToDis.Value.Date, True)
                End If

            End If
        End If

    End Sub
   

    Private Sub BgLoadReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadReportReferal.RunWorkerCompleted
        If RadByDate.Checked = True Then
            Dim ReferalV2 As New CRReferalV2
            ReferalV2.SetDataSource(Tbl_ReferalV1)

            'CRRefDialy.SetDataSource(TblPatientReferal)
            'CRRefDialy.SetParameterValue("Title", "Date from: " & Format(DFromReferal, "dd/MM/yyyy") & "  To: " & Format(DToReferal, "dd/MM/yyyy"))
            ReferalV2.SetParameterValue("Title", "Date from: " & Format(DFromReferal, "dd/MM/yyyy") & "  To: " & Format(DToReferal, "dd/MM/yyyy"))
            CRVPatientUtility.ReportSource = ReferalV2 ' CRRefDialy
            CRVPatientUtility.Refresh()
            BtnPreview.Enabled = True
            PicLoadReport.Visible = False
        End If
        If RadReferalDaily.Checked = True Then
            Dim ReferalV1 As New CRReferalV1
            ReferalV1.SetDataSource(Tbl_ReferalV1)

            'CRRefDialy.SetDataSource(TblPatientReferal)
            'CRRefDialy.SetParameterValue("Title", "Date from: " & Format(DFromReferal, "dd/MM/yyyy") & "  To: " & Format(DToReferal, "dd/MM/yyyy"))
            ReferalV1.SetParameterValue("Title", "Date from: " & Format(DFromReferal, "dd/MM/yyyy") & "  To: " & Format(DToReferal, "dd/MM/yyyy"))
            CRVPatientUtility.ReportSource = ReferalV1 ' CRRefDialy
            CRVPatientUtility.Refresh()
            BtnPreview.Enabled = True
            PicLoadReport.Visible = False
        End If
        If RadReferalByAge.Checked = True Then
            'CRReferalByAge.Subreports.Item("SELF").SetDataSource(tblReferalBySelf)
            'CRReferalByAge.Subreports.Item("PATIENT").SetDataSource(tblReferalByPatient)
            'CRReferalByAge.Subreports.Item("FRIEND").SetDataSource(tblReferalByFriend)
            'CRReferalByAge.Subreports.Item("CDMD").SetDataSource(tblReferalByCDMDS)
            'CRReferalByAge.Subreports.Item("TakeoScreening").SetDataSource(TblPatientReferalByAgeTakeo)
            'CRReferalByAge.Subreports.Item("KiryVongScreening").SetDataSource(TblReferalByKV)
            'CRReferalByAge.Subreports.Item("CHURCH").SetDataSource(tblReferalByChurch)
            'CRReferalByAge.Subreports.Item("NGO").SetDataSource(tblReferalByNGO)
            'CRReferalByAge.Subreports.Item("WORKER").SetDataSource(tblReferalByWorker)
            'CRReferalByAge.Subreports.Item("OTHER").SetDataSource(tblReferalByOther)
            'CRReferalByAge.Subreports.Item("PreyKabasVC").SetDataSource(tblReferalPreyKabasVC)
            'CRReferalByAge.Subreports.Item("PreyKabasScreening").SetDataSource(tblReferalPKScreening)
            'CRReferalByAge.Subreports.Item("SchoolScreening").SetDataSource(TblSchoolScreening)
            'CRReferalByAge.Subreports.Item("MoPoCho").SetDataSource(TblMoPoCho)
            'Dim Titles As CrystalDecisions.Shared.ParameterField
            'Titles = CRReferalByAge.ParameterFields("TitleDate")
            'Titles.CurrentValues.AddValue("Date from: " & Format(DateFrom.Value, "dd/MM/yyyy") & " To: " & Format(DateTo.Value, "dd/MM/yyyy"))
            '
            CRCombindRefferal.SetDataSource(TblPatientReferal)
            CRCombindRefferal.SetParameterValue("Title", "Date from: " & Format(DateFrom.Value, "dd/MM/yyyy") & " To: " & Format(DateTo.Value, "dd/MM/yyyy"))
            CRVPatientUtility.ReportSource = CRCombindRefferal
            CRVPatientUtility.Refresh()
            BtnPreview.Enabled = True
            PicLoadReport.Visible = False
        End If
    End Sub

    Private Sub BgDisability_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgDisability.RunWorkerCompleted
        If Me.rdDisByDaily.Checked = True Then
            Dim myArrayList As ArrayList = New ArrayList
            myArrayList.Add("Report Disability Date from " & Format(DFromDisability, "dd/MM/yyyy") & " To " & Format(DToDisability, "dd/MM/yyyy"))
            CRDisablity.SetDataSource(TblPatientDisability)
            CRVPatientUtility.ReportSource = CRDisablity
            Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVPatientUtility.ParameterFieldInfo
            ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
            CRVPatientUtility.Refresh()
            btnPrintDisability.Enabled = True
            PicLoadReport.Visible = False
        End If
        If Me.rdDisByAge.Checked = True Then
            CRDisabilityByAge.Subreports.Item("HEARING").SetDataSource(tblDisabilityHearing)
            CRDisabilityByAge.Subreports.Item("UNDERSTAND").SetDataSource(tblDisabilityUnderstand)
            CRDisabilityByAge.Subreports.Item("SEEING").SetDataSource(tblDisabilitySeeing)
            CRDisabilityByAge.Subreports.Item("PHYSICAL").SetDataSource(tblDisabilityPhysical)
            Dim Titles As CrystalDecisions.Shared.ParameterField
            If RadAll.Checked = True Then
                Titles = CRDisabilityByAge.ParameterFields("Title")
                Titles.CurrentValues.AddValue(" All Disability Date from: " & Format(Me.DateFromDis.Value, "dd/MM/yyyy") & " To: " & Format(Me.DateToDis.Value, "dd/MM/yyyy"))
            ElseIf RadByNew.Checked = True Then
                Titles = CRDisabilityByAge.ParameterFields("Title")
                Titles.CurrentValues.AddValue(" Disability for New Patioent Date from: " & Format(Me.DateFromDis.Value, "dd/MM/yyyy") & " To: " & Format(Me.DateToDis.Value, "dd/MM/yyyy"))
            ElseIf RadByOld.Checked = True Then
                Titles = CRDisabilityByAge.ParameterFields("Title")
                Titles.CurrentValues.AddValue(" Disability for Old Patient Date from: " & Format(Me.DateFromDis.Value, "dd/MM/yyyy") & " To: " & Format(Me.DateToDis.Value, "dd/MM/yyyy"))
            End If
            
            CRVPatientUtility.ReportSource = CRDisabilityByAge


            CRVPatientUtility.Refresh()
            btnPrintDisability.Enabled = True
            PicLoadReport.Visible = False
        End If
        If Me.RadCombinDisability.Checked = True Then

            CRPatientCombindDisability.SetDataSource(TblPatientCombindDisAbility)
            CRVPatientUtility.ReportSource = CRPatientCombindDisability
            If RadAll.Checked = True Then
                CRPatientCombindDisability.SetParameterValue("Title", "Combine Disability patient date from: " & Format(Me.DateFromDis.Value, "dd/MM/yyyy") & " To: " & Format(Me.DateToDis.Value, "dd/MM/yyyy"))
            ElseIf RadByNew.Checked = True Then
                CRPatientCombindDisability.SetParameterValue("Title", "Combine Disability for new patient date from: " & Format(Me.DateFromDis.Value, "dd/MM/yyyy") & " To: " & Format(Me.DateToDis.Value, "dd/MM/yyyy"))
            ElseIf RadByOld.Checked = True Then
                CRPatientCombindDisability.SetParameterValue("Title", "Combine Disability for all patient date from: " & Format(Me.DateFromDis.Value, "dd/MM/yyyy") & " To: " & Format(Me.DateToDis.Value, "dd/MM/yyyy"))
            End If

            CRVPatientUtility.Refresh()
            btnPrintDisability.Enabled = True
            PicLoadReport.Visible = False
        End If
    End Sub

    Private Sub btnPrintOccupationo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintOccupationo.Click
        DFromOcc = DateFromOcc.Value
        DToOcc = DateToOcc.Value
        btnPrintOccupationo.Enabled = True
        PicLoadReport.Visible = True
        BgOccupation.RunWorkerAsync()

    End Sub

    Private Sub BgOccupation_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgOccupation.DoWork
        TblPatientOccupation = Me.TblPatientsOccupationTableAdapter.GetData(DFromOcc, DToOcc)
    End Sub

    Private Sub BgOccupation_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgOccupation.RunWorkerCompleted
        Dim myArrayList As ArrayList = New ArrayList
        myArrayList.Add("Report Occupation Date from " & Format(DFromOcc, "dd/MM/yyyy") & " To " & Format(DToOcc, "dd/MM/yyyy"))
        CROccupation.SetDataSource(TblPatientOccupation)
        CRVPatientUtility.ReportSource = CROccupation
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVPatientUtility.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CRVPatientUtility.Refresh()
        btnPrintDisability.Enabled = True
        PicLoadReport.Visible = False
    End Sub

    Private Sub BgReferto_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgReferto.DoWork
        TblPatientReferTo = Me.V_PatientReferTableAdapter.GetData(DFromRefer, DToRefer)
    End Sub

    Private Sub BtnPrintRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintRefer.Click
        DFromRefer = DateReferFrom.Value
        DToRefer = DateReferTo.Value
        BtnPrintRefer.Enabled = False
        PicLoadReport.Visible = True
        BgReferto.RunWorkerAsync()
    End Sub

    Private Sub BgReferto_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgReferto.RunWorkerCompleted
        Dim myArrayList As ArrayList = New ArrayList
        myArrayList.Add("Report Refer Date from " & Format(DFromRefer, "dd/MM/yyyy") & " To " & Format(DToRefer, "dd/MM/yyyy"))
        CRReferTo.SetDataSource(TblPatientReferTo)
        CRVPatientUtility.ReportSource = CRReferTo
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVPatientUtility.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CRVPatientUtility.Refresh()
        BtnPrintRefer.Enabled = True
        PicLoadReport.Visible = False

    End Sub


    Dim TblDisDetial As DataTable
    Dim DA_DisDetial As New DSReferal_New_OldTableAdapters.V_DISABILITY_DETAILTableAdapter
    Dim CryDisDetail As New CrvDisabilityDetail

    Private Sub BtnPrintDisDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintDisDetail.Click
        DFromDisability = DDisFrom.Value.Date
        DToDisability = DDisTo.Value.Date
        BtnPrintDisDetail.Enabled = False
        PicLoadReport.Visible = True
        BgDisDetial.RunWorkerAsync()
    End Sub

    Private Sub BgDisDetial_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgDisDetial.DoWork
        LoadReportDisabilityDetail()
    End Sub
   
    Sub LoadReportDisabilityDetail()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadReportDisabilityDetail))
        Else
            'If Me.RViewAll.Checked = True Then
            TblDisDetial = DA_DisDetial.SelectDisability(DFromDisability, DToDisability)
            'End If
            'If Me.RHearing.Checked = True Then
            '    TblDisDetial = DA_DisDetial.SelectByHearing(DFromDisability, DToDisability)
            'End If
            'If Me.RPhysical.Checked = True Then
            '    TblDisDetial = DA_DisDetial.SelectPhysical(DFromDisability, DToDisability)
            'End If
            'If Me.RUnderstanding.Checked = True Then
            '    TblDisDetial = DA_DisDetial.SelectUnderdanding(DFromDisability, DToDisability)
            'End If
        End If
    End Sub

    Private Sub BgDisDetial_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgDisDetial.RunWorkerCompleted
        CryDisDetail.SetDataSource(TblDisDetial)
        CryDisDetail.SetParameterValue("Title", "From:" & DDisFrom.Text & " To:" & DDisTo.Text)
        CRVPatientUtility.ReportSource = CryDisDetail
        BtnPrintDisDetail.Enabled = True
        PicLoadReport.Visible = False
    End Sub

    Private Sub rdDisByAge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDisByAge.CheckedChanged
        GDisability.Enabled = rdDisByAge.Checked
    End Sub

    Private Sub RadCombinDisability_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCombinDisability.CheckedChanged
        GDisability.Enabled = RadCombinDisability.Checked
    End Sub
End Class
