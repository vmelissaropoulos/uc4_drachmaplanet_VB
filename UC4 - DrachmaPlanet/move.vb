

Imports com.uc4.communication
Imports com.uc4.communication.requests
Imports com.uc4.communication.requests.GetReplaceList
Imports com.uc4.communication.requests.FolderTree
Imports com.uc4.communication.requests.FolderList
Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.api.Template

Module move

    Private Function builtListToMove(ByVal includeList As List(Of String), ByVal excludeList As List(Of String), ByVal con As Connection) As List(Of String)
        ''''if include file set then do only for include into from folder
        ''''if exclude file set then do only for those not in exclude into from folder'
        ''''if both include and exclude files set then exclude from exclude list but make sure to include those in include (even if the same are in exlcude) into from folder
        ''''if neither set then do for all into from folder

        If includeList Is Nothing And excludeList Is Nothing Then

            'move everything recurcively and keeping folder struct from source to target

        ElseIf Not includeList Is Nothing And excludeList Is Nothing Then
            'move only include list from source to target

        ElseIf includeList Is Nothing And Not excludeList Is Nothing Then
            'move everything but exclude list from source to target

        ElseIf Not includeList Is Nothing And Not excludeList Is Nothing Then
            'move only include list from source to target but exclude those in exclude list.


        End If


        Return Nothing
    End Function

    'moveObjectsInList(myList, myObjList, txtTo.Text, txtFrom.Text, chkKeepFolderStruc.Checked, MDIParent1.myConnection)
    Public Sub moveObjectsInList(ByVal allObjects As Hashtable, ByVal objectsToMove As List(Of String), ByVal myTarget As String, ByVal folderStrucToKeep As String, ByVal flagKeepFolderStruc As Boolean, ByVal con As Connection)

        Dim myList As Hashtable = allObjects
        Dim keyObj As DictionaryEntry

        If flagKeepFolderStruc Then
            For Each objectToMove In objectsToMove
                For Each keyObj In myList
                    Dim folderListObject As FolderListItem = keyObj.Key
                    Dim ifolder As IFolder = keyObj.Value

                    If folderListObject.getName.Equals(objectToMove) Then
                        Dim tempTarget = buildTargetPath(ifolder.fullPath, myTarget, folderStrucToKeep)

                        If Not uc4FolderExists(tempTarget, con) Then
                            LOG("FOLD does not exist [" + myTarget + "]")
                            If Not createFolderPath(tempTarget, con) Then
                                LOG("FOLD ERROR: Could not create folder [" + tempTarget + "]")
                                Exit For
                            End If

                        End If

                        LOG("MOVING: from:[" + ifolder.fullPath + "]  >>  to:[" + tempTarget + "] " + folderListObject.getName)
                        moveObject(folderListObject, ifolder, tempTarget, con)

                        Exit For
                    End If
                Next
            Next

        Else

            For Each objectToMove In objectsToMove
                For Each keyObj In myList

                    Dim folderListObject As FolderListItem = keyObj.Key
                    Dim ifolder As IFolder = keyObj.Value

                    If folderListObject.getName = objectToMove Then
                        Dim tempTarget = buildTargetPath(ifolder.fullPath, myTarget, folderStrucToKeep)
                        LOG("MOVING: from:[" + ifolder.fullPath + "]  >>  to:[" + tempTarget + "] " + folderListObject.getName)
                        moveObject(folderListObject, ifolder, tempTarget, con)
                        Exit For
                    End If

                Next
            Next
        End If


    End Sub

    Public Function moveObject(ByVal objectToMove As FolderListItem, ByVal mySource As IFolder, ByVal myTarget As String, ByVal con As Connection) As Boolean
        myTarget = myTarget.Replace("\", "/")
        Dim targetIFolder As IFolder = pathToIFolder(myTarget, con)
        If mySource.fullPath = targetIFolder.fullPath Then
            LOG("MOVING: Object already in path!! from:[" + mySource.fullPath + "]  >>  to:[" + targetIFolder.fullPath + "] " + objectToMove.getName)
            Return True
        End If
        Dim move As MoveObject = New MoveObject(objectToMove, mySource, targetIFolder)

        con.sendRequestAndWait(move)
        If Not move.getMessageBox Is Nothing Then
            LOG("Could not move object. " + move.getMessageBox.getText)
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub moveObject(ByVal objectToMove As String, ByVal myTarget As String, ByVal con As Connection)
        Dim targetIFolder As IFolder = pathToIFolder(myTarget, con)
        Dim myList As Hashtable = fetchAllObjects(con)
        Dim keyObj As DictionaryEntry

        For Each keyObj In myList

            Dim folderListObject As FolderListItem = keyObj.Key
            Dim ifolder As IFolder = keyObj.Value

            If folderListObject.getName = objectToMove Then
                LOG(folderListObject.getName + vbTab + " [" + ifolder.fullPath + " -->>-- " + targetIFolder.fullPath + "]")
                moveObject(folderListObject, ifolder, myTarget, con)
                Exit For
            End If
        Next
    End Sub

    ''' <summary>
    ''' This function returns the path where the object should be moved depending it's current path, the target path and the folder_structure to keep same.
    ''' Ex:
    ''' source = C:/windows/system/temp
    ''' target = C:/users/
    ''' folderStrucToKeep = C:/windows
    ''' finalTarget = C:/users/system/temp
    ''' </summary>
    ''' <param name="source">The current path of the object</param>
    ''' <param name="target">Folder where to move object</param>
    ''' <param name="folderStrucToKeep">The portion of the source path to dispose. Keep the rest. ex: source - folderStrucToKeep = path_to_keep [C:/windows/system/temp - C:/windows = /system/temp]</param>
    ''' <returns>finalTarget: The complete path where to move the object</returns>
    ''' <remarks></remarks>
    Public Function buildTargetPath(ByVal source As String, ByVal target As String, ByVal folderStrucToKeep As String) As String
        source = source.Replace("\", "/")
        target = target.Replace("\", "/")
        folderStrucToKeep = folderStrucToKeep.Replace("\", "/")
        Dim finalTarget As String = ""

        If source.Contains(target) Then Return source

        If target.Contains(source) Then Return target

        If Not source.Contains(folderStrucToKeep) Then Return target

        If source.Contains(folderStrucToKeep) And Not source = folderStrucToKeep Then
            finalTarget = "/" + source.Substring(source.IndexOf(folderStrucToKeep) + folderStrucToKeep.Length + 1)
            finalTarget = target + finalTarget
        Else
            finalTarget = target
        End If

        Return finalTarget
    End Function

    Private Function getObjType(ByVal objName As String, ByVal con As Connection) As String
        Return Nothing
    End Function

    

End Module
