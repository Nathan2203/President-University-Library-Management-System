Imports System.Data.OleDb
Public Class ListBook
    Private Sub ListBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Retrieve()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            listViewBook.Items.Clear()
            Call Retrieve()
        Else
            Dim dt As New DataTable
            listViewBook.Items.Clear()
            dt = SearchBook(txtSearch.Text)
            For Each row In dt.Rows
                Call Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(8))
            Next
            dt.Rows.Clear()
            conn.Close()
            dr.Close()
        End If
    End Sub

    Dim id As String
    Private Sub listViewBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewBook.SelectedIndexChanged
        For i As Integer = 0 To listViewBook.Items.Count - 1
            If listViewBook.Items(i).Selected = True Then
                id = listViewBook.Items(i).SubItems(0).Text
            End If
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure want to delete it?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LibraryFunction.DeleteBook(id)
            listViewBook.Items.Clear()
            Call Retrieve()
        End If
    End Sub
    Private Sub Retrieve()
        Dim dt As New DataTable
        dt = LibraryFunction.ShowBook(3)
        For Each row In dt.Rows
            Call Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(8))
        Next
        dt.Rows.Clear()
    End Sub
    Private Sub Populate(isbn As String, name As String, author As String, genre As String, publisher As String, publishYear As Integer, stat As String)
        'Row Array
        Dim row As String() = New String() {isbn, name, author, genre, publisher, publishYear, stat}
        Dim item As ListViewItem = New ListViewItem(row)

        'Add rows to collection
        listViewBook.Items.Add(item)
    End Sub
    Private Function SearchBook(ByVal input As String) As DataTable
        Call Connection()
        cmd = New OleDbCommand("Select * From Tbl_Book Where Book_Name Like '%" & txtSearch.Text & "%' 
                                OR Book_Author Like '%" & txtSearch.Text & "%' OR Book_Genre Like '%" & txtSearch.Text & "%' 
                                OR Book_Publish_Year Like '%" & txtSearch.Text & "%' Order By Book_Name", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            da = New OleDbDataAdapter("Select * From Tbl_Book Where Book_Name Like '%" & txtSearch.Text & "%'
                                       OR Book_Author Like '%" & txtSearch.Text & "%' OR Book_Genre Like '%" & txtSearch.Text & "%' 
                                       OR Book_Publish_Year Like '%" & txtSearch.Text & "%' Order By Book_Name", conn)
            ds = New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Else
            MsgBox("Data was not found!", MessageBoxIcon.Error)
            Return LibraryFunction.ShowUser()
        End If
    End Function
End Class