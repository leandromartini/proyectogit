Imports dtl
Public Class brlIngresos
    Dim objIngresos As New dtlIngresos
    Public Function actualizarIngresosMes(ByVal idPersona As Integer, ByVal tpoDeuda As Long, ByVal importe As Double, ByVal fecEmision As Date) As Integer

        Try
            actualizarIngresosMes = objIngresos.actualizarRegistroIngresos(idPersona, tpoDeuda, importe, fecEmision)

        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarIngresosMes = 0
        End Try
    End Function

    Public Function obtenerIngresosMes() As DataSet
        Try
            obtenerIngresosMes = objIngresos.obtenerIngresosMes
        Catch ex As Exception
            obtenerIngresosMes = Nothing
        End Try

    End Function
End Class
