<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckItemFixAsset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCheckItemFixAsset))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtProductCode = New System.Windows.Forms.TextBox
        Me.TxtProductName = New System.Windows.Forms.TextBox
        Me.DateCheck = New System.Windows.Forms.DateTimePicker
        Me.btnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErrAssetCheck = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.LblFixAssetID = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.ErrAssetCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtNote)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtProductCode)
        Me.Panel1.Controls.Add(Me.TxtProductName)
        Me.Panel1.Controls.Add(Me.DateCheck)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 291)
        Me.Panel1.TabIndex = 1
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(13, 110)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(706, 167)
        Me.TxtNote.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Check:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Code:"
        '
        'TxtProductCode
        '
        Me.TxtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProductCode.Location = New System.Drawing.Point(493, 53)
        Me.TxtProductCode.Name = "TxtProductCode"
        Me.TxtProductCode.ReadOnly = True
        Me.TxtProductCode.Size = New System.Drawing.Size(226, 26)
        Me.TxtProductCode.TabIndex = 3
        '
        'TxtProductName
        '
        Me.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProductName.Location = New System.Drawing.Point(129, 53)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.ReadOnly = True
        Me.TxtProductName.Size = New System.Drawing.Size(226, 26)
        Me.TxtProductName.TabIndex = 2
        '
        'DateCheck
        '
        Me.DateCheck.Checked = False
        Me.DateCheck.CustomFormat = "dd - MM - yyyy"
        Me.DateCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCheck.Location = New System.Drawing.Point(129, 11)
        Me.DateCheck.Name = "DateCheck"
        Me.DateCheck.ShowCheckBox = True
        Me.DateCheck.Size = New System.Drawing.Size(226, 26)
        Me.DateCheck.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(658, 309)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 33)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(563, 309)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 33)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErrAssetCheck
        '
        Me.ErrAssetCheck.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(25, 320)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 5
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'LblFixAssetID
        '
        Me.LblFixAssetID.AutoSize = True
        Me.LblFixAssetID.Location = New System.Drawing.Point(74, 320)
        Me.LblFixAssetID.Name = "LblFixAssetID"
        Me.LblFixAssetID.Size = New System.Drawing.Size(13, 13)
        Me.LblFixAssetID.TabIndex = 6
        Me.LblFixAssetID.Text = "0"
        Me.LblFixAssetID.Visible = False
        '
        'FormCheckItemFixAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 347)
        Me.Controls.Add(Me.LblFixAssetID)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCheckItemFixAsset"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Check"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrAssetCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductName As System.Windows.Forms.TextBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateCheck As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrAssetCheck As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents LblFixAssetID As System.Windows.Forms.Label
End Class
