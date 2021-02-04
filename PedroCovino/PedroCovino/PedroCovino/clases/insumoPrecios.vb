Public Class insumoPrecios
    Private codigo As Integer = 0
    Private preciosiva As Double = 0.0
    Private preciociva As Double = 0.0
    Private ventapublico As Double = 0.0

    Public Sub Nuevo(cod As Integer, presiva As Double, preciva As Double, ventpub As Double)
        Try
            codigo = cod
            preciosiva = presiva
            preciociva = preciva
            ventapublico = ventpub
        Catch ex As Exception
            agregar_error(ex, "producto NuevoPruducto")
        End Try
    End Sub
    Public Function verCodigo()
        Return codigo
    End Function

    Public Function verpreciosiva()
        Return preciosiva
    End Function
    Public Function verpreciociva()
        Return preciociva
    End Function
    Public Function verventapublico()
        Return ventapublico
    End Function

    Friend Sub limpiar()
        codigo = 0
        preciosiva = 0.0
        preciociva = 0.0
        ventapublico = 0.0
    End Sub
End Class
