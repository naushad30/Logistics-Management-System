<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFrm
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
        Dim Button2 As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Dim Button7 As System.Windows.Forms.Button
        Dim Button6 As System.Windows.Forms.Button
        Dim Button5 As System.Windows.Forms.Button
        Dim Button4 As System.Windows.Forms.Button
        Dim Button3 As System.Windows.Forms.Button
        Dim Button9 As System.Windows.Forms.Button
        Me.FlatMini1 = New logistics_ms.FlatMini()
        Me.FlatMax1 = New logistics_ms.FlatMax()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatClose1 = New logistics_ms.FlatClose()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.exitbtn = New System.Windows.Forms.Button()
        Button2 = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        Button7 = New System.Windows.Forms.Button()
        Button6 = New System.Windows.Forms.Button()
        Button5 = New System.Windows.Forms.Button()
        Button4 = New System.Windows.Forms.Button()
        Button3 = New System.Windows.Forms.Button()
        Button9 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Button7
        '
        Button7.BackColor = System.Drawing.Color.MediumSeaGreen
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button7.Location = New System.Drawing.Point(205, 239)
        Button7.Name = "Button7"
        Button7.Size = New System.Drawing.Size(128, 96)
        Button7.TabIndex = 42
        Button7.Text = "Worker Details"
        Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button7.UseVisualStyleBackColor = False
        AddHandler Button7.Click, AddressOf Me.Button7_Click
        '
        'Button6
        '
        Button6.BackColor = System.Drawing.Color.MediumSeaGreen
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button6.Location = New System.Drawing.Point(45, 239)
        Button6.Name = "Button6"
        Button6.Size = New System.Drawing.Size(128, 96)
        Button6.TabIndex = 41
        Button6.Text = "Vehicle Details"
        Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button6.UseVisualStyleBackColor = False
        AddHandler Button6.Click, AddressOf Me.Button6_Click
        '
        'Button5
        '
        Button5.BackColor = System.Drawing.Color.MediumSeaGreen
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button5.Location = New System.Drawing.Point(375, 99)
        Button5.Name = "Button5"
        Button5.Size = New System.Drawing.Size(128, 96)
        Button5.TabIndex = 40
        Button5.Text = "Expensis Entry"
        Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button5.UseVisualStyleBackColor = False
        AddHandler Button5.Click, AddressOf Me.Button5_Click
        '
        'Button4
        '
        Button4.BackColor = System.Drawing.Color.MediumSeaGreen
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button4.Location = New System.Drawing.Point(205, 99)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(128, 96)
        Button4.TabIndex = 39
        Button4.Text = "Transport Info Entry"
        Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button4.UseVisualStyleBackColor = False
        AddHandler Button4.Click, AddressOf Me.Button4_Click
        '
        'Button3
        '
        Button3.BackColor = System.Drawing.Color.MediumSeaGreen
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button3.Location = New System.Drawing.Point(45, 99)
        Button3.Name = "Button3"
        Button3.Size = New System.Drawing.Size(128, 96)
        Button3.TabIndex = 38
        Button3.Text = "Customer Details"
        Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = False
        AddHandler Button3.Click, AddressOf Me.Button3_Click
        '
        'Button9
        '
        Button9.BackColor = System.Drawing.Color.MediumSeaGreen
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button9.Location = New System.Drawing.Point(428, 287)
        Button9.Name = "Button9"
        Button9.Size = New System.Drawing.Size(75, 48)
        Button9.TabIndex = 43
        Button9.Text = "Back"
        Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button9.UseVisualStyleBackColor = False
        AddHandler Button9.Click, AddressOf Me.Button9_Click
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(511, 10)
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
        Me.FlatMax1.Location = New System.Drawing.Point(535, 10)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 29
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.FlatMini1)
        Me.Panel1.Controls.Add(Me.FlatMax1)
        Me.Panel1.Controls.Add(Me.FlatClose1)
        Me.Panel1.Controls.Add(Button2)
        Me.Panel1.Controls.Add(Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.exitbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 51)
        Me.Panel1.TabIndex = 33
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(559, 10)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 28
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(229, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 39)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "REPORT FORM"
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.Color.Crimson
        Me.exitbtn.FlatAppearance.BorderSize = 0
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exitbtn.Location = New System.Drawing.Point(667, 14)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(28, 24)
        Me.exitbtn.TabIndex = 19
        Me.exitbtn.Text = "X"
        Me.exitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'ReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(590, 377)
        Me.Controls.Add(Button9)
        Me.Controls.Add(Button7)
        Me.Controls.Add(Button6)
        Me.Controls.Add(Button5)
        Me.Controls.Add(Button4)
        Me.Controls.Add(Button3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportFrm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatMini1 As logistics_ms.FlatMini
    Friend WithEvents FlatMax1 As logistics_ms.FlatMax
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlatClose1 As logistics_ms.FlatClose
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exitbtn As System.Windows.Forms.Button
End Class
