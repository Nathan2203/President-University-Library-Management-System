<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddABookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRentedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.aboutToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.mainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeBackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadAnImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.mainMenuStrip.SuspendLayout()
        Me.mainStatusStrip.SuspendLayout()
        Me.mainContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenuStrip
        '
        Me.mainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UserToolStripMenuItem, Me.ViewToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.mainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainMenuStrip.Name = "mainMenuStrip"
        Me.mainMenuStrip.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.mainMenuStrip.Size = New System.Drawing.Size(1620, 24)
        Me.mainMenuStrip.TabIndex = 0
        Me.mainMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddABookToolStripMenuItem, Me.ViewBooksToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'AddABookToolStripMenuItem
        '
        Me.AddABookToolStripMenuItem.Name = "AddABookToolStripMenuItem"
        Me.AddABookToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AddABookToolStripMenuItem.Text = "Add a book"
        '
        'ViewBooksToolStripMenuItem
        '
        Me.ViewBooksToolStripMenuItem.Name = "ViewBooksToolStripMenuItem"
        Me.ViewBooksToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ViewBooksToolStripMenuItem.Text = "View books"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ViewUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AddUserToolStripMenuItem.Text = "&Add User"
        '
        'ViewUserToolStripMenuItem
        '
        Me.ViewUserToolStripMenuItem.Name = "ViewUserToolStripMenuItem"
        Me.ViewUserToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ViewUserToolStripMenuItem.Text = "&View User"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRentedToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'AllRentedToolStripMenuItem
        '
        Me.AllRentedToolStripMenuItem.Name = "AllRentedToolStripMenuItem"
        Me.AllRentedToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AllRentedToolStripMenuItem.Text = "Status Books"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAllToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowToolStripMenuItem.Text = "&Windows"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CloseAllToolStripMenuItem.Text = "Close &All"
        '
        'mainStatusStrip
        '
        Me.mainStatusStrip.BackColor = System.Drawing.SystemColors.Highlight
        Me.mainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.aboutToolStripSplitButton})
        Me.mainStatusStrip.Location = New System.Drawing.Point(0, 812)
        Me.mainStatusStrip.Name = "mainStatusStrip"
        Me.mainStatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 23, 0)
        Me.mainStatusStrip.Size = New System.Drawing.Size(1620, 22)
        Me.mainStatusStrip.TabIndex = 2
        Me.mainStatusStrip.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(185, 17)
        Me.ToolStripStatusLabel1.Text = "PU Library Management System"
        '
        'aboutToolStripSplitButton
        '
        Me.aboutToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.aboutToolStripSplitButton.Image = Global.FinalProject.My.Resources.Resources.question_mark
        Me.aboutToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.aboutToolStripSplitButton.Name = "aboutToolStripSplitButton"
        Me.aboutToolStripSplitButton.Size = New System.Drawing.Size(32, 20)
        Me.aboutToolStripSplitButton.Text = "ToolStripSplitButton1"
        '
        'mainContextMenuStrip
        '
        Me.mainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeBackgroundToolStripMenuItem})
        Me.mainContextMenuStrip.Name = "mainContextMenuStrip"
        Me.mainContextMenuStrip.Size = New System.Drawing.Size(183, 26)
        '
        'ChangeBackgroundToolStripMenuItem
        '
        Me.ChangeBackgroundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadAnImageToolStripMenuItem})
        Me.ChangeBackgroundToolStripMenuItem.Name = "ChangeBackgroundToolStripMenuItem"
        Me.ChangeBackgroundToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ChangeBackgroundToolStripMenuItem.Text = "Change Background"
        '
        'UploadAnImageToolStripMenuItem
        '
        Me.UploadAnImageToolStripMenuItem.Name = "UploadAnImageToolStripMenuItem"
        Me.UploadAnImageToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UploadAnImageToolStripMenuItem.Text = "Upload an Image"
        '
        'mainOpenFileDialog
        '
        Me.mainOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1620, 834)
        Me.ContextMenuStrip = Me.mainContextMenuStrip
        Me.Controls.Add(Me.mainStatusStrip)
        Me.Controls.Add(Me.mainMenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "PU Library Management System (Admin)"
        Me.mainMenuStrip.ResumeLayout(False)
        Me.mainMenuStrip.PerformLayout()
        Me.mainStatusStrip.ResumeLayout(False)
        Me.mainStatusStrip.PerformLayout()
        Me.mainContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllRentedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainStatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainContextMenuStrip As ContextMenuStrip
    Friend WithEvents ChangeBackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadAnImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainOpenFileDialog As OpenFileDialog
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddABookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aboutToolStripSplitButton As ToolStripSplitButton
End Class
