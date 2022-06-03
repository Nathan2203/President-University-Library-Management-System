Public Class AddUser
    Dim major(15) As String
    Dim i As Integer
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddMajor(major)
        For i = 0 To 15
            cmbMajor.Items.Add(major(i))
        Next
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If ValidateInput() Then
            Dim gender As String
            If rdGender1.Checked = True Then
                gender = "Male"
                progBarInput.Value = progBarInput.Value + 10
            ElseIf rdGender2.Checked = True Then
                gender = "Female"
                progBarInput.Value = progBarInput.Value + 10
            End If
            LibraryFunction.AddUser(txtID.Text, txtName.Text, cmbMajor.SelectedItem, numUpDownBatch.Value, txtEmail.Text, txtPassword.Text,
                                    maskedtxtPhoneNumber.Text, gender, dtpActvDate.Value.Date, dtpValidTill.Value.Date, txtAddress.Text)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call ClearField()
    End Sub

    Private Sub ClearField()
        txtID.Clear()
        txtName.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        cmbMajor.SelectedIndex = -1
        txtAddress.Clear()
        maskedtxtPhoneNumber.Clear()
        dtpActvDate.ResetText()
        dtpValidTill.ResetText()
        For i As Integer = 0 To eulaCheckedListBox.Items.Count - 1
            eulaCheckedListBox.SetItemChecked(i, False)
        Next
        progBarInput.Value = 0
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
        If txtID.Text = "" Then
            MsgBox("Please input the Student ID!", MessageBoxIcon.Warning)
        ElseIf txtName.Text = "" Then
            MsgBox("Please input the Name!", MessageBoxIcon.Warning)
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please input the Email!", MessageBoxIcon.Warning)
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please input the Password!", MessageBoxIcon.Warning)
        ElseIf cmbMajor.SelectedIndex = -1 Then
            MsgBox("Please select the Major!", MessageBoxIcon.Warning)
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please input the Address!", MessageBoxIcon.Warning)
        ElseIf maskedtxtPhoneNumber.Text.Length < 12 Then
            MsgBox("Please input the right format for Phone Number!", MessageBoxIcon.Warning)
        ElseIf dtpActvDate.Value = dtpValidTill.Value Then
            MsgBox("The period of activation should not less than 4 year!", MessageBoxIcon.Warning)
        ElseIf eulaCheckedListBox.CheckedItems.Count = 0 Then
            MsgBox("Please check the EULA!", MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function

    'Increase the Progress Bar, when the control is leaved
    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub cmbMajor_Leave(sender As Object, e As EventArgs) Handles cmbMajor.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub numUpDownBatch_Leave(sender As Object, e As EventArgs) Handles numUpDownBatch.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub txtAddress_Leave(sender As Object, e As EventArgs) Handles txtAddress.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub maskedtxtPhoneNumber_Leave(sender As Object, e As EventArgs) Handles maskedtxtPhoneNumber.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub dtpActvDate_Leave(sender As Object, e As EventArgs) Handles dtpActvDate.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub dtpValidTill_Leave(sender As Object, e As EventArgs) Handles dtpValidTill.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
    Private Sub eulaCheckedListBox_Leave(sender As Object, e As EventArgs) Handles eulaCheckedListBox.Leave
        progBarInput.Value = progBarInput.Value + 10
    End Sub
End Class