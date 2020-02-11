Imports com.uc4.api
Imports com.uc4.api.objects
Imports com.uc4.communication.requests

Public Class frmPrePost_Process

    Private Sub btnIncludeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncludeList.Click
        openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|Ini files (*.ini)|*.ini"
        openFileDialog.Multiselect = False
        openFileDialog.Title = "Select Include List File"
        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtIncludeFile.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub frmPrePost_rocess_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        saveForm(Me)
    End Sub

    Private Sub frmPrePost_rocess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadForm(Me)
        With txtStrToReplaceOLD
            .ForeColor = Color.Gray
            .Text = "Replace this"
        End With

        With txtStrToReplaceNEW
            .ForeColor = Color.Gray
            .Text = "With this"
        End With
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If MsgBox("This only works for JOBS and JOBP objects for now!" + vbCrLf + "Please make sure that the objects in list file are all JOBS/JOBP objects." + vbCrLf + vbCrLf + "Continue?", vbInformation + MsgBoxStyle.YesNo, "Attention please!") = MsgBoxResult.No Then Exit Sub

        MDIParent1.Cursor = Cursors.WaitCursor
        Dim whereToApplyText As String = ""
        Dim whereToApply As String = ""
        For Each rBTN As RadioButton In groupBoxRBTNs.Controls
            If rBTN.Checked Then
                whereToApply = rBTN.Name
                whereToApplyText = rBTN.Text
            End If

        Next

        LOG("Adding script into " + whereToApplyText, True)
        For Each myObject As String In readFileByLine(txtIncludeFile.Text)
            LOG("Working on " + myObject, True)

            Dim objName As UC4ObjectName = New UC4ObjectName(myObject)
            Dim open As OpenObject = New OpenObject(objName, False, True)


            Try
                MDIParent1.myConnection.sendRequestAndWait(open)

                If Not open.getMessageBox Is Nothing Then
                    LOG("ERROR: " + open.getMessageBox().getText() + " %% Object: " + myObject + " returned a message box: ") ' + open.getMessageBox().getNumber())
                    Exit Sub
                Else

                    Dim openObject As UC4Object = open.getUC4Object

                    If open.getType.ToString.StartsWith("JOBS_") Then
                        Dim myOBJ As Job = openObject
                        If chkReplaceFirst.Checked Then
                            If Not String.IsNullOrEmpty(txtStrToReplaceOLD.Text) Or Not chkReplaceAll.Checked Then If Not replaceJOBSProcess(myOBJ, txtStrToReplaceOLD.Text, txtStrToReplaceNEW.Text, whereToApply, chkReplaceAll.Checked, MDIParent1.myConnection) Then LOG("ERROR: Failed to replace for " + myObject)
                            If Not String.IsNullOrEmpty(txtStrToAdd.Text) Then If Not addJOBSProcess(myOBJ, txtStrToAdd.Text, whereToApply, chkAppend.Checked, MDIParent1.myConnection) Then LOG("ERROR: Failed adding into " + myObject)
                        Else
                            If Not String.IsNullOrEmpty(txtStrToAdd.Text) Then If Not addJOBSProcess(myOBJ, txtStrToAdd.Text, whereToApply, chkAppend.Checked, MDIParent1.myConnection) Then LOG("ERROR: Failed adding into " + myObject)
                            If Not String.IsNullOrEmpty(txtStrToReplaceOLD.Text) Or Not chkReplaceAll.Checked Then If Not replaceJOBSProcess(myOBJ, txtStrToReplaceOLD.Text, txtStrToReplaceNEW.Text, whereToApply, chkReplaceAll.Checked, MDIParent1.myConnection) Then LOG("ERROR: Failed to replace for " + myObject)
                        End If
                    ElseIf open.getType.ToString.StartsWith("JOBP") Then
                        Dim myOBJ As JobPlan = openObject
                        If chkReplaceFirst.Checked Then
                            If Not String.IsNullOrEmpty(txtStrToReplaceOLD.Text) Or Not chkReplaceAll.Checked Then If Not replaceJOB_PLANProcess(myOBJ, txtStrToReplaceOLD.Text, txtStrToReplaceNEW.Text, whereToApply, chkReplaceAll.Checked, MDIParent1.myConnection) Then LOG("ERROR: Failed to replace for " + myObject)
                            If Not String.IsNullOrEmpty(txtStrToAdd.Text) Then If Not addJOB_PLANProcess(myOBJ, txtStrToAdd.Text, whereToApply, chkAppend.Checked, MDIParent1.myConnection) Then LOG("ERROR: Failed adding into " + myObject)
                        Else
                            If Not String.IsNullOrEmpty(txtStrToAdd.Text) Then If Not addJOB_PLANProcess(myOBJ, txtStrToAdd.Text, whereToApply, chkAppend.Checked, MDIParent1.myConnection) Then LOG("ERROR: Failed adding into " + myObject)
                            If Not String.IsNullOrEmpty(txtStrToReplaceOLD.Text) Or Not chkReplaceAll.Checked Then If Not replaceJOB_PLANProcess(myOBJ, txtStrToReplaceOLD.Text, txtStrToReplaceNEW.Text, whereToApply, chkReplaceAll.Checked, MDIParent1.myConnection) Then LOG("ERROR: Failed to replace for " + myObject)
                        End If
                    Else
                        LOG("Object type [" + open.getType.ToString + "] not implemented yet!")
                    End If


                    Dim close As CloseObject = New CloseObject(openObject)
                    MDIParent1.myConnection.sendRequestAndWait(close)
                    If (Not close.getMessageBox() Is Nothing) Then
                        LOG("ERROR:  " + close.getMessageBox.getText)
                        Exit Sub
                    End If

                End If
            Catch ex As Exception
                LOG("ERROR: " + ex.InnerException.ToString + " - " + ex.Message)
                Exit Sub
            End Try

        Next
        LOG("Finished")
        MDIParent1.Cursor = Cursors.Arrow
    End Sub

    Private Sub chkReplaceAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReplaceAll.CheckedChanged
        If chkReplaceAll.Checked Then
            txtStrToReplaceOLD.Enabled = False
        Else
            txtStrToReplaceOLD.Enabled = True
        End If

    End Sub

    Private Sub txtStrToReplaceOLD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStrToReplaceOLD.GotFocus
        With txtStrToReplaceOLD
            If .ForeColor = Color.Gray Then
                .ForeColor = Color.Black
                .Text = ""
            End If
        End With
    End Sub

    Private Sub txtStrToReplaceNEW_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStrToReplaceNEW.GotFocus
        With txtStrToReplaceNEW
            If .ForeColor = Color.Gray Then
                .ForeColor = Color.Black
                .Text = ""
            End If
        End With
    End Sub

    Private Sub txtStrToReplaceNEW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStrToReplaceNEW.TextChanged
        btnAdd.Enabled = mustEnable(groupBoxRBTNs)
    End Sub

    Private Sub txtStrToReplaceOLD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStrToReplaceOLD.TextChanged
        btnAdd.Enabled = mustEnable(groupBoxRBTNs)
    End Sub

    Private Sub txtStrToAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStrToAdd.TextChanged
        btnAdd.Enabled = mustEnable(groupBoxRBTNs)
    End Sub

    Private Sub rbtnPreProc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnPostProc.CheckedChanged, rbtnPreProc.CheckedChanged, rbtnProc.CheckedChanged
        btnAdd.Enabled = mustEnable(groupBoxRBTNs)
    End Sub

    Private Sub txtIncludeFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIncludeFile.TextChanged
        btnAdd.Enabled = mustEnable(groupBoxRBTNs)
    End Sub

    Private Function mustEnable(ByVal myGroupBox As GroupBox) As Boolean
        If Not String.IsNullOrEmpty(txtIncludeFile.Text) Then
            If Not String.IsNullOrEmpty(txtStrToAdd.Text) Or (Not String.IsNullOrEmpty(txtStrToReplaceOLD.Text)) Or (Not String.IsNullOrEmpty(txtStrToReplaceNEW.Text) And chkReplaceAll.Checked) Then
                For Each myRBTN As RadioButton In myGroupBox.Controls
                    If myRBTN.Checked Then
                        Return True
                    End If
                Next
            End If
        End If
        Return False
    End Function

    
End Class