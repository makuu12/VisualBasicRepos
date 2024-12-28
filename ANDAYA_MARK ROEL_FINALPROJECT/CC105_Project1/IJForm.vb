Imports System.Collections.Specialized.BitVector32

Public Class IJForm
    Dim con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim da1 As SqlClient.SqlDataAdapter
    Dim sqladd As String
    Dim dt As DataTable
    Dim id As Int64
    Dim firstname1, lastname1, course1, section1 As String

    Private Sub LinkingTablesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New SqlClient.SqlConnection
        con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_relational;User ID=sa;Password=1234;Pooling=False"
        'Dim viewrecords = "SELECT id, firstname, lastname, course_desc, sectionname FROM viewrec" VIEW
        Dim viewrecords = "Select DISTINCT id, firstname, lastname, courses_table.course_desc, section_table.sectionname
FROM students_table INNER JOIN courses_table 
ON students_table.courseid = courses_table.courseid 
INNER JOIN section_table
ON students_table.sectionid = section_table.sectionid"
        cmd = New SqlClient.SqlCommand(viewrecords, con1)
        cmd.CommandType = CommandType.Text
        da1 = New SqlClient.SqlDataAdapter()
        da1.SelectCommand = cmd
        dt = New DataTable
        da1.Fill(dt)
        DataGridView1.DataSource = dt
        loadsections()
        loadcourses()
    End Sub



    Public Sub loadsections()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_relational;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            Dim cmd1 As New SqlClient.SqlCommand("Select DISTINCT students_table.courseid, courses_table.course_desc FROM students_table INNER JOIN courses_table ON students_table.courseid = courses_table.courseid", con1)
            cmd1.CommandType = CommandType.Text
            Dim da2 As New SqlClient.SqlDataAdapter
            da2.SelectCommand = cmd1
            Dim dt1 As New DataTable
            If da2.Fill(dt1) Then
                ComboBox1.DataSource = dt1
                ComboBox1.DisplayMember = "course_desc"
                ComboBox1.ValueMember = "courseid"
                ComboBox1.Text = "Select Course"
            Else
                ComboBox1.DataSource = Nothing
                ComboBox1.Text = "Select Course"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub
    Public Sub loadcourses()
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_relational;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            Dim cmd1 As New SqlClient.SqlCommand("SELECT DISTINCT students_table.sectionid, section_table.sectionname FROM students_table INNER JOIN section_table ON students_table.sectionid = section_table.sectionid", con1)
            cmd1.CommandType = CommandType.Text
            Dim da2 As New SqlClient.SqlDataAdapter
            da2.SelectCommand = cmd1
            Dim dt1 As New DataTable
            If da2.Fill(dt1) Then
                ComboBox2.DataSource = dt1
                ComboBox2.DisplayMember = "sectionname"
                ComboBox2.ValueMember = "sectionid"
                ComboBox2.Text = "Select Section"
            Else
                ComboBox2.DataSource = Nothing
                ComboBox2.Text = "Select Section"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub



    Public Sub sponge()
        con1 = New SqlClient.SqlConnection
        con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_relational;User ID=sa;Password=1234;Pooling=False"
        'Dim viewrecords = "SELECT id, firstname, lastname, course_desc, sectionname FROM viewrec" VIEW
        Dim viewrecords = "
Select DISTINCT id, firstname, lastname, courses_table.course_desc, section_table.sectionname
FROM students_table 
INNER JOIN courses_table 
ON students_table.courseid = courses_table.courseid 
INNER JOIN section_table
ON students_table.sectionid = section_table.sectionid"
        cmd = New SqlClient.SqlCommand(viewrecords, con1)
        cmd.CommandType = CommandType.Text
        da1 = New SqlClient.SqlDataAdapter()
        da1.SelectCommand = cmd
        dt = New DataTable
        da1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_relational;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            firstname1 = TextBox1.Text.Trim()
            lastname1 = TextBox2.Text.Trim()
            course1 = ComboBox1.SelectedValue
            section1 = ComboBox2.SelectedValue
            sqladd = "insert into students_table (firstname, lastname, courseid, sectionid) VALUES ('" & firstname1 & "','" & lastname1 & "','" & course1 & "', '" & section1 & "')"
            cmd = New SqlClient.SqlCommand(sqladd, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successful inserted")
            sponge()
            TextBox1.Text = ""
            TextBox2.Text = ""
            loadsections()
            loadcourses()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_relational;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            firstname1 = TextBox1.Text
            lastname1 = TextBox2.Text
            course1 = ComboBox1.SelectedValue
            section1 = ComboBox2.SelectedValue
            id = TextBox4.Text
            Dim updaterow = "UPDATE updaterec SET firstname = '" & firstname1 & "', lastname = '" & lastname1 & "', courseid = '" & course1 & "', sectionid = '" & section1 & "'WHERE id = " & id & ""
            cmd = New SqlClient.SqlCommand(updaterow, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record updated")
            sponge()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            loadsections()
            loadcourses()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_relational;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            Dim sqldelete As String = "SELECT * FROM Viewrec DELETE FROM students_table WHERE id = " & TextBox4.Text
            cmd = New SqlClient.SqlCommand(sqldelete, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record deleted")
            sponge()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            loadsections()
            loadcourses()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim sqlsearch As String = "SELECT id, firstname, lastname, course_desc, sectionname FROM viewrec WHERE id='" & TextBox3.Text & "'"
            con1 = New SqlClient.SqlConnection
            con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_relational;User ID=sa;Password=1234;Pooling=False"
            con1.Open()
            cmd = New SqlClient.SqlCommand(sqlsearch, con1)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
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
            Else
                TextBox4.Clear()
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class

