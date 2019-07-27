Module ModDoctor
    Function SaveDoctor(ByVal DoctorName As String, _
    ByVal Sex As String, _
    ByVal Age As String, _
    ByVal Tel As String, _
    ByVal Job As String, ByVal Is_Active As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblDoctor (DoctorName,Sex,Age,Tel,Job,Is_Active)" & _
                            " VALUES (N'" & DoctorName & "','" & Sex & "','" & Age & "','" & Tel & "','" & Job & "','" & Is_Active & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateDoctor(ByVal DoctorNo As String, _
    ByVal DoctorName As String, _
    ByVal Sex As String, _
    ByVal Age As String, _
    ByVal Tel As String, _
    ByVal Job As String, ByVal Is_Active As Boolean) As Integer
        Dim sql As String = "UPDATE TblDoctor SET" & _
                            " DoctorName = N'" & DoctorName & _
                            "',Sex = '" & Sex & _
                            "',Age = '" & Age & _
                            "',Tel = '" & Tel & _
                            "',Job = '" & Job & _
                            "',Is_Active='" & Is_Active & "' WHERE DoctorNo=" & DoctorNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectDoctor() As DataTable
        Dim sql As String = "SELECT doctorNo,DoctorName,sex,age,Tel,Job,Is_Active FROM TblDoctor"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function selectDotorActive()
        Dim sql As String = "SELECT doctorNo,DoctorName,sex,age,Tel,Job,Is_Active FROM TblDoctor where Is_Active='0'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function DeleteDoctor(ByVal No As String) As Integer
        Dim sql As String = "DELETE FROM TblDoctor WHERE DoctorNo=" & No
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    ' Other
    Function SaveOther(ByVal Other As String, ByVal Description As String) As Integer
        Dim sql As String = "INSERT INTO TblOthers (Other, Description) VALUES('" & Other & "','" & Description & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(Sql)
    End Function
    Function UdateOther(ByVal No As String, ByVal Other As String, ByVal Description As String) As Integer
        Dim sql As String = "UPDATE TblOthers SET Other='" & Other & "',Description='" & Description & "' WHERE No=" & No
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectOther() As DataTable
        Dim sql As String = "SELECT No , Other , Description FROM TblOthers Order By Other Asc"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function DeleteOther(ByVal No As String) As Integer
        Dim sql As String = "DELETE FROM TblOthers WHERE No=" & No
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
End Module
