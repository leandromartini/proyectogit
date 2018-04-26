Imports System.Data.SqlClient
Imports System.Data



Public Class frmPersona

    Dim objDS As DataSet

    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objDS = pwiComun.llenarCboLocalidades()

        cboLocalidad.DataSource = objDS.Tables(0)
        cboLocalidad.DisplayMember = "descrip"
        cboLocalidad.ValueMember = "cod_ent"

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
        limpiar()
        Me.Close()
    End Sub
End Class