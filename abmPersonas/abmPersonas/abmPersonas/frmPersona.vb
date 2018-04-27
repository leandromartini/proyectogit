Imports System.Data.SqlClient
Imports System.Data



Public Class frmPersona

    Dim objDS As DataSet
    Dim objPwicomun As New pwiComun
    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objDS = objPwicomun.llenarCboLocalidades()
        cboLocalidad.DataSource = objDS.Tables(0)

        cboLocalidad.DisplayMember = "descrip"
        cboLocalidad.ValueMember = "cod_ent"
        cboLocalidad.Text = "Seleccione una localidad"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Try
            num = objPwicomun.ActualizarLista(txtNombre.Text, txtApellido.Text, txtFecNac.Text, cboLocalidad.SelectedValue)
            limpiar()
        Catch ex As Exception
            num = 0
        End Try
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