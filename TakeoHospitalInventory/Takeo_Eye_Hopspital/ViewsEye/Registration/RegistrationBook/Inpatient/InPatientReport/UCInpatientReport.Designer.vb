<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCInpatientReport
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnInDiagnosis = New System.Windows.Forms.Button
        Me.BtnFullNon = New System.Windows.Forms.Button
        Me.BtnInEyeProblem = New System.Windows.Forms.Button
        Me.BtnInSurgery = New System.Windows.Forms.Button
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CRVInPatient = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DSInpatientReport = New TakeoHospitalInventory.DSInpatientReport
        Me.TblInpatientReportTableAdapter = New TakeoHospitalInventory.DSInpatientReportTableAdapters.TblInpatientReportTableAdapter
        Me.BGLoadReport = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DSInpatientReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.DateFrom)
        Me.GroupBox3.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DateTo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(184, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(626, 121)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnInDiagnosis)
        Me.GroupBox4.Controls.Add(Me.BtnFullNon)
        Me.GroupBox4.Controls.Add(Me.BtnInEyeProblem)
        Me.GroupBox4.Controls.Add(Me.BtnInSurgery)
        Me.GroupBox4.Location = New System.Drawing.Point(260, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 106)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'BtnInDiagnosis
        '
        Me.BtnInDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInDiagnosis.Location = New System.Drawing.Point(7, 16)
        Me.BtnInDiagnosis.Name = "BtnInDiagnosis"
        Me.BtnInDiagnosis.Size = New System.Drawing.Size(96, 41)
        Me.BtnInDiagnosis.TabIndex = 5
        Me.BtnInDiagnosis.Text = "Diagnosis"
        Me.BtnInDiagnosis.UseVisualStyleBackColor = True
        '
        'BtnFullNon
        '
        Me.BtnFullNon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFullNon.Location = New System.Drawing.Point(109, 60)
        Me.BtnFullNon.Name = "BtnFullNon"
        Me.BtnFullNon.Size = New System.Drawing.Size(129, 37)
        Me.BtnFullNon.TabIndex = 8
        Me.BtnFullNon.Text = "Full/Non Payment"
        Me.BtnFullNon.UseVisualStyleBackColor = True
        '
        'BtnInEyeProblem
        '
        Me.BtnInEyeProblem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInEyeProblem.Location = New System.Drawing.Point(109, 19)
        Me.BtnInEyeProblem.Name = "BtnInEyeProblem"
        Me.BtnInEyeProblem.Size = New System.Drawing.Size(129, 38)
        Me.BtnInEyeProblem.TabIndex = 6
        Me.BtnInEyeProblem.Text = "Operations Performed "
        Me.BtnInEyeProblem.UseVisualStyleBackColor = True
        '
        'BtnInSurgery
        '
        Me.BtnInSurgery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInSurgery.Location = New System.Drawing.Point(7, 60)
        Me.BtnInSurgery.Name = "BtnInSurgery"
        Me.BtnInSurgery.Size = New System.Drawing.Size(96, 37)
        Me.BtnInSurgery.TabIndex = 7
        Me.BtnInSurgery.Text = "Surgery"
        Me.BtnInSurgery.UseVisualStyleBackColor = True
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(6, 31)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(134, 26)
        Me.DateFrom.TabIndex = 2
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Location = New System.Drawing.Point(146, 31)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(76, 69)
        Me.BtnPrintPreview.TabIndex = 4
        Me.BtnPrintPreview.Text = "Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date From:"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(6, 76)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(134, 26)
        Me.DateTo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monthly Inpatient Statistic"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Takeo Eye Hospital"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CRVInPatient)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(874, 650)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CRVInPatient
        '
        Me.CRVInPatient.ActiveViewIndex = -1
        Me.CRVInPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVInPatient.DisplayGroupTree = False
        Me.CRVInPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVInPatient.Location = New System.Drawing.Point(3, 16)
        Me.CRVInPatient.Name = "CRVInPatient"
        Me.CRVInPatient.SelectionFormula = ""
        Me.CRVInPatient.Size = New System.Drawing.Size(868, 631)
        Me.CRVInPatient.TabIndex = 0
        Me.CRVInPatient.ViewTimeSelectionFormula = ""
        '
        'DSInpatientReport
        '
        Me.DSInpatientReport.DataSetName = "DSInpatientReport"
        Me.DSInpatientReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInpatientReportTableAdapter
        '
        Me.TblInpatientReportTableAdapter.ClearBeforeFill = True
        '
        'BGLoadReport
        '
        '
        'UCInpatientReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCInpatientReport"
        Me.Size = New System.Drawing.Size(874, 793)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DSInpatientReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CRVInPatient As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DSInpatientReport As TakeoHospitalInventory.DSInpatientReport
    Friend WithEvents TblInpatientReportTableAdapter As TakeoHospitalInventory.DSInpatientReportTableAdapters.TblInpatientReportTableAdapter
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BGLoadReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnFullNon As System.Windows.Forms.Button
    Friend WithEvents BtnInSurgery As System.Windows.Forms.Button
    Friend WithEvents BtnInEyeProblem As System.Windows.Forms.Button
    Friend WithEvents BtnInDiagnosis As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
