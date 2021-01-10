Public Class ExpensesReportFrm

    Private Sub ExpensesReportFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LogisticDataSet.expensis_entry' table. You can move, or remove it, as needed.
        Me.expensis_entryTableAdapter.Fill(Me.LogisticDataSet.expensis_entry)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        ReportFrm.Show()
    End Sub
End Class