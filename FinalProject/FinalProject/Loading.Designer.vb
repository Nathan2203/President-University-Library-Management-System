<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.loadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.txtLoading = New System.Windows.Forms.Label()
        Me.progBarLoading = New System.Windows.Forms.ProgressBar()
        Me.loadingSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.txtInfo = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        CType(Me.loadingSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loadingSplitContainer.Panel1.SuspendLayout()
        Me.loadingSplitContainer.Panel2.SuspendLayout()
        Me.loadingSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'loadingTimer
        '
        '
        'txtLoading
        '
        Me.txtLoading.AutoSize = True
        Me.txtLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoading.Location = New System.Drawing.Point(5, 75)
        Me.txtLoading.Name = "txtLoading"
        Me.txtLoading.Size = New System.Drawing.Size(304, 17)
        Me.txtLoading.TabIndex = 3
        Me.txtLoading.Text = "Please wait. We will direct you to the right form."
        '
        'progBarLoading
        '
        Me.progBarLoading.Location = New System.Drawing.Point(8, 117)
        Me.progBarLoading.Name = "progBarLoading"
        Me.progBarLoading.Size = New System.Drawing.Size(252, 23)
        Me.progBarLoading.TabIndex = 4
        '
        'loadingSplitContainer
        '
        Me.loadingSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loadingSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.loadingSplitContainer.Name = "loadingSplitContainer"
        '
        'loadingSplitContainer.Panel1
        '
        Me.loadingSplitContainer.Panel1.Controls.Add(Me.txtInfo)
        '
        'loadingSplitContainer.Panel2
        '
        Me.loadingSplitContainer.Panel2.Controls.Add(Me.lblPercent)
        Me.loadingSplitContainer.Panel2.Controls.Add(Me.progBarLoading)
        Me.loadingSplitContainer.Panel2.Controls.Add(Me.txtLoading)
        Me.loadingSplitContainer.Size = New System.Drawing.Size(486, 210)
        Me.loadingSplitContainer.SplitterDistance = 161
        Me.loadingSplitContainer.TabIndex = 7
        '
        'txtInfo
        '
        Me.txtInfo.AutoSize = True
        Me.txtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.Location = New System.Drawing.Point(41, 76)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(63, 16)
        Me.txtInfo.TabIndex = 5
        Me.txtInfo.Text = "PU LMS"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(275, 123)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(20, 17)
        Me.lblPercent.TabIndex = 5
        Me.lblPercent.Text = "%"
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 210)
        Me.Controls.Add(Me.loadingSplitContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.loadingSplitContainer.Panel1.ResumeLayout(False)
        Me.loadingSplitContainer.Panel1.PerformLayout()
        Me.loadingSplitContainer.Panel2.ResumeLayout(False)
        Me.loadingSplitContainer.Panel2.PerformLayout()
        CType(Me.loadingSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loadingSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loadingTimer As Timer
    Friend WithEvents txtLoading As Label
    Friend WithEvents progBarLoading As ProgressBar
    Friend WithEvents loadingSplitContainer As SplitContainer
    Friend WithEvents txtInfo As Label
    Friend WithEvents lblPercent As Label
End Class
