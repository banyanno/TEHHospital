<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UFixInventory
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
        Dim GridFixAsset_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UFixInventory))
        Dim GridAssetCheck_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateFixAsset = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteAsset = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewAsset = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewCheckAsset = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CRVFixAsset = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridFixAsset = New Janus.Windows.GridEX.GridEX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridAssetCheck = New Janus.Windows.GridEX.GridEX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboDepartment = New System.Windows.Forms.ComboBox
        Me.ChDepartment = New System.Windows.Forms.CheckBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.TreeDepartment = New System.Windows.Forms.TreeView
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridFixAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridAssetCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.BtnUpdateFixAsset, Me.ToolStripSeparator2, Me.BtnDeleteAsset, Me.ToolStripSeparator3, Me.ViewAsset, Me.ToolStripSeparator5, Me.BtnNewCheckAsset})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1449, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1342235152_navigation_down_button_basic_blue
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(126, 25)
        Me.ToolStripButton1.Text = "New Fix Asset"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'BtnUpdateFixAsset
        '
        Me.BtnUpdateFixAsset.ForeColor = System.Drawing.Color.Blue
        Me.BtnUpdateFixAsset.Image = Global.TakeoHospitalInventory.My.Resources.Resources.configuration_edit
        Me.BtnUpdateFixAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateFixAsset.Name = "BtnUpdateFixAsset"
        Me.BtnUpdateFixAsset.Size = New System.Drawing.Size(144, 25)
        Me.BtnUpdateFixAsset.Text = "Update Fix Asset"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'BtnDeleteAsset
        '
        Me.BtnDeleteAsset.ForeColor = System.Drawing.Color.Blue
        Me.BtnDeleteAsset.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeleteAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteAsset.Name = "BtnDeleteAsset"
        Me.BtnDeleteAsset.Size = New System.Drawing.Size(107, 25)
        Me.BtnDeleteAsset.Text = "Delet Asset"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'ViewAsset
        '
        Me.ViewAsset.ForeColor = System.Drawing.Color.Blue
        Me.ViewAsset.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.ViewAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewAsset.Name = "ViewAsset"
        Me.ViewAsset.Size = New System.Drawing.Size(127, 25)
        Me.ViewAsset.Text = "View All Asset"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 28)
        '
        'BtnNewCheckAsset
        '
        Me.BtnNewCheckAsset.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewCheckAsset.Image = Global.TakeoHospitalInventory.My.Resources.Resources.edit1
        Me.BtnNewCheckAsset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewCheckAsset.Name = "BtnNewCheckAsset"
        Me.BtnNewCheckAsset.Size = New System.Drawing.Size(149, 25)
        Me.BtnNewCheckAsset.Text = "New Check Asset"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CRVFixAsset)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1449, 688)
        Me.SplitContainer1.SplitterDistance = 1190
        Me.SplitContainer1.TabIndex = 1
        '
        'CRVFixAsset
        '
        Me.CRVFixAsset.ActiveViewIndex = -1
        Me.CRVFixAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVFixAsset.DisplayGroupTree = False
        Me.CRVFixAsset.Location = New System.Drawing.Point(644, 22)
        Me.CRVFixAsset.Name = "CRVFixAsset"
        Me.CRVFixAsset.SelectionFormula = ""
        Me.CRVFixAsset.ShowGroupTreeButton = False
        Me.CRVFixAsset.Size = New System.Drawing.Size(497, 613)
        Me.CRVFixAsset.TabIndex = 1
        Me.CRVFixAsset.ViewTimeSelectionFormula = ""
        Me.CRVFixAsset.Visible = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(36, 66)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(593, 622)
        Me.SplitContainer2.SplitterDistance = 422
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridFixAsset)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 422)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Products"
        '
        'GridFixAsset
        '
        GridFixAsset_DesignTimeLayout.LayoutString = resources.GetString("GridFixAsset_DesignTimeLayout.LayoutString")
        Me.GridFixAsset.DesignTimeLayout = GridFixAsset_DesignTimeLayout
        Me.GridFixAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFixAsset.DynamicFiltering = True
        Me.GridFixAsset.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridFixAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridFixAsset.GroupByBoxVisible = False
        Me.GridFixAsset.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridFixAsset.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridFixAsset.Location = New System.Drawing.Point(3, 22)
        Me.GridFixAsset.Name = "GridFixAsset"
        Me.GridFixAsset.RecordNavigator = True
        Me.GridFixAsset.Size = New System.Drawing.Size(587, 397)
        Me.GridFixAsset.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridAssetCheck)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(593, 196)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Check List Detail"
        '
        'GridAssetCheck
        '
        GridAssetCheck_DesignTimeLayout.LayoutString = resources.GetString("GridAssetCheck_DesignTimeLayout.LayoutString")
        Me.GridAssetCheck.DesignTimeLayout = GridAssetCheck_DesignTimeLayout
        Me.GridAssetCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAssetCheck.GroupByBoxVisible = False
        Me.GridAssetCheck.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridAssetCheck.Location = New System.Drawing.Point(3, 22)
        Me.GridAssetCheck.Name = "GridAssetCheck"
        Me.GridAssetCheck.RecordNavigator = True
        Me.GridAssetCheck.Size = New System.Drawing.Size(587, 171)
        Me.GridAssetCheck.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Splitter1)
        Me.GroupBox1.Controls.Add(Me.TreeDepartment)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 688)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Departments"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox4.Controls.Add(Me.DateTo)
        Me.GroupBox4.Controls.Add(Me.DateFrom)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.CboDepartment)
        Me.GroupBox4.Controls.Add(Me.ChDepartment)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(3, 454)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(249, 231)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fix Asset Report"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(11, 223)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(111, 36)
        Me.BtnPrintPreview.TabIndex = 6
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd - MM - yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(11, 188)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(200, 26)
        Me.DateTo.TabIndex = 5
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd - MM - yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(11, 126)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(200, 26)
        Me.DateFrom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date Buy From:"
        '
        'CboDepartment
        '
        Me.CboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDepartment.Enabled = False
        Me.CboDepartment.FormattingEnabled = True
        Me.CboDepartment.Location = New System.Drawing.Point(11, 58)
        Me.CboDepartment.Name = "CboDepartment"
        Me.CboDepartment.Size = New System.Drawing.Size(225, 28)
        Me.CboDepartment.TabIndex = 1
        '
        'ChDepartment
        '
        Me.ChDepartment.AutoSize = True
        Me.ChDepartment.Location = New System.Drawing.Point(11, 28)
        Me.ChDepartment.Name = "ChDepartment"
        Me.ChDepartment.Size = New System.Drawing.Size(129, 24)
        Me.ChDepartment.TabIndex = 0
        Me.ChDepartment.Text = "Select By Dep"
        Me.ChDepartment.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(3, 449)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(249, 5)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'TreeDepartment
        '
        Me.TreeDepartment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TreeDepartment.Dock = System.Windows.Forms.DockStyle.Top
        Me.TreeDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeDepartment.ForeColor = System.Drawing.Color.Blue
        Me.TreeDepartment.FullRowSelect = True
        Me.TreeDepartment.HideSelection = False
        Me.TreeDepartment.Indent = 21
        Me.TreeDepartment.ItemHeight = 28
        Me.TreeDepartment.Location = New System.Drawing.Point(3, 22)
        Me.TreeDepartment.Name = "TreeDepartment"
        Me.TreeDepartment.Size = New System.Drawing.Size(249, 427)
        Me.TreeDepartment.TabIndex = 0
        '
        'UFixInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "UFixInventory"
        Me.Size = New System.Drawing.Size(1449, 716)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridFixAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridAssetCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TreeDepartment As System.Windows.Forms.TreeView
    Friend WithEvents GridFixAsset As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridAssetCheck As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateFixAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewCheckAsset As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents ChDepartment As System.Windows.Forms.CheckBox
    Friend WithEvents CRVFixAsset As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
