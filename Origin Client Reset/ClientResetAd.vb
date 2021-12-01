Imports System.Threading

Public Class ClientResetAd
    Dim timeRemain As Integer
    Dim totalTime As Integer = 20

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Client Reset is a utility program like Origin Client Reset, but has all the major clients included. This allows you to fix and reset clients like Steam, Battle.net, Origin, etc. Client Reset also comes with a downloader if you do not have a client already installed as well as themes and a few handy settings. Client Reset is also coded in C# instead of VB.NET which will be a bit more optimized and should run smoother. Client Reset will have long time support(LTS) and new features will be added.", "About Client Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClientResetAd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Try Client Reset - AIO Client Reset Utility " & timeRemain & " Second(s) Remain"
        Button1.Text = "Keep Origin Reset - Wait: " & timeRemain

        System.Threading.Thread.Sleep(1)
        Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        totalTime = totalTime - 1
        timeRemain = totalTime

        Button1.Text = "Keep Origin Reset - Wait:" & timeRemain
        Me.Text = "Try Client Reset - AIO Client Reset Utility (Please Wait: " & timeRemain & " Seconds)"
        If totalTime <= 0 Then
            Timer1.Stop()
            Button1.Text = "Keep Origin Reset"
            Button1.Enabled = True
            Me.Text = "Try Client Reset - AIO Client Reset Utility"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            My.Computer.Network.DownloadFile("https://jacobbrookhouse.me/downloads/server2/product/clientreset/Client%20Reset.exe",
                                            Application.StartupPath + "\Client Reset.exe",
                                            "",
                                            "",
                                            False,
                                            40000,
                                            True)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "An error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Diagnostics.Process.Start(Application.StartupPath + "\Client Reset.exe")
            Application.Exit()
        End Try
    End Sub
End Class