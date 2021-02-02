Public Class cnInsumos
    Dim objccdProducto As New ccdInsumos
    Public Function guardarNuevo(codigo, descrip, preciosiva, preciociva, ventapublico, stock) As Integer

        Try
            guardarNuevo = objccdProducto.actualizarInsumo(codigo, descrip, preciosiva, preciociva, ventapublico, stock)
        Catch ex As Exception
            agregar_error(ex, "cnProductos guardarNuevo")
            guardarNuevo = Nothing
        End Try
    End Function

    Public Function obtenerInsumosDescrip(codigo As Integer) As DataSet

        Try
            obtenerInsumosDescrip = objccdProducto.obtenerInsumosDescrip(codigo)
        Catch ex As Exception
            agregar_error(ex, "cnProductos obtenerInsumosDescrip")
            obtenerInsumosDescrip = Nothing
        End Try
    End Function

    Friend Function obtenerinsumosDetalle(id_prod As Integer) As DataSet

        Try
            obtenerinsumosDetalle = objccdProducto.obtenerinsumosDetalles(id_prod)
        Catch ex As Exception
            agregar_error(ex, "cnProductos obtenerinsumosDetalle")
            obtenerinsumosDetalle = Nothing
        End Try
    End Function

End Class
