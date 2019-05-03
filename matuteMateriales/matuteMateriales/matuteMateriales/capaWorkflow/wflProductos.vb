
Public Class wflProductos

    'agregaProducto se refiere a los materiales que entraron en el dia y se tienen que cargar a datos
    Friend Sub AgregarProductodeLista(item As ListViewItem)
        Dim objProducto As New productoCantidad
        'cargo clases correspondientes al producto
        objProducto.NuevoPruducto(item.SubItems(0).Text, "", "", item.SubItems(2).Text)
        objProducto.agregarCantidad(item.SubItems(1).Text)

        'en la tabla Prod_cantidad se incrementa el stock, 
        'actulizarProd_cantidad()

        'Si el precio cambio  
        If Not objProducto.obtenerprecio = objProducto.obtenerProductos(1) Then
            objProducto.actualizarProducto()
        End If
        'entonces hay que modificarlo en la tabla Productos, y agregar en prod_historia el nuevo precio con su fecha de modificacion
    End Sub

    Public Function ProductoNuevo(nom As String, unidad As String, precio As Double, descrip As String) As Long
        Try
            Dim objcnProducto As New cnProductos
            Dim objProductos As New productos

            objProductos.NuevoPruducto(nom, unidad, precio, descrip)

            beginTran()

            ProductoNuevo = objcnProducto.guardarNuevo(-1, objProductos.obtenerNombre, objProductos.obtenerDescripcion, objProductos.obtenerUnidad)

            If ProductoNuevo <> 0 Then
                disposeTran()
                Exit Function
            End If
            'Guardar el precio para el nuevo producto.

            commitTran()
            'Vaciar productos luego de realizar el proceso correspondiente
            objProductos.limpiar()
        Catch ex As Exception
            If IsDBNull(esTran) Then
                disposeTran()
            End If
            ProductoNuevo = 0
            MsgBox("Error debido a: " & ex.Message, MsgBoxStyle.Exclamation, "¡Advertencia!")
        End Try
    End Function
End Class
