Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(InputBox.Text * 2)
        InputBox.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(InputBox.Text / 2)
        InputBox.Text = ""
    End Sub
End Class
