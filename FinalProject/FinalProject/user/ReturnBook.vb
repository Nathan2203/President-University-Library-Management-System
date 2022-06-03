Imports System.Data.OleDb
Public Class ReturnBook
    Dim id As String
    Private Sub ReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Retrieve()
    End Sub
    Private Sub Retrieve()
        Dim dt As New DataTable
        Call Connection()
        cmd = New OleDbCommand("SELECT * FROM Tbl_Book WHERE [Student_ID] = '" & userForm.lblIDStud.Text & "'", conn)
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        conn.Close()
        dr.Close()
        For Each row In dt.Rows
            Call PopulateRented(row(0), row(1), row(3), row(2), row(7))
        Next
        dt.Rows.Clear()
    End Sub
    Private Sub PopulateRented(isbn As String, book_name As String, genre As String, author As String, desc As String)
        'Row Array
        Dim row As String() = New String() {isbn, book_name, genre, author, desc}
        Dim item As ListViewItem = New ListViewItem(row)

        'Add rows to collection
        rentedBookListView.Items.Add(item)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rentedBookListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rentedBookListView.SelectedIndexChanged
        For i As Integer = 0 To rentedBookListView.Items.Count - 1
            If rentedBookListView.Items(i).Selected = True Then
                id = rentedBookListView.Items(i).SubItems(0).Text
            End If
        Next
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        LibraryFunction.ReturnBook(id)
        rentedBookListView.Items.Clear()
        Me.Retrieve()
    End Sub
End Class