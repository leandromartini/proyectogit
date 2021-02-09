Public Class cnInsumos
    Dim objccdInsumos As New ccdInsumos
    Dim objccdInsumosProv As New ccdInsumosProveedores
    Dim objccdInsumosPrecios As New ccdInsumosPrecios
    Dim objccdInsumosStock As New ccdInsumosStock
    Public Function ActualizarInsumo(codigo, descrip) As Integer

        Try
            ActualizarInsumo = objccdInsumos.actualizarInsumo(codigo, descrip)
        Catch ex As Exception
            agregar_error(ex, "cnInsumos ActualizarInsumo")
            ActualizarInsumo = Nothing
        End Try
    End Function
    Public Function ActualizarInsumoPrecios(codigo, preciosiva, preciociva, ventapublico) As Integer
        Try
            ActualizarInsumoPrecios = objccdInsumosPrecios.actualizarInsumoPrecios(codigo, preciosiva, preciociva, ventapublico)
        Catch ex As Exception
            agregar_error(ex, "cnInsumos ActualizarInsumoPrecios")
            ActualizarInsumoPrecios = Nothing
        End Try
    End Function
    Public Function ActualizarInsumoStock(codigo, stock, stockMin, stockMax) As DateTime
        Try
            Dim int As Integer = -1
            ActualizarInsumoStock = "01/01/1900"
            int = objccdInsumosStock.actualizarInsumoStock(codigo, stock, stockMin, stockMax, DateTime.Now)
            If int > 0 Then
                ActualizarInsumoStock = DateTime.Now
            End If

        Catch ex As Exception
            agregar_error(ex, "cnInsumos ActualizarInsumoStock")
            ActualizarInsumoStock = Nothing
        End Try
    End Function

    Friend Function obtenerInsumosProv(idprov As Integer) As DataSet
        Try
            obtenerInsumosProv = objccdInsumosProv.obtenerInsumosProv(idprov)
        Catch ex As Exception
            agregar_error(ex, "cnInsumos obtenerInsumosProv")
            obtenerInsumosProv = Nothing
        End Try
    End Function

    Public Function obtenerInsumosDescrip(codigo As Integer) As DataSet

        Try
            obtenerInsumosDescrip = objccdInsumos.obtenerInsumosDescrip(codigo)
        Catch ex As Exception
            agregar_error(ex, "cnInsumos obtenerInsumosDescrip")
            obtenerInsumosDescrip = Nothing
        End Try
    End Function

    Friend Function obtenerinsumosDetalle(id_prod As Integer) As DataSet

        Try
            obtenerinsumosDetalle = objccdInsumos.obtenerinsumosDetalles(id_prod)
        Catch ex As Exception
            agregar_error(ex, "cnInsumos obtenerinsumosDetalle")
            obtenerinsumosDetalle = Nothing
        End Try
    End Function

End Class
