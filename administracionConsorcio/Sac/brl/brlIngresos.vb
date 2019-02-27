Imports dtl
Public Class brlIngresos
    Dim objIngresos As New dtlIngresos
    Public Function obtenerIngresosMes(ByVal mes As Long, ByVal año As Long, ByVal id_uf As Long) As DataSet
        Try

            obtenerIngresosMes = objIngresos.obtenerIngresosMes(mes, año, id_uf)

        Catch ex As Exception
            obtenerIngresosMes = Nothing
        End Try
    End Function

    Public Function actualizarIngresosMes(ByVal id_uf As Long, ByVal mes As Long, ByVal año As Long, ByVal expMes As Double, ByVal expExtra As Double,
                                               ByVal mantEdif As Double, ByVal subTotal As Double, ByVal redondeo As Double, ByVal total As Double) As Integer

        Try


            actualizarIngresosMes = objIngresos.actualizarRegistroIngresos(id_uf, mes, año, expMes, expExtra, mantEdif, subTotal, redondeo, total)


        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarIngresosMes = 0
        End Try
    End Function
End Class
