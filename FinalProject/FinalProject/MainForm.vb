Public Class MainForm
    Private Sub AddABookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddABookToolStripMenuItem.Click
        AddBook.MdiParent = Me
        AddBook.Show()
    End Sub
    Private Sub ViewBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBooksToolStripMenuItem.Click
        ListBook.MdiParent = Me
        ListBook.Show()
    End Sub
    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        AddUser.MdiParent = Me
        AddUser.Show()
    End Sub
    Private Sub ViewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUserToolStripMenuItem.Click
        UserDetail.MdiParent = Me
        UserDetail.Show()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        Dim child As Form
        For Each child In MdiChildren
            child.Close()
        Next
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
    Private Sub AllRentedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllRentedToolStripMenuItem.Click
        StatusBook.MdiParent = Me
        StatusBook.Show()
    End Sub

    Private Sub UploadAnImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadAnImageToolStripMenuItem.Click
        With mainOpenFileDialog
            .FileName = ""
            .Filter = ".jpg|*.jpg|.png|*.png|.gif|*.gif|.bmp|*.bmp"
        End With
        If mainOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            UploadAnImageToolStripMenuItem.Checked = True
            Dim BackFile As String
            BackFile = mainOpenFileDialog.FileName
            Me.BackgroundImage = Image.FromFile(BackFile)
            My.Settings.MainImage = BackFile
            My.Settings.Save()
        End If
    End Sub

    Private Sub aboutToolStripSplitButton_ButtonClick(sender As Object, e As EventArgs) Handles aboutToolStripSplitButton.ButtonClick
        MsgBox("This project is brought to you by" & vbCrLf & "Jonathan Benedict Sirait" & vbCrLf & "IT 3 2019", MessageBoxIcon.Information)
    End Sub
End Class