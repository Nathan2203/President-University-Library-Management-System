<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerAdd
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
        Me.components = New System.ComponentModel.Container()
        Me.Email = New System.Windows.Forms.Label()
        Me.Password1 = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.gender1 = New System.Windows.Forms.RadioButton()
        Me.gender2 = New System.Windows.Forms.RadioButton()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Name1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.Label()
        Me.activationDate = New System.Windows.Forms.Label()
        Me.validTill = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(22, 98)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(42, 17)
        Me.Email.TabIndex = 1
        Me.Email.Text = "Email"
        '
        'Password1
        '
        Me.Password1.AutoSize = True
        Me.Password1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password1.Location = New System.Drawing.Point(354, 40)
        Me.Password1.Name = "Password1"
        Me.Password1.Size = New System.Drawing.Size(69, 17)
        Me.Password1.TabIndex = 2
        Me.Password1.Text = "Password"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumber.Location = New System.Drawing.Point(22, 157)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.PhoneNumber.TabIndex = 3
        Me.PhoneNumber.Text = "Phone Number"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.Location = New System.Drawing.Point(354, 98)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(56, 17)
        Me.Gender.TabIndex = 4
        Me.Gender.Text = "Gender"
        '
        'gender1
        '
        Me.gender1.AutoSize = True
        Me.gender1.Location = New System.Drawing.Point(466, 99)
        Me.gender1.Name = "gender1"
        Me.gender1.Size = New System.Drawing.Size(48, 17)
        Me.gender1.TabIndex = 5
        Me.gender1.TabStop = True
        Me.gender1.Text = "Male"
        Me.gender1.UseVisualStyleBackColor = True
        '
        'gender2
        '
        Me.gender2.AutoSize = True
        Me.gender2.Location = New System.Drawing.Point(534, 99)
        Me.gender2.Name = "gender2"
        Me.gender2.Size = New System.Drawing.Size(59, 17)
        Me.gender2.TabIndex = 6
        Me.gender2.TabStop = True
        Me.gender2.Text = "Female"
        Me.gender2.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(132, 157)
        Me.txtPhoneNumber.Mask = "(999) 000-0000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 20)
        Me.txtPhoneNumber.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(132, 98)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(466, 37)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtPassword.TabIndex = 9
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Do you acccept any terms and condition", "Responsible if books that you borrowed broke, must pay the fine"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(25, 338)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(342, 94)
        Me.CheckedListBox1.TabIndex = 11
        '
        'Name1
        '
        Me.Name1.AutoSize = True
        Me.Name1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.Location = New System.Drawing.Point(22, 40)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(45, 17)
        Me.Name1.TabIndex = 0
        Me.Name1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(132, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 26)
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background color"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(25, 461)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 13
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(132, 461)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.validTill)
        Me.Panel1.Controls.Add(Me.activationDate)
        Me.Panel1.Controls.Add(Me.address)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Email)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Password1)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.PhoneNumber)
        Me.Panel1.Controls.Add(Me.CheckedListBox1)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Gender)
        Me.Panel1.Controls.Add(Me.Name1)
        Me.Panel1.Controls.Add(Me.gender1)
        Me.Panel1.Controls.Add(Me.gender2)
        Me.Panel1.Controls.Add(Me.txtPhoneNumber)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 516)
        Me.Panel1.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 231)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 15
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(22, 231)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(60, 17)
        Me.address.TabIndex = 16
        Me.address.Text = "Address"
        '
        'activationDate
        '
        Me.activationDate.AutoSize = True
        Me.activationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activationDate.Location = New System.Drawing.Point(354, 157)
        Me.activationDate.Name = "activationDate"
        Me.activationDate.Size = New System.Drawing.Size(103, 17)
        Me.activationDate.TabIndex = 17
        Me.activationDate.Text = "Activation Date"
        '
        'validTill
        '
        Me.validTill.AutoSize = True
        Me.validTill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validTill.Location = New System.Drawing.Point(360, 233)
        Me.validTill.Name = "validTill"
        Me.validTill.Size = New System.Drawing.Size(61, 17)
        Me.validTill.TabIndex = 18
        Me.validTill.Text = "Valid Till"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(466, 157)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 19
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(466, 231)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 20
        '
        'CustomerAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 540)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CustomerAdd"
        Me.Text = "CustomerAdd"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Email As Label
    Friend WithEvents Password1 As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents Gender As Label
    Friend WithEvents gender1 As RadioButton
    Friend WithEvents gender2 As RadioButton
    Friend WithEvents txtPhoneNumber As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Name1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents validTill As Label
    Friend WithEvents activationDate As Label
    Friend WithEvents address As Label
    Friend WithEvents TextBox1 As TextBox
End Class
