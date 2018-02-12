<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashbordReceiveReceipt
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
        Dim GridJanusWaitingPayment_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashbordReceiveReceipt))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnNewCashCount = New System.Windows.Forms.ToolStripButton
        Me.GridJanusWaitingPayment = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridJanusWaitingPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRefresh, Me.ToolStripSeparator1, Me.BtnNewCashCount})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1107, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(108, 22)
        Me.BtnRefresh.Text = "Refresh Receipt"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnNewCashCount
        '
        Me.BtnNewCashCount.Image = Global.TakeoHospitalInventory.My.Resources.Resources.CashReceipt
        Me.BtnNewCashCount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewCashCount.Name = "BtnNewCashCount"
        Me.BtnNewCashCount.Size = New System.Drawing.Size(116, 22)
        Me.BtnNewCashCount.Text = "New Cash Count"
        '
        'GridJanusWaitingPayment
        '
        GridJanusWaitingPayment_DesignTimeLayout.LayoutString = resources.GetString("GridJanusWaitingPayment_DesignTimeLayout.LayoutString")
        Me.GridJanusWaitingPayment.DesignTimeLayout = GridJanusWaitingPayment_DesignTimeLayout
        Me.GridJanusWaitingPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridJanusWaitingPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridJanusWaitingPayment.GroupByBoxVisible = False
        Me.GridJanusWaitingPayment.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridJanusWaitingPayment.Location = New System.Drawing.Point(0, 25)
        Me.GridJanusWaitingPayment.Name = "GridJanusWaitingPayment"
        Me.GridJanusWaitingPayment.RecordNavigator = True
        Me.GridJanusWaitingPayment.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridJanusWaitingPayment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridJanusWaitingPayment.Size = New System.Drawing.Size(1107, 517)
        Me.GridJanusWaitingPayment.TabIndex = 9
        Me.GridJanusWaitingPayment.WatermarkImage.Image = CType(resources.GetObject("GridJanusWaitingPayment.WatermarkImage.Image"), System.Drawing.Image)
        Me.GridJanusWaitingPayment.WatermarkImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.ToolStripSeparator3, Me.ToolStripLabel3, Me.ToolStripSeparator4, Me.ToolStripLabel4, Me.ToolStripSeparator5, Me.ToolStripLabel5})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 542)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1107, 25)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripLabel1.Text = "Status Note:"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Fuchsia
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripLabel2.Text = "Receipt's New-Patient"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripLabel3.Text = "Receipt's Old-Patients"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripLabel4.Text = "Receipt's In-Patients"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(138, 22)
        Me.ToolStripLabel5.Text = "Receipt's Optical Shops"
        '
        'DashbordReceiveReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridJanusWaitingPayment)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashbordReceiveReceipt"
        Me.Size = New System.Drawing.Size(1107, 567)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridJanusWaitingPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnNewCashCount As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridJanusWaitingPayment As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel

End Class
