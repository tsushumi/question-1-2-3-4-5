Public Class DemoForm
    Private Sub DemoForm()
        Me.Size = New System.Drawing.Size(My.Computer.Screen.WorkingArea.Width * 0.75, My.Computer.Screen.WorkingArea.Height * 0.5)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call DemoForm()
    End Sub
End Class
