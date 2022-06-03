<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersDetail
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
        Me.customerID = New System.Windows.Forms.Label()
        Me.userId = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customerID
        '
        Me.customerID.AutoSize = True
        Me.customerID.Location = New System.Drawing.Point(21, 31)
        Me.customerID.Name = "customerID"
        Me.customerID.Size = New System.Drawing.Size(65, 13)
        Me.customerID.TabIndex = 0
        Me.customerID.Text = "Customer ID"
        '
        'userId
        '
        Me.userId.Location = New System.Drawing.Point(102, 28)
        Me.userId.Name = "userId"
        Me.userId.Size = New System.Drawing.Size(119, 20)
        Me.userId.TabIndex = 1
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(634, 28)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(89, 23)
        Me.search.TabIndex = 2
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(699, 315)
        Me.DataGridView1.TabIndex = 3
        '
        'CustomersDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(751, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.userId)
        Me.Controls.Add(Me.customerID)
        Me.Name = "CustomersDetail"
        Me.Text = "Customer Detail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customerID As Label
    Friend WithEvents userId As TextBox
    Friend WithEvents search As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
