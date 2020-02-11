<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJSCH
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIncludeFile = New System.Windows.Forms.TextBox()
        Me.btnIncludeList = New System.Windows.Forms.Button()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnCreateJSCHTasks = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIncludeFile)
        Me.GroupBox2.Controls.Add(Me.btnIncludeList)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 50)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Browse for List file"
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
        'btnIncludeList
        '
        Me.btnIncludeList.Location = New System.Drawing.Point(6, 19)
        Me.btnIncludeList.Name = "btnIncludeList"
        Me.btnIncludeList.Size = New System.Drawing.Size(65, 23)
        Me.btnIncludeList.TabIndex = 5
        Me.btnIncludeList.Text = "Include"
        Me.btnIncludeList.UseVisualStyleBackColor = True
        '
        'btnCreateJSCHTasks
        '
        Me.btnCreateJSCHTasks.Location = New System.Drawing.Point(12, 82)
        Me.btnCreateJSCHTasks.Name = "btnCreateJSCHTasks"
        Me.btnCreateJSCHTasks.Size = New System.Drawing.Size(71, 23)
        Me.btnCreateJSCHTasks.TabIndex = 6
        Me.btnCreateJSCHTasks.Text = "Create"
        Me.btnCreateJSCHTasks.UseVisualStyleBackColor = True
        '
        'frmJSCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 291)
        Me.Controls.Add(Me.btnCreateJSCHTasks)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmJSCH"
        Me.Text = "frmJSCH"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIncludeFile As System.Windows.Forms.TextBox
    Friend WithEvents btnIncludeList As System.Windows.Forms.Button
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCreateJSCHTasks As System.Windows.Forms.Button
End Class
