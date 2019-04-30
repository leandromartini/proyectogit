Public Class wflProductos

    'agregaProducto se refiere a los materiales que entraron en el dia y se tienen que cargar a datos
    Friend Sub AgregarProducto(item As ListViewItem)
        Dim objProducto As New productoCantidad
        'cargo clases correspondientes al producto
        objProducto.NuevoPruducto(item.SubItems(0).Text, "", item.SubItems(2).Text)
        objProducto.agregarCantidad(item.SubItems(1).Text)

        'en la tabla Prod_cantidad se incrementa el stock, 
        'actulizarProd_cantidad()

        'Si el precio cambio  
        If Not objProducto.obtenerprecio = objProducto.obtenerProductos(1) Then
            objProducto.actualizarProducto()
        End If
        'entonces hay que modificarlo en la tabla Productos, y agregar en prod_historia el nuevo precio con su fecha de modificacion
    End Sub
End Class
