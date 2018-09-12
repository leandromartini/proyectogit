Imports System
Imports System.Data
Imports brl
Imports dtl
Public Class pwiDeudas

    Dim objDeudas As New brlDeudaAlta
    Public Function generarDeuda(ByVal idPersona As Integer, ByVal tpoDeuda As Long, ByVal importe As Double, ByVal fecEmision As Date) As Integer

        Try
            generarDeuda = brlDeudaAlta.altaDeuda(idPersona, tpoDeuda, importe, fecEmision)

        Catch ex As Exception
            MsgBox(ex.Message)
            generarDeuda = 0
        End Try
    End Function
    Public Function obtenerTpoDeudas() As DataSet
        Dim objTposDeudas As New deudasTpos
        Try
            obtenerTpoDeudas = objTposDeudas.obtenerTposDeudas
        Catch ex As Exception
            obtenerTpoDeudas = Nothing
        End Try
    End Function
End Class
