<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteNoteNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteNoteNew))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrDelete = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNote)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Noted"
        '
        'TxtNote
        '
        Me.TxtNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNote.Location = New System.Drawing.Point(3, 22)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(403, 170)
        Me.TxtNote.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(234, 202)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 33)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(325, 202)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(91, 33)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrDelete
        '
        Me.ErrDelete.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(19, 211)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 3
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'DeleteNoteNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 239)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteNoteNew"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Note"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents ErrDelete As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
End Class
