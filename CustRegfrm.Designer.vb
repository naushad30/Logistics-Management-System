<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustRegfrm
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
        Dim C_idLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Zip_codeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim addButton As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Dim Button2 As System.Windows.Forms.Button
        Dim Button9 As System.Windows.Forms.Button
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LogisticDataSet = New logistics_ms.LogisticDataSet()
        Me.Customer_regBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_regTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.customer_regTableAdapter()
        Me.TableAdapterManager = New logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager()
        Me.C_idTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_codeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.nextbtn = New System.Windows.Forms.Button()
        Me.prevbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatMini1 = New logistics_ms.FlatMini()
        Me.FlatMax1 = New logistics_ms.FlatMax()
        Me.FlatClose1 = New logistics_ms.FlatClose()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Customer_regDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        C_idLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Zip_codeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        addButton = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        Button2 = New System.Windows.Forms.Button()
        Button9 = New System.Windows.Forms.Button()
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_regBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Customer_regDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C_idLabel
        '
        C_idLabel.AutoSize = True
        C_idLabel.BackColor = System.Drawing.Color.Transparent
        C_idLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_idLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        C_idLabel.Location = New System.Drawing.Point(51, 36)
        C_idLabel.Name = "C_idLabel"
        C_idLabel.Size = New System.Drawing.Size(96, 15)
        C_idLabel.TabIndex = 1
        C_idLabel.Text = "Customer ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Transparent
        NameLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NameLabel.Location = New System.Drawing.Point(51, 66)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(47, 15)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Transparent
        AddressLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        AddressLabel.Location = New System.Drawing.Point(51, 94)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(69, 15)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.Transparent
        PhoneLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PhoneLabel.Location = New System.Drawing.Point(51, 133)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(75, 15)
        PhoneLabel.TabIndex = 7
        PhoneLabel.Text = "Phone No:"
        AddHandler PhoneLabel.Click, AddressOf Me.PhoneLabel_Click
        '
        'Zip_codeLabel
        '
        Zip_codeLabel.AutoSize = True
        Zip_codeLabel.BackColor = System.Drawing.Color.Transparent
        Zip_codeLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Zip_codeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Zip_codeLabel.Location = New System.Drawing.Point(51, 161)
        Zip_codeLabel.Name = "Zip_codeLabel"
        Zip_codeLabel.Size = New System.Drawing.Size(72, 15)
        Zip_codeLabel.TabIndex = 9
        Zip_codeLabel.Text = "Zip Code:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        EmailLabel.Location = New System.Drawing.Point(51, 186)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(50, 15)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "E-mail:"
        '
        'addButton
        '
        addButton.BackColor = System.Drawing.Color.MediumSeaGreen
        addButton.FlatAppearance.BorderSize = 0
        addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        addButton.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        addButton.Location = New System.Drawing.Point(481, 74)
        addButton.Name = "addButton"
        addButton.Size = New System.Drawing.Size(75, 33)
        addButton.TabIndex = 14
        addButton.Text = "Add"
        addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        addButton.UseVisualStyleBackColor = False
        AddHandler addButton.Click, AddressOf Me.addButton_Click
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
        'Button9
        '
        Button9.BackColor = System.Drawing.Color.MediumSeaGreen
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button9.Location = New System.Drawing.Point(594, 229)
        Button9.Name = "Button9"
        Button9.Size = New System.Drawing.Size(75, 34)
        Button9.TabIndex = 40
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
        'Customer_regBindingSource
        '
        Me.Customer_regBindingSource.DataMember = "customer_reg"
        Me.Customer_regBindingSource.DataSource = Me.LogisticDataSet
        '
        'Customer_regTableAdapter
        '
        Me.Customer_regTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customer_regTableAdapter = Me.Customer_regTableAdapter
        Me.TableAdapterManager.expensis_entryTableAdapter = Nothing
        Me.TableAdapterManager.transport_info_entryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vehicle_detailsTableAdapter = Nothing
        Me.TableAdapterManager.worker_detailsTableAdapter = Nothing
        '
        'C_idTextBox
        '
        Me.C_idTextBox.BackColor = System.Drawing.Color.Black
        Me.C_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_regBindingSource, "c_id", True))
        Me.C_idTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_idTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.C_idTextBox.Location = New System.Drawing.Point(172, 36)
        Me.C_idTextBox.Multiline = True
        Me.C_idTextBox.Name = "C_idTextBox"
        Me.C_idTextBox.Size = New System.Drawing.Size(180, 22)
        Me.C_idTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.Black
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_regBindingSource, "name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.NameTextBox.Location = New System.Drawing.Point(172, 64)
        Me.NameTextBox.Multiline = True
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(180, 22)
        Me.NameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.Black
        Me.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_regBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.AddressTextBox.Location = New System.Drawing.Point(172, 92)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(180, 33)
        Me.AddressTextBox.TabIndex = 6
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.BackColor = System.Drawing.Color.Black
        Me.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_regBindingSource, "phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.PhoneTextBox.Location = New System.Drawing.Point(172, 131)
        Me.PhoneTextBox.Multiline = True
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(180, 22)
        Me.PhoneTextBox.TabIndex = 8
        '
        'Zip_codeTextBox
        '
        Me.Zip_codeTextBox.BackColor = System.Drawing.Color.Black
        Me.Zip_codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Zip_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_regBindingSource, "zip_code", True))
        Me.Zip_codeTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zip_codeTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Zip_codeTextBox.Location = New System.Drawing.Point(172, 159)
        Me.Zip_codeTextBox.Multiline = True
        Me.Zip_codeTextBox.Name = "Zip_codeTextBox"
        Me.Zip_codeTextBox.Size = New System.Drawing.Size(180, 22)
        Me.Zip_codeTextBox.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.Black
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_regBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.EmailTextBox.Location = New System.Drawing.Point(172, 187)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(180, 22)
        Me.EmailTextBox.TabIndex = 12
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.savebtn.FlatAppearance.BorderSize = 0
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.savebtn.Location = New System.Drawing.Point(481, 113)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(75, 33)
        Me.savebtn.TabIndex = 15
        Me.savebtn.Text = "Save"
        Me.savebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.updatebtn.FlatAppearance.BorderSize = 0
        Me.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatebtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updatebtn.Location = New System.Drawing.Point(481, 152)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(75, 33)
        Me.updatebtn.TabIndex = 16
        Me.updatebtn.Text = "Update"
        Me.updatebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.deletebtn.FlatAppearance.BorderSize = 0
        Me.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletebtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deletebtn.Location = New System.Drawing.Point(481, 191)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 33)
        Me.deletebtn.TabIndex = 17
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.clearbtn.FlatAppearance.BorderSize = 0
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearbtn.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clearbtn.Location = New System.Drawing.Point(481, 230)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(75, 33)
        Me.clearbtn.TabIndex = 18
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.clearbtn.UseVisualStyleBackColor = False
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
        Me.nextbtn.Location = New System.Drawing.Point(634, 442)
        Me.nextbtn.Name = "nextbtn"
        Me.nextbtn.Size = New System.Drawing.Size(32, 32)
        Me.nextbtn.TabIndex = 21
        Me.nextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.nextbtn.UseVisualStyleBackColor = False
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
        Me.prevbtn.Location = New System.Drawing.Point(634, 314)
        Me.prevbtn.Name = "prevbtn"
        Me.prevbtn.Size = New System.Drawing.Size(32, 32)
        Me.prevbtn.TabIndex = 22
        Me.prevbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.prevbtn.UseVisualStyleBackColor = False
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
        Me.Panel1.Size = New System.Drawing.Size(706, 49)
        Me.Panel1.TabIndex = 24
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(627, 18)
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
        Me.FlatMax1.Location = New System.Drawing.Point(651, 19)
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
        Me.FlatClose1.Location = New System.Drawing.Point(678, 18)
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
        Me.Label1.Location = New System.Drawing.Point(205, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 39)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CUSTOMER REGISTRATION"
        '
        'Customer_regDataGridView
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_regDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Customer_regDataGridView.AutoGenerateColumns = False
        Me.Customer_regDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Customer_regDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Customer_regDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_regDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Customer_regDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_regDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Customer_regDataGridView.DataSource = Me.Customer_regBindingSource
        Me.Customer_regDataGridView.Location = New System.Drawing.Point(44, 314)
        Me.Customer_regDataGridView.Name = "Customer_regDataGridView"
        Me.Customer_regDataGridView.Size = New System.Drawing.Size(584, 160)
        Me.Customer_regDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "c_id"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "C_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "phone"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "zip_code"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!)
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Zip_code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn6.HeaderText = "E-mail"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(C_idLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.Zip_codeTextBox)
        Me.GroupBox1.Controls.Add(Zip_codeLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(PhoneLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.C_idTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(17, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 232)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Info"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(706, 511)
        Me.ShapeContainer1.TabIndex = 26
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape1.Location = New System.Drawing.Point(17, 299)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(677, 191)
        '
        'CustRegfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(706, 511)
        Me.Controls.Add(Button9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Customer_regDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.prevbtn)
        Me.Controls.Add(Me.nextbtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(addButton)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustRegfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Registration"
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_regBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Customer_regDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogisticDataSet As logistics_ms.LogisticDataSet
    Friend WithEvents Customer_regBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_regTableAdapter As logistics_ms.LogisticDataSetTableAdapters.customer_regTableAdapter
    Friend WithEvents TableAdapterManager As logistics_ms.LogisticDataSetTableAdapters.TableAdapterManager
    Friend WithEvents C_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zip_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents updatebtn As System.Windows.Forms.Button
    Friend WithEvents deletebtn As System.Windows.Forms.Button
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents nextbtn As System.Windows.Forms.Button
    Friend WithEvents prevbtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Customer_regDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlatMini1 As logistics_ms.FlatMini
    Friend WithEvents FlatMax1 As logistics_ms.FlatMax
    Friend WithEvents FlatClose1 As logistics_ms.FlatClose

End Class
