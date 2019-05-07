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
                conn()
                actualizarCantidad = CInt(command.ExecuteScalar())
            End With
            disconect()
        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarCantidad = Nothing
        End Try
    End Function
End Class
