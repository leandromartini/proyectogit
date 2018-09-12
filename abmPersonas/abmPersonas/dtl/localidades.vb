Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class localidades
    Public Shared Function obtenerLocalidades() As DataSet
        Try

            Dim sProdString As String = "[dbo].[localidades_obtenerRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerLocalidades = dataset
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerLocalidades = Nothing
            disconect()
        End Try
    End Function
End Class
