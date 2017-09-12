<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginInventory
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginInventory))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.BtnOk = New Janus.Windows.EditControls.UIButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BgLogin = New System.ComponentModel.BackgroundWorker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictLoading = New System.Windows.Forms.PictureBox
        Me.LblDate = New System.Windows.Forms.Label
        Me.LblStatus = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.JanusSuperTip1 = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Location = New System.Drawing.Point(19, 25)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Location = New System.Drawing.Point(19, 87)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(21, 49)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(349, 30)
        Me.txtUserName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(21, 109)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(349, 30)
        Me.txtPassword.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Controls.Add(Me.BtnOk)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 211)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnExit.Location = New System.Drawing.Point(264, 156)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(106, 34)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "&Exit"
        Me.BtnExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BtnOk
        '
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOk.Location = New System.Drawing.Point(152, 156)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(106, 34)
        Me.BtnOk.TabIndex = 2
        Me.BtnOk.Text = "&Login"
        Me.BtnOk.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.PictureBox1.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.TakeoHospitalInventory.My.Resources.Resources.desktop_computer
        Me.PictureBox1.Location = New System.Drawing.Point(399, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BgLogin
        '
        Me.BgLogin.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 42)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(239, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Takeo Eye and Inventory"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Controls.Add(Me.PictLoading)
        Me.Panel2.Controls.Add(Me.LblDate)
        Me.Panel2.Controls.Add(Me.LblStatus)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 259)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(693, 41)
        Me.Panel2.TabIndex = 11
        '
        'PictLoading
        '
        Me.PictLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictLoading.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loading_bar11
        Me.PictLoading.Location = New System.Drawing.Point(527, 1)
        Me.PictLoading.Name = "PictLoading"
        Me.PictLoading.Size = New System.Drawing.Size(165, 19)
        Me.PictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictLoading.TabIndex = 12
        Me.PictLoading.TabStop = False
        Me.PictLoading.Visible = False
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.ForeColor = System.Drawing.Color.White
        Me.LblDate.Location = New System.Drawing.Point(335, 14)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(0, 13)
        Me.LblDate.TabIndex = 11
        '
        'LblStatus
        '
        Me.LblStatus.ForeColor = System.Drawing.Color.White
        Me.LblStatus.Location = New System.Drawing.Point(399, 21)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(289, 17)
        Me.LblStatus.TabIndex = 10
        Me.LblStatus.Text = "Status"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblStatus.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Copyright 2012. All rights reserved by KTG"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(691, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 217)
        Me.Panel3.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 217)
        Me.Panel4.TabIndex = 13
        '
        'JanusSuperTip1
        '
        Me.JanusSuperTip1.AutoPopDelay = 2000
        Me.JanusSuperTip1.ImageList = Nothing
        '
        'frmLoginInventory
        '
        Me.AcceptButton = Me.BtnOk
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.TakeoHospitalInventory.My.Resources.Resources.Bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(693, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoginInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Takeo Hospital"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents PictLoading As System.Windows.Forms.PictureBox
    Friend WithEvents BgLogin As System.ComponentModel.BackgroundWorker
    Friend WithEvents JanusSuperTip1 As Janus.Windows.Common.JanusSuperTip
End Class
