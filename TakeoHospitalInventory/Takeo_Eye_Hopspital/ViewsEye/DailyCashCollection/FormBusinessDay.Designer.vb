﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusinessDay
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
        Dim GridEXBusinessDay_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBusinessDay))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewBusinessDay = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnClose = New System.Windows.Forms.ToolStripButton
        Me.GridEXBusinessDay = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridEXBusinessDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewBusinessDay, Me.ToolStripSeparator1, Me.BtnRefresh, Me.ToolStripSeparator2, Me.BtnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(833, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewBusinessDay
        '
        Me.BtnNewBusinessDay.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1316401141_Schedule_File
        Me.BtnNewBusinessDay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewBusinessDay.Name = "BtnNewBusinessDay"
        Me.BtnNewBusinessDay.Size = New System.Drawing.Size(150, 29)
        Me.BtnNewBusinessDay.Text = "Set New Business Day"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.TakeoHospitalInventory.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 29)
        Me.BtnRefresh.Text = "Refresh"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'BtnClose
        '
        Me.BtnClose.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Close1
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(65, 29)
        Me.BtnClose.Text = "Close"
        '
        'GridEXBusinessDay
        '
        Me.GridEXBusinessDay.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridEXBusinessDay_DesignTimeLayout.LayoutString = resources.GetString("GridEXBusinessDay_DesignTimeLayout.LayoutString")
        Me.GridEXBusinessDay.DesignTimeLayout = GridEXBusinessDay_DesignTimeLayout
        Me.GridEXBusinessDay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEXBusinessDay.GroupByBoxVisible = False
        Me.GridEXBusinessDay.Location = New System.Drawing.Point(0, 32)
        Me.GridEXBusinessDay.Name = "GridEXBusinessDay"
        Me.GridEXBusinessDay.RecordNavigator = True
        Me.GridEXBusinessDay.Size = New System.Drawing.Size(833, 537)
        Me.GridEXBusinessDay.TabIndex = 1
        '
        'FormBusinessDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 569)
        Me.Controls.Add(Me.GridEXBusinessDay)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBusinessDay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Business Days"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridEXBusinessDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GridEXBusinessDay As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnNewBusinessDay As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClose As System.Windows.Forms.ToolStripButton
End Class
