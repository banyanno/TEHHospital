<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainConsuling
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridConsulting_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainConsuling))
        Dim GridPatientRefund_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridAppointment_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolMenuConsuling = New System.Windows.Forms.ToolStrip
        Me.BtnNewConsulting = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnConsultReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnConsultForm = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnStatistic = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadAllConsult = New System.Windows.Forms.RadioButton
        Me.RadForNewPatient = New System.Windows.Forms.RadioButton
        Me.RadForOpticalShop = New System.Windows.Forms.RadioButton
        Me.RadForInPatient = New System.Windows.Forms.RadioButton
        Me.RadForOld = New System.Windows.Forms.RadioButton
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridConsulting = New Janus.Windows.GridEX.GridEX
        Me.MenuConsulting = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuApprove = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteConsult = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUndo = New System.Windows.Forms.ToolStripMenuItem
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BgLoadConsult = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.TxtPatientRefunID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnDisplayRefund = New System.Windows.Forms.Button
        Me.DateRefundTo = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateRefundFrom = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.GridPatientRefund = New Janus.Windows.GridEX.GridEX
        Me.ContextRefund = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDelRefund = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportMoneyRefund = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewRefund = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnReportRefund = New System.Windows.Forms.ToolStripButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadByDoctor = New System.Windows.Forms.RadioButton
        Me.TxtPatientSearchNo = New System.Windows.Forms.TextBox
        Me.RadViewByPatientNo = New System.Windows.Forms.RadioButton
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.RadByDateCreate = New System.Windows.Forms.RadioButton
        Me.RadByDateApp = New System.Windows.Forms.RadioButton
        Me.BtnDisplayAppp = New System.Windows.Forms.Button
        Me.DateATo = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.DateAFrom = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer
        Me.GridAppointment = New Janus.Windows.GridEX.GridEX
        Me.CMCallPatient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnCallPatient = New System.Windows.Forms.ToolStripMenuItem
        Me.CrystalApp = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnNewAppoint = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReportApp = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.UpdateOnAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrCounselling = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolMenuConsuling.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridConsulting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuConsulting.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.GridPatientRefund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextRefund.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.GridAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMCallPatient.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.ErrCounselling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolMenuConsuling
        '
        Me.ToolMenuConsuling.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolMenuConsuling.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewConsulting, Me.ToolStripSeparator1, Me.BtnConsultReport, Me.ToolStripSeparator2, Me.BtnConsultForm, Me.ToolStripSeparator5, Me.BtnStatistic})
        Me.ToolMenuConsuling.Location = New System.Drawing.Point(3, 3)
        Me.ToolMenuConsuling.Name = "ToolMenuConsuling"
        Me.ToolMenuConsuling.Size = New System.Drawing.Size(1390, 32)
        Me.ToolMenuConsuling.TabIndex = 0
        Me.ToolMenuConsuling.Text = "ToolStrip1"
        '
        'BtnNewConsulting
        '
        Me.BtnNewConsulting.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnNewConsulting.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewConsulting.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.BtnNewConsulting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewConsulting.Name = "BtnNewConsulting"
        Me.BtnNewConsulting.Size = New System.Drawing.Size(156, 29)
        Me.BtnNewConsulting.Text = "New Counselling"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnConsultReport
        '
        Me.BtnConsultReport.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnConsultReport.ForeColor = System.Drawing.Color.Blue
        Me.BtnConsultReport.Image = Global.TakeoHospitalInventory.My.Resources.Resources.sales_report
        Me.BtnConsultReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultReport.Name = "BtnConsultReport"
        Me.BtnConsultReport.Size = New System.Drawing.Size(172, 29)
        Me.BtnConsultReport.Text = "Report Counselling"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'BtnConsultForm
        '
        Me.BtnConsultForm.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnConsultForm.ForeColor = System.Drawing.Color.Blue
        Me.BtnConsultForm.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Open
        Me.BtnConsultForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultForm.Name = "BtnConsultForm"
        Me.BtnConsultForm.Size = New System.Drawing.Size(162, 29)
        Me.BtnConsultForm.Text = "Form Councelling"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'BtnStatistic
        '
        Me.BtnStatistic.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnStatistic.ForeColor = System.Drawing.Color.Blue
        Me.BtnStatistic.Image = Global.TakeoHospitalInventory.My.Resources.Resources.instock
        Me.BtnStatistic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStatistic.Name = "BtnStatistic"
        Me.BtnStatistic.Size = New System.Drawing.Size(178, 29)
        Me.BtnStatistic.Text = "Statistic Counselling"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 35)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtPatientNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnFind)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1390, 536)
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadAllConsult)
        Me.GroupBox3.Controls.Add(Me.RadForNewPatient)
        Me.GroupBox3.Controls.Add(Me.RadForOpticalShop)
        Me.GroupBox3.Controls.Add(Me.RadForInPatient)
        Me.GroupBox3.Controls.Add(Me.RadForOld)
        Me.GroupBox3.Location = New System.Drawing.Point(666, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(524, 54)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Option Counselling For"
        '
        'RadAllConsult
        '
        Me.RadAllConsult.AutoSize = True
        Me.RadAllConsult.Checked = True
        Me.RadAllConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAllConsult.Location = New System.Drawing.Point(9, 21)
        Me.RadAllConsult.Name = "RadAllConsult"
        Me.RadAllConsult.Size = New System.Drawing.Size(92, 21)
        Me.RadAllConsult.TabIndex = 14
        Me.RadAllConsult.TabStop = True
        Me.RadAllConsult.Text = "All Consult"
        Me.RadAllConsult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadAllConsult.UseVisualStyleBackColor = True
        '
        'RadForNewPatient
        '
        Me.RadForNewPatient.AutoSize = True
        Me.RadForNewPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadForNewPatient.Location = New System.Drawing.Point(107, 21)
        Me.RadForNewPatient.Name = "RadForNewPatient"
        Me.RadForNewPatient.Size = New System.Drawing.Size(101, 21)
        Me.RadForNewPatient.TabIndex = 13
        Me.RadForNewPatient.Text = "New Patient"
        Me.RadForNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForNewPatient.UseVisualStyleBackColor = True
        '
        'RadForOpticalShop
        '
        Me.RadForOpticalShop.AutoSize = True
        Me.RadForOpticalShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadForOpticalShop.Location = New System.Drawing.Point(408, 21)
        Me.RadForOpticalShop.Name = "RadForOpticalShop"
        Me.RadForOpticalShop.Size = New System.Drawing.Size(107, 21)
        Me.RadForOpticalShop.TabIndex = 12
        Me.RadForOpticalShop.Text = "Optical Shop"
        Me.RadForOpticalShop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForOpticalShop.UseVisualStyleBackColor = True
        '
        'RadForInPatient
        '
        Me.RadForInPatient.AutoSize = True
        Me.RadForInPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadForInPatient.Location = New System.Drawing.Point(316, 21)
        Me.RadForInPatient.Name = "RadForInPatient"
        Me.RadForInPatient.Size = New System.Drawing.Size(86, 21)
        Me.RadForInPatient.TabIndex = 11
        Me.RadForInPatient.Text = "In-Patient"
        Me.RadForInPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForInPatient.UseVisualStyleBackColor = True
        '
        'RadForOld
        '
        Me.RadForOld.AutoSize = True
        Me.RadForOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadForOld.Location = New System.Drawing.Point(214, 21)
        Me.RadForOld.Name = "RadForOld"
        Me.RadForOld.Size = New System.Drawing.Size(96, 21)
        Me.RadForOld.TabIndex = 10
        Me.RadForOld.Text = "Old Patient"
        Me.RadForOld.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadForOld.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(93, 18)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(136, 26)
        Me.TxtPatientNo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Patient No:"
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Location = New System.Drawing.Point(578, 15)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(80, 29)
        Me.BtnFind.TabIndex = 4
        Me.BtnFind.Text = "Display"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'DTo
        '
        Me.DTo.Checked = False
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(461, 18)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(110, 26)
        Me.DTo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To :"
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(293, 18)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(111, 26)
        Me.DFrom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From :"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(1390, 482)
        Me.SplitContainer2.SplitterDistance = 707
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridConsulting)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1388, 480)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consuling Information"
        '
        'GridConsulting
        '
        Me.GridConsulting.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridConsulting.ContextMenuStrip = Me.MenuConsulting
        GridConsulting_DesignTimeLayout.LayoutString = resources.GetString("GridConsulting_DesignTimeLayout.LayoutString")
        Me.GridConsulting.DesignTimeLayout = GridConsulting_DesignTimeLayout
        Me.GridConsulting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridConsulting.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GridConsulting.GroupByBoxVisible = False
        Me.GridConsulting.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridConsulting.Location = New System.Drawing.Point(3, 20)
        Me.GridConsulting.Name = "GridConsulting"
        Me.GridConsulting.RecordNavigator = True
        Me.GridConsulting.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridConsulting.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridConsulting.Size = New System.Drawing.Size(1382, 432)
        Me.GridConsulting.TabIndex = 0
        '
        'MenuConsulting
        '
        Me.MenuConsulting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuApprove, Me.ToolStripMenuItem1, Me.BtnDeleteConsult, Me.ToolStripSeparator3, Me.BtnUndo})
        Me.MenuConsulting.Name = "MenuConsulting"
        Me.MenuConsulting.Size = New System.Drawing.Size(152, 82)
        '
        'MenuApprove
        '
        Me.MenuApprove.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MenuApprove.Name = "MenuApprove"
        Me.MenuApprove.Size = New System.Drawing.Size(151, 22)
        Me.MenuApprove.Text = "Approve"
        Me.MenuApprove.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(148, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'BtnDeleteConsult
        '
        Me.BtnDeleteConsult.Enabled = False
        Me.BtnDeleteConsult.Name = "BtnDeleteConsult"
        Me.BtnDeleteConsult.Size = New System.Drawing.Size(151, 22)
        Me.BtnDeleteConsult.Text = "Delete Consult"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(148, 6)
        '
        'BtnUndo
        '
        Me.BtnUndo.Enabled = False
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(151, 22)
        Me.BtnUndo.Text = "Undo Consult"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(3, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pleace Check Status Consultation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(94, 98)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consuling Information"
        '
        'BgLoadConsult
        '
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 57)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TxtPatientRefunID)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel1.Controls.Add(Me.BtnDisplayRefund)
        Me.SplitContainer3.Panel1.Controls.Add(Me.DateRefundTo)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer3.Panel1.Controls.Add(Me.DateRefundFrom)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label7)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(1390, 514)
        Me.SplitContainer3.SplitterDistance = 60
        Me.SplitContainer3.TabIndex = 1
        '
        'TxtPatientRefunID
        '
        Me.TxtPatientRefunID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientRefunID.Location = New System.Drawing.Point(102, 19)
        Me.TxtPatientRefunID.Name = "TxtPatientRefunID"
        Me.TxtPatientRefunID.Size = New System.Drawing.Size(160, 26)
        Me.TxtPatientRefunID.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Patient No:"
        '
        'BtnDisplayRefund
        '
        Me.BtnDisplayRefund.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDisplayRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplayRefund.Location = New System.Drawing.Point(613, 16)
        Me.BtnDisplayRefund.Name = "BtnDisplayRefund"
        Me.BtnDisplayRefund.Size = New System.Drawing.Size(80, 29)
        Me.BtnDisplayRefund.TabIndex = 11
        Me.BtnDisplayRefund.Text = "Display"
        Me.BtnDisplayRefund.UseVisualStyleBackColor = True
        '
        'DateRefundTo
        '
        Me.DateRefundTo.Checked = False
        Me.DateRefundTo.CustomFormat = "dd/MM/yyyy"
        Me.DateRefundTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRefundTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRefundTo.Location = New System.Drawing.Point(496, 19)
        Me.DateRefundTo.Name = "DateRefundTo"
        Me.DateRefundTo.Size = New System.Drawing.Size(110, 26)
        Me.DateRefundTo.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(455, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "To :"
        '
        'DateRefundFrom
        '
        Me.DateRefundFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateRefundFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRefundFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRefundFrom.Location = New System.Drawing.Point(328, 19)
        Me.DateRefundFrom.Name = "DateRefundFrom"
        Me.DateRefundFrom.Size = New System.Drawing.Size(111, 26)
        Me.DateRefundFrom.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "From :"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.GridPatientRefund)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.ReportMoneyRefund)
        Me.SplitContainer4.Panel2Collapsed = True
        Me.SplitContainer4.Size = New System.Drawing.Size(1390, 450)
        Me.SplitContainer4.SplitterDistance = 694
        Me.SplitContainer4.TabIndex = 0
        '
        'GridPatientRefund
        '
        Me.GridPatientRefund.ContextMenuStrip = Me.ContextRefund
        GridPatientRefund_DesignTimeLayout.LayoutString = resources.GetString("GridPatientRefund_DesignTimeLayout.LayoutString")
        Me.GridPatientRefund.DesignTimeLayout = GridPatientRefund_DesignTimeLayout
        Me.GridPatientRefund.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPatientRefund.GroupByBoxVisible = False
        Me.GridPatientRefund.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPatientRefund.Location = New System.Drawing.Point(0, 0)
        Me.GridPatientRefund.Name = "GridPatientRefund"
        Me.GridPatientRefund.RecordNavigator = True
        Me.GridPatientRefund.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPatientRefund.Size = New System.Drawing.Size(1388, 448)
        Me.GridPatientRefund.TabIndex = 0
        '
        'ContextRefund
        '
        Me.ContextRefund.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDelRefund})
        Me.ContextRefund.Name = "ContextRefund"
        Me.ContextRefund.Size = New System.Drawing.Size(176, 30)
        '
        'BtnDelRefund
        '
        Me.BtnDelRefund.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnDelRefund.ForeColor = System.Drawing.Color.Red
        Me.BtnDelRefund.Name = "BtnDelRefund"
        Me.BtnDelRefund.Size = New System.Drawing.Size(175, 26)
        Me.BtnDelRefund.Text = "Delete Refund"
        '
        'ReportMoneyRefund
        '
        Me.ReportMoneyRefund.ActiveViewIndex = -1
        Me.ReportMoneyRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportMoneyRefund.DisplayGroupTree = False
        Me.ReportMoneyRefund.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportMoneyRefund.Location = New System.Drawing.Point(0, 0)
        Me.ReportMoneyRefund.Name = "ReportMoneyRefund"
        Me.ReportMoneyRefund.SelectionFormula = ""
        Me.ReportMoneyRefund.Size = New System.Drawing.Size(94, 98)
        Me.ReportMoneyRefund.TabIndex = 0
        Me.ReportMoneyRefund.ViewTimeSelectionFormula = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewRefund, Me.ToolStripSeparator4, Me.btnReportRefund})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1390, 54)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewRefund
        '
        Me.BtnNewRefund.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnNewRefund.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1410160314_PLayer_back
        Me.BtnNewRefund.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewRefund.Name = "BtnNewRefund"
        Me.BtnNewRefund.Size = New System.Drawing.Size(100, 51)
        Me.BtnNewRefund.Text = "New Refund"
        Me.BtnNewRefund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 54)
        '
        'btnReportRefund
        '
        Me.btnReportRefund.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnReportRefund.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.btnReportRefund.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReportRefund.Name = "btnReportRefund"
        Me.btnReportRefund.Size = New System.Drawing.Size(115, 51)
        Me.btnReportRefund.Text = "Report Refund"
        Me.btnReportRefund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1404, 607)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Controls.Add(Me.ToolMenuConsuling)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1396, 574)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "       Patient Counselling       "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1396, 574)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "       Patient Refund       "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer5)
        Me.TabPage3.Controls.Add(Me.ToolStrip2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1396, 574)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "       Appointment     "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 40)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer5.Panel1.Controls.Add(Me.RadByDateCreate)
        Me.SplitContainer5.Panel1.Controls.Add(Me.RadByDateApp)
        Me.SplitContainer5.Panel1.Controls.Add(Me.BtnDisplayAppp)
        Me.SplitContainer5.Panel1.Controls.Add(Me.DateATo)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer5.Panel1.Controls.Add(Me.DateAFrom)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label10)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer5.Size = New System.Drawing.Size(1390, 531)
        Me.SplitContainer5.SplitterDistance = 92
        Me.SplitContainer5.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadByDoctor)
        Me.GroupBox4.Controls.Add(Me.TxtPatientSearchNo)
        Me.GroupBox4.Controls.Add(Me.RadViewByPatientNo)
        Me.GroupBox4.Controls.Add(Me.CboDoctor)
        Me.GroupBox4.Location = New System.Drawing.Point(397, -1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(426, 86)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'RadByDoctor
        '
        Me.RadByDoctor.AutoSize = True
        Me.RadByDoctor.Location = New System.Drawing.Point(6, 53)
        Me.RadByDoctor.Name = "RadByDoctor"
        Me.RadByDoctor.Size = New System.Drawing.Size(101, 24)
        Me.RadByDoctor.TabIndex = 26
        Me.RadByDoctor.Text = "By Doctor:"
        Me.RadByDoctor.UseVisualStyleBackColor = True
        '
        'TxtPatientSearchNo
        '
        Me.TxtPatientSearchNo.Location = New System.Drawing.Point(145, 18)
        Me.TxtPatientSearchNo.Name = "TxtPatientSearchNo"
        Me.TxtPatientSearchNo.Size = New System.Drawing.Size(252, 26)
        Me.TxtPatientSearchNo.TabIndex = 25
        '
        'RadViewByPatientNo
        '
        Me.RadViewByPatientNo.AutoSize = True
        Me.RadViewByPatientNo.Checked = True
        Me.RadViewByPatientNo.Location = New System.Drawing.Point(6, 20)
        Me.RadViewByPatientNo.Name = "RadViewByPatientNo"
        Me.RadViewByPatientNo.Size = New System.Drawing.Size(127, 24)
        Me.RadViewByPatientNo.TabIndex = 24
        Me.RadViewByPatientNo.TabStop = True
        Me.RadViewByPatientNo.Text = "By Patient No:"
        Me.RadViewByPatientNo.UseVisualStyleBackColor = True
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Enabled = False
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(145, 50)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(252, 28)
        Me.CboDoctor.TabIndex = 21
        '
        'RadByDateCreate
        '
        Me.RadByDateCreate.AutoSize = True
        Me.RadByDateCreate.Checked = True
        Me.RadByDateCreate.Location = New System.Drawing.Point(12, 17)
        Me.RadByDateCreate.Name = "RadByDateCreate"
        Me.RadByDateCreate.Size = New System.Drawing.Size(130, 24)
        Me.RadByDateCreate.TabIndex = 23
        Me.RadByDateCreate.TabStop = True
        Me.RadByDateCreate.Text = "By date create"
        Me.RadByDateCreate.UseVisualStyleBackColor = True
        '
        'RadByDateApp
        '
        Me.RadByDateApp.AutoSize = True
        Me.RadByDateApp.Location = New System.Drawing.Point(12, 53)
        Me.RadByDateApp.Name = "RadByDateApp"
        Me.RadByDateApp.Size = New System.Drawing.Size(174, 24)
        Me.RadByDateApp.TabIndex = 22
        Me.RadByDateApp.Text = "By date appointment"
        Me.RadByDateApp.UseVisualStyleBackColor = True
        '
        'BtnDisplayAppp
        '
        Me.BtnDisplayAppp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDisplayAppp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplayAppp.Location = New System.Drawing.Point(829, 8)
        Me.BtnDisplayAppp.Name = "BtnDisplayAppp"
        Me.BtnDisplayAppp.Size = New System.Drawing.Size(159, 77)
        Me.BtnDisplayAppp.TabIndex = 18
        Me.BtnDisplayAppp.Text = "Display"
        Me.BtnDisplayAppp.UseVisualStyleBackColor = True
        '
        'DateATo
        '
        Me.DateATo.Checked = False
        Me.DateATo.CustomFormat = "dd/MM/yyyy"
        Me.DateATo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateATo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateATo.Location = New System.Drawing.Point(251, 50)
        Me.DateATo.Name = "DateATo"
        Me.DateATo.Size = New System.Drawing.Size(139, 26)
        Me.DateATo.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(191, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "To :"
        '
        'DateAFrom
        '
        Me.DateAFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateAFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAFrom.Location = New System.Drawing.Point(251, 12)
        Me.DateAFrom.Name = "DateAFrom"
        Me.DateAFrom.Size = New System.Drawing.Size(140, 26)
        Me.DateAFrom.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(191, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "From :"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.GridAppointment)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.CrystalApp)
        Me.SplitContainer6.Panel2Collapsed = True
        Me.SplitContainer6.Size = New System.Drawing.Size(1390, 435)
        Me.SplitContainer6.SplitterDistance = 740
        Me.SplitContainer6.TabIndex = 0
        '
        'GridAppointment
        '
        Me.GridAppointment.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAppointment.ContextMenuStrip = Me.CMCallPatient
        GridAppointment_DesignTimeLayout.LayoutString = resources.GetString("GridAppointment_DesignTimeLayout.LayoutString")
        Me.GridAppointment.DesignTimeLayout = GridAppointment_DesignTimeLayout
        Me.GridAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridAppointment.GroupByBoxVisible = False
        Me.GridAppointment.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridAppointment.Location = New System.Drawing.Point(0, 0)
        Me.GridAppointment.Name = "GridAppointment"
        Me.GridAppointment.RecordNavigator = True
        Me.GridAppointment.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridAppointment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAppointment.Size = New System.Drawing.Size(1390, 435)
        Me.GridAppointment.TabIndex = 0
        '
        'CMCallPatient
        '
        Me.CMCallPatient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnCallPatient})
        Me.CMCallPatient.Name = "MenuConsulting"
        Me.CMCallPatient.Size = New System.Drawing.Size(169, 26)
        '
        'BtnCallPatient
        '
        Me.BtnCallPatient.Name = "BtnCallPatient"
        Me.BtnCallPatient.Size = New System.Drawing.Size(168, 22)
        Me.BtnCallPatient.Text = "Upate Call Patient"
        '
        'CrystalApp
        '
        Me.CrystalApp.ActiveViewIndex = -1
        Me.CrystalApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalApp.DisplayGroupTree = False
        Me.CrystalApp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalApp.Location = New System.Drawing.Point(0, 0)
        Me.CrystalApp.Name = "CrystalApp"
        Me.CrystalApp.SelectionFormula = ""
        Me.CrystalApp.Size = New System.Drawing.Size(96, 100)
        Me.CrystalApp.TabIndex = 0
        Me.CrystalApp.ViewTimeSelectionFormula = ""
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewAppoint, Me.ToolStripSeparator6, Me.ToolStripButton2, Me.ToolStripSeparator7, Me.BtnReportApp, Me.ToolStripSeparator8, Me.ToolStripSplitButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1390, 37)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnNewAppoint
        '
        Me.BtnNewAppoint.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Open
        Me.BtnNewAppoint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewAppoint.Name = "BtnNewAppoint"
        Me.BtnNewAppoint.Size = New System.Drawing.Size(139, 34)
        Me.BtnNewAppoint.Text = "New Appointment"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(123, 34)
        Me.ToolStripButton2.Text = "Update On App"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 37)
        '
        'BtnReportApp
        '
        Me.BtnReportApp.Image = Global.TakeoHospitalInventory.My.Resources.Resources.printer
        Me.BtnReportApp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReportApp.Name = "BtnReportApp"
        Me.BtnReportApp.Size = New System.Drawing.Size(150, 34)
        Me.BtnReportApp.Text = "Appointment Report"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.UpdateOnAppointmentToolStripMenuItem, Me.ToolStripMenuItem3, Me.DeleteAppointmentToolStripMenuItem})
        Me.ToolStripSplitButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(130, 34)
        Me.ToolStripSplitButton1.Text = "Update Untility"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(247, 6)
        '
        'UpdateOnAppointmentToolStripMenuItem
        '
        Me.UpdateOnAppointmentToolStripMenuItem.Name = "UpdateOnAppointmentToolStripMenuItem"
        Me.UpdateOnAppointmentToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.UpdateOnAppointmentToolStripMenuItem.Text = "Update On Appointment"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(247, 6)
        '
        'DeleteAppointmentToolStripMenuItem
        '
        Me.DeleteAppointmentToolStripMenuItem.Name = "DeleteAppointmentToolStripMenuItem"
        Me.DeleteAppointmentToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.DeleteAppointmentToolStripMenuItem.Text = "Delete Appointment"
        '
        'ErrCounselling
        '
        Me.ErrCounselling.ContainerControl = Me
        '
        'MainConsuling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainConsuling"
        Me.Size = New System.Drawing.Size(1404, 607)
        Me.ToolMenuConsuling.ResumeLayout(False)
        Me.ToolMenuConsuling.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridConsulting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuConsulting.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.GridPatientRefund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextRefund.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.GridAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMCallPatient.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.ErrCounselling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolMenuConsuling As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewConsulting As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BgLoadConsult As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnConsultReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnConsultForm As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuConsulting As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuApprove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteConsult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridConsulting As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadForNewPatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadForOpticalShop As System.Windows.Forms.RadioButton
    Friend WithEvents RadForInPatient As System.Windows.Forms.RadioButton
    Friend WithEvents RadForOld As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllConsult As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewRefund As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnReportRefund As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TxtPatientRefunID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnDisplayRefund As System.Windows.Forms.Button
    Friend WithEvents DateRefundTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateRefundFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridPatientRefund As Janus.Windows.GridEX.GridEX
    Friend WithEvents ReportMoneyRefund As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ContextRefund As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDelRefund As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnStatistic As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewAppoint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReportApp As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridAppointment As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnDisplayAppp As System.Windows.Forms.Button
    Friend WithEvents DateATo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateAFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CrystalApp As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateOnAppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteAppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents ErrCounselling As System.Windows.Forms.ErrorProvider
    Friend WithEvents CMCallPatient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnCallPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadByDateApp As System.Windows.Forms.RadioButton
    Friend WithEvents RadByDateCreate As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadByDoctor As System.Windows.Forms.RadioButton
    Friend WithEvents TxtPatientSearchNo As System.Windows.Forms.TextBox
    Friend WithEvents RadViewByPatientNo As System.Windows.Forms.RadioButton

End Class
