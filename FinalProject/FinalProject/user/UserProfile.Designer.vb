<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserProfile))
        Me.profileListBox = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbMajorEdit = New System.Windows.Forms.ComboBox()
        Me.maskedtxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.linkEditPass = New System.Windows.Forms.LinkLabel()
        Me.lblConfimPass = New System.Windows.Forms.Label()
        Me.lblViewTitle = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblMajor2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.linkEdit = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblID1 = New System.Windows.Forms.Label()
        Me.lblEmail1 = New System.Windows.Forms.Label()
        Me.lblMajor1 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.lblBatch = New System.Windows.Forms.Label()
        Me.lblBatch1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'profileListBox
        '
        Me.profileListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.profileListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileListBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.profileListBox.FormattingEnabled = True
        Me.profileListBox.ItemHeight = 20
        Me.profileListBox.Location = New System.Drawing.Point(12, 307)
        Me.profileListBox.Name = "profileListBox"
        Me.profileListBox.Size = New System.Drawing.Size(316, 164)
        Me.profileListBox.TabIndex = 62
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(72, 17)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(141, 31)
        Me.lblTitle.TabIndex = 55
        Me.lblTitle.Text = "My Profile "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.cmbMajorEdit)
        Me.Panel1.Controls.Add(Me.maskedtxtPhoneNumber)
        Me.Panel1.Controls.Add(Me.txtConfirmPass)
        Me.Panel1.Controls.Add(Me.linkEditPass)
        Me.Panel1.Controls.Add(Me.lblConfimPass)
        Me.Panel1.Controls.Add(Me.lblViewTitle)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblMajor2)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblPhoneNumber)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.lblEmail2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(452, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 504)
        Me.Panel1.TabIndex = 53
        Me.Panel1.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(39, 452)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 40)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(143, 452)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 40)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmbMajorEdit
        '
        Me.cmbMajorEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajorEdit.FormattingEnabled = True
        Me.cmbMajorEdit.Location = New System.Drawing.Point(39, 99)
        Me.cmbMajorEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMajorEdit.Name = "cmbMajorEdit"
        Me.cmbMajorEdit.Size = New System.Drawing.Size(230, 24)
        Me.cmbMajorEdit.TabIndex = 2
        '
        'maskedtxtPhoneNumber
        '
        Me.maskedtxtPhoneNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maskedtxtPhoneNumber.AsciiOnly = True
        Me.maskedtxtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskedtxtPhoneNumber.Location = New System.Drawing.Point(39, 145)
        Me.maskedtxtPhoneNumber.Mask = "\0###########"
        Me.maskedtxtPhoneNumber.Name = "maskedtxtPhoneNumber"
        Me.maskedtxtPhoneNumber.Size = New System.Drawing.Size(165, 23)
        Me.maskedtxtPhoneNumber.TabIndex = 3
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(39, 285)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(227, 23)
        Me.txtConfirmPass.TabIndex = 6
        Me.txtConfirmPass.UseSystemPasswordChar = True
        Me.txtConfirmPass.Visible = False
        '
        'linkEditPass
        '
        Me.linkEditPass.ActiveLinkColor = System.Drawing.Color.White
        Me.linkEditPass.AutoSize = True
        Me.linkEditPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkEditPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkEditPass.LinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.linkEditPass.Location = New System.Drawing.Point(117, 218)
        Me.linkEditPass.Name = "linkEditPass"
        Me.linkEditPass.Size = New System.Drawing.Size(32, 17)
        Me.linkEditPass.TabIndex = 65
        Me.linkEditPass.TabStop = True
        Me.linkEditPass.Text = "Edit"
        '
        'lblConfimPass
        '
        Me.lblConfimPass.AutoSize = True
        Me.lblConfimPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfimPass.ForeColor = System.Drawing.Color.Silver
        Me.lblConfimPass.Location = New System.Drawing.Point(36, 265)
        Me.lblConfimPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfimPass.Name = "lblConfimPass"
        Me.lblConfimPass.Size = New System.Drawing.Size(156, 17)
        Me.lblConfimPass.TabIndex = 54
        Me.lblConfimPass.Text = "Confirm your password:"
        Me.lblConfimPass.Visible = False
        '
        'lblViewTitle
        '
        Me.lblViewTitle.AutoSize = True
        Me.lblViewTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewTitle.ForeColor = System.Drawing.Color.White
        Me.lblViewTitle.Location = New System.Drawing.Point(33, 22)
        Me.lblViewTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewTitle.Name = "lblViewTitle"
        Me.lblViewTitle.Size = New System.Drawing.Size(164, 31)
        Me.lblViewTitle.TabIndex = 49
        Me.lblViewTitle.Text = "Edit my data"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(40, 342)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(226, 103)
        Me.txtAddress.TabIndex = 7
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Silver
        Me.lblAddress.Location = New System.Drawing.Point(39, 316)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 20)
        Me.lblAddress.TabIndex = 45
        Me.lblAddress.Text = "Address:"
        '
        'lblMajor2
        '
        Me.lblMajor2.AutoSize = True
        Me.lblMajor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor2.ForeColor = System.Drawing.Color.Silver
        Me.lblMajor2.Location = New System.Drawing.Point(36, 79)
        Me.lblMajor2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMajor2.Name = "lblMajor2"
        Me.lblMajor2.Size = New System.Drawing.Size(47, 17)
        Me.lblMajor2.TabIndex = 38
        Me.lblMajor2.Text = "Major:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(40, 191)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 23)
        Me.txtEmail.TabIndex = 4
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.Silver
        Me.lblPhoneNumber.Location = New System.Drawing.Point(36, 125)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(107, 17)
        Me.lblPhoneNumber.TabIndex = 41
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(40, 238)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(227, 23)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Silver
        Me.lblPassword.Location = New System.Drawing.Point(37, 218)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(73, 17)
        Me.lblPassword.TabIndex = 40
        Me.lblPassword.Text = "Password:"
        '
        'lblEmail2
        '
        Me.lblEmail2.AutoSize = True
        Me.lblEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail2.ForeColor = System.Drawing.Color.Silver
        Me.lblEmail2.Location = New System.Drawing.Point(37, 171)
        Me.lblEmail2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail2.Name = "lblEmail2"
        Me.lblEmail2.Size = New System.Drawing.Size(46, 17)
        Me.lblEmail2.TabIndex = 39
        Me.lblEmail2.Text = "Email:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 71)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
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
        Me.btnClose.Location = New System.Drawing.Point(12, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'linkEdit
        '
        Me.linkEdit.ActiveLinkColor = System.Drawing.Color.White
        Me.linkEdit.AutoSize = True
        Me.linkEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkEdit.LinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.linkEdit.Location = New System.Drawing.Point(84, 264)
        Me.linkEdit.Name = "linkEdit"
        Me.linkEdit.Size = New System.Drawing.Size(89, 18)
        Me.linkEdit.TabIndex = 1
        Me.linkEdit.TabStop = True
        Me.linkEdit.Text = "Edit profile"
        '
        'Timer1
        '
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblEmail.Location = New System.Drawing.Point(256, 169)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(25, 13)
        Me.lblEmail.TabIndex = 72
        Me.lblEmail.Text = "mail"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblMajor.Location = New System.Drawing.Point(256, 206)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(32, 13)
        Me.lblMajor.TabIndex = 71
        Me.lblMajor.Text = "major"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblName.Location = New System.Drawing.Point(256, 131)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 13)
        Me.lblName.TabIndex = 70
        Me.lblName.Text = "name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblID.Location = New System.Drawing.Point(256, 90)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(53, 13)
        Me.lblID.TabIndex = 69
        Me.lblID.Text = "student id"
        '
        'lblID1
        '
        Me.lblID1.AutoSize = True
        Me.lblID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID1.ForeColor = System.Drawing.Color.White
        Me.lblID1.Location = New System.Drawing.Point(256, 72)
        Me.lblID1.Name = "lblID1"
        Me.lblID1.Size = New System.Drawing.Size(80, 18)
        Me.lblID1.TabIndex = 65
        Me.lblID1.Text = "Student ID:"
        '
        'lblEmail1
        '
        Me.lblEmail1.AutoSize = True
        Me.lblEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail1.ForeColor = System.Drawing.Color.White
        Me.lblEmail1.Location = New System.Drawing.Point(256, 151)
        Me.lblEmail1.Name = "lblEmail1"
        Me.lblEmail1.Size = New System.Drawing.Size(49, 18)
        Me.lblEmail1.TabIndex = 68
        Me.lblEmail1.Text = "Email:"
        '
        'lblMajor1
        '
        Me.lblMajor1.AutoSize = True
        Me.lblMajor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor1.ForeColor = System.Drawing.Color.White
        Me.lblMajor1.Location = New System.Drawing.Point(256, 188)
        Me.lblMajor1.Name = "lblMajor1"
        Me.lblMajor1.Size = New System.Drawing.Size(50, 18)
        Me.lblMajor1.TabIndex = 67
        Me.lblMajor1.Text = "Major:"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName1.ForeColor = System.Drawing.Color.White
        Me.lblName1.Location = New System.Drawing.Point(256, 113)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(75, 18)
        Me.lblName1.TabIndex = 66
        Me.lblName1.Text = "Full Name"
        '
        'lblBatch
        '
        Me.lblBatch.AutoSize = True
        Me.lblBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatch.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblBatch.Location = New System.Drawing.Point(256, 243)
        Me.lblBatch.Name = "lblBatch"
        Me.lblBatch.Size = New System.Drawing.Size(34, 13)
        Me.lblBatch.TabIndex = 74
        Me.lblBatch.Text = "batch"
        '
        'lblBatch1
        '
        Me.lblBatch1.AutoSize = True
        Me.lblBatch1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatch1.ForeColor = System.Drawing.Color.White
        Me.lblBatch1.Location = New System.Drawing.Point(256, 225)
        Me.lblBatch1.Name = "lblBatch1"
        Me.lblBatch1.Size = New System.Drawing.Size(50, 18)
        Me.lblBatch1.TabIndex = 73
        Me.lblBatch1.Text = "Batch:"
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 504)
        Me.Controls.Add(Me.lblBatch)
        Me.Controls.Add(Me.lblBatch1)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblID1)
        Me.Controls.Add(Me.lblEmail1)
        Me.Controls.Add(Me.lblMajor1)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.linkEdit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.profileListBox)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserProfile"
        Me.Text = "User Profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents profileListBox As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblViewTitle As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblMajor2 As Label
    Friend WithEvents lblEmail2 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents linkEdit As LinkLabel
    Friend WithEvents linkEditPass As LinkLabel
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents lblConfimPass As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents maskedtxtPhoneNumber As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblID1 As Label
    Friend WithEvents lblEmail1 As Label
    Friend WithEvents lblMajor1 As Label
    Friend WithEvents lblName1 As Label
    Friend WithEvents cmbMajorEdit As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblBatch As Label
    Friend WithEvents lblBatch1 As Label
End Class
