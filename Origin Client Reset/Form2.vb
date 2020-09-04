Imports System.IO
Imports System.Threading
Imports System.ServiceProcess
Public Class Form2
    Dim localdisk As String = IO.Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))
    Dim AC As String = localdisk & "ProgramData\Origin\AchievementCache"
    Dim CC As String = localdisk & "ProgramData\Origin\CatalogCache"
    Dim CBC As String = localdisk & "ProgramData\Origin\CustomBoxartCache"
    Dim DC As String = localdisk & "ProgramData\Origin\DownloadCache"
    Dim EC As String = localdisk & "ProgramData\Origin\EntitlementCache"
    Dim IGOC As String = localdisk & "ProgramData\Origin\IGOCache"
    Dim Logs1 As String = localdisk & "ProgramData\Origin\Logs"
    Dim NOCC As String = localdisk & "ProgramData\Origin\NonOriginContentCache"
    Dim temp1 As String = localdisk & "temp\"
    Dim temp2 As String = localdisk & "Windows\Temp\"
    Dim temp3 As String = localdisk & "Users\" & Environment.UserName & "\AppData\Local\Temp"
    Dim CC2 As String = localdisk & "Users\" & Environment.UserName & "\AppData\Roaming\Origin\CatalogCache"
    Dim CS As String = localdisk & "Users\" & Environment.UserName & "\AppData\Roaming\Origin\Cloud Saves"
    Dim CT As String = localdisk & "Users\" & Environment.UserName & "\AppData\Roaming\Origin\CommonTitles"
    Dim CC3 As String = localdisk & "Users\" & Environment.UserName & "\AppData\Roaming\Origin\ConsolidatedCache"
    Dim NC As String = localdisk & "Users\" & Environment.UserName & "\AppData\Roaming\Origin\NucleusCache"
    Dim WU As String = localdisk & "Users\" & Environment.UserName & "\AppData\Roaming\Origin\Widget Updates"
    Dim origin As String = localdisk & "Users\" & Environment.UserName & "\AppData\Local\Origin"
    Dim originexe As String = localdisk & "Program Files\Origin\Origin.exe"
    Dim p As Process()



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        OriginForm1.Image = My.Resources.Origin_64px
        Me.Icon = My.Resources.icons8_Origin
        Me.Text = "Origin Client Reset Tool"
        Label2.Text = "Origin Location: " & originexe
        Label2.Visible = True
        If File.Exists(originexe) Then

        Else
            Dim mess = MessageBox.Show("We could not find Origin!" & vbNewLine & "Do you have Origin installed?", "ERROR - Origin Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If mess = DialogResult.Yes Then
                Dim fbd As New FolderBrowserDialog
                fbd.ShowDialog()
                originexe = fbd.SelectedPath & "\Origin.exe"
                Label2.Text = "Origin Location: " & originexe
            ElseIf mess = DialogResult.No Then
                Application.Exit()
            End If

        End If
    End Sub


    Private Sub OriginButton1_Click(sender As Object, e As EventArgs) Handles OriginButton1.Click
        Label1.Visible = True
        Thread.Sleep(1000)
        If OriginButton1.Text = "RESET ORIGIN" Then
            PictureBox2.Visible = True

            Thread.Sleep(1000)
            p = Process.GetProcessesByName("Origin")
            If p.Count > 0 Then
                MessageBox.Show("We detected that Origin is still open and we can't continue with the reset!" & vbNewLine & "We will try and close Origin for you!", "Can't Continue", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Try
                    Process.GetProcessesByName("OriginWebHelperService")(0).Kill()
                Catch ex As Exception

                End Try
                Try
                    Dim proc1 = Process.GetProcessesByName("Origin")

                    For i As Integer = 0 To proc1.Count - 1
                        proc1(i).CloseMainWindow()
                    Next i
                    Process.GetProcessesByName("Origin")(0).Kill()
                Catch ex As Exception

                End Try
                Dim worker As New Thread(New ThreadStart(Function()
                                                             DeleteFiles()
                                                         End Function))
                CheckForIllegalCrossThreadCalls = False
                worker.Start()
            Else
                Try
                    Process.GetProcessesByName("OriginWebHelperService")(0).Kill()
                Catch ex As Exception

                End Try



                Dim worker As New Thread(New ThreadStart(Function()
                                                             DeleteFiles()
                                                         End Function))
                CheckForIllegalCrossThreadCalls = False
                worker.Start()

            End If
        Else
            Dim mess = MessageBox.Show("The reset process is complete! We highly recommend restarting your computer and then launch Origin, Click Yes to restart, Click No to launch Origin", "Restart Recommended", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If mess = DialogResult.Yes Then
                Shell("Shutdown -r -t 5")
            Else
                If File.Exists(originexe) Then
                    System.Diagnostics.Process.Start(originexe)
                    Thread.Sleep(5000)
                    Application.Exit()
                Else
                    MessageBox.Show("We could not find Origin!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If
        End If
    End Sub
    Public Sub DeleteFiles()
        Try
            OriginButton1.Enabled = False
            If Directory.Exists(AC) Then
                Directory.Delete(AC, True)
            End If
            Label1.Text = "Stage: 1 of 17"
            Thread.Sleep(1500)
            If Directory.Exists(CC) Then
                Directory.Delete(CC, True)
            End If
            Label1.Text = "Stage: 2 of 17"
            Thread.Sleep(1300)
            If Directory.Exists(CBC) Then
                Directory.Delete(CBC, True)
            End If
            Label1.Text = "Stage: 3 of 17"
            Thread.Sleep(1900)
            If Directory.Exists(DC) Then
                Directory.Delete(DC, True)
            End If
            Label1.Text = "Stage: 4 of 17"
            Thread.Sleep(1100)
            If Directory.Exists(EC) Then
                Directory.Delete(EC, True)
            End If
            Label1.Text = "Stage: 5 of 17"
            Thread.Sleep(1654)
            If Directory.Exists(IGOC) Then
                Directory.Delete(IGOC, True)
            End If
            Label1.Text = "Stage: 6 of 17"
            Thread.Sleep(1000)
            If Directory.Exists(Logs1) Then
                Directory.Delete(Logs1, True)
            End If
            Label1.Text = "Stage: 7 of 17"
            Thread.Sleep(1000)
            If Directory.Exists(NOCC) Then
                Directory.Delete(NOCC, True)
            End If
            Label1.Text = "Stage: 8 of 17"
            Thread.Sleep(1000)
            'If Directory.Exists(temp1) Then
            'Directory.Delete(temp1, True)
            'End If
            For Each file As IO.FileInfo In New IO.DirectoryInfo(temp1).GetFiles("*.*")
                'If (Now - file.CreationTime).Days > Now Then
                Try
                        file.Delete()
                    Catch
                        ' log exception or ignore '
                    End Try
                'End If
            Next
            Label1.Text = "Stage: 9 of 17"
            Thread.Sleep(2500)
            'If Directory.Exists(temp2) Then
            'Directory.Delete(temp2, True)
            'End If
            For Each file As IO.FileInfo In New IO.DirectoryInfo(temp2).GetFiles("*.*")
                'If (Now - file.CreationTime).Days > Now Then
                Try
                    file.Delete()
                Catch
                    ' log exception or ignore '
                End Try
                'End If
            Next
            For Each file As IO.FileInfo In New IO.DirectoryInfo(temp3).GetFiles("*.*")
                'If (Now - file.CreationTime).Days > Now Then
                Try
                    file.Delete()
                Catch
                    ' log exception or ignore '
                End Try
                'End If
            Next
            Label1.Text = "Stage: 10 of 17"
            Thread.Sleep(2500)
            If Directory.Exists(CC2) Then
                Directory.Delete(CC2, True)
            End If
            Label1.Text = "Stage: 11 of 17"
            Thread.Sleep(1000)
            If Directory.Exists(CS) Then
                Directory.Delete(CS, True)
            End If
            Label1.Text = "Stage: 12 of 17"
            Thread.Sleep(1000)
            If Directory.Exists(CT) Then
                Directory.Delete(CT, True)
            End If
            Label1.Text = "Stage: 13 of 17"
            Thread.Sleep(200)
            If Directory.Exists(CC3) Then
                Directory.Delete(CC3, True)
            End If
            Label1.Text = "Stage: 14 of 17"
            Thread.Sleep(500)
            If Directory.Exists(NC) Then
                Directory.Delete(NC, True)
            End If
            Label1.Text = "Stage: 15 of 17"
            Thread.Sleep(2000)
            If Directory.Exists(WU) Then
                Directory.Delete(WU, True)
            End If
            Label1.Text = "Stage: 16 of 17"
            Thread.Sleep(2000)
            If Directory.Exists(origin) Then
                Directory.Delete(origin, True)
            End If
            Label1.Text = "Stage: 17 of 17"
            Try
                Process.GetProcessesByName("explorer")(0).Kill()
            Catch ex As Exception

            End Try
            Thread.Sleep(5000)
            p = Process.GetProcessesByName("Origin")
            If p.Count > 0 Then

            Else
                System.Diagnostics.Process.Start("explorer.exe")
            End If
            Label1.Text = "Reset Complete"
            PictureBox2.Visible = False
            OriginButton1.Enabled = True
            OriginButton1.Text = "NEXT"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Can't Continue", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox1.Show()
    End Sub

    Private Sub OriginTopButton1_Click(sender As Object, e As EventArgs) Handles OriginTopButton1.Click
        Application.Exit()
    End Sub
End Class