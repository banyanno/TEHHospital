<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPatientReportUtility
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.BtnPrintDisDetail = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.DDisTo = New System.Windows.Forms.DateTimePicker
        Me.DDisFrom = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.BtnPrintRefer = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateReferTo = New System.Windows.Forms.DateTimePicker
        Me.DateReferFrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnPrintOccupationo = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateToOcc = New System.Windows.Forms.DateTimePicker
        Me.DateFromOcc = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadCombinDisability = New System.Windows.Forms.RadioButton
        Me.GDisability = New System.Windows.Forms.GroupBox
        Me.RadByOld = New System.Windows.Forms.RadioButton
        Me.RadByNew = New System.Windows.Forms.RadioButton
        Me.RadAll = New System.Windows.Forms.RadioButton
        Me.rdDisByAge = New System.Windows.Forms.RadioButton
        Me.btnPrintDisability = New System.Windows.Forms.Button
        Me.rdDisByDaily = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateToDis = New System.Windows.Forms.DateTimePicker
        Me.DateFromDis = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadByDate = New System.Windows.Forms.RadioButton
        Me.RadReferalByAge = New System.Windows.Forms.RadioButton
        Me.RadReferalDaily = New System.Windows.Forms.RadioButton
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.BgLoadReportReferal = New System.ComponentModel.BackgroundWorker
        Me.BgDisability = New System.ComponentModel.BackgroundWorker
        Me.BgOccupation = New System.ComponentModel.BackgroundWorker
        Me.BgReferto = New System.ComponentModel.BackgroundWorker
        Me.DSDashboardPatient = New TakeoHospitalInventory.DSDashboardPatient
        Me.TblFollowUpWithReferalTableAdapter = New TakeoHospitalInventory.DSDashboardPatientTableAdapters.TblFollowUpWithReferalTableAdapter
        Me.CRVPatientUtility = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.PicLoadReport = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataReportUtility = New TakeoHospitalInventory.DataReportUtility
        Me.DataTableDisabilityTableAdapter = New TakeoHospitalInventory.DataReportUtilityTableAdapters.DataTableDisabilityTableAdapter
        Me.TblPatientsOccupationTableAdapter = New TakeoHospitalInventory.DataReportUtilityTableAdapters.TblPatientsOccupationTableAdapter
        Me.V_PatientReferTableAdapter = New TakeoHospitalInventory.DataReportUtilityTableAdapters.V_PatientReferTableAdapter
        Me.BgDisDetial = New System.ComponentModel.BackgroundWorker
        Me.DsReferal = New TakeoHospitalInventory.DsReferal
        Me.ReferalByKVTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByKVTableAdapter
        Me.ReferalByTakeoTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByTakeoTableAdapter
        Me.ReferalBySelfTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalBySelfTableAdapter
        Me.ReferalByPatientTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByPatientTableAdapter
        Me.ReferalByFriendTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByFriendTableAdapter
        Me.ReferalByCDMDTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByCDMDTableAdapter
        Me.ReferalByChurchTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByChurchTableAdapter
        Me.ReferalByNGOTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByNGOTableAdapter
        Me.ReferalByWorkerTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReeferalByWorkerTableAdapter
        Me.ReferalByOtherTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByOtherTableAdapter
        Me.ReferalCDMDTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalCDMDTableAdapter
        Me.DisabilityHearingTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.DisabilityHearingTableAdapter
        Me.DisabilityUnderstandTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.DisabilityUnderstandTableAdapter
        Me.DisabilitySeeingTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.DisabilitySeeingTableAdapter
        Me.DisabilityPhysicalTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.DisabilityPhysicalTableAdapter
        Me.ReferalByPreyKabasVCTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByPreyKabasVCTableAdapter
        Me.ReferalByPreyKabascreeningTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByPreyKabascreeningTableAdapter
        Me.ReferalBySchoolTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalBySchoolTableAdapter
        Me.ReferalByMoPoChoTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.ReferalByMoPoChoTableAdapter
        Me.TblCombindRefferalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCombindRefferalTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.TblCombindRefferalTableAdapter
        Me.V_ReferalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_ReferalTableAdapter = New TakeoHospitalInventory.DsReferalTableAdapters.V_ReferalTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GDisability.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DSDashboardPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLoadReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataReportUtility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReferal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCombindRefferalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_ReferalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1289, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Report"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.BtnPrintDisDetail)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.DDisTo)
        Me.GroupBox7.Controls.Add(Me.DDisFrom)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Location = New System.Drawing.Point(733, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(267, 124)
        Me.GroupBox7.TabIndex = 113
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Disability Detail"
        '
        'BtnPrintDisDetail
        '
        Me.BtnPrintDisDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintDisDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintDisDetail.Location = New System.Drawing.Point(169, 32)
        Me.BtnPrintDisDetail.Name = "BtnPrintDisDetail"
        Me.BtnPrintDisDetail.Size = New System.Drawing.Size(89, 70)
        Me.BtnPrintDisDetail.TabIndex = 15
        Me.BtnPrintDisDetail.Text = "&Print Preview"
        Me.BtnPrintDisDetail.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "From:"
        '
        'DDisTo
        '
        Me.DDisTo.CustomFormat = "dd/MM/yyyy"
        Me.DDisTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDisTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DDisTo.Location = New System.Drawing.Point(51, 74)
        Me.DDisTo.Name = "DDisTo"
        Me.DDisTo.Size = New System.Drawing.Size(112, 26)
        Me.DDisTo.TabIndex = 10
        '
        'DDisFrom
        '
        Me.DDisFrom.CustomFormat = "dd/MM/yyyy"
        Me.DDisFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDisFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DDisFrom.Location = New System.Drawing.Point(51, 32)
        Me.DDisFrom.Name = "DDisFrom"
        Me.DDisFrom.Size = New System.Drawing.Size(112, 26)
        Me.DDisFrom.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "To:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnPrintRefer)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.DateReferTo)
        Me.GroupBox6.Controls.Add(Me.DateReferFrom)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Location = New System.Drawing.Point(1230, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(10, 100)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Report Patient Refer To"
        Me.GroupBox6.Visible = False
        '
        'BtnPrintRefer
        '
        Me.BtnPrintRefer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintRefer.Location = New System.Drawing.Point(169, 19)
        Me.BtnPrintRefer.Name = "BtnPrintRefer"
        Me.BtnPrintRefer.Size = New System.Drawing.Size(75, 63)
        Me.BtnPrintRefer.TabIndex = 12
        Me.BtnPrintRefer.Text = "&Print Preview"
        Me.BtnPrintRefer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "From:"
        '
        'DateReferTo
        '
        Me.DateReferTo.CustomFormat = "dd/MM/yyyy"
        Me.DateReferTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReferTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReferTo.Location = New System.Drawing.Point(56, 56)
        Me.DateReferTo.Name = "DateReferTo"
        Me.DateReferTo.Size = New System.Drawing.Size(107, 26)
        Me.DateReferTo.TabIndex = 11
        '
        'DateReferFrom
        '
        Me.DateReferFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateReferFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReferFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReferFrom.Location = New System.Drawing.Point(56, 18)
        Me.DateReferFrom.Name = "DateReferFrom"
        Me.DateReferFrom.Size = New System.Drawing.Size(107, 26)
        Me.DateReferFrom.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "To:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnPrintOccupationo)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.DateToOcc)
        Me.GroupBox5.Controls.Add(Me.DateFromOcc)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(1006, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(264, 124)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Report Occupation"
        '
        'btnPrintOccupationo
        '
        Me.btnPrintOccupationo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintOccupationo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintOccupationo.Location = New System.Drawing.Point(158, 33)
        Me.btnPrintOccupationo.Name = "btnPrintOccupationo"
        Me.btnPrintOccupationo.Size = New System.Drawing.Size(95, 63)
        Me.btnPrintOccupationo.TabIndex = 12
        Me.btnPrintOccupationo.Text = "&Print Preview"
        Me.btnPrintOccupationo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "From:"
        '
        'DateToOcc
        '
        Me.DateToOcc.CustomFormat = "dd/MM/yyyy"
        Me.DateToOcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToOcc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateToOcc.Location = New System.Drawing.Point(45, 70)
        Me.DateToOcc.Name = "DateToOcc"
        Me.DateToOcc.Size = New System.Drawing.Size(107, 26)
        Me.DateToOcc.TabIndex = 11
        '
        'DateFromOcc
        '
        Me.DateFromOcc.CustomFormat = "dd/MM/yyyy"
        Me.DateFromOcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFromOcc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFromOcc.Location = New System.Drawing.Point(45, 32)
        Me.DateFromOcc.Name = "DateFromOcc"
        Me.DateFromOcc.Size = New System.Drawing.Size(107, 26)
        Me.DateFromOcc.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "To:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadCombinDisability)
        Me.GroupBox4.Controls.Add(Me.GDisability)
        Me.GroupBox4.Controls.Add(Me.rdDisByAge)
        Me.GroupBox4.Controls.Add(Me.btnPrintDisability)
        Me.GroupBox4.Controls.Add(Me.rdDisByDaily)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.DateToDis)
        Me.GroupBox4.Controls.Add(Me.DateFromDis)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(334, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(392, 124)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report Disability"
        '
        'RadCombinDisability
        '
        Me.RadCombinDisability.AutoSize = True
        Me.RadCombinDisability.Location = New System.Drawing.Point(7, 98)
        Me.RadCombinDisability.Name = "RadCombinDisability"
        Me.RadCombinDisability.Size = New System.Drawing.Size(151, 17)
        Me.RadCombinDisability.TabIndex = 7
        Me.RadCombinDisability.Text = "View By Combine Disability"
        Me.RadCombinDisability.UseVisualStyleBackColor = True
        '
        'GDisability
        '
        Me.GDisability.Controls.Add(Me.RadByOld)
        Me.GDisability.Controls.Add(Me.RadByNew)
        Me.GDisability.Controls.Add(Me.RadAll)
        Me.GDisability.Enabled = False
        Me.GDisability.Location = New System.Drawing.Point(177, 49)
        Me.GDisability.Name = "GDisability"
        Me.GDisability.Size = New System.Drawing.Size(200, 69)
        Me.GDisability.TabIndex = 8
        Me.GDisability.TabStop = False
        '
        'RadByOld
        '
        Me.RadByOld.AutoSize = True
        Me.RadByOld.Location = New System.Drawing.Point(109, 13)
        Me.RadByOld.Name = "RadByOld"
        Me.RadByOld.Size = New System.Drawing.Size(82, 17)
        Me.RadByOld.TabIndex = 6
        Me.RadByOld.Text = "View By Old"
        Me.RadByOld.UseVisualStyleBackColor = True
        '
        'RadByNew
        '
        Me.RadByNew.AutoSize = True
        Me.RadByNew.Location = New System.Drawing.Point(15, 42)
        Me.RadByNew.Name = "RadByNew"
        Me.RadByNew.Size = New System.Drawing.Size(88, 17)
        Me.RadByNew.TabIndex = 5
        Me.RadByNew.Text = "View By New"
        Me.RadByNew.UseVisualStyleBackColor = True
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Checked = True
        Me.RadAll.Location = New System.Drawing.Point(15, 14)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(77, 17)
        Me.RadAll.TabIndex = 4
        Me.RadAll.TabStop = True
        Me.RadAll.Text = "View By All"
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'rdDisByAge
        '
        Me.rdDisByAge.AutoSize = True
        Me.rdDisByAge.Location = New System.Drawing.Point(94, 77)
        Me.rdDisByAge.Name = "rdDisByAge"
        Me.rdDisByAge.Size = New System.Drawing.Size(85, 17)
        Me.rdDisByAge.TabIndex = 3
        Me.rdDisByAge.Text = "View By Age"
        Me.rdDisByAge.UseVisualStyleBackColor = True
        '
        'btnPrintDisability
        '
        Me.btnPrintDisability.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintDisability.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintDisability.Location = New System.Drawing.Point(180, 14)
        Me.btnPrintDisability.Name = "btnPrintDisability"
        Me.btnPrintDisability.Size = New System.Drawing.Size(197, 35)
        Me.btnPrintDisability.TabIndex = 7
        Me.btnPrintDisability.Text = "&Print Preview"
        Me.btnPrintDisability.UseVisualStyleBackColor = True
        '
        'rdDisByDaily
        '
        Me.rdDisByDaily.AutoSize = True
        Me.rdDisByDaily.Checked = True
        Me.rdDisByDaily.Location = New System.Drawing.Point(7, 77)
        Me.rdDisByDaily.Name = "rdDisByDaily"
        Me.rdDisByDaily.Size = New System.Drawing.Size(89, 17)
        Me.rdDisByDaily.TabIndex = 3
        Me.rdDisByDaily.TabStop = True
        Me.rdDisByDaily.Text = "View By Daily"
        Me.rdDisByDaily.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "From:"
        '
        'DateToDis
        '
        Me.DateToDis.CustomFormat = "dd/MM/yyyy"
        Me.DateToDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToDis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateToDis.Location = New System.Drawing.Point(58, 49)
        Me.DateToDis.Name = "DateToDis"
        Me.DateToDis.Size = New System.Drawing.Size(112, 26)
        Me.DateToDis.TabIndex = 6
        '
        'DateFromDis
        '
        Me.DateFromDis.CustomFormat = "dd/MM/yyyy"
        Me.DateFromDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFromDis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFromDis.Location = New System.Drawing.Point(58, 18)
        Me.DateFromDis.Name = "DateFromDis"
        Me.DateFromDis.Size = New System.Drawing.Size(112, 26)
        Me.DateFromDis.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "To:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadByDate)
        Me.GroupBox3.Controls.Add(Me.RadReferalByAge)
        Me.GroupBox3.Controls.Add(Me.RadReferalDaily)
        Me.GroupBox3.Controls.Add(Me.BtnPreview)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DateTo)
        Me.GroupBox3.Controls.Add(Me.DateFrom)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(323, 119)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Referal"
        '
        'RadByDate
        '
        Me.RadByDate.AutoSize = True
        Me.RadByDate.Location = New System.Drawing.Point(202, 91)
        Me.RadByDate.Name = "RadByDate"
        Me.RadByDate.Size = New System.Drawing.Size(103, 17)
        Me.RadByDate.TabIndex = 4
        Me.RadByDate.TabStop = True
        Me.RadByDate.Text = "View By Referral"
        Me.RadByDate.UseVisualStyleBackColor = True
        '
        'RadReferalByAge
        '
        Me.RadReferalByAge.AutoSize = True
        Me.RadReferalByAge.Location = New System.Drawing.Point(97, 90)
        Me.RadReferalByAge.Name = "RadReferalByAge"
        Me.RadReferalByAge.Size = New System.Drawing.Size(85, 17)
        Me.RadReferalByAge.TabIndex = 3
        Me.RadReferalByAge.Text = "View By Age"
        Me.RadReferalByAge.UseVisualStyleBackColor = True
        '
        'RadReferalDaily
        '
        Me.RadReferalDaily.AutoSize = True
        Me.RadReferalDaily.Checked = True
        Me.RadReferalDaily.Location = New System.Drawing.Point(6, 90)
        Me.RadReferalDaily.Name = "RadReferalDaily"
        Me.RadReferalDaily.Size = New System.Drawing.Size(89, 17)
        Me.RadReferalDaily.TabIndex = 3
        Me.RadReferalDaily.TabStop = True
        Me.RadReferalDaily.Text = "View By Daily"
        Me.RadReferalDaily.UseVisualStyleBackColor = True
        '
        'BtnPreview
        '
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.Location = New System.Drawing.Point(172, 21)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(139, 64)
        Me.BtnPreview.TabIndex = 2
        Me.BtnPreview.Text = "&Print Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(55, 59)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(111, 26)
        Me.DateTo.TabIndex = 1
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(55, 21)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(111, 26)
        Me.DateFrom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "To:"
        '
        'BgLoadReportReferal
        '
        '
        'BgDisability
        '
        '
        'BgOccupation
        '
        '
        'BgReferto
        '
        '
        'DSDashboardPatient
        '
        Me.DSDashboardPatient.DataSetName = "DSDashboardPatient"
        Me.DSDashboardPatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFollowUpWithReferalTableAdapter
        '
        Me.TblFollowUpWithReferalTableAdapter.ClearBeforeFill = True
        '
        'CRVPatientUtility
        '
        Me.CRVPatientUtility.ActiveViewIndex = -1
        Me.CRVPatientUtility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPatientUtility.DisplayGroupTree = False
        Me.CRVPatientUtility.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPatientUtility.Location = New System.Drawing.Point(3, 16)
        Me.CRVPatientUtility.Name = "CRVPatientUtility"
        Me.CRVPatientUtility.SelectionFormula = ""
        Me.CRVPatientUtility.Size = New System.Drawing.Size(1283, 620)
        Me.CRVPatientUtility.TabIndex = 2
        Me.CRVPatientUtility.ViewTimeSelectionFormula = ""
        '
        'PicLoadReport
        '
        Me.PicLoadReport.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar
        Me.PicLoadReport.Location = New System.Drawing.Point(454, 319)
        Me.PicLoadReport.Name = "PicLoadReport"
        Me.PicLoadReport.Size = New System.Drawing.Size(200, 22)
        Me.PicLoadReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoadReport.TabIndex = 1
        Me.PicLoadReport.TabStop = False
        Me.PicLoadReport.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicLoadReport)
        Me.GroupBox2.Controls.Add(Me.CRVPatientUtility)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1289, 639)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report"
        '
        'DataReportUtility
        '
        Me.DataReportUtility.DataSetName = "DataReportUtility"
        Me.DataReportUtility.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTableDisabilityTableAdapter
        '
        Me.DataTableDisabilityTableAdapter.ClearBeforeFill = True
        '
        'TblPatientsOccupationTableAdapter
        '
        Me.TblPatientsOccupationTableAdapter.ClearBeforeFill = True
        '
        'V_PatientReferTableAdapter
        '
        Me.V_PatientReferTableAdapter.ClearBeforeFill = True
        '
        'BgDisDetial
        '
        '
        'DsReferal
        '
        Me.DsReferal.DataSetName = "DsReferal"
        Me.DsReferal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReferalByKVTableAdapter
        '
        Me.ReferalByKVTableAdapter.ClearBeforeFill = True
        '
        'ReferalByTakeoTableAdapter
        '
        Me.ReferalByTakeoTableAdapter.ClearBeforeFill = True
        '
        'ReferalBySelfTableAdapter
        '
        Me.ReferalBySelfTableAdapter.ClearBeforeFill = True
        '
        'ReferalByPatientTableAdapter
        '
        Me.ReferalByPatientTableAdapter.ClearBeforeFill = True
        '
        'ReferalByFriendTableAdapter
        '
        Me.ReferalByFriendTableAdapter.ClearBeforeFill = True
        '
        'ReferalByCDMDTableAdapter
        '
        Me.ReferalByCDMDTableAdapter.ClearBeforeFill = True
        '
        'ReferalByChurchTableAdapter
        '
        Me.ReferalByChurchTableAdapter.ClearBeforeFill = True
        '
        'ReferalByNGOTableAdapter
        '
        Me.ReferalByNGOTableAdapter.ClearBeforeFill = True
        '
        'ReferalByWorkerTableAdapter
        '
        Me.ReferalByWorkerTableAdapter.ClearBeforeFill = True
        '
        'ReferalByOtherTableAdapter
        '
        Me.ReferalByOtherTableAdapter.ClearBeforeFill = True
        '
        'ReferalCDMDTableAdapter
        '
        Me.ReferalCDMDTableAdapter.ClearBeforeFill = True
        '
        'DisabilityHearingTableAdapter
        '
        Me.DisabilityHearingTableAdapter.ClearBeforeFill = True
        '
        'DisabilityUnderstandTableAdapter
        '
        Me.DisabilityUnderstandTableAdapter.ClearBeforeFill = True
        '
        'DisabilitySeeingTableAdapter
        '
        Me.DisabilitySeeingTableAdapter.ClearBeforeFill = True
        '
        'DisabilityPhysicalTableAdapter
        '
        Me.DisabilityPhysicalTableAdapter.ClearBeforeFill = True
        '
        'ReferalByPreyKabasVCTableAdapter
        '
        Me.ReferalByPreyKabasVCTableAdapter.ClearBeforeFill = True
        '
        'ReferalByPreyKabascreeningTableAdapter
        '
        Me.ReferalByPreyKabascreeningTableAdapter.ClearBeforeFill = True
        '
        'ReferalBySchoolTableAdapter
        '
        Me.ReferalBySchoolTableAdapter.ClearBeforeFill = True
        '
        'ReferalByMoPoChoTableAdapter
        '
        Me.ReferalByMoPoChoTableAdapter.ClearBeforeFill = True
        '
        'TblCombindRefferalBindingSource
        '
        Me.TblCombindRefferalBindingSource.DataMember = "TblCombindRefferal"
        Me.TblCombindRefferalBindingSource.DataSource = Me.DsReferal
        '
        'TblCombindRefferalTableAdapter
        '
        Me.TblCombindRefferalTableAdapter.ClearBeforeFill = True
        '
        'V_ReferalBindingSource
        '
        Me.V_ReferalBindingSource.DataMember = "V_Referal"
        Me.V_ReferalBindingSource.DataSource = Me.DsReferal
        '
        'V_ReferalTableAdapter
        '
        Me.V_ReferalTableAdapter.ClearBeforeFill = True
        '
        'UCPatientReportUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCPatientReportUtility"
        Me.Size = New System.Drawing.Size(1289, 781)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GDisability.ResumeLayout(False)
        Me.GDisability.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DSDashboardPatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLoadReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataReportUtility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReferal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCombindRefferalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_ReferalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents BgLoadReportReferal As System.ComponentModel.BackgroundWorker
    Friend WithEvents DSDashboardPatient As TakeoHospitalInventory.DSDashboardPatient
    Friend WithEvents TblFollowUpWithReferalTableAdapter As TakeoHospitalInventory.DSDashboardPatientTableAdapters.TblFollowUpWithReferalTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrintOccupationo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateToOcc As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFromOcc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnPrintDisability As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateToDis As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFromDis As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BgDisability As System.ComponentModel.BackgroundWorker
    Friend WithEvents BgOccupation As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataReportUtility As TakeoHospitalInventory.DataReportUtility
    Friend WithEvents DataTableDisabilityTableAdapter As TakeoHospitalInventory.DataReportUtilityTableAdapters.DataTableDisabilityTableAdapter
    Friend WithEvents TblPatientsOccupationTableAdapter As TakeoHospitalInventory.DataReportUtilityTableAdapters.TblPatientsOccupationTableAdapter
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrintRefer As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateReferTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateReferFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents V_PatientReferTableAdapter As TakeoHospitalInventory.DataReportUtilityTableAdapters.V_PatientReferTableAdapter
    Friend WithEvents BgReferto As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadReferalByAge As System.Windows.Forms.RadioButton
    Friend WithEvents RadReferalDaily As System.Windows.Forms.RadioButton
    Friend WithEvents rdDisByAge As System.Windows.Forms.RadioButton
    Friend WithEvents rdDisByDaily As System.Windows.Forms.RadioButton
    Friend WithEvents DsReferal As TakeoHospitalInventory.DsReferal
    Friend WithEvents ReferalByKVTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByKVTableAdapter
    Friend WithEvents ReferalByTakeoTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByTakeoTableAdapter
    Friend WithEvents ReferalBySelfTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalBySelfTableAdapter
    Friend WithEvents ReferalByPatientTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByPatientTableAdapter
    Friend WithEvents ReferalByFriendTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByFriendTableAdapter
    Friend WithEvents ReferalByCDMDTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByCDMDTableAdapter
    Friend WithEvents ReferalByChurchTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByChurchTableAdapter
    Friend WithEvents ReferalByNGOTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByNGOTableAdapter
    Friend WithEvents ReferalByWorkerTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReeferalByWorkerTableAdapter
    Friend WithEvents ReferalByOtherTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByOtherTableAdapter
    Friend WithEvents ReferalCDMDTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalCDMDTableAdapter
    Friend WithEvents DisabilityHearingTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.DisabilityHearingTableAdapter
    Friend WithEvents DisabilityUnderstandTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.DisabilityUnderstandTableAdapter
    Friend WithEvents DisabilitySeeingTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.DisabilitySeeingTableAdapter
    Friend WithEvents DisabilityPhysicalTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.DisabilityPhysicalTableAdapter
    Friend WithEvents ReferalByPreyKabasVCTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByPreyKabasVCTableAdapter
    Friend WithEvents CRVPatientUtility As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PicLoadReport As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ReferalByPreyKabascreeningTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByPreyKabascreeningTableAdapter
    Friend WithEvents ReferalBySchoolTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalBySchoolTableAdapter
    Friend WithEvents ReferalByMoPoChoTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.ReferalByMoPoChoTableAdapter
    Friend WithEvents TblCombindRefferalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCombindRefferalTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.TblCombindRefferalTableAdapter
    Friend WithEvents V_ReferalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_ReferalTableAdapter As TakeoHospitalInventory.DsReferalTableAdapters.V_ReferalTableAdapter
    Friend WithEvents RadByDate As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrintDisDetail As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DDisTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DDisFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BgDisDetial As System.ComponentModel.BackgroundWorker
    Friend WithEvents GDisability As System.Windows.Forms.GroupBox
    Friend WithEvents RadByOld As System.Windows.Forms.RadioButton
    Friend WithEvents RadByNew As System.Windows.Forms.RadioButton
    Friend WithEvents RadAll As System.Windows.Forms.RadioButton
    Friend WithEvents RadCombinDisability As System.Windows.Forms.RadioButton

End Class
