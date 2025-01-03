Public Class lab


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tot As Integer
        For i = 0 To ListBox1.Items.Count - 1
            tot = tot + Val(ListBox1.Items(i))
        Next
        Label3.Text = "Total Price: " + tot.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
End Class