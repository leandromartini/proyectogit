Public Class insumo
    Dim codigo As Integer
    Public descripcion As String

    Public Sub Nuevo(codigonuevo As Integer, descripcionNuevo As String)
        Try
            codigo = codigonuevo
            descripcion = descripcionNuevo
        Catch ex As Exception
            agregar_error(ex, "producto NuevoPruducto")
        End Try
    End Sub
    Function verCodigo()
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
