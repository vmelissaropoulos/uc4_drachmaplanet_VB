<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectFolder
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
        Me.tvSelectFolder = New System.Windows.Forms.TreeView()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tvSelectFolder
        '
        Me.tvSelectFolder.Dock = System.Windows.Forms.DockStyle.Top
        Me.tvSelectFolder.Location = New System.Drawing.Point(0, 0)
        Me.tvSelectFolder.Name = "tvSelectFolder"
        Me.tvSelectFolder.ShowNodeToolTips = True
        Me.tvSelectFolder.Size = New System.Drawing.Size(263, 420)
        Me.tvSelectFolder.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnOK.Location = New System.Drawing.Point(0, 421)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(263, 31)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmSelectFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 452)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.tvSelectFolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSelectFolder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Folder"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvSelectFolder As System.Windows.Forms.TreeView
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
