<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrePost_Process
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
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkReplaceFirst = New System.Windows.Forms.CheckBox()
        Me.groupBoxRBTNs = New System.Windows.Forms.GroupBox()
        Me.rbtnPostProc = New System.Windows.Forms.RadioButton()
        Me.rbtnProc = New System.Windows.Forms.RadioButton()
        Me.rbtnPreProc = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIncludeFile = New System.Windows.Forms.TextBox()
        Me.btnIncludeList = New System.Windows.Forms.Button()
        Me.txtStrToAdd = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkAppend = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtStrToReplaceNEW = New System.Windows.Forms.TextBox()
        Me.chkReplaceAll = New System.Windows.Forms.CheckBox()
        Me.txtStrToReplaceOLD = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.groupBoxRBTNs.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(275, 71)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 89)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Go"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkReplaceFirst)
        Me.GroupBox1.Controls.Add(Me.groupBoxRBTNs)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 94)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'chkReplaceFirst
        '
        Me.chkReplaceFirst.AutoSize = True
        Me.chkReplaceFirst.Location = New System.Drawing.Point(11, 71)
        Me.chkReplaceFirst.Name = "chkReplaceFirst"
        Me.chkReplaceFirst.Size = New System.Drawing.Size(130, 17)
        Me.chkReplaceFirst.TabIndex = 14
        Me.chkReplaceFirst.Text = "Replace first then add"
        Me.chkReplaceFirst.UseVisualStyleBackColor = True
        '
        'groupBoxRBTNs
        '
        Me.groupBoxRBTNs.Controls.Add(Me.rbtnPostProc)
        Me.groupBoxRBTNs.Controls.Add(Me.rbtnProc)
        Me.groupBoxRBTNs.Controls.Add(Me.rbtnPreProc)
        Me.groupBoxRBTNs.Location = New System.Drawing.Point(7, 19)
        Me.groupBoxRBTNs.Name = "groupBoxRBTNs"
        Me.groupBoxRBTNs.Size = New System.Drawing.Size(249, 46)
        Me.groupBoxRBTNs.TabIndex = 13
        Me.groupBoxRBTNs.TabStop = False
        Me.groupBoxRBTNs.Text = "Where to apply"
        '
        'rbtnPostProc
        '
        Me.rbtnPostProc.AutoSize = True
        Me.rbtnPostProc.Location = New System.Drawing.Point(161, 18)
        Me.rbtnPostProc.Name = "rbtnPostProc"
        Me.rbtnPostProc.Size = New System.Drawing.Size(87, 17)
        Me.rbtnPostProc.TabIndex = 6
        Me.rbtnPostProc.TabStop = True
        Me.rbtnPostProc.Text = "Post-Process"
        Me.rbtnPostProc.UseVisualStyleBackColor = True
        '
        'rbtnProc
        '
        Me.rbtnProc.AutoSize = True
        Me.rbtnProc.Location = New System.Drawing.Point(92, 18)
        Me.rbtnProc.Name = "rbtnProc"
        Me.rbtnProc.Size = New System.Drawing.Size(63, 17)
        Me.rbtnProc.TabIndex = 5
        Me.rbtnProc.TabStop = True
        Me.rbtnProc.Text = "Process"
        Me.rbtnProc.UseVisualStyleBackColor = True
        '
        'rbtnPreProc
        '
        Me.rbtnPreProc.AutoSize = True
        Me.rbtnPreProc.Location = New System.Drawing.Point(4, 18)
        Me.rbtnPreProc.Name = "rbtnPreProc"
        Me.rbtnPreProc.Size = New System.Drawing.Size(82, 17)
        Me.rbtnPreProc.TabIndex = 4
        Me.rbtnPreProc.TabStop = True
        Me.rbtnPreProc.Text = "Pre-Process"
        Me.rbtnPreProc.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIncludeFile)
        Me.GroupBox2.Controls.Add(Me.btnIncludeList)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 55)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Browse for List file"
        '
        'txtIncludeFile
        '
        Me.txtIncludeFile.BackColor = System.Drawing.SystemColors.Info
        Me.txtIncludeFile.Location = New System.Drawing.Point(77, 21)
        Me.txtIncludeFile.Name = "txtIncludeFile"
        Me.txtIncludeFile.ReadOnly = True
        Me.txtIncludeFile.Size = New System.Drawing.Size(260, 20)
        Me.txtIncludeFile.TabIndex = 8
        '
        'btnIncludeList
        '
        Me.btnIncludeList.Location = New System.Drawing.Point(6, 19)
        Me.btnIncludeList.Name = "btnIncludeList"
        Me.btnIncludeList.Size = New System.Drawing.Size(65, 23)
        Me.btnIncludeList.TabIndex = 5
        Me.btnIncludeList.Text = "Select List"
        Me.btnIncludeList.UseVisualStyleBackColor = True
        '
        'txtStrToAdd
        '
        Me.txtStrToAdd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStrToAdd.Location = New System.Drawing.Point(3, 42)
        Me.txtStrToAdd.Multiline = True
        Me.txtStrToAdd.Name = "txtStrToAdd"
        Me.txtStrToAdd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStrToAdd.Size = New System.Drawing.Size(337, 79)
        Me.txtStrToAdd.TabIndex = 8
        Me.txtStrToAdd.Text = ":INC JOBI.UXSET"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkAppend)
        Me.GroupBox3.Controls.Add(Me.txtStrToAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 127)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Text to Add"
        '
        'chkAppend
        '
        Me.chkAppend.AutoSize = True
        Me.chkAppend.Location = New System.Drawing.Point(5, 19)
        Me.chkAppend.Name = "chkAppend"
        Me.chkAppend.Size = New System.Drawing.Size(181, 17)
        Me.chkAppend.TabIndex = 9
        Me.chkAppend.Text = "Append (add at the end of script)"
        Me.chkAppend.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtStrToReplaceNEW)
        Me.GroupBox4.Controls.Add(Me.chkReplaceAll)
        Me.GroupBox4.Controls.Add(Me.txtStrToReplaceOLD)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 299)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(343, 209)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Text to Replace"
        '
        'txtStrToReplaceNEW
        '
        Me.txtStrToReplaceNEW.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStrToReplaceNEW.Location = New System.Drawing.Point(3, 119)
        Me.txtStrToReplaceNEW.Multiline = True
        Me.txtStrToReplaceNEW.Name = "txtStrToReplaceNEW"
        Me.txtStrToReplaceNEW.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStrToReplaceNEW.Size = New System.Drawing.Size(337, 84)
        Me.txtStrToReplaceNEW.TabIndex = 10
        Me.txtStrToReplaceNEW.Text = "With this"
        '
        'chkReplaceAll
        '
        Me.chkReplaceAll.AutoSize = True
        Me.chkReplaceAll.Location = New System.Drawing.Point(5, 19)
        Me.chkReplaceAll.Name = "chkReplaceAll"
        Me.chkReplaceAll.Size = New System.Drawing.Size(119, 17)
        Me.chkReplaceAll.TabIndex = 9
        Me.chkReplaceAll.Text = "Replace Everything"
        Me.chkReplaceAll.UseVisualStyleBackColor = True
        '
        'txtStrToReplaceOLD
        '
        Me.txtStrToReplaceOLD.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStrToReplaceOLD.Location = New System.Drawing.Point(3, 42)
        Me.txtStrToReplaceOLD.Multiline = True
        Me.txtStrToReplaceOLD.Name = "txtStrToReplaceOLD"
        Me.txtStrToReplaceOLD.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStrToReplaceOLD.Size = New System.Drawing.Size(337, 70)
        Me.txtStrToReplaceOLD.TabIndex = 8
        Me.txtStrToReplaceOLD.Text = "Replace this"
        '
        'frmPrePost_Process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 520)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmPrePost_Process"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pre/Post Process Tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBoxRBTNs.ResumeLayout(False)
        Me.groupBoxRBTNs.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIncludeFile As System.Windows.Forms.TextBox
    Friend WithEvents btnIncludeList As System.Windows.Forms.Button
    Friend WithEvents groupBoxRBTNs As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnPostProc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnProc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPreProc As System.Windows.Forms.RadioButton
    Friend WithEvents chkReplaceFirst As System.Windows.Forms.CheckBox
    Friend WithEvents txtStrToAdd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAppend As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkReplaceAll As System.Windows.Forms.CheckBox
    Friend WithEvents txtStrToReplaceNEW As System.Windows.Forms.TextBox
    Friend WithEvents txtStrToReplaceOLD As System.Windows.Forms.TextBox
End Class
