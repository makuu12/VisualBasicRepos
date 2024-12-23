Public Class orderForm

    Private Sub orderForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        updaterow1()
        DataGridView1.DefaultCellStyle.Font = New Font("Yu Gothic UI", 18, FontStyle.Regular)
        DataGridView1.DefaultCellStyle.ForeColor = Color.White
    End Sub
    Private Sub updaterow1()
        Dim row As ArrayList = New ArrayList
        row.Add("1")
        row.Add("Americano(Hot)")
        row.Add("₱. 90")
        DataGridView1.Rows.Add(row.ToArray())
        row = New ArrayList
        row.Add("2")
        row.Add("Americano(Iced)")
        row.Add("₱. 110")
        DataGridView1.Rows.Add(row.ToArray())
        row = New ArrayList
        row.Add("3")
        row.Add("Latte(Hot)")
        row.Add("₱. 90")
        DataGridView1.Rows.Add(row.ToArray())
        row = New ArrayList
        row.Add("4")
        row.Add("Latte(Iced)")
        row.Add("₱. 110")
        DataGridView1.Rows.Add(row.ToArray())
        row = New ArrayList
        row.Add("5")
        row.Add("Caramel Macchiato(Hot)")
        row.Add("₱. 90")
        DataGridView1.Rows.Add(row.ToArray())
        row = New ArrayList
        row.Add("6")
        row.Add("Caramel Macchiato(Iced)")
        row.Add("₱. 110")
        DataGridView1.Rows.Add(row.ToArray())
        row = New ArrayList
        row.Add("7")
        row.Add("Caramel Macchiato(Iced Blended)")
        row.Add("₱. 130")
        DataGridView1.Rows.Add(row.ToArray())
        row = New ArrayList
        row.Add("Caramel Macchiato(Hot)")
        row.Add("3")
        row.Add("₱. 90")
        DataGridView2.Rows.Add(row.ToArray())
        row = New ArrayList
        row.Add("Latte(Iced)")
        row.Add("3")
        row.Add("₱. 110")
        DataGridView2.Rows.Add(row.ToArray())
    End Sub

End Class