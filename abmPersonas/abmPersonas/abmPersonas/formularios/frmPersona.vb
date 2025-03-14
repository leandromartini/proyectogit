﻿Imports System.Data.SqlClient
Imports System.Data

Public Class frmPersona

    Dim objDS As DataSet
    Dim objPwicomun As New pwiComun
    Dim idPersona As Integer = -1
    Sub abrirFormulario()
        Try
            objDS = objPwicomun.llenarCboLocalidades()
            cboLocalidad.DataSource = objDS.Tables(0)
            cboLocalidad.DisplayMember = "descrip"
            cboLocalidad.ValueMember = "cod_ent"
            cboLocalidad.SelectedIndex = -1
            cboLocalidad.Text = "Seleccionar Localidad"

            objDS = objPwicomun.obtenerListaPersonas()
            If Not objDS.Tables Is Nothing Then
                dgPersonas.DataSource = objDS.Tables(0)
                dgPersonas.Columns("idUsuario").Visible = False
                dgPersonas.Columns("ciudad").Visible = False
                dgPersonas.Columns("descrip").HeaderText = "Ciudad"
                dgPersonas.Columns("nombre").HeaderText = "Nombre"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            abrirFormulario()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim num As Integer

        Try
            If Not validar() Then
                MsgBox("Asegurese de llenar todos los campos!")

                Exit Sub
            End If
            num = objPwicomun.ActualizarRegistro(idPersona, txtNombre.Text, txtApellido.Text, dpFecNac.Text, cboLocalidad.SelectedValue)
            If num Then
                MsgBox("Se agregaron los datos de la persona.")
                bloquear()
                abrirFormulario()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiar()
        txtNombre.Text = ""
        txtApellido.Text = ""
        dpFecNac.Text = ""
        cboLocalidad.SelectedIndex = -1
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        dpFecNac.Enabled = True
        cboLocalidad.Enabled = True
        btnAlta.Enabled = True
    End Sub
    Public Sub bloquear()
        idPersona = -1
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        dpFecNac.Enabled = False
        cboLocalidad.Enabled = False
        btnAlta.Enabled = False
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idUsuario As Integer
        Dim bool As Integer
        Try
            If dgPersonas.CurrentRow IsNot Nothing Then
                Dim n As String = MsgBox("Seguro de desea eliminar?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
                If n = vbYes Then
                    idUsuario = dgPersonas.CurrentRow.Cells("idusuario").Value
                    bool = objPwicomun.eliminarPersonas(idUsuario)
                    If bool Then
                        MsgBox("Se elimino correctamente.")
                        abrirFormulario()
                    End If
                End If
            Else
                MsgBox("Debe seleccionar una fila a eliminar")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgPersonas.CurrentRow IsNot Nothing Then
                limpiar()
                txtNombre.Text = dgPersonas.CurrentRow.Cells("nombre").Value
                txtApellido.Text = dgPersonas.CurrentRow.Cells("apellido").Value
                dpFecNac.Text = dgPersonas.CurrentRow.Cells("fecNac").Value
                cboLocalidad.SelectedValue = dgPersonas.CurrentRow.Cells("ciudad").Value
                idPersona = dgPersonas.CurrentRow.Cells("idusuario").Value
            Else
                MsgBox("Ninguna fila seleccionada para modificar")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Function validar() As Boolean
        If txtNombre.Text = "" Then
            validar = False
            Exit Function
        End If
        If txtApellido.Text = "" Then
            validar = False
            Exit Function
        End If
        If dpFecNac.Text = "" Then
            validar = False
            Exit Function
        End If
        If cboLocalidad.Text = "Seleccionar Localidad" Then
            validar = False
            Exit Function
        End If
        validar = True
    End Function
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnAltaDeuda_Click(sender As Object, e As EventArgs) Handles btnAltaDeuda.Click
        Try
            If dgPersonas.CurrentRow IsNot Nothing Then
                frmAltaDeudas.idpersona = dgPersonas.CurrentRow.Cells("idusuario").Value
                frmAltaDeudas.ShowDialog()
            Else
                MsgBox("Debe seleccionar una persona para el alta de deudas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class