Imports System.Data.SqlClient
Public Class ccdProductos
    Public Function actualizarRegistroIngresos(ByVal id_prod As Integer, ByVal nombre As Long, ByVal descrip As Long, ByVal unidad As Long) As Integer
        Try

            Dim sProdString As String = "[dbo].[productos_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descrip", descrip)
                command.Parameters.AddWithValue("@unidad", unidad)
                conn()
                actualizarRegistroIngresos = command.ExecuteNonQuery()
            End With
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarRegistroIngresos = 0
        End Try
    End Function
End Class
