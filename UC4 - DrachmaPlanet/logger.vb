
Module logger
    Public Sub LOG(ByVal msg As String, Optional ByVal crlf As Boolean = False)
        'Dim my_msg = msg
        If crlf Then msg = vbCrLf + msg

        frmLogger.txtLOG.AppendText(msg + vbCrLf)

        If Not crlf Then msg = FormatDateTime(Now, DateFormat.LongTime) + ": " + msg
        appendToFile(msg, Application.StartupPath + "\Temp\DP_log_000.txt")

        If Not msg Is Nothing Then
            If msg.Contains("ERROR:") Then MsgBox(msg, vbOKOnly + vbCritical, "ERROR")
            If msg.Contains("WARNING: ") Then MsgBox(msg, vbOKOnly + vbExclamation, "WARNING")
            If msg.Contains("INFO: ") Then MsgBox(msg, vbOKOnly + vbInformation, "INFORMATION")
        End If
    End Sub
End Module
