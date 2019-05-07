Public Class productos
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Function obtenerProductos(id_prod) As DataSet
        Dim objccProd As New ccdProducto
        obtenerProductos = objccProd.obtenerProductos(id_prod)
    End Function
    Public Function obtenerNombre()
        Return nombre
    End Function
    Public Function obtenerDescripcion()
        Return descripcion
    End Function
    Public Function obtenerPrecio()
        Return precio
    End Function
    Public Function obtenerUnidad()
        Return unidad
    End Function
    Public Sub actualizarProducto()

    End Sub
    Friend Sub limpiar()
        nombre = ""
        descripcion = ""
        precio = 0
    End Sub
End Class
