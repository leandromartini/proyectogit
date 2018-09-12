Imports System
Imports System.Data
Imports dtl

Public Class brlDeudaAlta

    Public Shared Function altaDeuda(ByVal idPersona As Integer, ByVal tpoDeuda As Long, ByVal importe As Double, ByVal fecEmision As Date) As Integer
        Dim objDeudas As New deudas
        Try
            altaDeuda = objDeudas.actualizarRegistroDeudas(idPersona, tpoDeuda, importe, fecEmision)

        Catch ex As Exception
            MsgBox(ex.Message)
            altaDeuda = 0
        End Try
    End Function
End Class
