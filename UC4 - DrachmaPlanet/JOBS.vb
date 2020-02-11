Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication
Imports com.uc4.communication.requests

Module JOBS

    Public Function removePRPTfromJOBS(ByVal jobsName As String, ByVal prptName As String, ByVal con As Connection) As Boolean

        Dim objName As UC4ObjectName = New UC4ObjectName(jobsName)
        Dim open As OpenObject = New OpenObject(objName, False, True)


        Try
            con.sendRequestAndWait(open)
        Catch ex As Exception
            LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
            Return False
        End Try

        If Not open.getMessageBox Is Nothing Then
            LOG("ERROR: " + open.getMessageBox().getText() + " %% Object: " + jobsName + " returned a message box: ") ' + open.getMessageBox().getNumber())
            Return False
        Else

            Dim openObject As UC4Object = open.getUC4Object

            If Not openObject.getType.StartsWith("JOBS") Then Return False
            Dim myJOBS As Job = openObject

            Dim itPRPT As java.util.Iterator = myJOBS.values.promptSetIterator
            While itPRPT.hasNext
                Dim item As PromptSetDefinition = itPRPT.next
                'LOG("1: " + item.getName.toString)
                If item.getName.toString = prptName Then
                    itPRPT.remove()
                End If
            End While

            Dim save As SaveObject = New SaveObject(openObject)
            con.sendRequestAndWait(save)
            If (Not save.getMessageBox() Is Nothing) Then
                LOG("ERROR:  " + save.getMessageBox.getText)
                Return False
            End If

            Dim close As CloseObject = New CloseObject(openObject)
            con.sendRequestAndWait(close)
            If (Not close.getMessageBox() Is Nothing) Then
                LOG("ERROR:  " + close.getMessageBox.getText)
                Return False
            End If

            Return True
        End If
    End Function

    Public Function getObjectsfromJOBS(ByVal jobsName As String, ByVal con As Connection) As List(Of String)

        Dim RES As List(Of String) = New List(Of String)
        Dim objName As UC4ObjectName = New UC4ObjectName(jobsName)
        Dim open As OpenObject = New OpenObject(objName, True, True)

        Try
            con.sendRequestAndWait(open)
        Catch ex As Exception
            LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
        End Try

        If Not open.getMessageBox Is Nothing Then
            LOG("ERROR: " + open.getMessageBox().getText() + " %% Object: " + jobsName + " returned a message box: ") ' + open.getMessageBox().getNumber())

        Else
            Dim openObject As UC4Object = open.getUC4Object
            addToList(RES, openObject.getName)


            Dim myJOBS As Job = openObject
            addRangeToList(RES, iteratePRPTJob(myJOBS, con))
            addRangeToList(RES, iterateSYNCJob(myJOBS, con))


            Dim close As CloseObject = New CloseObject(openObject)
            Try
                con.sendRequestAndWait(close)
            Catch ex As Exception
                LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
            End Try
        End If

        Return RES
    End Function

    Public Function setLoginInJOBS(ByVal myJob As Job, ByVal myLogin As UC4ObjectName, ByVal dryRun As Boolean, ByVal con As Connection) As String
        Dim myJobAttributes As JobAttributes = myJob.attributes
        If dryRun Then
            Return myJobAttributes.getLogin.getName
        Else
            myJobAttributes.setLogin(myLogin)
            Dim save As SaveObject = New SaveObject(myJob)
            con.sendRequestAndWait(save)
            If (Not save.getMessageBox() Is Nothing) Then
                LOG("ERROR:  " + save.getMessageBox.getText)
                Return False
            End If
        End If

        Return True
    End Function

    Public Function setHostInJOBS(ByVal myJob As Job, ByVal myHost As UC4HostName, ByVal dryRun As Boolean, ByVal con As Connection) As String
        Dim myJobAttributes As JobAttributes = myJob.attributes
        If dryRun Then
            Return myJobAttributes.getHost.getName
        Else
            myJobAttributes.setHost(myHost)
            Dim save As SaveObject = New SaveObject(myJob)
            con.sendRequestAndWait(save)
            If (Not save.getMessageBox() Is Nothing) Then
                LOG("ERROR:  " + save.getMessageBox.getText)
                Return False
            End If
        End If

        Return True
    End Function

    Public Function setSHELLInJOBS(ByVal myJob As Job, ByVal myShell As String, ByVal dryRun As Boolean, ByVal con As Connection) As String
        Dim myUNIXJobAttributes As AttributesUnix = myJob.hostAttributes
        If dryRun Then
            Return myUNIXJobAttributes.getShell
        Else
            myUNIXJobAttributes.setShell(myShell)
            Dim save As SaveObject = New SaveObject(myJob)
            con.sendRequestAndWait(save)
            If (Not save.getMessageBox() Is Nothing) Then
                LOG("ERROR:  " + save.getMessageBox.getText)
                Return False
            End If
        End If

        Return True
    End Function

    Private Function iteratePRPTJob(ByVal myJOBS As Job, ByVal con As Connection) As List(Of String)
        Dim RES As List(Of String) = New List(Of String)

        Dim itPRPT As java.util.Iterator = myJOBS.values.promptSetIterator
        While itPRPT.hasNext
            Dim item As PromptSetDefinition = itPRPT.next
            LOG(vbTab + "[PRPT] " + item.getName.toString)
            RES.Add(item.getName.toString)
        End While
        Return RES
    End Function

    Private Function iterateSYNCJob(ByVal myJOBS As Job, ByVal con As Connection) As List(Of String)
        Dim RES As List(Of String) = New List(Of String)

        Dim itJPSync As java.util.Iterator = myJOBS.syncs.iterator
        While itJPSync.hasNext
            Dim item As SyncItem = itJPSync.next
            LOG(vbTab + "[SYNC] " + item.getSyncObject.getName.ToString)
            addToList(RES, item.getSyncObject.getName.ToString)
        End While

        Return RES
    End Function

