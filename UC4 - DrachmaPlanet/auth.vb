Imports com.uc4.api
Imports com.uc4.communication
Imports com.uc4.communication.requests

Module auth

    Public Function connect(ByVal myIP As String, ByVal myPort As Integer, ByVal myClient As Integer, ByVal myUser As String, ByVal myDep As String, ByVal myPassword As String, ByVal myLanguage As Char, ByVal myConnection As Connection) As Connection
        With frmLogin

            .Cursor = Cursors.WaitCursor

            'Select Case .btnConnect.Text
            'Case "Connect"
            Try
                LOG("Please wait... Trying to connect at " + myIP + " : " + myPort.ToString)
                myConnection = Connection.open(myIP, myPort)
            Catch ex As Exception
                .Cursor = Cursors.Arrow
                LOG("ERROR: " + ex.Message)
                Return myConnection
            End Try

            'Dim client As Integer = Integer.Parse(.txtClient.Text)
            'Dim user As String = .txtUser.Text
            'Dim dep As String = .txtDep.Text
            'Dim password As String = .txtPassword.Text
            'Dim language As Char = Char.Parse(.cmbLang.Text)
            Dim myRes = myConnection.login(myClient, myUser, myDep, myPassword, myLanguage)

            If (myRes.isLoginSuccessful) Then
                MDIParent1.ToolStripStatusLabel.Text = myRes.getWelcomeMessage
                MDIParent1.Text = myRes.getSystemName() + " - " + myClient.ToString + " - " + myRes.getUserObject.getName.ToString
                LOG("Success!")
                LOG("====== Connection Info ======")
                'LOG("CP HostName: " + myConnection.getCpAddress.getHostName + _
                '    "CP Address: " + myConnection.getCpAddress.getAddress.toString + _
                '    "CP Port: " + myConnection.getCpAddress.getPort.ToString + _
                '    "CPAddress: " + myConnection.getCpAddress.getAddress.toString)
                LOG(myRes.getWelcomeMessage())
                LOG("SessionID: " + myRes.getSessionID())
                LOG("System Name: " + myRes.getSystemName())
                LOG("User Name: " + myRes.getUserName())
                LOG("UserIdnr: " + myRes.getUserIdnr())
                LOG("Encoding: " + myRes.getEncoding())
                LOG("=============================")
                saveSettings()
                Return myConnection
                .Close()
            Else
                MDIParent1.ToolStripStatusLabel.Text = "ERROR: Connection could not be established! Check Log.."
                LOG("ERROR: Connection could not be established! Check Log..")
                LOG("====== Values Passed ======")
                LOG("IP: " + myIP)
                LOG("Port: " + myPort.ToString)
                LOG("Client: " + myClient.ToString)
                LOG("Language: " + myLanguage)
                LOG("User Name: " + myUser)
                LOG("Department: " + myDep)
                LOG("Password(len): " + myPassword.Length.ToString)
                LOG("============================")
                Return myConnection
            End If

            'enableDisableControls(Me.groupConnectionInfo, {"btnConnect"}, False)

            'Case "Disconnect"
            'myConnection.close()
            'MDIParent1.Text = "Disconnected"
            'LOG("Disconnected")
            '.btnConnect.Text = "Connect"
            'End Select

            .Cursor = Cursors.Arrow
        End With
    End Function
End Module
