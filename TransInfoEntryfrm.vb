Imports System.Data
Imports System.Data.OleDb

Public Class TransInfoEntryfrm
    Dim i As Integer

    Private Sub Transport_info_entryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.Transport_info_entryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)

    End Sub
    Sub DnameComboBoxRefresh()
        Driver_nameComboBox.ResetText()
        Dim con As New OleDb.OleDbConnection(strCon)

        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Try


            Dim DA As New OleDb.OleDbDataAdapter("SELECT name FROM worker_details where category='Driver'", con)
            Dim DS As New DataSet
            'fill data of trek in dataset
            DA.Fill(DS, "worker_details")

            con.Close()
            Dim j As Integer = 0
            'counting numbers of rows in dataset
            Dim i As Integer = DS.Tables("worker_details").Rows.Count


            'fill the combobox one item at a time
            While j <> i
                Driver_nameComboBox.Items.Add(DS.Tables("worker_details").Rows(j).Item(0))
                j = j + 1
            End While



        Catch ex As Exception
            '  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Sub nameComboBoxRefresh()
        NameComboBox.ResetText()
        Dim con As New OleDb.OleDbConnection(strCon)

        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Try


            Dim DA As New OleDb.OleDbDataAdapter("SELECT name FROM customer_reg", con)
            Dim DS As New DataSet
            'fill data of trek in dataset
            DA.Fill(DS, "customer_reg")

            con.Close()
            Dim j As Integer = 0
            'counting numbers of rows in dataset
            Dim i As Integer = DS.Tables("customer_reg").Rows.Count


            'fill the combobox one item at a time
            While j <> i
                NameComboBox.Items.Add(DS.Tables("customer_reg").Rows(j).Item(0))
                j = j + 1
            End While



        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub TransInfoEntryfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DnameComboBoxRefresh()
        nameComboBoxRefresh()
        disables()
        savebtn.Enabled = False
        Me.Vehicle_detailsTableAdapter.Fill(Me.LogisticDataSet.vehicle_details)
        Me.Worker_detailsTableAdapter.Fill(Me.LogisticDataSet.worker_details)
        Me.Customer_regTableAdapter.Fill(Me.LogisticDataSet.customer_reg)
        Me.Transport_info_entryTableAdapter.Fill(Me.LogisticDataSet.transport_info_entry)
      
        'TODO: This line of code loads data into the 'LogisticDataSet.transport_info_entry' table. You can move, or remove it, as needed.
    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameComboBox.SelectedIndexChanged
        Dim con As New OleDb.OleDbConnection(strCon)

        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Try


            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM customer_reg", con)
            Dim DS As New DataSet
            'fill data of trek in dataset
            DA.Fill(DS, "customer_reg")


            'assing then selected index 0f combobox to i

            i = NameComboBox.SelectedIndex


            'fill the textboxs
            If NameComboBox.SelectedText <> " " Then
                AddressTextBox.Text = DS.Tables("customer_reg").Rows(i)("address").ToString
                Zip_codeTextBox.Text = DS.Tables("customer_reg").Rows(i)("zip_code").ToString
                Phone_noTextBox.Text = DS.Tables("customer_reg").Rows(i)("phone").ToString
                EmailTextBox.Text = DS.Tables("customer_reg").Rows(i)("email").ToString
            End If



        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Sub enables()
        T_idTextBox.Enabled = True
        Transport_dateDateTimePicker.Enabled = True
        Driver_nameComboBox.Enabled = True
        Vehicle_noComboBox.Enabled = True
        Type_materialTextBox.Enabled = True
        AmountTextBox.Enabled = True
        NameComboBox.Enabled = True
        AddressTextBox.Enabled = True
        Zip_codeTextBox.Enabled = True
        Phone_noTextBox.Enabled = True
        EmailTextBox.Enabled = True
        R_nameTextBox.Enabled = True
        R_addressTextBox.Enabled = True
        R_zip_codeTextBox.Enabled = True
        R_phone_noTextBox.Enabled = True
        UnitTextBox.Enabled = True
        R_emailTextBox.Enabled = True

    End Sub
    Sub disables()
        T_idTextBox.Enabled = False
        Transport_dateDateTimePicker.Enabled = False
        Driver_nameComboBox.Enabled = False
        Vehicle_noComboBox.Enabled = False
        Type_materialTextBox.Enabled = False
        UnitTextBox.Enabled = False
        AmountTextBox.Enabled = False
        NameComboBox.Enabled = False
        AddressTextBox.Enabled = False
        Zip_codeTextBox.Enabled = False
        Phone_noTextBox.Enabled = False
        EmailTextBox.Enabled = False
        R_nameTextBox.Enabled = False
        R_addressTextBox.Enabled = False
        R_zip_codeTextBox.Enabled = False
        R_phone_noTextBox.Enabled = False
        R_emailTextBox.Enabled = False
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            savebtn.Enabled = True
            enables()

            Me.Transport_info_entryBindingSource.AddNew()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click


        If Len(Trim(Driver_nameComboBox.Text)) = 0 Then
            MessageBox.Show("Please Select Drivers Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Driver_nameComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Vehicle_noComboBox.Text)) = 0 Then
            MessageBox.Show("Please Select vehicle No", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Vehicle_noComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(Type_materialTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Material Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Type_materialTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(AmountTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AmountTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(NameComboBox.Text)) = 0 Then
            MessageBox.Show("Please Select senders Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NameComboBox.Focus()
            Exit Sub
        End If
        If Len(Trim(R_nameTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Receivers Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            R_nameTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(R_addressTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Receivers Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            R_addressTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(R_zip_codeTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Receivers Zip-Code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            R_zip_codeTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(R_phone_noTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Receivers Phone No", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            R_phone_noTextBox.Focus()
            Exit Sub
        End If
        If Len(Trim(R_emailTextBox.Text)) = 0 Then
            MessageBox.Show("Please Enter Receivers E-mail", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            R_emailTextBox.Focus()
            Exit Sub
        End If

        Me.Validate()
        Me.Transport_info_entryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)

        Me.Transport_info_entryTableAdapter.Fill(Me.LogisticDataSet.transport_info_entry)
        clearbtn.PerformClick()

        MsgBox("Data Saved Succesfull..!!!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Zip_codeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Zip_codeTextBox.KeyPress
        Zip_codeTextBox.MaxLength = 6
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub Phone_noTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Phone_noTextBox.KeyPress
        Phone_noTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
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

    Private Sub R_zip_codeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles R_zip_codeTextBox.KeyPress
        R_zip_codeTextBox.MaxLength = 6
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub R_phone_noTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles R_phone_noTextBox.KeyPress
        R_phone_noTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub
    Private Sub R_emailTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EmailTextBox.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If R_emailTextBox.Text.Length > 0 Then
            If Not rEMail.IsMatch(R_emailTextBox.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                R_emailTextBox.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub AmountTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AmountTextBox.KeyPress
        AmountTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub UnitTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UnitTextBox.KeyPress
        UnitTextBox.MaxLength = 5
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub updatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatebtn.Click
        Try
            Me.Validate()
            Me.Transport_info_entryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)
        Catch ex As Exception

        End Try
        MsgBox("Data Updated Succesfull..!!!", MsgBoxStyle.OkOnly)

    End Sub

    Private Sub deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletebtn.Click
        Try

        
        Me.Validate()
        Me.Transport_info_entryBindingSource.EndEdit()
        Me.Transport_info_entryBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)
        Catch ex As Exception

        End Try

        MsgBox("Data Deleted Succesfull..!!!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click

        Driver_nameComboBox.ResetText()
        Vehicle_noComboBox.ResetText()
        Type_materialTextBox.Clear()
        UnitTextBox.Clear()
        AmountTextBox.Clear()
        NameComboBox.ResetText()
        AddressTextBox.Clear()
        Zip_codeTextBox.Clear()
        Phone_noTextBox.Clear()
        EmailTextBox.Clear()
        R_nameTextBox.Clear()
        R_addressTextBox.Clear()
        R_zip_codeTextBox.Clear()
        R_phone_noTextBox.Clear()
        R_emailTextBox.Clear()

    End Sub


    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub

    Private Sub prevbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prevbtn.Click
        Me.Transport_info_entryBindingSource.MovePrevious()
        enables()
    End Sub

    Private Sub nextbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextbtn.Click
        Me.Transport_info_entryBindingSource.MoveNext()
        enables()
    End Sub


    Private Sub Transport_info_entryDataGridView_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        enables()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'move to main form
        MainFrm.Show()
        Me.Visible = False
        'ends
    End Sub

    Private Sub Transport_info_entryDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Transport_info_entryDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class