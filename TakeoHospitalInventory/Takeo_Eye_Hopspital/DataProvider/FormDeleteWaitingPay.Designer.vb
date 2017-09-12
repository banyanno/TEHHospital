<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeleteWaitingPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDeleteWaitingPay))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtCommand = New System.Windows.Forms.TextBox
        Me.ErrDelete = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCommand)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Command"
        '
        'TxtCommand
        '
        Me.TxtCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCommand.Location = New System.Drawing.Point(3, 16)
        Me.TxtCommand.Multiline = True
        Me.TxtCommand.Name = "TxtCommand"
        Me.TxtCommand.Size = New System.Drawing.Size(343, 133)
        Me.TxtCommand.TabIndex = 0
        '
        'ErrDelete
        '
        Me.ErrDelete.ContainerControl = Me
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(205, 204)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 30)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(286, 204)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 30)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaveOption.ForeColor = System.Drawing.Color.Blue
        Me.LblSaveOption.Location = New System.Drawing.Point(87, 11)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(57, 20)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Receipt No:"
        '
        'FormDeleteWaitingPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 240)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDeleteWaitingPay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrDelete As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtCommand As System.Windows.Forms.TextBox
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
