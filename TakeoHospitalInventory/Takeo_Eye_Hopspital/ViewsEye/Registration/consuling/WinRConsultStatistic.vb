Public Class WinRConsultStatistic
    Dim DA_ConStatistic As New DSConsultTableAdapters.V_CONSULING_STATISTICTableAdapter
    Public DFrom, DTo As Date
    Dim CRConStatisistic As New CRDConsultStatistic
    Public Title As String
    Private Sub WinRConsultStatistic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TblStatistic As DataTable = DA_ConStatistic.SelectConsultStatistic(DFrom, DTo)

        CRConStatisistic.SetDataSource(TblStatistic)
        CRConStatisistic.SetParameterValue("Title", Title)
        CrvConsulting.ReportSource = CRConStatisistic
    End Sub
End Class