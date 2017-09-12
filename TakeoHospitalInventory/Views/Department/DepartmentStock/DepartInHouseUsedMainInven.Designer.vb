<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartInHouseUsedMainInven
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
        Dim GridExpireDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartInHouseUsedMainInven))
        Dim gridUsedItemDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LblExpireID = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GridExpireDetail = New Janus.Windows.GridEX.GridEX
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dptUsedDate = New System.Windows.Forms.DateTimePicker
        Me.cbItem = New System.Windows.Forms.ComboBox
        Me.TxtStockQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rtbComment = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnRemoveItem = New Janus.Windows.EditControls.UIButton
        Me.BtnModifyItem = New Janus.Windows.EditControls.UIButton
        Me.BtnAddItem = New Janus.Windows.EditControls.UIButton
        Me.PictItem = New System.Windows.Forms.PictureBox
        Me.LblItemID = New System.Windows.Forms.Label
        Me.TxtUsedQTY = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtItemBarcode = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnSaveNewUsed = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.gridUsedItemDetail = New Janus.Windows.GridEX.GridEX
        Me.Label5 = New System.Windows.Forms.Label
        Me.ErrorInHouseUsed = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridUsedItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorInHouseUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridUsedItemDetail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Size = New System.Drawing.Size(943, 502)
        Me.SplitContainer1.SplitterDistance = 281
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblExpireID)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.GridExpireDetail)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.dptUsedDate)
        Me.GroupBox4.Controls.Add(Me.cbItem)
        Me.GroupBox4.Controls.Add(Me.TxtStockQty)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.rtbComment)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.BtnRemoveItem)
        Me.GroupBox4.Controls.Add(Me.BtnModifyItem)
        Me.GroupBox4.Controls.Add(Me.BtnAddItem)
        Me.GroupBox4.Controls.Add(Me.PictItem)
        Me.GroupBox4.Controls.Add(Me.LblItemID)
        Me.GroupBox4.Controls.Add(Me.TxtUsedQTY)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtItemBarcode)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 31)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(943, 250)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item Information"
        '
        'LblExpireID
        '
        Me.LblExpireID.AutoSize = True
        Me.LblExpireID.Location = New System.Drawing.Point(323, 227)
        Me.LblExpireID.Name = "LblExpireID"
        Me.LblExpireID.Size = New System.Drawing.Size(13, 13)
        Me.LblExpireID.TabIndex = 51
        Me.LblExpireID.Text = "0"
        Me.LblExpireID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(441, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 17)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "List of expire date:"
        '
        'GridExpireDetail
        '
        Me.GridExpireDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridExpireDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridExpireDetail_DesignTimeLayout.LayoutString = resources.GetString("GridExpireDetail_DesignTimeLayout.LayoutString")
        Me.GridExpireDetail.DesignTimeLayout = GridExpireDetail_DesignTimeLayout
        Me.GridExpireDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridExpireDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridExpireDetail.GroupByBoxVisible = False
        Me.GridExpireDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridExpireDetail.Location = New System.Drawing.Point(441, 42)
        Me.GridExpireDetail.Name = "GridExpireDetail"
        Me.GridExpireDetail.RecordNavigator = True
        Me.GridExpireDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridExpireDetail.Size = New System.Drawing.Size(497, 169)
        Me.GridExpireDetail.TabIndex = 49
        Me.GridExpireDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridExpireDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(750, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(420, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(420, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(420, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(421, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date:"
        '
        'dptUsedDate
        '
        Me.dptUsedDate.Checked = False
        Me.dptUsedDate.CustomFormat = "dd/MM/yyyy"
        Me.dptUsedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptUsedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptUsedDate.Location = New System.Drawing.Point(104, 79)
        Me.dptUsedDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptUsedDate.Name = "dptUsedDate"
        Me.dptUsedDate.Size = New System.Drawing.Size(312, 26)
        Me.dptUsedDate.TabIndex = 2
        '
        'cbItem
        '
        Me.cbItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbItem.FormattingEnabled = True
        Me.cbItem.Location = New System.Drawing.Point(104, 16)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(312, 28)
        Me.cbItem.TabIndex = 0
        '
        'TxtStockQty
        '
        Me.TxtStockQty.Enabled = False
        Me.TxtStockQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStockQty.Location = New System.Drawing.Point(104, 139)
        Me.TxtStockQty.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtStockQty.Name = "TxtStockQty"
        Me.TxtStockQty.Size = New System.Drawing.Size(312, 26)
        Me.TxtStockQty.TabIndex = 4
        Me.TxtStockQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Stock Quantity: "
        '
        'rtbComment
        '
        Me.rtbComment.Location = New System.Drawing.Point(104, 167)
        Me.rtbComment.Name = "rtbComment"
        Me.rtbComment.Size = New System.Drawing.Size(312, 44)
        Me.rtbComment.TabIndex = 5
        Me.rtbComment.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Comment:"
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveItem.Icon = CType(resources.GetObject("BtnRemoveItem.Icon"), System.Drawing.Icon)
        Me.BtnRemoveItem.Location = New System.Drawing.Point(184, 217)
        Me.BtnRemoveItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(92, 27)
        Me.BtnRemoveItem.TabIndex = 8
        Me.BtnRemoveItem.Text = "Remove Item"
        Me.BtnRemoveItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'BtnModifyItem
        '
        Me.BtnModifyItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModifyItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Floppy_s2
        Me.BtnModifyItem.Location = New System.Drawing.Point(93, 217)
        Me.BtnModifyItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModifyItem.Name = "BtnModifyItem"
        Me.BtnModifyItem.Size = New System.Drawing.Size(85, 27)
        Me.BtnModifyItem.TabIndex = 7
        Me.BtnModifyItem.Text = "Update Item"
        Me.BtnModifyItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddItem.Icon = CType(resources.GetObject("BtnAddItem.Icon"), System.Drawing.Icon)
        Me.BtnAddItem.Location = New System.Drawing.Point(7, 217)
        Me.BtnAddItem.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(82, 27)
        Me.BtnAddItem.TabIndex = 6
        Me.BtnAddItem.Text = "Add Item"
        Me.BtnAddItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'PictItem
        '
        Me.PictItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictItem.Location = New System.Drawing.Point(792, 98)
        Me.PictItem.Margin = New System.Windows.Forms.Padding(2)
        Me.PictItem.Name = "PictItem"
        Me.PictItem.Size = New System.Drawing.Size(107, 47)
        Me.PictItem.TabIndex = 8
        Me.PictItem.TabStop = False
        Me.PictItem.Visible = False
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Location = New System.Drawing.Point(827, 170)
        Me.LblItemID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(13, 13)
        Me.LblItemID.TabIndex = 7
        Me.LblItemID.Text = "0"
        Me.LblItemID.Visible = False
        '
        'TxtUsedQTY
        '
        Me.TxtUsedQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsedQTY.Location = New System.Drawing.Point(104, 109)
        Me.TxtUsedQTY.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUsedQTY.Name = "TxtUsedQTY"
        Me.TxtUsedQTY.Size = New System.Drawing.Size(312, 26)
        Me.TxtUsedQTY.TabIndex = 3
        Me.TxtUsedQTY.Text = "0"
        Me.TxtUsedQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 116)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Used Qty:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 24)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Item Name:"
        '
        'TxtItemBarcode
        '
        Me.TxtItemBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtItemBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemBarcode.Location = New System.Drawing.Point(104, 49)
        Me.TxtItemBarcode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemBarcode.Name = "TxtItemBarcode"
        Me.TxtItemBarcode.Size = New System.Drawing.Size(312, 26)
        Me.TxtItemBarcode.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 57)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Item Barcode:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSaveNewUsed, Me.ToolStripSeparator1, Me.BtnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(943, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSaveNewUsed
        '
        Me.BtnSaveNewUsed.Image = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.BtnSaveNewUsed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSaveNewUsed.Name = "BtnSaveNewUsed"
        Me.BtnSaveNewUsed.Size = New System.Drawing.Size(136, 28)
        Me.BtnSaveNewUsed.Text = "Save Used Item List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Close1
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(71, 28)
        Me.BtnCancel.Text = "Cancel"
        '
        'gridUsedItemDetail
        '
        Me.gridUsedItemDetail.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound
        gridUsedItemDetail_DesignTimeLayout.LayoutString = resources.GetString("gridUsedItemDetail_DesignTimeLayout.LayoutString")
        Me.gridUsedItemDetail.DesignTimeLayout = gridUsedItemDetail_DesignTimeLayout
        Me.gridUsedItemDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUsedItemDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridUsedItemDetail.GroupByBoxVisible = False
        Me.gridUsedItemDetail.Location = New System.Drawing.Point(0, 29)
        Me.gridUsedItemDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.gridUsedItemDetail.Name = "gridUsedItemDetail"
        Me.gridUsedItemDetail.RecordNavigator = True
        Me.gridUsedItemDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridUsedItemDetail.Size = New System.Drawing.Size(943, 188)
        Me.gridUsedItemDetail.TabIndex = 34
        Me.gridUsedItemDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(943, 29)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Used Item List"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorInHouseUsed
        '
        Me.ErrorInHouseUsed.ContainerControl = Me
        '
        'DepartInHouseUsedMainInven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(943, 502)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DepartInHouseUsedMainInven"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In House Used Item"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridUsedItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorInHouseUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRemoveItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnModifyItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAddItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents PictItem As System.Windows.Forms.PictureBox
    Friend WithEvents LblItemID As System.Windows.Forms.Label
    Friend WithEvents TxtUsedQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtItemBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtbComment As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSaveNewUsed As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gridUsedItemDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtStockQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorInHouseUsed As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dptUsedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GridExpireDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents LblExpireID As System.Windows.Forms.Label
End Class
