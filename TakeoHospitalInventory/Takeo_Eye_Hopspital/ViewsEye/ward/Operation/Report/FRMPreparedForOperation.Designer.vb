<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPreparedForOperation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMPreparedForOperation))
        Me.CRVPreparedForOperation = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DSOT = New TakeoHospitalInventory.DSOT
        Me.ViewPreparForOperationTableAdapter = New TakeoHospitalInventory.DSOTTableAdapters.ViewPreparForOperationTableAdapter
        CType(Me.DSOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRVPreparedForOperation
        '
        Me.CRVPreparedForOperation.ActiveViewIndex = -1
        Me.CRVPreparedForOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPreparedForOperation.DisplayGroupTree = False
        Me.CRVPreparedForOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPreparedForOperation.Location = New System.Drawing.Point(0, 0)
        Me.CRVPreparedForOperation.Name = "CRVPreparedForOperation"
        Me.CRVPreparedForOperation.SelectionFormula = ""
        Me.CRVPreparedForOperation.Size = New System.Drawing.Size(1198, 720)
        Me.CRVPreparedForOperation.TabIndex = 0
        Me.CRVPreparedForOperation.ViewTimeSelectionFormula = ""
        '
        'DSOT
        '
        Me.DSOT.DataSetName = "DSOT"
        Me.DSOT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewPreparForOperationTableAdapter
        '
        Me.ViewPreparForOperationTableAdapter.ClearBeforeFill = True
        '
        'FRMPreparedForOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 720)
        Me.Controls.Add(Me.CRVPreparedForOperation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMPreparedForOperation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Preparation For Operation"
        CType(Me.DSOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSOT As TakeoHospitalInventory.DSOT
    Friend WithEvents ViewPreparForOperationTableAdapter As TakeoHospitalInventory.DSOTTableAdapters.ViewPreparForOperationTableAdapter
    Friend WithEvents CRVPreparedForOperation As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
