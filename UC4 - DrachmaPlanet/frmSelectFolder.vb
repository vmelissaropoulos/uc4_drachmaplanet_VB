Public Class frmSelectFolder
    Private flag As Boolean = False

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        MDIParent1.selectedFolder = tvSelectFolder.SelectedNode.FullPath
        flag = True
        Me.Close()
    End Sub

    Private Sub frmSelectFolder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If flag = False Then MDIParent1.selectedFolder = ""
    End Sub

    Private Sub frmSelectFolder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        flag = False
    End Sub

    Private Sub tvSelectFolder_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvSelectFolder.AfterSelect
        e.Node.ToolTipText = e.Node.FullPath
    End Sub
End Class