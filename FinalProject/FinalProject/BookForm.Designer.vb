<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Book")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Books")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Books", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bookTree = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'bookTree
        '
        Me.bookTree.Location = New System.Drawing.Point(0, 1)
        Me.bookTree.Name = "bookTree"
        TreeNode1.Name = "nodeAdd"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode1.Text = "Add Book"
        TreeNode2.Name = "nodeList"
        TreeNode2.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode2.Text = "List Books"
        TreeNode3.Name = "nodeBooks"
        TreeNode3.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode3.Text = "Books"
        Me.bookTree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.bookTree.Size = New System.Drawing.Size(122, 641)
        Me.bookTree.TabIndex = 2
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 394)
        Me.Controls.Add(Me.bookTree)
        Me.IsMdiContainer = True
        Me.Name = "BookForm"
        Me.Text = " Books"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents bookTree As TreeView
End Class
