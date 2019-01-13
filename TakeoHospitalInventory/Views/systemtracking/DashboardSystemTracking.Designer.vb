<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardSystemTracking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardSystemTracking))
        Dim GridSystemTracking_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefreshHistory = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.GridSystemTracking = New Janus.Windows.GridEX.GridEX
        Me.CrystallSystemtrack = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridSystemTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefreshHistory, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1181, 52)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefreshHistory
        '
        Me.BtnRefreshHistory.Image = CType(resources.GetObject("BtnRefreshHistory.Image"), System.Drawing.Image)
        Me.BtnRefreshHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshHistory.Name = "BtnRefreshHistory"
        Me.BtnRefreshHistory.Size = New System.Drawing.Size(104, 49)
        Me.BtnRefreshHistory.Text = "    Print Preview    "
        Me.BtnRefreshHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(109, 49)
        Me.ToolStripButton2.Text = "    Filter Tracking    "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'GridSystemTracking
        '
        Me.GridSystemTracking.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridSystemTracking_DesignTimeLayout.LayoutString = resources.GetString("GridSystemTracking_DesignTimeLayout.LayoutString")
        Me.GridSystemTracking.DesignTimeLayout = GridSystemTracking_DesignTimeLayout
        Me.GridSystemTracking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSystemTracking.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridSystemTracking.GroupByBoxVisible = False
        Me.GridSystemTracking.Location = New System.Drawing.Point(0, 52)
        Me.GridSystemTracking.Name = "GridSystemTracking"
        Me.GridSystemTracking.RecordNavigator = True
        Me.GridSystemTracking.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridSystemTracking.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridSystemTracking.Size = New System.Drawing.Size(1181, 538)
        Me.GridSystemTracking.TabIndex = 1
        '
        'CrystallSystemtrack
        '
        Me.CrystallSystemtrack.ActiveViewIndex = -1
        Me.CrystallSystemtrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystallSystemtrack.DisplayGroupTree = False
        Me.CrystallSystemtrack.Location = New System.Drawing.Point(62, 158)
        Me.CrystallSystemtrack.Name = "CrystallSystemtrack"
        Me.CrystallSystemtrack.SelectionFormula = ""
        Me.CrystallSystemtrack.ShowGroupTreeButton = False
        Me.CrystallSystemtrack.Size = New System.Drawing.Size(694, 228)
        Me.CrystallSystemtrack.TabIndex = 2
        Me.CrystallSystemtrack.ViewTimeSelectionFormula = ""
        Me.CrystallSystemtrack.Visible = False
        '
        'DashboardSystemTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridSystemTracking)
        Me.Controls.Add(Me.CrystallSystemtrack)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashboardSystemTracking"
        Me.Size = New System.Drawing.Size(1181, 590)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridSystemTracking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnRefreshHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridSystemTracking As Janus.Windows.GridEX.GridEX
    Friend WithEvents CrystallSystemtrack As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
