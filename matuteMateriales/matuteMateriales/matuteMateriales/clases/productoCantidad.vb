Public Class productoCantidad
    Inherits productos
    Private cantidadProducto As Double

    Public Sub agregarMateriales(nom As String, unidad As String, descrip As String, prec As Double, cant As Double)
        NuevoPruducto(nom, unidad, descrip, prec)
        cantidadProducto = cant
    End Sub

    Public Sub agregarCantidad(cant)
        cantidadProducto = cant
    End Sub

    Public Function obtenerInventario(ByVal idProd As String)
        obtenerInventario = "prodcutos"
    End Function
End Class
