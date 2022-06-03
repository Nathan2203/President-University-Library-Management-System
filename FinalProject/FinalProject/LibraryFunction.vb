Imports System.Data.OleDb
Public Class LibraryFunction
    Shared Function ShowUser() As DataTable
        Dim dt As New DataTable
        Call Connection()
        cmd = New OleDbCommand("SELECT * FROM Tbl_User ORDER BY Name", conn)
        dr = cmd.ExecuteReader()
        dt.Load(dr)
        conn.Close()
        dr.Close()
        Return dt
    End Function
    Shared Sub AddUser(_id, _name, _major, _batch, _email, _pwd, _phoneNum, _gender, _actDate, _valdTill, _addr)
        Call Connection()
        cmd = New OleDbCommand("INSERT INTO Tbl_User VALUES ('" & _id & "','" & _name & "','" & _major & "','" & _batch & "',
                        '" & _email & "','" & _pwd & "','" & _phoneNum & "','" & _gender & "','" & _actDate & "','" & _valdTill & "',
                        '" & _addr & "')", conn)
        If cmd.ExecuteNonQuery() Then MsgBox("New user has been inputted!", MessageBoxIcon.Information)
        conn.Close()
    End Sub
    Shared Sub DeleteUser(_id)
        Call Connection()
        cmd = New OleDbCommand("DELETE * FROM Tbl_User WHERE Student_ID ='" & _id & "'", conn)
        If cmd.ExecuteNonQuery() Then MsgBox("Selected user has been deleted!", MessageBoxIcon.Information)
        conn.Close()
    End Sub
    Shared Sub EditUser(_id, _email, _pwd, _major, _phoneNum, _addr)
        Call Connection()
        cmd = New OleDbCommand("UPDATE [Tbl_User] SET [Email] ='" & _email & "', [Password] ='" & _pwd & "', [Major] ='" & _major & "', 
                            [Phone_Num] ='" & _phoneNum & "', [Address] ='" & _addr & "' WHERE [Student_ID] ='" & _id & "'", conn)
        da = New OleDbDataAdapter(cmd)
        da.UpdateCommand = conn.CreateCommand()
        da.UpdateCommand.CommandText = "UPDATE [Tbl_User] SET [Email] ='" & _email & "', [Password] ='" & _pwd & "', [Major] ='" & _major & "', 
                            [Phone_Num] ='" & _phoneNum & "', [Address] ='" & _addr & "' WHERE [Student_ID] ='" & _id & "'"

        If da.UpdateCommand.ExecuteNonQuery() Then MsgBox("Data has been updated!", MessageBoxIcon.Information)
        conn.Close()
    End Sub

    Shared Function ShowBook(ByVal opt As Integer) As DataTable
        Dim dt As New DataTable
        Call Connection()
        If opt = 1 Then
            cmd = New OleDbCommand("SELECT * FROM Tbl_Book WHERE [Book_Status] = 'Available' ORDER BY Book_Name", conn)
        ElseIf opt = 2 Then
            cmd = New OleDbCommand("SELECT Tbl_Book.[Book_ISBN], Tbl_Book.[Book_Name], Tbl_Book.[Book_Author], Tbl_Book.[Book_Genre], 
              Tbl_User.[Student_ID], Tbl_User.[Name], Tbl_User.[Major], Tbl_User.[Batch] FROM Tbl_Book, Tbl_User 
              WHERE Tbl_Book.[Book_Status] = 'Rented' AND Tbl_Book.[Student_ID] = Tbl_User.[Student_ID] ORDER BY Tbl_Book.[Book_Name]", conn)
        Else
            cmd = New OleDbCommand("SELECT * FROM Tbl_Book ORDER BY Book_Name", conn)
        End If
        da = New OleDbDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Shared Sub AddBook(_id, _name, _author, _genre, _publisher, _publishYear, _price, _desc, _status)
        Call Connection()
        cmd = New OleDbCommand("INSERT INTO Tbl_Book ([Book_ISBN], [Book_Name], [Book_Author], [Book_Genre], [Book_Publisher], [Book_Publish_Year],
                      [Book_Price], [Book_Desc], [Book_Status]) 
                      VALUES ('" & _id & "','" & _name & "','" & _author & "','" & _genre & "',
                      '" & _publisher & "','" & _publishYear & "', '" & _price & "','" & _desc & "', '" & _status & "')", conn)
        If cmd.ExecuteNonQuery() Then MsgBox("New book has been inputted!", MessageBoxIcon.Information)
        conn.Close()
    End Sub
    Shared Sub DeleteBook(_id)
        Call Connection()
        cmd = New OleDbCommand("DELETE * FROM Tbl_Book WHERE Book_ISBN ='" & _id & "'", conn)
        If cmd.ExecuteNonQuery() Then MsgBox("Selected book has been deleted!", MessageBoxIcon.Information)
        conn.Close()
    End Sub
    Shared Sub RentBook(book_id, student_id)
        Call Connection()
        cmd = New OleDbCommand("UPDATE Tbl_Book SET [Book_Status] = 'Rented', [Student_ID] = '" & student_id & "' WHERE Book_ISBN ='" & book_id & "'", conn)
        If cmd.ExecuteNonQuery() Then MsgBox("You have successful rent a book!", MessageBoxIcon.Information)
        conn.Close()
    End Sub
    Shared Sub ReturnBook(book_id)
        Call Connection()
        cmd = New OleDbCommand("UPDATE Tbl_Book SET [Book_Status] = 'Available', [Student_ID] = '' WHERE Book_ISBN ='" & book_id & "'", conn)
        If cmd.ExecuteNonQuery() Then MsgBox("You have successful return a book!", MessageBoxIcon.Information)
        conn.Close()
    End Sub
End Class
