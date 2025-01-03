Imports Microsoft.VisualBasic.ApplicationServices

Public Class MDIForm
    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.LogOutToolStripMenuItem.Enabled = False
        Me.RecordsToolStripMenuItem.Enabled = False
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click
        Admin1.ShowDialog()
    End Sub
End Class