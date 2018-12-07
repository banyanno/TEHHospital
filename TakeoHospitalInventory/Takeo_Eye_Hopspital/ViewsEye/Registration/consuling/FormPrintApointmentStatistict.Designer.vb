<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrintApointmentStatistict
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrintApointmentStatistict))
        Me.CrvViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.RadPatientNotCome = New System.Windows.Forms.RadioButton
        Me.RadPatientComeOnApp = New System.Windows.Forms.RadioButton
        Me.RadPatientCall = New System.Windows.Forms.RadioButton
        Me.RadPatientAppointment = New System.Windows.Forms.RadioButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrvViewer
        '
        Me.CrvViewer.ActiveViewIndex = -1
        Me.CrvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvViewer.DisplayGroupTree = False
        Me.CrvViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrvViewer.Name = "CrvViewer"
        Me.CrvViewer.SelectionFormula = ""
        Me.CrvViewer.ShowGroupTreeButton = False
        Me.CrvViewer.Size = New System.Drawing.Size(514, 474)
        Me.CrvViewer.TabIndex = 0
        Me.CrvViewer.ViewTimeSelectionFormula = ""
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnPrintPreview)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadPatientNotCome)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadPatientComeOnApp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadPatientCall)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadPatientAppointment)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrvViewer)
        Me.SplitContainer1.Size = New System.Drawing.Size(707, 474)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 1
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Location = New System.Drawing.Point(9, 212)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(108, 26)
        Me.BtnPrintPreview.TabIndex = 8
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From:"
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(12, 186)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(151, 20)
        Me.DTo.TabIndex = 5
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(12, 143)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(151, 20)
        Me.DFrom.TabIndex = 4
        '
        'RadPatientNotCome
        '
        Me.RadPatientNotCome.AutoSize = True
        Me.RadPatientNotCome.Location = New System.Drawing.Point(12, 93)
        Me.RadPatientNotCome.Name = "RadPatientNotCome"
        Me.RadPatientNotCome.Size = New System.Drawing.Size(181, 17)
        Me.RadPatientNotCome.TabIndex = 3
        Me.RadPatientNotCome.Text = "Patient not come(Date not come)"
        Me.RadPatientNotCome.UseVisualStyleBackColor = True
        '
        'RadPatientComeOnApp
        '
        Me.RadPatientComeOnApp.AutoSize = True
        Me.RadPatientComeOnApp.Location = New System.Drawing.Point(12, 70)
        Me.RadPatientComeOnApp.Name = "RadPatientComeOnApp"
        Me.RadPatientComeOnApp.Size = New System.Drawing.Size(185, 17)
        Me.RadPatientComeOnApp.TabIndex = 2
        Me.RadPatientComeOnApp.Text = "Patient come on app (Date Come)"
        Me.RadPatientComeOnApp.UseVisualStyleBackColor = True
        '
        'RadPatientCall
        '
        Me.RadPatientCall.AutoSize = True
        Me.RadPatientCall.Location = New System.Drawing.Point(12, 47)
        Me.RadPatientCall.Name = "RadPatientCall"
        Me.RadPatientCall.Size = New System.Drawing.Size(140, 17)
        Me.RadPatientCall.TabIndex = 1
        Me.RadPatientCall.Text = "Patient called (Date call)"
        Me.RadPatientCall.UseVisualStyleBackColor = True
        '
        'RadPatientAppointment
        '
        Me.RadPatientAppointment.AutoSize = True
        Me.RadPatientAppointment.Checked = True
        Me.RadPatientAppointment.Location = New System.Drawing.Point(12, 24)
        Me.RadPatientAppointment.Name = "RadPatientAppointment"
        Me.RadPatientAppointment.Size = New System.Drawing.Size(120, 17)
        Me.RadPatientAppointment.TabIndex = 0
        Me.RadPatientAppointment.TabStop = True
        Me.RadPatientAppointment.Text = "Patient Appointment"
        Me.RadPatientAppointment.UseVisualStyleBackColor = True
        '
        'FormPrintApointmentStatistict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 474)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrintApointmentStatistict"
        Me.Text = "Print Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RadPatientNotCome As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientComeOnApp As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientCall As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientAppointment As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
End Class
