<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnViewProfile = New System.Windows.Forms.Button()
        Me.maskedtxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblEditTitle = New System.Windows.Forms.Label()
        Me.cmbMajorEdit = New System.Windows.Forms.ComboBox()
        Me.editCancelbtn = New System.Windows.Forms.Button()
        Me.editUserbtn = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblMajorTxtEdit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMajorEdit = New System.Windows.Forms.Label()
        Me.lblNameEdit = New System.Windows.Forms.Label()
        Me.profileListBox = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnViewProfile)
        Me.Panel1.Controls.Add(Me.maskedtxtPhoneNumber)
        Me.Panel1.Controls.Add(Me.lblEditTitle)
        Me.Panel1.Controls.Add(Me.cmbMajorEdit)
        Me.Panel1.Controls.Add(Me.editCancelbtn)
        Me.Panel1.Controls.Add(Me.editUserbtn)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.lblMajor)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.lblPhoneNumber)
        Me.Panel1.Location = New System.Drawing.Point(537, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 608)
        Me.Panel1.TabIndex = 34
        '
        'btnViewProfile
        '
        Me.btnViewProfile.Location = New System.Drawing.Point(221, 99)
        Me.btnViewProfile.Name = "btnViewProfile"
        Me.btnViewProfile.Size = New System.Drawing.Size(75, 23)
        Me.btnViewProfile.TabIndex = 50
        Me.btnViewProfile.Text = "View Profile"
        Me.btnViewProfile.UseVisualStyleBackColor = True
        '
        'maskedtxtPhoneNumber
        '
        Me.maskedtxtPhoneNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maskedtxtPhoneNumber.AsciiOnly = True
        Me.maskedtxtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskedtxtPhoneNumber.Location = New System.Drawing.Point(333, 330)
        Me.maskedtxtPhoneNumber.Mask = "\0###########"
        Me.maskedtxtPhoneNumber.Name = "maskedtxtPhoneNumber"
        Me.maskedtxtPhoneNumber.Size = New System.Drawing.Size(128, 26)
        Me.maskedtxtPhoneNumber.TabIndex = 4
        '
        'lblEditTitle
        '
        Me.lblEditTitle.AutoSize = True
        Me.lblEditTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditTitle.ForeColor = System.Drawing.Color.White
        Me.lblEditTitle.Location = New System.Drawing.Point(177, 31)
        Me.lblEditTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditTitle.Name = "lblEditTitle"
        Me.lblEditTitle.Size = New System.Drawing.Size(145, 31)
        Me.lblEditTitle.TabIndex = 49
        Me.lblEditTitle.Text = "Edit Profile"
        '
        'cmbMajorEdit
        '
        Me.cmbMajorEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajorEdit.FormattingEnabled = True
        Me.cmbMajorEdit.Location = New System.Drawing.Point(49, 328)
        Me.cmbMajorEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMajorEdit.Name = "cmbMajorEdit"
        Me.cmbMajorEdit.Size = New System.Drawing.Size(230, 28)
        Me.cmbMajorEdit.TabIndex = 3
        '
        'editCancelbtn
        '
        Me.editCancelbtn.BackColor = System.Drawing.Color.DarkGray
        Me.editCancelbtn.FlatAppearance.BorderSize = 0
        Me.editCancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editCancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editCancelbtn.Location = New System.Drawing.Point(205, 535)
        Me.editCancelbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.editCancelbtn.Name = "editCancelbtn"
        Me.editCancelbtn.Size = New System.Drawing.Size(117, 44)
        Me.editCancelbtn.TabIndex = 7
        Me.editCancelbtn.Text = "&Cancel"
        Me.editCancelbtn.UseVisualStyleBackColor = False
        '
        'editUserbtn
        '
        Me.editUserbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.editUserbtn.FlatAppearance.BorderSize = 0
        Me.editUserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editUserbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editUserbtn.Location = New System.Drawing.Point(49, 535)
        Me.editUserbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.editUserbtn.Name = "editUserbtn"
        Me.editUserbtn.Size = New System.Drawing.Size(117, 44)
        Me.editUserbtn.TabIndex = 6
        Me.editUserbtn.Text = "&Save"
        Me.editUserbtn.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(49, 403)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(346, 112)
        Me.txtAddress.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(49, 141)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 26)
        Me.txtEmail.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Silver
        Me.lblAddress.Location = New System.Drawing.Point(45, 379)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 20)
        Me.lblAddress.TabIndex = 45
        Me.lblAddress.Text = "Address:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(49, 234)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(227, 26)
        Me.txtPassword.TabIndex = 2
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.ForeColor = System.Drawing.Color.Silver
        Me.lblMajor.Location = New System.Drawing.Point(45, 287)
        Me.lblMajor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(52, 20)
        Me.lblMajor.TabIndex = 38
        Me.lblMajor.Text = "Major:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Silver
        Me.lblEmail.Location = New System.Drawing.Point(45, 100)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 20)
        Me.lblEmail.TabIndex = 39
        Me.lblEmail.Text = "Email:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Silver
        Me.lblPassword.Location = New System.Drawing.Point(45, 193)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 20)
        Me.lblPassword.TabIndex = 40
        Me.lblPassword.Text = "Password:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.Silver
        Me.lblPhoneNumber.Location = New System.Drawing.Point(329, 287)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(119, 20)
        Me.lblPhoneNumber.TabIndex = 41
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(182, 43)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(141, 31)
        Me.lblTitle.TabIndex = 45
        Me.lblTitle.Text = "My Profile "
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblMail.Location = New System.Drawing.Point(24, 253)
        Me.lblMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(25, 13)
        Me.lblMail.TabIndex = 51
        Me.lblMail.Text = "mail"
        '
        'lblMajorTxtEdit
        '
        Me.lblMajorTxtEdit.AutoSize = True
        Me.lblMajorTxtEdit.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblMajorTxtEdit.Location = New System.Drawing.Point(24, 199)
        Me.lblMajorTxtEdit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMajorTxtEdit.Name = "lblMajorTxtEdit"
        Me.lblMajorTxtEdit.Size = New System.Drawing.Size(32, 13)
        Me.lblMajorTxtEdit.TabIndex = 50
        Me.lblMajorTxtEdit.Text = "major"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(24, 145)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 231)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 18)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Email:"
        '
        'lblMajorEdit
        '
        Me.lblMajorEdit.AutoSize = True
        Me.lblMajorEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajorEdit.ForeColor = System.Drawing.Color.White
        Me.lblMajorEdit.Location = New System.Drawing.Point(24, 177)
        Me.lblMajorEdit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMajorEdit.Name = "lblMajorEdit"
        Me.lblMajorEdit.Size = New System.Drawing.Size(50, 18)
        Me.lblMajorEdit.TabIndex = 47
        Me.lblMajorEdit.Text = "Major:"
        '
        'lblNameEdit
        '
        Me.lblNameEdit.AutoSize = True
        Me.lblNameEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameEdit.ForeColor = System.Drawing.Color.White
        Me.lblNameEdit.Location = New System.Drawing.Point(22, 118)
        Me.lblNameEdit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameEdit.Name = "lblNameEdit"
        Me.lblNameEdit.Size = New System.Drawing.Size(52, 18)
        Me.lblNameEdit.TabIndex = 46
        Me.lblNameEdit.Text = "Name:"
        '
        'profileListBox
        '
        Me.profileListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.profileListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileListBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.profileListBox.FormattingEnabled = True
        Me.profileListBox.ItemHeight = 20
        Me.profileListBox.Location = New System.Drawing.Point(51, 378)
        Me.profileListBox.Name = "profileListBox"
        Me.profileListBox.Size = New System.Drawing.Size(397, 184)
        Me.profileListBox.TabIndex = 52
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(84, 98)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(0, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 53
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'editUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 605)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.profileListBox)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblMajorTxtEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblMajorEdit)
        Me.Controls.Add(Me.lblNameEdit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editUser"
        Me.Text = "Edit User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEditTitle As Label
    Friend WithEvents cmbMajorEdit As ComboBox
    Friend WithEvents editCancelbtn As Button
    Friend WithEvents editUserbtn As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblMajor As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblMajorTxtEdit As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMajorEdit As Label
    Friend WithEvents lblNameEdit As Label
    Friend WithEvents profileListBox As ListBox
    Friend WithEvents maskedtxtPhoneNumber As MaskedTextBox
    Friend WithEvents btnViewProfile As Button
    Friend WithEvents btnClose As Button
End Class
