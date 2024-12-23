Public Class Login_Formvb
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        SignUpForm.ShowDialog()
        Me.Close()

    End Sub
End Class