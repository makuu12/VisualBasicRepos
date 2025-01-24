Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class triggerForm
    Dim con1 As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader



    Public Sub Binddata()
        Dim dt As DataTable
        Dim da1 As SqlClient.SqlDataAdapter
        Dim sql As String = "SELECT description, price, qty, total FROM tblCart"
        con1 = New SqlClient.SqlConnection
        con1.ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_trigger;User ID=sa;Password=1234"
        cmd = New SqlClient.SqlCommand(sql, con1)
        da1 = New SqlClient.SqlDataAdapter()
        da1.SelectCommand = cmd
        dt = New DataTable
        da1.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With con1
            .ConnectionString = "Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=sfit2a_trigger;User ID=sa;Password=1234"
        End With
        Binddata()
    End Sub
    Sub gene10()
        DataGridView1.Rows.Clear()
        con1.Open()
        cmd = New SqlCommand("SELECT * FROM tblCart where invoiceno LIKE @invoiceno1", con1)
        cmd.Parameters.AddWithValue("@invoiceno1", TextBox1.Text)
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)

        End While
        dr.Close()
        con1.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                con1.Open()
                cmd = New SqlCommand
                With cmd
                    .Connection = con1
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "insert1"
                    .Parameters.AddWithValue("@invoiceno1", TextBox1.Text)
                    .Parameters.AddWithValue("@description1", DataGridView1.Rows(i).Cells(0).Value.ToString)
                    .Parameters.AddWithValue("@price1", CDbl(DataGridView1.Rows(i).Cells(1).Value.ToString))
                    .Parameters.AddWithValue("@qty1", CType(DataGridView1.Rows(i).Cells(2).Value.ToString, Integer))
                    .ExecuteNonQuery()
                End With
                con1.Close()
            Next
            gene10()
            Binddata()
        Catch ex As Exception
            con1.Close()
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        gene10()
    End Sub


End Class
