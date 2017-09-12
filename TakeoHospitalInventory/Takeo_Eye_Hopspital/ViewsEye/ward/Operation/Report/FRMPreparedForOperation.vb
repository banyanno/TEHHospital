Public Class FRMPreparedForOperation
    Public Title1 As String = ""
    Public Title2 As String = ""
    Public OptionReport As Integer
    Public DateFrom As Date
    Public DateTo As Date
    Private Sub FRMPreparedForOperation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TblPreparForOperation As DataTable
        If OptionReport = 1 Then
            TblPreparForOperation = Me.ViewPreparForOperationTableAdapter.GetData()
        Else
            TblPreparForOperation = Me.ViewPreparForOperationTableAdapter.SelectOTHistory(DateFrom, DateTo)
        End If

        Dim CR As New CRPreparForOperation
        CR.SetDataSource(TblPreparForOperation)
        CRVPreparedForOperation.ReportSource = CR
        CR.SetParameterValue("Title1", Title1)
        CR.SetParameterValue("Title2", Title2)
        'CR.Refresh()
    End Sub
End Class