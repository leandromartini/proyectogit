Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class deudasTpos
    Public Function obtenerTposDeudas() As DataSet
        Try

            Dim sProdString As String = "[dbo].[deudas_obtenerTposDeudas]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerTposDeudas = dataset
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerTposDeudas = Nothing
        End Try
    End Function
End Class
