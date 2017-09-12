<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecItemAttribute
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecItemAttribute))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtPrice = New System.Windows.Forms.TextBox
        Me.TxtOldCost = New System.Windows.Forms.TextBox
        Me.TxtCurrency = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblItemID = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DTPRecItemExpired = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtGivenQty = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.gridProviderDetail = New System.Windows.Forms.DataGridView
        Me.ProviderName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GivenQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Currency = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProviderID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrencyID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExpiredDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RbDonator = New System.Windows.Forms.RadioButton
        Me.RbVendor = New System.Windows.Forms.RadioButton
        Me.CbVendor = New System.Windows.Forms.ComboBox
        Me.TxtCost = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CbCost = New System.Windows.Forms.ComboBox
        Me.CbDonation = New System.Windows.Forms.ComboBox
        Me.dtpExDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtRecQuantity = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.ErrorValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridProviderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.LblItemID)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtpExDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtRecQuantity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtItemName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 458)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtPrice)
        Me.GroupBox3.Controls.Add(Me.TxtOldCost)
        Me.GroupBox3.Controls.Add(Me.TxtCurrency)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(523, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'TxtPrice
        '
        Me.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(62, 80)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.ReadOnly = True
        Me.TxtPrice.Size = New System.Drawing.Size(135, 26)
        Me.TxtPrice.TabIndex = 22
        '
        'TxtOldCost
        '
        Me.TxtOldCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOldCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOldCost.Location = New System.Drawing.Point(62, 15)
        Me.TxtOldCost.Name = "TxtOldCost"
        Me.TxtOldCost.ReadOnly = True
        Me.TxtOldCost.Size = New System.Drawing.Size(135, 26)
        Me.TxtOldCost.TabIndex = 17
        '
        'TxtCurrency
        '
        Me.TxtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrency.Location = New System.Drawing.Point(62, 47)
        Me.TxtCurrency.Name = "TxtCurrency"
        Me.TxtCurrency.ReadOnly = True
        Me.TxtCurrency.Size = New System.Drawing.Size(135, 26)
        Me.TxtCurrency.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Old Cost:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Price Sale:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Currency:"
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Location = New System.Drawing.Point(129, 34)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(13, 13)
        Me.LblItemID.TabIndex = 18
        Me.LblItemID.Text = "0"
        Me.LblItemID.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTPRecItemExpired)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtGivenQty)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.gridProviderDetail)
        Me.GroupBox2.Controls.Add(Me.RbDonator)
        Me.GroupBox2.Controls.Add(Me.RbVendor)
        Me.GroupBox2.Controls.Add(Me.CbVendor)
        Me.GroupBox2.Controls.Add(Me.TxtCost)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CbCost)
        Me.GroupBox2.Controls.Add(Me.CbDonation)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 328)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Provider Info"
        '
        'DTPRecItemExpired
        '
        Me.DTPRecItemExpired.Checked = False
        Me.DTPRecItemExpired.CustomFormat = "dd/MM/yyyy"
        Me.DTPRecItemExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPRecItemExpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPRecItemExpired.Location = New System.Drawing.Point(442, 54)
        Me.DTPRecItemExpired.Name = "DTPRecItemExpired"
        Me.DTPRecItemExpired.ShowCheckBox = True
        Me.DTPRecItemExpired.Size = New System.Drawing.Size(268, 26)
        Me.DTPRecItemExpired.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.YellowGreen
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(290, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Expired Date Recieved Item :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Given Quantity * :"
        '
        'TxtGivenQty
        '
        Me.TxtGivenQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGivenQty.Location = New System.Drawing.Point(126, 54)
        Me.TxtGivenQty.Name = "TxtGivenQty"
        Me.TxtGivenQty.Size = New System.Drawing.Size(138, 26)
        Me.TxtGivenQty.TabIndex = 4
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(556, 88)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 31)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(637, 88)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 31)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'gridProviderDetail
        '
        Me.gridProviderDetail.AllowUserToAddRows = False
        Me.gridProviderDetail.AllowUserToDeleteRows = False
        Me.gridProviderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProviderDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProviderName, Me.GivenQty, Me.Cost, Me.Currency, Me.TotalCost, Me.ProviderID, Me.CurrencyID, Me.ExpiredDate})
        Me.gridProviderDetail.Location = New System.Drawing.Point(6, 125)
        Me.gridProviderDetail.Name = "gridProviderDetail"
        Me.gridProviderDetail.ReadOnly = True
        Me.gridProviderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridProviderDetail.Size = New System.Drawing.Size(792, 194)
        Me.gridProviderDetail.TabIndex = 17
        '
        'ProviderName
        '
        Me.ProviderName.HeaderText = "Vendor / Donator"
        Me.ProviderName.Name = "ProviderName"
        Me.ProviderName.ReadOnly = True
        Me.ProviderName.Width = 200
        '
        'GivenQty
        '
        Me.GivenQty.HeaderText = "Given Quantity"
        Me.GivenQty.Name = "GivenQty"
        Me.GivenQty.ReadOnly = True
        '
        'Cost
        '
        Me.Cost.HeaderText = "Cost"
        Me.Cost.Name = "Cost"
        Me.Cost.ReadOnly = True
        '
        'Currency
        '
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.ReadOnly = True
        '
        'TotalCost
        '
        Me.TotalCost.HeaderText = "Total Cost"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.ReadOnly = True
        '
        'ProviderID
        '
        Me.ProviderID.HeaderText = "ProviderID"
        Me.ProviderID.Name = "ProviderID"
        Me.ProviderID.ReadOnly = True
        '
        'CurrencyID
        '
        Me.CurrencyID.HeaderText = "CurrencyID"
        Me.CurrencyID.Name = "CurrencyID"
        Me.CurrencyID.ReadOnly = True
        '
        'ExpiredDate
        '
        Me.ExpiredDate.HeaderText = "Expired Date"
        Me.ExpiredDate.Name = "ExpiredDate"
        Me.ExpiredDate.ReadOnly = True
        '
        'RbDonator
        '
        Me.RbDonator.AutoSize = True
        Me.RbDonator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDonator.Location = New System.Drawing.Point(373, 26)
        Me.RbDonator.Name = "RbDonator"
        Me.RbDonator.Size = New System.Drawing.Size(63, 17)
        Me.RbDonator.TabIndex = 2
        Me.RbDonator.TabStop = True
        Me.RbDonator.Text = "Donator"
        Me.RbDonator.UseVisualStyleBackColor = True
        '
        'RbVendor
        '
        Me.RbVendor.AutoSize = True
        Me.RbVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbVendor.Location = New System.Drawing.Point(31, 27)
        Me.RbVendor.Name = "RbVendor"
        Me.RbVendor.Size = New System.Drawing.Size(59, 17)
        Me.RbVendor.TabIndex = 0
        Me.RbVendor.TabStop = True
        Me.RbVendor.Text = "Vendor"
        Me.RbVendor.UseVisualStyleBackColor = True
        '
        'CbVendor
        '
        Me.CbVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbVendor.FormattingEnabled = True
        Me.CbVendor.Location = New System.Drawing.Point(126, 19)
        Me.CbVendor.Name = "CbVendor"
        Me.CbVendor.Size = New System.Drawing.Size(241, 28)
        Me.CbVendor.TabIndex = 1
        '
        'TxtCost
        '
        Me.TxtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCost.Location = New System.Drawing.Point(126, 90)
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(138, 26)
        Me.TxtCost.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "New Cost * :"
        '
        'CbCost
        '
        Me.CbCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCost.FormattingEnabled = True
        Me.CbCost.Location = New System.Drawing.Point(270, 88)
        Me.CbCost.Name = "CbCost"
        Me.CbCost.Size = New System.Drawing.Size(97, 28)
        Me.CbCost.TabIndex = 6
        '
        'CbDonation
        '
        Me.CbDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDonation.FormattingEnabled = True
        Me.CbDonation.Location = New System.Drawing.Point(442, 19)
        Me.CbDonation.Name = "CbDonation"
        Me.CbDonation.Size = New System.Drawing.Size(268, 28)
        Me.CbDonation.TabIndex = 3
        '
        'dtpExDate
        '
        Me.dtpExDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpExDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExDate.Location = New System.Drawing.Point(205, 85)
        Me.dtpExDate.Name = "dtpExDate"
        Me.dtpExDate.ShowCheckBox = True
        Me.dtpExDate.Size = New System.Drawing.Size(314, 26)
        Me.dtpExDate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Expired Date For Item InStock  Alert:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Received Quantity :"
        '
        'TxtRecQuantity
        '
        Me.TxtRecQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtRecQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecQuantity.Location = New System.Drawing.Point(205, 53)
        Me.TxtRecQuantity.Name = "TxtRecQuantity"
        Me.TxtRecQuantity.ReadOnly = True
        Me.TxtRecQuantity.Size = New System.Drawing.Size(314, 26)
        Me.TxtRecQuantity.TabIndex = 1
        Me.TxtRecQuantity.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Name :"
        '
        'TxtItemName
        '
        Me.TxtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(205, 21)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.ReadOnly = True
        Me.TxtItemName.Size = New System.Drawing.Size(314, 26)
        Me.TxtItemName.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(737, 467)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 36)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnOK.Image = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.btnOK.Location = New System.Drawing.Point(644, 468)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(85, 36)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Save"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'ErrorValidation
        '
        Me.ErrorValidation.ContainerControl = Me
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(12, 476)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 2
        Me.txtRate.Visible = False
        '
        'frmRecItemAttribute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 511)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecItemAttribute"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridProviderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtRecQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbCost As System.Windows.Forms.ComboBox
    Friend WithEvents dtpExDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents ErrorValidation As System.Windows.Forms.ErrorProvider
    Friend WithEvents CbDonation As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbDonator As System.Windows.Forms.RadioButton
    Friend WithEvents RbVendor As System.Windows.Forms.RadioButton
    Friend WithEvents CbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents gridProviderDetail As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtGivenQty As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents DTPRecItemExpired As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProviderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GivenQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Currency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProviderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpiredDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtOldCost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblItemID As System.Windows.Forms.Label
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtCurrency As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
