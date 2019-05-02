Public Class cnProductos
    Dim objccdProductos As New ccdProductos
    'El agregar producto se refiere a los materiales que entraron en el dia y se tienen que cargar
    'de esta forma, en la tabla Prod_cantidad se incrementa el stock, 
    'Si el precio cambio, entonces hay que modificarlo en la tabla Productos, y agregar en prod_historia el nuevo precio con su fecha de modificacion
    Public Function guardarNuevo(id, nom, desc, uni)
        guardarNuevo = objccdProductos.actualizarProducto(id, nom, desc, uni)
    End Function
End Class
