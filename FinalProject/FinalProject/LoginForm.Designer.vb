<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.titleBar = New System.Windows.Forms.Panel()
        Me.pictMinimize = New System.Windows.Forms.PictureBox()
        Me.pictExit = New System.Windows.Forms.PictureBox()
        Me.chkBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.titleBar.SuspendLayout()
        CType(Me.pictMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.Silver
        Me.lblUsername.Location = New System.Drawing.Point(36, 254)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 21)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.Silver
        Me.lblPassword.Location = New System.Drawing.Point(36, 329)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(77, 21)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsername.Location = New System.Drawing.Point(40, 292)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(345, 22)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.Location = New System.Drawing.Point(40, 364)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(345, 22)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(40, 503)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(345, 48)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(40, 578)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(345, 48)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.titleBar)
        Me.Panel1.Controls.Add(Me.chkBoxShowPass)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 694)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FinalProject.My.Resources.Resources.book1
        Me.PictureBox3.Location = New System.Drawing.Point(149, 97)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(136, 141)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 679)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(417, 14)
        Me.Panel3.TabIndex = 9
        '
        'titleBar
        '
        Me.titleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.titleBar.Controls.Add(Me.pictMinimize)
        Me.titleBar.Controls.Add(Me.pictExit)
        Me.titleBar.Location = New System.Drawing.Point(0, 0)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(417, 42)
        Me.titleBar.TabIndex = 8
        '
        'pictMinimize
        '
        Me.pictMinimize.BackColor = System.Drawing.Color.White
        Me.pictMinimize.Image = Global.FinalProject.My.Resources.Resources.minimize5
        Me.pictMinimize.Location = New System.Drawing.Point(326, 3)
        Me.pictMinimize.Name = "pictMinimize"
        Me.pictMinimize.Size = New System.Drawing.Size(37, 34)
        Me.pictMinimize.TabIndex = 10
        Me.pictMinimize.TabStop = False
        '
        'pictExit
        '
        Me.pictExit.Image = Global.FinalProject.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2
        Me.pictExit.Location = New System.Drawing.Point(368, 3)
        Me.pictExit.Name = "pictExit"
        Me.pictExit.Size = New System.Drawing.Size(36, 34)
        Me.pictExit.TabIndex = 0
        Me.pictExit.TabStop = False
        '
        'chkBoxShowPass
        '
        Me.chkBoxShowPass.AutoSize = True
        Me.chkBoxShowPass.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkBoxShowPass.ForeColor = System.Drawing.Color.Firebrick
        Me.chkBoxShowPass.Location = New System.Drawing.Point(40, 408)
        Me.chkBoxShowPass.Name = "chkBoxShowPass"
        Me.chkBoxShowPass.Size = New System.Drawing.Size(147, 25)
        Me.chkBoxShowPass.TabIndex = 4
        Me.chkBoxShowPass.Text = "Show Password"
        Me.chkBoxShowPass.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 694)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.titleBar.ResumeLayout(False)
        CType(Me.pictMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents chkBoxShowPass As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents titleBar As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pictExit As PictureBox
    Friend WithEvents pictMinimize As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
