<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentBook
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
        Me.bookListView = New System.Windows.Forms.ListView()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bookListView
        '
        Me.bookListView.HideSelection = False
        Me.bookListView.Location = New System.Drawing.Point(64, 50)
        Me.bookListView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bookListView.Name = "bookListView"
        Me.bookListView.Size = New System.Drawing.Size(756, 233)
        Me.bookListView.TabIndex = 0
        Me.bookListView.UseCompatibleStateImageBehavior = False
        '
        'btnRent
        '
        Me.btnRent.Location = New System.Drawing.Point(64, 341)
        Me.btnRent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(100, 28)
        Me.btnRent.TabIndex = 1
        Me.btnRent.Text = "Rent Book"
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'RentBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 420)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.bookListView)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RentBook"
        Me.Text = "Rent A Book"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bookListView As ListView
    Friend WithEvents btnRent As Button
End Class
