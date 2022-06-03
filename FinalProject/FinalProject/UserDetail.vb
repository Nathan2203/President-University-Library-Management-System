Imports System.Data.OleDb
Public Class UserDetail
    Dim id As String
    Private Sub UserDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGridUser.DataSource = LibraryFunction.ShowUser()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            dataGridUser.DataSource = LibraryFunction.ShowUser()
        Else
            dataGridUser.DataSource = SearchUser(txtSearch.Text)
            conn.Close()
            dr.Close()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure want to delete it?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LibraryFunction.DeleteUser(id)
            dataGridUser.DataSource = LibraryFunction.ShowUser()
        End If
    End Sub
    Private Sub dataGridUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridUser.CellClick
        Dim i As Integer
        i = dataGridUser.CurrentRow.Index
        id = dataGridUser.Item(0, i).Value
    End Sub
    Private Function SearchUser(ByVal input As String) As DataTable

        Call Connection()
        cmd = New OleDbCommand("Select * From Tbl_User Where Name Like '%" & input & "%' OR 
                                Major Like '%" & input & "%' OR Email Like '%" & input & "%' OR Batch Like '%" & input & "%' OR
                                Gender Like '%" & input & "%'", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            da = New OleDbDataAdapter("Select * From Tbl_User Where Name Like '%" & input & "%' OR 
                                Major Like '%" & input & "%' OR Email Like '%" & input & "%' OR Batch Like '%" & input & "%' OR
                                Gender Like '%" & input & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Else
            MsgBox("Data was not found!", MessageBoxIcon.Error)
            Return LibraryFunction.ShowUser()
        End If
    End Function

    'Call koneksi()
    'Dim hapus As String = "delete from tbl_pegawai where nip='" & textbox1.text & "'"
    '        cmd = New sqlcommand(hapus, conn)
    '        cmd.executenonquery()
    '        msgbox("data berhasil di hapus", msgboxstyle.information, "information")
    '        Call kondisiawal()
    'End If
End Class