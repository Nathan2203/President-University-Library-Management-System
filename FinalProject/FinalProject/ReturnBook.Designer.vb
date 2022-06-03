<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnBook
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
        Me.bookGroupBox = New System.Windows.Forms.GroupBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtIssueDate = New System.Windows.Forms.TextBox()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.issueGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.IssueName = New System.Windows.Forms.Label()
        Me.issue = New System.Windows.Forms.Label()
        Me.listViewBook = New System.Windows.Forms.ListView()
        Me.controlGroupBox = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bookGroupBox.SuspendLayout()
        Me.issueGroupBox.SuspendLayout()
        Me.controlGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'bookGroupBox
        '
        Me.bookGroupBox.Controls.Add(Me.txtBookName)
        Me.bookGroupBox.Controls.Add(Me.txtBookID)
        Me.bookGroupBox.Controls.Add(Me.txtDescription)
        Me.bookGroupBox.Controls.Add(Me.lblDescription)
        Me.bookGroupBox.Controls.Add(Me.txtIssueDate)
        Me.bookGroupBox.Controls.Add(Me.lblIssueDate)
        Me.bookGroupBox.Controls.Add(Me.lblBookName)
        Me.bookGroupBox.Controls.Add(Me.lblBookID)
        Me.bookGroupBox.Location = New System.Drawing.Point(49, 47)
        Me.bookGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bookGroupBox.Name = "bookGroupBox"
        Me.bookGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bookGroupBox.Size = New System.Drawing.Size(956, 228)
        Me.bookGroupBox.TabIndex = 0
        Me.bookGroupBox.TabStop = False
        Me.bookGroupBox.Text = "Book Detail"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(167, 108)
        Me.txtBookName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(160, 22)
        Me.txtBookName.TabIndex = 10
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(167, 58)
        Me.txtBookID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(160, 22)
        Me.txtBookID.TabIndex = 9
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(519, 71)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(381, 111)
        Me.txtDescription.TabIndex = 8
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(515, 39)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(76, 16)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Description"
        '
        'txtIssueDate
        '
        Me.txtIssueDate.Location = New System.Drawing.Point(167, 159)
        Me.txtIssueDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIssueDate.Name = "txtIssueDate"
        Me.txtIssueDate.Size = New System.Drawing.Size(160, 22)
        Me.txtIssueDate.TabIndex = 5
        '
        'lblIssueDate
        '
        Me.lblIssueDate.AutoSize = True
        Me.lblIssueDate.Location = New System.Drawing.Point(40, 159)
        Me.lblIssueDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.Size = New System.Drawing.Size(72, 16)
        Me.lblIssueDate.TabIndex = 2
        Me.lblIssueDate.Text = "Issue Date"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(40, 108)
        Me.lblBookName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(80, 16)
        Me.lblBookName.TabIndex = 1
        Me.lblBookName.Text = "Book Name"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(40, 58)
        Me.lblBookID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(56, 16)
        Me.lblBookID.TabIndex = 0
        Me.lblBookID.Text = "Book ID"
        '
        'issueGroupBox
        '
        Me.issueGroupBox.Controls.Add(Me.TextBox4)
        Me.issueGroupBox.Controls.Add(Me.DateTimePicker1)
        Me.issueGroupBox.Controls.Add(Me.Label1)
        Me.issueGroupBox.Controls.Add(Me.Label4)
        Me.issueGroupBox.Controls.Add(Me.TextBox3)
        Me.issueGroupBox.Controls.Add(Me.ComboBox3)
        Me.issueGroupBox.Controls.Add(Me.IssueName)
        Me.issueGroupBox.Controls.Add(Me.issue)
        Me.issueGroupBox.Location = New System.Drawing.Point(49, 338)
        Me.issueGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.issueGroupBox.Name = "issueGroupBox"
        Me.issueGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.issueGroupBox.Size = New System.Drawing.Size(956, 118)
        Me.issueGroupBox.TabIndex = 1
        Me.issueGroupBox.TabStop = False
        Me.issueGroupBox.Text = "Issue Detail"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(588, 36)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(265, 22)
        Me.TextBox4.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(588, 75)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Return Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Due Date"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(167, 75)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(160, 22)
        Me.TextBox3.TabIndex = 3
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(167, 34)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox3.TabIndex = 2
        '
        'IssueName
        '
        Me.IssueName.AutoSize = True
        Me.IssueName.Location = New System.Drawing.Point(40, 75)
        Me.IssueName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IssueName.Name = "IssueName"
        Me.IssueName.Size = New System.Drawing.Size(45, 16)
        Me.IssueName.TabIndex = 1
        Me.IssueName.Text = "Name"
        '
        'issue
        '
        Me.issue.AutoSize = True
        Me.issue.Location = New System.Drawing.Point(40, 36)
        Me.issue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.issue.Name = "issue"
        Me.issue.Size = New System.Drawing.Size(60, 16)
        Me.issue.TabIndex = 0
        Me.issue.Text = "Issue To"
        '
        'listViewBook
        '
        Me.listViewBook.FullRowSelect = True
        Me.listViewBook.GridLines = True
        Me.listViewBook.HideSelection = False
        Me.listViewBook.Location = New System.Drawing.Point(49, 485)
        Me.listViewBook.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listViewBook.Name = "listViewBook"
        Me.listViewBook.Size = New System.Drawing.Size(955, 118)
        Me.listViewBook.TabIndex = 15
        Me.listViewBook.UseCompatibleStateImageBehavior = False
        Me.listViewBook.View = System.Windows.Forms.View.Details
        '
        'controlGroupBox
        '
        Me.controlGroupBox.Controls.Add(Me.btnSearch)
        Me.controlGroupBox.Controls.Add(Me.btnCancel)
        Me.controlGroupBox.Controls.Add(Me.btnClear)
        Me.controlGroupBox.Controls.Add(Me.btnReturn)
        Me.controlGroupBox.Location = New System.Drawing.Point(49, 638)
        Me.controlGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.controlGroupBox.Name = "controlGroupBox"
        Me.controlGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.controlGroupBox.Size = New System.Drawing.Size(529, 55)
        Me.controlGroupBox.TabIndex = 16
        Me.controlGroupBox.TabStop = False
        Me.controlGroupBox.Text = "Control"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(400, 23)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search the book by its id")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(268, 23)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Close the form")
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 23)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear all the field of the form")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(9, 25)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(100, 28)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Return"
        Me.ToolTip1.SetToolTip(Me.btnReturn, "Return the borrowed book so the book will be available")
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'ReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 719)
        Me.Controls.Add(Me.controlGroupBox)
        Me.Controls.Add(Me.listViewBook)
        Me.Controls.Add(Me.issueGroupBox)
        Me.Controls.Add(Me.bookGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.name = "ReturnBook"
        Me.Text = "ReturnBook"
        Me.bookGroupBox.ResumeLayout(False)
        Me.bookGroupBox.PerformLayout()
        Me.issueGroupBox.ResumeLayout(False)
        Me.issueGroupBox.PerformLayout()
        Me.controlGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bookGroupBox As GroupBox
    Friend WithEvents lblIssueDate As Label
    Friend WithEvents lblBookName As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtIssueDate As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents issueGroupBox As GroupBox
    Friend WithEvents issue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents IssueName As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents listViewBook As ListView
    Friend WithEvents controlGroupBox As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtBookID As TextBox
End Class
