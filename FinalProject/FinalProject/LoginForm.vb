Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username, password As String
        username = txtUsername.Text
        password = txtPassword.Text

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please input the missing field", MessageBoxIcon.Warning)
        Else
            If username = "adminPU" And password = "PUadmin" Then
                MsgBox("Login successfully!")
                Me.Hide()
                Dim loading As New Loading()
                loading.Show()
                loading.Text = "Welcome, Admin."
            Else
                Call Connection()
                cmd = New OleDbCommand("SELECT * FROM Tbl_User WHERE [Email] = '" & username & "' AND [Password] = '" & password & "'", conn)
                dr = cmd.ExecuteReader
                If (dr.Read() = True) Then
                    Me.Hide()
                    Dim loading As New Loading()
                    loading.Show()
                    loading.Text = "Welcome, " & dr("Name")
                    userForm.lblUsername.Text = dr("Name")
                    userForm.lblIDStud.Text = dr("Student_ID")
                    dr.Close()
                    conn.Close()
                Else
                    MsgBox("You've inputted wrong Username or Password! Please try again!", MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

#Region "Customize Controls"
    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub
    Private Sub btnClear_Paint(sender As Object, e As PaintEventArgs) Handles btnClear.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnClear.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnClear.Region = New Region(buttonPath)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
    Private Sub chkBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxShowPass.CheckedChanged
        If chkBoxShowPass.CheckState = CheckState.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
#End Region

#Region "Close and Minimize Form"
    Private Sub pictExit_Click(sender As Object, e As EventArgs) Handles pictExit.Click
        If MessageBox.Show("Are you sure want to close the application?", "Warning",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub pictMinimize_Click(sender As Object, e As EventArgs) Handles pictMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form - Arrastrar/ mover Formulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub FormLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region
End Class