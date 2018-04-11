Imports System.Data.SqlClient
Public Class frmPpal

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnVector_Click(sender As Object, e As EventArgs) Handles BtnVector.Click
        frmCargaVector.ShowDialog()
    End Sub

    Private Sub frmPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPersona_Click(sender As Object, e As EventArgs) Handles btnPersona.Click
        frmPersona.ShowDialog()

        'conexion.CreateCommand("select * from persona")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hola LeandroAcer!")
    End Sub
End Class
