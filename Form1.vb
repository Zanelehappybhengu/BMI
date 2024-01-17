Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight, hieght, bmi As Double

        weight = Val(TextBox1.Text)
        hieght = Val(TextBox2.Text)

        bmi = weight / (hieght) ^ 2

        TextBox3.Text = bmi

        If bmi < 18 Then
            TextBox4.Text = "underweight"
        ElseIf bmi >= 18 And bmi < 26 Then
            TextBox4.Text = "normal"
        Else
            TextBox4.Text = "overweight"
        End If


    End Sub
End Class
