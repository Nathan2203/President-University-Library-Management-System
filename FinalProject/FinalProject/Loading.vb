Public Class Loading
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingTimer.Start()
    End Sub
    Private Sub loadingTimer_Tick(sender As Object, e As EventArgs) Handles loadingTimer.Tick
        If progBarLoading.Value < 100 Then
            progBarLoading.Value = progBarLoading.Value + 10
            lblPercent.Text = Math.Round((progBarLoading.Value / 100) * 100, 2) & "%"
        ElseIf progBarLoading.Value = 100 Then
            If LoginForm.txtUsername.Text = "adminPU" Then
                Call LoadingAdmin()
            Else
                Call LoadingUser()
            End If
        End If
    End Sub
    Private Sub LoadingAdmin()
        loadingTimer.Stop()
        Me.Hide()
        MainForm.Show()
        MsgBox("Loading completed. Welcome Admin!", MessageBoxIcon.Information)
    End Sub
    Private Sub LoadingUser()
        loadingTimer.Stop()
        Me.Hide()
        userForm.Show()
        MsgBox("Loading completed. Welcome User!", MessageBoxIcon.Information)
    End Sub
End Class