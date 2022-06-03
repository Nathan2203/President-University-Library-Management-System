<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBook))
        Me.bookGroupBox = New System.Windows.Forms.GroupBox()
        Me.mskTxtISBN = New System.Windows.Forms.MaskedTextBox()
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.txtPublishYear = New System.Windows.Forms.TextBox()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Price = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.Label()
        Me.Author = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.progBarBook = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.bookGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bookGroupBox
        '
        Me.bookGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookGroupBox.Controls.Add(Me.mskTxtISBN)
        Me.bookGroupBox.Controls.Add(Me.txtDesc)
        Me.bookGroupBox.Controls.Add(Me.txtGenre)
        Me.bookGroupBox.Controls.Add(Me.lblGenre)
        Me.bookGroupBox.Controls.Add(Me.descriptionLabel)
        Me.bookGroupBox.Controls.Add(Me.txtPublishYear)
        Me.bookGroupBox.Controls.Add(Me.lblISBN)
        Me.bookGroupBox.Controls.Add(Me.txtPrice)
        Me.bookGroupBox.Controls.Add(Me.txtAuthor)
        Me.bookGroupBox.Controls.Add(Me.txtPublisher)
        Me.bookGroupBox.Controls.Add(Me.txtBookName)
        Me.bookGroupBox.Controls.Add(Me.Price)
        Me.bookGroupBox.Controls.Add(Me.year)
        Me.bookGroupBox.Controls.Add(Me.Author)
        Me.bookGroupBox.Controls.Add(Me.lblPublisher)
        Me.bookGroupBox.Controls.Add(Me.lblBookName)
        Me.bookGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bookGroupBox.Location = New System.Drawing.Point(12, 51)
        Me.bookGroupBox.Name = "bookGroupBox"
        Me.bookGroupBox.Size = New System.Drawing.Size(709, 399)
        Me.bookGroupBox.TabIndex = 0
        Me.bookGroupBox.TabStop = False
        Me.bookGroupBox.Text = "Add a book here:"
        '
        'mskTxtISBN
        '
        Me.mskTxtISBN.Location = New System.Drawing.Point(119, 33)
        Me.mskTxtISBN.Mask = "\978##########"
        Me.mskTxtISBN.Name = "mskTxtISBN"
        Me.mskTxtISBN.Size = New System.Drawing.Size(160, 22)
        Me.mskTxtISBN.TabIndex = 1
        '
        'txtDesc
        '
        Me.txtDesc.AcceptsTab = True
        Me.txtDesc.AutoWordSelection = True
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(119, 231)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDesc.Size = New System.Drawing.Size(351, 150)
        Me.txtDesc.TabIndex = 8
        Me.txtDesc.Text = ""
        '
        'txtGenre
        '
        Me.txtGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre.Location = New System.Drawing.Point(119, 124)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(160, 22)
        Me.txtGenre.TabIndex = 3
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(7, 127)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(50, 16)
        Me.lblGenre.TabIndex = 20
        Me.lblGenre.Text = "Genre"
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Location = New System.Drawing.Point(9, 231)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(87, 16)
        Me.descriptionLabel.TabIndex = 18
        Me.descriptionLabel.Text = "Description"
        '
        'txtPublishYear
        '
        Me.txtPublishYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublishYear.Location = New System.Drawing.Point(513, 77)
        Me.txtPublishYear.Name = "txtPublishYear"
        Me.txtPublishYear.Size = New System.Drawing.Size(160, 22)
        Me.txtPublishYear.TabIndex = 6
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(7, 36)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(43, 16)
        Me.lblISBN.TabIndex = 13
        Me.lblISBN.Text = "ISBN"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(513, 124)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(160, 22)
        Me.txtPrice.TabIndex = 7
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(119, 168)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(160, 22)
        Me.txtAuthor.TabIndex = 4
        '
        'txtPublisher
        '
        Me.txtPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(513, 33)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(160, 22)
        Me.txtPublisher.TabIndex = 5
        '
        'txtBookName
        '
        Me.txtBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.Location = New System.Drawing.Point(119, 77)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(160, 22)
        Me.txtBookName.TabIndex = 2
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Location = New System.Drawing.Point(378, 127)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(44, 16)
        Me.Price.TabIndex = 5
        Me.Price.Text = "Price"
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.Location = New System.Drawing.Point(376, 80)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(117, 16)
        Me.year.TabIndex = 4
        Me.year.Text = "Publishing Year"
        '
        'Author
        '
        Me.Author.AutoSize = True
        Me.Author.Location = New System.Drawing.Point(7, 171)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(52, 16)
        Me.Author.TabIndex = 3
        Me.Author.Text = "Author"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(376, 36)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(73, 16)
        Me.lblPublisher.TabIndex = 2
        Me.lblPublisher.Text = "Publisher"
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Location = New System.Drawing.Point(7, 80)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(89, 16)
        Me.lblBookName.TabIndex = 1
        Me.lblBookName.Text = "Book Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(36, 474)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 58)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(204, 20)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 32)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cance&l"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancel to add a book")
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(106, 20)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 32)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear all the field")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(7, 20)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 32)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "&Add Book"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add a book into PU LMS")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.progBarBook, Me.ToolStripSeparator1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(733, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripLabel1.Text = "Your progress:"
        '
        'progBarBook
        '
        Me.progBarBook.Name = "progBarBook"
        Me.progBarBook.Size = New System.Drawing.Size(120, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel2.Text = "Fill the field below"
        '
        'AddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 544)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bookGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add A Book"
        Me.bookGroupBox.ResumeLayout(False)
        Me.bookGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bookGroupBox As GroupBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents Price As Label
    Friend WithEvents year As Label
    Friend WithEvents Author As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents lblBookName As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblISBN As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtPublishYear As TextBox
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents progBarBook As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtDesc As RichTextBox
    Friend WithEvents mskTxtISBN As MaskedTextBox
End Class
