Imports com.uc4.api
Imports com.uc4.communication
Imports com.uc4.communication.requests


Public Class frmRename
    Private incNumberEND As Integer = 1

    Private Sub btnSelectUnselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectUnselectAll.Click
        If btnSelectUnselectAll.Text = "Select All" Then
            For Each item As ListViewItem In lvPreview.Items
                item.Checked = True
            Next
            btnSelectUnselectAll.Text = "Select None"
        ElseIf btnSelectUnselectAll.Text = "Select None" Then
            For Each item As ListViewItem In lvPreview.Items
                item.Checked = False
            Next
            btnSelectUnselectAll.Text = "Select All"
        End If
        'makePreview()
    End Sub

    Private Sub btnTongleSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTongleSelection.Click
        For Each item As ListViewItem In lvPreview.Items
            If item.Checked = True Then
                item.Checked = False
            Else
                item.Checked = True
            End If
        Next

        If lvPreview.CheckedItems.Count = 0 Then btnSelectUnselectAll.Text = "Select All"
        If lvPreview.CheckedItems.Count = lvPreview.Items.Count Then btnSelectUnselectAll.Text = "Select None"

        'makePreview()
    End Sub

    Private Sub btnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO.Click
        makePreview()

        'If btnConnect.Text = "Disconnect" Then
        If lvPreview.CheckedItems.Count > 0 Then
            LOG("Building rename list..")
            frmReplaceListDialog.lvRenameList.Items.Clear()
            Dim renameList As String = ""
            For x = 0 To lvPreview.Items.Count - 1
                If lvPreview.Items.Item(x).Checked = True Then
                    Dim itemNEW As New ListViewItem({lvPreview.Items.Item(x).SubItems(0).Text, lvPreview.Items.Item(x).SubItems(1).Text, ""})
                    frmReplaceListDialog.lvRenameList.Items.Add(itemNEW)
                    renameList = renameList + "RENAME: " + lvPreview.Items.Item(x).SubItems(0).Text + " _to_ " + lvPreview.Items.Item(x).SubItems(1).Text + vbCrLf
                End If
            Next

            LOG(renameList)

            autoSizeListViewColToContents(frmReplaceListDialog.lvRenameList)
            frmReplaceListDialog.ShowDialog()

        End If
        'Else
        'MsgBox("Please connect with AE first!", vbOKOnly + vbInformation, "No Active Connection")
        'End If

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        makePreview()
    End Sub

    Private Sub btnBrowseRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseRename.Click

        populateTreeView(frmBrowser.tvAllFolders, getAllFolders(True, MDIParent1.myConnection))

        frmBrowser.Tag = Me.Name
        frmBrowser.ShowDialog(Me)
    End Sub

    Private Sub btnRemoveFromRenameList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFromRenameList.Click
        For Each item As ListViewItem In lvPreview.Items
            If item.Checked = False Then lvPreview.Items.Item(item.Index).Remove()
        Next
    End Sub

    Private Sub lvPreview_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lvPreview.ItemChecked
        'makePreview()
    End Sub


    Public Sub makePreview()
        incNumberEND = 0

        'Check that "Replace" > "With" is correclty filled.
        If txtRepaceName.Lines.Length = txtWithName.Lines.Length Then
            'Check if there are any empty lines
            For Each ln As String In txtRepaceName.Lines
                If ln = "" Then
                    MsgBox("NO empty lines allowed!" + vbCrLf + "'Replace' textbox contains empty lines.", vbOKOnly + vbInformation, "No Cheating!")
                    Exit Sub
                End If
            Next
            For Each ln As String In txtWithName.Lines
                If ln = "" Then
                    MsgBox("NO empty lines allowed!" + vbCrLf + "'With' textbox contains empty lines.", vbOKOnly + vbInformation, "No Cheating!")
                    Exit Sub
                End If
            Next
        Else
            MsgBox("NO empty lines allowed!" + vbCrLf + vbCrLf + "Lines count between 'Replace' and 'With' textboxes DO NOT match!" + vbCrLf + _
                   "Maybe there is an empty last line somewhere?", vbOKOnly + vbInformation, "No Cheating!")
            Exit Sub
        End If

        'Construct Prefix
        Dim strPrefixName As String = ""
        If Not String.IsNullOrEmpty(txtPrefix1.Text) And Not cmbDelimiterPrefix1_2.SelectedIndex = -1 Then strPrefixName = txtPrefix1.Text
        'If Not txtPrefix2.Text = "" And Not cmbDelimiterPrefix2_3.SelectedIndex = -1 Then strPrefixName = strPrefixName + txtPrefix2.Text + cmbDelimiterPrefix2_3.Text
        'If Not txtPrefix3.Text = "" Then strPrefixName = strPrefixName + txtPrefix3.Text + "."
        'MsgBox(strPrefixName)

        'Construct Suffix
        Dim strSuffixName As String = ""
        If Not String.IsNullOrEmpty(txtSuffix1.Text) Then strSuffixName = txtSuffix1.Text
        'If Not txtSuffix2.Text = "" And Not cmbDelimiterSuffix1_2.SelectedIndex = -1 Then strSuffixName = strSuffixName + cmbDelimiterSuffix1_2.Text + txtSuffix2.Text
        'If Not txtSuffix3.Text = "" And Not cmbDelimiterSuffix2_3.SelectedIndex = -1 Then strSuffixName = strSuffixName + cmbDelimiterSuffix2_3.Text + txtSuffix3.Text


        'Get Replacement Rules
        Dim listReplaceName, listWithName As New List(Of String)
        For Each ln As String In txtRepaceName.Lines
            listReplaceName.Add(ln)
        Next
        For Each ln As String In txtWithName.Lines
            listWithName.Add(ln)
        Next

        'Make replacements
        If lvPreview.CheckedItems.Count > 0 Then
            Dim checkedCount As Integer = 0
            For x As Integer = 0 To lvPreview.Items.Count - 1

                Dim tempFullName = ""
                Dim myColor As Color = Color.White
                'Get the actual name
                Dim tmpName = evaluateRegEx(lvPreview.Items.Item(x).SubItems(0).Text)

                If lvPreview.Items.Item(x).Checked = False Then
                    tempFullName = lvPreview.Items.Item(x).SubItems(0).Text
                    myColor = Color.White
                Else
                    checkedCount += 1
                    For ln As Integer = 0 To listReplaceName.Count - 1
                        If Not listReplaceName.Item(ln).Contains("|") And listWithName.Item(ln).Contains("|") Then
                            tmpName = tmpName.Replace(listReplaceName.Item(ln), listWithName.Item(ln))
                        Else
                            Dim tempList As Array
                            tempList = listReplaceName.Item(ln).Split("|")
                            For j As Integer = 0 To tempList.Length - 1
                                tmpName = tmpName.Replace(Trim(tempList(j)), listWithName.Item(ln))
                            Next

                        End If
                    Next

                    'Increament Prefix
                    Dim strPrefixNumberEND As String = Nothing
                    If chkPrefixIncNumberEND.Checked = True Then
                        strPrefixNumberEND = checkedCount.ToString
                    End If
                    Dim strPrefixNumberSTART As String = Nothing
                    If chkPrefixIncNumberSTART.Checked = True Then
                        strPrefixNumberSTART = checkedCount.ToString
                    End If

                    Dim strSuffixNumberEND As String = Nothing
                    If chkSuffixIncNumberEND.Checked = True Then
                        strPrefixNumberEND = checkedCount.ToString
                    End If
                    Dim strSuffixNumberSTART As String = Nothing
                    If chkSuffixIncNumberSTART.Checked = True Then
                        strPrefixNumberSTART = checkedCount.ToString
                    End If

                    tempFullName = strPrefixNumberSTART + strPrefixName + strPrefixNumberEND + cmbDelimiterPrefix1_2.Text + tmpName + "." + strPrefixNumberSTART + strSuffixName + strPrefixNumberEND
                    myColor = Color.LightSeaGreen
                End If

                lvPreview.Items.Item(x).SubItems(1).Text = tempFullName
                lvPreview.Items.Item(x).BackColor = myColor
            Next
            setListViewColWidth(Me.lvPreview, 410)
        End If

        'Check for dublicates in Renaming results..
        If checkForDublicates(lvPreview) = True Then
            LOG("ERROR: Dublicate rename results where found!" _
                + vbCrLf + "The Renaming Action cannot proceed because UC4 does NOT allow dublicate Object Names!" _
                + vbCrLf + "Please make the appropriate changes in order to continue.")
        End If

    End Sub

    Private Function checkForDublicates(ByVal myListView As ListView) As Boolean
        Dim RES As Boolean = False
        btnGO.Enabled = True

        For upIndex = myListView.Items.Count - 1 To 1 Step -1
            Dim upItem = myListView.Items.Item(upIndex).SubItems(1)

            For downIndex = 0 To upIndex - 1 Step 1
                Dim downItem = myListView.Items.Item(downIndex).SubItems(1)

                If upItem.Text = downItem.Text Then
                    upItem.BackColor = Color.Red
                    upItem.ForeColor = Color.White
                    downItem.BackColor = Color.Red
                    downItem.ForeColor = Color.White
                    btnGO.Enabled = False
                    RES = True
                    Exit For
                End If
            Next
        Next

        Return RES
    End Function

    Private Function evaluateRegEx(ByVal myString As String) As String
        Dim flag As Integer = 0
        Dim stringToApplyRegex As String = ""
        If txtRegex3.BackColor = Color.White Then
            flag = 3
        ElseIf txtRegex2.BackColor = Color.White Then
            flag = 2
        ElseIf txtRegex1.BackColor = Color.White Then
            flag = 1
        End If

        If flag > 0 Then 'first regex evaluation
            Dim regexPreview As System.Text.RegularExpressions.MatchCollection = regMatches(txtRegexSample.Text, txtRegex1.Text)
            lstRegexPreview1.Items.Clear()
            If Not regexPreview Is Nothing Then
                lstRegexPreview1.BackColor = Color.LightYellow
                If regexPreview.Count > 0 Then
                    For i = 0 To regexPreview.Count - 1
                        lstRegexPreview1.Items.Add(regexPreview.Item(i).ToString)
                    Next
                    stringToApplyRegex = lstRegexPreview1.Items.Item(0)
                    lstRegexPreview1.Items.Item(0) = "* " + lstRegexPreview1.Items.Item(0)
                End If
            Else
                txtRegex1.BackColor = Color.IndianRed
                lstRegexPreview1.BackColor = Color.IndianRed
                lstRegexPreview1.Items.Add("No matches")
            End If

            If flag > 1 Then 'second regex evaluation
                regexPreview = regMatches(stringToApplyRegex, txtRegex2.Text)
                lstRegexPreview2.Items.Clear()
                If Not regexPreview Is Nothing Then
                    lstRegexPreview2.BackColor = Color.LightYellow
                    If regexPreview.Count > 0 Then
                        For i = 0 To regexPreview.Count - 1
                            lstRegexPreview2.Items.Add(regexPreview.Item(i).ToString)
                        Next
                        stringToApplyRegex = lstRegexPreview2.Items.Item(0)
                        lstRegexPreview2.Items.Item(0) = "* " + lstRegexPreview2.Items.Item(0)
                    End If
                Else
                    txtRegex2.BackColor = Color.IndianRed
                    lstRegexPreview2.BackColor = Color.IndianRed
                    lstRegexPreview2.Items.Add("No matches")
                End If

                If flag > 2 Then 'third regex evaluation
                    regexPreview = regMatches(stringToApplyRegex, txtRegex3.Text)
                    lstRegexPreview3.Items.Clear()
                    If Not regexPreview Is Nothing Then
                        lstRegexPreview3.BackColor = Color.LightYellow
                        If regexPreview.Count > 0 Then
                            For i = 0 To regexPreview.Count - 1
                                lstRegexPreview3.Items.Add(regexPreview.Item(i).ToString)
                            Next
                            stringToApplyRegex = lstRegexPreview3.Items.Item(0)
                            lstRegexPreview3.Items.Item(0) = "* " + lstRegexPreview3.Items.Item(0)
                        End If
                    Else
                        txtRegex3.BackColor = Color.IndianRed
                        lstRegexPreview3.BackColor = Color.IndianRed
                        lstRegexPreview3.Items.Add("No matches")
                    End If
                End If
            End If
        End If

        Return stringToApplyRegex
    End Function

    Private Sub btnEvaluateRegEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluateRegEx.Click
        txtRegexPreview.Text = evaluateRegEx(txtRegexSample.Text)
    End Sub

    Private Sub txtRegex_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegex1.Enter, txtRegex2.Enter, txtRegex3.Enter
        Dim textbox As TextBox = sender
        textbox.BackColor = Color.White
    End Sub
    Private Sub txtRegex_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegex1.Leave, txtRegex2.Leave, txtRegex3.Leave
        Dim textbox As TextBox = sender

        With textbox
            If .Name = "txtRegex1" Then
                If String.IsNullOrEmpty(.Text) Then
                    .BackColor = Color.LightGray
                    txtRegex2.BackColor = Color.LightGray
                    txtRegex3.BackColor = Color.LightGray
                End If
            ElseIf .Name = "txtRegex2" Then
                If String.IsNullOrEmpty(.Text) Or txtRegex1.BackColor = Color.LightGray Then
                    .BackColor = Color.LightGray
                    txtRegex3.BackColor = Color.LightGray

                Else
                    If txtRegex3.Text <> "" Then
                        txtRegex3.BackColor = Color.White
                    Else
                        txtRegex3.BackColor = Color.LightGray
                    End If

                End If
            ElseIf .Name = "txtRegex3" Then
                If String.IsNullOrEmpty(.Text) Or String.IsNullOrEmpty(txtRegex2.Text) Then
                    .BackColor = Color.LightGray
                End If
            End If

        End With
    End Sub

    Private Sub btnRegexHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegexHelp.Click
        If MsgBox("Connect online to to get help?", vbInformation + vbOKCancel, "Online Help") = MsgBoxResult.Ok Then
            frmHELP.Tag = "frmRename_REGEX"
            frmHELP.Show()
        End If
    End Sub

    Private Sub frmRename_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        saveForm(Me)
    End Sub

    Private Sub frmRename_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadForm(Me)
    End Sub
End Class

