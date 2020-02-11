Imports com.automic
Imports com.uc4.api
Imports com.uc4.api.Template
Imports com.uc4.api.UC4ObjectName
Imports com.uc4.api.UC4TimezoneName
Imports com.uc4.api.UC4UserName
Imports com.uc4.api.objects
Imports com.uc4.api.objects.UC4Object
Imports com.uc4.communication
Imports com.uc4.communication.Connection
Imports com.uc4.communication.requests
Imports com.uc4.communication.requests.CreateObject
Imports com.uc4.communication.requests.DeleteObject
Imports com.uc4.communication.requests.FolderList
Imports com.uc4.communication.requests.FolderTree

Module folder


    '// below method takes as an input either "AEV10 - 0005/UC4.APPLICATIONS/JFORUM_BREN"
    '// or simply: "0005/UC4.APPLICATIONS/JFORUM_BREN"
    Public Function getFolderByFullPathNAme(ByVal folderName As String, ByVal con As Connection) As IFolder
        If folderName.Contains("<No Folder>") Then
            Return getNoFolderFolder(con)
        End If
        Dim allFolders As List(Of IFolder) = getAllFolders(True, con)
        For Each folder As IFolder In allFolders
            Dim FullPath As String = ""
            If (Not folder.fullPath.Contains("-")) Then
                FullPath = folder.fullPath.Trim
            Else
                FullPath = folder.fullPath.Split("-")(1).Trim
            End If

            If (FullPath.ToUpper = folderName.ToUpper.Trim) Then
                Return folder
            End If

        Next
        Return Nothing
    End Function


    Public Function getNoFolderFolder(ByVal con As Connection) As IFolder
        Return getFolderTree(con)
    End Function

    Public Function getFolderTree(ByVal con As Connection) As com.uc4.communication.requests.FolderTree
        Dim tree As New FolderTree
        con.sendRequestAndWait(tree)
        If Not tree.getMessageBox Is Nothing Then
            LOG("ERROR: " + tree.getMessageBox.getText)
        End If
        Return tree
    End Function

    'Object is FOLD
    Public Function getFolderFromFolderObject(ByVal objName As UC4Object) As IFolder
        Dim obj_iFolder As IFolder = objName
        Return obj_iFolder
    End Function

    '   // Returns a list of ALL Folders (including folders in folders, folders in folders in folders etc.)
    Public Function getAllFolders(ByVal OnlyExtractFolderObjects As Boolean, ByVal con As Connection) As List(Of IFolder)
        Return getFoldersRecursively(getRootFolder(con), OnlyExtractFolderObjects, con)
    End Function

    Public Function getRootFolder(ByVal con As Connection) As IFolder
        Dim tree As New FolderTree
        con.sendRequestAndWait(tree)
        Return tree.root
    End Function

    '// Internal Method
    Private Sub addFoldersToList(ByVal folderList As List(Of IFolder), ByVal myFolder As IFolder, ByVal onlyExtractFolderObjects As Boolean)
        If onlyExtractFolderObjects Then
            If myFolder.getType = "FOLD" Then folderList.Add(myFolder)
            If myFolder.getType = "FOLD" And Not myFolder.subfolder Is Nothing Then
                Dim it0 As java.util.Iterator = myFolder.subfolder
                While it0.hasNext
                    Dim item0 As IFolder = it0.next
                    addFoldersToList(folderList, item0, onlyExtractFolderObjects)
                End While
            End If
        Else
            folderList.Add(myFolder)
            If (Not myFolder.subfolder Is Nothing) Then
                Dim it0 As IList(Of IFolder) = myFolder.subfolder
                For Each item0 As IFolder In it0
                    addFoldersToList(folderList, item0, onlyExtractFolderObjects)
                Next
            End If
        End If

    End Sub

    '   // Returns a list of ALL Folders (including folders in folders, folders in folders in folders etc.)
    Public Function getFoldersRecursively(ByVal rootFolder As IFolder, ByVal OnlyExtractFolderObjects As Boolean, ByVal con As Connection) As List(Of IFolder)
        Dim FolderList As List(Of IFolder) = New List(Of IFolder)
        If (Not OnlyExtractFolderObjects) Then
            FolderList.Add(getRootFolder(con))
        End If
        FolderList.Add(rootFolder)

        Dim it As java.util.Iterator = rootFolder.subfolder
        If (Not it Is Nothing) Then
            While it.hasNext
                Dim myFolder As IFolder = it.next
                If (Not myFolder.getName = "<No Folder>") Then
                    addFoldersToList(FolderList, myFolder, OnlyExtractFolderObjects)
                End If
            End While
        End If
        Return FolderList
    End Function

    Public Function pathToIFolder(ByVal path As String, ByVal con As Connection) As IFolder
        'If Not path = "" Then path = getRootFolder(con).ToString + "\" + path
        path = path.Replace("\", "/")
        Dim allFolders As List(Of IFolder) = getAllFolders(True, con)
        For Each folder As IFolder In allFolders
            Dim myFolder As String = folder.fullPath.ToString.Replace("\", "/")
            If myFolder = path Then
                Return folder
            End If
        Next
        Return Nothing
    End Function

    Public Function iFolderToString(ByVal ifolder As IFolder) As String
        Dim path As String = ifolder.fullPath
        Return path
    End Function

    Public Sub populateTreeView(ByVal TV As TreeView, ByVal ifolders As List(Of IFolder))
        For Each ifolder As IFolder In ifolders
            AddPath(TV, iFolderToString(ifolder))
        Next
    End Sub

    Private Sub AddPath(ByVal tv As TreeView, ByVal path As String)
        Dim pathBlocks() As String = path.Split("/c")
        Dim nodes As TreeNodeCollection = tv.Nodes
        For Each block As String In pathBlocks
            If nodes.Find(block, False).Length > 0 Then
                nodes = nodes.Find(block, False)(0).Nodes
            Else
                nodes = nodes.Add(block, block).Nodes
            End If
        Next
    End Sub

    Public Function getFolderContents(ByVal ifolder As IFolder, ByVal con As Connection) As FolderList
        Dim objectsInRootFolder As FolderList = New FolderList(ifolder)
        con.sendRequestAndWait(objectsInRootFolder)
        Return objectsInRootFolder
    End Function

    Public Function isFolderEmpty(ByVal ifolder As IFolder, ByVal con As Connection) As Boolean
        Dim list As FolderList = getFolderContents(ifolder, con)
        If list.size = 0 Then Return True Else Return False
    End Function

    Public Function fetchAllObjects(ByVal con As Connection) As Hashtable 'List(Of String)
        Dim ifolders As List(Of IFolder) = getAllFolders(True, con)
        'Dim allObjects As New List(Of String)
        Dim allObjects As New Hashtable

        For Each ifolder As IFolder In ifolders
            Dim objectsList As FolderList = getFolderContents(ifolder, con)
            Dim it As java.util.Iterator = objectsList.iterator
            Dim item As FolderListItem
            While it.hasNext
                item = it.next
                If Not item.getType = "Folder" And Not item.isLink Then
                    'allObjects.Add(item.toString)
                    allObjects.Add(item, ifolder)
                End If
            End While
        Next
        Return allObjects
    End Function

    Public Function fetchAllObjectsInFolder(ByVal fullFolderPath As String, ByVal includeSubfolders As Boolean, ByVal con As Connection) As List(Of String)
        fullFolderPath = fullFolderPath.Replace("\", "/")
        Dim allObjects As New List(Of String) 
        Dim myIfolder As IFolder = pathToIFolder(fullFolderPath, con)
        If includeSubfolders = True Then
            Dim ifolders As List(Of IFolder) = getFoldersRecursively(myifolder, True, con)
            For Each ifolder As IFolder In ifolders
                Dim objectsList As FolderList = getFolderContents(ifolder, con)
                Dim it As java.util.Iterator = objectsList.iterator
                Dim item As FolderListItem
                While it.hasNext
                    item = it.next
                    If Not item.getType = "Folder" Then
                        allObjects.Add(item.toString)
                    End If
                End While
            Next
        Else
            Dim objectsList As FolderList = getFolderContents(myIfolder, con)
            Dim it As java.util.Iterator = objectsList.iterator
            Dim item As FolderListItem
            While it.hasNext
                item = it.next
                If Not item.getType = "Folder" Then
                    allObjects.Add(item.toString)
                End If
            End While
        End If
        Return allObjects
    End Function

    Public Function createFolderPath(ByVal folderPath As String, ByVal con As Connection) As Boolean
        'LOG("Creating folder [" + folderPath + "]")

        If Not uc4FolderExists(folderPath, con) Then

            folderPath = New String(folderPath.Replace("\", "/"))
            Dim splitPath As String() = folderPath.Split("/")

            For x = 1 To splitPath.Length - 1 'To 0 Step -1
                Dim tempPath As String = splitPath(0) + "/"
                For z = 1 To x
                    If z < x Then
                        tempPath += splitPath(z) + "/"
                    Else
                        tempPath += splitPath(z)
                    End If
                Next
                'LOG(tempPath)
                If Not uc4FolderExists(tempPath, con) Then
                    Dim pfolder As String = tempPath.Substring(0, tempPath.LastIndexOf("/"))
                    createFolder(splitPath(x), pfolder, con)
                End If

            Next
        End If

        If uc4FolderExists(folderPath, con) Then
            Return True
        Else
            Return False
        End If


        Return True
    End Function

    Public Function createFolder(ByVal folderName As String, ByVal parentFolder As String, ByVal con As Connection) As Boolean
        Dim fname As UC4ObjectName = New UC4ObjectName(folderName)
        Dim pfolder As IFolder = pathToIFolder(parentFolder, con)
        Dim create As CreateObject = New CreateObject(fname, Template.FOLD, pfolder)

        con.sendRequestAndWait(create)

        If Not create.getMessageBox Is Nothing Then
            LOG("FOLD Warning: " + parentFolder + "/" + folderName + "  __[Reason: " + create.getMessageBox.getText + "]__")
            Return False
        End If

        LOG("FOLD Created: " + parentFolder + "/" + folderName)
        Return True
    End Function

    Public Function uc4FolderExists(ByVal folderPath As String, ByVal con As Connection) As Boolean
        folderPath = New String(folderPath.Replace("\", "/"))

        Try
            Dim folderTree As FolderTree = getFolderTree(con)

            folderPath = folderPath.Substring(folderPath.IndexOf("/"))
            folderTree.getFolder(folderPath).fullPath()
            Return True
        Catch ex As Exception
            'LOG("Folder does not exist [" + folderPath + "]")
            Return False
        End Try
    End Function
End Module
