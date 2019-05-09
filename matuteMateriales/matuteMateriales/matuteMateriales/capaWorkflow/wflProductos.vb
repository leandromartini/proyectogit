
Public Class wflProductos
    'agregaProducto se refiere a los materiales que entraron en el dia y se tienen que cargar a datos
    Friend Sub AgregarProductodeLista(item As ListViewItem)
        Dim objProductoCantidad As New productoCantidad
        Dim objProductos As New producto

        Try
            'cargo clases correspondientes al producto
            objProductoCantidad.agregarMateriales(item.SubItems(0).Text, "", "", item.SubItems(2).Text, item.SubItems(1).Text)
            Try
                Dim objcnProducto As New cnProductos
                Dim FechaPrecio As Date = "01/01/1900"
                'en la tabla Prod_cantidad se incrementa el stock, 
                objcnProducto.actulizarProd_cantidad(item.SubItems(4).Text, item.SubItems(1).Text)
                'Si el precio de lista es nuevo actualizo en tabla ProductosPrecio...
                If Not objProductoCantidad.verPrecio = objProductos.obtenerPrecio(item.SubItems(4).Text) Then
                    FechaPrecio = objcnProducto.guardarPrecio(item.SubItems(4).Text, item.SubItems(2).Text, -1)
                    If Not FechaPrecio = "01/01/1900" Then
                        'y agregar en prod_historia el nuevo precio con su fecha de modificacion
                        objcnProducto.guardarPrecioHist(item.SubItems(4).Text, item.SubItems(2).Text, -1, FechaPrecio.ToShortDateString)
                    End If
                End If
            Catch ex As Exception
                agregar_error(ex)
            End Try
        Catch ex As Exception
            agregar_error(ex)
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
            agregar_error(ex)
        End Try
    End Function

    Function obtenerProductos() As DataSet
        Dim objcnProductos As New cnProductos
        Try
            obtenerProductos = objcnProductos.obtenerProductos(-1)
        Catch ex As Exception
            agregar_error(ex)
            obtenerProductos = Nothing
        End Try
    End Function

    Function obtenerProductosInventario(id_prod) As DataSet
        Dim objcnProductos As New cnProductos
        Try
            obtenerProductosInventario = objcnProductos.obtenerProductosInventario(id_prod)
        Catch ex As Exception
            agregar_error(ex)
            obtenerProductosInventario = Nothing
        End Try
    End Function
End Class
