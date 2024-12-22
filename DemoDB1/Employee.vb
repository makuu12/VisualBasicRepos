﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Employee
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Private Sub Binding()

        ConnDb()

    End Sub
    Private Sub save()
        Try
            Dim ms As New MemoryStream
            empphoto.Image.Save(ms, empphoto.Image.RawFormat)
            Dim arrImage() As Byte = ms.GetBuffer
            ms.Close()
            ConnDb()

            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "insert into compayroll(empno,firstname,lastname,address,sex,contactno,dateofbirth,position,dateofhire,department,salary,photo) values (@empno,@firstname,@lastname,@address,@sex,@contactno,@dateofbirth,@position,@dateofhire,@department,@salary,@photo)"
            cmd.Parameters.Add("@empno", empno.Text)
            cmd.Parameters.Add("@firstname", empfirstname.Text)
            cmd.Parameters.Add("@lastname", emplastname.Text)
            cmd.Parameters.Add("@address", empaddress.Text)
            cmd.Parameters.Add("@sex", empsex.Text)
            cmd.Parameters.Add("@contactno", contactno.Text)
            cmd.Parameters.Add("@dateofbirth", dateofbirth.Value)
            cmd.Parameters.Add("@position", position.Text)
            cmd.Parameters.Add("@dateofhire", dateofhire.Value)
            cmd.Parameters.Add("@department", department.Text)
            cmd.Parameters.Add("@salary", salary.Text)
            cmd.Parameters.Add("@photo", arrImage)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Added")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub GetEmpNo()
        Try
            Dim Sql As String
            Dim EmpId As String
            Sql = "select empno from compayroll order by empno Desc"
            ConnDb()
            con.Open()
            cmd = New SqlCommand(Sql, con)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If (dr.Read) Then
                Dim id As Integer
                id = (dr(0 + 1))
                EmpId = id.ToString("00000")
            ElseIf IsDBNull(dr) Then
                EmpId = ("00001")
            Else
                EmpId = ("00001")

            End If
            empno.Text = EmpId
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .Filter = "All Files |*.*|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 2
        End With
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With empphoto
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
        End If

    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class