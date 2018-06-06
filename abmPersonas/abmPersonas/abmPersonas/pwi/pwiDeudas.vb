Imports System
Imports System.Data
Public Class pwiDeudas
    Dim objDeudas As New brlDeudaAlta
    Public Function generarDeuda(ByVal idPersona As Integer, ByVal tpoDeuda As Long, ByVal importe As Double, ByVal fecEmision As Date) As Integer
        Try
            generarDeuda = objDeudas.altaDeuda(idPersona, tpoDeuda, importe, fecEmision)

        Catch ex As Exception
            MsgBox(ex.Message)
            generarDeuda = 0
        End Try
    End Function
End Class
