Public Class cnContable
    Sub GuardarEgreso(id As Integer, precio As Double, cant As Double, total As Double, formaPago As String)
        Try
            Dim objccdPagosTpoPago As New ccdPagosTpoPago
            Dim objccdEgresos As New ccdEgresos
            Dim id_egreso As Integer
            id_egreso = objccdEgresos.actualizarEgresos(id, precio, cant, total, Date.Now)
            If id_egreso = 0 Then
                MsgBox("Error al cargar la tabla egresos")
                Exit Sub
            End If
            objccdPagosTpoPago.actualizarpagosTpoPago(id_egreso, formaPago, "E", Date.Now)
        Catch ex As Exception
            agregar_error(ex, "cnContable GuardarEgreso")
        End Try
    End Sub
    Function ObtenerEgresos(id As Integer, fecDede As Date, fecHasta As Date) As DataSet
        Try
            Dim objccdEgresos As New ccdEgresos

            ObtenerEgresos = objccdEgresos.ObtenerEgresos(id, fecDede, fecHasta)

        Catch ex As Exception
            agregar_error(ex, "cnContable ObtenerEgreso")
            ObtenerEgresos = Nothing
        End Try
    End Function
    Function GuardarIngreso(id_prod As Integer, precio As Double, cant As Double, total As Double, formaPago As String) As Integer
        Dim objccdIngresos As New ccdIngresos
        Dim id_egreso As Integer
        Dim objccdTpoPagos As New ccdPagosTpoPago
        Try
            id_egreso = objccdIngresos.actualizarIngresos(id_prod, precio, cant, total, Date.Now)
            If id_egreso <> 0 Then
                objccdTpoPagos.actualizarpagosTpoPago(id_egreso, formaPago, "I", Date.Now)
            End If
            GuardarIngreso = 1
        Catch ex As Exception
            GuardarIngreso = 0
            agregar_error(ex, "cnContable GuardarIngreso")
        End Try
    End Function

    Function ObtenerIngresos(id As Integer, fecDede As Date, fecHasta As Date) As DataSet
        Try
            Dim objccdIngresos As New ccdIngresos

            ObtenerIngresos = objccdIngresos.ObtenerIngresos(id, fecDede, fecHasta)

        Catch ex As Exception
            agregar_error(ex, "cnContable ObtenerEgreso")
            ObtenerIngresos = Nothing
        End Try
    End Function

End Class
