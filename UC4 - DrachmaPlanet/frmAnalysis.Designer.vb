<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysis
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.tabOBJECTS = New System.Windows.Forms.TabControl()
        Me.tabJOBS = New System.Windows.Forms.TabPage()
        Me.tabJOBP = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkHostJOBS = New System.Windows.Forms.CheckBox()
        Me.chkLoginJOBS = New System.Windows.Forms.CheckBox()
        Me.chkRuntimeJOBS = New System.Windows.Forms.CheckBox()
        Me.chkUXEXE = New System.Windows.Forms.CheckBox()
        Me.chkS_AREAJOBS = New System.Windows.Forms.CheckBox()
        Me.chkPrescriptJOBS = New System.Windows.Forms.CheckBox()
        Me.chkPostscriptJOBS = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbShellJOBS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkPromptSetTaskInfosJOBS = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.chkEOFJOBS = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.tabOBJECTS.SuspendLayout()
        Me.tabJOBS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tabOBJECTS)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1111, 506)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1111, 531)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'tabOBJECTS
        '
        Me.tabOBJECTS.Controls.Add(Me.tabJOBS)
        Me.tabOBJECTS.Controls.Add(Me.tabJOBP)
        Me.tabOBJECTS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabOBJECTS.Location = New System.Drawing.Point(0, 0)
        Me.tabOBJECTS.Name = "tabOBJECTS"
        Me.tabOBJECTS.SelectedIndex = 0
        Me.tabOBJECTS.Size = New System.Drawing.Size(1111, 506)
        Me.tabOBJECTS.TabIndex = 0
        '
        'tabJOBS
        '
        Me.tabJOBS.Controls.Add(Me.GroupBox3)
        Me.tabJOBS.Controls.Add(Me.GroupBox2)
        Me.tabJOBS.Controls.Add(Me.GroupBox1)
        Me.tabJOBS.Location = New System.Drawing.Point(4, 22)
        Me.tabJOBS.Name = "tabJOBS"
        Me.tabJOBS.Padding = New System.Windows.Forms.Padding(3)
        Me.tabJOBS.Size = New System.Drawing.Size(1103, 480)
        Me.tabJOBS.TabIndex = 0
        Me.tabJOBS.Text = "Job"
        Me.tabJOBS.UseVisualStyleBackColor = True
        '
        'tabJOBP
        '
        Me.tabJOBP.Location = New System.Drawing.Point(4, 22)
        Me.tabJOBP.Name = "tabJOBP"
        Me.tabJOBP.Padding = New System.Windows.Forms.Padding(3)
        Me.tabJOBP.Size = New System.Drawing.Size(1103, 480)
        Me.tabJOBP.TabIndex = 1
        Me.tabJOBP.Text = "Workflow"
        Me.tabJOBP.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.chkPromptSetTaskInfosJOBS)
        Me.GroupBox1.Controls.Add(Me.chkPostscriptJOBS)
        Me.GroupBox1.Controls.Add(Me.chkPrescriptJOBS)
        Me.GroupBox1.Controls.Add(Me.chkS_AREAJOBS)
        Me.GroupBox1.Controls.Add(Me.chkUXEXE)
        Me.GroupBox1.Controls.Add(Me.chkRuntimeJOBS)
        Me.GroupBox1.Controls.Add(Me.chkLoginJOBS)
        Me.GroupBox1.Controls.Add(Me.chkHostJOBS)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scan for: "
        '
        'chkHostJOBS
        '
        Me.chkHostJOBS.AutoSize = True
        Me.chkHostJOBS.Location = New System.Drawing.Point(6, 19)
        Me.chkHostJOBS.Name = "chkHostJOBS"
        Me.chkHostJOBS.Size = New System.Drawing.Size(89, 17)
        Me.chkHostJOBS.TabIndex = 0
        Me.chkHostJOBS.Text = "Host is empty"
        Me.chkHostJOBS.UseVisualStyleBackColor = True
        '
        'chkLoginJOBS
        '
        Me.chkLoginJOBS.AutoSize = True
        Me.chkLoginJOBS.Location = New System.Drawing.Point(6, 42)
        Me.chkLoginJOBS.Name = "chkLoginJOBS"
        Me.chkLoginJOBS.Size = New System.Drawing.Size(93, 17)
        Me.chkLoginJOBS.TabIndex = 0
        Me.chkLoginJOBS.Text = "Login is empty"
        Me.chkLoginJOBS.UseVisualStyleBackColor = True
        '
        'chkRuntimeJOBS
        '
        Me.chkRuntimeJOBS.AutoSize = True
        Me.chkRuntimeJOBS.Location = New System.Drawing.Point(6, 65)
        Me.chkRuntimeJOBS.Name = "chkRuntimeJOBS"
        Me.chkRuntimeJOBS.Size = New System.Drawing.Size(119, 17)
        Me.chkRuntimeJOBS.TabIndex = 0
        Me.chkRuntimeJOBS.Text = "Generate at runtime"
        Me.chkRuntimeJOBS.UseVisualStyleBackColor = True
        '
        'chkUXEXE
        '
        Me.chkUXEXE.AutoSize = True
        Me.chkUXEXE.Location = New System.Drawing.Point(6, 88)
        Me.chkUXEXE.Name = "chkUXEXE"
        Me.chkUXEXE.Size = New System.Drawing.Size(168, 17)
        Me.chkUXEXE.TabIndex = 0
        Me.chkUXEXE.Text = "Search for UXEXE commands"
        Me.chkUXEXE.UseVisualStyleBackColor = True
        '
        'chkS_AREAJOBS
        '
        Me.chkS_AREAJOBS.AutoSize = True
        Me.chkS_AREAJOBS.Location = New System.Drawing.Point(191, 18)
        Me.chkS_AREAJOBS.Name = "chkS_AREAJOBS"
        Me.chkS_AREAJOBS.Size = New System.Drawing.Size(120, 17)
        Me.chkS_AREAJOBS.TabIndex = 0
        Me.chkS_AREAJOBS.Text = "Search for S_AREA"
        Me.chkS_AREAJOBS.UseVisualStyleBackColor = True
        '
        'chkPrescriptJOBS
        '
        Me.chkPrescriptJOBS.AutoSize = True
        Me.chkPrescriptJOBS.Location = New System.Drawing.Point(191, 41)
        Me.chkPrescriptJOBS.Name = "chkPrescriptJOBS"
        Me.chkPrescriptJOBS.Size = New System.Drawing.Size(91, 17)
        Me.chkPrescriptJOBS.TabIndex = 0
        Me.chkPrescriptJOBS.Text = "Prescript exist"
        Me.chkPrescriptJOBS.UseVisualStyleBackColor = True
        '
        'chkPostscriptJOBS
        '
        Me.chkPostscriptJOBS.AutoSize = True
        Me.chkPostscriptJOBS.Location = New System.Drawing.Point(191, 64)
        Me.chkPostscriptJOBS.Name = "chkPostscriptJOBS"
        Me.chkPostscriptJOBS.Size = New System.Drawing.Size(96, 17)
        Me.chkPostscriptJOBS.TabIndex = 0
        Me.chkPostscriptJOBS.Text = "Postscript exist"
        Me.chkPostscriptJOBS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkEOFJOBS)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbShellJOBS)
        Me.GroupBox2.Location = New System.Drawing.Point(345, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(177, 142)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UNIX Specific: "
        '
        'cmbShellJOBS
        '
        Me.cmbShellJOBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShellJOBS.FormattingEnabled = True
        Me.cmbShellJOBS.Items.AddRange(New Object() {"Do Not Check", "", "-bash", "bash", "-csh", "csh", "-ksh", "ksh", "-sh", "sh", "-tchs", "tchs"})
        Me.cmbShellJOBS.Location = New System.Drawing.Point(48, 19)
        Me.cmbShellJOBS.Name = "cmbShellJOBS"
        Me.cmbShellJOBS.Size = New System.Drawing.Size(94, 21)
        Me.cmbShellJOBS.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Shell: "
        '
        'chkPromptSetTaskInfosJOBS
        '
        Me.chkPromptSetTaskInfosJOBS.AutoSize = True
        Me.chkPromptSetTaskInfosJOBS.Location = New System.Drawing.Point(191, 88)
        Me.chkPromptSetTaskInfosJOBS.Name = "chkPromptSetTaskInfosJOBS"
        Me.chkPromptSetTaskInfosJOBS.Size = New System.Drawing.Size(121, 17)
        Me.chkPromptSetTaskInfosJOBS.TabIndex = 0
        Me.chkPromptSetTaskInfosJOBS.Text = "PRPT.TASK.INFOS"
        Me.chkPromptSetTaskInfosJOBS.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(191, 111)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox9.TabIndex = 0
        Me.CheckBox9.Text = "reserved0"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'chkEOFJOBS
        '
        Me.chkEOFJOBS.AutoSize = True
        Me.chkEOFJOBS.Location = New System.Drawing.Point(6, 46)
        Me.chkEOFJOBS.Name = "chkEOFJOBS"
        Me.chkEOFJOBS.Size = New System.Drawing.Size(136, 17)
        Me.chkEOFJOBS.TabIndex = 3
        Me.chkEOFJOBS.Text = "Check for ""<<!"" pattern"
        Me.chkEOFJOBS.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(540, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(177, 142)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "WIN Specific: "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(136, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Check for ""<<!"" pattern"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Shell: "
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Do Not Check", "", "-bash", "bash", "-csh", "csh", "-ksh", "ksh", "-sh", "sh", "-tchs", "tchs"})
        Me.ComboBox1.Location = New System.Drawing.Point(48, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'frmAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 531)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Analysis Tool"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.tabOBJECTS.ResumeLayout(False)
        Me.tabJOBS.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tabOBJECTS As System.Windows.Forms.TabControl
    Friend WithEvents tabJOBS As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPostscriptJOBS As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrescriptJOBS As System.Windows.Forms.CheckBox
    Friend WithEvents chkS_AREAJOBS As System.Windows.Forms.CheckBox
    Friend WithEvents chkUXEXE As System.Windows.Forms.CheckBox
    Friend WithEvents chkRuntimeJOBS As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoginJOBS As System.Windows.Forms.CheckBox
    Friend WithEvents chkHostJOBS As System.Windows.Forms.CheckBox
    Friend WithEvents tabJOBP As System.Windows.Forms.TabPage
    Friend WithEvents cmbShellJOBS As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents chkEOFJOBS As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPromptSetTaskInfosJOBS As System.Windows.Forms.CheckBox
End Class
