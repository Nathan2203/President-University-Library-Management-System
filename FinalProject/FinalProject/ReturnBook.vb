Public Class ReturnBook
    Dim id As Integer
    Dim name As String
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        id = Val(txtBookID.Text)
        If txtBookID.Text = "" Then
            MsgBox("Please input the book id")
        Else
            MsgBox("Searching the book")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBookID.Clear()
    End Sub
End Class