<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFixAsset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFixAsset))
        Me.BtnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateBuy = New System.Windows.Forms.DateTimePicker
        Me.CboDepartment = New System.Windows.Forms.ComboBox
        Me.TxtProductName = New System.Windows.Forms.TextBox
        Me.TxtProductCOde = New System.Windows.Forms.TextBox
        Me.TxtProductPrice = New System.Windows.Forms.TextBox
        Me.TxtBuyer = New System.Windows.Forms.TextBox
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.ErrFixAsset = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ErrFixAsset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(575, 430)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 33)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(670, 430)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 33)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Buy *:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name *:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(374, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Code *:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department *:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Product Price *:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Buyer *:"
        '
        'DateBuy
        '
        Me.DateBuy.Checked = False
        Me.DateBuy.CustomFormat = "dd - MM - yyyy"
        Me.DateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBuy.Location = New System.Drawing.Point(131, 29)
        Me.DateBuy.Name = "DateBuy"
        Me.DateBuy.ShowCheckBox = True
        Me.DateBuy.Size = New System.Drawing.Size(226, 26)
        Me.DateBuy.TabIndex = 0
        '
        'CboDepartment
        '
        Me.CboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDepartment.FormattingEnabled = True
        Me.CboDepartment.Location = New System.Drawing.Point(495, 27)
        Me.CboDepartment.Name = "CboDepartment"
        Me.CboDepartment.Size = New System.Drawing.Size(226, 28)
        Me.CboDepartment.TabIndex = 1
        '
        'TxtProductName
        '
        Me.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProductName.Location = New System.Drawing.Point(131, 71)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(226, 26)
        Me.TxtProductName.TabIndex = 2
        '
        'TxtProductCOde
        '
        Me.TxtProductCOde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProductCOde.Location = New System.Drawing.Point(495, 71)
        Me.TxtProductCOde.Name = "TxtProductCOde"
        Me.TxtProductCOde.Size = New System.Drawing.Size(226, 26)
        Me.TxtProductCOde.TabIndex = 3
        '
        'TxtProductPrice
        '
        Me.TxtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProductPrice.Location = New System.Drawing.Point(131, 118)
        Me.TxtProductPrice.Name = "TxtProductPrice"
        Me.TxtProductPrice.Size = New System.Drawing.Size(226, 26)
        Me.TxtProductPrice.TabIndex = 4
        '
        'TxtBuyer
        '
        Me.TxtBuyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuyer.Location = New System.Drawing.Point(131, 162)
        Me.TxtBuyer.Name = "TxtBuyer"
        Me.TxtBuyer.Size = New System.Drawing.Size(226, 26)
        Me.TxtBuyer.TabIndex = 5
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(9, 228)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(725, 167)
        Me.TxtNote.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Description"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtNote)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtBuyer)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtProductPrice)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtProductCOde)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtProductName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CboDepartment)
        Me.Panel1.Controls.Add(Me.DateBuy)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 409)
        Me.Panel1.TabIndex = 0
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(19, 445)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 4
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'ErrFixAsset
        '
        Me.ErrFixAsset.ContainerControl = Me
        '
        'FormFixAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 468)
        Me.Controls.Add(Me.LblSaveOption)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFixAsset"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix Asset Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrFixAsset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateBuy As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents TxtProductName As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductCOde As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtBuyer As System.Windows.Forms.TextBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrFixAsset As System.Windows.Forms.ErrorProvider
End Class
