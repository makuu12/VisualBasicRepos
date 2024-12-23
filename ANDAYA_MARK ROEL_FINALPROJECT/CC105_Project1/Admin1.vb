Public Class Admin1
    Private Sub AdminBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sfit2a_andayaDataSet1)

    End Sub

    Private Sub Admin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sfit2a_andayaDataSet1.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Sfit2a_andayaDataSet1.admin)

    End Sub
End Class