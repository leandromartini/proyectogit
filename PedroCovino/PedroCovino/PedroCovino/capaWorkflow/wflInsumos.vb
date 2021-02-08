
Public Class wflInsumos
    Dim objcnInsumos As New cnInsumos

    Public Function actualizarInsumo(codigo, descrip, preciosiva, preciociva, precioPub, stock, stockmin, stockmax) As Date

        Try

            If descrip <> "" Then
                'Me fijo si existe el insumo, de lo contrario lo agrego
                objcnInsumos.ActualizarInsumo(codigo, descrip)
            End If

            'Me fijo si cambio algun importe de lo contrario acualizo
            If preciosiva <> 0.0 And preciociva <> 0.0 And precioPub <> 0.0 Then
                objcnInsumos.ActualizarInsumoPrecios(codigo, preciosiva, preciociva, precioPub)
            End If

            'Me fijo si cambio el stock de lo contrario lo actualizo
            If stock <> 0 Then
                actualizarInsumo = objcnInsumos.ActualizarInsumoStock(codigo, stock, stockmin, stockmax)
            End If

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
