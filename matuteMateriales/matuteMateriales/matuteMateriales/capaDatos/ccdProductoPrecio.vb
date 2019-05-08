Imports System.Data.SqlClient
Public Class ccdProductoPrecio
    Public Function actualizarPrecio(ByVal id_prod As Integer, precio As Double, precioIVA As Double) As Date
        Try
            Dim sProdString As String = "[dbo].[productosPrecio_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                command.Parameters.AddWithValue("@precio", precio)
                command.Parameters.AddWithValue("@precioiva", precioIVA)
                conn()
                actualizarPrecio = command.ExecuteScalar()
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Function
    Public Function obtenerPrecio(id_prod As Integer) As Double
        Try

            Dim sProdString As String = "[dbo].[productosPrecio_obtenerPrecio]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                conn()
                obtenerPrecio = CDbl(command.ExecuteScalar())
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex)
            obtenerPrecio = 0
        End Try
    End Function
End Class
