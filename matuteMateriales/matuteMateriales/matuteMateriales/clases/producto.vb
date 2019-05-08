Public Class producto
    Private nombre As String
    Private unidad As String
    Private descripcion As String
    Private precio As Double

    Public Sub NuevoPruducto(nom As String, uni As String, prec As Double, descrip As String)
        Try
            nombre = nom
            unidad = uni
            precio = prec
            descripcion = descrip
        Catch ex As Exception
            agregar_error(ex)
        End Try
    End Sub
    Public Function verNombre()
        Return nombre
    End Function
    Public Function verUnidad()
        Return unidad
    End Function
    Public Function verPrecio()
        Return precio
    End Function
    Public Function verDescripcion()
        Return descripcion
    End Function
    Function obtenerProductos(id_prod) As DataSet
        Dim objccProd As New ccdProducto
        obtenerProductos = objccProd.obtenerProductos(id_prod)
    End Function
    Public Function obtenerPrecio(id_prod As Double) As Double
        Dim objcnProd As New cnProductos
        obtenerPrecio = objcnProd.obtenerPrecio(id_prod)
    End Function
    Public Function obtenerUnidad()
        Return unidad
    End Function
    Public Sub actualizarProducto()

    End Sub
    Friend Sub limpiar()
        nombre = ""
        precio = 0
        descripcion = ""
    End Sub
End Class
