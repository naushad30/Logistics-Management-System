<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustReportFrm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.customer_regBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogisticDataSet = New logistics_ms.LogisticDataSet()
        Me.transport_info_entryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.customer_regTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.customer_regTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatClose1 = New logistics_ms.FlatClose()
        Me.FlatMax1 = New logistics_ms.FlatMax()
        Me.FlatMini1 = New logistics_ms.FlatMini()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.transport_info_entryTableAdapter = New logistics_ms.LogisticDataSetTableAdapters.transport_info_entryTableAdapter()
        Button9 = New System.Windows.Forms.Button()
        CType(Me.customer_regBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transport_info_entryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'customer_regBindingSource
        '
        Me.customer_regBindingSource.DataMember = "customer_reg"
        Me.customer_regBindingSource.DataSource = Me.LogisticDataSet
        '
        'LogisticDataSet
        '
        Me.LogisticDataSet.DataSetName = "LogisticDataSet"
        Me.LogisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Button9.TabIndex = 44
        Button9.Text = "Back"
        Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Button9.UseVisualStyleBackColor = False
        AddHandler Button9.Click, AddressOf Me.Button9_Click
        '
        'transport_info_entryBindingSource
        '
        Me.transport_info_entryBindingSource.DataMember = "transport_info_entry"
        Me.transport_info_entryBindingSource.DataSource = Me.LogisticDataSet
        '
        'customer_regTableAdapter
        '
        Me.customer_regTableAdapter.ClearBeforeFill = True
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
        Me.Panel1.Size = New System.Drawing.Size(800, 48)
        Me.Panel1.TabIndex = 1
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(762, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 3
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(738, 12)
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
        Me.FlatMini1.Location = New System.Drawing.Point(713, 13)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "custDataSet"
        ReportDataSource1.Value = Me.customer_regBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "logistics_ms.CustomerReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 48)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 430)
        Me.ReportViewer1.TabIndex = 2
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'transport_info_entryTableAdapter
        '
        Me.transport_info_entryTableAdapter.ClearBeforeFill = True
        '
        'CustReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.customer_regBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transport_info_entryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents customer_regBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogisticDataSet As logistics_ms.LogisticDataSet
    Friend WithEvents customer_regTableAdapter As logistics_ms.LogisticDataSetTableAdapters.customer_regTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlatClose1 As logistics_ms.FlatClose
    Friend WithEvents FlatMax1 As logistics_ms.FlatMax
    Friend WithEvents FlatMini1 As logistics_ms.FlatMini
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents transport_info_entryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents transport_info_entryTableAdapter As logistics_ms.LogisticDataSetTableAdapters.transport_info_entryTableAdapter
End Class
