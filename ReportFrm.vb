Public Class ReportFrm

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainFrm.Show()
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CustReportFrm.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VehicleReportFrm.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ExpensesReportFrm.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TransReportForm.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WorkerDetailReport.Show()
    End Sub
End Class