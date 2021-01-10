<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransInfoEntryfrm
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
        Dim T_idLabel As System.Windows.Forms.Label
        Dim Transport_dateLabel As System.Windows.Forms.Label
        Dim Vehicle_noLabel As System.Windows.Forms.Label
        Dim Type_materialLabel As System.Windows.Forms.Label
        Dim UnitLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Zip_codeLabel As System.Windows.Forms.Label
        Dim Phone_noLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim R_nameLabel As System.Windows.Forms.Label
        Dim R_addressLabel As System.Windows.Forms.Label
        Dim R_zip_codeLabel As System.Windows.Forms.Label
        Dim R_phone_noLabel As System.Windows.Forms.Label
        Dim R_emailLabel As System.Windows.Forms.Label
        Dim Driver_nameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim addButton As System.Windows.Forms.Button
        Dim Button2 As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Dim Button9 As System.Windows.Forms.Button
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LogisticDataSet = New logistics_ms.LogisticDataSet()
        Me.Transport_info_entryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Transport_info_entryTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.transport_info_entryTableAdapter()
        Me.TableAdapterManager = New logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager()
        Me.T_idTextBox = New System.Windows.Forms.TextBox()
        Me.Transport_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WorkerdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vehicle_noComboBox = New System.Windows.Forms.ComboBox()
        Me.VehicledetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Type_materialTextBox = New System.Windows.Forms.TextBox()
        Me.UnitTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerregBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_noTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.R_nameTextBox = New System.Windows.Forms.TextBox()
        Me.R_addressTextBox = New System.Windows.Forms.TextBox()
        Me.R_zip_codeTextBox = New System.Windows.Forms.TextBox()
        Me.R_phone_noTextBox = New System.Windows.Forms.TextBox()
        Me.R_emailTextBox = New System.Windows.Forms.TextBox()
        Me.Worker_detailsTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.worker_detailsTableAdapter()
        Me.Vehicle_detailsTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.vehicle_detailsTableAdapter()
        Me.Customer_regTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.customer_regTableAdapter()
        Me.Driver_nameComboBox = New System.Windows.Forms.ComboBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.prevbtn = New System.Windows.Forms.Button()
        Me.nextbtn = New System.Windows.Forms.Button()
        Me.Transport_info_entryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        T_idLabel = New System.Windows.Forms.Label()
        Transport_dateLabel = New System.Windows.Forms.Label()
        Vehicle_noLabel = New System.Windows.Forms.Label()
        Type_materialLabel = New System.Windows.Forms.Label()
        UnitLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Zip_codeLabel = New System.Windows.Forms.Label()
        Phone_noLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        R_nameLabel = New System.Windows.Forms.Label()
        R_addressLabel = New System.Windows.Forms.Label()
        R_zip_codeLabel = New System.Windows.Forms.Label()
        R_phone_noLabel = New System.Windows.Forms.Label()
        R_emailLabel = New System.Windows.Forms.Label()
        Driver_nameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        addButton = New System.Windows.Forms.Button()
        Button2 = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        Button9 = New System.Windows.Forms.Button()
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transport_info_entryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkerdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerregBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Transport_info_entryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T_idLabel
        '
        T_idLabel.AutoSize = True
        T_idLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        T_idLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        T_idLabel.Location = New System.Drawing.Point(11, 55)
        T_idLabel.Name = "T_idLabel"
        T_idLabel.Size = New System.Drawing.Size(98, 15)
        T_idLabel.TabIndex = 1
        T_idLabel.Text = "Transport ID:"
        '
        'Transport_dateLabel
        '
        Transport_dateLabel.AutoSize = True
        Transport_dateLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Transport_dateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Transport_dateLabel.Location = New System.Drawing.Point(291, 85)
        Transport_dateLabel.Name = "Transport_dateLabel"
        Transport_dateLabel.Size = New System.Drawing.Size(115, 15)
        Transport_dateLabel.TabIndex = 9
        Transport_dateLabel.Text = "Transport Date:"
        '
        'Vehicle_noLabel
        '
        Vehicle_noLabel.AutoSize = True
        Vehicle_noLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vehicle_noLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Vehicle_noLabel.Location = New System.Drawing.Point(291, 146)
        Vehicle_noLabel.Name = "Vehicle_noLabel"
        Vehicle_noLabel.Size = New System.Drawing.Size(84, 15)
        Vehicle_noLabel.TabIndex = 15
        Vehicle_noLabel.Text = "Vehicle No:"
        '
        'Type_materialLabel
        '
        Type_materialLabel.AutoSize = True
        Type_materialLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Type_materialLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Type_materialLabel.Location = New System.Drawing.Point(291, 178)
        Type_materialLabel.Name = "Type_materialLabel"
        Type_materialLabel.Size = New System.Drawing.Size(104, 15)
        Type_materialLabel.TabIndex = 17
        Type_materialLabel.Text = "Material Type:"
        '
        'UnitLabel
        '
        UnitLabel.AutoSize = True
        UnitLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        UnitLabel.Location = New System.Drawing.Point(291, 212)
        UnitLabel.Name = "UnitLabel"
        UnitLabel.Size = New System.Drawing.Size(39, 15)
        UnitLabel.TabIndex = 19
        UnitLabel.Text = "Unit:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        AmountLabel.Location = New System.Drawing.Point(291, 243)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(65, 15)
        AmountLabel.TabIndex = 21
        AmountLabel.Text = "Amount:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(14, 55)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(69, 15)
        AddressLabel.TabIndex = 25
        AddressLabel.Text = "Address:"
        '
        'Zip_codeLabel
        '
        Zip_codeLabel.AutoSize = True
        Zip_codeLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Zip_codeLabel.Location = New System.Drawing.Point(13, 102)
        Zip_codeLabel.Name = "Zip_codeLabel"
        Zip_codeLabel.Size = New System.Drawing.Size(72, 15)
        Zip_codeLabel.TabIndex = 27
        Zip_codeLabel.Text = "Zip-Code:"
        '
        'Phone_noLabel
        '
        Phone_noLabel.AutoSize = True
        Phone_noLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_noLabel.Location = New System.Drawing.Point(14, 131)
        Phone_noLabel.Name = "Phone_noLabel"
        Phone_noLabel.Size = New System.Drawing.Size(75, 15)
        Phone_noLabel.TabIndex = 29
        Phone_noLabel.Text = "Phone No:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(13, 162)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(50, 15)
        EmailLabel.TabIndex = 31
        EmailLabel.Text = "E-mail:"
        '
        'R_nameLabel
        '
        R_nameLabel.AutoSize = True
        R_nameLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        R_nameLabel.Location = New System.Drawing.Point(9, 22)
        R_nameLabel.Name = "R_nameLabel"
        R_nameLabel.Size = New System.Drawing.Size(47, 15)
        R_nameLabel.TabIndex = 33
        R_nameLabel.Text = "Name:"
        '
        'R_addressLabel
        '
        R_addressLabel.AutoSize = True
        R_addressLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        R_addressLabel.Location = New System.Drawing.Point(9, 48)
        R_addressLabel.Name = "R_addressLabel"
        R_addressLabel.Size = New System.Drawing.Size(69, 15)
        R_addressLabel.TabIndex = 35
        R_addressLabel.Text = "Address:"
        '
        'R_zip_codeLabel
        '
        R_zip_codeLabel.AutoSize = True
        R_zip_codeLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        R_zip_codeLabel.Location = New System.Drawing.Point(9, 104)
        R_zip_codeLabel.Name = "R_zip_codeLabel"
        R_zip_codeLabel.Size = New System.Drawing.Size(72, 15)
        R_zip_codeLabel.TabIndex = 37
        R_zip_codeLabel.Text = "Zip-Code:"
        '
        'R_phone_noLabel
        '
        R_phone_noLabel.AutoSize = True
        R_phone_noLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        R_phone_noLabel.Location = New System.Drawing.Point(9, 137)
        R_phone_noLabel.Name = "R_phone_noLabel"
        R_phone_noLabel.Size = New System.Drawing.Size(75, 15)
        R_phone_noLabel.TabIndex = 39
        R_phone_noLabel.Text = "Phone No:"
        '
        'R_emailLabel
        '
        R_emailLabel.AutoSize = True
        R_emailLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        R_emailLabel.Location = New System.Drawing.Point(9, 160)
        R_emailLabel.Name = "R_emailLabel"
        R_emailLabel.Size = New System.Drawing.Size(50, 15)
        R_emailLabel.TabIndex = 41
        R_emailLabel.Text = "E-mail:"
        '
        'Driver_nameLabel
        '
        Driver_nameLabel.AutoSize = True
        Driver_nameLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Driver_nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Driver_nameLabel.Location = New System.Drawing.Point(291, 113)
        Driver_nameLabel.Name = "Driver_nameLabel"
        Driver_nameLabel.Size = New System.Drawing.Size(94, 15)
        Driver_nameLabel.TabIndex = 43
        Driver_nameLabel.Text = "Driver Name:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(13, 22)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(47, 15)
        NameLabel.TabIndex = 44
        NameLabel.Text = "Name:"
        '
        'addButton
        '
        addButton.BackColor = System.Drawing.Color.MediumSeaGreen
        addButton.FlatAppearance.BorderSize = 0
        addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        addButton.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        addButton.Location = New System.Drawing.Point(798, 71)
        addButton.Name = "addButton"
        addButton.Size = New System.Drawing.Size(75, 33)
        addButton.TabIndex = 46
        addButton.Text = "Add"
        addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        addButton.UseVisualStyleBackColor = False
        AddHandler addButton.Click, AddressOf Me.addButton_Click
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
        'Button9
        '
        Button9.BackColor = System.Drawing.Color.MediumSeaGreen
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button9.Location = New System.Drawing.Point(798, 275)
        Button9.Name = "Button9"
        Button9.Size = New System.Drawing.Size(75, 34)
        Button9.TabIndex = 57
        Button9.Text = "Back"
        Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button9.UseVisualStyleBackColor = False
        AddHandler Button9.Click, AddressOf Me.Button9_Click
        '
        'LogisticDataSet
        '
        Me.LogisticDataSet.DataSetName = "LogisticDataSet"
        Me.LogisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Transport_info_entryBindingSource
        '
        Me.Transport_info_entryBindingSource.DataMember = "transport_info_entry"
        Me.Transport_info_entryBindingSource.DataSource = Me.LogisticDataSet
        '
        'Transport_info_entryTableAdapter
        '
        Me.Transport_info_entryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customer_regTableAdapter = Nothing
        Me.TableAdapterManager.expensis_entryTableAdapter = Nothing
        Me.TableAdapterManager.transport_info_entryTableAdapter = Me.Transport_info_entryTableAdapter
        Me.TableAdapterManager.UpdateOrder = logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vehicle_detailsTableAdapter = Nothing
        Me.TableAdapterManager.worker_detailsTableAdapter = Nothing
        '
        'T_idTextBox
        '
        Me.T_idTextBox.BackColor = System.Drawing.Color.Black
        Me.T_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "t_id", True))
        Me.T_idTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.T_idTextBox.ForeColor = System.Drawing.Color.White
        Me.T_idTextBox.Location = New System.Drawing.Point(136, 55)
        Me.T_idTextBox.Multiline = True
        Me.T_idTextBox.Name = "T_idTextBox"
        Me.T_idTextBox.Size = New System.Drawing.Size(86, 21)
        Me.T_idTextBox.TabIndex = 2
        '
        'Transport_dateDateTimePicker
        '
        Me.Transport_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Transport_info_entryBindingSource, "transport_date", True))
        Me.Transport_dateDateTimePicker.Location = New System.Drawing.Point(409, 84)
        Me.Transport_dateDateTimePicker.Name = "Transport_dateDateTimePicker"
        Me.Transport_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Transport_dateDateTimePicker.TabIndex = 10
        '
        'WorkerdetailsBindingSource
        '
        Me.WorkerdetailsBindingSource.DataMember = "worker_details"
        Me.WorkerdetailsBindingSource.DataSource = Me.LogisticDataSet
        '
        'Vehicle_noComboBox
        '
        Me.Vehicle_noComboBox.BackColor = System.Drawing.Color.Black
        Me.Vehicle_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "vehicle_no", True))
        Me.Vehicle_noComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VehicledetailsBindingSource, "vehicle_no", True))
        Me.Vehicle_noComboBox.DataSource = Me.VehicledetailsBindingSource
        Me.Vehicle_noComboBox.DisplayMember = "vehicle_no"
        Me.Vehicle_noComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Vehicle_noComboBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Vehicle_noComboBox.ForeColor = System.Drawing.Color.White
        Me.Vehicle_noComboBox.FormattingEnabled = True
        Me.Vehicle_noComboBox.Location = New System.Drawing.Point(409, 146)
        Me.Vehicle_noComboBox.Name = "Vehicle_noComboBox"
        Me.Vehicle_noComboBox.Size = New System.Drawing.Size(200, 25)
        Me.Vehicle_noComboBox.TabIndex = 16
        Me.Vehicle_noComboBox.ValueMember = "vehicle_no"
        '
        'VehicledetailsBindingSource
        '
        Me.VehicledetailsBindingSource.DataMember = "vehicle_details"
        Me.VehicledetailsBindingSource.DataSource = Me.LogisticDataSet
        '
        'Type_materialTextBox
        '
        Me.Type_materialTextBox.BackColor = System.Drawing.Color.Black
        Me.Type_materialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Type_materialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "type_material", True))
        Me.Type_materialTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Type_materialTextBox.ForeColor = System.Drawing.Color.White
        Me.Type_materialTextBox.Location = New System.Drawing.Point(409, 178)
        Me.Type_materialTextBox.Multiline = True
        Me.Type_materialTextBox.Name = "Type_materialTextBox"
        Me.Type_materialTextBox.Size = New System.Drawing.Size(200, 31)
        Me.Type_materialTextBox.TabIndex = 18
        '
        'UnitTextBox
        '
        Me.UnitTextBox.BackColor = System.Drawing.Color.Black
        Me.UnitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "unit", True))
        Me.UnitTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.UnitTextBox.ForeColor = System.Drawing.Color.White
        Me.UnitTextBox.Location = New System.Drawing.Point(409, 215)
        Me.UnitTextBox.Multiline = True
        Me.UnitTextBox.Name = "UnitTextBox"
        Me.UnitTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UnitTextBox.TabIndex = 20
        '
        'AmountTextBox
        '
        Me.AmountTextBox.BackColor = System.Drawing.Color.Black
        Me.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.AmountTextBox.ForeColor = System.Drawing.Color.White
        Me.AmountTextBox.Location = New System.Drawing.Point(409, 243)
        Me.AmountTextBox.Multiline = True
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox.TabIndex = 22
        '
        'CustomerregBindingSource
        '
        Me.CustomerregBindingSource.DataMember = "customer_reg"
        Me.CustomerregBindingSource.DataSource = Me.LogisticDataSet
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.Black
        Me.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.AddressTextBox.ForeColor = System.Drawing.Color.White
        Me.AddressTextBox.Location = New System.Drawing.Point(98, 55)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 48)
        Me.AddressTextBox.TabIndex = 26
        '
        'Zip_codeTextBox
        '
        Me.Zip_codeTextBox.BackColor = System.Drawing.Color.Black
        Me.Zip_codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Zip_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "zip_code", True))
        Me.Zip_codeTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Zip_codeTextBox.ForeColor = System.Drawing.Color.White
        Me.Zip_codeTextBox.Location = New System.Drawing.Point(98, 109)
        Me.Zip_codeTextBox.Multiline = True
        Me.Zip_codeTextBox.Name = "Zip_codeTextBox"
        Me.Zip_codeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Zip_codeTextBox.TabIndex = 28
        '
        'Phone_noTextBox
        '
        Me.Phone_noTextBox.BackColor = System.Drawing.Color.Black
        Me.Phone_noTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Phone_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "phone_no", True))
        Me.Phone_noTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Phone_noTextBox.ForeColor = System.Drawing.Color.White
        Me.Phone_noTextBox.Location = New System.Drawing.Point(98, 139)
        Me.Phone_noTextBox.Multiline = True
        Me.Phone_noTextBox.Name = "Phone_noTextBox"
        Me.Phone_noTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Phone_noTextBox.TabIndex = 30
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.Black
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.EmailTextBox.ForeColor = System.Drawing.Color.White
        Me.EmailTextBox.Location = New System.Drawing.Point(98, 168)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 32
        '
        'R_nameTextBox
        '
        Me.R_nameTextBox.BackColor = System.Drawing.Color.Black
        Me.R_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.R_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "r_name", True))
        Me.R_nameTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.R_nameTextBox.ForeColor = System.Drawing.Color.White
        Me.R_nameTextBox.Location = New System.Drawing.Point(90, 19)
        Me.R_nameTextBox.Multiline = True
        Me.R_nameTextBox.Name = "R_nameTextBox"
        Me.R_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.R_nameTextBox.TabIndex = 34
        '
        'R_addressTextBox
        '
        Me.R_addressTextBox.BackColor = System.Drawing.Color.Black
        Me.R_addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.R_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "r_address", True))
        Me.R_addressTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.R_addressTextBox.ForeColor = System.Drawing.Color.White
        Me.R_addressTextBox.Location = New System.Drawing.Point(90, 45)
        Me.R_addressTextBox.Multiline = True
        Me.R_addressTextBox.Name = "R_addressTextBox"
        Me.R_addressTextBox.Size = New System.Drawing.Size(200, 56)
        Me.R_addressTextBox.TabIndex = 36
        '
        'R_zip_codeTextBox
        '
        Me.R_zip_codeTextBox.BackColor = System.Drawing.Color.Black
        Me.R_zip_codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.R_zip_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "r_zip_code", True))
        Me.R_zip_codeTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.R_zip_codeTextBox.ForeColor = System.Drawing.Color.White
        Me.R_zip_codeTextBox.Location = New System.Drawing.Point(90, 108)
        Me.R_zip_codeTextBox.Multiline = True
        Me.R_zip_codeTextBox.Name = "R_zip_codeTextBox"
        Me.R_zip_codeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.R_zip_codeTextBox.TabIndex = 38
        '
        'R_phone_noTextBox
        '
        Me.R_phone_noTextBox.BackColor = System.Drawing.Color.Black
        Me.R_phone_noTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.R_phone_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "r_phone_no", True))
        Me.R_phone_noTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.R_phone_noTextBox.ForeColor = System.Drawing.Color.White
        Me.R_phone_noTextBox.Location = New System.Drawing.Point(90, 134)
        Me.R_phone_noTextBox.Multiline = True
        Me.R_phone_noTextBox.Name = "R_phone_noTextBox"
        Me.R_phone_noTextBox.Size = New System.Drawing.Size(200, 20)
        Me.R_phone_noTextBox.TabIndex = 40
        '
        'R_emailTextBox
        '
        Me.R_emailTextBox.BackColor = System.Drawing.Color.Black
        Me.R_emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.R_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "r_email", True))
        Me.R_emailTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.R_emailTextBox.ForeColor = System.Drawing.Color.White
        Me.R_emailTextBox.Location = New System.Drawing.Point(90, 166)
        Me.R_emailTextBox.Multiline = True
        Me.R_emailTextBox.Name = "R_emailTextBox"
        Me.R_emailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.R_emailTextBox.TabIndex = 42
        '
        'Worker_detailsTableAdapter
        '
        Me.Worker_detailsTableAdapter.ClearBeforeFill = True
        '
        'Vehicle_detailsTableAdapter
        '
        Me.Vehicle_detailsTableAdapter.ClearBeforeFill = True
        '
        'Customer_regTableAdapter
        '
        Me.Customer_regTableAdapter.ClearBeforeFill = True
        '
        'Driver_nameComboBox
        '
        Me.Driver_nameComboBox.BackColor = System.Drawing.Color.Black
        Me.Driver_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "driver_name", True))
        Me.Driver_nameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Driver_nameComboBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Driver_nameComboBox.ForeColor = System.Drawing.Color.White
        Me.Driver_nameComboBox.FormattingEnabled = True
        Me.Driver_nameComboBox.Location = New System.Drawing.Point(409, 113)
        Me.Driver_nameComboBox.Name = "Driver_nameComboBox"
        Me.Driver_nameComboBox.Size = New System.Drawing.Size(200, 25)
        Me.Driver_nameComboBox.TabIndex = 44
        '
        'NameComboBox
        '
        Me.NameComboBox.BackColor = System.Drawing.Color.Black
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transport_info_entryBindingSource, "name", True))
        Me.NameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NameComboBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.NameComboBox.ForeColor = System.Drawing.Color.White
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(98, 24)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(200, 25)
        Me.NameComboBox.TabIndex = 45
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.clearbtn.FlatAppearance.BorderSize = 0
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearbtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clearbtn.Location = New System.Drawing.Point(798, 227)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(75, 33)
        Me.clearbtn.TabIndex = 50
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
        Me.deletebtn.Location = New System.Drawing.Point(798, 188)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 33)
        Me.deletebtn.TabIndex = 49
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
        Me.updatebtn.Location = New System.Drawing.Point(798, 149)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(75, 33)
        Me.updatebtn.TabIndex = 48
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
        Me.savebtn.Location = New System.Drawing.Point(798, 110)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(75, 33)
        Me.savebtn.TabIndex = 47
        Me.savebtn.Text = "Save"
        Me.savebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(311, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 39)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "TRANSPORT INFO ENTERY"
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.Color.Crimson
        Me.exitbtn.FlatAppearance.BorderSize = 0
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exitbtn.Location = New System.Drawing.Point(845, 9)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(28, 24)
        Me.exitbtn.TabIndex = 19
        Me.exitbtn.Text = "X"
        Me.exitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Button2)
        Me.Panel1.Controls.Add(Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.exitbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 49)
        Me.Panel1.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NameComboBox)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.Phone_noTextBox)
        Me.GroupBox1.Controls.Add(Phone_noLabel)
        Me.GroupBox1.Controls.Add(Me.Zip_codeTextBox)
        Me.GroupBox1.Controls.Add(Zip_codeLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(58, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 211)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Senders Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.R_nameTextBox)
        Me.GroupBox2.Controls.Add(Me.R_emailTextBox)
        Me.GroupBox2.Controls.Add(R_emailLabel)
        Me.GroupBox2.Controls.Add(Me.R_phone_noTextBox)
        Me.GroupBox2.Controls.Add(R_phone_noLabel)
        Me.GroupBox2.Controls.Add(Me.R_zip_codeTextBox)
        Me.GroupBox2.Controls.Add(R_zip_codeLabel)
        Me.GroupBox2.Controls.Add(Me.R_addressTextBox)
        Me.GroupBox2.Controls.Add(R_addressLabel)
        Me.GroupBox2.Controls.Add(R_nameLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(467, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 211)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receivers Info"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape1.Location = New System.Drawing.Point(276, 73)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(359, 204)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(919, 772)
        Me.ShapeContainer1.TabIndex = 54
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape2.Location = New System.Drawing.Point(9, 557)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(861, 146)
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
        Me.prevbtn.Location = New System.Drawing.Point(826, 571)
        Me.prevbtn.Name = "prevbtn"
        Me.prevbtn.Size = New System.Drawing.Size(32, 32)
        Me.prevbtn.TabIndex = 56
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
        Me.nextbtn.Location = New System.Drawing.Point(826, 655)
        Me.nextbtn.Name = "nextbtn"
        Me.nextbtn.Size = New System.Drawing.Size(32, 32)
        Me.nextbtn.TabIndex = 55
        Me.nextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.nextbtn.UseVisualStyleBackColor = False
        '
        'Transport_info_entryDataGridView
        '
        Me.Transport_info_entryDataGridView.AutoGenerateColumns = False
        Me.Transport_info_entryDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Transport_info_entryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Transport_info_entryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Transport_info_entryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.Transport_info_entryDataGridView.DataSource = Me.Transport_info_entryBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Transport_info_entryDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.Transport_info_entryDataGridView.Location = New System.Drawing.Point(49, 568)
        Me.Transport_info_entryDataGridView.Name = "Transport_info_entryDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Transport_info_entryDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        Me.Transport_info_entryDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Transport_info_entryDataGridView.Size = New System.Drawing.Size(771, 119)
        Me.Transport_info_entryDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "t_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "t_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "transport_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "transport_date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "driver_name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "driver_name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "vehicle_no"
        Me.DataGridViewTextBoxColumn8.HeaderText = "vehicle_no"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "type_material"
        Me.DataGridViewTextBoxColumn9.HeaderText = "type_material"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "unit"
        Me.DataGridViewTextBoxColumn10.HeaderText = "unit"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn12.HeaderText = "name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn13.HeaderText = "address"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "zip_code"
        Me.DataGridViewTextBoxColumn14.HeaderText = "zip_code"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "phone_no"
        Me.DataGridViewTextBoxColumn15.HeaderText = "phone_no"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn16.HeaderText = "email"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "r_name"
        Me.DataGridViewTextBoxColumn17.HeaderText = "r_name"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "r_address"
        Me.DataGridViewTextBoxColumn18.HeaderText = "r_address"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "r_zip_code"
        Me.DataGridViewTextBoxColumn19.HeaderText = "r_zip_code"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "r_phone_no"
        Me.DataGridViewTextBoxColumn20.HeaderText = "r_phone_no"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "r_email"
        Me.DataGridViewTextBoxColumn21.HeaderText = "r_email"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'TransInfoEntryfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(919, 772)
        Me.Controls.Add(Me.Transport_info_entryDataGridView)
        Me.Controls.Add(Button9)
        Me.Controls.Add(Me.prevbtn)
        Me.Controls.Add(Me.nextbtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(addButton)
        Me.Controls.Add(Driver_nameLabel)
        Me.Controls.Add(Me.Driver_nameComboBox)
        Me.Controls.Add(T_idLabel)
        Me.Controls.Add(Me.T_idTextBox)
        Me.Controls.Add(Transport_dateLabel)
        Me.Controls.Add(Me.Transport_dateDateTimePicker)
        Me.Controls.Add(Vehicle_noLabel)
        Me.Controls.Add(Me.Vehicle_noComboBox)
        Me.Controls.Add(Type_materialLabel)
        Me.Controls.Add(Me.Type_materialTextBox)
        Me.Controls.Add(UnitLabel)
        Me.Controls.Add(Me.UnitTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransInfoEntryfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransInfoEntryfrm"
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transport_info_entryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkerdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerregBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Transport_info_entryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogisticDataSet As logistics_ms.LogisticDataSet
    Friend WithEvents Transport_info_entryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Transport_info_entryTableAdapter As logistics_ms.LogisticDataSetTableAdapters.transport_info_entryTableAdapter
    Friend WithEvents TableAdapterManager As logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Transport_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Vehicle_noComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Type_materialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zip_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_zip_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_phone_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkerdetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Worker_detailsTableAdapter As logistics_ms.LogisticDataSetTableAdapters.worker_detailsTableAdapter
    Friend WithEvents VehicledetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vehicle_detailsTableAdapter As logistics_ms.LogisticDataSetTableAdapters.vehicle_detailsTableAdapter
    Friend WithEvents CustomerregBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_regTableAdapter As logistics_ms.LogisticDataSetTableAdapters.customer_regTableAdapter
    Friend WithEvents Driver_nameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents deletebtn As System.Windows.Forms.Button
    Friend WithEvents updatebtn As System.Windows.Forms.Button
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitbtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents prevbtn As System.Windows.Forms.Button
    Friend WithEvents nextbtn As System.Windows.Forms.Button
    Friend WithEvents Transport_info_entryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
