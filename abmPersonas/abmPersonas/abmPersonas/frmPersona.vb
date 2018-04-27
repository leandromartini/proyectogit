Imports System.Data.SqlClient
Imports System.Data



Public Class frmPersona

    Dim objDS As DataSet
    Dim objPwicomun As New pwiComun
    Sub abrirFormulario()
        Try
            objDS = objPwicomun.llenarCboLocalidades()
            cboLocalidad.DataSource = objDS.Tables(0)
            cboLocalidad.DisplayMember = "descrip"
            cboLocalidad.ValueMember = "cod_ent"
            cboLocalidad.Text = "Seleccione una localidad"

            objDS = objPwicomun.obtenerListaPersonas()
            If Not objDS.Tables Is Nothing Then
                dgPersonas.DataSource = objDS.Tables(0)
            End If
        Catch ex As Exception
            btnEliminar.Enabled = False
        End Try
    End Sub

    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            abrirFormulario()
            btnEliminar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim num As Integer
        Try
            num = objPwicomun.ActualizarLista(txtNombre.Text, txtApellido.Text, txtFecNac.Text, cboLocalidad.SelectedValue)
            If num Then
                MsgBox("Se agregaron los datos de la persona.")
                txtNombre.Enabled = False
                txtApellido.Enabled = False
                txtFecNac.Enabled = False
                cboLocalidad.Enabled = False
                btnAlta.Enabled = False
                abrirFormulario()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiar()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtFecNac.Text = ""
        cboLocalidad.Text = ""
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtFecNac.Enabled = True
        cboLocalidad.Enabled = True
        btnAlta.Enabled = True
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idUsuario As Integer
        Dim bool As Integer
        Try
            Dim n As String = MsgBox("Seguro de desea eliminar?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
            If n = vbYes Then
                idUsuario = dgPersonas.CurrentRow.Cells("idusuario").Value
                bool = objPwicomun.eliminarPersonas(idUsuario)
                If bool Then
                    MsgBox("Se elimino correctamente.")
                    abrirFormulario()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim idUsuario As Integer
        Dim bool As Integer
        Try
            Dim n As String = MsgBox("Seguro de desea eliminar?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
            If n = vbYes Then
                idUsuario = dgPersonas.CurrentRow.Cells("idusuario").Value
                bool = objPwicomun.eliminarPersonas(idUsuario)
                If bool Then
                    MsgBox("Se elimino correctamente.")
                    abrirFormulario()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class