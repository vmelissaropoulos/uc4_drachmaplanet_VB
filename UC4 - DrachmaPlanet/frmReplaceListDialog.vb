Public Class frmReplaceListDialog

    Public Sub populateListView(ByVal item As ListViewItem)
        lvRenameList.Items.Add(item)
    End Sub

    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        Me.Close()
    End Sub

    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        If MsgBox("Are you sure to perform the mass rename action?" + vbCrLf + "Rolling back the changes requires manual actions!", vbYesNo + vbInformation, "Confirmation") = vbYes Then
            Dim myUC4Objects As New Hashtable
            Dim myObjectName As DictionaryEntry

            For x As Integer = 0 To lvRenameList.Items.Count - 1
                myUC4Objects.Add(lvRenameList.Items.Item(x).SubItems(0).Text, lvRenameList.Items.Item(x).SubItems(1).Text)
            Next

            LOG(renameInProccessTab(myUC4Objects, myObjectName))

            'For Each oldObjectName In myUC4Objects
            '    LOG("RENAME: " + myObjectName.Key + " _to_ " + myObjectName.Value)
            '    Dim renameResult As String = renameObject(myObjectName.Key, myObjectName.Value, True, MDIParent1.myConnection)
            '    LOG(renameResult)

            '    If renameResult.Contains("ERROR:") Then
            '        lvRenameList.Items(x).SubItems(2).Text = "ERROR! Check Log.."
            '    ElseIf renameResult.Contains("RENAMED_OK:") Then
            '        lvRenameList.Items(x).SubItems(2).Text = "Success"
            '    Else
            '        lvRenameList.Items(x).SubItems(2).Text = "N/A! Check Log.."
            '    End If
            'Next

            'For x As Integer = 0 To lvRenameList.Items.Count - 1

            '    'MsgBox(lvRenameList.Items.Item(x).SubItems(0).Text + " - " + lvRenameList.Items.Item(x).SubItems(1).Text)
            '    LOG("RENAME: " + lvRenameList.Items.Item(x).SubItems(0).Text + " _to_ " + lvRenameList.Items.Item(x).SubItems(1).Text)
            '    Dim renameResult As String = renameObject(lvRenameList.Items.Item(x).SubItems(0).Text, lvRenameList.Items.Item(x).SubItems(1).Text, True, MDIParent1.myConnection)
            '    LOG(renameResult)

            '    If renameResult.Contains("ERROR:") Then
            '        lvRenameList.Items(x).SubItems(2).Text = "ERROR! Check Log.."
            '    ElseIf renameResult.Contains("RENAMED_OK:") Then
            '        lvRenameList.Items(x).SubItems(2).Text = "Success"
            '    Else
            '        lvRenameList.Items(x).SubItems(2).Text = "N/A! Check Log.."
            '    End If
            'Next
            autoSizeListViewColToContents(lvRenameList)
        End If
    End Sub


End Class