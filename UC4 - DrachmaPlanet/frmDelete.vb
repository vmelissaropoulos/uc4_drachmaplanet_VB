Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication.requests
Imports com.uc4.communication.requests.FolderList
Imports com.uc4.communication.requests.FolderTree

Public Class frmDelete

    Private Sub frmDelete_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        saveForm(Me)
    End Sub

    Private Sub frmDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadForm(Me)
    End Sub

    Private Sub btnBrowseFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFrom.Click
        populateTreeView(frmSelectFolder.tvSelectFolder, getAllFolders(True, MDIParent1.myConnection))
        frmSelectFolder.ShowDialog(Me)
        txtPFolder.Text = MDIParent1.selectedFolder
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("You are about to delete all empty folders under selected path [" + txtPFolder.Text + "]" _
                  + vbCrLf + vbCrLf + "Are you sure?", vbYesNo + MsgBoxStyle.Exclamation, "Delete Confirmation") = MsgBoxResult.No _
        Then Exit Sub

        MDIParent1.Cursor = Cursors.WaitCursor
        Dim con As com.uc4.communication.Connection = MDIParent1.myConnection
        LOG("Deleting empty folders under path [" + txtPFolder.Text + "]...", True)
        Dim pFolder As IFolder = pathToIFolder(txtPFolder.Text, con)

        Dim foldersUnderPath As List(Of IFolder)
        If Not chkAlsoDeleteObjects.Checked Then
            foldersUnderPath = getFoldersRecursively(pFolder, True, con)

            Dim emptyFoldersUnderPath As New List(Of IFolder)
            For Each folder As IFolder In foldersUnderPath
                If isFolderEmpty(folder, con) Then
                    emptyFoldersUnderPath.Add(folder)
                    LOG(folder.fullPath)
                End If
            Next

            If MsgBox("This is the last confirmation. Check the list in log and confirm the folders for deletion." _
                      + vbCrLf + vbCrLf + "Are you sure?", vbYesNo + MsgBoxStyle.Exclamation, "Delete Confirmation") = MsgBoxResult.No _
            Then
                MDIParent1.Cursor = Cursors.Arrow
                Exit Sub
            End If


            For Each folder As IFolder In emptyFoldersUnderPath
                Try
                    Dim delete As DeleteObject = New DeleteObject(folder)
                    con.sendRequestAndWait(delete)

                    If Not delete.getMessageBox Is Nothing Then
                        LOG("DELETE Warning: " + folder.fullPath + "  __[Reason: " + delete.getMessageBox.getText + "]__")
                    End If
                Catch ex As Exception
                    LOG(ex.Message)
                End Try
            Next
        Else
            foldersUnderPath = getFoldersRecursively(pFolder, True, con)

            Dim objectsUnderPath As New List(Of String)
            For Each folder As IFolder In foldersUnderPath
                objectsUnderPath.AddRange(fetchAllObjectsInFolder(folder.fullPath, False, con))
            Next

            Dim myList As String = ""
            For Each obj As String In objectsUnderPath
                myList += obj + vbCrLf
            Next
            LOG(myList)

            If MsgBox("This is the last confirmation. Check the list in log and confirm the objects for deletion." _
                      + vbCrLf + vbCrLf + "Are you sure?", vbYesNo + MsgBoxStyle.Exclamation, "Delete Confirmation") = MsgBoxResult.No _
            Then Exit Sub

            For Each obj As String In objectsUnderPath
                Dim delete As DeleteObject = New DeleteObject(New UC4ObjectName(obj))
                con.sendRequestAndWait(delete)

                If Not delete.getMessageBox Is Nothing Then
                    LOG("DELETE Warning: " + obj + "  __[Reason: " + delete.getMessageBox.getText + "]__")
                Else
                    LOG("DELETE OK: " + obj)
                End If
            Next



        End If




        LOG("Finished...", True)
        MDIParent1.Cursor = Cursors.Arrow
    End Sub

End Class