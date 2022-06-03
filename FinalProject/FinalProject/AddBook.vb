Public Class AddBook
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateInput() Then
            Dim status As String = "Available"
            progBarBook.Value = progBarBook.Value + 4
            LibraryFunction.AddBook(mskTxtISBN.Text, txtBookName.Text, txtAuthor.Text, txtGenre.Text, txtPublisher.Text,
                                    txtPublishYear.Text, txtPrice.Text, txtDesc.Text, status)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call ClearField()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Function ValidateInput() As Boolean
        If mskTxtISBN.Text = "" Then
            MsgBox("Please input the ISBN!", MessageBoxIcon.Warning)
        ElseIf txtBookName.Text = "" Then
            MsgBox("Please input the Book Name!", MessageBoxIcon.Warning)
        ElseIf txtGenre.Text = "" Then
            MsgBox("Please input the Genre!", MessageBoxIcon.Warning)
        ElseIf txtAuthor.Text = "" Then
            MsgBox("Please input the Author!", MessageBoxIcon.Warning)
        ElseIf txtPublisher.Text = "" Then
            MsgBox("Please input the Publisher!", MessageBoxIcon.Warning)
        ElseIf txtPublishYear.Text = "" Then
            MsgBox("Please input the Publish Year!", MessageBoxIcon.Warning)
        ElseIf txtPrice.Text = "" Then
            MsgBox("Please input the Price!", MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub ClearField()
        txtDesc.Clear()
        txtGenre.Clear()
        txtPrice.Clear()
        txtBookName.Clear()
        txtPublisher.Clear()
        mskTxtISBN.Clear()
        txtAuthor.Clear()
        txtPublishYear.Clear()
        progBarBook.Value = 0
    End Sub

    Private Sub txtBookName_Leave(sender As Object, e As EventArgs) Handles txtBookName.Leave
        progBarBook.Value = progBarBook.Value + 12
    End Sub
    Private Sub txtGenre_Leave(sender As Object, e As EventArgs) Handles txtGenre.Leave
        progBarBook.Value = progBarBook.Value + 12
    End Sub
    Private Sub txtAuthor_Leave(sender As Object, e As EventArgs) Handles txtAuthor.Leave
        progBarBook.Value = progBarBook.Value + 12
    End Sub
    Private Sub txtPublisher_Leave(sender As Object, e As EventArgs) Handles txtPublisher.Leave
        progBarBook.Value = progBarBook.Value + 12
    End Sub
    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        progBarBook.Value = progBarBook.Value + 12
    End Sub
    Private Sub txtPublishYear_Leave(sender As Object, e As EventArgs) Handles txtPublishYear.Leave
        progBarBook.Value = progBarBook.Value + 12
    End Sub
    Private Sub txtDesc_Leave_1(sender As Object, e As EventArgs) Handles txtDesc.Leave
        progBarBook.Value = progBarBook.Value + 12
    End Sub

    Private Sub mskTxtISBN_Leave(sender As Object, e As EventArgs) Handles mskTxtISBN.Leave
        progBarBook.Value = progBarBook.Value + 12
    End Sub
End Class