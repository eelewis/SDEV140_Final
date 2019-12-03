Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(InputBox.Text * 2)
        InputBox.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(InputBox.Text / 2)
        InputBox.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Num4.Click
        InputBox.Text = InputBox.Text + "4"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Num7.Click
        InputBox.Text = InputBox.Text + "7"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Num8.Click
        InputBox.Text = InputBox.Text + "8"

    End Sub

    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        InputBox.Text = InputBox.Text + "1"
    End Sub

    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        InputBox.Text = InputBox.Text + "2"

    End Sub

    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        InputBox.Text = InputBox.Text + "3"

    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        InputBox.Text = InputBox.Text + "5"

    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        InputBox.Text = InputBox.Text + "6"

    End Sub

    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        InputBox.Text = InputBox.Text + "9"

    End Sub

    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click
        InputBox.Text = InputBox.Text + "0"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InputBox.Text = ""
    End Sub
End Class
