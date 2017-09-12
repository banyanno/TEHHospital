<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDiagnosisAndSurgeries
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnNewDiagosis = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.GridMainDiagnosis = New System.Windows.Forms.DataGridView
        Me.SID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Surgery = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextSubDiagnosis = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateSubDiagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TxtFindDiagnosis = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridSubDiagnosis = New System.Windows.Forms.DataGridView
        Me.SSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SID1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SurgerySub = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Code1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextDeleteSubDiagnosis = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSubDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnNewSurgeries = New System.Windows.Forms.Button
        Me.BtnFindSurgeries = New System.Windows.Forms.Button
        Me.GridSurgeries = New System.Windows.Forms.DataGridView
        Me.ContextMenuSurgeries = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtSurgeries = New System.Windows.Forms.TextBox
        Me.TypeSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Surgeries = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SurgeriesFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeSurgeries = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SurgDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridMainDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextSubDiagnosis.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridSubDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextDeleteSubDiagnosis.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridSurgeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuSurgeries.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1324, 1002)
        Me.SplitContainer1.SplitterDistance = 701
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(701, 1002)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Diagnosis"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnNewDiagosis)
        Me.GroupBox3.Controls.Add(Me.BtnFind)
        Me.GroupBox3.Controls.Add(Me.GridMainDiagnosis)
        Me.GroupBox3.Controls.Add(Me.TxtFindDiagnosis)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(4, 19)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(693, 979)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'BtnNewDiagosis
        '
        Me.BtnNewDiagosis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewDiagosis.Location = New System.Drawing.Point(433, 41)
        Me.BtnNewDiagosis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNewDiagosis.Name = "BtnNewDiagosis"
        Me.BtnNewDiagosis.Size = New System.Drawing.Size(124, 43)
        Me.BtnNewDiagosis.TabIndex = 2
        Me.BtnNewDiagosis.Text = "&New Diagnosis"
        Me.BtnNewDiagosis.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(336, 41)
        Me.BtnFind.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(89, 43)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.Text = "&Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'GridMainDiagnosis
        '
        Me.GridMainDiagnosis.AllowUserToAddRows = False
        Me.GridMainDiagnosis.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridMainDiagnosis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridMainDiagnosis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMainDiagnosis.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridMainDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridMainDiagnosis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridMainDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMainDiagnosis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SID, Me.Surgery, Me.Type, Me.Description, Me.Code})
        Me.GridMainDiagnosis.ContextMenuStrip = Me.ContextSubDiagnosis
        Me.GridMainDiagnosis.Location = New System.Drawing.Point(8, 110)
        Me.GridMainDiagnosis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridMainDiagnosis.MultiSelect = False
        Me.GridMainDiagnosis.Name = "GridMainDiagnosis"
        Me.GridMainDiagnosis.ReadOnly = True
        Me.GridMainDiagnosis.RowHeadersWidth = 50
        Me.GridMainDiagnosis.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMainDiagnosis.RowTemplate.Height = 35
        Me.GridMainDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridMainDiagnosis.Size = New System.Drawing.Size(677, 862)
        Me.GridMainDiagnosis.TabIndex = 3
        '
        'SID
        '
        Me.SID.DataPropertyName = "SID"
        Me.SID.HeaderText = "SID"
        Me.SID.Name = "SID"
        Me.SID.ReadOnly = True
        Me.SID.Visible = False
        '
        'Surgery
        '
        Me.Surgery.DataPropertyName = "Surgery"
        Me.Surgery.HeaderText = "Diagnosis"
        Me.Surgery.Name = "Surgery"
        Me.Surgery.ReadOnly = True
        Me.Surgery.Width = 200
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type Other"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Type.Width = 150
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 150
        '
        'Code
        '
        Me.Code.DataPropertyName = "Code"
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        Me.Code.Visible = False
        '
        'ContextSubDiagnosis
        '
        Me.ContextSubDiagnosis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateSubDiagToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeleteDiagnosisToolStripMenuItem})
        Me.ContextSubDiagnosis.Name = "ContextSubDiagnosis"
        Me.ContextSubDiagnosis.Size = New System.Drawing.Size(229, 54)
        '
        'CreateSubDiagToolStripMenuItem
        '
        Me.CreateSubDiagToolStripMenuItem.Name = "CreateSubDiagToolStripMenuItem"
        Me.CreateSubDiagToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.CreateSubDiagToolStripMenuItem.Text = "Create Sub Diagnosis..."
        Me.CreateSubDiagToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(225, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'DeleteDiagnosisToolStripMenuItem
        '
        Me.DeleteDiagnosisToolStripMenuItem.Name = "DeleteDiagnosisToolStripMenuItem"
        Me.DeleteDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.DeleteDiagnosisToolStripMenuItem.Text = "Delete Diagnosis"
        '
        'TxtFindDiagnosis
        '
        Me.TxtFindDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindDiagnosis.Location = New System.Drawing.Point(95, 50)
        Me.TxtFindDiagnosis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtFindDiagnosis.Name = "TxtFindDiagnosis"
        Me.TxtFindDiagnosis.Size = New System.Drawing.Size(225, 30)
        Me.TxtFindDiagnosis.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daignosis:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridSubDiagnosis)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(4, 19)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(693, 979)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sub Diagnosis"
        Me.GroupBox4.Visible = False
        '
        'GridSubDiagnosis
        '
        Me.GridSubDiagnosis.AllowUserToAddRows = False
        Me.GridSubDiagnosis.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridSubDiagnosis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GridSubDiagnosis.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridSubDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridSubDiagnosis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridSubDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSubDiagnosis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SSID, Me.SID1, Me.SurgerySub, Me.Description1, Me.Code1})
        Me.GridSubDiagnosis.ContextMenuStrip = Me.ContextDeleteSubDiagnosis
        Me.GridSubDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSubDiagnosis.Location = New System.Drawing.Point(4, 19)
        Me.GridSubDiagnosis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridSubDiagnosis.MultiSelect = False
        Me.GridSubDiagnosis.Name = "GridSubDiagnosis"
        Me.GridSubDiagnosis.ReadOnly = True
        Me.GridSubDiagnosis.RowHeadersWidth = 50
        Me.GridSubDiagnosis.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSubDiagnosis.RowTemplate.Height = 35
        Me.GridSubDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSubDiagnosis.Size = New System.Drawing.Size(685, 956)
        Me.GridSubDiagnosis.TabIndex = 0
        '
        'SSID
        '
        Me.SSID.DataPropertyName = "SSID"
        Me.SSID.HeaderText = "SSID"
        Me.SSID.Name = "SSID"
        Me.SSID.ReadOnly = True
        Me.SSID.Visible = False
        '
        'SID1
        '
        Me.SID1.DataPropertyName = "SID"
        Me.SID1.HeaderText = "SID"
        Me.SID1.Name = "SID1"
        Me.SID1.ReadOnly = True
        Me.SID1.Visible = False
        '
        'SurgerySub
        '
        Me.SurgerySub.DataPropertyName = "SurgerySub"
        Me.SurgerySub.HeaderText = "Sub Diagnosis"
        Me.SurgerySub.Name = "SurgerySub"
        Me.SurgerySub.ReadOnly = True
        Me.SurgerySub.Width = 200
        '
        'Description1
        '
        Me.Description1.DataPropertyName = "Description"
        Me.Description1.HeaderText = "Description"
        Me.Description1.Name = "Description1"
        Me.Description1.ReadOnly = True
        Me.Description1.Width = 150
        '
        'Code1
        '
        Me.Code1.DataPropertyName = "Code"
        Me.Code1.HeaderText = "Code"
        Me.Code1.Name = "Code1"
        Me.Code1.ReadOnly = True
        '
        'ContextDeleteSubDiagnosis
        '
        Me.ContextDeleteSubDiagnosis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSubDiagnosisToolStripMenuItem})
        Me.ContextDeleteSubDiagnosis.Name = "ContextDeleteSubDiagnosis"
        Me.ContextDeleteSubDiagnosis.Size = New System.Drawing.Size(212, 26)
        '
        'DeleteSubDiagnosisToolStripMenuItem
        '
        Me.DeleteSubDiagnosisToolStripMenuItem.Name = "DeleteSubDiagnosisToolStripMenuItem"
        Me.DeleteSubDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.DeleteSubDiagnosisToolStripMenuItem.Text = "Delete Sub Diagnosis"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNewSurgeries)
        Me.GroupBox2.Controls.Add(Me.BtnFindSurgeries)
        Me.GroupBox2.Controls.Add(Me.GridSurgeries)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtSurgeries)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(618, 1002)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Surgeries Type:"
        '
        'BtnNewSurgeries
        '
        Me.BtnNewSurgeries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewSurgeries.Location = New System.Drawing.Point(465, 59)
        Me.BtnNewSurgeries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNewSurgeries.Name = "BtnNewSurgeries"
        Me.BtnNewSurgeries.Size = New System.Drawing.Size(124, 43)
        Me.BtnNewSurgeries.TabIndex = 2
        Me.BtnNewSurgeries.Text = "New &Surgeries"
        Me.BtnNewSurgeries.UseVisualStyleBackColor = True
        '
        'BtnFindSurgeries
        '
        Me.BtnFindSurgeries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindSurgeries.Location = New System.Drawing.Point(369, 59)
        Me.BtnFindSurgeries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFindSurgeries.Name = "BtnFindSurgeries"
        Me.BtnFindSurgeries.Size = New System.Drawing.Size(88, 43)
        Me.BtnFindSurgeries.TabIndex = 1
        Me.BtnFindSurgeries.Text = "Fi&nd"
        Me.BtnFindSurgeries.UseVisualStyleBackColor = True
        '
        'GridSurgeries
        '
        Me.GridSurgeries.AllowUserToAddRows = False
        Me.GridSurgeries.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridSurgeries.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GridSurgeries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSurgeries.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridSurgeries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridSurgeries.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GridSurgeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSurgeries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeSID, Me.Surgeries, Me.SurgeriesFee, Me.TypeSurgeries, Me.SurgDescription})
        Me.GridSurgeries.ContextMenuStrip = Me.ContextMenuSurgeries
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridSurgeries.DefaultCellStyle = DataGridViewCellStyle8
        Me.GridSurgeries.Location = New System.Drawing.Point(9, 129)
        Me.GridSurgeries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridSurgeries.Name = "GridSurgeries"
        Me.GridSurgeries.ReadOnly = True
        Me.GridSurgeries.RowHeadersWidth = 50
        Me.GridSurgeries.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSurgeries.RowTemplate.Height = 35
        Me.GridSurgeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSurgeries.Size = New System.Drawing.Size(601, 865)
        Me.GridSurgeries.TabIndex = 3
        '
        'ContextMenuSurgeries
        '
        Me.ContextMenuSurgeries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ContextMenuSurgeries.Name = "ContextDeleteSubDiagnosis"
        Me.ContextMenuSurgeries.Size = New System.Drawing.Size(118, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuItem2.Text = "Delete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Surgeries Type:"
        '
        'TxtSurgeries
        '
        Me.TxtSurgeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurgeries.Location = New System.Drawing.Point(124, 70)
        Me.TxtSurgeries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSurgeries.Name = "TxtSurgeries"
        Me.TxtSurgeries.Size = New System.Drawing.Size(225, 30)
        Me.TxtSurgeries.TabIndex = 0
        '
        'TypeSID
        '
        Me.TypeSID.DataPropertyName = "SID"
        Me.TypeSID.HeaderText = "No"
        Me.TypeSID.Name = "TypeSID"
        Me.TypeSID.ReadOnly = True
        Me.TypeSID.Visible = False
        Me.TypeSID.Width = 50
        '
        'Surgeries
        '
        Me.Surgeries.DataPropertyName = "Surgeries"
        Me.Surgeries.HeaderText = "Surgeries"
        Me.Surgeries.Name = "Surgeries"
        Me.Surgeries.ReadOnly = True
        Me.Surgeries.Width = 200
        '
        'SurgeriesFee
        '
        Me.SurgeriesFee.DataPropertyName = "SurgeriesFee"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SurgeriesFee.DefaultCellStyle = DataGridViewCellStyle7
        Me.SurgeriesFee.HeaderText = "Surgery Price"
        Me.SurgeriesFee.Name = "SurgeriesFee"
        Me.SurgeriesFee.ReadOnly = True
        Me.SurgeriesFee.Width = 250
        '
        'TypeSurgeries
        '
        Me.TypeSurgeries.DataPropertyName = "Type"
        Me.TypeSurgeries.HeaderText = "Type Other"
        Me.TypeSurgeries.Name = "TypeSurgeries"
        Me.TypeSurgeries.ReadOnly = True
        Me.TypeSurgeries.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TypeSurgeries.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TypeSurgeries.Visible = False
        Me.TypeSurgeries.Width = 150
        '
        'SurgDescription
        '
        Me.SurgDescription.DataPropertyName = "Description"
        Me.SurgDescription.HeaderText = "Description"
        Me.SurgDescription.Name = "SurgDescription"
        Me.SurgDescription.ReadOnly = True
        Me.SurgDescription.Width = 300
        '
        'UCDiagnosisAndSurgeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UCDiagnosisAndSurgeries"
        Me.Size = New System.Drawing.Size(1324, 1002)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridMainDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextSubDiagnosis.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridSubDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextDeleteSubDiagnosis.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridSurgeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuSurgeries.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridMainDiagnosis As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridSubDiagnosis As System.Windows.Forms.DataGridView
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtFindDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNewDiagosis As System.Windows.Forms.Button
    Friend WithEvents ContextSubDiagnosis As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateSubDiagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteDiagnosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextDeleteSubDiagnosis As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSubDiagnosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurgerySub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridSurgeries As System.Windows.Forms.DataGridView
    Friend WithEvents BtnNewSurgeries As System.Windows.Forms.Button
    Friend WithEvents BtnFindSurgeries As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSurgeries As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuSurgeries As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surgery As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surgeries As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurgeriesFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeSurgeries As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SurgDescription As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
