Public Class Registration
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Dim reg As Employee = Employee
        reg.MdiParent = Me
        reg.Show()
    End Sub
End Class