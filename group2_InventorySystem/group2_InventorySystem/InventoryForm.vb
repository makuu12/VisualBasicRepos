Public Class InventoryForm
    Private Sub orderForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        updaterow()
        DataGridView1.DefaultCellStyle.Font = New Font("Yu Gothic UI", 18, FontStyle.Regular)
        DataGridView1.DefaultCellStyle.ForeColor = Color.White
        DataGridView2.DefaultCellStyle.Font = New Font("Yu Gothic UI", 13, FontStyle.Regular)
        DataGridView2.DefaultCellStyle.ForeColor = Color.White
    End Sub
    Private Sub updaterow()
        Dim row As ArrayList = New ArrayList
        row.Add("Sugar")
        row.Add("7000grams")
        row.Add("₱. 1000")
        DataGridView1.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("Coffee Beans (large)")
        row.Add("3000grams")
        row.Add("₱. 1500")
        DataGridView1.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("Coffee Beans (small)")
        row.Add("3000grams")
        row.Add("₱. 1500")
        DataGridView1.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("1")
        row.Add("sugar")
        row.Add("add")
        row.Add("7000grams")
        row.Add("₱. 1000")
        row.Add("03/25/23 2:47pm")
        DataGridView2.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("1")
        row.Add("Coffee Beans (large)")
        row.Add("add")
        row.Add("3000grams")
        row.Add("₱. 1500")
        row.Add("03/25/23 2:48pm")
        DataGridView2.Rows.Add(row.ToArray())

        row = New ArrayList
        row.Add("1")
        row.Add("Coffee Beans (large)")
        row.Add("add")
        row.Add("3000grams")
        row.Add("₱. 1500")
        row.Add("03/25/23 2:48pm")
        DataGridView2.Rows.Add(row.ToArray())



    End Sub

End Class