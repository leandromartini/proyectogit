Public Class frmNuevoIngreso
    Dim objImprimir As New imprimir
    Private rdCheck As String
    Private rdCheckForma As String
    Private TitulosDoc As String = "LISTA DE MATERIALES  "
    Private Sub frmMaterialesAgrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            agregar_error(ex, Name)
        End Try
    End Sub

End Class
