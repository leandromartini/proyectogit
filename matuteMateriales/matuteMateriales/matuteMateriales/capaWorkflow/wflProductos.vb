
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
                Dim FechaPrecio As Date
                'en la tabla Prod_cantidad se incrementa el stock, 
                objcnProducto.actulizarProd_cantidad(item.SubItems(4).Text, item.SubItems(1).Text)
                'Si el precio de lista es nuevo actualizo en tabla ProductosPrecio...
                If Not objProductoCantidad.verPrecio = objProductos.obtenerPrecio(item.SubItems(4).Text) Then
                    FechaPrecio = objcnProducto.guardarPrecio(item.SubItems(4).Text, item.SubItems(2).Text, -1)
                    If Not FechaPrecio = "" Then
                        'y agregar en prod_historia el nuevo precio con su fecha de modificacion
                        objcnProducto.guardarPrecioHist(item.SubItems(4).Text, item.SubItems(2).Text, -1, FechaPrecio)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function ProductoNuevo(nom As String, unidad As String, precio As Double, descrip As String) As Long
        Dim objProductos As New producto
        Dim objcnProducto As New cnProductos
        Try
            Dim idproducto As New Integer
            ProductoNuevo = 0
            objProductos.NuevoPruducto(nom, unidad, precio, descrip)
            'Primero guardo el producto
            idproducto = objcnProducto.guardarNuevo(-1, objProductos.verNombre, objProductos.verDescripcion, objProductos.obtenerUnidad)
            If IsNothing(idproducto) Then
                Exit Function
            End If
            'Luego guardo su precio el precio para el nuevo producto.
            ProductoNuevo = objcnProducto.guardarPrecio(idproducto, objProductos.verPrecio, -1)
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
