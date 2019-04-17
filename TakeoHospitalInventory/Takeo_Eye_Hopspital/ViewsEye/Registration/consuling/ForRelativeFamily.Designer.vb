<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForRelativeFamily
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
        Dim GridFamilyRelative_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForRelativeFamily))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewFamily = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.GridFamilyRelative = New Janus.Windows.GridEX.GridEX
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridFamilyRelative, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewFamily, Me.ToolStripSeparator1, Me.BtnRefresh, Me.ToolStripSeparator2, Me.BtnDelete, Me.ToolStripSeparator3, Me.BtnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(484, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewFamily
        '
        Me.BtnNewFamily.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.BtnNewFamily.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewFamily.Name = "BtnNewFamily"
        Me.BtnNewFamily.Size = New System.Drawing.Size(166, 25)
        Me.BtnNewFamily.Text = "New Family relative"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(83, 25)
        Me.BtnRefresh.Text = "Refresh"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'BtnDelete
        '
        Me.BtnDelete.Image = Global.TakeoHospitalInventory.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(90, 25)
        Me.BtnDelete.Text = "  Delete  "
        '
        'GridFamilyRelative
        '
        GridFamilyRelative_DesignTimeLayout.LayoutString = resources.GetString("GridFamilyRelative_DesignTimeLayout.LayoutString")
        Me.GridFamilyRelative.DesignTimeLayout = GridFamilyRelative_DesignTimeLayout
        Me.GridFamilyRelative.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFamilyRelative.GroupByBoxVisible = False
        Me.GridFamilyRelative.Location = New System.Drawing.Point(0, 28)
        Me.GridFamilyRelative.Name = "GridFamilyRelative"
        Me.GridFamilyRelative.RecordNavigator = True
        Me.GridFamilyRelative.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridFamilyRelative.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridFamilyRelative.Size = New System.Drawing.Size(484, 281)
        Me.GridFamilyRelative.TabIndex = 1
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'BtnClose
        '
        Me.BtnClose.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Close1
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(88, 25)
        Me.BtnClose.Text = "   Close  "
        '
        'ForRelativeFamily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridFamilyRelative)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ForRelativeFamily"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Family Relative"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridFamilyRelative, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewFamily As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridFamilyRelative As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClose As System.Windows.Forms.ToolStripButton
End Class
