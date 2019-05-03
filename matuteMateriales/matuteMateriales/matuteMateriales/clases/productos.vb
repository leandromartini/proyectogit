Public Class productos
    Private nombre As String
    Private unidad As String
    Private descripcion As String
    Private precio As Double

    Public Function obtenerProductos(ByVal idProd As Long) As DataSet
        'llamar a la capa de datos con su correspondiente clase de productos

    End Function
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
