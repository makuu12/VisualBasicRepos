Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Policy
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Admin_IdForm

    Private Sub TextBox1_Paint(sender As Object, e As PaintEventArgs) Handles TextBox1.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Yellow, ButtonBorderStyle.Solid)
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        If TextBox2.Text = "" Then
            MessageBox.Show("The First Name Field is Empty", "Could not Insert")
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("The Middle Name Field is Empty", "NCould not Insert")
        End If
        If TextBox4.Text = "" Then
            MessageBox.Show("The Last Name Field is Empty", "Could not Insert")
        End If
        If TextBox5.Text = "" Then
            MessageBox.Show("The  House Number Field is Empty", "Could not Insert")
        End If
        If TextBox6.Text = "" Then
            MessageBox.Show("The  Street Field is Empty", "Could not Insert")
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("The Sitio Field is Empty", "Could not Insert")
        End If
        If ComboBox2.Text IsNot "1" Or ComboBox2.Text IsNot "2" Or ComboBox2.Text IsNot "3" Or ComboBox2.Text IsNot "4" Or ComboBox2.Text IsNot "5" Or ComboBox2.Text IsNot "6" Or ComboBox2.Text IsNot "7" Then
            MessageBox.Show("The Sitio Field must be inside the choices", "Could not Insert")
        End If
        If TextBox7.Text = "" Then
            MessageBox.Show("The  Contact Number Field is Empty", "Could not Insert")
        End If
        'lagyan na kapag yung number may string ay mag-error
        If TextBox7.Text.Length > 11 Or TextBox9.Text.Length < 11 Then
            MessageBox.Show("The  Contact Number Must be 11 Digits", "Could not Insert")
        End If
        'sa textbox 8 kapag may laman, dapat may saktong characters lang base sa Precint id number ay mag-error
        If TextBox9.Text.Length > 9 Or TextBox8.Text.Length < 9 Then
            MessageBox.Show("The  TIN Number Must be 9 Digits", "Could not Insert")
        End If
        If DateTimePicker1.Text = "" Then
            MessageBox.Show("The  Birth Date Field is Empty", "Could not Insert")
        End If
        If TextBox10.Text = "" Then
            MessageBox.Show("The First Name Field is Empty in Emergency Contact", "Could not Insert")
            Stop
        End If
        If TextBox11.Text = "" Then
            MessageBox.Show("The Middle Name Field is Empty in Emergency Contact", "Could not Insert")
        End If
        If TextBox12.Text = "" Then
            MessageBox.Show("The Last Name Field is Empty in Emergency Contact", "Could not Insert")
        End If
        If TextBox13.Text = "" Then
            MessageBox.Show("The  House Number Field is Empty in Emergency Contact", "Could not Insert")
        End If
        If TextBox14.Text = "" Then
            MessageBox.Show("The  Street Field is Empty in Emergency Contact", "Could not Insert")
        End If
        If TextBox15.Text = "" Then
            MessageBox.Show("The  Contact Number Field is Empty in Emergency Contact", "Could not Insert")
        End If
        If ComboBox5.Text = "" Then
            MessageBox.Show("The Sitio Field is Empty in Emergency Contact", "Could not Insert")
        End If
        If ComboBox5.Text IsNot "1" Or ComboBox5.Text IsNot "2" Or ComboBox5.Text IsNot "3" Or ComboBox5.Text IsNot "4" Or ComboBox5.Text IsNot "5" Or ComboBox5.Text IsNot "6" Or ComboBox5.Text IsNot "7" Then
            MessageBox.Show("The Sitio Field must be inside the choices", "Could not Insert")
        End If


        'ILALAGAY SA TRY CATCH PARA SA PAG-INSERT SA DB
        'ILALAGAY SA TRY CATCH PARA SA PAG-INSERT SA DB
        'ILALAGAY SA TRY CATCH PARA SA PAG-INSERT SA DB

        'Dim fn, mn, ln, extn, blk, str, sitio, bdate, bplace, tin, btype, prct, efn, emn, eln, eextn, estr, eblk, ec, esitio, dr, dm As String
        'fn = TextBox2.Text
        'mn = TextBox3.Text
        'ln = TextBox4.Text
        'extn = ComboBox1.SelectedItem
        'blk = TextBox5.Text
        'str = TextBox6.Text
        'sitio = ComboBox2.SelectedItem
        'bdate = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        'prct = TextBox8.Text
        'tin = TextBox9.Text
        'btype = ComboBox3.SelectedItem
        'efn = TextBox10.Text
        'emn = TextBox11.Text
        'eln = TextBox12.Text
        'eextn = ComboBox4.SelectedItem
        'eblk = TextBox13.Text
        'estr = TextBox14.Text
        'esitio = ComboBox5.SelectedItem
        'ec = TextBox15.Text
        'dr = Date.Now.ToString("yyyy/MM/dd HH:mm")
        'dm = Date.Now.ToString("yyyy/MM/dd HH:mm")

        'TINANGGAL KO LANG JAN YUNG SEX AT CS DAHIL BARANGAY ID 'TO
        'MessageBox.Show("Successfully inserted")
        'sqladd = "INSERT into residents (firstname, middlename, lastname, extensionname, block, street, sitio, 
        '                        birthdate, birthplace, tin, bloodtype, precinct, 
        '                        ecfirstname, ecmiddlename, eclastname, ecextensionname, ecblock, ecstreet, ecsitio, eccontact, daterecorded, datemodified) VALUES 
        '                        ('" & fn & "','" & mn & "','" & ln & "','" & extn & "','" & blk & "','" & Str() & "','" & sitio & "','" & bdate & "','" & bplace & "',
        '                        '" & tin & "','" & btype & "','" & prct & "','" & efn & "','" & emn & "','" & eln & "','" & eextn & "',
        '                        '" & eblk & "','" & estr & "','" & esitio & "','" & ec & "','" & dr & "','" & dm & "')"


        'TextBox1.Clear()
        'TextBox2.Clear()
        'TextBox3.Clear()
        'TextBox4.Clear()
        'TextBox5.Clear()
        'TextBox6.Clear()
        'TextBox7.Clear()
        'TextBox8.Clear()
        'TextBox9.Clear()
        'TextBox10.Clear()
        'TextBox11.Clear()
        'TextBox12.Clear()
        'TextBox13.Clear()
        'TextBox14.Clear()
        'TextBox15.Clear()
        'ComboBox1.SelectedIndex = 1  'WAG 'YAN IDELETE DAHIL PARA ITO SA MAG-INPUT NA WALA NAMAN SA COMBO BOX
        'ComboBox2.SelectedIndex = 1  'WAG 'YAN IDELETE DAHIL PARA ITO SA MAG-INPUT NA WALA NAMAN SA COMBO BOX
        'ComboBox3.SelectedIndex = 1  'WAG 'YAN IDELETE DAHIL PARA ITO SA MAG-INPUT NA WALA NAMAN SA COMBO BOX
        'ComboBox4.SelectedIndex = 1  'WAG 'YAN IDELETE DAHIL PARA ITO SA MAG-INPUT NA WALA NAMAN SA COMBO BOX
        'ComboBox5.SelectedIndex = 1  'WAG 'YAN IDELETE DAHIL PARA ITO SA MAG-INPUT NA WALA NAMAN SA COMBO BOX
        'ComboBox1.SelectedIndex = -1
        'ComboBox2.SelectedIndex = -1
        'ComboBox3.SelectedIndex = -1
        'ComboBox4.SelectedIndex = -1
        'ComboBox5.SelectedIndex = -1

        'ILALAGAY SA TRY CATCH PARA SA PAG-INSERT SA DB
        'ILALAGAY SA TRY CATCH PARA SA PAG-INSERT SA DB
        'ILALAGAY SA TRY CATCH PARA SA PAG-INSERT SA DB



    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Do you want to update?", "Title", MessageBoxButtons.YesNo)

        If (result = DialogResult.OK) Then
            Update()
        End If
    End Sub
End Class

Public Class myTextbox ' di to nagana pero balak ko sana lagyan ng red na border sa textbox
    Inherits System.Windows.Forms.TextBox

    Private m_BorderColor As System.Drawing.Color = System.Drawing.Color.Red

    Public Function GetBorderColor() As System.Drawing.Color
        Return Me.m_BorderColor
    End Function
    Public Function SetBorderColor(ByVal clrBorder As System.Drawing.Color) As Boolean
        Me.m_BorderColor = clrBorder
        Me.Invalidate()
    End Function

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim penBorder As New Pen(Me.GetBorderColor, 1)
        Dim rectBorder As New Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(penBorder, rectBorder)
    End Sub

End Class