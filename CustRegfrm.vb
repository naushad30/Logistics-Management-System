Public Class CustRegfrm
    Private Sub CustRegfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Customer_regTableAdapter.Fill(Me.LogisticDataSet.customer_reg)
        savebtn.Enabled = False
        disables()

    End Sub
    Sub disables()
        C_idTextBox.Enabled = False
        NameTextBox.Enabled = False
        AddressTextBox.Enabled = False
        PhoneTextBox.Enabled = False
        Zip_codeTextBox.Enabled = False
        EmailTextBox.Enabled = False
    End Sub
    Sub enables()
        C_idTextBox.Enabled = True
        NameTextBox.Enabled = True
        AddressTextBox.Enabled = True
        PhoneTextBox.Enabled = True
        Zip_codeTextBox.Enabled = True
        EmailTextBox.Enabled = True
    End Sub

    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

       
        savebtn.Enabled = True
        enables()
            Me.Customer_regBindingSource.AddNew()
        Catch ex As Exception

        End Try

    End Sub
   
    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        Try

       
        If Len(Trim(NameTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NameTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(AddressTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddressTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(PhoneTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Phone no", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PhoneTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Zip_codeTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Zip-code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Zip_codeTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(EmailTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter E-mail", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmailTextBox.Focus()
            Exit Sub
        End If
        Me.Validate()
        Me.Customer_regBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)
        clearbtn.PerformClick()
            Me.Customer_regTableAdapter.Fill(Me.LogisticDataSet.customer_reg)
        Catch ex As Exception
            Throw ex

        End Try
        MsgBox("Data Saved Succesfull..!!!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub updatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatebtn.Click
        Try

            Me.Validate()
            Me.Customer_regBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)

        Catch ex As Exception

        End Try
        MsgBox("Data Updated Succesfull..!!!", MsgBoxStyle.OkOnly)
    End Sub


    Private Sub deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletebtn.Click
        Try

        
        Me.Validate()
        Me.Customer_regBindingSource.EndEdit()
        Me.Customer_regBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)
        Catch ex As Exception

        End Try
        MsgBox("Data Deleted Succesfull..!!!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        C_idTextBox.Clear()
        NameTextBox.Clear()
        AddressTextBox.Clear()
        PhoneTextBox.Clear()
        Zip_codeTextBox.Clear()
        EmailTextBox.Clear()
        NameTextBox.Focus()

    End Sub

    Private Sub prevbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prevbtn.Click
        Me.Customer_regBindingSource.MovePrevious()
        enables()
    End Sub

    Private Sub nextbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextbtn.Click
        Me.Customer_regBindingSource.MoveNext()
        enables()
    End Sub
  


    Private Sub EmailTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EmailTextBox.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If EmailTextBox.Text.Length > 0 Then
            If Not rEMail.IsMatch(EmailTextBox.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                EmailTextBox.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub PhoneTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PhoneTextBox.KeyPress
        PhoneTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub Zip_codeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Zip_codeTextBox.KeyPress
        Zip_codeTextBox.MaxLength = 6
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub PhoneLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub Customer_regDataGridView_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Customer_regDataGridView.MouseClick
        enables()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'move to main form
        MainFrm.Show()
        Me.Visible = False
        'ends
    End Sub
End Class
