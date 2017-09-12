Module ModOTStatistic
    Function TotalNewInSurgeryM_F(ByVal SurgeryType As String, ByVal DFrom As Date, ByVal DTo As Date, ByVal Age1 As String, ByVal Age2 As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                           " FROM TblPatients AS T1 INNER JOIN TblOTRegistration AS T2 ON T1.PatientNo = T2.PatientNo " & _
                           " WHERE T2.DeleteOption='False' " & _
                           " AND (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ") AND T2.OperationType='" & SurgeryType & "'" & _
                            " AND (CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) AS DateTime) " & _
                            " BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DFrom & "' AS DATETIME), 1) AS Datetime) AND " & _
                            " CAST(CONVERT(VARCHAR(10), CAST('" & DTo & "' AS DATETIME), 1) AS Datetime))"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function TotalNewInSurgery50(ByVal SurgeryType As String, ByVal DFrom As Date, ByVal DTo As Date) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                                   " FROM TblPatients AS T1 INNER JOIN TblOTRegistration AS T2 ON T1.PatientNo = T2.PatientNo " & _
                                   " WHERE T2.DeleteOption='False' " & _
                                   " AND (T1.Age >=50 AND T2.OperationType='" & SurgeryType & "')" & _
                                   " AND (CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) AS DateTime) " & _
                                " BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DFrom & "' AS DATETIME), 1) AS Datetime) AND " & _
                                " CAST(CONVERT(VARCHAR(10), CAST('" & DTo & "' AS DATETIME), 1) AS Datetime))"

        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function TotalEachSurgery(ByVal SurgeryType As String, ByVal DFrom As Date, ByVal DTo As Date, ByVal Age1 As String, ByVal Age2 As String) As Integer
        Dim sql As String = "SELECT COUNT(T2.PatientNo) FROM TblPatients AS T1 INNER JOIN TblOTRegistration AS T2 ON T1.PatientNo = T2.PatientNo " & _
                            " WHERE T2.DeleteOption='False' " & _
                            " AND  T2.OperationType='" & SurgeryType & "'" & _
                            " AND (CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) AS DateTime) " & _
                            " BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DFrom & "' AS DATETIME), 1) AS Datetime) AND " & _
                            " CAST(CONVERT(VARCHAR(10), CAST('" & DTo & "' AS DATETIME), 1) AS Datetime))"
        '" AND" & _
        '" (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ") "

        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)

    End Function
    Function TotalNewInSurgery(ByVal DFrom As Date, ByVal DTo As Date) As Integer
        Dim sql As String = "SELECT COUNT(T2.PatientNo) FROM TblPatients AS T1 INNER JOIN TblOTRegistration AS T2 ON T1.PatientNo = T2.PatientNo " & _
                       " WHERE T2.DeleteOption='False' " & _
                       " AND" & _
                      "  (CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) AS DateTime) " & _
                            " BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DFrom & "' AS DATETIME), 1) AS Datetime) AND " & _
                            " CAST(CONVERT(VARCHAR(10), CAST('" & DTo & "' AS DATETIME), 1) AS Datetime))"
        '" AND" & _
        '" (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ")"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalOtherSurgery(ByVal SurgeryType As String, ByVal DFrom As Date, ByVal DTo As Date, ByVal Age1 As String, ByVal Age2 As String) As Integer
        Dim sql As String = "SELECT COUNT(T2.PatientNo) FROM TblPatients AS T1 INNER JOIN TblOTRegistration AS T2 ON T1.PatientNo = T2.PatientNo " & _
                             " WHERE T2.DeleteOption='False' " & _
                             " AND" & _
                             " (CAST(CONVERT(VARCHAR(10), T2.DateOperated, 1) AS DateTime) " & _
                            " BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DFrom & "' AS DATETIME), 1) AS Datetime) AND " & _
                            " CAST(CONVERT(VARCHAR(10), CAST('" & DTo & "' AS DATETIME), 1) AS Datetime))"
        '" AND" & _
        '" (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ")"
        If SurgeryType <> "" Then
            sql = sql & SurgeryType
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
End Module
