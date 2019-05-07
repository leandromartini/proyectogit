Public Class productoCantidad
    Inherits productos
    Private cantidadProducto As Double

    Public Sub agregarMateriales(nom As String, unidad As String, descrip As String, prec As Double, cant As Double)
        Try
            NuevoPruducto(nom, unidad, prec, descrip)
            cantidadProducto = cant

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub agregarCantidad(cant)
        cantidadProducto = cant
    End Sub

    Public Function obtenerInventario(ByVal idProd As String)
        obtenerInventario = "prodcutos"
    End Function
End Class
