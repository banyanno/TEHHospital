<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrescription
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
        Dim GridPatientInformation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrescription))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CboOpticalShop = New System.Windows.Forms.ComboBox
        Me.RadItemInOpticalShop = New System.Windows.Forms.RadioButton
        Me.GroupMedicineInfo = New System.Windows.Forms.GroupBox
        Me.cbItemContainer = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cbLabourFac = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtUnitsInStock = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.LblItemUnitID = New System.Windows.Forms.Label
        Me.cbItemUnit = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.RbDrugOutsideHos = New System.Windows.Forms.RadioButton
        Me.RbDrugInHos = New System.Windows.Forms.RadioButton
        Me.cbRemark = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.LblItemID = New System.Windows.Forms.Label
        Me.CboItemName = New System.Windows.Forms.ComboBox
        Me.RadPatientNo = New System.Windows.Forms.RadioButton
        Me.RadPatientName = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridPatientInformation = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnBrowseDoctor = New Janus.Windows.EditControls.UIButton
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.TxtDoctorNo = New System.Windows.Forms.TextBox
        Me.TxtDocSex = New System.Windows.Forms.TextBox
        Me.TxtPatientNoReal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNameKh = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.TxtPatOccupation = New System.Windows.Forms.TextBox
        Me.TxtPatSex = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPatAge = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CboPatient = New System.Windows.Forms.TextBox
        Me.BtnRemveMedicine = New System.Windows.Forms.Button
        Me.BtnBrowsePatient = New Janus.Windows.EditControls.UIButton
        Me.BtnAddMedicine = New System.Windows.Forms.Button
        Me.TxtTempPatientNo = New System.Windows.Forms.TextBox
        Me.GridMedicine = New System.Windows.Forms.DataGridView
        Me.cItemID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cItemUnitID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRemark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cIsOutsideMedicine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContainerID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabourFacID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LblNew_OldID = New System.Windows.Forms.Label
        Me.TxtPrescriptionNote = New System.Windows.Forms.TextBox
        Me.CboEye = New System.Windows.Forms.ComboBox
        Me.DateApp = New System.Windows.Forms.DateTimePicker
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbDiagnosis = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CboSecondSurgery = New System.Windows.Forms.ComboBox
        Me.DateCreatePrescrip = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrorPrescription = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblSaveStatus = New System.Windows.Forms.Label
        Me.BgLoadPatient = New System.ComponentModel.BackgroundWorker
        Me.PictLoading = New System.Windows.Forms.PictureBox
        Me.LblLoading = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupMedicineInfo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridPatientInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.RadPatientNo)
        Me.GroupBox1.Controls.Add(Me.RadPatientName)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CboPatient)
        Me.GroupBox1.Controls.Add(Me.BtnRemveMedicine)
        Me.GroupBox1.Controls.Add(Me.BtnBrowsePatient)
        Me.GroupBox1.Controls.Add(Me.BtnAddMedicine)
        Me.GroupBox1.Controls.Add(Me.TxtTempPatientNo)
        Me.GroupBox1.Controls.Add(Me.GridMedicine)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1189, 768)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find By"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.CboOpticalShop)
        Me.GroupBox5.Controls.Add(Me.RadItemInOpticalShop)
        Me.GroupBox5.Controls.Add(Me.GroupMedicineInfo)
        Me.GroupBox5.Controls.Add(Me.TxtUnitsInStock)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.LblItemUnitID)
        Me.GroupBox5.Controls.Add(Me.cbItemUnit)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.TxtQuantity)
        Me.GroupBox5.Controls.Add(Me.RbDrugOutsideHos)
        Me.GroupBox5.Controls.Add(Me.RbDrugInHos)
        Me.GroupBox5.Controls.Add(Me.cbRemark)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.LblItemID)
        Me.GroupBox5.Controls.Add(Me.CboItemName)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 349)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(656, 403)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Medicine Information"
        '
        'CboOpticalShop
        '
        Me.CboOpticalShop.Enabled = False
        Me.CboOpticalShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOpticalShop.FormattingEnabled = True
        Me.CboOpticalShop.Location = New System.Drawing.Point(389, 40)
        Me.CboOpticalShop.Name = "CboOpticalShop"
        Me.CboOpticalShop.Size = New System.Drawing.Size(254, 28)
        Me.CboOpticalShop.TabIndex = 3
        '
        'RadItemInOpticalShop
        '
        Me.RadItemInOpticalShop.AutoSize = True
        Me.RadItemInOpticalShop.Location = New System.Drawing.Point(389, 18)
        Me.RadItemInOpticalShop.Name = "RadItemInOpticalShop"
        Me.RadItemInOpticalShop.Size = New System.Drawing.Size(121, 17)
        Me.RadItemInOpticalShop.TabIndex = 2
        Me.RadItemInOpticalShop.TabStop = True
        Me.RadItemInOpticalShop.Text = "Item In Optical Shop"
        Me.RadItemInOpticalShop.UseVisualStyleBackColor = True
        '
        'GroupMedicineInfo
        '
        Me.GroupMedicineInfo.Controls.Add(Me.cbItemContainer)
        Me.GroupMedicineInfo.Controls.Add(Me.Label15)
        Me.GroupMedicineInfo.Controls.Add(Me.cbLabourFac)
        Me.GroupMedicineInfo.Controls.Add(Me.Label17)
        Me.GroupMedicineInfo.Controls.Add(Me.TxtItemName)
        Me.GroupMedicineInfo.Controls.Add(Me.Label18)
        Me.GroupMedicineInfo.Enabled = False
        Me.GroupMedicineInfo.Location = New System.Drawing.Point(7, 96)
        Me.GroupMedicineInfo.Name = "GroupMedicineInfo"
        Me.GroupMedicineInfo.Size = New System.Drawing.Size(350, 124)
        Me.GroupMedicineInfo.TabIndex = 5
        Me.GroupMedicineInfo.TabStop = False
        Me.GroupMedicineInfo.Text = "Medicine Outside Hospital Info"
        '
        'cbItemContainer
        '
        Me.cbItemContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItemContainer.FormattingEnabled = True
        Me.cbItemContainer.Location = New System.Drawing.Point(94, 51)
        Me.cbItemContainer.Name = "cbItemContainer"
        Me.cbItemContainer.Size = New System.Drawing.Size(246, 28)
        Me.cbItemContainer.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Item Containing : "
        '
        'cbLabourFac
        '
        Me.cbLabourFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbLabourFac.FormattingEnabled = True
        Me.cbLabourFac.Location = New System.Drawing.Point(94, 85)
        Me.cbLabourFac.Name = "cbLabourFac"
        Me.cbLabourFac.Size = New System.Drawing.Size(246, 28)
        Me.cbLabourFac.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Laboratory : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtItemName
        '
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtItemName.Location = New System.Drawing.Point(94, 20)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(246, 26)
        Me.TxtItemName.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Item Name : *"
        '
        'TxtUnitsInStock
        '
        Me.TxtUnitsInStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtUnitsInStock.Location = New System.Drawing.Point(580, 143)
        Me.TxtUnitsInStock.Name = "TxtUnitsInStock"
        Me.TxtUnitsInStock.ReadOnly = True
        Me.TxtUnitsInStock.Size = New System.Drawing.Size(63, 26)
        Me.TxtUnitsInStock.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(461, 156)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Quantity In Stock: "
        '
        'LblItemUnitID
        '
        Me.LblItemUnitID.AutoSize = True
        Me.LblItemUnitID.Location = New System.Drawing.Point(498, 233)
        Me.LblItemUnitID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItemUnitID.Name = "LblItemUnitID"
        Me.LblItemUnitID.Size = New System.Drawing.Size(13, 13)
        Me.LblItemUnitID.TabIndex = 24
        Me.LblItemUnitID.Text = "0"
        Me.LblItemUnitID.Visible = False
        '
        'cbItemUnit
        '
        Me.cbItemUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItemUnit.Location = New System.Drawing.Point(580, 225)
        Me.cbItemUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.cbItemUnit.Name = "cbItemUnit"
        Me.cbItemUnit.Size = New System.Drawing.Size(64, 28)
        Me.cbItemUnit.TabIndex = 3
        Me.cbItemUnit.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(521, 233)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "UoM: *"
        Me.Label20.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(371, 124)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Quantity: *"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtQuantity.Location = New System.Drawing.Point(429, 111)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(214, 26)
        Me.TxtQuantity.TabIndex = 6
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RbDrugOutsideHos
        '
        Me.RbDrugOutsideHos.AutoSize = True
        Me.RbDrugOutsideHos.Location = New System.Drawing.Point(7, 73)
        Me.RbDrugOutsideHos.Name = "RbDrugOutsideHos"
        Me.RbDrugOutsideHos.Size = New System.Drawing.Size(148, 17)
        Me.RbDrugOutsideHos.TabIndex = 4
        Me.RbDrugOutsideHos.Text = "Medicine Outside Hospital"
        Me.RbDrugOutsideHos.UseVisualStyleBackColor = True
        '
        'RbDrugInHos
        '
        Me.RbDrugInHos.AutoSize = True
        Me.RbDrugInHos.Checked = True
        Me.RbDrugInHos.Location = New System.Drawing.Point(7, 18)
        Me.RbDrugInHos.Name = "RbDrugInHos"
        Me.RbDrugInHos.Size = New System.Drawing.Size(187, 17)
        Me.RbDrugInHos.TabIndex = 0
        Me.RbDrugInHos.TabStop = True
        Me.RbDrugInHos.Text = "Medicine in Hospital Item Name : *"
        Me.RbDrugInHos.UseVisualStyleBackColor = True
        '
        'cbRemark
        '
        Me.cbRemark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbRemark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRemark.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRemark.FormattingEnabled = True
        Me.cbRemark.Location = New System.Drawing.Point(429, 187)
        Me.cbRemark.Margin = New System.Windows.Forms.Padding(2)
        Me.cbRemark.Name = "cbRemark"
        Me.cbRemark.Size = New System.Drawing.Size(214, 28)
        Me.cbRemark.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(371, 202)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Remark *:"
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Location = New System.Drawing.Point(481, 233)
        Me.LblItemID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(13, 13)
        Me.LblItemID.TabIndex = 14
        Me.LblItemID.Text = "0"
        Me.LblItemID.Visible = False
        '
        'CboItemName
        '
        Me.CboItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboItemName.Location = New System.Drawing.Point(7, 40)
        Me.CboItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.CboItemName.Name = "CboItemName"
        Me.CboItemName.Size = New System.Drawing.Size(314, 28)
        Me.CboItemName.TabIndex = 1
        '
        'RadPatientNo
        '
        Me.RadPatientNo.AutoSize = True
        Me.RadPatientNo.Checked = True
        Me.RadPatientNo.ForeColor = System.Drawing.Color.Blue
        Me.RadPatientNo.Location = New System.Drawing.Point(107, 23)
        Me.RadPatientNo.Name = "RadPatientNo"
        Me.RadPatientNo.Size = New System.Drawing.Size(75, 17)
        Me.RadPatientNo.TabIndex = 1
        Me.RadPatientNo.TabStop = True
        Me.RadPatientNo.Text = "Patient No"
        Me.RadPatientNo.UseVisualStyleBackColor = True
        '
        'RadPatientName
        '
        Me.RadPatientName.AutoSize = True
        Me.RadPatientName.ForeColor = System.Drawing.Color.Blue
        Me.RadPatientName.Location = New System.Drawing.Point(12, 23)
        Me.RadPatientName.Name = "RadPatientName"
        Me.RadPatientName.Size = New System.Drawing.Size(89, 17)
        Me.RadPatientName.TabIndex = 0
        Me.RadPatientName.Text = "Patient Name"
        Me.RadPatientName.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GridPatientInformation)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 50)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(729, 183)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient Information"
        '
        'GridPatientInformation
        '
        Me.GridPatientInformation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPatientInformation_DesignTimeLayout.LayoutString = resources.GetString("GridPatientInformation_DesignTimeLayout.LayoutString")
        Me.GridPatientInformation.DesignTimeLayout = GridPatientInformation_DesignTimeLayout
        Me.GridPatientInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPatientInformation.GroupByBoxVisible = False
        Me.GridPatientInformation.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientInformation.Location = New System.Drawing.Point(2, 15)
        Me.GridPatientInformation.Margin = New System.Windows.Forms.Padding(2)
        Me.GridPatientInformation.Name = "GridPatientInformation"
        Me.GridPatientInformation.RecordNavigator = True
        Me.GridPatientInformation.Size = New System.Drawing.Size(725, 166)
        Me.GridPatientInformation.TabIndex = 0
        Me.GridPatientInformation.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BtnBrowseDoctor)
        Me.GroupBox2.Controls.Add(Me.TxtTel)
        Me.GroupBox2.Controls.Add(Me.TxtDoctorNo)
        Me.GroupBox2.Controls.Add(Me.TxtDocSex)
        Me.GroupBox2.Controls.Add(Me.TxtPatientNoReal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtNameKh)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtPatientName)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.TxtPatOccupation)
        Me.GroupBox2.Controls.Add(Me.TxtPatSex)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtPatAge)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(748, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 220)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Info"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(228, 179)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tel:"
        '
        'BtnBrowseDoctor
        '
        Me.BtnBrowseDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowseDoctor.Location = New System.Drawing.Point(231, 207)
        Me.BtnBrowseDoctor.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBrowseDoctor.Name = "BtnBrowseDoctor"
        Me.BtnBrowseDoctor.Size = New System.Drawing.Size(35, 26)
        Me.BtnBrowseDoctor.TabIndex = 1
        Me.BtnBrowseDoctor.Text = "..."
        Me.BtnBrowseDoctor.Visible = False
        Me.BtnBrowseDoctor.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'TxtTel
        '
        Me.TxtTel.BackColor = System.Drawing.Color.White
        Me.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(261, 168)
        Me.TxtTel.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTel.Multiline = True
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.ReadOnly = True
        Me.TxtTel.Size = New System.Drawing.Size(144, 34)
        Me.TxtTel.TabIndex = 7
        '
        'TxtDoctorNo
        '
        Me.TxtDoctorNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDoctorNo.Location = New System.Drawing.Point(33, 205)
        Me.TxtDoctorNo.Name = "TxtDoctorNo"
        Me.TxtDoctorNo.Size = New System.Drawing.Size(157, 20)
        Me.TxtDoctorNo.TabIndex = 8
        Me.TxtDoctorNo.Visible = False
        '
        'TxtDocSex
        '
        Me.TxtDocSex.BackColor = System.Drawing.Color.White
        Me.TxtDocSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocSex.Location = New System.Drawing.Point(173, 205)
        Me.TxtDocSex.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDocSex.Name = "TxtDocSex"
        Me.TxtDocSex.ReadOnly = True
        Me.TxtDocSex.Size = New System.Drawing.Size(37, 26)
        Me.TxtDocSex.TabIndex = 2
        Me.TxtDocSex.Visible = False
        '
        'TxtPatientNoReal
        '
        Me.TxtPatientNoReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPatientNoReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientNoReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNoReal.Location = New System.Drawing.Point(86, 39)
        Me.TxtPatientNoReal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatientNoReal.Name = "TxtPatientNoReal"
        Me.TxtPatientNoReal.ReadOnly = True
        Me.TxtPatientNoReal.Size = New System.Drawing.Size(318, 26)
        Me.TxtPatientNoReal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Patient No:"
        '
        'TxtNameKh
        '
        Me.TxtNameKh.BackColor = System.Drawing.Color.White
        Me.TxtNameKh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNameKh.Font = New System.Drawing.Font("Wat Phnom T3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameKh.Location = New System.Drawing.Point(86, 79)
        Me.TxtNameKh.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNameKh.Name = "TxtNameKh"
        Me.TxtNameKh.ReadOnly = True
        Me.TxtNameKh.Size = New System.Drawing.Size(138, 34)
        Me.TxtNameKh.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name: *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sex:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Age:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BackColor = System.Drawing.Color.White
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtPatientName.Location = New System.Drawing.Point(268, 81)
        Me.TxtPatientName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.ReadOnly = True
        Me.TxtPatientName.Size = New System.Drawing.Size(136, 26)
        Me.TxtPatientName.TabIndex = 2
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(86, 168)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(138, 34)
        Me.txtAddress.TabIndex = 6
        '
        'TxtPatOccupation
        '
        Me.TxtPatOccupation.BackColor = System.Drawing.Color.White
        Me.TxtPatOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatOccupation.Location = New System.Drawing.Point(86, 125)
        Me.TxtPatOccupation.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatOccupation.Name = "TxtPatOccupation"
        Me.TxtPatOccupation.ReadOnly = True
        Me.TxtPatOccupation.Size = New System.Drawing.Size(138, 26)
        Me.TxtPatOccupation.TabIndex = 3
        '
        'TxtPatSex
        '
        Me.TxtPatSex.BackColor = System.Drawing.Color.White
        Me.TxtPatSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatSex.Location = New System.Drawing.Point(268, 124)
        Me.TxtPatSex.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatSex.Name = "TxtPatSex"
        Me.TxtPatSex.ReadOnly = True
        Me.TxtPatSex.Size = New System.Drawing.Size(37, 26)
        Me.TxtPatSex.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Occupation:"
        '
        'TxtPatAge
        '
        Me.TxtPatAge.BackColor = System.Drawing.Color.White
        Me.TxtPatAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatAge.Location = New System.Drawing.Point(354, 125)
        Me.TxtPatAge.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPatAge.Name = "TxtPatAge"
        Me.TxtPatAge.ReadOnly = True
        Me.TxtPatAge.Size = New System.Drawing.Size(50, 26)
        Me.TxtPatAge.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 179)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Address:"
        '
        'CboPatient
        '
        Me.CboPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CboPatient.Location = New System.Drawing.Point(187, 18)
        Me.CboPatient.Margin = New System.Windows.Forms.Padding(2)
        Me.CboPatient.Name = "CboPatient"
        Me.CboPatient.Size = New System.Drawing.Size(242, 30)
        Me.CboPatient.TabIndex = 2
        '
        'BtnRemveMedicine
        '
        Me.BtnRemveMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRemveMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemveMedicine.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.BtnRemveMedicine.Location = New System.Drawing.Point(672, 465)
        Me.BtnRemveMedicine.Name = "BtnRemveMedicine"
        Me.BtnRemveMedicine.Size = New System.Drawing.Size(33, 31)
        Me.BtnRemveMedicine.TabIndex = 7
        Me.BtnRemveMedicine.TabStop = False
        Me.BtnRemveMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRemveMedicine.UseVisualStyleBackColor = True
        '
        'BtnBrowsePatient
        '
        Me.BtnBrowsePatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowsePatient.Location = New System.Drawing.Point(435, 17)
        Me.BtnBrowsePatient.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBrowsePatient.Name = "BtnBrowsePatient"
        Me.BtnBrowsePatient.Size = New System.Drawing.Size(93, 33)
        Me.BtnBrowsePatient.TabIndex = 3
        Me.BtnBrowsePatient.Text = "Find"
        '
        'BtnAddMedicine
        '
        Me.BtnAddMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMedicine.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.BtnAddMedicine.Location = New System.Drawing.Point(672, 422)
        Me.BtnAddMedicine.Name = "BtnAddMedicine"
        Me.BtnAddMedicine.Size = New System.Drawing.Size(33, 31)
        Me.BtnAddMedicine.TabIndex = 6
        Me.BtnAddMedicine.TabStop = False
        Me.BtnAddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddMedicine.UseVisualStyleBackColor = True
        '
        'TxtTempPatientNo
        '
        Me.TxtTempPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTempPatientNo.Location = New System.Drawing.Point(546, 23)
        Me.TxtTempPatientNo.Name = "TxtTempPatientNo"
        Me.TxtTempPatientNo.Size = New System.Drawing.Size(163, 20)
        Me.TxtTempPatientNo.TabIndex = 9
        Me.TxtTempPatientNo.Visible = False
        '
        'GridMedicine
        '
        Me.GridMedicine.AllowUserToAddRows = False
        Me.GridMedicine.AllowUserToDeleteRows = False
        Me.GridMedicine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMedicine.BackgroundColor = System.Drawing.SystemColors.Window
        Me.GridMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridMedicine.ColumnHeadersHeight = 30
        Me.GridMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridMedicine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemID, Me.cItemName, Me.cQuantity, Me.cItemUnitID, Me.cRemark, Me.cIsOutsideMedicine, Me.ContainerID, Me.LabourFacID})
        Me.GridMedicine.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GridMedicine.Location = New System.Drawing.Point(716, 349)
        Me.GridMedicine.Margin = New System.Windows.Forms.Padding(2)
        Me.GridMedicine.Name = "GridMedicine"
        Me.GridMedicine.ReadOnly = True
        Me.GridMedicine.RowTemplate.Height = 30
        Me.GridMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridMedicine.Size = New System.Drawing.Size(469, 403)
        Me.GridMedicine.TabIndex = 9
        '
        'cItemID
        '
        Me.cItemID.HeaderText = "ItemID"
        Me.cItemID.Name = "cItemID"
        Me.cItemID.ReadOnly = True
        Me.cItemID.Visible = False
        Me.cItemID.Width = 50
        '
        'cItemName
        '
        Me.cItemName.HeaderText = "Medicine"
        Me.cItemName.Name = "cItemName"
        Me.cItemName.ReadOnly = True
        Me.cItemName.Width = 200
        '
        'cQuantity
        '
        Me.cQuantity.HeaderText = "Quantity"
        Me.cQuantity.Name = "cQuantity"
        Me.cQuantity.ReadOnly = True
        '
        'cItemUnitID
        '
        Me.cItemUnitID.HeaderText = "Unit of Measuring"
        Me.cItemUnitID.Name = "cItemUnitID"
        Me.cItemUnitID.ReadOnly = True
        Me.cItemUnitID.Visible = False
        '
        'cRemark
        '
        Me.cRemark.HeaderText = "Remark"
        Me.cRemark.Name = "cRemark"
        Me.cRemark.ReadOnly = True
        Me.cRemark.Width = 200
        '
        'cIsOutsideMedicine
        '
        Me.cIsOutsideMedicine.HeaderText = "Medicine In Hospital"
        Me.cIsOutsideMedicine.Name = "cIsOutsideMedicine"
        Me.cIsOutsideMedicine.ReadOnly = True
        Me.cIsOutsideMedicine.Visible = False
        Me.cIsOutsideMedicine.Width = 200
        '
        'ContainerID
        '
        Me.ContainerID.HeaderText = "Containing"
        Me.ContainerID.Name = "ContainerID"
        Me.ContainerID.ReadOnly = True
        Me.ContainerID.Visible = False
        '
        'LabourFacID
        '
        Me.LabourFacID.HeaderText = "Labouratory"
        Me.LabourFacID.Name = "LabourFacID"
        Me.LabourFacID.ReadOnly = True
        Me.LabourFacID.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.LblNew_OldID)
        Me.GroupBox4.Controls.Add(Me.TxtPrescriptionNote)
        Me.GroupBox4.Controls.Add(Me.CboEye)
        Me.GroupBox4.Controls.Add(Me.DateApp)
        Me.GroupBox4.Controls.Add(Me.CboDoctor)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.CbDiagnosis)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.CboSecondSurgery)
        Me.GroupBox4.Controls.Add(Me.DateCreatePrescrip)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 246)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(1175, 94)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Doctor Info"
        '
        'LblNew_OldID
        '
        Me.LblNew_OldID.AutoSize = True
        Me.LblNew_OldID.Location = New System.Drawing.Point(623, 69)
        Me.LblNew_OldID.Name = "LblNew_OldID"
        Me.LblNew_OldID.Size = New System.Drawing.Size(13, 13)
        Me.LblNew_OldID.TabIndex = 22
        Me.LblNew_OldID.Text = "0"
        Me.LblNew_OldID.Visible = False
        '
        'TxtPrescriptionNote
        '
        Me.TxtPrescriptionNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrescriptionNote.Location = New System.Drawing.Point(890, 32)
        Me.TxtPrescriptionNote.Multiline = True
        Me.TxtPrescriptionNote.Name = "TxtPrescriptionNote"
        Me.TxtPrescriptionNote.Size = New System.Drawing.Size(271, 49)
        Me.TxtPrescriptionNote.TabIndex = 6
        '
        'CboEye
        '
        Me.CboEye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboEye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEye.FormattingEnabled = True
        Me.CboEye.Items.AddRange(New Object() {"Left Eye", "Right Eye", "Both Eye"})
        Me.CboEye.Location = New System.Drawing.Point(721, 54)
        Me.CboEye.Name = "CboEye"
        Me.CboEye.Size = New System.Drawing.Size(160, 28)
        Me.CboEye.TabIndex = 5
        '
        'DateApp
        '
        Me.DateApp.Checked = False
        Me.DateApp.CustomFormat = "dd/MM/yyyy"
        Me.DateApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateApp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateApp.Location = New System.Drawing.Point(721, 16)
        Me.DateApp.Name = "DateApp"
        Me.DateApp.ShowCheckBox = True
        Me.DateApp.Size = New System.Drawing.Size(160, 26)
        Me.DateApp.TabIndex = 4
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(86, 18)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(236, 28)
        Me.CboDoctor.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Diagnosis:"
        '
        'CbDiagnosis
        '
        Me.CbDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbDiagnosis.FormattingEnabled = True
        Me.CbDiagnosis.Location = New System.Drawing.Point(399, 19)
        Me.CbDiagnosis.Name = "CbDiagnosis"
        Me.CbDiagnosis.Size = New System.Drawing.Size(211, 28)
        Me.CbDiagnosis.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(815, 19)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Sex:"
        Me.Label8.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(655, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 28)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "On Eye:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Doctor Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Issue Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(623, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Date Appointment:"
        '
        'CboSecondSurgery
        '
        Me.CboSecondSurgery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSecondSurgery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSecondSurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSecondSurgery.FormattingEnabled = True
        Me.CboSecondSurgery.Location = New System.Drawing.Point(399, 54)
        Me.CboSecondSurgery.Name = "CboSecondSurgery"
        Me.CboSecondSurgery.Size = New System.Drawing.Size(211, 28)
        Me.CboSecondSurgery.TabIndex = 3
        '
        'DateCreatePrescrip
        '
        Me.DateCreatePrescrip.CustomFormat = "dd/MM/yyyy"
        Me.DateCreatePrescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreatePrescrip.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCreatePrescrip.Location = New System.Drawing.Point(86, 54)
        Me.DateCreatePrescrip.Margin = New System.Windows.Forms.Padding(2)
        Me.DateCreatePrescrip.Name = "DateCreatePrescrip"
        Me.DateCreatePrescrip.Size = New System.Drawing.Size(236, 26)
        Me.DateCreatePrescrip.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(330, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 28)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Surgery:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(890, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 28)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Note:"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnSave.Image = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.BtnSave.Location = New System.Drawing.Point(997, 788)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 37)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.BtnCancel.Location = New System.Drawing.Point(1090, 788)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(85, 37)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrorPrescription
        '
        Me.ErrorPrescription.ContainerControl = Me
        '
        'LblSaveStatus
        '
        Me.LblSaveStatus.AutoSize = True
        Me.LblSaveStatus.Location = New System.Drawing.Point(195, 808)
        Me.LblSaveStatus.Name = "LblSaveStatus"
        Me.LblSaveStatus.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveStatus.TabIndex = 20
        Me.LblSaveStatus.Text = "0"
        '
        'BgLoadPatient
        '
        '
        'PictLoading
        '
        Me.PictLoading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictLoading.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar1
        Me.PictLoading.Location = New System.Drawing.Point(59, 798)
        Me.PictLoading.Name = "PictLoading"
        Me.PictLoading.Size = New System.Drawing.Size(130, 24)
        Me.PictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictLoading.TabIndex = 21
        Me.PictLoading.TabStop = False
        Me.PictLoading.Visible = False
        '
        'LblLoading
        '
        Me.LblLoading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblLoading.AutoSize = True
        Me.LblLoading.Location = New System.Drawing.Point(8, 808)
        Me.LblLoading.Name = "LblLoading"
        Me.LblLoading.Size = New System.Drawing.Size(45, 13)
        Me.LblLoading.TabIndex = 22
        Me.LblLoading.Text = "Loading"
        Me.LblLoading.Visible = False
        '
        'frmPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 830)
        Me.Controls.Add(Me.LblLoading)
        Me.Controls.Add(Me.PictLoading)
        Me.Controls.Add(Me.LblSaveStatus)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPrescription"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupMedicineInfo.ResumeLayout(False)
        Me.GroupMedicineInfo.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridPatientInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPatAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatOccupation As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnBrowsePatient As Janus.Windows.EditControls.UIButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateCreatePrescrip As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDocSex As System.Windows.Forms.TextBox
    Friend WithEvents GridMedicine As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAddMedicine As System.Windows.Forms.Button
    Friend WithEvents BtnRemveMedicine As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnBrowseDoctor As Janus.Windows.EditControls.UIButton
    Friend WithEvents TxtTempPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDoctorNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorPrescription As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveStatus As System.Windows.Forms.Label
    Friend WithEvents BgLoadPatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents PictLoading As System.Windows.Forms.PictureBox
    Friend WithEvents LblLoading As System.Windows.Forms.Label
    Friend WithEvents CboPatient As System.Windows.Forms.TextBox
    Friend WithEvents TxtNameKh As System.Windows.Forms.TextBox
    Friend WithEvents LblNew_OldID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPatientInformation As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtPatientNoReal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientName As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CboSecondSurgery As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CboEye As System.Windows.Forms.ComboBox
    Friend WithEvents DateApp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtPrescriptionNote As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CboOpticalShop As System.Windows.Forms.ComboBox
    Friend WithEvents RadItemInOpticalShop As System.Windows.Forms.RadioButton
    Friend WithEvents GroupMedicineInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cbItemContainer As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbLabourFac As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtUnitsInStock As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblItemUnitID As System.Windows.Forms.Label
    Friend WithEvents cbItemUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents RbDrugOutsideHos As System.Windows.Forms.RadioButton
    Friend WithEvents RbDrugInHos As System.Windows.Forms.RadioButton
    Friend WithEvents cbRemark As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LblItemID As System.Windows.Forms.Label
    Friend WithEvents CboItemName As System.Windows.Forms.ComboBox
    Friend WithEvents cItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cItemUnitID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRemark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIsOutsideMedicine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContainerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabourFacID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
