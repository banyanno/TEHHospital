<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMSurgeryType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMSurgeryType))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtSurgeriesType = New System.Windows.Forms.TextBox
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChTypeOther = New System.Windows.Forms.CheckBox
        Me.ErrSurgeries = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtSurgeryPrice = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrSurgeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Surgeries Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description:"
        '
        'TxtSurgeriesType
        '
        Me.TxtSurgeriesType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurgeriesType.Location = New System.Drawing.Point(124, 16)
        Me.TxtSurgeriesType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSurgeriesType.Name = "TxtSurgeriesType"
        Me.TxtSurgeriesType.Size = New System.Drawing.Size(248, 30)
        Me.TxtSurgeriesType.TabIndex = 1
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(8, 103)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(472, 69)
        Me.TxtDescription.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(147, 190)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 37)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(255, 190)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 37)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(26, 204)
        Me.LblSaveOption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 17)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtSurgeryPrice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ChTypeOther)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSurgeriesType)
        Me.GroupBox1.Controls.Add(Me.TxtDescription)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(491, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ChTypeOther
        '
        Me.ChTypeOther.AutoSize = True
        Me.ChTypeOther.Location = New System.Drawing.Point(380, 28)
        Me.ChTypeOther.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChTypeOther.Name = "ChTypeOther"
        Me.ChTypeOther.Size = New System.Drawing.Size(102, 21)
        Me.ChTypeOther.TabIndex = 2
        Me.ChTypeOther.Text = "Type &Other"
        Me.ChTypeOther.UseVisualStyleBackColor = True
        Me.ChTypeOther.Visible = False
        '
        'ErrSurgeries
        '
        Me.ErrSurgeries.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Surgeries Price:"
        '
        'TxtSurgeryPrice
        '
        Me.TxtSurgeryPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurgeryPrice.Location = New System.Drawing.Point(122, 56)
        Me.TxtSurgeryPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSurgeryPrice.Name = "TxtSurgeryPrice"
        Me.TxtSurgeryPrice.Size = New System.Drawing.Size(248, 30)
        Me.TxtSurgeryPrice.TabIndex = 2
        Me.TxtSurgeryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(368, 48)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 42)
        Me.Label22.TabIndex = 146
        Me.Label22.Text = "erol"
        '
        'FRMSurgeryType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(501, 231)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMSurgeryType"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surgeries"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrSurgeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSurgeriesType As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrSurgeries As System.Windows.Forms.ErrorProvider
    Friend WithEvents ChTypeOther As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSurgeryPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
