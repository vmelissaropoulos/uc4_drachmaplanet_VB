Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication.requests
Imports com.uc4.communication.requests.FolderList
Imports com.uc4.communication.requests.FolderTree


Public Class frmMove

    Private Sub frmMove_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        saveForm(Me)
    End Sub

    Private Sub frmMove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadForm(Me)
    End Sub

    Private Sub btnBrowseFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFrom.Click
        populateTreeView(frmSelectFolder.tvSelectFolder, getAllFolders(True, MDIParent1.myConnection))
        frmSelectFolder.ShowDialog(Me)
        txtFrom.Text = MDIParent1.selectedFolder
    End Sub

    Private Sub btnBrowseTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseTo.Click
        populateTreeView(frmSelectFolder.tvSelectFolder, getAllFolders(True, MDIParent1.myConnection))
        frmSelectFolder.ShowDialog(Me)
        txtTo.Text = MDIParent1.selectedFolder
    End Sub

    Private Sub btnBrowseForPFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseForPFolder.Click
        populateTreeView(frmSelectFolder.tvSelectFolder, getAllFolders(True, MDIParent1.myConnection))
        frmSelectFolder.ShowDialog(Me)
        txtPFolder.Text = MDIParent1.selectedFolder
    End Sub


    Private Sub btnIncludeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncludeList.Click
        openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Ini files (*.ini)|*.ini"
        openFileDialog.Multiselect = False
        openFileDialog.Title = "Select Include List File"
        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtIncludeFile.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnExcludeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcludeList.Click
        openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Ini files (*.ini)|*.ini"
        openFileDialog.Multiselect = False
        openFileDialog.Title = "Select Exclude List File"
        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtExcludeFile.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnCreateFolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFolders.Click
        If txtPFolder.Text = "" Or lstFolderStructure.Items.Count = 0 Then
            MsgBox("WARNING: Please choose a folder and add folders into list.", MsgBoxStyle.OkOnly + vbInformation, "Need more info!")
            Exit Sub
        End If

        If MsgBox("This will create the folders indicated in listbox under each level one folder of selected path [" + txtPFolder.Text + "]" _
                  + vbCrLf + vbCrLf + "ex: " + txtPFolder.Text + "\EACH_FOLDER\" + lstFolderStructure.Items.Item(0).ToString _
                  + vbCrLf + vbCrLf + "Continue?", vbYesNo + MsgBoxStyle.Exclamation, "Are you sure?") = MsgBoxResult.No _
        Then Exit Sub

        MDIParent1.Cursor = Cursors.WaitCursor

        LOG("Creating folders defined in list under each folder in " + txtPFolder.Text + "...", True)
        Dim folderList As New List(Of String)
        Dim folderStructure As New List(Of String)

        For Each item As String In lstFolderStructure.Items
            folderStructure.Add(item)
        Next

        Dim pfolder As IFolder = pathToIFolder(txtPFolder.Text.Replace("\", "/"), MDIParent1.myConnection)
        Dim folderContents As FolderList = getFolderContents(pfolder, MDIParent1.myConnection)
        For Each item As FolderListItem In folderContents
            If item.getType = "Folder" Then
                folderList.Add(txtPFolder.Text.Replace("\", "/") + "/" + item.getName)
            End If
        Next

        For Each itFolder As String In folderList
            For Each fName As String In folderStructure
                Dim tempItFold As String = itFolder
                fName = fName.Replace("\", "/")
                If Not fName.Contains("/") Then fName += "/"
                Dim arrayFName As String() = fName.Split("/")
                For Each arFName As String In arrayFName
                    If Not arFName = "" Then
                        fName = arFName
                        createFolder(fName, tempItFold, MDIParent1.myConnection)
                        tempItFold += "/" + fName
                    End If
                Next

            Next
        Next
        LOG("Finished...", True)
        MDIParent1.Cursor = Cursors.Arrow
    End Sub


    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        MDIParent1.Cursor = Cursors.WaitCursor
        If txtFrom.Text = "" Or txtTo.Text = "" Then
            LOG("ERROR: Select Source and Target first!")
            MDIParent1.Cursor = Cursors.Arrow
            Exit Sub
        End If

        LOG("Getting information from UC4...", True)
        Dim myList As Hashtable = fetchAllObjects(MDIParent1.myConnection)
        Dim keyObj As DictionaryEntry

        LOG("Analysing objects in list...", True)
        Dim myObjList As New List(Of String)

        Dim myObjListFromFile As List(Of String) = readFileByLine(txtIncludeFile.Text)
        For Each obj In myObjListFromFile
            For Each keyObj In myList
                Dim folderListObject As FolderListItem = keyObj.Key
                Dim ifolder As IFolder = keyObj.Value
                If folderListObject.getName.Equals(obj.ToUpper) Then
                    LOG("Working on " + folderListObject.getName.ToString, True)
                    'MsgBox(folderListObject.getType.ToString)
                    If folderListObject.getType.Contains("Workflow") Then
                        Dim tempList As New List(Of String)
                        tempList = getJOBPTasksRecurcive(obj, MDIParent1.myConnection)
                        For Each item In tempList
                            If Not myObjList.Contains(item) Then
                                myObjList.Add(item)
                            End If
                        Next
                    ElseIf folderListObject.getType.Contains("Job") Then
                        Dim tempList As New List(Of String)
                        tempList = getObjectsfromJOBS(obj, MDIParent1.myConnection)
                        For Each item In tempList
                            If Not myObjList.Contains(item) Then
                                myObjList.Add(item)
                            End If
                        Next
                    Else
                        If Not myObjList.Contains(obj) Then
                            myObjList.Add(obj)
                        End If
                    End If

                    Exit For
                End If
            Next
        Next

        Dim index As Integer = 0
        Dim index2 As Integer = 0
        Dim msgList As List(Of String) = New List(Of String)
        Dim msgList2 As List(Of String) = New List(Of String)

        LOG("Following is the list of Objects to move...", True)
        For Each obj In myObjList

            For Each keyObj In myList
                Dim folderListObject As FolderListItem = keyObj.Key
                Dim ifolder As IFolder = keyObj.Value

                If folderListObject.getName.Equals(obj) Then
                    Dim logMSG = "from:[" + ifolder.fullPath + "] to:[" + buildTargetPath(ifolder.fullPath, txtTo.Text, txtFrom.Text) + "] [" + folderListObject.getType + "] " + folderListObject.getName
                    msgList.Add(logMSG)

                    If index < logMSG.IndexOf("]") Then
                        index = logMSG.IndexOf("]")
                    End If
                    Exit For
                End If
            Next
        Next

        For Each line In msgList
            Dim spacer = ""
            Dim indexABS = Math.Abs(index - line.IndexOf("]"))
            For x = 0 To indexABS - 1
                spacer += " "
            Next
            line = line.Substring(0, line.IndexOf("]") + 1) + spacer + line.Substring(line.IndexOf("]") + 1)
            msgList2.Add(line)
            If index2 < line.LastIndexOf("]") Then
                index2 = line.LastIndexOf("]")
            End If
        Next

        For Each line In msgList2

            Dim spacer = ""
            Dim indexABS = Math.Abs(index2 - line.LastIndexOf("]"))
            For x = 0 To indexABS - 1
                spacer += " "
            Next

            line = line.Substring(0, line.LastIndexOf("]") + 1) + spacer + line.Substring(line.LastIndexOf("]") + 1)
            LOG(line)
        Next


        If MsgBox("Check log and confirm objects list." + vbCrLf + vbCrLf + "Continue?", vbYesNo) = MsgBoxResult.No Then
            MDIParent1.Cursor = Cursors.Arrow
            Exit Sub
        End If


        LOG("Performing actions...", True)
        moveObjectsInList(myList, myObjList, txtTo.Text, txtFrom.Text, chkKeepFolderStruc.Checked, MDIParent1.myConnection)

        LOG("Finished!" + vbCrLf, True)

        MDIParent1.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnTEST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTEST.Click

    End Sub

    Private Sub btnTESTpath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTESTpath.Click
        Dim myObjList As List(Of String) = readFileByLine(txtIncludeFile.Text)

        'moveObjectsInList(myObjList, txtTo.Text, txtFrom.Text, chkKeepFolderStruc.Checked, MDIParent1.myConnection)

        'LOG(createFolderPath("UC4 - 0100/WIND_DEMO/RESURRECTION/NODE/JOBS/A/BE/BA/BLOM", MDIParent1.myConnection))

    End Sub

    Private Sub btnRemovePRPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePRPT.Click
        MDIParent1.Cursor = Cursors.WaitCursor

        LOG("Analysing UC4 Objects. Please wait...", True)
        Dim myList As List(Of String) = fetchAllObjectsInFolder(txtFrom.Text, True, MDIParent1.myConnection)

        For Each obj In myList
            If obj.StartsWith("JOBS.") Then
                If Not removePRPTfromJOBS(obj, "PRPT.TASK.INFOS", MDIParent1.myConnection) Then
                    LOG("PRPT.TASK.INFOS removal ERR: " + obj)
                Else
                    LOG("PRPT.TASK.INFOS removal OK: " + obj)
                End If
            End If

        Next
        'LOG("Removing : PRPT.TASK.INFOS from JOBS.WIN.NEW.1: " + removePRPTfromJOBS("JOBS.WIN.NEW.1", "PRPT.TASK.INFOS", MDIParent1.myConnection).ToString)

        MDIParent1.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnAddToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToList.Click
        Dim inputSTR = InputBox("Type the Folder name. This will be used to create list of folders under the selected path.", "Add item ot listbox")
        If Not inputSTR = "" Or Not inputSTR Is Nothing Then
            lstFolderStructure.Items.Add(inputSTR)
        End If
    End Sub

    Private Sub btnRemoveFromList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFromList.Click
        If lstFolderStructure.SelectedItems.Count > 0 Then
            lstFolderStructure.Items.Remove(lstFolderStructure.SelectedItem)

        End If
    End Sub

End Class