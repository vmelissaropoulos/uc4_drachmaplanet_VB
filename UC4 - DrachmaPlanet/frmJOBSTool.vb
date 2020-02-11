Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication.requests
Imports com.uc4.communication.Connection

Public Class frmJOBSTool
    Dim con As com.uc4.communication.Connection = MDIParent1.myConnection

    Private Sub frmJOBSTool_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        saveForm(Me)
    End Sub

    Private Sub frmJOBSTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadForm(Me)
    End Sub

    Private Sub btnBrowseList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseList.Click
        OpenFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Ini files (*.ini)|*.ini"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Title = "Select List File"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtIncludeFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnChangeLogins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeLogins.Click

        MDIParent1.Cursor = Cursors.WaitCursor

        LOG("Setting LOGIN informatin for objects in list...", True)

        Dim myObjListFromFile As List(Of String) = readFileByLine(txtIncludeFile.Text)

        For Each obj As String In myObjListFromFile

            If chkLoginDryRun.Checked Then
                Dim myLogin As UC4ObjectName = New UC4ObjectName(obj)

                Dim open As OpenObject = New OpenObject(New UC4ObjectName(obj), False, True)

                con.sendRequestAndWait(open)
                If (Not open.getMessageBox() Is Nothing) Then
                    LOG("ERROR:  " + open.getMessageBox.getText)
                End If

                Dim openObject As UC4Object = open.getUC4Object

                If openObject.getType.StartsWith("JOBS") Then

                    Dim myJob As Job = openObject
                    Dim result As String = setLoginInJOBS(myJob, myLogin, chkLoginDryRun.Checked, con)
                    LOG(obj + ";" + result, False)

                    If result = "False" Then
                        LOG("LOGIN ERR: Login could not be set!")
                    End If
                End If

                Dim close As CloseObject = New CloseObject(openObject)
                Try
                    con.sendRequestAndWait(close)
                Catch ex As Exception
                    LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                End Try

            Else
                Dim objSplit As String() = obj.Split(";")
                LOG("Working on " + objSplit(0)) ' + " [" + objSplit(1) + "]")

                Dim myLogin As UC4ObjectName = New UC4ObjectName(objSplit(1))

                Dim open As OpenObject = New OpenObject(New UC4ObjectName(objSplit(0)), False, True)

                con.sendRequestAndWait(open)
                If (Not open.getMessageBox() Is Nothing) Then
                    LOG("ERROR:  " + open.getMessageBox.getText)
                End If

                Dim openObject As UC4Object = open.getUC4Object

                If openObject.getType.StartsWith("JOBS") Then

                    Dim myJob As Job = openObject
                    Dim result As String = setLoginInJOBS(myJob, myLogin, chkLoginDryRun.Checked, con)

                    If result = "False" Then
                        LOG("LOGIN ERR: Login could not be set!")
                    End If

                    If chkLoginDryRun.Checked Then
                        LOG("Current: " + result + " - Will set: " + objSplit(1))
                    End If
                End If


                Dim close As CloseObject = New CloseObject(openObject)
                Try
                    con.sendRequestAndWait(close)
                Catch ex As Exception
                    LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                End Try
            End If

        Next
        LOG("Finished!", True)
        MDIParent1.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnSetShell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShell.Click
        MDIParent1.Cursor = Cursors.WaitCursor

        LOG("Setting SHELL information for objects in list...", True)

        Dim myShellList As List(Of String) = readFileByLine(txtShellFile.Text)
        Dim shellMapping As New Hashtable
        'Dim shellMapKey As DictionaryEntry

        Dim shellNODE As String = ""
        Dim shellUSER As String = ""
        Dim shellSHELL As String = ""

        LOG("Mapping Node Users to Shell...", True)
        For Each userShell As String In myShellList
            shellNODE = userShell.Split(";")(0).ToUpper
            shellUSER = userShell.Split(";")(1).ToUpper
            shellSHELL = userShell.Split(";")(2).ToLower

            shellMapping.Add("LOGIN." + shellNODE + "." + shellUSER, shellSHELL)
            LOG("LOGIN." + shellNODE + "." + shellUSER + ": " + shellMapping("LOGIN." + shellNODE + "." + shellUSER).ToString)
        Next
        LOG("Done")


        Dim myObjListFromFile As List(Of String) = readFileByLine(txtObjectsListFile.Text)

        For Each obj As String In myObjListFromFile
            LOG("Working on " + obj, True)
            Dim open As OpenObject = New OpenObject(New UC4ObjectName(obj), False, True)

            con.sendRequestAndWait(open)
            If (Not open.getMessageBox() Is Nothing) Then
                LOG("ERROR:  " + open.getMessageBox.getText)
            End If

            Dim openObject As UC4Object = open.getUC4Object

            If openObject.getType = "JOBS_UNIX" Then

                Dim myJob As Job = openObject
                Dim myJobLogin As String = myJob.attributes.getLogin.toString
                Try
                    Dim myShell As String = shellMapping(myJobLogin).ToString
                    Dim result As String = setSHELLInJOBS(myJob, myShell, chkShellDryRun.Checked, con)

                    If result = "False" Then LOG("LOGIN ERR: Shell could not be set!")
                    If chkShellDryRun.Checked Then LOG("Current: " + result + " - Will set to: " + myShell)
                    If result = "True" Then LOG("SHELL ok: " + myJobLogin + " [" + myShell + "]")

                Catch ex As Exception
                    LOG("SHELL ERR: Could not find the correct shell maping for " + myJobLogin)
                End Try

            Else
                LOG("SHELL Skip: Not a UNIX JOBS")
            End If


            Dim close As CloseObject = New CloseObject(openObject)
            Try
                con.sendRequestAndWait(close)
            Catch ex As Exception
                LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
            End Try

        Next
        LOG("Finished!", True)
        MDIParent1.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnObjectsListFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObjectsListFile.Click
        OpenFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Ini files (*.ini)|*.ini"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Title = "Select Objects List File"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtObjectsListFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnShellFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShellFile.Click
        OpenFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Ini files (*.ini)|*.ini"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Title = "Select Objects List File"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtShellFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnBrowseHostList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseHostList.Click
        OpenFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Ini files (*.ini)|*.ini"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Title = "Select List File"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtIncludeFileHosts.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnChangeHosts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeHosts.Click
        MDIParent1.Cursor = Cursors.WaitCursor

        LOG("Setting HOST information for objects in list...", True)

        Dim myObjListFromFile As List(Of String) = readFileByLine(txtIncludeFileHosts.Text)

        For Each obj As String In myObjListFromFile

            If chkHostDryRun.Checked Then
                Dim myHost As UC4HostName = New UC4HostName(obj)

                Dim open As OpenObject = New OpenObject(New UC4ObjectName(obj), False, True)

                con.sendRequestAndWait(open)
                If (Not open.getMessageBox() Is Nothing) Then
                    LOG("ERROR:  " + open.getMessageBox.getText)
                End If

                Dim openObject As UC4Object = open.getUC4Object

                If openObject.getType.StartsWith("JOBS") Then

                    Dim myJob As Job = openObject
                    Dim result As String = setHostInJOBS(myJob, myHost, chkHostDryRun.Checked, con)
                    LOG(obj + ";" + result, False)

                    If result = "False" Then
                        LOG("HOST ERR: Host could not be set!")
                    End If
                End If

                Dim close As CloseObject = New CloseObject(openObject)
                Try
                    con.sendRequestAndWait(close)
                Catch ex As Exception
                    LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                End Try

            Else
                Dim objSplit As String() = obj.Split(";")
                LOG("Working on " + objSplit(0)) ' + " [" + objSplit(1) + "]")

                Dim myHost As UC4HostName = New UC4HostName(objSplit(1))

                Dim open As OpenObject = New OpenObject(New UC4ObjectName(objSplit(0)), False, True)

                con.sendRequestAndWait(open)
                If (Not open.getMessageBox() Is Nothing) Then
                    LOG("ERROR:  " + open.getMessageBox.getText)
                End If

                Dim openObject As UC4Object = open.getUC4Object

                If openObject.getType.StartsWith("JOBS") Then

                    Dim myJob As Job = openObject
                    Dim result As String = setHostInJOBS(myJob, myHost, chkHostDryRun.Checked, con)

                    If result = "False" Then
                        LOG("HOST ERR: Host could not be set!")
                    End If

                    If chkHostDryRun.Checked Then
                        LOG("Current: " + result + " - Will set: " + objSplit(1))
                    End If
                End If


                Dim close As CloseObject = New CloseObject(openObject)
                Try
                    con.sendRequestAndWait(close)
                Catch ex As Exception
                    LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                End Try
            End If
            

        Next
        LOG("Finished!", True)
        MDIParent1.Cursor = Cursors.Arrow
    End Sub
End Class