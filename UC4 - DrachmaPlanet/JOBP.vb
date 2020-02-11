Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication
Imports com.uc4.communication.requests


Module JOBP

#Region "Pre-Script-Post"

    Public Function addJOB_PLANProcess(ByVal myJOBP As JobPlan, ByVal str As String, ByVal whereToApply As String, ByVal append As Boolean, ByVal con As Connection) As Boolean

        Try
            Select Case whereToApply
                Case "rbtnPreProc"

                Case "rbtnProc"
                    myJOBP.setProcess(buildPrePost_Process_ADD(myJOBP, str, myJOBP.getProcess, append))
                Case "rbtnPostProc"

                Case Else
                    LOG("ERROR: Cannot understand where to apply the additions!")

            End Select

            Dim save As SaveObject = New SaveObject(myJOBP)
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


    Private Function buildPrePost_Process_ADD(ByVal myJOBP As JobPlan, ByVal str As String, ByVal proc As String, ByVal append As Boolean) As String
        Dim nl = vbLf

        If append Then
            proc = proc + nl + str
        Else
            proc = str + nl + proc
        End If

        Return proc
    End Function

    Public Function replaceJOB_PLANProcess(ByVal myJOBP As JobPlan, ByVal strOLD As String, ByVal strNEW As String, ByVal whereToApply As String, ByVal replaceAll As Boolean, ByVal con As Connection) As Boolean

        Try
            Select Case whereToApply
                Case "rbtnPreProc"

                Case "rbtnProc"
                    myJOBP.setProcess(buildPrePost_Process_REPLACE(myJOBP, strOLD, strNEW, myJOBP.getProcess, replaceAll))
                Case "rbtnPostProc"

                Case Else
                    LOG("ERROR: Cannot understand where to apply the additions!")

            End Select

            Dim save As SaveObject = New SaveObject(myJOBP)
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


    Private Function buildPrePost_Process_REPLACE(ByVal myJOBP As JobPlan, ByVal strOLD As String, ByVal strNEW As String, ByVal proc As String, ByVal replaceAll As Boolean) As String
        Dim nl = vbLf

        If replaceAll Then
            proc = strNEW
        Else
            proc = proc.Replace(strOLD, strNEW)
        End If

        Return proc
    End Function

