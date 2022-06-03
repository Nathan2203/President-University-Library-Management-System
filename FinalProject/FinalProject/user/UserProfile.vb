Imports System.Data.OleDb
Public Class UserProfile
    Dim major(15) As String
    Dim currentPass As String
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddMajor(major)
        For i As Integer = 0 To 15
            cmbMajorEdit.Items.Add(major(i))
        Next
        Call LoadUserData()
        Call InitializeControlsPass()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateInput() = True Then
            LibraryFunction.EditUser(userForm.lblIDStud.Text, txtEmail.Text, txtPassword.Text,
                                     cmbMajorEdit.Text, maskedtxtPhoneNumber.Text, txtAddress.Text)
            ShowUpdate()
            Call Reset()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call Reset()
    End Sub
    Private Sub linkEditPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkEditPass.LinkClicked
        If linkEditPass.Text = "Edit" Then
            linkEditPass.Text = "Cancel"
            lblConfimPass.Visible = True
            txtPassword.Enabled = True
            txtPassword.Text = ""
            txtConfirmPass.Text = ""
            txtConfirmPass.Visible = True
        ElseIf linkEditPass.Text = "Cancel" Then
            'Restart only in edit password
            linkEditPass.Text = "Edit"
            lblConfimPass.Visible = False
            txtPassword.Text = currentPass
            txtConfirmPass.Text = currentPass
            txtPassword.Enabled = False
            txtConfirmPass.Visible = False
        End If
    End Sub
    Private Sub linkEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkEdit.LinkClicked
        Call LoadUserData()
        Panel1.Width = 10
        Panel1.Visible = True
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.Width += 20
        If Panel1.Width >= 400 Then
            Timer1.Stop()
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub Reset()
        Call InitializeControlsPass()
        Call LoadUserData()
    End Sub
    Private Sub LoadUserData()
        Dim dt As New DataTable
        Call Connection()
        cmd = New OleDbCommand("SELECT * FROM Tbl_User WHERE [Student_ID] = '" & userForm.lblIDStud.Text & "'", conn)
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        conn.Close()
        dr.Close()
        For Each row In dt.Rows
            lblID.Text = row(0)
            lblName.Text = row(1)
            lblMajor.Text = row(2)
            lblBatch.Text = row(3)
            lblEmail.Text = row(4)
            cmbMajorEdit.Text = row(2)
            txtEmail.Text = row(4)
            txtPassword.Text = row(5)
            maskedtxtPhoneNumber.Text = row(6)
            txtAddress.Text = row(10)
            currentPass = row(5)
        Next
    End Sub
    Private Sub InitializeControlsPass()
        Panel1.Visible = False
        linkEditPass.Text = "Edit"
        lblConfimPass.Visible = False
        txtPassword.UseSystemPasswordChar = True
        txtPassword.Enabled = False
        txtConfirmPass.UseSystemPasswordChar = True
        txtConfirmPass.Visible = False
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
        If cmbMajorEdit.SelectedIndex = -1 Then
            MsgBox("Please input the Major!", MessageBoxIcon.Warning)
        ElseIf maskedtxtPhoneNumber.Text.Length < 12 Then
            MsgBox("Please input the right format for Phone Number!", MessageBoxIcon.Warning)
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please input the Email!", MessageBoxIcon.Warning)
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please input the Password!", MessageBoxIcon.Warning)
        ElseIf txtConfirmPass.Text = "" Or Not txtPassword.Text.Length = txtConfirmPass.Text.Length Then
            MsgBox("Please confirm the Password!", MessageBoxIcon.Warning)
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please input the Address!", MessageBoxIcon.Warning)
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
End Class