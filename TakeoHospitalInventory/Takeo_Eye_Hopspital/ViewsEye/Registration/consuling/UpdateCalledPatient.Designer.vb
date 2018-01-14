<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateCalled
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateCalled))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnSetPara = New System.Windows.Forms.Button
        Me.TxtCallNoted = New System.Windows.Forms.TextBox
        Me.DateCalled = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblIsUpdate = New System.Windows.Forms.Label
        Me.AutocompleteMenu1 = New AutocompleteMenuNS.AutocompleteMenu
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSetPara)
        Me.GroupBox1.Controls.Add(Me.TxtCallNoted)
        Me.GroupBox1.Controls.Add(Me.DateCalled)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Info"
        '
        'BtnSetPara
        '
        Me.BtnSetPara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSetPara.Location = New System.Drawing.Point(403, 158)
        Me.BtnSetPara.Name = "BtnSetPara"
        Me.BtnSetPara.Size = New System.Drawing.Size(70, 38)
        Me.BtnSetPara.TabIndex = 8
        Me.BtnSetPara.Text = "Set Parameter"
        Me.BtnSetPara.UseVisualStyleBackColor = True
        '
        'TxtCallNoted
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtCallNoted, Me.AutocompleteMenu1)
        Me.TxtCallNoted.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtCallNoted.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.TxtCallNoted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCallNoted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCallNoted.Location = New System.Drawing.Point(84, 121)
        Me.TxtCallNoted.Multiline = True
        Me.TxtCallNoted.Name = "TxtCallNoted"
        Me.TxtCallNoted.Size = New System.Drawing.Size(316, 75)
        Me.TxtCallNoted.TabIndex = 7
        '
        'DateCalled
        '
        Me.DateCalled.CustomFormat = "dd/MM/yyyy"
        Me.DateCalled.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCalled.Location = New System.Drawing.Point(84, 91)
        Me.DateCalled.Name = "DateCalled"
        Me.DateCalled.Size = New System.Drawing.Size(160, 20)
        Me.DateCalled.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Call Noted:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date Call:"
        '
        'TxtPatientName
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtPatientName, Nothing)
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(84, 51)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(316, 31)
        Me.TxtPatientName.TabIndex = 3
        '
        'TxtPatientNo
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtPatientNo, Nothing)
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(84, 19)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(316, 26)
        Me.TxtPatientNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
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
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(328, 208)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 27)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(409, 208)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 27)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LblIsUpdate
        '
        Me.LblIsUpdate.AutoSize = True
        Me.LblIsUpdate.Location = New System.Drawing.Point(25, 193)
        Me.LblIsUpdate.Name = "LblIsUpdate"
        Me.LblIsUpdate.Size = New System.Drawing.Size(13, 13)
        Me.LblIsUpdate.TabIndex = 3
        Me.LblIsUpdate.Text = "0"
        Me.LblIsUpdate.Visible = False
        '
        'AutocompleteMenu1
        '
        Me.AutocompleteMenu1.AppearInterval = 300
        Me.AutocompleteMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AutocompleteMenu1.ImageList = Nothing
        Me.AutocompleteMenu1.Items = New String(-1) {}
        Me.AutocompleteMenu1.MinFragmentLength = 1
        Me.AutocompleteMenu1.TargetControlWrapper = Nothing
        Me.AutocompleteMenu1.ToolTipDuration = 3000
        '
        'FormUpdateCalled
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 237)
        Me.Controls.Add(Me.LblIsUpdate)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdateCalled"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Called"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCallNoted As System.Windows.Forms.TextBox
    Friend WithEvents DateCalled As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblIsUpdate As System.Windows.Forms.Label
    Friend WithEvents BtnSetPara As System.Windows.Forms.Button
    Friend WithEvents AutocompleteMenu1 As AutocompleteMenuNS.AutocompleteMenu
End Class
