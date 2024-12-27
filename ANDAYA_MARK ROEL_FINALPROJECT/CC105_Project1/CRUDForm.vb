
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CRUDForm
    Dim con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim da1 As SqlClient.SqlDataAdapter
    Dim sqladd As String
    Dim dt As DataTable


    Public Sub Binddata()
        Dim sql As String = "SELECT * FROM member"
        con1 = New SqlClient.SqlConnection
        con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2aCRUD;User ID=sa;Password=1234;Pooling=False"
        cmd = New SqlClient.SqlCommand(sql, con1)
        da1 = New SqlClient.SqlDataAdapter()
        da1.SelectCommand = cmd
        dt = New DataTable
        da1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        Binddata()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2aCRUD;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            Dim firstname1, lastname1, gender1 As String
            firstname1 = TextBox1.Text.Trim()
            lastname1 = TextBox2.Text.Trim()
            gender1 = ComboBox1.SelectedItem
            sqladd = "insert into member (first, last, gender) values ('" & firstname1 & "','" & lastname1 & "','" & gender1 & "')"
            cmd = New SqlClient.SqlCommand(sqladd, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successful inserted")
            Binddata()
            TextBox1.Clear()
            TextBox2.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2aCRUD;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            Dim firstname1, lastname1, gender1, newid As String
            newid = TextBox4.Text
            firstname1 = TextBox1.Text
            lastname1 = TextBox2.Text
            gender1 = ComboBox1.SelectedItem
            Dim sqlupdate = "UPDATE member SET " & "first = '" & firstname1 & "'," &
"last = '" & lastname1 & "'," &
                                                     "gender = '" & gender1 & "' WHERE id=" & TextBox4.Text

            cmd = New SqlClient.SqlCommand(sqlupdate, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record updated")
            Binddata()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Are you sure you want to Delete this row", "Attention!", MessageBoxButtons.YesNo)
        If Windows.Forms.DialogResult.Yes Then
            Try
                con1 = New SqlClient.SqlConnection
                con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2aCRUD;User ID=sa;Password=1234;Pooling=False"
                con1.Open()
                Dim newid As String
                newid = TextBox4.Text
                Dim sqldelete As String = "DELETE FROM member WHERE id= " & TextBox4.Text
                cmd = New SqlClient.SqlCommand(sqldelete, con1)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted")
                Binddata()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox4.Text = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
        Binddata()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim current_row As Integer = DataGridView1.CurrentRow.Index
        TextBox4.Text = DataGridView1(0, current_row).Value.ToString
        TextBox1.Text = DataGridView1(1, current_row).Value.ToString
        TextBox2.Text = DataGridView1(2, current_row).Value.ToString
        ComboBox1.Text = DataGridView1(3, current_row).Value.ToString
    End Sub

    Private Sub SearchBox_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim sqlsearch As String = "SELECT * FROM member WHERE id ='" & TextBox3.Text & "'"
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2aCRUD;User ID=sa;Password=1234;Pooling=False"
            cmd = New SqlClient.SqlCommand(sqlsearch, con1)
            cmd.CommandType = CommandType.Text
            da1 = New SqlClient.SqlDataAdapter()
            da1.SelectCommand = cmd
            dt = New DataTable
            da1.Fill(dt)
            If dt.Rows.Count > 0 Then
                TextBox4.Text = dt.Rows(0)(0).ToString()
                TextBox1.Text = dt.Rows(0)(1).ToString()
                TextBox2.Text = dt.Rows(0)(2).ToString()
                ComboBox1.Text = dt.Rows(0)(3).ToString()
            Else
                TextBox4.Clear()
                TextBox1.Clear()
                TextBox2.Clear()
                ComboBox1.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class


