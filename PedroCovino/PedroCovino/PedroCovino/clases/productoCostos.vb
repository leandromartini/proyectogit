Public Class productoCostos
    Inherits producto
    Private costosiva As Double
    Private costociva As Double
    Private precioPub As Double

    Public Sub agregarCostos(codigo As String, descrip As String, descrip As String, prec As Double, cant As Double)
        Try
            NuevoPruducto(codigo, descrip)
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
