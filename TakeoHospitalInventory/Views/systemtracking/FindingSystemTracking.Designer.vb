<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindingSystemTracking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindingSystemTracking))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.RadDescription = New System.Windows.Forms.RadioButton
        Me.txtAction = New System.Windows.Forms.TextBox
        Me.RadByAction = New System.Windows.Forms.RadioButton
        Me.TxtTrackingFrom = New System.Windows.Forms.TextBox
        Me.RadByTrackingFrom = New System.Windows.Forms.RadioButton
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.RadByPatient = New System.Windows.Forms.RadioButton
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnPritPreview1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date To:"
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(78, 12)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(208, 23)
        Me.DateFrom.TabIndex = 2
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(78, 43)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(208, 23)
        Me.DateTo.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDescription)
        Me.GroupBox1.Controls.Add(Me.RadDescription)
        Me.GroupBox1.Controls.Add(Me.txtAction)
        Me.GroupBox1.Controls.Add(Me.RadByAction)
        Me.GroupBox1.Controls.Add(Me.TxtTrackingFrom)
        Me.GroupBox1.Controls.Add(Me.RadByTrackingFrom)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadByPatient)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 244)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "With"
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(9, 211)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(250, 26)
        Me.TxtDescription.TabIndex = 7
        '
        'RadDescription
        '
        Me.RadDescription.AutoSize = True
        Me.RadDescription.Location = New System.Drawing.Point(9, 185)
        Me.RadDescription.Name = "RadDescription"
        Me.RadDescription.Size = New System.Drawing.Size(107, 24)
        Me.RadDescription.TabIndex = 6
        Me.RadDescription.TabStop = True
        Me.RadDescription.Text = "Description"
        Me.RadDescription.UseVisualStyleBackColor = True
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(9, 154)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(250, 26)
        Me.txtAction.TabIndex = 5
        '
        'RadByAction
        '
        Me.RadByAction.AutoSize = True
        Me.RadByAction.Location = New System.Drawing.Point(9, 129)
        Me.RadByAction.Name = "RadByAction"
        Me.RadByAction.Size = New System.Drawing.Size(76, 24)
        Me.RadByAction.TabIndex = 4
        Me.RadByAction.TabStop = True
        Me.RadByAction.Text = "Action:"
        Me.RadByAction.UseVisualStyleBackColor = True
        '
        'TxtTrackingFrom
        '
        Me.TxtTrackingFrom.Location = New System.Drawing.Point(9, 99)
        Me.TxtTrackingFrom.Name = "TxtTrackingFrom"
        Me.TxtTrackingFrom.Size = New System.Drawing.Size(250, 26)
        Me.TxtTrackingFrom.TabIndex = 3
        '
        'RadByTrackingFrom
        '
        Me.RadByTrackingFrom.AutoSize = True
        Me.RadByTrackingFrom.Location = New System.Drawing.Point(9, 74)
        Me.RadByTrackingFrom.Name = "RadByTrackingFrom"
        Me.RadByTrackingFrom.Size = New System.Drawing.Size(132, 24)
        Me.RadByTrackingFrom.TabIndex = 2
        Me.RadByTrackingFrom.TabStop = True
        Me.RadByTrackingFrom.Text = "Tracking From:"
        Me.RadByTrackingFrom.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Location = New System.Drawing.Point(9, 47)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(250, 26)
        Me.TxtPatientNo.TabIndex = 1
        '
        'RadByPatient
        '
        Me.RadByPatient.AutoSize = True
        Me.RadByPatient.Location = New System.Drawing.Point(9, 20)
        Me.RadByPatient.Name = "RadByPatient"
        Me.RadByPatient.Size = New System.Drawing.Size(105, 24)
        Me.RadByPatient.TabIndex = 0
        Me.RadByPatient.TabStop = True
        Me.RadByPatient.Text = "Patient No:"
        Me.RadByPatient.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Location = New System.Drawing.Point(133, 321)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(75, 28)
        Me.BtnFind.TabIndex = 5
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(212, 321)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 28)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnPritPreview1
        '
        Me.BtnPritPreview1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPritPreview1.Location = New System.Drawing.Point(16, 320)
        Me.BtnPritPreview1.Name = "BtnPritPreview1"
        Me.BtnPritPreview1.Size = New System.Drawing.Size(94, 28)
        Me.BtnPritPreview1.TabIndex = 7
        Me.BtnPritPreview1.Text = "Print Preview"
        Me.BtnPritPreview1.UseVisualStyleBackColor = True
        '
        'FindingSystemTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 353)
        Me.Controls.Add(Me.BtnPritPreview1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.DateFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindingSystemTracking"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter system traking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadByPatient As System.Windows.Forms.RadioButton
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtTrackingFrom As System.Windows.Forms.TextBox
    Friend WithEvents RadByTrackingFrom As System.Windows.Forms.RadioButton
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents RadByAction As System.Windows.Forms.RadioButton
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents RadDescription As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPritPreview1 As System.Windows.Forms.Button
End Class
