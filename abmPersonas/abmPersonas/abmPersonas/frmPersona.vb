Imports System.Data.SqlClient
Public Class frmPersona
    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLocalidad.Items.Add("La Plata")
        cboLocalidad.Items.Add("Trenque Lauquen")
        cboLocalidad.Items.Add("Bahia Blanca")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conexion.CreateCommand(txtNombre.Text, txtApellido.Text, txtFecNac.Text, 1)
        limpiar()
    End Sub
    Public Sub limpiar()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtFecNac.Text = ""
        cboLocalidad.Text = ""
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class