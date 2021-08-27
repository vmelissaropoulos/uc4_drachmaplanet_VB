Imports System.Windows.Forms
Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication
Imports com.uc4.communication.requests


'Some Comments
Public Class MDIParent1
    Public myConnection As Connection
    Public selectedFolder As String = ""
    Private incNumberEND As Integer = 1
    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        saveForm(Me)
    End Sub

    Private Sub MDIParent1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not IsNothing(myConnection) Then
            Try
                myConnection.close()
            Catch ex As Exception
                MsgBox("Could not close connection!" + vbCrLf + ex.Message + vbCrLf + vbCrLf + "No worries! Propably no connection was made in the first place.", vbOKOnly + vbInformation, "Connection Close")
            End Try
        End If
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadForm(Me)
        frmLogin.ShowDialog(Me)
        logFilesHousekeeping(Application.StartupPath + "\Temp")
        LOG("Program initialized. Ready to go..")
    End Sub

    Private Sub PrintPreviewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogToolStripButton.Click
        frmLogger.MdiParent = Me
        frmLogger.Height = My.Settings.log_height
        frmLogger.Dock = DockStyle.Bottom

        If frmLogger.Visible = True Then
            frmLogger.Visible = False
        Else
            frmLogger.Visible = True
            frmLogger.txtLOG.SelectionStart = frmLogger.txtLOG.TextLength
            frmLogger.txtLOG.ScrollToCaret()
        End If
    End Sub

    Private Sub RenameToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolToolStripMenuItem.Click, RenameToolToolStripButton.Click
        frmRename.MdiParent = Me
        frmRename.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolsStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem1.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub


    Private Sub StatusBarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem1.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem1.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem1.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem1.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeIconsToolStripMenuItem1.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem1.Click
        For Each ChildForm As System.Windows.Forms.Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.Cursor = Cursors.WaitCursor

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        'Search for text everywhere
        Me.Cursor = Cursors.WaitCursor
        Dim mySearch As List(Of SearchResultItem) = searchForTextAll("Vasilis Melissaropoulos", True, False, False, False, myConnection)
        If Not mySearch Is Nothing Then


            For Each searchResult In mySearch
                LOG(searchResult.getName)
            Next
        Else
            LOG("No results")
        End If

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        'fetch objects under folder (recurcive ability)
        populateTreeView(frmSelectFolder.tvSelectFolder, getAllFolders(True, myConnection))
        frmSelectFolder.ShowDialog(Me)
        If Not selectedFolder = "" Then
            Me.Cursor = Cursors.WaitCursor
            Dim myList As List(Of String) = fetchAllObjectsInFolder(selectedFolder, False, myConnection)

            If myList.Count > 0 Then
                For Each item In myList
                    LOG("---))>>> " + item)
                Next
            Else
                LOG("No results")
            End If
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ''sample call of selectFolder form
        'populateTreeView(frmSelectFolder.tvSelectFolder, getAllFolders(True, myConnection))
        'frmSelectFolder.ShowDialog(Me)
        'LOG(selectedFolder)

        checkJOBS("JOBS.COLROMDBSR.BULKCOLERR", False, myConnection)
    End Sub

    Private Sub AnalyseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalyseToolStripMenuItem.Click
        frmAnalysis.MdiParent = Me
        frmAnalysis.Show()
    End Sub

    Private Sub MoveToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToolToolStripMenuItem.Click
        frmMove.MdiParent = Me
        frmMove.Show()
    End Sub

    Private Sub ScheduleToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduleToolToolStripMenuItem.Click
        frmJSCH.MdiParent = Me
        frmJSCH.Show()
    End Sub

    Private Sub PreProcessPostToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreProcessPostToolToolStripMenuItem.Click
        frmPrePost_Process.MdiParent = Me
        frmPrePost_Process.Show()
    End Sub

    Private Sub OpenLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLogToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath + "\Temp\DP_log_000.txt")
    End Sub

    Private Sub DeleteToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolToolStripMenuItem.Click
        frmDelete.MdiParent = Me
        frmDelete.Show()
    End Sub

    Private Sub JOBSToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JOBSToolToolStripMenuItem.Click
        frmJOBSTool.MdiParent = Me
        frmJOBSTool.Show()
    End Sub
End Class
