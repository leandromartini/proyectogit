
Public Class wflProductos
    'agregaProducto se refiere a los materiales que entraron en el dia y se tienen que cargar a datos
    Friend Sub AgregarProductodeListaIngresa(item As ListViewItem)
        Dim objProductoCantidad As New productoCantidad
        Dim objProductos As New producto

        Try
            'cargo clases correspondientes al producto
            objProductoCantidad.agregarMateriales(item.SubItems(0).Text, "", "", item.SubItems(1).Text, item.SubItems(2).Text)
            Try
                Dim objcnProducto As New cnProductos
                Dim objcdEgresos As New cnEgresos
                Dim FechaPrecio As Date = "01/01/1900"
                'en la tabla Prod_cantidad se incrementa el stock, 
                objcnProducto.actulizarProd_cantidad(item.SubItems(6).Text, item.SubItems(2).Text, "+")
                'Agrego en la tabla egresos el id del producto total y la fecha
                objcdEgresos.NuevoEgreso(item.SubItems(6).Text, item.SubItems(1).Text, item.SubItems(2).Text, item.SubItems(3).Text, item.SubItems(5).Text)
                'si existe gasto de transporte lo guardo
                If item.SubItems(4).Text <> 0 Then
                    objcdEgresos.NuevoEgreso(-1, item.SubItems(4).Text, 1, item.SubItems(4).Text, item.SubItems(5).Text)
                End If
                'Si el precio de lista es nuevo actualizo en tabla ProductosPrecio...
                If Not objProductoCantidad.verPrecio = objProductos.obtenerPrecio(item.SubItems(6).Text) Then
                    FechaPrecio = objcnProducto.guardarPrecio(item.SubItems(6).Text, item.SubItems(1).Text, -1)
                    If Not FechaPrecio = "01/01/1900" Then
                        'y agregar en prod_historia el nuevo precio con su fecha de modificacion
                        objcnProducto.guardarPrecioHist(item.SubItems(6).Text, item.SubItems(1).Text, -1, FechaPrecio.ToShortDateString)
                    End If
                End If
            Catch ex As Exception
                agregar_error(ex, "wflProductos AgregarProductodeLista")
            End Try
        Catch ex As Exception
            agregar_error(ex, "wflProductos AgregarProductodeLista")
        End Try

    End Sub

    Public Function ProductoNuevo(nom As String, unidad As String, precio As Double, descrip As String) As Date
        Dim objProductos As New producto
        Dim objcnProducto As New cnProductos
        ProductoNuevo = "01/01/1900"
        Try
            Dim idproducto As New Integer
            objProductos.NuevoPruducto(nom, unidad, precio, descrip)
            'Primero guardo el producto
            idproducto = objcnProducto.guardarNuevo(-1, objProductos.verNombre, objProductos.verDescripcion, objProductos.obtenerUnidad)
            If idproducto < 1 Then
                Exit Function
            End If
            'Luego guardo su precio el precio para el nuevo producto.
            ProductoNuevo = objcnProducto.guardarPrecio(idproducto, objProductos.verPrecio, -1)
            'Vaciar productos luego de realizar el proceso correspondiente
            objProductos.limpiar()
        Catch ex As Exception
            agregar_error(ex, "wflProductos ProductoNuevo")
        End Try
    End Function

    Function obtenerProductos(id_prod) As DataSet
        Dim objcnProductos As New cnProductos
        Try
            obtenerProductos = objcnProductos.obtenerProductos(id_prod)
        Catch ex As Exception
            agregar_error(ex, "wflProductos obtenerProductos")
            obtenerProductos = Nothing
        End Try
    End Function

    Function obtenerProductosInventario(id_prod) As DataSet
        Dim objcnProductos As New cnProductos
        Try
            obtenerProductosInventario = objcnProductos.obtenerProductosInventario(id_prod)
        Catch ex As Exception
            agregar_error(ex, "wflProductos obtenerProductos")
            obtenerProductosInventario = Nothing
        End Try
    End Function

    Friend Sub AgregarProductodeListaVentas(item As ListViewItem)
        Try
            Dim objcnIngresos As New cnIngresos
            Dim objcnProducto As New cnProductos

            objcnIngresos.GuardarIngreso(item.SubItems(5).Text, item.SubItems(2).Text, item.SubItems(1).Text, item.SubItems(3).Text, item.SubItems(4).Text)

            objcnProducto.actulizarProd_cantidad(item.SubItems(5).Text, item.SubItems(1).Text, "-")
            'cuando guarde un producto que vendí, entonces vamos a tener un ingreso puede ser efectivo, tarjeta, cheque
            'de todas formas es un ingreso (haber), luego debemos quitar en (cantidad de productos), lo que hemos vendido
            'que pasa si vendo mas de lo que tengo? deberia poder validar antes.
            '

        Catch ex As Exception
            agregar_error(ex, "wflProductos AgregarProductodeListaVentas")
        End Try
    End Sub
End Class
