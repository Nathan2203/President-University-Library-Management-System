Public Class CustomersDetail
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Dim id As Integer
        id = Val(userId.Text)
        If userId.Text = "" Then
            MsgBox("Search all user")
        Else
            MsgBox("Search one user")
        End If
    End Sub
End Class