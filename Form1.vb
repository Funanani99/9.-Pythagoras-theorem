Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = (a ^ 2 + b ^ 2) ^ 0.5
        TextBox3.Text = Math.Round(c, 2)
        ' TextBox3.Text = c
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
