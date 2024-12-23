<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.staffOrManager = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1920, 1080)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(420, 61)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1500, 1019)
        Me.Panel5.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.staffOrManager)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(1, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 1024)
        Me.Panel3.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 20.0!)
        Me.Button5.Location = New System.Drawing.Point(0, 743)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(416, 80)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "SETTINGS"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(3, 858)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(413, 41)
        Me.Panel4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MARK ROEL ANDAYA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(106, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 52)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MANIGIR"
        '
        'staffOrManager
        '
        Me.staffOrManager.BackgroundImage = CType(resources.GetObject("staffOrManager.BackgroundImage"), System.Drawing.Image)
        Me.staffOrManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.staffOrManager.Location = New System.Drawing.Point(96, 48)
        Me.staffOrManager.Name = "staffOrManager"
        Me.staffOrManager.Size = New System.Drawing.Size(224, 244)
        Me.staffOrManager.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 20.0!)
        Me.Button4.Location = New System.Drawing.Point(0, 663)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(416, 80)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "SALES"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 20.0!)
        Me.Button3.Location = New System.Drawing.Point(0, 583)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(416, 80)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "INVENTORY"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 20.0!)
        Me.Button2.Location = New System.Drawing.Point(0, 503)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(416, 80)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "MENU"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(416, 80)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1920, 55)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(1876, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 40)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "x"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm"
        Me.Text = "mainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents staffOrManager As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel5 As Panel
End Class
