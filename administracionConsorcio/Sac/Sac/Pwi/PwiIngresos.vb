Imports brl
Public Class PwiIngresos
    Dim objIngresos As New brlIngresos
    Public Function obtenerIngresosMes(ByVal mes As Long, ByVal año As Long) As DataSet
        Try
            obtenerIngresosMes = objIngresos.obtenerIngresosMes(mes, año)
        Catch ex As Exception
            obtenerIngresosMes = Nothing
        End Try

    End Function

    Public Function actualizarIngresosMes(ByVal id_uf As Long, ByVal mes As Long, ByVal año As Long, ByVal expMes As Double, ByVal expExtra As Double,
                                               ByVal mantEdif As Double, ByVal subTotal As Double, ByVal redondeo As Double, ByVal total As Double) As Integer
        Try
            actualizarIngresosMes = objIngresos.actualizarIngresosMes(id_uf, mes, año, expMes, expExtra, mantEdif, subTotal, redondeo, total)

        Catch ex As Exception
            actualizarIngresosMes = Nothing
        End Try

    End Function

End Class
