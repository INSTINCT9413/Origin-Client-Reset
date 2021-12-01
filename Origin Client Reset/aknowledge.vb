Public Class aknowledge
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As New Form2
        frm2.Show()
        Dim CRAD As New ClientResetAd
        CRAD.Show()
        Threading.Thread.Sleep(1000)
        Close()
    End Sub

    Private Sub aknowledge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Select()
    End Sub
End Class