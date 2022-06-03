Public Class CustomerAdd
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim name, email, password, gender As String
        name = Val(txtName.Text)
        email = Val(txtEmail.Text)
        password = Val(txtPassword.Text)

        If txtName.Text = "" Or txtEmail.Text = "" Or txtPassword.Text = "" Or gender1.Checked = False Or gender2.Checked = False Then
            MsgBox("Please fill the required filled")
        Else
            If gender1.Checked = True Then
                gender = "Male"
            ElseIf gender2.Checked = True Then
                gender = "Female"
            End If

            MsgBox("Success add user")
        End If
    End Sub

End Class