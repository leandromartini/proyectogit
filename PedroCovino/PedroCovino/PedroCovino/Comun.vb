Public Class Comun

    Dim objInsumo As New insumo
    Dim objInsumoPrecio As New insumoPrecios
    Dim objInsumoStock As New insumoStock

    Public Sub ActualizarInsumo(codigo As Integer, descripcion As String)
        Try

            objInsumo.Nuevo(codigo, descripcion)

        Catch ex As Exception
            agregar_error(ex, "Comun ActualizarInsumo")
        End Try
    End Sub

    Public Sub ActualizarInsumoPrecios(codigo As Integer, preciosiva As Double, preciociva As Double, ventapublico As Double)
        Try

            objInsumoPrecio.Nuevo(codigo, preciosiva, preciociva, ventapublico)

        Catch ex As Exception
            agregar_error(ex, "Comun ActualizarInsumoPrecios")
        End Try
    End Sub

    Public Sub ActualizarInsumoStock(codigo As Integer, stockNue As Integer, stockminNue As Integer, stockmaxNue As Integer)
        Try

            objInsumoStock.Nuevo(codigo, stockNue, stockminNue, stockmaxNue)

        Catch ex As Exception
            agregar_error(ex, "Comun ActualizarInsumoPrecios")
        End Try
    End Sub
    Public Sub actualizarInsumo()
        Try

            Dim objWlfInsumo As New wflInsumos

            objWlfInsumo.actualizarInsumo(objInsumo.verCodigo, objInsumo.verDescripcion, objInsumoPrecio.verpreciosiva, objInsumoPrecio.verpreciociva,
                                          objInsumoPrecio.verventapublico, objInsumoStock.verStock, objInsumoStock.verstockmin, objInsumoStock.verstockmax)

        Catch ex As Exception
            agregar_error(ex, "Comun ActualizarInsumoPrecios")
        End Try
    End Sub


End Class
