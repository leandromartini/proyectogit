Imports abmPersonas.localidades

Public Class pwiComun
    Dim objPersona As New personas
    Dim objLoc As New localidades
    Public Function llenarCboLocalidades() As DataSet
        Try
            llenarCboLocalidades = objLoc.obtenerLocalidades
        Catch ex As Exception
            llenarCboLocalidades = Nothing
        End Try
    End Function

    Public Function obtenerListaPersonas() As DataSet
        Try
            obtenerListaPersonas = objPersona.obtenerPersonas
        Catch ex As Exception
            obtenerListaPersonas = Nothing
        End Try

    End Function
    Public Function ActualizarLista(ByVal txtNombre As String, ByVal txtApellido As String, ByVal fecNac As String, ByVal loc As Integer) As Integer

        Try
            ActualizarLista = objPersona.ActualizarLista(txtNombre, txtApellido, fecNac, loc)
        Catch ex As Exception
            ActualizarLista = 0
        End Try
    End Function

    Public Function eliminarPersonas(ByVal idusuario As String) As Integer

        Try
            eliminarPersonas = objPersona.eliminarPersonas(idusuario)
        Catch ex As Exception
            eliminarPersonas = 0
        End Try
    End Function
End Class






