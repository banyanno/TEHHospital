<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatientDischarged
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPatientDischarged))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridUndoInPatient = New System.Windows.Forms.DataGridView
        Me.ContextPatientDischarged = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnMenuCall = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MUndo = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnFollowUp = New System.Windows.Forms.Button
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.ChDoctor = New System.Windows.Forms.CheckBox
        Me.BtnReport = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CrViewerLeave = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ErrDischarge = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NewInPatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IS_CALL = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IS_PATIEN_FOLLOWUP = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameEng = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eye = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diagnosis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_RE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_LE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDischarge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateFollowUp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Signature = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Leave = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Waiting = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeDiagnosis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeleteOption = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DR_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALL_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALL_NOTED = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OT_ISCANCEL = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.OTCANCEL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTCANCEL_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTCANCEL_NOTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IS_VA_OPERATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_DR_SURGEON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_SURGEON_ONEYE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_SURGEON_PLAIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_SURGEON_ICPH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridUndoInPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextPatientDischarged.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ErrDischarge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridUndoInPatient)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1004, 626)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Patient Discharged"
        '
        'GridUndoInPatient
        '
        Me.GridUndoInPatient.AllowUserToAddRows = False
        Me.GridUndoInPatient.AllowUserToDeleteRows = False
        Me.GridUndoInPatient.BackgroundColor = System.Drawing.Color.White
        Me.GridUndoInPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridUndoInPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUndoInPatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NewInPatientNo, Me.IS_CALL, Me.IS_PATIEN_FOLLOWUP, Me.PatientNo, Me.NameKhmer, Me.NameEng, Me.Age, Me.Sex, Me.Telephone, Me.Address, Me.Eye, Me.Diagnosis, Me.VA_RE, Me.VA_LE, Me.DateDischarge, Me.DateFollowUp, Me.Signature, Me.Leave, Me.CreateDate, Me.Waiting, Me.TypeDiagnosis, Me.DeleteOption, Me.DR_NAME, Me.CALL_DATE, Me.CALL_NOTED, Me.OT_ISCANCEL, Me.OTCANCEL, Me.OTCANCEL_DATE, Me.OTCANCEL_NOTE, Me.IS_VA_OPERATE, Me.VA_DR_SURGEON, Me.VA_SURGEON_ONEYE, Me.VA_SURGEON_PLAIN, Me.VA_SURGEON_ICPH})
        Me.GridUndoInPatient.ContextMenuStrip = Me.ContextPatientDischarged
        Me.GridUndoInPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUndoInPatient.Location = New System.Drawing.Point(4, 20)
        Me.GridUndoInPatient.Margin = New System.Windows.Forms.Padding(4)
        Me.GridUndoInPatient.Name = "GridUndoInPatient"
        Me.GridUndoInPatient.ReadOnly = True
        Me.GridUndoInPatient.RowHeadersWidth = 100
        Me.GridUndoInPatient.RowTemplate.Height = 35
        Me.GridUndoInPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridUndoInPatient.Size = New System.Drawing.Size(996, 602)
        Me.GridUndoInPatient.TabIndex = 0
        '
        'ContextPatientDischarged
        '
        Me.ContextPatientDischarged.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnMenuCall, Me.ToolStripSeparator1, Me.MUndo})
        Me.ContextPatientDischarged.Name = "ContextUndoInPatient"
        Me.ContextPatientDischarged.Size = New System.Drawing.Size(166, 54)
        '
        'BtnMenuCall
        '
        Me.BtnMenuCall.Name = "BtnMenuCall"
        Me.BtnMenuCall.Size = New System.Drawing.Size(165, 22)
        Me.BtnMenuCall.Text = "Update Called"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'MUndo
        '
        Me.MUndo.Name = "MUndo"
        Me.MUndo.Size = New System.Drawing.Size(165, 22)
        Me.MUndo.Text = "Undo Discharged"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnFollowUp)
        Me.GroupBox1.Controls.Add(Me.CboDoctor)
        Me.GroupBox1.Controls.Add(Me.ChDoctor)
        Me.GroupBox1.Controls.Add(Me.BtnReport)
        Me.GroupBox1.Controls.Add(Me.BtnFind)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1284, 120)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Patient Discharged Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1001, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Select Date Discharge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1001, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Select Date Followup"
        '
        'BtnFollowUp
        '
        Me.BtnFollowUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFollowUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFollowUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFollowUp.Location = New System.Drawing.Point(800, 20)
        Me.BtnFollowUp.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFollowUp.Name = "BtnFollowUp"
        Me.BtnFollowUp.Size = New System.Drawing.Size(194, 36)
        Me.BtnFollowUp.TabIndex = 7
        Me.BtnFollowUp.Text = "Report Patient Follow Up"
        Me.BtnFollowUp.UseVisualStyleBackColor = True
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Enabled = False
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(412, 28)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(199, 28)
        Me.CboDoctor.TabIndex = 6
        '
        'ChDoctor
        '
        Me.ChDoctor.AutoSize = True
        Me.ChDoctor.Location = New System.Drawing.Point(294, 34)
        Me.ChDoctor.Name = "ChDoctor"
        Me.ChDoctor.Size = New System.Drawing.Size(122, 22)
        Me.ChDoctor.TabIndex = 5
        Me.ChDoctor.Text = "Select Doctor:"
        Me.ChDoctor.UseVisualStyleBackColor = True
        '
        'BtnReport
        '
        Me.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReport.Location = New System.Drawing.Point(800, 59)
        Me.BtnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(194, 36)
        Me.BtnReport.TabIndex = 4
        Me.BtnReport.Text = "Report Patient Discharge"
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFind.Location = New System.Drawing.Point(634, 22)
        Me.BtnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(147, 72)
        Me.BtnFind.TabIndex = 3
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(99, 30)
        Me.TxtPatientNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(188, 26)
        Me.TxtPatientNo.TabIndex = 2
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(382, 72)
        Me.DateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(229, 26)
        Me.DateTo.TabIndex = 1
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(99, 72)
        Me.DateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(188, 26)
        Me.DateFrom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(291, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 120)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrViewerLeave)
        Me.SplitContainer1.Size = New System.Drawing.Size(1284, 626)
        Me.SplitContainer1.SplitterDistance = 1004
        Me.SplitContainer1.TabIndex = 4
        '
        'CrViewerLeave
        '
        Me.CrViewerLeave.ActiveViewIndex = -1
        Me.CrViewerLeave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerLeave.DisplayGroupTree = False
        Me.CrViewerLeave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrViewerLeave.Location = New System.Drawing.Point(0, 0)
        Me.CrViewerLeave.Name = "CrViewerLeave"
        Me.CrViewerLeave.SelectionFormula = ""
        Me.CrViewerLeave.Size = New System.Drawing.Size(276, 626)
        Me.CrViewerLeave.TabIndex = 0
        Me.CrViewerLeave.ViewTimeSelectionFormula = ""
        '
        'ErrDischarge
        '
        Me.ErrDischarge.ContainerControl = Me
        '
        'NewInPatientNo
        '
        Me.NewInPatientNo.DataPropertyName = "NewInPatientNo"
        Me.NewInPatientNo.HeaderText = "NewInPatientNo"
        Me.NewInPatientNo.Name = "NewInPatientNo"
        Me.NewInPatientNo.ReadOnly = True
        Me.NewInPatientNo.Visible = False
        '
        'IS_CALL
        '
        Me.IS_CALL.DataPropertyName = "IS_CALL"
        Me.IS_CALL.HeaderText = "Is Called"
        Me.IS_CALL.Name = "IS_CALL"
        Me.IS_CALL.ReadOnly = True
        Me.IS_CALL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IS_CALL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IS_PATIEN_FOLLOWUP
        '
        Me.IS_PATIEN_FOLLOWUP.DataPropertyName = "IS_PATIEN_FOLLOWUP"
        Me.IS_PATIEN_FOLLOWUP.HeaderText = " Patient is Followup"
        Me.IS_PATIEN_FOLLOWUP.Name = "IS_PATIEN_FOLLOWUP"
        Me.IS_PATIEN_FOLLOWUP.ReadOnly = True
        '
        'PatientNo
        '
        Me.PatientNo.DataPropertyName = "PatientNo"
        Me.PatientNo.HeaderText = "Patient No"
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        '
        'NameKhmer
        '
        Me.NameKhmer.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Wat Phnom T3", 11.0!)
        Me.NameKhmer.DefaultCellStyle = DataGridViewCellStyle1
        Me.NameKhmer.FillWeight = 120.0!
        Me.NameKhmer.HeaderText = "Khmer Name"
        Me.NameKhmer.Name = "NameKhmer"
        Me.NameKhmer.ReadOnly = True
        Me.NameKhmer.Width = 120
        '
        'NameEng
        '
        Me.NameEng.DataPropertyName = "NameEng"
        Me.NameEng.FillWeight = 120.0!
        Me.NameEng.HeaderText = "English Name"
        Me.NameEng.Name = "NameEng"
        Me.NameEng.ReadOnly = True
        Me.NameEng.Width = 120
        '
        'Age
        '
        Me.Age.DataPropertyName = "Age"
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.FillWeight = 40.0!
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.ReadOnly = True
        Me.Sex.Width = 40
        '
        'Telephone
        '
        Me.Telephone.DataPropertyName = "Telephone"
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.ReadOnly = True
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'Eye
        '
        Me.Eye.DataPropertyName = "Eye"
        Me.Eye.HeaderText = "Eye"
        Me.Eye.Name = "Eye"
        Me.Eye.ReadOnly = True
        '
        'Diagnosis
        '
        Me.Diagnosis.DataPropertyName = "Diagnosis"
        Me.Diagnosis.HeaderText = "Diagnosis"
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.ReadOnly = True
        '
        'VA_RE
        '
        Me.VA_RE.DataPropertyName = "VA_RE"
        Me.VA_RE.FillWeight = 80.0!
        Me.VA_RE.HeaderText = "VA RE"
        Me.VA_RE.Name = "VA_RE"
        Me.VA_RE.ReadOnly = True
        Me.VA_RE.Width = 80
        '
        'VA_LE
        '
        Me.VA_LE.DataPropertyName = "VA_LE"
        Me.VA_LE.FillWeight = 80.0!
        Me.VA_LE.HeaderText = "VA LE"
        Me.VA_LE.Name = "VA_LE"
        Me.VA_LE.ReadOnly = True
        Me.VA_LE.Width = 80
        '
        'DateDischarge
        '
        Me.DateDischarge.DataPropertyName = "DateDischarge"
        Me.DateDischarge.FillWeight = 135.0!
        Me.DateDischarge.HeaderText = "Date Discharge"
        Me.DateDischarge.Name = "DateDischarge"
        Me.DateDischarge.ReadOnly = True
        Me.DateDischarge.Width = 135
        '
        'DateFollowUp
        '
        Me.DateFollowUp.DataPropertyName = "DateFollowUp"
        Me.DateFollowUp.FillWeight = 130.0!
        Me.DateFollowUp.HeaderText = "Date FollowUp"
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.ReadOnly = True
        Me.DateFollowUp.Width = 130
        '
        'Signature
        '
        Me.Signature.DataPropertyName = "Signature"
        Me.Signature.HeaderText = "Signature"
        Me.Signature.Name = "Signature"
        Me.Signature.ReadOnly = True
        Me.Signature.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Signature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Leave
        '
        Me.Leave.DataPropertyName = "Leave"
        Me.Leave.HeaderText = "Leave"
        Me.Leave.Name = "Leave"
        Me.Leave.ReadOnly = True
        '
        'CreateDate
        '
        Me.CreateDate.DataPropertyName = "CreateDate"
        Me.CreateDate.FillWeight = 120.0!
        Me.CreateDate.HeaderText = "Create Date"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        Me.CreateDate.Width = 120
        '
        'Waiting
        '
        Me.Waiting.DataPropertyName = "Waiting"
        Me.Waiting.HeaderText = "Waiting"
        Me.Waiting.Name = "Waiting"
        Me.Waiting.ReadOnly = True
        Me.Waiting.Visible = False
        '
        'TypeDiagnosis
        '
        Me.TypeDiagnosis.DataPropertyName = "TypeDiagnosis"
        Me.TypeDiagnosis.HeaderText = "TypeDiagnosis"
        Me.TypeDiagnosis.Name = "TypeDiagnosis"
        Me.TypeDiagnosis.ReadOnly = True
        Me.TypeDiagnosis.Visible = False
        '
        'DeleteOption
        '
        Me.DeleteOption.DataPropertyName = "DeleteOption"
        Me.DeleteOption.HeaderText = "DeleteOption"
        Me.DeleteOption.Name = "DeleteOption"
        Me.DeleteOption.ReadOnly = True
        Me.DeleteOption.Visible = False
        '
        'DR_NAME
        '
        Me.DR_NAME.DataPropertyName = "DR_NAME"
        Me.DR_NAME.HeaderText = "Doctor Name"
        Me.DR_NAME.Name = "DR_NAME"
        Me.DR_NAME.ReadOnly = True
        Me.DR_NAME.Width = 200
        '
        'CALL_DATE
        '
        Me.CALL_DATE.DataPropertyName = "CALL_DATE"
        Me.CALL_DATE.HeaderText = "Date Called"
        Me.CALL_DATE.Name = "CALL_DATE"
        Me.CALL_DATE.ReadOnly = True
        '
        'CALL_NOTED
        '
        Me.CALL_NOTED.DataPropertyName = "CALL_NOTED"
        Me.CALL_NOTED.HeaderText = "Call Noted"
        Me.CALL_NOTED.Name = "CALL_NOTED"
        Me.CALL_NOTED.ReadOnly = True
        '
        'OT_ISCANCEL
        '
        Me.OT_ISCANCEL.DataPropertyName = "OT_ISCANCEL"
        Me.OT_ISCANCEL.HeaderText = "Is OT Cancel"
        Me.OT_ISCANCEL.Name = "OT_ISCANCEL"
        Me.OT_ISCANCEL.ReadOnly = True
        Me.OT_ISCANCEL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OT_ISCANCEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'OTCANCEL
        '
        Me.OTCANCEL.DataPropertyName = "OTCANCEL"
        Me.OTCANCEL.HeaderText = "OT Cancel Type"
        Me.OTCANCEL.Name = "OTCANCEL"
        Me.OTCANCEL.ReadOnly = True
        '
        'OTCANCEL_DATE
        '
        Me.OTCANCEL_DATE.DataPropertyName = "OTCANCEL_DATE"
        Me.OTCANCEL_DATE.HeaderText = "OT Cancel Date"
        Me.OTCANCEL_DATE.Name = "OTCANCEL_DATE"
        Me.OTCANCEL_DATE.ReadOnly = True
        '
        'OTCANCEL_NOTE
        '
        Me.OTCANCEL_NOTE.DataPropertyName = "OTCANCEL_NOTE"
        Me.OTCANCEL_NOTE.HeaderText = "OT Cancel Note"
        Me.OTCANCEL_NOTE.Name = "OTCANCEL_NOTE"
        Me.OTCANCEL_NOTE.ReadOnly = True
        '
        'IS_VA_OPERATE
        '
        Me.IS_VA_OPERATE.DataPropertyName = "IS_VA_OPERATE"
        Me.IS_VA_OPERATE.HeaderText = "VA Surgeon"
        Me.IS_VA_OPERATE.Name = "IS_VA_OPERATE"
        Me.IS_VA_OPERATE.ReadOnly = True
        '
        'VA_DR_SURGEON
        '
        Me.VA_DR_SURGEON.DataPropertyName = "VA_DR_SURGEON"
        Me.VA_DR_SURGEON.HeaderText = "Dr. Surgeon"
        Me.VA_DR_SURGEON.Name = "VA_DR_SURGEON"
        Me.VA_DR_SURGEON.ReadOnly = True
        '
        'VA_SURGEON_ONEYE
        '
        Me.VA_SURGEON_ONEYE.DataPropertyName = "VA_SURGEON_ONEYE"
        Me.VA_SURGEON_ONEYE.HeaderText = "Surgeon On Eye"
        Me.VA_SURGEON_ONEYE.Name = "VA_SURGEON_ONEYE"
        Me.VA_SURGEON_ONEYE.ReadOnly = True
        '
        'VA_SURGEON_PLAIN
        '
        Me.VA_SURGEON_PLAIN.DataPropertyName = "VA_SURGEON_PLAIN"
        Me.VA_SURGEON_PLAIN.HeaderText = "VA Plain after Surgeon"
        Me.VA_SURGEON_PLAIN.Name = "VA_SURGEON_PLAIN"
        Me.VA_SURGEON_PLAIN.ReadOnly = True
        '
        'VA_SURGEON_ICPH
        '
        Me.VA_SURGEON_ICPH.DataPropertyName = "VA_SURGEON_ICPH"
        Me.VA_SURGEON_ICPH.HeaderText = "VA i/c PH after Surgeon"
        Me.VA_SURGEON_ICPH.Name = "VA_SURGEON_ICPH"
        Me.VA_SURGEON_ICPH.ReadOnly = True
        '
        'FormPatientDischarged
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 746)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPatientDischarged"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Discharged"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridUndoInPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextPatientDischarged.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ErrDischarge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridUndoInPatient As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextPatientDischarged As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnReport As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrViewerLeave As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents ChDoctor As System.Windows.Forms.CheckBox
    Friend WithEvents BtnFollowUp As System.Windows.Forms.Button
    Friend WithEvents ErrDischarge As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnMenuCall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NewInPatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IS_CALL As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IS_PATIEN_FOLLOWUP As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameEng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eye As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diagnosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_RE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_LE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDischarge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFollowUp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Signature As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Leave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Waiting As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDiagnosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteOption As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DR_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALL_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALL_NOTED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OT_ISCANCEL As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OTCANCEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTCANCEL_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTCANCEL_NOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IS_VA_OPERATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_DR_SURGEON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_SURGEON_ONEYE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_SURGEON_PLAIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_SURGEON_ICPH As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
