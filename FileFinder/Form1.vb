Imports System
Imports System.IO
Imports System.Threading

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x As Long, line As String
        Dim di As New DirectoryInfo(SearchFolder.Text)
        Dim files() As String, sFile As String


        Label1.Text = "Started."
        lst_Queue.Items.Clear()

        If IO.Directory.Exists(SearchFolder.Text) = False Then
            Call MsgBox("Search directory not found.", vbCritical)
            Exit Sub
        End If

        If IO.Directory.Exists(ArchiveFolder.Text) = False And chk_MoveFiles.Checked Then
            Call MsgBox("Archive directory not found.", vbCritical)
            Exit Sub
        End If

        If Mid(SearchFolder.Text, SearchFolder.TextLength, 1) <> "\" Then SearchFolder.Text = SearchFolder.Text & "\"

        If Mid(ArchiveFolder.Text, ArchiveFolder.TextLength, 1) <> "\" Then ArchiveFolder.Text = ArchiveFolder.Text & "\"

        If chk_Subdir.Checked Then 'all subdirectories or top?
            files = IO.Directory.GetFiles(SearchFolder.Text, txt_FileExt.Text, SearchOption.AllDirectories)
        Else
            files = IO.Directory.GetFiles(SearchFolder.Text, txt_FileExt.Text, SearchOption.TopDirectoryOnly)
        End If

        'Add listbox to queue
        For Each sFile In files
            lst_Queue.Items.Add(sFile.ToString)
        Next

        'quit if nothing is found
        If lst_Queue.Items.Count = 0 Or lst_Queue.Items.Count = -1 Then
            Call MsgBox("No files were found.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'remove blank lines and some trimming
        If chk_Multiple.Checked Then
            Dim lines() As String = lst_Multiple.Text.Split(vbNewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            lst_Multiple.Text = String.Join(vbNewLine, lines)
        End If

        Application.DoEvents()
        TrackBar1.Value = 0
        TrackBar1.Maximum = lst_Queue.Items.Count - 1

        Do
            TrackBar1.Value = lst_Queue.Items.Count - 1

            'let's open the file
            sFile = lst_Queue.Items(0).ToString
            Using sr As New StreamReader(sFile)
                Do
                    line = sr.ReadToEnd
                    Label1.Text = "Loading " & sFile & "..."
                    Application.DoEvents()
                Loop Until sr.BaseStream.Position = sr.BaseStream.Length

                txt_Results.Text = Replace(line, " ", "") 'fill the textbox
                'Thread.Sleep(1000) 'prevents duplicate file names, just in case. Also ensures it's loaded

                'Do 'wait until the textbox has data in it before moving on
                'Application.DoEvents()
                'Loop Until TextBox1.Text <> ""

                'remove fluff 
                Application.DoEvents()
            End Using

            'is there a match?
            If chk_Multiple.Checked Then
                For Each itm As String In lst_Multiple.Text.Split(Environment.NewLine)

                    'itm = Trim(Mid(itm, 2))
                    itm = LCase(Replace(itm, " ", ""))
                    x = InStr(LCase(txt_Results.Text), Trim(itm))

                    If x <> 0 Then

                        'remove items?
                        If chk_Remove.Checked Then
                            lst_Multiple.Text = Replace(lst_Multiple.Text, itm, "")
                            Dim lines() As String = lst_Multiple.Text.Split(vbNewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
                            lst_Multiple.Text = String.Join(vbNewLine, lines)
                        End If

                        'find the item
                        GoTo TheFound
                    End If

                Next
            Else
                x = InStr(LCase(txt_Results.Text), LCase(Trim(TheFile.Text)))
            End If

TheFound:
            If x <> 0 Then
                Label5.Text = sFile
                Label1.Text = "Found file!!!"

                Dim newFile As String = Mid(sFile, sFile.LastIndexOf("\") + 2, sFile.Length)

                'move files checked?
                If chk_MoveFiles.Checked Then
                    'move files
                    If File.Exists(ArchiveFolder.Text & sFile) = True Then 'add date on filename if it already exists
                        File.Move(sFile, ArchiveFolder.Text & DateTime.Now.ToString("hhmmss") & newFile)
                    Else
                        File.Move(sFile, ArchiveFolder.Text & newFile)
                    End If
                End If

                'copy files checked?
                If chk_CopyFiles.Checked Then
                    'copy files
                    If File.Exists(ArchiveFolder.Text & sFile) = True Then 'add date on filename if it already exists
                        File.Copy(sFile, ArchiveFolder.Text & DateTime.Now.ToString("hhmmss") & newFile)
                    Else
                        File.Copy(sFile, ArchiveFolder.Text & newFile)
                    End If
                End If

                If chk_Notify.Checked Then
                    Clipboard.SetText(Label5.Text)
                    Call MsgBox("File has been located!" & vbNewLine & "File path copied to clipboard.", vbInformation, vbOKOnly)
                End If

                'stop if requested
                If chk_Stop.Checked Then
                    Exit Sub
                End If

            End If

            'continue forwards
            lst_Queue.Items.RemoveAt(0)
            txt_Results.Text = ""
            Label1.Text = "Waiting..."
            Application.DoEvents()
        Loop Until lst_Queue.Items.Count = 0

        Label1.Text = "Completed."
    End Sub
    Public Sub SearchData()

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Clipboard.SetText(Label5.Text)
        Call MsgBox("File path copied to clipboard.", MsgBoxStyle.Information)
    End Sub

    Private Sub Form1_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.SearchFolder = SearchFolder.Text
        My.Settings.ArchiveFolder = ArchiveFolder.Text
        My.Settings.TheText = TheFile.Text
        End
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.SearchFolder = SearchFolder.Text
        My.Settings.ArchiveFolder = ArchiveFolder.Text
        My.Settings.TheText = TheFile.Text
        End
    End Sub

    Private Sub Form1_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        My.Settings.SearchFolder = SearchFolder.Text
        My.Settings.ArchiveFolder = ArchiveFolder.Text
        My.Settings.TheText = TheFile.Text
        End
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SearchFolder.Text = My.Settings.SearchFolder
        ArchiveFolder.Text = My.Settings.ArchiveFolder
        TheFile.Text = My.Settings.TheText
    End Sub

    Private Sub chk_MoveFiles_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_MoveFiles.CheckedChanged
        If chk_MoveFiles.Checked = True Then
            ArchiveFolder.Enabled = True
            chk_CopyFiles.Enabled = False
            Exit Sub
        Else
            chk_CopyFiles.Enabled = True
            ArchiveFolder.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub chk_Multiple_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_Multiple.CheckedChanged
        If chk_Multiple.Checked Then
            TheFile.Enabled = False
            lst_Multiple.Visible = True
            chk_Remove.Visible = True
            Exit Sub
        Else
            TheFile.Enabled = True
            lst_Multiple.Visible = False
            chk_Remove.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub chk_CopyFound_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_CopyFiles.CheckedChanged
        If chk_CopyFiles.Checked = True Then
            ArchiveFolder.Enabled = True
            chk_MoveFiles.Enabled = False
            Exit Sub
        Else
            chk_MoveFiles.Enabled = True
            ArchiveFolder.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub TheFile_TextChanged(sender As System.Object, e As System.EventArgs) Handles TheFile.TextChanged
        If chk_Multiple.Checked Then
            chk_Multiple.Checked = False
            lst_Multiple.Visible = False
        End If
    End Sub
End Class
