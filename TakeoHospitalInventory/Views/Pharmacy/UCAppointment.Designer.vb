<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCAppointment))
        Dim GridAppointment_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCalled = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
        Me.CboDoctor = New System.Windows.Forms.ComboBox
        Me.ChByDoctor = New System.Windows.Forms.CheckBox
        Me.BtnDisplayAppp = New System.Windows.Forms.Button
        Me.DateATo = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.DateAFrom = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer
        Me.GridAppointment = New Janus.Windows.GridEX.GridEX
        Me.CrystalApp = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ErrAppointMent = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RadByDateCreate = New System.Windows.Forms.RadioButton
        Me.RadByDateApp = New System.Windows.Forms.RadioButton
        Me.ToolStrip2.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.GridAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrAppointMent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewAppoint, Me.ToolStripSeparator6, Me.ToolStripButton2, Me.ToolStripSeparator7, Me.BtnReportApp, Me.ToolStripSeparator8, Me.ToolStripSplitButton1, Me.ToolStripSeparator1, Me.BtnCalled})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(942, 37)
        Me.ToolStrip2.TabIndex = 1
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'BtnCalled
        '
        Me.BtnCalled.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnCalled.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1316401141_Schedule_File
        Me.BtnCalled.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCalled.Name = "BtnCalled"
        Me.BtnCalled.Size = New System.Drawing.Size(156, 34)
        Me.BtnCalled.Text = "Update Call App"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 37)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.RadByDateCreate)
        Me.SplitContainer5.Panel1.Controls.Add(Me.RadByDateApp)
        Me.SplitContainer5.Panel1.Controls.Add(Me.CboDoctor)
        Me.SplitContainer5.Panel1.Controls.Add(Me.ChByDoctor)
        Me.SplitContainer5.Panel1.Controls.Add(Me.BtnDisplayAppp)
        Me.SplitContainer5.Panel1.Controls.Add(Me.DateATo)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer5.Panel1.Controls.Add(Me.DateAFrom)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label10)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer5.Size = New System.Drawing.Size(942, 567)
        Me.SplitContainer5.SplitterDistance = 93
        Me.SplitContainer5.TabIndex = 2
        '
        'CboDoctor
        '
        Me.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDoctor.Enabled = False
        Me.CboDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDoctor.FormattingEnabled = True
        Me.CboDoctor.Location = New System.Drawing.Point(13, 49)
        Me.CboDoctor.Name = "CboDoctor"
        Me.CboDoctor.Size = New System.Drawing.Size(185, 28)
        Me.CboDoctor.TabIndex = 20
        '
        'ChByDoctor
        '
        Me.ChByDoctor.AutoSize = True
        Me.ChByDoctor.Location = New System.Drawing.Point(13, 21)
        Me.ChByDoctor.Name = "ChByDoctor"
        Me.ChByDoctor.Size = New System.Drawing.Size(109, 17)
        Me.ChByDoctor.TabIndex = 19
        Me.ChByDoctor.Text = "Select By Doctor:"
        Me.ChByDoctor.UseVisualStyleBackColor = True
        '
        'BtnDisplayAppp
        '
        Me.BtnDisplayAppp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDisplayAppp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplayAppp.Location = New System.Drawing.Point(531, 9)
        Me.BtnDisplayAppp.Name = "BtnDisplayAppp"
        Me.BtnDisplayAppp.Size = New System.Drawing.Size(147, 66)
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
        Me.DateATo.Location = New System.Drawing.Point(403, 51)
        Me.DateATo.Name = "DateATo"
        Me.DateATo.Size = New System.Drawing.Size(110, 26)
        Me.DateATo.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(362, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "To :"
        '
        'DateAFrom
        '
        Me.DateAFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateAFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAFrom.Location = New System.Drawing.Point(402, 12)
        Me.DateAFrom.Name = "DateAFrom"
        Me.DateAFrom.Size = New System.Drawing.Size(111, 26)
        Me.DateAFrom.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(362, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
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
        Me.SplitContainer6.Size = New System.Drawing.Size(942, 470)
        Me.SplitContainer6.SplitterDistance = 740
        Me.SplitContainer6.TabIndex = 0
        '
        'GridAppointment
        '
        Me.GridAppointment.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAppointment_DesignTimeLayout.LayoutString = resources.GetString("GridAppointment_DesignTimeLayout.LayoutString")
        Me.GridAppointment.DesignTimeLayout = GridAppointment_DesignTimeLayout
        Me.GridAppointment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAppointment.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridAppointment.GroupByBoxVisible = False
        Me.GridAppointment.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridAppointment.Location = New System.Drawing.Point(0, 0)
        Me.GridAppointment.Name = "GridAppointment"
        Me.GridAppointment.RecordNavigator = True
        Me.GridAppointment.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridAppointment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAppointment.Size = New System.Drawing.Size(942, 470)
        Me.GridAppointment.TabIndex = 0
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
        'ErrAppointMent
        '
        Me.ErrAppointMent.ContainerControl = Me
        '
        'RadByDateCreate
        '
        Me.RadByDateCreate.AutoSize = True
        Me.RadByDateCreate.Checked = True
        Me.RadByDateCreate.Location = New System.Drawing.Point(232, 21)
        Me.RadByDateCreate.Name = "RadByDateCreate"
        Me.RadByDateCreate.Size = New System.Drawing.Size(94, 17)
        Me.RadByDateCreate.TabIndex = 25
        Me.RadByDateCreate.TabStop = True
        Me.RadByDateCreate.Text = "By date create"
        Me.RadByDateCreate.UseVisualStyleBackColor = True
        '
        'RadByDateApp
        '
        Me.RadByDateApp.AutoSize = True
        Me.RadByDateApp.Location = New System.Drawing.Point(232, 58)
        Me.RadByDateApp.Name = "RadByDateApp"
        Me.RadByDateApp.Size = New System.Drawing.Size(122, 17)
        Me.RadByDateApp.TabIndex = 24
        Me.RadByDateApp.Text = "By date appointment"
        Me.RadByDateApp.UseVisualStyleBackColor = True
        '
        'UCAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer5)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "UCAppointment"
        Me.Size = New System.Drawing.Size(942, 604)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.GridAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrAppointMent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewAppoint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReportApp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateOnAppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteAppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnDisplayAppp As System.Windows.Forms.Button
    Friend WithEvents DateATo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateAFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridAppointment As Janus.Windows.GridEX.GridEX
    Friend WithEvents CrystalApp As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ChByDoctor As System.Windows.Forms.CheckBox
    Friend WithEvents CboDoctor As System.Windows.Forms.ComboBox
    Friend WithEvents ErrAppointMent As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCalled As System.Windows.Forms.ToolStripButton
    Friend WithEvents RadByDateCreate As System.Windows.Forms.RadioButton
    Friend WithEvents RadByDateApp As System.Windows.Forms.RadioButton

End Class
