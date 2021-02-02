
Public Class wflInsumos

    'Public Function actualizarInsumo(nom As String, unidad As String, precio As Double, descrip As String) As Date
    '    Dim objProductos As New producto
    '    Dim objcnInsumos As New cnInsumos
    '    actualizarInsumo = "01/01/1900"
    '    Try
    '        Dim idproducto As New Integer
    '        objProductos.NuevoPruducto(nom, unidad, precio, descrip)
    '        'Primero guardo el producto
    '        idproducto = objcnInsumos.guardarNuevo(-1, objProductos.verNombre, objProductos.verDescripcion, objProductos.obtenerUnidad)
    '        If idproducto < 1 Then
    '            Exit Function
    '        End If
    '        'Luego guardo su precio el precio para el nuevo producto.
    '        ProductoNuevo = objcnProducto.guardarPrecio(idproducto, objProductos.verPrecio, -1)
    '        'Vaciar productos luego de realizar el proceso correspondiente
    '        objProductos.limpiar()
    '    Catch ex As Exception
    '        agregar_error(ex, "wflProductos ProductoNuevo")
    '    End Try
    'End Function

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
