Imports System.Runtime.InteropServices
Public Class userForm

#Region "FUNCTIONALITIES OF THE FORM"
    'RESIZE OF THE FORM- CHANGE SIZE
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DRAW RECTANGLE / EXCLUDE CORNER PANEL
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContainer.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR AND GRIP OF LOWER RECTANGLE/CORNER
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(67, 81, 120))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    'DRAG / MOVE THE FORM
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub titleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles titleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

#Region "OPEN FORM METHODS"
    Private Sub openFormOnPanel(Of Myform As {Form, New})()
        Dim Formula As Form
        Formula = Panel3.Controls.OfType(Of Myform)().FirstOrDefault()
        If Formula Is Nothing Then
            Formula = New Myform()
            Formula.TopLevel = False
            Formula.FormBorderStyle = FormBorderStyle.None
            Formula.Dock = DockStyle.None
            Panel3.Controls.Add(Formula)
            Panel3.Tag = Formula
            AddHandler Formula.FormClosed, AddressOf Me.closedForm
            Formula.BringToFront()
            Formula.Show()
        Else
            Formula.BringToFront()
        End If
    End Sub
    Private Sub closedForm(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("UserProfile") Is Nothing) Then
            btnViewProfile.BackColor = Color.FromArgb(46, 59, 104)
        End If
        If (Application.OpenForms("ReturnBook") Is Nothing) Then
            btnReturn.BackColor = Color.FromArgb(46, 59, 104)
        End If
        If (Application.OpenForms("RentBook") Is Nothing) Then
            btnRent.BackColor = Color.FromArgb(46, 59, 104)
        End If
        If (Application.OpenForms("AboutForm") Is Nothing) Then
            btnAbout.BackColor = Color.FromArgb(46, 59, 104)
        End If
    End Sub
#End Region

#Region "Close Form, Minimize Form, Logout Form"
    Private Sub exitPictureBox_Click(sender As Object, e As EventArgs) Handles exitPictureBox.Click
        If MessageBox.Show("Are you sure want to close the application?", "Warning",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub minimizePictureBox_Click(sender As Object, e As EventArgs) Handles minimizePictureBox.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure want to log out?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub
#End Region


    Private Sub lblIDStud_Click(sender As Object, e As EventArgs) Handles lblIDStud.Click
        MsgBox(lblIDStud.Text)
    End Sub

    Private Sub btnRent_Click_1(sender As Object, e As EventArgs) Handles btnRent.Click
        openFormOnPanel(Of RentBook)()
        btnRent.BackColor = Color.FromArgb(55, 70, 125)
    End Sub

    Private Sub btnReturn_Click_1(sender As Object, e As EventArgs) Handles btnReturn.Click
        openFormOnPanel(Of ReturnBook)()
        btnReturn.BackColor = Color.FromArgb(55, 70, 125)
    End Sub

    Private Sub btnViewProfile_Click_1(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        openFormOnPanel(Of UserProfile)()
        btnViewProfile.BackColor = Color.FromArgb(55, 70, 125)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        openFormOnPanel(Of AboutForm)()
        btnAbout.BackColor = Color.FromArgb(55, 70, 125)
    End Sub
End Class