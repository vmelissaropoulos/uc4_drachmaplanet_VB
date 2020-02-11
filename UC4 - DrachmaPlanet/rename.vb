Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication
Imports com.uc4.communication.requests
Imports com.uc4.communication.requests.GetReplaceList


Module rename
    Public Function renameObject(ByVal objName As String, ByVal new_objName As String, ByVal readMode As Boolean, ByVal con As Connection) As String
        Dim RES As String = Nothing
        Dim my_objName As UC4ObjectName = New UC4ObjectName(objName)

        Dim open As OpenObject = New OpenObject(my_objName, readMode, True)
        con.sendRequestAndWait(open)
        If (Not open.getMessageBox() Is Nothing) Then
            RES = ("ERROR: " + open.getMessageBox.getText)
            Return RES
        End If

        Dim openObject As UC4Object
        Try
            openObject = open.getUC4Object
        Catch ex As Exception
            RES = ("ERROR: " + ex.Message)
            Return RES
        End Try

        Dim oldName As UC4ObjectName = New UC4ObjectName(openObject.getName)
        Dim newName As UC4ObjectName = New UC4ObjectName(new_objName)
        Dim rename As RenameObject = New RenameObject(oldName, newName, getFolderByFullPathNAme(getObjFolderLocation(objName, con), con), frmRename.txtObjectTitle.Text)

        rename.setRenameIfUsed(False)
        con.sendRequestAndWait(rename)

        If (Not rename.getMessageBox() Is Nothing) Then
            LOG(rename.getMessageBox.getNumber.ToString + ": " + rename.getMessageBox.getText)

            If rename.getMessageBox.getNumber = 4005704 Then
                Dim msgRespong As MsgBoxResult = MsgBox(rename.getMessageBox.getNumber.ToString + ": " + rename.getMessageBox.getText, vbYesNoCancel + vbInformation, "Object in use")

                If msgRespong = vbYes Then
                    Dim replaceList As GetReplaceList = New GetReplaceList(rename)
                    con.sendRequestAndWait(replaceList)

                    If (Not replaceList.getMessageBox() Is Nothing) Then
                        RES = replaceList.getMessageBox.getText
                    End If

                    Dim replace As ReplaceObject = New ReplaceObject(replaceList)
                    con.sendRequestAndWait(replace)

                    If (Not replace.getMessageBox() Is Nothing) Then

                        If replace.getMessageBox.getNumber = 4005690 Then
                            RES = replace.getMessageBox.getNumber.ToString + ": " + replace.getMessageBox.getText
                        Else
                            RES = "ERROR: " + replace.getMessageBox.getNumber.ToString + ": " + replace.getMessageBox.getText
                        End If

                    Else
                        RES = Nothing
                    End If

                ElseIf msgRespong = vbNo Then
                    rename.setRenameIfUsed(True)
                    con.sendRequestAndWait(rename)
                    RES = "RENAME_OK: " + openObject.getName + " -> " + new_objName
                Else
                    RES = "INFO: Rename action canceled!"
                End If
            Else
                RES = "ERROR: " + rename.getMessageBox.getText
            End If
        Else
            RES = "RENAMED_OK: " + objName + " > " + new_objName
        End If

        If RES Is Nothing Then
            RES = "Hmmm! Something didn't work as expected! Debuging required!"
        End If





        'RES = renameJOBS(openObject, new_objName, getFolderByFullPathNAme(getObjFolderLocation(objName, con), con), con)

        'Dim objType As String = open.getType.ToString.ToUpper()
        'frmMain.Button1.Text = objType
        'Select Case objType
        '    Case "JOBS_UNIX", "JOBS_WIN"
        '        Dim myObj As Job = openObject
        '        RES = renameJOBS(openObject, new_objName, getFolderByFullPathNAme(getObjFolderLocation(objName, con), con), con)
        '        If RES Is Nothing Then
        '            RES = "RENAMED_OK: " + objName + " > " + new_objName
        '        End If
        '    Case "LOGIN"
        '    Case "SCHEDULE"
        '    Case "WORKFLOW"
        '    Case "PROMPTSET"
        '    Case "SYNC"
        '    Case "FOLDER"
        '    Case Else
        '        RES = "ERROR: Unknown Object Type!"

        'End Select

        Dim close As CloseObject = New CloseObject(openObject)
        con.sendRequestAndWait(close)
        If (Not close.getMessageBox() Is Nothing) Then
            RES = "ERROR:  " + close.getMessageBox.getText
        End If

        Return RES
    End Function

    Public Function renameInProccessTab(ByVal myObjectHash As Hashtable, ByVal myObjectName As DictionaryEntry) As String
        Dim RES As String = Nothing



        Return RES
    End Function


    'Public Function renameJOBS(ByVal openObject As UC4Object, ByVal new_objName As String, ByVal objFolder As IFolder, ByVal con As Connection) As String
    '    Dim RES As String = Nothing
    '    Dim oldName As UC4ObjectName = New UC4ObjectName(openObject.getName)
    '    Dim newName As UC4ObjectName = New UC4ObjectName(new_objName)
    '    Dim rename As RenameObject = New RenameObject(oldName, newName, objFolder, frmMain.txtObjectTitle.Text)

    '    rename.setRenameIfUsed(False)
    '    con.sendRequestAndWait(rename)

    '    If (Not rename.getMessageBox() Is Nothing) Then
    '        LOG(rename.getMessageBox.getNumber.ToString + ": " + rename.getMessageBox.getText)

    '        If rename.getMessageBox.getNumber = 4005704 Then
    '            Dim msgRespong As MsgBoxResult = MsgBox(rename.getMessageBox.getNumber.ToString + ": " + rename.getMessageBox.getText, vbYesNoCancel + vbInformation, "Object in use")

    '            If msgRespong = vbYes Then
    '                Dim replaceList As GetReplaceList = New GetReplaceList(rename)
    '                con.sendRequestAndWait(replaceList)

    '                If (Not replaceList.getMessageBox() Is Nothing) Then
    '                    RES = replaceList.getMessageBox.getText
    '                End If

    '                Dim replace As ReplaceObject = New ReplaceObject(replaceList)
    '                con.sendRequestAndWait(replace)

    '                If (Not replace.getMessageBox() Is Nothing) Then

    '                    If replace.getMessageBox.getNumber = 4005690 Then
    '                        RES = replace.getMessageBox.getNumber.ToString + ": " + replace.getMessageBox.getText
    '                    Else
    '                        RES = "ERROR: " + replace.getMessageBox.getNumber.ToString + ": " + replace.getMessageBox.getText
    '                    End If

    '                Else
    '                    RES = Nothing
    '                End If

    '            ElseIf msgRespong = vbNo Then
    '                rename.setRenameIfUsed(True)
    '                con.sendRequestAndWait(rename)
    '                RES = "RENAME_OK: " + openObject.getName + " -> " + new_objName
    '            Else
    '                RES = "INFO: Rename action canceled!"
    '            End If
    '        Else
    '            RES = "ERROR: " + rename.getMessageBox.getText
    '        End If
    '    Else
    '        RES = Nothing
    '    End If

    '    Return RES
    'End Function
End Module
