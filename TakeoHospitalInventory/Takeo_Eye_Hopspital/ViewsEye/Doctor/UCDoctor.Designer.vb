<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDoctor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnViewData = New System.Windows.Forms.Button
        Me.CboSex = New System.Windows.Forms.ComboBox
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.TxtFunction = New System.Windows.Forms.TextBox
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.TxtDoctorName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridDoctor = New System.Windows.Forms.DataGridView
        Me.DoctorNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DoctorName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Job = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextDoctor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnViewOther = New System.Windows.Forms.Button
        Me.BtnNewOther = New System.Windows.Forms.Button
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.TxtOther = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GridOther = New System.Windows.Forms.DataGridView
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Other = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextOther = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrDoctor = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextDoctor.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridOther, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextOther.SuspendLayout()
        CType(Me.ErrDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnNew)
        Me.GroupBox1.Controls.Add(Me.BtnViewData)
        Me.GroupBox1.Controls.Add(Me.CboSex)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.TxtFunction)
        Me.GroupBox1.Controls.Add(Me.TxtTel)
        Me.GroupBox1.Controls.Add(Me.TxtDoctorName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor Info"
        '
        'BtnNew
        '
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Location = New System.Drawing.Point(359, 66)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(77, 36)
        Me.BtnNew.TabIndex = 5
        Me.BtnNew.Text = "&New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnViewData
        '
        Me.BtnViewData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewData.Location = New System.Drawing.Point(359, 108)
        Me.BtnViewData.Name = "BtnViewData"
        Me.BtnViewData.Size = New System.Drawing.Size(77, 36)
        Me.BtnViewData.TabIndex = 6
        Me.BtnViewData.Text = "&View Data"
        Me.BtnViewData.UseVisualStyleBackColor = True
        '
        'CboSex
        '
        Me.CboSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSex.FormattingEnabled = True
        Me.CboSex.Location = New System.Drawing.Point(93, 51)
        Me.CboSex.Name = "CboSex"
        Me.CboSex.Size = New System.Drawing.Size(61, 28)
        Me.CboSex.TabIndex = 1
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(218, 54)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(53, 26)
        Me.TxtAge.TabIndex = 2
        '
        'TxtFunction
        '
        Me.TxtFunction.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFunction.Location = New System.Drawing.Point(93, 120)
        Me.TxtFunction.Name = "TxtFunction"
        Me.TxtFunction.ReadOnly = True
        Me.TxtFunction.Size = New System.Drawing.Size(260, 26)
        Me.TxtFunction.TabIndex = 4
        '
        'TxtTel
        '
        Me.TxtTel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(93, 86)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.ReadOnly = True
        Me.TxtTel.Size = New System.Drawing.Size(260, 26)
        Me.TxtTel.TabIndex = 3
        '
        'TxtDoctorName
        '
        Me.TxtDoctorName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtDoctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoctorName.Location = New System.Drawing.Point(93, 19)
        Me.TxtDoctorName.Name = "TxtDoctorName"
        Me.TxtDoctorName.ReadOnly = True
        Me.TxtDoctorName.Size = New System.Drawing.Size(260, 26)
        Me.TxtDoctorName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Function:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telephone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sex:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridDoctor)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 632)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Doctor List"
        '
        'GridDoctor
        '
        Me.GridDoctor.AllowUserToAddRows = False
        Me.GridDoctor.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridDoctor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridDoctor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridDoctor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDoctor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DoctorNo, Me.DoctorName, Me.Sex, Me.Age, Me.Telephone, Me.Job})
        Me.GridDoctor.ContextMenuStrip = Me.ContextDoctor
        Me.GridDoctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDoctor.Location = New System.Drawing.Point(3, 16)
        Me.GridDoctor.Name = "GridDoctor"
        Me.GridDoctor.ReadOnly = True
        Me.GridDoctor.RowHeadersWidth = 50
        Me.GridDoctor.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDoctor.RowTemplate.Height = 30
        Me.GridDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDoctor.Size = New System.Drawing.Size(382, 613)
        Me.GridDoctor.TabIndex = 0
        '
        'DoctorNo
        '
        Me.DoctorNo.DataPropertyName = "DoctorNo"
        Me.DoctorNo.HeaderText = "No"
        Me.DoctorNo.Name = "DoctorNo"
        Me.DoctorNo.ReadOnly = True
        Me.DoctorNo.Visible = False
        '
        'DoctorName
        '
        Me.DoctorName.DataPropertyName = "DoctorName"
        Me.DoctorName.HeaderText = "Name"
        Me.DoctorName.Name = "DoctorName"
        Me.DoctorName.ReadOnly = True
        Me.DoctorName.Width = 150
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.ReadOnly = True
        Me.Sex.Width = 50
        '
        'Age
        '
        Me.Age.DataPropertyName = "Age"
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        Me.Age.Width = 50
        '
        'Telephone
        '
        Me.Telephone.DataPropertyName = "Tel"
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.ReadOnly = True
        '
        'Job
        '
        Me.Job.DataPropertyName = "Job"
        Me.Job.HeaderText = "Function"
        Me.Job.Name = "Job"
        Me.Job.ReadOnly = True
        Me.Job.Width = 300
        '
        'ContextDoctor
        '
        Me.ContextDoctor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.ContextDoctor.Name = "ContextDoctor"
        Me.ContextDoctor.Size = New System.Drawing.Size(106, 26)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(804, 798)
        Me.SplitContainer1.SplitterDistance = 390
        Me.SplitContainer1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnViewOther)
        Me.GroupBox3.Controls.Add(Me.BtnNewOther)
        Me.GroupBox3.Controls.Add(Me.TxtDescription)
        Me.GroupBox3.Controls.Add(Me.TxtOther)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.GridOther)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(408, 796)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Others"
        '
        'BtnViewOther
        '
        Me.BtnViewOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewOther.Location = New System.Drawing.Point(313, 24)
        Me.BtnViewOther.Name = "BtnViewOther"
        Me.BtnViewOther.Size = New System.Drawing.Size(63, 30)
        Me.BtnViewOther.TabIndex = 6
        Me.BtnViewOther.Text = "View"
        Me.BtnViewOther.UseVisualStyleBackColor = True
        '
        'BtnNewOther
        '
        Me.BtnNewOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewOther.Location = New System.Drawing.Point(244, 24)
        Me.BtnNewOther.Name = "BtnNewOther"
        Me.BtnNewOther.Size = New System.Drawing.Size(63, 30)
        Me.BtnNewOther.TabIndex = 5
        Me.BtnNewOther.Text = "New"
        Me.BtnNewOther.UseVisualStyleBackColor = True
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(19, 82)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(370, 82)
        Me.TxtDescription.TabIndex = 4
        '
        'TxtOther
        '
        Me.TxtOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOther.Location = New System.Drawing.Point(58, 25)
        Me.TxtOther.Name = "TxtOther"
        Me.TxtOther.Size = New System.Drawing.Size(180, 26)
        Me.TxtOther.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Other:"
        '
        'GridOther
        '
        Me.GridOther.AllowUserToAddRows = False
        Me.GridOther.AllowUserToDeleteRows = False
        Me.GridOther.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridOther.BackgroundColor = System.Drawing.SystemColors.Window
        Me.GridOther.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOther.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Other, Me.Description})
        Me.GridOther.ContextMenuStrip = Me.ContextOther
        Me.GridOther.Location = New System.Drawing.Point(3, 180)
        Me.GridOther.Name = "GridOther"
        Me.GridOther.ReadOnly = True
        Me.GridOther.RowTemplate.Height = 30
        Me.GridOther.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridOther.Size = New System.Drawing.Size(402, 581)
        Me.GridOther.TabIndex = 0
        '
        'No
        '
        Me.No.DataPropertyName = "No"
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Visible = False
        '
        'Other
        '
        Me.Other.DataPropertyName = "Other"
        Me.Other.HeaderText = "Other"
        Me.Other.Name = "Other"
        Me.Other.ReadOnly = True
        Me.Other.Width = 150
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 200
        '
        'ContextOther
        '
        Me.ContextOther.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextOther.Name = "ContextOther"
        Me.ContextOther.Size = New System.Drawing.Size(106, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ErrDoctor
        '
        Me.ErrDoctor.ContainerControl = Me
        '
        'UCDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCDoctor"
        Me.Size = New System.Drawing.Size(804, 798)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextDoctor.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridOther, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextOther.ResumeLayout(False)
        CType(Me.ErrDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridDoctor As System.Windows.Forms.DataGridView
    Friend WithEvents TxtDoctorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboSex As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtFunction As System.Windows.Forms.TextBox
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents ErrDoctor As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnViewData As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridOther As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents TxtOther As System.Windows.Forms.TextBox
    Friend WithEvents BtnNewOther As System.Windows.Forms.Button
    Friend WithEvents BtnViewOther As System.Windows.Forms.Button
    Friend WithEvents ContextDoctor As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextOther As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoctorName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Job As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Other As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
