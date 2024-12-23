Public Class Form1
    Dim con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim cmd1 As SqlClient.SqlCommand
    Dim cmd2 As SqlClient.SqlCommand
    Dim da1 As SqlClient.SqlDataAdapter
    Dim da2 As SqlClient.SqlDataAdapter
    Dim da3 As SqlClient.SqlDataAdapter
    Dim sqladd As String
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dt2 As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_labexam;User ID=sa;Password=1234"
            con1.Open()
            Dim firstname1, lastname1 As String
            Dim gender1, course1, section1 As Integer
            firstname1 = TextBox1.Text.Trim()
            lastname1 = TextBox2.Text.Trim()
            gender1 = ComboBox1.SelectedValue
            course1 = ComboBox2.SelectedValue
            section1 = ComboBox3.SelectedValue
            sqladd = "insert into view2 (firstname, lastname, genderid, courseid, sectionid) values ('" & firstname1 & "','" & lastname1 & "','" & gender1 & "', " & course1 & " ," & section1 & ")"
            cmd = New SqlClient.SqlCommand(sqladd, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully inserted")
            sponge()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            ComboBox3.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub sponge()
        con1 = New SqlClient.SqlConnection
        con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_labexam;User ID=sa;Password=1234"
        cmd = New SqlClient.SqlCommand("SELECT * FROM view1", con1)
        cmd.CommandType = CommandType.Text
        da1 = New SqlClient.SqlDataAdapter()
        da1.SelectCommand = cmd
        dt = New DataTable
        da1.Fill(dt)
        DataGridView1.DataSource = dt
        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Student ID."
            .Columns(1).HeaderCell.Value = "First Name"
            .Columns(2).HeaderCell.Value = "Last Name"
            .Columns(3).HeaderCell.Value = "Gender"
            .Columns(4).HeaderCell.Value = "Course"
            .Columns(5).HeaderCell.Value = "Section"
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sponge()
        section()
        gender()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_labexam;User ID=sa;Password=1234"
            con1.Open()
            Dim cmd2 As New SqlClient.SqlCommand("SELECT DISTINCT courses.courseid, courses.course_desc FROM courses", con1)
            'INNER JOIN students ON courses.courseid=students.courseid
            cmd2.CommandType = CommandType.Text
            Dim da2 As New SqlClient.SqlDataAdapter
            da2.SelectCommand = cmd2
            Dim dt1 As New DataTable
            If da2.Fill(dt1) Then
                ComboBox2.DataSource = dt1
                ComboBox2.DisplayMember = "course_desc"
                ComboBox2.ValueMember = "courseid"
                ComboBox2.Text = "Select Course"
            Else
                ComboBox2.DataSource = Nothing
                ComboBox2.Text = "Select Course"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Public Sub section()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_labexam;User ID=sa;Password=1234"
            con1.Open()
            Dim cmd2 As New SqlClient.SqlCommand("SELECT DISTINCT sections.sectionid, sections.section_name FROM sections ", con1)
            cmd2.CommandType = CommandType.Text
            Dim da3 As New SqlClient.SqlDataAdapter
            da3.SelectCommand = cmd2
            Dim dt2 As New DataTable
            If da3.Fill(dt2) Then
                ComboBox3.DataSource = dt2
                ComboBox3.DisplayMember = "section_name"
                ComboBox3.ValueMember = "sectionid"
                ComboBox3.Text = "Select Section"
            Else
                ComboBox3.DataSource = Nothing
                ComboBox3.Text = "Select Section"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Public Sub gender()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_labexam;User ID=sa;Password=1234"
            con1.Open()
            Dim cmd3 As New SqlClient.SqlCommand("SELECT DISTINCT genders.genderid, genders.title FROM genders ", con1)
            cmd3.CommandType = CommandType.Text
            Dim da4 As New SqlClient.SqlDataAdapter
            da4.SelectCommand = cmd3
            Dim dt3 As New DataTable
            If da4.Fill(dt3) Then
                ComboBox1.DataSource = dt3
                ComboBox1.DisplayMember = "title"
                ComboBox1.ValueMember = "genderid"
                ComboBox1.Text = "Select Gender"
            Else
                ComboBox1.DataSource = Nothing
                ComboBox1.Text = "Select Gender"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Try
            Dim newid = TextBox3.Text
            Dim sqlsearch As String = "SELECT * FROM view1 WHERE studentsid='" & TextBox3.Text & "'"
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_labexam;User ID=sa;Password=1234"
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
                ComboBox2.Text = dt.Rows(0)(4).ToString()
                ComboBox3.Text = dt.Rows(0)(5).ToString()
            Else
                TextBox4.Clear()
                TextBox1.Clear()
                TextBox2.Clear()
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                ComboBox3.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try



    End Sub

    Private Sub update1_Click(sender As Object, e As EventArgs) Handles update1.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_labexam;User ID=sa;Password=1234"
            con1.Open()
            Dim firstname1, lastname1 As String
            Dim gender1, course1, section1, newid As Integer
            newid = TextBox4.Text
            firstname1 = TextBox1.Text
            lastname1 = TextBox2.Text
            gender1 = ComboBox1.SelectedValue
            course1 = ComboBox2.SelectedValue
            section1 = ComboBox3.SelectedValue
            Dim sqlupdate = "UPDATE view2 SET " & " firstname= '" & firstname1 & "'," &
                                                    "lastname = '" & lastname1 & "'," &
                                                     "genderid = '" & gender1 & "'," &
                                                     "courseid =" & course1 & "," &
                                                      "sectionid =" & section1 &
                                                     "WHERE studentsid=" & TextBox4.Text
            cmd = New SqlClient.SqlCommand(sqlupdate, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record updated")
            sponge()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            ComboBox3.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_labexam;User ID=sa;Password=1234"
            con1.Open()
            Dim newid As String
            newid = TextBox3.Text
            Dim sqldelete As String = "DELETE view2 WHERE studentsid =" & TextBox4.Text
            cmd = New SqlClient.SqlCommand(sqldelete, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record deleted")
            sponge()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            ComboBox3.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        ComboBox1.SelectedIndex = -1
    End Sub
End Class