#Region "Pre-Script-Post"

    'whereToApply: {rbtnPreProc,rbtnProc,rbtnPostProc}
    Public Function addJOBSProcess(ByVal myJOBS As Job, ByVal str As String, ByVal whereToApply As String, ByVal append As Boolean, ByVal con As Connection) As Boolean

        Try
            Select Case whereToApply
                Case "rbtnPreProc"
                    myJOBS.setPreProcess(buildPrePost_Process_ADD(myJOBS, str, myJOBS.getPreProcess, append))
                Case "rbtnProc"
                    myJOBS.setProcess(buildPrePost_Process_ADD(myJOBS, str, myJOBS.getProcess, append))
                Case "rbtnPostProc"
                    myJOBS.setPostProcess(buildPrePost_Process_ADD(myJOBS, str, myJOBS.getPostProcess, append))
                Case Else
                    LOG("ERROR: Cannot understand where to apply the additions!")

            End Select

            Dim save As SaveObject = New SaveObject(myJOBS)
            con.sendRequestAndWait(save)
            If (Not save.getMessageBox() Is Nothing) Then
                LOG("ERROR:  " + save.getMessageBox.getText)
                Return False
            End If

        Catch ex As Exception
            LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
            Return False
        End Try

        Return True
    End Function

    Private Function buildPrePost_Process_ADD(ByVal myJOBS As Job, ByVal str As String, ByVal proc As String, ByVal append As Boolean) As String
        Dim nl = vbLf

        If append Then
            proc = proc + nl + str
        Else
            proc = str + nl + proc
        End If

        Return proc
    End Function

    'whereToApply: {rbtnPreProc,rbtnProc,rbtnPostProc}
    Public Function replaceJOBSProcess(ByVal myJOBS As Job, ByVal strOLD As String, ByVal strNEW As String, ByVal whereToApply As String, ByVal replaceAll As Boolean, ByVal con As Connection) As Boolean

        Try
            Select Case whereToApply
                Case "rbtnPreProc"
                    myJOBS.setPreProcess(buildPrePost_Process_REPLACE(myJOBS, strOLD, strNEW, myJOBS.getPreProcess, replaceAll))
                Case "rbtnProc"
                    myJOBS.setProcess(buildPrePost_Process_REPLACE(myJOBS, strOLD, strNEW, myJOBS.getProcess, replaceAll))
                Case "rbtnPostProc"
                    myJOBS.setPostProcess(buildPrePost_Process_REPLACE(myJOBS, strOLD, strNEW, myJOBS.getPostProcess, replaceAll))
                Case Else
                    LOG("ERROR: Cannot understand where to apply the additions!")

            End Select

            Dim save As SaveObject = New SaveObject(myJOBS)
            con.sendRequestAndWait(save)
            If (Not save.getMessageBox() Is Nothing) Then
                LOG("ERROR:  " + save.getMessageBox.getText)
                Return False
            End If

        Catch ex As Exception
            LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
            Return False
        End Try

        Return True
    End Function

    Private Function buildPrePost_Process_REPLACE(ByVal myJOBS As Job, ByVal strOLD As String, ByVal strNEW As String, ByVal proc As String, ByVal replaceAll As Boolean) As String
        Dim nl = vbLf

        If replaceAll Then
            proc = strNEW
        Else
            proc = proc.Replace(strOLD, strNEW)
            'MsgBox(proc)
        End If

        Return proc
    End Function

#End Region

    Private Sub addToList(ByVal objList As List(Of String), ByVal obj As String)
        If Not objList.Contains(obj) Then
            objList.Add(obj)
        End If
    End Sub

    Private Sub addRangeToList(ByVal objList As List(Of String), ByVal objList2 As List(Of String))
        For Each obj In objList2
            If Not objList.Contains(obj) Then
                objList.Add(obj)
            End If
        Next
    End Sub
End Module
