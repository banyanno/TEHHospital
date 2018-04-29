<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RefractionParameter
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
        Dim GridDiagnosisRefraction_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RefractionParameter))
        Dim GridGlassesRefraction_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVARefraction_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.RefractionDiagnosis = New System.Windows.Forms.TabPage
        Me.GridDiagnosisRefraction = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewDiagnosis = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteDiagnosis = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshDiagnosis = New System.Windows.Forms.ToolStripButton
        Me.RefractionGlasses = New System.Windows.Forms.TabPage
        Me.GridGlassesRefraction = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnNewGlasses = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteGlasses = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshGlasses = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.VARefraction = New System.Windows.Forms.TabPage
        Me.GridVARefraction = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.BtnNewVA = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteVA = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshVA = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.RefractionDiagnosis.SuspendLayout()
        CType(Me.GridDiagnosisRefraction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.RefractionGlasses.SuspendLayout()
        CType(Me.GridGlassesRefraction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.VARefraction.SuspendLayout()
        CType(Me.GridVARefraction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.RefractionDiagnosis)
        Me.TabControl1.Controls.Add(Me.RefractionGlasses)
        Me.TabControl1.Controls.Add(Me.VARefraction)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(743, 536)
        Me.TabControl1.TabIndex = 0
        '
        'RefractionDiagnosis
        '
        Me.RefractionDiagnosis.Controls.Add(Me.GridDiagnosisRefraction)
        Me.RefractionDiagnosis.Controls.Add(Me.ToolStrip1)
        Me.RefractionDiagnosis.Location = New System.Drawing.Point(4, 29)
        Me.RefractionDiagnosis.Name = "RefractionDiagnosis"
        Me.RefractionDiagnosis.Padding = New System.Windows.Forms.Padding(3)
        Me.RefractionDiagnosis.Size = New System.Drawing.Size(735, 503)
        Me.RefractionDiagnosis.TabIndex = 0
        Me.RefractionDiagnosis.Text = "Diagnosis Refraction "
        Me.RefractionDiagnosis.UseVisualStyleBackColor = True
        '
        'GridDiagnosisRefraction
        '
        Me.GridDiagnosisRefraction.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDiagnosisRefraction_DesignTimeLayout.LayoutString = resources.GetString("GridDiagnosisRefraction_DesignTimeLayout.LayoutString")
        Me.GridDiagnosisRefraction.DesignTimeLayout = GridDiagnosisRefraction_DesignTimeLayout
        Me.GridDiagnosisRefraction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiagnosisRefraction.GroupByBoxVisible = False
        Me.GridDiagnosisRefraction.Location = New System.Drawing.Point(3, 31)
        Me.GridDiagnosisRefraction.Name = "GridDiagnosisRefraction"
        Me.GridDiagnosisRefraction.RecordNavigator = True
        Me.GridDiagnosisRefraction.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridDiagnosisRefraction.Size = New System.Drawing.Size(729, 469)
        Me.GridDiagnosisRefraction.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewDiagnosis, Me.ToolStripSeparator1, Me.BtnRefreshDiagnosis, Me.BtnDeleteDiagnosis, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(729, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "New Diagnois"
        '
        'BtnNewDiagnosis
        '
        Me.BtnNewDiagnosis.Image = Global.TakeoHospitalInventory.My.Resources.Resources._new
        Me.BtnNewDiagnosis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewDiagnosis.Name = "BtnNewDiagnosis"
        Me.BtnNewDiagnosis.Size = New System.Drawing.Size(134, 25)
        Me.BtnNewDiagnosis.Text = "New Diagnosis"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'BtnDeleteDiagnosis
        '
        Me.BtnDeleteDiagnosis.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeleteDiagnosis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteDiagnosis.Name = "BtnDeleteDiagnosis"
        Me.BtnDeleteDiagnosis.Size = New System.Drawing.Size(146, 25)
        Me.BtnDeleteDiagnosis.Text = "Delete Diagnosis"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'BtnRefreshDiagnosis
        '
        Me.BtnRefreshDiagnosis.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefreshDiagnosis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshDiagnosis.Name = "BtnRefreshDiagnosis"
        Me.BtnRefreshDiagnosis.Size = New System.Drawing.Size(117, 25)
        Me.BtnRefreshDiagnosis.Text = "     Refesh     "
        '
        'RefractionGlasses
        '
        Me.RefractionGlasses.Controls.Add(Me.GridGlassesRefraction)
        Me.RefractionGlasses.Controls.Add(Me.ToolStrip2)
        Me.RefractionGlasses.Location = New System.Drawing.Point(4, 29)
        Me.RefractionGlasses.Name = "RefractionGlasses"
        Me.RefractionGlasses.Padding = New System.Windows.Forms.Padding(3)
        Me.RefractionGlasses.Size = New System.Drawing.Size(735, 503)
        Me.RefractionGlasses.TabIndex = 1
        Me.RefractionGlasses.Tag = "Glasses"
        Me.RefractionGlasses.Text = "Glasses Refraction "
        Me.RefractionGlasses.UseVisualStyleBackColor = True
        '
        'GridGlassesRefraction
        '
        Me.GridGlassesRefraction.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridGlassesRefraction_DesignTimeLayout.LayoutString = resources.GetString("GridGlassesRefraction_DesignTimeLayout.LayoutString")
        Me.GridGlassesRefraction.DesignTimeLayout = GridGlassesRefraction_DesignTimeLayout
        Me.GridGlassesRefraction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGlassesRefraction.GroupByBoxVisible = False
        Me.GridGlassesRefraction.Location = New System.Drawing.Point(3, 31)
        Me.GridGlassesRefraction.Name = "GridGlassesRefraction"
        Me.GridGlassesRefraction.RecordNavigator = True
        Me.GridGlassesRefraction.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridGlassesRefraction.Size = New System.Drawing.Size(729, 469)
        Me.GridGlassesRefraction.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewGlasses, Me.ToolStripSeparator3, Me.BtnRefreshGlasses, Me.ToolStripSeparator7, Me.BtnDeleteGlasses, Me.ToolStripSeparator4})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(729, 28)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnNewGlasses
        '
        Me.BtnNewGlasses.Image = Global.TakeoHospitalInventory.My.Resources.Resources._new
        Me.BtnNewGlasses.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewGlasses.Name = "BtnNewGlasses"
        Me.BtnNewGlasses.Size = New System.Drawing.Size(118, 25)
        Me.BtnNewGlasses.Text = "New Glasses"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'BtnDeleteGlasses
        '
        Me.BtnDeleteGlasses.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeleteGlasses.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteGlasses.Name = "BtnDeleteGlasses"
        Me.BtnDeleteGlasses.Size = New System.Drawing.Size(130, 25)
        Me.BtnDeleteGlasses.Text = "Delete Glasses"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
        '
        'BtnRefreshGlasses
        '
        Me.BtnRefreshGlasses.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefreshGlasses.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshGlasses.Name = "BtnRefreshGlasses"
        Me.BtnRefreshGlasses.Size = New System.Drawing.Size(83, 25)
        Me.BtnRefreshGlasses.Text = "Refresh"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 28)
        '
        'VARefraction
        '
        Me.VARefraction.Controls.Add(Me.GridVARefraction)
        Me.VARefraction.Controls.Add(Me.ToolStrip3)
        Me.VARefraction.Location = New System.Drawing.Point(4, 29)
        Me.VARefraction.Name = "VARefraction"
        Me.VARefraction.Padding = New System.Windows.Forms.Padding(3)
        Me.VARefraction.Size = New System.Drawing.Size(735, 503)
        Me.VARefraction.TabIndex = 2
        Me.VARefraction.Text = "VA Refracton"
        Me.VARefraction.UseVisualStyleBackColor = True
        '
        'GridVARefraction
        '
        Me.GridVARefraction.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridVARefraction_DesignTimeLayout.LayoutString = resources.GetString("GridVARefraction_DesignTimeLayout.LayoutString")
        Me.GridVARefraction.DesignTimeLayout = GridVARefraction_DesignTimeLayout
        Me.GridVARefraction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVARefraction.GroupByBoxVisible = False
        Me.GridVARefraction.Location = New System.Drawing.Point(3, 31)
        Me.GridVARefraction.Name = "GridVARefraction"
        Me.GridVARefraction.RecordNavigator = True
        Me.GridVARefraction.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridVARefraction.Size = New System.Drawing.Size(729, 469)
        Me.GridVARefraction.TabIndex = 1
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewVA, Me.ToolStripSeparator5, Me.BtnRefreshVA, Me.ToolStripSeparator8, Me.BtnDeleteVA, Me.ToolStripSeparator6})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(729, 28)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'BtnNewVA
        '
        Me.BtnNewVA.Image = Global.TakeoHospitalInventory.My.Resources.Resources._new
        Me.BtnNewVA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewVA.Name = "BtnNewVA"
        Me.BtnNewVA.Size = New System.Drawing.Size(85, 25)
        Me.BtnNewVA.Text = "New VA"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 28)
        '
        'BtnDeleteVA
        '
        Me.BtnDeleteVA.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDeleteVA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteVA.Name = "BtnDeleteVA"
        Me.BtnDeleteVA.Size = New System.Drawing.Size(97, 25)
        Me.BtnDeleteVA.Text = "Delete VA"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 28)
        '
        'BtnRefreshVA
        '
        Me.BtnRefreshVA.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefreshVA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshVA.Name = "BtnRefreshVA"
        Me.BtnRefreshVA.Size = New System.Drawing.Size(123, 25)
        Me.BtnRefreshVA.Text = "     Refresh     "
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 28)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "download.png")
        Me.ImageList1.Images.SetKeyName(1, "Exit.ico")
        Me.ImageList1.Images.SetKeyName(2, "refresh.png")
        '
        'RefractionParameter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 536)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RefractionParameter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refraction Parameter"
        Me.TabControl1.ResumeLayout(False)
        Me.RefractionDiagnosis.ResumeLayout(False)
        Me.RefractionDiagnosis.PerformLayout()
        CType(Me.GridDiagnosisRefraction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.RefractionGlasses.ResumeLayout(False)
        Me.RefractionGlasses.PerformLayout()
        CType(Me.GridGlassesRefraction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.VARefraction.ResumeLayout(False)
        Me.VARefraction.PerformLayout()
        CType(Me.GridVARefraction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents RefractionDiagnosis As System.Windows.Forms.TabPage
    Friend WithEvents RefractionGlasses As System.Windows.Forms.TabPage
    Friend WithEvents VARefraction As System.Windows.Forms.TabPage
    Friend WithEvents GridDiagnosisRefraction As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GridGlassesRefraction As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents GridVARefraction As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewDiagnosis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteDiagnosis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewGlasses As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteGlasses As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewVA As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteVA As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshDiagnosis As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnRefreshGlasses As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshVA As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
