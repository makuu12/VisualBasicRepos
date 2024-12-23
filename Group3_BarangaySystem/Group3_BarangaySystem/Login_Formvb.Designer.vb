<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Formvb
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Group3_BarangaySystem.My.Resources.Resources.loginBg
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 750)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(210, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 65)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(208, 529)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sign Up or Fogot Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Yu Gothic", 14.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.Red
        Me.TextBox2.Location = New System.Drawing.Point(132, 481)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(326, 45)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usermame:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic", 14.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(132, 389)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 45)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 37)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(569, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 38)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "X"
        '
        'Login_Formvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 750)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_Formvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Formvb"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
