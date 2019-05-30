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
    Public Sub actulizarProd_cantidad(id As Integer, cant As Double, operador As String)
        Dim objccdProductoCantidad As New ccdProductoCantidad
        Dim objccdPagos As New ccdPagosTpoPago
        Try
            If operador = "+" Then
                objccdProductoCantidad.actualizarCantidad(id, objccdProductoCantidad.obtenerCantidad(id) + cant)
            Else
                objccdProductoCantidad.actualizarCantidad(id, objccdProductoCantidad.obtenerCantidad(id) - cant)
            End If
        Catch ex As Exception
            agregar_error(ex, "cnProductos ActualizarProd")
        End Try
    End Sub

    Friend Function obtenerProductosInventario(id_prod As Integer) As DataSet
        Try
            Dim objccdProducto As New ccdProducto
            obtenerProductosInventario = objccdProducto.obtenerProductosInventario(id_prod)
        Catch ex As Exception
            agregar_error(ex, "cnProductos obtenerProductosInventario")
            obtenerProductosInventario = Nothing
        End Try
    End Function
    'Friend Function GuardarEgreso(id_prod As Integer, precio As Double, cant As Double, total As Double, formaPago As String) As Integer
    '    Dim objccdEgresos As New ccdEgresos
    '    Dim id_egreso As Integer
    '    Dim objccdPagos As New ccdPagosTpoPago
    '    Try
    '        id_egreso = objccdEgresos.actualizarEgresos(id_prod, precio, cant, total, Date.Now)
    '        If id_egreso <> 0 Then
    '            objccdPagos.actualizarpagosTpoPago(id_egreso, formaPago, Date.Now)
    '        End If
    '        GuardarEgreso = 1
    '    Catch ex As Exception
    '        GuardarEgreso = 0
    '        agregar_error(ex, "cnProductos GuardarEgreso")
    '    End Try
    'End Function
End Class
