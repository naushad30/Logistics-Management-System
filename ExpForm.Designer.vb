<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Button9 As System.Windows.Forms.Button
        Dim addButton As System.Windows.Forms.Button
        Dim IDLabel As System.Windows.Forms.Label
        Dim Ex_dateLabel As System.Windows.Forms.Label
        Dim RepairsLabel As System.Windows.Forms.Label
        Dim Driver_allowLabel As System.Windows.Forms.Label
        Dim OilLabel As System.Windows.Forms.Label
        Dim PuncherLabel As System.Windows.Forms.Label
        Dim Road_tokenLabel As System.Windows.Forms.Label
        Dim OtherLabel As System.Windows.Forms.Label
        Dim DieselLabel As System.Windows.Forms.Label
        Dim Button2 As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Dim Ex_vehicle_noLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableAdapterManager = New logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager()
        Me.Expensis_entryTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.expensis_entryTableAdapter()
        Me.Expensis_entryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogisticDataSet = New logistics_ms.LogisticDataSet()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Ex_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RepairsTextBox = New System.Windows.Forms.TextBox()
        Me.Driver_allowTextBox = New System.Windows.Forms.TextBox()
        Me.OilTextBox = New System.Windows.Forms.TextBox()
        Me.PuncherTextBox = New System.Windows.Forms.TextBox()
        Me.Road_tokenTextBox = New System.Windows.Forms.TextBox()
        Me.OtherTextBox = New System.Windows.Forms.TextBox()
        Me.DieselTextBox = New System.Windows.Forms.TextBox()
        Me.Expensis_entryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatMini1 = New logistics_ms.FlatMini()
        Me.FlatMax1 = New logistics_ms.FlatMax()
        Me.FlatClose1 = New logistics_ms.FlatClose()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.prevbtn = New System.Windows.Forms.Button()
        Me.nextbtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ex_vehicle_noComboBox = New System.Windows.Forms.ComboBox()
        Me.VehicledetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vehicle_detailsTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.vehicle_detailsTableAdapter()
        Button9 = New System.Windows.Forms.Button()
        addButton = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        Ex_dateLabel = New System.Windows.Forms.Label()
        RepairsLabel = New System.Windows.Forms.Label()
        Driver_allowLabel = New System.Windows.Forms.Label()
        OilLabel = New System.Windows.Forms.Label()
        PuncherLabel = New System.Windows.Forms.Label()
        Road_tokenLabel = New System.Windows.Forms.Label()
        OtherLabel = New System.Windows.Forms.Label()
        DieselLabel = New System.Windows.Forms.Label()
        Button2 = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        Ex_vehicle_noLabel = New System.Windows.Forms.Label()
        CType(Me.Expensis_entryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Expensis_entryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VehicledetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button9
        '
        Button9.BackColor = System.Drawing.Color.MediumSeaGreen
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button9.Location = New System.Drawing.Point(621, 333)
        Button9.Name = "Button9"
        Button9.Size = New System.Drawing.Size(75, 32)
        Button9.TabIndex = 75
        Button9.Text = "Back"
        Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button9.UseVisualStyleBackColor = False
        AddHandler Button9.Click, AddressOf Me.Button9_Click
        '
        'addButton
        '
        addButton.BackColor = System.Drawing.Color.MediumSeaGreen
        addButton.FlatAppearance.BorderSize = 0
        addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        addButton.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        addButton.Location = New System.Drawing.Point(621, 127)
        addButton.Name = "addButton"
        addButton.Size = New System.Drawing.Size(75, 33)
        addButton.TabIndex = 70
        addButton.Text = "Add"
        addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        addButton.UseVisualStyleBackColor = False
        AddHandler addButton.Click, AddressOf Me.addButton_Click
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        IDLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        IDLabel.Location = New System.Drawing.Point(17, 30)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(20, 15)
        IDLabel.TabIndex = 75
        IDLabel.Text = "ID"
        '
        'Ex_dateLabel
        '
        Ex_dateLabel.AutoSize = True
        Ex_dateLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ex_dateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Ex_dateLabel.Location = New System.Drawing.Point(14, 62)
        Ex_dateLabel.Name = "Ex_dateLabel"
        Ex_dateLabel.Size = New System.Drawing.Size(37, 15)
        Ex_dateLabel.TabIndex = 77
        Ex_dateLabel.Text = "Date"
        '
        'RepairsLabel
        '
        RepairsLabel.AutoSize = True
        RepairsLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RepairsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        RepairsLabel.Location = New System.Drawing.Point(14, 123)
        RepairsLabel.Name = "RepairsLabel"
        RepairsLabel.Size = New System.Drawing.Size(53, 15)
        RepairsLabel.TabIndex = 81
        RepairsLabel.Text = "Repairs"
        '
        'Driver_allowLabel
        '
        Driver_allowLabel.AutoSize = True
        Driver_allowLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Driver_allowLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Driver_allowLabel.Location = New System.Drawing.Point(13, 152)
        Driver_allowLabel.Name = "Driver_allowLabel"
        Driver_allowLabel.Size = New System.Drawing.Size(114, 15)
        Driver_allowLabel.TabIndex = 83
        Driver_allowLabel.Text = "Driver Allowance"
        '
        'OilLabel
        '
        OilLabel.AutoSize = True
        OilLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OilLabel.ForeColor = System.Drawing.Color.White
        OilLabel.Location = New System.Drawing.Point(14, 183)
        OilLabel.Name = "OilLabel"
        OilLabel.Size = New System.Drawing.Size(24, 15)
        OilLabel.TabIndex = 85
        OilLabel.Text = "Oil"
        '
        'PuncherLabel
        '
        PuncherLabel.AutoSize = True
        PuncherLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PuncherLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PuncherLabel.Location = New System.Drawing.Point(14, 214)
        PuncherLabel.Name = "PuncherLabel"
        PuncherLabel.Size = New System.Drawing.Size(58, 15)
        PuncherLabel.TabIndex = 87
        PuncherLabel.Text = "Puncher"
        '
        'Road_tokenLabel
        '
        Road_tokenLabel.AutoSize = True
        Road_tokenLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Road_tokenLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Road_tokenLabel.Location = New System.Drawing.Point(14, 245)
        Road_tokenLabel.Name = "Road_tokenLabel"
        Road_tokenLabel.Size = New System.Drawing.Size(84, 15)
        Road_tokenLabel.TabIndex = 89
        Road_tokenLabel.Text = "Road Token"
        '
        'OtherLabel
        '
        OtherLabel.AutoSize = True
        OtherLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OtherLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        OtherLabel.Location = New System.Drawing.Point(14, 275)
        OtherLabel.Name = "OtherLabel"
        OtherLabel.Size = New System.Drawing.Size(44, 15)
        OtherLabel.TabIndex = 91
        OtherLabel.Text = "Other"
        '
        'DieselLabel
        '
        DieselLabel.AutoSize = True
        DieselLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DieselLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DieselLabel.Location = New System.Drawing.Point(14, 306)
        DieselLabel.Name = "DieselLabel"
        DieselLabel.Size = New System.Drawing.Size(46, 15)
        DieselLabel.TabIndex = 93
        DieselLabel.Text = "Diesel"
        '
        'Button2
        '
        Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button2.Location = New System.Drawing.Point(28, 9)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(10, 33)
        Button2.TabIndex = 27
        Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button1.Location = New System.Drawing.Point(12, 9)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(10, 33)
        Button1.TabIndex = 26
        Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        '
        'Ex_vehicle_noLabel
        '
        Ex_vehicle_noLabel.AutoSize = True
        Ex_vehicle_noLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ex_vehicle_noLabel.Location = New System.Drawing.Point(14, 91)
        Ex_vehicle_noLabel.Name = "Ex_vehicle_noLabel"
        Ex_vehicle_noLabel.Size = New System.Drawing.Size(77, 15)
        Ex_vehicle_noLabel.TabIndex = 94
        Ex_vehicle_noLabel.Text = "Vehicle No."
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customer_regTableAdapter = Nothing
        Me.TableAdapterManager.expensis_entryTableAdapter = Me.Expensis_entryTableAdapter
        Me.TableAdapterManager.transport_info_entryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vehicle_detailsTableAdapter = Nothing
        Me.TableAdapterManager.worker_detailsTableAdapter = Nothing
        '
        'Expensis_entryTableAdapter
        '
        Me.Expensis_entryTableAdapter.ClearBeforeFill = True
        '
        'Expensis_entryBindingSource
        '
        Me.Expensis_entryBindingSource.DataMember = "expensis_entry"
        Me.Expensis_entryBindingSource.DataSource = Me.LogisticDataSet
        '
        'LogisticDataSet
        '
        Me.LogisticDataSet.DataSetName = "LogisticDataSet"
        Me.LogisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.clearbtn.FlatAppearance.BorderSize = 0
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearbtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clearbtn.Location = New System.Drawing.Point(621, 283)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(75, 33)
        Me.clearbtn.TabIndex = 74
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.deletebtn.FlatAppearance.BorderSize = 0
        Me.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletebtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deletebtn.Location = New System.Drawing.Point(621, 244)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 33)
        Me.deletebtn.TabIndex = 73
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.updatebtn.FlatAppearance.BorderSize = 0
        Me.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatebtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updatebtn.Location = New System.Drawing.Point(621, 205)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(75, 33)
        Me.updatebtn.TabIndex = 72
        Me.updatebtn.Text = "Update"
        Me.updatebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.savebtn.FlatAppearance.BorderSize = 0
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.savebtn.Location = New System.Drawing.Point(621, 166)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(75, 33)
        Me.savebtn.TabIndex = 71
        Me.savebtn.Text = "Save"
        Me.savebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.Color.Black
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "ID", True))
        Me.IDTextBox.ForeColor = System.Drawing.Color.White
        Me.IDTextBox.Location = New System.Drawing.Point(145, 25)
        Me.IDTextBox.Multiline = True
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.IDTextBox.TabIndex = 76
        '
        'Ex_dateDateTimePicker
        '
        Me.Ex_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Expensis_entryBindingSource, "ex_date", True))
        Me.Ex_dateDateTimePicker.Location = New System.Drawing.Point(145, 57)
        Me.Ex_dateDateTimePicker.Name = "Ex_dateDateTimePicker"
        Me.Ex_dateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Ex_dateDateTimePicker.TabIndex = 78
        '
        'RepairsTextBox
        '
        Me.RepairsTextBox.BackColor = System.Drawing.Color.Black
        Me.RepairsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RepairsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "repairs", True))
        Me.RepairsTextBox.ForeColor = System.Drawing.Color.White
        Me.RepairsTextBox.Location = New System.Drawing.Point(145, 122)
        Me.RepairsTextBox.Multiline = True
        Me.RepairsTextBox.Name = "RepairsTextBox"
        Me.RepairsTextBox.Size = New System.Drawing.Size(200, 26)
        Me.RepairsTextBox.TabIndex = 82
        '
        'Driver_allowTextBox
        '
        Me.Driver_allowTextBox.BackColor = System.Drawing.Color.Black
        Me.Driver_allowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Driver_allowTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "driver_allow", True))
        Me.Driver_allowTextBox.ForeColor = System.Drawing.Color.White
        Me.Driver_allowTextBox.Location = New System.Drawing.Point(145, 152)
        Me.Driver_allowTextBox.Multiline = True
        Me.Driver_allowTextBox.Name = "Driver_allowTextBox"
        Me.Driver_allowTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Driver_allowTextBox.TabIndex = 84
        '
        'OilTextBox
        '
        Me.OilTextBox.BackColor = System.Drawing.Color.Black
        Me.OilTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "oil", True))
        Me.OilTextBox.ForeColor = System.Drawing.Color.White
        Me.OilTextBox.Location = New System.Drawing.Point(145, 183)
        Me.OilTextBox.Multiline = True
        Me.OilTextBox.Name = "OilTextBox"
        Me.OilTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OilTextBox.TabIndex = 86
        '
        'PuncherTextBox
        '
        Me.PuncherTextBox.BackColor = System.Drawing.Color.Black
        Me.PuncherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PuncherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "puncher", True))
        Me.PuncherTextBox.ForeColor = System.Drawing.Color.White
        Me.PuncherTextBox.Location = New System.Drawing.Point(145, 214)
        Me.PuncherTextBox.Multiline = True
        Me.PuncherTextBox.Name = "PuncherTextBox"
        Me.PuncherTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PuncherTextBox.TabIndex = 88
        '
        'Road_tokenTextBox
        '
        Me.Road_tokenTextBox.BackColor = System.Drawing.Color.Black
        Me.Road_tokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Road_tokenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "road_token", True))
        Me.Road_tokenTextBox.ForeColor = System.Drawing.Color.White
        Me.Road_tokenTextBox.Location = New System.Drawing.Point(145, 245)
        Me.Road_tokenTextBox.Multiline = True
        Me.Road_tokenTextBox.Name = "Road_tokenTextBox"
        Me.Road_tokenTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Road_tokenTextBox.TabIndex = 90
        '
        'OtherTextBox
        '
        Me.OtherTextBox.BackColor = System.Drawing.Color.Black
        Me.OtherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OtherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "other", True))
        Me.OtherTextBox.ForeColor = System.Drawing.Color.White
        Me.OtherTextBox.Location = New System.Drawing.Point(145, 275)
        Me.OtherTextBox.Multiline = True
        Me.OtherTextBox.Name = "OtherTextBox"
        Me.OtherTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OtherTextBox.TabIndex = 92
        '
        'DieselTextBox
        '
        Me.DieselTextBox.BackColor = System.Drawing.Color.Black
        Me.DieselTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DieselTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "diesel", True))
        Me.DieselTextBox.ForeColor = System.Drawing.Color.White
        Me.DieselTextBox.Location = New System.Drawing.Point(145, 306)
        Me.DieselTextBox.Multiline = True
        Me.DieselTextBox.Name = "DieselTextBox"
        Me.DieselTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DieselTextBox.TabIndex = 94
        '
        'Expensis_entryDataGridView
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        Me.Expensis_entryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Expensis_entryDataGridView.AutoGenerateColumns = False
        Me.Expensis_entryDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Expensis_entryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Expensis_entryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Expensis_entryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Expensis_entryDataGridView.DataSource = Me.Expensis_entryBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Expensis_entryDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.Expensis_entryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Expensis_entryDataGridView.Location = New System.Drawing.Point(67, 431)
        Me.Expensis_entryDataGridView.Name = "Expensis_entryDataGridView"
        Me.Expensis_entryDataGridView.Size = New System.Drawing.Size(665, 118)
        Me.Expensis_entryDataGridView.TabIndex = 94
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ex_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ex_date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ex_vehicle_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ex_vehicle_no"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "repairs"
        Me.DataGridViewTextBoxColumn4.HeaderText = "repairs"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "driver_allow"
        Me.DataGridViewTextBoxColumn5.HeaderText = "driver_allow"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "oil"
        Me.DataGridViewTextBoxColumn6.HeaderText = "oil"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "puncher"
        Me.DataGridViewTextBoxColumn7.HeaderText = "puncher"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "road_token"
        Me.DataGridViewTextBoxColumn8.HeaderText = "road_token"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "other"
        Me.DataGridViewTextBoxColumn9.HeaderText = "other"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "diesel"
        Me.DataGridViewTextBoxColumn10.HeaderText = "diesel"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.FlatMini1)
        Me.Panel1.Controls.Add(Me.FlatMax1)
        Me.Panel1.Controls.Add(Me.FlatClose1)
        Me.Panel1.Controls.Add(Button2)
        Me.Panel1.Controls.Add(Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 49)
        Me.Panel1.TabIndex = 95
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(738, 18)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 30
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(762, 19)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 29
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(789, 18)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 28
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(321, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 39)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Expenses "
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape1.Location = New System.Drawing.Point(57, 417)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(723, 148)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(817, 592)
        Me.ShapeContainer1.TabIndex = 96
        Me.ShapeContainer1.TabStop = False
        '
        'prevbtn
        '
        Me.prevbtn.BackColor = System.Drawing.Color.Transparent
        Me.prevbtn.BackgroundImage = Global.logistics_ms.My.Resources.Resources.chevron_up_round_32
        Me.prevbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.prevbtn.FlatAppearance.BorderSize = 0
        Me.prevbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.prevbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.prevbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prevbtn.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prevbtn.Location = New System.Drawing.Point(738, 431)
        Me.prevbtn.Name = "prevbtn"
        Me.prevbtn.Size = New System.Drawing.Size(32, 32)
        Me.prevbtn.TabIndex = 98
        Me.prevbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.prevbtn.UseVisualStyleBackColor = False
        '
        'nextbtn
        '
        Me.nextbtn.BackColor = System.Drawing.Color.Transparent
        Me.nextbtn.BackgroundImage = Global.logistics_ms.My.Resources.Resources.chevron_down_round_32
        Me.nextbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.nextbtn.FlatAppearance.BorderSize = 0
        Me.nextbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.nextbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextbtn.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nextbtn.Location = New System.Drawing.Point(738, 517)
        Me.nextbtn.Name = "nextbtn"
        Me.nextbtn.Size = New System.Drawing.Size(32, 32)
        Me.nextbtn.TabIndex = 97
        Me.nextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.nextbtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Ex_vehicle_noLabel)
        Me.GroupBox1.Controls.Add(Me.Ex_vehicle_noComboBox)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(Me.DieselTextBox)
        Me.GroupBox1.Controls.Add(DieselLabel)
        Me.GroupBox1.Controls.Add(Me.OtherTextBox)
        Me.GroupBox1.Controls.Add(OtherLabel)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.Road_tokenTextBox)
        Me.GroupBox1.Controls.Add(Road_tokenLabel)
        Me.GroupBox1.Controls.Add(Ex_dateLabel)
        Me.GroupBox1.Controls.Add(Me.PuncherTextBox)
        Me.GroupBox1.Controls.Add(Me.Ex_dateDateTimePicker)
        Me.GroupBox1.Controls.Add(PuncherLabel)
        Me.GroupBox1.Controls.Add(Me.OilTextBox)
        Me.GroupBox1.Controls.Add(OilLabel)
        Me.GroupBox1.Controls.Add(RepairsLabel)
        Me.GroupBox1.Controls.Add(Me.Driver_allowTextBox)
        Me.GroupBox1.Controls.Add(Me.RepairsTextBox)
        Me.GroupBox1.Controls.Add(Driver_allowLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(67, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 348)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Expenses Info"
        '
        'Ex_vehicle_noComboBox
        '
        Me.Ex_vehicle_noComboBox.BackColor = System.Drawing.Color.Black
        Me.Ex_vehicle_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Expensis_entryBindingSource, "ex_vehicle_no", True))
        Me.Ex_vehicle_noComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ex_vehicle_noComboBox.ForeColor = System.Drawing.Color.White
        Me.Ex_vehicle_noComboBox.FormattingEnabled = True
        Me.Ex_vehicle_noComboBox.Location = New System.Drawing.Point(145, 89)
        Me.Ex_vehicle_noComboBox.Name = "Ex_vehicle_noComboBox"
        Me.Ex_vehicle_noComboBox.Size = New System.Drawing.Size(200, 23)
        Me.Ex_vehicle_noComboBox.TabIndex = 95
        '
        'VehicledetailsBindingSource
        '
        Me.VehicledetailsBindingSource.DataMember = "vehicle_details"
        Me.VehicledetailsBindingSource.DataSource = Me.LogisticDataSet
        '
        'Vehicle_detailsTableAdapter
        '
        Me.Vehicle_detailsTableAdapter.ClearBeforeFill = True
        '
        'ExpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(817, 592)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.prevbtn)
        Me.Controls.Add(Me.nextbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Expensis_entryDataGridView)
        Me.Controls.Add(Button9)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(addButton)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExpForm"
        CType(Me.Expensis_entryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Expensis_entryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VehicledetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager As logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Expensis_entryTableAdapter As logistics_ms.LogisticDataSetTableAdapters.expensis_entryTableAdapter
    Friend WithEvents Expensis_entryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogisticDataSet As logistics_ms.LogisticDataSet
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents deletebtn As System.Windows.Forms.Button
    Friend WithEvents updatebtn As System.Windows.Forms.Button
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ex_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RepairsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Driver_allowTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PuncherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Road_tokenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DieselTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Expensis_entryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlatMini1 As logistics_ms.FlatMini
    Friend WithEvents FlatMax1 As logistics_ms.FlatMax
    Friend WithEvents FlatClose1 As logistics_ms.FlatClose
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents prevbtn As System.Windows.Forms.Button
    Friend WithEvents nextbtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VehicledetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vehicle_detailsTableAdapter As logistics_ms.LogisticDataSetTableAdapters.vehicle_detailsTableAdapter
    Friend WithEvents Ex_vehicle_noComboBox As System.Windows.Forms.ComboBox
End Class
