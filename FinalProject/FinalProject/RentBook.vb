Imports System.Data.OleDb
Public Class RentBook
    Dim id As String
    Private Sub RentBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Retrieve()
    End Sub
    Private Sub Retrieve()
        Dim dt As New DataTable
        dt = LibraryFunction.ShowBook(1)
        For Each row In dt.Rows
            Call Populate(row(0), row(1), row(3), row(2), row(7))
        Next
        dt.Rows.Clear()
    End Sub
    Private Sub Populate(isbn As String, name As String, genre As String, author As String, desc As String)
        'Row Array
        Dim row As String() = New String() {isbn, name, genre, author, desc}
        Dim item As ListViewItem = New ListViewItem(row)

        'Add rows to collection
        availableBookListView.Items.Add(item)
    End Sub
    Private Sub btnRentBook_Click(sender As Object, e As EventArgs) Handles btnRentBook.Click
        'Dim tanggal As DateTime
        'tanggal = System.DateTime.Now.ToString("mm/dd/yyyy")
        'tanggal = tanggal.AddDays(7)
        'MsgBox(tanggal)
        LibraryFunction.RentBook(id, userForm.lblIDStud.Text)
        availableBookListView.Items.Clear()
        Me.Retrieve()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call ClearField()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub availableBookListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles availableBookListView.SelectedIndexChanged
        For i As Integer = 0 To availableBookListView.Items.Count - 1
            If availableBookListView.Items(i).Selected = True Then
                id = availableBookListView.Items(i).SubItems(0).Text
            End If
        Next
        Dim dt As New DataTable
        Call Connection()
        cmd = New OleDbCommand("SELECT * FROM Tbl_Book WHERE [Book_ISBN] = '" & id & "'", conn)
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        conn.Close()
        dr.Close()
        For Each row In dt.Rows
            txtISBN.Text = row(0)
            txtName.Text = row(1)
            txtAuthor.Text = row(2)
            txtGenre.Text = row(3)
            txtPublisher.Text = row(4)
            txtPublishYear.Text = row(5)
            txtPrice.Text = row(6)
            txtDescription.Text = row(7)
        Next
    End Sub
    Private Sub ClearField()
        txtISBN.Clear()
        txtName.Clear()
        txtAuthor.Clear()
        txtGenre.Clear()
        txtPublisher.Clear()
        txtPublishYear.Clear()
        txtPrice.Clear()
        txtDescription.Clear()
    End Sub

End Class