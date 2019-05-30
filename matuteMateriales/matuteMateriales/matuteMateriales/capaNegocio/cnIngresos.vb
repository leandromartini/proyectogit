Public Class cnIngresos
    Function GuardarIngreso(id_prod As Integer, precio As Double, cant As Double, total As Double, formaPago As String) As Integer
        Dim objccdIngresos As New ccdIngresos
        Dim id_egreso As Integer
        Dim objccdTpoPagos As New ccdPagosTpoPago
        Try
            id_egreso = objccdIngresos.actualizarIngresos(id_prod, precio, cant, total, Date.Now)
            If id_egreso <> 0 Then
                objccdTpoPagos.actualizarpagosTpoPago(id_egreso, formaPago, Date.Now)
            End If
            GuardarIngreso = 1
        Catch ex As Exception
            GuardarIngreso = 0
            agregar_error(ex, "cnProductos GuardarEgreso")
        End Try
    End Function

End Class
