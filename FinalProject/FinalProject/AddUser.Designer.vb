<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rdGender1 = New System.Windows.Forms.RadioButton()
        Me.rdGender2 = New System.Windows.Forms.RadioButton()
        Me.maskedtxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.eulaCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.panelUser = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.numUpDownBatch = New System.Windows.Forms.NumericUpDown()
        Me.lblBatch = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.bookToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.progBarInput = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.dtpValidTill = New System.Windows.Forms.DateTimePicker()
        Me.dtpActvDate = New System.Windows.Forms.DateTimePicker()
        Me.lblValidTill = New System.Windows.Forms.Label()
        Me.lblActivationDate = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.addToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.panelUser.SuspendLayout()
        CType(Me.numUpDownBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bookToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(22, 150)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(22, 198)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(340, 174)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(340, 63)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 17)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Gender"
        '
        'rdGender1
        '
        Me.rdGender1.AutoSize = True
        Me.rdGender1.Checked = True
        Me.rdGender1.Location = New System.Drawing.Point(439, 64)
        Me.rdGender1.Name = "rdGender1"
        Me.rdGender1.Size = New System.Drawing.Size(48, 17)
        Me.rdGender1.TabIndex = 7
        Me.rdGender1.TabStop = True
        Me.rdGender1.Text = "Male"
        Me.rdGender1.UseVisualStyleBackColor = True
        '
        'rdGender2
        '
        Me.rdGender2.AutoSize = True
        Me.rdGender2.Location = New System.Drawing.Point(507, 64)
        Me.rdGender2.Name = "rdGender2"
        Me.rdGender2.Size = New System.Drawing.Size(59, 17)
        Me.rdGender2.TabIndex = 8
        Me.rdGender2.Text = "Female"
        Me.rdGender2.UseVisualStyleBackColor = True
        '
        'maskedtxtPhoneNumber
        '
        Me.maskedtxtPhoneNumber.AsciiOnly = True
        Me.maskedtxtPhoneNumber.Location = New System.Drawing.Point(449, 173)
        Me.maskedtxtPhoneNumber.Mask = "\0###########"
        Me.maskedtxtPhoneNumber.Name = "maskedtxtPhoneNumber"
        Me.maskedtxtPhoneNumber.Size = New System.Drawing.Size(117, 20)
        Me.maskedtxtPhoneNumber.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(113, 149)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(182, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(113, 197)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(182, 20)
        Me.txtPassword.TabIndex = 4
        '
        'eulaCheckedListBox
        '
        Me.eulaCheckedListBox.FormattingEnabled = True
        Me.eulaCheckedListBox.Items.AddRange(New Object() {"I acccept any terms and condition", "I responsible if the book that I borrowed broke, then I must pay the fine"})
        Me.eulaCheckedListBox.Location = New System.Drawing.Point(25, 338)
        Me.eulaCheckedListBox.Name = "eulaCheckedListBox"
        Me.eulaCheckedListBox.Size = New System.Drawing.Size(371, 49)
        Me.eulaCheckedListBox.TabIndex = 13
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(22, 98)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(113, 98)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(182, 20)
        Me.txtName.TabIndex = 2
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
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(17, 416)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(100, 36)
        Me.btnRegister.TabIndex = 14
        Me.btnRegister.Text = "&Register"
        Me.addToolTip.SetToolTip(Me.btnRegister, "Register user")
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(137, 416)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 36)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "&Clear"
        Me.addToolTip.SetToolTip(Me.btnClear, "Clear all the filled")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'panelUser
        '
        Me.panelUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelUser.Controls.Add(Me.txtID)
        Me.panelUser.Controls.Add(Me.lblID)
        Me.panelUser.Controls.Add(Me.numUpDownBatch)
        Me.panelUser.Controls.Add(Me.lblBatch)
        Me.panelUser.Controls.Add(Me.cmbMajor)
        Me.panelUser.Controls.Add(Me.bookToolStrip)
        Me.panelUser.Controls.Add(Me.lblMajor)
        Me.panelUser.Controls.Add(Me.dtpValidTill)
        Me.panelUser.Controls.Add(Me.dtpActvDate)
        Me.panelUser.Controls.Add(Me.lblValidTill)
        Me.panelUser.Controls.Add(Me.lblActivationDate)
        Me.panelUser.Controls.Add(Me.lblAddress)
        Me.panelUser.Controls.Add(Me.txtAddress)
        Me.panelUser.Controls.Add(Me.txtPassword)
        Me.panelUser.Controls.Add(Me.lblEmail)
        Me.panelUser.Controls.Add(Me.btnClear)
        Me.panelUser.Controls.Add(Me.lblPassword)
        Me.panelUser.Controls.Add(Me.btnRegister)
        Me.panelUser.Controls.Add(Me.lblPhoneNumber)
        Me.panelUser.Controls.Add(Me.eulaCheckedListBox)
        Me.panelUser.Controls.Add(Me.txtName)
        Me.panelUser.Controls.Add(Me.lblGender)
        Me.panelUser.Controls.Add(Me.lblName)
        Me.panelUser.Controls.Add(Me.rdGender1)
        Me.panelUser.Controls.Add(Me.rdGender2)
        Me.panelUser.Controls.Add(Me.maskedtxtPhoneNumber)
        Me.panelUser.Controls.Add(Me.txtEmail)
        Me.panelUser.Location = New System.Drawing.Point(10, 12)
        Me.panelUser.Name = "panelUser"
        Me.panelUser.Size = New System.Drawing.Size(688, 483)
        Me.panelUser.TabIndex = 15
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(113, 59)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(182, 20)
        Me.txtID.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(21, 60)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(74, 17)
        Me.lblID.TabIndex = 27
        Me.lblID.Text = "Student ID"
        '
        'numUpDownBatch
        '
        Me.numUpDownBatch.Location = New System.Drawing.Point(113, 296)
        Me.numUpDownBatch.Margin = New System.Windows.Forms.Padding(2)
        Me.numUpDownBatch.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.numUpDownBatch.Minimum = New Decimal(New Integer() {2017, 0, 0, 0})
        Me.numUpDownBatch.Name = "numUpDownBatch"
        Me.numUpDownBatch.Size = New System.Drawing.Size(56, 20)
        Me.numUpDownBatch.TabIndex = 6
        Me.numUpDownBatch.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'lblBatch
        '
        Me.lblBatch.AutoSize = True
        Me.lblBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatch.Location = New System.Drawing.Point(22, 296)
        Me.lblBatch.Name = "lblBatch"
        Me.lblBatch.Size = New System.Drawing.Size(44, 17)
        Me.lblBatch.TabIndex = 25
        Me.lblBatch.Text = "Batch"
        '
        'cmbMajor
        '
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(113, 247)
        Me.cmbMajor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(182, 21)
        Me.cmbMajor.TabIndex = 5
        '
        'bookToolStrip
        '
        Me.bookToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bookToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.progBarInput, Me.ToolStripSeparator1, Me.ToolStripLabel2})
        Me.bookToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.bookToolStrip.Name = "bookToolStrip"
        Me.bookToolStrip.Size = New System.Drawing.Size(688, 25)
        Me.bookToolStrip.TabIndex = 23
        Me.bookToolStrip.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripLabel1.Text = "Your progress:"
        '
        'progBarInput
        '
        Me.progBarInput.Maximum = 120
        Me.progBarInput.Name = "progBarInput"
        Me.progBarInput.Size = New System.Drawing.Size(120, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel2.Text = "Fill the field below"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(22, 248)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(43, 17)
        Me.lblMajor.TabIndex = 21
        Me.lblMajor.Text = "Major"
        '
        'dtpValidTill
        '
        Me.dtpValidTill.Location = New System.Drawing.Point(449, 273)
        Me.dtpValidTill.Name = "dtpValidTill"
        Me.dtpValidTill.Size = New System.Drawing.Size(200, 20)
        Me.dtpValidTill.TabIndex = 12
        '
        'dtpActvDate
        '
        Me.dtpActvDate.Location = New System.Drawing.Point(449, 223)
        Me.dtpActvDate.Name = "dtpActvDate"
        Me.dtpActvDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpActvDate.TabIndex = 11
        '
        'lblValidTill
        '
        Me.lblValidTill.AutoSize = True
        Me.lblValidTill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidTill.Location = New System.Drawing.Point(341, 273)
        Me.lblValidTill.Name = "lblValidTill"
        Me.lblValidTill.Size = New System.Drawing.Size(61, 17)
        Me.lblValidTill.TabIndex = 18
        Me.lblValidTill.Text = "Valid Till"
        '
        'lblActivationDate
        '
        Me.lblActivationDate.AutoSize = True
        Me.lblActivationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivationDate.Location = New System.Drawing.Point(340, 223)
        Me.lblActivationDate.Name = "lblActivationDate"
        Me.lblActivationDate.Size = New System.Drawing.Size(103, 17)
        Me.lblActivationDate.TabIndex = 17
        Me.lblActivationDate.Text = "Activation Date"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(340, 104)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 17)
        Me.lblAddress.TabIndex = 16
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(449, 101)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(188, 45)
        Me.txtAddress.TabIndex = 9
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 506)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.panelUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddUser"
        Me.Text = "Add A User"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.panelUser.ResumeLayout(False)
        Me.panelUser.PerformLayout()
        CType(Me.numUpDownBatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bookToolStrip.ResumeLayout(False)
        Me.bookToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents rdGender1 As RadioButton
    Friend WithEvents rdGender2 As RadioButton
    Friend WithEvents maskedtxtPhoneNumber As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents eulaCheckedListBox As CheckedListBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents panelUser As Panel
    Friend WithEvents dtpValidTill As DateTimePicker
    Friend WithEvents dtpActvDate As DateTimePicker
    Friend WithEvents lblValidTill As Label
    Friend WithEvents lblActivationDate As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblMajor As Label
    Friend WithEvents cmbMajor As ComboBox
    Friend WithEvents bookToolStrip As ToolStrip
    Friend WithEvents numUpDownBatch As NumericUpDown
    Friend WithEvents lblBatch As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents progBarInput As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents addToolTip As ToolTip
End Class
