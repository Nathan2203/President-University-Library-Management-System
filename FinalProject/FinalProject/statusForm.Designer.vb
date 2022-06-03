<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statusForm
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
        Me.statusTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rentedStatus = New System.Windows.Forms.ListView()
        Me.availableStatus = New System.Windows.Forms.ListView()
        Me.statusTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusTab
        '
        Me.statusTab.Controls.Add(Me.TabPage1)
        Me.statusTab.Controls.Add(Me.TabPage2)
        Me.statusTab.Location = New System.Drawing.Point(12, 12)
        Me.statusTab.Name = "statusTab"
        Me.statusTab.SelectedIndex = 0
        Me.statusTab.Size = New System.Drawing.Size(599, 269)
        Me.statusTab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rentedStatus)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(591, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rented Book"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.availableStatus)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(591, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Available Book"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rentedStatus
        '
        Me.rentedStatus.HideSelection = False
        Me.rentedStatus.Location = New System.Drawing.Point(6, 6)
        Me.rentedStatus.Name = "rentedStatus"
        Me.rentedStatus.Size = New System.Drawing.Size(579, 231)
        Me.rentedStatus.TabIndex = 0
        Me.rentedStatus.UseCompatibleStateImageBehavior = False
        '
        'availableStatus
        '
        Me.availableStatus.HideSelection = False
        Me.availableStatus.Location = New System.Drawing.Point(6, 6)
        Me.availableStatus.Name = "availableStatus"
        Me.availableStatus.Size = New System.Drawing.Size(579, 231)
        Me.availableStatus.TabIndex = 0
        Me.availableStatus.UseCompatibleStateImageBehavior = False
        '
        'statusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 293)
        Me.Controls.Add(Me.statusTab)
        Me.Name = "statusForm"
        Me.Text = "statusForm"
        Me.statusTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents statusTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rentedStatus As ListView
    Friend WithEvents availableStatus As ListView
End Class
