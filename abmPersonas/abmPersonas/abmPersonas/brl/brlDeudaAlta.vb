Imports System
Imports System.Data
Public Class brlDeudaAlta
    Dim objDeudas As New deudas
    Public Function altaDeuda(ByVal idPersona As Integer, ByVal tpoDeuda As Long, ByVal importe As Double, ByVal fecEmision As Date) As Integer
        Try
            altaDeuda = objDeudas.actualizarRegistroDeudas(idPersona, tpoDeuda, importe, fecEmision)

        Catch ex As Exception
            MsgBox(ex.Message)
            altaDeuda = 0
        End Try
    End Function
End Class
