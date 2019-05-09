Imports System.Data.SqlClient
Public Class ccdProductoCantidad
    Public Function actualizarCantidad(ByVal id_prod As Integer, ByVal cant As Double) As Integer
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[productosCantidad_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                command.Parameters.AddWithValue("@cant", cant)
                conn()
                actualizarCantidad = command.ExecuteNonQuery()
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex, "actualizarCantidad")
            actualizarCantidad = 0
        End Try
    End Function
    Public Function obtenerCantidad(ByVal id_prod As Integer) As Double
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[productosCantidad_obtenerCantidad]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                conn()
                obtenerCantidad = CDbl(command.ExecuteScalar())
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex, "obtenerCantidad")
            obtenerCantidad = 0
        End Try
    End Function
End Class
