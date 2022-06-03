<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblIDStud = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.titleBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnViewProfile = New System.Windows.Forms.Button()
        Me.btnMyProfile = New System.Windows.Forms.PictureBox()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.minimizePictureBox = New System.Windows.Forms.PictureBox()
        Me.exitPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.titleBar.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.btnMyProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblIDStud)
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.btnMyProfile)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 155)
        Me.Panel2.TabIndex = 0
        '
        'lblIDStud
        '
        Me.lblIDStud.AutoSize = True
        Me.lblIDStud.Font = New System.Drawing.Font("Ebrima", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDStud.ForeColor = System.Drawing.Color.DarkGray
        Me.lblIDStud.Location = New System.Drawing.Point(14, 116)
        Me.lblIDStud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDStud.Name = "lblIDStud"
        Me.lblIDStud.Size = New System.Drawing.Size(79, 20)
        Me.lblIDStud.TabIndex = 14
        Me.lblIDStud.Text = "Student ID"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.LightGray
        Me.lblUsername.Location = New System.Drawing.Point(12, 95)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 21)
        Me.lblUsername.TabIndex = 16
        Me.lblUsername.Text = "Username"
        '
        'titleBar
        '
        Me.titleBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.titleBar.Controls.Add(Me.Label2)
        Me.titleBar.Controls.Add(Me.PictureBox1)
        Me.titleBar.Controls.Add(Me.minimizePictureBox)
        Me.titleBar.Controls.Add(Me.exitPictureBox)
        Me.titleBar.Location = New System.Drawing.Point(0, 0)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(1200, 43)
        Me.titleBar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(36, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Main Menu"
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContainer.Controls.Add(Me.Panel5)
        Me.PanelContainer.Controls.Add(Me.titleBar)
        Me.PanelContainer.Controls.Add(Me.Panel3)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1200, 600)
        Me.PanelContainer.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnAbout)
        Me.Panel5.Controls.Add(Me.btnLogout)
        Me.Panel5.Controls.Add(Me.btnViewProfile)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.btnRent)
        Me.Panel5.Controls.Add(Me.btnReturn)
        Me.Panel5.Location = New System.Drawing.Point(0, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 559)
        Me.Panel5.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(236, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(964, 559)
        Me.Panel3.TabIndex = 2
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Ebrima", 11.25!)
        Me.btnAbout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAbout.Image = Global.FinalProject.My.Resources.Resources.question_mark
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbout.Location = New System.Drawing.Point(0, 381)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(236, 38)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.Location = New System.Drawing.Point(5, 478)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(231, 49)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnViewProfile
        '
        Me.btnViewProfile.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnViewProfile.FlatAppearance.BorderSize = 0
        Me.btnViewProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnViewProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProfile.Font = New System.Drawing.Font("Ebrima", 11.25!)
        Me.btnViewProfile.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnViewProfile.Image = Global.FinalProject.My.Resources.Resources.user
        Me.btnViewProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewProfile.Location = New System.Drawing.Point(0, 231)
        Me.btnViewProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewProfile.Name = "btnViewProfile"
        Me.btnViewProfile.Size = New System.Drawing.Size(235, 38)
        Me.btnViewProfile.TabIndex = 1
        Me.btnViewProfile.Text = "View Profile"
        Me.btnViewProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewProfile.UseVisualStyleBackColor = False
        '
        'btnMyProfile
        '
        Me.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyProfile.Image = CType(resources.GetObject("btnMyProfile.Image"), System.Drawing.Image)
        Me.btnMyProfile.Location = New System.Drawing.Point(76, 20)
        Me.btnMyProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(64, 64)
        Me.btnMyProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMyProfile.TabIndex = 12
        Me.btnMyProfile.TabStop = False
        '
        'btnRent
        '
        Me.btnRent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnRent.FlatAppearance.BorderSize = 0
        Me.btnRent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRent.Font = New System.Drawing.Font("Ebrima", 11.25!)
        Me.btnRent.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRent.Image = Global.FinalProject.My.Resources.Resources.books
        Me.btnRent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRent.Location = New System.Drawing.Point(3, 331)
        Me.btnRent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(233, 38)
        Me.btnRent.TabIndex = 3
        Me.btnRent.Text = "Rent A Book"
        Me.btnRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRent.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Ebrima", 11.25!)
        Me.btnReturn.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnReturn.Image = Global.FinalProject.My.Resources.Resources.bookshelf
        Me.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReturn.Location = New System.Drawing.Point(0, 281)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(235, 38)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return A Book"
        Me.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PictureBox1.Image = Global.FinalProject.My.Resources.Resources.photo_album
        Me.PictureBox1.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 27)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'minimizePictureBox
        '
        Me.minimizePictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizePictureBox.BackColor = System.Drawing.Color.White
        Me.minimizePictureBox.Image = Global.FinalProject.My.Resources.Resources.minimize5
        Me.minimizePictureBox.Location = New System.Drawing.Point(1088, 3)
        Me.minimizePictureBox.Name = "minimizePictureBox"
        Me.minimizePictureBox.Size = New System.Drawing.Size(36, 33)
        Me.minimizePictureBox.TabIndex = 0
        Me.minimizePictureBox.TabStop = False
        '
        'exitPictureBox
        '
        Me.exitPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitPictureBox.Image = Global.FinalProject.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2
        Me.exitPictureBox.Location = New System.Drawing.Point(1142, 3)
        Me.exitPictureBox.Name = "exitPictureBox"
        Me.exitPictureBox.Size = New System.Drawing.Size(31, 33)
        Me.exitPictureBox.TabIndex = 1
        Me.exitPictureBox.TabStop = False
        '
        'userForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.PanelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "userForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.titleBar.ResumeLayout(False)
        Me.titleBar.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.btnMyProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents titleBar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents minimizePictureBox As PictureBox
    Friend WithEvents exitPictureBox As PictureBox
    Friend WithEvents btnMyProfile As PictureBox
    Friend WithEvents lblIDStud As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnViewProfile As Button
    Friend WithEvents btnRent As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAbout As Button
End Class
