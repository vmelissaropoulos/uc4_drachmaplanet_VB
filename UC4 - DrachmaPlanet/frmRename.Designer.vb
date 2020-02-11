<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRename
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRename))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnRegexHelp = New System.Windows.Forms.Button()
        Me.lstRegexPreview3 = New System.Windows.Forms.ListBox()
        Me.lstRegexPreview2 = New System.Windows.Forms.ListBox()
        Me.lstRegexPreview1 = New System.Windows.Forms.ListBox()
        Me.btnEvaluateRegEx = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtRegexPreview = New System.Windows.Forms.TextBox()
        Me.txtRegex3 = New System.Windows.Forms.TextBox()
        Me.txtRegexSample = New System.Windows.Forms.TextBox()
        Me.txtRegex2 = New System.Windows.Forms.TextBox()
        Me.txtRegex1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.lvchOriginal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvchPreview = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRemoveFromRenameList = New System.Windows.Forms.Button()
        Me.btnBrowseRename = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtObjectTitle = New System.Windows.Forms.TextBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnGO = New System.Windows.Forms.Button()
        Me.btnTongleSelection = New System.Windows.Forms.Button()
        Me.btnSelectUnselectAll = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtWithName = New System.Windows.Forms.TextBox()
        Me.txtRepaceName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPrefixIncNumberSTART = New System.Windows.Forms.CheckBox()
        Me.chkPrefixIncNumberEND = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbDelimiterPrefix1_2 = New System.Windows.Forms.ComboBox()
        Me.txtPrefix1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkSuffixIncNumberSTART = New System.Windows.Forms.CheckBox()
        Me.chkSuffixIncNumberEND = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbDelimiterSuffix1_2 = New System.Windows.Forms.ComboBox()
        Me.txtSuffix1 = New System.Windows.Forms.TextBox()
        Me.chkRenameInProccess = New System.Windows.Forms.CheckBox()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnRegexHelp)
        Me.GroupBox5.Controls.Add(Me.lstRegexPreview3)
        Me.GroupBox5.Controls.Add(Me.lstRegexPreview2)
        Me.GroupBox5.Controls.Add(Me.lstRegexPreview1)
        Me.GroupBox5.Controls.Add(Me.btnEvaluateRegEx)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.txtRegexPreview)
        Me.GroupBox5.Controls.Add(Me.txtRegex3)
        Me.GroupBox5.Controls.Add(Me.txtRegexSample)
        Me.GroupBox5.Controls.Add(Me.txtRegex2)
        Me.GroupBox5.Controls.Add(Me.txtRegex1)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 375)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(856, 132)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "RegEx"
        '
        'btnRegexHelp
        '
        Me.btnRegexHelp.Location = New System.Drawing.Point(773, 77)
        Me.btnRegexHelp.Name = "btnRegexHelp"
        Me.btnRegexHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnRegexHelp.TabIndex = 13
        Me.btnRegexHelp.Text = "Help"
        Me.btnRegexHelp.UseVisualStyleBackColor = True
        '
        'lstRegexPreview3
        '
        Me.lstRegexPreview3.BackColor = System.Drawing.SystemColors.Info
        Me.lstRegexPreview3.FormattingEnabled = True
        Me.lstRegexPreview3.Location = New System.Drawing.Point(581, 45)
        Me.lstRegexPreview3.Name = "lstRegexPreview3"
        Me.lstRegexPreview3.Size = New System.Drawing.Size(186, 56)
        Me.lstRegexPreview3.TabIndex = 12
        '
        'lstRegexPreview2
        '
        Me.lstRegexPreview2.BackColor = System.Drawing.SystemColors.Info
        Me.lstRegexPreview2.FormattingEnabled = True
        Me.lstRegexPreview2.Location = New System.Drawing.Point(321, 44)
        Me.lstRegexPreview2.Name = "lstRegexPreview2"
        Me.lstRegexPreview2.Size = New System.Drawing.Size(201, 56)
        Me.lstRegexPreview2.TabIndex = 11
        '
        'lstRegexPreview1
        '
        Me.lstRegexPreview1.BackColor = System.Drawing.SystemColors.Info
        Me.lstRegexPreview1.FormattingEnabled = True
        Me.lstRegexPreview1.Location = New System.Drawing.Point(59, 44)
        Me.lstRegexPreview1.Name = "lstRegexPreview1"
        Me.lstRegexPreview1.Size = New System.Drawing.Size(203, 56)
        Me.lstRegexPreview1.TabIndex = 10
        '
        'btnEvaluateRegEx
        '
        Me.btnEvaluateRegEx.Location = New System.Drawing.Point(775, 15)
        Me.btnEvaluateRegEx.Name = "btnEvaluateRegEx"
        Me.btnEvaluateRegEx.Size = New System.Drawing.Size(75, 56)
        Me.btnEvaluateRegEx.TabIndex = 9
        Me.btnEvaluateRegEx.Text = "Evaluate Regex"
        Me.btnEvaluateRegEx.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(398, 109)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 13)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Final Result :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(526, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "RegEx 3:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Sample:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(266, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "RegEx 2:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(528, 44)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Result 3:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(268, 44)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 13)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Result 2:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 44)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 13)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Result 1:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 13)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "RegEx 1:"
        '
        'txtRegexPreview
        '
        Me.txtRegexPreview.BackColor = System.Drawing.SystemColors.Info
        Me.txtRegexPreview.Location = New System.Drawing.Point(472, 106)
        Me.txtRegexPreview.Name = "txtRegexPreview"
        Me.txtRegexPreview.ReadOnly = True
        Me.txtRegexPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegexPreview.Size = New System.Drawing.Size(378, 20)
        Me.txtRegexPreview.TabIndex = 2
        '
        'txtRegex3
        '
        Me.txtRegex3.BackColor = System.Drawing.Color.LightGray
        Me.txtRegex3.Location = New System.Drawing.Point(581, 19)
        Me.txtRegex3.Name = "txtRegex3"
        Me.txtRegex3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegex3.Size = New System.Drawing.Size(186, 20)
        Me.txtRegex3.TabIndex = 2
        '
        'txtRegexSample
        '
        Me.txtRegexSample.Location = New System.Drawing.Point(59, 106)
        Me.txtRegexSample.Name = "txtRegexSample"
        Me.txtRegexSample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegexSample.Size = New System.Drawing.Size(333, 20)
        Me.txtRegexSample.TabIndex = 2
        Me.txtRegexSample.Text = "JOBS.COSBILD1.TESTTTT"
        '
        'txtRegex2
        '
        Me.txtRegex2.BackColor = System.Drawing.Color.LightGray
        Me.txtRegex2.Location = New System.Drawing.Point(321, 19)
        Me.txtRegex2.Name = "txtRegex2"
        Me.txtRegex2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegex2.Size = New System.Drawing.Size(201, 20)
        Me.txtRegex2.TabIndex = 2
        '
        'txtRegex1
        '
        Me.txtRegex1.BackColor = System.Drawing.Color.White
        Me.txtRegex1.Location = New System.Drawing.Point(61, 19)
        Me.txtRegex1.Name = "txtRegex1"
        Me.txtRegex1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegex1.Size = New System.Drawing.Size(201, 20)
        Me.txtRegex1.TabIndex = 1
        Me.txtRegex1.Text = "[^.*?\.]\w*$"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkRenameInProccess)
        Me.GroupBox4.Controls.Add(Me.lvPreview)
        Me.GroupBox4.Controls.Add(Me.btnRemoveFromRenameList)
        Me.GroupBox4.Controls.Add(Me.btnBrowseRename)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtObjectTitle)
        Me.GroupBox4.Controls.Add(Me.btnPreview)
        Me.GroupBox4.Controls.Add(Me.btnGO)
        Me.GroupBox4.Controls.Add(Me.btnTongleSelection)
        Me.GroupBox4.Controls.Add(Me.btnSelectUnselectAll)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(856, 225)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select objects to apply"
        '
        'lvPreview
        '
        Me.lvPreview.CheckBoxes = True
        Me.lvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvchOriginal, Me.lvchPreview})
        Me.lvPreview.FullRowSelect = True
        Me.lvPreview.GridLines = True
        Me.lvPreview.Location = New System.Drawing.Point(7, 77)
        Me.lvPreview.MultiSelect = False
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(845, 142)
        Me.lvPreview.TabIndex = 15
        Me.lvPreview.UseCompatibleStateImageBehavior = False
        Me.lvPreview.View = System.Windows.Forms.View.Details
        '
        'lvchOriginal
        '
        Me.lvchOriginal.Text = "Original"
        Me.lvchOriginal.Width = 410
        '
        'lvchPreview
        '
        Me.lvchPreview.Text = "Preview"
        Me.lvchPreview.Width = 410
        '
        'btnRemoveFromRenameList
        '
        Me.btnRemoveFromRenameList.Location = New System.Drawing.Point(129, 19)
        Me.btnRemoveFromRenameList.Name = "btnRemoveFromRenameList"
        Me.btnRemoveFromRenameList.Size = New System.Drawing.Size(116, 23)
        Me.btnRemoveFromRenameList.TabIndex = 14
        Me.btnRemoveFromRenameList.Text = "Remove UnChecked"
        Me.btnRemoveFromRenameList.UseVisualStyleBackColor = True
        '
        'btnBrowseRename
        '
        Me.btnBrowseRename.Location = New System.Drawing.Point(7, 19)
        Me.btnBrowseRename.Name = "btnBrowseRename"
        Me.btnBrowseRename.Size = New System.Drawing.Size(116, 23)
        Me.btnBrowseRename.TabIndex = 13
        Me.btnBrowseRename.Text = "Add Objects"
        Me.btnBrowseRename.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(418, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Title"
        '
        'txtObjectTitle
        '
        Me.txtObjectTitle.Location = New System.Drawing.Point(451, 22)
        Me.txtObjectTitle.Name = "txtObjectTitle"
        Me.txtObjectTitle.Size = New System.Drawing.Size(397, 20)
        Me.txtObjectTitle.TabIndex = 10
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(421, 48)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 9
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(775, 48)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(75, 23)
        Me.btnGO.TabIndex = 9
        Me.btnGO.Text = "Go"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'btnTongleSelection
        '
        Me.btnTongleSelection.Location = New System.Drawing.Point(129, 48)
        Me.btnTongleSelection.Name = "btnTongleSelection"
        Me.btnTongleSelection.Size = New System.Drawing.Size(116, 23)
        Me.btnTongleSelection.TabIndex = 8
        Me.btnTongleSelection.Text = "Tongle Selection"
        Me.btnTongleSelection.UseVisualStyleBackColor = True
        '
        'btnSelectUnselectAll
        '
        Me.btnSelectUnselectAll.Location = New System.Drawing.Point(7, 48)
        Me.btnSelectUnselectAll.Name = "btnSelectUnselectAll"
        Me.btnSelectUnselectAll.Size = New System.Drawing.Size(116, 23)
        Me.btnSelectUnselectAll.TabIndex = 7
        Me.btnSelectUnselectAll.Text = "Select None"
        Me.btnSelectUnselectAll.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtWithName)
        Me.GroupBox3.Controls.Add(Me.txtRepaceName)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 513)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(856, 118)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Apply On RegEx's Final Result"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Info
        Me.Label19.Location = New System.Drawing.Point(288, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(562, 71)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = resources.GetString("Label19.Text")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(288, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Instructions"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(147, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "With"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Replace"
        '
        'txtWithName
        '
        Me.txtWithName.Location = New System.Drawing.Point(147, 38)
        Me.txtWithName.Multiline = True
        Me.txtWithName.Name = "txtWithName"
        Me.txtWithName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWithName.Size = New System.Drawing.Size(135, 74)
        Me.txtWithName.TabIndex = 2
        Me.txtWithName.Text = "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "."
        '
        'txtRepaceName
        '
        Me.txtRepaceName.Location = New System.Drawing.Point(7, 38)
        Me.txtRepaceName.Multiline = True
        Me.txtRepaceName.Name = "txtRepaceName"
        Me.txtRepaceName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRepaceName.Size = New System.Drawing.Size(134, 74)
        Me.txtRepaceName.TabIndex = 1
        Me.txtRepaceName.Text = "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "_"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPrefixIncNumberSTART)
        Me.GroupBox1.Controls.Add(Me.chkPrefixIncNumberEND)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbDelimiterPrefix1_2)
        Me.GroupBox1.Controls.Add(Me.txtPrefix1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 56)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Prefix"
        '
        'chkPrefixIncNumberSTART
        '
        Me.chkPrefixIncNumberSTART.AutoSize = True
        Me.chkPrefixIncNumberSTART.Location = New System.Drawing.Point(376, 12)
        Me.chkPrefixIncNumberSTART.Name = "chkPrefixIncNumberSTART"
        Me.chkPrefixIncNumberSTART.Size = New System.Drawing.Size(222, 17)
        Me.chkPrefixIncNumberSTART.TabIndex = 8
        Me.chkPrefixIncNumberSTART.Text = "Icreament Number at the START of prefix"
        Me.chkPrefixIncNumberSTART.UseVisualStyleBackColor = True
        '
        'chkPrefixIncNumberEND
        '
        Me.chkPrefixIncNumberEND.AutoSize = True
        Me.chkPrefixIncNumberEND.Location = New System.Drawing.Point(376, 35)
        Me.chkPrefixIncNumberEND.Name = "chkPrefixIncNumberEND"
        Me.chkPrefixIncNumberEND.Size = New System.Drawing.Size(209, 17)
        Me.chkPrefixIncNumberEND.TabIndex = 8
        Me.chkPrefixIncNumberEND.Text = "Icreament Number at the END of prefix"
        Me.chkPrefixIncNumberEND.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(302, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Delimiter"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(130, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Prefix"
        '
        'cmbDelimiterPrefix1_2
        '
        Me.cmbDelimiterPrefix1_2.FormattingEnabled = True
        Me.cmbDelimiterPrefix1_2.Items.AddRange(New Object() {".", "_", "-"})
        Me.cmbDelimiterPrefix1_2.Location = New System.Drawing.Point(301, 27)
        Me.cmbDelimiterPrefix1_2.Name = "cmbDelimiterPrefix1_2"
        Me.cmbDelimiterPrefix1_2.Size = New System.Drawing.Size(49, 21)
        Me.cmbDelimiterPrefix1_2.TabIndex = 4
        Me.cmbDelimiterPrefix1_2.Text = "."
        '
        'txtPrefix1
        '
        Me.txtPrefix1.Location = New System.Drawing.Point(7, 28)
        Me.txtPrefix1.Name = "txtPrefix1"
        Me.txtPrefix1.Size = New System.Drawing.Size(288, 20)
        Me.txtPrefix1.TabIndex = 1
        Me.txtPrefix1.Text = "JOBS_"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkSuffixIncNumberSTART)
        Me.GroupBox2.Controls.Add(Me.chkSuffixIncNumberEND)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cmbDelimiterSuffix1_2)
        Me.GroupBox2.Controls.Add(Me.txtSuffix1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(856, 64)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Suffix"
        '
        'chkSuffixIncNumberSTART
        '
        Me.chkSuffixIncNumberSTART.AutoSize = True
        Me.chkSuffixIncNumberSTART.Location = New System.Drawing.Point(376, 19)
        Me.chkSuffixIncNumberSTART.Name = "chkSuffixIncNumberSTART"
        Me.chkSuffixIncNumberSTART.Size = New System.Drawing.Size(221, 17)
        Me.chkSuffixIncNumberSTART.TabIndex = 10
        Me.chkSuffixIncNumberSTART.Text = "Icreament Number at the START of suffix"
        Me.chkSuffixIncNumberSTART.UseVisualStyleBackColor = True
        '
        'chkSuffixIncNumberEND
        '
        Me.chkSuffixIncNumberEND.AutoSize = True
        Me.chkSuffixIncNumberEND.Location = New System.Drawing.Point(376, 42)
        Me.chkSuffixIncNumberEND.Name = "chkSuffixIncNumberEND"
        Me.chkSuffixIncNumberEND.Size = New System.Drawing.Size(208, 17)
        Me.chkSuffixIncNumberEND.TabIndex = 9
        Me.chkSuffixIncNumberEND.Text = "Icreament Number at the END of suffix"
        Me.chkSuffixIncNumberEND.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(301, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Delimiter"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(129, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Suffix"
        '
        'cmbDelimiterSuffix1_2
        '
        Me.cmbDelimiterSuffix1_2.FormattingEnabled = True
        Me.cmbDelimiterSuffix1_2.Items.AddRange(New Object() {".", "_", "-"})
        Me.cmbDelimiterSuffix1_2.Location = New System.Drawing.Point(301, 28)
        Me.cmbDelimiterSuffix1_2.Name = "cmbDelimiterSuffix1_2"
        Me.cmbDelimiterSuffix1_2.Size = New System.Drawing.Size(49, 21)
        Me.cmbDelimiterSuffix1_2.TabIndex = 4
        Me.cmbDelimiterSuffix1_2.Text = "_"
        '
        'txtSuffix1
        '
        Me.txtSuffix1.Location = New System.Drawing.Point(6, 28)
        Me.txtSuffix1.Name = "txtSuffix1"
        Me.txtSuffix1.Size = New System.Drawing.Size(288, 20)
        Me.txtSuffix1.TabIndex = 1
        Me.txtSuffix1.Text = "BLIM"
        '
        'chkRenameInProccess
        '
        Me.chkRenameInProccess.AutoSize = True
        Me.chkRenameInProccess.Checked = True
        Me.chkRenameInProccess.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRenameInProccess.Location = New System.Drawing.Point(619, 54)
        Me.chkRenameInProccess.Name = "chkRenameInProccess"
        Me.chkRenameInProccess.Size = New System.Drawing.Size(148, 17)
        Me.chkRenameInProccess.TabIndex = 16
        Me.chkRenameInProccess.Text = "Also Rename In Proccess"
        Me.chkRenameInProccess.UseVisualStyleBackColor = True
        '
        'frmRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 638)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmRename"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rename"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegexHelp As System.Windows.Forms.Button
    Friend WithEvents lstRegexPreview3 As System.Windows.Forms.ListBox
    Friend WithEvents lstRegexPreview2 As System.Windows.Forms.ListBox
    Friend WithEvents lstRegexPreview1 As System.Windows.Forms.ListBox
    Friend WithEvents btnEvaluateRegEx As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtRegexPreview As System.Windows.Forms.TextBox
    Friend WithEvents txtRegex3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRegexSample As System.Windows.Forms.TextBox
    Friend WithEvents txtRegex2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRegex1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lvPreview As System.Windows.Forms.ListView
    Friend WithEvents lvchOriginal As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvchPreview As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoveFromRenameList As System.Windows.Forms.Button
    Friend WithEvents btnBrowseRename As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtObjectTitle As System.Windows.Forms.TextBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents btnTongleSelection As System.Windows.Forms.Button
    Friend WithEvents btnSelectUnselectAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtWithName As System.Windows.Forms.TextBox
    Friend WithEvents txtRepaceName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPrefixIncNumberSTART As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrefixIncNumberEND As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbDelimiterPrefix1_2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrefix1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSuffixIncNumberSTART As System.Windows.Forms.CheckBox
    Friend WithEvents chkSuffixIncNumberEND As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbDelimiterSuffix1_2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSuffix1 As System.Windows.Forms.TextBox
    Friend WithEvents chkRenameInProccess As System.Windows.Forms.CheckBox
End Class
