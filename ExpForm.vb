Imports System.Data
Imports System.Data.OleDb
Public Class ExpForm
    Dim i As Integer
    Sub vehicle_noComboBoxRefresh()
        Ex_vehicle_noComboBox.ResetText()
        Dim con As New OleDb.OleDbConnection(strCon)

        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Try


            Dim DA As New OleDb.OleDbDataAdapter("SELECT vehicle_no FROM vehicle_details", con)
            Dim DS As New DataSet
            'fill data of trek in dataset
            DA.Fill(DS, "vehicle_details")

            con.Close()
            Dim j As Integer = 0
            'counting numbers of rows in dataset
            Dim i As Integer = DS.Tables("vehicle_details").Rows.Count


            'fill the combobox one item at a time
            While j <> i
                Ex_vehicle_noComboBox.Items.Add(DS.Tables("vehicle_details").Rows(j).Item(0))
                j = j + 1
            End While



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub ExpForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vehicle_noComboBoxRefresh()
        'TODO: This line of code loads data into the 'LogisticDataSet.vehicle_details' table. You can move, or remove it, as needed.
        Me.Vehicle_detailsTableAdapter.Fill(Me.LogisticDataSet.vehicle_details)
        Me.Expensis_entryTableAdapter.Fill(Me.LogisticDataSet.expensis_entry)
        savebtn.Enabled = False
        disables()
    End Sub
    Sub disables()
        IDTextBox.Enabled = False
        Ex_dateDateTimePicker.Enabled = False
        Ex_vehicle_noComboBox.Enabled = False
        RepairsTextBox.Enabled = False
        Driver_allowTextBox.Enabled = False
        OilTextBox.Enabled = False
        PuncherTextBox.Enabled = False
        Road_tokenTextBox.Enabled = False
        OtherTextBox.Enabled = False
        DieselTextBox.Enabled = False
    End Sub
    Sub enables()
        IDTextBox.Enabled = True
        Ex_dateDateTimePicker.Enabled = True
        Ex_vehicle_noComboBox.Enabled = True
        RepairsTextBox.Enabled = True
        Driver_allowTextBox.Enabled = True
        OilTextBox.Enabled = True
        PuncherTextBox.Enabled = True
        Road_tokenTextBox.Enabled = True
        OtherTextBox.Enabled = True
        DieselTextBox.Enabled = True
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        
        savebtn.Enabled = True
        enables()
            Me.Expensis_entryBindingSource.AddNew()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click

        Try


            If Len(Trim(Ex_vehicle_noComboBox.Text)) = 0 Then
                MessageBox.Show("Please Select vehicle No", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Ex_vehicle_noComboBox.Focus()
                Exit Sub
            End If

            If Len(Trim(RepairsTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Repairs", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                RepairsTextBox.Focus()
                Exit Sub
            End If

            If Len(Trim(Driver_allowTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Driver Allowance", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Driver_allowTextBox.Focus()
                Exit Sub
            End If
            If Len(Trim(OilTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Oil Expenses", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OilTextBox.Focus()
                Exit Sub
            End If
            If Len(Trim(PuncherTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Puncher Expenses", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PuncherTextBox.Focus()
                Exit Sub
            End If
            If Len(Trim(Road_tokenTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Road token", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Road_tokenTextBox.Focus()
                Exit Sub
            End If
            If Len(Trim(OtherTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Other Expenses", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OtherTextBox.Focus()
                Exit Sub
            End If
            If Len(Trim(DieselTextBox.Text)) = 0 Then
                MessageBox.Show("Please Enter Diesel Expenses", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DieselTextBox.Focus()
                Exit Sub
            End If
            Me.Validate()
            Me.Expensis_entryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)
            clearbtn.PerformClick()
            Me.Expensis_entryTableAdapter.Fill(Me.LogisticDataSet.expensis_entry)
        Catch ex As Exception

        End Try
        MsgBox("Data Saved Succesfull..!!!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub updatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatebtn.Click

        Try


            Me.Validate()
            Me.Expensis_entryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)
        Catch ex As Exception

        End Try
        MsgBox("Data Updated Succesfull..!!!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletebtn.Click

        Try
            Me.Validate()
            Me.Expensis_entryBindingSource.EndEdit()
            Me.Expensis_entryBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.LogisticDataSet)
        Catch ex As Exception

        End Try
        MsgBox("Data Deleted Succesfull..!!!", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        IDTextBox.Clear()
        Ex_vehicle_noComboBox.ResetText()
        RepairsTextBox.Clear()
        Driver_allowTextBox.Clear()
        OilTextBox.Clear()
        PuncherTextBox.Clear()
        Road_tokenTextBox.Clear()
        OtherTextBox.Clear()
        DieselTextBox.Clear()
    End Sub

    Private Sub DieselTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DieselTextBox.KeyPress
        DieselTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub OtherTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OtherTextBox.KeyPress
        OtherTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub Road_tokenTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Road_tokenTextBox.KeyPress
        Road_tokenTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub PuncherTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PuncherTextBox.KeyPress
        PuncherTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub OilTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OilTextBox.KeyPress
        OilTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub Driver_allowTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Driver_allowTextBox.KeyPress
        Driver_allowTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub RepairsTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RepairsTextBox.KeyPress
        RepairsTextBox.MaxLength = 10
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(45) Or e.KeyChar > Chr(45)) And e.KeyChar <> Chr(8) And (e.KeyChar < Chr(95) Or e.KeyChar > Chr(95)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainFrm.Show()
        Me.Visible = False
    End Sub

    Private Sub prevbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prevbtn.Click
        Me.Expensis_entryBindingSource.MovePrevious()
        enables()
    End Sub

    Private Sub nextbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextbtn.Click
        Me.Expensis_entryBindingSource.MoveNext()
        enables()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class