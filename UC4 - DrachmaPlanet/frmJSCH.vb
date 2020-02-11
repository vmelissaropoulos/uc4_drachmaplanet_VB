Public Class frmJSCH

    Private Sub frmJSCH_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        saveForm(Me)
    End Sub

    Private Sub frmJSCH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadForm(Me)
        openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Ini files (*.ini)|*.ini"
        openFileDialog.Multiselect = False
    End Sub

    Private Sub btnIncludeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncludeList.Click
        OpenFileDialog.Title = "Select Include List File"
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtIncludeFile.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub btnCreateJSCHTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateJSCHTasks.Click
        MDIParent1.Cursor = Cursors.WaitCursor

        Dim myTaksListFromFile As List(Of String) = readFileByLine(txtIncludeFile.Text)
        addTaskToSchedule("JSCH.ROMANIA", myTaksListFromFile, MDIParent1.myConnection)

        MDIParent1.Cursor = Cursors.Arrow
    End Sub
End Class