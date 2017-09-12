<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalledPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCalledPatient))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtCallNoted = New System.Windows.Forms.TextBox
        Me.DateCalled = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblIsUpdate = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCallNoted)
        Me.GroupBox1.Controls.Add(Me.DateCalled)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 174)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Info"
        '
        'TxtCallNoted
        '
        Me.TxtCallNoted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCallNoted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCallNoted.Location = New System.Drawing.Point(65, 90)
        Me.TxtCallNoted.Multiline = True
        Me.TxtCallNoted.Name = "TxtCallNoted"
        Me.TxtCallNoted.Size = New System.Drawing.Size(404, 75)
        Me.TxtCallNoted.TabIndex = 7
        '
        'DateCalled
        '
        Me.DateCalled.CustomFormat = "dd/MM/yyyy"
        Me.DateCalled.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCalled.Location = New System.Drawing.Point(65, 60)
        Me.DateCalled.Name = "DateCalled"
        Me.DateCalled.Size = New System.Drawing.Size(160, 20)
        Me.DateCalled.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Call Noted:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date Call:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(309, 19)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(160, 31)
        Me.TxtPatientName.TabIndex = 3
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(65, 19)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(160, 26)
        Me.TxtPatientNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'LblIsUpdate
        '
        Me.LblIsUpdate.AutoSize = True
        Me.LblIsUpdate.Location = New System.Drawing.Point(23, 199)
        Me.LblIsUpdate.Name = "LblIsUpdate"
        Me.LblIsUpdate.Size = New System.Drawing.Size(13, 13)
        Me.LblIsUpdate.TabIndex = 6
        Me.LblIsUpdate.Text = "0"
        Me.LblIsUpdate.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(405, 192)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 27)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(324, 192)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 27)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FormCalledPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 222)
        Me.Controls.Add(Me.LblIsUpdate)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCalledPatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Called Patient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCallNoted As System.Windows.Forms.TextBox
    Friend WithEvents DateCalled As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblIsUpdate As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
