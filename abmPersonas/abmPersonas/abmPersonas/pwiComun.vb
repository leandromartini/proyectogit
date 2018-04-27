Imports abmPersonas.localidades

Public Class pwiComun
    Dim objLoc As New localidades
    Public Function llenarCboLocalidades() As DataSet
        llenarCboLocalidades = objLoc.obtenerLocalidades
    End Function
    Public Function ActualizarLista(ByVal txtNombre As String, ByVal txtApellido As String, ByVal fecNac As String, ByVal loc As Integer) As Integer
        Dim objPersona As New personas
        Try
            ActualizarLista = objPersona.ActualizarLista(txtNombre, txtApellido, fecNac, loc)
        Catch ex As Exception
            ActualizarLista = 0
        End Try
    End Function
End Class
