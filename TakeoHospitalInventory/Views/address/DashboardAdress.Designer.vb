<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAdress))
        Dim GridProvince_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridDistrict_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCommune_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVillage_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ProvinceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.DistrictToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.CommuneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.VillageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridProvince = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridDistrict = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GridCommune = New Janus.Windows.GridEX.GridEX
        Me.Label2 = New System.Windows.Forms.Label
        Me.GridVillage = New Janus.Windows.GridEX.GridEX
        Me.Label3 = New System.Windows.Forms.Label
        Me.VSMInterface = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.GridCommune, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVillage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BtnRefresh, Me.ToolStripSeparator3, Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1104, 57)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        Me.ToolStripSeparator1.Visible = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.AutoSize = False
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(120, 54)
        Me.BtnRefresh.Text = "Refresh Data"
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 25
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProvinceToolStripMenuItem, Me.ToolStripMenuItem1, Me.DistrictToolStripMenuItem, Me.ToolStripMenuItem2, Me.CommuneToolStripMenuItem, Me.ToolStripMenuItem3, Me.VillageToolStripMenuItem})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(171, 54)
        Me.ToolStripSplitButton1.Text = "Create New Address"
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProvinceToolStripMenuItem
        '
        Me.ProvinceToolStripMenuItem.CheckOnClick = True
        Me.ProvinceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProvinceToolStripMenuItem.Name = "ProvinceToolStripMenuItem"
        Me.ProvinceToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ProvinceToolStripMenuItem.Text = "Province..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(155, 6)
        '
        'DistrictToolStripMenuItem
        '
        Me.DistrictToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DistrictToolStripMenuItem.Name = "DistrictToolStripMenuItem"
        Me.DistrictToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DistrictToolStripMenuItem.Text = "District..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(155, 6)
        '
        'CommuneToolStripMenuItem
        '
        Me.CommuneToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CommuneToolStripMenuItem.Name = "CommuneToolStripMenuItem"
        Me.CommuneToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CommuneToolStripMenuItem.Text = "Commune..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(155, 6)
        '
        'VillageToolStripMenuItem
        '
        Me.VillageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VillageToolStripMenuItem.Name = "VillageToolStripMenuItem"
        Me.VillageToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.VillageToolStripMenuItem.Text = "Village..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 57)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridProvince)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1104, 474)
        Me.SplitContainer1.SplitterDistance = 420
        Me.SplitContainer1.TabIndex = 5
        '
        'GridProvince
        '
        Me.GridProvince.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridProvince.BackColor = System.Drawing.Color.White
        Me.GridProvince.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridProvince_DesignTimeLayout.LayoutString = resources.GetString("GridProvince_DesignTimeLayout.LayoutString")
        Me.GridProvince.DesignTimeLayout = GridProvince_DesignTimeLayout
        Me.GridProvince.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProvince.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridProvince.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridProvince.GroupByBoxVisible = False
        Me.GridProvince.HeaderFormatStyle.BackColor = System.Drawing.Color.Ivory
        Me.GridProvince.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridProvince.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridProvince.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridProvince.Location = New System.Drawing.Point(0, 0)
        Me.GridProvince.Name = "GridProvince"
        Me.GridProvince.RecordNavigator = True
        Me.GridProvince.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridProvince.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridProvince.Size = New System.Drawing.Size(420, 474)
        Me.GridProvince.TabIndex = 6
        Me.GridProvince.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridProvince.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridDistrict)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(680, 474)
        Me.SplitContainer2.SplitterDistance = 228
        Me.SplitContainer2.TabIndex = 0
        '
        'GridDistrict
        '
        Me.GridDistrict.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDistrict.BackColor = System.Drawing.Color.White
        Me.GridDistrict.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridDistrict_DesignTimeLayout.LayoutString = resources.GetString("GridDistrict_DesignTimeLayout.LayoutString")
        Me.GridDistrict.DesignTimeLayout = GridDistrict_DesignTimeLayout
        Me.GridDistrict.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDistrict.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridDistrict.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridDistrict.GroupByBoxVisible = False
        Me.GridDistrict.HeaderFormatStyle.BackColor = System.Drawing.Color.Ivory
        Me.GridDistrict.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridDistrict.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridDistrict.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridDistrict.Location = New System.Drawing.Point(0, 23)
        Me.GridDistrict.Name = "GridDistrict"
        Me.GridDistrict.RecordNavigator = True
        Me.GridDistrict.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridDistrict.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDistrict.Size = New System.Drawing.Size(680, 205)
        Me.GridDistrict.TabIndex = 7
        Me.GridDistrict.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridDistrict.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(680, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DISTRICT"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GridCommune)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GridVillage)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer3.Size = New System.Drawing.Size(680, 242)
        Me.SplitContainer3.SplitterDistance = 352
        Me.SplitContainer3.TabIndex = 10
        '
        'GridCommune
        '
        Me.GridCommune.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCommune.BackColor = System.Drawing.Color.White
        Me.GridCommune.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridCommune_DesignTimeLayout.LayoutString = resources.GetString("GridCommune_DesignTimeLayout.LayoutString")
        Me.GridCommune.DesignTimeLayout = GridCommune_DesignTimeLayout
        Me.GridCommune.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCommune.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridCommune.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridCommune.GroupByBoxVisible = False
        Me.GridCommune.HeaderFormatStyle.BackColor = System.Drawing.Color.Ivory
        Me.GridCommune.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridCommune.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridCommune.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridCommune.Location = New System.Drawing.Point(0, 23)
        Me.GridCommune.Name = "GridCommune"
        Me.GridCommune.RecordNavigator = True
        Me.GridCommune.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridCommune.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridCommune.Size = New System.Drawing.Size(352, 219)
        Me.GridCommune.TabIndex = 7
        Me.GridCommune.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridCommune.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "COMMUNE"
        '
        'GridVillage
        '
        Me.GridVillage.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVillage.BackColor = System.Drawing.Color.White
        Me.GridVillage.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridVillage_DesignTimeLayout.LayoutString = resources.GetString("GridVillage_DesignTimeLayout.LayoutString")
        Me.GridVillage.DesignTimeLayout = GridVillage_DesignTimeLayout
        Me.GridVillage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVillage.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.GridVillage.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridVillage.GroupByBoxVisible = False
        Me.GridVillage.HeaderFormatStyle.BackColor = System.Drawing.Color.Ivory
        Me.GridVillage.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridVillage.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridVillage.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridVillage.Location = New System.Drawing.Point(0, 23)
        Me.GridVillage.Name = "GridVillage"
        Me.GridVillage.RecordNavigator = True
        Me.GridVillage.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridVillage.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridVillage.Size = New System.Drawing.Size(324, 219)
        Me.GridVillage.TabIndex = 11
        Me.GridVillage.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridVillage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "VILLAGE"
        '
        'VSMInterface
        '
        JanusColorScheme1.ActiveCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme1.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme1.ControlColor = System.Drawing.Color.White
        JanusColorScheme1.ControlDarkColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme1.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.White
        JanusColorScheme1.InfoColor = System.Drawing.Color.White
        JanusColorScheme1.InfoTextColor = System.Drawing.Color.Black
        JanusColorScheme1.MenuColor = System.Drawing.Color.White
        JanusColorScheme1.MenuTextColor = System.Drawing.Color.Black
        JanusColorScheme1.Name = "DefaultInterface"
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.Black
        Me.VSMInterface.ColorSchemes.Add(JanusColorScheme1)
        Me.VSMInterface.DefaultColorScheme = Nothing
        '
        'DashboardAdress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardAdress"
        Me.Size = New System.Drawing.Size(1104, 531)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridProvince, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.GridCommune, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVillage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridProvince As Janus.Windows.GridEX.GridEX
    Friend WithEvents VSMInterface As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents GridDistrict As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridCommune As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridVillage As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ProvinceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DistrictToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CommuneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VillageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
