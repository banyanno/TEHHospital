<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDonation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewDonation))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtDonation = New System.Windows.Forms.TextBox
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrDonation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.ChIsActive = New System.Windows.Forms.CheckBox
        CType(Me.ErrDonation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Donation Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description:"
        '
        'TxtDonation
        '
        Me.TxtDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDonation.Location = New System.Drawing.Point(96, 19)
        Me.TxtDonation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDonation.Name = "TxtDonation"
        Me.TxtDonation.Size = New System.Drawing.Size(161, 24)
        Me.TxtDonation.TabIndex = 0
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(11, 63)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(246, 63)
        Me.TxtDescription.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(139, 132)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(56, 27)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(200, 132)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(56, 27)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrDonation
        '
        Me.ErrDonation.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(11, 138)
        Me.LblSaveOption.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'ChIsActive
        '
        Me.ChIsActive.AutoSize = True
        Me.ChIsActive.Location = New System.Drawing.Point(11, 137)
        Me.ChIsActive.Name = "ChIsActive"
        Me.ChIsActive.Size = New System.Drawing.Size(67, 17)
        Me.ChIsActive.TabIndex = 4
        Me.ChIsActive.Text = "Is Active"
        Me.ChIsActive.UseVisualStyleBackColor = True
        '
        'NewDonation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 164)
        Me.Controls.Add(Me.ChIsActive)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.TxtDonation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewDonation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donation"
        CType(Me.ErrDonation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDonation As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrDonation As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ChIsActive As System.Windows.Forms.CheckBox
End Class
