<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOutpatientReceipt
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
        Me.lblFees = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdAddRate = New System.Windows.Forms.Button
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblRielDolar = New System.Windows.Forms.Label
        Me.rdConsultationD = New System.Windows.Forms.RadioButton
        Me.rdConsultationR = New System.Windows.Forms.RadioButton
        Me.txtHN = New System.Windows.Forms.TextBox
        Me.txtReceiptNumber = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtReturnD = New System.Windows.Forms.TextBox
        Me.txtReturnR = New System.Windows.Forms.TextBox
        Me.dtpDateIn = New System.Windows.Forms.DateTimePicker
        Me.chkDollar = New System.Windows.Forms.CheckBox
        Me.chkRiel = New System.Windows.Forms.CheckBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtConsultation = New System.Windows.Forms.TextBox
        Me.txtAmountFigureD = New System.Windows.Forms.TextBox
        Me.txtAmountFigureR = New System.Windows.Forms.TextBox
        Me.txtAmountWord = New System.Windows.Forms.TextBox
        Me.txtPatient = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCashier = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkSocialFee = New System.Windows.Forms.CheckBox
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.lblReceiptToPrintID = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdCashierSave = New System.Windows.Forms.Button
        Me.lblCashierLogin = New System.Windows.Forms.Label
        Me.ChPrintPreveiw = New System.Windows.Forms.CheckBox
        Me.cmdFindHN = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Location = New System.Drawing.Point(834, 27)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(45, 13)
        Me.lblFees.TabIndex = 100
        Me.lblFees.Text = "Label15"
        Me.lblFees.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 47)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 33)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "erol"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdAddRate)
        Me.GroupBox2.Controls.Add(Me.txtRate)
        Me.GroupBox2.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(738, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 108)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GRtab��rR)ak;"
        '
        'cmdAddRate
        '
        Me.cmdAddRate.Enabled = False
        Me.cmdAddRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.cmdAddRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAddRate.Location = New System.Drawing.Point(170, 39)
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
        Me.txtRate.Location = New System.Drawing.Point(13, 40)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(151, 44)
        Me.txtRate.TabIndex = 0
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 103)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 33)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "dul�ar"
        '
        'lblRielDolar
        '
        Me.lblRielDolar.AutoSize = True
        Me.lblRielDolar.BackColor = System.Drawing.Color.Transparent
        Me.lblRielDolar.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRielDolar.Location = New System.Drawing.Point(406, 323)
        Me.lblRielDolar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRielDolar.Name = "lblRielDolar"
        Me.lblRielDolar.Size = New System.Drawing.Size(74, 31)
        Me.lblRielDolar.TabIndex = 92
        Me.lblRielDolar.Text = "erol dul�ar"
        Me.lblRielDolar.Visible = False
        '
        'rdConsultationD
        '
        Me.rdConsultationD.AutoSize = True
        Me.rdConsultationD.BackColor = System.Drawing.Color.Transparent
        Me.rdConsultationD.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdConsultationD.Location = New System.Drawing.Point(412, 276)
        Me.rdConsultationD.Name = "rdConsultationD"
        Me.rdConsultationD.Size = New System.Drawing.Size(57, 31)
        Me.rdConsultationD.TabIndex = 12
        Me.rdConsultationD.TabStop = True
        Me.rdConsultationD.Text = "dul�ar"
        Me.rdConsultationD.UseVisualStyleBackColor = False
        '
        'rdConsultationR
        '
        Me.rdConsultationR.AutoSize = True
        Me.rdConsultationR.BackColor = System.Drawing.Color.Transparent
        Me.rdConsultationR.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdConsultationR.Location = New System.Drawing.Point(412, 250)
        Me.rdConsultationR.Name = "rdConsultationR"
        Me.rdConsultationR.Size = New System.Drawing.Size(55, 31)
        Me.rdConsultationR.TabIndex = 11
        Me.rdConsultationR.TabStop = True
        Me.rdConsultationR.Text = "erol"
        Me.rdConsultationR.UseVisualStyleBackColor = False
        '
        'txtHN
        '
        Me.txtHN.BackColor = System.Drawing.SystemColors.Window
        Me.txtHN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHN.Location = New System.Drawing.Point(156, 64)
        Me.txtHN.Name = "txtHN"
        Me.txtHN.Size = New System.Drawing.Size(138, 31)
        Me.txtHN.TabIndex = 2
        '
        'txtReceiptNumber
        '
        Me.txtReceiptNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtReceiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNumber.Location = New System.Drawing.Point(494, 29)
        Me.txtReceiptNumber.Name = "txtReceiptNumber"
        Me.txtReceiptNumber.Size = New System.Drawing.Size(157, 31)
        Me.txtReceiptNumber.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtReturnD)
        Me.GroupBox1.Controls.Add(Me.txtReturnR)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(494, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 171)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "R)ak;Gab;"
        '
        'txtReturnD
        '
        Me.txtReturnD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtReturnD.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnD.Location = New System.Drawing.Point(61, 94)
        Me.txtReturnD.Name = "txtReturnD"
        Me.txtReturnD.ReadOnly = True
        Me.txtReturnD.Size = New System.Drawing.Size(231, 53)
        Me.txtReturnD.TabIndex = 1
        Me.txtReturnD.Text = "0"
        Me.txtReturnD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReturnR
        '
        Me.txtReturnR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtReturnR.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnR.Location = New System.Drawing.Point(61, 37)
        Me.txtReturnR.Name = "txtReturnR"
        Me.txtReturnR.ReadOnly = True
        Me.txtReturnR.Size = New System.Drawing.Size(231, 53)
        Me.txtReturnR.TabIndex = 0
        Me.txtReturnR.Text = "0"
        Me.txtReturnR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDateIn
        '
        Me.dtpDateIn.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateIn.Location = New System.Drawing.Point(494, 66)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.ShowCheckBox = True
        Me.dtpDateIn.Size = New System.Drawing.Size(157, 29)
        Me.dtpDateIn.TabIndex = 3
        '
        'chkDollar
        '
        Me.chkDollar.AutoSize = True
        Me.chkDollar.BackColor = System.Drawing.Color.Transparent
        Me.chkDollar.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDollar.Location = New System.Drawing.Point(738, 198)
        Me.chkDollar.Name = "chkDollar"
        Me.chkDollar.Size = New System.Drawing.Size(62, 35)
        Me.chkDollar.TabIndex = 9
        Me.chkDollar.Text = "dul�ar"
        Me.chkDollar.UseVisualStyleBackColor = False
        '
        'chkRiel
        '
        Me.chkRiel.AutoSize = True
        Me.chkRiel.BackColor = System.Drawing.Color.Transparent
        Me.chkRiel.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRiel.Location = New System.Drawing.Point(669, 198)
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
        Me.txtTotal.Location = New System.Drawing.Point(156, 310)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(247, 57)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.Text = "4000"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConsultation
        '
        Me.txtConsultation.BackColor = System.Drawing.Color.Azure
        Me.txtConsultation.Enabled = False
        Me.txtConsultation.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsultation.Location = New System.Drawing.Point(156, 257)
        Me.txtConsultation.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtConsultation.Name = "txtConsultation"
        Me.txtConsultation.Size = New System.Drawing.Size(247, 47)
        Me.txtConsultation.TabIndex = 10
        Me.txtConsultation.Text = "4000"
        Me.txtConsultation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountFigureD
        '
        Me.txtAmountFigureD.BackColor = System.Drawing.Color.LightYellow
        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountFigureD.ForeColor = System.Drawing.Color.Navy
        Me.txtAmountFigureD.Location = New System.Drawing.Point(404, 189)
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
        Me.txtAmountFigureR.Location = New System.Drawing.Point(156, 189)
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
        Me.txtAmountWord.Location = New System.Drawing.Point(156, 147)
        Me.txtAmountWord.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountWord.Name = "txtAmountWord"
        Me.txtAmountWord.ReadOnly = True
        Me.txtAmountWord.Size = New System.Drawing.Size(805, 26)
        Me.txtAmountWord.TabIndex = 5
        '
        'txtPatient
        '
        Me.txtPatient.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatient.Location = New System.Drawing.Point(156, 101)
        Me.txtPatient.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.Size = New System.Drawing.Size(495, 39)
        Me.txtPatient.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 325)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 31)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "srub"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 272)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 31)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "karBieRKaHCMgW"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 246)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 31)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "cMNayeTAelI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Amount in figure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 147)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 31)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "cMnYnTwkR)ak;"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 31)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = ")anTTYlBI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "HN:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 36)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "New-Out Patient Receipt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(412, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "kalbriec�T"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(397, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 31)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "elxvik�ybRt"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblFees)
        Me.Panel1.Location = New System.Drawing.Point(1, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 63)
        Me.Panel1.TabIndex = 101
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.BackColor = System.Drawing.Color.Transparent
        Me.lblCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(152, 34)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(0, 20)
        Me.lblCashier.TabIndex = 103
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(79, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Cashier:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSocialFee)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(494, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 66)
        Me.GroupBox3.TabIndex = 104
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Free Fees"
        Me.GroupBox3.Visible = False
        '
        'chkSocialFee
        '
        Me.chkSocialFee.Location = New System.Drawing.Point(22, 26)
        Me.chkSocialFee.Name = "chkSocialFee"
        Me.chkSocialFee.Size = New System.Drawing.Size(181, 24)
        Me.chkSocialFee.TabIndex = 0
        Me.chkSocialFee.Text = "Fees"
        Me.chkSocialFee.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Image = Global.TakeoHospitalInventory.My.Resources.Resources.search
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(657, 28)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(71, 32)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "&Find"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'lblReceiptToPrintID
        '
        Me.lblReceiptToPrintID.AutoSize = True
        Me.lblReceiptToPrintID.BackColor = System.Drawing.Color.Transparent
        Me.lblReceiptToPrintID.Location = New System.Drawing.Point(80, 41)
        Me.lblReceiptToPrintID.Name = "lblReceiptToPrintID"
        Me.lblReceiptToPrintID.Size = New System.Drawing.Size(85, 13)
        Me.lblReceiptToPrintID.TabIndex = 106
        Me.lblReceiptToPrintID.Text = "ReceiptIDtoPrint"
        Me.lblReceiptToPrintID.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Transparent
        Me.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Floppy_s2
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(828, 327)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(133, 49)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(828, 380)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(133, 49)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(828, 434)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(133, 49)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = Global.TakeoHospitalInventory.My.Resources.Resources.report
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(29, 404)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(133, 40)
        Me.cmdNew.TabIndex = 14
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.Visible = False
        '
        'cmdCashierSave
        '
        Me.cmdCashierSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCashierSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.cmdCashierSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.welcome_bg
        Me.cmdCashierSave.Location = New System.Drawing.Point(233, 390)
        Me.cmdCashierSave.Name = "cmdCashierSave"
        Me.cmdCashierSave.Size = New System.Drawing.Size(170, 71)
        Me.cmdCashierSave.TabIndex = 148
        Me.cmdCashierSave.Text = "&Cashier Save"
        Me.cmdCashierSave.UseVisualStyleBackColor = True
        Me.cmdCashierSave.Visible = False
        '
        'lblCashierLogin
        '
        Me.lblCashierLogin.AutoSize = True
        Me.lblCashierLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblCashierLogin.Location = New System.Drawing.Point(80, 9)
        Me.lblCashierLogin.Name = "lblCashierLogin"
        Me.lblCashierLogin.Size = New System.Drawing.Size(68, 13)
        Me.lblCashierLogin.TabIndex = 149
        Me.lblCashierLogin.Text = "CashierLogin"
        Me.lblCashierLogin.Visible = False
        '
        'ChPrintPreveiw
        '
        Me.ChPrintPreveiw.AutoSize = True
        Me.ChPrintPreveiw.BackColor = System.Drawing.Color.Transparent
        Me.ChPrintPreveiw.Location = New System.Drawing.Point(828, 295)
        Me.ChPrintPreveiw.Name = "ChPrintPreveiw"
        Me.ChPrintPreveiw.Size = New System.Drawing.Size(118, 17)
        Me.ChPrintPreveiw.TabIndex = 152
        Me.ChPrintPreveiw.Text = "Show Print Preveiw"
        Me.ChPrintPreveiw.UseVisualStyleBackColor = False
        '
        'cmdFindHN
        '
        Me.cmdFindHN.Location = New System.Drawing.Point(300, 64)
        Me.cmdFindHN.Name = "cmdFindHN"
        Me.cmdFindHN.Size = New System.Drawing.Size(75, 33)
        Me.cmdFindHN.TabIndex = 153
        Me.cmdFindHN.Text = "Fi&nd HN"
        Me.cmdFindHN.UseVisualStyleBackColor = True
        Me.cmdFindHN.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Location = New System.Drawing.Point(715, 27)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 156
        Me.lblID.Text = "0"
        Me.lblID.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(136, 272)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 157
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.cmdFindHN)
        Me.Panel2.Controls.Add(Me.ChPrintPreveiw)
        Me.Panel2.Controls.Add(Me.cmdCashierSave)
        Me.Panel2.Controls.Add(Me.cmdPrint)
        Me.Panel2.Controls.Add(Me.cmdSearch)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.lblCashier)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.lblRielDolar)
        Me.Panel2.Controls.Add(Me.rdConsultationD)
        Me.Panel2.Controls.Add(Me.rdConsultationR)
        Me.Panel2.Controls.Add(Me.cmdClose)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.txtHN)
        Me.Panel2.Controls.Add(Me.txtReceiptNumber)
        Me.Panel2.Controls.Add(Me.cmdNew)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.dtpDateIn)
        Me.Panel2.Controls.Add(Me.chkDollar)
        Me.Panel2.Controls.Add(Me.chkRiel)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.txtConsultation)
        Me.Panel2.Controls.Add(Me.txtAmountFigureD)
        Me.Panel2.Controls.Add(Me.txtAmountFigureR)
        Me.Panel2.Controls.Add(Me.txtAmountWord)
        Me.Panel2.Controls.Add(Me.txtPatient)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(972, 493)
        Me.Panel2.TabIndex = 158
        '
        'frmNewOutpatientReceipt
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(975, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCashierLogin)
        Me.Controls.Add(Me.lblReceiptToPrintID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewOutpatientReceipt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New-Out patient Receipt"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFees As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAddRate As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblRielDolar As System.Windows.Forms.Label
    Friend WithEvents rdConsultationD As System.Windows.Forms.RadioButton
    Friend WithEvents rdConsultationR As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtHN As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiptNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReturnD As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnR As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDollar As System.Windows.Forms.CheckBox
    Friend WithEvents chkRiel As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultation As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountFigureD As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountFigureR As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountWord As System.Windows.Forms.TextBox
    Friend WithEvents txtPatient As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSocialFee As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblReceiptToPrintID As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdCashierSave As System.Windows.Forms.Button
    Friend WithEvents lblCashierLogin As System.Windows.Forms.Label
    Friend WithEvents ChPrintPreveiw As System.Windows.Forms.CheckBox
    Friend WithEvents cmdFindHN As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
