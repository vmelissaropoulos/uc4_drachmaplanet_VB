<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMove
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.chkKeepFolderStruc = New System.Windows.Forms.CheckBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.btnBrowseTo = New System.Windows.Forms.Button()
        Me.btnBrowseFrom = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtExcludeFile = New System.Windows.Forms.TextBox()
        Me.txtIncludeFile = New System.Windows.Forms.TextBox()
        Me.btnExcludeList = New System.Windows.Forms.Button()
        Me.btnIncludeList = New System.Windows.Forms.Button()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnCreateFolders = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnTEST = New System.Windows.Forms.Button()
        Me.btnTESTpath = New System.Windows.Forms.Button()
        Me.btnRemovePRPT = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRemoveFromList = New System.Windows.Forms.Button()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.btnBrowseForPFolder = New System.Windows.Forms.Button()
        Me.lstFolderStructure = New System.Windows.Forms.ListBox()
        Me.txtPFolder = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTo)
        Me.GroupBox1.Controls.Add(Me.chkKeepFolderStruc)
        Me.GroupBox1.Controls.Add(Me.txtFrom)
        Me.GroupBox1.Controls.Add(Me.btnBrowseTo)
        Me.GroupBox1.Controls.Add(Me.btnBrowseFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 107)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Folders"
        '
        'txtTo
        '
        Me.txtTo.BackColor = System.Drawing.SystemColors.Info
        Me.txtTo.Location = New System.Drawing.Point(77, 50)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(333, 20)
        Me.txtTo.TabIndex = 7
        '
        'chkKeepFolderStruc
        '
        Me.chkKeepFolderStruc.AutoSize = True
        Me.chkKeepFolderStruc.Checked = True
        Me.chkKeepFolderStruc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeepFolderStruc.Location = New System.Drawing.Point(6, 77)
        Me.chkKeepFolderStruc.Name = "chkKeepFolderStruc"
        Me.chkKeepFolderStruc.Size = New System.Drawing.Size(129, 17)
        Me.chkKeepFolderStruc.TabIndex = 8
        Me.chkKeepFolderStruc.Text = "Keep Folder Structure"
        Me.chkKeepFolderStruc.UseVisualStyleBackColor = True
        '
        'txtFrom
        '
        Me.txtFrom.BackColor = System.Drawing.SystemColors.Info
        Me.txtFrom.Location = New System.Drawing.Point(77, 21)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.ReadOnly = True
        Me.txtFrom.Size = New System.Drawing.Size(333, 20)
        Me.txtFrom.TabIndex = 8
        '
        'btnBrowseTo
        '
        Me.btnBrowseTo.Location = New System.Drawing.Point(6, 48)
        Me.btnBrowseTo.Name = "btnBrowseTo"
        Me.btnBrowseTo.Size = New System.Drawing.Size(65, 23)
        Me.btnBrowseTo.TabIndex = 6
        Me.btnBrowseTo.Text = "Target"
        Me.btnBrowseTo.UseVisualStyleBackColor = True
        '
        'btnBrowseFrom
        '
        Me.btnBrowseFrom.Location = New System.Drawing.Point(6, 19)
        Me.btnBrowseFrom.Name = "btnBrowseFrom"
        Me.btnBrowseFrom.Size = New System.Drawing.Size(65, 23)
        Me.btnBrowseFrom.TabIndex = 5
        Me.btnBrowseFrom.Text = "Source"
        Me.btnBrowseFrom.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtExcludeFile)
        Me.GroupBox2.Controls.Add(Me.txtIncludeFile)
        Me.GroupBox2.Controls.Add(Me.btnExcludeList)
        Me.GroupBox2.Controls.Add(Me.btnIncludeList)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 80)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Browse for List file"
        '
        'txtExcludeFile
        '
        Me.txtExcludeFile.BackColor = System.Drawing.SystemColors.Info
        Me.txtExcludeFile.Enabled = False
        Me.txtExcludeFile.Location = New System.Drawing.Point(77, 48)
        Me.txtExcludeFile.Name = "txtExcludeFile"
        Me.txtExcludeFile.ReadOnly = True
        Me.txtExcludeFile.Size = New System.Drawing.Size(333, 20)
        Me.txtExcludeFile.TabIndex = 7
        '
        'txtIncludeFile
        '
        Me.txtIncludeFile.BackColor = System.Drawing.SystemColors.Info
        Me.txtIncludeFile.Location = New System.Drawing.Point(77, 21)
        Me.txtIncludeFile.Name = "txtIncludeFile"
        Me.txtIncludeFile.ReadOnly = True
        Me.txtIncludeFile.Size = New System.Drawing.Size(333, 20)
        Me.txtIncludeFile.TabIndex = 8
        '
        'btnExcludeList
        '
        Me.btnExcludeList.Enabled = False
        Me.btnExcludeList.Location = New System.Drawing.Point(6, 46)
        Me.btnExcludeList.Name = "btnExcludeList"
        Me.btnExcludeList.Size = New System.Drawing.Size(65, 23)
        Me.btnExcludeList.TabIndex = 6
        Me.btnExcludeList.Text = "Exclude"
        Me.btnExcludeList.UseVisualStyleBackColor = True
        '
        'btnIncludeList
        '
        Me.btnIncludeList.Location = New System.Drawing.Point(6, 19)
        Me.btnIncludeList.Name = "btnIncludeList"
        Me.btnIncludeList.Size = New System.Drawing.Size(65, 23)
        Me.btnIncludeList.TabIndex = 5
        Me.btnIncludeList.Text = "Include"
        Me.btnIncludeList.UseVisualStyleBackColor = True
        '
        'btnCreateFolders
        '
        Me.btnCreateFolders.Location = New System.Drawing.Point(434, 208)
        Me.btnCreateFolders.Name = "btnCreateFolders"
        Me.btnCreateFolders.Size = New System.Drawing.Size(80, 24)
        Me.btnCreateFolders.TabIndex = 5
        Me.btnCreateFolders.Text = "Create Folders"
        Me.btnCreateFolders.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(12, 208)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(80, 24)
        Me.btnMove.TabIndex = 5
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnTEST
        '
        Me.btnTEST.Location = New System.Drawing.Point(629, 72)
        Me.btnTEST.Name = "btnTEST"
        Me.btnTEST.Size = New System.Drawing.Size(104, 24)
        Me.btnTEST.TabIndex = 6
        Me.btnTEST.Text = "TEST"
        Me.btnTEST.UseVisualStyleBackColor = True
        '
        'btnTESTpath
        '
        Me.btnTESTpath.Location = New System.Drawing.Point(629, 12)
        Me.btnTESTpath.Name = "btnTESTpath"
        Me.btnTESTpath.Size = New System.Drawing.Size(104, 24)
        Me.btnTESTpath.TabIndex = 7
        Me.btnTESTpath.Text = "TestPath"
        Me.btnTESTpath.UseVisualStyleBackColor = True
        '
        'btnRemovePRPT
        '
        Me.btnRemovePRPT.Location = New System.Drawing.Point(629, 42)
        Me.btnRemovePRPT.Name = "btnRemovePRPT"
        Me.btnRemovePRPT.Size = New System.Drawing.Size(104, 24)
        Me.btnRemovePRPT.TabIndex = 9
        Me.btnRemovePRPT.Text = "testPRPTremoval"
        Me.btnRemovePRPT.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRemoveFromList)
        Me.GroupBox3.Controls.Add(Me.btnAddToList)
        Me.GroupBox3.Controls.Add(Me.btnBrowseForPFolder)
        Me.GroupBox3.Controls.Add(Me.lstFolderStructure)
        Me.GroupBox3.Location = New System.Drawing.Point(434, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 193)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Create folders in Folder"
        '
        'btnRemoveFromList
        '
        Me.btnRemoveFromList.Location = New System.Drawing.Point(133, 78)
        Me.btnRemoveFromList.Name = "btnRemoveFromList"
        Me.btnRemoveFromList.Size = New System.Drawing.Size(26, 24)
        Me.btnRemoveFromList.TabIndex = 3
        Me.btnRemoveFromList.Text = "-"
        Me.btnRemoveFromList.UseVisualStyleBackColor = True
        '
        'btnAddToList
        '
        Me.btnAddToList.Location = New System.Drawing.Point(133, 48)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(26, 24)
        Me.btnAddToList.TabIndex = 2
        Me.btnAddToList.Text = "+"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'btnBrowseForPFolder
        '
        Me.btnBrowseForPFolder.Location = New System.Drawing.Point(6, 21)
        Me.btnBrowseForPFolder.Name = "btnBrowseForPFolder"
        Me.btnBrowseForPFolder.Size = New System.Drawing.Size(54, 23)
        Me.btnBrowseForPFolder.TabIndex = 1
        Me.btnBrowseForPFolder.Text = "Folder"
        Me.btnBrowseForPFolder.UseVisualStyleBackColor = True
        '
        'lstFolderStructure
        '
        Me.lstFolderStructure.FormattingEnabled = True
        Me.lstFolderStructure.Items.AddRange(New Object() {"#ADMIN\LOGIN", "TOST"})
        Me.lstFolderStructure.Location = New System.Drawing.Point(6, 48)
        Me.lstFolderStructure.Name = "lstFolderStructure"
        Me.lstFolderStructure.Size = New System.Drawing.Size(121, 134)
        Me.lstFolderStructure.TabIndex = 0
        '
        'txtPFolder
        '
        Me.txtPFolder.BackColor = System.Drawing.SystemColors.Info
        Me.txtPFolder.Location = New System.Drawing.Point(500, 32)
        Me.txtPFolder.Name = "txtPFolder"
        Me.txtPFolder.ReadOnly = True
        Me.txtPFolder.Size = New System.Drawing.Size(93, 20)
        Me.txtPFolder.TabIndex = 8
        '
        'frmMove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 243)
        Me.Controls.Add(Me.txtPFolder)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnRemovePRPT)
        Me.Controls.Add(Me.btnTESTpath)
        Me.Controls.Add(Me.btnTEST)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnCreateFolders)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Move Tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseTo As System.Windows.Forms.Button
    Friend WithEvents btnBrowseFrom As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExcludeFile As System.Windows.Forms.TextBox
    Friend WithEvents txtIncludeFile As System.Windows.Forms.TextBox
    Friend WithEvents btnExcludeList As System.Windows.Forms.Button
    Friend WithEvents btnIncludeList As System.Windows.Forms.Button
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCreateFolders As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnTEST As System.Windows.Forms.Button
    Friend WithEvents btnTESTpath As System.Windows.Forms.Button
    Friend WithEvents chkKeepFolderStruc As System.Windows.Forms.CheckBox
    Friend WithEvents btnRemovePRPT As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowseForPFolder As System.Windows.Forms.Button
    Friend WithEvents lstFolderStructure As System.Windows.Forms.ListBox
    Friend WithEvents txtPFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoveFromList As System.Windows.Forms.Button
    Friend WithEvents btnAddToList As System.Windows.Forms.Button
End Class
