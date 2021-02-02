Module errores
    Sub agregar_error(ex As Exception, namefrm As String)
        guardar(ex, namefrm)
        MsgBox(ex.Message)
    End Sub
    Sub guardar(ex As Exception, namefrm As String)
        Dim objccdErrores As New ccdErrores
        objccdErrores.actualizarErrores(ex.Message, namefrm)
    End Sub
End Module
