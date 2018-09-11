<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRenterVAAfterSurgery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRenterVAAfterSurgery))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblConsellingNo = New System.Windows.Forms.Label
        Me.lblDateConselling = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupVASurgeon = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnNewVARefrac = New System.Windows.Forms.Button
        Me.CboVAPH = New System.Windows.Forms.ComboBox
        Me.CboVAPlain = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CboSurgeonOnEye = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CboDrSurgeon = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrVASurgery = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupVASurgeon.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrVASurgery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblConsellingNo)
        Me.GroupBox2.Controls.Add(Me.lblDateConselling)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 55)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conselling info"
        '
        'lblConsellingNo
        '
        Me.lblConsellingNo.AutoSize = True
        Me.lblConsellingNo.Location = New System.Drawing.Point(203, 22)
        Me.lblConsellingNo.Name = "lblConsellingNo"
        Me.lblConsellingNo.Size = New System.Drawing.Size(13, 13)
        Me.lblConsellingNo.TabIndex = 13
        Me.lblConsellingNo.Text = "0"
        Me.lblConsellingNo.Visible = False
        '
        'lblDateConselling
        '
        Me.lblDateConselling.AutoSize = True
        Me.lblDateConselling.Location = New System.Drawing.Point(101, 22)
        Me.lblDateConselling.Name = "lblDateConselling"
        Me.lblDateConselling.Size = New System.Drawing.Size(13, 13)
        Me.lblDateConselling.TabIndex = 12
        Me.lblDateConselling.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Date Conselling:"
        '
        'GroupVASurgeon
        '
        Me.GroupVASurgeon.Controls.Add(Me.GroupBox3)
        Me.GroupVASurgeon.Controls.Add(Me.CboSurgeonOnEye)
        Me.GroupVASurgeon.Controls.Add(Me.Label7)
        Me.GroupVASurgeon.Controls.Add(Me.CboDrSurgeon)
        Me.GroupVASurgeon.Controls.Add(Me.Label6)
        Me.GroupVASurgeon.Location = New System.Drawing.Point(6, 70)
        Me.GroupVASurgeon.Name = "GroupVASurgeon"
        Me.GroupVASurgeon.Size = New System.Drawing.Size(408, 172)
        Me.GroupVASurgeon.TabIndex = 15
        Me.GroupVASurgeon.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnNewVARefrac)
        Me.GroupBox3.Controls.Add(Me.CboVAPH)
        Me.GroupBox3.Controls.Add(Me.CboVAPlain)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 89)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "VA:"
        '
        'BtnNewVARefrac
        '
        Me.BtnNewVARefrac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewVARefrac.Location = New System.Drawing.Point(296, 52)
        Me.BtnNewVARefrac.Name = "BtnNewVARefrac"
        Me.BtnNewVARefrac.Size = New System.Drawing.Size(43, 27)
        Me.BtnNewVARefrac.TabIndex = 15
        Me.BtnNewVARefrac.Text = "..."
        Me.BtnNewVARefrac.UseVisualStyleBackColor = True
        '
        'CboVAPH
        '
        Me.CboVAPH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboVAPH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboVAPH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboVAPH.FormattingEnabled = True
        Me.CboVAPH.Location = New System.Drawing.Point(112, 51)
        Me.CboVAPH.Name = "CboVAPH"
        Me.CboVAPH.Size = New System.Drawing.Size(170, 28)
        Me.CboVAPH.TabIndex = 14
        '
        'CboVAPlain
        '
        Me.CboVAPlain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboVAPlain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboVAPlain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboVAPlain.FormattingEnabled = True
        Me.CboVAPlain.Location = New System.Drawing.Point(112, 17)
        Me.CboVAPlain.Name = "CboVAPlain"
        Me.CboVAPlain.Size = New System.Drawing.Size(170, 28)
        Me.CboVAPlain.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "i/c PH:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Plain:"
        '
        'CboSurgeonOnEye
        '
        Me.CboSurgeonOnEye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSurgeonOnEye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSurgeonOnEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSurgeonOnEye.FormattingEnabled = True
        Me.CboSurgeonOnEye.Items.AddRange(New Object() {"", "Right Eye", "Left Eye", "Both Eye"})
        Me.CboSurgeonOnEye.Location = New System.Drawing.Point(125, 48)
        Me.CboSurgeonOnEye.Name = "CboSurgeonOnEye"
        Me.CboSurgeonOnEye.Size = New System.Drawing.Size(272, 28)
        Me.CboSurgeonOnEye.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "On Eye:"
        '
        'CboDrSurgeon
        '
        Me.CboDrSurgeon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDrSurgeon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDrSurgeon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDrSurgeon.FormattingEnabled = True
        Me.CboDrSurgeon.Location = New System.Drawing.Point(125, 14)
        Me.CboDrSurgeon.Name = "CboDrSurgeon"
        Me.CboDrSurgeon.Size = New System.Drawing.Size(272, 28)
        Me.CboDrSurgeon.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "With Doctor Surgeon:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(258, 249)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 29)
        Me.BtnSave.TabIndex = 18
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(339, 248)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 29)
        Me.BtnCancel.TabIndex = 19
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrVASurgery
        '
        Me.ErrVASurgery.ContainerControl = Me
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(30, 257)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 20
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'FormRenterVAAfterSurgery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 284)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupVASurgeon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRenterVAAfterSurgery"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Renter VA After Surgery"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupVASurgeon.ResumeLayout(False)
        Me.GroupVASurgeon.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrVASurgery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblConsellingNo As System.Windows.Forms.Label
    Friend WithEvents lblDateConselling As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupVASurgeon As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNewVARefrac As System.Windows.Forms.Button
    Friend WithEvents CboVAPH As System.Windows.Forms.ComboBox
    Friend WithEvents CboVAPlain As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboSurgeonOnEye As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboDrSurgeon As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrVASurgery As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
End Class
