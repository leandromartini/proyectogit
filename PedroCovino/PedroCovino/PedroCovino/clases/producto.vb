Public Class producto
    Private codigo As Integer
    Private descripcion As String

    Public Sub NuevoPruducto(codigo As Integer, descripcion As String)
        Try
            codigo = codigo
            descripcion = descripcion
        Catch ex As Exception
            agregar_error(ex, "producto NuevoPruducto")
        End Try
    End Sub
    Public Function verCodigo()
        Return codigo
    End Function

    Public Function verDescripcion()
        Return descripcion
    End Function

    Friend Sub limpiar()
        codigo = 0
        descripcion = ""
    End Sub
End Class
