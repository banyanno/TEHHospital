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
        Me.RadPatientCome = New System.Windows.Forms.RadioButton
        Me.GrCome = New System.Windows.Forms.GroupBox
        Me.RadPatientComeOnApp = New System.Windows.Forms.RadioButton
        Me.RadPatientNotCome = New System.Windows.Forms.RadioButton
        Me.RadCall = New System.Windows.Forms.RadioButton
        Me.GrCall = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.RadIsnotCall = New System.Windows.Forms.RadioButton
        Me.RadPatientCalled = New System.Windows.Forms.RadioButton
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.RadPatientAppointment = New System.Windows.Forms.RadioButton
        Me.GbAllAppointment = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadAllDonthavephone = New System.Windows.Forms.RadioButton
        Me.RadAllHavePhone = New System.Windows.Forms.RadioButton
        Me.RadAllAppointment = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.ChIsComeOrNotCome = New System.Windows.Forms.CheckBox
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GrCome.SuspendLayout()
        Me.GrCall.SuspendLayout()
        Me.GbAllAppointment.SuspendLayout()
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
        Me.CrvViewer.Size = New System.Drawing.Size(761, 655)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadPatientCome)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GrCome)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadCall)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GrCall)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnPrintPreview)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadPatientAppointment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GbAllAppointment)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrvViewer)
        Me.SplitContainer1.Size = New System.Drawing.Size(977, 655)
        Me.SplitContainer1.SplitterDistance = 212
        Me.SplitContainer1.TabIndex = 1
        '
        'RadPatientCome
        '
        Me.RadPatientCome.AutoSize = True
        Me.RadPatientCome.Location = New System.Drawing.Point(14, 333)
        Me.RadPatientCome.Name = "RadPatientCome"
        Me.RadPatientCome.Size = New System.Drawing.Size(88, 17)
        Me.RadPatientCome.TabIndex = 12
        Me.RadPatientCome.TabStop = True
        Me.RadPatientCome.Text = "Patient Come"
        Me.RadPatientCome.UseVisualStyleBackColor = True
        '
        'GrCome
        '
        Me.GrCome.Controls.Add(Me.Label5)
        Me.GrCome.Controls.Add(Me.RadPatientComeOnApp)
        Me.GrCome.Controls.Add(Me.RadPatientNotCome)
        Me.GrCome.Enabled = False
        Me.GrCome.Location = New System.Drawing.Point(10, 336)
        Me.GrCome.Name = "GrCome"
        Me.GrCome.Size = New System.Drawing.Size(194, 98)
        Me.GrCome.TabIndex = 11
        Me.GrCome.TabStop = False
        '
        'RadPatientComeOnApp
        '
        Me.RadPatientComeOnApp.AutoSize = True
        Me.RadPatientComeOnApp.Checked = True
        Me.RadPatientComeOnApp.Location = New System.Drawing.Point(14, 26)
        Me.RadPatientComeOnApp.Name = "RadPatientComeOnApp"
        Me.RadPatientComeOnApp.Size = New System.Drawing.Size(62, 17)
        Me.RadPatientComeOnApp.TabIndex = 2
        Me.RadPatientComeOnApp.TabStop = True
        Me.RadPatientComeOnApp.Text = "Is come"
        Me.RadPatientComeOnApp.UseVisualStyleBackColor = True
        '
        'RadPatientNotCome
        '
        Me.RadPatientNotCome.AutoSize = True
        Me.RadPatientNotCome.Location = New System.Drawing.Point(14, 51)
        Me.RadPatientNotCome.Name = "RadPatientNotCome"
        Me.RadPatientNotCome.Size = New System.Drawing.Size(72, 17)
        Me.RadPatientNotCome.TabIndex = 3
        Me.RadPatientNotCome.Text = "Not Come"
        Me.RadPatientNotCome.UseVisualStyleBackColor = True
        '
        'RadCall
        '
        Me.RadCall.AutoSize = True
        Me.RadCall.Location = New System.Drawing.Point(15, 164)
        Me.RadCall.Name = "RadCall"
        Me.RadCall.Size = New System.Drawing.Size(89, 17)
        Me.RadCall.TabIndex = 1
        Me.RadCall.Text = "Patient called"
        Me.RadCall.UseVisualStyleBackColor = True
        '
        'GrCall
        '
        Me.GrCall.Controls.Add(Me.ChIsComeOrNotCome)
        Me.GrCall.Controls.Add(Me.Label4)
        Me.GrCall.Controls.Add(Me.RadIsnotCall)
        Me.GrCall.Controls.Add(Me.RadPatientCalled)
        Me.GrCall.Enabled = False
        Me.GrCall.Location = New System.Drawing.Point(11, 166)
        Me.GrCall.Name = "GrCall"
        Me.GrCall.Size = New System.Drawing.Size(194, 164)
        Me.GrCall.TabIndex = 10
        Me.GrCall.TabStop = False
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 53)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Check= come." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Uncheck= not come." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tip: Date= day patient will come."
        '
        'RadIsnotCall
        '
        Me.RadIsnotCall.AutoSize = True
        Me.RadIsnotCall.Location = New System.Drawing.Point(11, 50)
        Me.RadIsnotCall.Name = "RadIsnotCall"
        Me.RadIsnotCall.Size = New System.Drawing.Size(70, 17)
        Me.RadIsnotCall.TabIndex = 1
        Me.RadIsnotCall.Text = "Is not call"
        Me.RadIsnotCall.UseVisualStyleBackColor = True
        '
        'RadPatientCalled
        '
        Me.RadPatientCalled.AutoSize = True
        Me.RadPatientCalled.Checked = True
        Me.RadPatientCalled.Location = New System.Drawing.Point(11, 24)
        Me.RadPatientCalled.Name = "RadPatientCalled"
        Me.RadPatientCalled.Size = New System.Drawing.Size(64, 17)
        Me.RadPatientCalled.TabIndex = 0
        Me.RadPatientCalled.TabStop = True
        Me.RadPatientCalled.Text = "Is called"
        Me.RadPatientCalled.UseVisualStyleBackColor = True
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.Location = New System.Drawing.Point(11, 522)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(154, 26)
        Me.BtnPrintPreview.TabIndex = 8
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From:"
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(14, 496)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(151, 20)
        Me.DTo.TabIndex = 5
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(14, 453)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(151, 20)
        Me.DFrom.TabIndex = 4
        '
        'RadPatientAppointment
        '
        Me.RadPatientAppointment.AutoSize = True
        Me.RadPatientAppointment.Checked = True
        Me.RadPatientAppointment.Location = New System.Drawing.Point(13, 7)
        Me.RadPatientAppointment.Name = "RadPatientAppointment"
        Me.RadPatientAppointment.Size = New System.Drawing.Size(120, 17)
        Me.RadPatientAppointment.TabIndex = 0
        Me.RadPatientAppointment.TabStop = True
        Me.RadPatientAppointment.Text = "Patient Appointment"
        Me.RadPatientAppointment.UseVisualStyleBackColor = True
        '
        'GbAllAppointment
        '
        Me.GbAllAppointment.Controls.Add(Me.Label3)
        Me.GbAllAppointment.Controls.Add(Me.RadAllDonthavephone)
        Me.GbAllAppointment.Controls.Add(Me.RadAllHavePhone)
        Me.GbAllAppointment.Controls.Add(Me.RadAllAppointment)
        Me.GbAllAppointment.Location = New System.Drawing.Point(10, 11)
        Me.GbAllAppointment.Name = "GbAllAppointment"
        Me.GbAllAppointment.Size = New System.Drawing.Size(195, 145)
        Me.GbAllAppointment.TabIndex = 9
        Me.GbAllAppointment.TabStop = False
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tip: Date= day that create appointment"
        '
        'RadAllDonthavephone
        '
        Me.RadAllDonthavephone.AutoSize = True
        Me.RadAllDonthavephone.Location = New System.Drawing.Point(6, 77)
        Me.RadAllDonthavephone.Name = "RadAllDonthavephone"
        Me.RadAllDonthavephone.Size = New System.Drawing.Size(108, 17)
        Me.RadAllDonthavephone.TabIndex = 4
        Me.RadAllDonthavephone.Text = "Dont have phone"
        Me.RadAllDonthavephone.UseVisualStyleBackColor = True
        '
        'RadAllHavePhone
        '
        Me.RadAllHavePhone.AutoSize = True
        Me.RadAllHavePhone.Location = New System.Drawing.Point(6, 48)
        Me.RadAllHavePhone.Name = "RadAllHavePhone"
        Me.RadAllHavePhone.Size = New System.Drawing.Size(85, 17)
        Me.RadAllHavePhone.TabIndex = 3
        Me.RadAllHavePhone.Text = "Have Phone"
        Me.RadAllHavePhone.UseVisualStyleBackColor = True
        '
        'RadAllAppointment
        '
        Me.RadAllAppointment.AutoSize = True
        Me.RadAllAppointment.Checked = True
        Me.RadAllAppointment.Location = New System.Drawing.Point(6, 21)
        Me.RadAllAppointment.Name = "RadAllAppointment"
        Me.RadAllAppointment.Size = New System.Drawing.Size(98, 17)
        Me.RadAllAppointment.TabIndex = 2
        Me.RadAllAppointment.TabStop = True
        Me.RadAllAppointment.Text = "All Appointment"
        Me.RadAllAppointment.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tip: Date= day patient will come"
        '
        'ChIsComeOrNotCome
        '
        Me.ChIsComeOrNotCome.AutoSize = True
        Me.ChIsComeOrNotCome.Checked = True
        Me.ChIsComeOrNotCome.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChIsComeOrNotCome.Location = New System.Drawing.Point(11, 79)
        Me.ChIsComeOrNotCome.Name = "ChIsComeOrNotCome"
        Me.ChIsComeOrNotCome.Size = New System.Drawing.Size(136, 17)
        Me.ChIsComeOrNotCome.TabIndex = 7
        Me.ChIsComeOrNotCome.Text = "With come or not come"
        Me.ChIsComeOrNotCome.UseVisualStyleBackColor = True
        '
        'FormPrintApointmentStatistict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 655)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrintApointmentStatistict"
        Me.Text = "Print Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GrCome.ResumeLayout(False)
        Me.GrCome.PerformLayout()
        Me.GrCall.ResumeLayout(False)
        Me.GrCall.PerformLayout()
        Me.GbAllAppointment.ResumeLayout(False)
        Me.GbAllAppointment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RadPatientNotCome As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientComeOnApp As System.Windows.Forms.RadioButton
    Friend WithEvents RadCall As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientAppointment As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents GbAllAppointment As System.Windows.Forms.GroupBox
    Friend WithEvents RadAllDonthavephone As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllHavePhone As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllAppointment As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GrCall As System.Windows.Forms.GroupBox
    Friend WithEvents RadIsnotCall As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientCalled As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadPatientCome As System.Windows.Forms.RadioButton
    Friend WithEvents GrCome As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChIsComeOrNotCome As System.Windows.Forms.CheckBox
End Class
