Public Class frmLogger

    Private Sub frmLogger_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        My.Settings.log_height = Me.Height
        My.Settings.Save()
    End Sub

    Private Sub txtLOG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLOG.TextChanged
        txtLOG.SelectionStart = txtLOG.TextLength
        txtLOG.ScrollToCaret()
    End Sub
End Class