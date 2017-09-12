<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCOT_AND_IOLList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCOT_AND_IOLList))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmdUndoDeleteOT = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnStatistic = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnFindHistory = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.TxtFindPatientNo = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnShow = New System.Windows.Forms.Button
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridOTRegistration = New System.Windows.Forms.DataGridView
        Me.OTNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewInPatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Referal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OperationTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Anesthesia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Anesthetist = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IOL_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eye = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OperationType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Surgeon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Assistant = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Circulation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Compli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateOperated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Others = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Waiting = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IOL_ID_OLD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuNewInPatient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuOperationReady = New System.Windows.Forms.ToolStripMenuItem
        Me.ReadyToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteOTRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnCreateIOL = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnOperationReady = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridIOL = New System.Windows.Forms.DataGridView
        Me.IOLNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTNoIOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Surgeon1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eye1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IOLNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuIOL = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteIOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.bgCutstock = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridOTRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuNewInPatient.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridIOL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuIOL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1032, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdUndoDeleteOT)
        Me.GroupBox6.Location = New System.Drawing.Point(714, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(208, 132)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Undo Delete OT"
        '
        'cmdUndoDeleteOT
        '
        Me.cmdUndoDeleteOT.Location = New System.Drawing.Point(49, 48)
        Me.cmdUndoDeleteOT.Name = "cmdUndoDeleteOT"
        Me.cmdUndoDeleteOT.Size = New System.Drawing.Size(116, 51)
        Me.cmdUndoDeleteOT.TabIndex = 0
        Me.cmdUndoDeleteOT.Text = "&Undo Delete OT"
        Me.cmdUndoDeleteOT.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnStatistic)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.BtnFindHistory)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.DateTo)
        Me.GroupBox5.Controls.Add(Me.DateFrom)
        Me.GroupBox5.Controls.Add(Me.TxtFindPatientNo)
        Me.GroupBox5.Location = New System.Drawing.Point(353, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(355, 133)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Search History Patient In Operation by"
        '
        'BtnStatistic
        '
        Me.BtnStatistic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatistic.Location = New System.Drawing.Point(258, 29)
        Me.BtnStatistic.Name = "BtnStatistic"
        Me.BtnStatistic.Size = New System.Drawing.Size(91, 42)
        Me.BtnStatistic.TabIndex = 3
        Me.BtnStatistic.Text = "Statistic"
        Me.BtnStatistic.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "To:"
        '
        'BtnFindHistory
        '
        Me.BtnFindHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindHistory.Location = New System.Drawing.Point(258, 77)
        Me.BtnFindHistory.Name = "BtnFindHistory"
        Me.BtnFindHistory.Size = New System.Drawing.Size(89, 46)
        Me.BtnFindHistory.TabIndex = 2
        Me.BtnFindHistory.Text = "&Find"
        Me.BtnFindHistory.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient No:"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(78, 97)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(174, 26)
        Me.DateTo.TabIndex = 2
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(78, 65)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(174, 26)
        Me.DateFrom.TabIndex = 2
        '
        'TxtFindPatientNo
        '
        Me.TxtFindPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindPatientNo.Location = New System.Drawing.Point(78, 29)
        Me.TxtFindPatientNo.Name = "TxtFindPatientNo"
        Me.TxtFindPatientNo.Size = New System.Drawing.Size(174, 29)
        Me.TxtFindPatientNo.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnShow)
        Me.GroupBox4.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 133)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Find Patient Waiting Operate"
        '
        'BtnShow
        '
        Me.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShow.Location = New System.Drawing.Point(236, 59)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(89, 32)
        Me.BtnShow.TabIndex = 2
        Me.BtnShow.Text = "&Find"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(11, 63)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(220, 29)
        Me.TxtPatientNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SplitContainer1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1032, 654)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OT Registration"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridOTRegistration)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1026, 635)
        Me.SplitContainer1.SplitterDistance = 408
        Me.SplitContainer1.TabIndex = 0
        '
        'GridOTRegistration
        '
        Me.GridOTRegistration.AllowUserToAddRows = False
        Me.GridOTRegistration.AllowUserToDeleteRows = False
        Me.GridOTRegistration.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridOTRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridOTRegistration.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridOTRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOTRegistration.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OTNo, Me.NewInPatientNo, Me.PatientNo, Me.NameKhmer1, Me.Age, Me.Sex, Me.Referal, Me.Address, Me.OperationTime, Me.Anesthesia, Me.Anesthetist, Me.IOL_ID, Me.Eye, Me.OperationType, Me.IOL, Me.Surgeon, Me.Assistant, Me.Circulation, Me.Compli, Me.CreateDate, Me.DateOperated, Me.Others, Me.Waiting, Me.Status, Me.IOL_ID_OLD})
        Me.GridOTRegistration.ContextMenuStrip = Me.ContextMenuNewInPatient
        Me.GridOTRegistration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOTRegistration.Location = New System.Drawing.Point(0, 25)
        Me.GridOTRegistration.Name = "GridOTRegistration"
        Me.GridOTRegistration.ReadOnly = True
        Me.GridOTRegistration.RowHeadersWidth = 50
        Me.GridOTRegistration.RowTemplate.Height = 35
        Me.GridOTRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridOTRegistration.Size = New System.Drawing.Size(1026, 383)
        Me.GridOTRegistration.TabIndex = 0
        '
        'OTNo
        '
        Me.OTNo.DataPropertyName = "OTNo"
        Me.OTNo.HeaderText = "No"
        Me.OTNo.Name = "OTNo"
        Me.OTNo.ReadOnly = True
        Me.OTNo.Visible = False
        '
        'NewInPatientNo
        '
        Me.NewInPatientNo.DataPropertyName = "NewInPatientNo"
        Me.NewInPatientNo.HeaderText = "New Inno"
        Me.NewInPatientNo.Name = "NewInPatientNo"
        Me.NewInPatientNo.ReadOnly = True
        Me.NewInPatientNo.Visible = False
        '
        'PatientNo
        '
        Me.PatientNo.DataPropertyName = "PatientNo"
        Me.PatientNo.HeaderText = "PatientNo"
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        '
        'NameKhmer1
        '
        Me.NameKhmer1.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.NameKhmer1.DefaultCellStyle = DataGridViewCellStyle2
        Me.NameKhmer1.HeaderText = "Patient Name"
        Me.NameKhmer1.Name = "NameKhmer1"
        Me.NameKhmer1.ReadOnly = True
        '
        'Age
        '
        Me.Age.DataPropertyName = "Age"
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        Me.Age.Width = 50
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.ReadOnly = True
        Me.Sex.Width = 50
        '
        'Referal
        '
        Me.Referal.DataPropertyName = "Referal"
        Me.Referal.HeaderText = "Referal By"
        Me.Referal.Name = "Referal"
        Me.Referal.ReadOnly = True
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'OperationTime
        '
        Me.OperationTime.DataPropertyName = "OperationTime"
        Me.OperationTime.HeaderText = "Operation Time"
        Me.OperationTime.Name = "OperationTime"
        Me.OperationTime.ReadOnly = True
        Me.OperationTime.Width = 110
        '
        'Anesthesia
        '
        Me.Anesthesia.DataPropertyName = "Anesthesia"
        Me.Anesthesia.HeaderText = "Anesthesia"
        Me.Anesthesia.Name = "Anesthesia"
        Me.Anesthesia.ReadOnly = True
        '
        'Anesthetist
        '
        Me.Anesthetist.DataPropertyName = "Anesthetist"
        Me.Anesthetist.HeaderText = "Anesthetist"
        Me.Anesthetist.Name = "Anesthetist"
        Me.Anesthetist.ReadOnly = True
        '
        'IOL_ID
        '
        Me.IOL_ID.DataPropertyName = "IOL_ID"
        Me.IOL_ID.HeaderText = "IOL_ID"
        Me.IOL_ID.Name = "IOL_ID"
        Me.IOL_ID.ReadOnly = True
        Me.IOL_ID.Visible = False
        '
        'Eye
        '
        Me.Eye.DataPropertyName = "Eye"
        Me.Eye.HeaderText = "Eye"
        Me.Eye.Name = "Eye"
        Me.Eye.ReadOnly = True
        Me.Eye.Width = 80
        '
        'OperationType
        '
        Me.OperationType.DataPropertyName = "OperationType"
        Me.OperationType.HeaderText = "Operation Type"
        Me.OperationType.Name = "OperationType"
        Me.OperationType.ReadOnly = True
        Me.OperationType.Width = 150
        '
        'IOL
        '
        Me.IOL.DataPropertyName = "IOL"
        Me.IOL.HeaderText = "IOL"
        Me.IOL.Name = "IOL"
        Me.IOL.ReadOnly = True
        Me.IOL.Width = 50
        '
        'Surgeon
        '
        Me.Surgeon.DataPropertyName = "Surgeon"
        Me.Surgeon.HeaderText = "Surgeon"
        Me.Surgeon.Name = "Surgeon"
        Me.Surgeon.ReadOnly = True
        '
        'Assistant
        '
        Me.Assistant.DataPropertyName = "Assistant"
        Me.Assistant.HeaderText = "Assistant"
        Me.Assistant.Name = "Assistant"
        Me.Assistant.ReadOnly = True
        '
        'Circulation
        '
        Me.Circulation.DataPropertyName = "Circulation"
        Me.Circulation.HeaderText = "Circulation"
        Me.Circulation.Name = "Circulation"
        Me.Circulation.ReadOnly = True
        '
        'Compli
        '
        Me.Compli.DataPropertyName = "Compli"
        Me.Compli.HeaderText = "Compli"
        Me.Compli.Name = "Compli"
        Me.Compli.ReadOnly = True
        '
        'CreateDate
        '
        Me.CreateDate.DataPropertyName = "CreateDate"
        Me.CreateDate.HeaderText = "Date Prepare OT"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        Me.CreateDate.Width = 150
        '
        'DateOperated
        '
        Me.DateOperated.DataPropertyName = "DateOperated"
        Me.DateOperated.HeaderText = "Date Operated"
        Me.DateOperated.Name = "DateOperated"
        Me.DateOperated.ReadOnly = True
        Me.DateOperated.Width = 150
        '
        'Others
        '
        Me.Others.DataPropertyName = "Others"
        Me.Others.HeaderText = "Others"
        Me.Others.Name = "Others"
        Me.Others.ReadOnly = True
        '
        'Waiting
        '
        Me.Waiting.DataPropertyName = "Waiting"
        Me.Waiting.HeaderText = "Waiting"
        Me.Waiting.Name = "Waiting"
        Me.Waiting.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IOL_ID_OLD
        '
        Me.IOL_ID_OLD.DataPropertyName = "IOL_ID_OLD"
        Me.IOL_ID_OLD.HeaderText = "IOL_ID_OLD"
        Me.IOL_ID_OLD.Name = "IOL_ID_OLD"
        Me.IOL_ID_OLD.ReadOnly = True
        Me.IOL_ID_OLD.Visible = False
        '
        'ContextMenuNewInPatient
        '
        Me.ContextMenuNewInPatient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.MenuOperationReady, Me.ReadyToolStripMenuItem, Me.DeleteOTRegistrationToolStripMenuItem})
        Me.ContextMenuNewInPatient.Name = "ContextMenuNewInPatient"
        Me.ContextMenuNewInPatient.Size = New System.Drawing.Size(196, 82)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem1.Text = "Create IOL Registration"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'MenuOperationReady
        '
        Me.MenuOperationReady.Name = "MenuOperationReady"
        Me.MenuOperationReady.Size = New System.Drawing.Size(195, 22)
        Me.MenuOperationReady.Text = "Operation Ready"
        '
        'ReadyToolStripMenuItem
        '
        Me.ReadyToolStripMenuItem.Name = "ReadyToolStripMenuItem"
        Me.ReadyToolStripMenuItem.Size = New System.Drawing.Size(192, 6)
        '
        'DeleteOTRegistrationToolStripMenuItem
        '
        Me.DeleteOTRegistrationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteOTRegistrationToolStripMenuItem.Name = "DeleteOTRegistrationToolStripMenuItem"
        Me.DeleteOTRegistrationToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DeleteOTRegistrationToolStripMenuItem.Text = "Delete OT Registration"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnCreateIOL, Me.ToolStripSeparator2, Me.BtnOperationReady, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1026, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnCreateIOL
        '
        Me.BtnCreateIOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnCreateIOL.Image = CType(resources.GetObject("BtnCreateIOL.Image"), System.Drawing.Image)
        Me.BtnCreateIOL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCreateIOL.Name = "BtnCreateIOL"
        Me.BtnCreateIOL.Size = New System.Drawing.Size(132, 22)
        Me.BtnCreateIOL.Text = "Create IOL Registration"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnOperationReady
        '
        Me.BtnOperationReady.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnOperationReady.Image = CType(resources.GetObject("BtnOperationReady.Image"), System.Drawing.Image)
        Me.BtnOperationReady.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOperationReady.Name = "BtnOperationReady"
        Me.BtnOperationReady.Size = New System.Drawing.Size(99, 22)
        Me.BtnOperationReady.Text = "Operation Ready"
        Me.BtnOperationReady.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridIOL)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1026, 223)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "IOL"
        '
        'GridIOL
        '
        Me.GridIOL.AllowUserToAddRows = False
        Me.GridIOL.AllowUserToDeleteRows = False
        Me.GridIOL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridIOL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridIOL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridIOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridIOL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IOLNo, Me.OTNoIOL, Me.PatientNo1, Me.NameKhmer, Me.Age1, Me.Sex1, Me.Surgeon1, Me.Eye1, Me.IOLNumber, Me.CreateDate1, Me.OTNo1})
        Me.GridIOL.ContextMenuStrip = Me.ContextMenuIOL
        Me.GridIOL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridIOL.Location = New System.Drawing.Point(3, 16)
        Me.GridIOL.Name = "GridIOL"
        Me.GridIOL.ReadOnly = True
        Me.GridIOL.RowHeadersWidth = 25
        Me.GridIOL.RowTemplate.Height = 35
        Me.GridIOL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridIOL.Size = New System.Drawing.Size(1020, 204)
        Me.GridIOL.TabIndex = 0
        '
        'IOLNo
        '
        Me.IOLNo.DataPropertyName = "IOLNo"
        Me.IOLNo.HeaderText = "IOLNo"
        Me.IOLNo.Name = "IOLNo"
        Me.IOLNo.ReadOnly = True
        Me.IOLNo.Visible = False
        '
        'OTNoIOL
        '
        Me.OTNoIOL.DataPropertyName = "OTNo"
        Me.OTNoIOL.HeaderText = "OTNo"
        Me.OTNoIOL.Name = "OTNoIOL"
        Me.OTNoIOL.ReadOnly = True
        Me.OTNoIOL.Visible = False
        '
        'PatientNo1
        '
        Me.PatientNo1.DataPropertyName = "PatientNo"
        Me.PatientNo1.HeaderText = "PatientNo"
        Me.PatientNo1.Name = "PatientNo1"
        Me.PatientNo1.ReadOnly = True
        '
        'NameKhmer
        '
        Me.NameKhmer.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameKhmer.DefaultCellStyle = DataGridViewCellStyle4
        Me.NameKhmer.HeaderText = "Khmer Name"
        Me.NameKhmer.Name = "NameKhmer"
        Me.NameKhmer.ReadOnly = True
        Me.NameKhmer.Width = 150
        '
        'Age1
        '
        Me.Age1.DataPropertyName = "Age"
        Me.Age1.HeaderText = "Age"
        Me.Age1.Name = "Age1"
        Me.Age1.ReadOnly = True
        Me.Age1.Width = 50
        '
        'Sex1
        '
        Me.Sex1.DataPropertyName = "Sex"
        Me.Sex1.HeaderText = "Sex"
        Me.Sex1.Name = "Sex1"
        Me.Sex1.ReadOnly = True
        Me.Sex1.Width = 50
        '
        'Surgeon1
        '
        Me.Surgeon1.DataPropertyName = "Surgeon"
        Me.Surgeon1.HeaderText = "Surgeon"
        Me.Surgeon1.Name = "Surgeon1"
        Me.Surgeon1.ReadOnly = True
        '
        'Eye1
        '
        Me.Eye1.DataPropertyName = "Eye"
        Me.Eye1.HeaderText = "Eye"
        Me.Eye1.Name = "Eye1"
        Me.Eye1.ReadOnly = True
        '
        'IOLNumber
        '
        Me.IOLNumber.DataPropertyName = "IOLNumber"
        Me.IOLNumber.HeaderText = "IOL Number"
        Me.IOLNumber.Name = "IOLNumber"
        Me.IOLNumber.ReadOnly = True
        Me.IOLNumber.Width = 150
        '
        'CreateDate1
        '
        Me.CreateDate1.DataPropertyName = "CreateDate"
        Me.CreateDate1.HeaderText = "Date IOL"
        Me.CreateDate1.Name = "CreateDate1"
        Me.CreateDate1.ReadOnly = True
        '
        'OTNo1
        '
        Me.OTNo1.DataPropertyName = "OTNo"
        Me.OTNo1.HeaderText = "OT No"
        Me.OTNo1.Name = "OTNo1"
        Me.OTNo1.ReadOnly = True
        Me.OTNo1.Visible = False
        '
        'ContextMenuIOL
        '
        Me.ContextMenuIOL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteIOLToolStripMenuItem})
        Me.ContextMenuIOL.Name = "ContextMenuIOL"
        Me.ContextMenuIOL.Size = New System.Drawing.Size(129, 26)
        '
        'DeleteIOLToolStripMenuItem
        '
        Me.DeleteIOLToolStripMenuItem.Enabled = False
        Me.DeleteIOLToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteIOLToolStripMenuItem.Name = "DeleteIOLToolStripMenuItem"
        Me.DeleteIOLToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DeleteIOLToolStripMenuItem.Text = "Delete IOL"
        '
        'UCOT_AND_IOLList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCOT_AND_IOLList"
        Me.Size = New System.Drawing.Size(1032, 804)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridOTRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuNewInPatient.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridIOL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuIOL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridIOL As System.Windows.Forms.DataGridView
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuNewInPatient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteOTRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridOTRegistration As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuIOL As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteIOLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuOperationReady As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadyToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFindPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnFindHistory As System.Windows.Forms.Button
    Friend WithEvents BtnStatistic As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUndoDeleteOT As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnCreateIOL As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnOperationReady As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IOLNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTNoIOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surgeon1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eye1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IOLNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bgCutstock As System.ComponentModel.BackgroundWorker
    Friend WithEvents OTNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewInPatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Referal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperationTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anesthesia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anesthetist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IOL_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eye As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperationType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Surgeon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Assistant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Circulation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOperated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Others As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Waiting As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IOL_ID_OLD As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
