<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpensesReportFrm
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim Button9 As System.Windows.Forms.Button
        Me.expensis_entryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogisticDataSet = New logistics_ms.LogisticDataSet()
        Me.FlatClose1 = New logistics_ms.FlatClose()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatMax1 = New logistics_ms.FlatMax()
        Me.FlatMini1 = New logistics_ms.FlatMini()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.expensis_entryTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.expensis_entryTableAdapter()
        Button9 = New System.Windows.Forms.Button()
        CType(Me.expensis_entryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'expensis_entryBindingSource
        '
        Me.expensis_entryBindingSource.DataMember = "expensis_entry"
        Me.expensis_entryBindingSource.DataSource = Me.LogisticDataSet
        '
        'LogisticDataSet
        '
        Me.LogisticDataSet.DataSetName = "LogisticDataSet"
        Me.LogisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(576, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 3
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Button9)
        Me.Panel1.Controls.Add(Me.FlatClose1)
        Me.Panel1.Controls.Add(Me.FlatMax1)
        Me.Panel1.Controls.Add(Me.FlatMini1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 48)
        Me.Panel1.TabIndex = 2
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(552, 12)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 2
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(527, 13)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.expensis_entryBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "logistics_ms.Expensisreport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 48)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(614, 363)
        Me.ReportViewer1.TabIndex = 3
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'expensis_entryTableAdapter
        '
        Me.expensis_entryTableAdapter.ClearBeforeFill = True
        '
        'Button9
        '
        Button9.BackColor = System.Drawing.Color.MediumSeaGreen
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Button9.Location = New System.Drawing.Point(12, 9)
        Button9.Name = "Button9"
        Button9.Size = New System.Drawing.Size(61, 33)
        Button9.TabIndex = 45
        Button9.Text = "Back"
        Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button9.UseVisualStyleBackColor = False
        AddHandler Button9.Click, AddressOf Me.Button9_Click
        '
        'ExpensesReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 411)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExpensesReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExpensesReportFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.expensis_entryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatClose1 As logistics_ms.FlatClose
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlatMax1 As logistics_ms.FlatMax
    Friend WithEvents FlatMini1 As logistics_ms.FlatMini
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents expensis_entryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogisticDataSet As logistics_ms.LogisticDataSet
    Friend WithEvents expensis_entryTableAdapter As logistics_ms.LogisticDataSetTableAdapters.expensis_entryTableAdapter
End Class
