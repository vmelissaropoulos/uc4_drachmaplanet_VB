Imports System.Text.RegularExpressions

Module regexp
    Public Function regMatches(ByVal myString As String, ByVal pattern As String) As MatchCollection
        Dim RES As MatchCollection = Nothing

        Try
            Dim r As Regex = New Regex(pattern, RegexOptions.IgnoreCase)
            If String.IsNullOrEmpty(myString) Or String.IsNullOrEmpty(pattern) Then
                Return Nothing
            End If
            Dim m As MatchCollection = r.Matches(myString)
            If m.Count > 0 Then
                'For i = 0 To m.Count - 1
                '    LOG("REGEX[" + i.ToString + "]: " + m.Item(i).ToString)
                'Next
                RES = m
            End If
            Return RES
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try



    End Function



End Module