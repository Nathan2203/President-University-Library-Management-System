<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentBook
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
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentBook))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.controlGroupBox = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRentBook = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblBookISBN = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtPublishYear = New System.Windows.Forms.TextBox()
        Me.bookGroupBox = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.availableBookListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.controlGroupBox.SuspendLayout()
        Me.bookGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "ISBN"
        ColumnHeader1.Width = 100
        '
        'controlGroupBox
        '
        Me.controlGroupBox.Controls.Add(Me.btnCancel)
        Me.controlGroupBox.Controls.Add(Me.btnClear)
        Me.controlGroupBox.Controls.Add(Me.btnRentBook)
        Me.controlGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controlGroupBox.ForeColor = System.Drawing.Color.White
        Me.controlGroupBox.Location = New System.Drawing.Point(37, 455)
        Me.controlGroupBox.Name = "controlGroupBox"
        Me.controlGroupBox.Size = New System.Drawing.Size(304, 60)
        Me.controlGroupBox.TabIndex = 16
        Me.controlGroupBox.TabStop = False
        Me.controlGroupBox.Text = "Control"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(210, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Close the form")
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(114, 19)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear all the field of the form")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRentBook
        '
        Me.btnRentBook.BackColor = System.Drawing.Color.SeaGreen
        Me.btnRentBook.FlatAppearance.BorderSize = 0
        Me.btnRentBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRentBook.Location = New System.Drawing.Point(17, 19)
        Me.btnRentBook.Name = "btnRentBook"
        Me.btnRentBook.Size = New System.Drawing.Size(75, 35)
        Me.btnRentBook.TabIndex = 2
        Me.btnRentBook.Text = "&Rent"
        Me.ToolTip1.SetToolTip(Me.btnRentBook, "Return the borrowed book so the book will be available")
        Me.btnRentBook.UseVisualStyleBackColor = False
        '
        'lblBookISBN
        '
        Me.lblBookISBN.AutoSize = True
        Me.lblBookISBN.Location = New System.Drawing.Point(30, 47)
        Me.lblBookISBN.Name = "lblBookISBN"
        Me.lblBookISBN.Size = New System.Drawing.Size(75, 17)
        Me.lblBookISBN.TabIndex = 0
        Me.lblBookISBN.Text = "Book ISBN"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(30, 88)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(81, 17)
        Me.lblBookName.TabIndex = 1
        Me.lblBookName.Text = "Book Name"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(30, 129)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(48, 17)
        Me.lblGenre.TabIndex = 2
        Me.lblGenre.Text = "Genre"
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(125, 129)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.ReadOnly = True
        Me.txtGenre.Size = New System.Drawing.Size(160, 23)
        Me.txtGenre.TabIndex = 5
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(424, 135)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(427, 161)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(287, 91)
        Me.txtDescription.TabIndex = 8
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(125, 47)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.ReadOnly = True
        Me.txtISBN.Size = New System.Drawing.Size(160, 23)
        Me.txtISBN.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(125, 88)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(160, 23)
        Me.txtName.TabIndex = 10
        '
        'lblPublisher
        '
        Me.lblPublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(424, 47)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(67, 17)
        Me.lblPublisher.TabIndex = 24
        Me.lblPublisher.Text = "Publisher"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(30, 179)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(50, 17)
        Me.lblAuthor.TabIndex = 26
        Me.lblAuthor.Text = "Author"
        '
        'lblYear
        '
        Me.lblYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(424, 91)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(107, 17)
        Me.lblYear.TabIndex = 28
        Me.lblYear.Text = "Publishing Year"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(30, 226)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(40, 17)
        Me.lblPrice.TabIndex = 30
        Me.lblPrice.Text = "Price"
        '
        'txtPublisher
        '
        Me.txtPublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(537, 47)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.ReadOnly = True
        Me.txtPublisher.Size = New System.Drawing.Size(160, 22)
        Me.txtPublisher.TabIndex = 29
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(125, 174)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.ReadOnly = True
        Me.txtAuthor.Size = New System.Drawing.Size(160, 22)
        Me.txtAuthor.TabIndex = 27
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(125, 221)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(160, 22)
        Me.txtPrice.TabIndex = 32
        '
        'txtPublishYear
        '
        Me.txtPublishYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPublishYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublishYear.Location = New System.Drawing.Point(537, 88)
        Me.txtPublishYear.Name = "txtPublishYear"
        Me.txtPublishYear.ReadOnly = True
        Me.txtPublishYear.Size = New System.Drawing.Size(160, 22)
        Me.txtPublishYear.TabIndex = 31
        '
        'bookGroupBox
        '
        Me.bookGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookGroupBox.Controls.Add(Me.txtPublishYear)
        Me.bookGroupBox.Controls.Add(Me.txtPrice)
        Me.bookGroupBox.Controls.Add(Me.txtAuthor)
        Me.bookGroupBox.Controls.Add(Me.txtPublisher)
        Me.bookGroupBox.Controls.Add(Me.lblPrice)
        Me.bookGroupBox.Controls.Add(Me.lblYear)
        Me.bookGroupBox.Controls.Add(Me.lblAuthor)
        Me.bookGroupBox.Controls.Add(Me.lblPublisher)
        Me.bookGroupBox.Controls.Add(Me.txtName)
        Me.bookGroupBox.Controls.Add(Me.txtISBN)
        Me.bookGroupBox.Controls.Add(Me.txtDescription)
        Me.bookGroupBox.Controls.Add(Me.lblDescription)
        Me.bookGroupBox.Controls.Add(Me.txtGenre)
        Me.bookGroupBox.Controls.Add(Me.lblGenre)
        Me.bookGroupBox.Controls.Add(Me.lblBookName)
        Me.bookGroupBox.Controls.Add(Me.lblBookISBN)
        Me.bookGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bookGroupBox.ForeColor = System.Drawing.Color.White
        Me.bookGroupBox.Location = New System.Drawing.Point(37, 38)
        Me.bookGroupBox.Name = "bookGroupBox"
        Me.bookGroupBox.Size = New System.Drawing.Size(771, 268)
        Me.bookGroupBox.TabIndex = 0
        Me.bookGroupBox.TabStop = False
        Me.bookGroupBox.Text = "Book Detail"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(0, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'availableBookListView
        '
        Me.availableBookListView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.availableBookListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.availableBookListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.availableBookListView.HideSelection = False
        Me.availableBookListView.Location = New System.Drawing.Point(37, 327)
        Me.availableBookListView.Name = "availableBookListView"
        Me.availableBookListView.Size = New System.Drawing.Size(771, 122)
        Me.availableBookListView.TabIndex = 1
        Me.availableBookListView.UseCompatibleStateImageBehavior = False
        Me.availableBookListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Title"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Genre"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Author"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Description"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 200
        '
        'RentBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(846, 527)
        Me.Controls.Add(Me.availableBookListView)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.controlGroupBox)
        Me.Controls.Add(Me.bookGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RentBook"
        Me.Text = "Rent A Book"
        Me.controlGroupBox.ResumeLayout(False)
        Me.bookGroupBox.ResumeLayout(False)
        Me.bookGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents controlGroupBox As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRentBook As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblBookISBN As Label
    Friend WithEvents lblBookName As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPublisher As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtPublishYear As TextBox
    Friend WithEvents bookGroupBox As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents availableBookListView As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnCancel As Button
End Class
