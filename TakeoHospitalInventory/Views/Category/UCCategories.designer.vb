﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCategories
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
        Dim gridItems_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCategories))
        Dim gridItemRecTrans_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridExpireDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridItemChemical_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridItemPrice_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridItemProvider_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TVCategories = New System.Windows.Forms.TreeView
        Me.MenuCreateCatAndItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.NewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gridItems = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.PicItem = New System.Windows.Forms.PictureBox
        Me.TxtBarcodeNo = New System.Windows.Forms.TextBox
        Me.RadItemName = New System.Windows.Forms.RadioButton
        Me.RadBarcodNo = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.gridItemRecTrans = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage
        Me.GridExpireDetail = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.gridItemChemical = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
        Me.gridItemPrice = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.TBNewPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnEditPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.TBSetCurPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.TBCurrentPrice = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshData = New System.Windows.Forms.ToolStripButton
        Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage
        Me.gridItemProvider = New Janus.Windows.GridEX.GridEX
        Me.lblCateName = New System.Windows.Forms.Label
        Me.ImageListCate = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStripCate = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuAddCate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.subMenuAddItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.subMenuAddItemProvider = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuEditCate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.subMenuEditItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.subMenuDeleteCate = New System.Windows.Forms.ToolStripMenuItem
        Me.menuRefreshData = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshListItemsDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshListItemsInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuAdjustStock = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuPrintAllItems = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintItemsInCategory = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintItemAlertQty = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintItemAlertExpired = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnViewItemDetial = New System.Windows.Forms.ToolStripMenuItem
        Me.BgLoadingCategories = New System.ComponentModel.BackgroundWorker
        Me.BgAfterTVSelected = New System.ComponentModel.BackgroundWorker
        Me.MenuCreateCatAndItem.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.gridItemRecTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage5.SuspendLayout()
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.gridItemChemical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage3.SuspendLayout()
        CType(Me.gridItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.UiTabPage4.SuspendLayout()
        CType(Me.gridItemProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripCate.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVCategories
        '
        Me.TVCategories.BackColor = System.Drawing.SystemColors.Window
        Me.TVCategories.ContextMenuStrip = Me.MenuCreateCatAndItem
        Me.TVCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVCategories.HideSelection = False
        Me.TVCategories.Location = New System.Drawing.Point(0, 0)
        Me.TVCategories.Name = "TVCategories"
        Me.TVCategories.Size = New System.Drawing.Size(200, 215)
        Me.TVCategories.TabIndex = 6
        '
        'MenuCreateCatAndItem
        '
        Me.MenuCreateCatAndItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCategoryToolStripMenuItem, Me.ToolStripMenuItem3, Me.NewItemToolStripMenuItem})
        Me.MenuCreateCatAndItem.Name = "MenuCreateCatAndItem"
        Me.MenuCreateCatAndItem.Size = New System.Drawing.Size(150, 54)
        '
        'NewCategoryToolStripMenuItem
        '
        Me.NewCategoryToolStripMenuItem.Name = "NewCategoryToolStripMenuItem"
        Me.NewCategoryToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewCategoryToolStripMenuItem.Text = "New Category"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(146, 6)
        '
        'NewItemToolStripMenuItem
        '
        Me.NewItemToolStripMenuItem.Name = "NewItemToolStripMenuItem"
        Me.NewItemToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NewItemToolStripMenuItem.Text = "New Item"
        '
        'gridItems
        '
        Me.gridItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItems_DesignTimeLayout.LayoutString = resources.GetString("gridItems_DesignTimeLayout.LayoutString")
        Me.gridItems.DesignTimeLayout = gridItems_DesignTimeLayout
        Me.gridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItems.GroupByBoxVisible = False
        Me.gridItems.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridItems.Location = New System.Drawing.Point(0, 0)
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RecordNavigator = True
        Me.gridItems.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItems.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridItems.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridItems.Size = New System.Drawing.Size(748, 202)
        Me.gridItems.TabIndex = 7
        Me.gridItems.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        Me.gridItems.WatermarkImage.Alpha = 150
        Me.gridItems.WatermarkImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.gridItems.WatermarkImage.Size = New System.Drawing.Size(150, 150)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCateName)
        Me.SplitContainer1.Size = New System.Drawing.Size(952, 515)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.TabIndex = 8
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TVCategories)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(200, 490)
        Me.SplitContainer3.SplitterDistance = 215
        Me.SplitContainer3.SplitterWidth = 3
        Me.SplitContainer3.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtItemName)
        Me.GroupBox1.Controls.Add(Me.PicItem)
        Me.GroupBox1.Controls.Add(Me.TxtBarcodeNo)
        Me.GroupBox1.Controls.Add(Me.RadItemName)
        Me.GroupBox1.Controls.Add(Me.RadBarcodNo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(200, 272)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Item By"
        '
        'TxtItemName
        '
        Me.TxtItemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(4, 88)
        Me.TxtItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(192, 26)
        Me.TxtItemName.TabIndex = 4
        '
        'PicItem
        '
        Me.PicItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicItem.Location = New System.Drawing.Point(4, 201)
        Me.PicItem.Margin = New System.Windows.Forms.Padding(2)
        Me.PicItem.Name = "PicItem"
        Me.PicItem.Size = New System.Drawing.Size(192, 67)
        Me.PicItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicItem.TabIndex = 3
        Me.PicItem.TabStop = False
        '
        'TxtBarcodeNo
        '
        Me.TxtBarcodeNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBarcodeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcodeNo.Location = New System.Drawing.Point(4, 40)
        Me.TxtBarcodeNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBarcodeNo.Name = "TxtBarcodeNo"
        Me.TxtBarcodeNo.Size = New System.Drawing.Size(192, 26)
        Me.TxtBarcodeNo.TabIndex = 1
        '
        'RadItemName
        '
        Me.RadItemName.AutoSize = True
        Me.RadItemName.Location = New System.Drawing.Point(4, 67)
        Me.RadItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.RadItemName.Name = "RadItemName"
        Me.RadItemName.Size = New System.Drawing.Size(79, 17)
        Me.RadItemName.TabIndex = 0
        Me.RadItemName.Text = "Item Name:"
        Me.RadItemName.UseVisualStyleBackColor = True
        '
        'RadBarcodNo
        '
        Me.RadBarcodNo.AutoSize = True
        Me.RadBarcodNo.Checked = True
        Me.RadBarcodNo.Location = New System.Drawing.Point(4, 19)
        Me.RadBarcodNo.Margin = New System.Windows.Forms.Padding(2)
        Me.RadBarcodNo.Name = "RadBarcodNo"
        Me.RadBarcodNo.Size = New System.Drawing.Size(85, 17)
        Me.RadBarcodNo.TabIndex = 0
        Me.RadBarcodNo.TabStop = True
        Me.RadBarcodNo.Text = "Barcode No:"
        Me.RadBarcodNo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Categories"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 26)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gridItems)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(748, 489)
        Me.SplitContainer2.SplitterDistance = 202
        Me.SplitContainer2.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UiTab1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(748, 283)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.UiTab1.Location = New System.Drawing.Point(3, 16)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(742, 264)
        Me.UiTab1.TabIndex = 0
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage2, Me.UiTabPage5, Me.UiTabPage1, Me.UiTabPage3, Me.UiTabPage4})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.gridItemRecTrans)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(740, 240)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Item Received Transaction"
        '
        'gridItemRecTrans
        '
        Me.gridItemRecTrans.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemRecTrans_DesignTimeLayout.LayoutString = resources.GetString("gridItemRecTrans_DesignTimeLayout.LayoutString")
        Me.gridItemRecTrans.DesignTimeLayout = gridItemRecTrans_DesignTimeLayout
        Me.gridItemRecTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemRecTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemRecTrans.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemRecTrans.GroupByBoxVisible = False
        Me.gridItemRecTrans.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.gridItemRecTrans.Location = New System.Drawing.Point(0, 0)
        Me.gridItemRecTrans.Name = "gridItemRecTrans"
        Me.gridItemRecTrans.RecordNavigator = True
        Me.gridItemRecTrans.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemRecTrans.Size = New System.Drawing.Size(740, 240)
        Me.gridItemRecTrans.TabIndex = 8
        Me.gridItemRecTrans.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'UiTabPage5
        '
        Me.UiTabPage5.Controls.Add(Me.GridExpireDetail)
        Me.UiTabPage5.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage5.Name = "UiTabPage5"
        Me.UiTabPage5.Size = New System.Drawing.Size(740, 240)
        Me.UiTabPage5.TabStop = True
        Me.UiTabPage5.Text = "QTY Expire Date"
        '
        'GridExpireDetail
        '
        Me.GridExpireDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridExpireDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridExpireDetail_DesignTimeLayout.LayoutString = resources.GetString("GridExpireDetail_DesignTimeLayout.LayoutString")
        Me.GridExpireDetail.DesignTimeLayout = GridExpireDetail_DesignTimeLayout
        Me.GridExpireDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridExpireDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GridExpireDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridExpireDetail.GroupByBoxVisible = False
        Me.GridExpireDetail.Location = New System.Drawing.Point(0, 0)
        Me.GridExpireDetail.Name = "GridExpireDetail"
        Me.GridExpireDetail.RecordNavigator = True
        Me.GridExpireDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridExpireDetail.Size = New System.Drawing.Size(740, 240)
        Me.GridExpireDetail.TabIndex = 10
        Me.GridExpireDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridExpireDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.gridItemChemical)
        Me.UiTabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(740, 240)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Chemical Detail"
        '
        'gridItemChemical
        '
        Me.gridItemChemical.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemChemical_DesignTimeLayout.LayoutString = resources.GetString("gridItemChemical_DesignTimeLayout.LayoutString")
        Me.gridItemChemical.DesignTimeLayout = gridItemChemical_DesignTimeLayout
        Me.gridItemChemical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemChemical.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemChemical.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemChemical.GroupByBoxVisible = False
        Me.gridItemChemical.Location = New System.Drawing.Point(0, 0)
        Me.gridItemChemical.Name = "gridItemChemical"
        Me.gridItemChemical.RecordNavigator = True
        Me.gridItemChemical.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemChemical.Size = New System.Drawing.Size(740, 240)
        Me.gridItemChemical.TabIndex = 8
        Me.gridItemChemical.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.gridItemPrice)
        Me.UiTabPage3.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(740, 240)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "Item Price"
        '
        'gridItemPrice
        '
        Me.gridItemPrice.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemPrice_DesignTimeLayout.LayoutString = resources.GetString("gridItemPrice_DesignTimeLayout.LayoutString")
        Me.gridItemPrice.DesignTimeLayout = gridItemPrice_DesignTimeLayout
        Me.gridItemPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemPrice.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemPrice.GroupByBoxVisible = False
        Me.gridItemPrice.Location = New System.Drawing.Point(0, 25)
        Me.gridItemPrice.Name = "gridItemPrice"
        Me.gridItemPrice.RecordNavigator = True
        Me.gridItemPrice.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemPrice.Size = New System.Drawing.Size(740, 215)
        Me.gridItemPrice.TabIndex = 7
        Me.gridItemPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBNewPrice, Me.ToolStripSeparator2, Me.BtnEditPrice, Me.ToolStripSeparator6, Me.TBSetCurPrice, Me.ToolStripSeparator3, Me.TBCurrentPrice, Me.ToolStripSeparator5, Me.BtnRefreshData})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(740, 25)
        Me.ToolStrip2.TabIndex = 8
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'TBNewPrice
        '
        Me.TBNewPrice.Image = Global.TakeoHospitalInventory.My.Resources.Resources.price
        Me.TBNewPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBNewPrice.Name = "TBNewPrice"
        Me.TBNewPrice.Size = New System.Drawing.Size(87, 22)
        Me.TBNewPrice.Text = "New Price"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnEditPrice
        '
        Me.BtnEditPrice.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.BtnEditPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditPrice.Name = "BtnEditPrice"
        Me.BtnEditPrice.Size = New System.Drawing.Size(84, 22)
        Me.BtnEditPrice.Text = "Edit Price"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'TBSetCurPrice
        '
        Me.TBSetCurPrice.Image = Global.TakeoHospitalInventory.My.Resources.Resources.check
        Me.TBSetCurPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBSetCurPrice.Name = "TBSetCurPrice"
        Me.TBSetCurPrice.Size = New System.Drawing.Size(150, 22)
        Me.TBSetCurPrice.Text = "Set As Current Price"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TBCurrentPrice
        '
        Me.TBCurrentPrice.Image = Global.TakeoHospitalInventory.My.Resources.Resources.preview
        Me.TBCurrentPrice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBCurrentPrice.Name = "TBCurrentPrice"
        Me.TBCurrentPrice.Size = New System.Drawing.Size(108, 22)
        Me.TBCurrentPrice.Text = "Current Price"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator5.Visible = False
        '
        'BtnRefreshData
        '
        Me.BtnRefreshData.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.BtnRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshData.Name = "BtnRefreshData"
        Me.BtnRefreshData.Size = New System.Drawing.Size(107, 22)
        Me.BtnRefreshData.Text = "Refresh Data"
        Me.BtnRefreshData.Visible = False
        '
        'UiTabPage4
        '
        Me.UiTabPage4.Controls.Add(Me.gridItemProvider)
        Me.UiTabPage4.Location = New System.Drawing.Point(1, 23)
        Me.UiTabPage4.Name = "UiTabPage4"
        Me.UiTabPage4.Size = New System.Drawing.Size(740, 240)
        Me.UiTabPage4.TabStop = True
        Me.UiTabPage4.Text = "Item Provider"
        '
        'gridItemProvider
        '
        Me.gridItemProvider.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemProvider_DesignTimeLayout.LayoutString = resources.GetString("gridItemProvider_DesignTimeLayout.LayoutString")
        Me.gridItemProvider.DesignTimeLayout = gridItemProvider_DesignTimeLayout
        Me.gridItemProvider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemProvider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.gridItemProvider.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.gridItemProvider.GroupByBoxVisible = False
        Me.gridItemProvider.Location = New System.Drawing.Point(0, 0)
        Me.gridItemProvider.Name = "gridItemProvider"
        Me.gridItemProvider.RecordNavigator = True
        Me.gridItemProvider.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemProvider.Size = New System.Drawing.Size(740, 240)
        Me.gridItemProvider.TabIndex = 9
        Me.gridItemProvider.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'lblCateName
        '
        Me.lblCateName.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblCateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCateName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCateName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateName.ForeColor = System.Drawing.Color.White
        Me.lblCateName.Location = New System.Drawing.Point(0, 0)
        Me.lblCateName.Name = "lblCateName"
        Me.lblCateName.Size = New System.Drawing.Size(748, 26)
        Me.lblCateName.TabIndex = 14
        Me.lblCateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageListCate
        '
        Me.ImageListCate.ImageStream = CType(resources.GetObject("ImageListCate.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListCate.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListCate.Images.SetKeyName(0, "Gear1.png")
        '
        'MenuStripCate
        '
        Me.MenuStripCate.AutoSize = False
        Me.MenuStripCate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripCate.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStripCate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.menuRefreshData, Me.menuAdjustStock, Me.ToolStripMenuItem2, Me.BtnViewItemDetial})
        Me.MenuStripCate.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripCate.Name = "MenuStripCate"
        Me.MenuStripCate.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripCate.Size = New System.Drawing.Size(952, 34)
        Me.MenuStripCate.TabIndex = 9
        Me.MenuStripCate.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuAddCate, Me.ToolStripSeparator4, Me.subMenuAddItem, Me.ToolStripSeparator7, Me.subMenuAddItemProvider})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.blue_new
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(80, 30)
        Me.ToolStripMenuItem1.Text = "New"
        '
        'subMenuAddCate
        '
        Me.subMenuAddCate.Name = "subMenuAddCate"
        Me.subMenuAddCate.Size = New System.Drawing.Size(222, 22)
        Me.subMenuAddCate.Text = "New Category"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(219, 6)
        '
        'subMenuAddItem
        '
        Me.subMenuAddItem.Name = "subMenuAddItem"
        Me.subMenuAddItem.Size = New System.Drawing.Size(222, 22)
        Me.subMenuAddItem.Text = "New Item"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(219, 6)
        '
        'subMenuAddItemProvider
        '
        Me.subMenuAddItemProvider.Name = "subMenuAddItemProvider"
        Me.subMenuAddItemProvider.Size = New System.Drawing.Size(222, 22)
        Me.subMenuAddItemProvider.Text = "Register Item Provider Info"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.AutoSize = False
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuEditCate, Me.ToolStripSeparator1, Me.subMenuEditItem})
        Me.EditToolStripMenuItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(72, 30)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'subMenuEditCate
        '
        Me.subMenuEditCate.Name = "subMenuEditCate"
        Me.subMenuEditCate.Size = New System.Drawing.Size(148, 22)
        Me.subMenuEditCate.Text = "Edit Category"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'subMenuEditItem
        '
        Me.subMenuEditItem.Name = "subMenuEditItem"
        Me.subMenuEditItem.Size = New System.Drawing.Size(148, 22)
        Me.subMenuEditItem.Text = "Edit Item"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.AutoSize = False
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuDeleteCate})
        Me.DeleteToolStripMenuItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit_trash
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(94, 30)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'subMenuDeleteCate
        '
        Me.subMenuDeleteCate.Name = "subMenuDeleteCate"
        Me.subMenuDeleteCate.Size = New System.Drawing.Size(163, 22)
        Me.subMenuDeleteCate.Text = "Delete Category"
        '
        'menuRefreshData
        '
        Me.menuRefreshData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshListItemsDataToolStripMenuItem, Me.RefreshListItemsInformationToolStripMenuItem})
        Me.menuRefreshData.Image = Global.TakeoHospitalInventory.My.Resources.Resources.view_refresh
        Me.menuRefreshData.Name = "menuRefreshData"
        Me.menuRefreshData.Size = New System.Drawing.Size(121, 30)
        Me.menuRefreshData.Text = "Refresh Data"
        '
        'RefreshListItemsDataToolStripMenuItem
        '
        Me.RefreshListItemsDataToolStripMenuItem.Name = "RefreshListItemsDataToolStripMenuItem"
        Me.RefreshListItemsDataToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RefreshListItemsDataToolStripMenuItem.Text = "Refresh List Items Data"
        '
        'RefreshListItemsInformationToolStripMenuItem
        '
        Me.RefreshListItemsInformationToolStripMenuItem.Name = "RefreshListItemsInformationToolStripMenuItem"
        Me.RefreshListItemsInformationToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RefreshListItemsInformationToolStripMenuItem.Text = "Refresh Item Information"
        '
        'menuAdjustStock
        '
        Me.menuAdjustStock.Image = Global.TakeoHospitalInventory.My.Resources.Resources.app_48
        Me.menuAdjustStock.Name = "menuAdjustStock"
        Me.menuAdjustStock.Size = New System.Drawing.Size(121, 30)
        Me.menuAdjustStock.Text = "Adjust Stock"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.AutoSize = False
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPrintAllItems, Me.ToolStripMenuItem4, Me.PrintItemsInCategory, Me.ToolStripMenuItem5, Me.PrintItemAlertQty, Me.ToolStripMenuItem6, Me.PrintItemAlertExpired})
        Me.ToolStripMenuItem2.Image = Global.TakeoHospitalInventory.My.Resources.Resources.document_print
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(70, 30)
        Me.ToolStripMenuItem2.Text = "Print"
        '
        'menuPrintAllItems
        '
        Me.menuPrintAllItems.Name = "menuPrintAllItems"
        Me.menuPrintAllItems.Size = New System.Drawing.Size(215, 22)
        Me.menuPrintAllItems.Text = "Print All Items"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(212, 6)
        '
        'PrintItemsInCategory
        '
        Me.PrintItemsInCategory.Name = "PrintItemsInCategory"
        Me.PrintItemsInCategory.Size = New System.Drawing.Size(215, 22)
        Me.PrintItemsInCategory.Text = "Print Items In Category"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(212, 6)
        '
        'PrintItemAlertQty
        '
        Me.PrintItemAlertQty.Name = "PrintItemAlertQty"
        Me.PrintItemAlertQty.Size = New System.Drawing.Size(215, 22)
        Me.PrintItemAlertQty.Text = "Print Items Alert Quantity"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(212, 6)
        '
        'PrintItemAlertExpired
        '
        Me.PrintItemAlertExpired.Name = "PrintItemAlertExpired"
        Me.PrintItemAlertExpired.Size = New System.Drawing.Size(215, 22)
        Me.PrintItemAlertExpired.Text = "Print Items Alert Expired"
        '
        'BtnViewItemDetial
        '
        Me.BtnViewItemDetial.Image = Global.TakeoHospitalInventory.My.Resources.Resources.arrow_down_green_48
        Me.BtnViewItemDetial.Name = "BtnViewItemDetial"
        Me.BtnViewItemDetial.Size = New System.Drawing.Size(142, 30)
        Me.BtnViewItemDetial.Text = "View Item Detail"
        '
        'BgLoadingCategories
        '
        '
        'BgAfterTVSelected
        '
        '
        'UCCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStripCate)
        Me.Name = "UCCategories"
        Me.Size = New System.Drawing.Size(952, 549)
        Me.MenuCreateCatAndItem.ResumeLayout(False)
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.gridItemRecTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage5.ResumeLayout(False)
        CType(Me.GridExpireDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage1.ResumeLayout(False)
        CType(Me.gridItemChemical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage3.ResumeLayout(False)
        Me.UiTabPage3.PerformLayout()
        CType(Me.gridItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.UiTabPage4.ResumeLayout(False)
        CType(Me.gridItemProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripCate.ResumeLayout(False)
        Me.MenuStripCate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TVCategories As System.Windows.Forms.TreeView
    Friend WithEvents gridItems As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImageListCate As System.Windows.Forms.ImageList
    Friend WithEvents MenuStripCate As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuAddCate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuAddItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuEditCate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuEditItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuDeleteCate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRefreshData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BgLoadingCategories As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCateName As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents menuAdjustStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemPrice As Janus.Windows.GridEX.GridEX
    Friend WithEvents gridItemChemical As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents RadItemName As System.Windows.Forms.RadioButton
    Friend WithEvents RadBarcodNo As System.Windows.Forms.RadioButton
    Friend WithEvents TxtBarcodeNo As System.Windows.Forms.TextBox
    Friend WithEvents PicItem As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPrintAllItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintItemsInCategory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnViewItemDetial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCreateCatAndItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintItemAlertQty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintItemAlertExpired As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BgAfterTVSelected As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemRecTrans As Janus.Windows.GridEX.GridEX
    Friend WithEvents subMenuAddItemProvider As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents gridItemProvider As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TBNewPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEditPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBSetCurPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBCurrentPrice As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshData As System.Windows.Forms.ToolStripButton
    Friend WithEvents RefreshListItemsDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshListItemsInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridExpireDetail As Janus.Windows.GridEX.GridEX

End Class
