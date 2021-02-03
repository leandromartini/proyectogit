Public Class insumoStock
    Private codigo As Integer
    Private stock As Integer
    Private stockmin As Integer
    Private stockmax As Integer

    Public Sub Nuevo(cod As Integer, stck As Integer, stckmin As Integer, stckmax As Integer)
        Try
            codigo = cod
            stock = stck
            stockmin = stckmin
            stockmax = stckmax
        Catch ex As Exception
            agregar_error(ex, "producto NuevoPruducto")
        End Try
    End Sub

    Public Function verCodigo()
        Return codigo
    End Function
    Public Function verStock()
        Return stock
    End Function
    Public Function verstockmin()
        Return stockmin
    End Function
    Public Function verstockmax()
        Return stockmax
    End Function
    Friend Sub limpiar()
        codigo = 0
        stock = 0
        stockmin = 0
        stockmax = 0
    End Sub
End Class
