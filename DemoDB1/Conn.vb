Imports System.Data.SqlClient

Module Conn
    Public con As SqlConnection




    Public Sub Conndb()

        Try
            con = New SqlConnection("Data Source=DESKTOP-G6V20H0\SQL_SERVER;Initial Catalog=Group2GroupAct;User ID=sa;Password=1234")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub




End Module
