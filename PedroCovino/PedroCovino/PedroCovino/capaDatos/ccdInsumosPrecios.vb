Imports System.Data.SqlClient
Public Class ccdInsumosPrecios
    Public Function actualizarInsumoPrecios(ByVal codigo As Integer, ByVal preciosiva As Double, ByVal preciociva As Double, ByVal ventapublico As Double) As Integer
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[insumosPrecios_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@codigo", codigo)
                command.Parameters.AddWithValue("@preciosiva", preciosiva)
                command.Parameters.AddWithValue("@preciociva", preciociva)
                command.Parameters.AddWithValue("@ventapublico", ventapublico)
                conn()
                actualizarInsumoPrecios = CInt(command.ExecuteScalar())
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex, "actualizarProducto")
            actualizarInsumoPrecios = 0
        End Try
    End Function
End Class