#End Region

    Public Function getJOBPTasksRecurcive(ByVal jobpName As String, ByVal con As Connection) As List(Of String)

        Dim RES As List(Of String) = New List(Of String)
        Dim objName As UC4ObjectName = New UC4ObjectName(jobpName)
        Dim open As OpenObject = New OpenObject(objName, True, True)

        Try
            con.sendRequestAndWait(open)
        Catch ex As Exception
            LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
        End Try

        If Not open.getMessageBox Is Nothing Then
            LOG("ERROR: " + open.getMessageBox().getText() + " %% Object: " + jobpName + " returned a message box: ") ' + open.getMessageBox().getNumber())

        Else

            Dim openObject As UC4Object = open.getUC4Object
            addToList(RES, openObject.getName)

            If openObject.getClass.toString.Contains("JobPlan") Then
                Dim myWF As JobPlan = openObject
                addRangeToList(RES, iterateTasksJobPlan(myWF, con))

            ElseIf openObject.getClass.toString.Contains("WorkflowIF") Then
                Dim myWF As WorkflowIF = openObject
                addRangeToList(RES, iterateTasksWorkflowIF(myWF, con))

            ElseIf openObject.getClass.toString.Contains("WorkflowLoop") Then
                Dim myWF As WorkflowLoop = openObject
                addRangeToList(RES, iterateTasksWorkflowLoop(myWF, con))

            End If

            Dim close As CloseObject = New CloseObject(openObject)
            Try
                con.sendRequestAndWait(close)
            Catch ex As Exception
                LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
            End Try
        End If

        Return RES
    End Function

    Private Function iterateTasksJobPlan(ByVal myWF As JobPlan, ByVal con As Connection) As List(Of String)
        Dim RES As List(Of String) = New List(Of String)
        Dim itJPTask As java.util.Iterator = myWF.taskIterator
        While itJPTask.hasNext
            Dim task As JobPlanTask = itJPTask.next
            If Not task.getType.Equals("<START>") And Not task.getType.Equals("<END>") Then
                If task.getType = "JOBP" Then
                    LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                    addRangeToList(RES, getJOBPTasksRecurcive(task.getTaskName, con))
                Else
                    LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                    If task.getType.Equals("JOBS") Then
                        addRangeToList(RES, getObjectsfromJOBS(task.getTaskName.ToString, con))
                    Else
                        addToList(RES, task.getTaskName)
                    End If
                End If
            End If
        End While

        Dim itJPPrtp As java.util.Iterator = myWF.values.promptSetIterator
        While itJPPrtp.hasNext
            Dim item As PromptSetDefinition = itJPPrtp.next
            LOG(vbTab + "[PRPT] " + item.getName.toString)
            addToList(RES, item.getName.toString)
        End While

        Dim itJPSync As java.util.Iterator = myWF.syncs.iterator
        While itJPSync.hasNext
            Dim item As SyncItem = itJPSync.next
            LOG(vbTab + "[SYNC] " + item.getSyncObject.getName.ToString)
            addToList(RES, item.getSyncObject.getName.ToString)
        End While

        Return RES
    End Function

    Private Function iterateTasksWorkflowIF(ByVal myWF As WorkflowIF, ByVal con As Connection) As List(Of String)
        Dim RES As List(Of String) = New List(Of String)

        'Get condition
        Dim itCondition As java.util.Iterator = myWF.condition.iterator
        While itCondition.hasNext
            Dim itCond As ConditionOrAction = itCondition.next
            LOG(vbTab + "[" + itCond.getScriptName + "] " + itCond.getParameter("XC_P03"))
            addToList(RES, itCond.getParameter("XC_P03"))
        End While

        'True Branch
        Dim itTaskWFIFTrue As java.util.Iterator = myWF.trueTasksIterator
        LOG(vbTab + "[TRUE BRANCH]", True)
        While itTaskWFIFTrue.hasNext
            Dim task As JobPlanTask = itTaskWFIFTrue.next
            If Not task.getType.Equals("<START>") And Not task.getType.Equals("<END>") Then

                If task.getType = "JOBP" Then
                    LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                    addRangeToList(RES, getJOBPTasksRecurcive(task.getTaskName, con))
                Else
                    LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                    addToList(RES, task.getTaskName)
                End If
            End If
        End While

        'False Branch
        Dim itTaskWFIFFalse As java.util.Iterator = myWF.falseTasksIterator
        LOG(vbTab + "[FALSE BRANCH]", True)
        While itTaskWFIFFalse.hasNext
            Dim task As JobPlanTask = itTaskWFIFFalse.next
            If Not task.getType.Equals("<START>") And Not task.getType.Equals("<END>") Then
                If task.getType = "JOBP" Then
                    LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                    addRangeToList(RES, getJOBPTasksRecurcive(task.getTaskName, con))
                Else
                    LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                    addToList(RES, task.getTaskName)
                End If
            End If
        End While

        Dim itJPPrtp As java.util.Iterator = myWF.values.promptSetIterator
        While itJPPrtp.hasNext
            Dim item As PromptSetDefinition = itJPPrtp.next
            LOG(vbTab + "[PRPT] " + item.getName.toString)
            addToList(RES, item.getName.toString)
        End While

        Dim itJPSync As java.util.Iterator = myWF.syncs.iterator
        While itJPSync.hasNext
            Dim item As SyncItem = itJPSync.next
            LOG(vbTab + "[SYNC] " + item.getSyncObject.getName.ToString)
            addToList(RES, item.getSyncObject.getName.ToString)
        End While

        Return RES
    End Function

    Private Function iterateTasksWorkflowLoop(ByVal myWF As WorkflowLoop, ByVal con As Connection) As List(Of String)
        Dim RES As List(Of String) = New List(Of String)
        Dim itJPTask As java.util.Iterator = myWF.iterator

        If Not myWF.datasource.getVariableName Is Nothing Then
            addToList(RES, myWF.datasource.getVariableName.getName)
        ElseIf Not myWF.datasource.getArrayName Is Nothing Then
            addToList(RES, myWF.datasource.getArrayName)
        End If

        While itJPTask.hasNext
            Dim task As JobPlanTask = itJPTask.next
            If Not task.getType.Equals("<START>") Or Not task.getType.Equals("<END>") Then
                LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                If task.getType = "JOBP" Then
                    LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                    addRangeToList(RES, getJOBPTasksRecurcive(task.getTaskName, con))
                Else
                    LOG(vbTab + "[" + task.getType + "] " + task.getTaskName)
                    addToList(RES, task.getTaskName)
                End If
            End If
        End While

        Dim itJPPrtp As java.util.Iterator = myWF.values.promptSetIterator
        While itJPPrtp.hasNext
            Dim item As PromptSetDefinition = itJPPrtp.next
            LOG(vbTab + "[PRPT] " + item.getName.toString)
            addToList(RES, item.getName.toString)
        End While

        Dim itJPSync As java.util.Iterator = myWF.syncs.iterator
        While itJPSync.hasNext
            Dim item As SyncItem = itJPSync.next
            LOG(vbTab + "[SYNC] " + item.getSyncObject.getName.ToString)
            addToList(RES, item.getSyncObject.getName.ToString)
        End While

        Return RES
    End Function


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
