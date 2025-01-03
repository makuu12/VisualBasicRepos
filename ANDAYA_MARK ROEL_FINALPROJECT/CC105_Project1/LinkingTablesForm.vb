Public Class LinkingTablesForm
    Dim con1 As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim da1 As SqlClient.SqlDataAdapter
    Dim sqladd As String
    Dim dt As DataTable

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

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class