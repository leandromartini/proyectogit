Imports System.Data.SqlClient
Public Class frmPersona
    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("La Plata")
        ComboBox1.Items.Add("Trenque Lauquen")
        ComboBox1.Items.Add("Bahia Blanca")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query As String

        query = "insert into persona ( nombre, apellido, fecNac, ciudad) values ( " & TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text & ", 1 )"

        ' conexion.CreateCommand(query)



    End Sub
End Class