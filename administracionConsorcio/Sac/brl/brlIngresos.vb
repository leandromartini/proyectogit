Imports dtl
Public Class brlIngresos
    Dim objIngresos As New dtlIngresos
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

            Dim objDS As DataSet
            objDS = objIngresos.obtenerIngresosMes(mes, año, id_uf)
            If IsNothing(objDS) Then
                Throw New Exception("No se pudo obtener un registro vacío")
            End If

            'If objDS.Tables Is Nothing Then
            '    objDS.Tables(0).Columns("IdImplementa")
            'End If
            If objDS.Tables() = True Then

            End If


            'While Not rsImplementacion.EOF
            objDS.Tables(0).Rows("hola") = 1


            '    objDS.Tables(0).Columns("mes") = mes
            '    objDS.Tables(0).Columns("año") = año
            '    objDS.Tables(0).Columns("expMes") = expMes
            '    objDS.Tables(0).Columns("expExtra") = expExtra
            '    objDS.Tables(0).Columns("mantEdif") = mantEdif
            '    objDS.Tables(0).Columns("subTotal") = subTotal
            '    objDS.Tables(0).Columns("redondeo") = redondeo
            '    objDS.Tables(0).Columns("total") = total

            actualizarIngresosMes = objIngresos.actualizarRegistroIngresos(objDS.Tables(0).Columns("id_uf").DefaultValue, mes, año, expMes, expExtra, mantEdif, subTotal, redondeo, total)





        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarIngresosMes = 0
        End Try
    End Function
End Class
