
Public Class wflContable
    Function obtenerSaldos(fecDesde As Date, fecHasta As Date) As DataSet
        Dim objcnContable As New cnContable
        Try
            Dim auxEgresos As New DataSet
            Dim auxIngresos As New DataSet
            auxEgresos = objcnContable.ObtenerEgresos(-1, fecDesde, fecHasta)
            auxIngresos = objcnContable.ObtenerIngresos(-1, fecDesde, fecHasta)
            auxEgresos.Merge(auxIngresos)

            obtenerSaldos = auxEgresos
        Catch ex As Exception
            agregar_error(ex, "wflContable obtenerSaldos")
            obtenerSaldos = Nothing
        End Try
    End Function
End Class
