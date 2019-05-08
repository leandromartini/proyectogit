Module errores
    Sub agregar_error(ex As Exception)
        'guardar(ex)
        MsgBox(ex.Message)
    End Sub
    Sub guardar(ex As Exception)
        Dim objccdErrores As New ccdErrores
        objccdErrores.actualizarErrores(ex.Message)
    End Sub
End Module
