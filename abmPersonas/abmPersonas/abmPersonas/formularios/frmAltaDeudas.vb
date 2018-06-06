Imports System
Imports System.Data
Public Class frmAltaDeudas
    Dim objPwiDeudas As New pwiDeudas
    Public idpersona As Integer
    Sub abrirFormulario()
        Try
            txtIdentificador.Text = idpersona
            txtMonto.Text = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmAltaDeudas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirFormulario()
    End Sub

    Private Sub btnAltaDeuda_Click(sender As Object, e As EventArgs) Handles btnAltaDeuda.Click
        Dim bool As Boolean
        If Not validar() Then
            Exit Sub
        End If
        bool = objPwiDeudas.generarDeuda(idpersona, txtTpoDeuda.Text, txtMonto.Text, Date.Now)
        If bool Then
            MsgBox("Se guardo con exito la deuda!")
            limpiar()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Me.Close()
    End Sub
    Sub limpiar()
        txtMonto.Text = 0
        txtTpoDeuda.Text = ""
    End Sub
    Function validar()
        If txtMonto.Text = 0 Then
            MsgBox("El monto no puede ser cero (0)")
            Exit Function
        End If
        If txtTpoDeuda.Text = "" Then
            MsgBox("Ingrese el tipo de deuda")
            Exit Function
        End If
        validar = True
    End Function
End Class