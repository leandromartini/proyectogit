Public Class productoCantidad
    Inherits productos
    Private cantidadProducto As Double

    Public Sub agregarMateriales(ByVal nom As String, ByVal descrip As String, ByVal prec As Double, ByVal cant As Double)
        NuevoPruducto(nom, descrip, prec)
        cantidadProducto = cant
    End Sub

    Public Sub agregarCantidad(cant)
        cantidadProducto = cant
    End Sub

    Public Function obtenerInventario(ByVal idProd As String)
        obtenerInventario = "prodcutos"
    End Function
End Class
