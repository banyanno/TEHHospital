<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainDiagnosis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainDiagnosis))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChTypeOther = New System.Windows.Forms.CheckBox
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.TxtCode = New System.Windows.Forms.TextBox
        Me.TxtDiagnosis = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCance = New System.Windows.Forms.Button
        Me.ErrDiagnosis = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrDiagnosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChTypeOther)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.TxtDescription)
        Me.GroupBox1.Controls.Add(Me.TxtCode)
        Me.GroupBox1.Controls.Add(Me.TxtDiagnosis)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(484, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ChTypeOther
        '
        Me.ChTypeOther.AutoSize = True
        Me.ChTypeOther.Location = New System.Drawing.Point(345, 32)
        Me.ChTypeOther.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChTypeOther.Name = "ChTypeOther"
        Me.ChTypeOther.Size = New System.Drawing.Size(102, 21)
        Me.ChTypeOther.TabIndex = 1
        Me.ChTypeOther.Text = "Type Other"
        Me.ChTypeOther.UseVisualStyleBackColor = True
        Me.ChTypeOther.Visible = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(367, 102)
        Me.LblSaveOption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 17)
        Me.LblSaveOption.TabIndex = 4
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(15, 137)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(460, 70)
        Me.TxtDescription.TabIndex = 3
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(87, 70)
        Me.TxtCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(248, 30)
        Me.TxtCode.TabIndex = 2
        '
        'TxtDiagnosis
        '
        Me.TxtDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiagnosis.Location = New System.Drawing.Point(87, 23)
        Me.TxtDiagnosis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDiagnosis.Name = "TxtDiagnosis"
        Me.TxtDiagnosis.Size = New System.Drawing.Size(248, 30)
        Me.TxtDiagnosis.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diagnosis:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(153, 234)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 41)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCance
        '
        Me.BtnCance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCance.Location = New System.Drawing.Point(261, 234)
        Me.BtnCance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCance.Name = "BtnCance"
        Me.BtnCance.Size = New System.Drawing.Size(100, 41)
        Me.BtnCance.TabIndex = 2
        Me.BtnCance.Text = "&Cancel"
        Me.BtnCance.UseVisualStyleBackColor = True
        '
        'ErrDiagnosis
        '
        Me.ErrDiagnosis.ContainerControl = Me
        '
        'FrmMainDiagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 286)
        Me.Controls.Add(Me.BtnCance)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMainDiagnosis"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diagnosis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrDiagnosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents TxtCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCance As System.Windows.Forms.Button
    Friend WithEvents ErrDiagnosis As System.Windows.Forms.ErrorProvider
    Friend WithEvents ChTypeOther As System.Windows.Forms.CheckBox
End Class
