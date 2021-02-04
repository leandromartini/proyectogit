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
    Public Function grabarInsumo() As Boolean
        Try
            Dim fec As DateTime
            Dim objWlfInsumo As New wflInsumos
            grabarInsumo = False


            fec = objWlfInsumo.actualizarInsumo(objInsumoStock.verCodigo, objInsumo.verDescripcion, objInsumoPrecio.verpreciosiva, objInsumoPrecio.verpreciociva,
                                          objInsumoPrecio.verventapublico, objInsumoStock.verStock, objInsumoStock.verstockmin, objInsumoStock.verstockmax)

            objInsumo.limpiar()
            objInsumoPrecio.limpiar()
            objInsumoStock.limpiar()

            If fec = "01/01/1900" Then
                MsgBox("No se pudideron guardar los cambios! Consulte con el desarrollador")
                Exit Function
            End If
            grabarInsumo = True

        Catch ex As Exception
            agregar_error(ex, "Comun ActualizarInsumoPrecios")
            grabarInsumo = False
        End Try
    End Function


End Class
