<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMarkEOD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMarkEOD))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateNewBusinessDay = New System.Windows.Forms.DateTimePicker
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnSettingMarkEOD = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mark Next Business Day"
        '
        'DateNewBusinessDay
        '
        Me.DateNewBusinessDay.Checked = False
        Me.DateNewBusinessDay.CustomFormat = "dd-MM-yyyy"
        Me.DateNewBusinessDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateNewBusinessDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateNewBusinessDay.Location = New System.Drawing.Point(19, 53)
        Me.DateNewBusinessDay.Name = "DateNewBusinessDay"
        Me.DateNewBusinessDay.ShowCheckBox = True
        Me.DateNewBusinessDay.Size = New System.Drawing.Size(358, 44)
        Me.DateNewBusinessDay.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BtnSettingMarkEOD
        '
        Me.BtnSettingMarkEOD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettingMarkEOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettingMarkEOD.Location = New System.Drawing.Point(93, 110)
        Me.BtnSettingMarkEOD.Name = "BtnSettingMarkEOD"
        Me.BtnSettingMarkEOD.Size = New System.Drawing.Size(151, 44)
        Me.BtnSettingMarkEOD.TabIndex = 2
        Me.BtnSettingMarkEOD.Text = "Sett New Date"
        Me.BtnSettingMarkEOD.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(254, 110)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(123, 44)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaveOption.ForeColor = System.Drawing.Color.Red
        Me.LblSaveOption.Location = New System.Drawing.Point(12, 109)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(35, 37)
        Me.LblSaveOption.TabIndex = 4
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'FormMarkEOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 160)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSettingMarkEOD)
        Me.Controls.Add(Me.DateNewBusinessDay)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMarkEOD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMarkEOD"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateNewBusinessDay As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSettingMarkEOD As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
End Class
