Public Class MainFrm

    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'move to main form
        LoginForm.Show()
        Me.Visible = False
        'ends
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'move to main form
        CustRegfrm.Show()
        Me.Visible = False
        'ends
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'move to main form
        TransInfoEntryfrm.Show()
        Me.Visible = False
        'ends
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'move to main form
        VehicleDetailsfrm.Show()
        Me.Visible = False
        'ends
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'move to main form
        WorkerRegFrm.Show()
        Me.Visible = False
        'ends
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'move to main form
        ExpForm.Show()
        Me.Visible = False
        'ends
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReportFrm.Show()
        Me.Visible = False
    End Sub
End Class