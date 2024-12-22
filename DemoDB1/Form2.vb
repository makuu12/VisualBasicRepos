Imports System.Net

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_form()
    End Sub
    Dim dt As New DataTable
    Sub load_form()

        Try

            ConnDb()
            con.Open()
            Dim cmd1 As New SqlClient.SqlCommand("SELECT empno, firstname, lastname, address, sex, contactno, dateofbirth, position, dateofhire, department, salary FROM compayroll", con)
            cmd1.CommandType = CommandType.Text
            Dim da2 As New SqlClient.SqlDataAdapter
            da2.SelectCommand = cmd1
            dt = New DataTable
            da2.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sqlsearch As String = "SELECT * FROM compayroll WHERE empno = '" & TextBox1.Text & "'"
        ConnDb()
        con.Open()
        Dim cmd1 As New SqlClient.SqlCommand(sqlsearch, con)
        cmd1.CommandType = CommandType.Text
        cmd1.ExecuteNonQuery()
        Dim da2 As New SqlClient.SqlDataAdapter
        da2.SelectCommand = cmd1
        dt = New DataTable
        da2.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub


End Class