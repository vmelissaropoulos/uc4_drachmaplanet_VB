<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHELP
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
        Me.webHELP = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'webHELP
        '
        Me.webHELP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webHELP.Location = New System.Drawing.Point(0, 0)
        Me.webHELP.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webHELP.Name = "webHELP"
        Me.webHELP.Size = New System.Drawing.Size(1013, 476)
        Me.webHELP.TabIndex = 1
        '
        'frmHELP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 476)
        Me.Controls.Add(Me.webHELP)
        Me.Name = "frmHELP"
        Me.Text = "frmHELP"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents webHELP As System.Windows.Forms.WebBrowser
End Class
