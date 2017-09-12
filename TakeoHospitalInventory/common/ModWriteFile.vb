Imports System.IO

Module ModWriteFile
    Public Function GetFileContents(ByVal FullPath As String, _
           Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
    End Function

    Public Function SaveTextToFile(ByVal strData As String, _
     ByVal FullPath As String, _
       Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try
            If File.Exists(FullPath) = False Then
                Dim fs As New FileStream(FullPath, FileMode.Create, FileAccess.Write)
                fs.Close()
                objReader = New StreamWriter(FullPath)
                objReader.Write(strData)
                objReader.Close()
                bAns = True
            Else
                objReader = New StreamWriter(FullPath)
                objReader.Write(strData)
                objReader.Close()
                bAns = True
            End If


        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function
End Module
