Imports System.Data.SqlClient
Public Class ccdInsumos
    Public Function actualizarInsumo(ByVal codigo As Integer, ByVal descrip As String) As Integer
        Try
            Dim dataset As New DataSet
            Dim sProdString As String = "[dbo].[insumos_actualizarRegistro]"
            Dim command As New SqlCommand(sProdString, objConn)
            With command
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@codigo", codigo)
                command.Parameters.AddWithValue("@descrip", descrip)
                conn()
                actualizarInsumo = CInt(command.ExecuteScalar())
            End With
            disconect()
        Catch ex As Exception
            agregar_error(ex, "actualizarProducto")
            actualizarInsumo = 0
        End Try
    End Function
    Public Function obtenerInsumosDescrip(codigo, idprov) As DataSet
        Try
            Dim sProdString As String = "[dbo].[insumos_obtenerLista]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.Parameters.AddWithValue("@codigo", codigo)
                command.Parameters.AddWithValue("@idprov", idprov)
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerInsumosDescrip = dataset
        Catch ex As Exception
            disconect()
            agregar_error(ex, "obtenerProductos")
            obtenerInsumosDescrip = Nothing
        End Try
    End Function

    Friend Function obtenerinsumosDetalles(codigo As Object) As DataSet
        Try
            Dim sProdString As String = "[dbo].[insumos_obtenerListaDetalle]"
            Dim command As New SqlCommand(sProdString, objConn)
            Dim dataset As New DataSet
            With command
                command.Parameters.AddWithValue("@codigo", codigo)
                command.CommandType = CommandType.StoredProcedure
                conn()
            End With
            Dim da As New SqlDataAdapter(command)
            da.Fill(dataset)
            disconect()
            obtenerinsumosDetalles = dataset
        Catch ex As Exception
            disconect()
            agregar_error(ex, "obtenerinsumosInventario")
            obtenerinsumosDetalles = Nothing
        End Try
    End Function
End Class
