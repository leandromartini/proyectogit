Public Class cnProductos

    Public Function guardarNuevo(id, nom, desc, uni) As Integer
        'El guardar nuevo, es para al alta de nuevo concepto de producto, con su descrip, tipo unidad y precio.
        Dim objccdProducto As New ccdProducto
        guardarNuevo = objccdProducto.actualizarProducto(id, nom, desc, uni)
    End Function
    Public Function obtenerProductos(id_prod As Integer) As DataSet
        Dim objccdProducto As New ccdProducto
        obtenerProductos = objccdProducto.obtenerProductos(id_prod)
    End Function

    Public Function guardarPrecio(id, precio, precioIVA) As Date
        Dim objccdProductoPrecio As New ccdProductoPrecio
        guardarPrecio = objccdProductoPrecio.actualizarPrecio(id, precio, precioIVA)
    End Function
    Public Function obtenerPrecio(id) As Double
        Dim objccdProductoPrecio As New ccdProductoPrecio
        obtenerPrecio = objccdProductoPrecio.obtenerPrecio(id)
    End Function
    Public Function guardarPrecioHist(id, precio, precioIVA, fecAct) As Integer
        Dim objccdProductoPrecio As New ccdProductoPrecioHist
        guardarPrecioHist = objccdProductoPrecio.actualizarPrecioHist(id, precio, precioIVA, fecAct)
    End Function
    Public Function actulizarProd_cantidad(id As Integer, cant As Double) As Integer
        Dim objccdProductoCantidad As New ccdProductoCantidad

        actulizarProd_cantidad = objccdProductoCantidad.actualizarCantidad(id, objccdProductoCantidad.obtenerCantidad(id) + cant)

    End Function
End Class
