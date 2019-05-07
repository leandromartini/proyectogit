Public Class cnProductos
    Dim objccdProducto As New ccdProducto
    'El agregar producto se refiere a los materiales que entraron en el dia y se tienen que cargar
    'de esta forma, en la tabla Prod_cantidad se incrementa el stock, 
    'Si el precio cambio, entonces hay que modificarlo en la tabla Productos, y agregar en prod_historia el nuevo precio con su fecha de modificacion
    Public Function agregarProducto()

    End Function

    'El guardar nuevo, es para al alta de nuevo concepto de producto, con su descrip, tipo unidad y precio.
    Public Function guardarNuevo(id, nom, desc, uni) As Integer
        guardarNuevo = objccdProducto.actualizarProducto(id, nom, desc, uni)
    End Function

    Public Function guardarPrecio(id, precio, precioIVA)
        Dim objccdProductoPrecio As New ccdProductoPrecio
        guardarPrecio = objccdProductoPrecio.actualizarPrecio(id, precio, precioIVA)
    End Function

    Public Function obtenerProductos(id_prod As Integer) As DataSet
        Dim objccdProducto As New ccdProducto
        obtenerProductos = objccdProducto.obtenerProductos(id_prod)
    End Function


End Class
