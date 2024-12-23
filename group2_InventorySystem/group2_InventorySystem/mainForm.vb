
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class mainForm


    Sub switchPanel(ByVal panel As Form)
        Panel5.Controls.Clear()
        Anchor = AnchorStyles.Right Or AnchorStyles.Bottom Or AnchorStyles.Top Or AnchorStyles.Left
        '1020, 963
        '215, 186, 152
        'main panel size - 1020, 963
        'mainform size - 1440, 1024
        panel.TopLevel = False
        Panel5.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label4.Left = -175 Then
            Label4.Left = 300
        Else
            Label4.Left -= 5
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub


    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel5.BackColor = Color.FromArgb(215, 186, 152)
        switchPanel(HomeForm)
        Button1.BackColor = Color.FromArgb(96, 85, 67)
        Button2.BackColor = Color.FromArgb(179, 156, 127)
        Button3.BackColor = Color.FromArgb(179, 156, 127)
        Button4.BackColor = Color.FromArgb(179, 156, 127)
        Button5.BackColor = Color.FromArgb(179, 156, 127)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(HomeForm)
        Button1.BackColor = Color.FromArgb(96, 85, 67)
        Button2.BackColor = Color.FromArgb(179, 156, 127)
        Button3.BackColor = Color.FromArgb(179, 156, 127)
        Button4.BackColor = Color.FromArgb(179, 156, 127)
        Button5.BackColor = Color.FromArgb(179, 156, 127)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(orderForm)
        Button1.BackColor = Color.FromArgb(179, 156, 127)
        Button2.BackColor = Color.FromArgb(96, 85, 67)
        Button3.BackColor = Color.FromArgb(179, 156, 127)
        Button4.BackColor = Color.FromArgb(179, 156, 127)
        Button5.BackColor = Color.FromArgb(179, 156, 127)


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel5.BackColor = Color.FromArgb(215, 186, 152)
        switchPanel(InventoryForm)
        Button1.BackColor = Color.FromArgb(179, 156, 127)
        Button2.BackColor = Color.FromArgb(179, 156, 127)
        Button3.BackColor = Color.FromArgb(96, 85, 67)
        Button4.BackColor = Color.FromArgb(179, 156, 127)
        Button5.BackColor = Color.FromArgb(179, 156, 127)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel5.BackColor = Color.FromArgb(215, 186, 152)
        switchPanel(SalesForm)
        Button1.BackColor = Color.FromArgb(179, 156, 127)
        Button2.BackColor = Color.FromArgb(179, 156, 127)
        Button3.BackColor = Color.FromArgb(179, 156, 127)
        Button4.BackColor = Color.FromArgb(96, 85, 67)
        Button5.BackColor = Color.FromArgb(179, 156, 127)
    End Sub
End Class