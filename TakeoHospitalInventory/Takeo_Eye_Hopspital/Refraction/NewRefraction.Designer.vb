<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRefraction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewRefraction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblSaveOption = New System.Windows.Forms.Label
        Me.RefrationDate = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPatientAddress = New System.Windows.Forms.TextBox
        Me.TxtPatientTel = New System.Windows.Forms.TextBox
        Me.TxtPatientAge = New System.Windows.Forms.TextBox
        Me.TxtPatientSex = New System.Windows.Forms.TextBox
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.BtnFindPatient = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ChIsOld = New System.Windows.Forms.CheckBox
        Me.BtnGlassesAxis = New System.Windows.Forms.Button
        Me.CboLAxis = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.CboRAxis = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.ChPrescription = New System.Windows.Forms.CheckBox
        Me.TxtRefractionNote = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnNewDiagnosis = New System.Windows.Forms.Button
        Me.BtnNewGlasses = New System.Windows.Forms.Button
        Me.CboRGlasses = New System.Windows.Forms.ComboBox
        Me.CboLGlasses = New System.Windows.Forms.ComboBox
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CboLVAReading = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.BtnVAReading = New System.Windows.Forms.Button
        Me.CboADD = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.BtnNewVARefrac = New System.Windows.Forms.Button
        Me.CboRVARefrac = New System.Windows.Forms.ComboBox
        Me.CboLVARefrac = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnNewVA = New System.Windows.Forms.Button
        Me.CboRVAOld = New System.Windows.Forms.ComboBox
        Me.CboLVAOld = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrRefraction = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrRefraction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSaveOption)
        Me.GroupBox1.Controls.Add(Me.RefrationDate)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtPatientAddress)
        Me.GroupBox1.Controls.Add(Me.TxtPatientTel)
        Me.GroupBox1.Controls.Add(Me.TxtPatientAge)
        Me.GroupBox1.Controls.Add(Me.TxtPatientSex)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.BtnFindPatient)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Info"
        '
        'lblSaveOption
        '
        Me.lblSaveOption.AutoSize = True
        Me.lblSaveOption.Location = New System.Drawing.Point(431, 27)
        Me.lblSaveOption.Name = "lblSaveOption"
        Me.lblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.lblSaveOption.TabIndex = 14
        Me.lblSaveOption.Text = "0"
        Me.lblSaveOption.Visible = False
        '
        'RefrationDate
        '
        Me.RefrationDate.Checked = False
        Me.RefrationDate.CustomFormat = "dd/MM/yyyy"
        Me.RefrationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RefrationDate.Location = New System.Drawing.Point(333, 111)
        Me.RefrationDate.Name = "RefrationDate"
        Me.RefrationDate.ShowCheckBox = True
        Me.RefrationDate.Size = New System.Drawing.Size(190, 26)
        Me.RefrationDate.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(333, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Refraction Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tel:"
        Me.Label5.Visible = False
        '
        'TxtPatientAddress
        '
        Me.TxtPatientAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientAddress.Location = New System.Drawing.Point(85, 111)
        Me.TxtPatientAddress.Name = "TxtPatientAddress"
        Me.TxtPatientAddress.ReadOnly = True
        Me.TxtPatientAddress.Size = New System.Drawing.Size(242, 26)
        Me.TxtPatientAddress.TabIndex = 6
        '
        'TxtPatientTel
        '
        Me.TxtPatientTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientTel.Location = New System.Drawing.Point(450, 54)
        Me.TxtPatientTel.Name = "TxtPatientTel"
        Me.TxtPatientTel.ReadOnly = True
        Me.TxtPatientTel.Size = New System.Drawing.Size(242, 26)
        Me.TxtPatientTel.TabIndex = 5
        Me.TxtPatientTel.Visible = False
        '
        'TxtPatientAge
        '
        Me.TxtPatientAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientAge.Location = New System.Drawing.Point(257, 78)
        Me.TxtPatientAge.Name = "TxtPatientAge"
        Me.TxtPatientAge.ReadOnly = True
        Me.TxtPatientAge.Size = New System.Drawing.Size(70, 26)
        Me.TxtPatientAge.TabIndex = 4
        '
        'TxtPatientSex
        '
        Me.TxtPatientSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientSex.Location = New System.Drawing.Point(85, 78)
        Me.TxtPatientSex.Name = "TxtPatientSex"
        Me.TxtPatientSex.ReadOnly = True
        Me.TxtPatientSex.Size = New System.Drawing.Size(77, 26)
        Me.TxtPatientSex.TabIndex = 3
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(85, 46)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.ReadOnly = True
        Me.TxtPatientName.Size = New System.Drawing.Size(242, 26)
        Me.TxtPatientName.TabIndex = 2
        '
        'BtnFindPatient
        '
        Me.BtnFindPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindPatient.Location = New System.Drawing.Point(333, 13)
        Me.BtnFindPatient.Name = "BtnFindPatient"
        Me.BtnFindPatient.Size = New System.Drawing.Size(52, 27)
        Me.BtnFindPatient.TabIndex = 1
        Me.BtnFindPatient.Text = "..."
        Me.BtnFindPatient.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(85, 13)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(242, 26)
        Me.TxtPatientNo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Patient Sex:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 157)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(567, 432)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ChIsOld)
        Me.TabPage2.Controls.Add(Me.BtnGlassesAxis)
        Me.TabPage2.Controls.Add(Me.CboLAxis)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.CboRAxis)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.ChPrescription)
        Me.TabPage2.Controls.Add(Me.TxtRefractionNote)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.BtnNewDiagnosis)
        Me.TabPage2.Controls.Add(Me.BtnNewGlasses)
        Me.TabPage2.Controls.Add(Me.CboRGlasses)
        Me.TabPage2.Controls.Add(Me.CboLGlasses)
        Me.TabPage2.Controls.Add(Me.CboDiagnosis)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(559, 406)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Refraction Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ChIsOld
        '
        Me.ChIsOld.AutoSize = True
        Me.ChIsOld.ForeColor = System.Drawing.Color.Red
        Me.ChIsOld.Location = New System.Drawing.Point(398, 72)
        Me.ChIsOld.Name = "ChIsOld"
        Me.ChIsOld.Size = New System.Drawing.Size(89, 17)
        Me.ChIsOld.TabIndex = 13
        Me.ChIsOld.Text = "Is Old Patient"
        Me.ChIsOld.UseVisualStyleBackColor = True
        '
        'BtnGlassesAxis
        '
        Me.BtnGlassesAxis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGlassesAxis.Location = New System.Drawing.Point(490, 136)
        Me.BtnGlassesAxis.Name = "BtnGlassesAxis"
        Me.BtnGlassesAxis.Size = New System.Drawing.Size(43, 27)
        Me.BtnGlassesAxis.TabIndex = 8
        Me.BtnGlassesAxis.Text = "..."
        Me.BtnGlassesAxis.UseVisualStyleBackColor = True
        '
        'CboLAxis
        '
        Me.CboLAxis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboLAxis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboLAxis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLAxis.FormattingEnabled = True
        Me.CboLAxis.Location = New System.Drawing.Point(306, 135)
        Me.CboLAxis.Name = "CboLAxis"
        Me.CboLAxis.Size = New System.Drawing.Size(167, 28)
        Me.CboLAxis.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(242, 150)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "L Axis:"
        '
        'CboRAxis
        '
        Me.CboRAxis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboRAxis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRAxis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRAxis.FormattingEnabled = True
        Me.CboRAxis.Location = New System.Drawing.Point(74, 135)
        Me.CboRAxis.Name = "CboRAxis"
        Me.CboRAxis.Size = New System.Drawing.Size(166, 28)
        Me.CboRAxis.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "R Axis:"
        '
        'ChPrescription
        '
        Me.ChPrescription.AutoSize = True
        Me.ChPrescription.Location = New System.Drawing.Point(308, 72)
        Me.ChPrescription.Name = "ChPrescription"
        Me.ChPrescription.Size = New System.Drawing.Size(64, 17)
        Me.ChPrescription.TabIndex = 3
        Me.ChPrescription.Text = "Improve"
        Me.ChPrescription.UseVisualStyleBackColor = True
        '
        'TxtRefractionNote
        '
        Me.TxtRefractionNote.Location = New System.Drawing.Point(7, 343)
        Me.TxtRefractionNote.Multiline = True
        Me.TxtRefractionNote.Name = "TxtRefractionNote"
        Me.TxtRefractionNote.Size = New System.Drawing.Size(546, 54)
        Me.TxtRefractionNote.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 327)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Commend:"
        '
        'BtnNewDiagnosis
        '
        Me.BtnNewDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewDiagnosis.Location = New System.Drawing.Point(250, 66)
        Me.BtnNewDiagnosis.Name = "BtnNewDiagnosis"
        Me.BtnNewDiagnosis.Size = New System.Drawing.Size(43, 27)
        Me.BtnNewDiagnosis.TabIndex = 2
        Me.BtnNewDiagnosis.Text = "..."
        Me.BtnNewDiagnosis.UseVisualStyleBackColor = True
        '
        'BtnNewGlasses
        '
        Me.BtnNewGlasses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewGlasses.Location = New System.Drawing.Point(490, 99)
        Me.BtnNewGlasses.Name = "BtnNewGlasses"
        Me.BtnNewGlasses.Size = New System.Drawing.Size(43, 27)
        Me.BtnNewGlasses.TabIndex = 5
        Me.BtnNewGlasses.Text = "..."
        Me.BtnNewGlasses.UseVisualStyleBackColor = True
        '
        'CboRGlasses
        '
        Me.CboRGlasses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboRGlasses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRGlasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRGlasses.FormattingEnabled = True
        Me.CboRGlasses.Location = New System.Drawing.Point(73, 100)
        Me.CboRGlasses.Name = "CboRGlasses"
        Me.CboRGlasses.Size = New System.Drawing.Size(167, 28)
        Me.CboRGlasses.TabIndex = 4
        '
        'CboLGlasses
        '
        Me.CboLGlasses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboLGlasses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboLGlasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLGlasses.FormattingEnabled = True
        Me.CboLGlasses.Location = New System.Drawing.Point(306, 102)
        Me.CboLGlasses.Name = "CboLGlasses"
        Me.CboLGlasses.Size = New System.Drawing.Size(167, 28)
        Me.CboLGlasses.TabIndex = 5
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(73, 66)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(167, 28)
        Me.CboDiagnosis.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.CboLVAReading)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.BtnVAReading)
        Me.GroupBox3.Controls.Add(Me.CboADD)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.BtnNewVARefrac)
        Me.GroupBox3.Controls.Add(Me.CboRVARefrac)
        Me.GroupBox3.Controls.Add(Me.CboLVARefrac)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(547, 144)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "VA on Refraction:"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(243, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CboLVAReading
        '
        Me.CboLVAReading.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboLVAReading.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboLVAReading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLVAReading.FormattingEnabled = True
        Me.CboLVAReading.Location = New System.Drawing.Point(296, 99)
        Me.CboLVAReading.Name = "CboLVAReading"
        Me.CboLVAReading.Size = New System.Drawing.Size(170, 28)
        Me.CboLVAReading.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(295, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "VA Reading"
        '
        'BtnVAReading
        '
        Me.BtnVAReading.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVAReading.Location = New System.Drawing.Point(486, 100)
        Me.BtnVAReading.Name = "BtnVAReading"
        Me.BtnVAReading.Size = New System.Drawing.Size(43, 27)
        Me.BtnVAReading.TabIndex = 9
        Me.BtnVAReading.Text = "..."
        Me.BtnVAReading.UseVisualStyleBackColor = True
        '
        'CboADD
        '
        Me.CboADD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboADD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboADD.FormattingEnabled = True
        Me.CboADD.Location = New System.Drawing.Point(64, 99)
        Me.CboADD.Name = "CboADD"
        Me.CboADD.Size = New System.Drawing.Size(170, 28)
        Me.CboADD.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(63, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "ADD"
        '
        'BtnNewVARefrac
        '
        Me.BtnNewVARefrac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewVARefrac.Location = New System.Drawing.Point(486, 40)
        Me.BtnNewVARefrac.Name = "BtnNewVARefrac"
        Me.BtnNewVARefrac.Size = New System.Drawing.Size(43, 27)
        Me.BtnNewVARefrac.TabIndex = 2
        Me.BtnNewVARefrac.Text = "..."
        Me.BtnNewVARefrac.UseVisualStyleBackColor = True
        '
        'CboRVARefrac
        '
        Me.CboRVARefrac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboRVARefrac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRVARefrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRVARefrac.FormattingEnabled = True
        Me.CboRVARefrac.Location = New System.Drawing.Point(67, 39)
        Me.CboRVARefrac.Name = "CboRVARefrac"
        Me.CboRVARefrac.Size = New System.Drawing.Size(167, 28)
        Me.CboRVARefrac.TabIndex = 0
        '
        'CboLVARefrac
        '
        Me.CboLVARefrac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboLVARefrac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboLVARefrac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLVARefrac.FormattingEnabled = True
        Me.CboLVARefrac.Location = New System.Drawing.Point(299, 40)
        Me.CboLVARefrac.Name = "CboLVARefrac"
        Me.CboLVARefrac.Size = New System.Drawing.Size(167, 28)
        Me.CboLVARefrac.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(64, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "R VA:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(296, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "L VA:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "R Glasses:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(244, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "L Glasses:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Diagnosis:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNewVA)
        Me.GroupBox2.Controls.Add(Me.CboRVAOld)
        Me.GroupBox2.Controls.Add(Me.CboLVAOld)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 56)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Old VA"
        '
        'BtnNewVA
        '
        Me.BtnNewVA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewVA.Location = New System.Drawing.Point(484, 18)
        Me.BtnNewVA.Name = "BtnNewVA"
        Me.BtnNewVA.Size = New System.Drawing.Size(43, 27)
        Me.BtnNewVA.TabIndex = 2
        Me.BtnNewVA.Text = "..."
        Me.BtnNewVA.UseVisualStyleBackColor = True
        '
        'CboRVAOld
        '
        Me.CboRVAOld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboRVAOld.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboRVAOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRVAOld.FormattingEnabled = True
        Me.CboRVAOld.Location = New System.Drawing.Point(67, 17)
        Me.CboRVAOld.Name = "CboRVAOld"
        Me.CboRVAOld.Size = New System.Drawing.Size(167, 28)
        Me.CboRVAOld.TabIndex = 0
        '
        'CboLVAOld
        '
        Me.CboLVAOld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboLVAOld.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboLVAOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLVAOld.FormattingEnabled = True
        Me.CboLVAOld.Location = New System.Drawing.Point(302, 17)
        Me.CboLVAOld.Name = "CboLVAOld"
        Me.CboLVAOld.Size = New System.Drawing.Size(167, 28)
        Me.CboLVAOld.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "R VA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(263, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "L VA:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(414, 593)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 30)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(495, 593)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 30)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrRefraction
        '
        Me.ErrRefraction.ContainerControl = Me
        '
        'NewRefraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 626)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewRefraction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Refraction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrRefraction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnFindPatient As System.Windows.Forms.Button
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CboRGlasses As System.Windows.Forms.ComboBox
    Friend WithEvents CboLGlasses As System.Windows.Forms.ComboBox
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents CboRVARefrac As System.Windows.Forms.ComboBox
    Friend WithEvents CboLVARefrac As System.Windows.Forms.ComboBox
    Friend WithEvents CboRVAOld As System.Windows.Forms.ComboBox
    Friend WithEvents CboLVAOld As System.Windows.Forms.ComboBox
    Friend WithEvents BtnNewDiagnosis As System.Windows.Forms.Button
    Friend WithEvents BtnNewGlasses As System.Windows.Forms.Button
    Friend WithEvents BtnNewVARefrac As System.Windows.Forms.Button
    Friend WithEvents BtnNewVA As System.Windows.Forms.Button
    Friend WithEvents TxtRefractionNote As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RefrationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrRefraction As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ChPrescription As System.Windows.Forms.CheckBox
    Friend WithEvents CboADD As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CboLAxis As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CboRAxis As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BtnGlassesAxis As System.Windows.Forms.Button
    Friend WithEvents BtnVAReading As System.Windows.Forms.Button
    Friend WithEvents CboLVAReading As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ChIsOld As System.Windows.Forms.CheckBox
End Class
