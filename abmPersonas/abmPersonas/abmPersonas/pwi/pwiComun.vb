
Public Class pwiComun

    Public Function llenarCboLocalidades() As DataSet
        Dim Hours As Integer = Hour(Date.Now)

        Try
            If Hours = 13 Then
                llenarCboLocalidades = dtl.localidades.obtenerLocalidades
            Else

            End If

        Catch ex As Exception
            llenarCboLocalidades = Nothing
        End Try
    End Function

    Public Function obtenerListaPersonas() As DataSet
        Try
            obtenerListaPersonas = dtl.personas.obtenerListaPersonas
        Catch ex As Exception
            obtenerListaPersonas = Nothing
        End Try

    End Function
    Public Function ActualizarRegistro(ByVal idPersona As Integer, ByVal txtNombre As String, ByVal txtApellido As String, ByVal fecNac As String, ByVal loc As Integer) As Integer

        Try
            ActualizarRegistro = dtl.personas.ActualizarRegistroPersonas(idPersona, txtNombre, txtApellido, fecNac, loc)
        Catch ex As Exception
            ActualizarRegistro = 0
        End Try
    End Function

    Public Function eliminarPersonas(ByVal idusuario As String) As Integer

        Try
            eliminarPersonas = dtl.personas.eliminarRegistroPersonas(idusuario)
        Catch ex As Exception
            eliminarPersonas = 0
        End Try
    End Function

End Class






