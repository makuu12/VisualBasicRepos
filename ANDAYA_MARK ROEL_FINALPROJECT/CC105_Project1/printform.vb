Public Class printform
    Private Sub printform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sfit2a_andayaDataSet2.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Sfit2a_andayaDataSet2.admin)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class