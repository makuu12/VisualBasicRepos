Public Class MainForm
    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel3.Controls.Clear()
        Panel3.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(MDIForm)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(Form1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(LinkingTablesForm)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(CRUDForm)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchPanel(IJForm)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        switchPanel(STOREDForm)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        switchPanel(VIEWSForm)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        switchPanel(triggerForm)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        switchPanel(LabExamFormvb)
    End Sub


End Class
