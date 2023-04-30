Public Class Form1

    Private Sub MultiplicationTable()
        RichTextBox1.AppendText("Multiplication Table")
        RichTextBox1.AppendText(ControlChars.Lf)
        RichTextBox1.AppendText("* 1 2 3 4 5 6 7")
        RichTextBox1.AppendText(ControlChars.Lf)
        For i As Integer = 1 To 7
            RichTextBox1.AppendText(i & " ")
            For j As Integer = 1 To 7
                RichTextBox1.AppendText(i * j & " ")
            Next
            RichTextBox1.AppendText(ControlChars.Lf)
        Next
        RichTextBox1.AppendText(ControlChars.Lf)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call MultiplicationTable()
    End Sub
End Class
