<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnterDoctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEnterDoctor))
        Me.Label3 = New System.Windows.Forms.Label
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.lblNewPatientNo = New System.Windows.Forms.Label
        Me.txtPatientNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErrDiagnosis = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "By Doctor:"
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(76, 45)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(285, 28)
        Me.CboDoctor.TabIndex = 7
        '
        'lblNewPatientNo
        '
        Me.lblNewPatientNo.AutoSize = True
        Me.lblNewPatientNo.Location = New System.Drawing.Point(14, 83)
        Me.lblNewPatientNo.Name = "lblNewPatientNo"
        Me.lblNewPatientNo.Size = New System.Drawing.Size(13, 13)
        Me.lblNewPatientNo.TabIndex = 9
        Me.lblNewPatientNo.Text = "0"
        Me.lblNewPatientNo.Visible = False
        '
        'txtPatientNo
        '
        Me.txtPatientNo.BackColor = System.Drawing.Color.White
        Me.txtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientNo.Location = New System.Drawing.Point(75, 12)
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.ReadOnly = True
        Me.txtPatientNo.Size = New System.Drawing.Size(286, 26)
        Me.txtPatientNo.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Patient No:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(295, 83)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(66, 27)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(223, 83)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(66, 27)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErrDiagnosis
        '
        Me.ErrDiagnosis.ContainerControl = Me
        '
        'FormEnterDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 118)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.txtPatientNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNewPatientNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboDoctor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEnterDoctor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor"
        CType(Me.ErrDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents lblNewPatientNo As System.Windows.Forms.Label
    Friend WithEvents txtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrDiagnosis As System.Windows.Forms.ErrorProvider
End Class
