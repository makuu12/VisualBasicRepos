<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AuthenticationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 679)
        Me.Panel1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuthenticationToolStripMenuItem, Me.RecordsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(959, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AuthenticationToolStripMenuItem
        '
        Me.AuthenticationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.AuthenticationToolStripMenuItem.Name = "AuthenticationToolStripMenuItem"
        Me.AuthenticationToolStripMenuItem.Size = New System.Drawing.Size(143, 29)
        Me.AuthenticationToolStripMenuItem.Text = "Authentication"
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LogInToolStripMenuItem.Text = "Log In"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Enabled = False
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Enabled = False
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(91, 29)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'MDIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 679)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MDIForm"
        Me.Text = "MDIForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AuthenticationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
End Class
