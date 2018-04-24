Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class localidades

    Public Shared Function obtenerLocalidades() As SqlDataReader
        Try
            Dim sConnectionString As String _
            = "Initial Catalog=pruebas; Data Source=localhost ; Integrated Security=SSPI;"
            Dim objConn As New SqlConnection(sConnectionString)

            Dim sProdString As String = "[dbo].[localidades_ObtenerRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dalRes As New DataSet

            command.CommandType = CommandType.StoredProcedure
            conn()
            obtenerLocalidades = command.ExecuteReader()

            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerLocalidades = Nothing
        End Try
    End Function
End Class
