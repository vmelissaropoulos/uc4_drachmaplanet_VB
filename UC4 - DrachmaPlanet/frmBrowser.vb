Imports com.uc4.api
Imports com.uc4.communication
Imports com.uc4.communication.requests
Imports com.uc4.api.objects


Public Class frmBrowser
    Private myListView As New ListView

    Private Sub tvAllFolders_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvAllFolders.AfterSelect
        lstCurrentFolderContents.Items.Clear()
        Dim ifolder As IFolder = pathToIFolder(e.Node.FullPath, MDIParent1.myConnection)
        Dim objectsList As FolderList = getFolderContents(ifolder, MDIParent1.myConnection)
        Dim it As java.util.Iterator = objectsList.iterator
        While it.hasNext
            Dim item As FolderListItem = it.next
            If Not item.getType = "Folder" Then
                lstCurrentFolderContents.Items.Add(item.getName)
            End If
        End While
    End Sub

    Private Sub btnAddToActionList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToActionList.Click

        For Each item As String In lstCurrentFolderContents.SelectedItems
            Dim found As Boolean = False
            If lstObjectsToApplyActions.Items.Count > 0 Then
                For x As Integer = 0 To lstObjectsToApplyActions.Items.Count - 1
                    If lstObjectsToApplyActions.Items.Item(x).ToString = item Then
                        found = True
                    End If
                Next
            End If

            If found = False Then lstObjectsToApplyActions.Items.Add(item)
        Next

    End Sub

    Private Sub btnRemoveFromActionList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFromActionList.Click
        'MsgBox(lstObjectsToApplyActions.SelectedItems.Count.ToString)
        While lstObjectsToApplyActions.SelectedItems.Count > 0
            lstObjectsToApplyActions.Items.Remove(lstObjectsToApplyActions.SelectedItem)
        End While
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim listViewIt As List(Of ListViewItem) = Nothing
        For x As Integer = 0 To lstObjectsToApplyActions.Items.Count - 1
            Dim item As New ListViewItem({lstObjectsToApplyActions.Items.Item(x).ToString, Nothing})
            item.Checked = True
            myListView.Items.Add(item)
        Next
        setListViewColWidth(myListView, 410)
        frmRename.txtRegexSample.Text = myListView.Items.Item(0).SubItems(0).Text
        Me.Close()
    End Sub

    Private Sub lstCurrentFolderContents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCurrentFolderContents.SelectedIndexChanged
        lblCurentCount.Text = "Selected: " + lstCurrentFolderContents.SelectedItems.Count.ToString
    End Sub

    Private Sub lstObjectsToApplyActions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstObjectsToApplyActions.SelectedIndexChanged
        lblActionCount.Text = "Selected: " + lstObjectsToApplyActions.SelectedItems.Count.ToString
    End Sub

    Private Sub frmBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Me.Tag
            Case "frmRename"
                myListView = frmRename.lvPreview
        End Select
    End Sub

End Class