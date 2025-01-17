<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class printform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sfit2a_andayaDataSet2 = New CC105_Project1.sfit2a_andayaDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AdminTableAdapter = New CC105_Project1.sfit2a_andayaDataSet2TableAdapters.adminTableAdapter()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sfit2a_andayaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
        Me.AdminBindingSource.DataSource = Me.Sfit2a_andayaDataSet2
        '
        'Sfit2a_andayaDataSet2
        '
        Me.Sfit2a_andayaDataSet2.DataSetName = "sfit2a_andayaDataSet2"
        Me.Sfit2a_andayaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.AdminBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CC105_Project1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(885, 554)
        Me.ReportViewer1.TabIndex = 0
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'printform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 566)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "printform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "printform"
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sfit2a_andayaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sfit2a_andayaDataSet2 As sfit2a_andayaDataSet2
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As sfit2a_andayaDataSet2TableAdapters.adminTableAdapter
End Class
