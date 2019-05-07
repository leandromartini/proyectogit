
Public Class wflProductos

    'agregaProducto se refiere a los materiales que entraron en el dia y se tienen que cargar a datos
    Friend Sub AgregarProductodeLista(item As ListViewItem)
        Dim objProducto As New productoCantidad
        Try
            'cargo clases correspondientes al producto
            objProducto.NuevoPruducto(item.SubItems(0).Text, "", "", item.SubItems(2).Text)
            objProducto.agregarCantidad(item.SubItems(1).Text)

            'en la tabla Prod_cantidad se incrementa el stock, 
            'actulizarProd_cantidad()

            'Si el precio cambio  
            If Not objProducto.obtenerPrecio = objProducto.obtenerProductos(1) Then
                objProducto.actualizarProducto()
            End If
            'entonces hay que modificarlo en la tabla Productos, y agregar en prod_historia el nuevo precio con su fecha de modificacion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function ProductoNuevo(nom As String, unidad As String, precio As Double, descrip As String) As Long
        Try
            Dim objcnProducto As New cnProductos
            Dim objProductos As New productos
            Dim idproducto As New Integer

            ProductoNuevo = 0

            objProductos.NuevoPruducto(nom, unidad, precio, descrip)

            'Primero guardo el producto
            idproducto = objcnProducto.guardarNuevo(-1, objProductos.obtenerNombre, objProductos.obtenerDescripcion, objProductos.obtenerUnidad)

            If IsNothing(idproducto) Then
                Exit Function
            End If
            'Luego guardo su precio el precio para el nuevo producto.
            ProductoNuevo = objcnProducto.guardarPrecio(idproducto, objProductos.obtenerPrecio, -1)

            'Vaciar productos luego de realizar el proceso correspondiente
            objProductos.limpiar()
        Catch ex As Exception
            ProductoNuevo = 0
            MsgBox("Error debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
        End Try
    End Function

    Function obtenerProductos() As DataSet
        Dim objwflProductos As New cnProductos
        Try
            obtenerProductos = objwflProductos.obtenerProductos(-1)
        Catch ex As Exception
            MsgBox(ex.Message)
            obtenerProductos = Nothing
        End Try
    End Function

End Class
