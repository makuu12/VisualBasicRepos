Public Class Form2



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FirstName, LastName, Add, Gender, Level, ExSalary As String

        FirstName = TextBox1.Text
        LastName = TextBox2.Text
        Add = TextBox3.Text

        Gender = ""
        If RadioButton1.Checked Then
            Gender = "Male"
        ElseIf radioButton2.Checked = True Then
            Gender = "Female"
        ElseIf radioButton3.Checked = True Then
            Gender = "Other"
        End If
        Dim Skill1, Skill2, Skill3 As String
        Skill1 = ""
        If CheckBox1.Checked Then
            Skill1 = "Web"
        End If
        Skill2 = ""
        If CheckBox2.Checked Then
            Skill2 = "Desktop"
        End If
        Skill3 = ""
        If CheckBox3.Checked Then
            Skill3 = "Mobile"
        End If

        Level = ComboBox1.SelectedItem

        ExSalary = ListBox1.SelectedItem


        MsgBox("Name: " & FirstName & " " & LastName & Environment.NewLine & "Address: " & Add & Environment.NewLine &
               "Gender: " & Gender & Environment.NewLine & "Skills: " & Skill1 & " " & Skill2 &
               " " & Skill3 & Environment.NewLine & "Level: " & Level & Environment.NewLine &
               "Salary: " & ExSalary)

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        ComboBox1.SelectedItem = False
        ListBox1.SelectedItem = False

    End Sub
End Class