Imports System.Data.OleDb
Public Class StatusBook
    Private Sub StatusBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Retrieve("Available")
        Call Retrieve("Rented")
    End Sub
    Private Sub Retrieve(_status)
        Dim dt As New DataTable
        If _status = "Available" Then
            dt = LibraryFunction.ShowBook(1)
            For Each row In dt.Rows
                Call PopulateAvailable(row(0), row(1), row(2), row(3), _status)
            Next
        Else
            dt = LibraryFunction.ShowBook(2)
            For Each row In dt.Rows
                Call PopulateRented(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), _status)
            Next
        End If

        dt.Rows.Clear()
    End Sub
    Private Sub PopulateAvailable(isbn As String, name As String, author As String, genre As String, status As String)
        'Row Array
        Dim row As String() = New String() {isbn, name, author, genre}
        Dim item As ListViewItem = New ListViewItem(row)

        'Add rows to collection
        If status = "Available" Then
            availableStatus.Items.Add(item)
        Else
            rentedStatus.Items.Add(item)
        End If
    End Sub
    Private Sub PopulateRented(isbn As String, book_name As String, author As String, genre As String, id As String, stud_name As String, major As String, batch As String, status As String)
        'Row Array
        Dim row As String() = New String() {isbn, book_name, author, genre, id, stud_name, major, batch}
        Dim item As ListViewItem = New ListViewItem(row)

        'Add rows to collection
        If status = "Available" Then
            availableStatus.Items.Add(item)
        Else
            rentedStatus.Items.Add(item)
        End If
    End Sub
End Class