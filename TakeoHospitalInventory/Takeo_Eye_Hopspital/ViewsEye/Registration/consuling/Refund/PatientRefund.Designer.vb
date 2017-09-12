<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRefund
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
        Dim GridRefund_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientRefund))
        Me.GPatientRefund = New System.Windows.Forms.GroupBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.TxtRefundNote = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateRefund = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtRefundFor = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.RadRield = New System.Windows.Forms.RadioButton
        Me.TxtMoneyRefund = New System.Windows.Forms.TextBox
        Me.RadDolar = New System.Windows.Forms.RadioButton
        Me.Label32 = New System.Windows.Forms.Label
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ErrRefund = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridRefund = New Janus.Windows.GridEX.GridEX
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.GPatientRefund.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrRefund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridRefund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPatientRefund
        '
        Me.GPatientRefund.Controls.Add(Me.LblSaveOption)
        Me.GPatientRefund.Controls.Add(Me.TxtRefundNote)
        Me.GPatientRefund.Controls.Add(Me.Label3)
        Me.GPatientRefund.Controls.Add(Me.DateRefund)
        Me.GPatientRefund.Controls.Add(Me.Label2)
        Me.GPatientRefund.Controls.Add(Me.TxtRefundFor)
        Me.GPatientRefund.Controls.Add(Me.Label33)
        Me.GPatientRefund.Controls.Add(Me.RadRield)
        Me.GPatientRefund.Controls.Add(Me.TxtMoneyRefund)
        Me.GPatientRefund.Controls.Add(Me.RadDolar)
        Me.GPatientRefund.Controls.Add(Me.Label32)
        Me.GPatientRefund.Controls.Add(Me.TxtReceiptNo)
        Me.GPatientRefund.Controls.Add(Me.Label25)
        Me.GPatientRefund.Location = New System.Drawing.Point(427, 106)
        Me.GPatientRefund.Name = "GPatientRefund"
        Me.GPatientRefund.Size = New System.Drawing.Size(346, 265)
        Me.GPatientRefund.TabIndex = 5
        Me.GPatientRefund.TabStop = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(256, 101)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 15
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'TxtRefundNote
        '
        Me.TxtRefundNote.Location = New System.Drawing.Point(10, 179)
        Me.TxtRefundNote.Multiline = True
        Me.TxtRefundNote.Name = "TxtRefundNote"
        Me.TxtRefundNote.Size = New System.Drawing.Size(324, 69)
        Me.TxtRefundNote.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Refund Note:"
        '
        'DateRefund
        '
        Me.DateRefund.Checked = False
        Me.DateRefund.CustomFormat = "dd-MM-yyyy"
        Me.DateRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRefund.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRefund.Location = New System.Drawing.Point(84, 22)
        Me.DateRefund.Name = "DateRefund"
        Me.DateRefund.ShowCheckBox = True
        Me.DateRefund.Size = New System.Drawing.Size(144, 26)
        Me.DateRefund.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Date Refund:"
        '
        'TxtRefundFor
        '
        Me.TxtRefundFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRefundFor.Location = New System.Drawing.Point(163, 133)
        Me.TxtRefundFor.Name = "TxtRefundFor"
        Me.TxtRefundFor.ReadOnly = True
        Me.TxtRefundFor.Size = New System.Drawing.Size(65, 26)
        Me.TxtRefundFor.TabIndex = 10
        Me.TxtRefundFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(164, 104)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 13)
        Me.Label33.TabIndex = 9
        Me.Label33.Text = "Refund For"
        '
        'RadRield
        '
        Me.RadRield.AutoSize = True
        Me.RadRield.Font = New System.Drawing.Font("សម្រាប់កូនខ្មែរ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadRield.Location = New System.Drawing.Point(125, 99)
        Me.RadRield.Name = "RadRield"
        Me.RadRield.Size = New System.Drawing.Size(32, 26)
        Me.RadRield.TabIndex = 7
        Me.RadRield.TabStop = True
        Me.RadRield.Text = "៛"
        Me.RadRield.UseVisualStyleBackColor = True
        '
        'TxtMoneyRefund
        '
        Me.TxtMoneyRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMoneyRefund.Location = New System.Drawing.Point(6, 134)
        Me.TxtMoneyRefund.Name = "TxtMoneyRefund"
        Me.TxtMoneyRefund.Size = New System.Drawing.Size(151, 26)
        Me.TxtMoneyRefund.TabIndex = 9
        '
        'RadDolar
        '
        Me.RadDolar.AutoSize = True
        Me.RadDolar.Location = New System.Drawing.Point(70, 102)
        Me.RadDolar.Name = "RadDolar"
        Me.RadDolar.Size = New System.Drawing.Size(31, 17)
        Me.RadDolar.TabIndex = 6
        Me.RadDolar.TabStop = True
        Me.RadDolar.Text = "$"
        Me.RadDolar.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(5, 108)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 13)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Refund:"
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(70, 64)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.ReadOnly = True
        Me.TxtReceiptNo.Size = New System.Drawing.Size(158, 26)
        Me.TxtReceiptNo.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 13)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Receipt No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 94)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient "
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Location = New System.Drawing.Point(305, 15)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(28, 23)
        Me.BtnFind.TabIndex = 14
        Me.BtnFind.Text = "..."
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(69, 16)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(230, 26)
        Me.TxtPatientNo.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Patient No:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BackColor = System.Drawing.Color.White
        Me.TxtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(69, 49)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.ReadOnly = True
        Me.TxtPatientName.Size = New System.Drawing.Size(230, 33)
        Me.TxtPatientName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(603, 377)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 29)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(686, 377)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ErrRefund
        '
        Me.ErrRefund.ContainerControl = Me
        '
        'GridRefund
        '
        Me.GridRefund.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridRefund_DesignTimeLayout.LayoutString = resources.GetString("GridRefund_DesignTimeLayout.LayoutString")
        Me.GridRefund.DesignTimeLayout = GridRefund_DesignTimeLayout
        Me.GridRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridRefund.GroupByBoxVisible = False
        Me.GridRefund.Location = New System.Drawing.Point(7, 112)
        Me.GridRefund.Name = "GridRefund"
        Me.GridRefund.Size = New System.Drawing.Size(417, 259)
        Me.GridRefund.TabIndex = 12
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label37)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Controls.Add(Me.Label36)
        Me.GroupBox8.Controls.Add(Me.Label35)
        Me.GroupBox8.Location = New System.Drawing.Point(427, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(346, 73)
        Me.GroupBox8.TabIndex = 22
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Receipt Status"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.Location = New System.Drawing.Point(67, 21)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(94, 13)
        Me.Label37.TabIndex = 17
        Me.Label37.Text = "NR= New Receipt"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.Location = New System.Drawing.Point(213, 40)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(92, 13)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "OP= Optical Shop"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.Location = New System.Drawing.Point(67, 41)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 13)
        Me.Label36.TabIndex = 18
        Me.Label36.Text = "OR= Old Receipt"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.Location = New System.Drawing.Point(213, 21)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(76, 13)
        Me.Label35.TabIndex = 19
        Me.Label35.Text = "IR= In Receipt"
        '
        'PatientRefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 411)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GridRefund)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GPatientRefund)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatientRefund"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientRefund"
        Me.GPatientRefund.ResumeLayout(False)
        Me.GPatientRefund.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrRefund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridRefund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GPatientRefund As System.Windows.Forms.GroupBox
    Friend WithEvents TxtRefundFor As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents RadRield As System.Windows.Forms.RadioButton
    Friend WithEvents TxtMoneyRefund As System.Windows.Forms.TextBox
    Friend WithEvents RadDolar As System.Windows.Forms.RadioButton
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrRefund As System.Windows.Forms.ErrorProvider
    Friend WithEvents DateRefund As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtRefundNote As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents GridRefund As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
End Class
