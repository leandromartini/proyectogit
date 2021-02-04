Public Class frmNuevoInsumo
    Dim objImprimir As New imprimir
    Dim objComun As New Comun
    Private TitulosDoc As String = "NUEVO INGRESO "


    Private Sub frmNuevoInsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            validar()

            objComun.ActualizarInsumo(txtBoxCodigo.Text, txtBoxDescrip.Text)

            objComun.ActualizarInsumoPrecios(txtBoxCodigo.Text, CDbl(txtBoxPrecioSiva.Text), CDbl(txtBoxPrecioCiva.Text), CDbl(txtBoxPrecioPub.Text))

            objComun.ActualizarInsumoStock(txtBoxCodigo.Text, txtBoxStock.Text, txtBoxStockMin.Text, txtboxStockMax.Text)

            objComun.grabarInsumo()

            limpiar()

        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub
    Function validar()

        If txtBoxPrecioSiva.Text = "0,00" Then
            MsgBox("Agregue un precio sin IVA.", MsgBoxStyle.OkOnly, "Aviso")
            txtBoxPrecioSiva.Focus()
            Return False
        End If
        If txtBoxPrecioCiva.Text = "0,00" Then
            MsgBox("Agregue un precio con IVA.", MsgBoxStyle.OkOnly, "Aviso")
            txtBoxPrecioCiva.Focus()
            Return False
        End If
        If txtBoxPrecioPub.Text = "0,00" Then
            MsgBox("Agregue un precio para público.", MsgBoxStyle.OkOnly, "Aviso")
            txtBoxPrecioPub.Focus()
            Return False
        End If
    End Function
    Function limpiar()
        txtBoxCodigo.Text = ""
        txtBoxDescrip.Text = ""
        txtBoxPrecioSiva.Text = ""
        txtBoxPrecioCiva.Text = ""
        txtBoxPrecioPub.Text = ""
        txtBoxStock.Text = ""
        txtBoxStockMin.Text = ""
        txtboxStockMax.Text = ""
    End Function
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Close()
    End Sub
End Class