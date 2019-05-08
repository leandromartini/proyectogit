Imports System.Data.SqlClient
Public Class ccdProducto
    Public Function actualizarProducto(ByVal id_prod As Integer, ByVal nombre As String, ByVal descrip As String, ByVal unidad As String) As Integer
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[productos_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_prod", id_prod)
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descrip", descrip)
                command.Parameters.AddWithValue("@unidad", unidad)
                conn()
                actualizarProducto = CInt(command.ExecuteScalar())
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex)
            actualizarProducto = 0
        End Try
    End Function
    Public Function obtenerProductos(id_prod) As DataSet
        Try
            Dim sProdString As String = "[dbo].[productos_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.Parameters.AddWithValue("@id_prod", id_prod)
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerProductos = dataset
        Catch ex As Exception
            agregar_error(ex)
            obtenerProductos = Nothing
            disconect()
        End Try
    End Function
End Class
