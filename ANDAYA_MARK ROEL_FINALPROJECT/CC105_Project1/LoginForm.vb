




Imports Microsoft.VisualBasic.ApplicationServices

Public Class LoginForm


    Dim con1 As SqlClient.SqlConnection
    Dim da As SqlClient.SqlDataAdapter
    Dim cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Dim sql As String
    Dim rescount As Byte


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_andaya;Persist Security Info=True;User ID=sa;Password=1234"

            con1.Open()
            Dim user1, pass1 As String

            user1 = TextBox1.Text.Trim()
            pass1 = TextBox2.Text.Trim()

            sql = "select * from admin where username='" & user1 & "' and password = '" & pass1 & "'"
            da = New SqlClient.SqlDataAdapter(sql, con1)
            cb = New SqlClient.SqlCommandBuilder(da)
            ds = New DataSet
            da.Fill(ds, "admin1")
            rescount = ds.Tables(0).Rows.Count
            If rescount > 0 Then
                MessageBox.Show("Welcome " & user1)
                MainForm.ShowDialog()
                Close()
            Else
                MessageBox.Show("Incorrect Username and Password")

            End If

            con1.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class


