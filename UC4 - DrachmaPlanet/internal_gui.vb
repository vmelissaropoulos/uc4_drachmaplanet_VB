Imports Microsoft.Win32

Module internal_gui_
    Public Sub loadSettings()
        With My.Settings
            frmLogin.cmbIP.Items.Clear()
            'For Each ip As String In .cmbIP
            '    frmLogin.cmbIP.Items.Add(ip)
            'Next
            For i = 0 To .cmbIP.Count - 1
                frmLogin.cmbIP.Items.Add(.cmbIP.Item(i).ToString)
            Next

            frmLogin.cmbIP.Text = .ip
            frmLogin.txtPort.Text = .port
            frmLogin.txtClient.Text = .client
            frmLogin.txtDep.Text = .dep
            frmLogin.cmbLang.Text = .lang
            frmLogin.txtUser.Text = .user
            frmLogin.txtPassword.Text = .pass



            'If .frmLogin_Left > Screen.PrimaryScreen.WorkingArea.Width - 100 And Screen.AllScreens.Length = 1 Then
            '    frmLogin.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (frmLogin.Width / 2)
            '    frmLogin.Top = 30
            'Else
            '    frmLogin.Left = .frmLogin_Left
            '    frmLogin.Top = .frmLogin_Top
            'End If



        End With
    End Sub

    Public Sub saveSettings()
        With My.Settings
            If Not frmLogin.cmbIP.Items.Contains(frmLogin.cmbIP.Text) Then .cmbIP.Add(frmLogin.cmbIP.Text)
            .ip = frmLogin.cmbIP.Text
            .port = frmLogin.txtPort.Text
            .client = frmLogin.txtClient.Text
            .dep = frmLogin.txtDep.Text
            .lang = frmLogin.cmbLang.Text
            .user = frmLogin.txtUser.Text
            .pass = frmLogin.txtPassword.Text
            .Save()
        End With
    End Sub

    Public Function WriteToRegistry(ByVal _
    ParentKeyHive As RegistryHive, _
    ByVal SubKeyName As String, _
    ByVal ValueName As String, _
    ByVal Value As Object) As Boolean

        'DEMO USAGE
        'Dim bAns As Boolean
        'bAns = WriteToRegistry(RegistryHive.LocalMachine, "SOFTWARE\MyCompany\MyProgram\", "ProgramHasRunBefore", "Y")
        'Debug.WriteLine("Registry Write Successful: " & bAns)

        Dim objSubKey As RegistryKey
        Dim objParentKey As RegistryKey
        Dim bAns As Boolean


        Try

            Select Case ParentKeyHive
                Case RegistryHive.ClassesRoot
                    objParentKey = Registry.ClassesRoot
                Case RegistryHive.CurrentConfig
                    objParentKey = Registry.CurrentConfig
                Case RegistryHive.CurrentUser
                    objParentKey = Registry.CurrentUser
                Case RegistryHive.LocalMachine
                    objParentKey = Registry.LocalMachine
                Case RegistryHive.PerformanceData
                    objParentKey = Registry.PerformanceData
                Case RegistryHive.Users
                    objParentKey = Registry.Users
                Case Else
                    objParentKey = Nothing
            End Select


            'Open 
            objSubKey = objParentKey.OpenSubKey(SubKeyName, True)
            'create if doesn't exist
            If objSubKey Is Nothing Then
                objSubKey = objParentKey.CreateSubKey(SubKeyName)
            End If


            objSubKey.SetValue(ValueName, Value)
            bAns = True
        Catch ex As Exception
            bAns = False

        End Try

        Return True

    End Function

    Public Function RegValue(ByVal Hive As RegistryHive, _
       ByVal Key As String, ByVal ValueName As String, _
       Optional ByRef ErrInfo As String = "") As String

        Dim objParent As RegistryKey
        Dim objSubkey As RegistryKey
        Dim sAns As String = ""
        Select Case Hive
            Case RegistryHive.ClassesRoot
                objParent = Registry.ClassesRoot
            Case RegistryHive.CurrentConfig
                objParent = Registry.CurrentConfig
            Case RegistryHive.CurrentUser
                objParent = Registry.CurrentUser
            Case RegistryHive.LocalMachine
                objParent = Registry.LocalMachine
            Case RegistryHive.PerformanceData
                objParent = Registry.PerformanceData
            Case RegistryHive.Users
                objParent = Registry.Users
            Case Else
                objParent = Nothing
        End Select

        Try
            objSubkey = objParent.OpenSubKey(Key)
            'if can't be found, object is not initialized
            If Not objSubkey Is Nothing Then
                sAns = (objSubkey.GetValue(ValueName))
            End If

        Catch ex As Exception

            ErrInfo = ex.Message
        Finally

            'if no error but value is empty, populate errinfo
            If ErrInfo = "" And sAns = "" Then
                ErrInfo = "No value found for requested registry key"
            End If
        End Try
        Return sAns
    End Function

    Public Sub saveForm(ByVal myForm As Form)
        With myForm
            WriteToRegistry(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Top", .Top)
            WriteToRegistry(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Left", .Left)
            WriteToRegistry(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Height", .Height)
            WriteToRegistry(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Width", .Width)
            'WriteToRegistry(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_WindowState", .WindowState)
        End With
    End Sub

    Public Sub loadForm(ByVal myForm As Form)
        With myForm
            .Top = RegValue(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Top", myForm.Top)
            .Left = RegValue(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Left", myForm.Left)
            .Height = RegValue(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Height", myForm.Height)
            .Width = RegValue(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Width", myForm.Width)
            '.WindowState = RegValue(RegistryHive.CurrentUser, My.Application.Info.AssemblyName, .Name + "_Width", .WindowState)
        End With
    End Sub

    Public Sub autoSizeListViewColToContents(ByVal listview As ListView)
        listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        'listview.Columns.Item(1).Width = 410
    End Sub

    Public Sub setListViewColWidth(ByVal listview As ListView, ByVal width As Integer)
        For x = 0 To listview.Columns.Count - 1
            listview.Columns.Item(x).Width = width
        Next
    End Sub
End Module
