<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDateFollowUP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDateFollowUP))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblDateLeave = New System.Windows.Forms.Label
        Me.DateFollowUp = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateDischarge = New System.Windows.Forms.DateTimePicker
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.ErDateFollowUp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErDateFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboDoctor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblDateLeave)
        Me.GroupBox1.Controls.Add(Me.DateFollowUp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 260)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Followup"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(370, 126)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 10
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "(mm-dd-yyyy)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(9, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 51)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Note: If you don't check [Date Followup]  then patient won't have the followup."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(9, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 58)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ចំណាំ: ប្រសិនបើអ្នកមិនជ្រើសរើសថ្ងៃណាត់ជួប អ្នកជំងឺក៍មិនមានការណាត់ជួបដែរ។"
        '
        'LblDateLeave
        '
        Me.LblDateLeave.AutoSize = True
        Me.LblDateLeave.Location = New System.Drawing.Point(95, 35)
        Me.LblDateLeave.Name = "LblDateLeave"
        Me.LblDateLeave.Size = New System.Drawing.Size(13, 13)
        Me.LblDateLeave.TabIndex = 2
        Me.LblDateLeave.Text = "0"
        '
        'DateFollowUp
        '
        Me.DateFollowUp.Checked = False
        Me.DateFollowUp.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowUp.Location = New System.Drawing.Point(98, 63)
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.ShowCheckBox = True
        Me.DateFollowUp.Size = New System.Drawing.Size(171, 26)
        Me.DateFollowUp.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Date FollowUp:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Discharge:"
        '
        'DateDischarge
        '
        Me.DateDischarge.Checked = False
        Me.DateDischarge.CustomFormat = "dd/MM/yyyy"
        Me.DateDischarge.Enabled = False
        Me.DateDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDischarge.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDischarge.Location = New System.Drawing.Point(315, 26)
        Me.DateDischarge.Name = "DateDischarge"
        Me.DateDischarge.ShowCheckBox = True
        Me.DateDischarge.Size = New System.Drawing.Size(123, 26)
        Me.DateDischarge.TabIndex = 0
        Me.DateDischarge.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(12, 278)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(90, 31)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "With Doctor:"
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Enabled = False
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(98, 103)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(171, 28)
        Me.CboDoctor.TabIndex = 8
        '
        'ErDateFollowUp
        '
        Me.ErDateFollowUp.ContainerControl = Me
        '
        'FrmDateFollowUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.DateDischarge)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDateFollowUP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date FollowUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErDateFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateDischarge As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateFollowUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents LblDateLeave As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErDateFollowUp As System.Windows.Forms.ErrorProvider
End Class
