Imports System.Data.SqlClient
Public Class ccdProductoPrecio
    Public Function actualizarPrecio(ByVal id_prod As Integer, ByVal precio As Double, ByVal precioIVA As Double) As Integer
        Try

            Dim sProdString As String = "[dbo].[productosPrecio_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                command.Parameters.AddWithValue("@precio", precio)
                command.Parameters.AddWithValue("@precioiva", precioIVA)
                conn()
                actualizarPrecio = command.ExecuteNonQuery()
            End With
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarPrecio = Nothing
        End Try
    End Function
End Class
