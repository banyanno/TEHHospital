<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OTCancel
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OTCancel))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CboSurgeryName = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboDonateName = New System.Windows.Forms.ComboBox
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateCancel = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadPospone = New System.Windows.Forms.RadioButton
        Me.RadCancel = New System.Windows.Forms.RadioButton
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.ErrCancelOT = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadDonate = New System.Windows.Forms.RadioButton
        Me.RadPatientPaid = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrCancelOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboSurgeryName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtNote)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateCancel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadPospone)
        Me.GroupBox1.Controls.Add(Me.RadCancel)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 340)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operation Cancel"
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(95, 49)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(253, 26)
        Me.TxtReceiptNo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Receipt  No:"
        '
        'CboSurgeryName
        '
        Me.CboSurgeryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSurgeryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSurgeryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSurgeryName.FormattingEnabled = True
        Me.CboSurgeryName.Location = New System.Drawing.Point(95, 176)
        Me.CboSurgeryName.Name = "CboSurgeryName"
        Me.CboSurgeryName.Size = New System.Drawing.Size(253, 28)
        Me.CboSurgeryName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type of Surgery:"
        '
        'CboDonateName
        '
        Me.CboDonateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDonateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDonateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDonateName.FormattingEnabled = True
        Me.CboDonateName.Location = New System.Drawing.Point(119, 15)
        Me.CboDonateName.Name = "CboDonateName"
        Me.CboDonateName.Size = New System.Drawing.Size(218, 28)
        Me.CboDonateName.TabIndex = 3
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(13, 265)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(412, 67)
        Me.TxtNote.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Reason:"
        '
        'DateCancel
        '
        Me.DateCancel.Checked = False
        Me.DateCancel.CustomFormat = "dd/MM/yyyy"
        Me.DateCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCancel.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCancel.Location = New System.Drawing.Point(95, 212)
        Me.DateCancel.Name = "DateCancel"
        Me.DateCancel.ShowCheckBox = True
        Me.DateCancel.Size = New System.Drawing.Size(253, 26)
        Me.DateCancel.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date Cancel:"
        '
        'RadPospone
        '
        Me.RadPospone.AutoSize = True
        Me.RadPospone.Location = New System.Drawing.Point(153, 24)
        Me.RadPospone.Name = "RadPospone"
        Me.RadPospone.Size = New System.Drawing.Size(119, 17)
        Me.RadPospone.TabIndex = 1
        Me.RadPospone.Text = "Postpone Operation"
        Me.RadPospone.UseVisualStyleBackColor = True
        '
        'RadCancel
        '
        Me.RadCancel.AutoSize = True
        Me.RadCancel.Checked = True
        Me.RadCancel.Location = New System.Drawing.Point(16, 24)
        Me.RadCancel.Name = "RadCancel"
        Me.RadCancel.Size = New System.Drawing.Size(107, 17)
        Me.RadCancel.TabIndex = 0
        Me.RadCancel.TabStop = True
        Me.RadCancel.Text = "Cancel Operation"
        Me.RadCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Location = New System.Drawing.Point(275, 356)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 31)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(358, 356)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 31)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(4, 367)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'ErrCancelOT
        '
        Me.ErrCancelOT.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadPatientPaid)
        Me.GroupBox2.Controls.Add(Me.RadDonate)
        Me.GroupBox2.Controls.Add(Me.CboDonateName)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 77)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RadDonate
        '
        Me.RadDonate.AutoSize = True
        Me.RadDonate.Checked = True
        Me.RadDonate.Location = New System.Drawing.Point(6, 21)
        Me.RadDonate.Name = "RadDonate"
        Me.RadDonate.Size = New System.Drawing.Size(94, 17)
        Me.RadDonate.TabIndex = 4
        Me.RadDonate.Text = "Donate Name:"
        Me.RadDonate.UseVisualStyleBackColor = True
        '
        'RadPatientPaid
        '
        Me.RadPatientPaid.AutoSize = True
        Me.RadPatientPaid.Location = New System.Drawing.Point(6, 50)
        Me.RadPatientPaid.Name = "RadPatientPaid"
        Me.RadPatientPaid.Size = New System.Drawing.Size(82, 17)
        Me.RadPatientPaid.TabIndex = 5
        Me.RadPatientPaid.Text = "Patient Paid"
        Me.RadPatientPaid.UseVisualStyleBackColor = True
        '
        'OTCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 392)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OTCancel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OT Cancel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrCancelOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadPospone As System.Windows.Forms.RadioButton
    Friend WithEvents RadCancel As System.Windows.Forms.RadioButton
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateCancel As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrCancelOT As System.Windows.Forms.ErrorProvider
    Friend WithEvents CboDonateName As System.Windows.Forms.ComboBox
    Friend WithEvents CboSurgeryName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadPatientPaid As System.Windows.Forms.RadioButton
    Friend WithEvents RadDonate As System.Windows.Forms.RadioButton
End Class
