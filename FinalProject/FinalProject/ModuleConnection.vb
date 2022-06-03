Imports System.Data.OleDb
Module ModuleConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet

    Sub Connection()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PULibrary.mdb;Persist Security Info=False;")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            'MsgBox("Sukses")
        End If
    End Sub
End Module
