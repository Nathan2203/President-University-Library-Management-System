<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rentedBook
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.rentedBookbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(48, 41)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(568, 190)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'rentedBookbtn
        '
        Me.rentedBookbtn.Location = New System.Drawing.Point(48, 277)
        Me.rentedBookbtn.Name = "rentedBookbtn"
        Me.rentedBookbtn.Size = New System.Drawing.Size(75, 23)
        Me.rentedBookbtn.TabIndex = 1
        Me.rentedBookbtn.Text = "Rent Book"
        Me.rentedBookbtn.UseVisualStyleBackColor = True
        '
        'rentedBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 341)
        Me.Controls.Add(Me.rentedBookbtn)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "rentedBook"
        Me.Text = "rentedBook"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents rentedBookbtn As Button
End Class
