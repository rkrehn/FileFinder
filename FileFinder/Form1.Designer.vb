<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchFolder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ArchiveFolder = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TheFile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.txt_Results = New System.Windows.Forms.TextBox()
        Me.lst_Queue = New System.Windows.Forms.ListBox()
        Me.chk_Subdir = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_Stop = New System.Windows.Forms.CheckBox()
        Me.chk_Notify = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_FileExt = New System.Windows.Forms.TextBox()
        Me.chk_Multiple = New System.Windows.Forms.CheckBox()
        Me.lst_Multiple = New System.Windows.Forms.TextBox()
        Me.chk_Remove = New System.Windows.Forms.CheckBox()
        Me.chk_CopyFiles = New System.Windows.Forms.CheckBox()
        Me.chk_MoveFiles = New System.Windows.Forms.CheckBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(407, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Scan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Not started..."
        '
        'SearchFolder
        '
        Me.SearchFolder.Location = New System.Drawing.Point(15, 25)
        Me.SearchFolder.Name = "SearchFolder"
        Me.SearchFolder.Size = New System.Drawing.Size(498, 20)
        Me.SearchFolder.TabIndex = 3
        Me.SearchFolder.Text = "C:\"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Directory to scan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Move/Copy files?"
        '
        'ArchiveFolder
        '
        Me.ArchiveFolder.Enabled = False
        Me.ArchiveFolder.Location = New System.Drawing.Point(104, 77)
        Me.ArchiveFolder.Name = "ArchiveFolder"
        Me.ArchiveFolder.Size = New System.Drawing.Size(402, 20)
        Me.ArchiveFolder.TabIndex = 5
        Me.ArchiveFolder.Text = "C:\"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "What are you looking for?"
        '
        'TheFile
        '
        Me.TheFile.Location = New System.Drawing.Point(15, 129)
        Me.TheFile.Name = "TheFile"
        Me.TheFile.Size = New System.Drawing.Size(267, 20)
        Me.TheFile.TabIndex = 7
        Me.TheFile.Text = "texthere"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(467, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Status"
        Me.Label5.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Enabled = False
        Me.TrackBar1.LargeChange = 25
        Me.TrackBar1.Location = New System.Drawing.Point(12, 283)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 238)
        Me.TrackBar1.TabIndex = 10
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'txt_Results
        '
        Me.txt_Results.Location = New System.Drawing.Point(63, 283)
        Me.txt_Results.MaxLength = 65535
        Me.txt_Results.Multiline = True
        Me.txt_Results.Name = "txt_Results"
        Me.txt_Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Results.Size = New System.Drawing.Size(450, 238)
        Me.txt_Results.TabIndex = 11
        '
        'lst_Queue
        '
        Me.lst_Queue.FormattingEnabled = True
        Me.lst_Queue.Location = New System.Drawing.Point(530, 25)
        Me.lst_Queue.Name = "lst_Queue"
        Me.lst_Queue.Size = New System.Drawing.Size(524, 420)
        Me.lst_Queue.TabIndex = 13
        '
        'chk_Subdir
        '
        Me.chk_Subdir.AutoSize = True
        Me.chk_Subdir.Location = New System.Drawing.Point(5, 20)
        Me.chk_Subdir.Name = "chk_Subdir"
        Me.chk_Subdir.Size = New System.Drawing.Size(130, 17)
        Me.chk_Subdir.TabIndex = 14
        Me.chk_Subdir.Text = "Search Subdirectories"
        Me.chk_Subdir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_Stop)
        Me.GroupBox1.Controls.Add(Me.chk_Notify)
        Me.GroupBox1.Controls.Add(Me.chk_Subdir)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 48)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'chk_Stop
        '
        Me.chk_Stop.AutoSize = True
        Me.chk_Stop.Location = New System.Drawing.Point(230, 20)
        Me.chk_Stop.Name = "chk_Stop"
        Me.chk_Stop.Size = New System.Drawing.Size(83, 17)
        Me.chk_Stop.TabIndex = 16
        Me.chk_Stop.Text = "Stop on find"
        Me.chk_Stop.UseVisualStyleBackColor = True
        '
        'chk_Notify
        '
        Me.chk_Notify.AutoSize = True
        Me.chk_Notify.Location = New System.Drawing.Point(135, 20)
        Me.chk_Notify.Name = "chk_Notify"
        Me.chk_Notify.Size = New System.Drawing.Size(88, 17)
        Me.chk_Notify.TabIndex = 15
        Me.chk_Notify.Text = "Notify on find"
        Me.chk_Notify.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Certain file names or  extensions? (*.txt for text)"
        '
        'txt_FileExt
        '
        Me.txt_FileExt.Location = New System.Drawing.Point(15, 173)
        Me.txt_FileExt.Name = "txt_FileExt"
        Me.txt_FileExt.Size = New System.Drawing.Size(498, 20)
        Me.txt_FileExt.TabIndex = 16
        Me.txt_FileExt.Text = "*.*"
        '
        'chk_Multiple
        '
        Me.chk_Multiple.AutoSize = True
        Me.chk_Multiple.Location = New System.Drawing.Point(288, 131)
        Me.chk_Multiple.Name = "chk_Multiple"
        Me.chk_Multiple.Size = New System.Drawing.Size(68, 17)
        Me.chk_Multiple.TabIndex = 18
        Me.chk_Multiple.Text = "Multiple?"
        Me.chk_Multiple.UseVisualStyleBackColor = True
        '
        'lst_Multiple
        '
        Me.lst_Multiple.Location = New System.Drawing.Point(362, 116)
        Me.lst_Multiple.Multiline = True
        Me.lst_Multiple.Name = "lst_Multiple"
        Me.lst_Multiple.Size = New System.Drawing.Size(148, 53)
        Me.lst_Multiple.TabIndex = 19
        Me.lst_Multiple.Visible = False
        '
        'chk_Remove
        '
        Me.chk_Remove.AutoSize = True
        Me.chk_Remove.Location = New System.Drawing.Point(288, 150)
        Me.chk_Remove.Name = "chk_Remove"
        Me.chk_Remove.Size = New System.Drawing.Size(72, 17)
        Me.chk_Remove.TabIndex = 20
        Me.chk_Remove.Text = "Remove?"
        Me.chk_Remove.UseVisualStyleBackColor = True
        Me.chk_Remove.Visible = False
        '
        'chk_CopyFiles
        '
        Me.chk_CopyFiles.AutoSize = True
        Me.chk_CopyFiles.Location = New System.Drawing.Point(15, 89)
        Me.chk_CopyFiles.Name = "chk_CopyFiles"
        Me.chk_CopyFiles.Size = New System.Drawing.Size(83, 17)
        Me.chk_CopyFiles.TabIndex = 21
        Me.chk_CopyFiles.Text = "Copy Found"
        Me.chk_CopyFiles.UseVisualStyleBackColor = True
        '
        'chk_MoveFiles
        '
        Me.chk_MoveFiles.AutoSize = True
        Me.chk_MoveFiles.Location = New System.Drawing.Point(16, 67)
        Me.chk_MoveFiles.Name = "chk_MoveFiles"
        Me.chk_MoveFiles.Size = New System.Drawing.Size(86, 17)
        Me.chk_MoveFiles.TabIndex = 12
        Me.chk_MoveFiles.Text = "Move Found"
        Me.chk_MoveFiles.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 553)
        Me.Controls.Add(Me.chk_CopyFiles)
        Me.Controls.Add(Me.chk_Remove)
        Me.Controls.Add(Me.lst_Multiple)
        Me.Controls.Add(Me.chk_MoveFiles)
        Me.Controls.Add(Me.chk_Multiple)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_FileExt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lst_Queue)
        Me.Controls.Add(Me.txt_Results)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TheFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ArchiveFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Deep file scanner"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ArchiveFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TheFile As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents txt_Results As System.Windows.Forms.TextBox
    Friend WithEvents lst_Queue As System.Windows.Forms.ListBox
    Friend WithEvents chk_Subdir As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_FileExt As System.Windows.Forms.TextBox
    Friend WithEvents chk_Multiple As System.Windows.Forms.CheckBox
    Friend WithEvents lst_Multiple As System.Windows.Forms.TextBox
    Friend WithEvents chk_Notify As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Stop As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Remove As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CopyFiles As System.Windows.Forms.CheckBox
    Friend WithEvents chk_MoveFiles As System.Windows.Forms.CheckBox

End Class
