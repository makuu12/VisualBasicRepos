Imports System.Data.SqlClient



Public Class loginForm

    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim username, password As String
    Dim sql As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = Textusername.Text
        password = Textpassword.Text

        If (username = "" And password = "") Then
            MessageBox.Show("Please enter your Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ConnDb()
            con.Open()
            sql = "select * from Login where username = '" & username & "' and password = '" & password & "'"
            cmd = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader

            If (dr.Read = True) Then
                Dim f2 As Main = New Main
                f2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
        con.Close()
    End Sub
End Class
