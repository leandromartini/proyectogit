Imports System.Drawing.Printing

Public Class frmMaterialesStock
    Dim objImprimir As New imprimir
    Private TitulosDoc As String = "CONTROL DE INVENTARIO "

    Private Sub btnVistaPrevia_Click(sender As Object, e As EventArgs) Handles btnVistaPrevia.Click
        objImprimir.imprimirVistaPrevia(dgMaterialesStock, TitulosDoc)
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        objImprimir.imprimir(dgMaterialesStock, TitulosDoc)
    End Sub
    Private Sub limpiar()
        Try
            dgMaterialesStock.DataSource = Nothing
            dgMaterialesStock = Nothing
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        limpiar()
        Close()
    End Sub
End Class
