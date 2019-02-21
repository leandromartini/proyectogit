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
                Throw New Exception("No se pudo obtener un registro vacío de Lugar de Realización")
            End If

            If objDS.Tables Is Nothing Then
                objDS.Tables(0).MoveFirst()
            End If

            While Not rsImplementacion.EOF
                rsImplementacion("IdImplementa") = lngIdImplementa
                rsImplementacion("IdOferta") = lngIdOferta
                rsImplementacion("nroImplementa") = lngNroImplementa
                rsImplementacion("FecIni") = dtmFecInicio
                rsImplementacion("FecFin") = dtmFecFin
                rsImplementacion("cod_ent") = lngCod_ent
                rsImplementacion("codLugarRealiza") = lngCodLugarRealiza
                rsImplementacion("matricula") = lngMatricula
                rsImplementacion("arancel") = lngArancel
                rsImplementacion("cupoMinimo") = lngCupoMinimo
                rsImplementacion("cod_usu") = strCodUsu
                rsImplementacion("fecCreacion") = dtmfecCreacion
                rsImplementacion("Modalidad") = lngTpoModalidad
                rsImplementacion("IdMoodle") = lngIdMooddle
                rsImplementacion("estado") = lngEstado
                rsImplementacion("soloActivos") = lngsoloActivos
                rsImplementacion("cupoMaximo") = lngCupoMaximo
                actualizarIngresosMes = objIngresos.actualizarRegistroIngresos(id_uf, mes, año, expMes, expExtra, mantEdif, subTotal, redondeo, total)





        Catch ex As Exception
            MsgBox(ex.Message)
            actualizarIngresosMes = 0
        End Try
    End Function
End Class
