<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJOBSTool
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
        Me.chkLoginDryRun = New System.Windows.Forms.CheckBox()
        Me.btnChangeLogins = New System.Windows.Forms.Button()
        Me.txtIncludeFile = New System.Windows.Forms.TextBox()
        Me.btnBrowseList = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtObjectsListFile = New System.Windows.Forms.TextBox()
        Me.btnObjectsListFile = New System.Windows.Forms.Button()
        Me.txtShellFile = New System.Windows.Forms.TextBox()
        Me.btnShellFile = New System.Windows.Forms.Button()
        Me.chkShellDryRun = New System.Windows.Forms.CheckBox()
        Me.btnSetShell = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkHostDryRun = New System.Windows.Forms.CheckBox()
        Me.btnChangeHosts = New System.Windows.Forms.Button()
        Me.txtIncludeFileHosts = New System.Windows.Forms.TextBox()
        Me.btnBrowseHostList = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkLoginDryRun)
        Me.GroupBox1.Controls.Add(Me.btnChangeLogins)
        Me.GroupBox1.Controls.Add(Me.txtIncludeFile)
        Me.GroupBox1.Controls.Add(Me.btnBrowseList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Login Informantion"
        '
        'chkLoginDryRun
        '
        Me.chkLoginDryRun.AutoSize = True
        Me.chkLoginDryRun.Checked = True
        Me.chkLoginDryRun.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLoginDryRun.Location = New System.Drawing.Point(6, 51)
        Me.chkLoginDryRun.Name = "chkLoginDryRun"
        Me.chkLoginDryRun.Size = New System.Drawing.Size(60, 17)
        Me.chkLoginDryRun.TabIndex = 18
        Me.chkLoginDryRun.Text = "Dry run"
        Me.chkLoginDryRun.UseVisualStyleBackColor = True
        '
        'btnChangeLogins
        '
        Me.btnChangeLogins.Location = New System.Drawing.Point(77, 47)
        Me.btnChangeLogins.Name = "btnChangeLogins"
        Me.btnChangeLogins.Size = New System.Drawing.Size(333, 23)
        Me.btnChangeLogins.TabIndex = 17
        Me.btnChangeLogins.Text = "Set Login"
        Me.btnChangeLogins.UseVisualStyleBackColor = True
        '
        'txtIncludeFile
        '
        Me.txtIncludeFile.BackColor = System.Drawing.SystemColors.Info
        Me.txtIncludeFile.Location = New System.Drawing.Point(77, 21)
        Me.txtIncludeFile.Name = "txtIncludeFile"
        Me.txtIncludeFile.ReadOnly = True
        Me.txtIncludeFile.Size = New System.Drawing.Size(333, 20)
        Me.txtIncludeFile.TabIndex = 12
        '
        'btnBrowseList
        '
        Me.btnBrowseList.Location = New System.Drawing.Point(6, 19)
        Me.btnBrowseList.Name = "btnBrowseList"
        Me.btnBrowseList.Size = New System.Drawing.Size(65, 23)
        Me.btnBrowseList.TabIndex = 11
        Me.btnBrowseList.Text = "List File"
        Me.btnBrowseList.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtObjectsListFile)
        Me.GroupBox3.Controls.Add(Me.btnObjectsListFile)
        Me.GroupBox3.Controls.Add(Me.txtShellFile)
        Me.GroupBox3.Controls.Add(Me.btnShellFile)
        Me.GroupBox3.Controls.Add(Me.chkShellDryRun)
        Me.GroupBox3.Controls.Add(Me.btnSetShell)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(417, 106)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Set Shell"
        '
        'txtObjectsListFile
        '
        Me.txtObjectsListFile.BackColor = System.Drawing.SystemColors.Info
        Me.txtObjectsListFile.Location = New System.Drawing.Point(77, 21)
        Me.txtObjectsListFile.Name = "txtObjectsListFile"
        Me.txtObjectsListFile.ReadOnly = True
        Me.txtObjectsListFile.Size = New System.Drawing.Size(333, 20)
        Me.txtObjectsListFile.TabIndex = 20
        '
        'btnObjectsListFile
        '
        Me.btnObjectsListFile.Location = New System.Drawing.Point(6, 19)
        Me.btnObjectsListFile.Name = "btnObjectsListFile"
        Me.btnObjectsListFile.Size = New System.Drawing.Size(65, 23)
        Me.btnObjectsListFile.TabIndex = 19
        Me.btnObjectsListFile.Text = "List File"
        Me.btnObjectsListFile.UseVisualStyleBackColor = True
        '
        'txtShellFile
        '
        Me.txtShellFile.BackColor = System.Drawing.SystemColors.Info
        Me.txtShellFile.Location = New System.Drawing.Point(77, 47)
        Me.txtShellFile.Name = "txtShellFile"
        Me.txtShellFile.ReadOnly = True
        Me.txtShellFile.Size = New System.Drawing.Size(333, 20)
        Me.txtShellFile.TabIndex = 18
        '
        'btnShellFile
        '
        Me.btnShellFile.Location = New System.Drawing.Point(6, 45)
        Me.btnShellFile.Name = "btnShellFile"
        Me.btnShellFile.Size = New System.Drawing.Size(65, 23)
        Me.btnShellFile.TabIndex = 17
        Me.btnShellFile.Text = "Shell File"
        Me.btnShellFile.UseVisualStyleBackColor = True
        '
        'chkShellDryRun
        '
        Me.chkShellDryRun.AutoSize = True
        Me.chkShellDryRun.Checked = True
        Me.chkShellDryRun.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShellDryRun.Location = New System.Drawing.Point(6, 77)
        Me.chkShellDryRun.Name = "chkShellDryRun"
        Me.chkShellDryRun.Size = New System.Drawing.Size(60, 17)
        Me.chkShellDryRun.TabIndex = 16
        Me.chkShellDryRun.Text = "Dry run"
        Me.chkShellDryRun.UseVisualStyleBackColor = True
        '
        'btnSetShell
        '
        Me.btnSetShell.Location = New System.Drawing.Point(77, 73)
        Me.btnSetShell.Name = "btnSetShell"
        Me.btnSetShell.Size = New System.Drawing.Size(333, 23)
        Me.btnSetShell.TabIndex = 15
        Me.btnSetShell.Text = "Set Shell"
        Me.btnSetShell.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkHostDryRun)
        Me.GroupBox2.Controls.Add(Me.btnChangeHosts)
        Me.GroupBox2.Controls.Add(Me.txtIncludeFileHosts)
        Me.GroupBox2.Controls.Add(Me.btnBrowseHostList)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 82)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Set Host Informantion"
        '
        'chkHostDryRun
        '
        Me.chkHostDryRun.AutoSize = True
        Me.chkHostDryRun.Checked = True
        Me.chkHostDryRun.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHostDryRun.Location = New System.Drawing.Point(6, 51)
        Me.chkHostDryRun.Name = "chkHostDryRun"
        Me.chkHostDryRun.Size = New System.Drawing.Size(60, 17)
        Me.chkHostDryRun.TabIndex = 18
        Me.chkHostDryRun.Text = "Dry run"
        Me.chkHostDryRun.UseVisualStyleBackColor = True
        '
        'btnChangeHosts
        '
        Me.btnChangeHosts.Location = New System.Drawing.Point(77, 47)
        Me.btnChangeHosts.Name = "btnChangeHosts"
        Me.btnChangeHosts.Size = New System.Drawing.Size(333, 23)
        Me.btnChangeHosts.TabIndex = 17
        Me.btnChangeHosts.Text = "Set Host"
        Me.btnChangeHosts.UseVisualStyleBackColor = True
        '
        'txtIncludeFileHosts
        '
        Me.txtIncludeFileHosts.BackColor = System.Drawing.SystemColors.Info
        Me.txtIncludeFileHosts.Location = New System.Drawing.Point(77, 21)
        Me.txtIncludeFileHosts.Name = "txtIncludeFileHosts"
        Me.txtIncludeFileHosts.ReadOnly = True
        Me.txtIncludeFileHosts.Size = New System.Drawing.Size(333, 20)
        Me.txtIncludeFileHosts.TabIndex = 12
        '
        'btnBrowseHostList
        '
        Me.btnBrowseHostList.Location = New System.Drawing.Point(6, 19)
        Me.btnBrowseHostList.Name = "btnBrowseHostList"
        Me.btnBrowseHostList.Size = New System.Drawing.Size(65, 23)
        Me.btnBrowseHostList.TabIndex = 11
        Me.btnBrowseHostList.Text = "List File"
        Me.btnBrowseHostList.UseVisualStyleBackColor = True
        '
        'frmJOBSTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 447)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmJOBSTool"
        Me.Text = "frmJOBSTool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIncludeFile As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseList As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkShellDryRun As System.Windows.Forms.CheckBox
    Friend WithEvents btnSetShell As System.Windows.Forms.Button
    Friend WithEvents txtShellFile As System.Windows.Forms.TextBox
    Friend WithEvents btnShellFile As System.Windows.Forms.Button
    Friend WithEvents chkLoginDryRun As System.Windows.Forms.CheckBox
    Friend WithEvents btnChangeLogins As System.Windows.Forms.Button
    Friend WithEvents txtObjectsListFile As System.Windows.Forms.TextBox
    Friend WithEvents btnObjectsListFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkHostDryRun As System.Windows.Forms.CheckBox
    Friend WithEvents btnChangeHosts As System.Windows.Forms.Button
    Friend WithEvents txtIncludeFileHosts As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseHostList As System.Windows.Forms.Button
End Class
