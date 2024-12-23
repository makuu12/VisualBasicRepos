Public Class SalesForm
    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Chart1.Series("weekly").Points.AddXY("Mon", 100)
        Me.Chart1.Series("weekly").Points.AddXY("Tue", 150)
        Me.Chart1.Series("weekly").Points.AddXY("Wed", 250)
        Me.Chart1.Series("weekly").Points.AddXY("Thu", 0)
        Me.Chart1.Series("weekly").Points.AddXY("Fri", 0)
        Me.Chart1.Series("weekly").Points.AddXY("Sat", 150)
        Me.Chart1.Series("weekly").Points.AddXY("Sun", 350)

        updaterow()
        DataGridView1.DefaultCellStyle.Font = New Font("Yu Gothic UI", 12, FontStyle.Regular)
        DataGridView1.DefaultCellStyle.ForeColor = Color.White
        DataGridView1.DefaultCellStyle.Font = New Font("Yu Gothic UI", 18, FontStyle.Regular)
        DataGridView1.DefaultCellStyle.ForeColor = Color.White

    End Sub

    Private Sub updaterow()
        Dim row As ArrayList = New ArrayList

        row = New ArrayList
        row.Add("Americano(Iced)")
        row.Add("700")
        row.Add("70%")
        DataGridView1.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("Americano(Hot)")
        row.Add("300")
        row.Add("30%")
        DataGridView1.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("1")
        row.Add("Americano(Iced)")
        row.Add("2")
        row.Add("₱. 110")
        row.Add("₱. 220")
        row.Add("03/25/23 2:48pm")
        DataGridView2.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("1")
        row.Add("Americano(Iced)")
        row.Add("2")
        row.Add("₱. 110")
        row.Add("₱. 220")
        row.Add("03/25/23 2:43pm")
        DataGridView2.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("1")
        row.Add("Americano(Iced)")
        row.Add("2")
        row.Add("₱. 110")
        row.Add("₱. 220")
        row.Add("03/25/23 2:30pm")
        DataGridView2.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("1")
        row.Add("Americano(Iced)")
        row.Add("2")
        row.Add("₱. 110")
        row.Add("₱. 220")
        row.Add("03/25/23 1:40pm")
        DataGridView2.Rows.Add(row.ToArray())
    End Sub

End Class