
Public Class wflInsumos
    Dim objcnInsumos As New cnInsumos

    Public Function actualizarInsumo(codigo, descrip, preciosiva, preciociva, precioPub, stock, stockmin, stockmax) As Date
        actualizarInsumo = "01/01/1900"
        Try

            'Me fijo si existe el insumo, de lo contrario lo agrego
            objcnInsumos.ActualizarInsumo(codigo, descrip)

            'Me fijo si cambio algun importe de lo contrario acualizo

            objcnInsumos.ActualizarInsumoPrecios(codigo, preciosiva, preciociva, precioPub)


            'Me fijo si cambio el stock de lo contrario lo actualizo

            objcnInsumos.ActualizarInsumoStock(codigo, stock, stockmin, stockmax)

            actualizarInsumo = DateTime.Now

        Catch ex As Exception
            agregar_error(ex, "wflProductos ProductoNuevo")
        End Try
    End Function

    Function obtenerInsumosDescrip(codigo) As DataSet
        Dim objcnProductos As New cnInsumos
        Try
            obtenerInsumosDescrip = objcnProductos.obtenerInsumosDescrip(codigo)
        Catch ex As Exception
            agregar_error(ex, "wflProductos obtenerinsumosInventario")
            obtenerInsumosDescrip = Nothing
        End Try
    End Function

    Function obtenerInsumosDetalle(codigo) As DataSet
        Dim objcnProductos As New cnInsumos
        Try
            obtenerInsumosDetalle = objcnProductos.obtenerinsumosDetalle(codigo)
        Catch ex As Exception
            agregar_error(ex, "wflProductos obtenerinsumosInventario")
            obtenerInsumosDetalle = Nothing
        End Try
    End Function

End Class
