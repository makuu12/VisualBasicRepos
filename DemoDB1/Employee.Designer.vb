<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.empno = New System.Windows.Forms.TextBox()
        Me.empfirstname = New System.Windows.Forms.TextBox()
        Me.emplastname = New System.Windows.Forms.TextBox()
        Me.empaddress = New System.Windows.Forms.TextBox()
        Me.contactno = New System.Windows.Forms.TextBox()
        Me.position = New System.Windows.Forms.TextBox()
        Me.salary = New System.Windows.Forms.TextBox()
        Me.empphoto = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.empsex = New System.Windows.Forms.ComboBox()
        Me.dateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.dateofhire = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.department = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmpnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofbirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofhireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CompayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group2groupActDataSet = New DemoDB1.Group2groupActDataSet()
        Me.CompayrollTableAdapter = New DemoDB1.Group2groupActDataSetTableAdapters.compayrollTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group2groupActDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sex:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(662, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contact Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(704, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 31)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date of Birth:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(757, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 31)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Position:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(710, 342)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 31)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Date of Hire:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(715, 409)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 31)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Department:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(1384, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 31)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Photo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(785, 462)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 31)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Salary:"
        '
        'empno
        '
        Me.empno.BackColor = System.Drawing.Color.White
        Me.empno.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empno.Location = New System.Drawing.Point(195, 155)
        Me.empno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.empno.Name = "empno"
        Me.empno.Size = New System.Drawing.Size(457, 38)
        Me.empno.TabIndex = 12
        '
        'empfirstname
        '
        Me.empfirstname.BackColor = System.Drawing.Color.White
        Me.empfirstname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empfirstname.Location = New System.Drawing.Point(195, 222)
        Me.empfirstname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.empfirstname.Name = "empfirstname"
        Me.empfirstname.Size = New System.Drawing.Size(457, 38)
        Me.empfirstname.TabIndex = 13
        '
        'emplastname
        '
        Me.emplastname.BackColor = System.Drawing.Color.White
        Me.emplastname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emplastname.Location = New System.Drawing.Point(195, 282)
        Me.emplastname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.emplastname.Name = "emplastname"
        Me.emplastname.Size = New System.Drawing.Size(457, 38)
        Me.emplastname.TabIndex = 14
        '
        'empaddress
        '
        Me.empaddress.BackColor = System.Drawing.Color.White
        Me.empaddress.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empaddress.Location = New System.Drawing.Point(195, 342)
        Me.empaddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.empaddress.Name = "empaddress"
        Me.empaddress.Size = New System.Drawing.Size(457, 38)
        Me.empaddress.TabIndex = 15
        '
        'contactno
        '
        Me.contactno.BackColor = System.Drawing.Color.White
        Me.contactno.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactno.Location = New System.Drawing.Point(879, 158)
        Me.contactno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.contactno.Name = "contactno"
        Me.contactno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.contactno.Size = New System.Drawing.Size(457, 38)
        Me.contactno.TabIndex = 17
        '
        'position
        '
        Me.position.BackColor = System.Drawing.Color.White
        Me.position.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.position.Location = New System.Drawing.Point(879, 282)
        Me.position.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(457, 38)
        Me.position.TabIndex = 19
        '
        'salary
        '
        Me.salary.BackColor = System.Drawing.Color.White
        Me.salary.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.salary.Location = New System.Drawing.Point(879, 462)
        Me.salary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.salary.Name = "salary"
        Me.salary.Size = New System.Drawing.Size(457, 38)
        Me.salary.TabIndex = 22
        '
        'empphoto
        '
        Me.empphoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.empphoto.InitialImage = CType(resources.GetObject("empphoto.InitialImage"), System.Drawing.Image)
        Me.empphoto.Location = New System.Drawing.Point(1390, 165)
        Me.empphoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.empphoto.Name = "empphoto"
        Me.empphoto.Size = New System.Drawing.Size(298, 288)
        Me.empphoto.TabIndex = 23
        Me.empphoto.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(1380, 507)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 91)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(1380, 705)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(322, 42)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(117, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(368, 38)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Register New Employee"
        '
        'empsex
        '
        Me.empsex.BackColor = System.Drawing.Color.White
        Me.empsex.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empsex.FormattingEnabled = True
        Me.empsex.Items.AddRange(New Object() {"Female", "Male"})
        Me.empsex.Location = New System.Drawing.Point(195, 405)
        Me.empsex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.empsex.Name = "empsex"
        Me.empsex.Size = New System.Drawing.Size(457, 39)
        Me.empsex.TabIndex = 27
        '
        'dateofbirth
        '
        Me.dateofbirth.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateofbirth.Location = New System.Drawing.Point(879, 215)
        Me.dateofbirth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateofbirth.Name = "dateofbirth"
        Me.dateofbirth.Size = New System.Drawing.Size(457, 38)
        Me.dateofbirth.TabIndex = 28
        '
        'dateofhire
        '
        Me.dateofhire.CalendarMonthBackground = System.Drawing.Color.White
        Me.dateofhire.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateofhire.Location = New System.Drawing.Point(879, 342)
        Me.dateofhire.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateofhire.Name = "dateofhire"
        Me.dateofhire.Size = New System.Drawing.Size(457, 38)
        Me.dateofhire.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(1390, 461)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(298, 38)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Browse Image"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'department
        '
        Me.department.BackColor = System.Drawing.Color.White
        Me.department.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.department.FormattingEnabled = True
        Me.department.Items.AddRange(New Object() {"Creative", "IT", "Marketing", "System Analyst"})
        Me.department.Location = New System.Drawing.Point(879, 405)
        Me.department.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(457, 39)
        Me.department.TabIndex = 31
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpnoDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.ContactnoDataGridViewTextBoxColumn, Me.DateofbirthDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.DateofhireDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.PhotoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.CompayrollBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 574)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1312, 491)
        Me.DataGridView1.TabIndex = 32
        '
        'EmpnoDataGridViewTextBoxColumn
        '
        Me.EmpnoDataGridViewTextBoxColumn.DataPropertyName = "empno"
        Me.EmpnoDataGridViewTextBoxColumn.HeaderText = "empno"
        Me.EmpnoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmpnoDataGridViewTextBoxColumn.Name = "EmpnoDataGridViewTextBoxColumn"
        Me.EmpnoDataGridViewTextBoxColumn.Width = 150
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 150
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.Width = 150
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 150
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.Width = 150
        '
        'ContactnoDataGridViewTextBoxColumn
        '
        Me.ContactnoDataGridViewTextBoxColumn.DataPropertyName = "contactno"
        Me.ContactnoDataGridViewTextBoxColumn.HeaderText = "contactno"
        Me.ContactnoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ContactnoDataGridViewTextBoxColumn.Name = "ContactnoDataGridViewTextBoxColumn"
        Me.ContactnoDataGridViewTextBoxColumn.Width = 150
        '
        'DateofbirthDataGridViewTextBoxColumn
        '
        Me.DateofbirthDataGridViewTextBoxColumn.DataPropertyName = "dateofbirth"
        Me.DateofbirthDataGridViewTextBoxColumn.HeaderText = "dateofbirth"
        Me.DateofbirthDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DateofbirthDataGridViewTextBoxColumn.Name = "DateofbirthDataGridViewTextBoxColumn"
        Me.DateofbirthDataGridViewTextBoxColumn.Width = 150
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "position"
        Me.PositionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.Width = 150
        '
        'DateofhireDataGridViewTextBoxColumn
        '
        Me.DateofhireDataGridViewTextBoxColumn.DataPropertyName = "dateofhire"
        Me.DateofhireDataGridViewTextBoxColumn.HeaderText = "dateofhire"
        Me.DateofhireDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DateofhireDataGridViewTextBoxColumn.Name = "DateofhireDataGridViewTextBoxColumn"
        Me.DateofhireDataGridViewTextBoxColumn.Width = 150
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "department"
        Me.DepartmentDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.Width = 150
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "salary"
        Me.SalaryDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.Width = 150
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "photo"
        Me.PhotoDataGridViewImageColumn.HeaderText = "photo"
        Me.PhotoDataGridViewImageColumn.MinimumWidth = 8
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        Me.PhotoDataGridViewImageColumn.Width = 150
        '
        'CompayrollBindingSource
        '
        Me.CompayrollBindingSource.DataMember = "compayroll"
        Me.CompayrollBindingSource.DataSource = Me.Group2groupActDataSet
        '
        'Group2groupActDataSet
        '
        Me.Group2groupActDataSet.DataSetName = "Group2groupActDataSet"
        Me.Group2groupActDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompayrollTableAdapter
        '
        Me.CompayrollTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Button5.Location = New System.Drawing.Point(1549, 606)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 91)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Button6.Location = New System.Drawing.Point(1549, 507)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 91)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "Update"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Button7.Location = New System.Drawing.Point(1380, 606)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(163, 91)
        Me.Button7.TabIndex = 37
        Me.Button7.Text = "Clear"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1766, 1050)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.department)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dateofhire)
        Me.Controls.Add(Me.dateofbirth)
        Me.Controls.Add(Me.empsex)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.empphoto)
        Me.Controls.Add(Me.salary)
        Me.Controls.Add(Me.position)
        Me.Controls.Add(Me.contactno)
        Me.Controls.Add(Me.empaddress)
        Me.Controls.Add(Me.emplastname)
        Me.Controls.Add(Me.empfirstname)
        Me.Controls.Add(Me.empno)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group2groupActDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents empno As TextBox
    Friend WithEvents empfirstname As TextBox
    Friend WithEvents emplastname As TextBox
    Friend WithEvents empaddress As TextBox
    Friend WithEvents contactno As TextBox
    Friend WithEvents position As TextBox
    Friend WithEvents salary As TextBox
    Friend WithEvents empphoto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents empsex As ComboBox
    Friend WithEvents dateofbirth As DateTimePicker
    Friend WithEvents dateofhire As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents department As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Group2groupActDataSet As Group2groupActDataSet
    Friend WithEvents CompayrollBindingSource As BindingSource
    Friend WithEvents CompayrollTableAdapter As Group2groupActDataSetTableAdapters.compayrollTableAdapter
    Friend WithEvents EmpnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofbirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofhireDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
