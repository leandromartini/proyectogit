﻿Imports System.Data.SqlClient
Public Class ccdErrores
    Public Sub actualizarErrores(ByVal mensaje As String, namefrm As String)
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[errores_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_error", -1)
                command.Parameters.AddWithValue("@mensaje", mensaje)
                command.Parameters.AddWithValue("@namefrm", namefrm)
                If esConn() = 0 Then
                    conn()
                End If
                command.ExecuteNonQuery()
            End With
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class