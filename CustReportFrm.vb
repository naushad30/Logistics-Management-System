Public Class CustReportFrm

    Private Sub ReportFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LogisticDataSet.transport_info_entry' table. You can move, or remove it, as needed.
        Me.transport_info_entryTableAdapter.Fill(Me.LogisticDataSet.transport_info_entry)
        'TODO: This line of code loads data into the 'LogisticDataSet.customer_reg' table. You can move, or remove it, as needed.
        Me.customer_regTableAdapter.Fill(Me.LogisticDataSet.customer_reg)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        ReportFrm.Show()
    End Sub
End Class