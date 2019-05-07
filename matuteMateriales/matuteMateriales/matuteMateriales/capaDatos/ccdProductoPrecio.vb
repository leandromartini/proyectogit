Imports System.Data.SqlClient
Public Class ccdProductoPrecio
    Public Function actualizarPrecio(ByVal id_prod As Integer, precio As Double, precioIVA As Double) As Integer
        Try
            'DECLARE @MyDate date
            'set @MyDate = GETDATE()
            'Print(Convert(varchar,@MyDate, 3))
            Dim sProdString As String = "[dbo].[productosPrecio_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                command.Parameters.AddWithValue("@precio", precio)
                command.Parameters.AddWithValue("@precioiva", precioIVA)
                conn()
                'actualizarPrecio = command.ExecuteNonQuery()
                actualizarPrecio = "07/05/2019"
            End With
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarPrecio = Nothing
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
            MsgBox(ex.Message)
            obtenerPrecio = Nothing
        End Try
    End Function
End Class
