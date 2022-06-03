Public Class editUser
    Dim major(15) As String
    Dim i As Integer
    Private Sub editUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddMajor(major)
        For i = 0 To 15
            cmbMajorEdit.Items.Add(major(i))
        Next
    End Sub
    Private Sub editUserbtn_Click(sender As Object, e As EventArgs) Handles editUserbtn.Click
        If ValidateInput() = True Then
            profileListBox.Items.Clear()
            LibraryFunction.EditUser(userForm.lblIDStud.Text, txtEmail.Text, txtPassword.Text,
                                     cmbMajorEdit.Text, maskedtxtPhoneNumber.Text, txtAddress.Text)
            Call ClearField()
            ShowUpdate()
        End If
    End Sub
    Private Sub editCancelbtn_Click(sender As Object, e As EventArgs) Handles editCancelbtn.Click
        Me.Close()
    End Sub

    Function AddMajor(ByVal major As String()) As String()
        major(0) = "Accounting"
        major(1) = "Actuarial Science"
        major(2) = "Business Administration"
        major(3) = "Civil Engineering"
        major(4) = "Communication"
        major(5) = "Electrical Engineering"
        major(6) = "Elementary School Teacher Education"
        major(7) = "Environmental Engineering"
        major(8) = "Industrial Engineering"
        major(9) = "Information System"
        major(10) = "Information Technology"
        major(11) = "International Relations"
        major(12) = "Law"
        major(13) = "Management"
        major(14) = "Mechanical Engineering"
        major(15) = "Visual Communication Design"

        Return major
    End Function

    Private Function ValidateInput() As Boolean
        If txtEmail.Text = "" Then
            MsgBox("Please input the Email!", MessageBoxIcon.Warning)
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please input the Password!", MessageBoxIcon.Warning)
        ElseIf cmbMajorEdit.SelectedIndex = -1 Then
            MsgBox("Please input the Major!", MessageBoxIcon.Warning)
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please input the Address!", MessageBoxIcon.Warning)
        ElseIf maskedtxtPhoneNumber.Text.Length < 12 Then
            MsgBox("Please input the right format for Phone Number!", MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub ClearField()
        txtEmail.Clear()
        txtPassword.Clear()
        txtAddress.Clear()
        maskedtxtPhoneNumber.Clear()
        cmbMajorEdit.SelectedIndex = -1
    End Sub
    Private Sub ShowUpdate()
        profileListBox.Items.Add("Data has been updated!")
        profileListBox.Items.Add("List of updated data:")
        profileListBox.Items.Add("Email: " & txtEmail.Text)
        profileListBox.Items.Add("Password: " & txtPassword.Text)
        profileListBox.Items.Add("Major: " & cmbMajorEdit.Text)
        profileListBox.Items.Add("Phone Number: " & maskedtxtPhoneNumber.Text)
        profileListBox.Items.Add("Address: " & vbCrLf & txtAddress.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        ShowUpdate()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class