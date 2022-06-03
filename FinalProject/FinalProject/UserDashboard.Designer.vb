<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        Me.userBook = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.userAuthor = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.userBook.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'userBook
        '
        Me.userBook.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.userBook.Controls.Add(Me.TabPage1)
        Me.userBook.Controls.Add(Me.userAuthor)
        Me.userBook.Location = New System.Drawing.Point(12, 12)
        Me.userBook.Multiline = True
        Me.userBook.Name = "userBook"
        Me.userBook.SelectedIndex = 0
        Me.userBook.Size = New System.Drawing.Size(619, 352)
        Me.userBook.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(611, 326)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Books"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'userAuthor
        '
        Me.userAuthor.Location = New System.Drawing.Point(4, 4)
        Me.userAuthor.Name = "userAuthor"
        Me.userAuthor.Padding = New System.Windows.Forms.Padding(3)
        Me.userAuthor.Size = New System.Drawing.Size(611, 326)
        Me.userAuthor.TabIndex = 1
        Me.userAuthor.Text = "Author"
        Me.userAuthor.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 369)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(646, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripLabel1.Text = "Student Library Management Sistem"
        '
        'UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 394)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.userBook)
        Me.Name = "UserDashboard"
        Me.Text = "UserDashboard"
        Me.userBook.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userBook As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents userAuthor As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
