Imports brl
Public Class PwiIngresos
    Dim brlIngresos As New brlIngresos
    Dim brlCoef As New brlUf
    Dim objCoef As New DataSet
    Dim objIngresos As New DataSet
    Dim objAuxIngresos As New DataSet
    Public Function obtenerIngresosMes(ByVal mes As Long, ByVal año As Long, ByVal id_uf As Long) As DataSet
        Try
            obtenerIngresosMes = brlIngresos.obtenerIngresosMes(mes, año, id_uf)
        Catch ex As Exception
            obtenerIngresosMes = Nothing
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function NuevoIngresoMes() As DataSet
        Try

            objCoef.Clear()
            objIngresos.Clear()

            objCoef = brlCoef.obtenerListaUf(-1)

            objIngresos = obtenerIngresosMes(-1, -1, -1)
            For i = 0 To 1
                objIngresos.Tables(0).Columns.RemoveAt(0)
            Next
            Dim column As DataColumn
            objAuxIngresos.Merge(objCoef)

            For Each columns As DataColumn In objIngresos.Tables(0).Columns
                column = New DataColumn
                With column
                    .ColumnName = columns.ColumnName
                    .DataType = System.Type.GetType("System.Double")
                    .DefaultValue = 0
                    objAuxIngresos.Tables(0).Columns.Add(column)
                End With
            Next



            NuevoIngresoMes = objAuxIngresos
            '3. Calcular los valores, segun el importe exp. mes y cargarlos junto a exp extra mant edif total redonde total
            '3.1 Pedi valores de exp mes exp extra y mant edif.
            '3.2 desarrollar la funcion redonde.
            '3.3 sumar totales.
            '4. Una vez cargada la tabla recorrer hacer el alta de datos y visualizar.
        Catch ex As Exception
            NuevoIngresoMes = Nothing
            MsgBox(ex.Message)
        End Try

    End Function

    'Public Function actualizarIngresosMes(ByVal id_uf As Long, ByVal mes As Long, ByVal año As Long, ByVal expMes As Double, ByVal expExtra As Double,
    '                                           ByVal mantEdif As Double, ByVal subTotal As Double, ByVal redondeo As Double, ByVal total As Double) As Integer

    Public Function actualizarIngresosMes(ByVal auxDatagid As DataGridView)

        Try

            If auxDatagid.Rows.Count = 0 Then
                Exit Function
            End If

            For Each row As DataGridViewRow In auxDatagid.Rows
                actualizarIngresosMes = brlIngresos.actualizarIngresosMes(row.Cells(1).Value, 2, 2019, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).Value)

            Next



        Catch ex As Exception
            actualizarIngresosMes = Nothing
            MsgBox(ex.Message)
        End Try

    End Function

    Public Sub MontoExp(ByVal importe As Integer, ByRef intDefine As Integer)

        For Each row As DataRow In objAuxIngresos.Tables(0).Rows()

            Select Case intDefine

                Case 1
                    row("expMes") = importe * row("coef")

                Case 2
                    If row("coef") > 0.03 Then
                        row("expExtra") = importe / 15
                    Else
                        row("expExtra") = 0
                    End If
                Case 3
                    row("mantEdif") = importe / 20
            End Select

            row("subTotal") = Decimal.Round(row("expMes") + row("expExtra") + row("mantEdif"), 1)
            row("redondeo") = CInt(row("subTotal")) - CDec(row("subTotal"))
            row("total") = Decimal.Round(row("subTotal") + row("redondeo"), 1)

        Next

    End Sub

End Class
