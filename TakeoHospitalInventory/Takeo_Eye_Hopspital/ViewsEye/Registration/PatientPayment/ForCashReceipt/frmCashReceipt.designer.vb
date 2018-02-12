<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashReceipt))
        Me.lblFees = New System.Windows.Forms.Label
        Me.txtReturnD = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdAddRate = New System.Windows.Forms.Button
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.lblRielDolar = New System.Windows.Forms.Label
        Me.rdGlassD = New System.Windows.Forms.RadioButton
        Me.rdGlassR = New System.Windows.Forms.RadioButton
        Me.rdMedicineD = New System.Windows.Forms.RadioButton
        Me.rdMedicineR = New System.Windows.Forms.RadioButton
        Me.txtHN = New System.Windows.Forms.TextBox
        Me.txtReceiptNumber = New System.Windows.Forms.TextBox
        Me.txtReturnR = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtpDateIn = New System.Windows.Forms.DateTimePicker
        Me.chkDollar = New System.Windows.Forms.CheckBox
        Me.chkRiel = New System.Windows.Forms.CheckBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtGlass = New System.Windows.Forms.TextBox
        Me.txtMedicine = New System.Windows.Forms.TextBox
        Me.txtAmountFigureD = New System.Windows.Forms.TextBox
        Me.txtAmountFigureR = New System.Windows.Forms.TextBox
        Me.txtAmountWord = New System.Windows.Forms.TextBox
        Me.txtPatient = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCashier = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkSocialFee = New System.Windows.Forms.CheckBox
        Me.txtCashReceiptNumber = New System.Windows.Forms.TextBox
        Me.lblReceiptToPrintID = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdCashierSave = New System.Windows.Forms.Button
        Me.lblCashierLogin = New System.Windows.Forms.Label
        Me.ChPrintPreveiw = New System.Windows.Forms.CheckBox
        Me.cmdFindHN = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Location = New System.Drawing.Point(834, 27)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(66, 20)
        Me.lblFees.TabIndex = 139
        Me.lblFees.Text = "Label15"
        Me.lblFees.Visible = False
        '
        'txtReturnD
        '
        Me.txtReturnD.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnD.Location = New System.Drawing.Point(61, 87)
        Me.txtReturnD.Name = "txtReturnD"
        Me.txtReturnD.Size = New System.Drawing.Size(231, 53)
        Me.txtReturnD.TabIndex = 1
        Me.txtReturnD.Text = "0"
        Me.txtReturnD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdAddRate)
        Me.GroupBox2.Controls.Add(Me.txtRate)
        Me.GroupBox2.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(936, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 89)
        Me.GroupBox2.TabIndex = 138
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GRtabþÚrR)ak;"
        '
        'cmdAddRate
        '
        Me.cmdAddRate.Enabled = False
        Me.cmdAddRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.cmdAddRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAddRate.Location = New System.Drawing.Point(169, 37)
        Me.cmdAddRate.Name = "cmdAddRate"
        Me.cmdAddRate.Size = New System.Drawing.Size(44, 45)
        Me.cmdAddRate.TabIndex = 1
        Me.cmdAddRate.Text = "..."
        Me.cmdAddRate.UseVisualStyleBackColor = True
        Me.cmdAddRate.Visible = False
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.ForeColor = System.Drawing.Color.Navy
        Me.txtRate.Location = New System.Drawing.Point(12, 38)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(151, 44)
        Me.txtRate.TabIndex = 0
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRielDolar
        '
        Me.lblRielDolar.AutoSize = True
        Me.lblRielDolar.BackColor = System.Drawing.Color.Transparent
        Me.lblRielDolar.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRielDolar.Location = New System.Drawing.Point(392, 409)
        Me.lblRielDolar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRielDolar.Name = "lblRielDolar"
        Me.lblRielDolar.Size = New System.Drawing.Size(74, 31)
        Me.lblRielDolar.TabIndex = 131
        Me.lblRielDolar.Text = "erol duløar"
        '
        'rdGlassD
        '
        Me.rdGlassD.AutoSize = True
        Me.rdGlassD.BackColor = System.Drawing.Color.Transparent
        Me.rdGlassD.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGlassD.Location = New System.Drawing.Point(398, 365)
        Me.rdGlassD.Name = "rdGlassD"
        Me.rdGlassD.Size = New System.Drawing.Size(57, 31)
        Me.rdGlassD.TabIndex = 15
        Me.rdGlassD.TabStop = True
        Me.rdGlassD.Text = "duløar"
        Me.rdGlassD.UseVisualStyleBackColor = False
        '
        'rdGlassR
        '
        Me.rdGlassR.AutoSize = True
        Me.rdGlassR.BackColor = System.Drawing.Color.Transparent
        Me.rdGlassR.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGlassR.Location = New System.Drawing.Point(398, 339)
        Me.rdGlassR.Name = "rdGlassR"
        Me.rdGlassR.Size = New System.Drawing.Size(55, 31)
        Me.rdGlassR.TabIndex = 14
        Me.rdGlassR.TabStop = True
        Me.rdGlassR.Text = "erol"
        Me.rdGlassR.UseVisualStyleBackColor = False
        '
        'rdMedicineD
        '
        Me.rdMedicineD.AutoSize = True
        Me.rdMedicineD.BackColor = System.Drawing.Color.Transparent
        Me.rdMedicineD.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdMedicineD.Location = New System.Drawing.Point(398, 308)
        Me.rdMedicineD.Name = "rdMedicineD"
        Me.rdMedicineD.Size = New System.Drawing.Size(57, 31)
        Me.rdMedicineD.TabIndex = 12
        Me.rdMedicineD.TabStop = True
        Me.rdMedicineD.Text = "duløar"
        Me.rdMedicineD.UseVisualStyleBackColor = False
        '
        'rdMedicineR
        '
        Me.rdMedicineR.AutoSize = True
        Me.rdMedicineR.BackColor = System.Drawing.Color.Transparent
        Me.rdMedicineR.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdMedicineR.Location = New System.Drawing.Point(398, 282)
        Me.rdMedicineR.Name = "rdMedicineR"
        Me.rdMedicineR.Size = New System.Drawing.Size(55, 31)
        Me.rdMedicineR.TabIndex = 11
        Me.rdMedicineR.TabStop = True
        Me.rdMedicineR.Text = "erol"
        Me.rdMedicineR.UseVisualStyleBackColor = False
        '
        'txtHN
        '
        Me.txtHN.BackColor = System.Drawing.SystemColors.Control
        Me.txtHN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHN.Location = New System.Drawing.Point(90, 87)
        Me.txtHN.Name = "txtHN"
        Me.txtHN.Size = New System.Drawing.Size(400, 31)
        Me.txtHN.TabIndex = 2
        '
        'txtReceiptNumber
        '
        Me.txtReceiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNumber.Location = New System.Drawing.Point(3, 6)
        Me.txtReceiptNumber.Name = "txtReceiptNumber"
        Me.txtReceiptNumber.ReadOnly = True
        Me.txtReceiptNumber.Size = New System.Drawing.Size(222, 31)
        Me.txtReceiptNumber.TabIndex = 104
        Me.txtReceiptNumber.Visible = False
        '
        'txtReturnR
        '
        Me.txtReturnR.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnR.Location = New System.Drawing.Point(61, 30)
        Me.txtReturnR.Name = "txtReturnR"
        Me.txtReturnR.Size = New System.Drawing.Size(231, 53)
        Me.txtReturnR.TabIndex = 0
        Me.txtReturnR.Text = "0"
        Me.txtReturnR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtReturnD)
        Me.GroupBox1.Controls.Add(Me.txtReturnR)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(514, 287)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 153)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "R)ak;Gab;"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 96)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 33)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "duløar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 40)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 33)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "erol"
        '
        'dtpDateIn
        '
        Me.dtpDateIn.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateIn.Location = New System.Drawing.Point(665, 56)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.ShowCheckBox = True
        Me.dtpDateIn.Size = New System.Drawing.Size(176, 29)
        Me.dtpDateIn.TabIndex = 3
        '
        'chkDollar
        '
        Me.chkDollar.AutoSize = True
        Me.chkDollar.BackColor = System.Drawing.Color.Transparent
        Me.chkDollar.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDollar.Location = New System.Drawing.Point(755, 18)
        Me.chkDollar.Name = "chkDollar"
        Me.chkDollar.Size = New System.Drawing.Size(62, 35)
        Me.chkDollar.TabIndex = 9
        Me.chkDollar.Text = "duløar"
        Me.chkDollar.UseVisualStyleBackColor = False
        '
        'chkRiel
        '
        Me.chkRiel.AutoSize = True
        Me.chkRiel.BackColor = System.Drawing.Color.Transparent
        Me.chkRiel.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRiel.Location = New System.Drawing.Point(686, 18)
        Me.chkRiel.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.chkRiel.Name = "chkRiel"
        Me.chkRiel.Size = New System.Drawing.Size(60, 35)
        Me.chkRiel.TabIndex = 8
        Me.chkRiel.Text = "erol"
        Me.chkRiel.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotal.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(142, 396)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(247, 57)
        Me.txtTotal.TabIndex = 16
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGlass
        '
        Me.txtGlass.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtGlass.Enabled = False
        Me.txtGlass.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlass.Location = New System.Drawing.Point(142, 343)
        Me.txtGlass.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtGlass.Name = "txtGlass"
        Me.txtGlass.Size = New System.Drawing.Size(247, 47)
        Me.txtGlass.TabIndex = 13
        Me.txtGlass.Text = "0"
        Me.txtGlass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMedicine
        '
        Me.txtMedicine.BackColor = System.Drawing.Color.Azure
        Me.txtMedicine.Enabled = False
        Me.txtMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicine.Location = New System.Drawing.Point(142, 289)
        Me.txtMedicine.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtMedicine.Name = "txtMedicine"
        Me.txtMedicine.Size = New System.Drawing.Size(247, 47)
        Me.txtMedicine.TabIndex = 10
        Me.txtMedicine.Text = "0"
        Me.txtMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountFigureD
        '
        Me.txtAmountFigureD.BackColor = System.Drawing.Color.LightYellow
        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountFigureD.ForeColor = System.Drawing.Color.Navy
        Me.txtAmountFigureD.Location = New System.Drawing.Point(421, 9)
        Me.txtAmountFigureD.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountFigureD.Name = "txtAmountFigureD"
        Me.txtAmountFigureD.Size = New System.Drawing.Size(247, 48)
        Me.txtAmountFigureD.TabIndex = 7
        Me.txtAmountFigureD.Text = "0"
        Me.txtAmountFigureD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountFigureR
        '
        Me.txtAmountFigureR.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountFigureR.Location = New System.Drawing.Point(162, 9)
        Me.txtAmountFigureR.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountFigureR.Name = "txtAmountFigureR"
        Me.txtAmountFigureR.Size = New System.Drawing.Size(247, 48)
        Me.txtAmountFigureR.TabIndex = 6
        Me.txtAmountFigureR.Text = "0"
        Me.txtAmountFigureR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountWord
        '
        Me.txtAmountWord.BackColor = System.Drawing.Color.Linen
        Me.txtAmountWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountWord.Location = New System.Drawing.Point(90, 170)
        Me.txtAmountWord.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountWord.Name = "txtAmountWord"
        Me.txtAmountWord.ReadOnly = True
        Me.txtAmountWord.Size = New System.Drawing.Size(813, 26)
        Me.txtAmountWord.TabIndex = 5
        '
        'txtPatient
        '
        Me.txtPatient.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatient.Location = New System.Drawing.Point(90, 126)
        Me.txtPatient.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.Size = New System.Drawing.Size(485, 39)
        Me.txtPatient.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 411)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 31)
        Me.Label12.TabIndex = 124
        Me.Label12.Text = "srub"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 358)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 31)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Ev:nta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 300)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 31)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "fñaMeBTüepSg²"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 265)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 31)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "cMNayeTAelI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Amount in figure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 168)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 31)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "cMnYnTwkR)ak;"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 31)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = ")anTTYlBI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "HN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(567, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 31)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "elxvikáybRt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(582, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "kalbriecäT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblFees)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAmountFigureD)
        Me.Panel1.Controls.Add(Me.chkRiel)
        Me.Panel1.Controls.Add(Me.chkDollar)
        Me.Panel1.Controls.Add(Me.txtAmountFigureR)
        Me.Panel1.Location = New System.Drawing.Point(11, 202)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 63)
        Me.Panel1.TabIndex = 140
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.BackColor = System.Drawing.Color.Transparent
        Me.lblCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(94, 50)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(19, 20)
        Me.lblCashier.TabIndex = 142
        Me.lblCashier.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 141
        Me.Label15.Text = "Cashier:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSocialFee)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 460)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 66)
        Me.GroupBox3.TabIndex = 143
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Free Fees"
        Me.GroupBox3.Visible = False
        '
        'chkSocialFee
        '
        Me.chkSocialFee.Location = New System.Drawing.Point(33, 26)
        Me.chkSocialFee.Name = "chkSocialFee"
        Me.chkSocialFee.Size = New System.Drawing.Size(170, 24)
        Me.chkSocialFee.TabIndex = 27
        Me.chkSocialFee.Text = "Free"
        Me.chkSocialFee.UseVisualStyleBackColor = True
        '
        'txtCashReceiptNumber
        '
        Me.txtCashReceiptNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCashReceiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashReceiptNumber.Location = New System.Drawing.Point(665, 18)
        Me.txtCashReceiptNumber.Name = "txtCashReceiptNumber"
        Me.txtCashReceiptNumber.Size = New System.Drawing.Size(176, 31)
        Me.txtCashReceiptNumber.TabIndex = 0
        '
        'lblReceiptToPrintID
        '
        Me.lblReceiptToPrintID.AutoSize = True
        Me.lblReceiptToPrintID.BackColor = System.Drawing.Color.Transparent
        Me.lblReceiptToPrintID.Location = New System.Drawing.Point(236, 3)
        Me.lblReceiptToPrintID.Name = "lblReceiptToPrintID"
        Me.lblReceiptToPrintID.Size = New System.Drawing.Size(127, 20)
        Me.lblReceiptToPrintID.TabIndex = 146
        Me.lblReceiptToPrintID.Text = "ReceiptIDtoPrint"
        Me.lblReceiptToPrintID.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Floppy_s2
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(2, 506)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(155, 53)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(163, 506)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(155, 53)
        Me.cmdPrint.TabIndex = 19
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Image = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(847, 17)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(76, 32)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "&Find"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(324, 508)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(155, 53)
        Me.cmdClose.TabIndex = 20
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = Global.TakeoHospitalInventory.My.Resources.Resources.report
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(48, 480)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(133, 40)
        Me.cmdNew.TabIndex = 17
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.Visible = False
        '
        'cmdCashierSave
        '
        Me.cmdCashierSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCashierSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmdCashierSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.welcome_bg
        Me.cmdCashierSave.Location = New System.Drawing.Point(936, 96)
        Me.cmdCashierSave.Name = "cmdCashierSave"
        Me.cmdCashierSave.Size = New System.Drawing.Size(223, 69)
        Me.cmdCashierSave.TabIndex = 147
        Me.cmdCashierSave.Text = "&Cashier Save"
        Me.cmdCashierSave.UseVisualStyleBackColor = True
        Me.cmdCashierSave.Visible = False
        '
        'lblCashierLogin
        '
        Me.lblCashierLogin.AutoSize = True
        Me.lblCashierLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblCashierLogin.Location = New System.Drawing.Point(128, 0)
        Me.lblCashierLogin.Name = "lblCashierLogin"
        Me.lblCashierLogin.Size = New System.Drawing.Size(102, 20)
        Me.lblCashierLogin.TabIndex = 150
        Me.lblCashierLogin.Text = "CashierLogin"
        Me.lblCashierLogin.Visible = False
        '
        'ChPrintPreveiw
        '
        Me.ChPrintPreveiw.AutoSize = True
        Me.ChPrintPreveiw.BackColor = System.Drawing.Color.Transparent
        Me.ChPrintPreveiw.Location = New System.Drawing.Point(937, 175)
        Me.ChPrintPreveiw.Name = "ChPrintPreveiw"
        Me.ChPrintPreveiw.Size = New System.Drawing.Size(162, 24)
        Me.ChPrintPreveiw.TabIndex = 154
        Me.ChPrintPreveiw.Text = "Show Print Preveiw"
        Me.ChPrintPreveiw.UseVisualStyleBackColor = False
        Me.ChPrintPreveiw.Visible = False
        '
        'cmdFindHN
        '
        Me.cmdFindHN.Location = New System.Drawing.Point(495, 86)
        Me.cmdFindHN.Name = "cmdFindHN"
        Me.cmdFindHN.Size = New System.Drawing.Size(79, 33)
        Me.cmdFindHN.TabIndex = 155
        Me.cmdFindHN.Text = "Fi&nd HN"
        Me.cmdFindHN.UseVisualStyleBackColor = True
        Me.cmdFindHN.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(510, 18)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 20)
        Me.lblID.TabIndex = 156
        Me.lblID.Text = "0"
        Me.lblID.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1236, 499)
        Me.TabControl1.TabIndex = 157
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtReceiptNumber)
        Me.TabPage2.Controls.Add(Me.ChPrintPreveiw)
        Me.TabPage2.Controls.Add(Me.lblID)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.cmdFindHN)
        Me.TabPage2.Controls.Add(Me.cmdCashierSave)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.cmdSearch)
        Me.TabPage2.Controls.Add(Me.lblCashier)
        Me.TabPage2.Controls.Add(Me.lblReceiptToPrintID)
        Me.TabPage2.Controls.Add(Me.lblCashierLogin)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtCashReceiptNumber)
        Me.TabPage2.Controls.Add(Me.lblRielDolar)
        Me.TabPage2.Controls.Add(Me.dtpDateIn)
        Me.TabPage2.Controls.Add(Me.txtHN)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.rdGlassD)
        Me.TabPage2.Controls.Add(Me.cmdNew)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.rdGlassR)
        Me.TabPage2.Controls.Add(Me.txtPatient)
        Me.TabPage2.Controls.Add(Me.rdMedicineD)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.rdMedicineR)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.txtAmountWord)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtTotal)
        Me.TabPage2.Controls.Add(Me.txtMedicine)
        Me.TabPage2.Controls.Add(Me.txtGlass)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1228, 466)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cash Receipt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmCashReceipt
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1281, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCashReceipt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Receipt"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFees As System.Windows.Forms.Label
    Friend WithEvents txtReturnD As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAddRate As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents lblRielDolar As System.Windows.Forms.Label
    Friend WithEvents rdGlassD As System.Windows.Forms.RadioButton
    Friend WithEvents rdGlassR As System.Windows.Forms.RadioButton
    Friend WithEvents rdMedicineD As System.Windows.Forms.RadioButton
    Friend WithEvents rdMedicineR As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtHN As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiptNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnR As System.Windows.Forms.TextBox
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpDateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDollar As System.Windows.Forms.CheckBox
    Friend WithEvents chkRiel As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtGlass As System.Windows.Forms.TextBox
    Friend WithEvents txtMedicine As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountFigureD As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountFigureR As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountWord As System.Windows.Forms.TextBox
    Friend WithEvents txtPatient As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSocialFee As System.Windows.Forms.CheckBox
    Friend WithEvents txtCashReceiptNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblReceiptToPrintID As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdCashierSave As System.Windows.Forms.Button
    Friend WithEvents lblCashierLogin As System.Windows.Forms.Label
    Friend WithEvents ChPrintPreveiw As System.Windows.Forms.CheckBox
    Friend WithEvents cmdFindHN As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
