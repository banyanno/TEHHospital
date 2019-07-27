<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindingPatientScreening
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
        Dim GridPatientScreening_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindingPatientScreening))
        Me.RadByPatientNo = New System.Windows.Forms.RadioButton
        Me.RadPatientNameEng = New System.Windows.Forms.RadioButton
        Me.RadPatientNameKh = New System.Windows.Forms.RadioButton
        Me.TxtPatientScreeningNo = New System.Windows.Forms.TextBox
        Me.TxtPatientNameEng = New System.Windows.Forms.TextBox
        Me.TxtPatientNameKh = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.TxtPatientTel = New System.Windows.Forms.TextBox
        Me.RadTel = New System.Windows.Forms.RadioButton
        Me.ErrPatientScreening = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridPatientScreening = New Janus.Windows.GridEX.GridEX
        CType(Me.ErrPatientScreening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPatientScreening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadByPatientNo
        '
        Me.RadByPatientNo.AutoSize = True
        Me.RadByPatientNo.Checked = True
        Me.RadByPatientNo.Location = New System.Drawing.Point(12, 6)
        Me.RadByPatientNo.Name = "RadByPatientNo"
        Me.RadByPatientNo.Size = New System.Drawing.Size(126, 17)
        Me.RadByPatientNo.TabIndex = 0
        Me.RadByPatientNo.TabStop = True
        Me.RadByPatientNo.Text = "Patient No Screening"
        Me.RadByPatientNo.UseVisualStyleBackColor = True
        '
        'RadPatientNameEng
        '
        Me.RadPatientNameEng.AutoSize = True
        Me.RadPatientNameEng.Location = New System.Drawing.Point(12, 65)
        Me.RadPatientNameEng.Name = "RadPatientNameEng"
        Me.RadPatientNameEng.Size = New System.Drawing.Size(140, 17)
        Me.RadPatientNameEng.TabIndex = 1
        Me.RadPatientNameEng.Text = "Patient Name Screening"
        Me.RadPatientNameEng.UseVisualStyleBackColor = True
        '
        'RadPatientNameKh
        '
        Me.RadPatientNameKh.AutoSize = True
        Me.RadPatientNameKh.Location = New System.Drawing.Point(12, 117)
        Me.RadPatientNameKh.Name = "RadPatientNameKh"
        Me.RadPatientNameKh.Size = New System.Drawing.Size(156, 17)
        Me.RadPatientNameKh.TabIndex = 2
        Me.RadPatientNameKh.Text = "Patient Name Kh Screening"
        Me.RadPatientNameKh.UseVisualStyleBackColor = True
        '
        'TxtPatientScreeningNo
        '
        Me.TxtPatientScreeningNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientScreeningNo.Location = New System.Drawing.Point(12, 29)
        Me.TxtPatientScreeningNo.Name = "TxtPatientScreeningNo"
        Me.TxtPatientScreeningNo.Size = New System.Drawing.Size(250, 29)
        Me.TxtPatientScreeningNo.TabIndex = 3
        '
        'TxtPatientNameEng
        '
        Me.TxtPatientNameEng.Enabled = False
        Me.TxtPatientNameEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNameEng.Location = New System.Drawing.Point(12, 85)
        Me.TxtPatientNameEng.Name = "TxtPatientNameEng"
        Me.TxtPatientNameEng.Size = New System.Drawing.Size(250, 29)
        Me.TxtPatientNameEng.TabIndex = 4
        '
        'TxtPatientNameKh
        '
        Me.TxtPatientNameKh.Enabled = False
        Me.TxtPatientNameKh.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNameKh.Location = New System.Drawing.Point(12, 141)
        Me.TxtPatientNameKh.Name = "TxtPatientNameKh"
        Me.TxtPatientNameKh.Size = New System.Drawing.Size(250, 39)
        Me.TxtPatientNameKh.TabIndex = 5
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(12, 241)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(104, 33)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Find"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Location = New System.Drawing.Point(158, 241)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 33)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TxtPatientTel
        '
        Me.TxtPatientTel.Enabled = False
        Me.TxtPatientTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientTel.Location = New System.Drawing.Point(12, 205)
        Me.TxtPatientTel.Name = "TxtPatientTel"
        Me.TxtPatientTel.Size = New System.Drawing.Size(250, 29)
        Me.TxtPatientTel.TabIndex = 9
        '
        'RadTel
        '
        Me.RadTel.AutoSize = True
        Me.RadTel.Location = New System.Drawing.Point(12, 182)
        Me.RadTel.Name = "RadTel"
        Me.RadTel.Size = New System.Drawing.Size(139, 17)
        Me.RadTel.TabIndex = 8
        Me.RadTel.Text = "Patient Tel In Screening"
        Me.RadTel.UseVisualStyleBackColor = True
        '
        'ErrPatientScreening
        '
        Me.ErrPatientScreening.ContainerControl = Me
        '
        'GridPatientScreening
        '
        Me.GridPatientScreening.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPatientScreening.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridPatientScreening_DesignTimeLayout.LayoutString = resources.GetString("GridPatientScreening_DesignTimeLayout.LayoutString")
        Me.GridPatientScreening.DesignTimeLayout = GridPatientScreening_DesignTimeLayout
        Me.GridPatientScreening.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPatientScreening.GroupByBoxVisible = False
        Me.GridPatientScreening.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientScreening.Location = New System.Drawing.Point(281, 33)
        Me.GridPatientScreening.Name = "GridPatientScreening"
        Me.GridPatientScreening.RecordNavigator = True
        Me.GridPatientScreening.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridPatientScreening.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPatientScreening.Size = New System.Drawing.Size(614, 398)
        Me.GridPatientScreening.TabIndex = 10
        '
        'FindingPatientScreening
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 443)
        Me.Controls.Add(Me.GridPatientScreening)
        Me.Controls.Add(Me.TxtPatientTel)
        Me.Controls.Add(Me.RadTel)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtPatientNameKh)
        Me.Controls.Add(Me.TxtPatientNameEng)
        Me.Controls.Add(Me.TxtPatientScreeningNo)
        Me.Controls.Add(Me.RadPatientNameKh)
        Me.Controls.Add(Me.RadPatientNameEng)
        Me.Controls.Add(Me.RadByPatientNo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindingPatientScreening"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finding Patient In Screening"
        CType(Me.ErrPatientScreening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPatientScreening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadByPatientNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientNameEng As System.Windows.Forms.RadioButton
    Friend WithEvents RadPatientNameKh As System.Windows.Forms.RadioButton
    Friend WithEvents TxtPatientScreeningNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNameEng As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNameKh As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TxtPatientTel As System.Windows.Forms.TextBox
    Friend WithEvents RadTel As System.Windows.Forms.RadioButton
    Friend WithEvents ErrPatientScreening As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridPatientScreening As Janus.Windows.GridEX.GridEX
End Class
