<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainRefraction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainRefraction))
        Dim GridRefraction_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewRefraction = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnParameter = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridRefraction = New Janus.Windows.GridEX.GridEX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateRefractFrom = New System.Windows.Forms.DateTimePicker
        Me.DateRefractTo = New System.Windows.Forms.DateTimePicker
        Me.ChWithPatientNo = New System.Windows.Forms.CheckBox
        Me.TxtFindPatientNo = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridRefraction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BtnNewRefraction, Me.ToolStripSeparator3, Me.BtnParameter, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(842, 53)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'BtnNewRefraction
        '
        Me.BtnNewRefraction.Image = CType(resources.GetObject("BtnNewRefraction.Image"), System.Drawing.Image)
        Me.BtnNewRefraction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewRefraction.Name = "BtnNewRefraction"
        Me.BtnNewRefraction.Size = New System.Drawing.Size(121, 50)
        Me.BtnNewRefraction.Text = "New Refraction"
        Me.BtnNewRefraction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'BtnParameter
        '
        Me.BtnParameter.Image = CType(resources.GetObject("BtnParameter.Image"), System.Drawing.Image)
        Me.BtnParameter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnParameter.Name = "BtnParameter"
        Me.BtnParameter.Size = New System.Drawing.Size(160, 50)
        Me.BtnParameter.Text = "Parameter Refraction"
        Me.BtnParameter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 53)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(842, 468)
        Me.UiTab1.TabIndex = 3
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2})
        Me.UiTab1.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Left
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.SplitContainer1)
        Me.UiTabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTabPage1.Location = New System.Drawing.Point(28, 1)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(811, 464)
        Me.UiTabPage1.StateStyles.FormatStyle.FontSize = 12.0!
        Me.UiTabPage1.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Refraction Information"
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Location = New System.Drawing.Point(28, 1)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(811, 464)
        Me.UiTabPage2.StateStyles.FormatStyle.FontSize = 12.0!
        Me.UiTabPage2.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Refraction Report"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridRefraction)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(811, 464)
        Me.SplitContainer1.SplitterDistance = 578
        Me.SplitContainer1.TabIndex = 0
        '
        'GridRefraction
        '
        Me.GridRefraction.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridRefraction_DesignTimeLayout.LayoutString = resources.GetString("GridRefraction_DesignTimeLayout.LayoutString")
        Me.GridRefraction.DesignTimeLayout = GridRefraction_DesignTimeLayout
        Me.GridRefraction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRefraction.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridRefraction.GroupByBoxVisible = False
        Me.GridRefraction.Location = New System.Drawing.Point(0, 0)
        Me.GridRefraction.Name = "GridRefraction"
        Me.GridRefraction.RecordNavigator = True
        Me.GridRefraction.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridRefraction.Size = New System.Drawing.Size(578, 464)
        Me.GridRefraction.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TxtFindPatientNo)
        Me.GroupBox1.Controls.Add(Me.ChWithPatientNo)
        Me.GroupBox1.Controls.Add(Me.DateRefractTo)
        Me.GroupBox1.Controls.Add(Me.DateRefractFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 464)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find Refraction By:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To:"
        '
        'DateRefractFrom
        '
        Me.DateRefractFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateRefractFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRefractFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRefractFrom.Location = New System.Drawing.Point(60, 41)
        Me.DateRefractFrom.Name = "DateRefractFrom"
        Me.DateRefractFrom.Size = New System.Drawing.Size(154, 26)
        Me.DateRefractFrom.TabIndex = 2
        '
        'DateRefractTo
        '
        Me.DateRefractTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRefractTo.CustomFormat = "dd/MM/yyyy"
        Me.DateRefractTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRefractTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRefractTo.Location = New System.Drawing.Point(59, 75)
        Me.DateRefractTo.Name = "DateRefractTo"
        Me.DateRefractTo.Size = New System.Drawing.Size(154, 26)
        Me.DateRefractTo.TabIndex = 3
        '
        'ChWithPatientNo
        '
        Me.ChWithPatientNo.AutoSize = True
        Me.ChWithPatientNo.Location = New System.Drawing.Point(8, 113)
        Me.ChWithPatientNo.Name = "ChWithPatientNo"
        Me.ChWithPatientNo.Size = New System.Drawing.Size(173, 24)
        Me.ChWithPatientNo.TabIndex = 4
        Me.ChWithPatientNo.Text = "Find with Patient No:"
        Me.ChWithPatientNo.UseVisualStyleBackColor = True
        '
        'TxtFindPatientNo
        '
        Me.TxtFindPatientNo.Enabled = False
        Me.TxtFindPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFindPatientNo.Location = New System.Drawing.Point(9, 139)
        Me.TxtFindPatientNo.Name = "TxtFindPatientNo"
        Me.TxtFindPatientNo.Size = New System.Drawing.Size(203, 26)
        Me.TxtFindPatientNo.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MainRefraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UiTab1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "MainRefraction"
        Me.Size = New System.Drawing.Size(842, 521)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridRefraction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnParameter As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnNewRefraction As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridRefraction As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateRefractTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateRefractFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChWithPatientNo As System.Windows.Forms.CheckBox
    Friend WithEvents TxtFindPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
