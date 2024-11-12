Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=test"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

    End Sub
End Class
