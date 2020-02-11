Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.api.objects.Job
Imports com.uc4.api.objects.JobAttributes
Imports com.uc4.communication
Imports com.uc4.communication.requests



Module objJOBS
    Private saveFlag As Boolean = False

    Public Sub checkJOBS(ByVal jobName As String, ByVal readOnlyMode As Boolean, ByVal con As Connection)
        saveFlag = False

        Dim objName As UC4ObjectName = New UC4ObjectName(jobName)
        Dim open As OpenObject = New OpenObject(objName, readOnlyMode, True)

        Try
            con.sendRequestAndWait(open)
        Catch ex As Exception
            LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
        End Try

        If Not open.getMessageBox Is Nothing Then
            LOG("ERROR: " + open.getMessageBox().getText() + vbCrLf + " %% Object: " + jobName + " returned a message box: " + open.getMessageBox().getNumber())
        End If

        Dim openObject As UC4Object = open.getUC4Object
        Dim myJob As Job = openObject

        If myJob.getType.Equals("JOBS_UNIX") Then
            Try
                LOG("Analysing: " + vbTab + myJob.getName)
                checkJOBS_UNIX(myJob, con, readOnlyMode)
            Catch ex As Exception
                LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
            End Try
        ElseIf myJob.getType.Equals("JOBS_WINDOWS") Then
            Try
                'checkJOBS_WIN(myJob, connSource, readMode);
            Catch ex As Exception
                LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
            End Try
        End If

        Dim close As CloseObject = New CloseObject(myJob)
        con.sendRequestAndWait(close)
        If Not close.getMessageBox Is Nothing Then
            LOG("ERROR: " + open.getMessageBox().getText() + vbCrLf + " %% Object: " + jobName + " returned a message box: " + open.getMessageBox().getNumber())
        End If

    End Sub

    Public Sub checkJOBS_UNIX(ByVal myJob As Job, ByVal con As Connection, ByVal readOnlyMode As Boolean)
        Dim hostattributesUNIX As AttributesUnix = myJob.hostAttributes
        Dim save As SaveObject = Nothing
        If Not readOnlyMode Then
            save = New SaveObject(myJob)
        End If
        Dim close As CloseObject = New CloseObject(myJob)

        If myJob.attributes.getLogin.toString = "" Then
            LOG("Issue: " + vbTab + "Login for current JOBS is empty! Please check")
            If readOnlyMode Then

            End If
        End If

        If myJob.attributes.isGenerateAtRuntime = False Then
            LOG("Issue: " + vbTab + "Generate at runtime is disabled!")
            If Not readOnlyMode Then
                myJob.attributes.setGenerateAtRuntime(True)
                saveFlag = True
            End If
        End If


        If saveFlag And Not readOnlyMode Then
            con.sendRequestAndWait(save)
            If Not save.getMessageBox Is Nothing Then
                LOG("ERROR: " + save.getMessageBox().getText())
            Else
                LOG("Changes saved!")
            End If
        End If


    End Sub

End Module
