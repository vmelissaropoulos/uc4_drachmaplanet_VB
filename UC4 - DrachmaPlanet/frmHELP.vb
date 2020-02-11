Imports System.Windows.Forms

Public Class frmHELP
    Private Sub frmHELP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "frmRename_REGEX" Then
            Me.Text = ".NET Regural Expression quick reference"
            Dim uriRegexRef As Uri = New Uri("https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference#top")
            webHELP.Url = uriRegexRef
        End If
    End Sub
End Class
