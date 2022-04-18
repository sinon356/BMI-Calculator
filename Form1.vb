Public Class Form1
    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As Single, w As Single
        h = Val(txt1.Text)
        w = Val(txt2.Text)
        Result.Text = BMI(h, w)
    End Sub
End Class
