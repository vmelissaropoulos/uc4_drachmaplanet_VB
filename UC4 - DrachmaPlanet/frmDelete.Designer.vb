<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelete
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
        Me.chkAlsoDeleteObjects = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtPFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowseFrom = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAlsoDeleteObjects)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.txtPFolder)
        Me.GroupBox1.Controls.Add(Me.btnBrowseFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 80)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delete Empty Folders under path"
        '
        'chkAlsoDeleteObjects
        '
        Me.chkAlsoDeleteObjects.AutoSize = True
        Me.chkAlsoDeleteObjects.Location = New System.Drawing.Point(6, 54)
        Me.chkAlsoDeleteObjects.Name = "chkAlsoDeleteObjects"
        Me.chkAlsoDeleteObjects.Size = New System.Drawing.Size(119, 17)
        Me.chkAlsoDeleteObjects.TabIndex = 10
        Me.chkAlsoDeleteObjects.Text = "Also Delete Objects"
        Me.chkAlsoDeleteObjects.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(416, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(59, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtPFolder
        '
        Me.txtPFolder.BackColor = System.Drawing.SystemColors.Info
        Me.txtPFolder.Location = New System.Drawing.Point(77, 21)
        Me.txtPFolder.Name = "txtPFolder"
        Me.txtPFolder.ReadOnly = True
        Me.txtPFolder.Size = New System.Drawing.Size(333, 20)
        Me.txtPFolder.TabIndex = 8
        '
        'btnBrowseFrom
        '
        Me.btnBrowseFrom.Location = New System.Drawing.Point(6, 19)
        Me.btnBrowseFrom.Name = "btnBrowseFrom"
        Me.btnBrowseFrom.Size = New System.Drawing.Size(65, 23)
        Me.btnBrowseFrom.TabIndex = 5
        Me.btnBrowseFrom.Text = "Path"
        Me.btnBrowseFrom.UseVisualStyleBackColor = True
        '
        'frmDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDelete"
        Me.Text = "frmDelete"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseFrom As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents chkAlsoDeleteObjects As System.Windows.Forms.CheckBox
End Class
