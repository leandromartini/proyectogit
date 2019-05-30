Public Class cnEgresos
    Sub NuevoEgreso(id As Integer, precio As Double, cant As Double, total As Double, formaPago As String)
        Try
            Dim objccdPagosTpoPago As New ccdPagosTpoPago
            Dim objccdEgresos As New ccdEgresos
            Dim id_egreso As Integer
            id_egreso = objccdEgresos.actualizarEgresos(id, precio, cant, total, Date.Now)
            If id_egreso = 0 Then
                MsgBox("Error al cargar la tabla egresos")
                Exit Sub
            End If
            objccdPagosTpoPago.actualizarpagosTpoPago(id_egreso, formaPago, Date.Now)
        Catch ex As Exception
        End Try
    End Sub
End Class
