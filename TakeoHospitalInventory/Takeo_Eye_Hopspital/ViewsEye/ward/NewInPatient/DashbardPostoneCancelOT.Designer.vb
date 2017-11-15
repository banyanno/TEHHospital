<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashbardPostoneCancelOT
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
        Dim GridEXPostpone_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashbardPostoneCancelOT))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnUpdateCall = New System.Windows.Forms.Button
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.ChPrintPreview = New System.Windows.Forms.CheckBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridEXPostpone = New Janus.Windows.GridEX.GridEX
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeletePostone = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoPostone = New System.Windows.Forms.ToolStripMenuItem
        Me.ChDeleteRecord = New System.Windows.Forms.CheckBox
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridEXPostpone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridEXPostpone)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(832, 462)
        Me.SplitContainer1.SplitterDistance = 229
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChDeleteRecord)
        Me.GroupBox1.Controls.Add(Me.BtnUpdateCall)
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.ChPrintPreview)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 462)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Postpone/Cancel OT"
        '
        'BtnUpdateCall
        '
        Me.BtnUpdateCall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateCall.Location = New System.Drawing.Point(116, 158)
        Me.BtnUpdateCall.Name = "BtnUpdateCall"
        Me.BtnUpdateCall.Size = New System.Drawing.Size(105, 36)
        Me.BtnUpdateCall.TabIndex = 6
        Me.BtnUpdateCall.Text = "Update Called"
        Me.BtnUpdateCall.UseVisualStyleBackColor = True
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreview.Location = New System.Drawing.Point(5, 158)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(105, 36)
        Me.BtnPrintPreview.TabIndex = 5
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'ChPrintPreview
        '
        Me.ChPrintPreview.AutoSize = True
        Me.ChPrintPreview.Location = New System.Drawing.Point(6, 135)
        Me.ChPrintPreview.Name = "ChPrintPreview"
        Me.ChPrintPreview.Size = New System.Drawing.Size(82, 17)
        Me.ChPrintPreview.TabIndex = 4
        Me.ChPrintPreview.Text = "Print Report"
        Me.ChPrintPreview.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(6, 92)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(169, 26)
        Me.DateTo.TabIndex = 3
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(6, 41)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(169, 26)
        Me.DateFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From:"
        '
        'GridEXPostpone
        '
        Me.GridEXPostpone.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEXPostpone.ContextMenuStrip = Me.ContextMenuStrip1
        GridEXPostpone_DesignTimeLayout.LayoutString = resources.GetString("GridEXPostpone_DesignTimeLayout.LayoutString")
        Me.GridEXPostpone.DesignTimeLayout = GridEXPostpone_DesignTimeLayout
        Me.GridEXPostpone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEXPostpone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEXPostpone.GroupByBoxVisible = False
        Me.GridEXPostpone.Location = New System.Drawing.Point(0, 0)
        Me.GridEXPostpone.Name = "GridEXPostpone"
        Me.GridEXPostpone.RecordNavigator = True
        Me.GridEXPostpone.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridEXPostpone.Size = New System.Drawing.Size(599, 462)
        Me.GridEXPostpone.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(27, 25)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(446, 127)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        Me.CrystalReportViewer1.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDeletePostone, Me.ToolStripSeparator1, Me.UndoPostone})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 54)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'BtnDeletePostone
        '
        Me.BtnDeletePostone.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Delete_Icon
        Me.BtnDeletePostone.Name = "BtnDeletePostone"
        Me.BtnDeletePostone.Size = New System.Drawing.Size(160, 22)
        Me.BtnDeletePostone.Text = "Delete Postpone"
        '
        'UndoPostone
        '
        Me.UndoPostone.Image = Global.TakeoHospitalInventory.My.Resources.Resources._1_512
        Me.UndoPostone.Name = "UndoPostone"
        Me.UndoPostone.Size = New System.Drawing.Size(160, 22)
        Me.UndoPostone.Text = "Undo Postpone"
        '
        'ChDeleteRecord
        '
        Me.ChDeleteRecord.AutoSize = True
        Me.ChDeleteRecord.Location = New System.Drawing.Point(117, 135)
        Me.ChDeleteRecord.Name = "ChDeleteRecord"
        Me.ChDeleteRecord.Size = New System.Drawing.Size(112, 17)
        Me.ChDeleteRecord.TabIndex = 7
        Me.ChDeleteRecord.Text = "Is Deleted Record"
        Me.ChDeleteRecord.UseVisualStyleBackColor = True
        '
        'DashbardPostoneCancelOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DashbardPostoneCancelOT"
        Me.Size = New System.Drawing.Size(832, 462)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridEXPostpone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridEXPostpone As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents ChPrintPreview As System.Windows.Forms.CheckBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnUpdateCall As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnDeletePostone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoPostone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChDeleteRecord As System.Windows.Forms.CheckBox

End Class
