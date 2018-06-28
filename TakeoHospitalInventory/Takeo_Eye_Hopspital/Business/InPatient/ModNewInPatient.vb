Module ModNewInPatient
    Function SaveNewInPatient( _
    ByVal PatientNo As String, _
    ByVal Eye As String, _
    ByVal Diagnosis As String, _
    ByVal DiagnosisTem As String, _
    ByVal VA_RE As String, _
    ByVal VA_LE As String, _
    ByVal DateDischarge As String, _
    ByVal DateFollowUp As String, _
    ByVal Signature As Boolean, _
    ByVal TypeDiagnosis As Boolean, _
    ByVal Waiting As Integer, ByVal TIME_CREATE As String) As Integer
        Dim sql As String = "INSERT INTO TblNewInPatient " & _
                            "(PatientNo,Eye,Diagnosis,DiagnosisTem,VA_RE,VA_LE,DateDischarge,DateFollowUp,Signature,TypeDiagnosis,Waiting,TIME_CREATE) " & _
                            "VALUES (" & _
                            PatientNo & _
                            ",'" & Eye & _
                            "','" & Diagnosis & _
                            "','" & DiagnosisTem & _
                            "','" & VA_RE & _
                            "','" & VA_LE & _
                            "'," & DateDischarge & _
                            "," & DateFollowUp & _
                            ",'" & Signature & _
                            "','" & TypeDiagnosis & _
                            "'," & Waiting & ",'" & TIME_CREATE & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateOTWating(ByVal NewInPatientNo As String, ByVal Waiting As Integer) As Integer
        Dim sql As String = "UPDATE TblNewInpatient SET Waiting=" & Waiting & " WHERE NewInPatientNo=" & NewInPatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UpdateDeletePostonce(ByVal NewInPatientNo As String, ByVal IS_POSTPONE_DELETE As Boolean) As Integer
        Dim sql As String = "UPDATE TblNewInpatient SET IS_POSTPONE_DELETE='" & IS_POSTPONE_DELETE & "' WHERE NewInPatientNo=" & NewInPatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UpdateOTCancel(ByVal NewInPatientNo As String, ByVal OTCANCEL As String, ByVal OTCANCEL_DATE As DateTime, ByVal OTCANCEL_NOTE As String, ByVal OT_ISCANCEL As Boolean, ByVal DONATE_NAME As String, ByVal SURGERY_NAME As String, ByVal RECEIPT_NOM As String) As Integer
        Dim sql As String = "UPDATE TblNewInpatient SET OTCANCEL='" & OTCANCEL & "',OTCANCEL_DATE='" & OTCANCEL_DATE & "',OTCANCEL_NOTE='" & OTCANCEL_NOTE & "',OT_ISCANCEL ='" & OT_ISCANCEL & "',DONATE_NAME='" & DONATE_NAME & "', SURGERY_NAME='" & SURGERY_NAME & "',RECEIPT_NOM='" & RECEIPT_NOM & "',IS_CALL=0  WHERE NewInPatientNo=" & NewInPatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UpdateStatusCallPostpone(ByVal NewInpatientNo As String, ByVal Is_call As Boolean, ByVal Noted As String) As Integer
        Dim SQl As String = "UPDATE TblNewInpatient SET OTCANCEL_NOTE='" & Noted & "',IS_CALL_POSTPONE='" & Is_call & "'  WHERE NewInPatientNo=" & NewInpatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQl)
    End Function
    Function UpdateOTHistory(ByVal NewInpatientNo As String, ByVal HistoryStatus As Integer, ByVal HistoryDate As Date) As Integer
        Dim Sql As String = "Update TblNewInpatient SET HistoryOT=" & HistoryStatus & ",HistDatePrepar='" & HistoryDate & "' WHERE NewInPatientNo=" & NewInpatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(Sql)
    End Function
    Function CheckIOLExist(ByVal ItemID As Double, ByVal ItemeName As String) As Boolean
        Dim sql As String = "SELECT * FROM tblItem WHERE ITEMID=" & ItemID & " AND ITEMNAME='" & ItemeName.Trim & "'"
        Dim tblItem As DataTable = ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
        If tblItem.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function UpdatetFollowupInnewPatient(ByVal patientNo As String) As Integer
        If CheckNewInpatientExisting(patientNo) = True Then
            Dim sql As String = "UPDATE TblNewInpatient SET IS_PATIEN_FOLLOWUP='True' where PatientNo=" & patientNo
            Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
        Else
            Return 0
        End If
    End Function
    Function CheckNewInpatientExisting(ByVal PatientNo As String) As Boolean
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblNewInPatient WHERE PatientNo=" & PatientNo
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectAsScalar(sql)
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CheckNewInpatient(ByVal PatientNo As String) As Boolean
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblNewInPatient WHERE PatientNo=" & PatientNo & " AND  Leave =0"
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectAsScalar(sql)
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function UpdateFollowUp(ByVal NewInNo As String, ByVal DateDischarge As String, ByVal DateFollowUp As String, ByVal DrName As String) As Integer
        Dim sql As String = "UPDATE TblNewInPatient SET DateDischarge='" & DateDischarge & "', DateFollowUp=" & DateFollowUp & " , DR_NAME='" & DrName & "'" & _
        " WHERE NewInPatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UpdateVAAfterSurgeon(ByVal NewInPatientNo As Double, ByVal IS_VA_OPERATE As Boolean, ByVal VA_DR_SURGEON As String, ByVal VA_SURGEON_ONEYE As String, ByVal VA_SURGEON_PLAIN As String, ByVal VA_SURGEON_ICPH As String)
        Dim SQL As String = "UPDATE TblNewInPatient set IS_VA_OPERATE='" & IS_VA_OPERATE & "',VA_DR_SURGEON='" & VA_DR_SURGEON & "',VA_SURGEON_ONEYE='" & VA_SURGEON_ONEYE & "',VA_SURGEON_PLAIN='" & VA_SURGEON_PLAIN & "',VA_SURGEON_ICPH='" & VA_SURGEON_ICPH & "' WHERE NewInPatientNo=" & NewInPatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
    Function UpdateVAConselling(ByVal CONSULING_ID As Double, ByVal VA_PLAIN As String, ByVal VA_icPH As String)
        Dim SQL As String = "UPDATE CONSULING SET VA_PLAIN='" & VA_PLAIN & "',VA_icPH='" & VA_icPH & "' where CONSULING_ID=" & CONSULING_ID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
    Function GetConsellingInfo(ByVal PatientNo As String) As DataTable
        Dim SQL As String = "select top 1  * from CONSULING where PATIENT_NO='" & PatientNo & "'  order by CONSULING_ID desc"
        Return ModGlobleVariable.GENERAL_DAO.SelectAsDataTable(SQL)
    End Function
    Function UpdateNewInPatient(ByVal NewInNo As String, _
    ByVal PatientNo As String, _
    ByVal Eye As String, _
    ByVal Diagnosis As String, _
    ByVal DiagnosisTem As String, _
    ByVal VA_RE As String, _
    ByVal VA_LE As String, _
    ByVal DateDischarge As String, _
    ByVal DateFollowUp As String, _
    ByVal Signature As Boolean, _
    ByVal TypeDiagnosis As Boolean) As Integer
        Dim sql As String = "UPDATE TblNewInPatient SET " & _
        "Eye='" & Eye & "'," & _
        "Diagnosis='" & Diagnosis & "'," & _
        "DiagnosisTem='" & DiagnosisTem & "'," & _
        "VA_RE='" & VA_RE & "'," & _
        "VA_LE='" & VA_LE & "'," & _
        "DateDischarge=" & DateDischarge & "," & _
        "DateFollowUp=" & DateFollowUp & "," & _
        "Signature='" & Signature & "'," & _
        "TypeDiagnosis='" & TypeDiagnosis & "'" & _
        " WHERE NewInPatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectPatient(ByVal PatientNo As String) As DataTable
        Dim sql As String = "SELECT PatientNo,NameKhmer,Age,Sex,Address FROM TblPatients WHERE PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function DeleteNewInpatient(ByVal NewInNo As String) As Integer
        Dim sql As String = "DELETE FROM TblNewInpatient WHERE NewInpatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function CancelNewInpatient(ByVal NewInNo As String) As Integer
        Dim sql As String = "Update TblNewInpatient SET DeleteOption='True' WHERE NewInpatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UndoCancelNewInPatient(ByVal NewInNo As String) As Integer
        Dim sql As String = "Update TblNewInpatient SET DeleteOption='False' WHERE NewInpatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function UndoDischargedPatient(ByVal NewInNo As String, ByVal DateDischarge As String, ByVal DateFollowup As String) As Integer
        Dim sql As String = "Update TblNewInpatient SET DateDischarge=" & DateDischarge & ", DateFollowUp=" & DateFollowup & ", Leave='0' WHERE NewInpatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(Sql)
    End Function

    Function DeleteDaillyBookByNewInNo(ByVal NewInNo As String) As Integer
        Dim sql As String = "Update TblDaillyBook DeleteOption='True' WHERE NewInpatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UndoDeleteDiallyBook(ByVal NewInNo As String) As Integer
        Dim sql As String = "Update TblDaillyBook DeleteOption='False' WHERE NewInpatientNo=" & NewInNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function UpdateLeave(ByVal NewInPatientNo As String, ByVal Leave As String) As Integer
        Dim sql As String = "UPDATE TblNewInPatient SET Leave='" & Leave & "', DateDischarge='" & ModGlobleVariable.GeteDateServer & "' WHERE NewInPatientNo=" & NewInPatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function VAAfterSurgeon()
        Dim sql As String = "UPDATE TblNewInPatient SET Leave='" & Leave & "', DateDischarge='" & ModGlobleVariable.GeteDateServer & "' WHERE NewInPatientNo=" & NewInPatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function SelectOTForUpdate(ByVal OTNo As String) As DataTable
        Dim sql As String = "SELECT * FROM View_OTRegistration WHERE OTNo=" & OTNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function ViewPatienLeaveByDate(ByVal DateDischarge As String) As DataTable
        Dim sql As String = "SELECT * FROM V_NewInPatientDetial WHERE Leave='False' AND CONVERT(VARCHAR(10),DateDischarge, 103)= CONVERT(VARCHAR(10),CAST('" & DateDischarge & "' as DATETIME),103) "
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    ' Calculate Total Inpatient

    'Function TotalInpatientByDischarge(ByVal ChkBox As CheckBox, ByVal DateUpdateFrom As String, ByVal DateUpdateTo As String) As Integer
    '    If ChkBox.Checked = True Then
    '        Dim sql As String = "select count(PatientNo) as TotalInpatient from tblNewInpatient where DeleteOption='False'"
    '        sql = sql & " AND Leave !=0 AND CAST(CONVERT(VARCHAR(10), DateDischarge, 1) as DateTime) = CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdateTo & "' AS DATETIME), 1) as Datetime) AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) < CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdateFrom & "' AS DATETIME), 1) as Datetime)"
    '        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    '    End If
    'End Function

    'Function TotalInpatient(ByVal currentDate As String, ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "select count(PatientNo) as TotalInpatient from tblNewInpatient where DeleteOption='False'"
    '    If ChkBox.Checked = True Then
    '        sql = sql & "  AND Leave=0 AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) < CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime) "
    '    Else
    '        sql = sql & " AND Leave=0 AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) !=CAST(CONVERT(VARCHAR(10),CAST('" & currentDate & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function
    'Function TotalAllNewInaptient(ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "select count(PatientNo) as TotalInpatient from tblNewInpatient where leave=0 AND DeleteOption='False'"
    '    If ChkBox.Checked = True Then
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) <= CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function
    'Function TotalAdmmision(ByVal currentDate As String, ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "SELECT COUNT(PatientNo) as TotalAdmmision FROM tblNewInpatient " & _
    '                                "WHERE DeleteOption='False' and"
    '    If ChkBox.Checked = True Then
    '        sql = sql & " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) = CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime)"
    '    Else
    '        sql = sql & " leave=0 and  CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) =CAST(CONVERT(VARCHAR(10),CAST('" & currentDate & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function

    'Function TotalDischarge(ByVal currentDate As String, ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "SELECT COUNT(PatientNo) as TotalDischarge FROM tblNewInpatient " & _
    '                                " WHERE leave!=0 and DeleteOption='False'"
    '    If ChkBox.Checked = True Then
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), DateDischarge, 1) as DateTime) = CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime)"
    '    Else
    '        sql = sql & " and CAST(CONVERT(VARCHAR(10), DateDischarge, 1) as DateTime) = CAST(CONVERT(VARCHAR(10),CAST('" & currentDate & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function
    Function TotalInpatient(ByVal currentDate As String) As Integer
        Dim sql As String = "select count(patientNo) as TotalInpatient from tblNewInpatient where leave=0 AND DeleteOption='False' AND " & _
                                    " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) !=CAST(CONVERT(VARCHAR(10),CAST('" & currentDate & "' AS DATETIME), 1) as Datetime)"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalAllNewInaptient() As Integer
        Dim sql As String = "select count(patientNo) as TotalInpatient from tblNewInpatient where leave=0 AND DeleteOption='False'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalAdmmision(ByVal currentDate As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) as TotalAdmmision FROM tblNewInpatient " & _
                                    "WHERE leave=0 and DeleteOption='False' and  CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) =CAST(CONVERT(VARCHAR(10),CAST('" & currentDate & "' AS DATETIME), 1) as Datetime)"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalDischarge(ByVal currentDate As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) as TotalAdmmision FROM tblNewInpatient " & _
                                    " WHERE leave!=0 and deleteOption='False' and " & _
                                    " CAST(CONVERT(VARCHAR(10), DateDischarge, 1) as DateTime) =" & _
                                    " CAST(CONVERT(VARCHAR(10),CAST('" & currentDate & "' AS DATETIME), 1) as Datetime)"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    '-----------Finish calculate---------------------
    Function CountOTCataractReady(ByVal DateOT As String) As Integer
        Dim sql As String = "SELECT COUNT(T1.Diagnosis) AS TotalReadyDiagnosis " & _
        " FROM tblNewInpatient T1 INNER JOIN tblOTRegistration T2 " & _
        " ON T1.NewInPatientNo=T2.NewInpatientNo " & _
        " WHERE UPPER(T1.Diagnosis)=UPPER('Cataract') and T2.Status=1 and T1.Leave='0' AND T1.DeleteOption='False' " & _
        " AND CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) as DateTime) =CAST(CONVERT(VARCHAR(10),CAST('" & DateOT & "' AS DATETIME), 1) as Datetime)"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function CountOTOtherReady(ByVal DateOT As String) As Integer
        Dim sql As String = "SELECT COUNT(T1.Diagnosis) AS TotalReadyDiagnosis " & _
        " FROM tblNewInpatient T1 INNER JOIN tblOTRegistration T2 " & _
        " ON T1.NewInPatientNo=T2.NewInpatientNo " & _
        " WHERE UPPER(T1.Diagnosis)!=UPPER('Cataract') and T2.Status=1 and T1.Leave='0' AND T2.DeleteOption='False'" & _
        " AND CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) as DateTime) =CAST(CONVERT(VARCHAR(10),CAST('" & DateOT & "' AS DATETIME), 1) as Datetime)"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function CountWaitingOT() As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) AS TotalWaiting FROM   tblNewInpatient  WHERE Leave='0' AND DeleteOption='False' AND  Waiting=1"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function CountCorneaUlcer() As Integer
        Dim sql As String = "SELECT COUNT(PatientNO) TotalCorneaUlcer FROM TblNewInpatient WHERE upper(Diagnosis)=upper('corneal Ulcer') AND Leave=0 AND DeleteOption='False'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function CountOther() As Integer
        Dim sql As String = "SELECT COUNT(PatientNO) TotalCorneaUlcer FROM TblNewInpatient WHERE upper(Diagnosis)!=upper('corneal Ulcer') AND Leave=0 AND DeleteOption='False'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    ' Count OT for ward
    'Function CountOTCataractReady(ByVal DateOT As String, ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "SELECT COUNT(T1.Diagnosis) AS TotalReadyDiagnosis " & _
    '    " FROM tblNewInpatient T1 INNER JOIN tblOTRegistration T2 " & _
    '    " ON T1.NewInPatientNo=T2.NewInpatientNo " & _
    '    " WHERE UPPER(T1.Diagnosis)=UPPER('Cataract') and T2.Status=1 and T1.Leave=0 AND T1.DeleteOption='False'"
    '    If ChkBox.Checked = True Then
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) as DateTime) <= CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime)"
    '    Else
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) as DateTime) =CAST(CONVERT(VARCHAR(10),CAST('" & DateOT & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function
    'Function CountOTOtherReady(ByVal DateOT As String, ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "SELECT COUNT(T1.Diagnosis) AS TotalReadyDiagnosis " & _
    '    " FROM tblNewInpatient T1 INNER JOIN tblOTRegistration T2 " & _
    '    " ON T1.NewInPatientNo=T2.NewInpatientNo " & _
    '    " WHERE UPPER(T1.Diagnosis)!=UPPER('Cataract') and T2.Status=1 and T1.Leave=0 AND T2.DeleteOption='False'"
    '    If ChkBox.Checked = True Then
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) as DateTime) <= CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime)"
    '    Else
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) as DateTime) =CAST(CONVERT(VARCHAR(10),CAST('" & DateOT & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function

    'Function CountWaitingOT(ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "SELECT COUNT(PatientNo) AS TotalWaiting FROM   tblNewInpatient  WHERE Leave=0 AND DeleteOption='False' AND  Waiting=1"
    '    If ChkBox.Checked = True Then
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) <= CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function
    'Function CountCorneaUlcer(ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "SELECT COUNT(PatientNO) TotalCorneaUlcer FROM TblNewInpatient WHERE upper(Diagnosis)=upper('corneal Ulcer') AND Leave=0 AND DeleteOption='False'"
    '    If ChkBox.Checked = True Then
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) <= CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function
    'Function CountOther(ByVal ChkBox As CheckBox, ByVal DateUpdate As String) As Integer
    '    Dim sql As String = "SELECT COUNT(PatientNO) TotalCorneaUlcer FROM TblNewInpatient WHERE upper(Diagnosis)!=upper('corneal Ulcer') AND Leave=0 AND DeleteOption='False'"
    '    If ChkBox.Checked = True Then
    '        sql = sql & " AND CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) <= CAST(CONVERT(VARCHAR(10),CAST('" & DateUpdate & "' AS DATETIME), 1) as Datetime)"
    '    End If
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function

    '----Finish Count OT for ward

    Function DeleteInPatientBalance(ByVal currentDate As String) As Integer
        Dim sql As String = "DELETE FROM TblWardBalance WHERE CAST(CONVERT(VARCHAR(10), Date, 1) as DateTime) =CAST(CONVERT(VARCHAR(10),CAST('" & currentDate & "' AS DATETIME), 1) as Datetime)"
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    Function SaveDailyCountPatient(ByVal dateCount As String, _
    ByVal Inpatient As String, _
    ByVal Admission As String, _
    ByVal Discharge As String, _
    ByVal Total As String, _
    ByVal Surgery As String, _
    ByVal PostCat As String, _
    ByVal PostOther As String, _
    ByVal Corneal As String, _
    ByVal Waiting As String, _
    ByVal Others As String, _
    ByVal Note As String) As Integer
        DeleteInPatientBalance(dateCount)
        Dim sql As String = "INSERT INTO TblWardBalance (Date,Inpatient,Admission,Discharge,Total,Surgery,PostCat,PostOther,Corneal,Waiting,Others,Note) " & _
        " VALUES('" & dateCount & "'," & Inpatient & "," & Admission & "," & _
        Discharge & "," & Total & "," & Surgery & "," & PostCat & "," & _
        PostOther & "," & Corneal & "," & Waiting & "," & Others & ",'" & Note & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

    Function UpdateNurseOnCall(ByVal DateIn As String, ByVal Inpatient As Integer, ByVal Admission As Integer, ByVal Discharge As Integer, _
        ByVal Total As Integer, ByVal Surgery As Integer, ByVal PostCat As Integer, ByVal PostOther As Integer, ByVal Ulcer As Integer, _
        ByVal Waiting As Integer, ByVal Others As Integer, ByVal Note As String) As Integer
        Dim sql As String = "UPDATE TblWardBalance SET Inpatient=" & Inpatient & ", Admission=" & Admission & ", Discharge=" & Discharge & ", " & _
        " Total=" & Total & ", Surgery=" & Surgery & ", PostCat=" & PostCat & ", PostOther=" & PostOther & ", Corneal=" & Ulcer & ", " & _
        " Waiting=" & Waiting & ", Others=" & Others & ", Note='" & Note & "' WHERE Date='" & DateIn & "'"
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function SelectDailyInpatient(ByVal DateFrom As String, ByVal DateTo As String) As DataTable

        Dim sql As String = "SELECT * FROM TblWardBalance WHERE " & _
        " (CAST(CONVERT(VARCHAR(10), TblWardBalance.Date, 1)  " & _
        " AS DateTime) BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) AND CAST(CONVERT(VARCHAR(10), " & _
        " CAST('" & DateTo & "' AS DATETIME), 1) AS Datetime)) ORDER BY TblWardBalance.Date DESC "
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CountDailyPatient(ByVal Sex As String, ByVal DateFrom As String, ByVal DateTo As String) As Integer
        Dim sql As String = "select Count(T1." & Sex & ") FROM tblPatients T1 INNER JOIN TblNewInPatient T2 ON T1.PatientNo= T2.PatientNo WHERE" & _
        " (CAST(CONVERT(VARCHAR(10), T2.CreateDate, 1)  " & _
        " AS DateTime) BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) AND CAST(CONVERT(VARCHAR(10), " & _
        " CAST('" & DateTo & "' AS DATETIME), 1) AS Datetime)) "
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function SelectListNewInPatientDelete(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String) As DataTable
        Dim sql As String = "SELECT " & _
       " * FROM V_NewInPatientDetial" & _
       " WHERE DeleteOption='True' AND Leave=0 "
        If PatientNo <> "" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        If DateFrom <> "" And DateTo <> "" Then
            sql = sql & _
            " AND (CAST(CONVERT(VARCHAR(10), CreateDate, 1)  " & _
            " AS DateTime) BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) " & _
            " AND CAST(CONVERT(VARCHAR(10), " & _
            " CAST('" & DateTo & "' AS DATETIME), 1) AS Datetime))  "
        End If
        sql = sql & " ORDER BY CreateDate ASC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectListPatientDischarged(ByVal PatientNo As String, ByVal IsDocto As Boolean, ByVal DoctorName As String, ByVal DateFrom As String, ByVal DateTo As String) As DataTable
        Dim sql As String = "SELECT " & _
       " * FROM V_NewInpatientDetialLeave" & _
       " WHERE DeleteOption='False'"
        If PatientNo <> "" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        If IsDocto = True Then
            sql = sql & " AND DR_NAME='" & DoctorName & "' "
        End If
        If DateFrom <> "" And DateTo <> "" Then
            sql = sql & _
            " AND (CAST(CONVERT(VARCHAR(10), DateDischarge, 1)  " & _
            " AS DateTime) BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DateFrom & "' AS DATETIME), 1) AS Datetime) " & _
            " AND CAST(CONVERT(VARCHAR(10), " & _
            " CAST('" & DateTo & "' AS DATETIME), 1) AS Datetime))  "
        End If
        sql = sql & " ORDER BY DateDischarge ASC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
