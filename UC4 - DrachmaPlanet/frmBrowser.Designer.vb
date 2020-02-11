<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowser
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
        Me.lblActionCount = New System.Windows.Forms.Label()
        Me.lblCurentCount = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnRemoveFromActionList = New System.Windows.Forms.Button()
        Me.btnAddToActionList = New System.Windows.Forms.Button()
        Me.lstObjectsToApplyActions = New System.Windows.Forms.ListBox()
        Me.lstCurrentFolderContents = New System.Windows.Forms.ListBox()
        Me.tvAllFolders = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'lblActionCount
        '
        Me.lblActionCount.AutoSize = True
        Me.lblActionCount.Location = New System.Drawing.Point(869, 480)
        Me.lblActionCount.Name = "lblActionCount"
        Me.lblActionCount.Size = New System.Drawing.Size(61, 13)
        Me.lblActionCount.TabIndex = 21
        Me.lblActionCount.Text = "Selected: 0"
        '
        'lblCurentCount
        '
        Me.lblCurentCount.AutoSize = True
        Me.lblCurentCount.Location = New System.Drawing.Point(398, 483)
        Me.lblCurentCount.Name = "lblCurentCount"
        Me.lblCurentCount.Size = New System.Drawing.Size(61, 13)
        Me.lblCurentCount.TabIndex = 20
        Me.lblCurentCount.Text = "Selected: 0"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1185, 483)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 37)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(1106, 483)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(73, 37)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnRemoveFromActionList
        '
        Me.btnRemoveFromActionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnRemoveFromActionList.Location = New System.Drawing.Point(796, 248)
        Me.btnRemoveFromActionList.Name = "btnRemoveFromActionList"
        Me.btnRemoveFromActionList.Size = New System.Drawing.Size(67, 229)
        Me.btnRemoveFromActionList.TabIndex = 16
        Me.btnRemoveFromActionList.Text = "Remove Selected"
        Me.btnRemoveFromActionList.UseVisualStyleBackColor = True
        '
        'btnAddToActionList
        '
        Me.btnAddToActionList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnAddToActionList.Location = New System.Drawing.Point(796, 5)
        Me.btnAddToActionList.Name = "btnAddToActionList"
        Me.btnAddToActionList.Size = New System.Drawing.Size(67, 229)
        Me.btnAddToActionList.TabIndex = 17
        Me.btnAddToActionList.Text = "Add Selected"
        Me.btnAddToActionList.UseVisualStyleBackColor = True
        '
        'lstObjectsToApplyActions
        '
        Me.lstObjectsToApplyActions.FormattingEnabled = True
        Me.lstObjectsToApplyActions.Location = New System.Drawing.Point(869, 5)
        Me.lstObjectsToApplyActions.Name = "lstObjectsToApplyActions"
        Me.lstObjectsToApplyActions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstObjectsToApplyActions.Size = New System.Drawing.Size(389, 472)
        Me.lstObjectsToApplyActions.TabIndex = 15
        '
        'lstCurrentFolderContents
        '
        Me.lstCurrentFolderContents.FormattingEnabled = True
        Me.lstCurrentFolderContents.Location = New System.Drawing.Point(401, 5)
        Me.lstCurrentFolderContents.Name = "lstCurrentFolderContents"
        Me.lstCurrentFolderContents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCurrentFolderContents.Size = New System.Drawing.Size(389, 472)
        Me.lstCurrentFolderContents.TabIndex = 14
        '
        'tvAllFolders
        '
        Me.tvAllFolders.Location = New System.Drawing.Point(1, 3)
        Me.tvAllFolders.Name = "tvAllFolders"
        Me.tvAllFolders.Size = New System.Drawing.Size(394, 478)
        Me.tvAllFolders.TabIndex = 13
        '
        'frmBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 524)
        Me.Controls.Add(Me.lblActionCount)
        Me.Controls.Add(Me.lblCurentCount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnRemoveFromActionList)
        Me.Controls.Add(Me.btnAddToActionList)
        Me.Controls.Add(Me.lstObjectsToApplyActions)
        Me.Controls.Add(Me.lstCurrentFolderContents)
        Me.Controls.Add(Me.tvAllFolders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBrowser"
        Me.Text = "frmBrowser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblActionCount As System.Windows.Forms.Label
    Friend WithEvents lblCurentCount As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFromActionList As System.Windows.Forms.Button
    Friend WithEvents btnAddToActionList As System.Windows.Forms.Button
    Friend WithEvents lstObjectsToApplyActions As System.Windows.Forms.ListBox
    Friend WithEvents lstCurrentFolderContents As System.Windows.Forms.ListBox
    Friend WithEvents tvAllFolders As System.Windows.Forms.TreeView
End Class
