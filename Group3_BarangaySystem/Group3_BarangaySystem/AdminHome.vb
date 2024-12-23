Public Class AdminHome


    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
    End Sub
    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles Button2.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
    End Sub
    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles Button3.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
    End Sub
    Private Sub Button4_Paint(sender As Object, e As PaintEventArgs) Handles Button4.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
    End Sub
    Private Sub Button5_Paint(sender As Object, e As PaintEventArgs) Handles Button5.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
    End Sub
    Private Sub Button6_Paint(sender As Object, e As PaintEventArgs) Handles Button6.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
    End Sub
    Private Sub Button7_Paint(sender As Object, e As PaintEventArgs) Handles Button7.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(Admin_IdForm)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(AdminRecords)
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.IndianRed
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.IndianRed
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.IndianRed
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.IndianRed
    End Sub
    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.BackColor = Color.IndianRed
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim functions As New functions
        functions.AdminForm_theme()
    End Sub
End Class



Public Class functions
    Sub AdminForm_theme()
        Admin_IdForm.Panel2.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox1.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox1.ForeColor = Color.White
        Admin_IdForm.TextBox2.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox2.ForeColor = Color.White
        Admin_IdForm.TextBox3.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox3.ForeColor = Color.White
        Admin_IdForm.TextBox4.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox4.ForeColor = Color.White
        Admin_IdForm.TextBox5.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox5.ForeColor = Color.White
        Admin_IdForm.TextBox6.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox6.ForeColor = Color.White
        Admin_IdForm.TextBox7.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox7.ForeColor = Color.White
        Admin_IdForm.TextBox8.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox8.ForeColor = Color.White
        Admin_IdForm.TextBox9.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox9.ForeColor = Color.White
        Admin_IdForm.TextBox10.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox10.ForeColor = Color.White
        Admin_IdForm.TextBox11.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox11.ForeColor = Color.White
        Admin_IdForm.TextBox12.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox12.ForeColor = Color.White
        Admin_IdForm.TextBox13.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox13.ForeColor = Color.White
        Admin_IdForm.TextBox14.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox14.ForeColor = Color.White
        Admin_IdForm.TextBox15.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.TextBox15.ForeColor = Color.White
        Admin_IdForm.TextBox16.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.ComboBox1.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.ComboBox1.ForeColor = Color.White
        Admin_IdForm.ComboBox2.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.ComboBox2.ForeColor = Color.White
        Admin_IdForm.ComboBox3.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.ComboBox3.ForeColor = Color.White
        Admin_IdForm.ComboBox4.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.ComboBox4.ForeColor = Color.White
        Admin_IdForm.ComboBox5.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.ComboBox5.ForeColor = Color.White
        Admin_IdForm.ComboBox6.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.ComboBox6.ForeColor = Color.White
        Admin_IdForm.ComboBox6.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.ComboBox6.ForeColor = Color.White
        Admin_IdForm.DateTimePicker1.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.DateTimePicker1.ForeColor = Color.White
        Admin_IdForm.DateTimePicker2.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.DateTimePicker2.ForeColor = Color.White
        Admin_IdForm.Label1.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label2.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label3.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label4.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label5.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label6.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label7.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label8.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label9.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label10.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label11.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label12.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label13.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label14.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label15.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label16.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label17.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label18.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label19.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label20.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label21.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label22.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label23.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label24.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label25.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label26.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label26.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Label1.ForeColor = Color.White
        Admin_IdForm.Label2.ForeColor = Color.White
        Admin_IdForm.Label3.ForeColor = Color.White
        Admin_IdForm.Label4.ForeColor = Color.White
        Admin_IdForm.Label5.ForeColor = Color.White
        Admin_IdForm.Label6.ForeColor = Color.White
        Admin_IdForm.Label7.ForeColor = Color.White
        Admin_IdForm.Label8.ForeColor = Color.White
        Admin_IdForm.Label9.ForeColor = Color.White
        Admin_IdForm.Label10.ForeColor = Color.White
        Admin_IdForm.Label11.ForeColor = Color.White
        Admin_IdForm.Label12.ForeColor = Color.White
        Admin_IdForm.Label13.ForeColor = Color.White
        Admin_IdForm.Label14.ForeColor = Color.White
        Admin_IdForm.Label15.ForeColor = Color.White
        Admin_IdForm.Label16.ForeColor = Color.White
        Admin_IdForm.Label17.ForeColor = Color.White
        Admin_IdForm.Label18.ForeColor = Color.White
        Admin_IdForm.Label19.ForeColor = Color.White
        Admin_IdForm.Label20.ForeColor = Color.White
        Admin_IdForm.Label21.ForeColor = Color.White
        Admin_IdForm.Label22.ForeColor = Color.White
        Admin_IdForm.Label23.ForeColor = Color.White
        Admin_IdForm.Label24.ForeColor = Color.White
        Admin_IdForm.Label25.ForeColor = Color.White
        Admin_IdForm.Label26.ForeColor = Color.White
        Admin_IdForm.Button3.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Button4.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Button5.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Button6.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Button7.BackColor = Color.FromArgb(64, 68, 75)
        Admin_IdForm.Button3.ForeColor = Color.White
        Admin_IdForm.Button4.ForeColor = Color.White
        Admin_IdForm.Button5.ForeColor = Color.White
        Admin_IdForm.Button6.ForeColor = Color.White
        Admin_IdForm.Button7.ForeColor = Color.White


    End Sub
End Class