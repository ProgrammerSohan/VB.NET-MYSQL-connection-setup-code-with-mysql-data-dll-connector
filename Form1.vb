Imports MySql.Data.MySqlClient

Public Class Form1
    ' Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MySqlConnection As New MySqlConnection("host=127.0.0.1; user=root; password=;database=vbdotnet01")

        Try
            MySqlConnection.Open()
            MessageBox.Show("Successfully connected to the database")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
