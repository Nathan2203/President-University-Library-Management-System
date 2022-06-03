Public Class BookForm
    Private Sub bookTree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles bookTree.AfterSelect
        If bookTree.SelectedNode.Name = "nodeAdd" Then
            AddBook.MdiParent = Me
            AddBook.Show()
            AddBook.BringToFront()
        ElseIf bookTree.SelectedNode.Name = "nodeList" Then
            ListBook.MdiParent = Me
            ListBook.Show()
            ListBook.BringToFront()
        End If
    End Sub
End Class