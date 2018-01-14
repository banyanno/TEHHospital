<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewAppointment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnSetNewApp = New System.Windows.Forms.Button
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.LblSave = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupDiagnosis = New System.Windows.Forms.GroupBox
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CboEye = New System.Windows.Forms.ComboBox
        Me.DateApp = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CboSecondSurgery = New System.Windows.Forms.ComboBox
        Me.CboSecondDiagnosis = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.TxtPatientSex = New System.Windows.Forms.TextBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrAppointment = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AutocompleteMenu1 = New AutocompleteMenuNS.AutocompleteMenu
        Me.GroupBox1.SuspendLayout()
        Me.GroupDiagnosis.SuspendLayout()
        CType(Me.ErrAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSetNewApp)
        Me.GroupBox1.Controls.Add(Me.TxtTel)
        Me.GroupBox1.Controls.Add(Me.LblSave)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupDiagnosis)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.TxtNote)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.TxtPatientSex)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 408)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnSetNewApp
        '
        Me.BtnSetNewApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSetNewApp.Location = New System.Drawing.Point(467, 367)
        Me.BtnSetNewApp.Name = "BtnSetNewApp"
        Me.BtnSetNewApp.Size = New System.Drawing.Size(79, 34)
        Me.BtnSetNewApp.TabIndex = 17
        Me.BtnSetNewApp.Text = "Set Parameter"
        Me.BtnSetNewApp.UseVisualStyleBackColor = True
        '
        'TxtTel
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtTel, Nothing)
        Me.TxtTel.Enabled = False
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(87, 95)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(197, 26)
        Me.TxtTel.TabIndex = 16
        '
        'LblSave
        '
        Me.LblSave.AutoSize = True
        Me.LblSave.Location = New System.Drawing.Point(357, 16)
        Me.LblSave.Name = "LblSave"
        Me.LblSave.Size = New System.Drawing.Size(13, 13)
        Me.LblSave.TabIndex = 3
        Me.LblSave.Text = "0"
        Me.LblSave.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tel:"
        '
        'GroupDiagnosis
        '
        Me.GroupDiagnosis.Controls.Add(Me.CboDoctor)
        Me.GroupDiagnosis.Controls.Add(Me.Label8)
        Me.GroupDiagnosis.Controls.Add(Me.CboEye)
        Me.GroupDiagnosis.Controls.Add(Me.DateApp)
        Me.GroupDiagnosis.Controls.Add(Me.Label16)
        Me.GroupDiagnosis.Controls.Add(Me.Label7)
        Me.GroupDiagnosis.Controls.Add(Me.CboSecondSurgery)
        Me.GroupDiagnosis.Controls.Add(Me.CboSecondDiagnosis)
        Me.GroupDiagnosis.Controls.Add(Me.Label14)
        Me.GroupDiagnosis.Controls.Add(Me.Label15)
        Me.GroupDiagnosis.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDiagnosis.Location = New System.Drawing.Point(10, 123)
        Me.GroupDiagnosis.Name = "GroupDiagnosis"
        Me.GroupDiagnosis.Size = New System.Drawing.Size(535, 178)
        Me.GroupDiagnosis.TabIndex = 15
        Me.GroupDiagnosis.TabStop = False
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(327, 59)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(198, 28)
        Me.CboDoctor.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(386, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 28)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "With Dr."
        '
        'CboEye
        '
        Me.CboEye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboEye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEye.FormattingEnabled = True
        Me.CboEye.Items.AddRange(New Object() {"Left Eye", "Right Eye", "Both Eye"})
        Me.CboEye.Location = New System.Drawing.Point(87, 134)
        Me.CboEye.Name = "CboEye"
        Me.CboEye.Size = New System.Drawing.Size(225, 28)
        Me.CboEye.TabIndex = 2
        '
        'DateApp
        '
        Me.DateApp.Checked = False
        Me.DateApp.CustomFormat = "dd/MM/yyyy"
        Me.DateApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateApp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateApp.Location = New System.Drawing.Point(149, 24)
        Me.DateApp.Name = "DateApp"
        Me.DateApp.ShowCheckBox = True
        Me.DateApp.Size = New System.Drawing.Size(163, 26)
        Me.DateApp.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 28)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "On Eye:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 30)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Date Appointment:"
        '
        'CboSecondSurgery
        '
        Me.CboSecondSurgery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSecondSurgery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSecondSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSecondSurgery.FormattingEnabled = True
        Me.CboSecondSurgery.Location = New System.Drawing.Point(87, 96)
        Me.CboSecondSurgery.Name = "CboSecondSurgery"
        Me.CboSecondSurgery.Size = New System.Drawing.Size(225, 28)
        Me.CboSecondSurgery.TabIndex = 1
        '
        'CboSecondDiagnosis
        '
        Me.CboSecondDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSecondDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSecondDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSecondDiagnosis.FormattingEnabled = True
        Me.CboSecondDiagnosis.Location = New System.Drawing.Point(87, 59)
        Me.CboSecondDiagnosis.Name = "CboSecondDiagnosis"
        Me.CboSecondDiagnosis.Size = New System.Drawing.Size(225, 28)
        Me.CboSecondDiagnosis.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 28)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Surgery:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 28)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Diagnosis:"
        '
        'BtnFind
        '
        Me.BtnFind.Location = New System.Drawing.Point(295, 13)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(31, 27)
        Me.BtnFind.TabIndex = 12
        Me.BtnFind.Text = "..."
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtNote
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtNote, Me.AutocompleteMenu1)
        Me.TxtNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.TxtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNote.Location = New System.Drawing.Point(11, 307)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(453, 93)
        Me.TxtNote.TabIndex = 11
        '
        'TxtAge
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtAge, Nothing)
        Me.TxtAge.Enabled = False
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(421, 55)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(41, 26)
        Me.TxtAge.TabIndex = 9
        Me.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPatientSex
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtPatientSex, Nothing)
        Me.TxtPatientSex.Enabled = False
        Me.TxtPatientSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientSex.Location = New System.Drawing.Point(329, 55)
        Me.TxtPatientSex.Name = "TxtPatientSex"
        Me.TxtPatientSex.Size = New System.Drawing.Size(41, 26)
        Me.TxtPatientSex.TabIndex = 8
        Me.TxtPatientSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPatientName
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtPatientName, Nothing)
        Me.TxtPatientName.Enabled = False
        Me.TxtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(87, 50)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(197, 34)
        Me.TxtPatientName.TabIndex = 7
        '
        'TxtPatientNo
        '
        Me.AutocompleteMenu1.SetAutocompleteMenu(Me.TxtPatientNo, Nothing)
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(86, 14)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(198, 26)
        Me.TxtPatientNo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Note:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sex:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(397, 417)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 28)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(481, 417)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 28)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrAppointment
        '
        Me.ErrAppointment.ContainerControl = Me
        '
        'AutocompleteMenu1
        '
        Me.AutocompleteMenu1.AppearInterval = 100
        Me.AutocompleteMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.AutocompleteMenu1.ImageList = Nothing
        Me.AutocompleteMenu1.Items = New String(-1) {}
        Me.AutocompleteMenu1.LeftPadding = 10
        Me.AutocompleteMenu1.MaximumSize = New System.Drawing.Size(250, 300)
        Me.AutocompleteMenu1.MinFragmentLength = 1
        Me.AutocompleteMenu1.TargetControlWrapper = Nothing
        Me.AutocompleteMenu1.ToolTipDuration = 3000
        '
        'NewAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 450)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewAppointment"
        Me.ShowInTaskbar = False
        Me.Text = "Appointment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupDiagnosis.ResumeLayout(False)
        Me.GroupDiagnosis.PerformLayout()
        CType(Me.ErrAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents DateApp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblSave As System.Windows.Forms.Label
    Friend WithEvents ErrAppointment As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupDiagnosis As System.Windows.Forms.GroupBox
    Friend WithEvents CboEye As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CboSecondSurgery As System.Windows.Forms.ComboBox
    Friend WithEvents CboSecondDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnSetNewApp As System.Windows.Forms.Button
    Friend WithEvents AutocompleteMenu1 As AutocompleteMenuNS.AutocompleteMenu
End Class
