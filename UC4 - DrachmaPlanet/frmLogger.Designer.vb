<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogger
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
        Me.txtLOG = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtLOG
        '
        Me.txtLOG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLOG.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtLOG.Location = New System.Drawing.Point(0, 0)
        Me.txtLOG.Multiline = True
        Me.txtLOG.Name = "txtLOG"
        Me.txtLOG.ReadOnly = True
        Me.txtLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLOG.Size = New System.Drawing.Size(928, 261)
        Me.txtLOG.TabIndex = 1
        '
        'frmLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 261)
        Me.Controls.Add(Me.txtLOG)
        Me.Name = "frmLogger"
        Me.Text = "Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLOG As System.Windows.Forms.TextBox
End Class
