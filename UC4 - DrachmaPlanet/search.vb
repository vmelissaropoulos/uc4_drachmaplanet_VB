Imports com.uc4.communication
Imports com.uc4.communication.requests
Imports com.uc4.communication.requests.SearchObject
Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.api.SearchResultItem

Module search

    ' Returns the location of the object or null it it does not exist.
    Public Function getObjFolderLocation(ByVal objName As String, ByVal con As Connection) As String
        Dim RES As String = Nothing
        Try
            Dim search As SearchObject = New SearchObject
            search.selectAllObjectTypes()
            search.setName(objName)
            'search.setIncludeUseInScripts(True)
            'search.setSearchUseOfObjects(True)
            'search.setSearchInVariable(objName, True, True, True, com.uc4.communication.requests.SearchObject.VariableDataType.CHARACTER)
            con.sendRequestAndWait(search)
            Dim it As java.util.Iterator = search.resultIterator
            If it.hasNext() Then
                Dim item As SearchResultItem = it.next()
                RES = item.getFolder '"Name: " + item.getName + vbCrLf + "Use: " + item.getUse + vbCrLf + "Folder: " + item.getFolder() + vbCrLf + "FolderID: " + item.getFolderID
            End If
        Catch ex As Exception
            LOG("ERROR: " + ex.Message + vbCrLf)
        End Try

        Return RES
    End Function

    ' * Returns an iterator over all links for the specified object.
    Public Function getLinks(ByVal objName As String, ByVal con As Connection) As List(Of SearchResultItem)
        Try
            Dim search As SearchObject = New SearchObject
            search.selectAllObjectTypes()
            search.setName(objName)
            search.setIncludeLinks(True)
            con.sendRequestAndWait(search)
            Dim linksOnly As New List(Of SearchResultItem)
            Dim it As java.util.Iterator = search.resultIterator
            While it.hasNext
                Dim item As SearchResultItem = it.next()
                If item.isLink Then
                    linksOnly.Add(item)
                End If
            End While

            If linksOnly.Count = 0 Then Return Nothing
            Return linksOnly
        Catch ex As Exception
            LOG("ERROR: " + ex.Message)
        End Try
        Return Nothing
    End Function


    ' * Returns an iterator over all links for the specified object.
    Public Function getObjectUse(ByVal objName As String, ByVal con As Connection) As List(Of SearchResultItem)
        'Try
        Dim search As SearchObject = New SearchObject
        search.selectAllObjectTypes()
        search.setName(objName)
        search.setSearchUseOfObjects(True)
        con.sendRequestAndWait(search)
        Dim usingObjName As New List(Of SearchResultItem)
        Dim it As java.util.Iterator = search.resultIterator
        While it.hasNext
            Dim item As SearchResultItem = it.next()
            'If item.getUse.IsNullOrEmpty Then
            usingObjName.Add(item)
            'End If
        End While

        If usingObjName.Count = 0 Then Return Nothing
        Return usingObjName
        'Catch ex As Exception
        '    LOG("ERROR: " + ex.Message)
        'End Try
        'Return Nothing
    End Function

    Public Function searchForTextAll(ByVal pattern As String, ByVal process As Boolean, ByVal documentation As Boolean, ByVal objectTitle As Boolean, ByVal archiveKeys As Boolean, ByVal con As Connection) As List(Of SearchResultItem)

        Dim RES As New List(Of SearchResultItem)

        Dim search As SearchObject = New SearchObject
        search.selectAllObjectTypes()
        search.setTextSearch(pattern, process, documentation, objectTitle, archiveKeys)
        con.sendRequestAndWait(search)
        Dim it As java.util.Iterator = search.resultIterator
        While it.hasNext
            Dim item As SearchResultItem = it.next()
            RES.Add(item)
        End While

        If RES.Count = 0 Then Return Nothing
        Return RES
    End Function

End Module
