Public Class productos
    Private nombre As String
    Private descripcion As String
    Private precio As Double

    Public Function obtenerProductos(ByVal idProd As Long) As DataSet
        'llamar a la capa de datos con su correspondiente clase de productos

    End Function
    Public Sub NuevoPruducto(ByVal nom As String, ByVal descrip As String, ByVal prec As Double)
        nombre = nom
        descripcion = descrip
        precio = prec
    End Sub
    Public Function obtenerNombre()
        Return nombre
    End Function
    Public Function obtenerdescripcion()
        Return nombre
    End Function
    Public Function obtenerprecio()
        Return precio
    End Function
    Public Sub actualizarProducto()

    End Sub
    Friend Sub limpiar()
        nombre = ""
        descripcion = ""
        precio = 0
    End Sub
End Class
