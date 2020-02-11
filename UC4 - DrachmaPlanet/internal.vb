Imports System
Imports System.IO
Imports System.Text
Imports System.Collections

Module internal


    Public Function readFileByLine(ByVal path As String) As List(Of String)
        Dim objListFromFile As New List(Of String)
        Try
            If File.Exists(path) Then
                Dim sr As StreamReader = New StreamReader(path)

                Do While sr.Peek() >= 0
                    objListFromFile.Add(sr.ReadLine())
                Loop
                sr.Close()

            End If
        Catch e As Exception
            LOG("ERROR: Could not read the file.", e.ToString())
        End Try
        Return objListFromFile
    End Function

    Public Sub appendToFile(ByVal msg As String, ByVal path As String)
        If Not File.Exists(path) Then
            Dim sw As StreamWriter = File.CreateText(path)
            sw.Close()
        End If
        
        Using sw As StreamWriter = File.AppendText(path)
            sw.WriteLine(msg)
            sw.Close()
        End Using
    End Sub

    Public Sub logFilesHousekeeping(ByVal targetDirectory As String)
        Try
            If Not Directory.Exists(targetDirectory) Then
                Dim di As DirectoryInfo = Directory.CreateDirectory(targetDirectory)
            End If

            Dim fileEntries As String() = Directory.GetFiles(targetDirectory, "*.txt", SearchOption.TopDirectoryOnly)
            If fileEntries.Length = 0 Then
                If Not File.Exists(targetDirectory + "\DP_log_000.txt") Then
                    Dim sw As StreamWriter = File.CreateText(targetDirectory + "\DP_log_000.txt")
                    sw.Dispose()
                End If
            End If
            For Each fileName In fileEntries
                If fileName.Contains("000") Then
                    For x = fileEntries.Length - 1 To 0 Step -1
                        Dim file = fileEntries(x)
                        Dim tempNameCounter As Integer
                        Dim tempName As String = ""
                        tempName = File.Substring(File.IndexOf("DP_log_") + 7)
                        tempName = tempName.Substring(0, tempName.LastIndexOf(".txt"))
                        tempNameCounter = Convert.ToInt32(tempName)
                        tempNameCounter += 1
                        tempName = String.Format("{0:000}", tempNameCounter)
                        tempName = "DP_log_" + String.Format("{0:000}", tempNameCounter) + ".txt"
                        My.Computer.FileSystem.RenameFile(File, tempName)
                    Next
                    Exit For

                Else
                    If Not File.Exists(targetDirectory + "\DP_log_000.txt") Then
                        Dim sw As StreamWriter = File.CreateText(targetDirectory + "\DP_log_000.txt")
                        sw.Dispose()
                    End If
                End If


            Next fileName
        Catch ex As Exception
            MsgBox("The process failed: " + ex.ToString())
        End Try
       

    End Sub

End Module
